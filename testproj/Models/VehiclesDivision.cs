using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesDivision
    {
        public int Id { get; set; }
        public int? DivisionId { get; set; }
        public int? VehicleId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? Division { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
