using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Tagging
    {
        public int Id { get; set; }
        public decimal? CardNumber { get; set; }
        public decimal? TagNumber { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
