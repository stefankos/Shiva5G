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
    
    public partial class LOGLTECELLCAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGLTECELLCAR()
        {
            this.LOGLTECELLCARMBSFN = new HashSet<LOGLTECELLCARMBSFN>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal CELLCARRIERPK { get; set; }
        public decimal LTECELLFK { get; set; }
        public decimal CARRIERFK { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> MAXTXPOWER { get; set; }
        public Nullable<decimal> TRAFFICOFFSET { get; set; }
        public Nullable<decimal> CONTROLOFFSET { get; set; }
        public Nullable<decimal> SYNCOFFSET { get; set; }
        public Nullable<decimal> BROADCASTOFFSET { get; set; }
        public Nullable<decimal> NOISEFIGURE { get; set; }
        public Nullable<byte> TXPOWERFIXED { get; set; }
        public Nullable<byte> REFSIGNALSNRTHRESHENABLED { get; set; }
        public Nullable<byte> TIMINGADVANCEENABLED { get; set; }
        public Nullable<byte> ADMIMOTHRESHENABLED { get; set; }
        public Nullable<byte> MUMIMOTHRESHENABLED { get; set; }
        public Nullable<decimal> TIMINGADVANCEMODE { get; set; }
        public Nullable<decimal> MAXTA { get; set; }
        public Nullable<decimal> MAXRANGE { get; set; }
        public Nullable<decimal> REFSIGNALSNRTHRESH { get; set; }
        public Nullable<decimal> ADMIMOTHRESHRSSNR { get; set; }
        public Nullable<decimal> MUMIMOTHRESHRSSNR { get; set; }
        public Nullable<decimal> SCHEDULERKEY { get; set; }
        public Nullable<decimal> MAXSCHEDULEDUSERS { get; set; }
        public Nullable<decimal> CODESCHEMAKEY { get; set; }
        public Nullable<decimal> CODESCHEMATYPE { get; set; }
        public decimal CELLID { get; set; }
        public Nullable<byte> CELLSPECIFICFREQOFFSETS { get; set; }
        public Nullable<decimal> DL_MAX_MODULATION { get; set; }
        public Nullable<decimal> DLCELLCENTERLOAD { get; set; }
        public Nullable<decimal> DLCELLEDGELOAD { get; set; }
        public Nullable<decimal> MEANULCELLCENTERINTFLEVEL { get; set; }
        public Nullable<decimal> MEANULCELLEDGEINTFLEVEL { get; set; }
        public Nullable<byte> ICICSCHEMESENABLED { get; set; }
        public Nullable<decimal> RSRP { get; set; }
        public Nullable<decimal> RELRSRP { get; set; }
        public Nullable<byte> CELLEDGETHRESHMODE { get; set; }
        public Nullable<byte> CALCULATIONMETHOD { get; set; }
        public Nullable<decimal> REFERENCESIGNALPPRE { get; set; }
        public Nullable<byte> HIGHSINRLOCATIONENABLED { get; set; }
        public Nullable<byte> LINEOFSIGHTLOCATIONENABLED { get; set; }
        public Nullable<decimal> NONERAYLEIGHADJUSTMENT { get; set; }
        public Nullable<decimal> SINRTHRESHOLD { get; set; }
        public Nullable<byte> USEMIMOTHRESHRSSNR { get; set; }
        public Nullable<byte> USEMIMOTHRESHRSSINR { get; set; }
        public Nullable<byte> USEMIMOTHRESHTRAFFICSINR { get; set; }
        public Nullable<decimal> ADMIMOTHRESHRSSINR { get; set; }
        public Nullable<decimal> ADMIMOTHRESHULTRAFFICSINR { get; set; }
        public Nullable<decimal> ADMIMOTHRESHDLTRAFFICSINR { get; set; }
        public Nullable<decimal> MUMIMOTHRESHRSSINR { get; set; }
        public Nullable<decimal> MUMIMOTHRESHULTRAFFICSINR { get; set; }
        public Nullable<decimal> MUMIMOTHRESHDLTRAFFICSINR { get; set; }
        public Nullable<byte> TTIBUNDLINGENABLED { get; set; }
        public Nullable<byte> CELLCAENABLED { get; set; }
        public Nullable<byte> ENODEBCAENABLED { get; set; }
        public string CACELLIDENTITY { get; set; }
        public decimal DLNOISERISETERMGSM { get; set; }
        public decimal DLNOISERISETERMUMTS { get; set; }
        public decimal DLNOISERISETERMWIFI { get; set; }
        public decimal ULNOISERISECELLTERMGSM { get; set; }
        public decimal ULNOISERISECELLTERMUMTS { get; set; }
        public decimal ULNOISERISECELLTERMWIFI { get; set; }
        public decimal CHANNELPROTECTIONGSM { get; set; }
        public decimal CHANNELPROTECTIONUMTS { get; set; }
        public decimal CHANNELPROTECTIONWIFI { get; set; }
        public string DLCENTREABSCUSTOMMASK { get; set; }
        public Nullable<decimal> DLCENTREABSPATTERN_FK { get; set; }
        public string DLEDGEABSCUSTOMMASK { get; set; }
        public Nullable<decimal> DLEDGEABSPATTERN_FK { get; set; }
        public Nullable<byte> ENHICICSCHEMEENABLED { get; set; }
        public string INTERENODEBCACELLIDENTITY { get; set; }
        public Nullable<byte> INTERENODEBCAENABLED { get; set; }
        public decimal MBSFNCTRLOFFSET { get; set; }
        public Nullable<decimal> MBSFNENABLED { get; set; }
        public decimal MBSFNRSOFFSET { get; set; }
        public Nullable<decimal> MBSFNSYNCAREA { get; set; }
        public decimal MBSFNTRAFFICOFFSET { get; set; }
        public decimal MPCMODELFK { get; set; }
        public Nullable<decimal> RSRPOFFSET { get; set; }
        public Nullable<byte> RSRPOFFSETENABLED { get; set; }
        public string ULCENTREABSCUSTOMMASK { get; set; }
        public Nullable<decimal> ULCENTREABSPATTERN_FK { get; set; }
        public string ULEDGEABSCUSTOMMASK { get; set; }
        public Nullable<decimal> ULEDGEABSPATTERN_FK { get; set; }
    
        public virtual LOGLTECAR LOGLTECAR { get; set; }
        public virtual LOGLTECELL LOGLTECELL { get; set; }
        public virtual LTEEICICABSPATTERN LTEEICICABSPATTERN { get; set; }
        public virtual LTEEICICABSPATTERN LTEEICICABSPATTERN1 { get; set; }
        public virtual LTEEICICABSPATTERN LTEEICICABSPATTERN2 { get; set; }
        public virtual LTEEICICABSPATTERN LTEEICICABSPATTERN3 { get; set; }
        public virtual MULTIPATHCHANNELMODEL MULTIPATHCHANNELMODEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCARMBSFN> LOGLTECELLCARMBSFN { get; set; }
    }
}
