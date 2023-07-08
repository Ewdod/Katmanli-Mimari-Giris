using Microsoft.EntityFrameworkCore;
using Nortwind.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.Entity
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\EWDOD;Database=Northwind;Trusted_Connection=true");
        }



    }
}
