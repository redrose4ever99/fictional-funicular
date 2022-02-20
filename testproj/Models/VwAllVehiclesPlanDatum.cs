using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwAllVehiclesPlanDatum
    {
        public int VehicleId { get; set; }
        public string VehiclePlateNo { get; set; } = null!;
        public string? VehicleDesciption { get; set; }
        public int? CardNo { get; set; }
        public int? FuelType { get; set; }
        public int? VehicleModelId { get; set; }
        public int? DivisionId { get; set; }
        public string Title { get; set; } = null!;
        public int OriginalQuotaId { get; set; }
        public string? VehicleGroup { get; set; }
        public int? VehicleGroupId { get; set; }
        public double? Distance { get; set; }
        public decimal Quota { get; set; }
        public string? FuelTypeName { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Timeconsumptionaverage { get; set; }
        public int DecreaseRatio { get; set; }
        public decimal? NonAutomatedQuota { get; set; }
    }
}
