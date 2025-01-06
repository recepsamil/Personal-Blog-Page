using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace KisiselBlog.ViewComponents
{
	public class _ReferansComponentPartial : ViewComponent
	
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();

		public IViewComponentResult Invoke()
		{
			var values = bcontext.referans?.ToList();
			return View(values);
		}
	}
}
