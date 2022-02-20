using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilPlanTashkeelDetail
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int TashkeelId { get; set; }
        public int OilType { get; set; }
        public decimal ReplaceQuota { get; set; }
        public decimal ChangeQuota { get; set; }
        public decimal BurnRatio { get; set; }
        public decimal ChangeRoundup { get; set; }
        public decimal ReplaceRoundup { get; set; }
        public bool HasBurnException { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
