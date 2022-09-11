using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDistrict
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
