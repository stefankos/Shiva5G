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
    
    public partial class DBVERSION
    {
        public decimal VERSIONNUMBER { get; set; }
        public Nullable<decimal> UPGRADEVERSION { get; set; }
        public Nullable<decimal> MINPATCHSUPPORTED { get; set; }
        public string MINPATCHBUILD { get; set; }
    }
}
