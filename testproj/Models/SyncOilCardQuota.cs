using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilCardQuota
    {
        public int SiteId { get; set; }
        public int CardLogicalNo { get; set; }
        public int OilDrumId { get; set; }
        public DateTime AssignedDate { get; set; }
        public int ReplaceCount { get; set; }
        public int ChangeCount { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
