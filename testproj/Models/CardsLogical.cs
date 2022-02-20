using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class CardsLogical
    {
        public int Id { get; set; }
        public int? CardId { get; set; }
        public int? LogicalId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
