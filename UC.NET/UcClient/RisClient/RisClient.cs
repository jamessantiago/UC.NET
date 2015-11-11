using System;
using System.ServiceModel;
using System.Threading.Tasks;
using UcNetClient;

namespace RisNetClient
{
    public class RisClient : IRisClient
    {
        private readonly IRisClientFactory clientFactory;
        private readonly IUcClientSettings clientSettings;

        public RisClient(IUcClientSettings clientSettings) :
            this(new RisClientFactory(), clientSettings)
        {
        }

        public RisClient(IRisClientFactory clientFactory, IUcClientSettings clientSettings)
        {
            this.clientFactory = clientFactory;
            this.clientSettings = clientSettings;
        }

        public async Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<RisPortTypeClient, Task<TResultValue>> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                result.Value = await execute(client);
                client.Close();
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (Exception exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            return result;
        }

        public IUcResult<TResultValue> Execute<TResultValue>(Func<RisPortTypeClient, TResultValue> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                result.Value = execute(client);
                client.Close();
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (Exception exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            return result;
        }

        public async Task<IUcResult<bool>> ExecuteAsync(Func<RisPortTypeClient, Task> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                await execute(client);
                client.Close();
                result.Value = true;
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (Exception exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            return result;
        }

        public IUcResult<bool> Execute(Action<RisPortTypeClient> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.clientSettings);
            try
            {
                execute(client);
                client.Close();
                result.Value = true;
            }
            catch (CommunicationException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (TimeoutException exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            catch (Exception exception)
            {
                result.Exception = exception;
                client.Abort();
            }
            return result;
        }
    }
}