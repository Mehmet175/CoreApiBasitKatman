using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblSayacPeriodResult
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string SerialNo { get; set; }
        public string BugunInduktif { get; set; }
        public string BugunKapasitif { get; set; }
        public string BugunEndeks { get; set; }
        public string BugunPara { get; set; }
        public string DunEndeks { get; set; }
        public string DunPara { get; set; }
        public string AylikEndeks { get; set; }
        public string AylikPara { get; set; }
        public string GecenAyEndeks { get; set; }
        public string GecenAyPara { get; set; }
        public string YillikEndeks { get; set; }
        public string YillikPara { get; set; }
        public string GecenYilEndeks { get; set; }
        public string GecenYilPara { get; set; }
        public string TotalEndeks { get; set; }
        public string TotalPara { get; set; }
        public DateTime? Datetime { get; set; }
        public string BugunAktifEndeksFarki { get; set; }
        public string BugunInduktifEndeksFarki { get; set; }
        public string BugunKapasitifEndeksFarki { get; set; }
    }
}
