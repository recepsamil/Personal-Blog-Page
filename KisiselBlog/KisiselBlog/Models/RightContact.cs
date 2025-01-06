using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class RightContact
	{
		[Key]
		public int RightContactID { get; set; }
		public string? AdSoyad { get; set; }
		public string? Mail { get; set; }
		public string? Konu { get; set; }
		public string? Mesaj { get; set; }
	}
}
