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
    public partial class frmAFILIADOS : Form
    {
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        MODELO.AFILIADO oAFILIADO;
        string accion;


        public frmAFILIADOS(MODELO.AFILIADO miAFILIADO, string miaccion)
        {
            InitializeComponent();
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();
            oAFILIADO = miAFILIADO;
            accion = miaccion;

            if (accion != "A")
            {
                txtNombre_Afiliado.Text = oAFILIADO.Nombre;
                txtDirecion_Afiliado.Text = oAFILIADO.Direccion;
                txtEmail_Afiliado.Text = oAFILIADO.Email;
                MtbFecha_Nacimiento.Text = oAFILIADO.Fecha_Nacimiento.ToString();
                Txtsexo_Afiliado.Text = oAFILIADO.Sexo;
                TxtContrato_Afiliado.Text = oAFILIADO.Numero_Contrato.ToString();
                mtxtDNI_Afiliado.Text = oAFILIADO.DNI.ToString();
                mtxtTel_Afiliado.Text = oAFILIADO.Telefono.ToString();

                if(oAFILIADO.Estado == true)
                {
                    ChkEstado.Checked = true;
                }
                else
                {
                    ChkEstado.Checked = false;
                }

                if(oAFILIADO.Titular == true)
                {
                    chkTitular.Checked = true;
                }
                else
                {
                    ChkAdherente.Checked = true;
                }
            }
            if (accion == "C")
            {
                btnGuardar_AFILIADO.Visible = false;
                btnCancelar.Text = "CERRAR";
                txtNombre_Afiliado.Enabled = false;
                txtDirecion_Afiliado.Enabled = false;
                Txtsexo_Afiliado.Enabled = false;
                mtxtDNI_Afiliado.Enabled = false;
                mtxtTel_Afiliado.Enabled = false;
                chkTitular.Enabled = false;
                ChkDebito.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardar_AFILIADO_Click(object sender, EventArgs e)
        {
            int telefono, dni, contrato;
            DateTime fecha_nacimiento;

            if(!int.TryParse(TxtContrato_Afiliado.Text, out contrato))
            {
                MessageBox.Show("El número de contrato ingresado es incorrecto");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre_Afiliado.Text))
            {
                MessageBox.Show("El nombre ingresado es incorrecto");
                return;
            }

            if (!int.TryParse(mtxtDNI_Afiliado.Text, out dni))
            {
                MessageBox.Show("El DNI ingresado es incorrecto");
                return;
            }

            if (!DateTime.TryParse(MtbFecha_Nacimiento.Text, out fecha_nacimiento))
            {
                MessageBox.Show("La fecha de nacimiento ingresada es incorrecta");
                return;
            }

            if (string.IsNullOrEmpty(Txtsexo_Afiliado.Text))
            {
                MessageBox.Show("El sexo ingresado es incorrecto");
                return;
            }

            if (string.IsNullOrEmpty(txtDirecion_Afiliado.Text))
            {
                MessageBox.Show("La dirección ingresada es incorrecta");
                return;
            }

            if (!int.TryParse(mtxtTel_Afiliado.Text, out telefono))
            {
                MessageBox.Show("El telefono ingresado es incorrecto");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail_Afiliado.Text))
            {
                MessageBox.Show("El email ingresado es incorrecto");
                return;
            }



            oAFILIADO.Nombre = txtNombre_Afiliado.Text;
            oAFILIADO.DNI = dni;
            oAFILIADO.Fecha_Nacimiento = fecha_nacimiento;
            oAFILIADO.Sexo = Txtsexo_Afiliado.Text;
            oAFILIADO.Direccion = txtDirecion_Afiliado.Text;
            oAFILIADO.Telefono = telefono;
            oAFILIADO.Email = txtEmail_Afiliado.Text;
            oAFILIADO.Numero_Contrato = contrato;


            if(chkTitular.Checked == true)
            {
                oAFILIADO.Titular = true;
            }
            else
            {
                oAFILIADO.Adherente = true;
            }

            if(ChkEstado.Checked == true)
            {
                oAFILIADO.Estado = true;
            }
            else
            {
                oAFILIADO.Estado = false;
            }

            if (accion == "A")
            {
                cAFILIADOS.Agregar_Afiliado(oAFILIADO);
            }
            else
            {
                cAFILIADOS.Modificar_Afiliado(oAFILIADO);
            }

            this.DialogResult = DialogResult.OK;


            //FALTA EL TEMA DE LOS PLANES Y EL DEBITO AUTOMATICO
        }

    }
}
