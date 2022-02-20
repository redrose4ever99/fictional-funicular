using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwCardsVehiclesToSend
    {
        public int VehicleCardLinkId { get; set; }
        public int CardId { get; set; }
        public decimal CardNumber { get; set; }
        public int CardType { get; set; }
        public int IsActive { get; set; }
        public int PreAuthorize { get; set; }
        public int FuelType { get; set; }
        public int VehicleId { get; set; }
        public int? OriginalQuotaId { get; set; }
        public int? VehicleModel { get; set; }
        public decimal Quota { get; set; }
    }
}
