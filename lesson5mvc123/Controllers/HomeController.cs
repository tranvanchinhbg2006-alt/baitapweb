using Microsoft.AspNetCore.Mvc;
using Npgsql;
using CongNgheLapTrinhWeb_Bai1_Bai2.Models;

namespace CongNgheLapTrinhWeb_Bai1_Bai2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

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
            var products = new List<Product>();
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT id, name, price FROM product ORDER BY id";
            using var command = new NpgsqlCommand(sql, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2)
                });
            }

            return View(products);
        }
    }
}
