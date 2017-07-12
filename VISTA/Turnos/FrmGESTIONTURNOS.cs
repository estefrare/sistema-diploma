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
    [MODELO.formulario(CLASE = "FrmGESTIONTURNOS", DESCRIPCION = "Gestión de Turnos del Sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Turnos")]
    [MODELO.accion(CONTROL = "btnRegistrar_Turno", DESCRIPCION = "Registrar Turno", FORMULARIO = "FrmGESTIONTURNOS")]
    [MODELO.accion(CONTROL = "btnAnular_Turno", DESCRIPCION = "Anular Turno", FORMULARIO = "FrmGESTIONTURNOS")]
    [MODELO.accion(CONTROL = "btnBuscar_Turnos", DESCRIPCION = "Buscar Turno", FORMULARIO = "FrmGESTIONTURNOS")]
    [MODELO.accion(CONTROL = "btnActualizar_Calendario", DESCRIPCION = "Actualizar Calendario", FORMULARIO = "FrmGESTIONTURNOS")]

    public partial class FrmGESTIONTURNOS : Form
    {
        CONTROLADORA.cTURNOS cTURNOS;
        CONTROLADORA.cMEDICOS cMEDICOS;
        CONTROLADORA.cAUDITORIA cAUDITORIA;
        MODELO.USUARIO oUSUARIO;
        private static FrmGESTIONTURNOS Instancia;

        public static FrmGESTIONTURNOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmGESTIONTURNOS(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmGESTIONTURNOS(oUSUARIO);
            return Instancia;
        }

        List<DateTime> FechasNoLaborables;
        public FrmGESTIONTURNOS(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            oUSUARIO = miUSUARIO;
            cTURNOS = CONTROLADORA.cTURNOS.Obtener_Instancia();
            cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();
            cAUDITORIA = CONTROLADORA.cAUDITORIA.Obtener_Instancia();

            btnRegistrar_Turno.Enabled = miUSUARIO.VALIDAR_ACCION("FrmGESTIONTURNOS", "btnRegistrar_Turno");
            btnAnular_Turno.Enabled = miUSUARIO.VALIDAR_ACCION("FrmGESTIONTURNOS", "btnAnular_Turno");
            btnBuscar_Turnos.Enabled = miUSUARIO.VALIDAR_ACCION("FrmGESTIONTURNOS", "btnBuscar_Turnos");
            btnActualizar_Calendario.Enabled = miUSUARIO.VALIDAR_ACCION("FrmGESTIONTURNOS", "btnActualizar_Calendario");

            cmbMedicos.DataSource = cMEDICOS.Obtener_Medico(string.Empty).FindAll(x => x.Estado == true);
            cmbMedicos.DisplayMember = "Nombre";

            FechasNoLaborables = cTURNOS.Armar_Calendario((MODELO.MEDICO)cmbMedicos.SelectedItem, mcFecha.SelectionStart);
            ACTUALIZAR_CALENDARIO();
            mcFecha.UpdateBoldedDates();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Turnos_Click(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedItem == null)
                return;

            if (mcFecha.BoldedDates.ToList().Exists(x => x == mcFecha.SelectionStart))
            {
                DGVTurnos.DataSource = null;
                return;
            }

            Buscar_Turno();
        }

        private void Buscar_Turno()
        {
            List<MODELO.TURNO> oListaTurnos;
            MODELO.MEDICO oMEDICO = (MODELO.MEDICO)cmbMedicos.SelectedItem;
            oListaTurnos = cTURNOS.Buscar_Turnos(mcFecha.SelectionStart, oMEDICO);

            ACTUALIZAR_GRILLA(oListaTurnos);
        }

        private void ACTUALIZAR_GRILLA(List<MODELO.TURNO> oListaTurnos)
        {
            DGVTurnos.DataSource = null;
            DGVTurnos.DataSource = oListaTurnos;
            DGVTurnos.Columns[0].Visible = false;
            DGVTurnos.Columns[3].Visible = false;
            MODELO.MEDICO oMedico = (MODELO.MEDICO)cmbMedicos.SelectedItem;
            for (int x = 0; x <= oListaTurnos.Count - 1; x++)
            {
                DGVTurnos.Rows[x].HeaderCell.Value = oListaTurnos.ElementAt(x).Fecha.ToString().Remove(0, 10);
            }

            DGVTurnos.Columns[5].DisplayIndex = 3;
            DGVTurnos.Columns[4].DisplayIndex = 6;
            DGVTurnos.Columns[2].DisplayIndex = 1;
            DGVTurnos.Columns[1].DisplayIndex = 2;

            DGVTurnos.Columns[2].HeaderText = "FECHA";
            DGVTurnos.Columns[1].HeaderText = "ESTADO";
            DGVTurnos.Columns[4].HeaderText = "CONCURRIÓ";
        }

        private void btnRegistrar_Turno_Click(object sender, EventArgs e)
        {
            if (DGVTurnos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla");
                return;
            }
            MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
            if (oTurno.AFILIADO == null)
            {
                Agregar_Turno();
            }
        }

        private void Agregar_Turno()
        {
            MODELO.TURNO oTurno = (MODELO.TURNO) DGVTurnos.CurrentRow.DataBoundItem;
            oTurno.MEDICO = new MODELO.MEDICO();
            oTurno.MEDICO = (MODELO.MEDICO)cmbMedicos.SelectedItem;
            FrmTURNO formTURNO = new FrmTURNO(oTurno, "A", oUSUARIO);
            DialogResult dr = formTURNO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                Buscar_Turno();
        }

        private void btnAnular_Turno_Click(object sender, EventArgs e)
        {
            if (DGVTurnos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla");
                return;
            }
            MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
            if (oTurno.Estado == "Libre")
            {
                MessageBox.Show("Debe seleccionar un turno ya registrado");
                return;
            }

                if (oTurno.AFILIADO != null)
                {
                    ANULAR_TURNO();
                }
        }

        private void MODIFICAR_TURNO()
        {
            DialogResult dr = MessageBox.Show("¿Confirma la concurrencia del turno?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                MODELO.AUDITORIA oAUDITORIA= new MODELO.AUDITORIA();
                oAUDITORIA.Id_usuario = oUSUARIO.CODIGO;
                oAUDITORIA.Fecha = DateTime.Now;
                oAUDITORIA.Accion = "Concurrio";
                MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
                oAUDITORIA.Id_turno = oTurno.Id_Turno;
                cAUDITORIA.AUDITAR(oAUDITORIA);
                oTurno.Concurrio = true;
                cTURNOS.Modificar_Turno(oTurno);
                Buscar_Turno();
            }
        }

        private void ANULAR_TURNO()
        {
            MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
            if(oTurno.Concurrio == true)
            {
                MessageBox.Show("El turno que desea anular se ha realizado");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma la anulación del turno?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                MODELO.AUDITORIA oAUDITORIA = new MODELO.AUDITORIA();
                oAUDITORIA.Id_usuario = oUSUARIO.CODIGO;
                oAUDITORIA.Fecha = DateTime.Now;
                oAUDITORIA.Accion = "Anulo";
                oAUDITORIA.Id_turno = oTurno.Id_Turno;
                cAUDITORIA.AUDITAR(oAUDITORIA);
                cTURNOS.Anular_Turno(oTurno);
                Buscar_Turno();
            }
        }

        private void cmbMedicos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FechasNoLaborables = null;
            FechasNoLaborables = cTURNOS.Armar_Calendario((MODELO.MEDICO)cmbMedicos.SelectedItem, mcFecha.SelectionStart);
            ACTUALIZAR_CALENDARIO();
            mcFecha.UpdateBoldedDates();

            if (cmbMedicos.SelectedItem == null)
                return;

            if (mcFecha.BoldedDates.ToList().Exists(x => x == mcFecha.SelectionStart))
            {
                DGVTurnos.DataSource = null;
                return;
            }

            Buscar_Turno();
        }

        private void ACTUALIZAR_CALENDARIO()
        {
            mcFecha.RemoveAllBoldedDates();
            for (int i = 0; i <= FechasNoLaborables.Count - 1; i++)
            {
                mcFecha.AddBoldedDate(FechasNoLaborables.ElementAt(i));
            }
        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechasNoLaborables = null;
            FechasNoLaborables = cTURNOS.Armar_Calendario((MODELO.MEDICO)cmbMedicos.SelectedItem, mcFecha.SelectionStart);
            ACTUALIZAR_CALENDARIO();
            mcFecha.UpdateBoldedDates();

            if (cmbMedicos.SelectedItem == null)
                return;

            if (mcFecha.BoldedDates.ToList().Exists(x => x == mcFecha.SelectionStart))
            {
                DGVTurnos.DataSource = null;
                return;
            }

            Buscar_Turno();
        }

        private void DGVTurnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
            if (oTurno.AFILIADO == null)
            {
                Agregar_Turno();
            }
            else
            {
                ANULAR_TURNO();
            }
            Buscar_Turno();
        }

        private void btnActualizar_Calendario_Click(object sender, EventArgs e)
        {
            ACTUALIZAR_CALENDARIO();
            mcFecha.UpdateBoldedDates();
        }

        private void btnConcurrio_Turno_Click(object sender, EventArgs e)
        {  
            if (DGVTurnos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla");
                return;
            }
            MODELO.TURNO oTurno = (MODELO.TURNO)DGVTurnos.CurrentRow.DataBoundItem;
            if (oTurno.Estado == "Libre")
            {
                MessageBox.Show("Debe seleccionar un turno ya registrado");
                return;
            }
            if (oTurno.AFILIADO != null)
            {
                MODIFICAR_TURNO();
            }
        }
    }
}
