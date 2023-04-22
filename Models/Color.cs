using System.Text.Json.Serialization;

namespace Example.Models
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Color
	{
		Red,
		Brown,
		Gray
	}
}
