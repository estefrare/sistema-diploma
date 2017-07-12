using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cSERVICIOS
    {
        MODELO.CATALOGO oCATALOGO;

        private static cSERVICIOS instancia;

        public static cSERVICIOS Obtener_Instancia()
        {
            if (instancia == null)
                instancia = new cSERVICIOS();
            return instancia;
        }

        private cSERVICIOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Servicio(MODELO.SERVICIO oServicio)
        {
            oCATALOGO.SERVICIOS.Add(oServicio);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Servicio(MODELO.SERVICIO oServicio)
        {
            oCATALOGO.Entry(oServicio).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Eliminar_Sservicio(MODELO.SERVICIO oServicio)
        {
            oCATALOGO.SERVICIOS.Remove(oServicio);
            oCATALOGO.SaveChanges();
        }
        public List<MODELO.SERVICIO> Obtener_Servicios()
        {
            return oCATALOGO.SERVICIOS.ToList();
        }

        public List<MODELO.PLAN> Obtener_Planes()
        {
            return oCATALOGO.PLANES.ToList();
        }

        public List<MODELO.SERVICIO> Obtener_Servicio(string NOMBRE)
        {
            var lista = from servicios in oCATALOGO.SERVICIOS
                        where servicios.Nombre.Contains(NOMBRE)
                        select servicios;

            return (List<MODELO.SERVICIO>)lista.ToList();
        }


    }
}
