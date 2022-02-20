using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionYearCalcualationResult
    {
        public int Id { get; set; }
        public int? YearNo { get; set; }
        public int? DivisionId { get; set; }
        public decimal? AutomatedQuota { get; set; }
        public decimal? NonAuotomatedQuota { get; set; }
        public int? FuelType { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Fixed { get; set; }
        public bool? Fixed1 { get; set; }
        public bool? Fixed2 { get; set; }
        public bool? Fixed3 { get; set; }
        public bool? Fixed4 { get; set; }
        public bool? Fixed5 { get; set; }
        public bool? Fixed6 { get; set; }
        public bool? Fixed7 { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
