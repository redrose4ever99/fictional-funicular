using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            PlanCalculationData = new HashSet<PlanCalculationDatum>();
            PlannedDistances = new HashSet<PlannedDistance>();
            PlannedHours = new HashSet<PlannedHour>();
            QuotaAdditions = new HashSet<QuotaAddition>();
            VehicleRepairs = new HashSet<VehicleRepair>();
            VehiclesDivisions = new HashSet<VehiclesDivision>();
            VehiclesMotorGroups = new HashSet<VehiclesMotorGroup>();
            VehiclesNonAutomatedQuota = new HashSet<VehiclesNonAutomatedQuotum>();
            VehiclesSubDivisions = new HashSet<VehiclesSubDivision>();
            VehiclesUnits = new HashSet<VehiclesUnit>();
            VehiclesUsageTypes = new HashSet<VehiclesUsageType>();
        }

        public int Id { get; set; }
        public string VehiclePlateNo { get; set; } = null!;
        public int? CardNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? VehicleModel { get; set; }
        public int? FuelType { get; set; }
        public int? Quota { get; set; }
        public int? DivisionId { get; set; }
        public int? OriginalQuotaId { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? AutomationRatio { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? PlanApproveDivId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual FuleType? FuelTypeNavigation { get; set; }
        public virtual CardsVehicle CardsVehicle { get; set; } = null!;
        public virtual ICollection<PlanCalculationDatum> PlanCalculationData { get; set; }
        public virtual ICollection<PlannedDistance> PlannedDistances { get; set; }
        public virtual ICollection<PlannedHour> PlannedHours { get; set; }
        public virtual ICollection<QuotaAddition> QuotaAdditions { get; set; }
        public virtual ICollection<VehicleRepair> VehicleRepairs { get; set; }
        public virtual ICollection<VehiclesDivision> VehiclesDivisions { get; set; }
        public virtual ICollection<VehiclesMotorGroup> VehiclesMotorGroups { get; set; }
        public virtual ICollection<VehiclesNonAutomatedQuotum> VehiclesNonAutomatedQuota { get; set; }
        public virtual ICollection<VehiclesSubDivision> VehiclesSubDivisions { get; set; }
        public virtual ICollection<VehiclesUnit> VehiclesUnits { get; set; }
        public virtual ICollection<VehiclesUsageType> VehiclesUsageTypes { get; set; }
    }
}
