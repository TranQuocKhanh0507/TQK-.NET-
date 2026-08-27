using Microsoft.AspNetCore.Mvc;
using TqkLesson02Demo.Models;

namespace TqkLesson02Demo.Controllers
{
    public class TqkProductController1 : Controller
    {
        public IActionResult Index()
        {
            // Đưa dữ liệu ra view

            ViewBag.name = "Quốc Khánh";
            ViewData["address"] = "Fit NTU";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi ";

            return View();
        }

        // chi tiết sản phẩm
        public IActionResult GetProduct()
        {
            //Mock data
            TqkProduct product = new TqkProduct()
            {
                ProductId = "P001",
                ProductName = "Laptop Dell Vostro",
                YearRelease = 2024,
                Price = 12000000,
            };

            ViewData["productVD"] = product;
            ViewBag.productVB = product;

            return View();
        }
    }
}
