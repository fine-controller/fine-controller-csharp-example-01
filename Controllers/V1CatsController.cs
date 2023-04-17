using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v1/cats")]
	public class V1CatsController : ControllerBase
	{
		[HttpPut("{namespace}/{name}")]
		public void Put(string @namespace, string name, V1Cat cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(cat, Formatting.Indented)}");
		}

		[HttpDelete("{namespace}/{name}")]
		public void Delete(string @namespace, string name, V1Cat cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(cat, Formatting.Indented)}");
		}
	}
}