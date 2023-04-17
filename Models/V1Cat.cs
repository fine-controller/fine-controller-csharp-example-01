using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
	public class V1Cat
	{
		[Required]
		public string Name1 { get; set; }

		[Range(0, 10)]
		public int Age1 { get; set; }
	}
}
