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
    
    public partial class DISTRIBUTION
    {
        public decimal PROJECTNO { get; set; }
        public decimal LOGNODEPK { get; set; }
        public Nullable<decimal> GNDHEIGHT { get; set; }
        public string PHOTOFILE { get; set; }
        public Nullable<decimal> HEXRADIUS { get; set; }
        public Nullable<decimal> CABINKEY { get; set; }
        public Nullable<decimal> BTSKEY { get; set; }
        public Nullable<decimal> TOWERKEY { get; set; }
        public decimal MODIFYUSER { get; set; }
        public string FLAGVALUE { get; set; }
        public Nullable<decimal> SRCHRAD { get; set; }
        public Nullable<decimal> BTSFIXED { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
    
        public virtual LOGNODE LOGNODE { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
    }
}
