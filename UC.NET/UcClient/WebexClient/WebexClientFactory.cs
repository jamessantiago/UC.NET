using System.Net;
using System.ServiceModel;
using UcNetClient;

namespace WebexNetClient
{
    public class WebexClientFactory : IWebexClientFactory
    {
        private const string WebexEndpointUrlFormat = "https://{0}/WBXService/XMLService";

        public WebexApiClient CreateClient(WebexClientSettings settings)
        {
            var webexEndpointUrl = string.Format(WebexEndpointUrlFormat, settings.Server);
            var securityContext = new securityContextType()
            {
                siteID = settings.SiteId,
                siteIDSpecified = true,
                webExID = settings.User,
                password = settings.Password,                
                partnerID = settings.PartnetId,
                email = settings.Email
            };            
            var webexClient = new WebexApiClient(webexEndpointUrl, securityContext);
            return webexClient;
        }
    }
}