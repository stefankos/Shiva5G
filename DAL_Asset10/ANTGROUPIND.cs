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
    
    public partial class ANTGROUPIND
    {
        public decimal PROJECTNO { get; set; }
        public decimal GPINDEXPK { get; set; }
        public decimal CONFGRPFK { get; set; }
        public decimal DEVICEFK { get; set; }
        public decimal BEAMINDEX { get; set; }
        public decimal SSBINDEX { get; set; }
        public decimal CTRLBEAM { get; set; }
        public decimal TRAFBEAM { get; set; }
        public decimal CTRLINDEX { get; set; }
        public decimal TRAFINDEX { get; set; }
        public decimal MODIFYUSER { get; set; }
    
        public virtual ANTCONFGROUP ANTCONFGROUP { get; set; }
        public virtual ANTENNADEVICE ANTENNADEVICE { get; set; }
    }
}
