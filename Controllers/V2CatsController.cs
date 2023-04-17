using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v2/cats")]
	public class V2CatsController : ControllerBase
	{
		[HttpPut("{namespace}/{name}")]
		public void Put(string @namespace, string name, V2Cat cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(cat, Formatting.Indented)}");
		}

		[HttpDelete("{namespace}/{name}")]
		public void Delete(string @namespace, string name, V2Cat cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(cat, Formatting.Indented)}");
		}
	}
}