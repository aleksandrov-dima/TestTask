using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TestTask.CustomAuth.Models;
using TestTask.CustomAuth.Repositories;

namespace TestTask.CustomAuth.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [Authorize(Roles = "admin, user")]
        public ViewResult List(string category)
        {
            Log.Information("{@Name}: Просмотр списка товаров", User.Identity.Name);

            //string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;

            var model = new ProductsListViewModel()
            {
                Products = productRepository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .AsEnumerable(),

                CurrentCategory = category
            };

            return View(model);
        }
    }
}
