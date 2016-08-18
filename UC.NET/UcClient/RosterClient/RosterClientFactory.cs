using System.Net;
using System.ServiceModel;
using UcNetClient;

namespace RosterNetClient
{
    public class RosterClientFactory : IRosterClientFactory
    {
        private const string RosterEndpointUrlFormat = "https://{0}:8443/axl/services/AXLAPIService";

        public AXLPortClient CreateClient(IUcClientSettings settings)
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
            var RosterEndpointUrl = string.Format(RosterEndpointUrlFormat, settings.Server);
            var endpointAddress = new EndpointAddress(RosterEndpointUrl);
            var RosterClient = new AXLPortClient(basicHttpBinding, endpointAddress);
            RosterClient.ClientCredentials.UserName.UserName = settings.User;
            RosterClient.ClientCredentials.UserName.Password = settings.Password;
            return RosterClient;
        }
    }
}