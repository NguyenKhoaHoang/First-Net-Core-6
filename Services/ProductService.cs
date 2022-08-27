using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public List<Product> GetProduct()
        {
           return _context.Products.ToList();
        }
    }
}