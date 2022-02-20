using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionsMaxQuotum
    {
        public int Id { get; set; }
        public int? DivisionId { get; set; }
        public decimal? Maxquota { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? DecisionNumber { get; set; }
        public string? Notes { get; set; }
        public int? FuelType { get; set; }
        public int? CategoryId { get; set; }
        public bool? Locked { get; set; }
        public int? ActivationYear { get; set; }
        public int? IsActive { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
