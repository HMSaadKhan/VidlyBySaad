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

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
           if(!pageIndex.HasValue)
            { pageIndex = 1; }
            if (string.IsNullOrEmpty(sortBy)) { sortBy = "name"; }
            return Content(string.Format("pageIndex = "+pageIndex+" sort by="+sortBy));
        }
    }
}