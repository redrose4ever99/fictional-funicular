using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwVehiclesTagsCount
    {
        public int Tagcount { get; set; }
        public string? VehiclePlateNo { get; set; }
        public string Title { get; set; } = null!;
        public int? CardNo { get; set; }
        public string? SubDivTitle { get; set; }
        public int? SortId { get; set; }
    }
}
