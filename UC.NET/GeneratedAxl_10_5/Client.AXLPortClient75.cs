namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient75 _axlPortClient75;

        private static AXLPortClient75 axlPortClient75 => _axlPortClient75 == null ||
            _axlPortClient75.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient75 = LoadClient75()) : _axlPortClient75;

        private static AXLPortClient75 LoadClient75()
        {
            var client = new AXLPortClient75(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close75;
            OnAbort += Abort75;
            return client;
        }

        private static void Close75(object sender, System.EventArgs e)
        {
            _axlPortClient75.Close();
        }

        private static void Abort75(object sender, System.EventArgs e)
        {
            _axlPortClient75.Abort();
        }

        public AxlNetClient.ListUnassignedPresenceServersRes listUnassignedPresenceServers(AxlNetClient.ListUnassignedPresenceServersReq listUnassignedPresenceServers1)
        {
            return axlPortClient75.listUnassignedPresenceServers(listUnassignedPresenceServers1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceServersResponse> listUnassignedPresenceServersAsync(AxlNetClient.ListUnassignedPresenceServersReq listUnassignedPresenceServers)
        {
            return axlPortClient75.listUnassignedPresenceServersAsync(listUnassignedPresenceServers);
        }

        public AxlNetClient.ListAssignedPresenceUsersRes listAssignedPresenceUsers(AxlNetClient.ListAssignedPresenceUsersReq listAssignedPresenceUsers1)
        {
            return axlPortClient75.listAssignedPresenceUsers(listAssignedPresenceUsers1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceUsersResponse> listAssignedPresenceUsersAsync(AxlNetClient.ListAssignedPresenceUsersReq listAssignedPresenceUsers)
        {
            return axlPortClient75.listAssignedPresenceUsersAsync(listAssignedPresenceUsers);
        }

        public AxlNetClient.ListUnassignedPresenceUsersRes listUnassignedPresenceUsers(AxlNetClient.ListUnassignedPresenceUsersReq listUnassignedPresenceUsers1)
        {
            return axlPortClient75.listUnassignedPresenceUsers(listUnassignedPresenceUsers1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceUsersResponse> listUnassignedPresenceUsersAsync(AxlNetClient.ListUnassignedPresenceUsersReq listUnassignedPresenceUsers)
        {
            return axlPortClient75.listUnassignedPresenceUsersAsync(listUnassignedPresenceUsers);
        }

        public AxlNetClient.StandardResponse addWifiHotspot(AxlNetClient.AddWifiHotspotReq addWifiHotspot1)
        {
            return axlPortClient75.addWifiHotspot(addWifiHotspot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWifiHotspotResponse> addWifiHotspotAsync(AxlNetClient.AddWifiHotspotReq addWifiHotspot)
        {
            return axlPortClient75.addWifiHotspotAsync(addWifiHotspot);
        }

        public AxlNetClient.StandardResponse updateWifiHotspot(AxlNetClient.UpdateWifiHotspotReq updateWifiHotspot1)
        {
            return axlPortClient75.updateWifiHotspot(updateWifiHotspot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWifiHotspotResponse> updateWifiHotspotAsync(AxlNetClient.UpdateWifiHotspotReq updateWifiHotspot)
        {
            return axlPortClient75.updateWifiHotspotAsync(updateWifiHotspot);
        }

        public AxlNetClient.GetWifiHotspotRes getWifiHotspot(AxlNetClient.GetWifiHotspotReq getWifiHotspot1)
        {
            return axlPortClient75.getWifiHotspot(getWifiHotspot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWifiHotspotResponse> getWifiHotspotAsync(AxlNetClient.GetWifiHotspotReq getWifiHotspot)
        {
            return axlPortClient75.getWifiHotspotAsync(getWifiHotspot);
        }

        public AxlNetClient.StandardResponse removeWifiHotspot(AxlNetClient.NameAndGUIDRequest removeWifiHotspot1)
        {
            return axlPortClient75.removeWifiHotspot(removeWifiHotspot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWifiHotspotResponse> removeWifiHotspotAsync(AxlNetClient.NameAndGUIDRequest removeWifiHotspot)
        {
            return axlPortClient75.removeWifiHotspotAsync(removeWifiHotspot);
        }

        public AxlNetClient.ListWifiHotspotRes listWifiHotspot(AxlNetClient.ListWifiHotspotReq listWifiHotspot1)
        {
            return axlPortClient75.listWifiHotspot(listWifiHotspot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWifiHotspotResponse> listWifiHotspotAsync(AxlNetClient.ListWifiHotspotReq listWifiHotspot)
        {
            return axlPortClient75.listWifiHotspotAsync(listWifiHotspot);
        }

        public AxlNetClient.StandardResponse addWlanProfileGroup(AxlNetClient.AddWlanProfileGroupReq addWlanProfileGroup1)
        {
            return axlPortClient75.addWlanProfileGroup(addWlanProfileGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWlanProfileGroupResponse> addWlanProfileGroupAsync(AxlNetClient.AddWlanProfileGroupReq addWlanProfileGroup)
        {
            return axlPortClient75.addWlanProfileGroupAsync(addWlanProfileGroup);
        }

        public AxlNetClient.StandardResponse updateWlanProfileGroup(AxlNetClient.UpdateWlanProfileGroupReq updateWlanProfileGroup1)
        {
            return axlPortClient75.updateWlanProfileGroup(updateWlanProfileGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWlanProfileGroupResponse> updateWlanProfileGroupAsync(AxlNetClient.UpdateWlanProfileGroupReq updateWlanProfileGroup)
        {
            return axlPortClient75.updateWlanProfileGroupAsync(updateWlanProfileGroup);
        }

        public AxlNetClient.GetWlanProfileGroupRes getWlanProfileGroup(AxlNetClient.GetWlanProfileGroupReq getWlanProfileGroup1)
        {
            return axlPortClient75.getWlanProfileGroup(getWlanProfileGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWlanProfileGroupResponse> getWlanProfileGroupAsync(AxlNetClient.GetWlanProfileGroupReq getWlanProfileGroup)
        {
            return axlPortClient75.getWlanProfileGroupAsync(getWlanProfileGroup);
        }

        public AxlNetClient.StandardResponse removeWlanProfileGroup(AxlNetClient.NameAndGUIDRequest removeWlanProfileGroup1)
        {
            return axlPortClient75.removeWlanProfileGroup(removeWlanProfileGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWlanProfileGroupResponse> removeWlanProfileGroupAsync(AxlNetClient.NameAndGUIDRequest removeWlanProfileGroup)
        {
            return axlPortClient75.removeWlanProfileGroupAsync(removeWlanProfileGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort75
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUnassignedPresenceServers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUnassignedPresenceServersResponse listUnassignedPresenceServers(AxlNetClient.listUnassignedPresenceServersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUnassignedPresenceServers", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceServersResponse> listUnassignedPresenceServersAsync(AxlNetClient.listUnassignedPresenceServersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAssignedPresenceUsers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAssignedPresenceUsersResponse listAssignedPresenceUsers(AxlNetClient.listAssignedPresenceUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAssignedPresenceUsers", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceUsersResponse> listAssignedPresenceUsersAsync(AxlNetClient.listAssignedPresenceUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUnassignedPresenceUsers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUnassignedPresenceUsersResponse listUnassignedPresenceUsers(AxlNetClient.listUnassignedPresenceUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUnassignedPresenceUsers", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceUsersResponse> listUnassignedPresenceUsersAsync(AxlNetClient.listUnassignedPresenceUsersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWifiHotspot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addWifiHotspotResponse addWifiHotspot(AxlNetClient.addWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWifiHotspot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addWifiHotspotResponse> addWifiHotspotAsync(AxlNetClient.addWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWifiHotspot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateWifiHotspotResponse updateWifiHotspot(AxlNetClient.updateWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWifiHotspot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateWifiHotspotResponse> updateWifiHotspotAsync(AxlNetClient.updateWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWifiHotspot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getWifiHotspotResponse getWifiHotspot(AxlNetClient.getWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWifiHotspot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getWifiHotspotResponse> getWifiHotspotAsync(AxlNetClient.getWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWifiHotspot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeWifiHotspotResponse removeWifiHotspot(AxlNetClient.removeWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWifiHotspot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeWifiHotspotResponse> removeWifiHotspotAsync(AxlNetClient.removeWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWifiHotspot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listWifiHotspotResponse listWifiHotspot(AxlNetClient.listWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWifiHotspot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listWifiHotspotResponse> listWifiHotspotAsync(AxlNetClient.listWifiHotspotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWlanProfileGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addWlanProfileGroupResponse addWlanProfileGroup(AxlNetClient.addWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWlanProfileGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addWlanProfileGroupResponse> addWlanProfileGroupAsync(AxlNetClient.addWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWlanProfileGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateWlanProfileGroupResponse updateWlanProfileGroup(AxlNetClient.updateWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWlanProfileGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateWlanProfileGroupResponse> updateWlanProfileGroupAsync(AxlNetClient.updateWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWlanProfileGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getWlanProfileGroupResponse getWlanProfileGroup(AxlNetClient.getWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWlanProfileGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getWlanProfileGroupResponse> getWlanProfileGroupAsync(AxlNetClient.getWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWlanProfileGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeWlanProfileGroupResponse removeWlanProfileGroup(AxlNetClient.removeWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWlanProfileGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeWlanProfileGroupResponse> removeWlanProfileGroupAsync(AxlNetClient.removeWlanProfileGroupRequest request);
    }

    public class AXLPortClient75 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort75>, AxlNetClient.AXLPort75
    {
        public AXLPortClient75(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUnassignedPresenceServersResponse AxlNetClient.AXLPort75.listUnassignedPresenceServers(AxlNetClient.listUnassignedPresenceServersRequest request)
        {
            return base.Channel.listUnassignedPresenceServers(request);
        }

        public AxlNetClient.ListUnassignedPresenceServersRes listUnassignedPresenceServers(AxlNetClient.ListUnassignedPresenceServersReq listUnassignedPresenceServers1)
        {
            AxlNetClient.listUnassignedPresenceServersRequest inValue = new AxlNetClient.listUnassignedPresenceServersRequest();
            inValue.listUnassignedPresenceServers = listUnassignedPresenceServers1;
            AxlNetClient.listUnassignedPresenceServersResponse retVal = ((AxlNetClient.AXLPort75)(this)).listUnassignedPresenceServers(inValue);
            return retVal.listUnassignedPresenceServersResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceServersResponse> AxlNetClient.AXLPort75.listUnassignedPresenceServersAsync(AxlNetClient.listUnassignedPresenceServersRequest request)
        {
            return base.Channel.listUnassignedPresenceServersAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceServersResponse> listUnassignedPresenceServersAsync(AxlNetClient.ListUnassignedPresenceServersReq listUnassignedPresenceServers)
        {
            AxlNetClient.listUnassignedPresenceServersRequest inValue = new AxlNetClient.listUnassignedPresenceServersRequest();
            inValue.listUnassignedPresenceServers = listUnassignedPresenceServers;
            return ((AxlNetClient.AXLPort75)(this)).listUnassignedPresenceServersAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAssignedPresenceUsersResponse AxlNetClient.AXLPort75.listAssignedPresenceUsers(AxlNetClient.listAssignedPresenceUsersRequest request)
        {
            return base.Channel.listAssignedPresenceUsers(request);
        }

        public AxlNetClient.ListAssignedPresenceUsersRes listAssignedPresenceUsers(AxlNetClient.ListAssignedPresenceUsersReq listAssignedPresenceUsers1)
        {
            AxlNetClient.listAssignedPresenceUsersRequest inValue = new AxlNetClient.listAssignedPresenceUsersRequest();
            inValue.listAssignedPresenceUsers = listAssignedPresenceUsers1;
            AxlNetClient.listAssignedPresenceUsersResponse retVal = ((AxlNetClient.AXLPort75)(this)).listAssignedPresenceUsers(inValue);
            return retVal.listAssignedPresenceUsersResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceUsersResponse> AxlNetClient.AXLPort75.listAssignedPresenceUsersAsync(AxlNetClient.listAssignedPresenceUsersRequest request)
        {
            return base.Channel.listAssignedPresenceUsersAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceUsersResponse> listAssignedPresenceUsersAsync(AxlNetClient.ListAssignedPresenceUsersReq listAssignedPresenceUsers)
        {
            AxlNetClient.listAssignedPresenceUsersRequest inValue = new AxlNetClient.listAssignedPresenceUsersRequest();
            inValue.listAssignedPresenceUsers = listAssignedPresenceUsers;
            return ((AxlNetClient.AXLPort75)(this)).listAssignedPresenceUsersAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUnassignedPresenceUsersResponse AxlNetClient.AXLPort75.listUnassignedPresenceUsers(AxlNetClient.listUnassignedPresenceUsersRequest request)
        {
            return base.Channel.listUnassignedPresenceUsers(request);
        }

        public AxlNetClient.ListUnassignedPresenceUsersRes listUnassignedPresenceUsers(AxlNetClient.ListUnassignedPresenceUsersReq listUnassignedPresenceUsers1)
        {
            AxlNetClient.listUnassignedPresenceUsersRequest inValue = new AxlNetClient.listUnassignedPresenceUsersRequest();
            inValue.listUnassignedPresenceUsers = listUnassignedPresenceUsers1;
            AxlNetClient.listUnassignedPresenceUsersResponse retVal = ((AxlNetClient.AXLPort75)(this)).listUnassignedPresenceUsers(inValue);
            return retVal.listUnassignedPresenceUsersResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceUsersResponse> AxlNetClient.AXLPort75.listUnassignedPresenceUsersAsync(AxlNetClient.listUnassignedPresenceUsersRequest request)
        {
            return base.Channel.listUnassignedPresenceUsersAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUnassignedPresenceUsersResponse> listUnassignedPresenceUsersAsync(AxlNetClient.ListUnassignedPresenceUsersReq listUnassignedPresenceUsers)
        {
            AxlNetClient.listUnassignedPresenceUsersRequest inValue = new AxlNetClient.listUnassignedPresenceUsersRequest();
            inValue.listUnassignedPresenceUsers = listUnassignedPresenceUsers;
            return ((AxlNetClient.AXLPort75)(this)).listUnassignedPresenceUsersAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addWifiHotspotResponse AxlNetClient.AXLPort75.addWifiHotspot(AxlNetClient.addWifiHotspotRequest request)
        {
            return base.Channel.addWifiHotspot(request);
        }

        public AxlNetClient.StandardResponse addWifiHotspot(AxlNetClient.AddWifiHotspotReq addWifiHotspot1)
        {
            AxlNetClient.addWifiHotspotRequest inValue = new AxlNetClient.addWifiHotspotRequest();
            inValue.addWifiHotspot = addWifiHotspot1;
            AxlNetClient.addWifiHotspotResponse retVal = ((AxlNetClient.AXLPort75)(this)).addWifiHotspot(inValue);
            return retVal.addWifiHotspotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addWifiHotspotResponse> AxlNetClient.AXLPort75.addWifiHotspotAsync(AxlNetClient.addWifiHotspotRequest request)
        {
            return base.Channel.addWifiHotspotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWifiHotspotResponse> addWifiHotspotAsync(AxlNetClient.AddWifiHotspotReq addWifiHotspot)
        {
            AxlNetClient.addWifiHotspotRequest inValue = new AxlNetClient.addWifiHotspotRequest();
            inValue.addWifiHotspot = addWifiHotspot;
            return ((AxlNetClient.AXLPort75)(this)).addWifiHotspotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateWifiHotspotResponse AxlNetClient.AXLPort75.updateWifiHotspot(AxlNetClient.updateWifiHotspotRequest request)
        {
            return base.Channel.updateWifiHotspot(request);
        }

        public AxlNetClient.StandardResponse updateWifiHotspot(AxlNetClient.UpdateWifiHotspotReq updateWifiHotspot1)
        {
            AxlNetClient.updateWifiHotspotRequest inValue = new AxlNetClient.updateWifiHotspotRequest();
            inValue.updateWifiHotspot = updateWifiHotspot1;
            AxlNetClient.updateWifiHotspotResponse retVal = ((AxlNetClient.AXLPort75)(this)).updateWifiHotspot(inValue);
            return retVal.updateWifiHotspotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateWifiHotspotResponse> AxlNetClient.AXLPort75.updateWifiHotspotAsync(AxlNetClient.updateWifiHotspotRequest request)
        {
            return base.Channel.updateWifiHotspotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWifiHotspotResponse> updateWifiHotspotAsync(AxlNetClient.UpdateWifiHotspotReq updateWifiHotspot)
        {
            AxlNetClient.updateWifiHotspotRequest inValue = new AxlNetClient.updateWifiHotspotRequest();
            inValue.updateWifiHotspot = updateWifiHotspot;
            return ((AxlNetClient.AXLPort75)(this)).updateWifiHotspotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getWifiHotspotResponse AxlNetClient.AXLPort75.getWifiHotspot(AxlNetClient.getWifiHotspotRequest request)
        {
            return base.Channel.getWifiHotspot(request);
        }

        public AxlNetClient.GetWifiHotspotRes getWifiHotspot(AxlNetClient.GetWifiHotspotReq getWifiHotspot1)
        {
            AxlNetClient.getWifiHotspotRequest inValue = new AxlNetClient.getWifiHotspotRequest();
            inValue.getWifiHotspot = getWifiHotspot1;
            AxlNetClient.getWifiHotspotResponse retVal = ((AxlNetClient.AXLPort75)(this)).getWifiHotspot(inValue);
            return retVal.getWifiHotspotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getWifiHotspotResponse> AxlNetClient.AXLPort75.getWifiHotspotAsync(AxlNetClient.getWifiHotspotRequest request)
        {
            return base.Channel.getWifiHotspotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWifiHotspotResponse> getWifiHotspotAsync(AxlNetClient.GetWifiHotspotReq getWifiHotspot)
        {
            AxlNetClient.getWifiHotspotRequest inValue = new AxlNetClient.getWifiHotspotRequest();
            inValue.getWifiHotspot = getWifiHotspot;
            return ((AxlNetClient.AXLPort75)(this)).getWifiHotspotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeWifiHotspotResponse AxlNetClient.AXLPort75.removeWifiHotspot(AxlNetClient.removeWifiHotspotRequest request)
        {
            return base.Channel.removeWifiHotspot(request);
        }

        public AxlNetClient.StandardResponse removeWifiHotspot(AxlNetClient.NameAndGUIDRequest removeWifiHotspot1)
        {
            AxlNetClient.removeWifiHotspotRequest inValue = new AxlNetClient.removeWifiHotspotRequest();
            inValue.removeWifiHotspot = removeWifiHotspot1;
            AxlNetClient.removeWifiHotspotResponse retVal = ((AxlNetClient.AXLPort75)(this)).removeWifiHotspot(inValue);
            return retVal.removeWifiHotspotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeWifiHotspotResponse> AxlNetClient.AXLPort75.removeWifiHotspotAsync(AxlNetClient.removeWifiHotspotRequest request)
        {
            return base.Channel.removeWifiHotspotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWifiHotspotResponse> removeWifiHotspotAsync(AxlNetClient.NameAndGUIDRequest removeWifiHotspot)
        {
            AxlNetClient.removeWifiHotspotRequest inValue = new AxlNetClient.removeWifiHotspotRequest();
            inValue.removeWifiHotspot = removeWifiHotspot;
            return ((AxlNetClient.AXLPort75)(this)).removeWifiHotspotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listWifiHotspotResponse AxlNetClient.AXLPort75.listWifiHotspot(AxlNetClient.listWifiHotspotRequest request)
        {
            return base.Channel.listWifiHotspot(request);
        }

        public AxlNetClient.ListWifiHotspotRes listWifiHotspot(AxlNetClient.ListWifiHotspotReq listWifiHotspot1)
        {
            AxlNetClient.listWifiHotspotRequest inValue = new AxlNetClient.listWifiHotspotRequest();
            inValue.listWifiHotspot = listWifiHotspot1;
            AxlNetClient.listWifiHotspotResponse retVal = ((AxlNetClient.AXLPort75)(this)).listWifiHotspot(inValue);
            return retVal.listWifiHotspotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listWifiHotspotResponse> AxlNetClient.AXLPort75.listWifiHotspotAsync(AxlNetClient.listWifiHotspotRequest request)
        {
            return base.Channel.listWifiHotspotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWifiHotspotResponse> listWifiHotspotAsync(AxlNetClient.ListWifiHotspotReq listWifiHotspot)
        {
            AxlNetClient.listWifiHotspotRequest inValue = new AxlNetClient.listWifiHotspotRequest();
            inValue.listWifiHotspot = listWifiHotspot;
            return ((AxlNetClient.AXLPort75)(this)).listWifiHotspotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addWlanProfileGroupResponse AxlNetClient.AXLPort75.addWlanProfileGroup(AxlNetClient.addWlanProfileGroupRequest request)
        {
            return base.Channel.addWlanProfileGroup(request);
        }

        public AxlNetClient.StandardResponse addWlanProfileGroup(AxlNetClient.AddWlanProfileGroupReq addWlanProfileGroup1)
        {
            AxlNetClient.addWlanProfileGroupRequest inValue = new AxlNetClient.addWlanProfileGroupRequest();
            inValue.addWlanProfileGroup = addWlanProfileGroup1;
            AxlNetClient.addWlanProfileGroupResponse retVal = ((AxlNetClient.AXLPort75)(this)).addWlanProfileGroup(inValue);
            return retVal.addWlanProfileGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addWlanProfileGroupResponse> AxlNetClient.AXLPort75.addWlanProfileGroupAsync(AxlNetClient.addWlanProfileGroupRequest request)
        {
            return base.Channel.addWlanProfileGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWlanProfileGroupResponse> addWlanProfileGroupAsync(AxlNetClient.AddWlanProfileGroupReq addWlanProfileGroup)
        {
            AxlNetClient.addWlanProfileGroupRequest inValue = new AxlNetClient.addWlanProfileGroupRequest();
            inValue.addWlanProfileGroup = addWlanProfileGroup;
            return ((AxlNetClient.AXLPort75)(this)).addWlanProfileGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateWlanProfileGroupResponse AxlNetClient.AXLPort75.updateWlanProfileGroup(AxlNetClient.updateWlanProfileGroupRequest request)
        {
            return base.Channel.updateWlanProfileGroup(request);
        }

        public AxlNetClient.StandardResponse updateWlanProfileGroup(AxlNetClient.UpdateWlanProfileGroupReq updateWlanProfileGroup1)
        {
            AxlNetClient.updateWlanProfileGroupRequest inValue = new AxlNetClient.updateWlanProfileGroupRequest();
            inValue.updateWlanProfileGroup = updateWlanProfileGroup1;
            AxlNetClient.updateWlanProfileGroupResponse retVal = ((AxlNetClient.AXLPort75)(this)).updateWlanProfileGroup(inValue);
            return retVal.updateWlanProfileGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateWlanProfileGroupResponse> AxlNetClient.AXLPort75.updateWlanProfileGroupAsync(AxlNetClient.updateWlanProfileGroupRequest request)
        {
            return base.Channel.updateWlanProfileGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWlanProfileGroupResponse> updateWlanProfileGroupAsync(AxlNetClient.UpdateWlanProfileGroupReq updateWlanProfileGroup)
        {
            AxlNetClient.updateWlanProfileGroupRequest inValue = new AxlNetClient.updateWlanProfileGroupRequest();
            inValue.updateWlanProfileGroup = updateWlanProfileGroup;
            return ((AxlNetClient.AXLPort75)(this)).updateWlanProfileGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getWlanProfileGroupResponse AxlNetClient.AXLPort75.getWlanProfileGroup(AxlNetClient.getWlanProfileGroupRequest request)
        {
            return base.Channel.getWlanProfileGroup(request);
        }

        public AxlNetClient.GetWlanProfileGroupRes getWlanProfileGroup(AxlNetClient.GetWlanProfileGroupReq getWlanProfileGroup1)
        {
            AxlNetClient.getWlanProfileGroupRequest inValue = new AxlNetClient.getWlanProfileGroupRequest();
            inValue.getWlanProfileGroup = getWlanProfileGroup1;
            AxlNetClient.getWlanProfileGroupResponse retVal = ((AxlNetClient.AXLPort75)(this)).getWlanProfileGroup(inValue);
            return retVal.getWlanProfileGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getWlanProfileGroupResponse> AxlNetClient.AXLPort75.getWlanProfileGroupAsync(AxlNetClient.getWlanProfileGroupRequest request)
        {
            return base.Channel.getWlanProfileGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWlanProfileGroupResponse> getWlanProfileGroupAsync(AxlNetClient.GetWlanProfileGroupReq getWlanProfileGroup)
        {
            AxlNetClient.getWlanProfileGroupRequest inValue = new AxlNetClient.getWlanProfileGroupRequest();
            inValue.getWlanProfileGroup = getWlanProfileGroup;
            return ((AxlNetClient.AXLPort75)(this)).getWlanProfileGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeWlanProfileGroupResponse AxlNetClient.AXLPort75.removeWlanProfileGroup(AxlNetClient.removeWlanProfileGroupRequest request)
        {
            return base.Channel.removeWlanProfileGroup(request);
        }

        public AxlNetClient.StandardResponse removeWlanProfileGroup(AxlNetClient.NameAndGUIDRequest removeWlanProfileGroup1)
        {
            AxlNetClient.removeWlanProfileGroupRequest inValue = new AxlNetClient.removeWlanProfileGroupRequest();
            inValue.removeWlanProfileGroup = removeWlanProfileGroup1;
            AxlNetClient.removeWlanProfileGroupResponse retVal = ((AxlNetClient.AXLPort75)(this)).removeWlanProfileGroup(inValue);
            return retVal.removeWlanProfileGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeWlanProfileGroupResponse> AxlNetClient.AXLPort75.removeWlanProfileGroupAsync(AxlNetClient.removeWlanProfileGroupRequest request)
        {
            return base.Channel.removeWlanProfileGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWlanProfileGroupResponse> removeWlanProfileGroupAsync(AxlNetClient.NameAndGUIDRequest removeWlanProfileGroup)
        {
            AxlNetClient.removeWlanProfileGroupRequest inValue = new AxlNetClient.removeWlanProfileGroupRequest();
            inValue.removeWlanProfileGroup = removeWlanProfileGroup;
            return ((AxlNetClient.AXLPort75)(this)).removeWlanProfileGroupAsync(inValue);
        }
    }
}