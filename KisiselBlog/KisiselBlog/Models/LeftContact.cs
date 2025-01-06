using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class LeftContact
	{
		[Key]
		public int LeftContactID { get; set; }
		public string? Baslik { get; set; }
		public string? Aciklama { get; set; }
		public string? Konum { get; set; }
		public string? Mail { get; set; }
		public string? Telefon { get; set; }
	}
}
