using k8s;
using k8s.Models;

namespace Example.Models
{
	public class V1House : IKubernetesObject<V1ObjectMeta>, ISpec<V1HouseSpec>, IStatus<V1HouseStatus>
	{
		public string ApiVersion { get; set; }
		public string Kind { get; set; }
		public V1ObjectMeta Metadata { get; set; }
		public V1HouseSpec Spec { get; set; }
		public V1HouseStatus Status { get; set; }
	}
}
