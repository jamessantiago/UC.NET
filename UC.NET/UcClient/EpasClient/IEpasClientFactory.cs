using UcNetClient;

namespace EpasNetClient
{
    public interface IEpasClientFactory
    {
        EpasSoapServiceInterfaceClient CreateClient(string settings);
    }
}