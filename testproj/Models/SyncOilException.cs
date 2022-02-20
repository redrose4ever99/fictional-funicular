using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SyncOilException
    {
        public DateTime ExStart { get; set; }
        public DateTime ExEnd { get; set; }
        public int? ObjectId { get; set; }
        public int ExType { get; set; }
        public string Reason { get; set; } = null!;
        public string? UserId { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int SiteId { get; set; }
    }
}
