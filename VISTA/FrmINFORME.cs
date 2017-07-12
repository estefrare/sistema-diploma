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
    public partial class FrmINFORME : Form
    {
        CONTROLADORA.cINFORME cINFORME;
        public FrmINFORME()
        {
            InitializeComponent();
            cINFORME = CONTROLADORA.cINFORME.Obtener_Instancia();
            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvInforme.DataSource = cINFORME.Obtener_Informes("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void txtBuscar_Plan_TextChanged(object sender, EventArgs e)
        {
            dgvInforme.DataSource = cINFORME.Obtener_Informes(txtBuscar_medico.Text);
        }
    }
}
