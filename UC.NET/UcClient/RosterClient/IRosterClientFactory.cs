using UcNetClient;

namespace RosterNetClient
{
    public interface IRosterClientFactory
    {
        AXLPortClient CreateClient(IUcClientSettings settings);
    }
}