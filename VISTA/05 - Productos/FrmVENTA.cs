using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    [MODELO.formulario(CLASE = "FrmVENTA", DESCRIPCION = "Venta de productos", MENU = true, MODULO = "Seguridad", SUBMODULO = "Productos")]
    [MODELO.accion(CONTROL = "btnRealizar", DESCRIPCION = "Realizar venta", FORMULARIO = "FrmVENTA")]
    [MODELO.accion(CONTROL = "BtnEditarFormaPago", DESCRIPCION = "Elegir forma de pago", FORMULARIO = "FrmVENTA")]
    [MODELO.accion(CONTROL = "btnCancelar", DESCRIPCION = "Cancelar venta", FORMULARIO = "FrmVENTA")]
    
    public partial class FrmVENTA : Form
    {
        List<MODELO.PRODUCTO> listaProductos;
        CONTROLADORA.cPRODUCTOS cPRODUCTOS;
        CONTROLADORA.cFACTURAS cFACTURAS;
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        MODELO.FACTURA oFactura;
        decimal TOTAL = 0;
        string rutaProyecto;

        private static FrmVENTA Instancia;
        public static FrmVENTA obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            Instancia = new FrmVENTA(oUSUARIO);

            return Instancia;
        }

        private FrmVENTA(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            //Obtiene las controladoras
            cPRODUCTOS = CONTROLADORA.cPRODUCTOS.Obtener_Instancia();
            cFACTURAS = CONTROLADORA.cFACTURAS.Obtener_Instancia();
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();
            //Valida las acciones del usuario
            btnRealizar.Enabled = oUSUARIO.VALIDAR_ACCION("FrmFACTURA", "btnRealizar");
            btnRealizar.Enabled = oUSUARIO.VALIDAR_ACCION("FrmFACTURA", "btnRealizar");
            //Lista para cargar los productos elegidos
            listaProductos = new List<MODELO.PRODUCTO>();

            //Autocompleta los datos de la factura
            mtbFecha.Text = DateTime.Today.ToString();
            oFactura = new MODELO.FACTURA();
            oFactura.Nro_Factura = oFactura.Id_Factura + 100;
            txtNumeroFactura.Text = oFactura.Nro_Factura.ToString();
            oFactura.Importe = 0;

            //Ruta de la carpeta del proyecto: [...]/SISTEMA/
            rutaProyecto = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 15);
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            //Obtiene los productos del catalogo
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = cPRODUCTOS.Obtener_Productos(txtBusqueda.Text, chkStock.Checked);
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].Visible = false;

            //Obtiene los productos seleccionados
            dgvListaCompra.DataSource = listaProductos.ToList();
            dgvListaCompra.Columns[0].Visible = false;
            dgvListaCompra.Columns[4].Visible = false;
            dgvListaCompra.Columns[5].Visible = false;
            dgvListaCompra.Columns[6].Visible = false;
        }

        private void AGREGAR_PRODUCTO()
        {
            int cantidad;
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Ingrese un número valido.");
                return;
            }

            MODELO.PRODUCTO oProducto = (MODELO.PRODUCTO)dgvProductos.CurrentRow.DataBoundItem;
            decimal subTotal = 0;

            if(oProducto.Stock < cantidad)
            {
                MessageBox.Show("No contamos con stock suficiente.");
                return;
            }

            cFACTURAS.AgregarProducto(oFactura, oProducto, cantidad);
            for (int i = 1; i <= cantidad; i++)
            {
                listaProductos.Add(oProducto);
                txtTotal.Text = TOTAL.ToString();
                subTotal += oProducto.Precio;
            }
            txtTotal.Text = Convert.ToString(TOTAL + subTotal);
            TOTAL = Convert.ToDecimal(txtTotal.Text);
            ARMA_GRILLA();
        }

        private void QUITAR_PRODUCTO()
        {
            if (dgvListaCompra.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "ATENCIÓN!!");
                return;
            }
            else
            {
                MODELO.PRODUCTO oProducto;
                oProducto = cPRODUCTOS.BuscarProducto(Convert.ToInt32(dgvListaCompra.CurrentRow.Cells[0].Value));
                cFACTURAS.EliminarProducto(oFactura, oProducto);
                listaProductos.Remove(listaProductos.Find(x => x.Codigo_Producto == oProducto.Codigo_Producto));
                txtTotal.Text = Convert.ToString(TOTAL - oProducto.Precio);
            }
            ARMA_GRILLA();
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            QUITAR_PRODUCTO();
        }

        private void dgvListaCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            QUITAR_PRODUCTO();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            listaProductos.Clear();
            TOTAL = 0;
            txtTotal.Text = TOTAL.ToString();
            ARMA_GRILLA();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
           if (listaProductos.Count() == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto.");
                return;
            }

            if(ucAFILIADO1.AFILIADO == null)
            {
                MessageBox.Show("Debe ingresar un afiliado.");
                return;
            }

            oFactura.AFILIADO = ucAFILIADO1.AFILIADO;
            oFactura.Fecha = DateTime.Today;
            if (rb_TipoA.Checked) oFactura.Tipo_Factura = "A";
            if (rb_TipoB.Checked) oFactura.Tipo_Factura = "B";
            if (rb_TipoC.Checked) oFactura.Tipo_Factura = "C";
            oFactura.IDEstadoFactura = MODELO.Identificadores.EstadoFactura.Entregado;
            oFactura.Importe = TOTAL;
            cFACTURAS.Agregar_Factura(oFactura);

            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.ShowCloseButton = true;
            bool enviar = rbDebitoAutomatico.Checked;
            ARMA_FACTURA(enviar);
        }

        private void ARMA_FACTURA(bool enviar)
        {
            DatosFactura DatosFactura = new DatosFactura();
            int numero_detalles = oFactura.DETALLE_FACTURA.Count();
            List<MODELO.DETALLE_FACTURA> ListaDetallesFactura = new List<MODELO.DETALLE_FACTURA>();
            ListaDetallesFactura = oFactura.DETALLE_FACTURA.ToList();
            DatosFactura.Tables[1].Rows.Add
                (new object[] {
                        oFactura.Nro_Factura.ToString(),
                        oFactura.Fecha.ToString(),
                        oFactura.Tipo_Factura.ToString(),
                        oFactura.Importe.ToString(),
                        oFactura.AFILIADO.Nombre,
                        oFactura.AFILIADO.DNI.ToString()
                 });

            for (int k = 0; k < numero_detalles; k++)
            {
                DatosFactura.Tables[0].Rows.Add //se cargan los detalles en el dataset
                   (new object[] {
                        ListaDetallesFactura[k].Id_Detalle_Factura,
                        ListaDetallesFactura[k].Codigo_Producto,
                        ListaDetallesFactura[k].Cantidad,
                        ListaDetallesFactura[k].Precio,
                        ListaDetallesFactura[k].PRODUCTO.Descripcion,
                        ListaDetallesFactura[k].PRODUCTO.Marca
                   });
            }
            ReportDocument oRep = new ReportDocument();
            oRep.Load(rutaProyecto + "VISTA/Factura.rpt");
            oRep.SetDataSource(DatosFactura);
            crystalReportViewer1.ReportSource = oRep; //carga el documento en el CrystalReport

            if (enviar)
            {
                oRep.ExportToDisk(ExportFormatType.PortableDocFormat, rutaProyecto + "report" +oFactura.Nro_Factura+ ".pdf"); //exporta recibo en pdf
                string filename = rutaProyecto + "report" + oFactura.Nro_Factura + ".pdf";
                CONTROLADORA.funciones_compartidas.EnviarEmail(/*oAfiliado.Email*/ "frareesteban@gmail.com", "Recibo", "Recibo", filename);

                MessageBox.Show("Se ha enviado la factura por correo.");
                ARMA_GRILLA();
            }
        }

        private void BtnEditarFormaPago_Click(object sender, EventArgs e)
        {
            if (ucAFILIADO1.AFILIADO == null)
            {
                MessageBox.Show("Antes de elegir la forma de pago, debe ingresar un afiliado");
                return;
            }

            rbEfectivo.Enabled = true;
            rbEfectivo.Checked = true;

            if (ucAFILIADO1.AFILIADO.Forma_Pago != "Efectivo")
                rbDebitoAutomatico.Enabled = true;

            ucAFILIADO1.Enabled = false;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AGREGAR_PRODUCTO();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AGREGAR_PRODUCTO();
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
