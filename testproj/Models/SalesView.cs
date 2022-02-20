using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class SalesView
    {
        public int Id { get; set; }
        public int PumpId { get; set; }
        public long SaleId { get; set; }
        public int? TagId { get; set; }
        public int? CardId { get; set; }
        public long? SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? SiteId { get; set; }
        public int? DivisionId { get; set; }
        public int? OriginalSaleId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
