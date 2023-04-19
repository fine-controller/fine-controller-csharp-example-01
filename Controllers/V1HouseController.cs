using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v1house")]
	public class V1HouseController : ControllerBase
	{
		[HttpPut("{namespace}/{name}")]
		public void Put(string @namespace, string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}

		[HttpDelete("{namespace}/{name}")]
		public void Delete(string @namespace, string name, V1House v1house)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1house, Formatting.Indented)}");
		}
	}
}