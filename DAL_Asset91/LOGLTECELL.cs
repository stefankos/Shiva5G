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
    
    public partial class LOGLTECELL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGLTECELL()
        {
            this.LOGLTECELLCAR = new HashSet<LOGLTECELLCAR>();
            this.LOGLTEFEEDER = new HashSet<LOGLTEFEEDER>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal LOGCELLPK { get; set; }
        public Nullable<decimal> CELLID { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
        public Nullable<byte> SUMIMODLSUPPORT { get; set; }
        public Nullable<byte> SUMIMOULSUPPORT { get; set; }
        public Nullable<decimal> SUMIMODLSPATIALMODE { get; set; }
        public Nullable<decimal> SUMIMOULSPATIALMODE { get; set; }
        public Nullable<decimal> SUMIMOTXELEMS { get; set; }
        public Nullable<decimal> SUMIMORXELEMS { get; set; }
        public Nullable<byte> MUMIMODLSUPPORT { get; set; }
        public Nullable<byte> MUMIMOULSUPPORT { get; set; }
        public Nullable<decimal> MUMIMODLTERMS { get; set; }
        public Nullable<decimal> MUMIMOULTERMS { get; set; }
        public Nullable<byte> BEAMFORMINGSUPPORT { get; set; }
        public Nullable<decimal> BEAMFORMARRAYELEMS { get; set; }
        public Nullable<decimal> DLIRFACTOR { get; set; }
        public Nullable<decimal> ULIRFACTOR { get; set; }
        public Nullable<decimal> NBRLIMITINTRAINTRA { get; set; }
        public Nullable<decimal> NBRLIMITINTRAINTER { get; set; }
        public Nullable<decimal> NBRLIMITINTERGSM { get; set; }
        public Nullable<decimal> NBRLIMITINTERUMTS { get; set; }
        public Nullable<decimal> NBRLIMITINTERCDMA { get; set; }
        public Nullable<decimal> SIGNALLINGOVERHEAD { get; set; }
        public Nullable<decimal> TAC { get; set; }
        public Nullable<decimal> LOGCELLTYPEFK { get; set; }
        public Nullable<decimal> ACTUAL_RANGE { get; set; }
        public Nullable<byte> ASSIGNED_FIRST_RSI { get; set; }
        public Nullable<byte> ASSIGNED_NUM_RSI { get; set; }
        public Nullable<bool> AUTO_UPDATE_PRE_FMT { get; set; }
        public Nullable<decimal> DELAY_SPREAD { get; set; }
        public Nullable<bool> HIGH_SPEED_FLAG { get; set; }
        public Nullable<byte> NUM_CYCLIC_SHIFT { get; set; }
        public Nullable<byte> PRACH_CONFIG_INDEX { get; set; }
        public Nullable<byte> PRACH_FREQ_OFFSET { get; set; }
        public Nullable<byte> PREAMBLE_FORMAT { get; set; }
        public Nullable<byte> REQ_NUM_RSI { get; set; }
        public Nullable<bool> RSI_CALC_METHOD { get; set; }
        public Nullable<decimal> SCHEMA_FK { get; set; }
        public Nullable<byte> ZERO_CORRLTN_ZONE { get; set; }
        public Nullable<decimal> NBRLIMITALLTECHS { get; set; }
    
        public virtual LOGCELL LOGCELL { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
        public virtual LTERSISCHEMA LTERSISCHEMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECELLCAR> LOGLTECELLCAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTEFEEDER> LOGLTEFEEDER { get; set; }
    }
}
