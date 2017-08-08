using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    interface IProducto
    {
        void ActualizaStock(int cant, string accion);
    }
}
