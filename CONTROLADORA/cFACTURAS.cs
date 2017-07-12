using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cFACTURAS
    {
        MODELO.CATALOGO oCATALOGO;
        private static cFACTURAS Instancia;

        public static cFACTURAS Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cFACTURAS();

            return Instancia;
        }
        private cFACTURAS()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Factura (MODELO.FACTURA oFactura)
        {
            oCATALOGO.FACTURAS.Add(oFactura);
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.FACTURA> Obtener_Facturas ()
        {
            return oCATALOGO.FACTURAS.ToList();
        }

        public void AgregarProducto(MODELO.FACTURA miFactura, MODELO.PRODUCTO miProducto, int miCant)
        {
            MODELO.DETALLE_FACTURA respDetalle = (from detalle in miFactura.DETALLE_FACTURA
                                                       where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                                       select detalle).SingleOrDefault();

            if (respDetalle == null)
            {
                //Implementacion del metodo factory
                var oDetalle = miFactura.NuevoDetalle() as MODELO.DETALLE_FACTURA;
                oDetalle.PRODUCTO = miProducto;
                oDetalle.Cantidad = miCant;
                oDetalle.Precio = miProducto.Precio;
                miFactura.AgregarDetalle(oDetalle);
            }
            else
            {
                respDetalle.Cantidad = respDetalle.Cantidad + miCant;
            }
        }

        public void EliminarProducto(MODELO.FACTURA miFactura, MODELO.PRODUCTO miProducto)
        {
            MODELO.DETALLE_FACTURA oDetalle = (from detalle in miFactura.DETALLE_FACTURA
                                               where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                               select detalle).First();
            if(oDetalle.Cantidad > 1)
            {
                miFactura.DETALLE_FACTURA.Remove(oDetalle);
                oDetalle.Cantidad--;
                miFactura.AgregarDetalle(oDetalle);
            }
            miFactura.DETALLE_FACTURA.Remove(oDetalle);
        }

    }
}
