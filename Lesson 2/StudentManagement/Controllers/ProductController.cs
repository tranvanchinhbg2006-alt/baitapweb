using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return Content("Vui lòng nhập Product ID");
            }

            return Content("Product ID = " + id);
        }

        public IActionResult Category(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Content("Vui lòng nhập tên Category");
            }

            return Content("Category = " + name);
        }
    }
}
