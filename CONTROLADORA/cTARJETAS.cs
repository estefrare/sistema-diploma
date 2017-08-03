using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    class cTARJETAS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cTARJETAS Instancia;

        public static cTARJETAS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cTARJETAS();

            return Instancia;
        }

        private cTARJETAS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Tarjeta(MODELO.TARJETA oTarjeta)
        {
            oCATALOGO.TARJETAS.Add(oTarjeta);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Tarjeta(MODELO.TARJETA oTarjeta)
        {
            oCATALOGO.Entry(oTarjeta).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }
    }
}
