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
    
    public partial class PMPSECTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMPSECTOR()
        {
            this.PMPCARRIERs = new HashSet<PMPCARRIER>();
            this.SECTORANTENNAs = new HashSet<SECTORANTENNA>();
        }
    
        public decimal PROJECTNO { get; set; }
        public string IDNAME { get; set; }
        public decimal PMPSECTORKEY { get; set; }
        public decimal PMPHUBKEY { get; set; }
        public Nullable<decimal> RANGEMTR { get; set; }
        public string NAME1 { get; set; }
        public string NAME2 { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> OVERRIDEBW { get; set; }
        public Nullable<decimal> OVERRIDDENBWDEG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMPCARRIER> PMPCARRIERs { get; set; }
        public virtual PMPHUB PMPHUB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECTORANTENNA> SECTORANTENNAs { get; set; }
    }
}
