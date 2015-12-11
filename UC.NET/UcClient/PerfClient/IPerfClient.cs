using System;
using System.Threading.Tasks;
using UcNetClient;

namespace PerfNetClient
{
    public interface IPerfClient
    {
        Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<PerfmonPortTypeClient, Task<TResultValue>> execute);

        IUcResult<TResultValue> Execute<TResultValue>(Func<PerfmonPortTypeClient, TResultValue> execute);

        Task<IUcResult<bool>> ExecuteAsync(Func<PerfmonPortTypeClient, Task> execute);

        IUcResult<bool> Execute(Action<PerfmonPortTypeClient> execute);
    }
}