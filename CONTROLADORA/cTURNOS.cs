    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cTURNOS
    {
        MODELO.CATALOGO oCATALOGO;
        MODELO.MEDICO oMedico;
        MODELO.DATOS_EMPRESA oDatos_Empresa;
        private static cTURNOS Instancia;
        public static cTURNOS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cTURNOS();

            return Instancia;
        }

        private cTURNOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Turno(MODELO.TURNO oTurno)
        {
            oCATALOGO.TURNOS.Add(oTurno);
            oCATALOGO.SaveChanges();
        }

        public void Anular_Turno(MODELO.TURNO oTurno)
        {
            oTurno.Estado = "Anulado";
            Modificar_Turno(oTurno);
        }

        public void Modificar_Turno(MODELO.TURNO oTurno)
        {
            oCATALOGO.Entry(oTurno).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public List<DateTime> Armar_Calendario(MODELO.MEDICO MEDICO, DateTime Fecha)
        {
            oMedico = MEDICO;
            List<DateTime> Fechas = new List<DateTime>();
            List<MODELO.DIAS_NO_LABORABLES> oDiasNoLaborables = obtener_diasnolaborables();
            oMedico.DIA_NO_LABORABLE_MEDICO = Obtener_Dias_No_Labotables_Medico(oMedico);           
            oMedico.HORARIO_MEDICO = Obtener_Horas_Medicos(oMedico);
            oDatos_Empresa = new MODELO.DATOS_EMPRESA();
            oDatos_Empresa.DIAS_EMPRESA = obtener_diasempresa();
            for (int x = 0; x <= oDiasNoLaborables.Count - 1; x++)
            {
                if (oDiasNoLaborables.ElementAt(x).Fecha.Month == Fecha.Month)
                    Fechas.Add(oDiasNoLaborables.ElementAt(x).Fecha);
            }
            for (int x = 0; x <= oMedico.DIA_NO_LABORABLE_MEDICO.Count - 1; x++)
            {
                if (oMedico.DIA_NO_LABORABLE_MEDICO.ElementAt(x).Fecha.Month == Fecha.Month)
                    Fechas.Add(oMedico.DIA_NO_LABORABLE_MEDICO.ElementAt(x).Fecha);
            }
            for (int i = 1; i <= DateTime.DaysInMonth(Fecha.Year, Fecha.Month); i++)
            {
                DateTime FechaMes = Convert.ToDateTime(i + "/" + Fecha.Month + "/" + Fecha.Year);
                List<MODELO.HORARIO_MEDICO> horariomedico = Obtener_Horas_Medicos(oMedico);
                List<MODELO.DIAS_EMPRESA> diasempresa = obtener_diasempresa();
                if (!diasempresa.Exists(x => x.Dia == ObtenerDiaDeLaSemana(FechaMes)))
                {
                    Fechas.Add(FechaMes);
                }
                else   
                if (!horariomedico.Exists(x => x.Dia == ObtenerDiaDeLaSemana(FechaMes)))
                    {
                        Fechas.Add(FechaMes);
                    }
            }
            return Fechas;
        }

        public List<MODELO.TURNO> Buscar_Turnos(DateTime Fechaa, MODELO.MEDICO MEDICO)
        {
            oMedico = MEDICO;
            List<MODELO.TURNO> oListaTurnos = new List<MODELO.TURNO>();
            List<MODELO.HORARIO_MEDICO> oHorarioMedico = Obtener_Horas_Medicos(oMedico);
            int TurnosMaximos;
            string DiaSeleccionado = ObtenerDiaDeLaSemana(Fechaa);
            string Hora_Inicio = Convert.ToString(oHorarioMedico.First(x => x.Dia == DiaSeleccionado).Hora_Inicio);
            string Hora_Fin = Convert.ToString(oHorarioMedico.First(x => x.Dia == DiaSeleccionado).Hora_Fin);
            Hora_Inicio = Convert.ToString(Hora_Inicio.ElementAt(0)) + Convert.ToString(Hora_Inicio.ElementAt(1)) + Convert.ToString(Hora_Inicio.ElementAt(3)) + Convert.ToString(Hora_Inicio.ElementAt(4));
            Hora_Fin = Convert.ToString(Hora_Fin.ElementAt(0)) + Convert.ToString(Hora_Fin.ElementAt(1)) + Convert.ToString(Hora_Fin.ElementAt(3)) + Convert.ToString(Hora_Fin.ElementAt(4));
            TurnosMaximos = Convert.ToInt32(Hora_Fin) - Convert.ToInt32(Hora_Inicio);
            TurnosMaximos = (TurnosMaximos / 100) * 60;
            TurnosMaximos = TurnosMaximos / oMedico.Tiempo_Por_Paciente;
            string Fecha = Fechaa.ToString();
            Fecha = Fecha.Remove(10);
            Fecha = Fecha + " " + oHorarioMedico.First(x => x.Dia == DiaSeleccionado).Hora_Inicio;
            //------Prototype-------//
            MODELO.TURNO oTurno;
            oTurno = new MODELO.TURNO();
            oTurno.Fecha = Convert.ToDateTime(Fecha);
            oTurno.Estado = "Libre";
            //----------------------//
            for (int x = 0; x <= TurnosMaximos; x++)
            {
                oTurno.Estado = "Libre";
                List<MODELO.TURNO> oListaTurnosRegistrados = CONTROLADORA.cTURNOS.Obtener_Instancia().Recuperar_Turnos(Convert.ToDateTime(Fecha), oMedico.Nombre);
                if (oListaTurnosRegistrados.Exists(y => y.Fecha == oTurno.Fecha && y.Estado != "Anulado"))
                {
                    oListaTurnos.Add(oListaTurnosRegistrados.First(y => y.Fecha == oTurno.Fecha && y.Estado != "Anulado"));
                }
                else
                {
                    oListaTurnos.Add(oTurno);
                }
                oTurno = (MODELO.TURNO)oTurno.Clone();  //ACA LO CLONA
                oTurno.Fecha = oTurno.Fecha.AddMinutes(oMedico.Tiempo_Por_Paciente); //PASA AL HORARIO SIGUIENTE
                Fecha = oTurno.Fecha.ToString();
            }
            return oListaTurnos;
        }

        public List<MODELO.TURNO> Recuperar_Turnos(DateTime Fecha, string NombreMedico)
        {
                var listaturnos = from turno in oCATALOGO.TURNOS
                                  where turno.Fecha == Fecha && turno.MEDICO.Nombre == NombreMedico
                                  select turno;

                return (List<MODELO.TURNO>)listaturnos.ToList();
        }
        private static string ObtenerDiaDeLaSemana(DateTime Fechaa)
        {
            string DiaSeleccionado;
            if (Fechaa.DayOfWeek == DayOfWeek.Sunday)
            {
                DiaSeleccionado = "Domingo";
            }
            else if (Fechaa.DayOfWeek == DayOfWeek.Monday)
            {
                DiaSeleccionado = "Lunes";
            }
            else if (Fechaa.DayOfWeek == DayOfWeek.Tuesday)
            {
                DiaSeleccionado = "Martes";
            }
            else if (Fechaa.DayOfWeek == DayOfWeek.Wednesday)
            {
                DiaSeleccionado = "Miercoles";
            }
            else if (Fechaa.DayOfWeek == DayOfWeek.Thursday)
            {
                DiaSeleccionado = "Jueves";
            }
            else if (Fechaa.DayOfWeek == DayOfWeek.Friday)
            {
                DiaSeleccionado = "Viernes";
            }
            else DiaSeleccionado = "Sabado";
            return DiaSeleccionado;
        }

        public List<MODELO.DIAS_EMPRESA> obtener_diasempresa()
        {
            return oCATALOGO.DIAS_EMPRESAS.ToList();
        }

        public List<MODELO.DIAS_NO_LABORABLES> obtener_diasnolaborables()
        {
            return oCATALOGO.DIAS_NO_LABORABLESS.ToList();
        }

        public List<MODELO.DIA_NO_LABORABLE_MEDICO> Obtener_Dias_No_Labotables_Medico(MODELO.MEDICO MEDICO)
        {          
                var lista = from dias in oCATALOGO.DIAS_NO_LABORABLES_MEDICOS
                            where dias.MEDICO.DNI == MEDICO.DNI
                            select dias;

                return (List<MODELO.DIA_NO_LABORABLE_MEDICO>)lista.ToList();
        }

        public List<MODELO.HORARIO_MEDICO> Obtener_Horas_Medicos(MODELO.MEDICO MEDICO)
        {
            var lista = from horas in oCATALOGO.HORARIOS_MEDICOS
                        where horas.MEDICO.DNI == MEDICO.DNI
                        select horas;

            return (List<MODELO.HORARIO_MEDICO>)lista.ToList();
        }
    }
}
