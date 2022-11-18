using Microsoft.AspNetCore.Mvc;
using MyBuddyListPro.Models;
using System.Diagnostics;

namespace MyBuddyListPro.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/Home/ErrorHandler/{code:int}")]
        public IActionResult ErrorHandler(int code)
        {
            var customError = new CustomError();

            customError.code = code;

            if (code == 404)
            {
                customError.message = "Sorry, the page you requested could not be found.";
            }
            else
            {
                customError.message = "Sorry, an error has occurred.";
            }

            return View("~/Views/Shared/ErrorPage.cshtml", customError);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}