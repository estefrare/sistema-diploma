using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VISTA
{
    [MODELO.formulario(CLASE = "FrmCOMPRA", DESCRIPCION = "Compra de productos", MENU = true, MODULO = "Seguridad", SUBMODULO = "Productos")]
    //[MODELO.accion(CONTROL = "btnRealizar", DESCRIPCION = "Realizar venta", FORMULARIO = "FrmCOMPRA")]

    public partial class FrmCOMPRA : Form
    {
        List<MODELO.PRODUCTO> listaProductos;
        CONTROLADORA.cPRODUCTOS cPRODUCTOS;
        CONTROLADORA. cReciboCompra;
        //CONTROLADORA.cAFILIADOS cAFILIADOS;
        MODELO.RECIBO_COMPRA oRecibo_Compra;
        MODELO.PRODUCTO oProducto;
        decimal TOTAL = 0;
        string rutaProyecto;

        private static FrmCOMPRA Instancia;
        public static FrmCOMPRA obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            Instancia = new FrmCOMPRA(oUSUARIO);
            return Instancia;
        }

        private FrmCOMPRA(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            cPRODUCTOS = CONTROLADORA.cPRODUCTOS.Obtener_Instancia();
            listaProductos = new List<MODELO.PRODUCTO>();

            //Autocompleta los datos del recibo de compra
            //mtbFecha.Text = DateTime.Today.ToString();
            oRecibo_Compra = new MODELO.RECIBO_COMPRA();
            oRecibo_Compra.Nro_Recibo_Compra = oRecibo_Compra.Id_Recibo_Compra + 100;
            //txtNumeroFactura.Text = oRecibo_Compra.Nro_Recibo_Compra.ToString();
            oRecibo_Compra.Importe = 0;

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

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmPRODUCTO formPRODUCTO = new FrmPRODUCTO(new MODELO.PRODUCTO(), "A");
            DialogResult dr = formPRODUCTO.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
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

            MODELO.PRODUCTO oProducto = (MODELO.PRODUCTO) dgvProductos.CurrentRow.DataBoundItem;
            decimal subTotal = 0;

            //cFACTURAS.AgregarProducto(oFactura, oProducto, cantidad);
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AGREGAR_PRODUCTO();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QUITAR_PRODUCTO();
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
                crecibo_.EliminarProducto(oFactura, oProducto);
                listaProductos.Remove(listaProductos.Find(x => x.Codigo_Producto == oProducto.Codigo_Producto));
                txtTotal.Text = Convert.ToString(TOTAL - oProducto.Precio);
            }
            ARMA_GRILLA();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AGREGAR_PRODUCTO();
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count() == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto.");
                return;
            }

            int cantProduct = listaProductos.Count();
            MODELO.PRODUCTO oProductoCompra;
            //oRecibo_Compra.AFILIADO = ucAFILIADO1.AFILIADO;
            oRecibo_Compra.Fecha = DateTime.Today;
            oRecibo_Compra.Importe = TOTAL;
            //cFACTURAS.Agregar_Factura(oRecibo_Compra);

            for (int k = 0; k < cantProduct; k++)
            {
                oProductoCompra = listaProductos[k];
                oProducto = cPRODUCTOS.BuscarProducto(oProductoCompra.Codigo_Producto);
                oProducto.Stock++;
                cPRODUCTOS.Modificar_Producto(oProducto);
            }
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.ShowCloseButton = true;
            ARMA_RECIBO();
        }

        private void ARMA_RECIBO()
        {
            DatosRecibo DatosRecibo = new DatosRecibo();
            int numero_detalles = oRecibo_Compra.DETALLE_RECIBO_COMPRA.Count();
            List<MODELO.DETALLE_RECIBO_COMPRA> ListaDetallesRecibo = new List<MODELO.DETALLE_RECIBO_COMPRA>();
            ListaDetallesRecibo = oRecibo_Compra.DETALLE_RECIBO_COMPRA.ToList();
            DatosRecibo.Tables[1].Rows.Add
                (new object[] {
                        oRecibo_Compra.Nro_Recibo_Compra.ToString(),
                        oRecibo_Compra.Fecha.ToString(),
                        oRecibo_Compra.Importe.ToString(),
                        "Adobe", //oRecibo_Compra.Proveedor
                        "38240915" //oRecibo_Compra.AFILIADO.DNI.ToString()
                 });

            for (int k = 0; k < numero_detalles; k++)
            {
                DatosRecibo.Tables[0].Rows.Add //se cargan los detalles en el dataset
                   (new object[] {
                        ListaDetallesRecibo[k].Id_Detalle_Recibo_Compra,
                        ListaDetallesRecibo[k].Codigo_Producto,
                        ListaDetallesRecibo[k].Cantidad,
                        ListaDetallesRecibo[k].Precio,
                        ListaDetallesRecibo[k].PRODUCTO.Descripcion,
                        ListaDetallesRecibo[k].PRODUCTO.Marca
                   });
            }
            ReportDocument oRep = new ReportDocument();
            oRep.Load(rutaProyecto + "VISTA/ReciboCompra.rpt");
            oRep.SetDataSource(DatosRecibo);
            crystalReportViewer1.ReportSource = oRep; //carga el documento en el CrystalReport
        }
    }
}
