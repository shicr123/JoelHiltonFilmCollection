using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_Cruz.Models;

namespace Mission6_Cruz.Controllers
{
    public class HomeController : Controller
    {
        private FilmCollectionContext _context;
        public HomeController(FilmCollectionContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();  
        }
        public IActionResult GetToKnowJoel()
        {
            return View(); 
        }
        
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return View("Confirmation", movie);
            }
            return View("AddMovie", movie);
        }
    }
}