namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient19 _axlPortClient19;

        private static AXLPortClient19 axlPortClient19 => _axlPortClient19 == null ||
            _axlPortClient19.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient19 = LoadClient19()) : _axlPortClient19;

        private static AXLPortClient19 LoadClient19()
        {
            var client = new AXLPortClient19(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close19;
            OnAbort += Abort19;
            return client;
        }

        private static void Close19(object sender, System.EventArgs e)
        {
            _axlPortClient19.Close();
        }

        private static void Abort19(object sender, System.EventArgs e)
        {
            _axlPortClient19.Abort();
        }

        public AxlNetClient.ListMobileSmartClientProfileRes listMobileSmartClientProfile(AxlNetClient.ListMobileSmartClientProfileReq listMobileSmartClientProfile1)
        {
            return axlPortClient19.listMobileSmartClientProfile(listMobileSmartClientProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMobileSmartClientProfileResponse> listMobileSmartClientProfileAsync(AxlNetClient.ListMobileSmartClientProfileReq listMobileSmartClientProfile)
        {
            return axlPortClient19.listMobileSmartClientProfileAsync(listMobileSmartClientProfile);
        }

        public AxlNetClient.StandardResponse updateProcessNodeService(AxlNetClient.UpdateProcessNodeServiceReq updateProcessNodeService1)
        {
            return axlPortClient19.updateProcessNodeService(updateProcessNodeService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeServiceResponse> updateProcessNodeServiceAsync(AxlNetClient.UpdateProcessNodeServiceReq updateProcessNodeService)
        {
            return axlPortClient19.updateProcessNodeServiceAsync(updateProcessNodeService);
        }

        public AxlNetClient.GetProcessNodeServiceRes getProcessNodeService(AxlNetClient.GetProcessNodeServiceReq getProcessNodeService1)
        {
            return axlPortClient19.getProcessNodeService(getProcessNodeService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getProcessNodeServiceResponse> getProcessNodeServiceAsync(AxlNetClient.GetProcessNodeServiceReq getProcessNodeService)
        {
            return axlPortClient19.getProcessNodeServiceAsync(getProcessNodeService);
        }

        public AxlNetClient.ListProcessNodeServiceRes listProcessNodeService(AxlNetClient.ListProcessNodeServiceReq listProcessNodeService1)
        {
            return axlPortClient19.listProcessNodeService(listProcessNodeService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listProcessNodeServiceResponse> listProcessNodeServiceAsync(AxlNetClient.ListProcessNodeServiceReq listProcessNodeService)
        {
            return axlPortClient19.listProcessNodeServiceAsync(listProcessNodeService);
        }

        public AxlNetClient.StandardResponse updateMohAudioSource(AxlNetClient.UpdateMohAudioSourceReq updateMohAudioSource1)
        {
            return axlPortClient19.updateMohAudioSource(updateMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMohAudioSourceResponse> updateMohAudioSourceAsync(AxlNetClient.UpdateMohAudioSourceReq updateMohAudioSource)
        {
            return axlPortClient19.updateMohAudioSourceAsync(updateMohAudioSource);
        }

        public AxlNetClient.GetMohAudioSourceRes getMohAudioSource(AxlNetClient.GetMohAudioSourceReq getMohAudioSource1)
        {
            return axlPortClient19.getMohAudioSource(getMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMohAudioSourceResponse> getMohAudioSourceAsync(AxlNetClient.GetMohAudioSourceReq getMohAudioSource)
        {
            return axlPortClient19.getMohAudioSourceAsync(getMohAudioSource);
        }

        public AxlNetClient.StandardResponse removeMohAudioSource(AxlNetClient.RemoveMohAudioSourceReq removeMohAudioSource1)
        {
            return axlPortClient19.removeMohAudioSource(removeMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMohAudioSourceResponse> removeMohAudioSourceAsync(AxlNetClient.RemoveMohAudioSourceReq removeMohAudioSource)
        {
            return axlPortClient19.removeMohAudioSourceAsync(removeMohAudioSource);
        }

        public AxlNetClient.ListMohAudioSourceRes listMohAudioSource(AxlNetClient.ListMohAudioSourceReq listMohAudioSource1)
        {
            return axlPortClient19.listMohAudioSource(listMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMohAudioSourceResponse> listMohAudioSourceAsync(AxlNetClient.ListMohAudioSourceReq listMohAudioSource)
        {
            return axlPortClient19.listMohAudioSourceAsync(listMohAudioSource);
        }

        public AxlNetClient.StandardResponse addDhcpServer(AxlNetClient.AddDhcpServerReq addDhcpServer1)
        {
            return axlPortClient19.addDhcpServer(addDhcpServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDhcpServerResponse> addDhcpServerAsync(AxlNetClient.AddDhcpServerReq addDhcpServer)
        {
            return axlPortClient19.addDhcpServerAsync(addDhcpServer);
        }

        public AxlNetClient.StandardResponse updateDhcpServer(AxlNetClient.UpdateDhcpServerReq updateDhcpServer1)
        {
            return axlPortClient19.updateDhcpServer(updateDhcpServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDhcpServerResponse> updateDhcpServerAsync(AxlNetClient.UpdateDhcpServerReq updateDhcpServer)
        {
            return axlPortClient19.updateDhcpServerAsync(updateDhcpServer);
        }

        public AxlNetClient.GetDhcpServerRes getDhcpServer(AxlNetClient.GetDhcpServerReq getDhcpServer1)
        {
            return axlPortClient19.getDhcpServer(getDhcpServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDhcpServerResponse> getDhcpServerAsync(AxlNetClient.GetDhcpServerReq getDhcpServer)
        {
            return axlPortClient19.getDhcpServerAsync(getDhcpServer);
        }

        public AxlNetClient.StandardResponse removeDhcpServer(AxlNetClient.RemoveDhcpServerReq removeDhcpServer1)
        {
            return axlPortClient19.removeDhcpServer(removeDhcpServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDhcpServerResponse> removeDhcpServerAsync(AxlNetClient.RemoveDhcpServerReq removeDhcpServer)
        {
            return axlPortClient19.removeDhcpServerAsync(removeDhcpServer);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort19
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMobileSmartClientProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMobileSmartClientProfileResponse listMobileSmartClientProfile(AxlNetClient.listMobileSmartClientProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMobileSmartClientProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMobileSmartClientProfileResponse> listMobileSmartClientProfileAsync(AxlNetClient.listMobileSmartClientProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateProcessNodeService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateProcessNodeServiceResponse updateProcessNodeService(AxlNetClient.updateProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateProcessNodeService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeServiceResponse> updateProcessNodeServiceAsync(AxlNetClient.updateProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getProcessNodeService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getProcessNodeServiceResponse getProcessNodeService(AxlNetClient.getProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getProcessNodeService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getProcessNodeServiceResponse> getProcessNodeServiceAsync(AxlNetClient.getProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listProcessNodeService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listProcessNodeServiceResponse listProcessNodeService(AxlNetClient.listProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listProcessNodeService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listProcessNodeServiceResponse> listProcessNodeServiceAsync(AxlNetClient.listProcessNodeServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMohAudioSourceResponse updateMohAudioSource(AxlNetClient.updateMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMohAudioSourceResponse> updateMohAudioSourceAsync(AxlNetClient.updateMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMohAudioSourceResponse getMohAudioSource(AxlNetClient.getMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMohAudioSourceResponse> getMohAudioSourceAsync(AxlNetClient.getMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMohAudioSourceResponse removeMohAudioSource(AxlNetClient.removeMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMohAudioSourceResponse> removeMohAudioSourceAsync(AxlNetClient.removeMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMohAudioSourceResponse listMohAudioSource(AxlNetClient.listMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMohAudioSourceResponse> listMohAudioSourceAsync(AxlNetClient.listMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDhcpServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDhcpServerResponse addDhcpServer(AxlNetClient.addDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDhcpServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDhcpServerResponse> addDhcpServerAsync(AxlNetClient.addDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDhcpServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDhcpServerResponse updateDhcpServer(AxlNetClient.updateDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDhcpServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDhcpServerResponse> updateDhcpServerAsync(AxlNetClient.updateDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDhcpServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDhcpServerResponse getDhcpServer(AxlNetClient.getDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDhcpServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDhcpServerResponse> getDhcpServerAsync(AxlNetClient.getDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDhcpServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDhcpServerResponse removeDhcpServer(AxlNetClient.removeDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDhcpServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDhcpServerResponse> removeDhcpServerAsync(AxlNetClient.removeDhcpServerRequest request);
    }

    public class AXLPortClient19 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort19>, AxlNetClient.AXLPort19
    {
        public AXLPortClient19(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMobileSmartClientProfileResponse AxlNetClient.AXLPort19.listMobileSmartClientProfile(AxlNetClient.listMobileSmartClientProfileRequest request)
        {
            return base.Channel.listMobileSmartClientProfile(request);
        }

        public AxlNetClient.ListMobileSmartClientProfileRes listMobileSmartClientProfile(AxlNetClient.ListMobileSmartClientProfileReq listMobileSmartClientProfile1)
        {
            AxlNetClient.listMobileSmartClientProfileRequest inValue = new AxlNetClient.listMobileSmartClientProfileRequest();
            inValue.listMobileSmartClientProfile = listMobileSmartClientProfile1;
            AxlNetClient.listMobileSmartClientProfileResponse retVal = ((AxlNetClient.AXLPort19)(this)).listMobileSmartClientProfile(inValue);
            return retVal.listMobileSmartClientProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMobileSmartClientProfileResponse> AxlNetClient.AXLPort19.listMobileSmartClientProfileAsync(AxlNetClient.listMobileSmartClientProfileRequest request)
        {
            return base.Channel.listMobileSmartClientProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMobileSmartClientProfileResponse> listMobileSmartClientProfileAsync(AxlNetClient.ListMobileSmartClientProfileReq listMobileSmartClientProfile)
        {
            AxlNetClient.listMobileSmartClientProfileRequest inValue = new AxlNetClient.listMobileSmartClientProfileRequest();
            inValue.listMobileSmartClientProfile = listMobileSmartClientProfile;
            return ((AxlNetClient.AXLPort19)(this)).listMobileSmartClientProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateProcessNodeServiceResponse AxlNetClient.AXLPort19.updateProcessNodeService(AxlNetClient.updateProcessNodeServiceRequest request)
        {
            return base.Channel.updateProcessNodeService(request);
        }

        public AxlNetClient.StandardResponse updateProcessNodeService(AxlNetClient.UpdateProcessNodeServiceReq updateProcessNodeService1)
        {
            AxlNetClient.updateProcessNodeServiceRequest inValue = new AxlNetClient.updateProcessNodeServiceRequest();
            inValue.updateProcessNodeService = updateProcessNodeService1;
            AxlNetClient.updateProcessNodeServiceResponse retVal = ((AxlNetClient.AXLPort19)(this)).updateProcessNodeService(inValue);
            return retVal.updateProcessNodeServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeServiceResponse> AxlNetClient.AXLPort19.updateProcessNodeServiceAsync(AxlNetClient.updateProcessNodeServiceRequest request)
        {
            return base.Channel.updateProcessNodeServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeServiceResponse> updateProcessNodeServiceAsync(AxlNetClient.UpdateProcessNodeServiceReq updateProcessNodeService)
        {
            AxlNetClient.updateProcessNodeServiceRequest inValue = new AxlNetClient.updateProcessNodeServiceRequest();
            inValue.updateProcessNodeService = updateProcessNodeService;
            return ((AxlNetClient.AXLPort19)(this)).updateProcessNodeServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getProcessNodeServiceResponse AxlNetClient.AXLPort19.getProcessNodeService(AxlNetClient.getProcessNodeServiceRequest request)
        {
            return base.Channel.getProcessNodeService(request);
        }

        public AxlNetClient.GetProcessNodeServiceRes getProcessNodeService(AxlNetClient.GetProcessNodeServiceReq getProcessNodeService1)
        {
            AxlNetClient.getProcessNodeServiceRequest inValue = new AxlNetClient.getProcessNodeServiceRequest();
            inValue.getProcessNodeService = getProcessNodeService1;
            AxlNetClient.getProcessNodeServiceResponse retVal = ((AxlNetClient.AXLPort19)(this)).getProcessNodeService(inValue);
            return retVal.getProcessNodeServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getProcessNodeServiceResponse> AxlNetClient.AXLPort19.getProcessNodeServiceAsync(AxlNetClient.getProcessNodeServiceRequest request)
        {
            return base.Channel.getProcessNodeServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getProcessNodeServiceResponse> getProcessNodeServiceAsync(AxlNetClient.GetProcessNodeServiceReq getProcessNodeService)
        {
            AxlNetClient.getProcessNodeServiceRequest inValue = new AxlNetClient.getProcessNodeServiceRequest();
            inValue.getProcessNodeService = getProcessNodeService;
            return ((AxlNetClient.AXLPort19)(this)).getProcessNodeServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listProcessNodeServiceResponse AxlNetClient.AXLPort19.listProcessNodeService(AxlNetClient.listProcessNodeServiceRequest request)
        {
            return base.Channel.listProcessNodeService(request);
        }

        public AxlNetClient.ListProcessNodeServiceRes listProcessNodeService(AxlNetClient.ListProcessNodeServiceReq listProcessNodeService1)
        {
            AxlNetClient.listProcessNodeServiceRequest inValue = new AxlNetClient.listProcessNodeServiceRequest();
            inValue.listProcessNodeService = listProcessNodeService1;
            AxlNetClient.listProcessNodeServiceResponse retVal = ((AxlNetClient.AXLPort19)(this)).listProcessNodeService(inValue);
            return retVal.listProcessNodeServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listProcessNodeServiceResponse> AxlNetClient.AXLPort19.listProcessNodeServiceAsync(AxlNetClient.listProcessNodeServiceRequest request)
        {
            return base.Channel.listProcessNodeServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listProcessNodeServiceResponse> listProcessNodeServiceAsync(AxlNetClient.ListProcessNodeServiceReq listProcessNodeService)
        {
            AxlNetClient.listProcessNodeServiceRequest inValue = new AxlNetClient.listProcessNodeServiceRequest();
            inValue.listProcessNodeService = listProcessNodeService;
            return ((AxlNetClient.AXLPort19)(this)).listProcessNodeServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMohAudioSourceResponse AxlNetClient.AXLPort19.updateMohAudioSource(AxlNetClient.updateMohAudioSourceRequest request)
        {
            return base.Channel.updateMohAudioSource(request);
        }

        public AxlNetClient.StandardResponse updateMohAudioSource(AxlNetClient.UpdateMohAudioSourceReq updateMohAudioSource1)
        {
            AxlNetClient.updateMohAudioSourceRequest inValue = new AxlNetClient.updateMohAudioSourceRequest();
            inValue.updateMohAudioSource = updateMohAudioSource1;
            AxlNetClient.updateMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort19)(this)).updateMohAudioSource(inValue);
            return retVal.updateMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMohAudioSourceResponse> AxlNetClient.AXLPort19.updateMohAudioSourceAsync(AxlNetClient.updateMohAudioSourceRequest request)
        {
            return base.Channel.updateMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMohAudioSourceResponse> updateMohAudioSourceAsync(AxlNetClient.UpdateMohAudioSourceReq updateMohAudioSource)
        {
            AxlNetClient.updateMohAudioSourceRequest inValue = new AxlNetClient.updateMohAudioSourceRequest();
            inValue.updateMohAudioSource = updateMohAudioSource;
            return ((AxlNetClient.AXLPort19)(this)).updateMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMohAudioSourceResponse AxlNetClient.AXLPort19.getMohAudioSource(AxlNetClient.getMohAudioSourceRequest request)
        {
            return base.Channel.getMohAudioSource(request);
        }

        public AxlNetClient.GetMohAudioSourceRes getMohAudioSource(AxlNetClient.GetMohAudioSourceReq getMohAudioSource1)
        {
            AxlNetClient.getMohAudioSourceRequest inValue = new AxlNetClient.getMohAudioSourceRequest();
            inValue.getMohAudioSource = getMohAudioSource1;
            AxlNetClient.getMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort19)(this)).getMohAudioSource(inValue);
            return retVal.getMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMohAudioSourceResponse> AxlNetClient.AXLPort19.getMohAudioSourceAsync(AxlNetClient.getMohAudioSourceRequest request)
        {
            return base.Channel.getMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMohAudioSourceResponse> getMohAudioSourceAsync(AxlNetClient.GetMohAudioSourceReq getMohAudioSource)
        {
            AxlNetClient.getMohAudioSourceRequest inValue = new AxlNetClient.getMohAudioSourceRequest();
            inValue.getMohAudioSource = getMohAudioSource;
            return ((AxlNetClient.AXLPort19)(this)).getMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMohAudioSourceResponse AxlNetClient.AXLPort19.removeMohAudioSource(AxlNetClient.removeMohAudioSourceRequest request)
        {
            return base.Channel.removeMohAudioSource(request);
        }

        public AxlNetClient.StandardResponse removeMohAudioSource(AxlNetClient.RemoveMohAudioSourceReq removeMohAudioSource1)
        {
            AxlNetClient.removeMohAudioSourceRequest inValue = new AxlNetClient.removeMohAudioSourceRequest();
            inValue.removeMohAudioSource = removeMohAudioSource1;
            AxlNetClient.removeMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort19)(this)).removeMohAudioSource(inValue);
            return retVal.removeMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMohAudioSourceResponse> AxlNetClient.AXLPort19.removeMohAudioSourceAsync(AxlNetClient.removeMohAudioSourceRequest request)
        {
            return base.Channel.removeMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMohAudioSourceResponse> removeMohAudioSourceAsync(AxlNetClient.RemoveMohAudioSourceReq removeMohAudioSource)
        {
            AxlNetClient.removeMohAudioSourceRequest inValue = new AxlNetClient.removeMohAudioSourceRequest();
            inValue.removeMohAudioSource = removeMohAudioSource;
            return ((AxlNetClient.AXLPort19)(this)).removeMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMohAudioSourceResponse AxlNetClient.AXLPort19.listMohAudioSource(AxlNetClient.listMohAudioSourceRequest request)
        {
            return base.Channel.listMohAudioSource(request);
        }

        public AxlNetClient.ListMohAudioSourceRes listMohAudioSource(AxlNetClient.ListMohAudioSourceReq listMohAudioSource1)
        {
            AxlNetClient.listMohAudioSourceRequest inValue = new AxlNetClient.listMohAudioSourceRequest();
            inValue.listMohAudioSource = listMohAudioSource1;
            AxlNetClient.listMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort19)(this)).listMohAudioSource(inValue);
            return retVal.listMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMohAudioSourceResponse> AxlNetClient.AXLPort19.listMohAudioSourceAsync(AxlNetClient.listMohAudioSourceRequest request)
        {
            return base.Channel.listMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMohAudioSourceResponse> listMohAudioSourceAsync(AxlNetClient.ListMohAudioSourceReq listMohAudioSource)
        {
            AxlNetClient.listMohAudioSourceRequest inValue = new AxlNetClient.listMohAudioSourceRequest();
            inValue.listMohAudioSource = listMohAudioSource;
            return ((AxlNetClient.AXLPort19)(this)).listMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDhcpServerResponse AxlNetClient.AXLPort19.addDhcpServer(AxlNetClient.addDhcpServerRequest request)
        {
            return base.Channel.addDhcpServer(request);
        }

        public AxlNetClient.StandardResponse addDhcpServer(AxlNetClient.AddDhcpServerReq addDhcpServer1)
        {
            AxlNetClient.addDhcpServerRequest inValue = new AxlNetClient.addDhcpServerRequest();
            inValue.addDhcpServer = addDhcpServer1;
            AxlNetClient.addDhcpServerResponse retVal = ((AxlNetClient.AXLPort19)(this)).addDhcpServer(inValue);
            return retVal.addDhcpServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDhcpServerResponse> AxlNetClient.AXLPort19.addDhcpServerAsync(AxlNetClient.addDhcpServerRequest request)
        {
            return base.Channel.addDhcpServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDhcpServerResponse> addDhcpServerAsync(AxlNetClient.AddDhcpServerReq addDhcpServer)
        {
            AxlNetClient.addDhcpServerRequest inValue = new AxlNetClient.addDhcpServerRequest();
            inValue.addDhcpServer = addDhcpServer;
            return ((AxlNetClient.AXLPort19)(this)).addDhcpServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDhcpServerResponse AxlNetClient.AXLPort19.updateDhcpServer(AxlNetClient.updateDhcpServerRequest request)
        {
            return base.Channel.updateDhcpServer(request);
        }

        public AxlNetClient.StandardResponse updateDhcpServer(AxlNetClient.UpdateDhcpServerReq updateDhcpServer1)
        {
            AxlNetClient.updateDhcpServerRequest inValue = new AxlNetClient.updateDhcpServerRequest();
            inValue.updateDhcpServer = updateDhcpServer1;
            AxlNetClient.updateDhcpServerResponse retVal = ((AxlNetClient.AXLPort19)(this)).updateDhcpServer(inValue);
            return retVal.updateDhcpServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDhcpServerResponse> AxlNetClient.AXLPort19.updateDhcpServerAsync(AxlNetClient.updateDhcpServerRequest request)
        {
            return base.Channel.updateDhcpServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDhcpServerResponse> updateDhcpServerAsync(AxlNetClient.UpdateDhcpServerReq updateDhcpServer)
        {
            AxlNetClient.updateDhcpServerRequest inValue = new AxlNetClient.updateDhcpServerRequest();
            inValue.updateDhcpServer = updateDhcpServer;
            return ((AxlNetClient.AXLPort19)(this)).updateDhcpServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDhcpServerResponse AxlNetClient.AXLPort19.getDhcpServer(AxlNetClient.getDhcpServerRequest request)
        {
            return base.Channel.getDhcpServer(request);
        }

        public AxlNetClient.GetDhcpServerRes getDhcpServer(AxlNetClient.GetDhcpServerReq getDhcpServer1)
        {
            AxlNetClient.getDhcpServerRequest inValue = new AxlNetClient.getDhcpServerRequest();
            inValue.getDhcpServer = getDhcpServer1;
            AxlNetClient.getDhcpServerResponse retVal = ((AxlNetClient.AXLPort19)(this)).getDhcpServer(inValue);
            return retVal.getDhcpServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDhcpServerResponse> AxlNetClient.AXLPort19.getDhcpServerAsync(AxlNetClient.getDhcpServerRequest request)
        {
            return base.Channel.getDhcpServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDhcpServerResponse> getDhcpServerAsync(AxlNetClient.GetDhcpServerReq getDhcpServer)
        {
            AxlNetClient.getDhcpServerRequest inValue = new AxlNetClient.getDhcpServerRequest();
            inValue.getDhcpServer = getDhcpServer;
            return ((AxlNetClient.AXLPort19)(this)).getDhcpServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDhcpServerResponse AxlNetClient.AXLPort19.removeDhcpServer(AxlNetClient.removeDhcpServerRequest request)
        {
            return base.Channel.removeDhcpServer(request);
        }

        public AxlNetClient.StandardResponse removeDhcpServer(AxlNetClient.RemoveDhcpServerReq removeDhcpServer1)
        {
            AxlNetClient.removeDhcpServerRequest inValue = new AxlNetClient.removeDhcpServerRequest();
            inValue.removeDhcpServer = removeDhcpServer1;
            AxlNetClient.removeDhcpServerResponse retVal = ((AxlNetClient.AXLPort19)(this)).removeDhcpServer(inValue);
            return retVal.removeDhcpServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDhcpServerResponse> AxlNetClient.AXLPort19.removeDhcpServerAsync(AxlNetClient.removeDhcpServerRequest request)
        {
            return base.Channel.removeDhcpServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDhcpServerResponse> removeDhcpServerAsync(AxlNetClient.RemoveDhcpServerReq removeDhcpServer)
        {
            AxlNetClient.removeDhcpServerRequest inValue = new AxlNetClient.removeDhcpServerRequest();
            inValue.removeDhcpServer = removeDhcpServer;
            return ((AxlNetClient.AXLPort19)(this)).removeDhcpServerAsync(inValue);
        }
    }
}