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
    
    public partial class LTEEICICABSPATTERN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LTEEICICABSPATTERN()
        {
            this.LOGLTECELLCARs = new HashSet<LOGLTECELLCAR>();
            this.LOGLTECELLCARs1 = new HashSet<LOGLTECELLCAR>();
            this.LOGLTECELLCARs2 = new HashSet<LOGLTECELLCAR>();
            this.LOGLTECELLCARs3 = new HashSet<LOGLTECELLCAR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal PATTERN_PK { get; set; }
        public string PATTERNNAME { get; set; }
        public string PATTERNMASK { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCAR> LOGLTECELLCARs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCAR> LOGLTECELLCARs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCAR> LOGLTECELLCARs2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCAR> LOGLTECELLCARs3 { get; set; }
    }
}
