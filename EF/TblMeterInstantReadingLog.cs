using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblMeterInstantReadingLog
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? Result { get; set; }
    }
}
