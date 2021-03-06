namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient46 _axlPortClient46;

        private static AXLPortClient46 axlPortClient46 => _axlPortClient46 == null ||
            _axlPortClient46.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient46 = LoadClient46()) : _axlPortClient46;

        private static AXLPortClient46 LoadClient46()
        {
            var client = new AXLPortClient46(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close46;
            OnAbort += Abort46;
            return client;
        }

        private static void Close46(object sender, System.EventArgs e)
        {
            _axlPortClient46.Close();
        }

        private static void Abort46(object sender, System.EventArgs e)
        {
            _axlPortClient46.Abort();
        }

        public AxlNetClient.GetGatewayRes getGateway(AxlNetClient.GetGatewayReq getGateway1)
        {
            return axlPortClient46.getGateway(getGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayResponse> getGatewayAsync(AxlNetClient.GetGatewayReq getGateway)
        {
            return axlPortClient46.getGatewayAsync(getGateway);
        }

        public AxlNetClient.StandardResponse removeGateway(AxlNetClient.RemoveGatewayReq removeGateway1)
        {
            return axlPortClient46.removeGateway(removeGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayResponse> removeGatewayAsync(AxlNetClient.RemoveGatewayReq removeGateway)
        {
            return axlPortClient46.removeGatewayAsync(removeGateway);
        }

        public AxlNetClient.ListGatewayRes listGateway(AxlNetClient.ListGatewayReq listGateway1)
        {
            return axlPortClient46.listGateway(listGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGatewayResponse> listGatewayAsync(AxlNetClient.ListGatewayReq listGateway)
        {
            return axlPortClient46.listGatewayAsync(listGateway);
        }

        public AxlNetClient.StandardResponse resetGateway(AxlNetClient.ResetGatewayReq resetGateway1)
        {
            return axlPortClient46.resetGateway(resetGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetGatewayResponse> resetGatewayAsync(AxlNetClient.ResetGatewayReq resetGateway)
        {
            return axlPortClient46.resetGatewayAsync(resetGateway);
        }

        public AxlNetClient.StandardResponse applyGateway(AxlNetClient.ApplyGatewayReq applyGateway1)
        {
            return axlPortClient46.applyGateway(applyGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyGatewayResponse> applyGatewayAsync(AxlNetClient.ApplyGatewayReq applyGateway)
        {
            return axlPortClient46.applyGatewayAsync(applyGateway);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointAnalogAccess(AxlNetClient.AddGatewayEndpointAnalogAccessReq addGatewayEndpointAnalogAccess1)
        {
            return axlPortClient46.addGatewayEndpointAnalogAccess(addGatewayEndpointAnalogAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointAnalogAccessResponse> addGatewayEndpointAnalogAccessAsync(AxlNetClient.AddGatewayEndpointAnalogAccessReq addGatewayEndpointAnalogAccess)
        {
            return axlPortClient46.addGatewayEndpointAnalogAccessAsync(addGatewayEndpointAnalogAccess);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointAnalogAccess(AxlNetClient.UpdateGatewayEndpointAnalogAccessReq updateGatewayEndpointAnalogAccess1)
        {
            return axlPortClient46.updateGatewayEndpointAnalogAccess(updateGatewayEndpointAnalogAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointAnalogAccessResponse> updateGatewayEndpointAnalogAccessAsync(AxlNetClient.UpdateGatewayEndpointAnalogAccessReq updateGatewayEndpointAnalogAccess)
        {
            return axlPortClient46.updateGatewayEndpointAnalogAccessAsync(updateGatewayEndpointAnalogAccess);
        }

        public AxlNetClient.GetGatewayEndpointAnalogAccessRes getGatewayEndpointAnalogAccess(AxlNetClient.GetGatewayEndpointAnalogAccessReq getGatewayEndpointAnalogAccess1)
        {
            return axlPortClient46.getGatewayEndpointAnalogAccess(getGatewayEndpointAnalogAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointAnalogAccessResponse> getGatewayEndpointAnalogAccessAsync(AxlNetClient.GetGatewayEndpointAnalogAccessReq getGatewayEndpointAnalogAccess)
        {
            return axlPortClient46.getGatewayEndpointAnalogAccessAsync(getGatewayEndpointAnalogAccess);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointAnalogAccess(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointAnalogAccess1)
        {
            return axlPortClient46.removeGatewayEndpointAnalogAccess(removeGatewayEndpointAnalogAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointAnalogAccessResponse> removeGatewayEndpointAnalogAccessAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointAnalogAccess)
        {
            return axlPortClient46.removeGatewayEndpointAnalogAccessAsync(removeGatewayEndpointAnalogAccess);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessPri(AxlNetClient.AddGatewayEndpointDigitalAccessPriReq addGatewayEndpointDigitalAccessPri1)
        {
            return axlPortClient46.addGatewayEndpointDigitalAccessPri(addGatewayEndpointDigitalAccessPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessPriResponse> addGatewayEndpointDigitalAccessPriAsync(AxlNetClient.AddGatewayEndpointDigitalAccessPriReq addGatewayEndpointDigitalAccessPri)
        {
            return axlPortClient46.addGatewayEndpointDigitalAccessPriAsync(addGatewayEndpointDigitalAccessPri);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessPri(AxlNetClient.UpdateGatewayEndpointDigitalAccessPriReq updateGatewayEndpointDigitalAccessPri1)
        {
            return axlPortClient46.updateGatewayEndpointDigitalAccessPri(updateGatewayEndpointDigitalAccessPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse> updateGatewayEndpointDigitalAccessPriAsync(AxlNetClient.UpdateGatewayEndpointDigitalAccessPriReq updateGatewayEndpointDigitalAccessPri)
        {
            return axlPortClient46.updateGatewayEndpointDigitalAccessPriAsync(updateGatewayEndpointDigitalAccessPri);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessPriRes getGatewayEndpointDigitalAccessPri(AxlNetClient.GetGatewayEndpointDigitalAccessPriReq getGatewayEndpointDigitalAccessPri1)
        {
            return axlPortClient46.getGatewayEndpointDigitalAccessPri(getGatewayEndpointDigitalAccessPri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessPriResponse> getGatewayEndpointDigitalAccessPriAsync(AxlNetClient.GetGatewayEndpointDigitalAccessPriReq getGatewayEndpointDigitalAccessPri)
        {
            return axlPortClient46.getGatewayEndpointDigitalAccessPriAsync(getGatewayEndpointDigitalAccessPri);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort46
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewayResponse getGateway(AxlNetClient.getGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayResponse> getGatewayAsync(AxlNetClient.getGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewayResponse removeGateway(AxlNetClient.removeGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayResponse> removeGatewayAsync(AxlNetClient.removeGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listGatewayResponse listGateway(AxlNetClient.listGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listGatewayResponse> listGatewayAsync(AxlNetClient.listGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetGatewayResponse resetGateway(AxlNetClient.resetGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetGatewayResponse> resetGatewayAsync(AxlNetClient.resetGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyGatewayResponse applyGateway(AxlNetClient.applyGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyGatewayResponse> applyGatewayAsync(AxlNetClient.applyGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointAnalogAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewayEndpointAnalogAccessResponse addGatewayEndpointAnalogAccess(AxlNetClient.addGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointAnalogAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointAnalogAccessResponse> addGatewayEndpointAnalogAccessAsync(AxlNetClient.addGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointAnalogAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewayEndpointAnalogAccessResponse updateGatewayEndpointAnalogAccess(AxlNetClient.updateGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointAnalogAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointAnalogAccessResponse> updateGatewayEndpointAnalogAccessAsync(AxlNetClient.updateGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointAnalogAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewayEndpointAnalogAccessResponse getGatewayEndpointAnalogAccess(AxlNetClient.getGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointAnalogAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointAnalogAccessResponse> getGatewayEndpointAnalogAccessAsync(AxlNetClient.getGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointAnalogAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewayEndpointAnalogAccessResponse removeGatewayEndpointAnalogAccess(AxlNetClient.removeGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewayEndpointAnalogAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointAnalogAccessResponse> removeGatewayEndpointAnalogAccessAsync(AxlNetClient.removeGatewayEndpointAnalogAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewayEndpointDigitalAccessPriResponse addGatewayEndpointDigitalAccessPri(AxlNetClient.addGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessPriResponse> addGatewayEndpointDigitalAccessPriAsync(AxlNetClient.addGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse updateGatewayEndpointDigitalAccessPri(AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse> updateGatewayEndpointDigitalAccessPriAsync(AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewayEndpointDigitalAccessPriResponse getGatewayEndpointDigitalAccessPri(AxlNetClient.getGatewayEndpointDigitalAccessPriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewayEndpointDigitalAccessPri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessPriResponse> getGatewayEndpointDigitalAccessPriAsync(AxlNetClient.getGatewayEndpointDigitalAccessPriRequest request);
    }

    public class AXLPortClient46 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort46>, AxlNetClient.AXLPort46
    {
        public AXLPortClient46(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewayResponse AxlNetClient.AXLPort46.getGateway(AxlNetClient.getGatewayRequest request)
        {
            return base.Channel.getGateway(request);
        }

        public AxlNetClient.GetGatewayRes getGateway(AxlNetClient.GetGatewayReq getGateway1)
        {
            AxlNetClient.getGatewayRequest inValue = new AxlNetClient.getGatewayRequest();
            inValue.getGateway = getGateway1;
            AxlNetClient.getGatewayResponse retVal = ((AxlNetClient.AXLPort46)(this)).getGateway(inValue);
            return retVal.getGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayResponse> AxlNetClient.AXLPort46.getGatewayAsync(AxlNetClient.getGatewayRequest request)
        {
            return base.Channel.getGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayResponse> getGatewayAsync(AxlNetClient.GetGatewayReq getGateway)
        {
            AxlNetClient.getGatewayRequest inValue = new AxlNetClient.getGatewayRequest();
            inValue.getGateway = getGateway;
            return ((AxlNetClient.AXLPort46)(this)).getGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewayResponse AxlNetClient.AXLPort46.removeGateway(AxlNetClient.removeGatewayRequest request)
        {
            return base.Channel.removeGateway(request);
        }

        public AxlNetClient.StandardResponse removeGateway(AxlNetClient.RemoveGatewayReq removeGateway1)
        {
            AxlNetClient.removeGatewayRequest inValue = new AxlNetClient.removeGatewayRequest();
            inValue.removeGateway = removeGateway1;
            AxlNetClient.removeGatewayResponse retVal = ((AxlNetClient.AXLPort46)(this)).removeGateway(inValue);
            return retVal.removeGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayResponse> AxlNetClient.AXLPort46.removeGatewayAsync(AxlNetClient.removeGatewayRequest request)
        {
            return base.Channel.removeGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayResponse> removeGatewayAsync(AxlNetClient.RemoveGatewayReq removeGateway)
        {
            AxlNetClient.removeGatewayRequest inValue = new AxlNetClient.removeGatewayRequest();
            inValue.removeGateway = removeGateway;
            return ((AxlNetClient.AXLPort46)(this)).removeGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listGatewayResponse AxlNetClient.AXLPort46.listGateway(AxlNetClient.listGatewayRequest request)
        {
            return base.Channel.listGateway(request);
        }

        public AxlNetClient.ListGatewayRes listGateway(AxlNetClient.ListGatewayReq listGateway1)
        {
            AxlNetClient.listGatewayRequest inValue = new AxlNetClient.listGatewayRequest();
            inValue.listGateway = listGateway1;
            AxlNetClient.listGatewayResponse retVal = ((AxlNetClient.AXLPort46)(this)).listGateway(inValue);
            return retVal.listGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listGatewayResponse> AxlNetClient.AXLPort46.listGatewayAsync(AxlNetClient.listGatewayRequest request)
        {
            return base.Channel.listGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGatewayResponse> listGatewayAsync(AxlNetClient.ListGatewayReq listGateway)
        {
            AxlNetClient.listGatewayRequest inValue = new AxlNetClient.listGatewayRequest();
            inValue.listGateway = listGateway;
            return ((AxlNetClient.AXLPort46)(this)).listGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetGatewayResponse AxlNetClient.AXLPort46.resetGateway(AxlNetClient.resetGatewayRequest request)
        {
            return base.Channel.resetGateway(request);
        }

        public AxlNetClient.StandardResponse resetGateway(AxlNetClient.ResetGatewayReq resetGateway1)
        {
            AxlNetClient.resetGatewayRequest inValue = new AxlNetClient.resetGatewayRequest();
            inValue.resetGateway = resetGateway1;
            AxlNetClient.resetGatewayResponse retVal = ((AxlNetClient.AXLPort46)(this)).resetGateway(inValue);
            return retVal.resetGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetGatewayResponse> AxlNetClient.AXLPort46.resetGatewayAsync(AxlNetClient.resetGatewayRequest request)
        {
            return base.Channel.resetGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetGatewayResponse> resetGatewayAsync(AxlNetClient.ResetGatewayReq resetGateway)
        {
            AxlNetClient.resetGatewayRequest inValue = new AxlNetClient.resetGatewayRequest();
            inValue.resetGateway = resetGateway;
            return ((AxlNetClient.AXLPort46)(this)).resetGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyGatewayResponse AxlNetClient.AXLPort46.applyGateway(AxlNetClient.applyGatewayRequest request)
        {
            return base.Channel.applyGateway(request);
        }

        public AxlNetClient.StandardResponse applyGateway(AxlNetClient.ApplyGatewayReq applyGateway1)
        {
            AxlNetClient.applyGatewayRequest inValue = new AxlNetClient.applyGatewayRequest();
            inValue.applyGateway = applyGateway1;
            AxlNetClient.applyGatewayResponse retVal = ((AxlNetClient.AXLPort46)(this)).applyGateway(inValue);
            return retVal.applyGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyGatewayResponse> AxlNetClient.AXLPort46.applyGatewayAsync(AxlNetClient.applyGatewayRequest request)
        {
            return base.Channel.applyGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyGatewayResponse> applyGatewayAsync(AxlNetClient.ApplyGatewayReq applyGateway)
        {
            AxlNetClient.applyGatewayRequest inValue = new AxlNetClient.applyGatewayRequest();
            inValue.applyGateway = applyGateway;
            return ((AxlNetClient.AXLPort46)(this)).applyGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewayEndpointAnalogAccessResponse AxlNetClient.AXLPort46.addGatewayEndpointAnalogAccess(AxlNetClient.addGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.addGatewayEndpointAnalogAccess(request);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointAnalogAccess(AxlNetClient.AddGatewayEndpointAnalogAccessReq addGatewayEndpointAnalogAccess1)
        {
            AxlNetClient.addGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.addGatewayEndpointAnalogAccessRequest();
            inValue.addGatewayEndpointAnalogAccess = addGatewayEndpointAnalogAccess1;
            AxlNetClient.addGatewayEndpointAnalogAccessResponse retVal = ((AxlNetClient.AXLPort46)(this)).addGatewayEndpointAnalogAccess(inValue);
            return retVal.addGatewayEndpointAnalogAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointAnalogAccessResponse> AxlNetClient.AXLPort46.addGatewayEndpointAnalogAccessAsync(AxlNetClient.addGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.addGatewayEndpointAnalogAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointAnalogAccessResponse> addGatewayEndpointAnalogAccessAsync(AxlNetClient.AddGatewayEndpointAnalogAccessReq addGatewayEndpointAnalogAccess)
        {
            AxlNetClient.addGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.addGatewayEndpointAnalogAccessRequest();
            inValue.addGatewayEndpointAnalogAccess = addGatewayEndpointAnalogAccess;
            return ((AxlNetClient.AXLPort46)(this)).addGatewayEndpointAnalogAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewayEndpointAnalogAccessResponse AxlNetClient.AXLPort46.updateGatewayEndpointAnalogAccess(AxlNetClient.updateGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.updateGatewayEndpointAnalogAccess(request);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointAnalogAccess(AxlNetClient.UpdateGatewayEndpointAnalogAccessReq updateGatewayEndpointAnalogAccess1)
        {
            AxlNetClient.updateGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.updateGatewayEndpointAnalogAccessRequest();
            inValue.updateGatewayEndpointAnalogAccess = updateGatewayEndpointAnalogAccess1;
            AxlNetClient.updateGatewayEndpointAnalogAccessResponse retVal = ((AxlNetClient.AXLPort46)(this)).updateGatewayEndpointAnalogAccess(inValue);
            return retVal.updateGatewayEndpointAnalogAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointAnalogAccessResponse> AxlNetClient.AXLPort46.updateGatewayEndpointAnalogAccessAsync(AxlNetClient.updateGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.updateGatewayEndpointAnalogAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointAnalogAccessResponse> updateGatewayEndpointAnalogAccessAsync(AxlNetClient.UpdateGatewayEndpointAnalogAccessReq updateGatewayEndpointAnalogAccess)
        {
            AxlNetClient.updateGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.updateGatewayEndpointAnalogAccessRequest();
            inValue.updateGatewayEndpointAnalogAccess = updateGatewayEndpointAnalogAccess;
            return ((AxlNetClient.AXLPort46)(this)).updateGatewayEndpointAnalogAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewayEndpointAnalogAccessResponse AxlNetClient.AXLPort46.getGatewayEndpointAnalogAccess(AxlNetClient.getGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.getGatewayEndpointAnalogAccess(request);
        }

        public AxlNetClient.GetGatewayEndpointAnalogAccessRes getGatewayEndpointAnalogAccess(AxlNetClient.GetGatewayEndpointAnalogAccessReq getGatewayEndpointAnalogAccess1)
        {
            AxlNetClient.getGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.getGatewayEndpointAnalogAccessRequest();
            inValue.getGatewayEndpointAnalogAccess = getGatewayEndpointAnalogAccess1;
            AxlNetClient.getGatewayEndpointAnalogAccessResponse retVal = ((AxlNetClient.AXLPort46)(this)).getGatewayEndpointAnalogAccess(inValue);
            return retVal.getGatewayEndpointAnalogAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointAnalogAccessResponse> AxlNetClient.AXLPort46.getGatewayEndpointAnalogAccessAsync(AxlNetClient.getGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.getGatewayEndpointAnalogAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointAnalogAccessResponse> getGatewayEndpointAnalogAccessAsync(AxlNetClient.GetGatewayEndpointAnalogAccessReq getGatewayEndpointAnalogAccess)
        {
            AxlNetClient.getGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.getGatewayEndpointAnalogAccessRequest();
            inValue.getGatewayEndpointAnalogAccess = getGatewayEndpointAnalogAccess;
            return ((AxlNetClient.AXLPort46)(this)).getGatewayEndpointAnalogAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewayEndpointAnalogAccessResponse AxlNetClient.AXLPort46.removeGatewayEndpointAnalogAccess(AxlNetClient.removeGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.removeGatewayEndpointAnalogAccess(request);
        }

        public AxlNetClient.StandardResponse removeGatewayEndpointAnalogAccess(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointAnalogAccess1)
        {
            AxlNetClient.removeGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.removeGatewayEndpointAnalogAccessRequest();
            inValue.removeGatewayEndpointAnalogAccess = removeGatewayEndpointAnalogAccess1;
            AxlNetClient.removeGatewayEndpointAnalogAccessResponse retVal = ((AxlNetClient.AXLPort46)(this)).removeGatewayEndpointAnalogAccess(inValue);
            return retVal.removeGatewayEndpointAnalogAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointAnalogAccessResponse> AxlNetClient.AXLPort46.removeGatewayEndpointAnalogAccessAsync(AxlNetClient.removeGatewayEndpointAnalogAccessRequest request)
        {
            return base.Channel.removeGatewayEndpointAnalogAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewayEndpointAnalogAccessResponse> removeGatewayEndpointAnalogAccessAsync(AxlNetClient.NameAndGUIDRequest removeGatewayEndpointAnalogAccess)
        {
            AxlNetClient.removeGatewayEndpointAnalogAccessRequest inValue = new AxlNetClient.removeGatewayEndpointAnalogAccessRequest();
            inValue.removeGatewayEndpointAnalogAccess = removeGatewayEndpointAnalogAccess;
            return ((AxlNetClient.AXLPort46)(this)).removeGatewayEndpointAnalogAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewayEndpointDigitalAccessPriResponse AxlNetClient.AXLPort46.addGatewayEndpointDigitalAccessPri(AxlNetClient.addGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessPri(request);
        }

        public AxlNetClient.StandardResponse addGatewayEndpointDigitalAccessPri(AxlNetClient.AddGatewayEndpointDigitalAccessPriReq addGatewayEndpointDigitalAccessPri1)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.addGatewayEndpointDigitalAccessPriRequest();
            inValue.addGatewayEndpointDigitalAccessPri = addGatewayEndpointDigitalAccessPri1;
            AxlNetClient.addGatewayEndpointDigitalAccessPriResponse retVal = ((AxlNetClient.AXLPort46)(this)).addGatewayEndpointDigitalAccessPri(inValue);
            return retVal.addGatewayEndpointDigitalAccessPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessPriResponse> AxlNetClient.AXLPort46.addGatewayEndpointDigitalAccessPriAsync(AxlNetClient.addGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.addGatewayEndpointDigitalAccessPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewayEndpointDigitalAccessPriResponse> addGatewayEndpointDigitalAccessPriAsync(AxlNetClient.AddGatewayEndpointDigitalAccessPriReq addGatewayEndpointDigitalAccessPri)
        {
            AxlNetClient.addGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.addGatewayEndpointDigitalAccessPriRequest();
            inValue.addGatewayEndpointDigitalAccessPri = addGatewayEndpointDigitalAccessPri;
            return ((AxlNetClient.AXLPort46)(this)).addGatewayEndpointDigitalAccessPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse AxlNetClient.AXLPort46.updateGatewayEndpointDigitalAccessPri(AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessPri(request);
        }

        public AxlNetClient.StandardResponse updateGatewayEndpointDigitalAccessPri(AxlNetClient.UpdateGatewayEndpointDigitalAccessPriReq updateGatewayEndpointDigitalAccessPri1)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest();
            inValue.updateGatewayEndpointDigitalAccessPri = updateGatewayEndpointDigitalAccessPri1;
            AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse retVal = ((AxlNetClient.AXLPort46)(this)).updateGatewayEndpointDigitalAccessPri(inValue);
            return retVal.updateGatewayEndpointDigitalAccessPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse> AxlNetClient.AXLPort46.updateGatewayEndpointDigitalAccessPriAsync(AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.updateGatewayEndpointDigitalAccessPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewayEndpointDigitalAccessPriResponse> updateGatewayEndpointDigitalAccessPriAsync(AxlNetClient.UpdateGatewayEndpointDigitalAccessPriReq updateGatewayEndpointDigitalAccessPri)
        {
            AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.updateGatewayEndpointDigitalAccessPriRequest();
            inValue.updateGatewayEndpointDigitalAccessPri = updateGatewayEndpointDigitalAccessPri;
            return ((AxlNetClient.AXLPort46)(this)).updateGatewayEndpointDigitalAccessPriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewayEndpointDigitalAccessPriResponse AxlNetClient.AXLPort46.getGatewayEndpointDigitalAccessPri(AxlNetClient.getGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessPri(request);
        }

        public AxlNetClient.GetGatewayEndpointDigitalAccessPriRes getGatewayEndpointDigitalAccessPri(AxlNetClient.GetGatewayEndpointDigitalAccessPriReq getGatewayEndpointDigitalAccessPri1)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.getGatewayEndpointDigitalAccessPriRequest();
            inValue.getGatewayEndpointDigitalAccessPri = getGatewayEndpointDigitalAccessPri1;
            AxlNetClient.getGatewayEndpointDigitalAccessPriResponse retVal = ((AxlNetClient.AXLPort46)(this)).getGatewayEndpointDigitalAccessPri(inValue);
            return retVal.getGatewayEndpointDigitalAccessPriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessPriResponse> AxlNetClient.AXLPort46.getGatewayEndpointDigitalAccessPriAsync(AxlNetClient.getGatewayEndpointDigitalAccessPriRequest request)
        {
            return base.Channel.getGatewayEndpointDigitalAccessPriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewayEndpointDigitalAccessPriResponse> getGatewayEndpointDigitalAccessPriAsync(AxlNetClient.GetGatewayEndpointDigitalAccessPriReq getGatewayEndpointDigitalAccessPri)
        {
            AxlNetClient.getGatewayEndpointDigitalAccessPriRequest inValue = new AxlNetClient.getGatewayEndpointDigitalAccessPriRequest();
            inValue.getGatewayEndpointDigitalAccessPri = getGatewayEndpointDigitalAccessPri;
            return ((AxlNetClient.AXLPort46)(this)).getGatewayEndpointDigitalAccessPriAsync(inValue);
        }
    }
}