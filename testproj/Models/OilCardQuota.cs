using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilCardQuota
    {
        public int SyncId { get; set; }
        public int CardLogicalNo { get; set; }
        public int PlanId { get; set; }
        public int OilDrumId { get; set; }
        public int ReplaceCount { get; set; }
        public int ChangeCount { get; set; }
        public bool Approved { get; set; }
        public DateTime AssignedDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual OilCard CardLogicalNoNavigation { get; set; } = null!;
        public virtual OilDrum OilDrum { get; set; } = null!;
        public virtual OilPlan Plan { get; set; } = null!;
    }
}
