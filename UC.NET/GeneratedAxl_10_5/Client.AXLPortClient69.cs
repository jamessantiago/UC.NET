namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient69 _axlPortClient69;

        private static AXLPortClient69 axlPortClient69 => _axlPortClient69 == null ||
            _axlPortClient69.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient69 = LoadClient69()) : _axlPortClient69;

        private static AXLPortClient69 LoadClient69()
        {
            var client = new AXLPortClient69(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close69;
            OnAbort += Abort69;
            return client;
        }

        private static void Close69(object sender, System.EventArgs e)
        {
            _axlPortClient69.Close();
        }

        private static void Abort69(object sender, System.EventArgs e)
        {
            _axlPortClient69.Abort();
        }

        public AxlNetClient.GetAudioCodecPreferenceListRes getAudioCodecPreferenceList(AxlNetClient.GetAudioCodecPreferenceListReq getAudioCodecPreferenceList1)
        {
            return axlPortClient69.getAudioCodecPreferenceList(getAudioCodecPreferenceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAudioCodecPreferenceListResponse> getAudioCodecPreferenceListAsync(AxlNetClient.GetAudioCodecPreferenceListReq getAudioCodecPreferenceList)
        {
            return axlPortClient69.getAudioCodecPreferenceListAsync(getAudioCodecPreferenceList);
        }

        public AxlNetClient.StandardResponse removeAudioCodecPreferenceList(AxlNetClient.NameAndGUIDRequest removeAudioCodecPreferenceList1)
        {
            return axlPortClient69.removeAudioCodecPreferenceList(removeAudioCodecPreferenceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAudioCodecPreferenceListResponse> removeAudioCodecPreferenceListAsync(AxlNetClient.NameAndGUIDRequest removeAudioCodecPreferenceList)
        {
            return axlPortClient69.removeAudioCodecPreferenceListAsync(removeAudioCodecPreferenceList);
        }

        public AxlNetClient.ListAudioCodecPreferenceListRes listAudioCodecPreferenceList(AxlNetClient.ListAudioCodecPreferenceListReq listAudioCodecPreferenceList1)
        {
            return axlPortClient69.listAudioCodecPreferenceList(listAudioCodecPreferenceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAudioCodecPreferenceListResponse> listAudioCodecPreferenceListAsync(AxlNetClient.ListAudioCodecPreferenceListReq listAudioCodecPreferenceList)
        {
            return axlPortClient69.listAudioCodecPreferenceListAsync(listAudioCodecPreferenceList);
        }

        public AxlNetClient.StandardResponse addUcService(AxlNetClient.AddUcServiceReq addUcService1)
        {
            return axlPortClient69.addUcService(addUcService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUcServiceResponse> addUcServiceAsync(AxlNetClient.AddUcServiceReq addUcService)
        {
            return axlPortClient69.addUcServiceAsync(addUcService);
        }

        public AxlNetClient.StandardResponse updateUcService(AxlNetClient.UpdateUcServiceReq updateUcService1)
        {
            return axlPortClient69.updateUcService(updateUcService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUcServiceResponse> updateUcServiceAsync(AxlNetClient.UpdateUcServiceReq updateUcService)
        {
            return axlPortClient69.updateUcServiceAsync(updateUcService);
        }

        public AxlNetClient.GetUcServiceRes getUcService(AxlNetClient.GetUcServiceReq getUcService1)
        {
            return axlPortClient69.getUcService(getUcService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUcServiceResponse> getUcServiceAsync(AxlNetClient.GetUcServiceReq getUcService)
        {
            return axlPortClient69.getUcServiceAsync(getUcService);
        }

        public AxlNetClient.StandardResponse removeUcService(AxlNetClient.NameAndGUIDRequest removeUcService1)
        {
            return axlPortClient69.removeUcService(removeUcService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUcServiceResponse> removeUcServiceAsync(AxlNetClient.NameAndGUIDRequest removeUcService)
        {
            return axlPortClient69.removeUcServiceAsync(removeUcService);
        }

        public AxlNetClient.ListUcServiceRes listUcService(AxlNetClient.ListUcServiceReq listUcService1)
        {
            return axlPortClient69.listUcService(listUcService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUcServiceResponse> listUcServiceAsync(AxlNetClient.ListUcServiceReq listUcService)
        {
            return axlPortClient69.listUcServiceAsync(listUcService);
        }

        public AxlNetClient.StandardResponse addLbmHubGroup(AxlNetClient.AddLbmHubGroupReq addLbmHubGroup1)
        {
            return axlPortClient69.addLbmHubGroup(addLbmHubGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLbmHubGroupResponse> addLbmHubGroupAsync(AxlNetClient.AddLbmHubGroupReq addLbmHubGroup)
        {
            return axlPortClient69.addLbmHubGroupAsync(addLbmHubGroup);
        }

        public AxlNetClient.StandardResponse updateLbmHubGroup(AxlNetClient.UpdateLbmHubGroupReq updateLbmHubGroup1)
        {
            return axlPortClient69.updateLbmHubGroup(updateLbmHubGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLbmHubGroupResponse> updateLbmHubGroupAsync(AxlNetClient.UpdateLbmHubGroupReq updateLbmHubGroup)
        {
            return axlPortClient69.updateLbmHubGroupAsync(updateLbmHubGroup);
        }

        public AxlNetClient.GetLbmHubGroupRes getLbmHubGroup(AxlNetClient.GetLbmHubGroupReq getLbmHubGroup1)
        {
            return axlPortClient69.getLbmHubGroup(getLbmHubGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLbmHubGroupResponse> getLbmHubGroupAsync(AxlNetClient.GetLbmHubGroupReq getLbmHubGroup)
        {
            return axlPortClient69.getLbmHubGroupAsync(getLbmHubGroup);
        }

        public AxlNetClient.StandardResponse removeLbmHubGroup(AxlNetClient.NameAndGUIDRequest removeLbmHubGroup1)
        {
            return axlPortClient69.removeLbmHubGroup(removeLbmHubGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLbmHubGroupResponse> removeLbmHubGroupAsync(AxlNetClient.NameAndGUIDRequest removeLbmHubGroup)
        {
            return axlPortClient69.removeLbmHubGroupAsync(removeLbmHubGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort69
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAudioCodecPreferenceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAudioCodecPreferenceListResponse getAudioCodecPreferenceList(AxlNetClient.getAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAudioCodecPreferenceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAudioCodecPreferenceListResponse> getAudioCodecPreferenceListAsync(AxlNetClient.getAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAudioCodecPreferenceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAudioCodecPreferenceListResponse removeAudioCodecPreferenceList(AxlNetClient.removeAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAudioCodecPreferenceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAudioCodecPreferenceListResponse> removeAudioCodecPreferenceListAsync(AxlNetClient.removeAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAudioCodecPreferenceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAudioCodecPreferenceListResponse listAudioCodecPreferenceList(AxlNetClient.listAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAudioCodecPreferenceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAudioCodecPreferenceListResponse> listAudioCodecPreferenceListAsync(AxlNetClient.listAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUcService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUcServiceResponse addUcService(AxlNetClient.addUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUcService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUcServiceResponse> addUcServiceAsync(AxlNetClient.addUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUcService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUcServiceResponse updateUcService(AxlNetClient.updateUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUcService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUcServiceResponse> updateUcServiceAsync(AxlNetClient.updateUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUcService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUcServiceResponse getUcService(AxlNetClient.getUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUcService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUcServiceResponse> getUcServiceAsync(AxlNetClient.getUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUcService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUcServiceResponse removeUcService(AxlNetClient.removeUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUcService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUcServiceResponse> removeUcServiceAsync(AxlNetClient.removeUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUcService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUcServiceResponse listUcService(AxlNetClient.listUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUcService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUcServiceResponse> listUcServiceAsync(AxlNetClient.listUcServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLbmHubGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLbmHubGroupResponse addLbmHubGroup(AxlNetClient.addLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLbmHubGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLbmHubGroupResponse> addLbmHubGroupAsync(AxlNetClient.addLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLbmHubGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLbmHubGroupResponse updateLbmHubGroup(AxlNetClient.updateLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLbmHubGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLbmHubGroupResponse> updateLbmHubGroupAsync(AxlNetClient.updateLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLbmHubGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLbmHubGroupResponse getLbmHubGroup(AxlNetClient.getLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLbmHubGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLbmHubGroupResponse> getLbmHubGroupAsync(AxlNetClient.getLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLbmHubGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLbmHubGroupResponse removeLbmHubGroup(AxlNetClient.removeLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLbmHubGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLbmHubGroupResponse> removeLbmHubGroupAsync(AxlNetClient.removeLbmHubGroupRequest request);
    }

    public class AXLPortClient69 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort69>, AxlNetClient.AXLPort69
    {
        public AXLPortClient69(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAudioCodecPreferenceListResponse AxlNetClient.AXLPort69.getAudioCodecPreferenceList(AxlNetClient.getAudioCodecPreferenceListRequest request)
        {
            return base.Channel.getAudioCodecPreferenceList(request);
        }

        public AxlNetClient.GetAudioCodecPreferenceListRes getAudioCodecPreferenceList(AxlNetClient.GetAudioCodecPreferenceListReq getAudioCodecPreferenceList1)
        {
            AxlNetClient.getAudioCodecPreferenceListRequest inValue = new AxlNetClient.getAudioCodecPreferenceListRequest();
            inValue.getAudioCodecPreferenceList = getAudioCodecPreferenceList1;
            AxlNetClient.getAudioCodecPreferenceListResponse retVal = ((AxlNetClient.AXLPort69)(this)).getAudioCodecPreferenceList(inValue);
            return retVal.getAudioCodecPreferenceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAudioCodecPreferenceListResponse> AxlNetClient.AXLPort69.getAudioCodecPreferenceListAsync(AxlNetClient.getAudioCodecPreferenceListRequest request)
        {
            return base.Channel.getAudioCodecPreferenceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAudioCodecPreferenceListResponse> getAudioCodecPreferenceListAsync(AxlNetClient.GetAudioCodecPreferenceListReq getAudioCodecPreferenceList)
        {
            AxlNetClient.getAudioCodecPreferenceListRequest inValue = new AxlNetClient.getAudioCodecPreferenceListRequest();
            inValue.getAudioCodecPreferenceList = getAudioCodecPreferenceList;
            return ((AxlNetClient.AXLPort69)(this)).getAudioCodecPreferenceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAudioCodecPreferenceListResponse AxlNetClient.AXLPort69.removeAudioCodecPreferenceList(AxlNetClient.removeAudioCodecPreferenceListRequest request)
        {
            return base.Channel.removeAudioCodecPreferenceList(request);
        }

        public AxlNetClient.StandardResponse removeAudioCodecPreferenceList(AxlNetClient.NameAndGUIDRequest removeAudioCodecPreferenceList1)
        {
            AxlNetClient.removeAudioCodecPreferenceListRequest inValue = new AxlNetClient.removeAudioCodecPreferenceListRequest();
            inValue.removeAudioCodecPreferenceList = removeAudioCodecPreferenceList1;
            AxlNetClient.removeAudioCodecPreferenceListResponse retVal = ((AxlNetClient.AXLPort69)(this)).removeAudioCodecPreferenceList(inValue);
            return retVal.removeAudioCodecPreferenceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAudioCodecPreferenceListResponse> AxlNetClient.AXLPort69.removeAudioCodecPreferenceListAsync(AxlNetClient.removeAudioCodecPreferenceListRequest request)
        {
            return base.Channel.removeAudioCodecPreferenceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAudioCodecPreferenceListResponse> removeAudioCodecPreferenceListAsync(AxlNetClient.NameAndGUIDRequest removeAudioCodecPreferenceList)
        {
            AxlNetClient.removeAudioCodecPreferenceListRequest inValue = new AxlNetClient.removeAudioCodecPreferenceListRequest();
            inValue.removeAudioCodecPreferenceList = removeAudioCodecPreferenceList;
            return ((AxlNetClient.AXLPort69)(this)).removeAudioCodecPreferenceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAudioCodecPreferenceListResponse AxlNetClient.AXLPort69.listAudioCodecPreferenceList(AxlNetClient.listAudioCodecPreferenceListRequest request)
        {
            return base.Channel.listAudioCodecPreferenceList(request);
        }

        public AxlNetClient.ListAudioCodecPreferenceListRes listAudioCodecPreferenceList(AxlNetClient.ListAudioCodecPreferenceListReq listAudioCodecPreferenceList1)
        {
            AxlNetClient.listAudioCodecPreferenceListRequest inValue = new AxlNetClient.listAudioCodecPreferenceListRequest();
            inValue.listAudioCodecPreferenceList = listAudioCodecPreferenceList1;
            AxlNetClient.listAudioCodecPreferenceListResponse retVal = ((AxlNetClient.AXLPort69)(this)).listAudioCodecPreferenceList(inValue);
            return retVal.listAudioCodecPreferenceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAudioCodecPreferenceListResponse> AxlNetClient.AXLPort69.listAudioCodecPreferenceListAsync(AxlNetClient.listAudioCodecPreferenceListRequest request)
        {
            return base.Channel.listAudioCodecPreferenceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAudioCodecPreferenceListResponse> listAudioCodecPreferenceListAsync(AxlNetClient.ListAudioCodecPreferenceListReq listAudioCodecPreferenceList)
        {
            AxlNetClient.listAudioCodecPreferenceListRequest inValue = new AxlNetClient.listAudioCodecPreferenceListRequest();
            inValue.listAudioCodecPreferenceList = listAudioCodecPreferenceList;
            return ((AxlNetClient.AXLPort69)(this)).listAudioCodecPreferenceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUcServiceResponse AxlNetClient.AXLPort69.addUcService(AxlNetClient.addUcServiceRequest request)
        {
            return base.Channel.addUcService(request);
        }

        public AxlNetClient.StandardResponse addUcService(AxlNetClient.AddUcServiceReq addUcService1)
        {
            AxlNetClient.addUcServiceRequest inValue = new AxlNetClient.addUcServiceRequest();
            inValue.addUcService = addUcService1;
            AxlNetClient.addUcServiceResponse retVal = ((AxlNetClient.AXLPort69)(this)).addUcService(inValue);
            return retVal.addUcServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUcServiceResponse> AxlNetClient.AXLPort69.addUcServiceAsync(AxlNetClient.addUcServiceRequest request)
        {
            return base.Channel.addUcServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUcServiceResponse> addUcServiceAsync(AxlNetClient.AddUcServiceReq addUcService)
        {
            AxlNetClient.addUcServiceRequest inValue = new AxlNetClient.addUcServiceRequest();
            inValue.addUcService = addUcService;
            return ((AxlNetClient.AXLPort69)(this)).addUcServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUcServiceResponse AxlNetClient.AXLPort69.updateUcService(AxlNetClient.updateUcServiceRequest request)
        {
            return base.Channel.updateUcService(request);
        }

        public AxlNetClient.StandardResponse updateUcService(AxlNetClient.UpdateUcServiceReq updateUcService1)
        {
            AxlNetClient.updateUcServiceRequest inValue = new AxlNetClient.updateUcServiceRequest();
            inValue.updateUcService = updateUcService1;
            AxlNetClient.updateUcServiceResponse retVal = ((AxlNetClient.AXLPort69)(this)).updateUcService(inValue);
            return retVal.updateUcServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUcServiceResponse> AxlNetClient.AXLPort69.updateUcServiceAsync(AxlNetClient.updateUcServiceRequest request)
        {
            return base.Channel.updateUcServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUcServiceResponse> updateUcServiceAsync(AxlNetClient.UpdateUcServiceReq updateUcService)
        {
            AxlNetClient.updateUcServiceRequest inValue = new AxlNetClient.updateUcServiceRequest();
            inValue.updateUcService = updateUcService;
            return ((AxlNetClient.AXLPort69)(this)).updateUcServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUcServiceResponse AxlNetClient.AXLPort69.getUcService(AxlNetClient.getUcServiceRequest request)
        {
            return base.Channel.getUcService(request);
        }

        public AxlNetClient.GetUcServiceRes getUcService(AxlNetClient.GetUcServiceReq getUcService1)
        {
            AxlNetClient.getUcServiceRequest inValue = new AxlNetClient.getUcServiceRequest();
            inValue.getUcService = getUcService1;
            AxlNetClient.getUcServiceResponse retVal = ((AxlNetClient.AXLPort69)(this)).getUcService(inValue);
            return retVal.getUcServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUcServiceResponse> AxlNetClient.AXLPort69.getUcServiceAsync(AxlNetClient.getUcServiceRequest request)
        {
            return base.Channel.getUcServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUcServiceResponse> getUcServiceAsync(AxlNetClient.GetUcServiceReq getUcService)
        {
            AxlNetClient.getUcServiceRequest inValue = new AxlNetClient.getUcServiceRequest();
            inValue.getUcService = getUcService;
            return ((AxlNetClient.AXLPort69)(this)).getUcServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUcServiceResponse AxlNetClient.AXLPort69.removeUcService(AxlNetClient.removeUcServiceRequest request)
        {
            return base.Channel.removeUcService(request);
        }

        public AxlNetClient.StandardResponse removeUcService(AxlNetClient.NameAndGUIDRequest removeUcService1)
        {
            AxlNetClient.removeUcServiceRequest inValue = new AxlNetClient.removeUcServiceRequest();
            inValue.removeUcService = removeUcService1;
            AxlNetClient.removeUcServiceResponse retVal = ((AxlNetClient.AXLPort69)(this)).removeUcService(inValue);
            return retVal.removeUcServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUcServiceResponse> AxlNetClient.AXLPort69.removeUcServiceAsync(AxlNetClient.removeUcServiceRequest request)
        {
            return base.Channel.removeUcServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUcServiceResponse> removeUcServiceAsync(AxlNetClient.NameAndGUIDRequest removeUcService)
        {
            AxlNetClient.removeUcServiceRequest inValue = new AxlNetClient.removeUcServiceRequest();
            inValue.removeUcService = removeUcService;
            return ((AxlNetClient.AXLPort69)(this)).removeUcServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUcServiceResponse AxlNetClient.AXLPort69.listUcService(AxlNetClient.listUcServiceRequest request)
        {
            return base.Channel.listUcService(request);
        }

        public AxlNetClient.ListUcServiceRes listUcService(AxlNetClient.ListUcServiceReq listUcService1)
        {
            AxlNetClient.listUcServiceRequest inValue = new AxlNetClient.listUcServiceRequest();
            inValue.listUcService = listUcService1;
            AxlNetClient.listUcServiceResponse retVal = ((AxlNetClient.AXLPort69)(this)).listUcService(inValue);
            return retVal.listUcServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUcServiceResponse> AxlNetClient.AXLPort69.listUcServiceAsync(AxlNetClient.listUcServiceRequest request)
        {
            return base.Channel.listUcServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUcServiceResponse> listUcServiceAsync(AxlNetClient.ListUcServiceReq listUcService)
        {
            AxlNetClient.listUcServiceRequest inValue = new AxlNetClient.listUcServiceRequest();
            inValue.listUcService = listUcService;
            return ((AxlNetClient.AXLPort69)(this)).listUcServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLbmHubGroupResponse AxlNetClient.AXLPort69.addLbmHubGroup(AxlNetClient.addLbmHubGroupRequest request)
        {
            return base.Channel.addLbmHubGroup(request);
        }

        public AxlNetClient.StandardResponse addLbmHubGroup(AxlNetClient.AddLbmHubGroupReq addLbmHubGroup1)
        {
            AxlNetClient.addLbmHubGroupRequest inValue = new AxlNetClient.addLbmHubGroupRequest();
            inValue.addLbmHubGroup = addLbmHubGroup1;
            AxlNetClient.addLbmHubGroupResponse retVal = ((AxlNetClient.AXLPort69)(this)).addLbmHubGroup(inValue);
            return retVal.addLbmHubGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLbmHubGroupResponse> AxlNetClient.AXLPort69.addLbmHubGroupAsync(AxlNetClient.addLbmHubGroupRequest request)
        {
            return base.Channel.addLbmHubGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLbmHubGroupResponse> addLbmHubGroupAsync(AxlNetClient.AddLbmHubGroupReq addLbmHubGroup)
        {
            AxlNetClient.addLbmHubGroupRequest inValue = new AxlNetClient.addLbmHubGroupRequest();
            inValue.addLbmHubGroup = addLbmHubGroup;
            return ((AxlNetClient.AXLPort69)(this)).addLbmHubGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLbmHubGroupResponse AxlNetClient.AXLPort69.updateLbmHubGroup(AxlNetClient.updateLbmHubGroupRequest request)
        {
            return base.Channel.updateLbmHubGroup(request);
        }

        public AxlNetClient.StandardResponse updateLbmHubGroup(AxlNetClient.UpdateLbmHubGroupReq updateLbmHubGroup1)
        {
            AxlNetClient.updateLbmHubGroupRequest inValue = new AxlNetClient.updateLbmHubGroupRequest();
            inValue.updateLbmHubGroup = updateLbmHubGroup1;
            AxlNetClient.updateLbmHubGroupResponse retVal = ((AxlNetClient.AXLPort69)(this)).updateLbmHubGroup(inValue);
            return retVal.updateLbmHubGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLbmHubGroupResponse> AxlNetClient.AXLPort69.updateLbmHubGroupAsync(AxlNetClient.updateLbmHubGroupRequest request)
        {
            return base.Channel.updateLbmHubGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLbmHubGroupResponse> updateLbmHubGroupAsync(AxlNetClient.UpdateLbmHubGroupReq updateLbmHubGroup)
        {
            AxlNetClient.updateLbmHubGroupRequest inValue = new AxlNetClient.updateLbmHubGroupRequest();
            inValue.updateLbmHubGroup = updateLbmHubGroup;
            return ((AxlNetClient.AXLPort69)(this)).updateLbmHubGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLbmHubGroupResponse AxlNetClient.AXLPort69.getLbmHubGroup(AxlNetClient.getLbmHubGroupRequest request)
        {
            return base.Channel.getLbmHubGroup(request);
        }

        public AxlNetClient.GetLbmHubGroupRes getLbmHubGroup(AxlNetClient.GetLbmHubGroupReq getLbmHubGroup1)
        {
            AxlNetClient.getLbmHubGroupRequest inValue = new AxlNetClient.getLbmHubGroupRequest();
            inValue.getLbmHubGroup = getLbmHubGroup1;
            AxlNetClient.getLbmHubGroupResponse retVal = ((AxlNetClient.AXLPort69)(this)).getLbmHubGroup(inValue);
            return retVal.getLbmHubGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLbmHubGroupResponse> AxlNetClient.AXLPort69.getLbmHubGroupAsync(AxlNetClient.getLbmHubGroupRequest request)
        {
            return base.Channel.getLbmHubGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLbmHubGroupResponse> getLbmHubGroupAsync(AxlNetClient.GetLbmHubGroupReq getLbmHubGroup)
        {
            AxlNetClient.getLbmHubGroupRequest inValue = new AxlNetClient.getLbmHubGroupRequest();
            inValue.getLbmHubGroup = getLbmHubGroup;
            return ((AxlNetClient.AXLPort69)(this)).getLbmHubGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLbmHubGroupResponse AxlNetClient.AXLPort69.removeLbmHubGroup(AxlNetClient.removeLbmHubGroupRequest request)
        {
            return base.Channel.removeLbmHubGroup(request);
        }

        public AxlNetClient.StandardResponse removeLbmHubGroup(AxlNetClient.NameAndGUIDRequest removeLbmHubGroup1)
        {
            AxlNetClient.removeLbmHubGroupRequest inValue = new AxlNetClient.removeLbmHubGroupRequest();
            inValue.removeLbmHubGroup = removeLbmHubGroup1;
            AxlNetClient.removeLbmHubGroupResponse retVal = ((AxlNetClient.AXLPort69)(this)).removeLbmHubGroup(inValue);
            return retVal.removeLbmHubGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLbmHubGroupResponse> AxlNetClient.AXLPort69.removeLbmHubGroupAsync(AxlNetClient.removeLbmHubGroupRequest request)
        {
            return base.Channel.removeLbmHubGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLbmHubGroupResponse> removeLbmHubGroupAsync(AxlNetClient.NameAndGUIDRequest removeLbmHubGroup)
        {
            AxlNetClient.removeLbmHubGroupRequest inValue = new AxlNetClient.removeLbmHubGroupRequest();
            inValue.removeLbmHubGroup = removeLbmHubGroup;
            return ((AxlNetClient.AXLPort69)(this)).removeLbmHubGroupAsync(inValue);
        }
    }
}