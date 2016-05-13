using System.Net;
using System.ServiceModel;
using UcNetClient;

namespace EpasNetClient
{
    public class EpasClientFactory : IEpasClientFactory
    {
        private const string EpasEndpointUrlFormat = "https://{0}:8443/EPASSoap/service/latest";
        
        public EpasSoapServiceInterfaceClient CreateClient(string server)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            ServicePointManager.Expect100Continue = false;

            var basicHttpBinding = new WSHttpBinding(SecurityMode.Transport);
            //basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;

            basicHttpBinding.MaxReceivedMessageSize = 20000000;
            //basicHttpBinding.MaxBufferSize = 20000000;
            basicHttpBinding.MaxBufferPoolSize = 20000000;

            basicHttpBinding.ReaderQuotas.MaxDepth = 32;
            basicHttpBinding.ReaderQuotas.MaxArrayLength = 20000000;
            basicHttpBinding.ReaderQuotas.MaxStringContentLength = 20000000;
            
            //basicHttpBinding.TransferMode = TransferMode.Buffered;
            
            var epasEndpointUrl = string.Format(EpasEndpointUrlFormat, server);
            var endpointAddress = new EndpointAddress(epasEndpointUrl);
            var epasClient = new EpasSoapServiceInterfaceClient(basicHttpBinding, endpointAddress);
            return epasClient;
        }
    }
}