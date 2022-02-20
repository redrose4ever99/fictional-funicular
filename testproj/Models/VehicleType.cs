using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            VehicleGroups = new HashSet<VehicleGroup>();
        }

        public int Id { get; set; }
        public string? TypeName { get; set; }
        public double? TypeId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<VehicleGroup> VehicleGroups { get; set; }
    }
}
