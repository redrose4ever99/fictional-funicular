using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class WarActivationCard
    {
        public int CardNo { get; set; }
        public decimal? CardNumber { get; set; }
        public int? RegionId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
