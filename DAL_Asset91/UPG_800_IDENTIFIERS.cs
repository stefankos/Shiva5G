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
    
    public partial class UPG_800_IDENTIFIERS
    {
        public decimal IDENTIFIERS_PK { get; set; }
        public decimal OBJECT_TYPE_ID { get; set; }
        public decimal SUBTYPE_ID { get; set; }
        public Nullable<decimal> ID_SCHEME { get; set; }
        public decimal BASE_STRING_ENABLED { get; set; }
        public string BASE_STRING { get; set; }
        public string COMBINED_STRING { get; set; }
        public decimal PADDING_MIN_ENABLED { get; set; }
        public Nullable<decimal> PADDING_MIN { get; set; }
        public decimal ENFORCE_NAME_ENABLED { get; set; }
        public string PATTERN_STRING { get; set; }
        public decimal UPDATE_CELLS_ENABLED { get; set; }
        public string IDNAME { get; set; }
        public decimal CREATEUSER { get; set; }
        public decimal MODIFYUSER { get; set; }
        public decimal USERGROUP { get; set; }
        public decimal PERMISSION { get; set; }
        public System.DateTime CREATEDATE { get; set; }
        public System.DateTime MODIFYDATE { get; set; }
        public decimal PROJECTNO { get; set; }
    }
}
