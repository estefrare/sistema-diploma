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

    [MODELO.formulario(CLASE = "FrmGESTIONARAFILIADOS", DESCRIPCION = "Gestión de Afiliados del sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Afiliados")]
    [MODELO.accion(CONTROL = "btnConsultar_Afiliado", DESCRIPCION = "Consultar datos del Afiliado", FORMULARIO = "FrmGESTIONARAFILIADOS")]
    [MODELO.accion(CONTROL = "btnModificar_Afiliado", DESCRIPCION = "Modificar datos del Afiliado", FORMULARIO = "FrmGESTIONARAFILIADOS")]
    [MODELO.accion(CONTROL = "btnAgregar_Afiliado", DESCRIPCION = "Agregar Afiliados al sistema", FORMULARIO = "FrmGESTIONARAFILIADOS")]
    public partial class FrmGESTIONARAFILIADOS : Form
    {
        CONTROLADORA.cAFILIADOS cAFILIADOS;

        private static FrmGESTIONARAFILIADOS instancia;

        public static FrmGESTIONARAFILIADOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
                instancia = new FrmGESTIONARAFILIADOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new FrmGESTIONARAFILIADOS(oUSUARIO);

            return instancia;
        }
        public FrmGESTIONARAFILIADOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();

            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();

            btnConsultar_Afiliado.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARAFILIADOS", "btnConsultar_Afiliado");
            btnModificar_Afiliado.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARAFILIADOS", "btnModificar_Afiliado");
            btnAgregar_Afiliado.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGESTIONARAFILIADOS", "btnAgregar_Afiliado");

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvAFILIADOS.DataSource = null;
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados_Inactivos(txtBuscar_Afiliado.Text, ChkInactivos.Checked);
            dgvAFILIADOS.Columns[0].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Afiliado_Click(object sender, EventArgs e)
        {
            FrmAFILIADO FormAfiliado = new FrmAFILIADO(new MODELO.AFILIADO(), "A");
            DialogResult dr = FormAfiliado.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnModificar_Afiliado_Click(object sender, EventArgs e)
        {
            if (dgvAFILIADOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una afiliado");
                return;
            }
            FrmAFILIADO FormAfiliado = new FrmAFILIADO(cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = FormAfiliado.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnConsultar_Afiliado_Click(object sender, EventArgs e)
        {
            if (dgvAFILIADOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una afiliado");
                return;
            }
            FrmAFILIADO FormAfiliado = new FrmAFILIADO(cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = FormAfiliado.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void txtBuscar_Afiliado_TextChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void ChkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
