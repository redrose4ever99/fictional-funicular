using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwVehicleLookUp
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
        public int? OriginalQuotaId { get; set; }
        public string? UsageType { get; set; }
        public int? UsageTypeId { get; set; }
        public string? VehicleGroup { get; set; }
        public int? VehicleGroupId { get; set; }
        public int? UnitId { get; set; }
        public string? UnitName { get; set; }
        public double? Distance { get; set; }
        public decimal? Quota { get; set; }
        public string? CfuelTypeName { get; set; }
        public string? VfuelTypeName { get; set; }
        public int? CfuelT { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public int? TagId { get; set; }
        public int? AutomationRatio { get; set; }
    }
}
