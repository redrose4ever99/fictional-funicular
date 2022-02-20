using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwAllVehiclesWithAllDatum
    {
        public int VehicleId { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? CardId { get; set; }
        public int? CardNo { get; set; }
        public int? FuelType { get; set; }
        public string? VehicleModel { get; set; }
        public int? VehicleModelId { get; set; }
        public int? DivisionId { get; set; }
        public string Title { get; set; } = null!;
        public int OriginalQuotaId { get; set; }
        public string? UsageType { get; set; }
        public int? UsageTypeId { get; set; }
        public string? VehicleGroup { get; set; }
        public int? VehicleGroupId { get; set; }
        public int? UnitId { get; set; }
        public string? UnitName { get; set; }
        public double? Distance { get; set; }
        public decimal Quota { get; set; }
        public decimal? CardNumber { get; set; }
        public string? FuelTypeName { get; set; }
        public int? CardFuelType { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Timeconsumptionaverage { get; set; }
        public int DecreaseRatio { get; set; }
        public string? SubDivTitle { get; set; }
    }
}
