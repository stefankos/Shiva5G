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
    
    public partial class BACKTOBACKANTENNA
    {
        public decimal PROJECTNO { get; set; }
        public decimal BACKTOBACKANTENNA_PK { get; set; }
        public decimal PRLINKFK { get; set; }
        public decimal LINKFK { get; set; }
        public decimal PRLINKEND_FK { get; set; }
        public Nullable<decimal> MWANTENNA_FK { get; set; }
        public Nullable<decimal> ANTENNAHEIGHT { get; set; }
        public Nullable<decimal> TILT { get; set; }
        public Nullable<decimal> DRYRADOMELOSS { get; set; }
        public Nullable<decimal> WETRADOMELOSS { get; set; }
        public Nullable<decimal> OVERRIDEACTELEV { get; set; }
        public Nullable<decimal> USERACTELEV { get; set; }
        public Nullable<decimal> OVERRIDEANTDIR { get; set; }
        public Nullable<decimal> USERANTDIR { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> COORDTYPE { get; set; }
        public Nullable<decimal> ACTUALELEVATION { get; set; }
        public Nullable<decimal> DIRECTION { get; set; }
    
        public virtual PRLINKEND PRLINKEND { get; set; }
        public virtual LINK LINK { get; set; }
        public virtual PRLLINK PRLLINK { get; set; }
    }
}
