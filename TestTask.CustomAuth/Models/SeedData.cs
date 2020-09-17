using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestTask.CustomAuth.Repositories;

namespace TestTask.CustomAuth.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product()
                    {
                        Name = "Samsung 150",
                        Price = 17000,
                        Category = "Телевизоры"
                    },
                    new Product()
                    {
                        Name = "Philips 72",
                        Price = 15000,
                        Category = "Телевизоры"
                    },
                    new Product()
                    {
                        Name = "Polar 2",
                        Price = 25000,
                        Category = "Холодильники"
                    },
                    new Product()
                    {
                        Name = "Indezit M3",
                        Price = 21000,
                        Category = "Холодильники"
                    }
                );
                context.SaveChanges();
            }

        }
    }
}
