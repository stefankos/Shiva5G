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
    
    public partial class SECTORANTENNA
    {
        public decimal PROJECTNO { get; set; }
        public string IDNAME { get; set; }
        public decimal SECTORANTENNAKEY { get; set; }
        public decimal PMPSECTORKEY { get; set; }
        public Nullable<decimal> MWANTENNAKEY { get; set; }
        public Nullable<decimal> ANTENNAHEIGHT { get; set; }
        public Nullable<decimal> TILT { get; set; }
        public Nullable<decimal> DRYRADOMELOSS { get; set; }
        public Nullable<decimal> WETRADOMELOSS { get; set; }
        public Nullable<decimal> OVERRIDEACTELEV { get; set; }
        public Nullable<decimal> USERACTELEV { get; set; }
        public Nullable<decimal> OVERRIDEANTDIR { get; set; }
        public Nullable<decimal> USERANTDIR { get; set; }
        public Nullable<decimal> COORDTYPE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> OVERRIDEEIRP { get; set; }
        public Nullable<decimal> EIRP { get; set; }
        public Nullable<decimal> MAXEIRP { get; set; }
    
        public virtual PMPSECTOR PMPSECTOR { get; set; }
    }
}
