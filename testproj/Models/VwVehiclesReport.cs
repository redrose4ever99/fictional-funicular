using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class VwVehiclesReport
    {
        public int تسلسلي { get; set; }
        public string? رقمالعربة { get; set; }
        public string? النوع { get; set; }
        public int? البطاقة { get; set; }
        public string? الطراز { get; set; }
        public string التشكيل { get; set; } = null!;
        public string? نوعالوقود { get; set; }
        public int? الاستهلاك { get; set; }
        public int? نسبةالأتمتة { get; set; }
        public string? نوعالاستخدام { get; set; }
        public string? مجموعةالمركبة { get; set; }
        public string? تتبعللمجموعة { get; set; }
        public double? المسافةالمقررة { get; set; }
        public decimal? الساعاتالمقررة { get; set; }
        public int? CardId { get; set; }
        public int? DivisionId { get; set; }
        public int? FuelType { get; set; }
        public int? AutomationRatio { get; set; }
    }
}
