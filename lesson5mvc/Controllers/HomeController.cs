using Microsoft.AspNetCore.Mvc;
using CongNgheLapTrinhWeb_Bai1_Bai2.Models;

namespace CongNgheLapTrinhWeb_Bai1_Bai2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bai1()
        {
            return View();
        }

        public IActionResult Bai2()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 15000000 },
                new Product { Id = 2, Name = "Ban phim", Price = 500000 },
                new Product { Id = 3, Name = "Chuot", Price = 300000 },
                new Product { Id = 4, Name = "Tai nghe", Price = 800000 }
            };

            return View(products);
        }
    }
}
