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
    
    public partial class DIFFMSC
    {
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal LOGNODEPK { get; set; }
        public decimal DLOGNODEPK { get; set; }
        public Nullable<decimal> GNDHEIGHT { get; set; }
        public Nullable<decimal> DGNDHEIGHT { get; set; }
        public string PHOTOFILE { get; set; }
        public string DPHOTOFILE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public string FLAGVALUE { get; set; }
        public string DFLAGVALUE { get; set; }
        public Nullable<decimal> SRCHRAD { get; set; }
        public Nullable<decimal> DSRCHRAD { get; set; }
        public Nullable<decimal> DIRECTKEY { get; set; }
        public Nullable<decimal> DDIRECTKEY { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal DLOGNODETYPEFK { get; set; }
    
        public virtual DIFFLOGNODE DIFFLOGNODE { get; set; }
    }
}
