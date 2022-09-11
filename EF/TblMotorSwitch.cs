using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblMotorSwitch
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public bool Status { get; set; }
        public string Tip { get; set; }
    }
}
