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
    
    public partial class GRIDCONFIG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRIDCONFIG()
        {
            this.GRIDCONFIGCELLS = new HashSet<GRIDCONFIGCELLS>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal CONFIGPK { get; set; }
        public decimal OBJECTFK { get; set; }
        public decimal OBJECTTYPEFK { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual LOGNODE LOGNODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRIDCONFIGCELLS> GRIDCONFIGCELLS { get; set; }
    }
}
