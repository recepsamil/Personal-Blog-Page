using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Menu1
	{
		[Key]
		public int Menu1ID { get; set; }
		public string? Baslik { get; set; }
		public string? Aciklama { get; set; }
	}
}
