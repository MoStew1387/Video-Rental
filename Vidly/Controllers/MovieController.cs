using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var viewResult = new ViewResult();
            var customers = new List<Customer>
            {
                new Customer("Customer 1"),
                new Customer("Customer 2")
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            // return RedirectToAction("Index", "Home");
            // return new EmptyResult();
            // return HttpNotFound();
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex ={0}&sortBy ={1}", pageIndex, sortBy));


        }
        [Route ("movies/released/{year:regex(\\d{4}}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }

}