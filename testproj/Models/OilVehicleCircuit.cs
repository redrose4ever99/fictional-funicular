using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilVehicleCircuit
    {
        public int VehicleGroupId { get; set; }
        public int OilType { get; set; }
        public int OilCircuitId { get; set; }
        public decimal Capacity { get; set; }
        public decimal ChangeRatio { get; set; }
        public decimal ReplaceRatio { get; set; }
        public decimal ChangeDistance { get; set; }
        public decimal ChangeHours { get; set; }
        public Guid Pk { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
