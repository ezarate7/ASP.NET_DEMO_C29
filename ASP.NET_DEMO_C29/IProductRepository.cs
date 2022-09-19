using ASP.NET_DEMO_C29.Models;
using System.Drawing;
using Dapper;

namespace ASP.NET_DEMO_C29
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
