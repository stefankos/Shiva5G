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
    
    public partial class LTEFRAME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LTEFRAME()
        {
            this.LTECARRIERs = new HashSet<LTECARRIER>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal FRAME_PK { get; set; }
        public string IDNAME { get; set; }
        public decimal DUPLEX_MODE { get; set; }
        public decimal CONFIGURATION { get; set; }
        public decimal CYCLIC_PREFIX { get; set; }
        public decimal SUBCARRIER_SPACING { get; set; }
        public decimal FRAME_DURATION { get; set; }
        public decimal NUM_SLOTS_PER_SUB_FRAME { get; set; }
        public decimal NUM_SUBFRAMES { get; set; }
        public decimal NUM_SYMBOLS_RB_DL { get; set; }
        public decimal NUM_SYMBOLS_RB_UL { get; set; }
        public decimal NUM_SUBCARS_RB_DL { get; set; }
        public decimal NUM_SUBCARS_RB_UL { get; set; }
        public decimal REF_SIG_SUBCARS { get; set; }
        public decimal TDD_FRAME_CONFIG { get; set; }
        public decimal TDD_SUBFRAMES_DL { get; set; }
        public decimal TDD_SUBFRAMES_UL { get; set; }
        public decimal TDD_SUBFRAMES_SP { get; set; }
        public string SUBFRAME_POSITION { get; set; }
        public decimal CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal USERGROUP { get; set; }
        public decimal PERMISSION { get; set; }
        public System.DateTime CREATEDATE { get; set; }
        public System.DateTime MODIFYDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LTECARRIER> LTECARRIERs { get; set; }
    }
}
