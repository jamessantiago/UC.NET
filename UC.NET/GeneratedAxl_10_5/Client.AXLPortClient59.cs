namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient59 _axlPortClient59;

        private static AXLPortClient59 axlPortClient59 => _axlPortClient59 == null ||
            _axlPortClient59.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient59 = LoadClient59()) : _axlPortClient59;

        private static AXLPortClient59 LoadClient59()
        {
            var client = new AXLPortClient59(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close59;
            OnAbort += Abort59;
            return client;
        }

        private static void Close59(object sender, System.EventArgs e)
        {
            _axlPortClient59.Close();
        }

        private static void Abort59(object sender, System.EventArgs e)
        {
            _axlPortClient59.Abort();
        }

        public AxlNetClient.ListImeRouteFilterGroupRes listImeRouteFilterGroup(AxlNetClient.ListImeRouteFilterGroupReq listImeRouteFilterGroup1)
        {
            return axlPortClient59.listImeRouteFilterGroup(listImeRouteFilterGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterGroupResponse> listImeRouteFilterGroupAsync(AxlNetClient.ListImeRouteFilterGroupReq listImeRouteFilterGroup)
        {
            return axlPortClient59.listImeRouteFilterGroupAsync(listImeRouteFilterGroup);
        }

        public AxlNetClient.StandardResponse addImeRouteFilterElement(AxlNetClient.AddImeRouteFilterElementReq addImeRouteFilterElement1)
        {
            return axlPortClient59.addImeRouteFilterElement(addImeRouteFilterElement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterElementResponse> addImeRouteFilterElementAsync(AxlNetClient.AddImeRouteFilterElementReq addImeRouteFilterElement)
        {
            return axlPortClient59.addImeRouteFilterElementAsync(addImeRouteFilterElement);
        }

        public AxlNetClient.StandardResponse updateImeRouteFilterElement(AxlNetClient.UpdateImeRouteFilterElementReq updateImeRouteFilterElement1)
        {
            return axlPortClient59.updateImeRouteFilterElement(updateImeRouteFilterElement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterElementResponse> updateImeRouteFilterElementAsync(AxlNetClient.UpdateImeRouteFilterElementReq updateImeRouteFilterElement)
        {
            return axlPortClient59.updateImeRouteFilterElementAsync(updateImeRouteFilterElement);
        }

        public AxlNetClient.GetImeRouteFilterElementRes getImeRouteFilterElement(AxlNetClient.GetImeRouteFilterElementReq getImeRouteFilterElement1)
        {
            return axlPortClient59.getImeRouteFilterElement(getImeRouteFilterElement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterElementResponse> getImeRouteFilterElementAsync(AxlNetClient.GetImeRouteFilterElementReq getImeRouteFilterElement)
        {
            return axlPortClient59.getImeRouteFilterElementAsync(getImeRouteFilterElement);
        }

        public AxlNetClient.StandardResponse removeImeRouteFilterElement(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterElement1)
        {
            return axlPortClient59.removeImeRouteFilterElement(removeImeRouteFilterElement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterElementResponse> removeImeRouteFilterElementAsync(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterElement)
        {
            return axlPortClient59.removeImeRouteFilterElementAsync(removeImeRouteFilterElement);
        }

        public AxlNetClient.ListImeRouteFilterElementRes listImeRouteFilterElement(AxlNetClient.ListImeRouteFilterElementReq listImeRouteFilterElement1)
        {
            return axlPortClient59.listImeRouteFilterElement(listImeRouteFilterElement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterElementResponse> listImeRouteFilterElementAsync(AxlNetClient.ListImeRouteFilterElementReq listImeRouteFilterElement)
        {
            return axlPortClient59.listImeRouteFilterElementAsync(listImeRouteFilterElement);
        }

        public AxlNetClient.StandardResponse addImeClient(AxlNetClient.AddImeClientReq addImeClient1)
        {
            return axlPortClient59.addImeClient(addImeClient1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeClientResponse> addImeClientAsync(AxlNetClient.AddImeClientReq addImeClient)
        {
            return axlPortClient59.addImeClientAsync(addImeClient);
        }

        public AxlNetClient.StandardResponse updateImeClient(AxlNetClient.UpdateImeClientReq updateImeClient1)
        {
            return axlPortClient59.updateImeClient(updateImeClient1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeClientResponse> updateImeClientAsync(AxlNetClient.UpdateImeClientReq updateImeClient)
        {
            return axlPortClient59.updateImeClientAsync(updateImeClient);
        }

        public AxlNetClient.GetImeClientRes getImeClient(AxlNetClient.GetImeClientReq getImeClient1)
        {
            return axlPortClient59.getImeClient(getImeClient1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeClientResponse> getImeClientAsync(AxlNetClient.GetImeClientReq getImeClient)
        {
            return axlPortClient59.getImeClientAsync(getImeClient);
        }

        public AxlNetClient.StandardResponse removeImeClient(AxlNetClient.NameAndGUIDRequest removeImeClient1)
        {
            return axlPortClient59.removeImeClient(removeImeClient1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeClientResponse> removeImeClientAsync(AxlNetClient.NameAndGUIDRequest removeImeClient)
        {
            return axlPortClient59.removeImeClientAsync(removeImeClient);
        }

        public AxlNetClient.ListImeClientRes listImeClient(AxlNetClient.ListImeClientReq listImeClient1)
        {
            return axlPortClient59.listImeClient(listImeClient1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeClientResponse> listImeClientAsync(AxlNetClient.ListImeClientReq listImeClient)
        {
            return axlPortClient59.listImeClientAsync(listImeClient);
        }

        public AxlNetClient.StandardResponse addImeEnrolledPattern(AxlNetClient.AddImeEnrolledPatternReq addImeEnrolledPattern1)
        {
            return axlPortClient59.addImeEnrolledPattern(addImeEnrolledPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternResponse> addImeEnrolledPatternAsync(AxlNetClient.AddImeEnrolledPatternReq addImeEnrolledPattern)
        {
            return axlPortClient59.addImeEnrolledPatternAsync(addImeEnrolledPattern);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort59
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeRouteFilterGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeRouteFilterGroupResponse listImeRouteFilterGroup(AxlNetClient.listImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeRouteFilterGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterGroupResponse> listImeRouteFilterGroupAsync(AxlNetClient.listImeRouteFilterGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeRouteFilterElement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeRouteFilterElementResponse addImeRouteFilterElement(AxlNetClient.addImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeRouteFilterElement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterElementResponse> addImeRouteFilterElementAsync(AxlNetClient.addImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeRouteFilterElement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeRouteFilterElementResponse updateImeRouteFilterElement(AxlNetClient.updateImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeRouteFilterElement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterElementResponse> updateImeRouteFilterElementAsync(AxlNetClient.updateImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeRouteFilterElement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeRouteFilterElementResponse getImeRouteFilterElement(AxlNetClient.getImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeRouteFilterElement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterElementResponse> getImeRouteFilterElementAsync(AxlNetClient.getImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeRouteFilterElement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeRouteFilterElementResponse removeImeRouteFilterElement(AxlNetClient.removeImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeRouteFilterElement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterElementResponse> removeImeRouteFilterElementAsync(AxlNetClient.removeImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeRouteFilterElement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeRouteFilterElementResponse listImeRouteFilterElement(AxlNetClient.listImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeRouteFilterElement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterElementResponse> listImeRouteFilterElementAsync(AxlNetClient.listImeRouteFilterElementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeClient", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeClientResponse addImeClient(AxlNetClient.addImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeClient", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeClientResponse> addImeClientAsync(AxlNetClient.addImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeClient", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeClientResponse updateImeClient(AxlNetClient.updateImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeClient", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeClientResponse> updateImeClientAsync(AxlNetClient.updateImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeClient", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeClientResponse getImeClient(AxlNetClient.getImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeClient", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeClientResponse> getImeClientAsync(AxlNetClient.getImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeClient", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeClientResponse removeImeClient(AxlNetClient.removeImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeClient", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeClientResponse> removeImeClientAsync(AxlNetClient.removeImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeClient", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeClientResponse listImeClient(AxlNetClient.listImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeClient", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeClientResponse> listImeClientAsync(AxlNetClient.listImeClientRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeEnrolledPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeEnrolledPatternResponse addImeEnrolledPattern(AxlNetClient.addImeEnrolledPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeEnrolledPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternResponse> addImeEnrolledPatternAsync(AxlNetClient.addImeEnrolledPatternRequest request);
    }

    public class AXLPortClient59 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort59>, AxlNetClient.AXLPort59
    {
        public AXLPortClient59(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeRouteFilterGroupResponse AxlNetClient.AXLPort59.listImeRouteFilterGroup(AxlNetClient.listImeRouteFilterGroupRequest request)
        {
            return base.Channel.listImeRouteFilterGroup(request);
        }

        public AxlNetClient.ListImeRouteFilterGroupRes listImeRouteFilterGroup(AxlNetClient.ListImeRouteFilterGroupReq listImeRouteFilterGroup1)
        {
            AxlNetClient.listImeRouteFilterGroupRequest inValue = new AxlNetClient.listImeRouteFilterGroupRequest();
            inValue.listImeRouteFilterGroup = listImeRouteFilterGroup1;
            AxlNetClient.listImeRouteFilterGroupResponse retVal = ((AxlNetClient.AXLPort59)(this)).listImeRouteFilterGroup(inValue);
            return retVal.listImeRouteFilterGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterGroupResponse> AxlNetClient.AXLPort59.listImeRouteFilterGroupAsync(AxlNetClient.listImeRouteFilterGroupRequest request)
        {
            return base.Channel.listImeRouteFilterGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterGroupResponse> listImeRouteFilterGroupAsync(AxlNetClient.ListImeRouteFilterGroupReq listImeRouteFilterGroup)
        {
            AxlNetClient.listImeRouteFilterGroupRequest inValue = new AxlNetClient.listImeRouteFilterGroupRequest();
            inValue.listImeRouteFilterGroup = listImeRouteFilterGroup;
            return ((AxlNetClient.AXLPort59)(this)).listImeRouteFilterGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeRouteFilterElementResponse AxlNetClient.AXLPort59.addImeRouteFilterElement(AxlNetClient.addImeRouteFilterElementRequest request)
        {
            return base.Channel.addImeRouteFilterElement(request);
        }

        public AxlNetClient.StandardResponse addImeRouteFilterElement(AxlNetClient.AddImeRouteFilterElementReq addImeRouteFilterElement1)
        {
            AxlNetClient.addImeRouteFilterElementRequest inValue = new AxlNetClient.addImeRouteFilterElementRequest();
            inValue.addImeRouteFilterElement = addImeRouteFilterElement1;
            AxlNetClient.addImeRouteFilterElementResponse retVal = ((AxlNetClient.AXLPort59)(this)).addImeRouteFilterElement(inValue);
            return retVal.addImeRouteFilterElementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterElementResponse> AxlNetClient.AXLPort59.addImeRouteFilterElementAsync(AxlNetClient.addImeRouteFilterElementRequest request)
        {
            return base.Channel.addImeRouteFilterElementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeRouteFilterElementResponse> addImeRouteFilterElementAsync(AxlNetClient.AddImeRouteFilterElementReq addImeRouteFilterElement)
        {
            AxlNetClient.addImeRouteFilterElementRequest inValue = new AxlNetClient.addImeRouteFilterElementRequest();
            inValue.addImeRouteFilterElement = addImeRouteFilterElement;
            return ((AxlNetClient.AXLPort59)(this)).addImeRouteFilterElementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeRouteFilterElementResponse AxlNetClient.AXLPort59.updateImeRouteFilterElement(AxlNetClient.updateImeRouteFilterElementRequest request)
        {
            return base.Channel.updateImeRouteFilterElement(request);
        }

        public AxlNetClient.StandardResponse updateImeRouteFilterElement(AxlNetClient.UpdateImeRouteFilterElementReq updateImeRouteFilterElement1)
        {
            AxlNetClient.updateImeRouteFilterElementRequest inValue = new AxlNetClient.updateImeRouteFilterElementRequest();
            inValue.updateImeRouteFilterElement = updateImeRouteFilterElement1;
            AxlNetClient.updateImeRouteFilterElementResponse retVal = ((AxlNetClient.AXLPort59)(this)).updateImeRouteFilterElement(inValue);
            return retVal.updateImeRouteFilterElementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterElementResponse> AxlNetClient.AXLPort59.updateImeRouteFilterElementAsync(AxlNetClient.updateImeRouteFilterElementRequest request)
        {
            return base.Channel.updateImeRouteFilterElementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeRouteFilterElementResponse> updateImeRouteFilterElementAsync(AxlNetClient.UpdateImeRouteFilterElementReq updateImeRouteFilterElement)
        {
            AxlNetClient.updateImeRouteFilterElementRequest inValue = new AxlNetClient.updateImeRouteFilterElementRequest();
            inValue.updateImeRouteFilterElement = updateImeRouteFilterElement;
            return ((AxlNetClient.AXLPort59)(this)).updateImeRouteFilterElementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeRouteFilterElementResponse AxlNetClient.AXLPort59.getImeRouteFilterElement(AxlNetClient.getImeRouteFilterElementRequest request)
        {
            return base.Channel.getImeRouteFilterElement(request);
        }

        public AxlNetClient.GetImeRouteFilterElementRes getImeRouteFilterElement(AxlNetClient.GetImeRouteFilterElementReq getImeRouteFilterElement1)
        {
            AxlNetClient.getImeRouteFilterElementRequest inValue = new AxlNetClient.getImeRouteFilterElementRequest();
            inValue.getImeRouteFilterElement = getImeRouteFilterElement1;
            AxlNetClient.getImeRouteFilterElementResponse retVal = ((AxlNetClient.AXLPort59)(this)).getImeRouteFilterElement(inValue);
            return retVal.getImeRouteFilterElementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterElementResponse> AxlNetClient.AXLPort59.getImeRouteFilterElementAsync(AxlNetClient.getImeRouteFilterElementRequest request)
        {
            return base.Channel.getImeRouteFilterElementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeRouteFilterElementResponse> getImeRouteFilterElementAsync(AxlNetClient.GetImeRouteFilterElementReq getImeRouteFilterElement)
        {
            AxlNetClient.getImeRouteFilterElementRequest inValue = new AxlNetClient.getImeRouteFilterElementRequest();
            inValue.getImeRouteFilterElement = getImeRouteFilterElement;
            return ((AxlNetClient.AXLPort59)(this)).getImeRouteFilterElementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeRouteFilterElementResponse AxlNetClient.AXLPort59.removeImeRouteFilterElement(AxlNetClient.removeImeRouteFilterElementRequest request)
        {
            return base.Channel.removeImeRouteFilterElement(request);
        }

        public AxlNetClient.StandardResponse removeImeRouteFilterElement(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterElement1)
        {
            AxlNetClient.removeImeRouteFilterElementRequest inValue = new AxlNetClient.removeImeRouteFilterElementRequest();
            inValue.removeImeRouteFilterElement = removeImeRouteFilterElement1;
            AxlNetClient.removeImeRouteFilterElementResponse retVal = ((AxlNetClient.AXLPort59)(this)).removeImeRouteFilterElement(inValue);
            return retVal.removeImeRouteFilterElementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterElementResponse> AxlNetClient.AXLPort59.removeImeRouteFilterElementAsync(AxlNetClient.removeImeRouteFilterElementRequest request)
        {
            return base.Channel.removeImeRouteFilterElementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeRouteFilterElementResponse> removeImeRouteFilterElementAsync(AxlNetClient.NameAndGUIDRequest removeImeRouteFilterElement)
        {
            AxlNetClient.removeImeRouteFilterElementRequest inValue = new AxlNetClient.removeImeRouteFilterElementRequest();
            inValue.removeImeRouteFilterElement = removeImeRouteFilterElement;
            return ((AxlNetClient.AXLPort59)(this)).removeImeRouteFilterElementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeRouteFilterElementResponse AxlNetClient.AXLPort59.listImeRouteFilterElement(AxlNetClient.listImeRouteFilterElementRequest request)
        {
            return base.Channel.listImeRouteFilterElement(request);
        }

        public AxlNetClient.ListImeRouteFilterElementRes listImeRouteFilterElement(AxlNetClient.ListImeRouteFilterElementReq listImeRouteFilterElement1)
        {
            AxlNetClient.listImeRouteFilterElementRequest inValue = new AxlNetClient.listImeRouteFilterElementRequest();
            inValue.listImeRouteFilterElement = listImeRouteFilterElement1;
            AxlNetClient.listImeRouteFilterElementResponse retVal = ((AxlNetClient.AXLPort59)(this)).listImeRouteFilterElement(inValue);
            return retVal.listImeRouteFilterElementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterElementResponse> AxlNetClient.AXLPort59.listImeRouteFilterElementAsync(AxlNetClient.listImeRouteFilterElementRequest request)
        {
            return base.Channel.listImeRouteFilterElementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeRouteFilterElementResponse> listImeRouteFilterElementAsync(AxlNetClient.ListImeRouteFilterElementReq listImeRouteFilterElement)
        {
            AxlNetClient.listImeRouteFilterElementRequest inValue = new AxlNetClient.listImeRouteFilterElementRequest();
            inValue.listImeRouteFilterElement = listImeRouteFilterElement;
            return ((AxlNetClient.AXLPort59)(this)).listImeRouteFilterElementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeClientResponse AxlNetClient.AXLPort59.addImeClient(AxlNetClient.addImeClientRequest request)
        {
            return base.Channel.addImeClient(request);
        }

        public AxlNetClient.StandardResponse addImeClient(AxlNetClient.AddImeClientReq addImeClient1)
        {
            AxlNetClient.addImeClientRequest inValue = new AxlNetClient.addImeClientRequest();
            inValue.addImeClient = addImeClient1;
            AxlNetClient.addImeClientResponse retVal = ((AxlNetClient.AXLPort59)(this)).addImeClient(inValue);
            return retVal.addImeClientResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeClientResponse> AxlNetClient.AXLPort59.addImeClientAsync(AxlNetClient.addImeClientRequest request)
        {
            return base.Channel.addImeClientAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeClientResponse> addImeClientAsync(AxlNetClient.AddImeClientReq addImeClient)
        {
            AxlNetClient.addImeClientRequest inValue = new AxlNetClient.addImeClientRequest();
            inValue.addImeClient = addImeClient;
            return ((AxlNetClient.AXLPort59)(this)).addImeClientAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeClientResponse AxlNetClient.AXLPort59.updateImeClient(AxlNetClient.updateImeClientRequest request)
        {
            return base.Channel.updateImeClient(request);
        }

        public AxlNetClient.StandardResponse updateImeClient(AxlNetClient.UpdateImeClientReq updateImeClient1)
        {
            AxlNetClient.updateImeClientRequest inValue = new AxlNetClient.updateImeClientRequest();
            inValue.updateImeClient = updateImeClient1;
            AxlNetClient.updateImeClientResponse retVal = ((AxlNetClient.AXLPort59)(this)).updateImeClient(inValue);
            return retVal.updateImeClientResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeClientResponse> AxlNetClient.AXLPort59.updateImeClientAsync(AxlNetClient.updateImeClientRequest request)
        {
            return base.Channel.updateImeClientAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeClientResponse> updateImeClientAsync(AxlNetClient.UpdateImeClientReq updateImeClient)
        {
            AxlNetClient.updateImeClientRequest inValue = new AxlNetClient.updateImeClientRequest();
            inValue.updateImeClient = updateImeClient;
            return ((AxlNetClient.AXLPort59)(this)).updateImeClientAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeClientResponse AxlNetClient.AXLPort59.getImeClient(AxlNetClient.getImeClientRequest request)
        {
            return base.Channel.getImeClient(request);
        }

        public AxlNetClient.GetImeClientRes getImeClient(AxlNetClient.GetImeClientReq getImeClient1)
        {
            AxlNetClient.getImeClientRequest inValue = new AxlNetClient.getImeClientRequest();
            inValue.getImeClient = getImeClient1;
            AxlNetClient.getImeClientResponse retVal = ((AxlNetClient.AXLPort59)(this)).getImeClient(inValue);
            return retVal.getImeClientResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeClientResponse> AxlNetClient.AXLPort59.getImeClientAsync(AxlNetClient.getImeClientRequest request)
        {
            return base.Channel.getImeClientAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeClientResponse> getImeClientAsync(AxlNetClient.GetImeClientReq getImeClient)
        {
            AxlNetClient.getImeClientRequest inValue = new AxlNetClient.getImeClientRequest();
            inValue.getImeClient = getImeClient;
            return ((AxlNetClient.AXLPort59)(this)).getImeClientAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeClientResponse AxlNetClient.AXLPort59.removeImeClient(AxlNetClient.removeImeClientRequest request)
        {
            return base.Channel.removeImeClient(request);
        }

        public AxlNetClient.StandardResponse removeImeClient(AxlNetClient.NameAndGUIDRequest removeImeClient1)
        {
            AxlNetClient.removeImeClientRequest inValue = new AxlNetClient.removeImeClientRequest();
            inValue.removeImeClient = removeImeClient1;
            AxlNetClient.removeImeClientResponse retVal = ((AxlNetClient.AXLPort59)(this)).removeImeClient(inValue);
            return retVal.removeImeClientResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeClientResponse> AxlNetClient.AXLPort59.removeImeClientAsync(AxlNetClient.removeImeClientRequest request)
        {
            return base.Channel.removeImeClientAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeClientResponse> removeImeClientAsync(AxlNetClient.NameAndGUIDRequest removeImeClient)
        {
            AxlNetClient.removeImeClientRequest inValue = new AxlNetClient.removeImeClientRequest();
            inValue.removeImeClient = removeImeClient;
            return ((AxlNetClient.AXLPort59)(this)).removeImeClientAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeClientResponse AxlNetClient.AXLPort59.listImeClient(AxlNetClient.listImeClientRequest request)
        {
            return base.Channel.listImeClient(request);
        }

        public AxlNetClient.ListImeClientRes listImeClient(AxlNetClient.ListImeClientReq listImeClient1)
        {
            AxlNetClient.listImeClientRequest inValue = new AxlNetClient.listImeClientRequest();
            inValue.listImeClient = listImeClient1;
            AxlNetClient.listImeClientResponse retVal = ((AxlNetClient.AXLPort59)(this)).listImeClient(inValue);
            return retVal.listImeClientResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeClientResponse> AxlNetClient.AXLPort59.listImeClientAsync(AxlNetClient.listImeClientRequest request)
        {
            return base.Channel.listImeClientAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeClientResponse> listImeClientAsync(AxlNetClient.ListImeClientReq listImeClient)
        {
            AxlNetClient.listImeClientRequest inValue = new AxlNetClient.listImeClientRequest();
            inValue.listImeClient = listImeClient;
            return ((AxlNetClient.AXLPort59)(this)).listImeClientAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeEnrolledPatternResponse AxlNetClient.AXLPort59.addImeEnrolledPattern(AxlNetClient.addImeEnrolledPatternRequest request)
        {
            return base.Channel.addImeEnrolledPattern(request);
        }

        public AxlNetClient.StandardResponse addImeEnrolledPattern(AxlNetClient.AddImeEnrolledPatternReq addImeEnrolledPattern1)
        {
            AxlNetClient.addImeEnrolledPatternRequest inValue = new AxlNetClient.addImeEnrolledPatternRequest();
            inValue.addImeEnrolledPattern = addImeEnrolledPattern1;
            AxlNetClient.addImeEnrolledPatternResponse retVal = ((AxlNetClient.AXLPort59)(this)).addImeEnrolledPattern(inValue);
            return retVal.addImeEnrolledPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternResponse> AxlNetClient.AXLPort59.addImeEnrolledPatternAsync(AxlNetClient.addImeEnrolledPatternRequest request)
        {
            return base.Channel.addImeEnrolledPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeEnrolledPatternResponse> addImeEnrolledPatternAsync(AxlNetClient.AddImeEnrolledPatternReq addImeEnrolledPattern)
        {
            AxlNetClient.addImeEnrolledPatternRequest inValue = new AxlNetClient.addImeEnrolledPatternRequest();
            inValue.addImeEnrolledPattern = addImeEnrolledPattern;
            return ((AxlNetClient.AXLPort59)(this)).addImeEnrolledPatternAsync(inValue);
        }
    }
}