using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class RECIBO_COMPRA : Documento
    {
        public override void AgregarDetalle(Detalle det)
        {
            var deta = det as MODELO.DETALLE_RECIBO_COMPRA;
            ActualizaStock();
            this.DETALLE_RECIBO_COMPRA.Add(deta);
        }

        public override Detalle NuevoDetalle()
        {
            return new DETALLE_RECIBO_COMPRA();
        }

        private void ActualizaStock()
        {
            foreach (DETALLE_RECIBO_COMPRA det in DETALLE_RECIBO_COMPRA)
            {
                det.PRODUCTO.ActualizaStock(det.Cantidad, "INCREMENTAR");
            }
        }

    }
}

