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
    
    public partial class LOGWIFICELL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGWIFICELL()
        {
            this.LOGWIFICELLCARs = new HashSet<LOGWIFICELLCAR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal LOGCELLFK { get; set; }
        public Nullable<decimal> CELLID { get; set; }
        public Nullable<decimal> SIGNALLINGOVERHEAD { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> ACTIVATION { get; set; }
        public Nullable<decimal> CELLOVERRIDECOLORREF { get; set; }
        public decimal CELLPARAMSPK { get; set; }
        public string CRANGROUP { get; set; }
        public decimal CSAREA { get; set; }
        public decimal CSRANGE { get; set; }
        public decimal INDOORSCHEMAFK { get; set; }
        public string SECNAME { get; set; }
    
        public virtual LOGCELL LOGCELL { get; set; }
        public virtual TGCLUTTERLOSSSCHEMA TGCLUTTERLOSSSCHEMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIFICELLCAR> LOGWIFICELLCARs { get; set; }
    }
}
