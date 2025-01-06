using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Misyon
	{
		[Key]
		public int MisyonID { get; set; }
		public string? Baslik { get; set; }
		public string? Misyon1 { get; set; }
		public string? Misyon2 { get; set; }
		public string? MisyonImage { get; set; }

	}
}
