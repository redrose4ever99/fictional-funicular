using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class LogicalsSite
    {
        public int Id { get; set; }
        public int LogicalId { get; set; }
        public int SiteId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsActive { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual StoreLogicalCard Logical { get; set; } = null!;
    }
}
