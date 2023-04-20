using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	public class V1ConfigMapController : ControllerBase
	{
		[HttpPut("/-/v1/v1configmap/{namespace}/{name}")]
		public void Put(string @namespace, string name, V1ConfigMap v1configmap)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1configmap, Formatting.Indented)}");
		}

		[HttpDelete("/-/v1/v1configmap/{namespace}/{name}")]
		public void Delete(string @namespace, string name, V1ConfigMap v1configmap)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nnamespace : {@namespace}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1configmap, Formatting.Indented)}");
		}
	}
}