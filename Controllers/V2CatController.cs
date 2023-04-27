using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Example.Controllers
{
	[ApiController]
	public class V2CatController : ControllerBase
	{
		[HttpPut("/@/v2/v2cat/{namespace}/{name}")]
		public V2CatStatus Put(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonSerializer.Serialize(v2cat, new JsonSerializerOptions { WriteIndented = true })}");
			return v2cat.Status;
		}

		[HttpDelete("/@/v2/v2cat/{namespace}/{name}")]
		public void Delete(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonSerializer.Serialize(v2cat, new JsonSerializerOptions { WriteIndented = true })}");
		}
	}
}