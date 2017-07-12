using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cDIASNOLABORABLESEMPRESA
    {
        MODELO.CATALOGO oCatalogo;

        private static cDIASNOLABORABLESEMPRESA instancia;
        public static cDIASNOLABORABLESEMPRESA obtener_instancia()
        {
            if (instancia == null)
                instancia = new cDIASNOLABORABLESEMPRESA();
            return instancia;
        }

        private cDIASNOLABORABLESEMPRESA()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }
    }
}
