using System;
using System.Threading.Tasks;
using UcNetClient;

namespace EpasNetClient
{
    public interface IEpasClient
    {
        Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<EpasSoapServiceInterfaceClient, Task<TResultValue>> execute);

        IUcResult<TResultValue> Execute<TResultValue>(Func<EpasSoapServiceInterfaceClient, TResultValue> execute);

        Task<IUcResult<bool>> ExecuteAsync(Func<EpasSoapServiceInterfaceClient, Task> execute);

        IUcResult<bool> Execute(Action<EpasSoapServiceInterfaceClient> execute);
    }
}