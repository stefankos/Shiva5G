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
    
    public partial class TGSERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGSERVICE()
        {
            this.CARRIEDTRAFFICDETAILs = new HashSet<CARRIEDTRAFFICDETAIL>();
            this.SERVICECARRIERs = new HashSet<SERVICECARRIER>();
            this.SRVCELLBITPRIORs = new HashSet<SRVCELLBITPRIOR>();
            this.SRVCELLPRIORs = new HashSet<SRVCELLPRIOR>();
            this.TGSERVICEMBSFNs = new HashSet<TGSERVICEMBSFN>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal SERVICEKEY { get; set; }
        public string IDNAME { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> CIRPACK { get; set; }
        public Nullable<decimal> USESOFTHO { get; set; }
        public Nullable<decimal> USESUPPHO { get; set; }
        public Nullable<decimal> MNPKTSZUL { get; set; }
        public Nullable<decimal> MNPKTSZDL { get; set; }
        public Nullable<decimal> MNCALLUL { get; set; }
        public Nullable<decimal> MNCALLDL { get; set; }
        public Nullable<decimal> MNREADUL { get; set; }
        public Nullable<decimal> MNREADDL { get; set; }
        public Nullable<decimal> MNPKTCLUL { get; set; }
        public Nullable<decimal> MNPKTCLDL { get; set; }
        public Nullable<decimal> MNPKTARUL { get; set; }
        public Nullable<decimal> MNPKTARDL { get; set; }
        public Nullable<decimal> MNSTODL { get; set; }
        public Nullable<decimal> RETRANSUL { get; set; }
        public Nullable<decimal> RETRANSDL { get; set; }
        public Nullable<decimal> BLERUL { get; set; }
        public Nullable<decimal> BLERDL { get; set; }
        public Nullable<decimal> MNBITUL { get; set; }
        public Nullable<decimal> MNBITDL { get; set; }
        public Nullable<decimal> TOUL { get; set; }
        public Nullable<decimal> TODL { get; set; }
        public Nullable<decimal> PRICSTRAF { get; set; }
        public Nullable<decimal> NETTYPE { get; set; }
        public Nullable<decimal> TRAFFICCLS { get; set; }
        public Nullable<decimal> INTPKTARRTIMDL { get; set; }
        public Nullable<decimal> INTPKTARRTIMUL { get; set; }
        public Nullable<decimal> ALPHA { get; set; }
        public Nullable<decimal> K { get; set; }
        public Nullable<decimal> M { get; set; }
        public Nullable<decimal> CSACTUL { get; set; }
        public Nullable<decimal> CSACTDL { get; set; }
        public Nullable<decimal> IGNORPRI { get; set; }
        public Nullable<decimal> RC0DLCHECK { get; set; }
        public Nullable<decimal> RC0DLPRIORITY { get; set; }
        public Nullable<decimal> RC1DLCHECK { get; set; }
        public Nullable<decimal> RC1DLPRIORITY { get; set; }
        public Nullable<decimal> RC2DLCHECK { get; set; }
        public Nullable<decimal> RC2DLPRIORITY { get; set; }
        public Nullable<decimal> RC3DLCHECK { get; set; }
        public Nullable<decimal> RC3DLPRIORITY { get; set; }
        public Nullable<decimal> RC4DLCHECK { get; set; }
        public Nullable<decimal> RC4DLPRIORITY { get; set; }
        public Nullable<decimal> RC5DLCHECK { get; set; }
        public Nullable<decimal> RC5DLPRIORITY { get; set; }
        public Nullable<decimal> RC6DLCHECK { get; set; }
        public Nullable<decimal> RC6DLPRIORITY { get; set; }
        public Nullable<decimal> RC7DLCHECK { get; set; }
        public Nullable<decimal> RC7DLPRIORITY { get; set; }
        public Nullable<decimal> RC8DLCHECK { get; set; }
        public Nullable<decimal> RC8DLPRIORITY { get; set; }
        public Nullable<decimal> RC9DLCHECK { get; set; }
        public Nullable<decimal> RC9DLPRIORITY { get; set; }
        public Nullable<decimal> PRECEDENCECLASS { get; set; }
        public Nullable<decimal> MAXNUMRETRANSDL { get; set; }
        public decimal OVERRIDEACT { get; set; }
        public Nullable<decimal> ULUSRBTR { get; set; }
        public Nullable<decimal> DLUSRBTR { get; set; }
        public decimal ULSERVICERATE { get; set; }
        public decimal DLSERVICERATE { get; set; }
        public decimal SERVICEPRIORITY { get; set; }
        public Nullable<decimal> REVENUE { get; set; }
        public decimal USECQITABLES { get; set; }
        public decimal DLMINDATARATE { get; set; }
        public decimal MACPOWEROFFSET { get; set; }
        public Nullable<decimal> ISREALTIME { get; set; }
        public Nullable<decimal> SESSIONTIME_RT_UL { get; set; }
        public Nullable<decimal> SESSIONTIME_RT_DL { get; set; }
        public Nullable<decimal> PEAKRATE_RT_UL_BPS { get; set; }
        public Nullable<decimal> PEAKRATE_RT_DL_BPS { get; set; }
        public Nullable<decimal> OVERHEAD_RT_UL_PERCENT { get; set; }
        public Nullable<decimal> OVERHEAD_RT_DL_PERCENT { get; set; }
        public Nullable<decimal> RATEPROB_RT_UL_FULL { get; set; }
        public Nullable<decimal> RATEPROB_RT_DL_FULL { get; set; }
        public Nullable<decimal> RATEPROB_RT_UL_HALF { get; set; }
        public Nullable<decimal> RATEPROB_RT_DL_HALF { get; set; }
        public Nullable<decimal> RATEPROB_RT_UL_QTR { get; set; }
        public Nullable<decimal> RATEPROB_RT_DL_QTR { get; set; }
        public Nullable<decimal> RATEPROB_RT_UL_EIGHTH { get; set; }
        public Nullable<decimal> RATEPROB_RT_DL_EIGHTH { get; set; }
        public Nullable<decimal> PKT_RT_UL_FULL_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_DL_FULL_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_UL_HALF_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_DL_HALF_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_UL_QTR_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_DL_QTR_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_UL_EIGHTH_BYTES { get; set; }
        public Nullable<decimal> PKT_RT_DL_EIGHTH_BYTES { get; set; }
        public Nullable<decimal> DELAY { get; set; }
        public Nullable<decimal> PELR { get; set; }
        public Nullable<decimal> QCI { get; set; }
        public Nullable<decimal> GTBITRATEDL { get; set; }
        public Nullable<decimal> GTBITRATEUL { get; set; }
        public Nullable<decimal> MXBITRATEDL { get; set; }
        public Nullable<decimal> MXBITRATEUL { get; set; }
        public Nullable<decimal> ISDEFAULT { get; set; }
        public decimal BEARER_SELECTION_MODE { get; set; }
        public Nullable<decimal> WIFI_DL_SVC_RATE { get; set; }
        public Nullable<decimal> WIFI_SUPPORT { get; set; }
        public Nullable<decimal> WIFI_UL_SVC_RATE { get; set; }
        public decimal BWALLOCATIONMODEUL { get; set; }
        public Nullable<decimal> TTIBUNDLINGULOVERHEAD { get; set; }
        public Nullable<decimal> TTIBUNDLINGULGAIN { get; set; }
        public decimal TTIBUNDLINGULENABLED { get; set; }
        public Nullable<decimal> TTIBUNDLINGDLOVERHEAD { get; set; }
        public Nullable<decimal> TTIBUNDLINGDLGAIN { get; set; }
        public decimal TTIBUNDLINGDLENABLED { get; set; }
        public decimal LOADBALANCING { get; set; }
        public Nullable<decimal> LTETRAFFICCLS { get; set; }
        public decimal DLGSMSERVICERATE { get; set; }
        public Nullable<decimal> MBSFNOVERHEAD { get; set; }
        public Nullable<decimal> MBSFNENABLED { get; set; }
        public Nullable<decimal> MBSFNRATE { get; set; }
        public decimal REQUIRE_LICENSED_LTECARRIER { get; set; }
        public decimal BEARER_SELECTION_MODE5G { get; set; }
        public decimal BWALLOCATIONMODEUL5G { get; set; }
        public Nullable<decimal> DELAY5G { get; set; }
        public Nullable<decimal> GTBITRATEDL5G { get; set; }
        public Nullable<decimal> GTBITRATEUL5G { get; set; }
        public Nullable<decimal> ISREALTIME5G { get; set; }
        public decimal LOADBALANCING5G { get; set; }
        public Nullable<decimal> MXBITRATEDL5G { get; set; }
        public Nullable<decimal> MXBITRATEUL5G { get; set; }
        public Nullable<decimal> OVERHEAD_RT_DL_PERCENT5G { get; set; }
        public Nullable<decimal> OVERHEAD_RT_UL_PERCENT5G { get; set; }
        public Nullable<decimal> PELR5G { get; set; }
        public Nullable<decimal> QCI5G { get; set; }
        public decimal REQUIRE_LICENSED_5GCARRIER { get; set; }
        public Nullable<decimal> TRAFFICCLS5G { get; set; }
        public decimal TTIBUNDLINGDLENABLED5G { get; set; }
        public Nullable<decimal> TTIBUNDLINGDLGAIN5G { get; set; }
        public Nullable<decimal> TTIBUNDLINGDLOVERHEAD5G { get; set; }
        public decimal TTIBUNDLINGULENABLED5G { get; set; }
        public Nullable<decimal> TTIBUNDLINGULGAIN5G { get; set; }
        public Nullable<decimal> TTIBUNDLINGULOVERHEAD5G { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRIEDTRAFFICDETAIL> CARRIEDTRAFFICDETAILs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICECARRIER> SERVICECARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SRVCELLBITPRIOR> SRVCELLBITPRIORs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SRVCELLPRIOR> SRVCELLPRIORs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TGSERVICEMBSFN> TGSERVICEMBSFNs { get; set; }
    }
}
