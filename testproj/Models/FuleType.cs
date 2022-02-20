using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class FuleType
    {
        public FuleType()
        {
            Vehicles = new HashSet<Vehicle>();
            VehiclesDeleteds = new HashSet<VehiclesDeleted>();
        }

        public int Id { get; set; }
        public string? FuelTypeName { get; set; }
        public string? TypeColor { get; set; }
        public double? MaxDensity { get; set; }
        public double? MinDensity { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<VehiclesDeleted> VehiclesDeleteds { get; set; }
    }
}
