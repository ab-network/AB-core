using System.Threading.Tasks;

// Google Dependencies
using Google.Apis.Container.v1;
using Google.Apis.Container.v1.Data;

using Google.Apis.Compute.v1;
using Google.Apis.Compute.v1.Data;

using Google.Apis.Services;

// Local Dependencies
using ABGCP.Utils;

namespace ABService
{
    public class GCPProject
    {
        string instanceProject;

        // GCP services.
        ContainerService containerService = null;
        ComputeService computeService = null;

        public GCPProject(string project, string apiKey)
        {
            instanceProject = project;

            BaseClientService.Initializer init = new BaseClientService.Initializer
            {
                ApplicationName = "AB-core",
                ApiKey = apiKey
            };

            containerService = new ContainerService(init);
            computeService = new ComputeService(init);
        }

        public Task<InstanceList> ViewInstanceLists(Reigons reigon, Zones zone)
        {
            string strZone = ZoneUtils.FormatZone(reigon, zone);

            InstancesResource.ListRequest request = computeService.Instances.List(instanceProject, strZone);
            return request.ExecuteAsync();
        }
    }
}
