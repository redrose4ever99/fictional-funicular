using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwMawqef
    {
        public string Title { get; set; } = null!;
        public int? Quota { get; set; }
        public int FuelType { get; set; }
        public int? CatId { get; set; }
        public int? YearNo { get; set; }
        public int? MonthNo { get; set; }
        public int? SumAmount { get; set; }
    }
}
