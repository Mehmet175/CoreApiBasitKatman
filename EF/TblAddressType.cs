using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblAddressType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int? DataType { get; set; }
    }
}
