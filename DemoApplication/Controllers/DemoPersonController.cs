using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class DemoPersonController : Controller
    {
	    public ActionResult Index()
	    {
		    var person = new DemoPersonViewModel();
		    return View(person);
	    }
    }
}