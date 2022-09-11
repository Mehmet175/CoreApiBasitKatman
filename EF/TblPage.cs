using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblPage
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int Must1 { get; set; }
        public int Must2 { get; set; }
        public int Must3 { get; set; }
        public bool Status { get; set; }
    }
}
