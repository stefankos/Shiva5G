//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_Asset10
{
    using System;
    using System.Collections.Generic;
    
    public partial class GENERICNBR
    {
        public decimal PROJECTNO { get; set; }
        public decimal PARENTKEY { get; set; }
        public decimal PARENTTYPEFK { get; set; }
        public decimal CELLCARRIERKEY { get; set; }
        public decimal NBRKEY { get; set; }
        public decimal NBRTYPEFK { get; set; }
        public decimal NBRCELLCARRIERKEY { get; set; }
        public Nullable<decimal> MARGIN { get; set; }
        public Nullable<decimal> DIRECTION { get; set; }
        public Nullable<decimal> HANDOVERTYPE { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> PROTECTED { get; set; }
        public Nullable<decimal> PLANNED_STATUS { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE1 { get; set; }
    }
}
