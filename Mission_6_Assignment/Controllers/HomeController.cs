using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_6_Assignment.Models;
using System.Diagnostics;
using System.Linq;

namespace Mission_6_Assignment.Controllers
{

    public class HomeController : Controller
    {
        private MovieCatalogContext _context;

        public HomeController(MovieCatalogContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        // POST: /Home/AddMovie
        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                // Add the new movie to the database
                _context.Movies.Add(newMovie);
                _context.SaveChanges();

                // Redirect back to the Movie List after adding
                return RedirectToAction("MovieList");
            }

            // If validation fails, stay on AddMovie page and show errors
            return View(newMovie);
        }


        // GET: /Home/Edit/5
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: /Home/Edit/5
        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Update(updatedMovie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View(updatedMovie);
        }

        // GET: /Home/Delete/5
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie); // shows confirmation page
        }

        // POST: /Home/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("MovieList");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}
