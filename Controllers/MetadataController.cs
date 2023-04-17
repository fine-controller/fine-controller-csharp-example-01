using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/metadata")]
	public class MetadataController : ControllerBase
	{
		[HttpGet]
		public Metadata Get()
		{
			Console.WriteLine($"GET {Request.Path}\n");

			return new Metadata
			{
				Group = "fc1.yollo.com"
			};
		}
	}
}