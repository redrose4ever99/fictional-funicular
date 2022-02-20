using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilCard
    {
        public int CardLogicalNo { get; set; }
        public decimal? CardPhysicalNumber { get; set; }
        public string TashkeelTitle { get; set; } = null!;
        public string DivisionTitle { get; set; } = null!;
        public string UnitTitle { get; set; } = null!;
        public int SiteId { get; set; }
        public bool Active { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
