using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class MEDICO
    {
        public override string ToString()
        {
            return this.Nombre;
        }
    }

    public partial class TURNO
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public partial class AFILIADO
    {
        public override string ToString()
        {
            return this.Nombre;
        }
    }

    public partial class PLAN
    {
        public override string ToString()
        {
            return this.Nombre;
        }
    }

    
}
