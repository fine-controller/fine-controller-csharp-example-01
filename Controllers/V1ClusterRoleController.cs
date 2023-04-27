using k8s.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Example.Controllers
{
	[ApiController]
	public class V1ClusterRoleController : ControllerBase
	{
		[HttpPut("/rbac.authorization.k8s.io/v1/v1clusterrole/-/{name}")]
		public void Put(string name, V1ClusterRole v1clusterrole)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonSerializer.Serialize(v1clusterrole, new JsonSerializerOptions { WriteIndented = true })}");
		}

		[HttpDelete("/rbac.authorization.k8s.io/v1/v1clusterrole/-/{name}")]
		public void Delete(string name, V1ClusterRole v1clusterrole)
		{
			Console.WriteLine($"\n{Request.Method} {Request.Path}\nname : {name}\nrequest : {JsonSerializer.Serialize(v1clusterrole, new JsonSerializerOptions { WriteIndented = true })}");
		}
	}
}