using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwAllDivisionQuotum
    {
        public int? DivisionId { get; set; }
        public string Title { get; set; } = null!;
        public string? FuelTypeName { get; set; }
        public decimal? Quota { get; set; }
        public int? FuelType { get; set; }
    }
}
