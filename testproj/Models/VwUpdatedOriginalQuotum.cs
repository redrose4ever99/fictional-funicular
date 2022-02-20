using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwUpdatedOriginalQuotum
    {
        public int Id { get; set; }
        public decimal Quota { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsUpdated { get; set; }
        public long? LastUpdatedDate { get; set; }
        public int? DivisionId { get; set; }
        public decimal OldQuota { get; set; }
        public string? VehiclePlateNo { get; set; }
        public int? VehicleId { get; set; }
    }
}
