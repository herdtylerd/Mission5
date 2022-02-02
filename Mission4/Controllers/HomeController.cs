using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            MovieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        // Add a movie
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = MovieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie m)
        {
            // See if input was valid, if not return errors
            if (ModelState.IsValid)
            {
                MovieContext.Add(m);
                MovieContext.SaveChanges();
                return View("Index");
            }
            else
            {
                ViewBag.Categories = MovieContext.Categories.ToList();
                return View();
            }
            
        }

        // List all movies
        public IActionResult MovieList()
        {
            var movies = MovieContext.Movies
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }


        // Edit a movie
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            var movie = MovieContext.Movies.Single(x => x.MovieId == movieid);
            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            MovieContext.Update(m);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        // Delete a movie
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = MovieContext.Movies.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete (Movie m)
        {
            MovieContext.Movies.Remove(m);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
