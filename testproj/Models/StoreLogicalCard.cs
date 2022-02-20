using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class StoreLogicalCard
    {
        public StoreLogicalCard()
        {
            DivisionQuota = new HashSet<DivisionQuotum>();
            LogicalsSites = new HashSet<LogicalsSite>();
        }

        public int Id { get; set; }
        public int CardNo { get; set; }
        public int DivisionId { get; set; }
        public int? SubDivId { get; set; }
        public int? ChildDivId { get; set; }
        public int FuelType { get; set; }
        public decimal? CardNumber { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? LastUpdateDate { get; set; }
        public int? CardType { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<DivisionQuotum> DivisionQuota { get; set; }
        public virtual ICollection<LogicalsSite> LogicalsSites { get; set; }
    }
}
