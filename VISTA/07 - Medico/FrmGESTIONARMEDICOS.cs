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
   [MODELO.formulario(CLASE = "FrmGESTIONARMEDICOS", DESCRIPCION = "Gestión de Medicos del sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Medicos")]
   [MODELO.accion(CONTROL = "btnConfigurar_Medico", DESCRIPCION = "Configurar horarios del medico", FORMULARIO = "FrmGESTIONARMEDICOS")]
   [MODELO.accion(CONTROL = "btnModificar_Medico", DESCRIPCION = "Modificar datos del Medico", FORMULARIO = "FrmGESTIONARMEDICOS")]
   [MODELO.accion(CONTROL = "btnAgregar_Medico", DESCRIPCION = "Agregar Medicos al sistema", FORMULARIO = "FrmGESTIONARMEDICOS")]
   [MODELO.accion(CONTROL = "BtnInforme", DESCRIPCION = "Informe de los Medicos", FORMULARIO = "FrmGESTIONARMEDICOS")]

    public partial class FrmGESTIONARMEDICOS : Form
    {
        CONTROLADORA.cMEDICOS cMEDICOS;
        CONTROLADORA.cUSUARIOS cUSUARIOS;

        private static FrmGESTIONARMEDICOS Instancia;
        public static FrmGESTIONARMEDICOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmGESTIONARMEDICOS(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmGESTIONARMEDICOS(oUSUARIO);

            return Instancia;
        }
        private FrmGESTIONARMEDICOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();


            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();

            btnConsultar_Medico.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARMEDICOS", "btnConsultar_Medico");
            btnModificar_Medico.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARMEDICOS", "btnModificar_Medico");
            btnAgregar_Medico.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARMEDICOS", "btnAgregar_Medico");
            btnConfigurar_Medico.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARMEDICOS", "btnConfigurar_Medico");
            BtnInforme.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARMEDICOS", "BtnInforme");
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            

            if (cMEDICOS.Obtener_Medico(string.Empty).Count > 0)
                ARMAR_GRILLA();
        }

        private void ARMAR_GRILLA()
        {
            dgvMEDICOS.DataSource = null;
            dgvMEDICOS.DataSource = cMEDICOS.Obtener_Medico(string.Empty);
           
            dgvMEDICOS.Columns[0].Visible = false;
            dgvMEDICOS.Columns[2].Visible = false;
            dgvMEDICOS.Columns[3].Visible = false;
            dgvMEDICOS.Columns[4].Visible = false;
            dgvMEDICOS.Columns[9].Visible = false;
            dgvMEDICOS.Columns[10].Visible = false;
            dgvMEDICOS.Columns[11].Visible = false;
            dgvMEDICOS.Columns[12].Visible = false;

            dgvMEDICOS.Columns[1].HeaderText = "NOMBRE";
            dgvMEDICOS.Columns[5].HeaderText = "MATRICULA";
            dgvMEDICOS.Columns[6].HeaderText = "DNI";
            dgvMEDICOS.Columns[7].HeaderText = "ESPECIALIDAD";
            dgvMEDICOS.Columns[8].HeaderText = "ESTADO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Medico_Click(object sender, EventArgs e)
        {
            FrmMEDICO formMEDICO = new FrmMEDICO(new MODELO.MEDICO(), "A");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();
        }

        private void btnModificar_Medico_Click(object sender, EventArgs e)
        {
            if (dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Médico de la lista");
                return;
            }
            FrmMEDICO formMEDICO = new FrmMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem, "M");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();
        }

        private void btnConsultar_Medico_Click(object sender, EventArgs e)
        {
            if (dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Médico de la lista");
                return;
            }
            FrmMEDICO formMEDICO = new FrmMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem, "C");
            DialogResult dr = formMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMAR_GRILLA();

        }

        private void txtBuscar_Medico_KeyUp(object sender, KeyEventArgs e)
        {
            dgvMEDICOS.DataSource = cMEDICOS.Obtener_Medico(txtBuscar_Medico.Text);
        }

        private void btnConfigurar_Medico_Click(object sender, EventArgs e)
        {
            if (dgvMEDICOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un médico de la grilla");
                return;
            }
            FrmCONFIGMEDICO formCONFIGMEDICO = new FrmCONFIGMEDICO((MODELO.MEDICO)dgvMEDICOS.CurrentRow.DataBoundItem);
            DialogResult dr = formCONFIGMEDICO.ShowDialog();
        }

        private void txtBuscar_Medico_TextChanged(object sender, EventArgs e)
        {
            dgvMEDICOS.DataSource = cMEDICOS.Obtener_Medico(txtBuscar_Medico.Text);
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
           FrmINFORME FormInforme = new FrmINFORME();
           DialogResult dr = FormInforme.ShowDialog();
        } 
    }
}
