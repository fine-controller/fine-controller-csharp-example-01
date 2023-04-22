using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
	public class V2CatSpec
	{
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9\s]{1,5}$")]
		public string Name2 { get; set; }

		[Range(0, 10)]
		public int Age2 { get; set; }
	}
}
