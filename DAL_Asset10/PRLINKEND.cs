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
    
    public partial class PRLINKEND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRLINKEND()
        {
            this.BACKTOBACKANTENNAs = new HashSet<BACKTOBACKANTENNA>();
            this.REFLECTORs = new HashSet<REFLECTOR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal PRLINKEND_PK { get; set; }
        public decimal PRLINKFK { get; set; }
        public decimal LINKFK { get; set; }
        public Nullable<decimal> SITEADDRESSFK { get; set; }
        public decimal LINKENDTYPE { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<decimal> WAVEGUIDELENGTH { get; set; }
        public Nullable<decimal> WAVEGUIDELOSSPERM { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> DISTANCETOSITEA { get; set; }
        public Nullable<decimal> DISTANCETOSITEB { get; set; }
        public Nullable<decimal> WAVEGUIDELOSS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKTOBACKANTENNA> BACKTOBACKANTENNAs { get; set; }
        public virtual LINK LINK { get; set; }
        public virtual PRLLINK PRLLINK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFLECTOR> REFLECTORs { get; set; }
    }
}
