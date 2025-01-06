using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class BlogPost
	{
		[Key]
		public int BlogPostID { get; set; }
		public string? Image { get; set; }

		[DisplayName("Url")]
		public string? KısaBaslik { get; set; }
		public string? TarihBaslik { get; set; }
		public string? Baslik { get; set; }
		public string? ParagrafBaslik { get; set; }
		public string? TakımImg { get; set; }
		public string? AdSoyad { get; set; }
		public string? Pozisyon { get; set; }
	}
}
