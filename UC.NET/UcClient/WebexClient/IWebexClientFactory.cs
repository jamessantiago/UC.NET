using UcNetClient;

namespace WebexNetClient
{
    public interface IWebexClientFactory
    {
        WebexApiClient CreateClient(WebexClientSettings settings);
    }
}