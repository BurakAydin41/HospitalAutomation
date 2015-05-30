//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalAutomation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOSYALAR
    {
        public int DosyaID { get; set; }
        public string DosyaNo { get; set; }
        public int BolumID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int OgretimUyeID { get; set; }
        public int TanıID { get; set; }
        public int HastaStatuID { get; set; }
        public int MuayeneEpikrizID { get; set; }
        public int MuayeneEpikrizYolID { get; set; }
        public int TetkikRaporID { get; set; }
        public int TetkikRaporYolID { get; set; }
        public int AdliSaglikKuruluID { get; set; }
        public int AdliSaglikKuruluYolID { get; set; }
    
        public virtual ADLISAGLIKKURULU ADLISAGLIKKURULU { get; set; }
        public virtual ADLISAGLIKKURULUYOL ADLISAGLIKKURULUYOL { get; set; }
        public virtual MUAYENEEPIKRIZ MUAYENEEPIKRIZ { get; set; }
        public virtual MUAYENEEPIKRIZYOL MUAYENEEPIKRIZYOL { get; set; }
        public virtual OGRETIMUYELERİ OGRETIMUYELERİ { get; set; }
        public virtual STATU STATU { get; set; }
        public virtual TANILAR TANILAR { get; set; }
        public virtual TETKIKRAPORLAR TETKIKRAPORLAR { get; set; }
        public virtual TETKIKRAPORYOL TETKIKRAPORYOL { get; set; }
        public virtual BOLUMLER BOLUMLER { get; set; }
    }
}
