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
    
    public partial class LOGUMTSCELLCAR
    {
        public decimal CELLCARRIERPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal LOGCELLFK { get; set; }
        public decimal CARRIERFK { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> PILOTPOWER { get; set; }
        public Nullable<decimal> COMMONCHANPWR { get; set; }
        public Nullable<decimal> NOISERISE { get; set; }
        public Nullable<decimal> ORTHOGFACTOR { get; set; }
        public Nullable<decimal> CODESCHEMAKEY { get; set; }
        public Nullable<decimal> CODESCHEMATYPE { get; set; }
        public Nullable<decimal> SCRAMBLINGCODE { get; set; }
        public Nullable<decimal> SCRAMCODEGRP { get; set; }
        public Nullable<decimal> MAXACTIVESETSIZE { get; set; }
        public Nullable<decimal> SOFTHOSRCHWND { get; set; }
        public Nullable<decimal> CELLBGRNDNOISE { get; set; }
        public Nullable<decimal> SYNCHCHANPWR { get; set; }
        public Nullable<decimal> MAXTXPOWER { get; set; }
        public Nullable<decimal> SECSYNCHPOW { get; set; }
        public Nullable<decimal> SECCMNCHPOW { get; set; }
        public Nullable<decimal> ULNOISERISE { get; set; }
        public Nullable<decimal> DLPOWER { get; set; }
        public Nullable<decimal> HANDOVERMARGIN { get; set; }
        public Nullable<decimal> MULTIUSERDETECTIONFACTOR { get; set; }
        public Nullable<decimal> DOWNLINKLOADINGLEVEL { get; set; }
        public Nullable<byte> TXPOWFIXED { get; set; }
        public Nullable<byte> MAXTXDLPOWFIXED { get; set; }
        public Nullable<byte> CHANPOWFIXED { get; set; }
        public decimal OTSRSPILTTERLOSS { get; set; }
        public decimal RELPWRS { get; set; }
        public decimal MAXHSDPAPWR { get; set; }
        public decimal AICHPWR { get; set; }
        public decimal PICHPWR { get; set; }
        public decimal AICHACT { get; set; }
        public decimal PICHACT { get; set; }
        public decimal SCCPCHACT { get; set; }
        public decimal PCCPCHON { get; set; }
        public decimal SCCPCHON { get; set; }
        public decimal PSCHON { get; set; }
        public decimal SSCHON { get; set; }
        public decimal AICHON { get; set; }
        public decimal PICHON { get; set; }
        public Nullable<byte> HSDPAPOWFIXED { get; set; }
        public decimal HSDPADLTRAFFPWRDBM { get; set; }
        public decimal DSCHPWRTDD { get; set; }
        public decimal DSCHONTDD { get; set; }
        public decimal SUPDYNHSSCCH { get; set; }
        public decimal EAGCHPOWER { get; set; }
        public decimal ERGCHPOWER { get; set; }
        public decimal EHICHPOWER { get; set; }
        public decimal HSSCCHPOWER { get; set; }
        public decimal HSSCCHMEANPOWER { get; set; }
        public decimal EAGCHON { get; set; }
        public decimal ERGCHON { get; set; }
        public decimal EHICHON { get; set; }
        public decimal EAGCHACT { get; set; }
        public decimal ERGCHACT { get; set; }
        public decimal EHICHACT { get; set; }
        public decimal CHANNELPROTECTIONGSM { get; set; }
        public decimal CHANNELPROTECTIONLTE { get; set; }
        public decimal CHANNELPROTECTIONWIFI { get; set; }
        public decimal DLNOISERISETERMGSM { get; set; }
        public decimal DLNOISERISETERMLTE { get; set; }
        public decimal DLNOISERISETERMWIFI { get; set; }
        public decimal ULNOISERISECELLTERMGSM { get; set; }
        public decimal ULNOISERISECELLTERMLTE { get; set; }
        public decimal ULNOISERISECELLTERMWIFI { get; set; }
        public decimal CELLPARAMSFK { get; set; }
        public decimal CHANNELPROTECTION5G { get; set; }
        public decimal DLNOISERISETERM5G { get; set; }
        public decimal ULNOISERISECELLTERM5G { get; set; }
    
        public virtual LOGCELL LOGCELL { get; set; }
        public virtual LOGUMTSCAR LOGUMTSCAR { get; set; }
        public virtual LOGUMTSCELL LOGUMTSCELL { get; set; }
    }
}
