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
    
    public partial class UPG_810_LOGNODE_RENAME
    {
        public decimal PROJECTNO { get; set; }
        public decimal LOGNODEPK { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal LOGNETWORKFK { get; set; }
        public decimal ADDRESSFK { get; set; }
        public string IDNAME { get; set; }
        public string NAME { get; set; }
        public string NAME2 { get; set; }
        public string USERCOMMENT { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> HASCONSTRAINTS { get; set; }
        public Nullable<decimal> CONSTRFLAGS { get; set; }
        public Nullable<decimal> MINSECTORS { get; set; }
        public Nullable<decimal> MAXSECTORS { get; set; }
        public Nullable<decimal> NETWORKLEVEL { get; set; }
        public Nullable<decimal> SIGNALLINGOVERHEAD { get; set; }
    }
}
