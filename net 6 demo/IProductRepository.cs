using net_6_demo.Models;

namespace net_6_demo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetById(int id);
        public void UpdateProduct(Product product);
        
    }

}