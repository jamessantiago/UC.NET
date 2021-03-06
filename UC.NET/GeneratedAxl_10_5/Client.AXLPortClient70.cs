namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient70 _axlPortClient70;

        private static AXLPortClient70 axlPortClient70 => _axlPortClient70 == null ||
            _axlPortClient70.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient70 = LoadClient70()) : _axlPortClient70;

        private static AXLPortClient70 LoadClient70()
        {
            var client = new AXLPortClient70(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close70;
            OnAbort += Abort70;
            return client;
        }

        private static void Close70(object sender, System.EventArgs e)
        {
            _axlPortClient70.Close();
        }

        private static void Abort70(object sender, System.EventArgs e)
        {
            _axlPortClient70.Abort();
        }

        public AxlNetClient.ListLbmHubGroupRes listLbmHubGroup(AxlNetClient.ListLbmHubGroupReq listLbmHubGroup1)
        {
            return axlPortClient70.listLbmHubGroup(listLbmHubGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLbmHubGroupResponse> listLbmHubGroupAsync(AxlNetClient.ListLbmHubGroupReq listLbmHubGroup)
        {
            return axlPortClient70.listLbmHubGroupAsync(listLbmHubGroup);
        }

        public AxlNetClient.StandardResponse addImportedDirectoryUriCatalogs(AxlNetClient.AddImportedDirectoryUriCatalogsReq addImportedDirectoryUriCatalogs1)
        {
            return axlPortClient70.addImportedDirectoryUriCatalogs(addImportedDirectoryUriCatalogs1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImportedDirectoryUriCatalogsResponse> addImportedDirectoryUriCatalogsAsync(AxlNetClient.AddImportedDirectoryUriCatalogsReq addImportedDirectoryUriCatalogs)
        {
            return axlPortClient70.addImportedDirectoryUriCatalogsAsync(addImportedDirectoryUriCatalogs);
        }

        public AxlNetClient.StandardResponse updateImportedDirectoryUriCatalogs(AxlNetClient.UpdateImportedDirectoryUriCatalogsReq updateImportedDirectoryUriCatalogs1)
        {
            return axlPortClient70.updateImportedDirectoryUriCatalogs(updateImportedDirectoryUriCatalogs1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImportedDirectoryUriCatalogsResponse> updateImportedDirectoryUriCatalogsAsync(AxlNetClient.UpdateImportedDirectoryUriCatalogsReq updateImportedDirectoryUriCatalogs)
        {
            return axlPortClient70.updateImportedDirectoryUriCatalogsAsync(updateImportedDirectoryUriCatalogs);
        }

        public AxlNetClient.GetImportedDirectoryUriCatalogsRes getImportedDirectoryUriCatalogs(AxlNetClient.GetImportedDirectoryUriCatalogsReq getImportedDirectoryUriCatalogs1)
        {
            return axlPortClient70.getImportedDirectoryUriCatalogs(getImportedDirectoryUriCatalogs1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImportedDirectoryUriCatalogsResponse> getImportedDirectoryUriCatalogsAsync(AxlNetClient.GetImportedDirectoryUriCatalogsReq getImportedDirectoryUriCatalogs)
        {
            return axlPortClient70.getImportedDirectoryUriCatalogsAsync(getImportedDirectoryUriCatalogs);
        }

        public AxlNetClient.StandardResponse removeImportedDirectoryUriCatalogs(AxlNetClient.NameAndGUIDRequest removeImportedDirectoryUriCatalogs1)
        {
            return axlPortClient70.removeImportedDirectoryUriCatalogs(removeImportedDirectoryUriCatalogs1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImportedDirectoryUriCatalogsResponse> removeImportedDirectoryUriCatalogsAsync(AxlNetClient.NameAndGUIDRequest removeImportedDirectoryUriCatalogs)
        {
            return axlPortClient70.removeImportedDirectoryUriCatalogsAsync(removeImportedDirectoryUriCatalogs);
        }

        public AxlNetClient.ListImportedDirectoryUriCatalogsRes listImportedDirectoryUriCatalogs(AxlNetClient.ListImportedDirectoryUriCatalogsReq listImportedDirectoryUriCatalogs1)
        {
            return axlPortClient70.listImportedDirectoryUriCatalogs(listImportedDirectoryUriCatalogs1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImportedDirectoryUriCatalogsResponse> listImportedDirectoryUriCatalogsAsync(AxlNetClient.ListImportedDirectoryUriCatalogsReq listImportedDirectoryUriCatalogs)
        {
            return axlPortClient70.listImportedDirectoryUriCatalogsAsync(listImportedDirectoryUriCatalogs);
        }

        public AxlNetClient.StandardResponse addVohServer(AxlNetClient.AddVohServerReq addVohServer1)
        {
            return axlPortClient70.addVohServer(addVohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVohServerResponse> addVohServerAsync(AxlNetClient.AddVohServerReq addVohServer)
        {
            return axlPortClient70.addVohServerAsync(addVohServer);
        }

        public AxlNetClient.StandardResponse updateVohServer(AxlNetClient.UpdateVohServerReq updateVohServer1)
        {
            return axlPortClient70.updateVohServer(updateVohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVohServerResponse> updateVohServerAsync(AxlNetClient.UpdateVohServerReq updateVohServer)
        {
            return axlPortClient70.updateVohServerAsync(updateVohServer);
        }

        public AxlNetClient.GetVohServerRes getVohServer(AxlNetClient.GetVohServerReq getVohServer1)
        {
            return axlPortClient70.getVohServer(getVohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVohServerResponse> getVohServerAsync(AxlNetClient.GetVohServerReq getVohServer)
        {
            return axlPortClient70.getVohServerAsync(getVohServer);
        }

        public AxlNetClient.StandardResponse removeVohServer(AxlNetClient.NameAndGUIDRequest removeVohServer1)
        {
            return axlPortClient70.removeVohServer(removeVohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVohServerResponse> removeVohServerAsync(AxlNetClient.NameAndGUIDRequest removeVohServer)
        {
            return axlPortClient70.removeVohServerAsync(removeVohServer);
        }

        public AxlNetClient.ListVohServerRes listVohServer(AxlNetClient.ListVohServerReq listVohServer1)
        {
            return axlPortClient70.listVohServer(listVohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVohServerResponse> listVohServerAsync(AxlNetClient.ListVohServerReq listVohServer)
        {
            return axlPortClient70.listVohServerAsync(listVohServer);
        }

        public AxlNetClient.StandardResponse addSdpTransparencyProfile(AxlNetClient.AddSdpTransparencyProfileReq addSdpTransparencyProfile1)
        {
            return axlPortClient70.addSdpTransparencyProfile(addSdpTransparencyProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSdpTransparencyProfileResponse> addSdpTransparencyProfileAsync(AxlNetClient.AddSdpTransparencyProfileReq addSdpTransparencyProfile)
        {
            return axlPortClient70.addSdpTransparencyProfileAsync(addSdpTransparencyProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort70
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLbmHubGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLbmHubGroupResponse listLbmHubGroup(AxlNetClient.listLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLbmHubGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLbmHubGroupResponse> listLbmHubGroupAsync(AxlNetClient.listLbmHubGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImportedDirectoryUriCatalogs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImportedDirectoryUriCatalogsResponse addImportedDirectoryUriCatalogs(AxlNetClient.addImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImportedDirectoryUriCatalogs", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImportedDirectoryUriCatalogsResponse> addImportedDirectoryUriCatalogsAsync(AxlNetClient.addImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImportedDirectoryUriCatalogs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImportedDirectoryUriCatalogsResponse updateImportedDirectoryUriCatalogs(AxlNetClient.updateImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImportedDirectoryUriCatalogs", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImportedDirectoryUriCatalogsResponse> updateImportedDirectoryUriCatalogsAsync(AxlNetClient.updateImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImportedDirectoryUriCatalogs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImportedDirectoryUriCatalogsResponse getImportedDirectoryUriCatalogs(AxlNetClient.getImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImportedDirectoryUriCatalogs", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImportedDirectoryUriCatalogsResponse> getImportedDirectoryUriCatalogsAsync(AxlNetClient.getImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImportedDirectoryUriCatalogs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImportedDirectoryUriCatalogsResponse removeImportedDirectoryUriCatalogs(AxlNetClient.removeImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImportedDirectoryUriCatalogs", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImportedDirectoryUriCatalogsResponse> removeImportedDirectoryUriCatalogsAsync(AxlNetClient.removeImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImportedDirectoryUriCatalogs", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImportedDirectoryUriCatalogsResponse listImportedDirectoryUriCatalogs(AxlNetClient.listImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImportedDirectoryUriCatalogs", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImportedDirectoryUriCatalogsResponse> listImportedDirectoryUriCatalogsAsync(AxlNetClient.listImportedDirectoryUriCatalogsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVohServerResponse addVohServer(AxlNetClient.addVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVohServerResponse> addVohServerAsync(AxlNetClient.addVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVohServerResponse updateVohServer(AxlNetClient.updateVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVohServerResponse> updateVohServerAsync(AxlNetClient.updateVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVohServerResponse getVohServer(AxlNetClient.getVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVohServerResponse> getVohServerAsync(AxlNetClient.getVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVohServerResponse removeVohServer(AxlNetClient.removeVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVohServerResponse> removeVohServerAsync(AxlNetClient.removeVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVohServerResponse listVohServer(AxlNetClient.listVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVohServerResponse> listVohServerAsync(AxlNetClient.listVohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSdpTransparencyProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSdpTransparencyProfileResponse addSdpTransparencyProfile(AxlNetClient.addSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSdpTransparencyProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSdpTransparencyProfileResponse> addSdpTransparencyProfileAsync(AxlNetClient.addSdpTransparencyProfileRequest request);
    }

    public class AXLPortClient70 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort70>, AxlNetClient.AXLPort70
    {
        public AXLPortClient70(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLbmHubGroupResponse AxlNetClient.AXLPort70.listLbmHubGroup(AxlNetClient.listLbmHubGroupRequest request)
        {
            return base.Channel.listLbmHubGroup(request);
        }

        public AxlNetClient.ListLbmHubGroupRes listLbmHubGroup(AxlNetClient.ListLbmHubGroupReq listLbmHubGroup1)
        {
            AxlNetClient.listLbmHubGroupRequest inValue = new AxlNetClient.listLbmHubGroupRequest();
            inValue.listLbmHubGroup = listLbmHubGroup1;
            AxlNetClient.listLbmHubGroupResponse retVal = ((AxlNetClient.AXLPort70)(this)).listLbmHubGroup(inValue);
            return retVal.listLbmHubGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLbmHubGroupResponse> AxlNetClient.AXLPort70.listLbmHubGroupAsync(AxlNetClient.listLbmHubGroupRequest request)
        {
            return base.Channel.listLbmHubGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLbmHubGroupResponse> listLbmHubGroupAsync(AxlNetClient.ListLbmHubGroupReq listLbmHubGroup)
        {
            AxlNetClient.listLbmHubGroupRequest inValue = new AxlNetClient.listLbmHubGroupRequest();
            inValue.listLbmHubGroup = listLbmHubGroup;
            return ((AxlNetClient.AXLPort70)(this)).listLbmHubGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImportedDirectoryUriCatalogsResponse AxlNetClient.AXLPort70.addImportedDirectoryUriCatalogs(AxlNetClient.addImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.addImportedDirectoryUriCatalogs(request);
        }

        public AxlNetClient.StandardResponse addImportedDirectoryUriCatalogs(AxlNetClient.AddImportedDirectoryUriCatalogsReq addImportedDirectoryUriCatalogs1)
        {
            AxlNetClient.addImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.addImportedDirectoryUriCatalogsRequest();
            inValue.addImportedDirectoryUriCatalogs = addImportedDirectoryUriCatalogs1;
            AxlNetClient.addImportedDirectoryUriCatalogsResponse retVal = ((AxlNetClient.AXLPort70)(this)).addImportedDirectoryUriCatalogs(inValue);
            return retVal.addImportedDirectoryUriCatalogsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImportedDirectoryUriCatalogsResponse> AxlNetClient.AXLPort70.addImportedDirectoryUriCatalogsAsync(AxlNetClient.addImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.addImportedDirectoryUriCatalogsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImportedDirectoryUriCatalogsResponse> addImportedDirectoryUriCatalogsAsync(AxlNetClient.AddImportedDirectoryUriCatalogsReq addImportedDirectoryUriCatalogs)
        {
            AxlNetClient.addImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.addImportedDirectoryUriCatalogsRequest();
            inValue.addImportedDirectoryUriCatalogs = addImportedDirectoryUriCatalogs;
            return ((AxlNetClient.AXLPort70)(this)).addImportedDirectoryUriCatalogsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImportedDirectoryUriCatalogsResponse AxlNetClient.AXLPort70.updateImportedDirectoryUriCatalogs(AxlNetClient.updateImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.updateImportedDirectoryUriCatalogs(request);
        }

        public AxlNetClient.StandardResponse updateImportedDirectoryUriCatalogs(AxlNetClient.UpdateImportedDirectoryUriCatalogsReq updateImportedDirectoryUriCatalogs1)
        {
            AxlNetClient.updateImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.updateImportedDirectoryUriCatalogsRequest();
            inValue.updateImportedDirectoryUriCatalogs = updateImportedDirectoryUriCatalogs1;
            AxlNetClient.updateImportedDirectoryUriCatalogsResponse retVal = ((AxlNetClient.AXLPort70)(this)).updateImportedDirectoryUriCatalogs(inValue);
            return retVal.updateImportedDirectoryUriCatalogsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImportedDirectoryUriCatalogsResponse> AxlNetClient.AXLPort70.updateImportedDirectoryUriCatalogsAsync(AxlNetClient.updateImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.updateImportedDirectoryUriCatalogsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImportedDirectoryUriCatalogsResponse> updateImportedDirectoryUriCatalogsAsync(AxlNetClient.UpdateImportedDirectoryUriCatalogsReq updateImportedDirectoryUriCatalogs)
        {
            AxlNetClient.updateImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.updateImportedDirectoryUriCatalogsRequest();
            inValue.updateImportedDirectoryUriCatalogs = updateImportedDirectoryUriCatalogs;
            return ((AxlNetClient.AXLPort70)(this)).updateImportedDirectoryUriCatalogsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImportedDirectoryUriCatalogsResponse AxlNetClient.AXLPort70.getImportedDirectoryUriCatalogs(AxlNetClient.getImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.getImportedDirectoryUriCatalogs(request);
        }

        public AxlNetClient.GetImportedDirectoryUriCatalogsRes getImportedDirectoryUriCatalogs(AxlNetClient.GetImportedDirectoryUriCatalogsReq getImportedDirectoryUriCatalogs1)
        {
            AxlNetClient.getImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.getImportedDirectoryUriCatalogsRequest();
            inValue.getImportedDirectoryUriCatalogs = getImportedDirectoryUriCatalogs1;
            AxlNetClient.getImportedDirectoryUriCatalogsResponse retVal = ((AxlNetClient.AXLPort70)(this)).getImportedDirectoryUriCatalogs(inValue);
            return retVal.getImportedDirectoryUriCatalogsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImportedDirectoryUriCatalogsResponse> AxlNetClient.AXLPort70.getImportedDirectoryUriCatalogsAsync(AxlNetClient.getImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.getImportedDirectoryUriCatalogsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImportedDirectoryUriCatalogsResponse> getImportedDirectoryUriCatalogsAsync(AxlNetClient.GetImportedDirectoryUriCatalogsReq getImportedDirectoryUriCatalogs)
        {
            AxlNetClient.getImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.getImportedDirectoryUriCatalogsRequest();
            inValue.getImportedDirectoryUriCatalogs = getImportedDirectoryUriCatalogs;
            return ((AxlNetClient.AXLPort70)(this)).getImportedDirectoryUriCatalogsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImportedDirectoryUriCatalogsResponse AxlNetClient.AXLPort70.removeImportedDirectoryUriCatalogs(AxlNetClient.removeImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.removeImportedDirectoryUriCatalogs(request);
        }

        public AxlNetClient.StandardResponse removeImportedDirectoryUriCatalogs(AxlNetClient.NameAndGUIDRequest removeImportedDirectoryUriCatalogs1)
        {
            AxlNetClient.removeImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.removeImportedDirectoryUriCatalogsRequest();
            inValue.removeImportedDirectoryUriCatalogs = removeImportedDirectoryUriCatalogs1;
            AxlNetClient.removeImportedDirectoryUriCatalogsResponse retVal = ((AxlNetClient.AXLPort70)(this)).removeImportedDirectoryUriCatalogs(inValue);
            return retVal.removeImportedDirectoryUriCatalogsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImportedDirectoryUriCatalogsResponse> AxlNetClient.AXLPort70.removeImportedDirectoryUriCatalogsAsync(AxlNetClient.removeImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.removeImportedDirectoryUriCatalogsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImportedDirectoryUriCatalogsResponse> removeImportedDirectoryUriCatalogsAsync(AxlNetClient.NameAndGUIDRequest removeImportedDirectoryUriCatalogs)
        {
            AxlNetClient.removeImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.removeImportedDirectoryUriCatalogsRequest();
            inValue.removeImportedDirectoryUriCatalogs = removeImportedDirectoryUriCatalogs;
            return ((AxlNetClient.AXLPort70)(this)).removeImportedDirectoryUriCatalogsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImportedDirectoryUriCatalogsResponse AxlNetClient.AXLPort70.listImportedDirectoryUriCatalogs(AxlNetClient.listImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.listImportedDirectoryUriCatalogs(request);
        }

        public AxlNetClient.ListImportedDirectoryUriCatalogsRes listImportedDirectoryUriCatalogs(AxlNetClient.ListImportedDirectoryUriCatalogsReq listImportedDirectoryUriCatalogs1)
        {
            AxlNetClient.listImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.listImportedDirectoryUriCatalogsRequest();
            inValue.listImportedDirectoryUriCatalogs = listImportedDirectoryUriCatalogs1;
            AxlNetClient.listImportedDirectoryUriCatalogsResponse retVal = ((AxlNetClient.AXLPort70)(this)).listImportedDirectoryUriCatalogs(inValue);
            return retVal.listImportedDirectoryUriCatalogsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImportedDirectoryUriCatalogsResponse> AxlNetClient.AXLPort70.listImportedDirectoryUriCatalogsAsync(AxlNetClient.listImportedDirectoryUriCatalogsRequest request)
        {
            return base.Channel.listImportedDirectoryUriCatalogsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImportedDirectoryUriCatalogsResponse> listImportedDirectoryUriCatalogsAsync(AxlNetClient.ListImportedDirectoryUriCatalogsReq listImportedDirectoryUriCatalogs)
        {
            AxlNetClient.listImportedDirectoryUriCatalogsRequest inValue = new AxlNetClient.listImportedDirectoryUriCatalogsRequest();
            inValue.listImportedDirectoryUriCatalogs = listImportedDirectoryUriCatalogs;
            return ((AxlNetClient.AXLPort70)(this)).listImportedDirectoryUriCatalogsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVohServerResponse AxlNetClient.AXLPort70.addVohServer(AxlNetClient.addVohServerRequest request)
        {
            return base.Channel.addVohServer(request);
        }

        public AxlNetClient.StandardResponse addVohServer(AxlNetClient.AddVohServerReq addVohServer1)
        {
            AxlNetClient.addVohServerRequest inValue = new AxlNetClient.addVohServerRequest();
            inValue.addVohServer = addVohServer1;
            AxlNetClient.addVohServerResponse retVal = ((AxlNetClient.AXLPort70)(this)).addVohServer(inValue);
            return retVal.addVohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVohServerResponse> AxlNetClient.AXLPort70.addVohServerAsync(AxlNetClient.addVohServerRequest request)
        {
            return base.Channel.addVohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVohServerResponse> addVohServerAsync(AxlNetClient.AddVohServerReq addVohServer)
        {
            AxlNetClient.addVohServerRequest inValue = new AxlNetClient.addVohServerRequest();
            inValue.addVohServer = addVohServer;
            return ((AxlNetClient.AXLPort70)(this)).addVohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVohServerResponse AxlNetClient.AXLPort70.updateVohServer(AxlNetClient.updateVohServerRequest request)
        {
            return base.Channel.updateVohServer(request);
        }

        public AxlNetClient.StandardResponse updateVohServer(AxlNetClient.UpdateVohServerReq updateVohServer1)
        {
            AxlNetClient.updateVohServerRequest inValue = new AxlNetClient.updateVohServerRequest();
            inValue.updateVohServer = updateVohServer1;
            AxlNetClient.updateVohServerResponse retVal = ((AxlNetClient.AXLPort70)(this)).updateVohServer(inValue);
            return retVal.updateVohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVohServerResponse> AxlNetClient.AXLPort70.updateVohServerAsync(AxlNetClient.updateVohServerRequest request)
        {
            return base.Channel.updateVohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVohServerResponse> updateVohServerAsync(AxlNetClient.UpdateVohServerReq updateVohServer)
        {
            AxlNetClient.updateVohServerRequest inValue = new AxlNetClient.updateVohServerRequest();
            inValue.updateVohServer = updateVohServer;
            return ((AxlNetClient.AXLPort70)(this)).updateVohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVohServerResponse AxlNetClient.AXLPort70.getVohServer(AxlNetClient.getVohServerRequest request)
        {
            return base.Channel.getVohServer(request);
        }

        public AxlNetClient.GetVohServerRes getVohServer(AxlNetClient.GetVohServerReq getVohServer1)
        {
            AxlNetClient.getVohServerRequest inValue = new AxlNetClient.getVohServerRequest();
            inValue.getVohServer = getVohServer1;
            AxlNetClient.getVohServerResponse retVal = ((AxlNetClient.AXLPort70)(this)).getVohServer(inValue);
            return retVal.getVohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVohServerResponse> AxlNetClient.AXLPort70.getVohServerAsync(AxlNetClient.getVohServerRequest request)
        {
            return base.Channel.getVohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVohServerResponse> getVohServerAsync(AxlNetClient.GetVohServerReq getVohServer)
        {
            AxlNetClient.getVohServerRequest inValue = new AxlNetClient.getVohServerRequest();
            inValue.getVohServer = getVohServer;
            return ((AxlNetClient.AXLPort70)(this)).getVohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVohServerResponse AxlNetClient.AXLPort70.removeVohServer(AxlNetClient.removeVohServerRequest request)
        {
            return base.Channel.removeVohServer(request);
        }

        public AxlNetClient.StandardResponse removeVohServer(AxlNetClient.NameAndGUIDRequest removeVohServer1)
        {
            AxlNetClient.removeVohServerRequest inValue = new AxlNetClient.removeVohServerRequest();
            inValue.removeVohServer = removeVohServer1;
            AxlNetClient.removeVohServerResponse retVal = ((AxlNetClient.AXLPort70)(this)).removeVohServer(inValue);
            return retVal.removeVohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVohServerResponse> AxlNetClient.AXLPort70.removeVohServerAsync(AxlNetClient.removeVohServerRequest request)
        {
            return base.Channel.removeVohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVohServerResponse> removeVohServerAsync(AxlNetClient.NameAndGUIDRequest removeVohServer)
        {
            AxlNetClient.removeVohServerRequest inValue = new AxlNetClient.removeVohServerRequest();
            inValue.removeVohServer = removeVohServer;
            return ((AxlNetClient.AXLPort70)(this)).removeVohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVohServerResponse AxlNetClient.AXLPort70.listVohServer(AxlNetClient.listVohServerRequest request)
        {
            return base.Channel.listVohServer(request);
        }

        public AxlNetClient.ListVohServerRes listVohServer(AxlNetClient.ListVohServerReq listVohServer1)
        {
            AxlNetClient.listVohServerRequest inValue = new AxlNetClient.listVohServerRequest();
            inValue.listVohServer = listVohServer1;
            AxlNetClient.listVohServerResponse retVal = ((AxlNetClient.AXLPort70)(this)).listVohServer(inValue);
            return retVal.listVohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVohServerResponse> AxlNetClient.AXLPort70.listVohServerAsync(AxlNetClient.listVohServerRequest request)
        {
            return base.Channel.listVohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVohServerResponse> listVohServerAsync(AxlNetClient.ListVohServerReq listVohServer)
        {
            AxlNetClient.listVohServerRequest inValue = new AxlNetClient.listVohServerRequest();
            inValue.listVohServer = listVohServer;
            return ((AxlNetClient.AXLPort70)(this)).listVohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSdpTransparencyProfileResponse AxlNetClient.AXLPort70.addSdpTransparencyProfile(AxlNetClient.addSdpTransparencyProfileRequest request)
        {
            return base.Channel.addSdpTransparencyProfile(request);
        }

        public AxlNetClient.StandardResponse addSdpTransparencyProfile(AxlNetClient.AddSdpTransparencyProfileReq addSdpTransparencyProfile1)
        {
            AxlNetClient.addSdpTransparencyProfileRequest inValue = new AxlNetClient.addSdpTransparencyProfileRequest();
            inValue.addSdpTransparencyProfile = addSdpTransparencyProfile1;
            AxlNetClient.addSdpTransparencyProfileResponse retVal = ((AxlNetClient.AXLPort70)(this)).addSdpTransparencyProfile(inValue);
            return retVal.addSdpTransparencyProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSdpTransparencyProfileResponse> AxlNetClient.AXLPort70.addSdpTransparencyProfileAsync(AxlNetClient.addSdpTransparencyProfileRequest request)
        {
            return base.Channel.addSdpTransparencyProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSdpTransparencyProfileResponse> addSdpTransparencyProfileAsync(AxlNetClient.AddSdpTransparencyProfileReq addSdpTransparencyProfile)
        {
            AxlNetClient.addSdpTransparencyProfileRequest inValue = new AxlNetClient.addSdpTransparencyProfileRequest();
            inValue.addSdpTransparencyProfile = addSdpTransparencyProfile;
            return ((AxlNetClient.AXLPort70)(this)).addSdpTransparencyProfileAsync(inValue);
        }
    }
}