using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilDrum
    {
        public OilDrum()
        {
            OilCardQuota = new HashSet<OilCardQuota>();
        }

        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public int OilType { get; set; }
        public decimal Capacity { get; set; }
        public int? IsBurned { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual OilType OilTypeNavigation { get; set; } = null!;
        public virtual ICollection<OilCardQuota> OilCardQuota { get; set; }
    }
}
