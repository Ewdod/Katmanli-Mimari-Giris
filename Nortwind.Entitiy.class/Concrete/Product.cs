﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entitiy.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; } = null!;
        public  Int16 UnitsInStock { get; set; }


    }
}
