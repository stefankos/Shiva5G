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
    
    public partial class PRIORGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRIORGROUP()
        {
            this.PRIORUSERLICCONFIGs = new HashSet<PRIORUSERLICCONFIG>();
            this.PRIORUSERPRIVEXes = new HashSet<PRIORUSERPRIVEX>();
            this.PRIORUSERs = new HashSet<PRIORUSER>();
        }
    
        public decimal GRPKEY { get; set; }
        public string GRP { get; set; }
        public string GRPCOM { get; set; }
        public decimal DISTRPREDPRIORITY { get; set; }
        public decimal DISTRPREDENABLED { get; set; }
        public decimal DISTRPREDUNLIMAGENTS { get; set; }
        public decimal DISTRPREDAGENTLIMIT { get; set; }
        public decimal LICUSERESTRICTED { get; set; }
        public decimal LICCOMMUTERESTRICTED { get; set; }
        public decimal LICGRPHASCONFIG { get; set; }
        public decimal DISTRCOVAGENTLIMIT { get; set; }
        public decimal DISTRCOVENABLED { get; set; }
        public decimal DISTRCOVPRIORITY { get; set; }
        public decimal DISTRCOVUNLIMAGENTS { get; set; }
        public decimal LICALLOWUSEROVERRIDE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIORUSERLICCONFIG> PRIORUSERLICCONFIGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIORUSERPRIVEX> PRIORUSERPRIVEXes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIORUSER> PRIORUSERs { get; set; }
    }
}
