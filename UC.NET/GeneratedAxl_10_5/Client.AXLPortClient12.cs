namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient12 _axlPortClient12;

        private static AXLPortClient12 axlPortClient12 => _axlPortClient12 == null ||
            _axlPortClient12.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient12 = LoadClient12()) : _axlPortClient12;

        private static AXLPortClient12 LoadClient12()
        {
            var client = new AXLPortClient12(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close12;
            OnAbort += Abort12;
            return client;
        }

        private static void Close12(object sender, System.EventArgs e)
        {
            _axlPortClient12.Close();
        }

        private static void Abort12(object sender, System.EventArgs e)
        {
            _axlPortClient12.Abort();
        }

        public AxlNetClient.StandardResponse resetCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest resetCommonDeviceConfig1)
        {
            return axlPortClient12.resetCommonDeviceConfig(resetCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCommonDeviceConfigResponse> resetCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest resetCommonDeviceConfig)
        {
            return axlPortClient12.resetCommonDeviceConfigAsync(resetCommonDeviceConfig);
        }

        public AxlNetClient.StandardResponse applyCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest applyCommonDeviceConfig1)
        {
            return axlPortClient12.applyCommonDeviceConfig(applyCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCommonDeviceConfigResponse> applyCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest applyCommonDeviceConfig)
        {
            return axlPortClient12.applyCommonDeviceConfigAsync(applyCommonDeviceConfig);
        }

        public AxlNetClient.StandardResponse addResourcePriorityNamespace(AxlNetClient.AddResourcePriorityNamespaceReq addResourcePriorityNamespace1)
        {
            return axlPortClient12.addResourcePriorityNamespace(addResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceResponse> addResourcePriorityNamespaceAsync(AxlNetClient.AddResourcePriorityNamespaceReq addResourcePriorityNamespace)
        {
            return axlPortClient12.addResourcePriorityNamespaceAsync(addResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse updateResourcePriorityNamespace(AxlNetClient.UpdateResourcePriorityNamespaceReq updateResourcePriorityNamespace1)
        {
            return axlPortClient12.updateResourcePriorityNamespace(updateResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceResponse> updateResourcePriorityNamespaceAsync(AxlNetClient.UpdateResourcePriorityNamespaceReq updateResourcePriorityNamespace)
        {
            return axlPortClient12.updateResourcePriorityNamespaceAsync(updateResourcePriorityNamespace);
        }

        public AxlNetClient.GetResourcePriorityNamespaceRes getResourcePriorityNamespace(AxlNetClient.GetResourcePriorityNamespaceReq getResourcePriorityNamespace1)
        {
            return axlPortClient12.getResourcePriorityNamespace(getResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceResponse> getResourcePriorityNamespaceAsync(AxlNetClient.GetResourcePriorityNamespaceReq getResourcePriorityNamespace)
        {
            return axlPortClient12.getResourcePriorityNamespaceAsync(getResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse removeResourcePriorityNamespace(AxlNetClient.RemoveResourcePriorityNamespaceReq removeResourcePriorityNamespace1)
        {
            return axlPortClient12.removeResourcePriorityNamespace(removeResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceResponse> removeResourcePriorityNamespaceAsync(AxlNetClient.RemoveResourcePriorityNamespaceReq removeResourcePriorityNamespace)
        {
            return axlPortClient12.removeResourcePriorityNamespaceAsync(removeResourcePriorityNamespace);
        }

        public AxlNetClient.ListResourcePriorityNamespaceRes listResourcePriorityNamespace(AxlNetClient.ListResourcePriorityNamespaceReq listResourcePriorityNamespace1)
        {
            return axlPortClient12.listResourcePriorityNamespace(listResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceResponse> listResourcePriorityNamespaceAsync(AxlNetClient.ListResourcePriorityNamespaceReq listResourcePriorityNamespace)
        {
            return axlPortClient12.listResourcePriorityNamespaceAsync(listResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse resetResourcePriorityNamespace(AxlNetClient.ResetResourcePriorityNamespaceReq resetResourcePriorityNamespace1)
        {
            return axlPortClient12.resetResourcePriorityNamespace(resetResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceResponse> resetResourcePriorityNamespaceAsync(AxlNetClient.ResetResourcePriorityNamespaceReq resetResourcePriorityNamespace)
        {
            return axlPortClient12.resetResourcePriorityNamespaceAsync(resetResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse restartResourcePriorityNamespace(AxlNetClient.RestartResourcePriorityNamespaceReq restartResourcePriorityNamespace1)
        {
            return axlPortClient12.restartResourcePriorityNamespace(restartResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceResponse> restartResourcePriorityNamespaceAsync(AxlNetClient.RestartResourcePriorityNamespaceReq restartResourcePriorityNamespace)
        {
            return axlPortClient12.restartResourcePriorityNamespaceAsync(restartResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse applyResourcePriorityNamespace(AxlNetClient.ApplyResourcePriorityNamespaceReq applyResourcePriorityNamespace1)
        {
            return axlPortClient12.applyResourcePriorityNamespace(applyResourcePriorityNamespace1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceResponse> applyResourcePriorityNamespaceAsync(AxlNetClient.ApplyResourcePriorityNamespaceReq applyResourcePriorityNamespace)
        {
            return axlPortClient12.applyResourcePriorityNamespaceAsync(applyResourcePriorityNamespace);
        }

        public AxlNetClient.StandardResponse addResourcePriorityNamespaceList(AxlNetClient.AddResourcePriorityNamespaceListReq addResourcePriorityNamespaceList1)
        {
            return axlPortClient12.addResourcePriorityNamespaceList(addResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceListResponse> addResourcePriorityNamespaceListAsync(AxlNetClient.AddResourcePriorityNamespaceListReq addResourcePriorityNamespaceList)
        {
            return axlPortClient12.addResourcePriorityNamespaceListAsync(addResourcePriorityNamespaceList);
        }

        public AxlNetClient.StandardResponse updateResourcePriorityNamespaceList(AxlNetClient.UpdateResourcePriorityNamespaceListReq updateResourcePriorityNamespaceList1)
        {
            return axlPortClient12.updateResourcePriorityNamespaceList(updateResourcePriorityNamespaceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceListResponse> updateResourcePriorityNamespaceListAsync(AxlNetClient.UpdateResourcePriorityNamespaceListReq updateResourcePriorityNamespaceList)
        {
            return axlPortClient12.updateResourcePriorityNamespaceListAsync(updateResourcePriorityNamespaceList);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort12
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCommonDeviceConfigResponse resetCommonDeviceConfig(AxlNetClient.resetCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCommonDeviceConfigResponse> resetCommonDeviceConfigAsync(AxlNetClient.resetCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCommonDeviceConfigResponse applyCommonDeviceConfig(AxlNetClient.applyCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCommonDeviceConfigResponse> applyCommonDeviceConfigAsync(AxlNetClient.applyCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addResourcePriorityNamespaceResponse addResourcePriorityNamespace(AxlNetClient.addResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceResponse> addResourcePriorityNamespaceAsync(AxlNetClient.addResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateResourcePriorityNamespaceResponse updateResourcePriorityNamespace(AxlNetClient.updateResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceResponse> updateResourcePriorityNamespaceAsync(AxlNetClient.updateResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getResourcePriorityNamespaceResponse getResourcePriorityNamespace(AxlNetClient.getResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceResponse> getResourcePriorityNamespaceAsync(AxlNetClient.getResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeResourcePriorityNamespaceResponse removeResourcePriorityNamespace(AxlNetClient.removeResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceResponse> removeResourcePriorityNamespaceAsync(AxlNetClient.removeResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listResourcePriorityNamespaceResponse listResourcePriorityNamespace(AxlNetClient.listResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceResponse> listResourcePriorityNamespaceAsync(AxlNetClient.listResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetResourcePriorityNamespaceResponse resetResourcePriorityNamespace(AxlNetClient.resetResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceResponse> resetResourcePriorityNamespaceAsync(AxlNetClient.resetResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartResourcePriorityNamespaceResponse restartResourcePriorityNamespace(AxlNetClient.restartResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceResponse> restartResourcePriorityNamespaceAsync(AxlNetClient.restartResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyResourcePriorityNamespace", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyResourcePriorityNamespaceResponse applyResourcePriorityNamespace(AxlNetClient.applyResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyResourcePriorityNamespace", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceResponse> applyResourcePriorityNamespaceAsync(AxlNetClient.applyResourcePriorityNamespaceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addResourcePriorityNamespaceListResponse addResourcePriorityNamespaceList(AxlNetClient.addResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceListResponse> addResourcePriorityNamespaceListAsync(AxlNetClient.addResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateResourcePriorityNamespaceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateResourcePriorityNamespaceListResponse updateResourcePriorityNamespaceList(AxlNetClient.updateResourcePriorityNamespaceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateResourcePriorityNamespaceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceListResponse> updateResourcePriorityNamespaceListAsync(AxlNetClient.updateResourcePriorityNamespaceListRequest request);
    }

    public class AXLPortClient12 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort12>, AxlNetClient.AXLPort12
    {
        public AXLPortClient12(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCommonDeviceConfigResponse AxlNetClient.AXLPort12.resetCommonDeviceConfig(AxlNetClient.resetCommonDeviceConfigRequest request)
        {
            return base.Channel.resetCommonDeviceConfig(request);
        }

        public AxlNetClient.StandardResponse resetCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest resetCommonDeviceConfig1)
        {
            AxlNetClient.resetCommonDeviceConfigRequest inValue = new AxlNetClient.resetCommonDeviceConfigRequest();
            inValue.resetCommonDeviceConfig = resetCommonDeviceConfig1;
            AxlNetClient.resetCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort12)(this)).resetCommonDeviceConfig(inValue);
            return retVal.resetCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCommonDeviceConfigResponse> AxlNetClient.AXLPort12.resetCommonDeviceConfigAsync(AxlNetClient.resetCommonDeviceConfigRequest request)
        {
            return base.Channel.resetCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCommonDeviceConfigResponse> resetCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest resetCommonDeviceConfig)
        {
            AxlNetClient.resetCommonDeviceConfigRequest inValue = new AxlNetClient.resetCommonDeviceConfigRequest();
            inValue.resetCommonDeviceConfig = resetCommonDeviceConfig;
            return ((AxlNetClient.AXLPort12)(this)).resetCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCommonDeviceConfigResponse AxlNetClient.AXLPort12.applyCommonDeviceConfig(AxlNetClient.applyCommonDeviceConfigRequest request)
        {
            return base.Channel.applyCommonDeviceConfig(request);
        }

        public AxlNetClient.StandardResponse applyCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest applyCommonDeviceConfig1)
        {
            AxlNetClient.applyCommonDeviceConfigRequest inValue = new AxlNetClient.applyCommonDeviceConfigRequest();
            inValue.applyCommonDeviceConfig = applyCommonDeviceConfig1;
            AxlNetClient.applyCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort12)(this)).applyCommonDeviceConfig(inValue);
            return retVal.applyCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCommonDeviceConfigResponse> AxlNetClient.AXLPort12.applyCommonDeviceConfigAsync(AxlNetClient.applyCommonDeviceConfigRequest request)
        {
            return base.Channel.applyCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCommonDeviceConfigResponse> applyCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest applyCommonDeviceConfig)
        {
            AxlNetClient.applyCommonDeviceConfigRequest inValue = new AxlNetClient.applyCommonDeviceConfigRequest();
            inValue.applyCommonDeviceConfig = applyCommonDeviceConfig;
            return ((AxlNetClient.AXLPort12)(this)).applyCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.addResourcePriorityNamespace(AxlNetClient.addResourcePriorityNamespaceRequest request)
        {
            return base.Channel.addResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse addResourcePriorityNamespace(AxlNetClient.AddResourcePriorityNamespaceReq addResourcePriorityNamespace1)
        {
            AxlNetClient.addResourcePriorityNamespaceRequest inValue = new AxlNetClient.addResourcePriorityNamespaceRequest();
            inValue.addResourcePriorityNamespace = addResourcePriorityNamespace1;
            AxlNetClient.addResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).addResourcePriorityNamespace(inValue);
            return retVal.addResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.addResourcePriorityNamespaceAsync(AxlNetClient.addResourcePriorityNamespaceRequest request)
        {
            return base.Channel.addResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceResponse> addResourcePriorityNamespaceAsync(AxlNetClient.AddResourcePriorityNamespaceReq addResourcePriorityNamespace)
        {
            AxlNetClient.addResourcePriorityNamespaceRequest inValue = new AxlNetClient.addResourcePriorityNamespaceRequest();
            inValue.addResourcePriorityNamespace = addResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).addResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.updateResourcePriorityNamespace(AxlNetClient.updateResourcePriorityNamespaceRequest request)
        {
            return base.Channel.updateResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse updateResourcePriorityNamespace(AxlNetClient.UpdateResourcePriorityNamespaceReq updateResourcePriorityNamespace1)
        {
            AxlNetClient.updateResourcePriorityNamespaceRequest inValue = new AxlNetClient.updateResourcePriorityNamespaceRequest();
            inValue.updateResourcePriorityNamespace = updateResourcePriorityNamespace1;
            AxlNetClient.updateResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).updateResourcePriorityNamespace(inValue);
            return retVal.updateResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.updateResourcePriorityNamespaceAsync(AxlNetClient.updateResourcePriorityNamespaceRequest request)
        {
            return base.Channel.updateResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceResponse> updateResourcePriorityNamespaceAsync(AxlNetClient.UpdateResourcePriorityNamespaceReq updateResourcePriorityNamespace)
        {
            AxlNetClient.updateResourcePriorityNamespaceRequest inValue = new AxlNetClient.updateResourcePriorityNamespaceRequest();
            inValue.updateResourcePriorityNamespace = updateResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).updateResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.getResourcePriorityNamespace(AxlNetClient.getResourcePriorityNamespaceRequest request)
        {
            return base.Channel.getResourcePriorityNamespace(request);
        }

        public AxlNetClient.GetResourcePriorityNamespaceRes getResourcePriorityNamespace(AxlNetClient.GetResourcePriorityNamespaceReq getResourcePriorityNamespace1)
        {
            AxlNetClient.getResourcePriorityNamespaceRequest inValue = new AxlNetClient.getResourcePriorityNamespaceRequest();
            inValue.getResourcePriorityNamespace = getResourcePriorityNamespace1;
            AxlNetClient.getResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).getResourcePriorityNamespace(inValue);
            return retVal.getResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.getResourcePriorityNamespaceAsync(AxlNetClient.getResourcePriorityNamespaceRequest request)
        {
            return base.Channel.getResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getResourcePriorityNamespaceResponse> getResourcePriorityNamespaceAsync(AxlNetClient.GetResourcePriorityNamespaceReq getResourcePriorityNamespace)
        {
            AxlNetClient.getResourcePriorityNamespaceRequest inValue = new AxlNetClient.getResourcePriorityNamespaceRequest();
            inValue.getResourcePriorityNamespace = getResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).getResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.removeResourcePriorityNamespace(AxlNetClient.removeResourcePriorityNamespaceRequest request)
        {
            return base.Channel.removeResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse removeResourcePriorityNamespace(AxlNetClient.RemoveResourcePriorityNamespaceReq removeResourcePriorityNamespace1)
        {
            AxlNetClient.removeResourcePriorityNamespaceRequest inValue = new AxlNetClient.removeResourcePriorityNamespaceRequest();
            inValue.removeResourcePriorityNamespace = removeResourcePriorityNamespace1;
            AxlNetClient.removeResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).removeResourcePriorityNamespace(inValue);
            return retVal.removeResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.removeResourcePriorityNamespaceAsync(AxlNetClient.removeResourcePriorityNamespaceRequest request)
        {
            return base.Channel.removeResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeResourcePriorityNamespaceResponse> removeResourcePriorityNamespaceAsync(AxlNetClient.RemoveResourcePriorityNamespaceReq removeResourcePriorityNamespace)
        {
            AxlNetClient.removeResourcePriorityNamespaceRequest inValue = new AxlNetClient.removeResourcePriorityNamespaceRequest();
            inValue.removeResourcePriorityNamespace = removeResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).removeResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.listResourcePriorityNamespace(AxlNetClient.listResourcePriorityNamespaceRequest request)
        {
            return base.Channel.listResourcePriorityNamespace(request);
        }

        public AxlNetClient.ListResourcePriorityNamespaceRes listResourcePriorityNamespace(AxlNetClient.ListResourcePriorityNamespaceReq listResourcePriorityNamespace1)
        {
            AxlNetClient.listResourcePriorityNamespaceRequest inValue = new AxlNetClient.listResourcePriorityNamespaceRequest();
            inValue.listResourcePriorityNamespace = listResourcePriorityNamespace1;
            AxlNetClient.listResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).listResourcePriorityNamespace(inValue);
            return retVal.listResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.listResourcePriorityNamespaceAsync(AxlNetClient.listResourcePriorityNamespaceRequest request)
        {
            return base.Channel.listResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listResourcePriorityNamespaceResponse> listResourcePriorityNamespaceAsync(AxlNetClient.ListResourcePriorityNamespaceReq listResourcePriorityNamespace)
        {
            AxlNetClient.listResourcePriorityNamespaceRequest inValue = new AxlNetClient.listResourcePriorityNamespaceRequest();
            inValue.listResourcePriorityNamespace = listResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).listResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.resetResourcePriorityNamespace(AxlNetClient.resetResourcePriorityNamespaceRequest request)
        {
            return base.Channel.resetResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse resetResourcePriorityNamespace(AxlNetClient.ResetResourcePriorityNamespaceReq resetResourcePriorityNamespace1)
        {
            AxlNetClient.resetResourcePriorityNamespaceRequest inValue = new AxlNetClient.resetResourcePriorityNamespaceRequest();
            inValue.resetResourcePriorityNamespace = resetResourcePriorityNamespace1;
            AxlNetClient.resetResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).resetResourcePriorityNamespace(inValue);
            return retVal.resetResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.resetResourcePriorityNamespaceAsync(AxlNetClient.resetResourcePriorityNamespaceRequest request)
        {
            return base.Channel.resetResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetResourcePriorityNamespaceResponse> resetResourcePriorityNamespaceAsync(AxlNetClient.ResetResourcePriorityNamespaceReq resetResourcePriorityNamespace)
        {
            AxlNetClient.resetResourcePriorityNamespaceRequest inValue = new AxlNetClient.resetResourcePriorityNamespaceRequest();
            inValue.resetResourcePriorityNamespace = resetResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).resetResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.restartResourcePriorityNamespace(AxlNetClient.restartResourcePriorityNamespaceRequest request)
        {
            return base.Channel.restartResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse restartResourcePriorityNamespace(AxlNetClient.RestartResourcePriorityNamespaceReq restartResourcePriorityNamespace1)
        {
            AxlNetClient.restartResourcePriorityNamespaceRequest inValue = new AxlNetClient.restartResourcePriorityNamespaceRequest();
            inValue.restartResourcePriorityNamespace = restartResourcePriorityNamespace1;
            AxlNetClient.restartResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).restartResourcePriorityNamespace(inValue);
            return retVal.restartResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.restartResourcePriorityNamespaceAsync(AxlNetClient.restartResourcePriorityNamespaceRequest request)
        {
            return base.Channel.restartResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartResourcePriorityNamespaceResponse> restartResourcePriorityNamespaceAsync(AxlNetClient.RestartResourcePriorityNamespaceReq restartResourcePriorityNamespace)
        {
            AxlNetClient.restartResourcePriorityNamespaceRequest inValue = new AxlNetClient.restartResourcePriorityNamespaceRequest();
            inValue.restartResourcePriorityNamespace = restartResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).restartResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyResourcePriorityNamespaceResponse AxlNetClient.AXLPort12.applyResourcePriorityNamespace(AxlNetClient.applyResourcePriorityNamespaceRequest request)
        {
            return base.Channel.applyResourcePriorityNamespace(request);
        }

        public AxlNetClient.StandardResponse applyResourcePriorityNamespace(AxlNetClient.ApplyResourcePriorityNamespaceReq applyResourcePriorityNamespace1)
        {
            AxlNetClient.applyResourcePriorityNamespaceRequest inValue = new AxlNetClient.applyResourcePriorityNamespaceRequest();
            inValue.applyResourcePriorityNamespace = applyResourcePriorityNamespace1;
            AxlNetClient.applyResourcePriorityNamespaceResponse retVal = ((AxlNetClient.AXLPort12)(this)).applyResourcePriorityNamespace(inValue);
            return retVal.applyResourcePriorityNamespaceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceResponse> AxlNetClient.AXLPort12.applyResourcePriorityNamespaceAsync(AxlNetClient.applyResourcePriorityNamespaceRequest request)
        {
            return base.Channel.applyResourcePriorityNamespaceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyResourcePriorityNamespaceResponse> applyResourcePriorityNamespaceAsync(AxlNetClient.ApplyResourcePriorityNamespaceReq applyResourcePriorityNamespace)
        {
            AxlNetClient.applyResourcePriorityNamespaceRequest inValue = new AxlNetClient.applyResourcePriorityNamespaceRequest();
            inValue.applyResourcePriorityNamespace = applyResourcePriorityNamespace;
            return ((AxlNetClient.AXLPort12)(this)).applyResourcePriorityNamespaceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addResourcePriorityNamespaceListResponse AxlNetClient.AXLPort12.addResourcePriorityNamespaceList(AxlNetClient.addResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.addResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse addResourcePriorityNamespaceList(AxlNetClient.AddResourcePriorityNamespaceListReq addResourcePriorityNamespaceList1)
        {
            AxlNetClient.addResourcePriorityNamespaceListRequest inValue = new AxlNetClient.addResourcePriorityNamespaceListRequest();
            inValue.addResourcePriorityNamespaceList = addResourcePriorityNamespaceList1;
            AxlNetClient.addResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort12)(this)).addResourcePriorityNamespaceList(inValue);
            return retVal.addResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort12.addResourcePriorityNamespaceListAsync(AxlNetClient.addResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.addResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addResourcePriorityNamespaceListResponse> addResourcePriorityNamespaceListAsync(AxlNetClient.AddResourcePriorityNamespaceListReq addResourcePriorityNamespaceList)
        {
            AxlNetClient.addResourcePriorityNamespaceListRequest inValue = new AxlNetClient.addResourcePriorityNamespaceListRequest();
            inValue.addResourcePriorityNamespaceList = addResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort12)(this)).addResourcePriorityNamespaceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateResourcePriorityNamespaceListResponse AxlNetClient.AXLPort12.updateResourcePriorityNamespaceList(AxlNetClient.updateResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.updateResourcePriorityNamespaceList(request);
        }

        public AxlNetClient.StandardResponse updateResourcePriorityNamespaceList(AxlNetClient.UpdateResourcePriorityNamespaceListReq updateResourcePriorityNamespaceList1)
        {
            AxlNetClient.updateResourcePriorityNamespaceListRequest inValue = new AxlNetClient.updateResourcePriorityNamespaceListRequest();
            inValue.updateResourcePriorityNamespaceList = updateResourcePriorityNamespaceList1;
            AxlNetClient.updateResourcePriorityNamespaceListResponse retVal = ((AxlNetClient.AXLPort12)(this)).updateResourcePriorityNamespaceList(inValue);
            return retVal.updateResourcePriorityNamespaceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceListResponse> AxlNetClient.AXLPort12.updateResourcePriorityNamespaceListAsync(AxlNetClient.updateResourcePriorityNamespaceListRequest request)
        {
            return base.Channel.updateResourcePriorityNamespaceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateResourcePriorityNamespaceListResponse> updateResourcePriorityNamespaceListAsync(AxlNetClient.UpdateResourcePriorityNamespaceListReq updateResourcePriorityNamespaceList)
        {
            AxlNetClient.updateResourcePriorityNamespaceListRequest inValue = new AxlNetClient.updateResourcePriorityNamespaceListRequest();
            inValue.updateResourcePriorityNamespaceList = updateResourcePriorityNamespaceList;
            return ((AxlNetClient.AXLPort12)(this)).updateResourcePriorityNamespaceListAsync(inValue);
        }
    }
}