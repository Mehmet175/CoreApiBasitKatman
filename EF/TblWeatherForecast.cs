using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblWeatherForecast
    {
        public Guid Id { get; set; }
        public int CityId { get; set; }
        public string Heat { get; set; }
        public string Icon { get; set; }
        public DateTime Datetime { get; set; }
        public string Humidity { get; set; }
        public string WindKph { get; set; }
        public string Day { get; set; }
    }
}
