namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient67 _axlPortClient67;

        private static AXLPortClient67 axlPortClient67 => _axlPortClient67 == null ||
            _axlPortClient67.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient67 = LoadClient67()) : _axlPortClient67;

        private static AXLPortClient67 LoadClient67()
        {
            var client = new AXLPortClient67(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close67;
            OnAbort += Abort67;
            return client;
        }

        private static void Close67(object sender, System.EventArgs e)
        {
            _axlPortClient67.Close();
        }

        private static void Abort67(object sender, System.EventArgs e)
        {
            _axlPortClient67.Abort();
        }

        public AxlNetClient.StandardResponse removeGatewaySccpEndpoints(AxlNetClient.NameAndGUIDRequest removeGatewaySccpEndpoints1)
        {
            return axlPortClient67.removeGatewaySccpEndpoints(removeGatewaySccpEndpoints1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewaySccpEndpointsResponse> removeGatewaySccpEndpointsAsync(AxlNetClient.NameAndGUIDRequest removeGatewaySccpEndpoints)
        {
            return axlPortClient67.removeGatewaySccpEndpointsAsync(removeGatewaySccpEndpoints);
        }

        public AxlNetClient.StandardResponse addBillingServer(AxlNetClient.AddBillingServerReq addBillingServer1)
        {
            return axlPortClient67.addBillingServer(addBillingServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addBillingServerResponse> addBillingServerAsync(AxlNetClient.AddBillingServerReq addBillingServer)
        {
            return axlPortClient67.addBillingServerAsync(addBillingServer);
        }

        public AxlNetClient.ListBillingServerRes listBillingServer(AxlNetClient.ListBillingServerReq listBillingServer1)
        {
            return axlPortClient67.listBillingServer(listBillingServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listBillingServerResponse> listBillingServerAsync(AxlNetClient.ListBillingServerReq listBillingServer)
        {
            return axlPortClient67.listBillingServerAsync(listBillingServer);
        }

        public AxlNetClient.StandardResponse addLbmGroup(AxlNetClient.AddLbmGroupReq addLbmGroup1)
        {
            return axlPortClient67.addLbmGroup(addLbmGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLbmGroupResponse> addLbmGroupAsync(AxlNetClient.AddLbmGroupReq addLbmGroup)
        {
            return axlPortClient67.addLbmGroupAsync(addLbmGroup);
        }

        public AxlNetClient.StandardResponse updateLbmGroup(AxlNetClient.UpdateLbmGroupReq updateLbmGroup1)
        {
            return axlPortClient67.updateLbmGroup(updateLbmGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLbmGroupResponse> updateLbmGroupAsync(AxlNetClient.UpdateLbmGroupReq updateLbmGroup)
        {
            return axlPortClient67.updateLbmGroupAsync(updateLbmGroup);
        }

        public AxlNetClient.GetLbmGroupRes getLbmGroup(AxlNetClient.GetLbmGroupReq getLbmGroup1)
        {
            return axlPortClient67.getLbmGroup(getLbmGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLbmGroupResponse> getLbmGroupAsync(AxlNetClient.GetLbmGroupReq getLbmGroup)
        {
            return axlPortClient67.getLbmGroupAsync(getLbmGroup);
        }

        public AxlNetClient.StandardResponse removeLbmGroup(AxlNetClient.NameAndGUIDRequest removeLbmGroup1)
        {
            return axlPortClient67.removeLbmGroup(removeLbmGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLbmGroupResponse> removeLbmGroupAsync(AxlNetClient.NameAndGUIDRequest removeLbmGroup)
        {
            return axlPortClient67.removeLbmGroupAsync(removeLbmGroup);
        }

        public AxlNetClient.ListLbmGroupRes listLbmGroup(AxlNetClient.ListLbmGroupReq listLbmGroup1)
        {
            return axlPortClient67.listLbmGroup(listLbmGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLbmGroupResponse> listLbmGroupAsync(AxlNetClient.ListLbmGroupReq listLbmGroup)
        {
            return axlPortClient67.listLbmGroupAsync(listLbmGroup);
        }

        public AxlNetClient.StandardResponse addAnnouncement(AxlNetClient.AddAnnouncementReq addAnnouncement1)
        {
            return axlPortClient67.addAnnouncement(addAnnouncement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAnnouncementResponse> addAnnouncementAsync(AxlNetClient.AddAnnouncementReq addAnnouncement)
        {
            return axlPortClient67.addAnnouncementAsync(addAnnouncement);
        }

        public AxlNetClient.StandardResponse updateAnnouncement(AxlNetClient.UpdateAnnouncementReq updateAnnouncement1)
        {
            return axlPortClient67.updateAnnouncement(updateAnnouncement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAnnouncementResponse> updateAnnouncementAsync(AxlNetClient.UpdateAnnouncementReq updateAnnouncement)
        {
            return axlPortClient67.updateAnnouncementAsync(updateAnnouncement);
        }

        public AxlNetClient.GetAnnouncementRes getAnnouncement(AxlNetClient.GetAnnouncementReq getAnnouncement1)
        {
            return axlPortClient67.getAnnouncement(getAnnouncement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAnnouncementResponse> getAnnouncementAsync(AxlNetClient.GetAnnouncementReq getAnnouncement)
        {
            return axlPortClient67.getAnnouncementAsync(getAnnouncement);
        }

        public AxlNetClient.StandardResponse removeAnnouncement(AxlNetClient.NameAndGUIDRequest removeAnnouncement1)
        {
            return axlPortClient67.removeAnnouncement(removeAnnouncement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAnnouncementResponse> removeAnnouncementAsync(AxlNetClient.NameAndGUIDRequest removeAnnouncement)
        {
            return axlPortClient67.removeAnnouncementAsync(removeAnnouncement);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort67
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewaySccpEndpoints", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewaySccpEndpointsResponse removeGatewaySccpEndpoints(AxlNetClient.removeGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewaySccpEndpoints", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewaySccpEndpointsResponse> removeGatewaySccpEndpointsAsync(AxlNetClient.removeGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addBillingServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addBillingServerResponse addBillingServer(AxlNetClient.addBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addBillingServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addBillingServerResponse> addBillingServerAsync(AxlNetClient.addBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listBillingServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listBillingServerResponse listBillingServer(AxlNetClient.listBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listBillingServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listBillingServerResponse> listBillingServerAsync(AxlNetClient.listBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLbmGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLbmGroupResponse addLbmGroup(AxlNetClient.addLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLbmGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLbmGroupResponse> addLbmGroupAsync(AxlNetClient.addLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLbmGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLbmGroupResponse updateLbmGroup(AxlNetClient.updateLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLbmGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLbmGroupResponse> updateLbmGroupAsync(AxlNetClient.updateLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLbmGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLbmGroupResponse getLbmGroup(AxlNetClient.getLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLbmGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLbmGroupResponse> getLbmGroupAsync(AxlNetClient.getLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLbmGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLbmGroupResponse removeLbmGroup(AxlNetClient.removeLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLbmGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLbmGroupResponse> removeLbmGroupAsync(AxlNetClient.removeLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLbmGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLbmGroupResponse listLbmGroup(AxlNetClient.listLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLbmGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLbmGroupResponse> listLbmGroupAsync(AxlNetClient.listLbmGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAnnouncement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAnnouncementResponse addAnnouncement(AxlNetClient.addAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAnnouncement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAnnouncementResponse> addAnnouncementAsync(AxlNetClient.addAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAnnouncement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAnnouncementResponse updateAnnouncement(AxlNetClient.updateAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAnnouncement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAnnouncementResponse> updateAnnouncementAsync(AxlNetClient.updateAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAnnouncement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAnnouncementResponse getAnnouncement(AxlNetClient.getAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAnnouncement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAnnouncementResponse> getAnnouncementAsync(AxlNetClient.getAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAnnouncement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAnnouncementResponse removeAnnouncement(AxlNetClient.removeAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAnnouncement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAnnouncementResponse> removeAnnouncementAsync(AxlNetClient.removeAnnouncementRequest request);
    }

    public class AXLPortClient67 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort67>, AxlNetClient.AXLPort67
    {
        public AXLPortClient67(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewaySccpEndpointsResponse AxlNetClient.AXLPort67.removeGatewaySccpEndpoints(AxlNetClient.removeGatewaySccpEndpointsRequest request)
        {
            return base.Channel.removeGatewaySccpEndpoints(request);
        }

        public AxlNetClient.StandardResponse removeGatewaySccpEndpoints(AxlNetClient.NameAndGUIDRequest removeGatewaySccpEndpoints1)
        {
            AxlNetClient.removeGatewaySccpEndpointsRequest inValue = new AxlNetClient.removeGatewaySccpEndpointsRequest();
            inValue.removeGatewaySccpEndpoints = removeGatewaySccpEndpoints1;
            AxlNetClient.removeGatewaySccpEndpointsResponse retVal = ((AxlNetClient.AXLPort67)(this)).removeGatewaySccpEndpoints(inValue);
            return retVal.removeGatewaySccpEndpointsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewaySccpEndpointsResponse> AxlNetClient.AXLPort67.removeGatewaySccpEndpointsAsync(AxlNetClient.removeGatewaySccpEndpointsRequest request)
        {
            return base.Channel.removeGatewaySccpEndpointsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewaySccpEndpointsResponse> removeGatewaySccpEndpointsAsync(AxlNetClient.NameAndGUIDRequest removeGatewaySccpEndpoints)
        {
            AxlNetClient.removeGatewaySccpEndpointsRequest inValue = new AxlNetClient.removeGatewaySccpEndpointsRequest();
            inValue.removeGatewaySccpEndpoints = removeGatewaySccpEndpoints;
            return ((AxlNetClient.AXLPort67)(this)).removeGatewaySccpEndpointsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addBillingServerResponse AxlNetClient.AXLPort67.addBillingServer(AxlNetClient.addBillingServerRequest request)
        {
            return base.Channel.addBillingServer(request);
        }

        public AxlNetClient.StandardResponse addBillingServer(AxlNetClient.AddBillingServerReq addBillingServer1)
        {
            AxlNetClient.addBillingServerRequest inValue = new AxlNetClient.addBillingServerRequest();
            inValue.addBillingServer = addBillingServer1;
            AxlNetClient.addBillingServerResponse retVal = ((AxlNetClient.AXLPort67)(this)).addBillingServer(inValue);
            return retVal.addBillingServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addBillingServerResponse> AxlNetClient.AXLPort67.addBillingServerAsync(AxlNetClient.addBillingServerRequest request)
        {
            return base.Channel.addBillingServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addBillingServerResponse> addBillingServerAsync(AxlNetClient.AddBillingServerReq addBillingServer)
        {
            AxlNetClient.addBillingServerRequest inValue = new AxlNetClient.addBillingServerRequest();
            inValue.addBillingServer = addBillingServer;
            return ((AxlNetClient.AXLPort67)(this)).addBillingServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listBillingServerResponse AxlNetClient.AXLPort67.listBillingServer(AxlNetClient.listBillingServerRequest request)
        {
            return base.Channel.listBillingServer(request);
        }

        public AxlNetClient.ListBillingServerRes listBillingServer(AxlNetClient.ListBillingServerReq listBillingServer1)
        {
            AxlNetClient.listBillingServerRequest inValue = new AxlNetClient.listBillingServerRequest();
            inValue.listBillingServer = listBillingServer1;
            AxlNetClient.listBillingServerResponse retVal = ((AxlNetClient.AXLPort67)(this)).listBillingServer(inValue);
            return retVal.listBillingServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listBillingServerResponse> AxlNetClient.AXLPort67.listBillingServerAsync(AxlNetClient.listBillingServerRequest request)
        {
            return base.Channel.listBillingServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listBillingServerResponse> listBillingServerAsync(AxlNetClient.ListBillingServerReq listBillingServer)
        {
            AxlNetClient.listBillingServerRequest inValue = new AxlNetClient.listBillingServerRequest();
            inValue.listBillingServer = listBillingServer;
            return ((AxlNetClient.AXLPort67)(this)).listBillingServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLbmGroupResponse AxlNetClient.AXLPort67.addLbmGroup(AxlNetClient.addLbmGroupRequest request)
        {
            return base.Channel.addLbmGroup(request);
        }

        public AxlNetClient.StandardResponse addLbmGroup(AxlNetClient.AddLbmGroupReq addLbmGroup1)
        {
            AxlNetClient.addLbmGroupRequest inValue = new AxlNetClient.addLbmGroupRequest();
            inValue.addLbmGroup = addLbmGroup1;
            AxlNetClient.addLbmGroupResponse retVal = ((AxlNetClient.AXLPort67)(this)).addLbmGroup(inValue);
            return retVal.addLbmGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLbmGroupResponse> AxlNetClient.AXLPort67.addLbmGroupAsync(AxlNetClient.addLbmGroupRequest request)
        {
            return base.Channel.addLbmGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLbmGroupResponse> addLbmGroupAsync(AxlNetClient.AddLbmGroupReq addLbmGroup)
        {
            AxlNetClient.addLbmGroupRequest inValue = new AxlNetClient.addLbmGroupRequest();
            inValue.addLbmGroup = addLbmGroup;
            return ((AxlNetClient.AXLPort67)(this)).addLbmGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLbmGroupResponse AxlNetClient.AXLPort67.updateLbmGroup(AxlNetClient.updateLbmGroupRequest request)
        {
            return base.Channel.updateLbmGroup(request);
        }

        public AxlNetClient.StandardResponse updateLbmGroup(AxlNetClient.UpdateLbmGroupReq updateLbmGroup1)
        {
            AxlNetClient.updateLbmGroupRequest inValue = new AxlNetClient.updateLbmGroupRequest();
            inValue.updateLbmGroup = updateLbmGroup1;
            AxlNetClient.updateLbmGroupResponse retVal = ((AxlNetClient.AXLPort67)(this)).updateLbmGroup(inValue);
            return retVal.updateLbmGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLbmGroupResponse> AxlNetClient.AXLPort67.updateLbmGroupAsync(AxlNetClient.updateLbmGroupRequest request)
        {
            return base.Channel.updateLbmGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLbmGroupResponse> updateLbmGroupAsync(AxlNetClient.UpdateLbmGroupReq updateLbmGroup)
        {
            AxlNetClient.updateLbmGroupRequest inValue = new AxlNetClient.updateLbmGroupRequest();
            inValue.updateLbmGroup = updateLbmGroup;
            return ((AxlNetClient.AXLPort67)(this)).updateLbmGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLbmGroupResponse AxlNetClient.AXLPort67.getLbmGroup(AxlNetClient.getLbmGroupRequest request)
        {
            return base.Channel.getLbmGroup(request);
        }

        public AxlNetClient.GetLbmGroupRes getLbmGroup(AxlNetClient.GetLbmGroupReq getLbmGroup1)
        {
            AxlNetClient.getLbmGroupRequest inValue = new AxlNetClient.getLbmGroupRequest();
            inValue.getLbmGroup = getLbmGroup1;
            AxlNetClient.getLbmGroupResponse retVal = ((AxlNetClient.AXLPort67)(this)).getLbmGroup(inValue);
            return retVal.getLbmGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLbmGroupResponse> AxlNetClient.AXLPort67.getLbmGroupAsync(AxlNetClient.getLbmGroupRequest request)
        {
            return base.Channel.getLbmGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLbmGroupResponse> getLbmGroupAsync(AxlNetClient.GetLbmGroupReq getLbmGroup)
        {
            AxlNetClient.getLbmGroupRequest inValue = new AxlNetClient.getLbmGroupRequest();
            inValue.getLbmGroup = getLbmGroup;
            return ((AxlNetClient.AXLPort67)(this)).getLbmGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLbmGroupResponse AxlNetClient.AXLPort67.removeLbmGroup(AxlNetClient.removeLbmGroupRequest request)
        {
            return base.Channel.removeLbmGroup(request);
        }

        public AxlNetClient.StandardResponse removeLbmGroup(AxlNetClient.NameAndGUIDRequest removeLbmGroup1)
        {
            AxlNetClient.removeLbmGroupRequest inValue = new AxlNetClient.removeLbmGroupRequest();
            inValue.removeLbmGroup = removeLbmGroup1;
            AxlNetClient.removeLbmGroupResponse retVal = ((AxlNetClient.AXLPort67)(this)).removeLbmGroup(inValue);
            return retVal.removeLbmGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLbmGroupResponse> AxlNetClient.AXLPort67.removeLbmGroupAsync(AxlNetClient.removeLbmGroupRequest request)
        {
            return base.Channel.removeLbmGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLbmGroupResponse> removeLbmGroupAsync(AxlNetClient.NameAndGUIDRequest removeLbmGroup)
        {
            AxlNetClient.removeLbmGroupRequest inValue = new AxlNetClient.removeLbmGroupRequest();
            inValue.removeLbmGroup = removeLbmGroup;
            return ((AxlNetClient.AXLPort67)(this)).removeLbmGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLbmGroupResponse AxlNetClient.AXLPort67.listLbmGroup(AxlNetClient.listLbmGroupRequest request)
        {
            return base.Channel.listLbmGroup(request);
        }

        public AxlNetClient.ListLbmGroupRes listLbmGroup(AxlNetClient.ListLbmGroupReq listLbmGroup1)
        {
            AxlNetClient.listLbmGroupRequest inValue = new AxlNetClient.listLbmGroupRequest();
            inValue.listLbmGroup = listLbmGroup1;
            AxlNetClient.listLbmGroupResponse retVal = ((AxlNetClient.AXLPort67)(this)).listLbmGroup(inValue);
            return retVal.listLbmGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLbmGroupResponse> AxlNetClient.AXLPort67.listLbmGroupAsync(AxlNetClient.listLbmGroupRequest request)
        {
            return base.Channel.listLbmGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLbmGroupResponse> listLbmGroupAsync(AxlNetClient.ListLbmGroupReq listLbmGroup)
        {
            AxlNetClient.listLbmGroupRequest inValue = new AxlNetClient.listLbmGroupRequest();
            inValue.listLbmGroup = listLbmGroup;
            return ((AxlNetClient.AXLPort67)(this)).listLbmGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAnnouncementResponse AxlNetClient.AXLPort67.addAnnouncement(AxlNetClient.addAnnouncementRequest request)
        {
            return base.Channel.addAnnouncement(request);
        }

        public AxlNetClient.StandardResponse addAnnouncement(AxlNetClient.AddAnnouncementReq addAnnouncement1)
        {
            AxlNetClient.addAnnouncementRequest inValue = new AxlNetClient.addAnnouncementRequest();
            inValue.addAnnouncement = addAnnouncement1;
            AxlNetClient.addAnnouncementResponse retVal = ((AxlNetClient.AXLPort67)(this)).addAnnouncement(inValue);
            return retVal.addAnnouncementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAnnouncementResponse> AxlNetClient.AXLPort67.addAnnouncementAsync(AxlNetClient.addAnnouncementRequest request)
        {
            return base.Channel.addAnnouncementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAnnouncementResponse> addAnnouncementAsync(AxlNetClient.AddAnnouncementReq addAnnouncement)
        {
            AxlNetClient.addAnnouncementRequest inValue = new AxlNetClient.addAnnouncementRequest();
            inValue.addAnnouncement = addAnnouncement;
            return ((AxlNetClient.AXLPort67)(this)).addAnnouncementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAnnouncementResponse AxlNetClient.AXLPort67.updateAnnouncement(AxlNetClient.updateAnnouncementRequest request)
        {
            return base.Channel.updateAnnouncement(request);
        }

        public AxlNetClient.StandardResponse updateAnnouncement(AxlNetClient.UpdateAnnouncementReq updateAnnouncement1)
        {
            AxlNetClient.updateAnnouncementRequest inValue = new AxlNetClient.updateAnnouncementRequest();
            inValue.updateAnnouncement = updateAnnouncement1;
            AxlNetClient.updateAnnouncementResponse retVal = ((AxlNetClient.AXLPort67)(this)).updateAnnouncement(inValue);
            return retVal.updateAnnouncementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAnnouncementResponse> AxlNetClient.AXLPort67.updateAnnouncementAsync(AxlNetClient.updateAnnouncementRequest request)
        {
            return base.Channel.updateAnnouncementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAnnouncementResponse> updateAnnouncementAsync(AxlNetClient.UpdateAnnouncementReq updateAnnouncement)
        {
            AxlNetClient.updateAnnouncementRequest inValue = new AxlNetClient.updateAnnouncementRequest();
            inValue.updateAnnouncement = updateAnnouncement;
            return ((AxlNetClient.AXLPort67)(this)).updateAnnouncementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAnnouncementResponse AxlNetClient.AXLPort67.getAnnouncement(AxlNetClient.getAnnouncementRequest request)
        {
            return base.Channel.getAnnouncement(request);
        }

        public AxlNetClient.GetAnnouncementRes getAnnouncement(AxlNetClient.GetAnnouncementReq getAnnouncement1)
        {
            AxlNetClient.getAnnouncementRequest inValue = new AxlNetClient.getAnnouncementRequest();
            inValue.getAnnouncement = getAnnouncement1;
            AxlNetClient.getAnnouncementResponse retVal = ((AxlNetClient.AXLPort67)(this)).getAnnouncement(inValue);
            return retVal.getAnnouncementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAnnouncementResponse> AxlNetClient.AXLPort67.getAnnouncementAsync(AxlNetClient.getAnnouncementRequest request)
        {
            return base.Channel.getAnnouncementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAnnouncementResponse> getAnnouncementAsync(AxlNetClient.GetAnnouncementReq getAnnouncement)
        {
            AxlNetClient.getAnnouncementRequest inValue = new AxlNetClient.getAnnouncementRequest();
            inValue.getAnnouncement = getAnnouncement;
            return ((AxlNetClient.AXLPort67)(this)).getAnnouncementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAnnouncementResponse AxlNetClient.AXLPort67.removeAnnouncement(AxlNetClient.removeAnnouncementRequest request)
        {
            return base.Channel.removeAnnouncement(request);
        }

        public AxlNetClient.StandardResponse removeAnnouncement(AxlNetClient.NameAndGUIDRequest removeAnnouncement1)
        {
            AxlNetClient.removeAnnouncementRequest inValue = new AxlNetClient.removeAnnouncementRequest();
            inValue.removeAnnouncement = removeAnnouncement1;
            AxlNetClient.removeAnnouncementResponse retVal = ((AxlNetClient.AXLPort67)(this)).removeAnnouncement(inValue);
            return retVal.removeAnnouncementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAnnouncementResponse> AxlNetClient.AXLPort67.removeAnnouncementAsync(AxlNetClient.removeAnnouncementRequest request)
        {
            return base.Channel.removeAnnouncementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAnnouncementResponse> removeAnnouncementAsync(AxlNetClient.NameAndGUIDRequest removeAnnouncement)
        {
            AxlNetClient.removeAnnouncementRequest inValue = new AxlNetClient.removeAnnouncementRequest();
            inValue.removeAnnouncement = removeAnnouncement;
            return ((AxlNetClient.AXLPort67)(this)).removeAnnouncementAsync(inValue);
        }
    }
}