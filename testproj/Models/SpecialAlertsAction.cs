using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SpecialAlertsAction
    {
        public int Id { get; set; }
        public int? AlertId { get; set; }
        public int? Userid { get; set; }
        public string? TableName { get; set; }
        public int? RecordId { get; set; }
        public int? SiteId { get; set; }
        public string? Notes { get; set; }
        public DateTime? AlertDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
