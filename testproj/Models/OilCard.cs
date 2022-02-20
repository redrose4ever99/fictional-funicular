using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilCard
    {
        public OilCard()
        {
            OilCardQuota = new HashSet<OilCardQuota>();
        }

        public int CardLogicalNo { get; set; }
        public decimal? CardPhysicalNumber { get; set; }
        public int TashkeelId { get; set; }
        public int DivisionId { get; set; }
        public int UnitId { get; set; }
        public int SiteId { get; set; }
        public bool? Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<OilCardQuota> OilCardQuota { get; set; }
    }
}
