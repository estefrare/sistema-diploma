using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cDATOSEMPRESA
    {
        MODELO.CATALOGO oCatalogo;

        private static cDATOSEMPRESA instancia;

        public static cDATOSEMPRESA obtener_instancia()
        {
            if (instancia == null)
                instancia = new cDATOSEMPRESA();
            return instancia;
        }

        private cDATOSEMPRESA()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public MODELO.DATOS_EMPRESA Obtener_DatosEmpresa()
        {
            return oCatalogo.DATOS_EMPRESAS.Find(1);
        }

        public void Agregar_DatosEmpresa(MODELO.DATOS_EMPRESA DATOS)
        {
            oCatalogo.DATOS_EMPRESAS.Add(DATOS);
            oCatalogo.SaveChanges();
        }

        public void Modificar_DatosEmpresa(MODELO.DATOS_EMPRESA DATOS)
        {
            oCatalogo.Entry(DATOS).State = System.Data.Entity.EntityState.Modified;
            oCatalogo.SaveChanges();
        }

        public void Eliminar_DiaEmpresa(MODELO.DIAS_EMPRESA DIA)
        {
            oCatalogo.DIAS_EMPRESAS.Remove(DIA);
            oCatalogo.SaveChanges();
        }

        public void Eliminar_DiaNoLaborable(MODELO.DIAS_NO_LABORABLES DIA)
        {
            oCatalogo.DIAS_NO_LABORABLESS.Remove(DIA);
            oCatalogo.SaveChanges();
        }

        public List<MODELO.DIAS_EMPRESA> Obtener_DiasEmpresa()
        {
            var lista = from dias in oCatalogo.DIAS_EMPRESAS
                        where dias.DATOS_EMPRESA.Id_Empresa == 1
                        select dias;

            return (List<MODELO.DIAS_EMPRESA>)lista.ToList();
        }

        public List<MODELO.DIAS_NO_LABORABLES> Obtener_DiasNoLaborables()
        {
            var lista = from dias in oCatalogo.DIAS_NO_LABORABLESS
                        where dias.DATOS_EMPRESA.Id_Empresa == 1
                        select dias;

            return (List<MODELO.DIAS_NO_LABORABLES>)lista.ToList();
        }
    }
}
