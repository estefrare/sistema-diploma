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
    public partial class FrmCONFIGMEDICO : Form
    {

        CONTROLADORA.cTURNOS cTURNOS;
        CONTROLADORA.cMEDICOS cMEDICOS;
        MODELO.MEDICO oMEDICO;
        public FrmCONFIGMEDICO(MODELO.MEDICO miMEDICO)
        {
            InitializeComponent();
            cTURNOS = CONTROLADORA.cTURNOS.Obtener_Instancia();
            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();
            oMEDICO = miMEDICO;

            if (cTURNOS.Obtener_Horas_Medicos(oMEDICO).Count() > 0)
                ARMAR_GRILLA();

            if (cTURNOS.Obtener_Dias_No_Labotables_Medico(oMEDICO).Count > 0)
                ARMAR_GRILLA2();
        }

        private void ARMAR_GRILLA2()
        {
            dgvDiasNoLaborablesMedicos.DataSource = null;
            dgvDiasNoLaborablesMedicos.DataSource = cTURNOS.Obtener_Dias_No_Labotables_Medico(oMEDICO);
            dgvDiasNoLaborablesMedicos.Columns[0].Visible = false;
            dgvDiasNoLaborablesMedicos.Columns[3].Visible = false;
        }

        private void ARMAR_GRILLA()
        {
            dgvHorariosMedico.DataSource = null;
            dgvHorariosMedico.DataSource = cTURNOS.Obtener_Horas_Medicos(oMEDICO);
            dgvHorariosMedico.Columns[0].Visible = false;
            dgvHorariosMedico.Columns[4].Visible = false;
            dgvHorariosMedico.Columns[3].DisplayIndex = 1;
        }


        private void btnAgregar_Horario_Click(object sender, EventArgs e)
        {
            if (cTURNOS.Obtener_Horas_Medicos(oMEDICO).Count() == 7)
            {
                MessageBox.Show("El medico seleccionado ya tiene todos los días cargados");
                return;
            }
            FrmHORARIOMEDICO formHORARIOMEDICO = new FrmHORARIOMEDICO(new MODELO.HORARIO_MEDICO(), "A", oMEDICO);
            DialogResult dr = formHORARIOMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ARMAR_GRILLA();
            }
        }

        private void btnEliminar_Horario_Click(object sender, EventArgs e)
        {
            if (dgvHorariosMedico.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un día");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma la eliminación del día?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cMEDICOS.Eliminar_HorarioMedico((MODELO.HORARIO_MEDICO)dgvHorariosMedico.CurrentRow.DataBoundItem);
                ARMAR_GRILLA();
            }
        }

        private void btnAgregar_Día_No_Laborable_Click(object sender, EventArgs e)
        {
            FrmDIASNOLABORABLESMEDICO formDIASNOLABORABLESMEDICO = new FrmDIASNOLABORABLESMEDICO(new MODELO.DIA_NO_LABORABLE_MEDICO(), "A", oMEDICO);
            DialogResult dr = formDIASNOLABORABLESMEDICO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ARMAR_GRILLA2();
            }
        }

        private void btnEliminar_Dia_No_Laborable_Click(object sender, EventArgs e)
        {
            if (dgvDiasNoLaborablesMedicos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar el día");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma la eliminación?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cMEDICOS.Eliminar_DiaNoLaborableMedico((MODELO.DIA_NO_LABORABLE_MEDICO)dgvDiasNoLaborablesMedicos.CurrentRow.DataBoundItem);
                ARMAR_GRILLA2();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
