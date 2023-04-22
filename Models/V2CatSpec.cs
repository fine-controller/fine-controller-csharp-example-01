using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
	public class V2CatSpec
	{
		[Required]
		[RegularExpression(@"^[a-zA-Z''-'\s]{1,5}$", ErrorMessage = "Only letters and digits not allowed")] // Allow up to 5 uppercase and lowercase 
		public string Name2 { get; set; }

		[Range(0, 10)]
		public int Age2 { get; set; }
	}
}
