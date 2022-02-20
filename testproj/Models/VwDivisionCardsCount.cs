using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwDivisionCardsCount
    {
        public int Id { get; set; }
        public int? CountOfLinked { get; set; }
        public int? CountOfNotLinked { get; set; }
        public string Title { get; set; } = null!;
    }
}
