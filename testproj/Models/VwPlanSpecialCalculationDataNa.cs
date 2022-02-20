using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwPlanSpecialCalculationDataNa
    {
        public int? OriginalQuotaId { get; set; }
        public int? DivisionId { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int Distanceconsumptionaverage { get; set; }
        public decimal Timeconsumptionaverage { get; set; }
        public int DecreaseRatio { get; set; }
        public int? AutomationRatio { get; set; }
        public int? FuelType { get; set; }
        public int Distanse { get; set; }
        public decimal? Hours { get; set; }
        public int ActivationMonth { get; set; }
        public int ActivationYear { get; set; }
        public int VehicleId { get; set; }
    }
}
