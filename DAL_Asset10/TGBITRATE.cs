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
    
    public partial class TGBITRATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGBITRATE()
        {
            this.LTECARRIERMBSFNs = new HashSet<LTECARRIERMBSFN>();
            this.LTECARRIERMBSFNs1 = new HashSet<LTECARRIERMBSFN>();
            this.SRVCELLBITPRIORs = new HashSet<SRVCELLBITPRIOR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal BITRATEKEY { get; set; }
        public string IDNAME { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> PCCPCHSIRTARGET { get; set; }
        public Nullable<decimal> THROUGHPUTPERTIMESLOT { get; set; }
        public Nullable<decimal> COLOUR { get; set; }
        public Nullable<decimal> CHIPRATE { get; set; }
        public Nullable<decimal> ULAI { get; set; }
        public Nullable<decimal> ULUSER { get; set; }
        public Nullable<decimal> DLAI { get; set; }
        public Nullable<decimal> DLUSER { get; set; }
        public Nullable<decimal> DLCHANS { get; set; }
        public Nullable<decimal> ULCHANS { get; set; }
        public Nullable<decimal> ULCTRLOHEAD { get; set; }
        public Nullable<decimal> DLCTRLOHEAD { get; set; }
        public Nullable<decimal> SPARE1 { get; set; }
        public Nullable<decimal> SPARE2 { get; set; }
        public Nullable<decimal> SPARE3 { get; set; }
        public Nullable<decimal> SPARE4 { get; set; }
        public Nullable<decimal> NETTYPE { get; set; }
        public Nullable<decimal> EBNOULTG { get; set; }
        public Nullable<decimal> EBNODLTG { get; set; }
        public Nullable<decimal> EBNOULAC { get; set; }
        public Nullable<decimal> EBNODLAC { get; set; }
        public Nullable<decimal> BER1 { get; set; }
        public Nullable<decimal> BER2 { get; set; }
        public Nullable<decimal> BER3 { get; set; }
        public Nullable<decimal> BER4 { get; set; }
        public Nullable<decimal> BER5 { get; set; }
        public Nullable<decimal> BER6 { get; set; }
        public Nullable<decimal> BER7 { get; set; }
        public Nullable<decimal> BER8 { get; set; }
        public Nullable<decimal> BER9 { get; set; }
        public Nullable<decimal> BER10 { get; set; }
        public Nullable<decimal> BLER1 { get; set; }
        public Nullable<decimal> BLER2 { get; set; }
        public Nullable<decimal> BLER3 { get; set; }
        public Nullable<decimal> BLER4 { get; set; }
        public Nullable<decimal> BLER5 { get; set; }
        public Nullable<decimal> BLER6 { get; set; }
        public Nullable<decimal> BLER7 { get; set; }
        public Nullable<decimal> BLER8 { get; set; }
        public Nullable<decimal> BLER9 { get; set; }
        public Nullable<decimal> BLER10 { get; set; }
        public Nullable<decimal> ACTIVUL { get; set; }
        public Nullable<decimal> ACTIVDL { get; set; }
        public Nullable<decimal> RCDOWNLINK { get; set; }
        public Nullable<decimal> RCUPLINK { get; set; }
        public Nullable<decimal> RCFRAMELENGTH { get; set; }
        public string RCCODINGTYPE { get; set; }
        public Nullable<decimal> GROSSDATARATE { get; set; }
        public string CODINGSCHEME { get; set; }
        public Nullable<decimal> NUMCODES { get; set; }
        public Nullable<decimal> NUMTIMESLOTS { get; set; }
        public Nullable<decimal> SWITCHINGTYPE { get; set; }
        public Nullable<decimal> V0 { get; set; }
        public Nullable<decimal> V1 { get; set; }
        public Nullable<decimal> V2 { get; set; }
        public Nullable<decimal> V3 { get; set; }
        public Nullable<decimal> V4 { get; set; }
        public Nullable<decimal> V5 { get; set; }
        public Nullable<decimal> V6 { get; set; }
        public Nullable<decimal> V7 { get; set; }
        public Nullable<decimal> V8 { get; set; }
        public Nullable<decimal> V9 { get; set; }
        public Nullable<decimal> V10 { get; set; }
        public Nullable<decimal> V11 { get; set; }
        public Nullable<decimal> V12 { get; set; }
        public Nullable<decimal> V13 { get; set; }
        public Nullable<decimal> V14 { get; set; }
        public Nullable<decimal> V15 { get; set; }
        public Nullable<decimal> V16 { get; set; }
        public Nullable<decimal> V17 { get; set; }
        public Nullable<decimal> V18 { get; set; }
        public Nullable<decimal> V19 { get; set; }
        public Nullable<decimal> V20 { get; set; }
        public Nullable<decimal> V21 { get; set; }
        public Nullable<decimal> V22 { get; set; }
        public Nullable<decimal> V23 { get; set; }
        public Nullable<decimal> V24 { get; set; }
        public Nullable<decimal> V25 { get; set; }
        public Nullable<decimal> V26 { get; set; }
        public Nullable<decimal> V27 { get; set; }
        public Nullable<decimal> V28 { get; set; }
        public Nullable<decimal> V29 { get; set; }
        public Nullable<decimal> V30 { get; set; }
        public Nullable<decimal> V31 { get; set; }
        public Nullable<decimal> V32 { get; set; }
        public Nullable<decimal> V33 { get; set; }
        public Nullable<decimal> V34 { get; set; }
        public Nullable<decimal> V35 { get; set; }
        public Nullable<decimal> V36 { get; set; }
        public Nullable<decimal> V37 { get; set; }
        public Nullable<decimal> V38 { get; set; }
        public Nullable<decimal> V39 { get; set; }
        public Nullable<decimal> V40 { get; set; }
        public Nullable<decimal> V41 { get; set; }
        public Nullable<decimal> V42 { get; set; }
        public Nullable<decimal> V43 { get; set; }
        public Nullable<decimal> V44 { get; set; }
        public Nullable<decimal> V45 { get; set; }
        public Nullable<decimal> V46 { get; set; }
        public Nullable<decimal> V47 { get; set; }
        public Nullable<decimal> V48 { get; set; }
        public Nullable<decimal> V49 { get; set; }
        public Nullable<decimal> V50 { get; set; }
        public Nullable<decimal> V51 { get; set; }
        public Nullable<decimal> V52 { get; set; }
        public Nullable<decimal> V53 { get; set; }
        public Nullable<decimal> V54 { get; set; }
        public Nullable<decimal> V55 { get; set; }
        public Nullable<decimal> V56 { get; set; }
        public Nullable<decimal> V57 { get; set; }
        public Nullable<decimal> V58 { get; set; }
        public Nullable<decimal> V59 { get; set; }
        public Nullable<decimal> V60 { get; set; }
        public Nullable<decimal> V61 { get; set; }
        public Nullable<decimal> V62 { get; set; }
        public Nullable<decimal> V63 { get; set; }
        public Nullable<decimal> V64 { get; set; }
        public Nullable<decimal> V65 { get; set; }
        public Nullable<decimal> V66 { get; set; }
        public Nullable<decimal> V67 { get; set; }
        public Nullable<decimal> V68 { get; set; }
        public Nullable<decimal> V69 { get; set; }
        public Nullable<decimal> V70 { get; set; }
        public Nullable<decimal> V71 { get; set; }
        public Nullable<decimal> V72 { get; set; }
        public Nullable<decimal> V73 { get; set; }
        public Nullable<decimal> V74 { get; set; }
        public Nullable<decimal> V75 { get; set; }
        public Nullable<decimal> V76 { get; set; }
        public Nullable<decimal> V77 { get; set; }
        public Nullable<decimal> V78 { get; set; }
        public Nullable<decimal> V79 { get; set; }
        public Nullable<decimal> V80 { get; set; }
        public Nullable<decimal> V81 { get; set; }
        public Nullable<decimal> V82 { get; set; }
        public Nullable<decimal> V83 { get; set; }
        public Nullable<decimal> V84 { get; set; }
        public Nullable<decimal> V85 { get; set; }
        public Nullable<decimal> V86 { get; set; }
        public Nullable<decimal> V87 { get; set; }
        public Nullable<decimal> V88 { get; set; }
        public Nullable<decimal> V89 { get; set; }
        public Nullable<decimal> V90 { get; set; }
        public Nullable<decimal> V91 { get; set; }
        public Nullable<decimal> V92 { get; set; }
        public Nullable<decimal> V93 { get; set; }
        public Nullable<decimal> V94 { get; set; }
        public Nullable<decimal> V95 { get; set; }
        public Nullable<decimal> V96 { get; set; }
        public Nullable<decimal> V97 { get; set; }
        public Nullable<decimal> V98 { get; set; }
        public Nullable<decimal> V99 { get; set; }
        public Nullable<decimal> V100 { get; set; }
        public Nullable<decimal> V101 { get; set; }
        public Nullable<decimal> RES0CONSUMP { get; set; }
        public Nullable<decimal> RES1CONSUMP { get; set; }
        public Nullable<decimal> RES2CONSUMP { get; set; }
        public Nullable<decimal> RES3CONSUMP { get; set; }
        public Nullable<decimal> RES4CONSUMP { get; set; }
        public Nullable<decimal> RES5CONSUMP { get; set; }
        public Nullable<decimal> BRDIRECTION { get; set; }
        public Nullable<decimal> SUPPORTHALFRATE { get; set; }
        public Nullable<decimal> SUPPORTAMR { get; set; }
        public Nullable<decimal> MINAMRFULLRATEDB { get; set; }
        public Nullable<decimal> MINAMRHALFRATEDB { get; set; }
        public Nullable<decimal> MINFULLRATEDB { get; set; }
        public Nullable<decimal> MINHALFRATEDB { get; set; }
        public decimal TECHTYPE { get; set; }
        public decimal HSDPARATEFK { get; set; }
        public decimal REQECIO { get; set; }
        public Nullable<decimal> SUBCHANNEL { get; set; }
        public Nullable<decimal> BANDWIDTH { get; set; }
        public Nullable<decimal> CODINGSCHEMETYPE { get; set; }
        public decimal DATAOFFSET { get; set; }
        public decimal SUBCHANNELMODE { get; set; }
        public decimal MODULATION { get; set; }
        public decimal CODINGRATE { get; set; }
        public decimal REPETITION { get; set; }
        public decimal CINRDB { get; set; }
        public decimal CINR1 { get; set; }
        public decimal CINR2 { get; set; }
        public decimal CINR3 { get; set; }
        public decimal TXPOW { get; set; }
        public decimal DLMIMOMODE { get; set; }
        public Nullable<decimal> CINRWITHMULTI { get; set; }
        public decimal USEAASTABLES { get; set; }
        public decimal CQITABINDEX { get; set; }
        public decimal CQIINDEX { get; set; }
        public decimal TTIMS { get; set; }
        public decimal SFCODESINDEX { get; set; }
        public decimal BLOCKSIZE { get; set; }
        public Nullable<decimal> EVDOREQIORIOC_DB { get; set; }
        public Nullable<decimal> EVDOSLOTS { get; set; }
        public Nullable<decimal> EVDOBITS { get; set; }
        public Nullable<decimal> EVDOOVERHEADBITS { get; set; }
        public Nullable<decimal> EVDOCHIPSPERBIT { get; set; }
        public Nullable<decimal> EVDOEBNT_DB_1 { get; set; }
        public Nullable<decimal> EVDOPER_1 { get; set; }
        public Nullable<decimal> EVDOEBNT_DB_2 { get; set; }
        public Nullable<decimal> EVDOPER_2 { get; set; }
        public Nullable<decimal> EVDOEBNT_DB_3 { get; set; }
        public Nullable<decimal> EVDOPER_3 { get; set; }
        public Nullable<decimal> EVDOEBNT_DB_4 { get; set; }
        public Nullable<decimal> EVDOPER_4 { get; set; }
        public Nullable<decimal> EVDOEBNT_DB_5 { get; set; }
        public Nullable<decimal> EVDOPER_5 { get; set; }
        public Nullable<decimal> ISDEFAULT { get; set; }
        public Nullable<decimal> MBSFNENABLED { get; set; }
    
        public virtual HSDPARATE HSDPARATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LTECARRIERMBSFN> LTECARRIERMBSFNs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LTECARRIERMBSFN> LTECARRIERMBSFNs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SRVCELLBITPRIOR> SRVCELLBITPRIORs { get; set; }
    }
}
