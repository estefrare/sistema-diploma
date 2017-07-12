using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    [MODELO.formulario(CLASE = "FrmFACTURACION", DESCRIPCION = "Facturación de afiliados", MENU = true, MODULO = "Seguridad", SUBMODULO = "Facturación")]
    [MODELO.accion(CONTROL = "btnCobrar", DESCRIPCION = "Cobrar Afiliado", FORMULARIO = "FrmFACTURACION")]
    [MODELO.accion(CONTROL = "btnDebitar", DESCRIPCION = "Debitar Afiliados", FORMULARIO = "FrmFACTURACION")]
    public partial class FrmFACTURACION : Form
    {
        CONTROLADORA.cFACTURACION cFACTURACION;
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        MODELO.RECIBO oRecibo;
        MODELO.AFILIADO oAfiliado;
        string rutaProyecto;

        private static FrmFACTURACION Instancia;
        public static FrmFACTURACION obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmFACTURACION(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmFACTURACION(oUSUARIO);

            return Instancia;
        }

        private FrmFACTURACION(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            //Obtiene las controladoras
            cFACTURACION = CONTROLADORA.cFACTURACION.Obtener_Instancia();
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();
            //Validas las acciones del usuario
            btnCobrar.Enabled = oUSUARIO.VALIDAR_ACCION("FrmFACTURACION", "btnCobrar");
            btnDebitar.Enabled = oUSUARIO.VALIDAR_ACCION("FrmFACTURACION", "btnDebitar");
            //Dehabilita el boton cobrar - Se activa cuando selecciona un afiliafo que paga en efectivo
            btnCobrar.Enabled = false;
            //Ruta de la carpeta del proyecto: [...]/SISTEMA/
            rutaProyecto = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 15);

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvAFILIADOS.DataSource = null;
            //Obtiene los afiliado - Puede buscar por: nombre, Debito automatico, estado
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados(txtBuscar_Afiliado.Text, chkDebitoAutomatico.Checked, ChkInactivos.Checked);
            //Ocutla la tabla de id_Afiliados
            dgvAFILIADOS.Columns[0].Visible = false;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //Abre el formulario de Cobrar con el objeto Afiliado
            FrmCOBRAR FormCobrar = new FrmCOBRAR(cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)));
            DialogResult dr = FormCobrar.ShowDialog();            
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            if (!CONTROLADORA.funciones_compartidas.CHEQUEAR_EMAIL())
            {
                MessageBox.Show("No se ha configurado una cuenta de correo para el envio de recibos.");
                return;
            }
            //CREA TODOS LOS RECIBOS Y LOS ENVIA UNO POR UNO POR CORREO
            bool enviaron = false; //para saber si mostrar mensaje de recibos enviados
            ListaDeudasAPagar lista = new ListaDeudasAPagar(); 
            dgvAFILIADOS.DataSource = cAFILIADOS.Obtener_Afiliados("",true, false); //obtiene todos los afiliados con Debito Automático
            int numero_afiliados = dgvAFILIADOS.Rows.Count; //numero de afiliados
            for (int j = 0; j <= numero_afiliados - 1; j++) //crea recibo uno por uno
            {
                lista.Clear();
                oAfiliado = cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS[0, j].Value)); //obtiene afiliado
                MODELO.DEUDA oDeuda = oAfiliado.DEUDAS.FirstOrDefault(x => x.Pagada == false); //obtiene deuda sin pagar
                //Crea un recibo nuevo
                oRecibo = new MODELO.RECIBO();
                //Crea el Detalle_Recibo con el Recibo y la Deuda
                cFACTURACION.AgregarDetalle(oRecibo, oDeuda);
                if(oDeuda != null) //si la deuda existe
                {
                    enviaron = true;
                    lblDebitar.Visible = true;
                    lblDebitar.Text = lblDebitar.Text = "Se estan enviando los recibos. Por favor, espere que termine el proceso." + " Quedan " + numero_afiliados + " por enviar.";
                    lista.Tables[0].Rows.Add //se carga la deuda en el dataset
                    (new object[] {
                                        oDeuda.Id,
                                        oDeuda.Mes,
                                        oDeuda.Año,
                                        oDeuda.Monto,
                                        oDeuda.Pagada,
                                        oDeuda.AFILIADO.Nombre,
                                        oDeuda.Monto
                    });

                    //----ESTO ES PARA CREAR EL RECIBO PDF---//
                    ReportDocument oRep = new ReportDocument(); 
                    oRep.Load(rutaProyecto+ "VISTA/Recibo.rpt"); 
                    oRep.SetDataSource(lista); 
                    crystalReportViewer1.ReportSource = oRep; //carga el documento en el CrystalReport

                    //----ESTO ES PARA ENVIAR EL RECIBO PDF POR MAIL---//
                    oRep.ExportToDisk(ExportFormatType.PortableDocFormat, rutaProyecto+ "report"+ j +".pdf"); //exporta recibo en pdf
                    string filename = rutaProyecto+"report" + j + ".pdf";
                    CONTROLADORA.funciones_compartidas.EnviarEmail(oAfiliado.Email, "Recibo", "Recibo", filename);
                    lblDebitar.Text = lblDebitar.Text = "Se estan enviando los recibos. Por favor, espere que termine el proceso." + " Quedan " + (numero_afiliados - (j + 1)) + " por enviar.";
                    oAfiliado.DEUDAS.First(x => x.Pagada == false).Pagada = true; //Cambia el estado de la deuda a pagado
                    cAFILIADOS.Modificar_Afiliado(oAfiliado); //guarda la deuda

                    //Completa los datos del Recibo y lo guarda en el catalogo
                    oRecibo.AFILIADO = oAfiliado;
                    oRecibo.Fecha = DateTime.Today;
                    oRecibo.Importe = oDeuda.Monto;
                    oRecibo.Nro_Recibo = oRecibo.Id_Recibo + 100;
                    cFACTURACION.AgregarRecibo(oRecibo);
                }
            }

            if (enviaron) //si se enviaron recibos, se muestra el mensaje
            {
                MessageBox.Show("Se han enviado todos los recibos por correo.");
                lblDebitar.Visible = false;
                //Deshabilita el boton Debitar porque ya se realizo esa tarea
                btnDebitar.Enabled = false;
                ARMA_GRILLA();
            }
            else
            {
                MessageBox.Show("Ya se han cobrado las cuantas de Debito Automático.");
                ARMA_GRILLA();
            }
        
        }

        private void dgvAFILIADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esto activa el boton Cobrar, si el ususario paga en Efectivo
            if (cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)).Forma_Pago == "Efectivo")
                btnCobrar.Enabled = true;
            else
                btnCobrar.Enabled = false;
        }

        private void dgvAFILIADOS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Abre el formulario Cobrar
            if (cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)).Forma_Pago == "Efectivo")
            {
                FrmCOBRAR FormCobrar = new FrmCOBRAR(cAFILIADOS.Obtener_Afiliados(Convert.ToInt32(dgvAFILIADOS.CurrentRow.Cells[0].Value)));
                FormCobrar.Show();
            }
        }

        private void FrmFACTURACION_Load(object sender, EventArgs e)
        {
            //GENERA LAS DEUDAS, SI TODAVIA NO EXISTE
            //obtiene todos los afiliados
            List<MODELO.AFILIADO> oAfiliados = cAFILIADOS.Obtener_Afiliados();
            for (int i = 0; i <= oAfiliados.Count-1; i++)
            {
                //crea una deuda para cada afiliado con el mes y el año del dia
                MODELO.DEUDA oDeuda = new MODELO.DEUDA();
                oDeuda.AFILIADO = oAfiliados[i];
                oDeuda.Mes = DateTime.Now.Month.ToString();
                oDeuda.Año = DateTime.Now.Year;
                oDeuda.Monto = oAfiliados[i].PLAN.Costo;

                //compara la deuda con la lista de deudas
                List<MODELO.DEUDA> Deudas = cAFILIADOS.Obtener_Deudas();
                if (Deudas.Find(x => x.Año == oDeuda.Año && x.Mes == oDeuda.Mes && x.AFILIADO == oDeuda.AFILIADO) == null)
                {
                    //la deuda no existe, se crea
                    cAFILIADOS.Agregar_Deuda(oDeuda);
                }
            }

            ARMA_GRILLA();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_Afiliado_TextChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void chkDebitoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }
    }
}
