using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
	public class Metadata
	{
		[Required]
		public string Group { get; set; }
	}
}
