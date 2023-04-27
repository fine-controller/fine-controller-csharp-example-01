using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Example.Controllers
{
	[ApiController]
	public class V1HouseController : ControllerBase
	{
		[HttpPut("/@/v1/v1house/-/{name}")]
		public void Put(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonSerializer.Serialize(v1house, new JsonSerializerOptions { WriteIndented = true })}");
		}

		[HttpDelete("/@/v1/v1house/-/{name}")]
		public void Delete(string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonSerializer.Serialize(v1house, new JsonSerializerOptions { WriteIndented = true })}");
		}
	}
}