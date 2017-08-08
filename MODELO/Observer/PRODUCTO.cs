using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class PRODUCTO : IProducto
    {
        public void ActualizaStock(int cant, string accion)
        {
            if(accion == "INCREMENTAR")
            {
                Stock += cant;
            }
            else
            {
                Stock -= cant;
            }
            
        }
    }
}
