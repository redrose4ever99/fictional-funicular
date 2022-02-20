using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class QuotaAddition
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? MonthNo { get; set; }
        public int? YearNo { get; set; }
        public decimal? Quota { get; set; }
        public int? Distance { get; set; }
        public decimal? Hours { get; set; }
        public int? DecisionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Decision? Decision { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
