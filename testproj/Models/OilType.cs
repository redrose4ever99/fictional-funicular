using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class OilType
    {
        public OilType()
        {
            OilDrums = new HashSet<OilDrum>();
        }

        public int Id { get; set; }
        public string Label { get; set; } = null!;
        public decimal? BurnRatio { get; set; }
        public string? MainCat { get; set; }
        public string? SubCat { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<OilDrum> OilDrums { get; set; }
    }
}
