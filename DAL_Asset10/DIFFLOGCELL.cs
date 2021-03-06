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
    
    public partial class DIFFLOGCELL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIFFLOGCELL()
        {
            this.DIFFFIVEGCELLPARAMS = new HashSet<DIFFFIVEGCELLPARAM>();
            this.DIFFGSMCELLs = new HashSet<DIFFGSMCELL>();
            this.DIFFLOGIS95SECTOR = new HashSet<DIFFLOGIS95SECTOR>();
            this.DIFFLOGLTECELLs = new HashSet<DIFFLOGLTECELL>();
            this.DIFFLOGUMTSCELLs = new HashSet<DIFFLOGUMTSCELL>();
            this.DIFFLOGWIFICELLs = new HashSet<DIFFLOGWIFICELL>();
        }
    
        public decimal LOGCELLPK { get; set; }
        public decimal DLOGCELLPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal LOGNODEFK { get; set; }
        public decimal DLOGNODEFK { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal DLOGNODETYPEFK { get; set; }
        public string IDNAME { get; set; }
        public string DIDNAME { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DCREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<System.DateTime> DMODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public Nullable<decimal> DVISIBILITY { get; set; }
        public Nullable<decimal> DVISIBILITYGROUP { get; set; }
        public Nullable<decimal> VISIBILITY { get; set; }
        public Nullable<decimal> VISIBILITYGROUP { get; set; }
        public decimal ADDRESSFK { get; set; }
        public decimal DADDRESSFK { get; set; }
        public decimal ACTIVETECHNOLOGY { get; set; }
        public decimal DACTIVETECHNOLOGY { get; set; }
        public decimal DSUBTYPEFK { get; set; }
        public decimal DSUPPORTEDTECHNOLOGYDATA { get; set; }
        public decimal SUBTYPEFK { get; set; }
        public decimal SUPPORTEDTECHNOLOGYDATA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFFIVEGCELLPARAM> DIFFFIVEGCELLPARAMS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFGSMCELL> DIFFGSMCELLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFLOGIS95SECTOR> DIFFLOGIS95SECTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFLOGLTECELL> DIFFLOGLTECELLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFLOGUMTSCELL> DIFFLOGUMTSCELLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFLOGWIFICELL> DIFFLOGWIFICELLs { get; set; }
    }
}
