using Northwind.DataAccess.Abstract;
using Nortwind.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.Entity
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }


        }

        public Product Get(int productId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == productId)!;
            }
        }


        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }


        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Products.Update(product);
            }
        }


        public void Delete(int productId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //return context.Products.ToList();
            }
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
