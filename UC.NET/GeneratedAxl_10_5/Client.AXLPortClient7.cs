namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient7 _axlPortClient7;

        private static AXLPortClient7 axlPortClient7 => _axlPortClient7 == null ||
            _axlPortClient7.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient7 = LoadClient7()) : _axlPortClient7;

        private static AXLPortClient7 LoadClient7()
        {
            var client = new AXLPortClient7(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close7;
            OnAbort += Abort7;
            return client;
        }

        private static void Close7(object sender, System.EventArgs e)
        {
            _axlPortClient7.Close();
        }

        private static void Abort7(object sender, System.EventArgs e)
        {
            _axlPortClient7.Abort();
        }

        public AxlNetClient.ListMediaResourceListRes listMediaResourceList(AxlNetClient.ListMediaResourceListReq listMediaResourceList1)
        {
            return axlPortClient7.listMediaResourceList(listMediaResourceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMediaResourceListResponse> listMediaResourceListAsync(AxlNetClient.ListMediaResourceListReq listMediaResourceList)
        {
            return axlPortClient7.listMediaResourceListAsync(listMediaResourceList);
        }

        public AxlNetClient.StandardResponse addRegion(AxlNetClient.AddRegionReq addRegion1)
        {
            return axlPortClient7.addRegion(addRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRegionResponse> addRegionAsync(AxlNetClient.AddRegionReq addRegion)
        {
            return axlPortClient7.addRegionAsync(addRegion);
        }

        public AxlNetClient.StandardResponse updateRegion(AxlNetClient.UpdateRegionReq updateRegion1)
        {
            return axlPortClient7.updateRegion(updateRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRegionResponse> updateRegionAsync(AxlNetClient.UpdateRegionReq updateRegion)
        {
            return axlPortClient7.updateRegionAsync(updateRegion);
        }

        public AxlNetClient.GetRegionRes getRegion(AxlNetClient.GetRegionReq getRegion1)
        {
            return axlPortClient7.getRegion(getRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRegionResponse> getRegionAsync(AxlNetClient.GetRegionReq getRegion)
        {
            return axlPortClient7.getRegionAsync(getRegion);
        }

        public AxlNetClient.StandardResponse removeRegion(AxlNetClient.NameAndGUIDRequest removeRegion1)
        {
            return axlPortClient7.removeRegion(removeRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRegionResponse> removeRegionAsync(AxlNetClient.NameAndGUIDRequest removeRegion)
        {
            return axlPortClient7.removeRegionAsync(removeRegion);
        }

        public AxlNetClient.ListRegionRes listRegion(AxlNetClient.ListRegionReq listRegion1)
        {
            return axlPortClient7.listRegion(listRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRegionResponse> listRegionAsync(AxlNetClient.ListRegionReq listRegion)
        {
            return axlPortClient7.listRegionAsync(listRegion);
        }

        public AxlNetClient.StandardResponse restartRegion(AxlNetClient.NameAndGUIDRequest restartRegion1)
        {
            return axlPortClient7.restartRegion(restartRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartRegionResponse> restartRegionAsync(AxlNetClient.NameAndGUIDRequest restartRegion)
        {
            return axlPortClient7.restartRegionAsync(restartRegion);
        }

        public AxlNetClient.StandardResponse applyRegion(AxlNetClient.NameAndGUIDRequest applyRegion1)
        {
            return axlPortClient7.applyRegion(applyRegion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRegionResponse> applyRegionAsync(AxlNetClient.NameAndGUIDRequest applyRegion)
        {
            return axlPortClient7.applyRegionAsync(applyRegion);
        }

        public AxlNetClient.StandardResponse addAarGroup(AxlNetClient.AddAarGroupReq addAarGroup1)
        {
            return axlPortClient7.addAarGroup(addAarGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAarGroupResponse> addAarGroupAsync(AxlNetClient.AddAarGroupReq addAarGroup)
        {
            return axlPortClient7.addAarGroupAsync(addAarGroup);
        }

        public AxlNetClient.StandardResponse updateAarGroup(AxlNetClient.UpdateAarGroupReq updateAarGroup1)
        {
            return axlPortClient7.updateAarGroup(updateAarGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAarGroupResponse> updateAarGroupAsync(AxlNetClient.UpdateAarGroupReq updateAarGroup)
        {
            return axlPortClient7.updateAarGroupAsync(updateAarGroup);
        }

        public AxlNetClient.GetAarGroupRes getAarGroup(AxlNetClient.GetAarGroupReq getAarGroup1)
        {
            return axlPortClient7.getAarGroup(getAarGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAarGroupResponse> getAarGroupAsync(AxlNetClient.GetAarGroupReq getAarGroup)
        {
            return axlPortClient7.getAarGroupAsync(getAarGroup);
        }

        public AxlNetClient.StandardResponse removeAarGroup(AxlNetClient.NameAndGUIDRequest removeAarGroup1)
        {
            return axlPortClient7.removeAarGroup(removeAarGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAarGroupResponse> removeAarGroupAsync(AxlNetClient.NameAndGUIDRequest removeAarGroup)
        {
            return axlPortClient7.removeAarGroupAsync(removeAarGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort7
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMediaResourceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMediaResourceListResponse listMediaResourceList(AxlNetClient.listMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMediaResourceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMediaResourceListResponse> listMediaResourceListAsync(AxlNetClient.listMediaResourceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRegionResponse addRegion(AxlNetClient.addRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRegionResponse> addRegionAsync(AxlNetClient.addRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRegionResponse updateRegion(AxlNetClient.updateRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRegionResponse> updateRegionAsync(AxlNetClient.updateRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRegionResponse getRegion(AxlNetClient.getRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRegionResponse> getRegionAsync(AxlNetClient.getRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRegionResponse removeRegion(AxlNetClient.removeRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRegionResponse> removeRegionAsync(AxlNetClient.removeRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRegionResponse listRegion(AxlNetClient.listRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRegionResponse> listRegionAsync(AxlNetClient.listRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartRegionResponse restartRegion(AxlNetClient.restartRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartRegionResponse> restartRegionAsync(AxlNetClient.restartRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRegion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyRegionResponse applyRegion(AxlNetClient.applyRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRegion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyRegionResponse> applyRegionAsync(AxlNetClient.applyRegionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAarGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAarGroupResponse addAarGroup(AxlNetClient.addAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAarGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAarGroupResponse> addAarGroupAsync(AxlNetClient.addAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAarGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAarGroupResponse updateAarGroup(AxlNetClient.updateAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAarGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAarGroupResponse> updateAarGroupAsync(AxlNetClient.updateAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAarGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAarGroupResponse getAarGroup(AxlNetClient.getAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAarGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAarGroupResponse> getAarGroupAsync(AxlNetClient.getAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAarGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAarGroupResponse removeAarGroup(AxlNetClient.removeAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAarGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAarGroupResponse> removeAarGroupAsync(AxlNetClient.removeAarGroupRequest request);
    }

    public class AXLPortClient7 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort7>, AxlNetClient.AXLPort7
    {
        public AXLPortClient7(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMediaResourceListResponse AxlNetClient.AXLPort7.listMediaResourceList(AxlNetClient.listMediaResourceListRequest request)
        {
            return base.Channel.listMediaResourceList(request);
        }

        public AxlNetClient.ListMediaResourceListRes listMediaResourceList(AxlNetClient.ListMediaResourceListReq listMediaResourceList1)
        {
            AxlNetClient.listMediaResourceListRequest inValue = new AxlNetClient.listMediaResourceListRequest();
            inValue.listMediaResourceList = listMediaResourceList1;
            AxlNetClient.listMediaResourceListResponse retVal = ((AxlNetClient.AXLPort7)(this)).listMediaResourceList(inValue);
            return retVal.listMediaResourceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMediaResourceListResponse> AxlNetClient.AXLPort7.listMediaResourceListAsync(AxlNetClient.listMediaResourceListRequest request)
        {
            return base.Channel.listMediaResourceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMediaResourceListResponse> listMediaResourceListAsync(AxlNetClient.ListMediaResourceListReq listMediaResourceList)
        {
            AxlNetClient.listMediaResourceListRequest inValue = new AxlNetClient.listMediaResourceListRequest();
            inValue.listMediaResourceList = listMediaResourceList;
            return ((AxlNetClient.AXLPort7)(this)).listMediaResourceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRegionResponse AxlNetClient.AXLPort7.addRegion(AxlNetClient.addRegionRequest request)
        {
            return base.Channel.addRegion(request);
        }

        public AxlNetClient.StandardResponse addRegion(AxlNetClient.AddRegionReq addRegion1)
        {
            AxlNetClient.addRegionRequest inValue = new AxlNetClient.addRegionRequest();
            inValue.addRegion = addRegion1;
            AxlNetClient.addRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).addRegion(inValue);
            return retVal.addRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRegionResponse> AxlNetClient.AXLPort7.addRegionAsync(AxlNetClient.addRegionRequest request)
        {
            return base.Channel.addRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRegionResponse> addRegionAsync(AxlNetClient.AddRegionReq addRegion)
        {
            AxlNetClient.addRegionRequest inValue = new AxlNetClient.addRegionRequest();
            inValue.addRegion = addRegion;
            return ((AxlNetClient.AXLPort7)(this)).addRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRegionResponse AxlNetClient.AXLPort7.updateRegion(AxlNetClient.updateRegionRequest request)
        {
            return base.Channel.updateRegion(request);
        }

        public AxlNetClient.StandardResponse updateRegion(AxlNetClient.UpdateRegionReq updateRegion1)
        {
            AxlNetClient.updateRegionRequest inValue = new AxlNetClient.updateRegionRequest();
            inValue.updateRegion = updateRegion1;
            AxlNetClient.updateRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).updateRegion(inValue);
            return retVal.updateRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRegionResponse> AxlNetClient.AXLPort7.updateRegionAsync(AxlNetClient.updateRegionRequest request)
        {
            return base.Channel.updateRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRegionResponse> updateRegionAsync(AxlNetClient.UpdateRegionReq updateRegion)
        {
            AxlNetClient.updateRegionRequest inValue = new AxlNetClient.updateRegionRequest();
            inValue.updateRegion = updateRegion;
            return ((AxlNetClient.AXLPort7)(this)).updateRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRegionResponse AxlNetClient.AXLPort7.getRegion(AxlNetClient.getRegionRequest request)
        {
            return base.Channel.getRegion(request);
        }

        public AxlNetClient.GetRegionRes getRegion(AxlNetClient.GetRegionReq getRegion1)
        {
            AxlNetClient.getRegionRequest inValue = new AxlNetClient.getRegionRequest();
            inValue.getRegion = getRegion1;
            AxlNetClient.getRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).getRegion(inValue);
            return retVal.getRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRegionResponse> AxlNetClient.AXLPort7.getRegionAsync(AxlNetClient.getRegionRequest request)
        {
            return base.Channel.getRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRegionResponse> getRegionAsync(AxlNetClient.GetRegionReq getRegion)
        {
            AxlNetClient.getRegionRequest inValue = new AxlNetClient.getRegionRequest();
            inValue.getRegion = getRegion;
            return ((AxlNetClient.AXLPort7)(this)).getRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRegionResponse AxlNetClient.AXLPort7.removeRegion(AxlNetClient.removeRegionRequest request)
        {
            return base.Channel.removeRegion(request);
        }

        public AxlNetClient.StandardResponse removeRegion(AxlNetClient.NameAndGUIDRequest removeRegion1)
        {
            AxlNetClient.removeRegionRequest inValue = new AxlNetClient.removeRegionRequest();
            inValue.removeRegion = removeRegion1;
            AxlNetClient.removeRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).removeRegion(inValue);
            return retVal.removeRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRegionResponse> AxlNetClient.AXLPort7.removeRegionAsync(AxlNetClient.removeRegionRequest request)
        {
            return base.Channel.removeRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRegionResponse> removeRegionAsync(AxlNetClient.NameAndGUIDRequest removeRegion)
        {
            AxlNetClient.removeRegionRequest inValue = new AxlNetClient.removeRegionRequest();
            inValue.removeRegion = removeRegion;
            return ((AxlNetClient.AXLPort7)(this)).removeRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRegionResponse AxlNetClient.AXLPort7.listRegion(AxlNetClient.listRegionRequest request)
        {
            return base.Channel.listRegion(request);
        }

        public AxlNetClient.ListRegionRes listRegion(AxlNetClient.ListRegionReq listRegion1)
        {
            AxlNetClient.listRegionRequest inValue = new AxlNetClient.listRegionRequest();
            inValue.listRegion = listRegion1;
            AxlNetClient.listRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).listRegion(inValue);
            return retVal.listRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRegionResponse> AxlNetClient.AXLPort7.listRegionAsync(AxlNetClient.listRegionRequest request)
        {
            return base.Channel.listRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRegionResponse> listRegionAsync(AxlNetClient.ListRegionReq listRegion)
        {
            AxlNetClient.listRegionRequest inValue = new AxlNetClient.listRegionRequest();
            inValue.listRegion = listRegion;
            return ((AxlNetClient.AXLPort7)(this)).listRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartRegionResponse AxlNetClient.AXLPort7.restartRegion(AxlNetClient.restartRegionRequest request)
        {
            return base.Channel.restartRegion(request);
        }

        public AxlNetClient.StandardResponse restartRegion(AxlNetClient.NameAndGUIDRequest restartRegion1)
        {
            AxlNetClient.restartRegionRequest inValue = new AxlNetClient.restartRegionRequest();
            inValue.restartRegion = restartRegion1;
            AxlNetClient.restartRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).restartRegion(inValue);
            return retVal.restartRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartRegionResponse> AxlNetClient.AXLPort7.restartRegionAsync(AxlNetClient.restartRegionRequest request)
        {
            return base.Channel.restartRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartRegionResponse> restartRegionAsync(AxlNetClient.NameAndGUIDRequest restartRegion)
        {
            AxlNetClient.restartRegionRequest inValue = new AxlNetClient.restartRegionRequest();
            inValue.restartRegion = restartRegion;
            return ((AxlNetClient.AXLPort7)(this)).restartRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyRegionResponse AxlNetClient.AXLPort7.applyRegion(AxlNetClient.applyRegionRequest request)
        {
            return base.Channel.applyRegion(request);
        }

        public AxlNetClient.StandardResponse applyRegion(AxlNetClient.NameAndGUIDRequest applyRegion1)
        {
            AxlNetClient.applyRegionRequest inValue = new AxlNetClient.applyRegionRequest();
            inValue.applyRegion = applyRegion1;
            AxlNetClient.applyRegionResponse retVal = ((AxlNetClient.AXLPort7)(this)).applyRegion(inValue);
            return retVal.applyRegionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyRegionResponse> AxlNetClient.AXLPort7.applyRegionAsync(AxlNetClient.applyRegionRequest request)
        {
            return base.Channel.applyRegionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRegionResponse> applyRegionAsync(AxlNetClient.NameAndGUIDRequest applyRegion)
        {
            AxlNetClient.applyRegionRequest inValue = new AxlNetClient.applyRegionRequest();
            inValue.applyRegion = applyRegion;
            return ((AxlNetClient.AXLPort7)(this)).applyRegionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAarGroupResponse AxlNetClient.AXLPort7.addAarGroup(AxlNetClient.addAarGroupRequest request)
        {
            return base.Channel.addAarGroup(request);
        }

        public AxlNetClient.StandardResponse addAarGroup(AxlNetClient.AddAarGroupReq addAarGroup1)
        {
            AxlNetClient.addAarGroupRequest inValue = new AxlNetClient.addAarGroupRequest();
            inValue.addAarGroup = addAarGroup1;
            AxlNetClient.addAarGroupResponse retVal = ((AxlNetClient.AXLPort7)(this)).addAarGroup(inValue);
            return retVal.addAarGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAarGroupResponse> AxlNetClient.AXLPort7.addAarGroupAsync(AxlNetClient.addAarGroupRequest request)
        {
            return base.Channel.addAarGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAarGroupResponse> addAarGroupAsync(AxlNetClient.AddAarGroupReq addAarGroup)
        {
            AxlNetClient.addAarGroupRequest inValue = new AxlNetClient.addAarGroupRequest();
            inValue.addAarGroup = addAarGroup;
            return ((AxlNetClient.AXLPort7)(this)).addAarGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAarGroupResponse AxlNetClient.AXLPort7.updateAarGroup(AxlNetClient.updateAarGroupRequest request)
        {
            return base.Channel.updateAarGroup(request);
        }

        public AxlNetClient.StandardResponse updateAarGroup(AxlNetClient.UpdateAarGroupReq updateAarGroup1)
        {
            AxlNetClient.updateAarGroupRequest inValue = new AxlNetClient.updateAarGroupRequest();
            inValue.updateAarGroup = updateAarGroup1;
            AxlNetClient.updateAarGroupResponse retVal = ((AxlNetClient.AXLPort7)(this)).updateAarGroup(inValue);
            return retVal.updateAarGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAarGroupResponse> AxlNetClient.AXLPort7.updateAarGroupAsync(AxlNetClient.updateAarGroupRequest request)
        {
            return base.Channel.updateAarGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAarGroupResponse> updateAarGroupAsync(AxlNetClient.UpdateAarGroupReq updateAarGroup)
        {
            AxlNetClient.updateAarGroupRequest inValue = new AxlNetClient.updateAarGroupRequest();
            inValue.updateAarGroup = updateAarGroup;
            return ((AxlNetClient.AXLPort7)(this)).updateAarGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAarGroupResponse AxlNetClient.AXLPort7.getAarGroup(AxlNetClient.getAarGroupRequest request)
        {
            return base.Channel.getAarGroup(request);
        }

        public AxlNetClient.GetAarGroupRes getAarGroup(AxlNetClient.GetAarGroupReq getAarGroup1)
        {
            AxlNetClient.getAarGroupRequest inValue = new AxlNetClient.getAarGroupRequest();
            inValue.getAarGroup = getAarGroup1;
            AxlNetClient.getAarGroupResponse retVal = ((AxlNetClient.AXLPort7)(this)).getAarGroup(inValue);
            return retVal.getAarGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAarGroupResponse> AxlNetClient.AXLPort7.getAarGroupAsync(AxlNetClient.getAarGroupRequest request)
        {
            return base.Channel.getAarGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAarGroupResponse> getAarGroupAsync(AxlNetClient.GetAarGroupReq getAarGroup)
        {
            AxlNetClient.getAarGroupRequest inValue = new AxlNetClient.getAarGroupRequest();
            inValue.getAarGroup = getAarGroup;
            return ((AxlNetClient.AXLPort7)(this)).getAarGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAarGroupResponse AxlNetClient.AXLPort7.removeAarGroup(AxlNetClient.removeAarGroupRequest request)
        {
            return base.Channel.removeAarGroup(request);
        }

        public AxlNetClient.StandardResponse removeAarGroup(AxlNetClient.NameAndGUIDRequest removeAarGroup1)
        {
            AxlNetClient.removeAarGroupRequest inValue = new AxlNetClient.removeAarGroupRequest();
            inValue.removeAarGroup = removeAarGroup1;
            AxlNetClient.removeAarGroupResponse retVal = ((AxlNetClient.AXLPort7)(this)).removeAarGroup(inValue);
            return retVal.removeAarGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAarGroupResponse> AxlNetClient.AXLPort7.removeAarGroupAsync(AxlNetClient.removeAarGroupRequest request)
        {
            return base.Channel.removeAarGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAarGroupResponse> removeAarGroupAsync(AxlNetClient.NameAndGUIDRequest removeAarGroup)
        {
            AxlNetClient.removeAarGroupRequest inValue = new AxlNetClient.removeAarGroupRequest();
            inValue.removeAarGroup = removeAarGroup;
            return ((AxlNetClient.AXLPort7)(this)).removeAarGroupAsync(inValue);
        }
    }
}