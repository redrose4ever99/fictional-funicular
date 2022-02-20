using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilChangeDate
    {
        public int Id { get; set; }
        public int OilCategoryId { get; set; }
        public int TashkeelId { get; set; }
        public DateTime ChangeDate { get; set; }
        public DateTime NextChangeDate { get; set; }
        public int? PlanId { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual OilCircuitCategory OilCategory { get; set; } = null!;
    }
}
