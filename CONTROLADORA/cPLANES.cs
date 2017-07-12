using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPLANES
    {
        MODELO.CATALOGO oCATALOGO;

        private static cPLANES instancia;

        public static cPLANES obtener_instancia()
        {
            if (instancia == null)
                instancia = new cPLANES();
            return instancia;
        }

        private cPLANES()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Plan(MODELO.PLAN oPlan)
        {
            oCATALOGO.PLANES.Add(oPlan);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Plan(MODELO.PLAN oPlan)
        {
            oCATALOGO.Entry(oPlan).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Eliminar_Plan(MODELO.PLAN oPlan)
        {
            oCATALOGO.PLANES.Remove(oPlan);
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.PLAN> Obtener_Planes()
        {
            return oCATALOGO.PLANES.ToList();
        }

        public List<MODELO.SERVICIO> Obtener_Servicios()
        {
            return oCATALOGO.SERVICIOS.ToList();
        }

        public List<MODELO.PLAN> Obtener_Plan(string NOMBRE)
        {
            var lista = from planes in oCATALOGO.PLANES
                        where planes.Nombre.Contains(NOMBRE)
                        select planes;

            return (List<MODELO.PLAN>)lista.ToList();
        }

        public List<MODELO.PLAN> Obtener_Planes(MODELO.PLAN oPLAN)
        {
            var lista = from plan in oCATALOGO.PLANES
                        select plan;

            return (List<MODELO.PLAN>)lista.ToList();
        }

    }
}
