using UcNetClient;

namespace PerfNetClient
{
    public interface IPerfClientFactory
    {
        PerfmonPortTypeClient CreateClient(IUcClientSettings settings);
    }
}