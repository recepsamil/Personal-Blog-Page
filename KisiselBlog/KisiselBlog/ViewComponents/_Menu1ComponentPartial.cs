using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KisiselBlog.ViewComponents
{
	public class _Menu1ComponentPartial : ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{

			var values = bcontext.Menu1s?.ToList();	
			return View(values);
		}
	}
}
