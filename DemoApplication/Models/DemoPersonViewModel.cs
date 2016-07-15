using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoApplication.Models
{
	public class DemoPersonViewModel
	{
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		public int Age { get; set; }

		public CountryViewModel Country { get; set; }
	}
}