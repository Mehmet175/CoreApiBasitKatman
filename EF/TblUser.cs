using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblUser
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string UserTypeId { get; set; }
        public string UserrName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreateUserId { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }
    }
}
