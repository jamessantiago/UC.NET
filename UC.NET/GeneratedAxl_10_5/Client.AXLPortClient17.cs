namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient17 _axlPortClient17;

        private static AXLPortClient17 axlPortClient17 => _axlPortClient17 == null ||
            _axlPortClient17.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient17 = LoadClient17()) : _axlPortClient17;

        private static AXLPortClient17 LoadClient17()
        {
            var client = new AXLPortClient17(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close17;
            OnAbort += Abort17;
            return client;
        }

        private static void Close17(object sender, System.EventArgs e)
        {
            _axlPortClient17.Close();
        }

        private static void Abort17(object sender, System.EventArgs e)
        {
            _axlPortClient17.Abort();
        }

        public AxlNetClient.StandardResponse addRouteFilter(AxlNetClient.AddRouteFilterReq addRouteFilter1)
        {
            return axlPortClient17.addRouteFilter(addRouteFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteFilterResponse> addRouteFilterAsync(AxlNetClient.AddRouteFilterReq addRouteFilter)
        {
            return axlPortClient17.addRouteFilterAsync(addRouteFilter);
        }

        public AxlNetClient.StandardResponse updateRouteFilter(AxlNetClient.UpdateRouteFilterReq updateRouteFilter1)
        {
            return axlPortClient17.updateRouteFilter(updateRouteFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteFilterResponse> updateRouteFilterAsync(AxlNetClient.UpdateRouteFilterReq updateRouteFilter)
        {
            return axlPortClient17.updateRouteFilterAsync(updateRouteFilter);
        }

        public AxlNetClient.GetRouteFilterRes getRouteFilter(AxlNetClient.GetRouteFilterReq getRouteFilter1)
        {
            return axlPortClient17.getRouteFilter(getRouteFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteFilterResponse> getRouteFilterAsync(AxlNetClient.GetRouteFilterReq getRouteFilter)
        {
            return axlPortClient17.getRouteFilterAsync(getRouteFilter);
        }

        public AxlNetClient.StandardResponse removeRouteFilter(AxlNetClient.NameAndGUIDRequest removeRouteFilter1)
        {
            return axlPortClient17.removeRouteFilter(removeRouteFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteFilterResponse> removeRouteFilterAsync(AxlNetClient.NameAndGUIDRequest removeRouteFilter)
        {
            return axlPortClient17.removeRouteFilterAsync(removeRouteFilter);
        }

        public AxlNetClient.ListRouteFilterRes listRouteFilter(AxlNetClient.ListRouteFilterReq listRouteFilter1)
        {
            return axlPortClient17.listRouteFilter(listRouteFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteFilterResponse> listRouteFilterAsync(AxlNetClient.ListRouteFilterReq listRouteFilter)
        {
            return axlPortClient17.listRouteFilterAsync(listRouteFilter);
        }

        public AxlNetClient.StandardResponse addCallManagerGroup(AxlNetClient.AddCallManagerGroupReq addCallManagerGroup1)
        {
            return axlPortClient17.addCallManagerGroup(addCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallManagerGroupResponse> addCallManagerGroupAsync(AxlNetClient.AddCallManagerGroupReq addCallManagerGroup)
        {
            return axlPortClient17.addCallManagerGroupAsync(addCallManagerGroup);
        }

        public AxlNetClient.StandardResponse updateCallManagerGroup(AxlNetClient.UpdateCallManagerGroupReq updateCallManagerGroup1)
        {
            return axlPortClient17.updateCallManagerGroup(updateCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallManagerGroupResponse> updateCallManagerGroupAsync(AxlNetClient.UpdateCallManagerGroupReq updateCallManagerGroup)
        {
            return axlPortClient17.updateCallManagerGroupAsync(updateCallManagerGroup);
        }

        public AxlNetClient.GetCallManagerGroupRes getCallManagerGroup(AxlNetClient.GetCallManagerGroupReq getCallManagerGroup1)
        {
            return axlPortClient17.getCallManagerGroup(getCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallManagerGroupResponse> getCallManagerGroupAsync(AxlNetClient.GetCallManagerGroupReq getCallManagerGroup)
        {
            return axlPortClient17.getCallManagerGroupAsync(getCallManagerGroup);
        }

        public AxlNetClient.StandardResponse removeCallManagerGroup(AxlNetClient.NameAndGUIDRequest removeCallManagerGroup1)
        {
            return axlPortClient17.removeCallManagerGroup(removeCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallManagerGroupResponse> removeCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest removeCallManagerGroup)
        {
            return axlPortClient17.removeCallManagerGroupAsync(removeCallManagerGroup);
        }

        public AxlNetClient.ListCallManagerGroupRes listCallManagerGroup(AxlNetClient.ListCallManagerGroupReq listCallManagerGroup1)
        {
            return axlPortClient17.listCallManagerGroup(listCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallManagerGroupResponse> listCallManagerGroupAsync(AxlNetClient.ListCallManagerGroupReq listCallManagerGroup)
        {
            return axlPortClient17.listCallManagerGroupAsync(listCallManagerGroup);
        }

        public AxlNetClient.StandardResponse resetCallManagerGroup(AxlNetClient.NameAndGUIDRequest resetCallManagerGroup1)
        {
            return axlPortClient17.resetCallManagerGroup(resetCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCallManagerGroupResponse> resetCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest resetCallManagerGroup)
        {
            return axlPortClient17.resetCallManagerGroupAsync(resetCallManagerGroup);
        }

        public AxlNetClient.StandardResponse applyCallManagerGroup(AxlNetClient.NameAndGUIDRequest applyCallManagerGroup1)
        {
            return axlPortClient17.applyCallManagerGroup(applyCallManagerGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCallManagerGroupResponse> applyCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest applyCallManagerGroup)
        {
            return axlPortClient17.applyCallManagerGroupAsync(applyCallManagerGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort17
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRouteFilterResponse addRouteFilter(AxlNetClient.addRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRouteFilterResponse> addRouteFilterAsync(AxlNetClient.addRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRouteFilterResponse updateRouteFilter(AxlNetClient.updateRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteFilterResponse> updateRouteFilterAsync(AxlNetClient.updateRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRouteFilterResponse getRouteFilter(AxlNetClient.getRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRouteFilterResponse> getRouteFilterAsync(AxlNetClient.getRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRouteFilterResponse removeRouteFilter(AxlNetClient.removeRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteFilterResponse> removeRouteFilterAsync(AxlNetClient.removeRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRouteFilterResponse listRouteFilter(AxlNetClient.listRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRouteFilterResponse> listRouteFilterAsync(AxlNetClient.listRouteFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCallManagerGroupResponse addCallManagerGroup(AxlNetClient.addCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCallManagerGroupResponse> addCallManagerGroupAsync(AxlNetClient.addCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallManagerGroupResponse updateCallManagerGroup(AxlNetClient.updateCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallManagerGroupResponse> updateCallManagerGroupAsync(AxlNetClient.updateCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallManagerGroupResponse getCallManagerGroup(AxlNetClient.getCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallManagerGroupResponse> getCallManagerGroupAsync(AxlNetClient.getCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCallManagerGroupResponse removeCallManagerGroup(AxlNetClient.removeCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCallManagerGroupResponse> removeCallManagerGroupAsync(AxlNetClient.removeCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallManagerGroupResponse listCallManagerGroup(AxlNetClient.listCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallManagerGroupResponse> listCallManagerGroupAsync(AxlNetClient.listCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCallManagerGroupResponse resetCallManagerGroup(AxlNetClient.resetCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCallManagerGroupResponse> resetCallManagerGroupAsync(AxlNetClient.resetCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCallManagerGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCallManagerGroupResponse applyCallManagerGroup(AxlNetClient.applyCallManagerGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCallManagerGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCallManagerGroupResponse> applyCallManagerGroupAsync(AxlNetClient.applyCallManagerGroupRequest request);
    }

    public class AXLPortClient17 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort17>, AxlNetClient.AXLPort17
    {
        public AXLPortClient17(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRouteFilterResponse AxlNetClient.AXLPort17.addRouteFilter(AxlNetClient.addRouteFilterRequest request)
        {
            return base.Channel.addRouteFilter(request);
        }

        public AxlNetClient.StandardResponse addRouteFilter(AxlNetClient.AddRouteFilterReq addRouteFilter1)
        {
            AxlNetClient.addRouteFilterRequest inValue = new AxlNetClient.addRouteFilterRequest();
            inValue.addRouteFilter = addRouteFilter1;
            AxlNetClient.addRouteFilterResponse retVal = ((AxlNetClient.AXLPort17)(this)).addRouteFilter(inValue);
            return retVal.addRouteFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRouteFilterResponse> AxlNetClient.AXLPort17.addRouteFilterAsync(AxlNetClient.addRouteFilterRequest request)
        {
            return base.Channel.addRouteFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteFilterResponse> addRouteFilterAsync(AxlNetClient.AddRouteFilterReq addRouteFilter)
        {
            AxlNetClient.addRouteFilterRequest inValue = new AxlNetClient.addRouteFilterRequest();
            inValue.addRouteFilter = addRouteFilter;
            return ((AxlNetClient.AXLPort17)(this)).addRouteFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRouteFilterResponse AxlNetClient.AXLPort17.updateRouteFilter(AxlNetClient.updateRouteFilterRequest request)
        {
            return base.Channel.updateRouteFilter(request);
        }

        public AxlNetClient.StandardResponse updateRouteFilter(AxlNetClient.UpdateRouteFilterReq updateRouteFilter1)
        {
            AxlNetClient.updateRouteFilterRequest inValue = new AxlNetClient.updateRouteFilterRequest();
            inValue.updateRouteFilter = updateRouteFilter1;
            AxlNetClient.updateRouteFilterResponse retVal = ((AxlNetClient.AXLPort17)(this)).updateRouteFilter(inValue);
            return retVal.updateRouteFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteFilterResponse> AxlNetClient.AXLPort17.updateRouteFilterAsync(AxlNetClient.updateRouteFilterRequest request)
        {
            return base.Channel.updateRouteFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteFilterResponse> updateRouteFilterAsync(AxlNetClient.UpdateRouteFilterReq updateRouteFilter)
        {
            AxlNetClient.updateRouteFilterRequest inValue = new AxlNetClient.updateRouteFilterRequest();
            inValue.updateRouteFilter = updateRouteFilter;
            return ((AxlNetClient.AXLPort17)(this)).updateRouteFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRouteFilterResponse AxlNetClient.AXLPort17.getRouteFilter(AxlNetClient.getRouteFilterRequest request)
        {
            return base.Channel.getRouteFilter(request);
        }

        public AxlNetClient.GetRouteFilterRes getRouteFilter(AxlNetClient.GetRouteFilterReq getRouteFilter1)
        {
            AxlNetClient.getRouteFilterRequest inValue = new AxlNetClient.getRouteFilterRequest();
            inValue.getRouteFilter = getRouteFilter1;
            AxlNetClient.getRouteFilterResponse retVal = ((AxlNetClient.AXLPort17)(this)).getRouteFilter(inValue);
            return retVal.getRouteFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRouteFilterResponse> AxlNetClient.AXLPort17.getRouteFilterAsync(AxlNetClient.getRouteFilterRequest request)
        {
            return base.Channel.getRouteFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteFilterResponse> getRouteFilterAsync(AxlNetClient.GetRouteFilterReq getRouteFilter)
        {
            AxlNetClient.getRouteFilterRequest inValue = new AxlNetClient.getRouteFilterRequest();
            inValue.getRouteFilter = getRouteFilter;
            return ((AxlNetClient.AXLPort17)(this)).getRouteFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRouteFilterResponse AxlNetClient.AXLPort17.removeRouteFilter(AxlNetClient.removeRouteFilterRequest request)
        {
            return base.Channel.removeRouteFilter(request);
        }

        public AxlNetClient.StandardResponse removeRouteFilter(AxlNetClient.NameAndGUIDRequest removeRouteFilter1)
        {
            AxlNetClient.removeRouteFilterRequest inValue = new AxlNetClient.removeRouteFilterRequest();
            inValue.removeRouteFilter = removeRouteFilter1;
            AxlNetClient.removeRouteFilterResponse retVal = ((AxlNetClient.AXLPort17)(this)).removeRouteFilter(inValue);
            return retVal.removeRouteFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteFilterResponse> AxlNetClient.AXLPort17.removeRouteFilterAsync(AxlNetClient.removeRouteFilterRequest request)
        {
            return base.Channel.removeRouteFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteFilterResponse> removeRouteFilterAsync(AxlNetClient.NameAndGUIDRequest removeRouteFilter)
        {
            AxlNetClient.removeRouteFilterRequest inValue = new AxlNetClient.removeRouteFilterRequest();
            inValue.removeRouteFilter = removeRouteFilter;
            return ((AxlNetClient.AXLPort17)(this)).removeRouteFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRouteFilterResponse AxlNetClient.AXLPort17.listRouteFilter(AxlNetClient.listRouteFilterRequest request)
        {
            return base.Channel.listRouteFilter(request);
        }

        public AxlNetClient.ListRouteFilterRes listRouteFilter(AxlNetClient.ListRouteFilterReq listRouteFilter1)
        {
            AxlNetClient.listRouteFilterRequest inValue = new AxlNetClient.listRouteFilterRequest();
            inValue.listRouteFilter = listRouteFilter1;
            AxlNetClient.listRouteFilterResponse retVal = ((AxlNetClient.AXLPort17)(this)).listRouteFilter(inValue);
            return retVal.listRouteFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRouteFilterResponse> AxlNetClient.AXLPort17.listRouteFilterAsync(AxlNetClient.listRouteFilterRequest request)
        {
            return base.Channel.listRouteFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteFilterResponse> listRouteFilterAsync(AxlNetClient.ListRouteFilterReq listRouteFilter)
        {
            AxlNetClient.listRouteFilterRequest inValue = new AxlNetClient.listRouteFilterRequest();
            inValue.listRouteFilter = listRouteFilter;
            return ((AxlNetClient.AXLPort17)(this)).listRouteFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCallManagerGroupResponse AxlNetClient.AXLPort17.addCallManagerGroup(AxlNetClient.addCallManagerGroupRequest request)
        {
            return base.Channel.addCallManagerGroup(request);
        }

        public AxlNetClient.StandardResponse addCallManagerGroup(AxlNetClient.AddCallManagerGroupReq addCallManagerGroup1)
        {
            AxlNetClient.addCallManagerGroupRequest inValue = new AxlNetClient.addCallManagerGroupRequest();
            inValue.addCallManagerGroup = addCallManagerGroup1;
            AxlNetClient.addCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).addCallManagerGroup(inValue);
            return retVal.addCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCallManagerGroupResponse> AxlNetClient.AXLPort17.addCallManagerGroupAsync(AxlNetClient.addCallManagerGroupRequest request)
        {
            return base.Channel.addCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallManagerGroupResponse> addCallManagerGroupAsync(AxlNetClient.AddCallManagerGroupReq addCallManagerGroup)
        {
            AxlNetClient.addCallManagerGroupRequest inValue = new AxlNetClient.addCallManagerGroupRequest();
            inValue.addCallManagerGroup = addCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).addCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallManagerGroupResponse AxlNetClient.AXLPort17.updateCallManagerGroup(AxlNetClient.updateCallManagerGroupRequest request)
        {
            return base.Channel.updateCallManagerGroup(request);
        }

        public AxlNetClient.StandardResponse updateCallManagerGroup(AxlNetClient.UpdateCallManagerGroupReq updateCallManagerGroup1)
        {
            AxlNetClient.updateCallManagerGroupRequest inValue = new AxlNetClient.updateCallManagerGroupRequest();
            inValue.updateCallManagerGroup = updateCallManagerGroup1;
            AxlNetClient.updateCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).updateCallManagerGroup(inValue);
            return retVal.updateCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallManagerGroupResponse> AxlNetClient.AXLPort17.updateCallManagerGroupAsync(AxlNetClient.updateCallManagerGroupRequest request)
        {
            return base.Channel.updateCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallManagerGroupResponse> updateCallManagerGroupAsync(AxlNetClient.UpdateCallManagerGroupReq updateCallManagerGroup)
        {
            AxlNetClient.updateCallManagerGroupRequest inValue = new AxlNetClient.updateCallManagerGroupRequest();
            inValue.updateCallManagerGroup = updateCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).updateCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallManagerGroupResponse AxlNetClient.AXLPort17.getCallManagerGroup(AxlNetClient.getCallManagerGroupRequest request)
        {
            return base.Channel.getCallManagerGroup(request);
        }

        public AxlNetClient.GetCallManagerGroupRes getCallManagerGroup(AxlNetClient.GetCallManagerGroupReq getCallManagerGroup1)
        {
            AxlNetClient.getCallManagerGroupRequest inValue = new AxlNetClient.getCallManagerGroupRequest();
            inValue.getCallManagerGroup = getCallManagerGroup1;
            AxlNetClient.getCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).getCallManagerGroup(inValue);
            return retVal.getCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallManagerGroupResponse> AxlNetClient.AXLPort17.getCallManagerGroupAsync(AxlNetClient.getCallManagerGroupRequest request)
        {
            return base.Channel.getCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallManagerGroupResponse> getCallManagerGroupAsync(AxlNetClient.GetCallManagerGroupReq getCallManagerGroup)
        {
            AxlNetClient.getCallManagerGroupRequest inValue = new AxlNetClient.getCallManagerGroupRequest();
            inValue.getCallManagerGroup = getCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).getCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCallManagerGroupResponse AxlNetClient.AXLPort17.removeCallManagerGroup(AxlNetClient.removeCallManagerGroupRequest request)
        {
            return base.Channel.removeCallManagerGroup(request);
        }

        public AxlNetClient.StandardResponse removeCallManagerGroup(AxlNetClient.NameAndGUIDRequest removeCallManagerGroup1)
        {
            AxlNetClient.removeCallManagerGroupRequest inValue = new AxlNetClient.removeCallManagerGroupRequest();
            inValue.removeCallManagerGroup = removeCallManagerGroup1;
            AxlNetClient.removeCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).removeCallManagerGroup(inValue);
            return retVal.removeCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCallManagerGroupResponse> AxlNetClient.AXLPort17.removeCallManagerGroupAsync(AxlNetClient.removeCallManagerGroupRequest request)
        {
            return base.Channel.removeCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallManagerGroupResponse> removeCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest removeCallManagerGroup)
        {
            AxlNetClient.removeCallManagerGroupRequest inValue = new AxlNetClient.removeCallManagerGroupRequest();
            inValue.removeCallManagerGroup = removeCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).removeCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallManagerGroupResponse AxlNetClient.AXLPort17.listCallManagerGroup(AxlNetClient.listCallManagerGroupRequest request)
        {
            return base.Channel.listCallManagerGroup(request);
        }

        public AxlNetClient.ListCallManagerGroupRes listCallManagerGroup(AxlNetClient.ListCallManagerGroupReq listCallManagerGroup1)
        {
            AxlNetClient.listCallManagerGroupRequest inValue = new AxlNetClient.listCallManagerGroupRequest();
            inValue.listCallManagerGroup = listCallManagerGroup1;
            AxlNetClient.listCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).listCallManagerGroup(inValue);
            return retVal.listCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallManagerGroupResponse> AxlNetClient.AXLPort17.listCallManagerGroupAsync(AxlNetClient.listCallManagerGroupRequest request)
        {
            return base.Channel.listCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallManagerGroupResponse> listCallManagerGroupAsync(AxlNetClient.ListCallManagerGroupReq listCallManagerGroup)
        {
            AxlNetClient.listCallManagerGroupRequest inValue = new AxlNetClient.listCallManagerGroupRequest();
            inValue.listCallManagerGroup = listCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).listCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCallManagerGroupResponse AxlNetClient.AXLPort17.resetCallManagerGroup(AxlNetClient.resetCallManagerGroupRequest request)
        {
            return base.Channel.resetCallManagerGroup(request);
        }

        public AxlNetClient.StandardResponse resetCallManagerGroup(AxlNetClient.NameAndGUIDRequest resetCallManagerGroup1)
        {
            AxlNetClient.resetCallManagerGroupRequest inValue = new AxlNetClient.resetCallManagerGroupRequest();
            inValue.resetCallManagerGroup = resetCallManagerGroup1;
            AxlNetClient.resetCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).resetCallManagerGroup(inValue);
            return retVal.resetCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCallManagerGroupResponse> AxlNetClient.AXLPort17.resetCallManagerGroupAsync(AxlNetClient.resetCallManagerGroupRequest request)
        {
            return base.Channel.resetCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCallManagerGroupResponse> resetCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest resetCallManagerGroup)
        {
            AxlNetClient.resetCallManagerGroupRequest inValue = new AxlNetClient.resetCallManagerGroupRequest();
            inValue.resetCallManagerGroup = resetCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).resetCallManagerGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCallManagerGroupResponse AxlNetClient.AXLPort17.applyCallManagerGroup(AxlNetClient.applyCallManagerGroupRequest request)
        {
            return base.Channel.applyCallManagerGroup(request);
        }

        public AxlNetClient.StandardResponse applyCallManagerGroup(AxlNetClient.NameAndGUIDRequest applyCallManagerGroup1)
        {
            AxlNetClient.applyCallManagerGroupRequest inValue = new AxlNetClient.applyCallManagerGroupRequest();
            inValue.applyCallManagerGroup = applyCallManagerGroup1;
            AxlNetClient.applyCallManagerGroupResponse retVal = ((AxlNetClient.AXLPort17)(this)).applyCallManagerGroup(inValue);
            return retVal.applyCallManagerGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCallManagerGroupResponse> AxlNetClient.AXLPort17.applyCallManagerGroupAsync(AxlNetClient.applyCallManagerGroupRequest request)
        {
            return base.Channel.applyCallManagerGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCallManagerGroupResponse> applyCallManagerGroupAsync(AxlNetClient.NameAndGUIDRequest applyCallManagerGroup)
        {
            AxlNetClient.applyCallManagerGroupRequest inValue = new AxlNetClient.applyCallManagerGroupRequest();
            inValue.applyCallManagerGroup = applyCallManagerGroup;
            return ((AxlNetClient.AXLPort17)(this)).applyCallManagerGroupAsync(inValue);
        }
    }
}