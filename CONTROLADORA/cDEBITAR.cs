using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cDEBITAR
    {
        MODELO.CATALOGO oCATALOGO;
        private static cDEBITAR Instancia;

        public static cDEBITAR Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cDEBITAR();

            return Instancia;
        }

        private cDEBITAR()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }
    }
}
