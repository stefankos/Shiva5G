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
    
    public partial class DIFFLOGATTACHMENT
    {
        public decimal ATTACHPK { get; set; }
        public decimal DATTACHPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal PARENTTYPE { get; set; }
        public decimal DPARENTTYPE { get; set; }
        public string FILENAME { get; set; }
        public string DFILENAME { get; set; }
        public string COMMENTS { get; set; }
        public string DCOMMENTS { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal PARENTKEY { get; set; }
        public decimal DPARENTKEY { get; set; }
    }
}
