using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPRODUCTOS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cPRODUCTOS Instancia;

        public static cPRODUCTOS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cPRODUCTOS();

            return Instancia;
        }
        private cPRODUCTOS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCATALOGO.PRODUCTOS.Add(oProducto);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCATALOGO.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.PRODUCTO> Obtener_Productos(string TEXTO, bool STOCK)
        {
            var productos = from producto in oCATALOGO.PRODUCTOS.ToList()
                            where producto.Descripcion.ToLower().Contains(TEXTO.ToLower()) || producto.Marca.ToLower().Contains(TEXTO.ToLower())
                            select producto;
            if (STOCK == false)
            {
                productos = productos.Where(gr => gr.Stock != 0);
            }

            return productos.ToList();
        }

        public MODELO.PRODUCTO BuscarProducto(int cod)
        {
            return oCATALOGO.PRODUCTOS.Find(cod);
        }
    }
}
