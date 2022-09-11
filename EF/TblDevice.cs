using System;
using System.Collections.Generic;

#nullable disable

namespace DenemeApi.EF
{
    public partial class TblDevice
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Asdu { get; set; }
        public string SerialNo { get; set; }
        public string DeviceType { get; set; }
        public string DeviceKw { get; set; }
        public Guid DeviceTypeId { get; set; }
        public string DeviceName { get; set; }
        public string Address { get; set; }
        public string UnitPrice { get; set; }
        public string Unit { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreateUserId { get; set; }
        public DateTime LicenceFinishDate { get; set; }
        public int Must { get; set; }
        public bool Status { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Multiplier { get; set; }
        public string Appellation { get; set; }
        public string AboneNo { get; set; }
        public string TekilNo { get; set; }
        public string SozlesmeGucu { get; set; }
        public Guid SubCompanyId { get; set; }
        public bool? Visibility { get; set; }
        public string UnitPriceBuy { get; set; }
    }
}
