using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController:Controller
    {
        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>()
            {
                new Product("iphone14pro", 2800, "cell phone"),
                new Product("Apple watch 8", 1200, "watch"),
                new Product("Macbook air M1", 1950, "computer"),
                new Product("Macbook air M2", 2200, "computer"),
                new Product("Xiaomi Mi Smart Speaker", 150, "accessory"),
            };
        }

        public IActionResult Index()
        {
            ViewBag.products = Products;
            return View();
        }

        public IActionResult Detail(int id)
        {
            var product = Products.Find(prod => prod.ProductId == id);

            if (product == null)
            {
                return View("error");
            }

            ViewBag.product = product;

            return View();
        }
    }
}
