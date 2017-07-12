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
    public partial class FrmGESTIONARSERVICIOS : Form
    {

        CONTROLADORA.cSERVICIOS cSERVICIOS;

        private static FrmGESTIONARSERVICIOS instancia;

        public static FrmGESTIONARSERVICIOS Obtener_Instancia()
        {
            if (instancia == null)
                instancia = new FrmGESTIONARSERVICIOS();
            if (instancia.IsDisposed)
                instancia = new FrmGESTIONARSERVICIOS();
            return instancia;
        }
        public FrmGESTIONARSERVICIOS()
        {
            InitializeComponent();

            cSERVICIOS = CONTROLADORA.cSERVICIOS.Obtener_Instancia();

            if (cSERVICIOS.Obtener_Planes().Count > 0)
                ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvSERVICIOS.DataSource = null;
            dgvSERVICIOS.DataSource = cSERVICIOS.Obtener_Servicios();
            dgvSERVICIOS.Columns[5].Visible = false;

            dgvSERVICIOS.Columns[0].HeaderText = "ID SERVICIO";
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
            FrmSERVICIO FormServicios = new FrmSERVICIO(new MODELO.SERVICIO(), "A");
            DialogResult dr = FormServicios.ShowDialog();

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

            FrmSERVICIO FormServicios = new FrmSERVICIO((MODELO.SERVICIO)dgvSERVICIOS.CurrentRow.DataBoundItem, "M");
            DialogResult dr = FormServicios.ShowDialog();

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

            FrmSERVICIO FormServicios = new FrmSERVICIO((MODELO.SERVICIO)dgvSERVICIOS.CurrentRow.DataBoundItem, "C");
            DialogResult dr = FormServicios.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSERVICIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar el servicio que desea eliminar");
                return;
            }

            DialogResult dr = MessageBox.Show("¿En verdad desea eliminar este servicio?", "¡Atención!", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cSERVICIOS.Eliminar_Sservicio((MODELO.SERVICIO)dgvSERVICIOS.CurrentRow.DataBoundItem);
                ARMA_GRILLA();
            }
        }
    }
}
