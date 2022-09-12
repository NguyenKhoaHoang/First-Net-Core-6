using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Services;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        // public List<Product> Products { get; set; }
        // public readonly DataContext _context;

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            // Products = new List<Product>()
            // {
            //     new Product {Id = 1, Name = "Nuooo",Quantity = 2,Price = 500},
            //     new Product {Id = 2, Name = "Nuooo 2",Quantity = 3,Price = 600},
            //     new Product {Id = 3, Name = "Nuooo 3",Quantity = 4,Price = 700},

            // };

            // _context = context;

            _productService = productService;

        }

        public IActionResult Index()
        {
            // var products = _context.Products.ToList();
            var products = _productService.GetProduct();
            return View(products);
        }
        
        public IActionResult Create()
        {
            var categories = _productService.GetCategories();
            return View(categories);
        }

        public IActionResult Save(Product product)
        {
            if (product.Id == 0)
            {
                _productService.CreateProduct(product);
            } else {
                _productService.UpdateProduct(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var product = _productService.GetProductById(id);
            if(product==null) return RedirectToAction("Create");
            var categories = _productService.GetCategories();   
            ViewBag.Product = product;
            return View(categories);
        }

        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}