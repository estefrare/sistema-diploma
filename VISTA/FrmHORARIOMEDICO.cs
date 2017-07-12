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
            if (string.IsNullOrEmpty(txtDia.Text))
            {
                MessageBox.Show("Ingrese el Día");
                return;
            }
            txtDia.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDia.Text.ToLower());
            txtDia.Text = txtDia.Text.Trim();
            if (txtDia.Text != "Lunes" && txtDia.Text != "Martes" && txtDia.Text != "Miercoles" && txtDia.Text != "Jueves" && txtDia.Text != "Viernes" && txtDia.Text != "Viernes" && txtDia.Text != "Sabado" && txtDia.Text != "Domingo")
            {
                MessageBox.Show("Debe ingresar un dia valido");
                return;
            }
            if (mtxtHoraInicio.Text == "  :")
            {
                MessageBox.Show("Debe ingresar hora de inicio");
                return;
            }
            if (mtxtHoraFin.Text == "  :")
            {
                MessageBox.Show("Debe ingresar hora de fin");
                return;
            }
            if (mtxtHoraFin.Text.PadRight(5, '0') == mtxtHoraInicio.Text.PadRight(5, '0'))
            {
                MessageBox.Show("Los horarios ingresados no pueden ser iguales");
                return;
            }


            string hora_inicio = mtxtHoraInicio.Text.Substring(0, 2); //valida logica de horas
            string hora_fin = mtxtHoraFin.Text.Substring(0, 2);
            int hora1 = Int32.Parse(hora_inicio);
            int hora2 = Int32.Parse(hora_fin);
            if (hora1 > hora2)
            {
                MessageBox.Show("La hora de incio no puede ser mayor a la hora de finalizacion");
                return;
            }

            oHORARIOMEDICO.Dia = txtDia.Text; //pasa a minuscula y luego a titulo
            oHORARIOMEDICO.Hora_Inicio = mtxtHoraInicio.Text;
            oHORARIOMEDICO.Hora_Fin = mtxtHoraFin.Text;

            if (ACCION == "A")
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

        private void mtxtHoraFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnGuardar_Horario_Click(sender, e);
            }
        }


        private void mtxtHoraInicio_Leave(object sender, EventArgs e)
        {
            mtxtHoraInicio.Text = mtxtHoraInicio.Text.PadRight(5, '0'); //completa las horas con 0
        }

        private void mtxtHoraFin_Leave(object sender, EventArgs e)
        {
            mtxtHoraFin.Text = mtxtHoraFin.Text.PadRight(5, '0'); //completa las horas con 0
        }

        private void mtxtHoraFin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnGuardar_Horario_Click(sender, e);
            }
        }
    }
}
