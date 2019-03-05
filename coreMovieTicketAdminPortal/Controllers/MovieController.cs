using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMovieTicketAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMovieTicketAdminPortal.Controllers
{
    public class MovieController : Controller
    {
        MovieDbContext context;
        public MovieController(MovieDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Movie movies = context.Movies.Find(id);
            return View(movies);
        }

        [HttpPost]
        public IActionResult Delete(int id, Auditorium a1)
        {
            var movies = context.Movies.Where(x => x.MovieId == id).SingleOrDefault();
            context.Movies.Remove(movies);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            Movie movie = context.Movies.Where(x => x.MovieId == id).SingleOrDefault();
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(int id, Movie m1)
        {
            Movie movie = context.Movies.Where(x => x.MovieId == id).SingleOrDefault();

            movie.MovieName = m1.MovieName;
            movie.MovieDescription = m1.MovieDescription;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Create()
        {
            var movies = context.Movies.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m1)
        {
            context.Movies.Add(m1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            Movie movie = context.Movies.Where(x => x.MovieId == id).SingleOrDefault();
            return View(movie);
        }

    }
}