using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class Documento
    {
        public abstract Detalle NuevoDetalle();
        public abstract void AgregarDetalle(MODELO.Detalle det);
    }
}