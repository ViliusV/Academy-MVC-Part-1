using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
			var dbContext = new UsersEntities();

	        var user = dbContext.Members.FirstOrDefault();
	        var model = new LoginViewModel
	        {
		        UserName = user.UserName,
		        Password = user.Password
	        };

            return View(model);
        }
    }
}