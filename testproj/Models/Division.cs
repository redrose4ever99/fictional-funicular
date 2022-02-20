using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Division
    {
        public Division()
        {
            DecisionIssuerDivisions = new HashSet<Decision>();
            DecisionRelatedDivisions = new HashSet<Decision>();
            DivisionFreeRatios = new HashSet<DivisionFreeRatio>();
            UnApprovedDivisionFuels = new HashSet<UnApprovedDivisionFuel>();
            Units = new HashSet<Unit>();
            VehicleRepairDivisionIdinNavigations = new HashSet<VehicleRepair>();
            VehicleRepairDivisionIdoutNavigations = new HashSet<VehicleRepair>();
            VehiclesDivisions = new HashSet<VehiclesDivision>();
            VehiclesSubDivisions = new HashSet<VehiclesSubDivision>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsTashkeel { get; set; }
        public int? SortId { get; set; }
        public int? TmpId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Decision> DecisionIssuerDivisions { get; set; }
        public virtual ICollection<Decision> DecisionRelatedDivisions { get; set; }
        public virtual ICollection<DivisionFreeRatio> DivisionFreeRatios { get; set; }
        public virtual ICollection<UnApprovedDivisionFuel> UnApprovedDivisionFuels { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<VehicleRepair> VehicleRepairDivisionIdinNavigations { get; set; }
        public virtual ICollection<VehicleRepair> VehicleRepairDivisionIdoutNavigations { get; set; }
        public virtual ICollection<VehiclesDivision> VehiclesDivisions { get; set; }
        public virtual ICollection<VehiclesSubDivision> VehiclesSubDivisions { get; set; }
    }
}
