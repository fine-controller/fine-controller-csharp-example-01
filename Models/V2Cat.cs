using k8s;
using k8s.Models;

namespace Example.Models
{
	public class V2Cat : IKubernetesObject<V1ObjectMeta>, ISpec<V2CatSpec>, IStatus<V2CatStatus>
	{
		public string ApiVersion { get; set; }
		public string Kind { get; set; }
		public V1ObjectMeta Metadata { get; set; }
		public V2CatSpec Spec { get; set; }
		public V2CatStatus Status { get; set; }
	}
}
