using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMovieTicketAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMovieTicketAdminPortal.Controllers
{
    public class MultiplexController : Controller
    {
        MovieDbContext context;
        public MultiplexController(MovieDbContext _context) // add in services in startup.cs
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var multiplexes = context.Multiplexes.ToList();
            return View(multiplexes);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Multiplex multiplex = context.Multiplexes.Find(id);

            return View(multiplex);
        }
        [HttpPost]
        public ActionResult Delete(int id, Multiplex m1)
        {
            var author = context.Multiplexes.Where(x => x.MultiplexId == id).SingleOrDefault();
            context.Multiplexes.Remove(author);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            Multiplex multiplex = context.Multiplexes.Where(x => x.MultiplexId == id).SingleOrDefault();
            return View(multiplex);
        }
        [HttpPost]
        public ActionResult Edit(int id, Multiplex m1)
        {
            Multiplex multiplex = context.Multiplexes.Where(x => x.MultiplexId == id).SingleOrDefault();

            multiplex.MultiplexName = m1.MultiplexName;
            multiplex.MultiplexDescription = m1.MultiplexDescription;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            Multiplex multiplex = context.Multiplexes.Where(x => x.MultiplexId == id).SingleOrDefault();
            return View(multiplex);
        }
        [HttpGet]
        public ViewResult Create()
        {
            var multiplexes = context.Multiplexes.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Multiplex m1)
        {
            context.Multiplexes.Add(m1);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}