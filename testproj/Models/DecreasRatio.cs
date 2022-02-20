using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DecreasRatio
    {
        public int Id { get; set; }
        public int FuelTypeId { get; set; }
        public int DecreaseRatio { get; set; }
        public int IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? DecisionNumber { get; set; }
        public string? Notes { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
