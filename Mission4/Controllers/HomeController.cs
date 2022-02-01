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

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie m)
        {
            MovieContext.Add(m);
            MovieContext.SaveChanges();
            return View("Index");
        }

        public IActionResult MovieList()
        {
            var movies = MovieContext.Movies
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            var movie = MovieContext.Movies.Single(x => x.MovieId == movieid);
            return View("Movies", movie);
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
