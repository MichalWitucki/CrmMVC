using CrmMVC.Domain.Model;
using CrmMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public int AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public void DeleteProduct(int productId)
        {
            Product? productToDelete = _context.Products.Find(productId);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
            }
        }

        public IQueryable<Product> GetAllProducts()
        {
            IQueryable<Product> products = _context.Products;
            return products;
        }

        public Product? GetProductById(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.Id == productId);
            return product;
        }

        public IQueryable<Product> GetOfferItems()
        {
            IQueryable<Product>? offerItems = _context.Products.Where(p => p.IsOfferItem);
            return offerItems;
        }

        public IQueryable<Product> GetPipes()
        {
            IQueryable<Product>? pipes = _context.Products.Where(p => p.IsPipe);
            return pipes;
        }
    }
}
