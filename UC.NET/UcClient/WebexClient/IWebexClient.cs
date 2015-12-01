using System;
using System.Threading.Tasks;
using UcNetClient;
using WebexNetClient;

namespace WebexNetClient
{
    public interface IWebexClient
    {
        Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<WebexApiClient, Task<TResultValue>> execute);

        IUcResult<TResultValue> Execute<TResultValue>(Func<WebexApiClient, TResultValue> execute);

        Task<IUcResult<bool>> ExecuteAsync(Func<WebexApiClient, Task> execute);

        IUcResult<bool> Execute(Action<WebexApiClient> execute);
    }
}