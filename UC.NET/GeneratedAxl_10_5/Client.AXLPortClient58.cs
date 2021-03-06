namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient58 _axlPortClient58;

        private static AXLPortClient58 axlPortClient58 => _axlPortClient58 == null ||
            _axlPortClient58.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient58 = LoadClient58()) : _axlPortClient58;

        private static AXLPortClient58 LoadClient58()
        {
            var client = new AXLPortClient58(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close58;
            OnAbort += Abort58;
            return client;
        }

        private static void Close58(object sender, System.EventArgs e)
        {
            _axlPortClient58.Close();
        }

        private static void Abort58(object sender, System.EventArgs e)
        {
            _axlPortClient58.Abort();
        }

        public AxlNetClient.GetVpnProfileRes getVpnProfile(AxlNetClient.GetVpnProfileReq getVpnProfile1)
        {
            return axlPortClient58.getVpnProfile(getVpnProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnProfileResponse> getVpnProfileAsync(AxlNetClient.GetVpnProfileReq getVpnProfile)
        {
            return axlPortClient58.getVpnProfileAsync(getVpnProfile);
        }

        public AxlNetClient.StandardResponse removeVpnProfile(AxlNetClient.NameAndGUIDRequest removeVpnProfile1)
        {
            return axlPortClient58.removeVpnProfile(removeVpnProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnProfileResponse> removeVpnProfileAsync(AxlNetClient.NameAndGUIDRequest removeVpnProfile)
        {
            return axlPortClient58.removeVpnProfileAsync(removeVpnProfile);
        }

        public AxlNetClient.ListVpnProfileRes listVpnProfile(AxlNetClient.ListVpnProfileReq listVpnProfile1)
        {
            return axlPortClient58.listVpnProfile(listVpnProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnProfileResponse> listVpnProfileAsync(AxlNetClient.ListVpnProfileReq listVpnProfile)
        {
            return axlPortClient58.listVpnProfileAsync(listVpnProfile);
        }

        public AxlNetClient.StandardResponse addImeServer(AxlNetClient.AddImeServerReq addImeServer1)
        {
            return axlPortClient58.addImeServer(addImeServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeServerResponse> addImeServerAsync(AxlNetClient.AddImeServerReq addImeServer)
        {
            return axlPortClient58.addImeServerAsync(addImeServer);
        }

        public AxlNetClient.StandardResponse updateImeServer(AxlNetClient.UpdateImeServerReq updateImeServer1)
        {
            return axlPortClient58.updateImeServer(updateImeServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeServerResponse> updateImeServerAsync(AxlNetClient.UpdateImeServerReq updateImeServer)
        {
            return axlPortClient58.updateImeServerAsync(updateImeServer);
        }

        public AxlNetClient.GetImeServerRes getImeServer(AxlNetClient.GetImeServerReq getImeServer1)
        {
            return axlPortClient58.getImeServer(getImeServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeServerResponse> getImeServerAsync(AxlNetClient.GetImeServerReq getImeServer)
        {
            return axlPortClient58.getImeServerAsync(getImeServer);
        }

        public AxlNetClient.StandardResponse removeImeServer(AxlNetClient.NameAndGUIDRequest removeImeServer1)
        {
            return axlPortClient58.removeImeServer(removeImeServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeServerResponse> removeImeServerAsync(AxlNetClient.NameAndGUIDRequest removeImeServer)
        {
            return axlPortClient58.removeImeServerAsync(removeImeServer);
        }

        public AxlNetClient.ListImeServerRes listImeServer(AxlNetClient.ListImeServerReq listImeServer1)
        {
            return axlPortClient58.listImeServer(listImeServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeServerResponse> listImeServerAsync(AxlNetClient.ListImeServerReq listImeServer)
        {
            return axlPortClient58.listImeServerAsync(listImeServer);
        }

        public AxlNetClient.StandardResponse addImeRouteFilterGroup(AxlNetClient.AddImeRouteFilterGroupReq addImeRouteFilterGroup1)
        {
            return axlPortClient58.addImeRouteFilterGroup(addImeRouteFilterGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterGroupResponse> addImeRouteFilterGroupAsync(AxlNetClient.AddImeRouteFilterGroupReq addImeRouteFilterGroup)
        {
            return axlPortClient58.addImeRouteFilterGroupAsync(addImeRouteFilterGroup);
        }

        public AxlNetClient.StandardResponse updateImeRouteFilterGroup(AxlNetClient.UpdateImeRouteFilterGroupReq updateImeRouteFilterGroup1)
        {
            return axlPortClient58.updateImeRouteFilterGroup(updateImeRouteFilterGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterGroupResponse> updateImeRouteFilterGroupAsync(AxlNetClient.UpdateImeRouteFilterGroupReq updateImeRouteFilterGroup)
        {
            return axlPortClient58.updateImeRouteFilterGroupAsync(updateImeRouteFilterGroup);
        }

        public AxlNetClient.GetImeRouteFilterGroupRes getImeRouteFilterGroup(AxlNetClient.GetImeRouteFilterGroupReq getImeRouteFilterGroup1)
        {
            return axlPortClient58.getImeRouteFilterGroup(getImeRouteFilterGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterGroupResponse> getImeRouteFilterGroupAsync(AxlNetClient.GetImeRouteFilterGroupReq getImeRouteFilterGroup)
        {
            return axlPortClient58.getImeRouteFilterGroupAsync(getImeRouteFilterGroup);
        }

        public AxlNetClient.StandardResponse removeImeRouteFilterGroup(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterGroup1)
        {
            return axlPortClient58.removeImeRouteFilterGroup(removeImeRouteFilterGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterGroupResponse> removeImeRouteFilterGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterGroup)
        {
            return axlPortClient58.removeImeRouteFilterGroupAsync(removeImeRouteFilterGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort58
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVpnProfileResponse getVpnProfile(AxlNetClient.getVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVpnProfileResponse> getVpnProfileAsync(AxlNetClient.getVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVpnProfileResponse removeVpnProfile(AxlNetClient.removeVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnProfileResponse> removeVpnProfileAsync(AxlNetClient.removeVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVpnProfileResponse listVpnProfile(AxlNetClient.listVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVpnProfileResponse> listVpnProfileAsync(AxlNetClient.listVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeServerResponse addImeServer(AxlNetClient.addImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeServerResponse> addImeServerAsync(AxlNetClient.addImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeServerResponse updateImeServer(AxlNetClient.updateImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeServerResponse> updateImeServerAsync(AxlNetClient.updateImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeServerResponse getImeServer(AxlNetClient.getImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeServerResponse> getImeServerAsync(AxlNetClient.getImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeServerResponse removeImeServer(AxlNetClient.removeImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeServerResponse> removeImeServerAsync(AxlNetClient.removeImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeServerResponse listImeServer(AxlNetClient.listImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeServerResponse> listImeServerAsync(AxlNetClient.listImeServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeRouteFilterGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeRouteFilterGroupResponse addImeRouteFilterGroup(AxlNetClient.addImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeRouteFilterGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterGroupResponse> addImeRouteFilterGroupAsync(AxlNetClient.addImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeRouteFilterGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeRouteFilterGroupResponse updateImeRouteFilterGroup(AxlNetClient.updateImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeRouteFilterGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterGroupResponse> updateImeRouteFilterGroupAsync(AxlNetClient.updateImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeRouteFilterGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeRouteFilterGroupResponse getImeRouteFilterGroup(AxlNetClient.getImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeRouteFilterGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterGroupResponse> getImeRouteFilterGroupAsync(AxlNetClient.getImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeRouteFilterGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeRouteFilterGroupResponse removeImeRouteFilterGroup(AxlNetClient.removeImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeRouteFilterGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterGroupResponse> removeImeRouteFilterGroupAsync(AxlNetClient.removeImeRouteFilterGroupRequest request);
    }

    public class AXLPortClient58 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort58>, AxlNetClient.AXLPort58
    {
        public AXLPortClient58(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVpnProfileResponse AxlNetClient.AXLPort58.getVpnProfile(AxlNetClient.getVpnProfileRequest request)
        {
            return base.Channel.getVpnProfile(request);
        }

        public AxlNetClient.GetVpnProfileRes getVpnProfile(AxlNetClient.GetVpnProfileReq getVpnProfile1)
        {
            AxlNetClient.getVpnProfileRequest inValue = new AxlNetClient.getVpnProfileRequest();
            inValue.getVpnProfile = getVpnProfile1;
            AxlNetClient.getVpnProfileResponse retVal = ((AxlNetClient.AXLPort58)(this)).getVpnProfile(inValue);
            return retVal.getVpnProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVpnProfileResponse> AxlNetClient.AXLPort58.getVpnProfileAsync(AxlNetClient.getVpnProfileRequest request)
        {
            return base.Channel.getVpnProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnProfileResponse> getVpnProfileAsync(AxlNetClient.GetVpnProfileReq getVpnProfile)
        {
            AxlNetClient.getVpnProfileRequest inValue = new AxlNetClient.getVpnProfileRequest();
            inValue.getVpnProfile = getVpnProfile;
            return ((AxlNetClient.AXLPort58)(this)).getVpnProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVpnProfileResponse AxlNetClient.AXLPort58.removeVpnProfile(AxlNetClient.removeVpnProfileRequest request)
        {
            return base.Channel.removeVpnProfile(request);
        }

        public AxlNetClient.StandardResponse removeVpnProfile(AxlNetClient.NameAndGUIDRequest removeVpnProfile1)
        {
            AxlNetClient.removeVpnProfileRequest inValue = new AxlNetClient.removeVpnProfileRequest();
            inValue.removeVpnProfile = removeVpnProfile1;
            AxlNetClient.removeVpnProfileResponse retVal = ((AxlNetClient.AXLPort58)(this)).removeVpnProfile(inValue);
            return retVal.removeVpnProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnProfileResponse> AxlNetClient.AXLPort58.removeVpnProfileAsync(AxlNetClient.removeVpnProfileRequest request)
        {
            return base.Channel.removeVpnProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnProfileResponse> removeVpnProfileAsync(AxlNetClient.NameAndGUIDRequest removeVpnProfile)
        {
            AxlNetClient.removeVpnProfileRequest inValue = new AxlNetClient.removeVpnProfileRequest();
            inValue.removeVpnProfile = removeVpnProfile;
            return ((AxlNetClient.AXLPort58)(this)).removeVpnProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVpnProfileResponse AxlNetClient.AXLPort58.listVpnProfile(AxlNetClient.listVpnProfileRequest request)
        {
            return base.Channel.listVpnProfile(request);
        }

        public AxlNetClient.ListVpnProfileRes listVpnProfile(AxlNetClient.ListVpnProfileReq listVpnProfile1)
        {
            AxlNetClient.listVpnProfileRequest inValue = new AxlNetClient.listVpnProfileRequest();
            inValue.listVpnProfile = listVpnProfile1;
            AxlNetClient.listVpnProfileResponse retVal = ((AxlNetClient.AXLPort58)(this)).listVpnProfile(inValue);
            return retVal.listVpnProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVpnProfileResponse> AxlNetClient.AXLPort58.listVpnProfileAsync(AxlNetClient.listVpnProfileRequest request)
        {
            return base.Channel.listVpnProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnProfileResponse> listVpnProfileAsync(AxlNetClient.ListVpnProfileReq listVpnProfile)
        {
            AxlNetClient.listVpnProfileRequest inValue = new AxlNetClient.listVpnProfileRequest();
            inValue.listVpnProfile = listVpnProfile;
            return ((AxlNetClient.AXLPort58)(this)).listVpnProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeServerResponse AxlNetClient.AXLPort58.addImeServer(AxlNetClient.addImeServerRequest request)
        {
            return base.Channel.addImeServer(request);
        }

        public AxlNetClient.StandardResponse addImeServer(AxlNetClient.AddImeServerReq addImeServer1)
        {
            AxlNetClient.addImeServerRequest inValue = new AxlNetClient.addImeServerRequest();
            inValue.addImeServer = addImeServer1;
            AxlNetClient.addImeServerResponse retVal = ((AxlNetClient.AXLPort58)(this)).addImeServer(inValue);
            return retVal.addImeServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeServerResponse> AxlNetClient.AXLPort58.addImeServerAsync(AxlNetClient.addImeServerRequest request)
        {
            return base.Channel.addImeServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeServerResponse> addImeServerAsync(AxlNetClient.AddImeServerReq addImeServer)
        {
            AxlNetClient.addImeServerRequest inValue = new AxlNetClient.addImeServerRequest();
            inValue.addImeServer = addImeServer;
            return ((AxlNetClient.AXLPort58)(this)).addImeServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeServerResponse AxlNetClient.AXLPort58.updateImeServer(AxlNetClient.updateImeServerRequest request)
        {
            return base.Channel.updateImeServer(request);
        }

        public AxlNetClient.StandardResponse updateImeServer(AxlNetClient.UpdateImeServerReq updateImeServer1)
        {
            AxlNetClient.updateImeServerRequest inValue = new AxlNetClient.updateImeServerRequest();
            inValue.updateImeServer = updateImeServer1;
            AxlNetClient.updateImeServerResponse retVal = ((AxlNetClient.AXLPort58)(this)).updateImeServer(inValue);
            return retVal.updateImeServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeServerResponse> AxlNetClient.AXLPort58.updateImeServerAsync(AxlNetClient.updateImeServerRequest request)
        {
            return base.Channel.updateImeServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeServerResponse> updateImeServerAsync(AxlNetClient.UpdateImeServerReq updateImeServer)
        {
            AxlNetClient.updateImeServerRequest inValue = new AxlNetClient.updateImeServerRequest();
            inValue.updateImeServer = updateImeServer;
            return ((AxlNetClient.AXLPort58)(this)).updateImeServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeServerResponse AxlNetClient.AXLPort58.getImeServer(AxlNetClient.getImeServerRequest request)
        {
            return base.Channel.getImeServer(request);
        }

        public AxlNetClient.GetImeServerRes getImeServer(AxlNetClient.GetImeServerReq getImeServer1)
        {
            AxlNetClient.getImeServerRequest inValue = new AxlNetClient.getImeServerRequest();
            inValue.getImeServer = getImeServer1;
            AxlNetClient.getImeServerResponse retVal = ((AxlNetClient.AXLPort58)(this)).getImeServer(inValue);
            return retVal.getImeServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeServerResponse> AxlNetClient.AXLPort58.getImeServerAsync(AxlNetClient.getImeServerRequest request)
        {
            return base.Channel.getImeServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeServerResponse> getImeServerAsync(AxlNetClient.GetImeServerReq getImeServer)
        {
            AxlNetClient.getImeServerRequest inValue = new AxlNetClient.getImeServerRequest();
            inValue.getImeServer = getImeServer;
            return ((AxlNetClient.AXLPort58)(this)).getImeServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeServerResponse AxlNetClient.AXLPort58.removeImeServer(AxlNetClient.removeImeServerRequest request)
        {
            return base.Channel.removeImeServer(request);
        }

        public AxlNetClient.StandardResponse removeImeServer(AxlNetClient.NameAndGUIDRequest removeImeServer1)
        {
            AxlNetClient.removeImeServerRequest inValue = new AxlNetClient.removeImeServerRequest();
            inValue.removeImeServer = removeImeServer1;
            AxlNetClient.removeImeServerResponse retVal = ((AxlNetClient.AXLPort58)(this)).removeImeServer(inValue);
            return retVal.removeImeServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeServerResponse> AxlNetClient.AXLPort58.removeImeServerAsync(AxlNetClient.removeImeServerRequest request)
        {
            return base.Channel.removeImeServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeServerResponse> removeImeServerAsync(AxlNetClient.NameAndGUIDRequest removeImeServer)
        {
            AxlNetClient.removeImeServerRequest inValue = new AxlNetClient.removeImeServerRequest();
            inValue.removeImeServer = removeImeServer;
            return ((AxlNetClient.AXLPort58)(this)).removeImeServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeServerResponse AxlNetClient.AXLPort58.listImeServer(AxlNetClient.listImeServerRequest request)
        {
            return base.Channel.listImeServer(request);
        }

        public AxlNetClient.ListImeServerRes listImeServer(AxlNetClient.ListImeServerReq listImeServer1)
        {
            AxlNetClient.listImeServerRequest inValue = new AxlNetClient.listImeServerRequest();
            inValue.listImeServer = listImeServer1;
            AxlNetClient.listImeServerResponse retVal = ((AxlNetClient.AXLPort58)(this)).listImeServer(inValue);
            return retVal.listImeServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeServerResponse> AxlNetClient.AXLPort58.listImeServerAsync(AxlNetClient.listImeServerRequest request)
        {
            return base.Channel.listImeServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeServerResponse> listImeServerAsync(AxlNetClient.ListImeServerReq listImeServer)
        {
            AxlNetClient.listImeServerRequest inValue = new AxlNetClient.listImeServerRequest();
            inValue.listImeServer = listImeServer;
            return ((AxlNetClient.AXLPort58)(this)).listImeServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeRouteFilterGroupResponse AxlNetClient.AXLPort58.addImeRouteFilterGroup(AxlNetClient.addImeRouteFilterGroupRequest request)
        {
            return base.Channel.addImeRouteFilterGroup(request);
        }

        public AxlNetClient.StandardResponse addImeRouteFilterGroup(AxlNetClient.AddImeRouteFilterGroupReq addImeRouteFilterGroup1)
        {
            AxlNetClient.addImeRouteFilterGroupRequest inValue = new AxlNetClient.addImeRouteFilterGroupRequest();
            inValue.addImeRouteFilterGroup = addImeRouteFilterGroup1;
            AxlNetClient.addImeRouteFilterGroupResponse retVal = ((AxlNetClient.AXLPort58)(this)).addImeRouteFilterGroup(inValue);
            return retVal.addImeRouteFilterGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterGroupResponse> AxlNetClient.AXLPort58.addImeRouteFilterGroupAsync(AxlNetClient.addImeRouteFilterGroupRequest request)
        {
            return base.Channel.addImeRouteFilterGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterGroupResponse> addImeRouteFilterGroupAsync(AxlNetClient.AddImeRouteFilterGroupReq addImeRouteFilterGroup)
        {
            AxlNetClient.addImeRouteFilterGroupRequest inValue = new AxlNetClient.addImeRouteFilterGroupRequest();
            inValue.addImeRouteFilterGroup = addImeRouteFilterGroup;
            return ((AxlNetClient.AXLPort58)(this)).addImeRouteFilterGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeRouteFilterGroupResponse AxlNetClient.AXLPort58.updateImeRouteFilterGroup(AxlNetClient.updateImeRouteFilterGroupRequest request)
        {
            return base.Channel.updateImeRouteFilterGroup(request);
        }

        public AxlNetClient.StandardResponse updateImeRouteFilterGroup(AxlNetClient.UpdateImeRouteFilterGroupReq updateImeRouteFilterGroup1)
        {
            AxlNetClient.updateImeRouteFilterGroupRequest inValue = new AxlNetClient.updateImeRouteFilterGroupRequest();
            inValue.updateImeRouteFilterGroup = updateImeRouteFilterGroup1;
            AxlNetClient.updateImeRouteFilterGroupResponse retVal = ((AxlNetClient.AXLPort58)(this)).updateImeRouteFilterGroup(inValue);
            return retVal.updateImeRouteFilterGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterGroupResponse> AxlNetClient.AXLPort58.updateImeRouteFilterGroupAsync(AxlNetClient.updateImeRouteFilterGroupRequest request)
        {
            return base.Channel.updateImeRouteFilterGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterGroupResponse> updateImeRouteFilterGroupAsync(AxlNetClient.UpdateImeRouteFilterGroupReq updateImeRouteFilterGroup)
        {
            AxlNetClient.updateImeRouteFilterGroupRequest inValue = new AxlNetClient.updateImeRouteFilterGroupRequest();
            inValue.updateImeRouteFilterGroup = updateImeRouteFilterGroup;
            return ((AxlNetClient.AXLPort58)(this)).updateImeRouteFilterGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeRouteFilterGroupResponse AxlNetClient.AXLPort58.getImeRouteFilterGroup(AxlNetClient.getImeRouteFilterGroupRequest request)
        {
            return base.Channel.getImeRouteFilterGroup(request);
        }

        public AxlNetClient.GetImeRouteFilterGroupRes getImeRouteFilterGroup(AxlNetClient.GetImeRouteFilterGroupReq getImeRouteFilterGroup1)
        {
            AxlNetClient.getImeRouteFilterGroupRequest inValue = new AxlNetClient.getImeRouteFilterGroupRequest();
            inValue.getImeRouteFilterGroup = getImeRouteFilterGroup1;
            AxlNetClient.getImeRouteFilterGroupResponse retVal = ((AxlNetClient.AXLPort58)(this)).getImeRouteFilterGroup(inValue);
            return retVal.getImeRouteFilterGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterGroupResponse> AxlNetClient.AXLPort58.getImeRouteFilterGroupAsync(AxlNetClient.getImeRouteFilterGroupRequest request)
        {
            return base.Channel.getImeRouteFilterGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterGroupResponse> getImeRouteFilterGroupAsync(AxlNetClient.GetImeRouteFilterGroupReq getImeRouteFilterGroup)
        {
            AxlNetClient.getImeRouteFilterGroupRequest inValue = new AxlNetClient.getImeRouteFilterGroupRequest();
            inValue.getImeRouteFilterGroup = getImeRouteFilterGroup;
            return ((AxlNetClient.AXLPort58)(this)).getImeRouteFilterGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeRouteFilterGroupResponse AxlNetClient.AXLPort58.removeImeRouteFilterGroup(AxlNetClient.removeImeRouteFilterGroupRequest request)
        {
            return base.Channel.removeImeRouteFilterGroup(request);
        }

        public AxlNetClient.StandardResponse removeImeRouteFilterGroup(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterGroup1)
        {
            AxlNetClient.removeImeRouteFilterGroupRequest inValue = new AxlNetClient.removeImeRouteFilterGroupRequest();
            inValue.removeImeRouteFilterGroup = removeImeRouteFilterGroup1;
            AxlNetClient.removeImeRouteFilterGroupResponse retVal = ((AxlNetClient.AXLPort58)(this)).removeImeRouteFilterGroup(inValue);
            return retVal.removeImeRouteFilterGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterGroupResponse> AxlNetClient.AXLPort58.removeImeRouteFilterGroupAsync(AxlNetClient.removeImeRouteFilterGroupRequest request)
        {
            return base.Channel.removeImeRouteFilterGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterGroupResponse> removeImeRouteFilterGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterGroup)
        {
            AxlNetClient.removeImeRouteFilterGroupRequest inValue = new AxlNetClient.removeImeRouteFilterGroupRequest();
            inValue.removeImeRouteFilterGroup = removeImeRouteFilterGroup;
            return ((AxlNetClient.AXLPort58)(this)).removeImeRouteFilterGroupAsync(inValue);
        }
    }
}