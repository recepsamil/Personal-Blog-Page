using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace KisiselBlog.ViewComponents
{
	public class _MisyonComponentPartial:ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{
			var values =bcontext.misyons?.ToList();
			return View(values);
		}
	}
}
