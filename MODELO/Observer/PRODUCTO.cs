using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class PRODUCTO : IProducto
    {
        public void ActualizaStock(int cant)
        {
            Stock -= cant;
        }
    }
}
