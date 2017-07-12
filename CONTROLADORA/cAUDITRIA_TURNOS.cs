using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cAUDITRIA_TURNOS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cAUDITRIA_TURNOS instancia;
        public static cAUDITRIA_TURNOS Obtener_instancia()
        {
            if (instancia == null)
                instancia = new cAUDITRIA_TURNOS();

            return instancia;
        }

        public cAUDITRIA_TURNOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }
        
        public void AUDITAR_TURNO (MODELO.Auditoria_Turnos oAUDITORIA_TURNO)
        {
            oCATALOGO.Auditoria_Turnos.Add(oAUDITORIA_TURNO);
            oCATALOGO.SaveChanges();
        }
        
    }

    
}
