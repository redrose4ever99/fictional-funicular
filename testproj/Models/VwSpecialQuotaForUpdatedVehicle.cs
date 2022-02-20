using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwSpecialQuotaForUpdatedVehicle
    {
        public int? VehicleId { get; set; }
        public int? ActivationMonth { get; set; }
        public int? ActivationYear { get; set; }
        public decimal? Quota { get; set; }
        public int? DivisionId { get; set; }
    }
}
