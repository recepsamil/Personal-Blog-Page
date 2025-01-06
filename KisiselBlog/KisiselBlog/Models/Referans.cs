using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Referans
	{
		[Key]
		public int ReferansID { get; set; }
		public string? Img { get; set; }
		public string? AdSoyad { get; set; }
		public string? Block { get; set; }
	}
}
