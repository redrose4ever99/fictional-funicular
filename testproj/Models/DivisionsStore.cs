using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class DivisionsStore
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsTashkeel { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
