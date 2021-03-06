namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient47 _axlPortClient47;

        private static AXLPortClient47 axlPortClient47 => _axlPortClient47 == null ||
            _axlPortClient47.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient47 = LoadClient47()) : _axlPortClient47;

        private static AXLPortClient47 LoadClient47()
        {
            var client = new AXLPortClient47(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close47;
            OnAbort += Abort47;
            return client;
        }

        private static void Close47(object sender, System.EventArgs e)
        {
            _axlPortClient47.Close();
        }

        private static void Abort47(object sender, System.EventArgs e)
        {
            _axlPortClient47.Abort();
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessPri(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessPri1)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessPri(removeGatewayEndpointDigitalAccessPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse> removeGatewayEndpointDigitalAccessPriAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessPri)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessPriAsync(removeGatewayEndpointDigitalAccessPri);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessBri(AxlNetClient.AddGatewayEndpointDigitalAccessBriReq addGatewayEndpointDigitalAccessBri1)
        {
            return axlPortClient47.addGatewayEndpointDigitalAccessBri(addGatewayEndpointDigitalAccessBri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessBriResponse> addGatewayEndpointDigitalAccessBriAsync(AxlNetClient.AddGatewayEndpointDigitalAccessBriReq addGatewayEndpointDigitalAccessBri)
        {
            return axlPortClient47.addGatewayEndpointDigitalAccessBriAsync(addGatewayEndpointDigitalAccessBri);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessBri(AxlNetClient.UpdateGatewayEndpointDigitalAccessBriReq updateGatewayEndpointDigitalAccessBri1)
        {
            return axlPortClient47.updateGatewayEndpointDigitalAccessBri(updateGatewayEndpointDigitalAccessBri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse> updateGatewayEndpointDigitalAccessBriAsync(AxlNetClient.UpdateGatewayEndpointDigitalAccessBriReq updateGatewayEndpointDigitalAccessBri)
        {
            return axlPortClient47.updateGatewayEndpointDigitalAccessBriAsync(updateGatewayEndpointDigitalAccessBri);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessBriRes getGatewayEndpointDigitalAccessBri(AxlNetClient.GetGatewayEndpointDigitalAccessBriReq getGatewayEndpointDigitalAccessBri1)
        {
            return axlPortClient47.getGatewayEndpointDigitalAccessBri(getGatewayEndpointDigitalAccessBri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessBriResponse> getGatewayEndpointDigitalAccessBriAsync(AxlNetClient.GetGatewayEndpointDigitalAccessBriReq getGatewayEndpointDigitalAccessBri)
        {
            return axlPortClient47.getGatewayEndpointDigitalAccessBriAsync(getGatewayEndpointDigitalAccessBri);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessBri(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessBri1)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessBri(removeGatewayEndpointDigitalAccessBri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse> removeGatewayEndpointDigitalAccessBriAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessBri)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessBriAsync(removeGatewayEndpointDigitalAccessBri);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessT1(AxlNetClient.AddGatewayEndpointDigitalAccessT1Req addGatewayEndpointDigitalAccessT11)
        {
            return axlPortClient47.addGatewayEndpointDigitalAccessT1(addGatewayEndpointDigitalAccessT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessT1Response> addGatewayEndpointDigitalAccessT1Async(AxlNetClient.AddGatewayEndpointDigitalAccessT1Req addGatewayEndpointDigitalAccessT1)
        {
            return axlPortClient47.addGatewayEndpointDigitalAccessT1Async(addGatewayEndpointDigitalAccessT1);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessT1(AxlNetClient.UpdateGatewayEndpointDigitalAccessT1Req updateGatewayEndpointDigitalAccessT11)
        {
            return axlPortClient47.updateGatewayEndpointDigitalAccessT1(updateGatewayEndpointDigitalAccessT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessT1Response> updateGatewayEndpointDigitalAccessT1Async(AxlNetClient.UpdateGatewayEndpointDigitalAccessT1Req updateGatewayEndpointDigitalAccessT1)
        {
            return axlPortClient47.updateGatewayEndpointDigitalAccessT1Async(updateGatewayEndpointDigitalAccessT1);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessT1Res getGatewayEndpointDigitalAccessT1(AxlNetClient.GetGatewayEndpointDigitalAccessT1Req getGatewayEndpointDigitalAccessT11)
        {
            return axlPortClient47.getGatewayEndpointDigitalAccessT1(getGatewayEndpointDigitalAccessT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessT1Response> getGatewayEndpointDigitalAccessT1Async(AxlNetClient.GetGatewayEndpointDigitalAccessT1Req getGatewayEndpointDigitalAccessT1)
        {
            return axlPortClient47.getGatewayEndpointDigitalAccessT1Async(getGatewayEndpointDigitalAccessT1);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessT1(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessT11)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessT1(removeGatewayEndpointDigitalAccessT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessT1Response> removeGatewayEndpointDigitalAccessT1Async(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessT1)
        {
            return axlPortClient47.removeGatewayEndpointDigitalAccessT1Async(removeGatewayEndpointDigitalAccessT1);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst600024PortFXSGateway(AxlNetClient.AddCiscoCatalyst600024PortFXSGatewayReq addCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient47.addCiscoCatalyst600024PortFXSGateway(addCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse> addCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.AddCiscoCatalyst600024PortFXSGatewayReq addCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient47.addCiscoCatalyst600024PortFXSGatewayAsync(addCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst600024PortFXSGateway(AxlNetClient.UpdateCiscoCatalyst600024PortFXSGatewayReq updateCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient47.updateCiscoCatalyst600024PortFXSGateway(updateCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse> updateCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.UpdateCiscoCatalyst600024PortFXSGatewayReq updateCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient47.updateCiscoCatalyst600024PortFXSGatewayAsync(updateCiscoCatalyst600024PortFXSGateway);
        }

        public AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayRes getCiscoCatalyst600024PortFXSGateway(AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayReq getCiscoCatalyst600024PortFXSGateway1)
        {
            return axlPortClient47.getCiscoCatalyst600024PortFXSGateway(getCiscoCatalyst600024PortFXSGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse> getCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayReq getCiscoCatalyst600024PortFXSGateway)
        {
            return axlPortClient47.getCiscoCatalyst600024PortFXSGatewayAsync(getCiscoCatalyst600024PortFXSGateway);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort47
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse removeGatewayEndpointDigitalAccessPri(AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse> removeGatewayEndpointDigitalAccessPriAsync(AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewayEndpointDigitalAccessBriResponse addGatewayEndpointDigitalAccessBri(AxlNetClient.addGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessBriResponse> addGatewayEndpointDigitalAccessBriAsync(AxlNetClient.addGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse updateGatewayEndpointDigitalAccessBri(AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse> updateGatewayEndpointDigitalAccessBriAsync(AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewayEndpointDigitalAccessBriResponse getGatewayEndpointDigitalAccessBri(AxlNetClient.getGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessBriResponse> getGatewayEndpointDigitalAccessBriAsync(AxlNetClient.getGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse removeGatewayEndpointDigitalAccessBri(AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessBri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse> removeGatewayEndpointDigitalAccessBriAsync(AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewayEndpointDigitalAccessT1Response addGatewayEndpointDigitalAccessT1(AxlNetClient.addGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessT1Response> addGatewayEndpointDigitalAccessT1Async(AxlNetClient.addGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewayEndpointDigitalAccessT1Response updateGatewayEndpointDigitalAccessT1(AxlNetClient.updateGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessT1Response> updateGatewayEndpointDigitalAccessT1Async(AxlNetClient.updateGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewayEndpointDigitalAccessT1Response getGatewayEndpointDigitalAccessT1(AxlNetClient.getGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessT1Response> getGatewayEndpointDigitalAccessT1Async(AxlNetClient.getGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewayEndpointDigitalAccessT1Response removeGatewayEndpointDigitalAccessT1(AxlNetClient.removeGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointDigitalAccessT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessT1Response> removeGatewayEndpointDigitalAccessT1Async(AxlNetClient.removeGatewayEndpointDigitalAccessT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse addCiscoCatalyst600024PortFXSGateway(AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse> addCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse updateCiscoCatalyst600024PortFXSGateway(AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse> updateCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse getCiscoCatalyst600024PortFXSGateway(AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCiscoCatalyst600024PortFXSGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse> getCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest request);
    }

    public class AXLPortClient47 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort47>, AxlNetClient.AXLPort47
    {
        public AXLPortClient47(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessPri(AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessPri(request);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessPri(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessPri1)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest();
            inValue.removeGatewayEndpointDigitalAccessPri = removeGatewayEndpointDigitalAccessPri1;
            AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse retVal = ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessPri(inValue);
            return retVal.removeGatewayEndpointDigitalAccessPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse> AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessPriAsync(AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessPriResponse> removeGatewayEndpointDigitalAccessPriAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessPri)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessPriRequest();
            inValue.removeGatewayEndpointDigitalAccessPri = removeGatewayEndpointDigitalAccessPri;
            return ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewayEndpointDigitalAccessBriResponse AxlNetClient.AXLPort47.addGatewayEndpointDigitalAccessBri(AxlNetClient.addGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessBri(request);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessBri(AxlNetClient.AddGatewayEndpointDigitalAccessBriReq addGatewayEndpointDigitalAccessBri1)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.addGatewayEndpointDigitalAccessBriRequest();
            inValue.addGatewayEndpointDigitalAccessBri = addGatewayEndpointDigitalAccessBri1;
            AxlNetClient.addGatewayEndpointDigitalAccessBriResponse retVal = ((AxlNetClient.AXLPort47)(this)).addGatewayEndpointDigitalAccessBri(inValue);
            return retVal.addGatewayEndpointDigitalAccessBriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessBriResponse> AxlNetClient.AXLPort47.addGatewayEndpointDigitalAccessBriAsync(AxlNetClient.addGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessBriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessBriResponse> addGatewayEndpointDigitalAccessBriAsync(AxlNetClient.AddGatewayEndpointDigitalAccessBriReq addGatewayEndpointDigitalAccessBri)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.addGatewayEndpointDigitalAccessBriRequest();
            inValue.addGatewayEndpointDigitalAccessBri = addGatewayEndpointDigitalAccessBri;
            return ((AxlNetClient.AXLPort47)(this)).addGatewayEndpointDigitalAccessBriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse AxlNetClient.AXLPort47.updateGatewayEndpointDigitalAccessBri(AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessBri(request);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessBri(AxlNetClient.UpdateGatewayEndpointDigitalAccessBriReq updateGatewayEndpointDigitalAccessBri1)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest();
            inValue.updateGatewayEndpointDigitalAccessBri = updateGatewayEndpointDigitalAccessBri1;
            AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse retVal = ((AxlNetClient.AXLPort47)(this)).updateGatewayEndpointDigitalAccessBri(inValue);
            return retVal.updateGatewayEndpointDigitalAccessBriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse> AxlNetClient.AXLPort47.updateGatewayEndpointDigitalAccessBriAsync(AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessBriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessBriResponse> updateGatewayEndpointDigitalAccessBriAsync(AxlNetClient.UpdateGatewayEndpointDigitalAccessBriReq updateGatewayEndpointDigitalAccessBri)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessBriRequest();
            inValue.updateGatewayEndpointDigitalAccessBri = updateGatewayEndpointDigitalAccessBri;
            return ((AxlNetClient.AXLPort47)(this)).updateGatewayEndpointDigitalAccessBriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewayEndpointDigitalAccessBriResponse AxlNetClient.AXLPort47.getGatewayEndpointDigitalAccessBri(AxlNetClient.getGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessBri(request);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessBriRes getGatewayEndpointDigitalAccessBri(AxlNetClient.GetGatewayEndpointDigitalAccessBriReq getGatewayEndpointDigitalAccessBri1)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.getGatewayEndpointDigitalAccessBriRequest();
            inValue.getGatewayEndpointDigitalAccessBri = getGatewayEndpointDigitalAccessBri1;
            AxlNetClient.getGatewayEndpointDigitalAccessBriResponse retVal = ((AxlNetClient.AXLPort47)(this)).getGatewayEndpointDigitalAccessBri(inValue);
            return retVal.getGatewayEndpointDigitalAccessBriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessBriResponse> AxlNetClient.AXLPort47.getGatewayEndpointDigitalAccessBriAsync(AxlNetClient.getGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessBriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessBriResponse> getGatewayEndpointDigitalAccessBriAsync(AxlNetClient.GetGatewayEndpointDigitalAccessBriReq getGatewayEndpointDigitalAccessBri)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.getGatewayEndpointDigitalAccessBriRequest();
            inValue.getGatewayEndpointDigitalAccessBri = getGatewayEndpointDigitalAccessBri;
            return ((AxlNetClient.AXLPort47)(this)).getGatewayEndpointDigitalAccessBriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessBri(AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessBri(request);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessBri(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessBri1)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest();
            inValue.removeGatewayEndpointDigitalAccessBri = removeGatewayEndpointDigitalAccessBri1;
            AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse retVal = ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessBri(inValue);
            return retVal.removeGatewayEndpointDigitalAccessBriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse> AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessBriAsync(AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessBriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessBriResponse> removeGatewayEndpointDigitalAccessBriAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessBri)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessBriRequest();
            inValue.removeGatewayEndpointDigitalAccessBri = removeGatewayEndpointDigitalAccessBri;
            return ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessBriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewayEndpointDigitalAccessT1Response AxlNetClient.AXLPort47.addGatewayEndpointDigitalAccessT1(AxlNetClient.addGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessT1(request);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessT1(AxlNetClient.AddGatewayEndpointDigitalAccessT1Req addGatewayEndpointDigitalAccessT11)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.addGatewayEndpointDigitalAccessT1Request();
            inValue.addGatewayEndpointDigitalAccessT1 = addGatewayEndpointDigitalAccessT11;
            AxlNetClient.addGatewayEndpointDigitalAccessT1Response retVal = ((AxlNetClient.AXLPort47)(this)).addGatewayEndpointDigitalAccessT1(inValue);
            return retVal.addGatewayEndpointDigitalAccessT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessT1Response> AxlNetClient.AXLPort47.addGatewayEndpointDigitalAccessT1Async(AxlNetClient.addGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessT1Response> addGatewayEndpointDigitalAccessT1Async(AxlNetClient.AddGatewayEndpointDigitalAccessT1Req addGatewayEndpointDigitalAccessT1)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.addGatewayEndpointDigitalAccessT1Request();
            inValue.addGatewayEndpointDigitalAccessT1 = addGatewayEndpointDigitalAccessT1;
            return ((AxlNetClient.AXLPort47)(this)).addGatewayEndpointDigitalAccessT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewayEndpointDigitalAccessT1Response AxlNetClient.AXLPort47.updateGatewayEndpointDigitalAccessT1(AxlNetClient.updateGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessT1(request);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessT1(AxlNetClient.UpdateGatewayEndpointDigitalAccessT1Req updateGatewayEndpointDigitalAccessT11)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessT1Request();
            inValue.updateGatewayEndpointDigitalAccessT1 = updateGatewayEndpointDigitalAccessT11;
            AxlNetClient.updateGatewayEndpointDigitalAccessT1Response retVal = ((AxlNetClient.AXLPort47)(this)).updateGatewayEndpointDigitalAccessT1(inValue);
            return retVal.updateGatewayEndpointDigitalAccessT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessT1Response> AxlNetClient.AXLPort47.updateGatewayEndpointDigitalAccessT1Async(AxlNetClient.updateGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessT1Response> updateGatewayEndpointDigitalAccessT1Async(AxlNetClient.UpdateGatewayEndpointDigitalAccessT1Req updateGatewayEndpointDigitalAccessT1)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessT1Request();
            inValue.updateGatewayEndpointDigitalAccessT1 = updateGatewayEndpointDigitalAccessT1;
            return ((AxlNetClient.AXLPort47)(this)).updateGatewayEndpointDigitalAccessT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewayEndpointDigitalAccessT1Response AxlNetClient.AXLPort47.getGatewayEndpointDigitalAccessT1(AxlNetClient.getGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessT1(request);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessT1Res getGatewayEndpointDigitalAccessT1(AxlNetClient.GetGatewayEndpointDigitalAccessT1Req getGatewayEndpointDigitalAccessT11)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.getGatewayEndpointDigitalAccessT1Request();
            inValue.getGatewayEndpointDigitalAccessT1 = getGatewayEndpointDigitalAccessT11;
            AxlNetClient.getGatewayEndpointDigitalAccessT1Response retVal = ((AxlNetClient.AXLPort47)(this)).getGatewayEndpointDigitalAccessT1(inValue);
            return retVal.getGatewayEndpointDigitalAccessT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessT1Response> AxlNetClient.AXLPort47.getGatewayEndpointDigitalAccessT1Async(AxlNetClient.getGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessT1Response> getGatewayEndpointDigitalAccessT1Async(AxlNetClient.GetGatewayEndpointDigitalAccessT1Req getGatewayEndpointDigitalAccessT1)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.getGatewayEndpointDigitalAccessT1Request();
            inValue.getGatewayEndpointDigitalAccessT1 = getGatewayEndpointDigitalAccessT1;
            return ((AxlNetClient.AXLPort47)(this)).getGatewayEndpointDigitalAccessT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewayEndpointDigitalAccessT1Response AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessT1(AxlNetClient.removeGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessT1(request);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointDigitalAccessT1(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessT11)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessT1Request();
            inValue.removeGatewayEndpointDigitalAccessT1 = removeGatewayEndpointDigitalAccessT11;
            AxlNetClient.removeGatewayEndpointDigitalAccessT1Response retVal = ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessT1(inValue);
            return retVal.removeGatewayEndpointDigitalAccessT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessT1Response> AxlNetClient.AXLPort47.removeGatewayEndpointDigitalAccessT1Async(AxlNetClient.removeGatewayEndpointDigitalAccessT1Request request)
        {
            return base.Channel.removeGatewayEndpointDigitalAccessT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointDigitalAccessT1Response> removeGatewayEndpointDigitalAccessT1Async(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointDigitalAccessT1)
        {
            AxlNetClient.removeGatewayEndpointDigitalAccessT1Request inValue = new AxlNetClient.removeGatewayEndpointDigitalAccessT1Request();
            inValue.removeGatewayEndpointDigitalAccessT1 = removeGatewayEndpointDigitalAccessT1;
            return ((AxlNetClient.AXLPort47)(this)).removeGatewayEndpointDigitalAccessT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort47.addCiscoCatalyst600024PortFXSGateway(AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.addCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse addCiscoCatalyst600024PortFXSGateway(AxlNetClient.AddCiscoCatalyst600024PortFXSGatewayReq addCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.addCiscoCatalyst600024PortFXSGateway = addCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort47)(this)).addCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.addCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort47.addCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.addCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCiscoCatalyst600024PortFXSGatewayResponse> addCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.AddCiscoCatalyst600024PortFXSGatewayReq addCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.addCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.addCiscoCatalyst600024PortFXSGateway = addCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort47)(this)).addCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort47.updateCiscoCatalyst600024PortFXSGateway(AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.updateCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.StandardResponse updateCiscoCatalyst600024PortFXSGateway(AxlNetClient.UpdateCiscoCatalyst600024PortFXSGatewayReq updateCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.updateCiscoCatalyst600024PortFXSGateway = updateCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort47)(this)).updateCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.updateCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort47.updateCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.updateCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayResponse> updateCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.UpdateCiscoCatalyst600024PortFXSGatewayReq updateCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.updateCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.updateCiscoCatalyst600024PortFXSGateway = updateCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort47)(this)).updateCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse AxlNetClient.AXLPort47.getCiscoCatalyst600024PortFXSGateway(AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.getCiscoCatalyst600024PortFXSGateway(request);
        }

        public AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayRes getCiscoCatalyst600024PortFXSGateway(AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayReq getCiscoCatalyst600024PortFXSGateway1)
        {
            AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.getCiscoCatalyst600024PortFXSGateway = getCiscoCatalyst600024PortFXSGateway1;
            AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse retVal = ((AxlNetClient.AXLPort47)(this)).getCiscoCatalyst600024PortFXSGateway(inValue);
            return retVal.getCiscoCatalyst600024PortFXSGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse> AxlNetClient.AXLPort47.getCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest request)
        {
            return base.Channel.getCiscoCatalyst600024PortFXSGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCiscoCatalyst600024PortFXSGatewayResponse> getCiscoCatalyst600024PortFXSGatewayAsync(AxlNetClient.GetCiscoCatalyst600024PortFXSGatewayReq getCiscoCatalyst600024PortFXSGateway)
        {
            AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest inValue = new AxlNetClient.getCiscoCatalyst600024PortFXSGatewayRequest();
            inValue.getCiscoCatalyst600024PortFXSGateway = getCiscoCatalyst600024PortFXSGateway;
            return ((AxlNetClient.AXLPort47)(this)).getCiscoCatalyst600024PortFXSGatewayAsync(inValue);
        }
    }
}