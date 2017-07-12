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
    public partial class FrmSERVICIO : Form
    {
        MODELO.SERVICIO oServicio;
        CONTROLADORA.cSERVICIOS cSERVICIOS;
        string accion;
        public FrmSERVICIO(MODELO.SERVICIO miServicio, string miaccion)
        {
            InitializeComponent();
            cSERVICIOS = CONTROLADORA.cSERVICIOS.Obtener_Instancia();
            oServicio = miServicio;
            accion = miaccion;

            if(accion != "A")
            {
                TxtNombreServicio.Text = oServicio.Nombre;
                TxtDescripcionServicio.Text = oServicio.Descripcion;
                MtbFechaCreacionServicio.Text = oServicio.Fecha_Creacion.ToString();
                if (oServicio.Estado == true)
                {
                    ChkBoxEstadoServicio.Checked = true;
                }
                else
                {
                    ChkBoxEstadoServicio.Checked = false;
                }
            }

            if(accion == "C")
            {
                TxtNombreServicio.Enabled = false;
                TxtDescripcionServicio.Enabled = false;
                MtbFechaCreacionServicio.Enabled = false;
                ChkBoxEstadoServicio.Enabled = false;
            }
        }

        private void FrmSERVICIOS_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            DateTime fecha_creacion;

            if(string.IsNullOrEmpty(TxtNombreServicio.Text))
            {
                MessageBox.Show("El nombre ingresado es incorrecto");
                return;
            }

            if(string.IsNullOrEmpty(TxtDescripcionServicio.Text))
            {
                MessageBox.Show("La descripción ingresada es incorrecta");
                return;
            }

            if(!DateTime.TryParse(MtbFechaCreacionServicio.Text,out fecha_creacion))
            {
                MessageBox.Show("La fecha ingresada es incorrecta");
                return;
            }

            oServicio.Nombre = TxtNombreServicio.Text;
            oServicio.Descripcion = TxtDescripcionServicio.Text;
            oServicio.Fecha_Creacion = fecha_creacion;
            if (ChkBoxEstadoServicio.Checked == true)
            {
                oServicio.Estado = true;
            }
            else
            {
                oServicio.Estado = false;
            }

            if (accion == "A")
            {
                cSERVICIOS.Agregar_Servicio(oServicio);
            }
            else
                cSERVICIOS.Modificar_Servicio(oServicio);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
