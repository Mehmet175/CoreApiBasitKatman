using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblPeriodResult
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Address { get; set; }
        public string TodayResult { get; set; }
        public string TodayMoney { get; set; }
        public string YesterdayResult { get; set; }
        public string YesterdayMoney { get; set; }
        public string MonthResult { get; set; }
        public string MonthMoney { get; set; }
        public string YearResult { get; set; }
        public string YearMoney { get; set; }
        public string TotalResult { get; set; }
        public string TotalMoney { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
