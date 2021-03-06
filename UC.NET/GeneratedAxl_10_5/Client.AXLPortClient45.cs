namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient45 _axlPortClient45;

        private static AXLPortClient45 axlPortClient45 => _axlPortClient45 == null ||
            _axlPortClient45.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient45 = LoadClient45()) : _axlPortClient45;

        private static AXLPortClient45 LoadClient45()
        {
            var client = new AXLPortClient45(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close45;
            OnAbort += Abort45;
            return client;
        }

        private static void Close45(object sender, System.EventArgs e)
        {
            _axlPortClient45.Close();
        }

        private static void Abort45(object sender, System.EventArgs e)
        {
            _axlPortClient45.Abort();
        }

        public AxlNetClient.GetDeviceProfileOptionsRes getDeviceProfileOptions(AxlNetClient.GetDeviceProfileOptionsReq getDeviceProfileOptions1)
        {
            return axlPortClient45.getDeviceProfileOptions(getDeviceProfileOptions1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileOptionsResponse> getDeviceProfileOptionsAsync(AxlNetClient.GetDeviceProfileOptionsReq getDeviceProfileOptions)
        {
            return axlPortClient45.getDeviceProfileOptionsAsync(getDeviceProfileOptions);
        }

        public AxlNetClient.StandardResponse addRemoteDestination(AxlNetClient.AddRemoteDestinationReq addRemoteDestination1)
        {
            return axlPortClient45.addRemoteDestination(addRemoteDestination1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationResponse> addRemoteDestinationAsync(AxlNetClient.AddRemoteDestinationReq addRemoteDestination)
        {
            return axlPortClient45.addRemoteDestinationAsync(addRemoteDestination);
        }

        public AxlNetClient.StandardResponse updateRemoteDestination(AxlNetClient.UpdateRemoteDestinationReq updateRemoteDestination1)
        {
            return axlPortClient45.updateRemoteDestination(updateRemoteDestination1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationResponse> updateRemoteDestinationAsync(AxlNetClient.UpdateRemoteDestinationReq updateRemoteDestination)
        {
            return axlPortClient45.updateRemoteDestinationAsync(updateRemoteDestination);
        }

        public AxlNetClient.GetRemoteDestinationRes getRemoteDestination(AxlNetClient.GetRemoteDestinationReq getRemoteDestination1)
        {
            return axlPortClient45.getRemoteDestination(getRemoteDestination1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationResponse> getRemoteDestinationAsync(AxlNetClient.GetRemoteDestinationReq getRemoteDestination)
        {
            return axlPortClient45.getRemoteDestinationAsync(getRemoteDestination);
        }

        public AxlNetClient.StandardResponse removeRemoteDestination(AxlNetClient.RemoveRemoteDestinationReq removeRemoteDestination1)
        {
            return axlPortClient45.removeRemoteDestination(removeRemoteDestination1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationResponse> removeRemoteDestinationAsync(AxlNetClient.RemoveRemoteDestinationReq removeRemoteDestination)
        {
            return axlPortClient45.removeRemoteDestinationAsync(removeRemoteDestination);
        }

        public AxlNetClient.ListRemoteDestinationRes listRemoteDestination(AxlNetClient.ListRemoteDestinationReq listRemoteDestination1)
        {
            return axlPortClient45.listRemoteDestination(listRemoteDestination1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationResponse> listRemoteDestinationAsync(AxlNetClient.ListRemoteDestinationReq listRemoteDestination)
        {
            return axlPortClient45.listRemoteDestinationAsync(listRemoteDestination);
        }

        public AxlNetClient.StandardResponse addVg224(AxlNetClient.AddVg224Req addVg2241)
        {
            return axlPortClient45.addVg224(addVg2241);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVg224Response> addVg224Async(AxlNetClient.AddVg224Req addVg224)
        {
            return axlPortClient45.addVg224Async(addVg224);
        }

        public AxlNetClient.StandardResponse updateVg224(AxlNetClient.UpdateVg224Req updateVg2241)
        {
            return axlPortClient45.updateVg224(updateVg2241);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVg224Response> updateVg224Async(AxlNetClient.UpdateVg224Req updateVg224)
        {
            return axlPortClient45.updateVg224Async(updateVg224);
        }

        public AxlNetClient.GetVg224Res getVg224(AxlNetClient.GetVg224Req getVg2241)
        {
            return axlPortClient45.getVg224(getVg2241);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVg224Response> getVg224Async(AxlNetClient.GetVg224Req getVg224)
        {
            return axlPortClient45.getVg224Async(getVg224);
        }

        public AxlNetClient.StandardResponse removeVg224(AxlNetClient.RemoveVg224Req removeVg2241)
        {
            return axlPortClient45.removeVg224(removeVg2241);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVg224Response> removeVg224Async(AxlNetClient.RemoveVg224Req removeVg224)
        {
            return axlPortClient45.removeVg224Async(removeVg224);
        }

        public AxlNetClient.StandardResponse addGateway(AxlNetClient.AddGatewayReq addGateway1)
        {
            return axlPortClient45.addGateway(addGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayResponse> addGatewayAsync(AxlNetClient.AddGatewayReq addGateway)
        {
            return axlPortClient45.addGatewayAsync(addGateway);
        }

        public AxlNetClient.StandardResponse updateGateway(AxlNetClient.UpdateGatewayReq updateGateway1)
        {
            return axlPortClient45.updateGateway(updateGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayResponse> updateGatewayAsync(AxlNetClient.UpdateGatewayReq updateGateway)
        {
            return axlPortClient45.updateGatewayAsync(updateGateway);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort45
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceProfileOptions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDeviceProfileOptionsResponse getDeviceProfileOptions(AxlNetClient.getDeviceProfileOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceProfileOptions", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileOptionsResponse> getDeviceProfileOptionsAsync(AxlNetClient.getDeviceProfileOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteDestination", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRemoteDestinationResponse addRemoteDestination(AxlNetClient.addRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteDestination", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationResponse> addRemoteDestinationAsync(AxlNetClient.addRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteDestination", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRemoteDestinationResponse updateRemoteDestination(AxlNetClient.updateRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteDestination", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationResponse> updateRemoteDestinationAsync(AxlNetClient.updateRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteDestination", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRemoteDestinationResponse getRemoteDestination(AxlNetClient.getRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteDestination", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationResponse> getRemoteDestinationAsync(AxlNetClient.getRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteDestination", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRemoteDestinationResponse removeRemoteDestination(AxlNetClient.removeRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteDestination", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationResponse> removeRemoteDestinationAsync(AxlNetClient.removeRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteDestination", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRemoteDestinationResponse listRemoteDestination(AxlNetClient.listRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteDestination", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationResponse> listRemoteDestinationAsync(AxlNetClient.listRemoteDestinationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVg224", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVg224Response addVg224(AxlNetClient.addVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVg224", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVg224Response> addVg224Async(AxlNetClient.addVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVg224", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVg224Response updateVg224(AxlNetClient.updateVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVg224", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVg224Response> updateVg224Async(AxlNetClient.updateVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVg224", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVg224Response getVg224(AxlNetClient.getVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVg224", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVg224Response> getVg224Async(AxlNetClient.getVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVg224", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVg224Response removeVg224(AxlNetClient.removeVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVg224", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVg224Response> removeVg224Async(AxlNetClient.removeVg224Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewayResponse addGateway(AxlNetClient.addGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayResponse> addGatewayAsync(AxlNetClient.addGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewayResponse updateGateway(AxlNetClient.updateGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayResponse> updateGatewayAsync(AxlNetClient.updateGatewayRequest request);
    }

    public class AXLPortClient45 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort45>, AxlNetClient.AXLPort45
    {
        public AXLPortClient45(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDeviceProfileOptionsResponse AxlNetClient.AXLPort45.getDeviceProfileOptions(AxlNetClient.getDeviceProfileOptionsRequest request)
        {
            return base.Channel.getDeviceProfileOptions(request);
        }

        public AxlNetClient.GetDeviceProfileOptionsRes getDeviceProfileOptions(AxlNetClient.GetDeviceProfileOptionsReq getDeviceProfileOptions1)
        {
            AxlNetClient.getDeviceProfileOptionsRequest inValue = new AxlNetClient.getDeviceProfileOptionsRequest();
            inValue.getDeviceProfileOptions = getDeviceProfileOptions1;
            AxlNetClient.getDeviceProfileOptionsResponse retVal = ((AxlNetClient.AXLPort45)(this)).getDeviceProfileOptions(inValue);
            return retVal.getDeviceProfileOptionsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileOptionsResponse> AxlNetClient.AXLPort45.getDeviceProfileOptionsAsync(AxlNetClient.getDeviceProfileOptionsRequest request)
        {
            return base.Channel.getDeviceProfileOptionsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileOptionsResponse> getDeviceProfileOptionsAsync(AxlNetClient.GetDeviceProfileOptionsReq getDeviceProfileOptions)
        {
            AxlNetClient.getDeviceProfileOptionsRequest inValue = new AxlNetClient.getDeviceProfileOptionsRequest();
            inValue.getDeviceProfileOptions = getDeviceProfileOptions;
            return ((AxlNetClient.AXLPort45)(this)).getDeviceProfileOptionsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRemoteDestinationResponse AxlNetClient.AXLPort45.addRemoteDestination(AxlNetClient.addRemoteDestinationRequest request)
        {
            return base.Channel.addRemoteDestination(request);
        }

        public AxlNetClient.StandardResponse addRemoteDestination(AxlNetClient.AddRemoteDestinationReq addRemoteDestination1)
        {
            AxlNetClient.addRemoteDestinationRequest inValue = new AxlNetClient.addRemoteDestinationRequest();
            inValue.addRemoteDestination = addRemoteDestination1;
            AxlNetClient.addRemoteDestinationResponse retVal = ((AxlNetClient.AXLPort45)(this)).addRemoteDestination(inValue);
            return retVal.addRemoteDestinationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationResponse> AxlNetClient.AXLPort45.addRemoteDestinationAsync(AxlNetClient.addRemoteDestinationRequest request)
        {
            return base.Channel.addRemoteDestinationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationResponse> addRemoteDestinationAsync(AxlNetClient.AddRemoteDestinationReq addRemoteDestination)
        {
            AxlNetClient.addRemoteDestinationRequest inValue = new AxlNetClient.addRemoteDestinationRequest();
            inValue.addRemoteDestination = addRemoteDestination;
            return ((AxlNetClient.AXLPort45)(this)).addRemoteDestinationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRemoteDestinationResponse AxlNetClient.AXLPort45.updateRemoteDestination(AxlNetClient.updateRemoteDestinationRequest request)
        {
            return base.Channel.updateRemoteDestination(request);
        }

        public AxlNetClient.StandardResponse updateRemoteDestination(AxlNetClient.UpdateRemoteDestinationReq updateRemoteDestination1)
        {
            AxlNetClient.updateRemoteDestinationRequest inValue = new AxlNetClient.updateRemoteDestinationRequest();
            inValue.updateRemoteDestination = updateRemoteDestination1;
            AxlNetClient.updateRemoteDestinationResponse retVal = ((AxlNetClient.AXLPort45)(this)).updateRemoteDestination(inValue);
            return retVal.updateRemoteDestinationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationResponse> AxlNetClient.AXLPort45.updateRemoteDestinationAsync(AxlNetClient.updateRemoteDestinationRequest request)
        {
            return base.Channel.updateRemoteDestinationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationResponse> updateRemoteDestinationAsync(AxlNetClient.UpdateRemoteDestinationReq updateRemoteDestination)
        {
            AxlNetClient.updateRemoteDestinationRequest inValue = new AxlNetClient.updateRemoteDestinationRequest();
            inValue.updateRemoteDestination = updateRemoteDestination;
            return ((AxlNetClient.AXLPort45)(this)).updateRemoteDestinationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRemoteDestinationResponse AxlNetClient.AXLPort45.getRemoteDestination(AxlNetClient.getRemoteDestinationRequest request)
        {
            return base.Channel.getRemoteDestination(request);
        }

        public AxlNetClient.GetRemoteDestinationRes getRemoteDestination(AxlNetClient.GetRemoteDestinationReq getRemoteDestination1)
        {
            AxlNetClient.getRemoteDestinationRequest inValue = new AxlNetClient.getRemoteDestinationRequest();
            inValue.getRemoteDestination = getRemoteDestination1;
            AxlNetClient.getRemoteDestinationResponse retVal = ((AxlNetClient.AXLPort45)(this)).getRemoteDestination(inValue);
            return retVal.getRemoteDestinationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationResponse> AxlNetClient.AXLPort45.getRemoteDestinationAsync(AxlNetClient.getRemoteDestinationRequest request)
        {
            return base.Channel.getRemoteDestinationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationResponse> getRemoteDestinationAsync(AxlNetClient.GetRemoteDestinationReq getRemoteDestination)
        {
            AxlNetClient.getRemoteDestinationRequest inValue = new AxlNetClient.getRemoteDestinationRequest();
            inValue.getRemoteDestination = getRemoteDestination;
            return ((AxlNetClient.AXLPort45)(this)).getRemoteDestinationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRemoteDestinationResponse AxlNetClient.AXLPort45.removeRemoteDestination(AxlNetClient.removeRemoteDestinationRequest request)
        {
            return base.Channel.removeRemoteDestination(request);
        }

        public AxlNetClient.StandardResponse removeRemoteDestination(AxlNetClient.RemoveRemoteDestinationReq removeRemoteDestination1)
        {
            AxlNetClient.removeRemoteDestinationRequest inValue = new AxlNetClient.removeRemoteDestinationRequest();
            inValue.removeRemoteDestination = removeRemoteDestination1;
            AxlNetClient.removeRemoteDestinationResponse retVal = ((AxlNetClient.AXLPort45)(this)).removeRemoteDestination(inValue);
            return retVal.removeRemoteDestinationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationResponse> AxlNetClient.AXLPort45.removeRemoteDestinationAsync(AxlNetClient.removeRemoteDestinationRequest request)
        {
            return base.Channel.removeRemoteDestinationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationResponse> removeRemoteDestinationAsync(AxlNetClient.RemoveRemoteDestinationReq removeRemoteDestination)
        {
            AxlNetClient.removeRemoteDestinationRequest inValue = new AxlNetClient.removeRemoteDestinationRequest();
            inValue.removeRemoteDestination = removeRemoteDestination;
            return ((AxlNetClient.AXLPort45)(this)).removeRemoteDestinationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRemoteDestinationResponse AxlNetClient.AXLPort45.listRemoteDestination(AxlNetClient.listRemoteDestinationRequest request)
        {
            return base.Channel.listRemoteDestination(request);
        }

        public AxlNetClient.ListRemoteDestinationRes listRemoteDestination(AxlNetClient.ListRemoteDestinationReq listRemoteDestination1)
        {
            AxlNetClient.listRemoteDestinationRequest inValue = new AxlNetClient.listRemoteDestinationRequest();
            inValue.listRemoteDestination = listRemoteDestination1;
            AxlNetClient.listRemoteDestinationResponse retVal = ((AxlNetClient.AXLPort45)(this)).listRemoteDestination(inValue);
            return retVal.listRemoteDestinationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationResponse> AxlNetClient.AXLPort45.listRemoteDestinationAsync(AxlNetClient.listRemoteDestinationRequest request)
        {
            return base.Channel.listRemoteDestinationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationResponse> listRemoteDestinationAsync(AxlNetClient.ListRemoteDestinationReq listRemoteDestination)
        {
            AxlNetClient.listRemoteDestinationRequest inValue = new AxlNetClient.listRemoteDestinationRequest();
            inValue.listRemoteDestination = listRemoteDestination;
            return ((AxlNetClient.AXLPort45)(this)).listRemoteDestinationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVg224Response AxlNetClient.AXLPort45.addVg224(AxlNetClient.addVg224Request request)
        {
            return base.Channel.addVg224(request);
        }

        public AxlNetClient.StandardResponse addVg224(AxlNetClient.AddVg224Req addVg2241)
        {
            AxlNetClient.addVg224Request inValue = new AxlNetClient.addVg224Request();
            inValue.addVg224 = addVg2241;
            AxlNetClient.addVg224Response retVal = ((AxlNetClient.AXLPort45)(this)).addVg224(inValue);
            return retVal.addVg224Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVg224Response> AxlNetClient.AXLPort45.addVg224Async(AxlNetClient.addVg224Request request)
        {
            return base.Channel.addVg224Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVg224Response> addVg224Async(AxlNetClient.AddVg224Req addVg224)
        {
            AxlNetClient.addVg224Request inValue = new AxlNetClient.addVg224Request();
            inValue.addVg224 = addVg224;
            return ((AxlNetClient.AXLPort45)(this)).addVg224Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVg224Response AxlNetClient.AXLPort45.updateVg224(AxlNetClient.updateVg224Request request)
        {
            return base.Channel.updateVg224(request);
        }

        public AxlNetClient.StandardResponse updateVg224(AxlNetClient.UpdateVg224Req updateVg2241)
        {
            AxlNetClient.updateVg224Request inValue = new AxlNetClient.updateVg224Request();
            inValue.updateVg224 = updateVg2241;
            AxlNetClient.updateVg224Response retVal = ((AxlNetClient.AXLPort45)(this)).updateVg224(inValue);
            return retVal.updateVg224Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVg224Response> AxlNetClient.AXLPort45.updateVg224Async(AxlNetClient.updateVg224Request request)
        {
            return base.Channel.updateVg224Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVg224Response> updateVg224Async(AxlNetClient.UpdateVg224Req updateVg224)
        {
            AxlNetClient.updateVg224Request inValue = new AxlNetClient.updateVg224Request();
            inValue.updateVg224 = updateVg224;
            return ((AxlNetClient.AXLPort45)(this)).updateVg224Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVg224Response AxlNetClient.AXLPort45.getVg224(AxlNetClient.getVg224Request request)
        {
            return base.Channel.getVg224(request);
        }

        public AxlNetClient.GetVg224Res getVg224(AxlNetClient.GetVg224Req getVg2241)
        {
            AxlNetClient.getVg224Request inValue = new AxlNetClient.getVg224Request();
            inValue.getVg224 = getVg2241;
            AxlNetClient.getVg224Response retVal = ((AxlNetClient.AXLPort45)(this)).getVg224(inValue);
            return retVal.getVg224Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVg224Response> AxlNetClient.AXLPort45.getVg224Async(AxlNetClient.getVg224Request request)
        {
            return base.Channel.getVg224Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVg224Response> getVg224Async(AxlNetClient.GetVg224Req getVg224)
        {
            AxlNetClient.getVg224Request inValue = new AxlNetClient.getVg224Request();
            inValue.getVg224 = getVg224;
            return ((AxlNetClient.AXLPort45)(this)).getVg224Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVg224Response AxlNetClient.AXLPort45.removeVg224(AxlNetClient.removeVg224Request request)
        {
            return base.Channel.removeVg224(request);
        }

        public AxlNetClient.StandardResponse removeVg224(AxlNetClient.RemoveVg224Req removeVg2241)
        {
            AxlNetClient.removeVg224Request inValue = new AxlNetClient.removeVg224Request();
            inValue.removeVg224 = removeVg2241;
            AxlNetClient.removeVg224Response retVal = ((AxlNetClient.AXLPort45)(this)).removeVg224(inValue);
            return retVal.removeVg224Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVg224Response> AxlNetClient.AXLPort45.removeVg224Async(AxlNetClient.removeVg224Request request)
        {
            return base.Channel.removeVg224Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVg224Response> removeVg224Async(AxlNetClient.RemoveVg224Req removeVg224)
        {
            AxlNetClient.removeVg224Request inValue = new AxlNetClient.removeVg224Request();
            inValue.removeVg224 = removeVg224;
            return ((AxlNetClient.AXLPort45)(this)).removeVg224Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewayResponse AxlNetClient.AXLPort45.addGateway(AxlNetClient.addGatewayRequest request)
        {
            return base.Channel.addGateway(request);
        }

        public AxlNetClient.StandardResponse addGateway(AxlNetClient.AddGatewayReq addGateway1)
        {
            AxlNetClient.addGatewayRequest inValue = new AxlNetClient.addGatewayRequest();
            inValue.addGateway = addGateway1;
            AxlNetClient.addGatewayResponse retVal = ((AxlNetClient.AXLPort45)(this)).addGateway(inValue);
            return retVal.addGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayResponse> AxlNetClient.AXLPort45.addGatewayAsync(AxlNetClient.addGatewayRequest request)
        {
            return base.Channel.addGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayResponse> addGatewayAsync(AxlNetClient.AddGatewayReq addGateway)
        {
            AxlNetClient.addGatewayRequest inValue = new AxlNetClient.addGatewayRequest();
            inValue.addGateway = addGateway;
            return ((AxlNetClient.AXLPort45)(this)).addGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewayResponse AxlNetClient.AXLPort45.updateGateway(AxlNetClient.updateGatewayRequest request)
        {
            return base.Channel.updateGateway(request);
        }

        public AxlNetClient.StandardResponse updateGateway(AxlNetClient.UpdateGatewayReq updateGateway1)
        {
            AxlNetClient.updateGatewayRequest inValue = new AxlNetClient.updateGatewayRequest();
            inValue.updateGateway = updateGateway1;
            AxlNetClient.updateGatewayResponse retVal = ((AxlNetClient.AXLPort45)(this)).updateGateway(inValue);
            return retVal.updateGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayResponse> AxlNetClient.AXLPort45.updateGatewayAsync(AxlNetClient.updateGatewayRequest request)
        {
            return base.Channel.updateGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayResponse> updateGatewayAsync(AxlNetClient.UpdateGatewayReq updateGateway)
        {
            AxlNetClient.updateGatewayRequest inValue = new AxlNetClient.updateGatewayRequest();
            inValue.updateGateway = updateGateway;
            return ((AxlNetClient.AXLPort45)(this)).updateGatewayAsync(inValue);
        }
    }
}