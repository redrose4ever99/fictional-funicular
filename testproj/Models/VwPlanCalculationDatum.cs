using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwPlanCalculationDatum
    {
        public int VehicleId { get; set; }
        public int? OriginalQuotaId { get; set; }
        public int? DivisionId { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int Distanceconsumptionaverage { get; set; }
        public decimal Timeconsumptionaverage { get; set; }
        public double Distance { get; set; }
        public int DecreaseRatio { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal Hours { get; set; }
        public int? FuelType { get; set; }
        public string Title { get; set; } = null!;
    }
}
