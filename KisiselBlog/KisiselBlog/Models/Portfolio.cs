using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class Portfolio
	{
		[Key]
		public int PortfolioID { get; set; }
		public string? Baslik { get; set; }
		public string? ImgUrl { get; set; }
		public string? Aciklama { get; set; }
		public string? Sinif1 { get; set; }
		public string? Sinif2 { get; set; }
	}
}
