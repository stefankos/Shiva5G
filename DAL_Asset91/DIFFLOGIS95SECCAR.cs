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
    
    public partial class DIFFLOGIS95SECCAR
    {
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal SECCARPK { get; set; }
        public decimal DSECCARPK { get; set; }
        public decimal CARRIERFK { get; set; }
        public decimal DCARRIERFK { get; set; }
        public decimal SECTORFK { get; set; }
        public decimal DSECTORFK { get; set; }
        public Nullable<decimal> MAXPAPWR_DBM { get; set; }
        public Nullable<decimal> DMAXPAPWR_DBM { get; set; }
        public Nullable<decimal> RATEDPAPWR_DBM { get; set; }
        public Nullable<decimal> DRATEDPAPWR_DBM { get; set; }
        public Nullable<decimal> MAXPWRPERCHAN_DBM { get; set; }
        public Nullable<decimal> DMAXPWRPERCHAN_DBM { get; set; }
        public Nullable<decimal> MINPWRPERCHAN_DBM { get; set; }
        public Nullable<decimal> DMINPWRPERCHAN_DBM { get; set; }
        public Nullable<decimal> PWRCTLSTEPSIZE_DB { get; set; }
        public Nullable<decimal> DPWRCTLSTEPSIZE_DB { get; set; }
        public Nullable<decimal> DEDICATEDCHANELEMS { get; set; }
        public Nullable<decimal> DDEDICATEDCHANELEMS { get; set; }
        public Nullable<decimal> NUMPOOLEDPRIMCHANELEMS { get; set; }
        public Nullable<decimal> DNUMPOOLEDPRIMCHANELEMS { get; set; }
        public Nullable<decimal> MAXHOCHANELEMS { get; set; }
        public Nullable<decimal> DMAXHOCHANELEMS { get; set; }
        public Nullable<decimal> PILOTPWR_DBM { get; set; }
        public Nullable<decimal> DPILOTPWR_DBM { get; set; }
        public Nullable<decimal> NUMPAGINGCHANS { get; set; }
        public Nullable<decimal> DNUMPAGINGCHANS { get; set; }
        public Nullable<decimal> PAGINGCHANPWR_DBM { get; set; }
        public Nullable<decimal> DPAGINGCHANPWR_DBM { get; set; }
        public Nullable<decimal> PAGINGCHANDATARATE_KBS { get; set; }
        public Nullable<decimal> DPAGINGCHANDATARATE_KBS { get; set; }
        public Nullable<decimal> SYNCCHANPWR_DBM { get; set; }
        public Nullable<decimal> DSYNCCHANPWR_DBM { get; set; }
        public Nullable<decimal> SYNCCHANDATARATE_KBS { get; set; }
        public Nullable<decimal> DSYNCCHANDATARATE_KBS { get; set; }
        public Nullable<decimal> RCVRNOISEFIGURE_DBM { get; set; }
        public Nullable<decimal> DRCVRNOISEFIGURE_DBM { get; set; }
        public Nullable<decimal> EXCESSNOISE_DB { get; set; }
        public Nullable<decimal> DEXCESSNOISE_DB { get; set; }
        public Nullable<decimal> NOISERISELMT_DB { get; set; }
        public Nullable<decimal> DNOISERISELMT_DB { get; set; }
        public Nullable<decimal> ACTIVESETSIZE { get; set; }
        public Nullable<decimal> DACTIVESETSIZE { get; set; }
        public Nullable<decimal> T_DROP_DB { get; set; }
        public Nullable<decimal> DT_DROP_DB { get; set; }
        public Nullable<decimal> TX_LOSS_DB { get; set; }
        public Nullable<decimal> DTX_LOSS_DB { get; set; }
        public Nullable<decimal> RX_LOSS_DB { get; set; }
        public Nullable<decimal> DRX_LOSS_DB { get; set; }
        public Nullable<decimal> ORTHOGFACTOR { get; set; }
        public Nullable<decimal> DORTHOGFACTOR { get; set; }
        public Nullable<decimal> MEANPRICHANUSD { get; set; }
        public Nullable<decimal> DMEANPRICHANUSD { get; set; }
        public Nullable<decimal> MEANHOCHANUSD { get; set; }
        public Nullable<decimal> DMEANHOCHANUSD { get; set; }
        public Nullable<decimal> MEANTOTDLTFCPWR { get; set; }
        public Nullable<decimal> DMEANTOTDLTFCPWR { get; set; }
        public Nullable<decimal> MEANACHNOISERISE { get; set; }
        public Nullable<decimal> DMEANACHNOISERISE { get; set; }
        public string RCDOWNLINK { get; set; }
        public string DRCDOWNLINK { get; set; }
        public string RCUPLINK { get; set; }
        public string DRCUPLINK { get; set; }
        public Nullable<decimal> EXCESSNOISE_CHECK { get; set; }
        public Nullable<decimal> DEXCESSNOISE_CHECK { get; set; }
        public Nullable<decimal> MINSUPPPWR_DBM { get; set; }
        public Nullable<decimal> DMINSUPPPWR_DBM { get; set; }
        public Nullable<decimal> MAXSUPPPWR_DBM { get; set; }
        public Nullable<decimal> DMAXSUPPPWR_DBM { get; set; }
        public Nullable<decimal> USEDBMBIT { get; set; }
        public Nullable<decimal> DUSEDBMBIT { get; set; }
        public Nullable<decimal> BROADCASTCTRLCHANPWR { get; set; }
        public Nullable<decimal> DBROADCASTCTRLCHANPWR { get; set; }
        public Nullable<decimal> QUICKPAGINGCHANPWR { get; set; }
        public Nullable<decimal> DQUICKPAGINGCHANPWR { get; set; }
        public Nullable<decimal> COMMPWRCTRLCHANPWR { get; set; }
        public Nullable<decimal> DCOMMPWRCTRLCHANPWR { get; set; }
        public Nullable<decimal> COMMASSIGNCHANPWR { get; set; }
        public Nullable<decimal> DCOMMASSIGNCHANPWR { get; set; }
        public Nullable<decimal> COMMCTRLCHANPWR { get; set; }
        public Nullable<decimal> DCOMMCTRLCHANPWR { get; set; }
        public Nullable<decimal> DEDICATEDCTRLCHANPWR { get; set; }
        public Nullable<decimal> DDEDICATEDCTRLCHANPWR { get; set; }
        public Nullable<decimal> DATAOFFSETNOMCHANPWR { get; set; }
        public Nullable<decimal> DDATAOFFSETNOMCHANPWR { get; set; }
        public Nullable<decimal> DATAOFFSETCHANPWR9K6 { get; set; }
        public Nullable<decimal> DDATAOFFSETCHANPWR9K6 { get; set; }
        public Nullable<decimal> DATAOFFSETCHANPWR19K2 { get; set; }
        public Nullable<decimal> DDATAOFFSETCHANPWR19K2 { get; set; }
        public Nullable<decimal> DATAOFFSETCHANPWR38K4 { get; set; }
        public Nullable<decimal> DDATAOFFSETCHANPWR38K4 { get; set; }
        public Nullable<decimal> DATAOFFSETCHANPWR76K8 { get; set; }
        public Nullable<decimal> DDATAOFFSETCHANPWR76K8 { get; set; }
        public Nullable<decimal> DATAOFFSETCHANPWR153K6 { get; set; }
        public Nullable<decimal> DDATAOFFSETCHANPWR153K6 { get; set; }
        public Nullable<decimal> SYNCHCHANPWRCHECK { get; set; }
        public Nullable<decimal> DSYNCHCHANPWRCHECK { get; set; }
        public Nullable<decimal> BROADCASTCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> DBROADCASTCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> QUICKPAGINGCHANPWRCHECK { get; set; }
        public Nullable<decimal> DQUICKPAGINGCHANPWRCHECK { get; set; }
        public Nullable<decimal> COMMPWRCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> DCOMMPWRCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> COMMASSIGNCHANPWRCHECK { get; set; }
        public Nullable<decimal> DCOMMASSIGNCHANPWRCHECK { get; set; }
        public Nullable<decimal> COMMCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> DCOMMCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> DEDICATEDCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> DDEDICATEDCTRLCHANPWRCHECK { get; set; }
        public Nullable<decimal> NUMCHANSPOOL { get; set; }
        public Nullable<decimal> DNUMCHANSPOOL { get; set; }
        public Nullable<decimal> MAXHOCHANSPOOL { get; set; }
        public Nullable<decimal> DMAXHOCHANSPOOL { get; set; }
        public Nullable<decimal> MAXPRIMCHANSPOOL { get; set; }
        public Nullable<decimal> DMAXPRIMCHANSPOOL { get; set; }
        public Nullable<decimal> MAKEVALRO { get; set; }
        public Nullable<decimal> DMAKEVALRO { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> SCRAMBLINGCODE { get; set; }
        public Nullable<decimal> DSCRAMBLINGCODE { get; set; }
        public Nullable<decimal> SCRAMBLINGCODEGRP { get; set; }
        public Nullable<decimal> DSCRAMBLINGCODEGRP { get; set; }
        public Nullable<decimal> MAXDPCHPWRDBM { get; set; }
        public Nullable<decimal> DMAXDPCHPWRDBM { get; set; }
        public Nullable<decimal> MINDPCHPWRDBM { get; set; }
        public Nullable<decimal> DMINDPCHPWRDBM { get; set; }
        public Nullable<decimal> CODEORTHOFACTOR { get; set; }
        public Nullable<decimal> DCODEORTHOFACTOR { get; set; }
        public Nullable<decimal> JOINTDETECTIONORTHOFACTOR { get; set; }
        public Nullable<decimal> DJOINTDETECTIONORTHOFACTOR { get; set; }
        public Nullable<decimal> SPCONFIG { get; set; }
        public Nullable<decimal> DSPCONFIG { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal MACINDEXES { get; set; }
        public decimal DMACINDEXES { get; set; }
    }
}