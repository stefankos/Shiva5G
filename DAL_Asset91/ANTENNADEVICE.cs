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
    
    public partial class ANTENNADEVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANTENNADEVICE()
        {
            this.ANTENNAPATTERN = new HashSet<ANTENNAPATTERN>();
            this.ANTENNAPORT = new HashSet<ANTENNAPORT>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal DEVICEPK { get; set; }
        public string IDNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string PHOTOFILE { get; set; }
        public string MANUFACTURER { get; set; }
        public Nullable<decimal> SUPPLIERKEY { get; set; }
        public Nullable<decimal> PARENTKEY { get; set; }
        public Nullable<decimal> NOELEMENTS { get; set; }
        public Nullable<decimal> ANTENNACATEGORY { get; set; }
        public Nullable<decimal> COST { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> DEPTH { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<decimal> WIDTH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANTENNAPATTERN> ANTENNAPATTERN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANTENNAPORT> ANTENNAPORT { get; set; }
    }
}
