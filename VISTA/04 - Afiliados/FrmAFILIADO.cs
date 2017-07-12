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
    public partial class FrmAFILIADO : Form
    {
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        MODELO.AFILIADO oAFILIADO;
        MODELO.TARJETA oTarjeta; 
        string accion;

        public FrmAFILIADO(MODELO.AFILIADO miAFILIADO, string miaccion)
        {
            InitializeComponent();
            
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();
            oAFILIADO = miAFILIADO;
            accion = miaccion;

            CBPlanes.DataSource = cAFILIADOS.Obtener_Planes();
            CBPlanes.DisplayMember = "Nombre";

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
                CBPlanes.Text = oAFILIADO.PLAN.ToString();
                if(oAFILIADO.Forma_Pago == "Debito Automático")
                {
                    oTarjeta = oAFILIADO.TARJETAS;
                    txtNumeroTarjeta.Text = oAFILIADO.TARJETAS.Numero.ToString();
                    mtbVencimientoTarjeta.Text = oAFILIADO.TARJETAS.Vencimiento;
                }
                if (oAFILIADO.Forma_Pago.ToString() == "Efectivo")
                    RbEfectivo.Checked = true;
                else
                    RbDebitoAutomatico.Checked = true;
                if (oAFILIADO.Estado == true)
                {
                    ChkEstado.Checked = true;
                }
                else
                {
                    ChkEstado.Checked = false;
                }

            }
            if (accion == "C")
            {
                ChkEstado.Enabled = false;
                MtbFecha_Nacimiento.Enabled = false;
                btnGuardar_AFILIADO.Visible = false;
                btnCancelar.Text = "CERRAR";
                txtNombre_Afiliado.Enabled = false;
                txtDirecion_Afiliado.Enabled = false;
                Txtsexo_Afiliado.Enabled = false;
                mtxtDNI_Afiliado.Enabled = false;
                mtxtTel_Afiliado.Enabled = false;
                GB_FormasPago.Enabled = false;
                gbTarjeta.Enabled = false;
                TxtContrato_Afiliado.Enabled = false;
                txtEmail_Afiliado.Enabled = false;
                CBPlanes.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardar_AFILIADO_Click(object sender, EventArgs e)
        {
            int telefono, dni, contrato;
            Int64 numero_tarjeta = 0;
            DateTime fecha_nacimiento;

            if (!int.TryParse(TxtContrato_Afiliado.Text, out contrato))
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

            if (CBPlanes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan");
                return;
            }

            if (RbDebitoAutomatico.Checked)
            {
                if (!Int64.TryParse(txtNumeroTarjeta.Text, out numero_tarjeta))
                {
                    MessageBox.Show("Debe ingresar el número de la tarjeta");
                    return;
                }

                if (string.IsNullOrEmpty(mtbVencimientoTarjeta.Text))
                {
                    MessageBox.Show("Debe ingresar la fecha de vencimiento de la tarjeta");
                    return;
                }
            }

            oAFILIADO.Nombre = txtNombre_Afiliado.Text;
            oAFILIADO.DNI = dni;
            oAFILIADO.Fecha_Nacimiento = fecha_nacimiento;
            oAFILIADO.Sexo = Txtsexo_Afiliado.Text;
            oAFILIADO.Direccion = txtDirecion_Afiliado.Text;
            oAFILIADO.Telefono = telefono;
            oAFILIADO.Email = txtEmail_Afiliado.Text;
            oAFILIADO.Numero_Contrato = contrato;
            oAFILIADO.PLAN = (MODELO.PLAN)CBPlanes.SelectedItem;

            if (ChkEstado.Checked == true)
            {
                oAFILIADO.Estado = true;
            }
            else
            {
                oAFILIADO.Estado = false;
            }

            if (RbEfectivo.Checked)
                oAFILIADO.Forma_Pago = "Efectivo";
            else
            {
                if (accion == "A" || oAFILIADO.TARJETAS == null)
                    oTarjeta = new MODELO.TARJETA();

                oTarjeta.AFILIADO = oAFILIADO;
                oTarjeta.Vencimiento = mtbVencimientoTarjeta.Text;
                oTarjeta.Numero = numero_tarjeta;
                oTarjeta.Titular = txtNombre_Afiliado.Text;
                oAFILIADO.Forma_Pago = "Debito Automático";

                if (accion == "A" || oAFILIADO.TARJETAS == null)
                    cAFILIADOS.Agregar_Tarjeta(oTarjeta);
                else
                    cAFILIADOS.Modificar_Tarjeta(oTarjeta);

                oAFILIADO.TARJETAS = oTarjeta;

            }

            MODELO.DEUDA oDeuda = new MODELO.DEUDA();
            oDeuda.AFILIADO = oAFILIADO;
            oDeuda.Mes = DateTime.Now.Month.ToString();
            oDeuda.Año = DateTime.Now.Year;
            oDeuda.Monto = oAFILIADO.PLAN.Costo;
            oDeuda.Pagada = false;

            List<MODELO.DEUDA> Deudas = cAFILIADOS.Obtener_Deudas();
            if (Deudas.Find(x => x.Año == oDeuda.Año && x.Mes == oDeuda.Mes && x.AFILIADO == oDeuda.AFILIADO) == null)
            {
                oAFILIADO.DEUDAS.Add(oDeuda);
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
        }

        private void CBPlanes_KeyDown(object sender, KeyEventArgs e)
        {
                VerSERVICIOS formVerServicio = new VerSERVICIOS();
                DialogResult dr = formVerServicio.ShowDialog();     
        }

        private void FrmAFILIADO_Load(object sender, EventArgs e)
        {

        }

        private void RbDebitoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDebitoAutomatico.Checked)
                gbTarjeta.Enabled = true;
            else
                gbTarjeta.Enabled = false;
        }

        private void RbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEfectivo.Checked)
                gbTarjeta.Enabled = false;
            else
                gbTarjeta.Enabled = true;

        }
    }
}
