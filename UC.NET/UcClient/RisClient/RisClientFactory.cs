using System.Net;
using System.ServiceModel;

namespace RisNetClient
{
    public class RisClientFactory : IRisClientFactory
    {
        private const string RisEndpointUrlFormat = "https://{0}:8443/realtimeservice2/services/RISService70";

        public RisPortTypeClient CreateClient(IRisClientSettings settings)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            ServicePointManager.Expect100Continue = false;
            var basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            var RisEndpointUrl = string.Format(RisEndpointUrlFormat, settings.Server);
            var endpointAddress = new EndpointAddress(RisEndpointUrl);
            var RisClient = new RisPortTypeClient(basicHttpBinding, endpointAddress);
            RisClient.ClientCredentials.UserName.UserName = settings.User;
            RisClient.ClientCredentials.UserName.Password = settings.Password;
            return RisClient;
        }
    }
}