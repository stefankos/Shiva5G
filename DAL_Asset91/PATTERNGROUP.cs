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
    
    public partial class PATTERNGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATTERNGROUP()
        {
            this.GROUPCARRIER = new HashSet<GROUPCARRIER>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal PATTERNKEY { get; set; }
        public decimal GROUPKEY { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GROUPCARRIER> GROUPCARRIER { get; set; }
        public virtual PATTERN PATTERN { get; set; }
    }
}