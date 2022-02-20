using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwVehicleInfo
    {
        public int? DivisionId { get; set; }
        public int? VehicleId { get; set; }
        public string Title { get; set; } = null!;
        public string? VehiclePlateNo { get; set; }
        public int? CardNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? VehicleModel { get; set; }
        public string? TypeName { get; set; }
        public int? FuelType { get; set; }
        public string? FuelTypeName { get; set; }
        public decimal Quota { get; set; }
        public string? Notes { get; set; }
        public int CardId { get; set; }
        public decimal CardNumber { get; set; }
        public int CardFuelType { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public double? Distance { get; set; }
    }
}
