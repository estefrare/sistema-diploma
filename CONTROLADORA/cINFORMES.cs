using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
   public class cINFORME
    {
        MODELO.CATALOGO oCATALOGO;

        private static cINFORME Instancia;

        public static cINFORME Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cINFORME();

            return Instancia;
        }

        private cINFORME()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public DataTable Obtener_Informes(string busqueda)
        {
            int anulados = 0, concurridos = 0;
            CONTROLADORA.cMEDICOS cMEDICOS = CONTROLADORA.cMEDICOS.Obtener_Instancia();
            List<MODELO.MEDICO> Lista_Medicos;

            DataTable Tabla_Informe = new DataTable();
            Tabla_Informe.Columns.Add("Medico", typeof(string));
            Tabla_Informe.Columns.Add("Anulados", typeof(string));
            Tabla_Informe.Columns.Add("Concurridos", typeof(string));
            Tabla_Informe.Columns.Add("Total", typeof(string));

            if(!string.IsNullOrEmpty(busqueda))
            {
                Lista_Medicos = cMEDICOS.Obtener_Medico(busqueda);
            }
            else
            {
                Lista_Medicos = oCATALOGO.MEDICOS.ToList();
            }
             
            for (int j = 0; j < Lista_Medicos.Count; j++)
            {
                string nombre = Lista_Medicos[j].Nombre;

                var listaturnos = from turno in oCATALOGO.TURNOS
                                  where turno.MEDICO.Nombre == nombre && turno.Estado != "Libre"
                                  select turno;

                List<MODELO.TURNO> turnos;
                turnos = (List<MODELO.TURNO>)listaturnos.ToList();

                int total_turnos = listaturnos.Count();

                for (int k = 0; k < total_turnos; k++)
                {
                    if (turnos[k].Estado == "Anulado")
                        anulados += 1;
                    if (turnos[k].Concurrio)
                        concurridos += 1;
                }

                Tabla_Informe.Rows.Add(nombre, anulados, concurridos, total_turnos);
                anulados = 0;
                concurridos = 0;
            }
            return Tabla_Informe;
        }
    }
}
