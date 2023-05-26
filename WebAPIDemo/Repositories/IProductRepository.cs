using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);

    }
}
