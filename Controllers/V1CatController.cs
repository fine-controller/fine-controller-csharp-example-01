using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/v1/cats")]
	public class V1CatController : ControllerBase
	{
		[HttpPut]
		public void Put(V1Cat cat)
		{
			Console.WriteLine($"PUT {Request.Path}\n{JsonConvert.SerializeObject(cat, Formatting.Indented)}\n");
		}

		[HttpDelete]
		public void Delete(V1Cat cat)
		{
			Console.WriteLine($"DELETE {Request.Path}\n{JsonConvert.SerializeObject(cat, Formatting.Indented)}\n");
		}
	}
}