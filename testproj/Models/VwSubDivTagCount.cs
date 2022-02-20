using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwSubDivTagCount
    {
        public string? التشكيل { get; set; }
        public string? الوحدة { get; set; }
        public string العربة { get; set; } = null!;
        public int? رقمالبطاقة { get; set; }
        public string طرازالعربة { get; set; } = null!;
        public int عددالحساسات { get; set; }
        public string? المادة { get; set; }
        public int? SortId { get; set; }
    }
}
