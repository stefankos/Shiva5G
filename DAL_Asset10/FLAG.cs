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
    
    public partial class FLAG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FLAG()
        {
            this.FLAGVALUES = new HashSet<FLAGVALUE>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal FLAGGROUPKEY { get; set; }
        public decimal FLAGKEY { get; set; }
        public decimal INDX { get; set; }
        public string FLAGID { get; set; }
    
        public virtual FLAGGROUP FLAGGROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAGVALUE> FLAGVALUES { get; set; }
    }
}