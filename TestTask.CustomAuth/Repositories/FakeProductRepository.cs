using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.CustomAuth.Models;

namespace TestTask.CustomAuth.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Samsung A31 ", Price = 15000},
            new Product {Name = "IPhone 12", Price = 70000},
            new Product {Name = "Huawei T90", Price = 8000}
        }.AsQueryable();

        public Product DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
