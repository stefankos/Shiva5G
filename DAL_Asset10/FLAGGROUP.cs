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
    
    public partial class FLAGGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FLAGGROUP()
        {
            this.ACTIVEFLAGS = new HashSet<ACTIVEFLAG>();
            this.FLAGASSOCIATIONS = new HashSet<FLAGASSOCIATION>();
            this.FLAGS = new HashSet<FLAG>();
            this.FLAGVALUES = new HashSet<FLAGVALUE>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal FLAGGROUPKEY { get; set; }
        public string FLAGGROUPID { get; set; }
        public decimal FIELDTYPE { get; set; }
        public decimal FLAGGROUPLOCKED { get; set; }
        public decimal RESETONCLONING { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVEFLAG> ACTIVEFLAGS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAGASSOCIATION> FLAGASSOCIATIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAG> FLAGS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAGVALUE> FLAGVALUES { get; set; }
    }
}
