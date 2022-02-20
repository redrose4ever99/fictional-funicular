using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class FreeVehicle
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? CardId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? UpdateDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
