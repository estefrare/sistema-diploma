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
    
    public partial class RECIBO_COMPRA
    {
        public RECIBO_COMPRA()
        {
            this.DETALLE_RECIBO_COMPRA = new HashSet<DETALLE_RECIBO_COMPRA>();
        }
    
        public int Id_Recibo_Compra { get; set; }
        public decimal Importe { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Nro_Recibo_Compra { get; set; }
        public int IdEstadoReciboCompra { get; set; }
        public string Proveedor { get; set; }
    
        public virtual ICollection<DETALLE_RECIBO_COMPRA> DETALLE_RECIBO_COMPRA { get; set; }
    }
}