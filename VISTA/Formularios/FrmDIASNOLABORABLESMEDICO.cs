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
    public partial class FrmDIASNOLABORABLESMEDICO : Form
    {
        MODELO.MEDICO oMEDICO;
        MODELO.DIA_NO_LABORABLE_MEDICO oDIANOLABORABLEMEDICO;
        CONTROLADORA.cMEDICOS cMEDICOS;
        string ACCION;
        public FrmDIASNOLABORABLESMEDICO(MODELO.DIA_NO_LABORABLE_MEDICO miDIA, string miACCION, MODELO.MEDICO miMEDICO)
        {
            InitializeComponent();

            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();

            ACCION = miACCION;
            oMEDICO = miMEDICO;
            oDIANOLABORABLEMEDICO = miDIA;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar el motivo");
                return;
            }

            oDIANOLABORABLEMEDICO.Fecha = Convert.ToDateTime(dtpFecha.Text);
            oDIANOLABORABLEMEDICO.Motivo = txtMotivo.Text;

            if (ACCION == "A")
            {
                oMEDICO.DIA_NO_LABORABLE_MEDICO.Add(oDIANOLABORABLEMEDICO);
                cMEDICOS.Modificar_Medico(oMEDICO);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
