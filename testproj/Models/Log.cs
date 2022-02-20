using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? UserId { get; set; }
        public string? TableName { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
