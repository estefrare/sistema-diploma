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
            this.DETALLE_RECIBO_COMPRA.Add(deta);
        }

        public override Detalle NuevoDetalle()
        {
            return new DETALLE_RECIBO_COMPRA();
        }
    }
}

