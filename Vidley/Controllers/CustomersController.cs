using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;


namespace Vidley.Controllers
{
    public class CustomersController : Controller
    {
        
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith",  },
                new Customer { Id = 2, Name = "Mavis Brown",  }
            };

            return View(customers);
        }

        [Route("Customers/Details/{id}/{name}]")]
        public ActionResult Details(int id, string name)
        {
            var customer = new Customer { Id = id, Name = name };
            
            return View(customer);

        }
    }
}