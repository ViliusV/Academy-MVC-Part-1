using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Details()
        {
	        var model = new PersonViewModel
	        {
		        FirstName = "John",
		        LastName = "Doe",
		        Age = 25
	        };

            return View(model);
        }

	    public ActionResult Edit(int id)
	    {
			//take from db
			var model = new PersonViewModel
			{
				FirstName = "John",
				LastName = "Doe",
				Age = 25
			};

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
	    public ActionResult Edit(PersonViewModel model)
	    {
		    //update model in DB

			return RedirectToAction("Details");
	    }
    }
}