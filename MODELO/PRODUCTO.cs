//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.DETALLE_RECIBO_COMPRA = new HashSet<DETALLE_RECIBO_COMPRA>();
        }
    
        public int Codigo_Producto { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Stock_Minimo { get; set; }
    
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual ICollection<DETALLE_RECIBO_COMPRA> DETALLE_RECIBO_COMPRA { get; set; }
    }
}
