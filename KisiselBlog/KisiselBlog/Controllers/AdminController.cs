using KisiselBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace KisiselBlog.Controllers
{
	
	public class AdminController : Controller
	{
		KisiselBlogContext bcontext = new KisiselBlogContext();
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AdminLogin()
		{
			return View();
		}


		[HttpPost]
		public IActionResult AdminLogin(AdminLogin login)
		{
			var user = bcontext.adminLogins?.FirstOrDefault(x => x.mail == login.mail && x.sifre == login.sifre);
			if (user != null)
			{

				return RedirectToAction("Index");

			}
			{
				TempData["ErrorMessage"] = "Geçersiz kullanıcı adı veya şifre.";
			}

			return View();
		}

		public IActionResult BlogPost()
		{
			var values = bcontext.blogPosts?.ToList();
			return View(values);
		}

		public IActionResult BlogAdd()
		{
			return View();
		}

		[HttpPost]
		public IActionResult BlogAdd(BlogPost blogPost)
		{
			if (blogPost != null)
			{
				// Resim yollarını düzenleyelim
				var img = "/BlogTema/assets/img/team/" + blogPost.Image;
				blogPost.Image = img;

				var team = "/BlogTema/assets/img/team/" + blogPost.TakımImg;
				blogPost.TakımImg = team;

				// Blog postu veritabanına ekle
				bcontext.blogPosts?.Add(blogPost);
				bcontext.SaveChanges();

				return RedirectToAction("BlogPost");
			}

			return View(blogPost); // Hatalı giriş durumunda aynı view'a dön
		}

		public IActionResult BlogUpdate(int id)
		{
			var values = bcontext.blogPosts?.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult BlogUpdate(BlogPost blogPost)
		{
			var img = "/BlogTema/assets/img/team/" + blogPost.Image;
			blogPost.Image = img;
			var team = "/BlogTema/assets/img/team/" + blogPost.TakımImg;
			blogPost.TakımImg = team;

			bcontext.blogPosts?.Update(blogPost);
			bcontext.SaveChanges();
			return RedirectToAction("BlogPost");
		}

		[HttpGet]
		public IActionResult BlogDelete(int id)
		{
			var blog = bcontext.blogPosts?.Find(id);
			if (blog != null)
			{
				bcontext.blogPosts?.Remove(blog);
				bcontext.SaveChanges();
			}
			return RedirectToAction("BlogPost");
		}


	}
}



	
