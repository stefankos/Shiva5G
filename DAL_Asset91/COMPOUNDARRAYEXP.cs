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
    
    public partial class COMPOUNDARRAYEXP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPOUNDARRAYEXP()
        {
            this.COMPOUNDARRAYTERM = new HashSet<COMPOUNDARRAYTERM>();
        }
    
        public decimal COMPOUNDARRAYEXPKEY { get; set; }
        public decimal PARENTKEY { get; set; }
        public decimal PROJECTNO { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public string LOTSRCINTNLNAME { get; set; }
        public string LOFSRCINTNLNAME { get; set; }
        public string LOTSRCDISPNAME { get; set; }
        public string LOFSRCDISPNAME { get; set; }
        public string LOTARRGENRCNAME { get; set; }
        public string LOFARRGENRCNAME { get; set; }
        public string LOTARRDISPNAME { get; set; }
        public string LOFARRDISPNAME { get; set; }
        public string LOTINSTINTNLNAME { get; set; }
        public string LOFINSTINTNLNAME { get; set; }
        public string LOTINSTDISPNAME { get; set; }
        public string LOFINSTDISPNAME { get; set; }
        public string RESERVED1 { get; set; }
        public string RESERVED2 { get; set; }
        public Nullable<decimal> RESERVED3 { get; set; }
        public Nullable<decimal> RESERVED4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPOUNDARRAYTERM> COMPOUNDARRAYTERM { get; set; }
    }
}
