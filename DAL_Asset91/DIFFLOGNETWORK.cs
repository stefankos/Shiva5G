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
    
    public partial class DIFFLOGNETWORK
    {
        public decimal PROJECTNO { get; set; }
        public Nullable<decimal> DPROJECTNO { get; set; }
        public decimal LOGNETWORKPK { get; set; }
        public decimal DLOGNETWORKPK { get; set; }
        public Nullable<decimal> NETWORKTYPEFK { get; set; }
        public Nullable<decimal> DNETWORKTYPEFK { get; set; }
        public decimal PARENTFK { get; set; }
        public decimal DPARENTFK { get; set; }
        public string USERCOMMENT { get; set; }
        public string DUSERCOMMENT { get; set; }
        public string IDNAME { get; set; }
        public string DIDNAME { get; set; }
        public string SUBNETID { get; set; }
        public string DSUBNETID { get; set; }
        public string MECONTEXTID { get; set; }
        public string DMECONTEXTID { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> DCREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<decimal> DUSERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DCREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<System.DateTime> DMODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> DPERMISSION { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public Nullable<decimal> DVISIBILITY { get; set; }
        public Nullable<decimal> DVISIBILITYGROUP { get; set; }
        public Nullable<decimal> VISIBILITY { get; set; }
        public Nullable<decimal> VISIBILITYGROUP { get; set; }
    
        public virtual DIFFLOGPLMN DIFFLOGPLMN { get; set; }
    }
}
