using AjaxJquery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxJquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(int num1, int num2)
        {
            int result = num1 + num2;
            return Content(result.ToString());
        }

        [HttpPost]
        public IActionResult Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return Content(result.ToString());
        }

        [HttpPost]
        public IActionResult Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return Content(result.ToString());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
