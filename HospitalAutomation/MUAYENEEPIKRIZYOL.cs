//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalAutomation
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUAYENEEPIKRIZYOL
    {
        public MUAYENEEPIKRIZYOL()
        {
            this.DOSYALARs = new HashSet<DOSYALAR>();
            this.MUAYENEEPIKRIZRESIMLERs = new HashSet<MUAYENEEPIKRIZRESIMLER>();
        }
    
        public int MuayeneEpikrizYolID { get; set; }
        public string MuayeneEpikrizYolKayit { get; set; }
    
        public virtual ICollection<DOSYALAR> DOSYALARs { get; set; }
        public virtual ICollection<MUAYENEEPIKRIZRESIMLER> MUAYENEEPIKRIZRESIMLERs { get; set; }
    }
}
