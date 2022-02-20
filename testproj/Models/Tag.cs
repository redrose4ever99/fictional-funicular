using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public decimal TagNumber { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual CardsTag CardsTag { get; set; } = null!;
    }
}
