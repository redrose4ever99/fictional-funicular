using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilBill
    {
        public Guid BillId { get; set; }
        public int SiteId { get; set; }
        public int? OfficeId { get; set; }
        public int? UserId { get; set; }
        public int? CardLogicalNo { get; set; }
        public DateTime BillDate { get; set; }
        public int BillType { get; set; }
        public bool? Burnt { get; set; }
        public int EmptyDrums { get; set; }
        public string? Note { get; set; }
        public int Reference { get; set; }
        public string? DriverName { get; set; }
        public string? RepresenterName { get; set; }
        public string? TankerPlateNo { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
