using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMovieTicketAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMovieTicketAdminPortal.Controllers
{
    public class AuditoriumController : Controller
    {
        MovieDbContext context;
        public AuditoriumController(MovieDbContext _context) 
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var auditoriums = context.Auditoriums.ToList();
            return View(auditoriums);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
           Auditorium auditorium = context.Auditoriums.Find(id);

            return View(auditorium);
        }

        [HttpPost]
        public ActionResult Delete(int id, Auditorium a1)
        {
            var auditorium = context.Auditoriums.Where(x => x.AuditoriumId == id).SingleOrDefault();
            context.Auditoriums.Remove(auditorium);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Create()
        {
            var auditoriums = context.Auditoriums.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auditorium a1)
        {
            context.Auditoriums.Add(a1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public ActionResult Edit(int id)
        {

           Auditorium auditorium = context.Auditoriums.Where(x => x.AuditoriumId == id).SingleOrDefault();
            return View(auditorium);
        }
        [HttpPost]
        public ActionResult Edit(int id, Auditorium a1)
        {
            Auditorium auditorium = context.Auditoriums.Where(x => x.AuditoriumId == id).SingleOrDefault();

            auditorium.AuditoriumName = a1.AuditoriumName;
            auditorium.AuditoriumDescription = a1.AuditoriumDescription;
            auditorium.Seats= a1.Seats;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            Auditorium auditorium = context.Auditoriums.Where(x => x.AuditoriumId == id).SingleOrDefault();
            return View(auditorium);
        }

    }
}