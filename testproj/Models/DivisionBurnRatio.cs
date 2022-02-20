using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionBurnRatio
    {
        public int Id { get; set; }
        public int? DivisionId { get; set; }
        public decimal? BurnRatio { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
