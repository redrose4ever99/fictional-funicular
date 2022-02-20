using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilPlan
    {
        public OilPlan()
        {
            OilCardQuota = new HashSet<OilCardQuota>();
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public bool Approved { get; set; }
        public DateTime LastUpdate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<OilCardQuota> OilCardQuota { get; set; }
    }
}
