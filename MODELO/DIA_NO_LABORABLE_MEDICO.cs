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
    
    public partial class DIA_NO_LABORABLE_MEDICO
    {
        public int Id_Dia { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Motivo { get; set; }
    
        public virtual MEDICO MEDICO { get; set; }
    }
}