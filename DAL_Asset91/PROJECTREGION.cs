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
    
    public partial class PROJECTREGION
    {
        public decimal PROJECTNUMBER { get; set; }
        public decimal USERKEY { get; set; }
        public string NAME { get; set; }
        public string FILENAME { get; set; }
        public Nullable<decimal> ENABLED { get; set; }
    
        public virtual PROJECT PROJECT { get; set; }
    }
}
