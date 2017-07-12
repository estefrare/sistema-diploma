using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cAUDITORIA
    {
        MODELO.CATALOGO oCATALOGO;
        private static cAUDITORIA Instancia;
        public static cAUDITORIA Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cAUDITORIA();

            return Instancia;
        }

        private cAUDITORIA()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void AUDITAR (MODELO.AUDITORIA oAUDITORIA)
        {
            oCATALOGO.AUDITORIAs.Add(oAUDITORIA);
            oCATALOGO.SaveChanges();
        }

        public void MODIFICAR_AUDITORIA (MODELO.AUDITORIA oAUDITORIA)
        {
            oCATALOGO.Entry(oAUDITORIA).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }
        public MODELO.AUDITORIA BUSCAR_AUDITORIA (int CODIGO)
        {
            return oCATALOGO.AUDITORIAs.Find(CODIGO);
        } 
    }
}
