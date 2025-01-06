using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class AnasayfaImage
	{
		[Key]
		public int AnasayfaImageID { get; set; }
		public string? Image { get; set; }
	}
}
