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
    
    public partial class LOGNODETYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGNODETYPE()
        {
            this.ACTIVEATTRIBs = new HashSet<ACTIVEATTRIB>();
            this.ACTIVEELEMENTS = new HashSet<ACTIVEELEMENT>();
            this.ACTIVEOBJECTS = new HashSet<ACTIVEOBJECT>();
            this.BSCs = new HashSet<BSC>();
            this.CARRIEDTRAFFICTOTALs = new HashSet<CARRIEDTRAFFICTOTAL>();
            this.DIFFSERVICECARRIERs = new HashSet<DIFFSERVICECARRIER>();
            this.DIFFTERMTYCARRIERs = new HashSet<DIFFTERMTYCARRIER>();
            this.DISTRIBUTIONs = new HashSet<DISTRIBUTION>();
            this.FLAGASSOCIATIONS = new HashSet<FLAGASSOCIATION>();
            this.FLAGVALUES = new HashSet<FLAGVALUE>();
            this.GENERICNBRs = new HashSet<GENERICNBR>();
            this.GENERICNBRs1 = new HashSet<GENERICNBR>();
            this.GENREPEATERs = new HashSet<GENREPEATER>();
            this.LOGCELLs = new HashSet<LOGCELL>();
            this.LOGCELLs1 = new HashSet<LOGCELL>();
            this.LOGCONNECTIONs = new HashSet<LOGCONNECTION>();
            this.LOGCONNECTIONs1 = new HashSet<LOGCONNECTION>();
            this.LOGIS95BSC = new HashSet<LOGIS95BSC>();
            this.LOGIS95MSC = new HashSet<LOGIS95MSC>();
            this.LOGMMEs = new HashSet<LOGMME>();
            this.LOGNETWORKs = new HashSet<LOGNETWORK>();
            this.LOGNODEs = new HashSet<LOGNODE>();
            this.LOGNODEs1 = new HashSet<LOGNODE>();
            this.LOGNODETRAFFICs = new HashSet<LOGNODETRAFFIC>();
            this.LOGRNCs = new HashSet<LOGRNC>();
            this.LOGSAEGWs = new HashSet<LOGSAEGW>();
            this.MSCs = new HashSet<MSC>();
            this.MUNODEs = new HashSet<MUNODE>();
            this.SCRIPTEVENTS = new HashSet<SCRIPTEVENT>();
            this.SERVICECARRIERs = new HashSet<SERVICECARRIER>();
            this.TERMTYCARRIERs = new HashSet<TERMTYCARRIER>();
        }
    
        public decimal LOGNODETYPEKEY { get; set; }
        public string DESCRIPTION { get; set; }
        public string FULLDESCRIPTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVEATTRIB> ACTIVEATTRIBs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVEELEMENT> ACTIVEELEMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVEOBJECT> ACTIVEOBJECTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSC> BSCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRIEDTRAFFICTOTAL> CARRIEDTRAFFICTOTALs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFSERVICECARRIER> DIFFSERVICECARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIFFTERMTYCARRIER> DIFFTERMTYCARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRIBUTION> DISTRIBUTIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAGASSOCIATION> FLAGASSOCIATIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLAGVALUE> FLAGVALUES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERICNBR> GENERICNBRs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERICNBR> GENERICNBRs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENREPEATER> GENREPEATERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGCELL> LOGCELLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGCELL> LOGCELLs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGCONNECTION> LOGCONNECTIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGCONNECTION> LOGCONNECTIONs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIS95BSC> LOGIS95BSC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIS95MSC> LOGIS95MSC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGMME> LOGMMEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGNETWORK> LOGNETWORKs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGNODE> LOGNODEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGNODE> LOGNODEs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGNODETRAFFIC> LOGNODETRAFFICs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGRNC> LOGRNCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGSAEGW> LOGSAEGWs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSC> MSCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUNODE> MUNODEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCRIPTEVENT> SCRIPTEVENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICECARRIER> SERVICECARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYCARRIER> TERMTYCARRIERs { get; set; }
    }
}