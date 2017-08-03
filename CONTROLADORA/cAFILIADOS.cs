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
        CONTROLADORA.cDEUDAS cDEUDAS;
        CONTROLADORA.cTARJETAS cTARJETAS;
        CONTROLADORA.cPLANES cPLANES;
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
            cDEUDAS = CONTROLADORA.cDEUDAS.Obtener_Instancia();
            cTARJETAS = CONTROLADORA.cTARJETAS.Obtener_Instancia();
            cPLANES = CONTROLADORA.cPLANES.obtener_instancia();
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
            cTARJETAS.Agregar_Tarjeta(oTarjeta);
        }

        public void Modificar_Tarjeta(MODELO.TARJETA oTarjeta)
        {
            cTARJETAS.Modificar_Tarjeta(oTarjeta);
        }

        public void Agregar_Servicio(MODELO.SERVICIO oServicio)
        {
            oCATALOGO.SERVICIOS.Add(oServicio);
            oCATALOGO.SaveChanges();
        }

        public void Agregar_Deuda(MODELO.DEUDA oDeuda)
        {
            cDEUDAS.Agregar_Deuda(oDeuda);
        }

        
        public List<MODELO.DEUDA> Obtener_Deudas(int id)
        {
            return cDEUDAS.Obtener_Deudas(id);
        }

        public List<MODELO.DEUDA> Obtener_Deudas()
        {
            return cDEUDAS.Obtener_Deudas();
        }

        public void modificar_deuda(MODELO.DEUDA oDeuda)
        {
            cDEUDAS.modificar_deuda(oDeuda);
        }

        public System.Collections.IEnumerable chequear_deuda (MODELO.DEUDA oDeuda)
        {
            return chequear_deuda(oDeuda);
        }

        public List<MODELO.PLAN> Obtener_Planes()
        {
            return cPLANES.Obtener_Planes();
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
