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
    
    public partial class PREDICTIONMODEL
    {
        public decimal PROJECTNO { get; set; }
        public decimal MODELKEY { get; set; }
        public string MODELTYPE { get; set; }
        public string SYSTEMPARAMS { get; set; }
        public string MODELPARAMS { get; set; }
        public string COMMENTS { get; set; }
        public string IDNAME { get; set; }
        public Nullable<decimal> CREATEUSER { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public decimal MODIFYUSER { get; set; }
    }
}
