using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
	public class V2Cat
	{
		[Required]
		public string Name2 { get; set; }

		[Range(0, 20)]
		public int Age2 { get; set; }
	}
}
