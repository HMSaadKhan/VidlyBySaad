using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyBySaad.Models;

namespace VidlyBySaad.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek" };
            return View(movie);
        }
    }
}