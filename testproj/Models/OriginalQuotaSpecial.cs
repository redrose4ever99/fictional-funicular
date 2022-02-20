using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OriginalQuotaSpecial
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public decimal? Quota { get; set; }
        public decimal? Hours { get; set; }
        public int Distanse { get; set; }
        public int ActivationMonth { get; set; }
        public int ActivationYear { get; set; }
        public int? AutomationRatio { get; set; }
        public int? ActivationQuarter { get; set; }
        public bool? IsActive { get; set; }
        public long? LastUpdateDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? DecisionId { get; set; }
        public int? DivisionId { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
