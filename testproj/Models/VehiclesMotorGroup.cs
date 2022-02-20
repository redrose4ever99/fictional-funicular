using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesMotorGroup
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? MotorGroupId { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual VehicleGroup? MotorGroup { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
