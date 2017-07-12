using MODELO.Identificadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class FACTURA : Documento
    {
        public int IDEstadoFactura
        {
            get
            {
                return this.IdEstadoFactura;
            }
            set
            {
                IdEstadoFactura = value;

                if (value == EstadoFactura.Entregado)
                {
                    ActualizaStock();
                }
            }
        }

        public override Detalle NuevoDetalle()
        {
            return new DETALLE_FACTURA();
        }

        public override void AgregarDetalle(Detalle det)
        {
            var deta = det as MODELO.DETALLE_FACTURA;
            this.DETALLE_FACTURA.Add(deta);
        }

        private void ActualizaStock()
        {
            foreach (DETALLE_FACTURA det in DETALLE_FACTURA)
            {
                det.PRODUCTO.ActualizaStock(det.Cantidad);
            }
        }
    }
}

