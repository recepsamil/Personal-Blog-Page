using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace KisiselBlog.Models
{
	public class KisiselBlogContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-746C1RT; Initial Catalog=KisiselBlog; Integrated Security=True;  TrustServerCertificate=True;");
		}
	
		public DbSet<AdminLogin>? adminLogins { get; set; }
		public DbSet<Anasayfa>? anasayfas { get; set; }
		public DbSet<AnasayfaImage>? anasayfaImages { get; set; }
		public DbSet<BlogPost>? blogPosts { get; set; }
		public DbSet<Misyon>?  misyons { get; set; }
		public DbSet<Menu1>? Menu1s { get; set; }
		public DbSet<Menu2>? Menu2s { get; set; }
		public DbSet<Portfolio>? portfolios { get; set; }
		public DbSet<Takim>? takims { get; set; }
		public DbSet<LeftContact>?  leftContacts { get; set; }
		public DbSet<RightContact>? rightContacts { get; set; }
		public DbSet<Referans>? referans { get; set; }
	}
}
