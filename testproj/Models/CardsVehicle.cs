using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class CardsVehicle
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CardId { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Card Card { get; set; } = null!;
        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
