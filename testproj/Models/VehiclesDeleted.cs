using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesDeleted
    {
        public int Id { get; set; }
        public string VehiclePlateNo { get; set; } = null!;
        public int? CardNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? VehicleModel { get; set; }
        public int? FuelType { get; set; }
        public int? Quota { get; set; }
        public int? DivisionId { get; set; }
        public int? OriginalQuotaId { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? AutomationRatio { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? PlanApproveDivId { get; set; }

        public virtual FuleType? FuelTypeNavigation { get; set; }
    }
}
