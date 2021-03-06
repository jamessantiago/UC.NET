namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient61 _axlPortClient61;

        private static AXLPortClient61 axlPortClient61 => _axlPortClient61 == null ||
            _axlPortClient61.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient61 = LoadClient61()) : _axlPortClient61;

        private static AXLPortClient61 LoadClient61()
        {
            var client = new AXLPortClient61(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close61;
            OnAbort += Abort61;
            return client;
        }

        private static void Close61(object sender, System.EventArgs e)
        {
            _axlPortClient61.Close();
        }

        private static void Abort61(object sender, System.EventArgs e)
        {
            _axlPortClient61.Abort();
        }

        public AxlNetClient.StandardResponse removeImeExclusionNumber(AxlNetClient.RemoveImeExclusionNumberReq removeImeExclusionNumber1)
        {
            return axlPortClient61.removeImeExclusionNumber(removeImeExclusionNumber1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberResponse> removeImeExclusionNumberAsync(AxlNetClient.RemoveImeExclusionNumberReq removeImeExclusionNumber)
        {
            return axlPortClient61.removeImeExclusionNumberAsync(removeImeExclusionNumber);
        }

        public AxlNetClient.ListImeExclusionNumberRes listImeExclusionNumber(AxlNetClient.ListImeExclusionNumberReq listImeExclusionNumber1)
        {
            return axlPortClient61.listImeExclusionNumber(listImeExclusionNumber1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberResponse> listImeExclusionNumberAsync(AxlNetClient.ListImeExclusionNumberReq listImeExclusionNumber)
        {
            return axlPortClient61.listImeExclusionNumberAsync(listImeExclusionNumber);
        }

        public AxlNetClient.StandardResponse addImeExclusionNumberGroup(AxlNetClient.AddImeExclusionNumberGroupReq addImeExclusionNumberGroup1)
        {
            return axlPortClient61.addImeExclusionNumberGroup(addImeExclusionNumberGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberGroupResponse> addImeExclusionNumberGroupAsync(AxlNetClient.AddImeExclusionNumberGroupReq addImeExclusionNumberGroup)
        {
            return axlPortClient61.addImeExclusionNumberGroupAsync(addImeExclusionNumberGroup);
        }

        public AxlNetClient.StandardResponse updateImeExclusionNumberGroup(AxlNetClient.UpdateImeExclusionNumberGroupReq updateImeExclusionNumberGroup1)
        {
            return axlPortClient61.updateImeExclusionNumberGroup(updateImeExclusionNumberGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberGroupResponse> updateImeExclusionNumberGroupAsync(AxlNetClient.UpdateImeExclusionNumberGroupReq updateImeExclusionNumberGroup)
        {
            return axlPortClient61.updateImeExclusionNumberGroupAsync(updateImeExclusionNumberGroup);
        }

        public AxlNetClient.GetImeExclusionNumberGroupRes getImeExclusionNumberGroup(AxlNetClient.GetImeExclusionNumberGroupReq getImeExclusionNumberGroup1)
        {
            return axlPortClient61.getImeExclusionNumberGroup(getImeExclusionNumberGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberGroupResponse> getImeExclusionNumberGroupAsync(AxlNetClient.GetImeExclusionNumberGroupReq getImeExclusionNumberGroup)
        {
            return axlPortClient61.getImeExclusionNumberGroupAsync(getImeExclusionNumberGroup);
        }

        public AxlNetClient.StandardResponse removeImeExclusionNumberGroup(AxlNetClient.NameAndGUIDRequest removeImeExclusionNumberGroup1)
        {
            return axlPortClient61.removeImeExclusionNumberGroup(removeImeExclusionNumberGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberGroupResponse> removeImeExclusionNumberGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeExclusionNumberGroup)
        {
            return axlPortClient61.removeImeExclusionNumberGroupAsync(removeImeExclusionNumberGroup);
        }

        public AxlNetClient.ListImeExclusionNumberGroupRes listImeExclusionNumberGroup(AxlNetClient.ListImeExclusionNumberGroupReq listImeExclusionNumberGroup1)
        {
            return axlPortClient61.listImeExclusionNumberGroup(listImeExclusionNumberGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberGroupResponse> listImeExclusionNumberGroupAsync(AxlNetClient.ListImeExclusionNumberGroupReq listImeExclusionNumberGroup)
        {
            return axlPortClient61.listImeExclusionNumberGroupAsync(listImeExclusionNumberGroup);
        }

        public AxlNetClient.StandardResponse addImeFirewall(AxlNetClient.AddImeFirewallReq addImeFirewall1)
        {
            return axlPortClient61.addImeFirewall(addImeFirewall1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeFirewallResponse> addImeFirewallAsync(AxlNetClient.AddImeFirewallReq addImeFirewall)
        {
            return axlPortClient61.addImeFirewallAsync(addImeFirewall);
        }

        public AxlNetClient.StandardResponse updateImeFirewall(AxlNetClient.UpdateImeFirewallReq updateImeFirewall1)
        {
            return axlPortClient61.updateImeFirewall(updateImeFirewall1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeFirewallResponse> updateImeFirewallAsync(AxlNetClient.UpdateImeFirewallReq updateImeFirewall)
        {
            return axlPortClient61.updateImeFirewallAsync(updateImeFirewall);
        }

        public AxlNetClient.GetImeFirewallRes getImeFirewall(AxlNetClient.GetImeFirewallReq getImeFirewall1)
        {
            return axlPortClient61.getImeFirewall(getImeFirewall1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeFirewallResponse> getImeFirewallAsync(AxlNetClient.GetImeFirewallReq getImeFirewall)
        {
            return axlPortClient61.getImeFirewallAsync(getImeFirewall);
        }

        public AxlNetClient.StandardResponse removeImeFirewall(AxlNetClient.NameAndGUIDRequest removeImeFirewall1)
        {
            return axlPortClient61.removeImeFirewall(removeImeFirewall1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeFirewallResponse> removeImeFirewallAsync(AxlNetClient.NameAndGUIDRequest removeImeFirewall)
        {
            return axlPortClient61.removeImeFirewallAsync(removeImeFirewall);
        }

        public AxlNetClient.ListImeFirewallRes listImeFirewall(AxlNetClient.ListImeFirewallReq listImeFirewall1)
        {
            return axlPortClient61.listImeFirewall(listImeFirewall1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeFirewallResponse> listImeFirewallAsync(AxlNetClient.ListImeFirewallReq listImeFirewall)
        {
            return axlPortClient61.listImeFirewallAsync(listImeFirewall);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort61
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeExclusionNumber", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeExclusionNumberResponse removeImeExclusionNumber(AxlNetClient.removeImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeExclusionNumber", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberResponse> removeImeExclusionNumberAsync(AxlNetClient.removeImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeExclusionNumber", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeExclusionNumberResponse listImeExclusionNumber(AxlNetClient.listImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeExclusionNumber", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberResponse> listImeExclusionNumberAsync(AxlNetClient.listImeExclusionNumberRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeExclusionNumberGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeExclusionNumberGroupResponse addImeExclusionNumberGroup(AxlNetClient.addImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeExclusionNumberGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberGroupResponse> addImeExclusionNumberGroupAsync(AxlNetClient.addImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeExclusionNumberGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeExclusionNumberGroupResponse updateImeExclusionNumberGroup(AxlNetClient.updateImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeExclusionNumberGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberGroupResponse> updateImeExclusionNumberGroupAsync(AxlNetClient.updateImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeExclusionNumberGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeExclusionNumberGroupResponse getImeExclusionNumberGroup(AxlNetClient.getImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeExclusionNumberGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberGroupResponse> getImeExclusionNumberGroupAsync(AxlNetClient.getImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeExclusionNumberGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeExclusionNumberGroupResponse removeImeExclusionNumberGroup(AxlNetClient.removeImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeExclusionNumberGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberGroupResponse> removeImeExclusionNumberGroupAsync(AxlNetClient.removeImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeExclusionNumberGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeExclusionNumberGroupResponse listImeExclusionNumberGroup(AxlNetClient.listImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeExclusionNumberGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberGroupResponse> listImeExclusionNumberGroupAsync(AxlNetClient.listImeExclusionNumberGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeFirewall", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeFirewallResponse addImeFirewall(AxlNetClient.addImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeFirewall", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeFirewallResponse> addImeFirewallAsync(AxlNetClient.addImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeFirewall", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeFirewallResponse updateImeFirewall(AxlNetClient.updateImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeFirewall", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeFirewallResponse> updateImeFirewallAsync(AxlNetClient.updateImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeFirewall", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeFirewallResponse getImeFirewall(AxlNetClient.getImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeFirewall", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeFirewallResponse> getImeFirewallAsync(AxlNetClient.getImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeFirewall", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeFirewallResponse removeImeFirewall(AxlNetClient.removeImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeFirewall", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeFirewallResponse> removeImeFirewallAsync(AxlNetClient.removeImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeFirewall", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeFirewallResponse listImeFirewall(AxlNetClient.listImeFirewallRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeFirewall", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeFirewallResponse> listImeFirewallAsync(AxlNetClient.listImeFirewallRequest request);
    }

    public class AXLPortClient61 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort61>, AxlNetClient.AXLPort61
    {
        public AXLPortClient61(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeExclusionNumberResponse AxlNetClient.AXLPort61.removeImeExclusionNumber(AxlNetClient.removeImeExclusionNumberRequest request)
        {
            return base.Channel.removeImeExclusionNumber(request);
        }

        public AxlNetClient.StandardResponse removeImeExclusionNumber(AxlNetClient.RemoveImeExclusionNumberReq removeImeExclusionNumber1)
        {
            AxlNetClient.removeImeExclusionNumberRequest inValue = new AxlNetClient.removeImeExclusionNumberRequest();
            inValue.removeImeExclusionNumber = removeImeExclusionNumber1;
            AxlNetClient.removeImeExclusionNumberResponse retVal = ((AxlNetClient.AXLPort61)(this)).removeImeExclusionNumber(inValue);
            return retVal.removeImeExclusionNumberResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberResponse> AxlNetClient.AXLPort61.removeImeExclusionNumberAsync(AxlNetClient.removeImeExclusionNumberRequest request)
        {
            return base.Channel.removeImeExclusionNumberAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberResponse> removeImeExclusionNumberAsync(AxlNetClient.RemoveImeExclusionNumberReq removeImeExclusionNumber)
        {
            AxlNetClient.removeImeExclusionNumberRequest inValue = new AxlNetClient.removeImeExclusionNumberRequest();
            inValue.removeImeExclusionNumber = removeImeExclusionNumber;
            return ((AxlNetClient.AXLPort61)(this)).removeImeExclusionNumberAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeExclusionNumberResponse AxlNetClient.AXLPort61.listImeExclusionNumber(AxlNetClient.listImeExclusionNumberRequest request)
        {
            return base.Channel.listImeExclusionNumber(request);
        }

        public AxlNetClient.ListImeExclusionNumberRes listImeExclusionNumber(AxlNetClient.ListImeExclusionNumberReq listImeExclusionNumber1)
        {
            AxlNetClient.listImeExclusionNumberRequest inValue = new AxlNetClient.listImeExclusionNumberRequest();
            inValue.listImeExclusionNumber = listImeExclusionNumber1;
            AxlNetClient.listImeExclusionNumberResponse retVal = ((AxlNetClient.AXLPort61)(this)).listImeExclusionNumber(inValue);
            return retVal.listImeExclusionNumberResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberResponse> AxlNetClient.AXLPort61.listImeExclusionNumberAsync(AxlNetClient.listImeExclusionNumberRequest request)
        {
            return base.Channel.listImeExclusionNumberAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberResponse> listImeExclusionNumberAsync(AxlNetClient.ListImeExclusionNumberReq listImeExclusionNumber)
        {
            AxlNetClient.listImeExclusionNumberRequest inValue = new AxlNetClient.listImeExclusionNumberRequest();
            inValue.listImeExclusionNumber = listImeExclusionNumber;
            return ((AxlNetClient.AXLPort61)(this)).listImeExclusionNumberAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeExclusionNumberGroupResponse AxlNetClient.AXLPort61.addImeExclusionNumberGroup(AxlNetClient.addImeExclusionNumberGroupRequest request)
        {
            return base.Channel.addImeExclusionNumberGroup(request);
        }

        public AxlNetClient.StandardResponse addImeExclusionNumberGroup(AxlNetClient.AddImeExclusionNumberGroupReq addImeExclusionNumberGroup1)
        {
            AxlNetClient.addImeExclusionNumberGroupRequest inValue = new AxlNetClient.addImeExclusionNumberGroupRequest();
            inValue.addImeExclusionNumberGroup = addImeExclusionNumberGroup1;
            AxlNetClient.addImeExclusionNumberGroupResponse retVal = ((AxlNetClient.AXLPort61)(this)).addImeExclusionNumberGroup(inValue);
            return retVal.addImeExclusionNumberGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberGroupResponse> AxlNetClient.AXLPort61.addImeExclusionNumberGroupAsync(AxlNetClient.addImeExclusionNumberGroupRequest request)
        {
            return base.Channel.addImeExclusionNumberGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeExclusionNumberGroupResponse> addImeExclusionNumberGroupAsync(AxlNetClient.AddImeExclusionNumberGroupReq addImeExclusionNumberGroup)
        {
            AxlNetClient.addImeExclusionNumberGroupRequest inValue = new AxlNetClient.addImeExclusionNumberGroupRequest();
            inValue.addImeExclusionNumberGroup = addImeExclusionNumberGroup;
            return ((AxlNetClient.AXLPort61)(this)).addImeExclusionNumberGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeExclusionNumberGroupResponse AxlNetClient.AXLPort61.updateImeExclusionNumberGroup(AxlNetClient.updateImeExclusionNumberGroupRequest request)
        {
            return base.Channel.updateImeExclusionNumberGroup(request);
        }

        public AxlNetClient.StandardResponse updateImeExclusionNumberGroup(AxlNetClient.UpdateImeExclusionNumberGroupReq updateImeExclusionNumberGroup1)
        {
            AxlNetClient.updateImeExclusionNumberGroupRequest inValue = new AxlNetClient.updateImeExclusionNumberGroupRequest();
            inValue.updateImeExclusionNumberGroup = updateImeExclusionNumberGroup1;
            AxlNetClient.updateImeExclusionNumberGroupResponse retVal = ((AxlNetClient.AXLPort61)(this)).updateImeExclusionNumberGroup(inValue);
            return retVal.updateImeExclusionNumberGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberGroupResponse> AxlNetClient.AXLPort61.updateImeExclusionNumberGroupAsync(AxlNetClient.updateImeExclusionNumberGroupRequest request)
        {
            return base.Channel.updateImeExclusionNumberGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeExclusionNumberGroupResponse> updateImeExclusionNumberGroupAsync(AxlNetClient.UpdateImeExclusionNumberGroupReq updateImeExclusionNumberGroup)
        {
            AxlNetClient.updateImeExclusionNumberGroupRequest inValue = new AxlNetClient.updateImeExclusionNumberGroupRequest();
            inValue.updateImeExclusionNumberGroup = updateImeExclusionNumberGroup;
            return ((AxlNetClient.AXLPort61)(this)).updateImeExclusionNumberGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeExclusionNumberGroupResponse AxlNetClient.AXLPort61.getImeExclusionNumberGroup(AxlNetClient.getImeExclusionNumberGroupRequest request)
        {
            return base.Channel.getImeExclusionNumberGroup(request);
        }

        public AxlNetClient.GetImeExclusionNumberGroupRes getImeExclusionNumberGroup(AxlNetClient.GetImeExclusionNumberGroupReq getImeExclusionNumberGroup1)
        {
            AxlNetClient.getImeExclusionNumberGroupRequest inValue = new AxlNetClient.getImeExclusionNumberGroupRequest();
            inValue.getImeExclusionNumberGroup = getImeExclusionNumberGroup1;
            AxlNetClient.getImeExclusionNumberGroupResponse retVal = ((AxlNetClient.AXLPort61)(this)).getImeExclusionNumberGroup(inValue);
            return retVal.getImeExclusionNumberGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberGroupResponse> AxlNetClient.AXLPort61.getImeExclusionNumberGroupAsync(AxlNetClient.getImeExclusionNumberGroupRequest request)
        {
            return base.Channel.getImeExclusionNumberGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeExclusionNumberGroupResponse> getImeExclusionNumberGroupAsync(AxlNetClient.GetImeExclusionNumberGroupReq getImeExclusionNumberGroup)
        {
            AxlNetClient.getImeExclusionNumberGroupRequest inValue = new AxlNetClient.getImeExclusionNumberGroupRequest();
            inValue.getImeExclusionNumberGroup = getImeExclusionNumberGroup;
            return ((AxlNetClient.AXLPort61)(this)).getImeExclusionNumberGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeExclusionNumberGroupResponse AxlNetClient.AXLPort61.removeImeExclusionNumberGroup(AxlNetClient.removeImeExclusionNumberGroupRequest request)
        {
            return base.Channel.removeImeExclusionNumberGroup(request);
        }

        public AxlNetClient.StandardResponse removeImeExclusionNumberGroup(AxlNetClient.NameAndGUIDRequest removeImeExclusionNumberGroup1)
        {
            AxlNetClient.removeImeExclusionNumberGroupRequest inValue = new AxlNetClient.removeImeExclusionNumberGroupRequest();
            inValue.removeImeExclusionNumberGroup = removeImeExclusionNumberGroup1;
            AxlNetClient.removeImeExclusionNumberGroupResponse retVal = ((AxlNetClient.AXLPort61)(this)).removeImeExclusionNumberGroup(inValue);
            return retVal.removeImeExclusionNumberGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberGroupResponse> AxlNetClient.AXLPort61.removeImeExclusionNumberGroupAsync(AxlNetClient.removeImeExclusionNumberGroupRequest request)
        {
            return base.Channel.removeImeExclusionNumberGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeExclusionNumberGroupResponse> removeImeExclusionNumberGroupAsync(AxlNetClient.NameAndGUIDRequest removeImeExclusionNumberGroup)
        {
            AxlNetClient.removeImeExclusionNumberGroupRequest inValue = new AxlNetClient.removeImeExclusionNumberGroupRequest();
            inValue.removeImeExclusionNumberGroup = removeImeExclusionNumberGroup;
            return ((AxlNetClient.AXLPort61)(this)).removeImeExclusionNumberGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeExclusionNumberGroupResponse AxlNetClient.AXLPort61.listImeExclusionNumberGroup(AxlNetClient.listImeExclusionNumberGroupRequest request)
        {
            return base.Channel.listImeExclusionNumberGroup(request);
        }

        public AxlNetClient.ListImeExclusionNumberGroupRes listImeExclusionNumberGroup(AxlNetClient.ListImeExclusionNumberGroupReq listImeExclusionNumberGroup1)
        {
            AxlNetClient.listImeExclusionNumberGroupRequest inValue = new AxlNetClient.listImeExclusionNumberGroupRequest();
            inValue.listImeExclusionNumberGroup = listImeExclusionNumberGroup1;
            AxlNetClient.listImeExclusionNumberGroupResponse retVal = ((AxlNetClient.AXLPort61)(this)).listImeExclusionNumberGroup(inValue);
            return retVal.listImeExclusionNumberGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberGroupResponse> AxlNetClient.AXLPort61.listImeExclusionNumberGroupAsync(AxlNetClient.listImeExclusionNumberGroupRequest request)
        {
            return base.Channel.listImeExclusionNumberGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeExclusionNumberGroupResponse> listImeExclusionNumberGroupAsync(AxlNetClient.ListImeExclusionNumberGroupReq listImeExclusionNumberGroup)
        {
            AxlNetClient.listImeExclusionNumberGroupRequest inValue = new AxlNetClient.listImeExclusionNumberGroupRequest();
            inValue.listImeExclusionNumberGroup = listImeExclusionNumberGroup;
            return ((AxlNetClient.AXLPort61)(this)).listImeExclusionNumberGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeFirewallResponse AxlNetClient.AXLPort61.addImeFirewall(AxlNetClient.addImeFirewallRequest request)
        {
            return base.Channel.addImeFirewall(request);
        }

        public AxlNetClient.StandardResponse addImeFirewall(AxlNetClient.AddImeFirewallReq addImeFirewall1)
        {
            AxlNetClient.addImeFirewallRequest inValue = new AxlNetClient.addImeFirewallRequest();
            inValue.addImeFirewall = addImeFirewall1;
            AxlNetClient.addImeFirewallResponse retVal = ((AxlNetClient.AXLPort61)(this)).addImeFirewall(inValue);
            return retVal.addImeFirewallResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeFirewallResponse> AxlNetClient.AXLPort61.addImeFirewallAsync(AxlNetClient.addImeFirewallRequest request)
        {
            return base.Channel.addImeFirewallAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeFirewallResponse> addImeFirewallAsync(AxlNetClient.AddImeFirewallReq addImeFirewall)
        {
            AxlNetClient.addImeFirewallRequest inValue = new AxlNetClient.addImeFirewallRequest();
            inValue.addImeFirewall = addImeFirewall;
            return ((AxlNetClient.AXLPort61)(this)).addImeFirewallAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeFirewallResponse AxlNetClient.AXLPort61.updateImeFirewall(AxlNetClient.updateImeFirewallRequest request)
        {
            return base.Channel.updateImeFirewall(request);
        }

        public AxlNetClient.StandardResponse updateImeFirewall(AxlNetClient.UpdateImeFirewallReq updateImeFirewall1)
        {
            AxlNetClient.updateImeFirewallRequest inValue = new AxlNetClient.updateImeFirewallRequest();
            inValue.updateImeFirewall = updateImeFirewall1;
            AxlNetClient.updateImeFirewallResponse retVal = ((AxlNetClient.AXLPort61)(this)).updateImeFirewall(inValue);
            return retVal.updateImeFirewallResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeFirewallResponse> AxlNetClient.AXLPort61.updateImeFirewallAsync(AxlNetClient.updateImeFirewallRequest request)
        {
            return base.Channel.updateImeFirewallAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeFirewallResponse> updateImeFirewallAsync(AxlNetClient.UpdateImeFirewallReq updateImeFirewall)
        {
            AxlNetClient.updateImeFirewallRequest inValue = new AxlNetClient.updateImeFirewallRequest();
            inValue.updateImeFirewall = updateImeFirewall;
            return ((AxlNetClient.AXLPort61)(this)).updateImeFirewallAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeFirewallResponse AxlNetClient.AXLPort61.getImeFirewall(AxlNetClient.getImeFirewallRequest request)
        {
            return base.Channel.getImeFirewall(request);
        }

        public AxlNetClient.GetImeFirewallRes getImeFirewall(AxlNetClient.GetImeFirewallReq getImeFirewall1)
        {
            AxlNetClient.getImeFirewallRequest inValue = new AxlNetClient.getImeFirewallRequest();
            inValue.getImeFirewall = getImeFirewall1;
            AxlNetClient.getImeFirewallResponse retVal = ((AxlNetClient.AXLPort61)(this)).getImeFirewall(inValue);
            return retVal.getImeFirewallResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeFirewallResponse> AxlNetClient.AXLPort61.getImeFirewallAsync(AxlNetClient.getImeFirewallRequest request)
        {
            return base.Channel.getImeFirewallAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeFirewallResponse> getImeFirewallAsync(AxlNetClient.GetImeFirewallReq getImeFirewall)
        {
            AxlNetClient.getImeFirewallRequest inValue = new AxlNetClient.getImeFirewallRequest();
            inValue.getImeFirewall = getImeFirewall;
            return ((AxlNetClient.AXLPort61)(this)).getImeFirewallAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeFirewallResponse AxlNetClient.AXLPort61.removeImeFirewall(AxlNetClient.removeImeFirewallRequest request)
        {
            return base.Channel.removeImeFirewall(request);
        }

        public AxlNetClient.StandardResponse removeImeFirewall(AxlNetClient.NameAndGUIDRequest removeImeFirewall1)
        {
            AxlNetClient.removeImeFirewallRequest inValue = new AxlNetClient.removeImeFirewallRequest();
            inValue.removeImeFirewall = removeImeFirewall1;
            AxlNetClient.removeImeFirewallResponse retVal = ((AxlNetClient.AXLPort61)(this)).removeImeFirewall(inValue);
            return retVal.removeImeFirewallResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeFirewallResponse> AxlNetClient.AXLPort61.removeImeFirewallAsync(AxlNetClient.removeImeFirewallRequest request)
        {
            return base.Channel.removeImeFirewallAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeFirewallResponse> removeImeFirewallAsync(AxlNetClient.NameAndGUIDRequest removeImeFirewall)
        {
            AxlNetClient.removeImeFirewallRequest inValue = new AxlNetClient.removeImeFirewallRequest();
            inValue.removeImeFirewall = removeImeFirewall;
            return ((AxlNetClient.AXLPort61)(this)).removeImeFirewallAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeFirewallResponse AxlNetClient.AXLPort61.listImeFirewall(AxlNetClient.listImeFirewallRequest request)
        {
            return base.Channel.listImeFirewall(request);
        }

        public AxlNetClient.ListImeFirewallRes listImeFirewall(AxlNetClient.ListImeFirewallReq listImeFirewall1)
        {
            AxlNetClient.listImeFirewallRequest inValue = new AxlNetClient.listImeFirewallRequest();
            inValue.listImeFirewall = listImeFirewall1;
            AxlNetClient.listImeFirewallResponse retVal = ((AxlNetClient.AXLPort61)(this)).listImeFirewall(inValue);
            return retVal.listImeFirewallResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeFirewallResponse> AxlNetClient.AXLPort61.listImeFirewallAsync(AxlNetClient.listImeFirewallRequest request)
        {
            return base.Channel.listImeFirewallAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeFirewallResponse> listImeFirewallAsync(AxlNetClient.ListImeFirewallReq listImeFirewall)
        {
            AxlNetClient.listImeFirewallRequest inValue = new AxlNetClient.listImeFirewallRequest();
            inValue.listImeFirewall = listImeFirewall;
            return ((AxlNetClient.AXLPort61)(this)).listImeFirewallAsync(inValue);
        }
    }
}