using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	public class V1HouseController : ControllerBase
	{
		[HttpPut("/@/v1/v1house/-/{name}")]
		public void Put(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}

		[HttpDelete("/@/v1/v1house/-/{name}")]
		public void Delete(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}
	}
}