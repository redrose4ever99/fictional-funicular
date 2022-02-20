using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilCircuitCategory
    {
        public OilCircuitCategory()
        {
            OilChangeDates = new HashSet<OilChangeDate>();
            OilCircuits = new HashSet<OilCircuit>();
        }

        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public int ChangeEveryYrs { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<OilChangeDate> OilChangeDates { get; set; }
        public virtual ICollection<OilCircuit> OilCircuits { get; set; }
    }
}
