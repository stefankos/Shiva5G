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
    
    public partial class DIFFGSMCELL
    {
        public decimal PROJECTNO { get; set; }
        public decimal DPROJECTNO { get; set; }
        public decimal LOGCELLPK { get; set; }
        public decimal DLOGCELLPK { get; set; }
        public Nullable<decimal> CONFIGKEY { get; set; }
        public Nullable<decimal> DCONFIGKEY { get; set; }
        public Nullable<decimal> AZIMUTH { get; set; }
        public Nullable<decimal> DAZIMUTH { get; set; }
        public Nullable<decimal> BSCC { get; set; }
        public Nullable<decimal> DBSCC { get; set; }
        public Nullable<decimal> NCC { get; set; }
        public Nullable<decimal> DNCC { get; set; }
        public Nullable<decimal> MCC { get; set; }
        public Nullable<decimal> DMCC { get; set; }
        public Nullable<decimal> MNC { get; set; }
        public Nullable<decimal> DMNC { get; set; }
        public Nullable<decimal> MODELKEY { get; set; }
        public Nullable<decimal> DMODELKEY { get; set; }
        public Nullable<decimal> LAC { get; set; }
        public Nullable<decimal> DLAC { get; set; }
        public Nullable<decimal> RAC { get; set; }
        public Nullable<decimal> DRAC { get; set; }
        public Nullable<decimal> CARREQ { get; set; }
        public Nullable<decimal> DCARREQ { get; set; }
        public Nullable<decimal> NUMCARS { get; set; }
        public Nullable<decimal> DNUMCARS { get; set; }
        public Nullable<decimal> CNTRLCHAN { get; set; }
        public Nullable<decimal> DCNTRLCHAN { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal DMODIFYUSER { get; set; }
        public Nullable<decimal> CORRFACTOR { get; set; }
        public Nullable<decimal> DCORRFACTOR { get; set; }
        public Nullable<decimal> CELLEQUIPMENTKEY { get; set; }
        public Nullable<decimal> DCELLEQUIPMENTKEY { get; set; }
        public Nullable<decimal> DTXSTATE { get; set; }
        public Nullable<decimal> DDTXSTATE { get; set; }
        public Nullable<decimal> DTXFACTOR { get; set; }
        public Nullable<decimal> DDTXFACTOR { get; set; }
        public Nullable<decimal> COMMONBCCH { get; set; }
        public Nullable<decimal> DCOMMONBCCH { get; set; }
        public Nullable<decimal> CELLTYPE { get; set; }
        public Nullable<decimal> DCELLTYPE { get; set; }
        public Nullable<decimal> BTSID { get; set; }
        public Nullable<decimal> DBTSID { get; set; }
        public Nullable<decimal> GSMCELLTYPE { get; set; }
        public Nullable<decimal> DGSMCELLTYPE { get; set; }
        public Nullable<decimal> BCFKEY { get; set; }
        public Nullable<decimal> DBCFKEY { get; set; }
        public Nullable<decimal> USEPRI { get; set; }
        public Nullable<decimal> DUSEPRI { get; set; }
        public Nullable<decimal> SEGMENT_ID { get; set; }
        public Nullable<decimal> DSEGMENT_ID { get; set; }
        public string SEGMENT_NAME { get; set; }
        public string DSEGMENT_NAME { get; set; }
        public Nullable<decimal> FCCCATEGORY { get; set; }
        public Nullable<decimal> DFCCCATEGORY { get; set; }
        public Nullable<decimal> USEANTGAIN { get; set; }
        public Nullable<decimal> DUSEANTGAIN { get; set; }
        public Nullable<decimal> SUPPORTAMR { get; set; }
        public Nullable<decimal> DSUPPORTAMR { get; set; }
        public Nullable<decimal> DIFFSTATE { get; set; }
        public decimal NSEI { get; set; }
        public decimal DNSEI { get; set; }
        public Nullable<decimal> GSMID { get; set; }
        public Nullable<decimal> DGSMID { get; set; }
        public Nullable<decimal> CITYTYPE { get; set; }
        public Nullable<decimal> DCITYTYPE { get; set; }
        public Nullable<decimal> MAXCELLRADIUSBACK { get; set; }
        public Nullable<decimal> DMAXCELLRADIUSBACK { get; set; }
        public Nullable<decimal> MAXCELLRADIUSFRONT { get; set; }
        public Nullable<decimal> DMAXCELLRADIUSFRONT { get; set; }
        public Nullable<decimal> ENABLELSCE { get; set; }
        public Nullable<decimal> DENABLELSCE { get; set; }
        public Nullable<decimal> DCODESCHEMAKEY { get; set; }
        public Nullable<decimal> DCODESCHEMATYPE { get; set; }
        public Nullable<decimal> CODESCHEMATYPE { get; set; }
        public Nullable<decimal> CODESCHEMAKEY { get; set; }
        public Nullable<decimal> DSIGNALLINGOVERHEAD { get; set; }
        public Nullable<decimal> SIGNALLINGOVERHEAD { get; set; }
        public decimal DLOGCELLTYPEFK { get; set; }
        public decimal LOGCELLTYPEFK { get; set; }
        public Nullable<decimal> DNBRLIMITALLTECHS { get; set; }
        public Nullable<decimal> DNBRLIMITINTERLTE { get; set; }
        public Nullable<decimal> DNBRLIMITINTERUMTS { get; set; }
        public Nullable<decimal> DNBRLIMITINTRAGSM { get; set; }
        public Nullable<decimal> NBRLIMITALLTECHS { get; set; }
        public Nullable<decimal> NBRLIMITINTERLTE { get; set; }
        public Nullable<decimal> NBRLIMITINTERUMTS { get; set; }
        public Nullable<decimal> NBRLIMITINTRAGSM { get; set; }
    
        public virtual DIFFLOGCELL DIFFLOGCELL { get; set; }
    }
}
