using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblMeterInstantReading
    {
        public Guid Id { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
    }
}
