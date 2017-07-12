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
    public partial class FrmTURNO : Form
    {
        CONTROLADORA.cAUDITORIA cAUDITORIA;
        CONTROLADORA.cTURNOS cTURNOS;
        MODELO.AUDITORIA oAUDITORIA;
        MODELO.TURNO oTurno;
        MODELO.Auditoria_Turnos oAUDITORIA_TURNO;
        CONTROLADORA.cAUDITRIA_TURNOS cAUDITORIA_TURNO;
        MODELO.USUARIO oUSUARIO;
        string ACCION;
        public FrmTURNO(MODELO.TURNO miTURNO, string miACCION, MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            oUSUARIO = miUSUARIO;
            cTURNOS = CONTROLADORA.cTURNOS.Obtener_Instancia();
            cAUDITORIA = CONTROLADORA.cAUDITORIA.Obtener_Instancia();
            cAUDITORIA_TURNO = CONTROLADORA.cAUDITRIA_TURNOS.Obtener_instancia();

            CARGA_DATOS(miTURNO, miACCION);

            if (ACCION == "A")
            {
                txtEstado_Turno.Text = "Registrado";
            }
        }

        private void CARGA_DATOS(MODELO.TURNO miTURNO, string miACCION)
        {
            oTurno = miTURNO;
            ACCION = miACCION;
            lblMensaje_Ayuda.Text = "Ingrese el DNI del afiliado y presione 'ENTER' para cargar el afiliado o F5 para buscarlo";
            txtFecha_Turno.Text = Convert.ToString(oTurno.Fecha);
            txtFecha_Turno.ReadOnly = true;
            txtNombre_Medico.Text = oTurno.MEDICO.Nombre;
            txtNombre_Medico.ReadOnly = true;
            txtMatricula_Medico.Text = oTurno.MEDICO.Matricula.ToString();
            txtMatricula_Medico.ReadOnly = true;
            txtEstado_Turno.Enabled = false;
        }

        private void btnCancelar_Turno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Turno_Click(object sender, EventArgs e)
        {

            if(ucAFILIADO1.AFILIADO == null)
            {
                MessageBox.Show("Debe seleccionar un afiliado");
                return;
            }

            if(string.IsNullOrEmpty(TxtMotivo_Turno.Text))
            {
                MessageBox.Show("Debe ingresar el motivo del Turno");
                return;
            }

            
            oTurno.AFILIADO = ucAFILIADO1.AFILIADO;
            oTurno.Estado = txtEstado_Turno.Text;
            oTurno.Motivo = TxtMotivo_Turno.Text;
            oTurno.Concurrio = false;
            cTURNOS.Agregar_Turno(oTurno);

            oAUDITORIA = new MODELO.AUDITORIA();
            oAUDITORIA.Id_usuario = oUSUARIO.CODIGO;
            oAUDITORIA.Fecha = DateTime.Now;
            oAUDITORIA.Id_turno = oTurno.Id_Turno;
            oAUDITORIA.Accion = "Alta";
            cAUDITORIA.AUDITAR(oAUDITORIA);

            MessageBox.Show("EL turno se registró correctamente");
            this.DialogResult = DialogResult.OK;
        }

        private void txtEstado_Turno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                btnGuardar_Turno_Click(sender, e);
            }
        }
    }
}
