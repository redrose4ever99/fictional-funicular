using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class ActivationStatus
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Status { get; set; }
        public string? Note { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
