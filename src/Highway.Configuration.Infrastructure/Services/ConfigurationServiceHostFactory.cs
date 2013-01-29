using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Highway.Configuration.Core.Interfaces;

namespace Highway.Configuration.Infrastructure.Services
{
    public class ConfigurationServiceHostFactory : WebServiceHostFactory
    {
        protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses)
        {
            WebServiceHost host = new WebServiceHost(serviceType, baseAddresses);
            var wsHttpBinding = new WSHttpBinding();
            host.AddServiceEndpoint(typeof(IConfiguration), wsHttpBinding,string.Empty);
            return host;
        }
    }
}