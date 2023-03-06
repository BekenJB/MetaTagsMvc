using MetaTagsMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MetaTagsMvc.Controllers
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
            ViewBag.Keywords = "Keyword1, Keyword2, Keyword3, Keyword4, Keyword5";
            ViewBag.Description = "Testing how to add metatags to an MVC applicaiton";

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