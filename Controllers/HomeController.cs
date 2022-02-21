using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JoelHilton.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext MovieContext { get; set; }

        //constructor
        public HomeController(MovieContext movieContext)
        {
            MovieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = MovieContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.Category == xCat)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult NewMovies()
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovies(MovieResponses mr)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Add(mr);
                MovieContext.SaveChanges();

                return View();

            } else // if invalid
            {
                return View(mr);
            }
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

            var movie = MovieContext.Responses.Single(x => x.MovieId == movieid);

            return View("NewMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponses mr)
        {
            if (ModelState.IsValid)
            {
                //MovieContext.Update(mr);
                MovieContext.Responses.Update(mr);
                MovieContext.SaveChanges();
                return RedirectToAction("MovieList");
            }else
            { 
                return RedirectToAction("Edit", mr);
            }
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = MovieContext.Responses.Single(x => x.MovieId == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponses mr)
        {
            MovieContext.Responses.Remove(mr);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
