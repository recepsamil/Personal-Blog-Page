using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KisiselBlog.ViewComponents
{
	public class _AnasayfaImageComponentPartial : ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{
			var values = bcontext.anasayfaImages?.ToList();
			return View(values);
		}
	}
}
