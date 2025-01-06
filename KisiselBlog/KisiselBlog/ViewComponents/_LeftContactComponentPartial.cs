using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KisiselBlog.ViewComponents
{
	public class _LeftContactComponentPartial : ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{
			var values = bcontext.leftContacts?.ToList();
			return View(values);

		}
	}
}
