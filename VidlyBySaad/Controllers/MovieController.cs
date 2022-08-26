using System.Collections.Generic;
using System.Web.Mvc;
using VidlyBySaad.Models;
using VidlyBySaad.ViewModels;

namespace VidlyBySaad.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek" };
            var customers = new List<Customer>
                { new Customer{ Name ="Customer1"},
                new Customer{ Name ="Customer2"} };
            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
       
    }
}