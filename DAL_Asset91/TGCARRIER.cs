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
    
    public partial class TGCARRIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGCARRIER()
        {
            this.LOGUMTSCAR = new HashSet<LOGUMTSCAR>();
            this.TGCARRIERADJ = new HashSet<TGCARRIERADJ>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal CARRIERKEY { get; set; }
        public string IDNAME { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> UPLINKCH { get; set; }
        public Nullable<decimal> DOWNLINKCH { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> ATTENUATION_DL { get; set; }
        public Nullable<decimal> ATTENUATION_UL { get; set; }
        public Nullable<decimal> FREQ_HI_DL { get; set; }
        public Nullable<decimal> FREQ_HI_UL { get; set; }
        public Nullable<decimal> FREQ_LO_DL { get; set; }
        public Nullable<decimal> FREQ_LO_UL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGUMTSCAR> LOGUMTSCAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGCARRIERADJ> TGCARRIERADJ { get; set; }
    }
}
