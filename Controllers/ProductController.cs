using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>()
            {
                new Product {Id = 1, Name = "Nuooo",Quantity = 2,Price = 500},
                new Product {Id = 2, Name = "Nuooo 2",Quantity = 3,Price = 600},
                new Product {Id = 3, Name = "Nuooo 3",Quantity = 4,Price = 700},

            };
        }

        public IActionResult Index()
        {

            return View(Products);
        }
    }
}