﻿using Northwind.DataAccess.Abstract;
using Nortwind.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHiberNate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {

            List<Product> products = new List<Product>()
            {
                new Product {ProductId = 1,
                    ProductName ="Laptop",
                    CategoryId=1,
                    UnitPrice=300,
                    UnitsInStock=100}
            };
            return products;

        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
