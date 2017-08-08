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
    [MODELO.formulario(CLASE = "FrmGESTIONARPRODUCTOS", DESCRIPCION = "Gestión de Productos", MENU = true, MODULO = "Seguridad", SUBMODULO = "Productos")]
    [MODELO.accion(CONTROL = "btnModificarProducto", DESCRIPCION = "Modificar Producto", FORMULARIO = "FrmGESTIONARPRODUCTOS")]
    [MODELO.accion(CONTROL = "btnAgregarProducto", DESCRIPCION = "Agregar Producto", FORMULARIO = "FrmGESTIONARPRODUCTOS")]
    [MODELO.accion(CONTROL = "btnConsultarProducto", DESCRIPCION = "Consultar Producto", FORMULARIO = "FrmGESTIONARPRODUCTOS")]

    public partial class FrmGESTIONARPRODUCTOS : Form
    {
        CONTROLADORA.cPRODUCTOS cProductos;

        private static FrmGESTIONARPRODUCTOS Instancia;
        public static FrmGESTIONARPRODUCTOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmGESTIONARPRODUCTOS(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmGESTIONARPRODUCTOS(oUSUARIO);

            return Instancia;
        }

        private FrmGESTIONARPRODUCTOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnConsultarProducto.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARPRODUCTOS", "btnConsultarProducto");


            cProductos = CONTROLADORA.cPRODUCTOS.Obtener_Instancia();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = cProductos.Obtener_Productos(txtBuscarProducto.Text, chkStock.Checked);
            dgvProductos.Columns[6].Visible = false;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmPRODUCTO formPRODUCTO = new FrmPRODUCTO(new MODELO.PRODUCTO() , "A");
            DialogResult dr = formPRODUCTO.ShowDialog();
            if(dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            FrmPRODUCTO formPRODUCTO = new FrmPRODUCTO((MODELO.PRODUCTO)dgvProductos.CurrentRow.DataBoundItem, "M");
            DialogResult dr = formPRODUCTO.ShowDialog();
            if (dr == DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            FrmPRODUCTO formPRODUCTO = new FrmPRODUCTO((MODELO.PRODUCTO)dgvProductos.CurrentRow.DataBoundItem, "C");
            DialogResult dr = formPRODUCTO.ShowDialog();
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
