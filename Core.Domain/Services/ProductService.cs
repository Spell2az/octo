using System;
using System.Collections.Generic;

namespace Core.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
        }

        public IEnumerable<Product> GetProducts()
        {
            return unitOfWork.Products.GetAll();
        }

        public Product GetProductById(int id)
        {
            return unitOfWork.Products.Get(id);
        }

        public IEnumerable<Product> GetProductsByCategory(Categories category)
        {
            return unitOfWork.Products.Find(p => p.Category == category);
        }

        public Product CreateProduct(Product product)
        {
            unitOfWork.Products.Add(product);
            unitOfWork.Complete();
            return product;
        }
    }
}
