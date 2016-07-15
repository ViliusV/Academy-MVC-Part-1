using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
	public class PersonViewModel
	{
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		public int Age { get; set; }

		public bool IsHere { get; set; }
	}
}