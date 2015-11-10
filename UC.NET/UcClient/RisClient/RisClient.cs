using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace RisNetClient
{
    public class RisClient : IRisClient
    {
        private readonly IRisClientFactory clientFactory;
        private readonly IRisClientSettings clientSettings;

        public RisClient(IRisClientSettings clientSettings) :
            this(new RisClientFactory(), clientSettings)
        {
        }

        public RisClient(IRisClientFactory clientFactory, IRisClientSettings clientSettings)
        {
            this.clientFactory = clientFactory;
            this.clientSettings = clientSettings;
        }

        public async Task<IRisResult<TResultValue>> ExecuteAsync<TResultValue>(Func<RisPortTypeClient, Task<TResultValue>> execute)
        {
            var result = new RisResult<TResultValue>();
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

        public IRisResult<TResultValue> Execute<TResultValue>(Func<RisPortTypeClient, TResultValue> execute)
        {
            var result = new RisResult<TResultValue>();
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

        public async Task<IRisResult<bool>> ExecuteAsync(Func<RisPortTypeClient, Task> execute)
        {
            var result = new RisResult<bool>();
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

        public IRisResult<bool> Execute(Action<RisPortTypeClient> execute)
        {
            var result = new RisResult<bool>();
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