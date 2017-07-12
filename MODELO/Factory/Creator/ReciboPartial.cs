using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class RECIBO : Documento
    {
        public override void AgregarDetalle(Detalle det)
        {
            var deta = det as MODELO.DETALLE_RECIBO;
            this.DETALLE_RECIBO.Add(deta);
        }

        public override Detalle NuevoDetalle()
        {
            return new DETALLE_RECIBO();
        }
    }
}

