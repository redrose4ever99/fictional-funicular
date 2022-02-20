using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OriginalQuotum
    {
        public int Id { get; set; }
        public decimal Quota { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsUpdated { get; set; }
        public long? LastUpdatedDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
