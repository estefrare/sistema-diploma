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
    [MODELO.formulario(CLASE = "FrmCONFIGEMPRESA", DESCRIPCION = "Gestión de datos de la Empresa", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Datos de la Empresa")]
    [MODELO.accion(CONTROL = "btnGuardarDatos", DESCRIPCION = "Guardar Datos de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "btnCancelar", DESCRIPCION = "Cancelar", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "btnModificarDatos", DESCRIPCION = "Modificar datos de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "AgregarDiaLaborable", DESCRIPCION = "Agregar Día Laborable de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "btnEliminarDiaLaborable", DESCRIPCION = "Eliminar Día Laborable de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "btnAgregarDiaNoLaborable", DESCRIPCION = "Agregar Día no Laborable de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    [MODELO.accion(CONTROL = "btnEliminarDiaNoLaborable", DESCRIPCION = "Eliminar Día no Laborable de la Empresa", FORMULARIO = "FrmCONFIGEMPRESA")]
    public partial class FrmCONFIGEMPRESA : Form
    {
        private static FrmCONFIGEMPRESA Instancia;
        CONTROLADORA.cDATOSEMPRESA cDATOSEMPRESA;
        MODELO.DATOS_EMPRESA oDATOSEMPRESA;
        string ACCION;

        public static FrmCONFIGEMPRESA obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmCONFIGEMPRESA(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmCONFIGEMPRESA(oUSUARIO);

            return Instancia;
        }
        public FrmCONFIGEMPRESA(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            cDATOSEMPRESA = CONTROLADORA.cDATOSEMPRESA.obtener_instancia();
            oDATOSEMPRESA = cDATOSEMPRESA.Obtener_DatosEmpresa();

            btnGuardarDatos.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnGuardarDatos");
            btnCancelar.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnCancelar");
            btnModificarDatos.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnModificarDatos");
            AgregarDiaLaborable.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "AgregarDiaLaborable");
            btnEliminarDiaLaborable.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnEliminarDiaLaborable");
            btnAgregarDiaNoLaborable.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnAgregarDiaNoLaborable");
            btnEliminarDiaNoLaborable.Enabled = oUSUARIO.VALIDAR_ACCION("FrmCONFIGEMPRESA", "btnEliminarDiaNoLaborable");


            if (oDATOSEMPRESA != null)
            {
                gbDatosEmpresa.Enabled = false;
                txtDueño.Text = oDATOSEMPRESA.Dueño;
                txtLocalidad.Text = oDATOSEMPRESA.Localidad;
                txtNombre.Text = oDATOSEMPRESA.Nombre;
                btnModificarDatos.Visible = true;
                ACTIVAR_BOTONERA();
            }
            else
            {
                ACCION = "A";
                DESACTIVAR_BOTONERA();
            }

            if (cDATOSEMPRESA.Obtener_DiasEmpresa().Count > 0)
            {
                ARMAR_GRILLA1();
            }

            if (cDATOSEMPRESA.Obtener_DiasNoLaborables().Count > 0)
                ARMAR_GRILLA2();


        }

        private void ARMAR_GRILLA2()
        {
            dgvDiasNoLab.DataSource = null;
            dgvDiasNoLab.DataSource = cDATOSEMPRESA.Obtener_DiasNoLaborables();
            dgvDiasNoLab.Columns[0].Visible = false;
            dgvDiasNoLab.Columns[3].Visible = false;
        }

        private void ARMAR_GRILLA1()
        {
            dgvDias_Empresa.DataSource = null;
            dgvDias_Empresa.DataSource = cDATOSEMPRESA.Obtener_DiasEmpresa();
            dgvDias_Empresa.Columns[0].Visible = false;
            dgvDias_Empresa.Columns[4].Visible = false;
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            gbDatosEmpresa.Enabled = true;
            btnModificarDatos.Enabled = false;
            ACCION = "M";
            DESACTIVAR_BOTONERA();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosEmpresa.Enabled = false;
            txtDueño.Text = oDATOSEMPRESA.Dueño;
            txtLocalidad.Text = oDATOSEMPRESA.Localidad;
            txtNombre.Text = oDATOSEMPRESA.Nombre;
            btnModificarDatos.Enabled = true;
            if (ACCION == "M")
                ACTIVAR_BOTONERA();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtDueño.Text))
            {
                MessageBox.Show("Debe ingresar el dueño");
                return;
            }

            if (string.IsNullOrEmpty(txtLocalidad.Text))
            {
                MessageBox.Show("Debe ingresar la localidad");
                return;
            }

            if (ACCION == "A")
            {
                oDATOSEMPRESA = new MODELO.DATOS_EMPRESA();
                oDATOSEMPRESA.Nombre = txtNombre.Text;
                oDATOSEMPRESA.Dueño = txtDueño.Text;
                oDATOSEMPRESA.Localidad = txtLocalidad.Text;
                cDATOSEMPRESA.Agregar_DatosEmpresa(oDATOSEMPRESA);

            }
            else
            {
                oDATOSEMPRESA.Nombre = txtNombre.Text;
                oDATOSEMPRESA.Dueño = txtDueño.Text;
                oDATOSEMPRESA.Localidad = txtLocalidad.Text;
                cDATOSEMPRESA.Modificar_DatosEmpresa(oDATOSEMPRESA);
            }

            gbDatosEmpresa.Enabled = false;
            btnModificarDatos.Visible = true;
            btnModificarDatos.Enabled = true;
            ACTIVAR_BOTONERA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cDATOSEMPRESA.Obtener_DiasEmpresa().Count == 7)
            {
                MessageBox.Show("La empresa ya tiene todos los días cargados");
                return;
            }
            FrmDIAEMPRESA formDIAEMPRESA = new FrmDIAEMPRESA(new MODELO.DIAS_EMPRESA(), "A", oDATOSEMPRESA);
            DialogResult dr = formDIAEMPRESA.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ARMAR_GRILLA1();
            }
        }

        private void btnEliminarDia_Click(object sender, EventArgs e)
        {
            if (dgvDias_Empresa.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un día de la grilla");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma la eliminación?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cDATOSEMPRESA.Eliminar_DiaEmpresa((MODELO.DIAS_EMPRESA)dgvDias_Empresa.CurrentRow.DataBoundItem);
                ARMAR_GRILLA1();
            }
        }

        private void btnAgregarDiaNoLaborable_Click(object sender, EventArgs e)
        {
            FrmDIANOLABORALEMPRESA formDIANOLABEMP = new FrmDIANOLABORALEMPRESA(new MODELO.DIAS_NO_LABORABLES(), "A", oDATOSEMPRESA);
            DialogResult dr = formDIANOLABEMP.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ARMAR_GRILLA2();
            }
        }

        private void btnEliminarDiaNoLaborable_Click(object sender, EventArgs e)
        {
            if (dgvDiasNoLab.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un día de la grilla");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma la eliminación?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cDATOSEMPRESA.Eliminar_DiaNoLaborable((MODELO.DIAS_NO_LABORABLES)dgvDiasNoLab.CurrentRow.DataBoundItem);
                ARMAR_GRILLA2();
            }
        }

        private void DESACTIVAR_BOTONERA()
        {
            AgregarDiaLaborable.Enabled = false;
            btnEliminarDiaLaborable.Enabled = false;
            btnEliminarDiaNoLaborable.Enabled = false;
            btnAgregarDiaNoLaborable.Enabled = false;
        }

        private void ACTIVAR_BOTONERA()
        {
            AgregarDiaLaborable.Enabled = true;
            btnEliminarDiaLaborable.Enabled = true;
            btnEliminarDiaNoLaborable.Enabled = true;
            btnAgregarDiaNoLaborable.Enabled = true;
        }
    }

}
