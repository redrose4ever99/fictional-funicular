using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class Card
    {
        public Card()
        {
            CardsTags = new HashSet<CardsTag>();
        }

        public int Id { get; set; }
        public decimal CardNumber { get; set; }
        public int CardType { get; set; }
        public int IsActive { get; set; }
        public int PreAuthorize { get; set; }
        public int FuelType { get; set; }
        public bool? IsUpdated { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? LastUpdatedDate { get; set; }
        public short? SiteType { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual CardsVehicle CardsVehicle { get; set; } = null!;
        public virtual ICollection<CardsTag> CardsTags { get; set; }
    }
}
