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
    public partial class FrmHORARIOMEDICO : Form
    {
        CONTROLADORA.cMEDICOS cMEDICOS;
        MODELO.MEDICO oMEDICO;
        MODELO.HORARIO_MEDICO oHORARIOMEDICO;
        string ACCION;
        public FrmHORARIOMEDICO(MODELO.HORARIO_MEDICO miHORARIOMEDICO, string miACCION, MODELO.MEDICO miMEDICO)
        {
            InitializeComponent();
            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();

            ACCION = miACCION;
            oMEDICO = miMEDICO;
            oHORARIOMEDICO = miHORARIOMEDICO;

            if (ACCION != "A")
            {
                txtDia.Text = oHORARIOMEDICO.Dia;
                mtxtHoraInicio.Text = oHORARIOMEDICO.Hora_Inicio;
                mtxtHoraFin.Text = oHORARIOMEDICO.Hora_Fin;
            }
        }

        private void btnGuardar_Horario_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDia.Text))
            {
                MessageBox.Show("Ingrese el Día");
                return;
            }

            /*int horainicio;
            if(!int.TryParse(mtxtHoraInicio.Text, out horainicio))
            {
                MessageBox.Show("Ingrese la Hora Inicio");
                return;
            }

            int horafin;
            if(!int.TryParse(mtxtHoraFin.Text, out horafin))
            {
                MessageBox.Show("Ingrese la Hora Fin");
                return;
            }*/

            oHORARIOMEDICO.Dia = txtDia.Text;
            oHORARIOMEDICO.Hora_Inicio = mtxtHoraInicio.Text;
            oHORARIOMEDICO.Hora_Fin = mtxtHoraFin.Text;

            if(ACCION == "A")
            {
                oMEDICO.HORARIO_MEDICO.Add(oHORARIOMEDICO);
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
