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
    
    public partial class TGCLUTTERPARAM
    {
        public decimal PROJECTNO { get; set; }
        public decimal SCHEMAKEY { get; set; }
        public decimal PARAMSKEY { get; set; }
        public string CLUTTERNAME { get; set; }
        public Nullable<decimal> FADEIND { get; set; }
        public Nullable<decimal> FADEOUT { get; set; }
        public Nullable<decimal> ORTHLOSS { get; set; }
        public Nullable<decimal> ANGULARSPREAD { get; set; }
        public Nullable<decimal> ULSDSINRADJ { get; set; }
        public Nullable<decimal> DLSDSINRADJ { get; set; }
        public Nullable<decimal> DLSMRATEGAIN { get; set; }
        public Nullable<decimal> DLSMEBNOADJ { get; set; }
        public Nullable<decimal> DLSDEBNOADJ { get; set; }
        public Nullable<decimal> ULSDEBNOADJ { get; set; }
        public Nullable<decimal> ULSMRATEGAIN { get; set; }
        public Nullable<decimal> ULSMSINROFFSET { get; set; }
        public Nullable<decimal> DLSMSINROFFSET { get; set; }
        public Nullable<decimal> ULMUMIMOSINROFFSET { get; set; }
        public Nullable<decimal> DLMUMIMOSINROFFSET { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual TGCLUTTERPARAMSSCHEMA TGCLUTTERPARAMSSCHEMA { get; set; }
    }
}
