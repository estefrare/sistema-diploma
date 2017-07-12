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
    public partial class FrmGESTIONARPLANES : Form
    {
        CONTROLADORA.cPLANES cPLANES;

        private static FrmGESTIONARPLANES instacia;

        public static FrmGESTIONARPLANES obtener_instancia()
        {
            if (instacia == null)
                instacia = new FrmGESTIONARPLANES();
            if (instacia.IsDisposed)
                instacia = new FrmGESTIONARPLANES();
            return instacia;
        }
        public FrmGESTIONARPLANES()
        {
            InitializeComponent();

            cPLANES = CONTROLADORA.cPLANES.obtener_instancia();

            if (cPLANES.Obtener_Planes().Count > 0)
                ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvPLANES.DataSource = null;
            dgvPLANES.DataSource = cPLANES.Obtener_Planes();
            dgvPLANES.Columns[4].Visible = false;
            dgvPLANES.Columns[5].Visible = false;
            dgvPLANES.Columns[6].Visible = false;

            dgvPLANES.Columns[0].HeaderText = "ID PLAN";
            dgvPLANES.Columns[1].HeaderText = "NOMBRE";
            dgvPLANES.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvPLANES.Columns[3].HeaderText = "COSTO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Afiliado_Click(object sender, EventArgs e)
        {
            FrmPLAN FormPlanes = new FrmPLAN(new MODELO.PLAN(), "A");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnModificar_Afiliado_Click(object sender, EventArgs e)
        {
            if (dgvPLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan");
                return;
            }
            FrmPLAN FormPlanes = new FrmPLAN((MODELO.PLAN)dgvPLANES.CurrentRow.DataBoundItem, "M");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnConsultar_Afiliado_Click(object sender, EventArgs e)
        {
            if (dgvPLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan");
                return;
            }
            FrmPLAN FormPlanes = new FrmPLAN((MODELO.PLAN)dgvPLANES.CurrentRow.DataBoundItem, "C");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }
    }
}
