using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblStatusHandlerScada
    {
        public Guid Id { get; set; }
        public string Ip { get; set; }
        public string Asdu { get; set; }
        public string Address { get; set; }
        public string Value { get; set; }
        public DateTime Datetime { get; set; }
        public string Port { get; set; }
    }
}
