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
    
    public partial class LOGWIFIFEEDER
    {
        public decimal FEEDPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal WIFICELLFK { get; set; }
        public decimal FEEDERTYPEFK { get; set; }
        public decimal MHAMPTYPEFK { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> MHGAIN_DB { get; set; }
        public Nullable<decimal> LENGTH { get; set; }
        public Nullable<decimal> CORRFACTOR { get; set; }
        public decimal ADDRESSFK { get; set; }
        public decimal LOGANTENNAFK { get; set; }
    
        public virtual LOGICALANTENNA LOGICALANTENNA { get; set; }
        public virtual LOGWIFICELL LOGWIFICELL { get; set; }
        public virtual SITEADDRESS SITEADDRESS { get; set; }
    }
}
