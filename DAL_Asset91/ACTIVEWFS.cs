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
    
    public partial class ACTIVEWFS
    {
        public decimal PROJECTNO { get; set; }
        public decimal FILTERFK { get; set; }
        public decimal RULEFK { get; set; }
        public decimal WFSSERVICEFK { get; set; }
        public string WFSFEATURE { get; set; }
        public string WFSATTRIB { get; set; }
        public decimal ATTRIBTYPE { get; set; }
        public decimal WFSRULETYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public string QUERYXML { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual FILTERS FILTERS { get; set; }
        public virtual RULES RULES { get; set; }
    }
}
