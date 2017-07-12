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
    public partial class FrmDIASNOLABORABLESEMPRESA : Form
    {
        CONTROLADORA.cDATOSEMPRESA cDATOSEMPRESA;
        MODELO.DATOS_EMPRESA oDATOSEMPRESA;
        MODELO.DIAS_NO_LABORABLES oDIANOLABORABLE;
        string ACCION;
        public FrmDIASNOLABORABLESEMPRESA(MODELO.DIAS_NO_LABORABLES miDIA, string miACCION, MODELO.DATOS_EMPRESA miDATOS)
        {
            InitializeComponent();
            cDATOSEMPRESA = CONTROLADORA.cDATOSEMPRESA.obtener_instancia();

            oDATOSEMPRESA = miDATOS;
            oDIANOLABORABLE = miDIA;
            ACCION = miACCION;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BtnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese el motivo");
                return;
            }

            oDIANOLABORABLE.Fecha = Convert.ToDateTime(dtpFecha.Text);
            oDIANOLABORABLE.Motivo = txtMotivo.Text;

            if (ACCION == "A")
            {
                oDATOSEMPRESA.DIAS_NO_LABORABLES.Add(oDIANOLABORABLE);
                cDATOSEMPRESA.Modificar_DatosEmpresa(oDATOSEMPRESA);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
