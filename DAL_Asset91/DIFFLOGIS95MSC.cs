//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIFFLOGIS95MSC
    {
        public decimal LOGNODEPK { get; set; }
        public decimal DLOGNODEPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public Nullable<decimal> SUPPORTS_SHO { get; set; }
        public Nullable<decimal> DSUPPORTS_SHO { get; set; }
        public Nullable<decimal> NEEDSBSC { get; set; }
        public Nullable<decimal> DNEEDSBSC { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal DLOGNODETYPEFK { get; set; }
    
        public virtual DIFFLOGNODE DIFFLOGNODE { get; set; }
    }
}
