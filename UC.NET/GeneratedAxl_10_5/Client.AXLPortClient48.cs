namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient48 _axlPortClient48;

        private static AXLPortClient48 axlPortClient48 => _axlPortClient48 == null ||
            _axlPortClient48.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient48 = LoadClient48()) : _axlPortClient48;

        private static AXLPortClient48 LoadClient48()
        {
            var client = new AXLPortClient48(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close48;
            OnAbort += Abort48;
            return client;
        }

        private static void Close48(object sender, System.EventArgs e)
        {
            _axlPortClient48.Close();
        }

        private static void Abort48(object sender, System.EventArgs e)
        {
            _axlPortClient48.Abort();
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient48.removeCiscoCatalyst600024PortFXSGateway(removeCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse> removeCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient48.removeCiscoCatalyst600024PortFXSGatewayAsync(removeCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayRes listCiscoCatalyst600024PortFXSGateway(AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayReq listCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient48.listCiscoCatalyst600024PortFXSGateway(listCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse> listCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayReq listCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient48.listCiscoCatalyst600024PortFXSGatewayAsync(listCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient48.resetCiscoCatalyst600024PortFXSGateway(resetCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse> resetCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient48.resetCiscoCatalyst600024PortFXSGatewayAsync(resetCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient48.restartCiscoCatalyst600024PortFXSGateway(restartCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse> restartCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient48.restartCiscoCatalyst600024PortFXSGatewayAsync(restartCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient48.applyCiscoCatalyst600024PortFXSGateway(applyCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse> applyCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient48.applyCiscoCatalyst600024PortFXSGatewayAsync(applyCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000E1VoIPGateway(AxlNetClient.AddCiscoCatalyst6000E1VoIPGatewayReq addCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.addCiscoCatalyst6000E1VoIPGateway(addCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse> addCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.AddCiscoCatalyst6000E1VoIPGatewayReq addCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.addCiscoCatalyst6000E1VoIPGatewayAsync(addCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000E1VoIPGateway(AxlNetClient.UpdateCiscoCatalyst6000E1VoIPGatewayReq updateCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.updateCiscoCatalyst6000E1VoIPGateway(updateCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse> updateCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.UpdateCiscoCatalyst6000E1VoIPGatewayReq updateCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.updateCiscoCatalyst6000E1VoIPGatewayAsync(updateCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayRes getCiscoCatalyst6000E1VoIPGateway(AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayReq getCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.getCiscoCatalyst6000E1VoIPGateway(getCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse> getCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayReq getCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.getCiscoCatalyst6000E1VoIPGatewayAsync(getCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.removeCiscoCatalyst6000E1VoIPGateway(removeCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse> removeCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.removeCiscoCatalyst6000E1VoIPGatewayAsync(removeCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayRes listCiscoCatalyst6000E1VoIPGateway(AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayReq listCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.listCiscoCatalyst6000E1VoIPGateway(listCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse> listCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayReq listCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.listCiscoCatalyst6000E1VoIPGatewayAsync(listCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.resetCiscoCatalyst6000E1VoIPGateway(resetCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse> resetCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.resetCiscoCatalyst6000E1VoIPGatewayAsync(resetCiscoCatalyst6000E1VoIPGateway);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000E1VoIPGateway1)
        {
            return axlPortClient48.restartCiscoCatalyst6000E1VoIPGateway(restartCiscoCatalyst6000E1VoIPGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse> restartCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000E1VoIPGateway)
        {
            return axlPortClient48.restartCiscoCatalyst6000E1VoIPGatewayAsync(restartCiscoCatalyst6000E1VoIPGateway);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort48
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse removeCiscoCatalyst600024PortFXSGateway(AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse> removeCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse listCiscoCatalyst600024PortFXSGateway(AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse> listCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse resetCiscoCatalyst600024PortFXSGateway(AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse> resetCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse restartCiscoCatalyst600024PortFXSGateway(AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse> restartCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse applyCiscoCatalyst600024PortFXSGateway(AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse> applyCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse addCiscoCatalyst6000E1VoIPGateway(AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse> addCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse updateCiscoCatalyst6000E1VoIPGateway(AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse> updateCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse getCiscoCatalyst6000E1VoIPGateway(AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse> getCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse removeCiscoCatalyst6000E1VoIPGateway(AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse> removeCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse listCiscoCatalyst6000E1VoIPGateway(AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse> listCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse resetCiscoCatalyst6000E1VoIPGateway(AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse> resetCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse restartCiscoCatalyst6000E1VoIPGateway(AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000E1VoIPGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse> restartCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest request);
    }

    public class AXLPortClient48 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort48>, AxlNetClient.AXLPort48
    {
        public AXLPortClient48(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort48.removeCiscoCatalyst600024PortFXSGateway(AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.removeCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.removeCiscoCatalyst600024PortFXSGateway = removeCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).removeCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.removeCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort48.removeCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.removeCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayResponse> removeCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.removeCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.removeCiscoCatalyst600024PortFXSGateway = removeCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort48)(this)).removeCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort48.listCiscoCatalyst600024PortFXSGateway(AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.listCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayRes listCiscoCatalyst600024PortFXSGateway(AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayReq listCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.listCiscoCatalyst600024PortFXSGateway = listCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).listCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.listCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort48.listCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.listCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst600024PortFXSGatewayResponse> listCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.ListCiscoCatalyst600024PortFXSGatewayReq listCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.listCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.listCiscoCatalyst600024PortFXSGateway = listCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort48)(this)).listCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort48.resetCiscoCatalyst600024PortFXSGateway(AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.resetCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.resetCiscoCatalyst600024PortFXSGateway = resetCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).resetCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.resetCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort48.resetCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.resetCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayResponse> resetCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.resetCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.resetCiscoCatalyst600024PortFXSGateway = resetCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort48)(this)).resetCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort48.restartCiscoCatalyst600024PortFXSGateway(AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.restartCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.restartCiscoCatalyst600024PortFXSGateway = restartCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).restartCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.restartCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort48.restartCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.restartCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayResponse> restartCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.restartCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.restartCiscoCatalyst600024PortFXSGateway = restartCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort48)(this)).restartCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort48.applyCiscoCatalyst600024PortFXSGateway(AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.applyCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst600024PortFXSGateway(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.applyCiscoCatalyst600024PortFXSGateway = applyCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).applyCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.applyCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort48.applyCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.applyCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayResponse> applyCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.applyCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.applyCiscoCatalyst600024PortFXSGateway = applyCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort48)(this)).applyCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.addCiscoCatalyst6000E1VoIPGateway(AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.addCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst6000E1VoIPGateway(AxlNetClient.AddCiscoCatalyst6000E1VoIPGatewayReq addCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.addCiscoCatalyst6000E1VoIPGateway = addCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).addCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.addCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.addCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.addCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayResponse> addCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.AddCiscoCatalyst6000E1VoIPGatewayReq addCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.addCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.addCiscoCatalyst6000E1VoIPGateway = addCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).addCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.updateCiscoCatalyst6000E1VoIPGateway(AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.updateCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst6000E1VoIPGateway(AxlNetClient.UpdateCiscoCatalyst6000E1VoIPGatewayReq updateCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.updateCiscoCatalyst6000E1VoIPGateway = updateCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).updateCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.updateCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.updateCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.updateCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayResponse> updateCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.UpdateCiscoCatalyst6000E1VoIPGatewayReq updateCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.updateCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.updateCiscoCatalyst6000E1VoIPGateway = updateCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).updateCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.getCiscoCatalyst6000E1VoIPGateway(AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.getCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayRes getCiscoCatalyst6000E1VoIPGateway(AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayReq getCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.getCiscoCatalyst6000E1VoIPGateway = getCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).getCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.getCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.getCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.getCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayResponse> getCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.GetCiscoCatalyst6000E1VoIPGatewayReq getCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.getCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.getCiscoCatalyst6000E1VoIPGateway = getCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).getCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.removeCiscoCatalyst6000E1VoIPGateway(AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.removeCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.removeCiscoCatalyst6000E1VoIPGateway = removeCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).removeCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.removeCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.removeCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.removeCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayResponse> removeCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.removeCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.removeCiscoCatalyst6000E1VoIPGateway = removeCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).removeCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.listCiscoCatalyst6000E1VoIPGateway(AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.listCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayRes listCiscoCatalyst6000E1VoIPGateway(AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayReq listCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.listCiscoCatalyst6000E1VoIPGateway = listCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).listCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.listCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.listCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.listCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayResponse> listCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.ListCiscoCatalyst6000E1VoIPGatewayReq listCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.listCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.listCiscoCatalyst6000E1VoIPGateway = listCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).listCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.resetCiscoCatalyst6000E1VoIPGateway(AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.resetCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.resetCiscoCatalyst6000E1VoIPGateway = resetCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).resetCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.resetCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.resetCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.resetCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayResponse> resetCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.resetCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.resetCiscoCatalyst6000E1VoIPGateway = resetCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).resetCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse AxlNetClient.AXLPort48.restartCiscoCatalyst6000E1VoIPGateway(AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.restartCiscoCatalyst6000E1VoIPGateway(request);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000E1VoIPGateway(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000E1VoIPGateway1)
        {
            AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.restartCiscoCatalyst6000E1VoIPGateway = restartCiscoCatalyst6000E1VoIPGateway1;
            AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse retVal = ((AxlNetClient.AXLPort48)(this)).restartCiscoCatalyst6000E1VoIPGateway(inValue);
            return retVal.restartCiscoCatalyst6000E1VoIPGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse> AxlNetClient.AXLPort48.restartCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest request)
        {
            return base.Channel.restartCiscoCatalyst6000E1VoIPGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayResponse> restartCiscoCatalyst6000E1VoIPGatewayAsync(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000E1VoIPGateway)
        {
            AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest inValue = new AxlNetClient.restartCiscoCatalyst6000E1VoIPGatewayRequest();
            inValue.restartCiscoCatalyst6000E1VoIPGateway = restartCiscoCatalyst6000E1VoIPGateway;
            return ((AxlNetClient.AXLPort48)(this)).restartCiscoCatalyst6000E1VoIPGatewayAsync(inValue);
        }
    }
}