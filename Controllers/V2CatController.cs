using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	public class V2CatController : ControllerBase
	{
		[HttpPut("/./v2/v2cat/{namespace}/{name}")]
		public V2CatStatus Put(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v2cat, Formatting.Indented)}");
			return v2cat.Status;
		}

		[HttpDelete("/./v2/v2cat/{namespace}/{name}")]
		public void Delete(string @namespace, string name, V2Cat v2cat)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v2cat, Formatting.Indented)}");
		}
	}
}