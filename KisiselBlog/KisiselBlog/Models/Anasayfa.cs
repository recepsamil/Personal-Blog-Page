using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Anasayfa
	{
		[Key]
		public int AnasayfaID { get; set; }
		public string? Baslik { get; set; }
		public string? Aciklama1 { get; set; }
		public string? Aciklama2 { get; set; }
	}
}
