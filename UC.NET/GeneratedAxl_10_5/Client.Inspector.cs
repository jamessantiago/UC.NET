using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;

namespace AxlNetClient
{
    public class AxlClientInspector : IClientMessageInspector
    {
        private string authstring;

        public AxlClientInspector(string AuthenticationString)
        {
            authstring = AuthenticationString;            
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            // Making sure we have a HttpRequestMessageProperty
            HttpRequestMessageProperty httpRequestMessageProperty;
            if (request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                httpRequestMessageProperty = request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
                if (httpRequestMessageProperty == null)
                {
                    httpRequestMessageProperty = new HttpRequestMessageProperty();
                    request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
                }
            }
            else
            {
                httpRequestMessageProperty = new HttpRequestMessageProperty();
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessageProperty);
            }
            // Add the authorization header to the WCF request    
            httpRequestMessageProperty.Headers.Add("Authorization", authstring);
            return null;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }
    }

    public class AuthenticationBehavior : IEndpointBehavior
    {
        private string authstring;

        public AuthenticationBehavior(string username, string password)
        {
            authstring = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new AxlClientInspector(authstring));
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}
