using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class GetlastVinfo
    {
        public string? VehiclePlateNo { get; set; }
        public string? VehicleDesciption { get; set; }
        public int? Distanceconsumptionaverage { get; set; }
        public int? Timeconsumptionaverage { get; set; }
        public int? Distance { get; set; }
        public int? AutomationRatio { get; set; }
        public decimal? Hours { get; set; }
        public decimal? VehicleQuota { get; set; }
        public string? Title { get; set; }
        public int VehicleId { get; set; }
    }
}
