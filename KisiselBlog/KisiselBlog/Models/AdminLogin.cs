using System.ComponentModel.DataAnnotations;

namespace KisiselBlog.Models
{
	public class AdminLogin
	{
		[Key]
		public int LoginID { get; set; }

		[Required(ErrorMessage = "Mail alanı zorunludur.")]
		public string? mail { get; set; }

		[Required(ErrorMessage = "Şifre alanı zorunludur.")]
		public string? sifre { get; set; }
	}
}
