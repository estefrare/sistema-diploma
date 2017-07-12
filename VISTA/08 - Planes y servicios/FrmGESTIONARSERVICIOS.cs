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
    [MODELO.formulario(CLASE = "FrmGESTIONARSERVICIOS", DESCRIPCION = "Gestión de Servicios del Sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión Planes y Servicios")]
    [MODELO.accion(CONTROL = "btnConsultar_Servicio", DESCRIPCION = "Consultar datos del servicio", FORMULARIO = "FrmGESTIONARSERVICIOS")]
    [MODELO.accion(CONTROL = "btnModificar_Servicio", DESCRIPCION = "Modificar datos del servicio", FORMULARIO = "FrmGESTIONARSERVICIOS")]
    [MODELO.accion(CONTROL = "btnAgregar_Servicio", DESCRIPCION = "Agregar servicios al sistema", FORMULARIO = "FrmGESTIONARSERVICIOS")]
    public partial class FrmGESTIONARSERVICIOS : Form
    {
        CONTROLADORA.cSERVICIOS cSERVICIOS;

        private static FrmGESTIONARSERVICIOS instancia;

        public static FrmGESTIONARSERVICIOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
                instancia = new FrmGESTIONARSERVICIOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new FrmGESTIONARSERVICIOS(oUSUARIO);
            return instancia;
        }
        public FrmGESTIONARSERVICIOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();

            cSERVICIOS = CONTROLADORA.cSERVICIOS.Obtener_Instancia();
            btnConsultar_Servicio.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARSERVICIOS", "btnConsultar_Servicio");
            btnModificar_Servicio.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARSERVICIOS", "btnModificar_Servicio");
            btnAgregar_Servicio.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARSERVICIOS", "btnAgregar_Servicio");

            if (cSERVICIOS.Obtener_Servicio(string.Empty).Count > 0)
                ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvSERVICIOS.DataSource = null;
            dgvSERVICIOS.DataSource = cSERVICIOS.Obtener_Servicio(string.Empty);
            dgvSERVICIOS.Columns[0].Visible = false;
            dgvSERVICIOS.Columns[5].Visible = false;

            //dgvSERVICIOS.Columns[0].HeaderText = "ID SERVICIO";
            dgvSERVICIOS.Columns[1].HeaderText = "NOMBRE";
            dgvSERVICIOS.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvSERVICIOS.Columns[3].HeaderText = "FECHA CREACIÓN";
            dgvSERVICIOS.Columns[4].HeaderText = "ESTADO";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Servicio_Click(object sender, EventArgs e)
        {
            FrmSERVICIOS FormServicio = new FrmSERVICIOS(new MODELO.SERVICIO(), "A");
            DialogResult dr = FormServicio.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnModificar_Servicio_Click(object sender, EventArgs e)
        {
            if (dgvSERVICIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un servicio");
                return;
            }
            FrmSERVICIOS FormServicio = new FrmSERVICIOS((MODELO.SERVICIO)dgvSERVICIOS.CurrentRow.DataBoundItem, "M");
            DialogResult dr = FormServicio.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnConsultar_Servicio_Click(object sender, EventArgs e)
        {
            if (dgvSERVICIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un servicio");
                return;
            }
            FrmSERVICIOS FormServicio = new FrmSERVICIOS((MODELO.SERVICIO)dgvSERVICIOS.CurrentRow.DataBoundItem, "C");
            DialogResult dr = FormServicio.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Servicio_TextChanged(object sender, EventArgs e)
        {
            dgvSERVICIOS.DataSource = cSERVICIOS.Obtener_Servicio(txtBuscar_Servicio.Text);

            dgvSERVICIOS.Columns[5].Visible = false;

            dgvSERVICIOS.Columns[0].HeaderText = "ID SERVICIO";
            dgvSERVICIOS.Columns[1].HeaderText = "NOMBRE";
            dgvSERVICIOS.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvSERVICIOS.Columns[3].HeaderText = "FECHA CREACIÓN";
            dgvSERVICIOS.Columns[4].HeaderText = "ESTADO";
        }
    }
}
