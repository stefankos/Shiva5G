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
    
    public partial class LOGWIMAXMOBCELL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGWIMAXMOBCELL()
        {
            this.LOGWIMAXMOBCELLCAR = new HashSet<LOGWIMAXMOBCELLCAR>();
            this.LOGWIMAXMOBFEEDER = new HashSet<LOGWIMAXMOBFEEDER>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal LOGCELLPK { get; set; }
        public Nullable<decimal> CELLID { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<decimal> SIGNALLINGOVERHEAD { get; set; }
        public Nullable<decimal> LOGCELLTYPEFK { get; set; }
    
        public virtual LOGCELL LOGCELL { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIMAXMOBCELLCAR> LOGWIMAXMOBCELLCAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIMAXMOBFEEDER> LOGWIMAXMOBFEEDER { get; set; }
    }
}
