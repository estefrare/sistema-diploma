using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class ucAFILIADO : UserControl
    {
        MODELO.AFILIADO oAFILIADO;
        MODELO.CATALOGO oCATALOGO;
        public ucAFILIADO()
        {
            InitializeComponent();
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public MODELO.AFILIADO AFILIADO
        {
            get
            {
                return oAFILIADO;
            }
            set
            {
                if(oAFILIADO != null)
                {
                    txtDNI_Afiliado.Text = oAFILIADO.DNI.ToString();
                    txtNombre_Afiliado.Text = oAFILIADO.Nombre;
                }
                else
                {
                    oAFILIADO = value;
                }
            }
        }

        private void txtDNI_Afiliado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int dni;
                if(!int.TryParse(txtDNI_Afiliado.Text, out dni))
                {
                    MessageBox.Show("El DNI es incorrecto");
                    txtDNI_Afiliado.Focus();
                    return;
                }
                oAFILIADO = oCATALOGO.AFILIADOS.FirstOrDefault(x => x.DNI == dni);

                if(oAFILIADO == null)
                {
                    MessageBox.Show("No se ha encontrado el Afiliado");
                    return;
                }
                else
                {
                    txtDNI_Afiliado.Text = oAFILIADO.DNI.ToString();
                    txtNombre_Afiliado.Text = oAFILIADO.Nombre;
                }
            }

            if(e.KeyCode == Keys.F5)
            {
                FrmBUSCARAFILIADO formBUSCARAFILIADO = new FrmBUSCARAFILIADO();
                DialogResult dr = formBUSCARAFILIADO.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    oAFILIADO = formBUSCARAFILIADO.AFILIADO;
                    txtDNI_Afiliado.Text = oAFILIADO.DNI.ToString();
                    txtNombre_Afiliado.Text = oAFILIADO.Nombre;
                }
            }
        }
    }
}
