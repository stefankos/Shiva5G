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
    
    public partial class DIFFDISTRIBUTION
    {
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal LOGNODEPK { get; set; }
        public decimal DLOGNODEPK { get; set; }
        public Nullable<decimal> GNDHEIGHT { get; set; }
        public Nullable<decimal> DGNDHEIGHT { get; set; }
        public string PHOTOFILE { get; set; }
        public string DPHOTOFILE { get; set; }
        public Nullable<decimal> HEXRADIUS { get; set; }
        public Nullable<decimal> DHEXRADIUS { get; set; }
        public Nullable<decimal> CABINKEY { get; set; }
        public Nullable<decimal> DCABINKEY { get; set; }
        public Nullable<decimal> BTSKEY { get; set; }
        public Nullable<decimal> DBTSKEY { get; set; }
        public Nullable<decimal> TOWERKEY { get; set; }
        public Nullable<decimal> DTOWERKEY { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public string FLAGVALUE { get; set; }
        public string DFLAGVALUE { get; set; }
        public Nullable<decimal> SRCHRAD { get; set; }
        public Nullable<decimal> DSRCHRAD { get; set; }
        public Nullable<decimal> BTSFIXED { get; set; }
        public Nullable<decimal> DBTSFIXED { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal DLOGNODETYPEFK { get; set; }
    
        public virtual DIFFLOGNODE DIFFLOGNODE { get; set; }
    }
}
