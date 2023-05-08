using exception_Filters.Filter;
using exception_Filters.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace exception_Filters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       [MyexceptionFilter] // Only handles Action
        public IActionResult Index()
        {
            int age = 100;     
            int l = age / 0;    // Some Unhandled Exceptions
            return View();
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