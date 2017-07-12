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
    public partial class FrmMEDICO : Form
    {
        CONTROLADORA.cMEDICOS cMEDICOS;
        MODELO.MEDICO oMEDICO;
        string ACCION;
        public FrmMEDICO(MODELO.MEDICO miMEDICO, string miACCION)
        {
            InitializeComponent();
            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();
            oMEDICO = miMEDICO;
            ACCION = miACCION;

            if (ACCION != "A")
            {
                txtNombre_Medico.Text = oMEDICO.Nombre;
                txtEmail_Medico.Text = oMEDICO.Email;
                txtEspecialidad_Medico.Text = oMEDICO.Especialidad;
                mtxtDNI_Medico.Text = oMEDICO.DNI.ToString();
                mtxtTel_Medico.Text = oMEDICO.Telefono.ToString();
                txtMatricula_Medico.Text = oMEDICO.Matricula.ToString();
                txtTiempo_Por_Paciente.Text = oMEDICO.Tiempo_Por_Paciente.ToString();
                if (oMEDICO.Estado == true)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }

                if (ACCION == "C")
                {
                    btnGuardar_Medico.Visible = false;
                    btnCancelar.Text = "CERRAR";
                    txtEmail_Medico.Enabled = false;
                    txtEspecialidad_Medico.Enabled = false;
                    txtMatricula_Medico.Enabled = false;
                    txtNombre_Medico.Enabled = false;
                    txtTiempo_Por_Paciente.Enabled = false;
                    mtxtDNI_Medico.Enabled = false;
                    mtxtTel_Medico.Enabled = false;
                    chkActivo.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardar_Medico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre_Medico.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del médico");
                return;
            }

            int matricula;
            if (!int.TryParse(txtMatricula_Medico.Text, out matricula))
            {
                MessageBox.Show("La matricula ingresada es incorrecta");
                return;
            }

            int dni;
            if (!int.TryParse(mtxtDNI_Medico.Text, out dni))
            {
                MessageBox.Show("El DNI ingresado es incorrecto");
                return;
            }
            else
            {
                if (ACCION == "A" && cMEDICOS.Obtener_Medicos(string.Empty).Count(c => c.DNI == dni) > 0)
                {
                    MessageBox.Show("El DNI ingresado ya se encuentra registrado");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtEspecialidad_Medico.Text))
            {
                MessageBox.Show("Debe ingresar la especialidad del médico");
                return;
            }

            int tel;
            if (!int.TryParse(mtxtTel_Medico.Text, out tel))
            {
                MessageBox.Show("El teléfono ingresado es incorrecto");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail_Medico.Text))
            {
                MessageBox.Show("Debe ingresar el Email del médico");
                return;
            }

            int tiempopaciente;
            if (!int.TryParse(txtTiempo_Por_Paciente.Text, out tiempopaciente))
            {
                MessageBox.Show("Debe ingresar el tiempo que el médico atenderá a cada paciente");
                return;
            }

            oMEDICO.Nombre = txtNombre_Medico.Text;
            oMEDICO.Matricula = matricula;
            oMEDICO.DNI = dni;
            oMEDICO.Especialidad = txtEspecialidad_Medico.Text;
            oMEDICO.Telefono = tel;
            oMEDICO.Email = txtEmail_Medico.Text;
            oMEDICO.Direccion = "ESPAÑA";
            if (chkActivo.Checked == true)
            {
                oMEDICO.Estado = true;
            }
            else
            {
                oMEDICO.Estado = false;
            }

            oMEDICO.Tiempo_Por_Paciente = tiempopaciente;

            if (ACCION == "A")
            {
                cMEDICOS.Agregar_Medico(oMEDICO);
            }
            else
            {
                cMEDICOS.Modificar_Medico(oMEDICO);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
