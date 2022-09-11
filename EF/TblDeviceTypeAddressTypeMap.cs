using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDeviceTypeAddressTypeMap
    {
        public Guid Id { get; set; }
        public Guid DeviceTypeId { get; set; }
        public Guid AddressTypeId { get; set; }
        public string Address { get; set; }
    }
}
