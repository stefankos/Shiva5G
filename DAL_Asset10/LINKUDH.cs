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
    
    public partial class LINKUDH
    {
        public decimal LINKKEYPK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal DISTANCE { get; set; }
        public Nullable<decimal> DTM { get; set; }
        public Nullable<decimal> CLUTTERVALUE { get; set; }
        public Nullable<decimal> BUILDINGVECTOR { get; set; }
        public Nullable<decimal> BUILDINGRASTER { get; set; }
        public Nullable<decimal> UDTMVALUE { get; set; }
        public Nullable<decimal> UCLUTTERVALUE { get; set; }
        public Nullable<decimal> UOBSTRUCTIONVALUE { get; set; }
        public Nullable<decimal> THEIGHT { get; set; }
        public Nullable<decimal> LOSCLEAR { get; set; }
        public Nullable<decimal> FRESCLEAR { get; set; }
        public Nullable<decimal> MODIFYUSER { get; set; }
    
        public virtual LINKUDPROF LINKUDPROF { get; set; }
    }
}
