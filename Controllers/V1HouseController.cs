using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/-/v1/v1house")]
	public class V1HouseController : ControllerBase
	{
		[HttpPut("{name}")]
		public void Put(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}

		[HttpDelete("{name}")]
		public void Delete(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}
	}
}