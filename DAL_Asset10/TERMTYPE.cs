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
    
    public partial class TERMTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TERMTYPE()
        {
            this.CARRIEDTRAFFICDETAILs = new HashSet<CARRIEDTRAFFICDETAIL>();
            this.TERMMOBSPEEDs = new HashSet<TERMMOBSPEED>();
            this.TERMTYCARRIERs = new HashSet<TERMTYCARRIER>();
            this.TERMTYCELLAYs = new HashSet<TERMTYCELLAY>();
            this.TERMTYCLUTTERs = new HashSet<TERMTYCLUTTER>();
            this.TERMTYPOLYGONs = new HashSet<TERMTYPOLYGON>();
            this.TERMTYVECTORs = new HashSet<TERMTYVECTOR>();
            this.TERMTYPEPOINTs = new HashSet<TERMTYPEPOINT>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal TERMTYPEKEY { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public Nullable<decimal> USEWEIGHTS { get; set; }
        public Nullable<decimal> MAXMOBPOWER { get; set; }
        public Nullable<decimal> DYNAMRANGE { get; set; }
        public Nullable<decimal> POWERSTEP { get; set; }
        public Nullable<decimal> REQECIO { get; set; }
        public Nullable<decimal> NOISEFIG { get; set; }
        public Nullable<decimal> BODYLOSS { get; set; }
        public Nullable<decimal> ANTENGAIN { get; set; }
        public Nullable<decimal> TERMWEIGHT { get; set; }
        public Nullable<decimal> SWITCHING { get; set; }
        public Nullable<decimal> MBHRATE { get; set; }
        public Nullable<decimal> MAXTIMESLOT { get; set; }
        public Nullable<decimal> HSCSDTRAFPERTERM { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT1 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT2 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT3 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT4 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT5 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT6 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT7 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTT8 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTNT1 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTNT2 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTNT3 { get; set; }
        public Nullable<decimal> HSCSDWEIGHTNT4 { get; set; }
        public Nullable<decimal> HSCSDTIMESLOTWEIGHTNT { get; set; }
        public Nullable<decimal> HSCSDTIMESLOTWEIGHTT1 { get; set; }
        public Nullable<decimal> HSCSDTIMESLOTWEIGHTT2 { get; set; }
        public Nullable<decimal> HSCSDTIMESLOTWEIGHTT3 { get; set; }
        public Nullable<decimal> HSCSDTIMESLOTWEIGHTT4 { get; set; }
        public Nullable<decimal> TWOGSNRDB { get; set; }
        public Nullable<decimal> TWOGRECVRSENSITIVITYDBM { get; set; }
        public Nullable<decimal> TWOGNOISEFIGDB { get; set; }
        public Nullable<decimal> TWOGMAXNUMTIMESLOTS { get; set; }
        public Nullable<decimal> SUPPORT2G { get; set; }
        public Nullable<decimal> SUPPORT3G { get; set; }
        public Nullable<decimal> CCS1 { get; set; }
        public Nullable<decimal> CCS2 { get; set; }
        public Nullable<decimal> CCS3 { get; set; }
        public Nullable<decimal> CCS4 { get; set; }
        public Nullable<decimal> FAMILYA { get; set; }
        public Nullable<decimal> FAMILYB { get; set; }
        public Nullable<decimal> FAMILYC { get; set; }
        public Nullable<decimal> MASTERTERMINAL { get; set; }
        public Nullable<decimal> MASTERNAMEKEY { get; set; }
        public Nullable<decimal> TRAFFICSCALE { get; set; }
        public Nullable<decimal> JOINTDETFACT { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal SUPHSDPA { get; set; }
        public decimal MAXHSDPACODES { get; set; }
        public decimal REQRSCP { get; set; }
        public decimal REQSIR { get; set; }
        public decimal BEAMWIDTH { get; set; }
        public Nullable<decimal> SUBCHANNEL { get; set; }
        public Nullable<decimal> USEVECTORDENSITY { get; set; }
        public decimal WIMAXMULTIPLEX { get; set; }
        public decimal WIMAXMOD { get; set; }
        public decimal WIMAXMIMOTX { get; set; }
        public decimal WIMAXMIMORX { get; set; }
        public decimal WIMAXTERMSUPPORTSETTING { get; set; }
        public decimal SUPHSUPA { get; set; }
        public decimal SUPUL2MSTTI { get; set; }
        public decimal ULMAXCODES { get; set; }
        public decimal ULMODSUPPORTED { get; set; }
        public decimal ULMINSFSUPPORTED { get; set; }
        public decimal DLMAXBLOCKSIZE { get; set; }
        public decimal REQHSSCCHECNT { get; set; }
        public decimal DLCHIPEQFACTOR { get; set; }
        public decimal SUPCHIPEQFACTOR { get; set; }
        public decimal DLINTCANFACTOR { get; set; }
        public decimal SUPINTCANFACTOR { get; set; }
        public decimal ANTENNA_KEY { get; set; }
        public decimal BEAM_FORMING_ACTIVE { get; set; }
        public decimal MAX_BLOCKSIZE_DL { get; set; }
        public decimal MAX_BLOCKSIZE_UL { get; set; }
        public decimal MAX_MOD_SCHEME_DL { get; set; }
        public decimal MAX_MOD_SCHEME_UL { get; set; }
        public decimal MAX_TX_POWER { get; set; }
        public decimal MU_MIMO_DL { get; set; }
        public decimal MU_MIMO_UL { get; set; }
        public decimal REQD_RSRQ { get; set; }
        public decimal REQD_SINR { get; set; }
        public decimal RX_COMB_GAIN { get; set; }
        public decimal SU_MIMO_ELEM_CNT_DL { get; set; }
        public decimal SU_MIMO_ELEM_CNT_UL { get; set; }
        public decimal SU_MIMO_ENABLE_DL { get; set; }
        public decimal SU_MIMO_ENABLE_UL { get; set; }
        public decimal SU_MIMO_MODE_DL { get; set; }
        public decimal SU_MIMO_MODE_UL { get; set; }
        public decimal TERM_CATEGORY { get; set; }
        public string HSDPA_CATEGORY { get; set; }
        public string HSUPA_CATEGORY { get; set; }
        public decimal MC_HSPA_MAX_DL_CARRIERS { get; set; }
        public decimal MC_HSPA_MAX_UL_CARRIERS { get; set; }
        public decimal WIFI_ANTENNA_GAIN { get; set; }
        public decimal WIFI_BODY_LOSS { get; set; }
        public decimal WIFI_MAX_MOBILE_POWER { get; set; }
        public decimal WIFI_NOISE_FIGURE { get; set; }
        public decimal WIFI_REQ_SIGNAL_STRENGHTH { get; set; }
        public decimal WIFI_SUPPORT { get; set; }
        public decimal WIFI_TX_DYNAMIC_RANGE { get; set; }
        public decimal LTE_ANTENGAIN { get; set; }
        public decimal LTE_BODYLOSS { get; set; }
        public decimal LTE_DYNAMRANGE { get; set; }
        public decimal LTE_MAX_DL_CARRIERS { get; set; }
        public decimal LTE_MAX_UL_CARRIERS { get; set; }
        public decimal LTE_NOISEFIG { get; set; }
        public decimal LTE_REQRSRP { get; set; }
        public decimal LTE_SUPPORT { get; set; }
        public decimal HAS_CRE_SUPPORT { get; set; }
        public decimal MBSFN_ENABLED { get; set; }
        public decimal MBSFN_REQ_RSRP { get; set; }
        public decimal MBSFN_REQ_RSRQ { get; set; }
        public decimal MBSFN_REQ_SINR { get; set; }
        public decimal ANTENGAIN_5G { get; set; }
        public decimal ANTENNA_KEY_5G { get; set; }
        public decimal BEAM_FORMING_ACTIVE_5G { get; set; }
        public decimal BEAMWIDTH_5G { get; set; }
        public decimal BODYLOSS_5G { get; set; }
        public decimal BPSK_PI2_UL_5G { get; set; }
        public decimal DYNAMRANGE_5G { get; set; }
        public decimal FIVEG_SUPPORT { get; set; }
        public decimal HAS_CRE_SUPPORT_5G { get; set; }
        public decimal MAX_BLOCKSIZE_DL_5G { get; set; }
        public decimal MAX_BLOCKSIZE_UL_5G { get; set; }
        public decimal MAX_DL_CARRIERS_5G { get; set; }
        public decimal MAX_MOD_SCHEME_DL_5G { get; set; }
        public decimal MAX_MOD_SCHEME_UL_5G { get; set; }
        public decimal MAX_TX_POWER_5G { get; set; }
        public decimal MAX_UL_CARRIERS_5G { get; set; }
        public decimal MU_MIMO_DL_5G { get; set; }
        public decimal MU_MIMO_UL_5G { get; set; }
        public decimal NOISEFIG_5G { get; set; }
        public decimal REQD_RSRQ_5G { get; set; }
        public decimal REQD_SINR_5G { get; set; }
        public decimal REQRSRP_5G { get; set; }
        public decimal RX_COMB_GAIN_5G { get; set; }
        public decimal SU_MIMO_ELEM_CNT_DL_5G { get; set; }
        public decimal SU_MIMO_ELEM_CNT_UL_5G { get; set; }
        public decimal SU_MIMO_ENABLE_DL_5G { get; set; }
        public decimal SU_MIMO_ENABLE_UL_5G { get; set; }
        public decimal SU_MIMO_MODE_DL_5G { get; set; }
        public decimal SU_MIMO_MODE_UL_5G { get; set; }
        public decimal TERM_CATEGORY_5G { get; set; }
        public decimal DC_MAXCARRIERS_DL { get; set; }
        public decimal DC_MAXCARRIERS_UL { get; set; }
        public decimal DC_MAXPOWER { get; set; }
        public decimal DC_SUPPORT_EN { get; set; }
        public decimal DC_SUPPORT_LTE { get; set; }
        public decimal DC_SUPPORT_NE { get; set; }
        public decimal DC_SUPPORT_NR { get; set; }
        public decimal ALLCARRIERS_3G { get; set; }
        public decimal ALLCARRIERS_5G { get; set; }
        public decimal ALLCARRIERS_LTE { get; set; }
        public decimal ALLCARRIERS_WIFI { get; set; }
        public decimal CRS_RATE_MATCHING_5G { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRIEDTRAFFICDETAIL> CARRIEDTRAFFICDETAILs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMMOBSPEED> TERMMOBSPEEDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYCARRIER> TERMTYCARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYCELLAY> TERMTYCELLAYs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYCLUTTER> TERMTYCLUTTERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYPOLYGON> TERMTYPOLYGONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYVECTOR> TERMTYVECTORs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TERMTYPEPOINT> TERMTYPEPOINTs { get; set; }
    }
}
