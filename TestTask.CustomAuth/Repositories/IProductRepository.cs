using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.CustomAuth.Models;

namespace TestTask.CustomAuth.Repositories
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        Product DeleteProduct(int productId);
        void SaveProduct(Product product);
    }
}
