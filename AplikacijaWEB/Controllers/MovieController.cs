using AplikacijaWEB.Models;
using AplikacijaWEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace AplikacijaWEB.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
   
        public ViewResult Index()
        {
            var movie = _context.Movies.Include(m => m.Genre).ToList();

            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        /* private IEnumerable <Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name = "Shrek!"},
                new Movie {Id=2, Name = "Wall-e"}
            };
        } 
        */

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customers>
            {
                new Customers {Name ="Customer 1"},
                new Customers {Name ="Customer 2"}
            };

            var viewModel = new RandomMovieView
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);

        }

    }
}