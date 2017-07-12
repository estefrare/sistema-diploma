using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Reporting.WebForms;
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
    public partial class FrmCOBRAR : Form
    {
        CONTROLADORA.cAFILIADOS cAFILIADOS;
        CONTROLADORA.cFACTURACION cFACTURACION;
        MODELO.AFILIADO oAfiliado;
        MODELO.DEUDA oDeuda;
        MODELO.RECIBO oRecibo;
        List<MODELO.DEUDA> listaDeudas;
        string rutaProyecto;

        public FrmCOBRAR(MODELO.AFILIADO miAFILIADO)
        {
            InitializeComponent();
            oAfiliado = miAFILIADO;
            //Obtiene las controladoras
            cAFILIADOS = CONTROLADORA.cAFILIADOS.Obtener_Instancia();
            cFACTURACION = CONTROLADORA.cFACTURACION.Obtener_Instancia();
            //Crea una lista de deudas para guardar las deudas seleccionadas
            listaDeudas = new List<MODELO.DEUDA>();
            //Autocompleta los datos del afiliado
            txtNombre_Afiliado.Text = oAfiliado.Nombre;
            mtxtDNI_Afiliado.Text = oAfiliado.DNI.ToString();
            //Ruta de la carpeta del proyecto: [...]/SISTEMA/
            rutaProyecto = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 15);

            ARMA_GRILLA();
        }

        public void ARMA_GRILLA()
        {
            //Obtiene las deudas del afilado
            DgvTotalDeudas.DataSource = cAFILIADOS.Obtener_Deudas(oAfiliado.Id_Afiliado);
            DgvTotalDeudas.Columns[0].Visible = false;
            DgvTotalDeudas.Columns[5].Visible = false;
            //Guardas las deudas seleccionadas en la grilla
            DgvDeudasSeleccionadas.DataSource = listaDeudas.ToList();
            DgvDeudasSeleccionadas.Columns[0].Visible = false;
            DgvDeudasSeleccionadas.Columns[5].Visible = false;
        }

        private void DgvTotalDeudas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oDeuda = (MODELO.DEUDA)DgvTotalDeudas.CurrentRow.DataBoundItem;
            if (listaDeudas.Find(x => x.Id == oDeuda.Id) == null)
            {
                //Agrega la deuda a la lista y actualiza el total a pagar
                listaDeudas.Add(oDeuda);
                txt_Total_a_pagar.Text = Convert.ToString(Convert.ToDecimal(txt_Total_a_pagar.Text) + oDeuda.Monto);
            }
            ARMA_GRILLA();
        }

        private void DgvDeudasSeleccionadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oDeuda = (MODELO.DEUDA)DgvDeudasSeleccionadas.CurrentRow.DataBoundItem;
            if (listaDeudas.Find(x => x.Id == oDeuda.Id) != null)
            {
                //Quita la deuda seleccionada y actualiza el total a pagar
                listaDeudas.Remove(oDeuda);
                txt_Total_a_pagar.Text = Convert.ToString(Convert.ToDecimal(txt_Total_a_pagar.Text) - oDeuda.Monto);
            }
            ARMA_GRILLA();
        }

        private void CREAR_RECIBO()
        {
            if(DgvDeudasSeleccionadas.RowCount <= 0)
            {
                MessageBox.Show("Debe seleccionar al menos una deuda.");
                return;
            }

            //Crea la lista
            ListaDeudasAPagar lista = new ListaDeudasAPagar();
            //Obtiene la cantidad de deudas seleccionadas
            int filas = DgvDeudasSeleccionadas.Rows.Count;
            //Crea el recibo
            oRecibo = new MODELO.RECIBO();
            decimal total = 0;
            for (int i = 0; i <= filas - 1; i++)
            {
                //Acumula el total a pagar
                total += Convert.ToDecimal(DgvDeudasSeleccionadas[3, i].Value);
            }
            //Crea los recibos uno por uno
            for (int i = 0; i <= filas - 1; i++)
            {
                //Obtiene la deduda
                oDeuda = (MODELO.DEUDA)DgvDeudasSeleccionadas.Rows[i].DataBoundItem;
                oDeuda.Pagada = true;
                //Modifica la deuda pagada
                cAFILIADOS.modificar_deuda(oDeuda);
                //Crea el detalle y le agrega Recibo y Deuda
                cFACTURACION.AgregarDetalle(oRecibo, oDeuda);
                //Crea objeto para Crystal Report
                lista.Tables[0].Rows.Add
                (new object[] {
                    DgvDeudasSeleccionadas[0, i].Value.ToString(),
                    DgvDeudasSeleccionadas[1, i].Value.ToString(),
                    DgvDeudasSeleccionadas[2, i].Value.ToString(),
                    DgvDeudasSeleccionadas[3, i].Value.ToString(),
                    DgvDeudasSeleccionadas[4, i].Value.ToString(),
                    DgvDeudasSeleccionadas[5, i].Value.ToString(),
                    total
                });
            }

            //----ESTO ES PARA CREAR EL REPORTE PDF----//
            ReportDocument oRep = new ReportDocument();
            oRep.Load(rutaProyecto+"VISTA/Recibo.rpt");
            oRep.SetDataSource(lista);
            crystalReportViewer1.ReportSource = oRep;
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.PrintReport();
            listaDeudas.Clear();

            //Completa los datos del Recibo
            oRecibo.Importe = total;
            oRecibo.Fecha = DateTime.Today;
            oRecibo.Nro_Recibo = oRecibo.Id_Recibo + 100;
            oRecibo.AFILIADO = oAfiliado;
            //Guarda el Recibo
            cFACTURACION.AgregarRecibo(oRecibo);

            ARMA_GRILLA();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            CREAR_RECIBO();
        }

    }
}
