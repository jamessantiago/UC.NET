using System;
using System.Threading.Tasks;
using UcNetClient;

namespace RisNetClient
{
    public interface IRisClient
    {
        Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<RisPortTypeClient, Task<TResultValue>> execute);

        IUcResult<TResultValue> Execute<TResultValue>(Func<RisPortTypeClient, TResultValue> execute);

        Task<IUcResult<bool>> ExecuteAsync(Func<RisPortTypeClient, Task> execute);

        IUcResult<bool> Execute(Action<RisPortTypeClient> execute);
    }
}