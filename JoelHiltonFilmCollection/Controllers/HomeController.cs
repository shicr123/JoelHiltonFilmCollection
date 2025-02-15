using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JoelHiltonFilmCollection.Controllers
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
            return View();  // No need to fetch movies here
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View(); // This is for the "Get to Know Joel" page
        }
    }
}