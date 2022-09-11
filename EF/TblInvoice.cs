using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblInvoice
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid FirstDataId { get; set; }
        public Guid SecondDataId { get; set; }
        public string UnitPrice { get; set; }
        public string Unit { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public string IndexDifference { get; set; }
        public string BillingPrice { get; set; }
        public string IndexMul { get; set; }
        public string InvoiceType { get; set; }
        public string FirstIndex { get; set; }
        public string SercondIndex { get; set; }
        public string Multiplier { get; set; }
        public string Kdv { get; set; }
    }
}
