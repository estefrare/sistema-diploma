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
    public partial class FrmPRODUCTO : Form
    {
        MODELO.PRODUCTO oProducto;
        CONTROLADORA.cPRODUCTOS cProductos;
        string ACCION;
        public FrmPRODUCTO(MODELO.PRODUCTO miProducto, string miACCION)
        {
            InitializeComponent();
            cProductos = CONTROLADORA.cPRODUCTOS.Obtener_Instancia();
            oProducto = miProducto;
            ACCION = miACCION;

            if(ACCION != "A")
            {
                txtCodigoProducto.Text = oProducto.Codigo_Producto.ToString();
                txtDescripcionProducto.Text = oProducto.Descripcion;
                txtMarcaProducto.Text = oProducto.Marca;
                txtPrecio.Text = oProducto.Precio.ToString();
                txtStockMinimoProducto.Text = oProducto.Stock_Minimo.ToString();

                if (ACCION == "C")
                {
                    btnGuardarProducto.Enabled = false;
                    gbProducto.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            int codigoProducto, stockMinimo;
            decimal precio;
            if(!int.TryParse(txtCodigoProducto.Text, out codigoProducto))
            {
                MessageBox.Show("Debe ingresar un codigo valido.");
                return;
            }

            if (!int.TryParse(txtStockMinimoProducto.Text, out stockMinimo))
            {
                MessageBox.Show("Debe ingresar un stock mínimo valido.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un precio valido.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }

            if (string.IsNullOrEmpty(txtMarcaProducto.Text))
            {
                MessageBox.Show("Debe ingresar una marca.");
                return;
            }

            oProducto.Codigo_Producto = codigoProducto;
            oProducto.Descripcion = txtDescripcionProducto.Text;
            oProducto.Marca = txtMarcaProducto.Text;
            oProducto.Precio = precio;
            oProducto.Stock_Minimo = stockMinimo;

            if(ACCION == "A")
            {
                cProductos.Agregar_Producto(oProducto);
            }
            else
            {
                cProductos.Modificar_Producto(oProducto);
            }

            this.DialogResult = DialogResult.OK;

        }
    }
}
