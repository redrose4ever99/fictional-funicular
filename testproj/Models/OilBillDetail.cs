using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilBillDetail
    {
        public int Id { get; set; }
        public Guid BillId { get; set; }
        public int OilDrumId { get; set; }
        public int NeededCount { get; set; }
        public int AcceptedCount { get; set; }
        public DateTime DummyDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
