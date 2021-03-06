namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient60 _axlPortClient60;

        private static AXLPortClient60 axlPortClient60 => _axlPortClient60 == null ||
            _axlPortClient60.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient60 = LoadClient60()) : _axlPortClient60;

        private static AXLPortClient60 LoadClient60()
        {
            var client = new AXLPortClient60(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close60;
            OnAbort += Abort60;
            return client;
        }

        private static void Close60(object sender, System.EventArgs e)
        {
            _axlPortClient60.Close();
        }

        private static void Abort60(object sender, System.EventArgs e)
        {
            _axlPortClient60.Abort();
        }

        public AxlNetClient.StandardResponse updateImeEnrolledPattern(AxlNetClient.UpdateImeEnrolledPatternReq updateImeEnrolledPattern1)
        {
            return axlPortClient60.updateImeEnrolledPattern(updateImeEnrolledPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternResponse> updateImeEnrolledPatternAsync(AxlNetClient.UpdateImeEnrolledPatternReq updateImeEnrolledPattern)
        {
            return axlPortClient60.updateImeEnrolledPatternAsync(updateImeEnrolledPattern);
        }

        public AxlNetClient.GetImeEnrolledPatternRes getImeEnrolledPattern(AxlNetClient.GetImeEnrolledPatternReq getImeEnrolledPattern1)
        {
            return axlPortClient60.getImeEnrolledPattern(getImeEnrolledPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternResponse> getImeEnrolledPatternAsync(AxlNetClient.GetImeEnrolledPatternReq getImeEnrolledPattern)
        {
            return axlPortClient60.getImeEnrolledPatternAsync(getImeEnrolledPattern);
        }

        public AxlNetClient.StandardResponse removeImeEnrolledPattern(AxlNetClient.RemoveImeEnrolledPatternReq removeImeEnrolledPattern1)
        {
            return axlPortClient60.removeImeEnrolledPattern(removeImeEnrolledPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternResponse> removeImeEnrolledPatternAsync(AxlNetClient.RemoveImeEnrolledPatternReq removeImeEnrolledPattern)
        {
            return axlPortClient60.removeImeEnrolledPatternAsync(removeImeEnrolledPattern);
        }

        public AxlNetClient.ListImeEnrolledPatternRes listImeEnrolledPattern(AxlNetClient.ListImeEnrolledPatternReq listImeEnrolledPattern1)
        {
            return axlPortClient60.listImeEnrolledPattern(listImeEnrolledPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternResponse> listImeEnrolledPatternAsync(AxlNetClient.ListImeEnrolledPatternReq listImeEnrolledPattern)
        {
            return axlPortClient60.listImeEnrolledPatternAsync(listImeEnrolledPattern);
        }

        public AxlNetClient.StandardResponse addImeEnrolledPatternGroup(AxlNetClient.AddImeEnrolledPatternGroupReq addImeEnrolledPatternGroup1)
        {
            return axlPortClient60.addImeEnrolledPatternGroup(addImeEnrolledPatternGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternGroupResponse> addImeEnrolledPatternGroupAsync(AxlNetClient.AddImeEnrolledPatternGroupReq addImeEnrolledPatternGroup)
        {
            return axlPortClient60.addImeEnrolledPatternGroupAsync(addImeEnrolledPatternGroup);
        }

        public AxlNetClient.StandardResponse updateImeEnrolledPatternGroup(AxlNetClient.UpdateImeEnrolledPatternGroupReq updateImeEnrolledPatternGroup1)
        {
            return axlPortClient60.updateImeEnrolledPatternGroup(updateImeEnrolledPatternGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternGroupResponse> updateImeEnrolledPatternGroupAsync(AxlNetClient.UpdateImeEnrolledPatternGroupReq updateImeEnrolledPatternGroup)
        {
            return axlPortClient60.updateImeEnrolledPatternGroupAsync(updateImeEnrolledPatternGroup);
        }

        public AxlNetClient.GetImeEnrolledPatternGroupRes getImeEnrolledPatternGroup(AxlNetClient.GetImeEnrolledPatternGroupReq getImeEnrolledPatternGroup1)
        {
            return axlPortClient60.getImeEnrolledPatternGroup(getImeEnrolledPatternGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternGroupResponse> getImeEnrolledPatternGroupAsync(AxlNetClient.GetImeEnrolledPatternGroupReq getImeEnrolledPatternGroup)
        {
            return axlPortClient60.getImeEnrolledPatternGroupAsync(getImeEnrolledPatternGroup);
        }

        public AxlNetClient.StandardResponse removeImeEnrolledPatternGroup(AxlNetClient.NameAndGUIDRequest removeImeEnrolledPatternGroup1)
        {
            return axlPortClient60.removeImeEnrolledPatternGroup(removeImeEnrolledPatternGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternGroupResponse> removeImeEnrolledPatternGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeEnrolledPatternGroup)
        {
            return axlPortClient60.removeImeEnrolledPatternGroupAsync(removeImeEnrolledPatternGroup);
        }

        public AxlNetClient.ListImeEnrolledPatternGroupRes listImeEnrolledPatternGroup(AxlNetClient.ListImeEnrolledPatternGroupReq listImeEnrolledPatternGroup1)
        {
            return axlPortClient60.listImeEnrolledPatternGroup(listImeEnrolledPatternGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternGroupResponse> listImeEnrolledPatternGroupAsync(AxlNetClient.ListImeEnrolledPatternGroupReq listImeEnrolledPatternGroup)
        {
            return axlPortClient60.listImeEnrolledPatternGroupAsync(listImeEnrolledPatternGroup);
        }

        public AxlNetClient.StandardResponse addImeExclusionNumber(AxlNetClient.AddImeExclusionNumberReq addImeExclusionNumber1)
        {
            return axlPortClient60.addImeExclusionNumber(addImeExclusionNumber1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberResponse> addImeExclusionNumberAsync(AxlNetClient.AddImeExclusionNumberReq addImeExclusionNumber)
        {
            return axlPortClient60.addImeExclusionNumberAsync(addImeExclusionNumber);
        }

        public AxlNetClient.StandardResponse updateImeExclusionNumber(AxlNetClient.UpdateImeExclusionNumberReq updateImeExclusionNumber1)
        {
            return axlPortClient60.updateImeExclusionNumber(updateImeExclusionNumber1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberResponse> updateImeExclusionNumberAsync(AxlNetClient.UpdateImeExclusionNumberReq updateImeExclusionNumber)
        {
            return axlPortClient60.updateImeExclusionNumberAsync(updateImeExclusionNumber);
        }

        public AxlNetClient.GetImeExclusionNumberRes getImeExclusionNumber(AxlNetClient.GetImeExclusionNumberReq getImeExclusionNumber1)
        {
            return axlPortClient60.getImeExclusionNumber(getImeExclusionNumber1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberResponse> getImeExclusionNumberAsync(AxlNetClient.GetImeExclusionNumberReq getImeExclusionNumber)
        {
            return axlPortClient60.getImeExclusionNumberAsync(getImeExclusionNumber);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort60
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeEnrolledPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeEnrolledPatternResponse updateImeEnrolledPattern(AxlNetClient.updateImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeEnrolledPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternResponse> updateImeEnrolledPatternAsync(AxlNetClient.updateImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeEnrolledPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeEnrolledPatternResponse getImeEnrolledPattern(AxlNetClient.getImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeEnrolledPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternResponse> getImeEnrolledPatternAsync(AxlNetClient.getImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeEnrolledPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeEnrolledPatternResponse removeImeEnrolledPattern(AxlNetClient.removeImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeEnrolledPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternResponse> removeImeEnrolledPatternAsync(AxlNetClient.removeImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeEnrolledPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeEnrolledPatternResponse listImeEnrolledPattern(AxlNetClient.listImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeEnrolledPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternResponse> listImeEnrolledPatternAsync(AxlNetClient.listImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeEnrolledPatternGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeEnrolledPatternGroupResponse addImeEnrolledPatternGroup(AxlNetClient.addImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeEnrolledPatternGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternGroupResponse> addImeEnrolledPatternGroupAsync(AxlNetClient.addImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeEnrolledPatternGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeEnrolledPatternGroupResponse updateImeEnrolledPatternGroup(AxlNetClient.updateImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeEnrolledPatternGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternGroupResponse> updateImeEnrolledPatternGroupAsync(AxlNetClient.updateImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeEnrolledPatternGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeEnrolledPatternGroupResponse getImeEnrolledPatternGroup(AxlNetClient.getImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeEnrolledPatternGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternGroupResponse> getImeEnrolledPatternGroupAsync(AxlNetClient.getImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeEnrolledPatternGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeEnrolledPatternGroupResponse removeImeEnrolledPatternGroup(AxlNetClient.removeImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeEnrolledPatternGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternGroupResponse> removeImeEnrolledPatternGroupAsync(AxlNetClient.removeImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeEnrolledPatternGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeEnrolledPatternGroupResponse listImeEnrolledPatternGroup(AxlNetClient.listImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeEnrolledPatternGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternGroupResponse> listImeEnrolledPatternGroupAsync(AxlNetClient.listImeEnrolledPatternGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeExclusionNumber", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeExclusionNumberResponse addImeExclusionNumber(AxlNetClient.addImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeExclusionNumber", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberResponse> addImeExclusionNumberAsync(AxlNetClient.addImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeExclusionNumber", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeExclusionNumberResponse updateImeExclusionNumber(AxlNetClient.updateImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeExclusionNumber", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberResponse> updateImeExclusionNumberAsync(AxlNetClient.updateImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeExclusionNumber", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeExclusionNumberResponse getImeExclusionNumber(AxlNetClient.getImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeExclusionNumber", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberResponse> getImeExclusionNumberAsync(AxlNetClient.getImeExclusionNumberRequest request);
    }

    public class AXLPortClient60 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort60>, AxlNetClient.AXLPort60
    {
        public AXLPortClient60(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeEnrolledPatternResponse AxlNetClient.AXLPort60.updateImeEnrolledPattern(AxlNetClient.updateImeEnrolledPatternRequest request)
        {
            return base.Channel.updateImeEnrolledPattern(request);
        }

        public AxlNetClient.StandardResponse updateImeEnrolledPattern(AxlNetClient.UpdateImeEnrolledPatternReq updateImeEnrolledPattern1)
        {
            AxlNetClient.updateImeEnrolledPatternRequest inValue = new AxlNetClient.updateImeEnrolledPatternRequest();
            inValue.updateImeEnrolledPattern = updateImeEnrolledPattern1;
            AxlNetClient.updateImeEnrolledPatternResponse retVal = ((AxlNetClient.AXLPort60)(this)).updateImeEnrolledPattern(inValue);
            return retVal.updateImeEnrolledPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternResponse> AxlNetClient.AXLPort60.updateImeEnrolledPatternAsync(AxlNetClient.updateImeEnrolledPatternRequest request)
        {
            return base.Channel.updateImeEnrolledPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternResponse> updateImeEnrolledPatternAsync(AxlNetClient.UpdateImeEnrolledPatternReq updateImeEnrolledPattern)
        {
            AxlNetClient.updateImeEnrolledPatternRequest inValue = new AxlNetClient.updateImeEnrolledPatternRequest();
            inValue.updateImeEnrolledPattern = updateImeEnrolledPattern;
            return ((AxlNetClient.AXLPort60)(this)).updateImeEnrolledPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeEnrolledPatternResponse AxlNetClient.AXLPort60.getImeEnrolledPattern(AxlNetClient.getImeEnrolledPatternRequest request)
        {
            return base.Channel.getImeEnrolledPattern(request);
        }

        public AxlNetClient.GetImeEnrolledPatternRes getImeEnrolledPattern(AxlNetClient.GetImeEnrolledPatternReq getImeEnrolledPattern1)
        {
            AxlNetClient.getImeEnrolledPatternRequest inValue = new AxlNetClient.getImeEnrolledPatternRequest();
            inValue.getImeEnrolledPattern = getImeEnrolledPattern1;
            AxlNetClient.getImeEnrolledPatternResponse retVal = ((AxlNetClient.AXLPort60)(this)).getImeEnrolledPattern(inValue);
            return retVal.getImeEnrolledPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternResponse> AxlNetClient.AXLPort60.getImeEnrolledPatternAsync(AxlNetClient.getImeEnrolledPatternRequest request)
        {
            return base.Channel.getImeEnrolledPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternResponse> getImeEnrolledPatternAsync(AxlNetClient.GetImeEnrolledPatternReq getImeEnrolledPattern)
        {
            AxlNetClient.getImeEnrolledPatternRequest inValue = new AxlNetClient.getImeEnrolledPatternRequest();
            inValue.getImeEnrolledPattern = getImeEnrolledPattern;
            return ((AxlNetClient.AXLPort60)(this)).getImeEnrolledPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeEnrolledPatternResponse AxlNetClient.AXLPort60.removeImeEnrolledPattern(AxlNetClient.removeImeEnrolledPatternRequest request)
        {
            return base.Channel.removeImeEnrolledPattern(request);
        }

        public AxlNetClient.StandardResponse removeImeEnrolledPattern(AxlNetClient.RemoveImeEnrolledPatternReq removeImeEnrolledPattern1)
        {
            AxlNetClient.removeImeEnrolledPatternRequest inValue = new AxlNetClient.removeImeEnrolledPatternRequest();
            inValue.removeImeEnrolledPattern = removeImeEnrolledPattern1;
            AxlNetClient.removeImeEnrolledPatternResponse retVal = ((AxlNetClient.AXLPort60)(this)).removeImeEnrolledPattern(inValue);
            return retVal.removeImeEnrolledPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternResponse> AxlNetClient.AXLPort60.removeImeEnrolledPatternAsync(AxlNetClient.removeImeEnrolledPatternRequest request)
        {
            return base.Channel.removeImeEnrolledPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternResponse> removeImeEnrolledPatternAsync(AxlNetClient.RemoveImeEnrolledPatternReq removeImeEnrolledPattern)
        {
            AxlNetClient.removeImeEnrolledPatternRequest inValue = new AxlNetClient.removeImeEnrolledPatternRequest();
            inValue.removeImeEnrolledPattern = removeImeEnrolledPattern;
            return ((AxlNetClient.AXLPort60)(this)).removeImeEnrolledPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeEnrolledPatternResponse AxlNetClient.AXLPort60.listImeEnrolledPattern(AxlNetClient.listImeEnrolledPatternRequest request)
        {
            return base.Channel.listImeEnrolledPattern(request);
        }

        public AxlNetClient.ListImeEnrolledPatternRes listImeEnrolledPattern(AxlNetClient.ListImeEnrolledPatternReq listImeEnrolledPattern1)
        {
            AxlNetClient.listImeEnrolledPatternRequest inValue = new AxlNetClient.listImeEnrolledPatternRequest();
            inValue.listImeEnrolledPattern = listImeEnrolledPattern1;
            AxlNetClient.listImeEnrolledPatternResponse retVal = ((AxlNetClient.AXLPort60)(this)).listImeEnrolledPattern(inValue);
            return retVal.listImeEnrolledPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternResponse> AxlNetClient.AXLPort60.listImeEnrolledPatternAsync(AxlNetClient.listImeEnrolledPatternRequest request)
        {
            return base.Channel.listImeEnrolledPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternResponse> listImeEnrolledPatternAsync(AxlNetClient.ListImeEnrolledPatternReq listImeEnrolledPattern)
        {
            AxlNetClient.listImeEnrolledPatternRequest inValue = new AxlNetClient.listImeEnrolledPatternRequest();
            inValue.listImeEnrolledPattern = listImeEnrolledPattern;
            return ((AxlNetClient.AXLPort60)(this)).listImeEnrolledPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeEnrolledPatternGroupResponse AxlNetClient.AXLPort60.addImeEnrolledPatternGroup(AxlNetClient.addImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.addImeEnrolledPatternGroup(request);
        }

        public AxlNetClient.StandardResponse addImeEnrolledPatternGroup(AxlNetClient.AddImeEnrolledPatternGroupReq addImeEnrolledPatternGroup1)
        {
            AxlNetClient.addImeEnrolledPatternGroupRequest inValue = new AxlNetClient.addImeEnrolledPatternGroupRequest();
            inValue.addImeEnrolledPatternGroup = addImeEnrolledPatternGroup1;
            AxlNetClient.addImeEnrolledPatternGroupResponse retVal = ((AxlNetClient.AXLPort60)(this)).addImeEnrolledPatternGroup(inValue);
            return retVal.addImeEnrolledPatternGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternGroupResponse> AxlNetClient.AXLPort60.addImeEnrolledPatternGroupAsync(AxlNetClient.addImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.addImeEnrolledPatternGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternGroupResponse> addImeEnrolledPatternGroupAsync(AxlNetClient.AddImeEnrolledPatternGroupReq addImeEnrolledPatternGroup)
        {
            AxlNetClient.addImeEnrolledPatternGroupRequest inValue = new AxlNetClient.addImeEnrolledPatternGroupRequest();
            inValue.addImeEnrolledPatternGroup = addImeEnrolledPatternGroup;
            return ((AxlNetClient.AXLPort60)(this)).addImeEnrolledPatternGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeEnrolledPatternGroupResponse AxlNetClient.AXLPort60.updateImeEnrolledPatternGroup(AxlNetClient.updateImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.updateImeEnrolledPatternGroup(request);
        }

        public AxlNetClient.StandardResponse updateImeEnrolledPatternGroup(AxlNetClient.UpdateImeEnrolledPatternGroupReq updateImeEnrolledPatternGroup1)
        {
            AxlNetClient.updateImeEnrolledPatternGroupRequest inValue = new AxlNetClient.updateImeEnrolledPatternGroupRequest();
            inValue.updateImeEnrolledPatternGroup = updateImeEnrolledPatternGroup1;
            AxlNetClient.updateImeEnrolledPatternGroupResponse retVal = ((AxlNetClient.AXLPort60)(this)).updateImeEnrolledPatternGroup(inValue);
            return retVal.updateImeEnrolledPatternGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternGroupResponse> AxlNetClient.AXLPort60.updateImeEnrolledPatternGroupAsync(AxlNetClient.updateImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.updateImeEnrolledPatternGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeEnrolledPatternGroupResponse> updateImeEnrolledPatternGroupAsync(AxlNetClient.UpdateImeEnrolledPatternGroupReq updateImeEnrolledPatternGroup)
        {
            AxlNetClient.updateImeEnrolledPatternGroupRequest inValue = new AxlNetClient.updateImeEnrolledPatternGroupRequest();
            inValue.updateImeEnrolledPatternGroup = updateImeEnrolledPatternGroup;
            return ((AxlNetClient.AXLPort60)(this)).updateImeEnrolledPatternGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeEnrolledPatternGroupResponse AxlNetClient.AXLPort60.getImeEnrolledPatternGroup(AxlNetClient.getImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.getImeEnrolledPatternGroup(request);
        }

        public AxlNetClient.GetImeEnrolledPatternGroupRes getImeEnrolledPatternGroup(AxlNetClient.GetImeEnrolledPatternGroupReq getImeEnrolledPatternGroup1)
        {
            AxlNetClient.getImeEnrolledPatternGroupRequest inValue = new AxlNetClient.getImeEnrolledPatternGroupRequest();
            inValue.getImeEnrolledPatternGroup = getImeEnrolledPatternGroup1;
            AxlNetClient.getImeEnrolledPatternGroupResponse retVal = ((AxlNetClient.AXLPort60)(this)).getImeEnrolledPatternGroup(inValue);
            return retVal.getImeEnrolledPatternGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternGroupResponse> AxlNetClient.AXLPort60.getImeEnrolledPatternGroupAsync(AxlNetClient.getImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.getImeEnrolledPatternGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeEnrolledPatternGroupResponse> getImeEnrolledPatternGroupAsync(AxlNetClient.GetImeEnrolledPatternGroupReq getImeEnrolledPatternGroup)
        {
            AxlNetClient.getImeEnrolledPatternGroupRequest inValue = new AxlNetClient.getImeEnrolledPatternGroupRequest();
            inValue.getImeEnrolledPatternGroup = getImeEnrolledPatternGroup;
            return ((AxlNetClient.AXLPort60)(this)).getImeEnrolledPatternGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeEnrolledPatternGroupResponse AxlNetClient.AXLPort60.removeImeEnrolledPatternGroup(AxlNetClient.removeImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.removeImeEnrolledPatternGroup(request);
        }

        public AxlNetClient.StandardResponse removeImeEnrolledPatternGroup(AxlNetClient.NameAndGUIDRequest removeImeEnrolledPatternGroup1)
        {
            AxlNetClient.removeImeEnrolledPatternGroupRequest inValue = new AxlNetClient.removeImeEnrolledPatternGroupRequest();
            inValue.removeImeEnrolledPatternGroup = removeImeEnrolledPatternGroup1;
            AxlNetClient.removeImeEnrolledPatternGroupResponse retVal = ((AxlNetClient.AXLPort60)(this)).removeImeEnrolledPatternGroup(inValue);
            return retVal.removeImeEnrolledPatternGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternGroupResponse> AxlNetClient.AXLPort60.removeImeEnrolledPatternGroupAsync(AxlNetClient.removeImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.removeImeEnrolledPatternGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeEnrolledPatternGroupResponse> removeImeEnrolledPatternGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeEnrolledPatternGroup)
        {
            AxlNetClient.removeImeEnrolledPatternGroupRequest inValue = new AxlNetClient.removeImeEnrolledPatternGroupRequest();
            inValue.removeImeEnrolledPatternGroup = removeImeEnrolledPatternGroup;
            return ((AxlNetClient.AXLPort60)(this)).removeImeEnrolledPatternGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeEnrolledPatternGroupResponse AxlNetClient.AXLPort60.listImeEnrolledPatternGroup(AxlNetClient.listImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.listImeEnrolledPatternGroup(request);
        }

        public AxlNetClient.ListImeEnrolledPatternGroupRes listImeEnrolledPatternGroup(AxlNetClient.ListImeEnrolledPatternGroupReq listImeEnrolledPatternGroup1)
        {
            AxlNetClient.listImeEnrolledPatternGroupRequest inValue = new AxlNetClient.listImeEnrolledPatternGroupRequest();
            inValue.listImeEnrolledPatternGroup = listImeEnrolledPatternGroup1;
            AxlNetClient.listImeEnrolledPatternGroupResponse retVal = ((AxlNetClient.AXLPort60)(this)).listImeEnrolledPatternGroup(inValue);
            return retVal.listImeEnrolledPatternGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternGroupResponse> AxlNetClient.AXLPort60.listImeEnrolledPatternGroupAsync(AxlNetClient.listImeEnrolledPatternGroupRequest request)
        {
            return base.Channel.listImeEnrolledPatternGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeEnrolledPatternGroupResponse> listImeEnrolledPatternGroupAsync(AxlNetClient.ListImeEnrolledPatternGroupReq listImeEnrolledPatternGroup)
        {
            AxlNetClient.listImeEnrolledPatternGroupRequest inValue = new AxlNetClient.listImeEnrolledPatternGroupRequest();
            inValue.listImeEnrolledPatternGroup = listImeEnrolledPatternGroup;
            return ((AxlNetClient.AXLPort60)(this)).listImeEnrolledPatternGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeExclusionNumberResponse AxlNetClient.AXLPort60.addImeExclusionNumber(AxlNetClient.addImeExclusionNumberRequest request)
        {
            return base.Channel.addImeExclusionNumber(request);
        }

        public AxlNetClient.StandardResponse addImeExclusionNumber(AxlNetClient.AddImeExclusionNumberReq addImeExclusionNumber1)
        {
            AxlNetClient.addImeExclusionNumberRequest inValue = new AxlNetClient.addImeExclusionNumberRequest();
            inValue.addImeExclusionNumber = addImeExclusionNumber1;
            AxlNetClient.addImeExclusionNumberResponse retVal = ((AxlNetClient.AXLPort60)(this)).addImeExclusionNumber(inValue);
            return retVal.addImeExclusionNumberResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberResponse> AxlNetClient.AXLPort60.addImeExclusionNumberAsync(AxlNetClient.addImeExclusionNumberRequest request)
        {
            return base.Channel.addImeExclusionNumberAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberResponse> addImeExclusionNumberAsync(AxlNetClient.AddImeExclusionNumberReq addImeExclusionNumber)
        {
            AxlNetClient.addImeExclusionNumberRequest inValue = new AxlNetClient.addImeExclusionNumberRequest();
            inValue.addImeExclusionNumber = addImeExclusionNumber;
            return ((AxlNetClient.AXLPort60)(this)).addImeExclusionNumberAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeExclusionNumberResponse AxlNetClient.AXLPort60.updateImeExclusionNumber(AxlNetClient.updateImeExclusionNumberRequest request)
        {
            return base.Channel.updateImeExclusionNumber(request);
        }

        public AxlNetClient.StandardResponse updateImeExclusionNumber(AxlNetClient.UpdateImeExclusionNumberReq updateImeExclusionNumber1)
        {
            AxlNetClient.updateImeExclusionNumberRequest inValue = new AxlNetClient.updateImeExclusionNumberRequest();
            inValue.updateImeExclusionNumber = updateImeExclusionNumber1;
            AxlNetClient.updateImeExclusionNumberResponse retVal = ((AxlNetClient.AXLPort60)(this)).updateImeExclusionNumber(inValue);
            return retVal.updateImeExclusionNumberResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberResponse> AxlNetClient.AXLPort60.updateImeExclusionNumberAsync(AxlNetClient.updateImeExclusionNumberRequest request)
        {
            return base.Channel.updateImeExclusionNumberAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberResponse> updateImeExclusionNumberAsync(AxlNetClient.UpdateImeExclusionNumberReq updateImeExclusionNumber)
        {
            AxlNetClient.updateImeExclusionNumberRequest inValue = new AxlNetClient.updateImeExclusionNumberRequest();
            inValue.updateImeExclusionNumber = updateImeExclusionNumber;
            return ((AxlNetClient.AXLPort60)(this)).updateImeExclusionNumberAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeExclusionNumberResponse AxlNetClient.AXLPort60.getImeExclusionNumber(AxlNetClient.getImeExclusionNumberRequest request)
        {
            return base.Channel.getImeExclusionNumber(request);
        }

        public AxlNetClient.GetImeExclusionNumberRes getImeExclusionNumber(AxlNetClient.GetImeExclusionNumberReq getImeExclusionNumber1)
        {
            AxlNetClient.getImeExclusionNumberRequest inValue = new AxlNetClient.getImeExclusionNumberRequest();
            inValue.getImeExclusionNumber = getImeExclusionNumber1;
            AxlNetClient.getImeExclusionNumberResponse retVal = ((AxlNetClient.AXLPort60)(this)).getImeExclusionNumber(inValue);
            return retVal.getImeExclusionNumberResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberResponse> AxlNetClient.AXLPort60.getImeExclusionNumberAsync(AxlNetClient.getImeExclusionNumberRequest request)
        {
            return base.Channel.getImeExclusionNumberAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberResponse> getImeExclusionNumberAsync(AxlNetClient.GetImeExclusionNumberReq getImeExclusionNumber)
        {
            AxlNetClient.getImeExclusionNumberRequest inValue = new AxlNetClient.getImeExclusionNumberRequest();
            inValue.getImeExclusionNumber = getImeExclusionNumber;
            return ((AxlNetClient.AXLPort60)(this)).getImeExclusionNumberAsync(inValue);
        }
    }
}