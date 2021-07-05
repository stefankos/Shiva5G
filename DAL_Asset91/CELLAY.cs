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
    
    public partial class CELLAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CELLAY()
        {
            this.CARLAYDATA = new HashSet<CARLAYDATA>();
            this.CARRIERS = new HashSet<CARRIERS>();
            this.CELLAYDATA = new HashSet<CELLAYDATA>();
            this.CLDANTENNA = new HashSet<CLDANTENNA>();
            this.SRVCELLBITPRIOR = new HashSet<SRVCELLBITPRIOR>();
            this.SRVCELLPRIOR = new HashSet<SRVCELLPRIOR>();
            this.CELLAYCARLAY = new HashSet<CELLAYCARLAY>();
            this.TERMTYCELLAY = new HashSet<TERMTYCELLAY>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal CELLAYKEY { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> IWEIGHT { get; set; }
        public Nullable<decimal> CCMAP { get; set; }
        public Nullable<decimal> SUPERLAYER { get; set; }
        public Nullable<decimal> CAOFFSET { get; set; }
        public Nullable<decimal> MEANCI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARLAYDATA> CARLAYDATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRIERS> CARRIERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CELLAYDATA> CELLAYDATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLDANTENNA> CLDANTENNA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SRVCELLBITPRIOR> SRVCELLBITPRIOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SRVCELLPRIOR> SRVCELLPRIOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CELLAYCARLAY> CELLAYCARLAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYCELLAY> TERMTYCELLAY { get; set; }
    }
}
