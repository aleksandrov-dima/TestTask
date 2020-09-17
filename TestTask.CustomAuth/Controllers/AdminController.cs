using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Serilog;
using TestTask.CustomAuth.Models;
using TestTask.CustomAuth.Repositories;

namespace TestTask.CustomAuth.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IProductRepository productRepository;

        public AdminController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult Index() => View(productRepository.Products);

        public ViewResult Edit(int productId) =>
            View(productRepository.Products
                .FirstOrDefault(p => p.ProductId == productId));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                bool isNew = product.ProductId == 0 ? true : false;

                productRepository.SaveProduct(product);

                TempData["message"] = $"{product.Name} успешно сохранен";

                if (isNew)
                {
                    Log.Information("{@User}: Товар был добавлен {@product}", User.Identity.Name, product);
                }
                else
                {
                    Log.Information("{@User}: Товар был изменен {@ProductId}", User.Identity.Name, product.ProductId);
                }

                return RedirectToAction("Index");
            }
            else
            {
                //ошибка в веденных данных
                return View(product);
            }
        }

        public ViewResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult Delete(int productId)
        {
            Product deletedProduct = productRepository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} успешно удален";
                Log.Information("{@User}: Товар был удален {@product}", User.Identity.Name, deletedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
