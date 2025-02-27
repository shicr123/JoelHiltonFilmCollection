using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //store all categories so we can access them in the view 
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            
            return View(); 
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View("Confirmation", movie);
         }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            Movie movieToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("AddMovie", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();
            
            return RedirectToAction("ListMovies");
        }

        public IActionResult ListMovies()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Movie movieToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            return View(movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("ListMovies");
        }
        
    }
    
    
}