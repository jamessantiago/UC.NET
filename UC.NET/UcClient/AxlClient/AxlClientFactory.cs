using System.Net;
using System.ServiceModel;
using UcNetClient;

namespace AxlNetClient
{
    public class AxlClientFactory : IAxlClientFactory
    {
        private const string AxlEndpointUrlFormat = "https://{0}:8443/axl/";
        
        public AXLPortClient CreateClient(IUcClientSettings settings)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            ServicePointManager.Expect100Continue = false;                
            
            var basicHttpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);            

            basicHttpBinding.MaxReceivedMessageSize = 20000000;
            basicHttpBinding.MaxBufferSize = 20000000;
            basicHttpBinding.MaxBufferPoolSize = 20000000;

            basicHttpBinding.ReaderQuotas.MaxDepth = 32;
            basicHttpBinding.ReaderQuotas.MaxArrayLength = 20000000;
            basicHttpBinding.ReaderQuotas.MaxStringContentLength = 20000000;
            basicHttpBinding.ReaderQuotas.MaxNameTableCharCount = 20000000;

            basicHttpBinding.TransferMode = TransferMode.Buffered;

            var axlEndpointUrl = string.Format(AxlEndpointUrlFormat, settings.Server);
            var endpointAddress = new EndpointAddress(axlEndpointUrl);
            var axlClient = new AXLPortClient(basicHttpBinding, endpointAddress, settings.User, settings.Password);            
            return axlClient;            
        }
    }
}