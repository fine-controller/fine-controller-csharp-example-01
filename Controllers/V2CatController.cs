using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v2cat")]
	public class V2CatController : ControllerBase
	{
		[HttpPut("{namespace}/{name}")]
		public void Put(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v2cat, Formatting.Indented)}");
		}

		[HttpDelete("{namespace}/{name}")]
		public void Delete(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v2cat, Formatting.Indented)}");
		}
	}
}