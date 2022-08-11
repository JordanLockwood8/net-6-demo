using Microsoft.AspNetCore.Mvc;

namespace net_6_demo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ProductIndex()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            var product = _repo.GetById(id);
            return View(product);
        }

    }
}
