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
    public partial class VerSERVICIOS : Form
    {
        MODELO.PLAN oPLAN;
        MODELO.SERVICIO oSERVICIO;
        CONTROLADORA.cPLANES cPLANES;

        public VerSERVICIOS()
        {
            InitializeComponent();

            cPLANES = CONTROLADORA.cPLANES.obtener_instancia();
            oSERVICIO = new MODELO.SERVICIO();
            //oPLAN = new MODELO.PLAN();
            CbPlan.DataSource = cPLANES.Obtener_Planes();
            CbPlan.DisplayMember = "NOMBRE";

            

            ChkListServicios.Enabled = false;

        }

        private void VerSERVICIOS_Load(object sender, EventArgs e)
        {
            oPLAN = (MODELO.PLAN)CbPlan.SelectedItem;

            ChkListServicios.DataSource = null;
            ChkListServicios.DataSource = oPLAN.SERVICIO.ToList();
            ChkListServicios.DisplayMember = "NOMBRE";


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
        }


    }
}
