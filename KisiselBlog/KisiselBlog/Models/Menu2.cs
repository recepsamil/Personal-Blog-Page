using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Menu2
	{
		[Key]
		public int Menu2ID { get; set; }
		public string? Img { get; set; }
		public string? Baslik { get; set; }
		public string? Aciklama1 { get; set; }
		public string? Aciklama2 { get; set; }
		public string? Aciklama3 { get; set; }
	}
}
