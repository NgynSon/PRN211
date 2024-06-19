using System;
using System.Collections.Generic;

namespace MyStock.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
    }
}
