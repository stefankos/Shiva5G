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
    
    public partial class VHMASK
    {
        public decimal PROJECTNO { get; set; }
        public decimal DEVICEFK { get; set; }
        public decimal PATTERNFK { get; set; }
        public decimal MASKPK { get; set; }
        public string MASK { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
    
        public virtual ANTENNAPATTERN ANTENNAPATTERN { get; set; }
    }
}
