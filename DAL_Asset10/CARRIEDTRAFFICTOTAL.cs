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
    
    public partial class CARRIEDTRAFFICTOTAL
    {
        public decimal PROJECTNO { get; set; }
        public decimal CARTRAFTOTPK { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal PARENTFK { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> TECHNOLOGY { get; set; }
        public Nullable<decimal> CAPACITY { get; set; }
        public Nullable<decimal> SIGNALLING_OVERHEAD { get; set; }
        public Nullable<decimal> TERMINALCOUNT_PS { get; set; }
        public Nullable<bool> OVERRIDE_PS { get; set; }
        public Nullable<bool> PROTECTED_PS { get; set; }
        public Nullable<decimal> THROUGHPUTDL_PS { get; set; }
        public Nullable<decimal> THROUGHPUTUL_PS { get; set; }
        public Nullable<decimal> INTERHOTHROUGHPUTDL_PS { get; set; }
        public Nullable<decimal> INTERHOTHROUGHPUTUL_PS { get; set; }
        public Nullable<bool> OVERRIDE_CS { get; set; }
        public Nullable<bool> PROTECTED_CS { get; set; }
        public Nullable<decimal> THROUGHPUTDL_CS { get; set; }
        public Nullable<decimal> THROUGHPUTUL_CS { get; set; }
        public Nullable<decimal> INTERHOTHROUGHPUTDL_CS { get; set; }
        public Nullable<decimal> INTERHOTHROUGHPUTUL_CS { get; set; }
        public Nullable<decimal> TERMINALCOUNT_CS { get; set; }
    
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
    }
}
