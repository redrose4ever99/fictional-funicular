using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesNonAutomatedQuotum
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public decimal? Quota { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public int? ActivationMonth { get; set; }
        public int? ActivationYear { get; set; }
        public int? DivisionId { get; set; }
        public int? AutomationRatio { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
    }
}
