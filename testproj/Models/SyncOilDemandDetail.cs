using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilDemandDetail
    {
        public Guid BillId { get; set; }
        public int OilType { get; set; }
        public decimal NeededAmount { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
