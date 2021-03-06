namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient13 _axlPortClient13;

        private static AXLPortClient13 axlPortClient13 => _axlPortClient13 == null ||
            _axlPortClient13.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient13 = LoadClient13()) : _axlPortClient13;

        private static AXLPortClient13 LoadClient13()
        {
            var client = new AXLPortClient13(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close13;
            OnAbort += Abort13;
            return client;
        }

        private static void Close13(object sender, System.EventArgs e)
        {
            _axlPortClient13.Close();
        }

        private static void Abort13(object sender, System.EventArgs e)
        {
            _axlPortClient13.Abort();
        }

        public AxlNetClient.GetResourcePriorityNamespaceListRes getResourcePriorityNamespaceList(AxlNetClient.GetResourcePriorityNamespaceListReq getResourcePriorityNamespaceList1)
        {
            return axlPortClient13.getResourcePriorityNamespaceList(getResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceListResponse> getResourcePriorityNamespaceListAsync(AxlNetClient.GetResourcePriorityNamespaceListReq getResourcePriorityNamespaceList)
        {
            return axlPortClient13.getResourcePriorityNamespaceListAsync(getResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse removeResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest removeResourcePriorityNamespaceList1)
        {
            return axlPortClient13.removeResourcePriorityNamespaceList(removeResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceListResponse> removeResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest removeResourcePriorityNamespaceList)
        {
            return axlPortClient13.removeResourcePriorityNamespaceListAsync(removeResourcePriorityNamespaceList);
        }

        public AxlNetClient.ListResourcePriorityNamespaceListRes listResourcePriorityNamespaceList(AxlNetClient.ListResourcePriorityNamespaceListReq listResourcePriorityNamespaceList1)
        {
            return axlPortClient13.listResourcePriorityNamespaceList(listResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceListResponse> listResourcePriorityNamespaceListAsync(AxlNetClient.ListResourcePriorityNamespaceListReq listResourcePriorityNamespaceList)
        {
            return axlPortClient13.listResourcePriorityNamespaceListAsync(listResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse resetResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest resetResourcePriorityNamespaceList1)
        {
            return axlPortClient13.resetResourcePriorityNamespaceList(resetResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceListResponse> resetResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest resetResourcePriorityNamespaceList)
        {
            return axlPortClient13.resetResourcePriorityNamespaceListAsync(resetResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse restartResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest restartResourcePriorityNamespaceList1)
        {
            return axlPortClient13.restartResourcePriorityNamespaceList(restartResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceListResponse> restartResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest restartResourcePriorityNamespaceList)
        {
            return axlPortClient13.restartResourcePriorityNamespaceListAsync(restartResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse applyResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest applyResourcePriorityNamespaceList1)
        {
            return axlPortClient13.applyResourcePriorityNamespaceList(applyResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceListResponse> applyResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest applyResourcePriorityNamespaceList)
        {
            return axlPortClient13.applyResourcePriorityNamespaceListAsync(applyResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse addDeviceMobility(AxlNetClient.AddDeviceMobilityReq addDeviceMobility1)
        {
            return axlPortClient13.addDeviceMobility(addDeviceMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityResponse> addDeviceMobilityAsync(AxlNetClient.AddDeviceMobilityReq addDeviceMobility)
        {
            return axlPortClient13.addDeviceMobilityAsync(addDeviceMobility);
        }

        public AxlNetClient.StandardResponse updateDeviceMobility(AxlNetClient.UpdateDeviceMobilityReq updateDeviceMobility1)
        {
            return axlPortClient13.updateDeviceMobility(updateDeviceMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityResponse> updateDeviceMobilityAsync(AxlNetClient.UpdateDeviceMobilityReq updateDeviceMobility)
        {
            return axlPortClient13.updateDeviceMobilityAsync(updateDeviceMobility);
        }

        public AxlNetClient.GetDeviceMobilityRes getDeviceMobility(AxlNetClient.GetDeviceMobilityReq getDeviceMobility1)
        {
            return axlPortClient13.getDeviceMobility(getDeviceMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityResponse> getDeviceMobilityAsync(AxlNetClient.GetDeviceMobilityReq getDeviceMobility)
        {
            return axlPortClient13.getDeviceMobilityAsync(getDeviceMobility);
        }

        public AxlNetClient.StandardResponse removeDeviceMobility(AxlNetClient.NameAndGUIDRequest removeDeviceMobility1)
        {
            return axlPortClient13.removeDeviceMobility(removeDeviceMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityResponse> removeDeviceMobilityAsync(AxlNetClient.NameAndGUIDRequest removeDeviceMobility)
        {
            return axlPortClient13.removeDeviceMobilityAsync(removeDeviceMobility);
        }

        public AxlNetClient.ListDeviceMobilityRes listDeviceMobility(AxlNetClient.ListDeviceMobilityReq listDeviceMobility1)
        {
            return axlPortClient13.listDeviceMobility(listDeviceMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityResponse> listDeviceMobilityAsync(AxlNetClient.ListDeviceMobilityReq listDeviceMobility)
        {
            return axlPortClient13.listDeviceMobilityAsync(listDeviceMobility);
        }

        public AxlNetClient.StandardResponse addCmcInfo(AxlNetClient.AddCmcInfoReq addCmcInfo1)
        {
            return axlPortClient13.addCmcInfo(addCmcInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCmcInfoResponse> addCmcInfoAsync(AxlNetClient.AddCmcInfoReq addCmcInfo)
        {
            return axlPortClient13.addCmcInfoAsync(addCmcInfo);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort13
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getResourcePriorityNamespaceListResponse getResourcePriorityNamespaceList(AxlNetClient.getResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceListResponse> getResourcePriorityNamespaceListAsync(AxlNetClient.getResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeResourcePriorityNamespaceListResponse removeResourcePriorityNamespaceList(AxlNetClient.removeResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceListResponse> removeResourcePriorityNamespaceListAsync(AxlNetClient.removeResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listResourcePriorityNamespaceListResponse listResourcePriorityNamespaceList(AxlNetClient.listResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceListResponse> listResourcePriorityNamespaceListAsync(AxlNetClient.listResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetResourcePriorityNamespaceListResponse resetResourcePriorityNamespaceList(AxlNetClient.resetResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceListResponse> resetResourcePriorityNamespaceListAsync(AxlNetClient.resetResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartResourcePriorityNamespaceListResponse restartResourcePriorityNamespaceList(AxlNetClient.restartResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceListResponse> restartResourcePriorityNamespaceListAsync(AxlNetClient.restartResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyResourcePriorityNamespaceListResponse applyResourcePriorityNamespaceList(AxlNetClient.applyResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceListResponse> applyResourcePriorityNamespaceListAsync(AxlNetClient.applyResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDeviceMobilityResponse addDeviceMobility(AxlNetClient.addDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityResponse> addDeviceMobilityAsync(AxlNetClient.addDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDeviceMobilityResponse updateDeviceMobility(AxlNetClient.updateDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityResponse> updateDeviceMobilityAsync(AxlNetClient.updateDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDeviceMobilityResponse getDeviceMobility(AxlNetClient.getDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityResponse> getDeviceMobilityAsync(AxlNetClient.getDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDeviceMobilityResponse removeDeviceMobility(AxlNetClient.removeDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityResponse> removeDeviceMobilityAsync(AxlNetClient.removeDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDeviceMobilityResponse listDeviceMobility(AxlNetClient.listDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityResponse> listDeviceMobilityAsync(AxlNetClient.listDeviceMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCmcInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCmcInfoResponse addCmcInfo(AxlNetClient.addCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCmcInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCmcInfoResponse> addCmcInfoAsync(AxlNetClient.addCmcInfoRequest request);
    }

    public class AXLPortClient13 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort13>, AxlNetClient.AXLPort13
    {
        public AXLPortClient13(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.getResourcePriorityNamespaceList(AxlNetClient.getResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.getResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.GetResourcePriorityNamespaceListRes getResourcePriorityNamespaceList(AxlNetClient.GetResourcePriorityNamespaceListReq getResourcePriorityNamespaceList1)
        {
            AxlNetClient.getResourcePriorityNamespaceListRequest inValue = new AxlNetClient.getResourcePriorityNamespaceListRequest();
            inValue.getResourcePriorityNamespaceList = getResourcePriorityNamespaceList1;
            AxlNetClient.getResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).getResourcePriorityNamespaceList(inValue);
            return retVal.getResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.getResourcePriorityNamespaceListAsync(AxlNetClient.getResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.getResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceListResponse> getResourcePriorityNamespaceListAsync(AxlNetClient.GetResourcePriorityNamespaceListReq getResourcePriorityNamespaceList)
        {
            AxlNetClient.getResourcePriorityNamespaceListRequest inValue = new AxlNetClient.getResourcePriorityNamespaceListRequest();
            inValue.getResourcePriorityNamespaceList = getResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).getResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.removeResourcePriorityNamespaceList(AxlNetClient.removeResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.removeResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse removeResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest removeResourcePriorityNamespaceList1)
        {
            AxlNetClient.removeResourcePriorityNamespaceListRequest inValue = new AxlNetClient.removeResourcePriorityNamespaceListRequest();
            inValue.removeResourcePriorityNamespaceList = removeResourcePriorityNamespaceList1;
            AxlNetClient.removeResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).removeResourcePriorityNamespaceList(inValue);
            return retVal.removeResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.removeResourcePriorityNamespaceListAsync(AxlNetClient.removeResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.removeResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceListResponse> removeResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest removeResourcePriorityNamespaceList)
        {
            AxlNetClient.removeResourcePriorityNamespaceListRequest inValue = new AxlNetClient.removeResourcePriorityNamespaceListRequest();
            inValue.removeResourcePriorityNamespaceList = removeResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).removeResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.listResourcePriorityNamespaceList(AxlNetClient.listResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.listResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.ListResourcePriorityNamespaceListRes listResourcePriorityNamespaceList(AxlNetClient.ListResourcePriorityNamespaceListReq listResourcePriorityNamespaceList1)
        {
            AxlNetClient.listResourcePriorityNamespaceListRequest inValue = new AxlNetClient.listResourcePriorityNamespaceListRequest();
            inValue.listResourcePriorityNamespaceList = listResourcePriorityNamespaceList1;
            AxlNetClient.listResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).listResourcePriorityNamespaceList(inValue);
            return retVal.listResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.listResourcePriorityNamespaceListAsync(AxlNetClient.listResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.listResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceListResponse> listResourcePriorityNamespaceListAsync(AxlNetClient.ListResourcePriorityNamespaceListReq listResourcePriorityNamespaceList)
        {
            AxlNetClient.listResourcePriorityNamespaceListRequest inValue = new AxlNetClient.listResourcePriorityNamespaceListRequest();
            inValue.listResourcePriorityNamespaceList = listResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).listResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.resetResourcePriorityNamespaceList(AxlNetClient.resetResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.resetResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse resetResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest resetResourcePriorityNamespaceList1)
        {
            AxlNetClient.resetResourcePriorityNamespaceListRequest inValue = new AxlNetClient.resetResourcePriorityNamespaceListRequest();
            inValue.resetResourcePriorityNamespaceList = resetResourcePriorityNamespaceList1;
            AxlNetClient.resetResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).resetResourcePriorityNamespaceList(inValue);
            return retVal.resetResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.resetResourcePriorityNamespaceListAsync(AxlNetClient.resetResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.resetResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceListResponse> resetResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest resetResourcePriorityNamespaceList)
        {
            AxlNetClient.resetResourcePriorityNamespaceListRequest inValue = new AxlNetClient.resetResourcePriorityNamespaceListRequest();
            inValue.resetResourcePriorityNamespaceList = resetResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).resetResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.restartResourcePriorityNamespaceList(AxlNetClient.restartResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.restartResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse restartResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest restartResourcePriorityNamespaceList1)
        {
            AxlNetClient.restartResourcePriorityNamespaceListRequest inValue = new AxlNetClient.restartResourcePriorityNamespaceListRequest();
            inValue.restartResourcePriorityNamespaceList = restartResourcePriorityNamespaceList1;
            AxlNetClient.restartResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).restartResourcePriorityNamespaceList(inValue);
            return retVal.restartResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.restartResourcePriorityNamespaceListAsync(AxlNetClient.restartResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.restartResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceListResponse> restartResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest restartResourcePriorityNamespaceList)
        {
            AxlNetClient.restartResourcePriorityNamespaceListRequest inValue = new AxlNetClient.restartResourcePriorityNamespaceListRequest();
            inValue.restartResourcePriorityNamespaceList = restartResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).restartResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyResourcePriorityNamespaceListResponse AxlNetClient.AXLPort13.applyResourcePriorityNamespaceList(AxlNetClient.applyResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.applyResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse applyResourcePriorityNamespaceList(AxlNetClient.NameAndGUIDRequest applyResourcePriorityNamespaceList1)
        {
            AxlNetClient.applyResourcePriorityNamespaceListRequest inValue = new AxlNetClient.applyResourcePriorityNamespaceListRequest();
            inValue.applyResourcePriorityNamespaceList = applyResourcePriorityNamespaceList1;
            AxlNetClient.applyResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort13)(this)).applyResourcePriorityNamespaceList(inValue);
            return retVal.applyResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort13.applyResourcePriorityNamespaceListAsync(AxlNetClient.applyResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.applyResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceListResponse> applyResourcePriorityNamespaceListAsync(AxlNetClient.NameAndGUIDRequest applyResourcePriorityNamespaceList)
        {
            AxlNetClient.applyResourcePriorityNamespaceListRequest inValue = new AxlNetClient.applyResourcePriorityNamespaceListRequest();
            inValue.applyResourcePriorityNamespaceList = applyResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort13)(this)).applyResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDeviceMobilityResponse AxlNetClient.AXLPort13.addDeviceMobility(AxlNetClient.addDeviceMobilityRequest request)
        {
            return base.Channel.addDeviceMobility(request);
        }

        public AxlNetClient.StandardResponse addDeviceMobility(AxlNetClient.AddDeviceMobilityReq addDeviceMobility1)
        {
            AxlNetClient.addDeviceMobilityRequest inValue = new AxlNetClient.addDeviceMobilityRequest();
            inValue.addDeviceMobility = addDeviceMobility1;
            AxlNetClient.addDeviceMobilityResponse retVal = ((AxlNetClient.AXLPort13)(this)).addDeviceMobility(inValue);
            return retVal.addDeviceMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityResponse> AxlNetClient.AXLPort13.addDeviceMobilityAsync(AxlNetClient.addDeviceMobilityRequest request)
        {
            return base.Channel.addDeviceMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityResponse> addDeviceMobilityAsync(AxlNetClient.AddDeviceMobilityReq addDeviceMobility)
        {
            AxlNetClient.addDeviceMobilityRequest inValue = new AxlNetClient.addDeviceMobilityRequest();
            inValue.addDeviceMobility = addDeviceMobility;
            return ((AxlNetClient.AXLPort13)(this)).addDeviceMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDeviceMobilityResponse AxlNetClient.AXLPort13.updateDeviceMobility(AxlNetClient.updateDeviceMobilityRequest request)
        {
            return base.Channel.updateDeviceMobility(request);
        }

        public AxlNetClient.StandardResponse updateDeviceMobility(AxlNetClient.UpdateDeviceMobilityReq updateDeviceMobility1)
        {
            AxlNetClient.updateDeviceMobilityRequest inValue = new AxlNetClient.updateDeviceMobilityRequest();
            inValue.updateDeviceMobility = updateDeviceMobility1;
            AxlNetClient.updateDeviceMobilityResponse retVal = ((AxlNetClient.AXLPort13)(this)).updateDeviceMobility(inValue);
            return retVal.updateDeviceMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityResponse> AxlNetClient.AXLPort13.updateDeviceMobilityAsync(AxlNetClient.updateDeviceMobilityRequest request)
        {
            return base.Channel.updateDeviceMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityResponse> updateDeviceMobilityAsync(AxlNetClient.UpdateDeviceMobilityReq updateDeviceMobility)
        {
            AxlNetClient.updateDeviceMobilityRequest inValue = new AxlNetClient.updateDeviceMobilityRequest();
            inValue.updateDeviceMobility = updateDeviceMobility;
            return ((AxlNetClient.AXLPort13)(this)).updateDeviceMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDeviceMobilityResponse AxlNetClient.AXLPort13.getDeviceMobility(AxlNetClient.getDeviceMobilityRequest request)
        {
            return base.Channel.getDeviceMobility(request);
        }

        public AxlNetClient.GetDeviceMobilityRes getDeviceMobility(AxlNetClient.GetDeviceMobilityReq getDeviceMobility1)
        {
            AxlNetClient.getDeviceMobilityRequest inValue = new AxlNetClient.getDeviceMobilityRequest();
            inValue.getDeviceMobility = getDeviceMobility1;
            AxlNetClient.getDeviceMobilityResponse retVal = ((AxlNetClient.AXLPort13)(this)).getDeviceMobility(inValue);
            return retVal.getDeviceMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityResponse> AxlNetClient.AXLPort13.getDeviceMobilityAsync(AxlNetClient.getDeviceMobilityRequest request)
        {
            return base.Channel.getDeviceMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityResponse> getDeviceMobilityAsync(AxlNetClient.GetDeviceMobilityReq getDeviceMobility)
        {
            AxlNetClient.getDeviceMobilityRequest inValue = new AxlNetClient.getDeviceMobilityRequest();
            inValue.getDeviceMobility = getDeviceMobility;
            return ((AxlNetClient.AXLPort13)(this)).getDeviceMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDeviceMobilityResponse AxlNetClient.AXLPort13.removeDeviceMobility(AxlNetClient.removeDeviceMobilityRequest request)
        {
            return base.Channel.removeDeviceMobility(request);
        }

        public AxlNetClient.StandardResponse removeDeviceMobility(AxlNetClient.NameAndGUIDRequest removeDeviceMobility1)
        {
            AxlNetClient.removeDeviceMobilityRequest inValue = new AxlNetClient.removeDeviceMobilityRequest();
            inValue.removeDeviceMobility = removeDeviceMobility1;
            AxlNetClient.removeDeviceMobilityResponse retVal = ((AxlNetClient.AXLPort13)(this)).removeDeviceMobility(inValue);
            return retVal.removeDeviceMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityResponse> AxlNetClient.AXLPort13.removeDeviceMobilityAsync(AxlNetClient.removeDeviceMobilityRequest request)
        {
            return base.Channel.removeDeviceMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityResponse> removeDeviceMobilityAsync(AxlNetClient.NameAndGUIDRequest removeDeviceMobility)
        {
            AxlNetClient.removeDeviceMobilityRequest inValue = new AxlNetClient.removeDeviceMobilityRequest();
            inValue.removeDeviceMobility = removeDeviceMobility;
            return ((AxlNetClient.AXLPort13)(this)).removeDeviceMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDeviceMobilityResponse AxlNetClient.AXLPort13.listDeviceMobility(AxlNetClient.listDeviceMobilityRequest request)
        {
            return base.Channel.listDeviceMobility(request);
        }

        public AxlNetClient.ListDeviceMobilityRes listDeviceMobility(AxlNetClient.ListDeviceMobilityReq listDeviceMobility1)
        {
            AxlNetClient.listDeviceMobilityRequest inValue = new AxlNetClient.listDeviceMobilityRequest();
            inValue.listDeviceMobility = listDeviceMobility1;
            AxlNetClient.listDeviceMobilityResponse retVal = ((AxlNetClient.AXLPort13)(this)).listDeviceMobility(inValue);
            return retVal.listDeviceMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityResponse> AxlNetClient.AXLPort13.listDeviceMobilityAsync(AxlNetClient.listDeviceMobilityRequest request)
        {
            return base.Channel.listDeviceMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityResponse> listDeviceMobilityAsync(AxlNetClient.ListDeviceMobilityReq listDeviceMobility)
        {
            AxlNetClient.listDeviceMobilityRequest inValue = new AxlNetClient.listDeviceMobilityRequest();
            inValue.listDeviceMobility = listDeviceMobility;
            return ((AxlNetClient.AXLPort13)(this)).listDeviceMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCmcInfoResponse AxlNetClient.AXLPort13.addCmcInfo(AxlNetClient.addCmcInfoRequest request)
        {
            return base.Channel.addCmcInfo(request);
        }

        public AxlNetClient.StandardResponse addCmcInfo(AxlNetClient.AddCmcInfoReq addCmcInfo1)
        {
            AxlNetClient.addCmcInfoRequest inValue = new AxlNetClient.addCmcInfoRequest();
            inValue.addCmcInfo = addCmcInfo1;
            AxlNetClient.addCmcInfoResponse retVal = ((AxlNetClient.AXLPort13)(this)).addCmcInfo(inValue);
            return retVal.addCmcInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCmcInfoResponse> AxlNetClient.AXLPort13.addCmcInfoAsync(AxlNetClient.addCmcInfoRequest request)
        {
            return base.Channel.addCmcInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCmcInfoResponse> addCmcInfoAsync(AxlNetClient.AddCmcInfoReq addCmcInfo)
        {
            AxlNetClient.addCmcInfoRequest inValue = new AxlNetClient.addCmcInfoRequest();
            inValue.addCmcInfo = addCmcInfo;
            return ((AxlNetClient.AXLPort13)(this)).addCmcInfoAsync(inValue);
        }
    }
}