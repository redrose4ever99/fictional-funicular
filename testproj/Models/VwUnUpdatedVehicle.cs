using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwUnUpdatedVehicle
    {
        public int? Expr1 { get; set; }
        public string VehiclePlateNo { get; set; } = null!;
        public int? CardNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? VehicleModel { get; set; }
        public int? FuelType { get; set; }
        public int? OriginalQuotaId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
