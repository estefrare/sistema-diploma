using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    class cRECIBOS_COMPRA
    {
        MODELO.CATALOGO oCATALOGO;
        private static cRECIBOS_COMPRA Instancia;

        public static cRECIBOS_COMPRA Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cRECIBOS_COMPRA();

            return Instancia;
        }
        private cRECIBOS_COMPRA()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Recibo_Compra(MODELO.RECIBO_COMPRA oReciboCompra)
        {
            oCATALOGO.RECIBO_COMPRA.Add(oReciboCompra);
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.RECIBO_COMPRA> Obtener_RecibosCompra()
        {
            return oCATALOGO.RECIBO_COMPRA.ToList();
        }

        public void AgregarProducto(MODELO.RECIBO_COMPRA miReciboCompra, MODELO.PRODUCTO miProducto, int miCant)
        {
            MODELO.DETALLE_RECIBO_COMPRA respDetalle = (from detalle in miReciboCompra.DETALLE_RECIBO_COMPRA
                                                        where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                                  select detalle).SingleOrDefault();

            if (respDetalle == null)
            {
                //Implementacion del metodo factory
                var oDetalle = miReciboCompra.NuevoDetalle() as MODELO.DETALLE_RECIBO_COMPRA;
                oDetalle.PRODUCTO = miProducto;
                oDetalle.Cantidad = miCant;
                oDetalle.Precio = miProducto.Precio;
                miReciboCompra.AgregarDetalle(oDetalle);
            }
            else
            {
                respDetalle.Cantidad = respDetalle.Cantidad + miCant;
            }
        }

        public void EliminarProducto(MODELO.RECIBO_COMPRA miFactura, MODELO.PRODUCTO miProducto)
        {
            MODELO.DETALLE_RECIBO_COMPRA oDetalle = (from detalle in miFactura.DETALLE_RECIBO_COMPRA
                                                     where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                               select detalle).First();
            if (oDetalle.Cantidad > 1)
            {
                miFactura.DETALLE_RECIBO_COMPRA.Remove(oDetalle);
                oDetalle.Cantidad--;
                miFactura.AgregarDetalle(oDetalle);
            }
            miFactura.DETALLE_RECIBO_COMPRA.Remove(oDetalle);
        }
    }
}
