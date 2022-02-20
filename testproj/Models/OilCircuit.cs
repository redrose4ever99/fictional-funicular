using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilCircuit
    {
        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public int OilCategoryId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual OilCircuitCategory OilCategory { get; set; } = null!;
    }
}
