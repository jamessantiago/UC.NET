namespace RisNetClient
{
    public interface IRisClientFactory
    {
        RisPortTypeClient CreateClient(IRisClientSettings settings);
    }
}