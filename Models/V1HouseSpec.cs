using System.Text.Json.Serialization;

namespace Example.Models
{
	public class V1HouseSpec
	{
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public Color Color { get; set; }
	}
}
