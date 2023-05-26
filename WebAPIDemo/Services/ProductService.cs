using WebAPIDemo.Models;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public int AddProduct(Product prod)
        {
            return _repo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return (_repo.DeleteProduct(id));
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }
        public Product GetProductById(int id)
        {
            return _repo.GetProductById(id);
        }

        public int UpdateProduct(Product prod)
        {
            return _repo.UpdateProduct(prod);
        }

    }
}
