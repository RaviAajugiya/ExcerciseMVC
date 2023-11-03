using ExcerciseMVC.Models;
using MVC_Vidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace MVC_Vidly.Controllers
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
        // GET: Movie
        public ActionResult Movie()
        {
            //var movies = _context.movies.Include(m => m.Genre).ToList();
            return View();
        }

        public ActionResult Details(int id)
        {
            //var movie = _context.movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            return View();
        }


    }
}