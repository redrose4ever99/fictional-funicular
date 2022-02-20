using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehicleGroup
    {
        public VehicleGroup()
        {
            VehiclesMotorGroups = new HashSet<VehiclesMotorGroup>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; } = null!;
        public int CategoryId { get; set; }
        public int FuelType { get; set; }
        public decimal? EnginFuelCapacity { get; set; }
        public decimal Timeconsumptionaverage { get; set; }
        public int Distanceconsumptionaverage { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? EngineTypeId { get; set; }
        public int? EngineCapacity { get; set; }
        public int? MaingeartypeId { get; set; }
        public decimal? Maingearcapacity { get; set; }
        public int? SecondGearTypeId { get; set; }
        public decimal? SecondGearCapacity { get; set; }
        public int? FrontbridgeTypeId { get; set; }
        public decimal? FrontbridgeCapacity { get; set; }
        public int? MidlebridgetypId { get; set; }
        public decimal? MidlebridgeCapacity { get; set; }
        public int? BackBridgeTypeId { get; set; }
        public decimal? BackBridgeCapacity { get; set; }
        public int? SteringwheeltypId { get; set; }
        public decimal? SteringwheelCapacity { get; set; }
        public int? BraketypeId { get; set; }
        public decimal? BrakeCapacity { get; set; }
        public int? FlipflopcircuittypeId { get; set; }
        public decimal? FlipflopcircuitCapacity { get; set; }
        public int? CoolingcircuittypeId { get; set; }
        public decimal? CoolingcircuitCapacity { get; set; }
        public int? HidroliccirctypeId { get; set; }
        public decimal? HidroliccircCacacity { get; set; }
        public int? HasTwoTags { get; set; }
        public decimal? MilfafCapacity { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual VehicleType Category { get; set; } = null!;
        public virtual ICollection<VehiclesMotorGroup> VehiclesMotorGroups { get; set; }
    }
}
