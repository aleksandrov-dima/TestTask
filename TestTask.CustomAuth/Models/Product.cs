using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.CustomAuth.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Введите наименование товара")]
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        //[Range(decimal.Zero, decimal.MaxValue, ErrorMessage = "Введите положительное число")]
        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Укажите категорию товара")]
        [Display(Name = "Категория")]
        public string Category { get; set; }
    }
}
