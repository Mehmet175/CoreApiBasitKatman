using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Models.ComplexType
{
    public class CtUser
    {
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }

    }
}
