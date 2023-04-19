using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v1cat")]
	public class V1CatController : ControllerBase
	{
		[HttpPut("{namespace}/{name}")]
		public void Put(string @namespace, string name, V1Cat v1cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1cat, Formatting.Indented)}");
		}

		[HttpDelete("{namespace}/{name}")]
		public void Delete(string @namespace, string name, V1Cat v1cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1cat, Formatting.Indented)}");
		}
	}
}