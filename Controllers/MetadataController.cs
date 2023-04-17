using Example.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	[Route("/metadata")]
	public class MetadataController : ControllerBase
	{
		private static readonly Metadata Metadata = new()
		{
			Group = "fine-controller-example-01.github.io"
		};

		[HttpGet]
		public Metadata Get()
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nresponse : {JsonConvert.SerializeObject(Metadata, Formatting.Indented)}");
			return Metadata;
		}
	}
}