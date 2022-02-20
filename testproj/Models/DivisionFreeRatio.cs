using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionFreeRatio
    {
        public int Id { get; set; }
        public int? DivisionId { get; set; }
        public short? FreeCardsRatio { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Division? Division { get; set; }
    }
}
