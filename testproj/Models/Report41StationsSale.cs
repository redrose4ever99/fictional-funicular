using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Report41StationsSale
    {
        public int? DivisionId { get; set; }
        public int? VehicleId { get; set; }
        public int? FuelType { get; set; }
        public long? SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public int? SaleTs { get; set; }
    }
}
