using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilAdd
    {
        public int Id { get; set; }
        public int OilType { get; set; }
        public int Amount { get; set; }
        public int Replace { get; set; }
        public int TashkeelId { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
