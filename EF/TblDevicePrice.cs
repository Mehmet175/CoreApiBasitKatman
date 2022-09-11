using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDevicePrice
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public string Type { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}
