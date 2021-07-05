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
    
    public partial class LTECARRIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LTECARRIER()
        {
            this.LOGLTECAR = new HashSet<LOGLTECAR>();
            this.LTECARRIERMBSFN = new HashSet<LTECARRIERMBSFN>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal CARRIERKEY { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> IS_ACTIVE { get; set; }
        public Nullable<decimal> FREQ_BAND_FK { get; set; }
        public Nullable<decimal> FRAME_STRUCT_FK { get; set; }
        public Nullable<decimal> SAMPLING_FACTOR { get; set; }
        public Nullable<decimal> BANDWIDTH_MHZ { get; set; }
        public Nullable<decimal> NUM_RESOURCE_BLOCKS { get; set; }
        public Nullable<decimal> FFT_SIZE { get; set; }
        public Nullable<decimal> FREQ_LO_DL { get; set; }
        public Nullable<decimal> LO_EARFCN_DL { get; set; }
        public Nullable<decimal> FREQ_HI_DL { get; set; }
        public Nullable<decimal> HI_EARFCN_DL { get; set; }
        public Nullable<decimal> ATTENUATION_DL { get; set; }
        public Nullable<decimal> FREQ_LO_UL { get; set; }
        public Nullable<decimal> LO_EARFCN_UL { get; set; }
        public Nullable<decimal> FREQ_HI_UL { get; set; }
        public Nullable<decimal> HI_EARFCN_UL { get; set; }
        public Nullable<decimal> ATTENUATION_UL { get; set; }
        public Nullable<decimal> REF_SIG_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> REF_SIG_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> REF_SIG_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> REF_SIG_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> REF_SIG_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> CTRL_PDCCH_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> CTRL_PDCCH_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> CTRL_PDCCH_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> CTRL_PDCCH_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> CTRL_PDCCH_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> BCAST_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> BCAST_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> BCAST_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> BCAST_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> BCAST_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> SYNC_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> SYNC_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> SYNC_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> SYNC_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> SYNC_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> CTRL_PUCCH_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> CTRL_PUCCH_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> CTRL_PUCCH_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> CTRL_PUCCH_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> CTRL_PUCCH_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> SND_REF_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> SND_REF_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> SND_REF_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> SND_REF_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> SND_REF_NUM_RES_BLOCKS { get; set; }
        public Nullable<decimal> DEMOD_SUBFRAME_TX1 { get; set; }
        public Nullable<decimal> DEMOD_SUBFRAME_TX2 { get; set; }
        public Nullable<decimal> DEMOD_SUBFRAME_TX2PLUS { get; set; }
        public Nullable<decimal> DEMOD_NUM_SUBFRAMES { get; set; }
        public Nullable<decimal> DEMOD_NUM_RES_BLOCKS { get; set; }
        public Nullable<byte> ICICSCHEMESENABLED { get; set; }
        public Nullable<byte> ICICMETHOD { get; set; }
        public Nullable<decimal> REUSE1PARTITIONS { get; set; }
        public Nullable<decimal> REUSE1COORDFACTOR { get; set; }
        public Nullable<decimal> SOFTREUSECEPARTITIONS { get; set; }
        public Nullable<decimal> SOFTREUSEPOW { get; set; }
        public Nullable<decimal> SOFTREUSESBW { get; set; }
        public Nullable<decimal> SOFTREUSECOORDFACTOR { get; set; }
        public Nullable<decimal> REUSEPARTCEPARTITIONS { get; set; }
        public Nullable<decimal> REUSEPARTPOW { get; set; }
        public Nullable<decimal> REUSEPARTBW { get; set; }
        public Nullable<decimal> REUSEPARTCOORDFACTOR { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<byte> ENHICICSCHEMESENABLED { get; set; }
        public Nullable<decimal> IS_LICENSED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECAR> LOGLTECAR { get; set; }
        public virtual LTEFRAMES LTEFRAMES { get; set; }
        public virtual LTEFREQBANDS LTEFREQBANDS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LTECARRIERMBSFN> LTECARRIERMBSFN { get; set; }
    }
}
