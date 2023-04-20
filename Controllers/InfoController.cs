using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
	[ApiController]
	public class InfoController : ControllerBase
	{
		[HttpGet("/info/group")]
		public string GetGroup()
		{
			return "finecontroller-csharp-example-01.io";
		}
	}
}