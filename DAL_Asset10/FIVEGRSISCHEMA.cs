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
    
    public partial class FIVEGRSISCHEMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIVEGRSISCHEMA()
        {
            this.FIVEGCELLCARs = new HashSet<FIVEGCELLCAR>();
            this.FIVEGRSIINDICES = new HashSet<FIVEGRSIINDICE>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal SCHEMAKEY_PK { get; set; }
        public string IDNAME { get; set; }
        public decimal NETWORK_TYPE { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public bool ISSHORTFORMAT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIVEGCELLCAR> FIVEGCELLCARs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIVEGRSIINDICE> FIVEGRSIINDICES { get; set; }
    }
}