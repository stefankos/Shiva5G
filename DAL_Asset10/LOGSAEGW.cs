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
    
    public partial class LOGSAEGW
    {
        public decimal LOGNODEPK { get; set; }
        public decimal LOGNODETYPEFK { get; set; }
        public decimal PROJECTNO { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual LOGNODE LOGNODE { get; set; }
        public virtual LOGNODETYPE LOGNODETYPE { get; set; }
    }
}
