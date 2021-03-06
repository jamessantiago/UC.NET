namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient72 _axlPortClient72;

        private static AXLPortClient72 axlPortClient72 => _axlPortClient72 == null ||
            _axlPortClient72.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient72 = LoadClient72()) : _axlPortClient72;

        private static AXLPortClient72 LoadClient72()
        {
            var client = new AXLPortClient72(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close72;
            OnAbort += Abort72;
            return client;
        }

        private static void Close72(object sender, System.EventArgs e)
        {
            _axlPortClient72.Close();
        }

        private static void Abort72(object sender, System.EventArgs e)
        {
            _axlPortClient72.Abort();
        }

        public AxlNetClient.StandardResponse removeDirNumberAliasLookupandSync(AxlNetClient.NameAndGUIDRequest removeDirNumberAliasLookupandSync1)
        {
            return axlPortClient72.removeDirNumberAliasLookupandSync(removeDirNumberAliasLookupandSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirNumberAliasLookupandSyncResponse> removeDirNumberAliasLookupandSyncAsync(AxlNetClient.NameAndGUIDRequest removeDirNumberAliasLookupandSync)
        {
            return axlPortClient72.removeDirNumberAliasLookupandSyncAsync(removeDirNumberAliasLookupandSync);
        }

        public AxlNetClient.ListDirNumberAliasLookupandSyncRes listDirNumberAliasLookupandSync(AxlNetClient.ListDirNumberAliasLookupandSyncReq listDirNumberAliasLookupandSync1)
        {
            return axlPortClient72.listDirNumberAliasLookupandSync(listDirNumberAliasLookupandSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirNumberAliasLookupandSyncResponse> listDirNumberAliasLookupandSyncAsync(AxlNetClient.ListDirNumberAliasLookupandSyncReq listDirNumberAliasLookupandSync)
        {
            return axlPortClient72.listDirNumberAliasLookupandSyncAsync(listDirNumberAliasLookupandSync);
        }

        public AxlNetClient.StandardResponse addLocalRouteGroup(AxlNetClient.AddLocalRouteGroupReq addLocalRouteGroup1)
        {
            return axlPortClient72.addLocalRouteGroup(addLocalRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLocalRouteGroupResponse> addLocalRouteGroupAsync(AxlNetClient.AddLocalRouteGroupReq addLocalRouteGroup)
        {
            return axlPortClient72.addLocalRouteGroupAsync(addLocalRouteGroup);
        }

        public AxlNetClient.GetLocalRouteGroupRes getLocalRouteGroup(AxlNetClient.GetLocalRouteGroupReq getLocalRouteGroup1)
        {
            return axlPortClient72.getLocalRouteGroup(getLocalRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLocalRouteGroupResponse> getLocalRouteGroupAsync(AxlNetClient.GetLocalRouteGroupReq getLocalRouteGroup)
        {
            return axlPortClient72.getLocalRouteGroupAsync(getLocalRouteGroup);
        }

        public AxlNetClient.ListLocalRouteGroupRes listLocalRouteGroup(AxlNetClient.ListLocalRouteGroupReq listLocalRouteGroup1)
        {
            return axlPortClient72.listLocalRouteGroup(listLocalRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLocalRouteGroupResponse> listLocalRouteGroupAsync(AxlNetClient.ListLocalRouteGroupReq listLocalRouteGroup)
        {
            return axlPortClient72.listLocalRouteGroupAsync(listLocalRouteGroup);
        }

        public AxlNetClient.StandardResponse addAdvertisedPatterns(AxlNetClient.AddAdvertisedPatternsReq addAdvertisedPatterns1)
        {
            return axlPortClient72.addAdvertisedPatterns(addAdvertisedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAdvertisedPatternsResponse> addAdvertisedPatternsAsync(AxlNetClient.AddAdvertisedPatternsReq addAdvertisedPatterns)
        {
            return axlPortClient72.addAdvertisedPatternsAsync(addAdvertisedPatterns);
        }

        public AxlNetClient.StandardResponse updateAdvertisedPatterns(AxlNetClient.UpdateAdvertisedPatternsReq updateAdvertisedPatterns1)
        {
            return axlPortClient72.updateAdvertisedPatterns(updateAdvertisedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAdvertisedPatternsResponse> updateAdvertisedPatternsAsync(AxlNetClient.UpdateAdvertisedPatternsReq updateAdvertisedPatterns)
        {
            return axlPortClient72.updateAdvertisedPatternsAsync(updateAdvertisedPatterns);
        }

        public AxlNetClient.GetAdvertisedPatternsRes getAdvertisedPatterns(AxlNetClient.GetAdvertisedPatternsReq getAdvertisedPatterns1)
        {
            return axlPortClient72.getAdvertisedPatterns(getAdvertisedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAdvertisedPatternsResponse> getAdvertisedPatternsAsync(AxlNetClient.GetAdvertisedPatternsReq getAdvertisedPatterns)
        {
            return axlPortClient72.getAdvertisedPatternsAsync(getAdvertisedPatterns);
        }

        public AxlNetClient.StandardResponse removeAdvertisedPatterns(AxlNetClient.RemoveAdvertisedPatternsReq removeAdvertisedPatterns1)
        {
            return axlPortClient72.removeAdvertisedPatterns(removeAdvertisedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAdvertisedPatternsResponse> removeAdvertisedPatternsAsync(AxlNetClient.RemoveAdvertisedPatternsReq removeAdvertisedPatterns)
        {
            return axlPortClient72.removeAdvertisedPatternsAsync(removeAdvertisedPatterns);
        }

        public AxlNetClient.ListAdvertisedPatternsRes listAdvertisedPatterns(AxlNetClient.ListAdvertisedPatternsReq listAdvertisedPatterns1)
        {
            return axlPortClient72.listAdvertisedPatterns(listAdvertisedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAdvertisedPatternsResponse> listAdvertisedPatternsAsync(AxlNetClient.ListAdvertisedPatternsReq listAdvertisedPatterns)
        {
            return axlPortClient72.listAdvertisedPatternsAsync(listAdvertisedPatterns);
        }

        public AxlNetClient.StandardResponse addBlockedLearnedPatterns(AxlNetClient.AddBlockedLearnedPatternsReq addBlockedLearnedPatterns1)
        {
            return axlPortClient72.addBlockedLearnedPatterns(addBlockedLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addBlockedLearnedPatternsResponse> addBlockedLearnedPatternsAsync(AxlNetClient.AddBlockedLearnedPatternsReq addBlockedLearnedPatterns)
        {
            return axlPortClient72.addBlockedLearnedPatternsAsync(addBlockedLearnedPatterns);
        }

        public AxlNetClient.StandardResponse updateBlockedLearnedPatterns(AxlNetClient.UpdateBlockedLearnedPatternsReq updateBlockedLearnedPatterns1)
        {
            return axlPortClient72.updateBlockedLearnedPatterns(updateBlockedLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateBlockedLearnedPatternsResponse> updateBlockedLearnedPatternsAsync(AxlNetClient.UpdateBlockedLearnedPatternsReq updateBlockedLearnedPatterns)
        {
            return axlPortClient72.updateBlockedLearnedPatternsAsync(updateBlockedLearnedPatterns);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort72
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirNumberAliasLookupandSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDirNumberAliasLookupandSyncResponse removeDirNumberAliasLookupandSync(AxlNetClient.removeDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirNumberAliasLookupandSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDirNumberAliasLookupandSyncResponse> removeDirNumberAliasLookupandSyncAsync(AxlNetClient.removeDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirNumberAliasLookupandSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDirNumberAliasLookupandSyncResponse listDirNumberAliasLookupandSync(AxlNetClient.listDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirNumberAliasLookupandSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDirNumberAliasLookupandSyncResponse> listDirNumberAliasLookupandSyncAsync(AxlNetClient.listDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLocalRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLocalRouteGroupResponse addLocalRouteGroup(AxlNetClient.addLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLocalRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLocalRouteGroupResponse> addLocalRouteGroupAsync(AxlNetClient.addLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLocalRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLocalRouteGroupResponse getLocalRouteGroup(AxlNetClient.getLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLocalRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLocalRouteGroupResponse> getLocalRouteGroupAsync(AxlNetClient.getLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLocalRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLocalRouteGroupResponse listLocalRouteGroup(AxlNetClient.listLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLocalRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLocalRouteGroupResponse> listLocalRouteGroupAsync(AxlNetClient.listLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAdvertisedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAdvertisedPatternsResponse addAdvertisedPatterns(AxlNetClient.addAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAdvertisedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAdvertisedPatternsResponse> addAdvertisedPatternsAsync(AxlNetClient.addAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAdvertisedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAdvertisedPatternsResponse updateAdvertisedPatterns(AxlNetClient.updateAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAdvertisedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAdvertisedPatternsResponse> updateAdvertisedPatternsAsync(AxlNetClient.updateAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAdvertisedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAdvertisedPatternsResponse getAdvertisedPatterns(AxlNetClient.getAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAdvertisedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAdvertisedPatternsResponse> getAdvertisedPatternsAsync(AxlNetClient.getAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAdvertisedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAdvertisedPatternsResponse removeAdvertisedPatterns(AxlNetClient.removeAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAdvertisedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAdvertisedPatternsResponse> removeAdvertisedPatternsAsync(AxlNetClient.removeAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAdvertisedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAdvertisedPatternsResponse listAdvertisedPatterns(AxlNetClient.listAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAdvertisedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAdvertisedPatternsResponse> listAdvertisedPatternsAsync(AxlNetClient.listAdvertisedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addBlockedLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addBlockedLearnedPatternsResponse addBlockedLearnedPatterns(AxlNetClient.addBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addBlockedLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addBlockedLearnedPatternsResponse> addBlockedLearnedPatternsAsync(AxlNetClient.addBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateBlockedLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateBlockedLearnedPatternsResponse updateBlockedLearnedPatterns(AxlNetClient.updateBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateBlockedLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateBlockedLearnedPatternsResponse> updateBlockedLearnedPatternsAsync(AxlNetClient.updateBlockedLearnedPatternsRequest request);
    }

    public class AXLPortClient72 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort72>, AxlNetClient.AXLPort72
    {
        public AXLPortClient72(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDirNumberAliasLookupandSyncResponse AxlNetClient.AXLPort72.removeDirNumberAliasLookupandSync(AxlNetClient.removeDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.removeDirNumberAliasLookupandSync(request);
        }

        public AxlNetClient.StandardResponse removeDirNumberAliasLookupandSync(AxlNetClient.NameAndGUIDRequest removeDirNumberAliasLookupandSync1)
        {
            AxlNetClient.removeDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.removeDirNumberAliasLookupandSyncRequest();
            inValue.removeDirNumberAliasLookupandSync = removeDirNumberAliasLookupandSync1;
            AxlNetClient.removeDirNumberAliasLookupandSyncResponse retVal = ((AxlNetClient.AXLPort72)(this)).removeDirNumberAliasLookupandSync(inValue);
            return retVal.removeDirNumberAliasLookupandSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDirNumberAliasLookupandSyncResponse> AxlNetClient.AXLPort72.removeDirNumberAliasLookupandSyncAsync(AxlNetClient.removeDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.removeDirNumberAliasLookupandSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirNumberAliasLookupandSyncResponse> removeDirNumberAliasLookupandSyncAsync(AxlNetClient.NameAndGUIDRequest removeDirNumberAliasLookupandSync)
        {
            AxlNetClient.removeDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.removeDirNumberAliasLookupandSyncRequest();
            inValue.removeDirNumberAliasLookupandSync = removeDirNumberAliasLookupandSync;
            return ((AxlNetClient.AXLPort72)(this)).removeDirNumberAliasLookupandSyncAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDirNumberAliasLookupandSyncResponse AxlNetClient.AXLPort72.listDirNumberAliasLookupandSync(AxlNetClient.listDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.listDirNumberAliasLookupandSync(request);
        }

        public AxlNetClient.ListDirNumberAliasLookupandSyncRes listDirNumberAliasLookupandSync(AxlNetClient.ListDirNumberAliasLookupandSyncReq listDirNumberAliasLookupandSync1)
        {
            AxlNetClient.listDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.listDirNumberAliasLookupandSyncRequest();
            inValue.listDirNumberAliasLookupandSync = listDirNumberAliasLookupandSync1;
            AxlNetClient.listDirNumberAliasLookupandSyncResponse retVal = ((AxlNetClient.AXLPort72)(this)).listDirNumberAliasLookupandSync(inValue);
            return retVal.listDirNumberAliasLookupandSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDirNumberAliasLookupandSyncResponse> AxlNetClient.AXLPort72.listDirNumberAliasLookupandSyncAsync(AxlNetClient.listDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.listDirNumberAliasLookupandSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirNumberAliasLookupandSyncResponse> listDirNumberAliasLookupandSyncAsync(AxlNetClient.ListDirNumberAliasLookupandSyncReq listDirNumberAliasLookupandSync)
        {
            AxlNetClient.listDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.listDirNumberAliasLookupandSyncRequest();
            inValue.listDirNumberAliasLookupandSync = listDirNumberAliasLookupandSync;
            return ((AxlNetClient.AXLPort72)(this)).listDirNumberAliasLookupandSyncAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLocalRouteGroupResponse AxlNetClient.AXLPort72.addLocalRouteGroup(AxlNetClient.addLocalRouteGroupRequest request)
        {
            return base.Channel.addLocalRouteGroup(request);
        }

        public AxlNetClient.StandardResponse addLocalRouteGroup(AxlNetClient.AddLocalRouteGroupReq addLocalRouteGroup1)
        {
            AxlNetClient.addLocalRouteGroupRequest inValue = new AxlNetClient.addLocalRouteGroupRequest();
            inValue.addLocalRouteGroup = addLocalRouteGroup1;
            AxlNetClient.addLocalRouteGroupResponse retVal = ((AxlNetClient.AXLPort72)(this)).addLocalRouteGroup(inValue);
            return retVal.addLocalRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLocalRouteGroupResponse> AxlNetClient.AXLPort72.addLocalRouteGroupAsync(AxlNetClient.addLocalRouteGroupRequest request)
        {
            return base.Channel.addLocalRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLocalRouteGroupResponse> addLocalRouteGroupAsync(AxlNetClient.AddLocalRouteGroupReq addLocalRouteGroup)
        {
            AxlNetClient.addLocalRouteGroupRequest inValue = new AxlNetClient.addLocalRouteGroupRequest();
            inValue.addLocalRouteGroup = addLocalRouteGroup;
            return ((AxlNetClient.AXLPort72)(this)).addLocalRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLocalRouteGroupResponse AxlNetClient.AXLPort72.getLocalRouteGroup(AxlNetClient.getLocalRouteGroupRequest request)
        {
            return base.Channel.getLocalRouteGroup(request);
        }

        public AxlNetClient.GetLocalRouteGroupRes getLocalRouteGroup(AxlNetClient.GetLocalRouteGroupReq getLocalRouteGroup1)
        {
            AxlNetClient.getLocalRouteGroupRequest inValue = new AxlNetClient.getLocalRouteGroupRequest();
            inValue.getLocalRouteGroup = getLocalRouteGroup1;
            AxlNetClient.getLocalRouteGroupResponse retVal = ((AxlNetClient.AXLPort72)(this)).getLocalRouteGroup(inValue);
            return retVal.getLocalRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLocalRouteGroupResponse> AxlNetClient.AXLPort72.getLocalRouteGroupAsync(AxlNetClient.getLocalRouteGroupRequest request)
        {
            return base.Channel.getLocalRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLocalRouteGroupResponse> getLocalRouteGroupAsync(AxlNetClient.GetLocalRouteGroupReq getLocalRouteGroup)
        {
            AxlNetClient.getLocalRouteGroupRequest inValue = new AxlNetClient.getLocalRouteGroupRequest();
            inValue.getLocalRouteGroup = getLocalRouteGroup;
            return ((AxlNetClient.AXLPort72)(this)).getLocalRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLocalRouteGroupResponse AxlNetClient.AXLPort72.listLocalRouteGroup(AxlNetClient.listLocalRouteGroupRequest request)
        {
            return base.Channel.listLocalRouteGroup(request);
        }

        public AxlNetClient.ListLocalRouteGroupRes listLocalRouteGroup(AxlNetClient.ListLocalRouteGroupReq listLocalRouteGroup1)
        {
            AxlNetClient.listLocalRouteGroupRequest inValue = new AxlNetClient.listLocalRouteGroupRequest();
            inValue.listLocalRouteGroup = listLocalRouteGroup1;
            AxlNetClient.listLocalRouteGroupResponse retVal = ((AxlNetClient.AXLPort72)(this)).listLocalRouteGroup(inValue);
            return retVal.listLocalRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLocalRouteGroupResponse> AxlNetClient.AXLPort72.listLocalRouteGroupAsync(AxlNetClient.listLocalRouteGroupRequest request)
        {
            return base.Channel.listLocalRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLocalRouteGroupResponse> listLocalRouteGroupAsync(AxlNetClient.ListLocalRouteGroupReq listLocalRouteGroup)
        {
            AxlNetClient.listLocalRouteGroupRequest inValue = new AxlNetClient.listLocalRouteGroupRequest();
            inValue.listLocalRouteGroup = listLocalRouteGroup;
            return ((AxlNetClient.AXLPort72)(this)).listLocalRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAdvertisedPatternsResponse AxlNetClient.AXLPort72.addAdvertisedPatterns(AxlNetClient.addAdvertisedPatternsRequest request)
        {
            return base.Channel.addAdvertisedPatterns(request);
        }

        public AxlNetClient.StandardResponse addAdvertisedPatterns(AxlNetClient.AddAdvertisedPatternsReq addAdvertisedPatterns1)
        {
            AxlNetClient.addAdvertisedPatternsRequest inValue = new AxlNetClient.addAdvertisedPatternsRequest();
            inValue.addAdvertisedPatterns = addAdvertisedPatterns1;
            AxlNetClient.addAdvertisedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).addAdvertisedPatterns(inValue);
            return retVal.addAdvertisedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAdvertisedPatternsResponse> AxlNetClient.AXLPort72.addAdvertisedPatternsAsync(AxlNetClient.addAdvertisedPatternsRequest request)
        {
            return base.Channel.addAdvertisedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAdvertisedPatternsResponse> addAdvertisedPatternsAsync(AxlNetClient.AddAdvertisedPatternsReq addAdvertisedPatterns)
        {
            AxlNetClient.addAdvertisedPatternsRequest inValue = new AxlNetClient.addAdvertisedPatternsRequest();
            inValue.addAdvertisedPatterns = addAdvertisedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).addAdvertisedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAdvertisedPatternsResponse AxlNetClient.AXLPort72.updateAdvertisedPatterns(AxlNetClient.updateAdvertisedPatternsRequest request)
        {
            return base.Channel.updateAdvertisedPatterns(request);
        }

        public AxlNetClient.StandardResponse updateAdvertisedPatterns(AxlNetClient.UpdateAdvertisedPatternsReq updateAdvertisedPatterns1)
        {
            AxlNetClient.updateAdvertisedPatternsRequest inValue = new AxlNetClient.updateAdvertisedPatternsRequest();
            inValue.updateAdvertisedPatterns = updateAdvertisedPatterns1;
            AxlNetClient.updateAdvertisedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).updateAdvertisedPatterns(inValue);
            return retVal.updateAdvertisedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAdvertisedPatternsResponse> AxlNetClient.AXLPort72.updateAdvertisedPatternsAsync(AxlNetClient.updateAdvertisedPatternsRequest request)
        {
            return base.Channel.updateAdvertisedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAdvertisedPatternsResponse> updateAdvertisedPatternsAsync(AxlNetClient.UpdateAdvertisedPatternsReq updateAdvertisedPatterns)
        {
            AxlNetClient.updateAdvertisedPatternsRequest inValue = new AxlNetClient.updateAdvertisedPatternsRequest();
            inValue.updateAdvertisedPatterns = updateAdvertisedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).updateAdvertisedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAdvertisedPatternsResponse AxlNetClient.AXLPort72.getAdvertisedPatterns(AxlNetClient.getAdvertisedPatternsRequest request)
        {
            return base.Channel.getAdvertisedPatterns(request);
        }

        public AxlNetClient.GetAdvertisedPatternsRes getAdvertisedPatterns(AxlNetClient.GetAdvertisedPatternsReq getAdvertisedPatterns1)
        {
            AxlNetClient.getAdvertisedPatternsRequest inValue = new AxlNetClient.getAdvertisedPatternsRequest();
            inValue.getAdvertisedPatterns = getAdvertisedPatterns1;
            AxlNetClient.getAdvertisedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).getAdvertisedPatterns(inValue);
            return retVal.getAdvertisedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAdvertisedPatternsResponse> AxlNetClient.AXLPort72.getAdvertisedPatternsAsync(AxlNetClient.getAdvertisedPatternsRequest request)
        {
            return base.Channel.getAdvertisedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAdvertisedPatternsResponse> getAdvertisedPatternsAsync(AxlNetClient.GetAdvertisedPatternsReq getAdvertisedPatterns)
        {
            AxlNetClient.getAdvertisedPatternsRequest inValue = new AxlNetClient.getAdvertisedPatternsRequest();
            inValue.getAdvertisedPatterns = getAdvertisedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).getAdvertisedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAdvertisedPatternsResponse AxlNetClient.AXLPort72.removeAdvertisedPatterns(AxlNetClient.removeAdvertisedPatternsRequest request)
        {
            return base.Channel.removeAdvertisedPatterns(request);
        }

        public AxlNetClient.StandardResponse removeAdvertisedPatterns(AxlNetClient.RemoveAdvertisedPatternsReq removeAdvertisedPatterns1)
        {
            AxlNetClient.removeAdvertisedPatternsRequest inValue = new AxlNetClient.removeAdvertisedPatternsRequest();
            inValue.removeAdvertisedPatterns = removeAdvertisedPatterns1;
            AxlNetClient.removeAdvertisedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).removeAdvertisedPatterns(inValue);
            return retVal.removeAdvertisedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAdvertisedPatternsResponse> AxlNetClient.AXLPort72.removeAdvertisedPatternsAsync(AxlNetClient.removeAdvertisedPatternsRequest request)
        {
            return base.Channel.removeAdvertisedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAdvertisedPatternsResponse> removeAdvertisedPatternsAsync(AxlNetClient.RemoveAdvertisedPatternsReq removeAdvertisedPatterns)
        {
            AxlNetClient.removeAdvertisedPatternsRequest inValue = new AxlNetClient.removeAdvertisedPatternsRequest();
            inValue.removeAdvertisedPatterns = removeAdvertisedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).removeAdvertisedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAdvertisedPatternsResponse AxlNetClient.AXLPort72.listAdvertisedPatterns(AxlNetClient.listAdvertisedPatternsRequest request)
        {
            return base.Channel.listAdvertisedPatterns(request);
        }

        public AxlNetClient.ListAdvertisedPatternsRes listAdvertisedPatterns(AxlNetClient.ListAdvertisedPatternsReq listAdvertisedPatterns1)
        {
            AxlNetClient.listAdvertisedPatternsRequest inValue = new AxlNetClient.listAdvertisedPatternsRequest();
            inValue.listAdvertisedPatterns = listAdvertisedPatterns1;
            AxlNetClient.listAdvertisedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).listAdvertisedPatterns(inValue);
            return retVal.listAdvertisedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAdvertisedPatternsResponse> AxlNetClient.AXLPort72.listAdvertisedPatternsAsync(AxlNetClient.listAdvertisedPatternsRequest request)
        {
            return base.Channel.listAdvertisedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAdvertisedPatternsResponse> listAdvertisedPatternsAsync(AxlNetClient.ListAdvertisedPatternsReq listAdvertisedPatterns)
        {
            AxlNetClient.listAdvertisedPatternsRequest inValue = new AxlNetClient.listAdvertisedPatternsRequest();
            inValue.listAdvertisedPatterns = listAdvertisedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).listAdvertisedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addBlockedLearnedPatternsResponse AxlNetClient.AXLPort72.addBlockedLearnedPatterns(AxlNetClient.addBlockedLearnedPatternsRequest request)
        {
            return base.Channel.addBlockedLearnedPatterns(request);
        }

        public AxlNetClient.StandardResponse addBlockedLearnedPatterns(AxlNetClient.AddBlockedLearnedPatternsReq addBlockedLearnedPatterns1)
        {
            AxlNetClient.addBlockedLearnedPatternsRequest inValue = new AxlNetClient.addBlockedLearnedPatternsRequest();
            inValue.addBlockedLearnedPatterns = addBlockedLearnedPatterns1;
            AxlNetClient.addBlockedLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).addBlockedLearnedPatterns(inValue);
            return retVal.addBlockedLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addBlockedLearnedPatternsResponse> AxlNetClient.AXLPort72.addBlockedLearnedPatternsAsync(AxlNetClient.addBlockedLearnedPatternsRequest request)
        {
            return base.Channel.addBlockedLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addBlockedLearnedPatternsResponse> addBlockedLearnedPatternsAsync(AxlNetClient.AddBlockedLearnedPatternsReq addBlockedLearnedPatterns)
        {
            AxlNetClient.addBlockedLearnedPatternsRequest inValue = new AxlNetClient.addBlockedLearnedPatternsRequest();
            inValue.addBlockedLearnedPatterns = addBlockedLearnedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).addBlockedLearnedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateBlockedLearnedPatternsResponse AxlNetClient.AXLPort72.updateBlockedLearnedPatterns(AxlNetClient.updateBlockedLearnedPatternsRequest request)
        {
            return base.Channel.updateBlockedLearnedPatterns(request);
        }

        public AxlNetClient.StandardResponse updateBlockedLearnedPatterns(AxlNetClient.UpdateBlockedLearnedPatternsReq updateBlockedLearnedPatterns1)
        {
            AxlNetClient.updateBlockedLearnedPatternsRequest inValue = new AxlNetClient.updateBlockedLearnedPatternsRequest();
            inValue.updateBlockedLearnedPatterns = updateBlockedLearnedPatterns1;
            AxlNetClient.updateBlockedLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort72)(this)).updateBlockedLearnedPatterns(inValue);
            return retVal.updateBlockedLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateBlockedLearnedPatternsResponse> AxlNetClient.AXLPort72.updateBlockedLearnedPatternsAsync(AxlNetClient.updateBlockedLearnedPatternsRequest request)
        {
            return base.Channel.updateBlockedLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateBlockedLearnedPatternsResponse> updateBlockedLearnedPatternsAsync(AxlNetClient.UpdateBlockedLearnedPatternsReq updateBlockedLearnedPatterns)
        {
            AxlNetClient.updateBlockedLearnedPatternsRequest inValue = new AxlNetClient.updateBlockedLearnedPatternsRequest();
            inValue.updateBlockedLearnedPatterns = updateBlockedLearnedPatterns;
            return ((AxlNetClient.AXLPort72)(this)).updateBlockedLearnedPatternsAsync(inValue);
        }
    }
}