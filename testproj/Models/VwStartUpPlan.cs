using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwStartUpPlan
    {
        public int? OriginalQuotaId { get; set; }
        public int Distanceconsumptionaverage { get; set; }
        public int? FuelType { get; set; }
        public int? CardNo { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string GroupName { get; set; } = null!;
        public string? VehicleDesciption { get; set; }
        public double? Distance { get; set; }
        public double? Calculated { get; set; }
        public int DecreaseRatio { get; set; }
        public int IsActive { get; set; }
        public int? VehicleId { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal? Hours { get; set; }
        public decimal Timeconsumptionaverage { get; set; }
    }
}
