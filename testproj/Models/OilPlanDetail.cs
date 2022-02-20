using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilPlanDetail
    {
        public int PlanId { get; set; }
        public int TashkeelId { get; set; }
        public int? FuelCategoryId { get; set; }
        public int VehicleId { get; set; }
        public int OilType { get; set; }
        public int PlanDetailType { get; set; }
        public DateTime LastUpdate { get; set; }
        public Guid Pk { get; set; }
        public decimal? ReplaceQuota2 { get; set; }
        public decimal? ChangeQuota2 { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
