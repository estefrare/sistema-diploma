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
    public partial class FrmDIAEMPRESA : Form
    {

        CONTROLADORA.cDATOSEMPRESA cDATOSEMPRESA;
        MODELO.DIAS_EMPRESA oDIASEMPRESA;
        MODELO.DATOS_EMPRESA oDATOSEMPRESA;
        string ACCION;
        public FrmDIAEMPRESA(MODELO.DIAS_EMPRESA miDIA, string miACCION, MODELO.DATOS_EMPRESA miDATOS)
        {
            InitializeComponent();
            cDATOSEMPRESA = CONTROLADORA.cDATOSEMPRESA.obtener_instancia();

            oDIASEMPRESA = miDIA;
            oDATOSEMPRESA = miDATOS;
            ACCION = miACCION;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDia.Text))
            {
                MessageBox.Show("Debe ingresar el día");
                return;
            }

            oDIASEMPRESA.Dia = txtDia.Text;
            oDIASEMPRESA.Hora_Inicio = mtxtHora_Inicio.Text;
            oDIASEMPRESA.Hora_Fin = mtxtHora_Fin.Text;

            if (ACCION == "A")
            {
                oDATOSEMPRESA.DIAS_EMPRESA.Add(oDIASEMPRESA);
                cDATOSEMPRESA.Modificar_DatosEmpresa(oDATOSEMPRESA);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
