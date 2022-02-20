using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class PlanCalculationDatum
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int? OriginalQuotaId { get; set; }
        public int? DivisionId { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public int? Timeconsumptionaverage { get; set; }
        public int? Distance { get; set; }
        public int? DecreaseRatio { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal? Hours { get; set; }
        public decimal? VehicleQuota { get; set; }
        public int? FuelType { get; set; }
        public string? Title { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int ActivationYear { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
