using Microsoft.AspNetCore.Mvc;
using KisiselBlog.Models;
namespace KisiselBlog.ViewComponents
{
	public class _AnasayfaComponentPartial : ViewComponent
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IViewComponentResult Invoke()
		{
			var values = bcontext.anasayfas?.ToList();
			ViewData["message"] = "Yüklediğiniz için Teşekkürler :)";
			return View(values);
		}
	}
}
