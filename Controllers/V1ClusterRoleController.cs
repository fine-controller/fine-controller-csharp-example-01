using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Example.Controllers
{
	[ApiController]
	public class V1ClusterRoleController : ControllerBase
	{
		[HttpPut("/rbac.authorization.k8s.io/v1/v1clusterrole/-/{name}")]
		public void Put(string name, V1ClusterRole v1clusterrole)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1clusterrole, Formatting.Indented)}");
		}

		[HttpDelete("/rbac.authorization.k8s.io/v1/v1clusterrole/-/{name}")]
		public void Delete(string name, V1ClusterRole v1clusterrole)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonConvert.SerializeObject(v1clusterrole, Formatting.Indented)}");
		}
	}
}