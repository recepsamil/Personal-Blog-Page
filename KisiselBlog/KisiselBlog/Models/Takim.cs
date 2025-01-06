using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Takim
	{
		[Key]
		public int TakimID { get; set; }
		public string? Ozellik { get; set; }
		public string? ImageUrl { get; set; }
		public string? AdSoyad{ get; set; }
		public string? Pozisyon { get; set; }
		public string? Aciklama { get; set; }
		
	}
}
