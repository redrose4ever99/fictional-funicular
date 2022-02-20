using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionQuotum
    {
        public int Id { get; set; }
        public int? YearNo { get; set; }
        public int? MonthNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? LastUpdateDate { get; set; }
        public int? LogicalId { get; set; }
        public int? CatId { get; set; }
        public int? Quota { get; set; }
        public int? DecisionId { get; set; }
        public int? SiteId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual FillingCategory? Cat { get; set; }
        public virtual Decision? Decision { get; set; }
        public virtual StoreLogicalCard? Logical { get; set; }
    }
}
