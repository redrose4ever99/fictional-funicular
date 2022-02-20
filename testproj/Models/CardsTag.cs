using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class CardsTag
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int TagId { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Card Card { get; set; } = null!;
        public virtual Tag Tag { get; set; } = null!;
    }
}
