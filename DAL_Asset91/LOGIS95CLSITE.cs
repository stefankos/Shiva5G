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
    
    public partial class LOGIS95CLSITE
    {
        public decimal PROJECTNO { get; set; }
        public decimal IS95BSPK { get; set; }
        public decimal IS95CLUSTERFK { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
    
        public virtual LOGIS95CLUSTER LOGIS95CLUSTER { get; set; }
        public virtual MUNODE MUNODE { get; set; }
    }
}
