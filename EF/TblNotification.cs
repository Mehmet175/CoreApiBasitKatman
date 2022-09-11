using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblNotification
    {
        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public string Token { get; set; }
        public bool? Status { get; set; }
    }
}
