using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class PlanStoppedVehilce
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public DateTime CreationDate { get; set; }
        public int DivisionId { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
