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
    
    public partial class CARLAYDATA
    {
        public decimal PROJECTNO { get; set; }
        public decimal CELLKEY { get; set; }
        public decimal CELLAYKEY { get; set; }
        public decimal CARLAYKEY { get; set; }
        public Nullable<decimal> REQUIRED { get; set; }
        public Nullable<decimal> TRXREQUIRED { get; set; }
        public Nullable<decimal> MAXCARRIERS { get; set; }
        public Nullable<decimal> TYPE { get; set; }
        public string CHANNELTYPE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public string TRXIDS { get; set; }
        public decimal CELLAYDATAFK { get; set; }
    
        public virtual CARLAY CARLAY { get; set; }
        public virtual GSMCELL GSMCELL { get; set; }
        public virtual CELLAY CELLAY { get; set; }
        public virtual CELLAYDATA CELLAYDATA { get; set; }
    }
}
