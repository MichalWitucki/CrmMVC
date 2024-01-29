using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        int AddProduct(Product product);
        void DeleteProduct(int productId);
        IQueryable<Product>? GetAllProducts();
        IQueryable<Product>? GetOfferItems();
        IQueryable<Product>? GetPipes();
        Product? GetProductById(int productId);
    }
}
