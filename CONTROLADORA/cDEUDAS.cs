using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    class cDEUDAS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cDEUDAS Instancia;

        public static cDEUDAS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cDEUDAS();

            return Instancia;
        }

        private cDEUDAS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Deuda(MODELO.DEUDA oDeuda)
        {
            oCATALOGO.DEUDAS.Add(oDeuda);
            oCATALOGO.SaveChanges();
        }


        public List<MODELO.DEUDA> Obtener_Deudas(int id)
        {
            var lista = from deudas in oCATALOGO.DEUDAS
                        where deudas.AFILIADO.Id_Afiliado == id && deudas.Pagada == false
                        select deudas;

            return (List<MODELO.DEUDA>)lista.ToList();
        }

        public List<MODELO.DEUDA> Obtener_Deudas()
        {
            return oCATALOGO.DEUDAS.ToList();
        }

        public void modificar_deuda(MODELO.DEUDA oDeuda)
        {
            oCATALOGO.Entry(oDeuda).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public System.Collections.IEnumerable chequear_deuda(MODELO.DEUDA oDeuda)
        {
            var lista = from deuda in oCATALOGO.DEUDAS
                        where deuda.Mes == oDeuda.Mes && deuda.Año == oDeuda.Año && deuda.AFILIADO == oDeuda.AFILIADO
                        select deuda;

            return lista.ToList();
        }

    }
}
