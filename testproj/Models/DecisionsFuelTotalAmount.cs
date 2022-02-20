using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DecisionsFuelTotalAmount
    {
        public string DecisionNumber { get; set; } = null!;
        public decimal? TotalAmount { get; set; }
        public int? MonthNo { get; set; }
        public int? YearNo { get; set; }
        public int? FuelType { get; set; }
        public string CatId { get; set; } = null!;
    }
}
