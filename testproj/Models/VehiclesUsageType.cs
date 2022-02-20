using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesUsageType
    {
        public int Id { get; set; }
        public int? UsageTypeId { get; set; }
        public int? VehicleId { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual UsageType? UsageType { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
