using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDeviceStatuLog
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public bool Modem { get; set; }
        public bool Medas { get; set; }
        public bool Port { get; set; }
        public bool Salter { get; set; }
        public bool Sure { get; set; }
        public bool Kesici { get; set; }
        public string Value { get; set; }
        public DateTime Datetime { get; set; }
    }
}
