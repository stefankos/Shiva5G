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
    
    public partial class LINK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LINK()
        {
            this.BACKTOBACKANTENNAs = new HashSet<BACKTOBACKANTENNA>();
            this.LINKATTACHes = new HashSet<LINKATTACH>();
            this.PMPHUBLINKENDs = new HashSet<PMPHUBLINKEND>();
            this.PRLINKENDs = new HashSet<PRLINKEND>();
            this.PRLREFs = new HashSet<PRLREF>();
            this.PTPLINKENDs = new HashSet<PTPLINKEND>();
            this.REFLECTORs = new HashSet<REFLECTOR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal LINKKEY { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> ISTEMPLATE { get; set; }
        public string NAME1 { get; set; }
        public string NAME2 { get; set; }
        public Nullable<decimal> CLIMATICREGIONITU { get; set; }
        public Nullable<decimal> CLIMATICREGIONCRANE { get; set; }
        public Nullable<decimal> USECLIMREGION { get; set; }
        public Nullable<decimal> CLIMATEMODEL { get; set; }
        public Nullable<decimal> RAINRATE { get; set; }
        public Nullable<decimal> EXCESS { get; set; }
        public Nullable<decimal> CHANNELBASED { get; set; }
        public Nullable<decimal> FREQBANDKEY { get; set; }
        public string FREQCHANNEL { get; set; }
        public Nullable<decimal> DIVCHANNELBASED { get; set; }
        public Nullable<decimal> DIVFREQBANDKEY { get; set; }
        public string DIVFREQCHANNEL { get; set; }
        public Nullable<decimal> KFACTOR { get; set; }
        public Nullable<decimal> ALPHA { get; set; }
        public Nullable<decimal> CALCMETHOD { get; set; }
        public Nullable<decimal> TERRAIN5307 { get; set; }
        public Nullable<decimal> COASTALAREA { get; set; }
        public Nullable<decimal> PLVALUE { get; set; }
        public Nullable<decimal> COVERSCOASTAL { get; set; }
        public Nullable<decimal> COASTALPROP { get; set; }
        public Nullable<decimal> CLIMATETERRAIN { get; set; }
        public Nullable<decimal> CLITERFACTORC { get; set; }
        public Nullable<decimal> TERRAINROUGH { get; set; }
        public Nullable<decimal> CLIMATEFACTOR { get; set; }
        public Nullable<decimal> TERRAINROUGHFACTOR { get; set; }
        public Nullable<decimal> POINTREFRGRAD { get; set; }
        public Nullable<decimal> REGION { get; set; }
        public Nullable<decimal> PROPEFFECT { get; set; }
        public Nullable<decimal> SHORTPERIODVALUE { get; set; }
        public Nullable<decimal> SHORTPERIODUNIT { get; set; }
        public Nullable<decimal> SHORTPERIODTYPE { get; set; }
        public Nullable<decimal> OVERIDEOBSLOSS { get; set; }
        public Nullable<decimal> USEROBSLOSS { get; set; }
        public Nullable<decimal> LINKTYPEKEY { get; set; }
        public Nullable<decimal> LOSSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string FLAGVALUE { get; set; }
        public string LOSREQDATE { get; set; }
        public string DIRECTRADIOCAP { get; set; }
        public string DIRECTRADIOFAMILY { get; set; }
        public Nullable<decimal> OBJECTTYPE { get; set; }
        public Nullable<decimal> PTPFREQDIV { get; set; }
        public Nullable<decimal> USEAUTOCALCRAINRATE { get; set; }
        public Nullable<decimal> GRADE { get; set; }
        public Nullable<decimal> CLASS { get; set; }
        public Nullable<decimal> REFLINKLENGTH { get; set; }
        public Nullable<decimal> REFLINKLENGTHOVER { get; set; }
        public Nullable<decimal> ERRORPERFORMANCE { get; set; }
        public Nullable<decimal> USEITU_826 { get; set; }
        public Nullable<decimal> OVERHEAD { get; set; }
        public Nullable<decimal> USESINGLEVALUE { get; set; }
        public Nullable<decimal> SINGLECAPACITYVALUE { get; set; }
        public Nullable<decimal> PDHSDHMULTIPLE { get; set; }
        public Nullable<decimal> CAPACITYTYPE { get; set; }
        public Nullable<decimal> PERMISSION { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<decimal> USERGROUP { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
        public Nullable<decimal> RANGEPK { get; set; }
        public Nullable<decimal> LINKPARENTKEY { get; set; }
        public Nullable<decimal> POLARISATION { get; set; }
        public Nullable<decimal> DIVPOLARISATION { get; set; }
        public Nullable<decimal> RADIOCONFIGN { get; set; }
        public Nullable<decimal> RADIOCONFIGM { get; set; }
        public Nullable<decimal> REFLOSSA { get; set; }
        public Nullable<decimal> REFLOSSB { get; set; }
        public Nullable<decimal> LINKLENGTH { get; set; }
        public decimal CHANNELKEY { get; set; }
        public Nullable<decimal> TEMPRATUREFACTOR { get; set; }
        public decimal DIVCHANNELKEY { get; set; }
        public Nullable<decimal> DUPLEXMETHOD { get; set; }
        public Nullable<decimal> PACKETSIZE { get; set; }
        public Nullable<decimal> PACKETTYPE { get; set; }
        public Nullable<decimal> SYMMETRY { get; set; }
        public Nullable<decimal> SYNCDELAY { get; set; }
        public Nullable<decimal> SYNCMODE { get; set; }
        public Nullable<decimal> SYMMETRYMP { get; set; }
        public string INFOCOMMENTS { get; set; }
        public Nullable<decimal> HEADERSIZE { get; set; }
        public Nullable<decimal> ISLINKREVERSE { get; set; }
        public Nullable<decimal> VISIBILITY { get; set; }
        public Nullable<decimal> VISIBILITYGROUP { get; set; }
        public decimal DIVPREDMODELKEY { get; set; }
        public decimal PREDMODELKEY { get; set; }
        public Nullable<decimal> ACTUALLATENCY { get; set; }
        public Nullable<decimal> BBERMONTHVALUE { get; set; }
        public Nullable<decimal> BBEROBJECTIVEVALUE { get; set; }
        public Nullable<decimal> DIVREQFMAGAINSTRAIN { get; set; }
        public Nullable<decimal> DIVTOTALANTENNAGAIN { get; set; }
        public Nullable<decimal> DIVTOTALFEEDERLOSS { get; set; }
        public Nullable<decimal> ESMONTHVALUE { get; set; }
        public Nullable<decimal> ESROBJECTIVEVALUE { get; set; }
        public string OBJECTIVECALCMETHOD { get; set; }
        public Nullable<decimal> REQFMAGAINSTRAIN { get; set; }
        public Nullable<decimal> SESRMONTHVALUE { get; set; }
        public Nullable<decimal> SESROBJECTIVEVALUE { get; set; }
        public Nullable<decimal> TOTALANTENNAGAIN { get; set; }
        public Nullable<decimal> TOTALFEEDERLOSS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACKTOBACKANTENNA> BACKTOBACKANTENNAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINKATTACH> LINKATTACHes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMPHUBLINKEND> PMPHUBLINKENDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRLINKEND> PRLINKENDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRLREF> PRLREFs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PTPLINKEND> PTPLINKENDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFLECTOR> REFLECTORs { get; set; }
        public virtual LINKUDPROF LINKUDPROF { get; set; }
    }
}
