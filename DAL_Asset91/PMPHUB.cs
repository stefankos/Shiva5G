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
    
    public partial class PMPHUB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMPHUB()
        {
            this.PMPHUBLINKEND = new HashSet<PMPHUBLINKEND>();
            this.PMPSECTOR = new HashSet<PMPSECTOR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public string IDNAME { get; set; }
        public decimal PMPHUBKEY { get; set; }
        public decimal SITEADDRKEY { get; set; }
        public Nullable<decimal> ISTEMPLATE { get; set; }
        public string NAME1 { get; set; }
        public string NAME2 { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> VISIBILITY { get; set; }
        public Nullable<decimal> VISIBILITYGROUP { get; set; }
    
        public virtual SITEADDRESS SITEADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMPHUBLINKEND> PMPHUBLINKEND { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMPSECTOR> PMPSECTOR { get; set; }
    }
}
