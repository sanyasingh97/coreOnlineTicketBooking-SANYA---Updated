using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMovieTicketAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace coreMovieTicketAdminPortal.Controllers
{
    public class MovieDetailController : Controller
    {
        MovieDbContext context;
        public MovieDetailController(MovieDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var moviedetails = context.MovieDetails.ToList();
            return View(moviedetails);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            MovieDetail moviedetails = context.MovieDetails.Find(id);
            return View(moviedetails);
        }

        [HttpPost]
        public IActionResult Delete(int id, MovieDetail m1)
        {
            var moviedetails = context.MovieDetails.Where(x => x.MovieDetailId == id).SingleOrDefault();
            context.MovieDetails.Remove(moviedetails);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            MovieDetail moviedetail = context.MovieDetails.Where(x => x.MovieDetailId == id).SingleOrDefault();
            return View(moviedetail);
        }
        [HttpPost]
        public ActionResult Edit(int id, MovieDetail m1)
        {
            MovieDetail moviedetails = context.MovieDetails.Where(x => x.MovieDetailId == id).SingleOrDefault();

            moviedetails.Casting = m1.Casting ;
            moviedetails.Producer = m1.Producer;
            moviedetails.Director = m1.Director;
            moviedetails.MovieType = m1.MovieType;
            moviedetails.MovieImage = m1.MovieImage;
            moviedetails.MovieDuration = m1.MovieDuration;
            moviedetails.Price = m1.Price;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.movie = new SelectList(context.Movies, "MovieId","MovieName");
            //ViewBag.movie = new SelectList(context.Movies, "MovieId", "MovieType");
            var moviedetails = context.MovieDetails.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieDetail m1)
        {
            context.MovieDetails.Add(m1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            MovieDetail moviedetail = context.MovieDetails.Where(x => x.MovieDetailId == id).SingleOrDefault();
            return View(moviedetail);
        }

    }
}
    
