using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesUnit
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? UnitId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Unit? Unit { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
