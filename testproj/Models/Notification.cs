using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public int? UserId { get; set; }
        public string? Note { get; set; }
        public int? FormId { get; set; }
        public int? ToUserId { get; set; }
        public DateTime? Ended { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
