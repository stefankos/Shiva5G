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
    
    public partial class SRVCELLBITPRIOR
    {
        public decimal PROJECTNO { get; set; }
        public decimal SERVICEKEY { get; set; }
        public decimal CELLAYKEY { get; set; }
        public decimal BITRATEKEY { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual CELLAY CELLAY { get; set; }
        public virtual TGSERVICE TGSERVICE { get; set; }
        public virtual TGBITRATE TGBITRATE { get; set; }
    }
}
