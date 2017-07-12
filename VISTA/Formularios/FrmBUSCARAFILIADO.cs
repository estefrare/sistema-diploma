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
    public partial class FrmBUSCARAFILIADO : Form
    {
        MODELO.AFILIADO oAFILIADO;
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        public FrmBUSCARAFILIADO()
        {
            InitializeComponent();
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();

            if (cAFILIADOS.Obtener_Afiliados(string.Empty).Count > 0)
                ARMAR_GRILLA();
        }

        private void ARMAR_GRILLA()
        {
            dgvAFILIADOS.DataSource = null;
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados(string.Empty);

            dgvAFILIADOS.Columns[0].Visible = false;
            dgvAFILIADOS.Columns[7].Visible = false;
            dgvAFILIADOS.Columns[9].Visible = false;
            dgvAFILIADOS.Columns[10].Visible = false;
            dgvAFILIADOS.Columns[3].Visible = false;
            dgvAFILIADOS.Columns[6].Visible = false;
            dgvAFILIADOS.Columns[4].Visible = false;
            dgvAFILIADOS.Columns[11].Visible = false;
            dgvAFILIADOS.Columns[12].Visible = false;

            dgvAFILIADOS.Columns[1].HeaderText = "NOMBRE";
            dgvAFILIADOS.Columns[2].HeaderText = "DIRECCIÓN";
            dgvAFILIADOS.Columns[5].HeaderText = "DNI";
            dgvAFILIADOS.Columns[8].HeaderText = "SEXO";
        }

        public MODELO.AFILIADO AFILIADO
        {
            get
            {
                return oAFILIADO;
            }
        }

        private void dgvAFILIADOS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAFILIADOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Afiliafo");
                return;
            }
            else
            {
                oAFILIADO = (MODELO.AFILIADO)dgvAFILIADOS.CurrentRow.DataBoundItem;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void txtNombre_Afiliado_KeyUp(object sender, KeyEventArgs e)
        {
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados(txtNombre_Afiliado.Text);
        }
    }


}
