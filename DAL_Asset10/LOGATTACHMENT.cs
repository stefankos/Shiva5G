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
    
    public partial class LOGATTACHMENT
    {
        public decimal ATTACHPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal PARENTKEY { get; set; }
        public decimal PARENTTYPE { get; set; }
        public string FILENAME { get; set; }
        public string COMMENTS { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual LOGNODE LOGNODE { get; set; }
    }
}
