using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionPlanCalcResult
    {
        public int Id { get; set; }
        public int? DivisionId { get; set; }
        public int? Fuel0 { get; set; }
        public int? Fuel1 { get; set; }
        public int? Fuel2 { get; set; }
        public int? ActivationYear { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
