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
    public partial class FrmGESTIONARMEDICOS : Form
    {
        CONTROLADORA.cMEDICOS cMEDICOS;

        private static FrmGESTIONARMEDICOS Instancia;
        public static FrmGESTIONARMEDICOS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new FrmGESTIONARMEDICOS();
            if (Instancia.IsDisposed)
                Instancia = new FrmGESTIONARMEDICOS();

            return Instancia;
        }
        public FrmGESTIONARMEDICOS()
        {
            InitializeComponent();
            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();

            if (cMEDICOS.Obtener_Medicos(string.Empty).Count > 0)
                ARMAR_GRILLA();
        }

        private void ARMAR_GRILLA()
        {
            dgvMEDICOS.DataSource = null;
            dgvMEDICOS.DataSource = cMEDICOS.Obtener_Medicos(string.Empty);
            dgvMEDICOS.Columns[0].Visible = false;
            dgvMEDICOS.Columns[2].Visible = false;
            dgvMEDICOS.Columns[3].Visible = false;
            dgvMEDICOS.Columns[4].Visible = false;
            dgvMEDICOS.Columns[9].Visible = false;
            dgvMEDICOS.Columns[10].Visible = false;
            dgvMEDICOS.Columns[11].Visible = false;
            dgvMEDICOS.Columns[12].Visible = false;

            dgvMEDICOS.Columns[1].HeaderText = "NOMBRE";
            dgvMEDICOS.Columns[5].HeaderText = "MATRICULA";
            dgvMEDICOS.Columns[6].HeaderText = "DNI";
            dgvMEDICOS.Columns[7].HeaderText = "ESPECIALIDAD";
            dgvMEDICOS.Columns[8].HeaderText = "ESTADO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Medico_Click(object sender, EventArgs e)
        {
            FrmMEDICO formMEDICO = new FrmMEDICO(new MODELO.MEDICO(), "A");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();
        }

        private void btnModificar_Medico_Click(object sender, EventArgs e)
        {
            if(dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Médico de la lista");
                return;
            }
            FrmMEDICO formMEDICO = new FrmMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem, "M");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();
        }

        private void btnConsultar_Medico_Click(object sender, EventArgs e)
        {
            if (dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Médico de la lista");
                return;
            }
            FrmMEDICO formMEDICO = new FrmMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem, "C");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();

        }

        private void txtBuscar_Medico_KeyUp(object sender, KeyEventArgs e)
        {
            dgvMEDICOS.DataSource = cMEDICOS.Obtener_Medicos(txtBuscar_Medico.Text);
        }

        private void btnConfigurar_Medico_Click(object sender, EventArgs e)
        {
            if (dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un médico de la grilla");
                return;
            }
            FrmCONFIGMEDICO formCONFIGMEDICO = new FrmCONFIGMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem);
            DialogResult dr = formCONFIGMEDICO.ShowDialog();
        } 
    }

}
