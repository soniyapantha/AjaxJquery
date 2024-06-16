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

        [HttpPost]
        public IActionResult Division(int num1, int num2)
        {
            if (num2 == 0)
                return Content("Cannot divide by zero");

            decimal result = (decimal)num1 / num2;
            return Content(result.ToString());
        }

        [HttpPost]
        public IActionResult ComputeNumber(int num1, int num2)
        {
            CalculationModel computeModel = new CalculationModel
            {
                Add = num1 + num2,
                Substract = num1 - num2,
                Multiply = num1 * num2,
                Division = num2 != 0 ? (decimal)num1 / num2 : 0
            };
            //here returning(computeModel)model directly isnot good...we
            //should return it with datatype "Json";
            return Json(computeModel);
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
