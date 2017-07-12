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

    [MODELO.formulario(CLASE = "FrmGESTIONARPLANES", DESCRIPCION = "Gestión de Planes del sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión Planes y Servicios")]
    [MODELO.accion(CONTROL = "btnConsultar_Planes", DESCRIPCION = "Consultar datos del Plan", FORMULARIO = "FrmGESTIONARPLANES")]
    [MODELO.accion(CONTROL = "btnModificar_Planes", DESCRIPCION = "Modificar datos del Plan", FORMULARIO = "FrmGESTIONARPLANES")]
    [MODELO.accion(CONTROL = "btnAgregar_Planes", DESCRIPCION = "Agregar Planes al sistema", FORMULARIO = "FrmGESTIONARPLANES")]
    public partial class FrmGESTIONARPLANES : Form
    {
        CONTROLADORA.cPLANES cPLANES;

        private static FrmGESTIONARPLANES instacia;

        public static FrmGESTIONARPLANES obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instacia == null)
                instacia = new FrmGESTIONARPLANES(oUSUARIO);
            if (instacia.IsDisposed)
                instacia = new FrmGESTIONARPLANES(oUSUARIO);
            return instacia;
        }
        public FrmGESTIONARPLANES(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();

            cPLANES = CONTROLADORA.cPLANES.obtener_instancia();
            btnConsultar_Planes.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARPLANES", "btnConsultar_Planes");
            btnModificar_Planes.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARPLANES", "btnModificar_Planes");
            btnAgregar_Planes.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARPLANES", "btnAgregar_Planes");


            if (cPLANES.Obtener_Plan((string.Empty)).Count > 0)
                ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            dgvPLANES.DataSource = null;
            dgvPLANES.DataSource = cPLANES.Obtener_Plan((string.Empty));
            dgvPLANES.Columns[0].Visible = false;
            dgvPLANES.Columns[5].Visible = false;
            dgvPLANES.Columns[6].Visible = false;

            //dgvPLANES.Columns[0].HeaderText = "ID PLAN";
            dgvPLANES.Columns[1].HeaderText = "NOMBRE";
            dgvPLANES.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvPLANES.Columns[3].HeaderText = "COSTO";
            dgvPLANES.Columns[4].HeaderText = "ESTADO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Planes_Click(object sender, EventArgs e)
        {
            FrmPLANES FormPlanes = new FrmPLANES(new MODELO.PLAN(), "A");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnModificar_Planes_Click(object sender, EventArgs e)
        {
            if (dgvPLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan");
                return;
            }
            FrmPLANES FormPlanes = new FrmPLANES((MODELO.PLAN)dgvPLANES.CurrentRow.DataBoundItem, "M");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnConsultar_Planes_Click(object sender, EventArgs e)
        {
            if (dgvPLANES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plan");
                return;
            }
            FrmPLANES FormPlanes = new FrmPLANES((MODELO.PLAN)dgvPLANES.CurrentRow.DataBoundItem, "C");
            DialogResult dr = FormPlanes.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void txtBuscar_Plan_TextChanged(object sender, EventArgs e)
        {
            dgvPLANES.DataSource = cPLANES.Obtener_Plan(txtBuscar_Plan.Text);

            dgvPLANES.Columns[5].Visible = false;
            dgvPLANES.Columns[6].Visible = false;

            dgvPLANES.Columns[0].HeaderText = "ID PLAN";
            dgvPLANES.Columns[1].HeaderText = "NOMBRE";
            dgvPLANES.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgvPLANES.Columns[3].HeaderText = "COSTO";
            dgvPLANES.Columns[4].HeaderText = "ESTADO";
        }


    }
}
