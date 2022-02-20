using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehicleRepair
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public DateTime RepairStartDate { get; set; }
        public int UserId { get; set; }
        public DateTime? RepairEndDate { get; set; }
        public int? EndUserId { get; set; }
        public string? Comments { get; set; }
        public DateTime CreationDate { get; set; }
        public int? ActivatorId { get; set; }
        public int? EndActivatorId { get; set; }
        public int? DivisionIdin { get; set; }
        public int? DivisionIdout { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? DivisionIdinNavigation { get; set; }
        public virtual Division? DivisionIdoutNavigation { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
