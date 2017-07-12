using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txtDia.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDia.Text.ToLower());
            txtDia.Text = txtDia.Text.Trim();
            if (txtDia.Text != "Lunes" && txtDia.Text != "Martes" && txtDia.Text != "Miercoles" && txtDia.Text != "Jueves" && txtDia.Text != "Viernes" && txtDia.Text != "Viernes" && txtDia.Text != "Sabado" && txtDia.Text != "Domingo")
            {
                MessageBox.Show("Debe ingresar un dia valido");
                return;
            }
            if (mtxtHora_Inicio.Text == "  :")
            {
                MessageBox.Show("Debe ingresar hora de inicio");
                return;
            }
            if (mtxtHora_Fin.Text == "  :")
            {
                MessageBox.Show("Debe ingresar hora de fin");
                return;
            }
            if (mtxtHora_Fin.Text.PadRight(5, '0') == mtxtHora_Inicio.Text.PadRight(5, '0'))
            {
                MessageBox.Show("Los horarios ingresados no pueden ser iguales");
                return;
            }


            string hora_inicio = mtxtHora_Inicio.Text.Substring(0, 2); //valida logica de horas
            string hora_fin = mtxtHora_Fin.Text.Substring(0, 2);
            int hora1 = Int32.Parse(hora_inicio);
            int hora2 = Int32.Parse(hora_fin);
            if (hora1 > hora2)
            {
                MessageBox.Show("La hora de incio no puede ser mayor a la hora de finalizacion");
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

        private void mtxtHora_Inicio_Leave_1(object sender, EventArgs e)
        {
            mtxtHora_Inicio.Text = mtxtHora_Inicio.Text.PadRight(5, '0'); //completa las horas con 0
        }

        private void mtxtHora_Fin_Leave(object sender, EventArgs e)
        {
            mtxtHora_Fin.Text = mtxtHora_Fin.Text.PadRight(5, '0'); //completa las horas con 0
        }

        private void mtxtHora_Fin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
        }




    }
}
