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
    public partial class FrmGESTIONARAFILIADOS : Form
    {
        CONTROLADORA.cAFILIADOS cAFILIADOS;

        private static FrmGESTIONARAFILIADOS instancia;

        public static FrmGESTIONARAFILIADOS Obtener_Instancia()
        {
            if (instancia == null)
                instancia = new FrmGESTIONARAFILIADOS();
            if (instancia.IsDisposed)
                instancia = new FrmGESTIONARAFILIADOS();

            return instancia;
        }
        public FrmGESTIONARAFILIADOS()
        {
            InitializeComponent();

            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();

            if (cAFILIADOS.Obtener_Afiliados(String.Empty).Count > 0)
                ARMA_GRILLA();
        }

            private void ARMA_GRILLA()
        {
            dgvAFILIADOS.DataSource = null;
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados(string.Empty);
            dgvAFILIADOS.Columns[0].Visible = false;
            dgvAFILIADOS.Columns[3].Visible = false;
            dgvAFILIADOS.Columns[4].Visible = false;
            dgvAFILIADOS.Columns[7].Visible = false;
            dgvAFILIADOS.Columns[13].Visible = false;
            dgvAFILIADOS.Columns[14].Visible = false;
            dgvAFILIADOS.Columns[15].Visible = false;


            dgvAFILIADOS.Columns[1].HeaderText = "NOMBRE";
            dgvAFILIADOS.Columns[2].HeaderText = "DIRECCIÓN";
            dgvAFILIADOS.Columns[5].HeaderText = "DNI";
            dgvAFILIADOS.Columns[6].HeaderText = "NACIMIENTO";
            dgvAFILIADOS.Columns[8].HeaderText = "SEXO";
            dgvAFILIADOS.Columns[9].HeaderText = "TITULAR";
            dgvAFILIADOS.Columns[10].HeaderText = "ADHERENTE";
            dgvAFILIADOS.Columns[11].HeaderText = "CONTRATO";
            dgvAFILIADOS.Columns[12].HeaderText = "ESTADO";

        }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnAgregar_Afiliado_Click(object sender, EventArgs e)
            {
                frmAFILIADOS FormAfiliado = new frmAFILIADOS(new MODELO.AFILIADO(), "A");
                DialogResult dr = FormAfiliado.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    ARMA_GRILLA();
            }

            private void btnModificar_Afiliado_Click(object sender, EventArgs e)
            {
                if (dgvAFILIADOS.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a una afiliado");
                    return;
                }
                frmAFILIADOS FormAfiliado = new frmAFILIADOS((MODELO.AFILIADO)dgvAFILIADOS.CurrentRow.DataBoundItem, "M");
                DialogResult dr = FormAfiliado.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    ARMA_GRILLA();
            }

            private void btnConsultar_Afiliado_Click(object sender, EventArgs e)
            {
                if (dgvAFILIADOS.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar a una afiliado");
                    return;
                }
                frmAFILIADOS FormAfiliado = new frmAFILIADOS((MODELO.AFILIADO)dgvAFILIADOS.CurrentRow.DataBoundItem, "C");
                DialogResult dr = FormAfiliado.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    ARMA_GRILLA();
            }

            private void txtBuscar_Afiliado_TextChanged(object sender, EventArgs e)
            {
                dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados(txtBuscar_Afiliado.Text);
            }
    }
}
