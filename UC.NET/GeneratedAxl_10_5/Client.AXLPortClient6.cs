namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient6 _axlPortClient6;

        private static AXLPortClient6 axlPortClient6 => _axlPortClient6 == null ||
            _axlPortClient6.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient6 = LoadClient6()) : _axlPortClient6;

        private static AXLPortClient6 LoadClient6()
        {
            var client = new AXLPortClient6(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close6;
            OnAbort += Abort6;
            return client;
        }

        private static void Close6(object sender, System.EventArgs e)
        {
            _axlPortClient6.Close();
        }

        private static void Abort6(object sender, System.EventArgs e)
        {
            _axlPortClient6.Abort();
        }

        public AxlNetClient.StandardResponse resetCallManager(AxlNetClient.NameAndGUIDRequest resetCallManager1)
        {
            return axlPortClient6.resetCallManager(resetCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCallManagerResponse> resetCallManagerAsync(AxlNetClient.NameAndGUIDRequest resetCallManager)
        {
            return axlPortClient6.resetCallManagerAsync(resetCallManager);
        }

        public AxlNetClient.StandardResponse restartCallManager(AxlNetClient.NameAndGUIDRequest restartCallManager1)
        {
            return axlPortClient6.restartCallManager(restartCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCallManagerResponse> restartCallManagerAsync(AxlNetClient.NameAndGUIDRequest restartCallManager)
        {
            return axlPortClient6.restartCallManagerAsync(restartCallManager);
        }

        public AxlNetClient.StandardResponse applyCallManager(AxlNetClient.NameAndGUIDRequest applyCallManager1)
        {
            return axlPortClient6.applyCallManager(applyCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCallManagerResponse> applyCallManagerAsync(AxlNetClient.NameAndGUIDRequest applyCallManager)
        {
            return axlPortClient6.applyCallManagerAsync(applyCallManager);
        }

        public AxlNetClient.StandardResponse addMediaResourceGroup(AxlNetClient.AddMediaResourceGroupReq addMediaResourceGroup1)
        {
            return axlPortClient6.addMediaResourceGroup(addMediaResourceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMediaResourceGroupResponse> addMediaResourceGroupAsync(AxlNetClient.AddMediaResourceGroupReq addMediaResourceGroup)
        {
            return axlPortClient6.addMediaResourceGroupAsync(addMediaResourceGroup);
        }

        public AxlNetClient.StandardResponse updateMediaResourceGroup(AxlNetClient.UpdateMediaResourceGroupReq updateMediaResourceGroup1)
        {
            return axlPortClient6.updateMediaResourceGroup(updateMediaResourceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceGroupResponse> updateMediaResourceGroupAsync(AxlNetClient.UpdateMediaResourceGroupReq updateMediaResourceGroup)
        {
            return axlPortClient6.updateMediaResourceGroupAsync(updateMediaResourceGroup);
        }

        public AxlNetClient.GetMediaResourceGroupRes getMediaResourceGroup(AxlNetClient.GetMediaResourceGroupReq getMediaResourceGroup1)
        {
            return axlPortClient6.getMediaResourceGroup(getMediaResourceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMediaResourceGroupResponse> getMediaResourceGroupAsync(AxlNetClient.GetMediaResourceGroupReq getMediaResourceGroup)
        {
            return axlPortClient6.getMediaResourceGroupAsync(getMediaResourceGroup);
        }

        public AxlNetClient.StandardResponse removeMediaResourceGroup(AxlNetClient.NameAndGUIDRequest removeMediaResourceGroup1)
        {
            return axlPortClient6.removeMediaResourceGroup(removeMediaResourceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceGroupResponse> removeMediaResourceGroupAsync(AxlNetClient.NameAndGUIDRequest removeMediaResourceGroup)
        {
            return axlPortClient6.removeMediaResourceGroupAsync(removeMediaResourceGroup);
        }

        public AxlNetClient.ListMediaResourceGroupRes listMediaResourceGroup(AxlNetClient.ListMediaResourceGroupReq listMediaResourceGroup1)
        {
            return axlPortClient6.listMediaResourceGroup(listMediaResourceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMediaResourceGroupResponse> listMediaResourceGroupAsync(AxlNetClient.ListMediaResourceGroupReq listMediaResourceGroup)
        {
            return axlPortClient6.listMediaResourceGroupAsync(listMediaResourceGroup);
        }

        public AxlNetClient.StandardResponse addMediaResourceList(AxlNetClient.AddMediaResourceListReq addMediaResourceList1)
        {
            return axlPortClient6.addMediaResourceList(addMediaResourceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMediaResourceListResponse> addMediaResourceListAsync(AxlNetClient.AddMediaResourceListReq addMediaResourceList)
        {
            return axlPortClient6.addMediaResourceListAsync(addMediaResourceList);
        }

        public AxlNetClient.StandardResponse updateMediaResourceList(AxlNetClient.UpdateMediaResourceListReq updateMediaResourceList1)
        {
            return axlPortClient6.updateMediaResourceList(updateMediaResourceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceListResponse> updateMediaResourceListAsync(AxlNetClient.UpdateMediaResourceListReq updateMediaResourceList)
        {
            return axlPortClient6.updateMediaResourceListAsync(updateMediaResourceList);
        }

        public AxlNetClient.GetMediaResourceListRes getMediaResourceList(AxlNetClient.GetMediaResourceListReq getMediaResourceList1)
        {
            return axlPortClient6.getMediaResourceList(getMediaResourceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMediaResourceListResponse> getMediaResourceListAsync(AxlNetClient.GetMediaResourceListReq getMediaResourceList)
        {
            return axlPortClient6.getMediaResourceListAsync(getMediaResourceList);
        }

        public AxlNetClient.StandardResponse removeMediaResourceList(AxlNetClient.NameAndGUIDRequest removeMediaResourceList1)
        {
            return axlPortClient6.removeMediaResourceList(removeMediaResourceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceListResponse> removeMediaResourceListAsync(AxlNetClient.NameAndGUIDRequest removeMediaResourceList)
        {
            return axlPortClient6.removeMediaResourceListAsync(removeMediaResourceList);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort6
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCallManagerResponse resetCallManager(AxlNetClient.resetCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCallManagerResponse> resetCallManagerAsync(AxlNetClient.resetCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCallManagerResponse restartCallManager(AxlNetClient.restartCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCallManagerResponse> restartCallManagerAsync(AxlNetClient.restartCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCallManagerResponse applyCallManager(AxlNetClient.applyCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCallManagerResponse> applyCallManagerAsync(AxlNetClient.applyCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMediaResourceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMediaResourceGroupResponse addMediaResourceGroup(AxlNetClient.addMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMediaResourceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMediaResourceGroupResponse> addMediaResourceGroupAsync(AxlNetClient.addMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMediaResourceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMediaResourceGroupResponse updateMediaResourceGroup(AxlNetClient.updateMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMediaResourceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceGroupResponse> updateMediaResourceGroupAsync(AxlNetClient.updateMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMediaResourceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMediaResourceGroupResponse getMediaResourceGroup(AxlNetClient.getMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMediaResourceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMediaResourceGroupResponse> getMediaResourceGroupAsync(AxlNetClient.getMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMediaResourceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMediaResourceGroupResponse removeMediaResourceGroup(AxlNetClient.removeMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMediaResourceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceGroupResponse> removeMediaResourceGroupAsync(AxlNetClient.removeMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMediaResourceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMediaResourceGroupResponse listMediaResourceGroup(AxlNetClient.listMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMediaResourceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMediaResourceGroupResponse> listMediaResourceGroupAsync(AxlNetClient.listMediaResourceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMediaResourceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMediaResourceListResponse addMediaResourceList(AxlNetClient.addMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMediaResourceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMediaResourceListResponse> addMediaResourceListAsync(AxlNetClient.addMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMediaResourceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMediaResourceListResponse updateMediaResourceList(AxlNetClient.updateMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMediaResourceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceListResponse> updateMediaResourceListAsync(AxlNetClient.updateMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMediaResourceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMediaResourceListResponse getMediaResourceList(AxlNetClient.getMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMediaResourceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMediaResourceListResponse> getMediaResourceListAsync(AxlNetClient.getMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMediaResourceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMediaResourceListResponse removeMediaResourceList(AxlNetClient.removeMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMediaResourceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceListResponse> removeMediaResourceListAsync(AxlNetClient.removeMediaResourceListRequest request);
    }

    public class AXLPortClient6 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort6>, AxlNetClient.AXLPort6
    {
        public AXLPortClient6(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCallManagerResponse AxlNetClient.AXLPort6.resetCallManager(AxlNetClient.resetCallManagerRequest request)
        {
            return base.Channel.resetCallManager(request);
        }

        public AxlNetClient.StandardResponse resetCallManager(AxlNetClient.NameAndGUIDRequest resetCallManager1)
        {
            AxlNetClient.resetCallManagerRequest inValue = new AxlNetClient.resetCallManagerRequest();
            inValue.resetCallManager = resetCallManager1;
            AxlNetClient.resetCallManagerResponse retVal = ((AxlNetClient.AXLPort6)(this)).resetCallManager(inValue);
            return retVal.resetCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCallManagerResponse> AxlNetClient.AXLPort6.resetCallManagerAsync(AxlNetClient.resetCallManagerRequest request)
        {
            return base.Channel.resetCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCallManagerResponse> resetCallManagerAsync(AxlNetClient.NameAndGUIDRequest resetCallManager)
        {
            AxlNetClient.resetCallManagerRequest inValue = new AxlNetClient.resetCallManagerRequest();
            inValue.resetCallManager = resetCallManager;
            return ((AxlNetClient.AXLPort6)(this)).resetCallManagerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCallManagerResponse AxlNetClient.AXLPort6.restartCallManager(AxlNetClient.restartCallManagerRequest request)
        {
            return base.Channel.restartCallManager(request);
        }

        public AxlNetClient.StandardResponse restartCallManager(AxlNetClient.NameAndGUIDRequest restartCallManager1)
        {
            AxlNetClient.restartCallManagerRequest inValue = new AxlNetClient.restartCallManagerRequest();
            inValue.restartCallManager = restartCallManager1;
            AxlNetClient.restartCallManagerResponse retVal = ((AxlNetClient.AXLPort6)(this)).restartCallManager(inValue);
            return retVal.restartCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCallManagerResponse> AxlNetClient.AXLPort6.restartCallManagerAsync(AxlNetClient.restartCallManagerRequest request)
        {
            return base.Channel.restartCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCallManagerResponse> restartCallManagerAsync(AxlNetClient.NameAndGUIDRequest restartCallManager)
        {
            AxlNetClient.restartCallManagerRequest inValue = new AxlNetClient.restartCallManagerRequest();
            inValue.restartCallManager = restartCallManager;
            return ((AxlNetClient.AXLPort6)(this)).restartCallManagerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCallManagerResponse AxlNetClient.AXLPort6.applyCallManager(AxlNetClient.applyCallManagerRequest request)
        {
            return base.Channel.applyCallManager(request);
        }

        public AxlNetClient.StandardResponse applyCallManager(AxlNetClient.NameAndGUIDRequest applyCallManager1)
        {
            AxlNetClient.applyCallManagerRequest inValue = new AxlNetClient.applyCallManagerRequest();
            inValue.applyCallManager = applyCallManager1;
            AxlNetClient.applyCallManagerResponse retVal = ((AxlNetClient.AXLPort6)(this)).applyCallManager(inValue);
            return retVal.applyCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCallManagerResponse> AxlNetClient.AXLPort6.applyCallManagerAsync(AxlNetClient.applyCallManagerRequest request)
        {
            return base.Channel.applyCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCallManagerResponse> applyCallManagerAsync(AxlNetClient.NameAndGUIDRequest applyCallManager)
        {
            AxlNetClient.applyCallManagerRequest inValue = new AxlNetClient.applyCallManagerRequest();
            inValue.applyCallManager = applyCallManager;
            return ((AxlNetClient.AXLPort6)(this)).applyCallManagerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMediaResourceGroupResponse AxlNetClient.AXLPort6.addMediaResourceGroup(AxlNetClient.addMediaResourceGroupRequest request)
        {
            return base.Channel.addMediaResourceGroup(request);
        }

        public AxlNetClient.StandardResponse addMediaResourceGroup(AxlNetClient.AddMediaResourceGroupReq addMediaResourceGroup1)
        {
            AxlNetClient.addMediaResourceGroupRequest inValue = new AxlNetClient.addMediaResourceGroupRequest();
            inValue.addMediaResourceGroup = addMediaResourceGroup1;
            AxlNetClient.addMediaResourceGroupResponse retVal = ((AxlNetClient.AXLPort6)(this)).addMediaResourceGroup(inValue);
            return retVal.addMediaResourceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMediaResourceGroupResponse> AxlNetClient.AXLPort6.addMediaResourceGroupAsync(AxlNetClient.addMediaResourceGroupRequest request)
        {
            return base.Channel.addMediaResourceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMediaResourceGroupResponse> addMediaResourceGroupAsync(AxlNetClient.AddMediaResourceGroupReq addMediaResourceGroup)
        {
            AxlNetClient.addMediaResourceGroupRequest inValue = new AxlNetClient.addMediaResourceGroupRequest();
            inValue.addMediaResourceGroup = addMediaResourceGroup;
            return ((AxlNetClient.AXLPort6)(this)).addMediaResourceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMediaResourceGroupResponse AxlNetClient.AXLPort6.updateMediaResourceGroup(AxlNetClient.updateMediaResourceGroupRequest request)
        {
            return base.Channel.updateMediaResourceGroup(request);
        }

        public AxlNetClient.StandardResponse updateMediaResourceGroup(AxlNetClient.UpdateMediaResourceGroupReq updateMediaResourceGroup1)
        {
            AxlNetClient.updateMediaResourceGroupRequest inValue = new AxlNetClient.updateMediaResourceGroupRequest();
            inValue.updateMediaResourceGroup = updateMediaResourceGroup1;
            AxlNetClient.updateMediaResourceGroupResponse retVal = ((AxlNetClient.AXLPort6)(this)).updateMediaResourceGroup(inValue);
            return retVal.updateMediaResourceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceGroupResponse> AxlNetClient.AXLPort6.updateMediaResourceGroupAsync(AxlNetClient.updateMediaResourceGroupRequest request)
        {
            return base.Channel.updateMediaResourceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceGroupResponse> updateMediaResourceGroupAsync(AxlNetClient.UpdateMediaResourceGroupReq updateMediaResourceGroup)
        {
            AxlNetClient.updateMediaResourceGroupRequest inValue = new AxlNetClient.updateMediaResourceGroupRequest();
            inValue.updateMediaResourceGroup = updateMediaResourceGroup;
            return ((AxlNetClient.AXLPort6)(this)).updateMediaResourceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMediaResourceGroupResponse AxlNetClient.AXLPort6.getMediaResourceGroup(AxlNetClient.getMediaResourceGroupRequest request)
        {
            return base.Channel.getMediaResourceGroup(request);
        }

        public AxlNetClient.GetMediaResourceGroupRes getMediaResourceGroup(AxlNetClient.GetMediaResourceGroupReq getMediaResourceGroup1)
        {
            AxlNetClient.getMediaResourceGroupRequest inValue = new AxlNetClient.getMediaResourceGroupRequest();
            inValue.getMediaResourceGroup = getMediaResourceGroup1;
            AxlNetClient.getMediaResourceGroupResponse retVal = ((AxlNetClient.AXLPort6)(this)).getMediaResourceGroup(inValue);
            return retVal.getMediaResourceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMediaResourceGroupResponse> AxlNetClient.AXLPort6.getMediaResourceGroupAsync(AxlNetClient.getMediaResourceGroupRequest request)
        {
            return base.Channel.getMediaResourceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMediaResourceGroupResponse> getMediaResourceGroupAsync(AxlNetClient.GetMediaResourceGroupReq getMediaResourceGroup)
        {
            AxlNetClient.getMediaResourceGroupRequest inValue = new AxlNetClient.getMediaResourceGroupRequest();
            inValue.getMediaResourceGroup = getMediaResourceGroup;
            return ((AxlNetClient.AXLPort6)(this)).getMediaResourceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMediaResourceGroupResponse AxlNetClient.AXLPort6.removeMediaResourceGroup(AxlNetClient.removeMediaResourceGroupRequest request)
        {
            return base.Channel.removeMediaResourceGroup(request);
        }

        public AxlNetClient.StandardResponse removeMediaResourceGroup(AxlNetClient.NameAndGUIDRequest removeMediaResourceGroup1)
        {
            AxlNetClient.removeMediaResourceGroupRequest inValue = new AxlNetClient.removeMediaResourceGroupRequest();
            inValue.removeMediaResourceGroup = removeMediaResourceGroup1;
            AxlNetClient.removeMediaResourceGroupResponse retVal = ((AxlNetClient.AXLPort6)(this)).removeMediaResourceGroup(inValue);
            return retVal.removeMediaResourceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceGroupResponse> AxlNetClient.AXLPort6.removeMediaResourceGroupAsync(AxlNetClient.removeMediaResourceGroupRequest request)
        {
            return base.Channel.removeMediaResourceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceGroupResponse> removeMediaResourceGroupAsync(AxlNetClient.NameAndGUIDRequest removeMediaResourceGroup)
        {
            AxlNetClient.removeMediaResourceGroupRequest inValue = new AxlNetClient.removeMediaResourceGroupRequest();
            inValue.removeMediaResourceGroup = removeMediaResourceGroup;
            return ((AxlNetClient.AXLPort6)(this)).removeMediaResourceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMediaResourceGroupResponse AxlNetClient.AXLPort6.listMediaResourceGroup(AxlNetClient.listMediaResourceGroupRequest request)
        {
            return base.Channel.listMediaResourceGroup(request);
        }

        public AxlNetClient.ListMediaResourceGroupRes listMediaResourceGroup(AxlNetClient.ListMediaResourceGroupReq listMediaResourceGroup1)
        {
            AxlNetClient.listMediaResourceGroupRequest inValue = new AxlNetClient.listMediaResourceGroupRequest();
            inValue.listMediaResourceGroup = listMediaResourceGroup1;
            AxlNetClient.listMediaResourceGroupResponse retVal = ((AxlNetClient.AXLPort6)(this)).listMediaResourceGroup(inValue);
            return retVal.listMediaResourceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMediaResourceGroupResponse> AxlNetClient.AXLPort6.listMediaResourceGroupAsync(AxlNetClient.listMediaResourceGroupRequest request)
        {
            return base.Channel.listMediaResourceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMediaResourceGroupResponse> listMediaResourceGroupAsync(AxlNetClient.ListMediaResourceGroupReq listMediaResourceGroup)
        {
            AxlNetClient.listMediaResourceGroupRequest inValue = new AxlNetClient.listMediaResourceGroupRequest();
            inValue.listMediaResourceGroup = listMediaResourceGroup;
            return ((AxlNetClient.AXLPort6)(this)).listMediaResourceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMediaResourceListResponse AxlNetClient.AXLPort6.addMediaResourceList(AxlNetClient.addMediaResourceListRequest request)
        {
            return base.Channel.addMediaResourceList(request);
        }

        public AxlNetClient.StandardResponse addMediaResourceList(AxlNetClient.AddMediaResourceListReq addMediaResourceList1)
        {
            AxlNetClient.addMediaResourceListRequest inValue = new AxlNetClient.addMediaResourceListRequest();
            inValue.addMediaResourceList = addMediaResourceList1;
            AxlNetClient.addMediaResourceListResponse retVal = ((AxlNetClient.AXLPort6)(this)).addMediaResourceList(inValue);
            return retVal.addMediaResourceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMediaResourceListResponse> AxlNetClient.AXLPort6.addMediaResourceListAsync(AxlNetClient.addMediaResourceListRequest request)
        {
            return base.Channel.addMediaResourceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMediaResourceListResponse> addMediaResourceListAsync(AxlNetClient.AddMediaResourceListReq addMediaResourceList)
        {
            AxlNetClient.addMediaResourceListRequest inValue = new AxlNetClient.addMediaResourceListRequest();
            inValue.addMediaResourceList = addMediaResourceList;
            return ((AxlNetClient.AXLPort6)(this)).addMediaResourceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMediaResourceListResponse AxlNetClient.AXLPort6.updateMediaResourceList(AxlNetClient.updateMediaResourceListRequest request)
        {
            return base.Channel.updateMediaResourceList(request);
        }

        public AxlNetClient.StandardResponse updateMediaResourceList(AxlNetClient.UpdateMediaResourceListReq updateMediaResourceList1)
        {
            AxlNetClient.updateMediaResourceListRequest inValue = new AxlNetClient.updateMediaResourceListRequest();
            inValue.updateMediaResourceList = updateMediaResourceList1;
            AxlNetClient.updateMediaResourceListResponse retVal = ((AxlNetClient.AXLPort6)(this)).updateMediaResourceList(inValue);
            return retVal.updateMediaResourceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceListResponse> AxlNetClient.AXLPort6.updateMediaResourceListAsync(AxlNetClient.updateMediaResourceListRequest request)
        {
            return base.Channel.updateMediaResourceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMediaResourceListResponse> updateMediaResourceListAsync(AxlNetClient.UpdateMediaResourceListReq updateMediaResourceList)
        {
            AxlNetClient.updateMediaResourceListRequest inValue = new AxlNetClient.updateMediaResourceListRequest();
            inValue.updateMediaResourceList = updateMediaResourceList;
            return ((AxlNetClient.AXLPort6)(this)).updateMediaResourceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMediaResourceListResponse AxlNetClient.AXLPort6.getMediaResourceList(AxlNetClient.getMediaResourceListRequest request)
        {
            return base.Channel.getMediaResourceList(request);
        }

        public AxlNetClient.GetMediaResourceListRes getMediaResourceList(AxlNetClient.GetMediaResourceListReq getMediaResourceList1)
        {
            AxlNetClient.getMediaResourceListRequest inValue = new AxlNetClient.getMediaResourceListRequest();
            inValue.getMediaResourceList = getMediaResourceList1;
            AxlNetClient.getMediaResourceListResponse retVal = ((AxlNetClient.AXLPort6)(this)).getMediaResourceList(inValue);
            return retVal.getMediaResourceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMediaResourceListResponse> AxlNetClient.AXLPort6.getMediaResourceListAsync(AxlNetClient.getMediaResourceListRequest request)
        {
            return base.Channel.getMediaResourceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMediaResourceListResponse> getMediaResourceListAsync(AxlNetClient.GetMediaResourceListReq getMediaResourceList)
        {
            AxlNetClient.getMediaResourceListRequest inValue = new AxlNetClient.getMediaResourceListRequest();
            inValue.getMediaResourceList = getMediaResourceList;
            return ((AxlNetClient.AXLPort6)(this)).getMediaResourceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMediaResourceListResponse AxlNetClient.AXLPort6.removeMediaResourceList(AxlNetClient.removeMediaResourceListRequest request)
        {
            return base.Channel.removeMediaResourceList(request);
        }

        public AxlNetClient.StandardResponse removeMediaResourceList(AxlNetClient.NameAndGUIDRequest removeMediaResourceList1)
        {
            AxlNetClient.removeMediaResourceListRequest inValue = new AxlNetClient.removeMediaResourceListRequest();
            inValue.removeMediaResourceList = removeMediaResourceList1;
            AxlNetClient.removeMediaResourceListResponse retVal = ((AxlNetClient.AXLPort6)(this)).removeMediaResourceList(inValue);
            return retVal.removeMediaResourceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceListResponse> AxlNetClient.AXLPort6.removeMediaResourceListAsync(AxlNetClient.removeMediaResourceListRequest request)
        {
            return base.Channel.removeMediaResourceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMediaResourceListResponse> removeMediaResourceListAsync(AxlNetClient.NameAndGUIDRequest removeMediaResourceList)
        {
            AxlNetClient.removeMediaResourceListRequest inValue = new AxlNetClient.removeMediaResourceListRequest();
            inValue.removeMediaResourceList = removeMediaResourceList;
            return ((AxlNetClient.AXLPort6)(this)).removeMediaResourceListAsync(inValue);
        }
    }
}