using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehiclesSubDivision
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? SubDivisionId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? SubDivision { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
