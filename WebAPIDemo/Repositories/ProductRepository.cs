using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddProduct(Product prod)
        {
            _db.Products.Add(prod);
            int res = _db.SaveChanges();
            return res;
        }

        public int DeleteProduct(int id)
        {
            int res = 0;
            var prod = _db.Products.Find(id);
            if (prod != null)
            {
                _db.Products.Remove(prod);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            var prod = _db.Products.Find(id);
            return prod;
        }

        public int UpdateProduct(Product prod)
        {
            int res = 0;
            var p = _db.Products.Where(x => x.Id == prod.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = prod.Name;
                p.Price = prod.Price;
                p.Company = prod.Company;
                res = _db.SaveChanges();
            }
            return res;
        }

    }
}
