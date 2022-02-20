using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Decision
    {
        public Decision()
        {
            DivisionQuota = new HashSet<DivisionQuotum>();
            QuotaAdditions = new HashSet<QuotaAddition>();
        }

        public int Id { get; set; }
        public string DecisionNumber { get; set; } = null!;
        public DateTime? DecisionDate { get; set; }
        public int? IssuerDivisionId { get; set; }
        public int? RelatedDivisionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public int CatId { get; set; }
        public int? Cancled { get; set; }
        public int? YearNo { get; set; }
        public int? ApproveUserId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? IssuerDivision { get; set; }
        public virtual Division? RelatedDivision { get; set; }
        public virtual ICollection<DivisionQuotum> DivisionQuota { get; set; }
        public virtual ICollection<QuotaAddition> QuotaAdditions { get; set; }
    }
}
