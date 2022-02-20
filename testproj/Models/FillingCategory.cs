using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class FillingCategory
    {
        public FillingCategory()
        {
            DivisionQuota = new HashSet<DivisionQuotum>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public int? CategoryDifinitionId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<DivisionQuotum> DivisionQuota { get; set; }
    }
}
