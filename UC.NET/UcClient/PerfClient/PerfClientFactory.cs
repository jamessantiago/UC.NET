using System.Net;
using System.ServiceModel;
using UcNetClient;

namespace PerfNetClient
{
    public class PerfClientFactory : IPerfClientFactory
    {
        private const string PerfEndpointUrlFormat = "https://{0}:8443/perfmonservice2/services/PerfmonService";
        
        public PerfmonPortTypeClient CreateClient(IUcClientSettings settings)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            ServicePointManager.Expect100Continue = false;                      
            
            var basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            basicHttpBinding.MaxReceivedMessageSize = 20000000;
            basicHttpBinding.MaxBufferSize = 20000000;
            basicHttpBinding.MaxBufferPoolSize = 20000000;

            basicHttpBinding.ReaderQuotas.MaxDepth = 32;
            basicHttpBinding.ReaderQuotas.MaxArrayLength = 20000000;
            basicHttpBinding.ReaderQuotas.MaxStringContentLength = 20000000;
            
            basicHttpBinding.TransferMode = TransferMode.Buffered;
            basicHttpBinding.UseDefaultWebProxy = false;
            
            var axlEndpointUrl = string.Format(PerfEndpointUrlFormat, settings.Server);
            var endpointAddress = new EndpointAddress(axlEndpointUrl);
            var axlClient = new PerfmonPortTypeClient(basicHttpBinding, endpointAddress);
            axlClient.ClientCredentials.UserName.UserName = settings.User;
            axlClient.ClientCredentials.UserName.Password = settings.Password;
            return axlClient;
        }
    }
}