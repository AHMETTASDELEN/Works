using System;
using System.Collections.Generic;
using System.Text;

namespace ProductListExample
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice  { get; set; }
        public int UnitsInStock { get; set; }
    }
}
