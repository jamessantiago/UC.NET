using System;
using System.ServiceModel;
using System.Threading.Tasks;
using UcNetClient;

namespace EpasNetClient
{
    public class EpasClient : IEpasClient
    {
        private readonly IEpasClientFactory clientFactory;
        private readonly string server;

        public EpasClient(string server) :
            this(new EpasClientFactory(), server)
        {
        }

        public EpasClient(EpasClientFactory clientFactory, string server)
        {
            this.clientFactory = clientFactory;
            this.server = server;
        }

        public async Task<IUcResult<TResultValue>> ExecuteAsync<TResultValue>(Func<EpasSoapServiceInterfaceClient, Task<TResultValue>> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.server);
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

        public IUcResult<TResultValue> Execute<TResultValue>(Func<EpasSoapServiceInterfaceClient, TResultValue> execute)
        {
            var result = new UcResult<TResultValue>();
            var client = this.clientFactory.CreateClient(this.server);
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

        public async Task<IUcResult<bool>> ExecuteAsync(Func<EpasSoapServiceInterfaceClient, Task> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.server);
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

        public IUcResult<bool> Execute(Action<EpasSoapServiceInterfaceClient> execute)
        {
            var result = new UcResult<bool>();
            var client = this.clientFactory.CreateClient(this.server);
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