using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cMEDICOS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cMEDICOS Instancia;

        public static cMEDICOS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cMEDICOS();
            return Instancia;
        }

        private cMEDICOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Medico(MODELO.MEDICO oMedico)
        {
            oCATALOGO.MEDICOS.Add(oMedico);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Medico(MODELO.MEDICO oMedico)
        {
            oCATALOGO.Entry(oMedico).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Agregar_HorarioMedico(MODELO.HORARIO_MEDICO oHorarioMedico)
        {
            oCATALOGO.HORARIOS_MEDICOS.Add(oHorarioMedico);
            oCATALOGO.SaveChanges();
        }

        public void Eliminar_HorarioMedico(MODELO.HORARIO_MEDICO oHorarioMedico)
        {
            oCATALOGO.HORARIOS_MEDICOS.Remove(oHorarioMedico);
            oCATALOGO.SaveChanges();
        }

        public void Eliminar_DiaNoLaborableMedico(MODELO.DIA_NO_LABORABLE_MEDICO DIA)
        {
            oCATALOGO.DIAS_NO_LABORABLES_MEDICOS.Remove(DIA);
            oCATALOGO.SaveChanges();
        }

       /* public System.Collections.IEnumerable Obtener_Medicos(string NOMBRE, bool INACTIVOS)
        {
            var medicos = from medico in oCATALOGO.MEDICOS.ToList()
                          where medico.Nombre.Contains(NOMBRE)
                          select new { medico = medico.Id_Medico, nombre = medico.Nombre, ACTIVO = medico.Estado };

            if (INACTIVOS == false)
            {
                medicos = medicos.Where(gr => gr.ACTIVO == true);
            }
            return medicos.ToList();
        }*/

        public List<MODELO.MEDICO> Obtener_Medicos()
        {
            return oCATALOGO.MEDICOS.ToList();
        }

        public List<MODELO.MEDICO> Obtener_Medico(string NOMBRE)
        {
            var medicos = from medico in oCATALOGO.MEDICOS
                          where medico.Nombre.Contains(NOMBRE)
                          select medico;

            return (List<MODELO.MEDICO>)medicos.ToList();
        }


    }
}
