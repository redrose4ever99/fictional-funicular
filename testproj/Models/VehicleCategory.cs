using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VehicleCategory
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public double? CreationDate { get; set; }
        public double? UpdateDate { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
