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
    
    public partial class CIOBJENTRY
    {
        public decimal PROJECTNO { get; set; }
        public decimal CIOBJKEY { get; set; }
        public Nullable<decimal> CIOBJECTIVE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal FREQSEP { get; set; }
    
        public virtual CIOBJ CIOBJ { get; set; }
    }
}
