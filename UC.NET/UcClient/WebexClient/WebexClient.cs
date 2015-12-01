using System;
using System.ServiceModel;
using System.Threading.Tasks;
using UcNetClient;

namespace WebexNetClient
{
    public class WebexClient : IWebexClient
    {
        private readonly IWebexClientFactory clientFactory;
        private readonly WebexClientSettings clientSettings;

        public WebexClient(WebexClientSettings clientSettings) :
            this(new WebexClientFactory(), clientSettings)
        {
        }

        public WebexClient(IWebexClientFactory clientFactory, WebexClientSettings clientSettings)
        {
            this.clientFactory = clientFactory;
            this.clientSettings = clientSettings;
        }

        public async Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<WebexApiClient, Task<TResultValue>> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                result.Value = await execute(client);
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
            }
            catch (Exception exception)
            {
                result.Exception = exception;
            }
            return result;
        }

        public IUcResult<TResultValue> Execute<TResultValue>(Func<WebexApiClient, TResultValue> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                result.Value = execute(client);
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
            }
            catch (Exception exception)
            {
                result.Exception = exception;
            }
            return result;
        }

        public async Task<IUcResult<bool>> ExecuteAsync(Func<WebexApiClient, Task> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                await execute(client);
                result.Value = true;
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
            }
            catch (Exception exception)
            {
                result.Exception = exception;
            }
            return result;
        }

        public IUcResult<bool> Execute(Action<WebexApiClient> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                execute(client);
                result.Value = true;
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
            }
            catch (Exception exception)
            {
                result.Exception = exception;
            }
            return result;
        }
    }
}