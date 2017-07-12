using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    [MODELO.formulario(CLASE = "FrmCOMPRA", DESCRIPCION = "Compra de productos", MENU = true, MODULO = "Seguridad", SUBMODULO = "Productos")]
    //[MODELO.accion(CONTROL = "btnRealizar", DESCRIPCION = "Realizar venta", FORMULARIO = "FrmCOMPRA")]

    public partial class FrmCOMPRA : Form
    {
        List<MODELO.PRODUCTO> listaProductos;
        CONTROLADORA.cPRODUCTOS cPRODUCTOS;
        //CONTROLADORA.cFACTURAS cFACTURAS;
        //CONTROLADORA.cAFILIADOS cAFILIADOS;
        //MODELO.FACTURA oFactura;
        MODELO.PRODUCTO oProducto;
        decimal TOTAL = 0;

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
                //cFACTURAS.EliminarProducto(oFactura, oProducto);
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
            for (int k = 0; k < cantProduct; k++)
            {
                oProductoCompra = listaProductos[k];
                oProducto = cPRODUCTOS.BuscarProducto(oProductoCompra.Codigo_Producto);
                oProducto.Stock++;
                cPRODUCTOS.Modificar_Producto(oProducto);
            } 
        }
    }
}
