using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Vidley.Controllers
{
    

    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Bob Smith",  },
                new Customer { Name = "Mavis Brown",  }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);            

        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        public ActionResult Index() //int? pageIndex, string sortBy
        {

            var movies = _context.Movies.Include(m => m.Genre).ToList(); ;//GetMovies();

            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")] //{month:regex(\\d{4}):range(1, 12)}
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }


        public ActionResult MovieForm()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {   
                Genres = genres

            };
            
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            } else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.Genre = movie.Genre;
                movieInDb.DateAdded = DateTime.Now;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (ValidationException e)
            {

                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Movies");
        }



    }
}