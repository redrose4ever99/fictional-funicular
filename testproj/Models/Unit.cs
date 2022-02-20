using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Unit
    {
        public Unit()
        {
            VehiclesUnits = new HashSet<VehiclesUnit>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Title { get; set; }
        public long? OracleCreationDate { get; set; }
        public long? OracleUpdateDate { get; set; }
        public bool? IsAcive { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? Parent { get; set; }
        public virtual ICollection<VehiclesUnit> VehiclesUnits { get; set; }
    }
}
