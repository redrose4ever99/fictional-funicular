using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class PlannedHour
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public decimal? Hours { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
    }
}
