﻿using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
	[ApiController]
	public class HealthController : ControllerBase
	{
		[HttpGet("/health")]
		public IActionResult GetHealth()
		{
			return Ok();
		}
	}
}