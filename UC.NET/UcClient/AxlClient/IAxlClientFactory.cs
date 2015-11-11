using UcNetClient;

namespace AxlNetClient
{
    public interface IAxlClientFactory
    {
        AXLPortClient CreateClient(IUcClientSettings settings);
    }
}