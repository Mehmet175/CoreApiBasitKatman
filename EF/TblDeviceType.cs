using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDeviceType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Port { get; set; }
    }
}
