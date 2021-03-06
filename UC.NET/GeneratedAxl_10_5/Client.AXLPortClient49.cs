namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient49 _axlPortClient49;

        private static AXLPortClient49 axlPortClient49 => _axlPortClient49 == null ||
            _axlPortClient49.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient49 = LoadClient49()) : _axlPortClient49;

        private static AXLPortClient49 LoadClient49()
        {
            var client = new AXLPortClient49(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close49;
            OnAbort += Abort49;
            return client;
        }

        private static void Close49(object sender, System.EventArgs e)
        {
            _axlPortClient49.Close();
        }

        private static void Abort49(object sender, System.EventArgs e)
        {
            _axlPortClient49.Abort();
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient49.applyCiscoCatalyst6000E1VoIPGateway(applyCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse> applyCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient49.applyCiscoCatalyst6000E1VoIPGatewayAsync(applyCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayPriReq addCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.addCiscoCatalyst6000T1VoIPGatewayPri(addCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse> addCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayPriReq addCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.addCiscoCatalyst6000T1VoIPGatewayPriAsync(addCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayPriReq updateCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.updateCiscoCatalyst6000T1VoIPGatewayPri(updateCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse> updateCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayPriReq updateCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.updateCiscoCatalyst6000T1VoIPGatewayPriAsync(updateCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriRes getCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriReq getCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.getCiscoCatalyst6000T1VoIPGatewayPri(getCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse> getCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriReq getCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.getCiscoCatalyst6000T1VoIPGatewayPriAsync(getCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.removeCiscoCatalyst6000T1VoIPGatewayPri(removeCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse> removeCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.removeCiscoCatalyst6000T1VoIPGatewayPriAsync(removeCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriRes listCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriReq listCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.listCiscoCatalyst6000T1VoIPGatewayPri(listCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse> listCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriReq listCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.listCiscoCatalyst6000T1VoIPGatewayPriAsync(listCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.resetCiscoCatalyst6000T1VoIPGatewayPri(resetCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse> resetCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.resetCiscoCatalyst6000T1VoIPGatewayPriAsync(resetCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.restartCiscoCatalyst6000T1VoIPGatewayPri(restartCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse> restartCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.restartCiscoCatalyst6000T1VoIPGatewayPriAsync(restartCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            return axlPortClient49.applyCiscoCatalyst6000T1VoIPGatewayPri(applyCiscoCatalyst6000T1VoIPGatewayPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse> applyCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayPri)
        {
            return axlPortClient49.applyCiscoCatalyst6000T1VoIPGatewayPriAsync(applyCiscoCatalyst6000T1VoIPGatewayPri);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayT1Req addCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient49.addCiscoCatalyst6000T1VoIPGatewayT1(addCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response> addCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayT1Req addCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient49.addCiscoCatalyst6000T1VoIPGatewayT1Async(addCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayT1Req updateCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient49.updateCiscoCatalyst6000T1VoIPGatewayT1(updateCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response> updateCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayT1Req updateCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient49.updateCiscoCatalyst6000T1VoIPGatewayT1Async(updateCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Res getCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Req getCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient49.getCiscoCatalyst6000T1VoIPGatewayT1(getCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response> getCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Req getCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient49.getCiscoCatalyst6000T1VoIPGatewayT1Async(getCiscoCatalyst6000T1VoIPGatewayT1);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort49
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse applyCiscoCatalyst6000E1VoIPGateway(AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse> applyCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse addCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse> addCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse updateCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse> updateCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse getCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse> getCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse removeCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse> removeCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse listCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse> listCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse resetCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse> resetCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse restartCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse> restartCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse applyCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000T1VoIPGatewayPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse> applyCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response addCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response> addCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response updateCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response> updateCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response getCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response> getCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request request);
    }

    public class AXLPortClient49 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort49>, AxlNetClient.AXLPort49
    {
        public AXLPortClient49(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort49.applyCiscoCatalyst6000E1VoIPGateway(AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.applyCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.applyCiscoCatalyst6000E1VoIPGateway = applyCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort49)(this)).applyCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.applyCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort49.applyCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.applyCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayResponse> applyCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.applyCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.applyCiscoCatalyst6000E1VoIPGateway = applyCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort49)(this)).applyCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.addCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.addCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayPriReq addCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.addCiscoCatalyst6000T1VoIPGatewayPri = addCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).addCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.addCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.addCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.addCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriResponse> addCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayPriReq addCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.addCiscoCatalyst6000T1VoIPGatewayPri = addCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).addCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.updateCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.updateCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayPriReq updateCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.updateCiscoCatalyst6000T1VoIPGatewayPri = updateCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).updateCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.updateCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.updateCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.updateCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriResponse> updateCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayPriReq updateCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.updateCiscoCatalyst6000T1VoIPGatewayPri = updateCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).updateCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.getCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.getCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriRes getCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriReq getCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.getCiscoCatalyst6000T1VoIPGatewayPri = getCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).getCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.getCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.getCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.getCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriResponse> getCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayPriReq getCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.getCiscoCatalyst6000T1VoIPGatewayPri = getCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).getCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.removeCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.removeCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.removeCiscoCatalyst6000T1VoIPGatewayPri = removeCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).removeCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.removeCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.removeCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.removeCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriResponse> removeCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.removeCiscoCatalyst6000T1VoIPGatewayPri = removeCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).removeCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.listCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.listCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriRes listCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriReq listCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.listCiscoCatalyst6000T1VoIPGatewayPri = listCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).listCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.listCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.listCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.listCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriResponse> listCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayPriReq listCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.listCiscoCatalyst6000T1VoIPGatewayPri = listCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).listCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.resetCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.resetCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.resetCiscoCatalyst6000T1VoIPGatewayPri = resetCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).resetCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.resetCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.resetCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.resetCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriResponse> resetCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.resetCiscoCatalyst6000T1VoIPGatewayPri = resetCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).resetCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.restartCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.restartCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.restartCiscoCatalyst6000T1VoIPGatewayPri = restartCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).restartCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.restartCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.restartCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.restartCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriResponse> restartCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.restartCiscoCatalyst6000T1VoIPGatewayPri = restartCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).restartCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse AxlNetClient.AXLPort49.applyCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.applyCiscoCatalyst6000T1VoIPGatewayPri(request);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000T1VoIPGatewayPri(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayPri1)
        {
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.applyCiscoCatalyst6000T1VoIPGatewayPri = applyCiscoCatalyst6000T1VoIPGatewayPri1;
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse retVal = ((AxlNetClient.AXLPort49)(this)).applyCiscoCatalyst6000T1VoIPGatewayPri(inValue);
            return retVal.applyCiscoCatalyst6000T1VoIPGatewayPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse> AxlNetClient.AXLPort49.applyCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest request)
        {
            return base.Channel.applyCiscoCatalyst6000T1VoIPGatewayPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriResponse> applyCiscoCatalyst6000T1VoIPGatewayPriAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayPri)
        {
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest inValue = new AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayPriRequest();
            inValue.applyCiscoCatalyst6000T1VoIPGatewayPri = applyCiscoCatalyst6000T1VoIPGatewayPri;
            return ((AxlNetClient.AXLPort49)(this)).applyCiscoCatalyst6000T1VoIPGatewayPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort49.addCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.addCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayT1Req addCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.addCiscoCatalyst6000T1VoIPGatewayT1 = addCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort49)(this)).addCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.addCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort49.addCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.addCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Response> addCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.AddCiscoCatalyst6000T1VoIPGatewayT1Req addCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.addCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.addCiscoCatalyst6000T1VoIPGatewayT1 = addCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort49)(this)).addCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort49.updateCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.updateCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayT1Req updateCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.updateCiscoCatalyst6000T1VoIPGatewayT1 = updateCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort49)(this)).updateCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.updateCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort49.updateCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.updateCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Response> updateCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.UpdateCiscoCatalyst6000T1VoIPGatewayT1Req updateCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.updateCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.updateCiscoCatalyst6000T1VoIPGatewayT1 = updateCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort49)(this)).updateCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort49.getCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.getCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Res getCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Req getCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.getCiscoCatalyst6000T1VoIPGatewayT1 = getCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort49)(this)).getCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.getCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort49.getCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.getCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Response> getCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.GetCiscoCatalyst6000T1VoIPGatewayT1Req getCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.getCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.getCiscoCatalyst6000T1VoIPGatewayT1 = getCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort49)(this)).getCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }
    }
}