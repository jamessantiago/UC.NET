using System;
using System.Threading.Tasks;

namespace RisNetClient
{
    public interface IRisClient
    {
        Task<IRisResult<TResultValue>> ExecuteAsync<TResultValue>(Func<RisPortTypeClient, Task<TResultValue>> execute);

        IRisResult<TResultValue> Execute<TResultValue>(Func<RisPortTypeClient, TResultValue> execute);

        Task<IRisResult<bool>> ExecuteAsync(Func<RisPortTypeClient, Task> execute);

        IRisResult<bool> Execute(Action<RisPortTypeClient> execute);
    }
}