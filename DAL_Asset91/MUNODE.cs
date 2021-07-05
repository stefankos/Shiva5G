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
    
    public partial class MUNODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUNODE()
        {
            this.LOGIS95CAR = new HashSet<LOGIS95CAR>();
            this.LOGIS95CLSITE = new HashSet<LOGIS95CLSITE>();
            this.LOGLTECAR = new HashSet<LOGLTECAR>();
            this.LOGUMTSCAR = new HashSet<LOGUMTSCAR>();
            this.LOGWIFICAR = new HashSet<LOGWIFICAR>();
            this.LOGWIMAXCAR = new HashSet<LOGWIMAXCAR>();
            this.LOGWIMAXMOBCAR = new HashSet<LOGWIMAXMOBCAR>();
        }
    
        public decimal PROJECTNO { get; set; }
        public decimal LOGNODEPK { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal SUPPORTEDTECHNOLOGY { get; set; }
        public decimal SUPPORTEDTECHNOLOGYDATA { get; set; }
        public Nullable<decimal> NODEID { get; set; }
        public Nullable<decimal> AGGREGATECAPACITY { get; set; }
        public Nullable<decimal> HEXRADIUS { get; set; }
        public Nullable<decimal> MINSECTORS { get; set; }
        public Nullable<decimal> MAXSECTORS { get; set; }
        public Nullable<decimal> GRDCSTRNTFLAGS { get; set; }
        public Nullable<decimal> NETWORKLEVEL { get; set; }
        public Nullable<decimal> CABINKEY { get; set; }
        public Nullable<decimal> BTSKEY { get; set; }
        public Nullable<decimal> TOWERKEY { get; set; }
        public Nullable<decimal> BTSFIXED { get; set; }
        public Nullable<decimal> NODEBTYPEFK { get; set; }
        public Nullable<decimal> RES1ULTOT { get; set; }
        public Nullable<decimal> RES1DLTOT { get; set; }
        public Nullable<decimal> RES1ULPRI { get; set; }
        public Nullable<decimal> RES1DLPRI { get; set; }
        public Nullable<decimal> RES1ULHO { get; set; }
        public Nullable<decimal> RES1DLHO { get; set; }
        public Nullable<decimal> RES2ULTOT { get; set; }
        public Nullable<decimal> RES2DLTOT { get; set; }
        public Nullable<decimal> RES2ULPRI { get; set; }
        public Nullable<decimal> RES2DLPRI { get; set; }
        public Nullable<decimal> RES2ULHO { get; set; }
        public Nullable<decimal> RES2DLHO { get; set; }
        public Nullable<decimal> RES3ULTOT { get; set; }
        public Nullable<decimal> RES3DLTOT { get; set; }
        public Nullable<decimal> RES3ULPRI { get; set; }
        public Nullable<decimal> RES3DLPRI { get; set; }
        public Nullable<decimal> RES3ULHO { get; set; }
        public Nullable<decimal> RES3DLHO { get; set; }
        public Nullable<decimal> NUMCHANSPOOL { get; set; }
        public Nullable<decimal> NFVELEMENT { get; set; }
        public string NFVHOSTID { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIS95CAR> LOGIS95CAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGIS95CLSITE> LOGIS95CLSITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGLTECAR> LOGLTECAR { get; set; }
        public virtual LOGNODE LOGNODE { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGUMTSCAR> LOGUMTSCAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIFICAR> LOGWIFICAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIMAXCAR> LOGWIMAXCAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOGWIMAXMOBCAR> LOGWIMAXMOBCAR { get; set; }
    }
}
