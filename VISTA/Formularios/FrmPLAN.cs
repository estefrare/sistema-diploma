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
    public partial class FrmPLAN : Form
    {
        CONTROLADORA.cPLANES cPLANES;
        MODELO.PLAN oPLAN;
        string accion;
        bool checkear;
        bool checkearA = false;

        public FrmPLAN(MODELO.PLAN miPLAN, string miaccion)
        {
            InitializeComponent();

            cPLANES = CONTROLADORA.cPLANES.obtener_instancia();
            oPLAN = miPLAN;
            accion = miaccion;
            ChkListServicios.Enabled = true;
            
            

            if (accion != "A")
            {
                TxtNombrePlan.Text = oPLAN.Nombre;
                TxtDescripcionPlan.Text = oPLAN.Descripcion;
                TxtCostoPlan.Text = oPLAN.Costo.ToString();
                if (oPLAN.Estado == true)
                {
                    ChkBoxEstadoPlan.Checked = true;
                }
                else
                {
                    ChkBoxEstadoPlan.Checked = false;
                }
            }
            
            if(accion == "C")
            {
                BtnCancelar.Text = "CERRAR";
                TxtNombrePlan.Enabled = false;
                TxtDescripcionPlan.Enabled = false;
                TxtCostoPlan.Enabled = false;
                ChkListServicios.Enabled = false;
                ChkBoxEstadoPlan.Enabled = false;
            }



        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;     
        }

        private void FrmPLANES_Load(object sender, EventArgs e)
        {
            ChkListServicios.DataSource = null;
            ChkListServicios.DataSource = cPLANES.Obtener_Servicios();
            ChkListServicios.DisplayMember = "Nombre";

            checkearA = false;

            for (int i = 0; i < ChkListServicios.Items.Count; i++)
            {
                MODELO.SERVICIO oServicio = (MODELO.SERVICIO)ChkListServicios.Items[i];
                foreach (MODELO.SERVICIO miServicio in oPLAN.SERVICIO.ToList())
                {
                    if (miServicio.Nombre == oServicio.Nombre)
                    {
                        ChkListServicios.SetItemChecked(i, true);
                    }
                }
            }

            checkear = true;
        }


        private void ChkListServicios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkear == false) return;

            MODELO.SERVICIO oServicio = (MODELO.SERVICIO)ChkListServicios.SelectedItem;

            if (e.NewValue == CheckState.Checked)
            {
                oPLAN.SERVICIO.Add(oServicio);
            }
            else
            {
                oPLAN.SERVICIO.Remove(oServicio);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int costo;

            if (string.IsNullOrEmpty(TxtNombrePlan.Text))
            {
                MessageBox.Show("El nombre ingresado es incorrecto");
                return;
            }

            if(string.IsNullOrEmpty(TxtDescripcionPlan.Text))
            {
                MessageBox.Show("La descripcion ingresada es incorrecta");
                return;
            }

            if(!int.TryParse(TxtCostoPlan.Text, out costo))
            {
                MessageBox.Show("El costo ingresado es incorrecto");
                return;
            }

            oPLAN.Nombre = TxtNombrePlan.Text;
            oPLAN.Descripcion = TxtDescripcionPlan.Text;
            oPLAN.Costo = costo;

            if(ChkBoxEstadoPlan.Checked == true)
            {
                oPLAN.Estado = true;
            }
            else
            {
                oPLAN.Estado = false;
            }

            if (accion == "A")
            {
                cPLANES.Agregar_Plan(oPLAN);
            }
            else
                cPLANES.Modificar_Plan(oPLAN);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
