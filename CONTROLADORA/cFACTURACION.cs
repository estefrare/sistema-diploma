using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cFACTURACION
    {
        MODELO.CATALOGO oCATALOGO;
        private static cFACTURACION Instancia;
        public static cFACTURACION Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cFACTURACION();

            return Instancia;
        }

        private cFACTURACION()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void AgregarDetalle(MODELO.RECIBO miRecibo, MODELO.DEUDA miDeuda)
        {
            if (miRecibo.DETALLE_RECIBO.Count() == 0)
            {
                //Implementacion del metodo factory
                var oDetalle = miRecibo.NuevoDetalle() as MODELO.DETALLE_RECIBO;
                oDetalle.DEUDAS.Add(miDeuda);
                oDetalle.Importe = miDeuda.Monto;
                miRecibo.AgregarDetalle(oDetalle);
            }
            else
            {
                MODELO.DETALLE_RECIBO oDetalle_Recibo = miRecibo.DETALLE_RECIBO.First();
                miRecibo.DETALLE_RECIBO.Remove(oDetalle_Recibo);
                oDetalle_Recibo.DEUDAS.Add(miDeuda);
                oDetalle_Recibo.Importe += miDeuda.Monto;
                miRecibo.DETALLE_RECIBO.Add(oDetalle_Recibo);
            }
        }

        public void AgregarRecibo(MODELO.RECIBO oRecibo)
        {
            oCATALOGO.RECIBOS.Add(oRecibo);
            oCATALOGO.SaveChanges();
        }

    }
}