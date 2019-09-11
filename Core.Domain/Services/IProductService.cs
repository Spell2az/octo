using System.Collections.Generic;

namespace Core.Domain.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        IEnumerable<Product> GetProductsByCategory(Categories category);
        Product CreateProduct(Product product);
    }
}