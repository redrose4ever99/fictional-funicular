using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class UsageType
    {
        public UsageType()
        {
            VehiclesUsageTypes = new HashSet<VehiclesUsageType>();
        }

        public int Id { get; set; }
        public string? UsageName { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<VehiclesUsageType> VehiclesUsageTypes { get; set; }
    }
}
