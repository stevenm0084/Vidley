﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    

    public class MoviesController : Controller
    {
        

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Bob Smith",  },
                new Customer { Name = "Mavis Brown",  }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);            

        }

        public ActionResult Edit(int id)
        {
            
            return Content("id = " + id);
        }

        public ActionResult Index() //int? pageIndex, string sortBy
        {
            /*if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
            */

            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"  },
                new Movie { Id = 2, Name = "Wall-e"   }
            };

            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")] //{month:regex(\\d{4}):range(1, 12)}
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }


    }
}