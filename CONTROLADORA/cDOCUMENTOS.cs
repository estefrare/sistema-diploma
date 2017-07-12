using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    abstract class cDOCUMENTOS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cDOCUMENTOS Instancia;

        private cDOCUMENTOS()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        
    }
}
