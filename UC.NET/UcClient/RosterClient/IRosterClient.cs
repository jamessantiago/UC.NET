using System;
using System.Threading.Tasks;
using UcNetClient;

namespace RosterNetClient
{
    public interface IRosterClient
    {
        Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<AXLPortClient, Task<TResultValue>> execute);

        IUcResult<TResultValue> Execute<TResultValue>(Func<AXLPortClient, TResultValue> execute);

        Task<IUcResult<bool>> ExecuteAsync(Func<AXLPortClient, Task> execute);

        IUcResult<bool> Execute(Action<AXLPortClient> execute);
    }
}