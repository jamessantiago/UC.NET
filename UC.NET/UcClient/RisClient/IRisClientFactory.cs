using UcNetClient;

namespace RisNetClient
{
    public interface IRisClientFactory
    {
        RisPortTypeClient CreateClient(IUcClientSettings settings);
    }
}