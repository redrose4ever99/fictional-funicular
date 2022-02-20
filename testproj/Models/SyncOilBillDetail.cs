using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilBillDetail
    {
        public Guid BillId { get; set; }
        public int OilDrumId { get; set; }
        public int AcceptedCount { get; set; }
        public int NeededCount { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
