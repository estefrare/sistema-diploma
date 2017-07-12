using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cAFILIADOS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cAFILIADOS Instancia;

        public static cAFILIADOS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cAFILIADOS();

            return Instancia;
        }

        private cAFILIADOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();      
        }

        public void Agregar_Afiliado(MODELO.AFILIADO oAfiliado)
        {
            oCATALOGO.AFILIADOS.Add(oAfiliado);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Afiliado(MODELO.AFILIADO oAfiliado)
        {
            oCATALOGO.Entry(oAfiliado).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Agregar_Tarjeta (MODELO.TARJETA oTarjeta)
        {
            oCATALOGO.TARJETAS.Add(oTarjeta);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Tarjeta(MODELO.TARJETA oTarjeta)
        {
            oCATALOGO.Entry(oTarjeta).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Agregar_Servicio(MODELO.SERVICIO oServicio)
        {
            oCATALOGO.SERVICIOS.Add(oServicio);
            oCATALOGO.SaveChanges();
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

        public System.Collections.IEnumerable chequear_deuda (MODELO.DEUDA oDeuda)
        {
            var lista = from deuda in oCATALOGO.DEUDAS
                        where deuda.Mes == oDeuda.Mes && deuda.Año == oDeuda.Año && deuda.AFILIADO == oDeuda.AFILIADO
                        select deuda;

            return lista.ToList();
        }

        public List<MODELO.PLAN> Obtener_Planes()
        {
            return oCATALOGO.PLANES.ToList();
        }

        public List<MODELO.AFILIADO> Obtener_Afiliados()
        {
            return oCATALOGO.AFILIADOS.ToList();
        }

        public MODELO.AFILIADO Obtener_Afiliados(Int32 CODIGO)
        {
            return oCATALOGO.AFILIADOS.Find(CODIGO);
        }

        public List<MODELO.AFILIADO> Obtener_Afiliado(string NOMBRE)
        {
            var lista = from afiliados in oCATALOGO.AFILIADOS
                        where afiliados.Nombre.Contains(NOMBRE)
                        select afiliados;

            return (List<MODELO.AFILIADO>)lista.ToList();
        }

        public System.Collections.IEnumerable Obtener_Afiliados(string NOMBRE, bool debito, bool INACTIVOS)
        {
            var afiliados = from afiliado in oCATALOGO.AFILIADOS.ToList()
                            where afiliado.Nombre.Contains(NOMBRE)
                            select new { ID_AFILIADO = afiliado.Id_Afiliado, AFILIADO = afiliado.Nombre, DNI = afiliado.DNI, NACIMIENTO = afiliado.Fecha_Nacimiento, ESTADO = afiliado.Estado, PAGO = afiliado.Forma_Pago, CONTRATO = afiliado.Numero_Contrato };

            if (INACTIVOS == false)
            {
                afiliados = afiliados.Where(gr => gr.ESTADO == true);
            }

            if (debito)
            {
                afiliados = afiliados.Where(x => x.PAGO == "Debito Automático");
            }

            return afiliados.ToList();
        }


    }
}
