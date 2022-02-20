using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VNQO
    {
        public int? VehicleId { get; set; }
        public decimal? Quota { get; set; }
        public bool? IsActive { get; set; }
        public int? ActivationMonth { get; set; }
        public int? ActivationYear { get; set; }
        public int? DivisionId { get; set; }
        public int? Mo { get; set; }
    }
}
