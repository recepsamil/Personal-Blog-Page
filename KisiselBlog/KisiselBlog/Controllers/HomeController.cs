using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KisiselBlog.Controllers
{
	public class HomeController : Controller
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}

		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Services()
		{
			return View();
		}
		public IActionResult Portfolio()
		{
			var values = bcontext.portfolios?.ToList();
			return View(values);
		}
		public IActionResult Team()
		{
			var values = bcontext.takims?.ToList();
			return View(values);
		}
		public IActionResult Contact(RightContact rightContact)
		{
			bcontext.rightContacts?.Add(rightContact);
			bcontext.SaveChanges();
			return View();
		}

	}
}
