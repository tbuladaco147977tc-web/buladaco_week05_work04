using System;

namespace Buladaco_week05_work004
{
    internal sealed class Product
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }
        public bool IsActive { get; set; }
        public decimal Cost { get; set; }
        public decimal Markup { get; set; }
        public decimal Price { get; set; }
    }

    internal static class ProductStore
    {
        public static Product Current { get; set; }
    }
}
