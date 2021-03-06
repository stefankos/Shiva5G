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
    
    public partial class PHYANTENNA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHYANTENNA()
        {
            this.LOGICALANTENNAs = new HashSet<LOGICALANTENNA>();
            this.PHYANTENNAPORTs = new HashSet<PHYANTENNAPORT>();
        }
    
        public decimal PHYANTENNAPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public Nullable<decimal> ADDRESSFK { get; set; }
        public Nullable<decimal> DEVICEFK { get; set; }
        public Nullable<decimal> MASTERPATTERN1FK { get; set; }
        public Nullable<decimal> MASTERPATTERN2FK { get; set; }
        public Nullable<decimal> MASTERPATTERN3FK { get; set; }
        public Nullable<decimal> MASTERPATTERN4FK { get; set; }
        public Nullable<decimal> PHYINDEX { get; set; }
        public string INSTANCEID { get; set; }
        public Nullable<decimal> AZIMUTH { get; set; }
        public Nullable<decimal> TILT { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<decimal> SPATIALDIV { get; set; }
        public Nullable<decimal> RELATIVE { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> DEVICEFIXED { get; set; }
        public Nullable<decimal> AZIMUTHFIXED { get; set; }
        public Nullable<decimal> HEIGHTFIXED { get; set; }
        public Nullable<decimal> MECHDOWNFIXED { get; set; }
        public Nullable<decimal> MINMECHTILTFIXED { get; set; }
        public Nullable<decimal> MINMECHTILT { get; set; }
        public Nullable<decimal> MAXMECHTILTFIXED { get; set; }
        public Nullable<decimal> MAXMECHTILT { get; set; }
        public Nullable<decimal> MECHTILTSTEPFIXED { get; set; }
        public Nullable<decimal> MECHTILTSTEP { get; set; }
        public Nullable<decimal> USEFORBIDDEN { get; set; }
        public Nullable<decimal> MINFORBIDDENAZMTH { get; set; }
        public Nullable<decimal> MAXFORBIDDENAZMTH { get; set; }
        public Nullable<decimal> UPGRADEUNIT { get; set; }
        public string CUSTOM1 { get; set; }
        public string CUSTOM2 { get; set; }
        public string CUSTOM3 { get; set; }
        public Nullable<decimal> CUSTOM4 { get; set; }
        public Nullable<decimal> CUSTOM5 { get; set; }
        public Nullable<decimal> CUSTOM6 { get; set; }
        public Nullable<decimal> HEIGHTOFFSET { get; set; }
        public Nullable<decimal> MASTERPATTERN5FK { get; set; }
        public Nullable<decimal> MASTERPATTERN6FK { get; set; }
        public Nullable<decimal> MASTERPATTERN7FK { get; set; }
        public Nullable<decimal> MASTERPATTERN8FK { get; set; }
        public decimal AVAILSYNCRETGROUPS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGICALANTENNA> LOGICALANTENNAs { get; set; }
        public virtual SITEADDRESS SITEADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYANTENNAPORT> PHYANTENNAPORTs { get; set; }
    }
}
