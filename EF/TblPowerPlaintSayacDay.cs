using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblPowerPlaintSayacDay
    {
        public Guid Id { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Address { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Day { get; set; }
        public double Price { get; set; }
    }
}
