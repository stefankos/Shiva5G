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
    
    public partial class GENREPEATERFEEDER
    {
        public decimal REPEATERFEEDERPK { get; set; }
        public decimal REPEATERFK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal FEEDERFK { get; set; }
        public decimal MASTHEADAMPFK { get; set; }
        public decimal OBJECTTYPE { get; set; }
        public decimal FEEDERTYPE { get; set; }
        public Nullable<decimal> MHAGAIN_DB { get; set; }
        public Nullable<decimal> TXDIVERSITY { get; set; }
        public Nullable<decimal> RXDIVERSITY { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> OUTPUTPOWER { get; set; }
        public Nullable<decimal> RXSIGNAL { get; set; }
        public Nullable<byte> RXSIGNALSPECIFIED { get; set; }
        public Nullable<decimal> FEEDERLENGTH { get; set; }
        public decimal LOGANTENNAFK { get; set; }
        public decimal SITEADDRESSFK { get; set; }
        public Nullable<decimal> RXTHRESHOLD { get; set; }
        public Nullable<decimal> RXTHRESHOLDENABLED { get; set; }
    
        public virtual GENREPEATER GENREPEATER { get; set; }
        public virtual LOGICALANTENNA LOGICALANTENNA { get; set; }
        public virtual SITEADDRESS SITEADDRESS { get; set; }
    }
}
