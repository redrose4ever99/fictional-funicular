using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class UnApprovedDivisionFuel
    {
        public int Id { get; set; }
        public int DivisionId { get; set; }
        public int FuelType { get; set; }
        public int YearNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division Division { get; set; } = null!;
    }
}
