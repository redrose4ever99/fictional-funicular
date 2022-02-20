using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VNQ1
    {
        public int? VehicleId { get; set; }
        public decimal? Quota { get; set; }
        public bool? IsActive { get; set; }
        public int? ActivationMonth { get; set; }
        public int? ActivationYear { get; set; }
        public int? DivisionId { get; set; }
    }
}
