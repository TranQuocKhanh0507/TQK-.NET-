using Microsoft.AspNetCore.Mvc;
using TqkLesson03.Models;

namespace TqkLesson03.Controllers
{
    public class TqkProductController : Controller
    {
        // Mock data
        private readonly List<TqkProduct> _products = new()
        {
            new TqkProduct
            {
                TqkProductId = "SP001",
                TqkProductName = "Laptop Dell Inspiron 15",
                TqkYearRelease = "2023",
                TqkPrice = 15990000
            },

            new TqkProduct
            {
                TqkProductId = "SP002",
                TqkProductName = "Laptop ASUS Vivobook 15",
                TqkYearRelease = "2024",
                TqkPrice = 14990000
            },

            new TqkProduct
            {
                TqkProductId = "SP003",
                TqkProductName = "Laptop HP Pavilion 14",
                TqkYearRelease = "2023",
                TqkPrice = 17990000
            },

            new TqkProduct
            {
                TqkProductId = "SP004",
                TqkProductName = "iPhone 15",
                TqkYearRelease = "2023",
                TqkPrice = 21990000
            },

            new TqkProduct
            {
                TqkProductId = "SP005",
                TqkProductName = "Samsung Galaxy S24",
                TqkYearRelease = "2024",
                TqkPrice = 20990000
            },

            new TqkProduct
            {
                TqkProductId = "SP006",
                TqkProductName = "Xiaomi Redmi Note 13",
                TqkYearRelease = "2024",
                TqkPrice = 6990000
            },

            new TqkProduct
            {
                TqkProductId = "SP007",
                TqkProductName = "iPad Air M2",
                TqkYearRelease = "2024",
                TqkPrice = 16990000
            },

            new TqkProduct
            {
                TqkProductId = "SP008",
                TqkProductName = "MacBook Air M2",
                TqkYearRelease = "2022",
                TqkPrice = 24990000
            },

            new TqkProduct
            {
                TqkProductId = "SP009",
                TqkProductName = "Sony WH-1000XM5",
                TqkYearRelease = "2022",
                TqkPrice = 8490000
            },

            new TqkProduct
            {
                TqkProductId = "SP010",
                TqkProductName = "Apple Watch Series 9",
                TqkYearRelease = "2023",
                TqkPrice = 10990000
            }
        };

        public IActionResult Index()
        {
            return Json(_products);
        }

        public IActionResult TqkGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
        public IActionResult TqkGetListProduct()
        {
            return View(_products);
        }
    }
}