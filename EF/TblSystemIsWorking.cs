using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblSystemIsWorking
    {
        public Guid Id { get; set; }
        public string SerialNo { get; set; }
        public DateTime Datetime { get; set; }
        public string Value { get; set; }
    }
}
