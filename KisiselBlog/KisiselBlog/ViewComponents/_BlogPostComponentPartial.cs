using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KisiselBlog.ViewComponents
{
	public class _BlogPostComponentPartial:ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{
			var values = bcontext.blogPosts?.ToList();
			return View(values);
		}
	}
}
