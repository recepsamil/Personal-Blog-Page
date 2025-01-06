using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace KisiselBlog.ViewComponents
{
	public class _RightContactComponentPartial : ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{

			var values = bcontext.rightContacts?.ToList();
			return View(values);
			

		}
	}
}
