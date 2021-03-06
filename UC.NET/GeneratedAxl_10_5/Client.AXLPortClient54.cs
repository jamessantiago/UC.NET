namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient54 _axlPortClient54;

        private static AXLPortClient54 axlPortClient54 => _axlPortClient54 == null ||
            _axlPortClient54.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient54 = LoadClient54()) : _axlPortClient54;

        private static AXLPortClient54 LoadClient54()
        {
            var client = new AXLPortClient54(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close54;
            OnAbort += Abort54;
            return client;
        }

        private static void Close54(object sender, System.EventArgs e)
        {
            _axlPortClient54.Close();
        }

        private static void Abort54(object sender, System.EventArgs e)
        {
            _axlPortClient54.Abort();
        }

        public AxlNetClient.ListCcdHostedDNRes listCcdHostedDN(AxlNetClient.ListCcdHostedDNReq listCcdHostedDN1)
        {
            return axlPortClient54.listCcdHostedDN(listCcdHostedDN1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNResponse> listCcdHostedDNAsync(AxlNetClient.ListCcdHostedDNReq listCcdHostedDN)
        {
            return axlPortClient54.listCcdHostedDNAsync(listCcdHostedDN);
        }

        public AxlNetClient.StandardResponse addCcdHostedDNGroup(AxlNetClient.AddCcdHostedDNGroupReq addCcdHostedDNGroup1)
        {
            return axlPortClient54.addCcdHostedDNGroup(addCcdHostedDNGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNGroupResponse> addCcdHostedDNGroupAsync(AxlNetClient.AddCcdHostedDNGroupReq addCcdHostedDNGroup)
        {
            return axlPortClient54.addCcdHostedDNGroupAsync(addCcdHostedDNGroup);
        }

        public AxlNetClient.StandardResponse updateCcdHostedDNGroup(AxlNetClient.UpdateCcdHostedDNGroupReq updateCcdHostedDNGroup1)
        {
            return axlPortClient54.updateCcdHostedDNGroup(updateCcdHostedDNGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNGroupResponse> updateCcdHostedDNGroupAsync(AxlNetClient.UpdateCcdHostedDNGroupReq updateCcdHostedDNGroup)
        {
            return axlPortClient54.updateCcdHostedDNGroupAsync(updateCcdHostedDNGroup);
        }

        public AxlNetClient.GetCcdHostedDNGroupRes getCcdHostedDNGroup(AxlNetClient.GetCcdHostedDNGroupReq getCcdHostedDNGroup1)
        {
            return axlPortClient54.getCcdHostedDNGroup(getCcdHostedDNGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNGroupResponse> getCcdHostedDNGroupAsync(AxlNetClient.GetCcdHostedDNGroupReq getCcdHostedDNGroup)
        {
            return axlPortClient54.getCcdHostedDNGroupAsync(getCcdHostedDNGroup);
        }

        public AxlNetClient.StandardResponse removeCcdHostedDNGroup(AxlNetClient.NameAndGUIDRequest removeCcdHostedDNGroup1)
        {
            return axlPortClient54.removeCcdHostedDNGroup(removeCcdHostedDNGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNGroupResponse> removeCcdHostedDNGroupAsync(AxlNetClient.NameAndGUIDRequest removeCcdHostedDNGroup)
        {
            return axlPortClient54.removeCcdHostedDNGroupAsync(removeCcdHostedDNGroup);
        }

        public AxlNetClient.ListCcdHostedDNGroupRes listCcdHostedDNGroup(AxlNetClient.ListCcdHostedDNGroupReq listCcdHostedDNGroup1)
        {
            return axlPortClient54.listCcdHostedDNGroup(listCcdHostedDNGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNGroupResponse> listCcdHostedDNGroupAsync(AxlNetClient.ListCcdHostedDNGroupReq listCcdHostedDNGroup)
        {
            return axlPortClient54.listCcdHostedDNGroupAsync(listCcdHostedDNGroup);
        }

        public AxlNetClient.StandardResponse addCcdRequestingService(AxlNetClient.AddCcdRequestingServiceReq addCcdRequestingService1)
        {
            return axlPortClient54.addCcdRequestingService(addCcdRequestingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdRequestingServiceResponse> addCcdRequestingServiceAsync(AxlNetClient.AddCcdRequestingServiceReq addCcdRequestingService)
        {
            return axlPortClient54.addCcdRequestingServiceAsync(addCcdRequestingService);
        }

        public AxlNetClient.StandardResponse updateCcdRequestingService(AxlNetClient.UpdateCcdRequestingServiceReq updateCcdRequestingService1)
        {
            return axlPortClient54.updateCcdRequestingService(updateCcdRequestingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdRequestingServiceResponse> updateCcdRequestingServiceAsync(AxlNetClient.UpdateCcdRequestingServiceReq updateCcdRequestingService)
        {
            return axlPortClient54.updateCcdRequestingServiceAsync(updateCcdRequestingService);
        }

        public AxlNetClient.GetCcdRequestingServiceRes getCcdRequestingService(AxlNetClient.GetCcdRequestingServiceReq getCcdRequestingService1)
        {
            return axlPortClient54.getCcdRequestingService(getCcdRequestingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdRequestingServiceResponse> getCcdRequestingServiceAsync(AxlNetClient.GetCcdRequestingServiceReq getCcdRequestingService)
        {
            return axlPortClient54.getCcdRequestingServiceAsync(getCcdRequestingService);
        }

        public AxlNetClient.StandardResponse removeCcdRequestingService(AxlNetClient.NameAndGUIDRequest removeCcdRequestingService1)
        {
            return axlPortClient54.removeCcdRequestingService(removeCcdRequestingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdRequestingServiceResponse> removeCcdRequestingServiceAsync(AxlNetClient.NameAndGUIDRequest removeCcdRequestingService)
        {
            return axlPortClient54.removeCcdRequestingServiceAsync(removeCcdRequestingService);
        }

        public AxlNetClient.StandardResponse updateInterClusterServiceProfile(AxlNetClient.UpdateInterClusterServiceProfileReq updateInterClusterServiceProfile1)
        {
            return axlPortClient54.updateInterClusterServiceProfile(updateInterClusterServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateInterClusterServiceProfileResponse> updateInterClusterServiceProfileAsync(AxlNetClient.UpdateInterClusterServiceProfileReq updateInterClusterServiceProfile)
        {
            return axlPortClient54.updateInterClusterServiceProfileAsync(updateInterClusterServiceProfile);
        }

        public AxlNetClient.GetInterClusterServiceProfileRes getInterClusterServiceProfile(AxlNetClient.GetInterClusterServiceProfileReq getInterClusterServiceProfile1)
        {
            return axlPortClient54.getInterClusterServiceProfile(getInterClusterServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getInterClusterServiceProfileResponse> getInterClusterServiceProfileAsync(AxlNetClient.GetInterClusterServiceProfileReq getInterClusterServiceProfile)
        {
            return axlPortClient54.getInterClusterServiceProfileAsync(getInterClusterServiceProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort54
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdHostedDN", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCcdHostedDNResponse listCcdHostedDN(AxlNetClient.listCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdHostedDN", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNResponse> listCcdHostedDNAsync(AxlNetClient.listCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdHostedDNGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCcdHostedDNGroupResponse addCcdHostedDNGroup(AxlNetClient.addCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdHostedDNGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNGroupResponse> addCcdHostedDNGroupAsync(AxlNetClient.addCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdHostedDNGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCcdHostedDNGroupResponse updateCcdHostedDNGroup(AxlNetClient.updateCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdHostedDNGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNGroupResponse> updateCcdHostedDNGroupAsync(AxlNetClient.updateCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdHostedDNGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCcdHostedDNGroupResponse getCcdHostedDNGroup(AxlNetClient.getCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdHostedDNGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNGroupResponse> getCcdHostedDNGroupAsync(AxlNetClient.getCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdHostedDNGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCcdHostedDNGroupResponse removeCcdHostedDNGroup(AxlNetClient.removeCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdHostedDNGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNGroupResponse> removeCcdHostedDNGroupAsync(AxlNetClient.removeCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdHostedDNGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCcdHostedDNGroupResponse listCcdHostedDNGroup(AxlNetClient.listCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdHostedDNGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNGroupResponse> listCcdHostedDNGroupAsync(AxlNetClient.listCcdHostedDNGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdRequestingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCcdRequestingServiceResponse addCcdRequestingService(AxlNetClient.addCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdRequestingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCcdRequestingServiceResponse> addCcdRequestingServiceAsync(AxlNetClient.addCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdRequestingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCcdRequestingServiceResponse updateCcdRequestingService(AxlNetClient.updateCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdRequestingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdRequestingServiceResponse> updateCcdRequestingServiceAsync(AxlNetClient.updateCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdRequestingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCcdRequestingServiceResponse getCcdRequestingService(AxlNetClient.getCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdRequestingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCcdRequestingServiceResponse> getCcdRequestingServiceAsync(AxlNetClient.getCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdRequestingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCcdRequestingServiceResponse removeCcdRequestingService(AxlNetClient.removeCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdRequestingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdRequestingServiceResponse> removeCcdRequestingServiceAsync(AxlNetClient.removeCcdRequestingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateInterClusterServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateInterClusterServiceProfileResponse updateInterClusterServiceProfile(AxlNetClient.updateInterClusterServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateInterClusterServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateInterClusterServiceProfileResponse> updateInterClusterServiceProfileAsync(AxlNetClient.updateInterClusterServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getInterClusterServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getInterClusterServiceProfileResponse getInterClusterServiceProfile(AxlNetClient.getInterClusterServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getInterClusterServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getInterClusterServiceProfileResponse> getInterClusterServiceProfileAsync(AxlNetClient.getInterClusterServiceProfileRequest request);
    }

    public class AXLPortClient54 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort54>, AxlNetClient.AXLPort54
    {
        public AXLPortClient54(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCcdHostedDNResponse AxlNetClient.AXLPort54.listCcdHostedDN(AxlNetClient.listCcdHostedDNRequest request)
        {
            return base.Channel.listCcdHostedDN(request);
        }

        public AxlNetClient.ListCcdHostedDNRes listCcdHostedDN(AxlNetClient.ListCcdHostedDNReq listCcdHostedDN1)
        {
            AxlNetClient.listCcdHostedDNRequest inValue = new AxlNetClient.listCcdHostedDNRequest();
            inValue.listCcdHostedDN = listCcdHostedDN1;
            AxlNetClient.listCcdHostedDNResponse retVal = ((AxlNetClient.AXLPort54)(this)).listCcdHostedDN(inValue);
            return retVal.listCcdHostedDNResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNResponse> AxlNetClient.AXLPort54.listCcdHostedDNAsync(AxlNetClient.listCcdHostedDNRequest request)
        {
            return base.Channel.listCcdHostedDNAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNResponse> listCcdHostedDNAsync(AxlNetClient.ListCcdHostedDNReq listCcdHostedDN)
        {
            AxlNetClient.listCcdHostedDNRequest inValue = new AxlNetClient.listCcdHostedDNRequest();
            inValue.listCcdHostedDN = listCcdHostedDN;
            return ((AxlNetClient.AXLPort54)(this)).listCcdHostedDNAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCcdHostedDNGroupResponse AxlNetClient.AXLPort54.addCcdHostedDNGroup(AxlNetClient.addCcdHostedDNGroupRequest request)
        {
            return base.Channel.addCcdHostedDNGroup(request);
        }

        public AxlNetClient.StandardResponse addCcdHostedDNGroup(AxlNetClient.AddCcdHostedDNGroupReq addCcdHostedDNGroup1)
        {
            AxlNetClient.addCcdHostedDNGroupRequest inValue = new AxlNetClient.addCcdHostedDNGroupRequest();
            inValue.addCcdHostedDNGroup = addCcdHostedDNGroup1;
            AxlNetClient.addCcdHostedDNGroupResponse retVal = ((AxlNetClient.AXLPort54)(this)).addCcdHostedDNGroup(inValue);
            return retVal.addCcdHostedDNGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNGroupResponse> AxlNetClient.AXLPort54.addCcdHostedDNGroupAsync(AxlNetClient.addCcdHostedDNGroupRequest request)
        {
            return base.Channel.addCcdHostedDNGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNGroupResponse> addCcdHostedDNGroupAsync(AxlNetClient.AddCcdHostedDNGroupReq addCcdHostedDNGroup)
        {
            AxlNetClient.addCcdHostedDNGroupRequest inValue = new AxlNetClient.addCcdHostedDNGroupRequest();
            inValue.addCcdHostedDNGroup = addCcdHostedDNGroup;
            return ((AxlNetClient.AXLPort54)(this)).addCcdHostedDNGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCcdHostedDNGroupResponse AxlNetClient.AXLPort54.updateCcdHostedDNGroup(AxlNetClient.updateCcdHostedDNGroupRequest request)
        {
            return base.Channel.updateCcdHostedDNGroup(request);
        }

        public AxlNetClient.StandardResponse updateCcdHostedDNGroup(AxlNetClient.UpdateCcdHostedDNGroupReq updateCcdHostedDNGroup1)
        {
            AxlNetClient.updateCcdHostedDNGroupRequest inValue = new AxlNetClient.updateCcdHostedDNGroupRequest();
            inValue.updateCcdHostedDNGroup = updateCcdHostedDNGroup1;
            AxlNetClient.updateCcdHostedDNGroupResponse retVal = ((AxlNetClient.AXLPort54)(this)).updateCcdHostedDNGroup(inValue);
            return retVal.updateCcdHostedDNGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNGroupResponse> AxlNetClient.AXLPort54.updateCcdHostedDNGroupAsync(AxlNetClient.updateCcdHostedDNGroupRequest request)
        {
            return base.Channel.updateCcdHostedDNGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNGroupResponse> updateCcdHostedDNGroupAsync(AxlNetClient.UpdateCcdHostedDNGroupReq updateCcdHostedDNGroup)
        {
            AxlNetClient.updateCcdHostedDNGroupRequest inValue = new AxlNetClient.updateCcdHostedDNGroupRequest();
            inValue.updateCcdHostedDNGroup = updateCcdHostedDNGroup;
            return ((AxlNetClient.AXLPort54)(this)).updateCcdHostedDNGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCcdHostedDNGroupResponse AxlNetClient.AXLPort54.getCcdHostedDNGroup(AxlNetClient.getCcdHostedDNGroupRequest request)
        {
            return base.Channel.getCcdHostedDNGroup(request);
        }

        public AxlNetClient.GetCcdHostedDNGroupRes getCcdHostedDNGroup(AxlNetClient.GetCcdHostedDNGroupReq getCcdHostedDNGroup1)
        {
            AxlNetClient.getCcdHostedDNGroupRequest inValue = new AxlNetClient.getCcdHostedDNGroupRequest();
            inValue.getCcdHostedDNGroup = getCcdHostedDNGroup1;
            AxlNetClient.getCcdHostedDNGroupResponse retVal = ((AxlNetClient.AXLPort54)(this)).getCcdHostedDNGroup(inValue);
            return retVal.getCcdHostedDNGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNGroupResponse> AxlNetClient.AXLPort54.getCcdHostedDNGroupAsync(AxlNetClient.getCcdHostedDNGroupRequest request)
        {
            return base.Channel.getCcdHostedDNGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNGroupResponse> getCcdHostedDNGroupAsync(AxlNetClient.GetCcdHostedDNGroupReq getCcdHostedDNGroup)
        {
            AxlNetClient.getCcdHostedDNGroupRequest inValue = new AxlNetClient.getCcdHostedDNGroupRequest();
            inValue.getCcdHostedDNGroup = getCcdHostedDNGroup;
            return ((AxlNetClient.AXLPort54)(this)).getCcdHostedDNGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCcdHostedDNGroupResponse AxlNetClient.AXLPort54.removeCcdHostedDNGroup(AxlNetClient.removeCcdHostedDNGroupRequest request)
        {
            return base.Channel.removeCcdHostedDNGroup(request);
        }

        public AxlNetClient.StandardResponse removeCcdHostedDNGroup(AxlNetClient.NameAndGUIDRequest removeCcdHostedDNGroup1)
        {
            AxlNetClient.removeCcdHostedDNGroupRequest inValue = new AxlNetClient.removeCcdHostedDNGroupRequest();
            inValue.removeCcdHostedDNGroup = removeCcdHostedDNGroup1;
            AxlNetClient.removeCcdHostedDNGroupResponse retVal = ((AxlNetClient.AXLPort54)(this)).removeCcdHostedDNGroup(inValue);
            return retVal.removeCcdHostedDNGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNGroupResponse> AxlNetClient.AXLPort54.removeCcdHostedDNGroupAsync(AxlNetClient.removeCcdHostedDNGroupRequest request)
        {
            return base.Channel.removeCcdHostedDNGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNGroupResponse> removeCcdHostedDNGroupAsync(AxlNetClient.NameAndGUIDRequest removeCcdHostedDNGroup)
        {
            AxlNetClient.removeCcdHostedDNGroupRequest inValue = new AxlNetClient.removeCcdHostedDNGroupRequest();
            inValue.removeCcdHostedDNGroup = removeCcdHostedDNGroup;
            return ((AxlNetClient.AXLPort54)(this)).removeCcdHostedDNGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCcdHostedDNGroupResponse AxlNetClient.AXLPort54.listCcdHostedDNGroup(AxlNetClient.listCcdHostedDNGroupRequest request)
        {
            return base.Channel.listCcdHostedDNGroup(request);
        }

        public AxlNetClient.ListCcdHostedDNGroupRes listCcdHostedDNGroup(AxlNetClient.ListCcdHostedDNGroupReq listCcdHostedDNGroup1)
        {
            AxlNetClient.listCcdHostedDNGroupRequest inValue = new AxlNetClient.listCcdHostedDNGroupRequest();
            inValue.listCcdHostedDNGroup = listCcdHostedDNGroup1;
            AxlNetClient.listCcdHostedDNGroupResponse retVal = ((AxlNetClient.AXLPort54)(this)).listCcdHostedDNGroup(inValue);
            return retVal.listCcdHostedDNGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNGroupResponse> AxlNetClient.AXLPort54.listCcdHostedDNGroupAsync(AxlNetClient.listCcdHostedDNGroupRequest request)
        {
            return base.Channel.listCcdHostedDNGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdHostedDNGroupResponse> listCcdHostedDNGroupAsync(AxlNetClient.ListCcdHostedDNGroupReq listCcdHostedDNGroup)
        {
            AxlNetClient.listCcdHostedDNGroupRequest inValue = new AxlNetClient.listCcdHostedDNGroupRequest();
            inValue.listCcdHostedDNGroup = listCcdHostedDNGroup;
            return ((AxlNetClient.AXLPort54)(this)).listCcdHostedDNGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCcdRequestingServiceResponse AxlNetClient.AXLPort54.addCcdRequestingService(AxlNetClient.addCcdRequestingServiceRequest request)
        {
            return base.Channel.addCcdRequestingService(request);
        }

        public AxlNetClient.StandardResponse addCcdRequestingService(AxlNetClient.AddCcdRequestingServiceReq addCcdRequestingService1)
        {
            AxlNetClient.addCcdRequestingServiceRequest inValue = new AxlNetClient.addCcdRequestingServiceRequest();
            inValue.addCcdRequestingService = addCcdRequestingService1;
            AxlNetClient.addCcdRequestingServiceResponse retVal = ((AxlNetClient.AXLPort54)(this)).addCcdRequestingService(inValue);
            return retVal.addCcdRequestingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCcdRequestingServiceResponse> AxlNetClient.AXLPort54.addCcdRequestingServiceAsync(AxlNetClient.addCcdRequestingServiceRequest request)
        {
            return base.Channel.addCcdRequestingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdRequestingServiceResponse> addCcdRequestingServiceAsync(AxlNetClient.AddCcdRequestingServiceReq addCcdRequestingService)
        {
            AxlNetClient.addCcdRequestingServiceRequest inValue = new AxlNetClient.addCcdRequestingServiceRequest();
            inValue.addCcdRequestingService = addCcdRequestingService;
            return ((AxlNetClient.AXLPort54)(this)).addCcdRequestingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCcdRequestingServiceResponse AxlNetClient.AXLPort54.updateCcdRequestingService(AxlNetClient.updateCcdRequestingServiceRequest request)
        {
            return base.Channel.updateCcdRequestingService(request);
        }

        public AxlNetClient.StandardResponse updateCcdRequestingService(AxlNetClient.UpdateCcdRequestingServiceReq updateCcdRequestingService1)
        {
            AxlNetClient.updateCcdRequestingServiceRequest inValue = new AxlNetClient.updateCcdRequestingServiceRequest();
            inValue.updateCcdRequestingService = updateCcdRequestingService1;
            AxlNetClient.updateCcdRequestingServiceResponse retVal = ((AxlNetClient.AXLPort54)(this)).updateCcdRequestingService(inValue);
            return retVal.updateCcdRequestingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdRequestingServiceResponse> AxlNetClient.AXLPort54.updateCcdRequestingServiceAsync(AxlNetClient.updateCcdRequestingServiceRequest request)
        {
            return base.Channel.updateCcdRequestingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdRequestingServiceResponse> updateCcdRequestingServiceAsync(AxlNetClient.UpdateCcdRequestingServiceReq updateCcdRequestingService)
        {
            AxlNetClient.updateCcdRequestingServiceRequest inValue = new AxlNetClient.updateCcdRequestingServiceRequest();
            inValue.updateCcdRequestingService = updateCcdRequestingService;
            return ((AxlNetClient.AXLPort54)(this)).updateCcdRequestingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCcdRequestingServiceResponse AxlNetClient.AXLPort54.getCcdRequestingService(AxlNetClient.getCcdRequestingServiceRequest request)
        {
            return base.Channel.getCcdRequestingService(request);
        }

        public AxlNetClient.GetCcdRequestingServiceRes getCcdRequestingService(AxlNetClient.GetCcdRequestingServiceReq getCcdRequestingService1)
        {
            AxlNetClient.getCcdRequestingServiceRequest inValue = new AxlNetClient.getCcdRequestingServiceRequest();
            inValue.getCcdRequestingService = getCcdRequestingService1;
            AxlNetClient.getCcdRequestingServiceResponse retVal = ((AxlNetClient.AXLPort54)(this)).getCcdRequestingService(inValue);
            return retVal.getCcdRequestingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCcdRequestingServiceResponse> AxlNetClient.AXLPort54.getCcdRequestingServiceAsync(AxlNetClient.getCcdRequestingServiceRequest request)
        {
            return base.Channel.getCcdRequestingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdRequestingServiceResponse> getCcdRequestingServiceAsync(AxlNetClient.GetCcdRequestingServiceReq getCcdRequestingService)
        {
            AxlNetClient.getCcdRequestingServiceRequest inValue = new AxlNetClient.getCcdRequestingServiceRequest();
            inValue.getCcdRequestingService = getCcdRequestingService;
            return ((AxlNetClient.AXLPort54)(this)).getCcdRequestingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCcdRequestingServiceResponse AxlNetClient.AXLPort54.removeCcdRequestingService(AxlNetClient.removeCcdRequestingServiceRequest request)
        {
            return base.Channel.removeCcdRequestingService(request);
        }

        public AxlNetClient.StandardResponse removeCcdRequestingService(AxlNetClient.NameAndGUIDRequest removeCcdRequestingService1)
        {
            AxlNetClient.removeCcdRequestingServiceRequest inValue = new AxlNetClient.removeCcdRequestingServiceRequest();
            inValue.removeCcdRequestingService = removeCcdRequestingService1;
            AxlNetClient.removeCcdRequestingServiceResponse retVal = ((AxlNetClient.AXLPort54)(this)).removeCcdRequestingService(inValue);
            return retVal.removeCcdRequestingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdRequestingServiceResponse> AxlNetClient.AXLPort54.removeCcdRequestingServiceAsync(AxlNetClient.removeCcdRequestingServiceRequest request)
        {
            return base.Channel.removeCcdRequestingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdRequestingServiceResponse> removeCcdRequestingServiceAsync(AxlNetClient.NameAndGUIDRequest removeCcdRequestingService)
        {
            AxlNetClient.removeCcdRequestingServiceRequest inValue = new AxlNetClient.removeCcdRequestingServiceRequest();
            inValue.removeCcdRequestingService = removeCcdRequestingService;
            return ((AxlNetClient.AXLPort54)(this)).removeCcdRequestingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateInterClusterServiceProfileResponse AxlNetClient.AXLPort54.updateInterClusterServiceProfile(AxlNetClient.updateInterClusterServiceProfileRequest request)
        {
            return base.Channel.updateInterClusterServiceProfile(request);
        }

        public AxlNetClient.StandardResponse updateInterClusterServiceProfile(AxlNetClient.UpdateInterClusterServiceProfileReq updateInterClusterServiceProfile1)
        {
            AxlNetClient.updateInterClusterServiceProfileRequest inValue = new AxlNetClient.updateInterClusterServiceProfileRequest();
            inValue.updateInterClusterServiceProfile = updateInterClusterServiceProfile1;
            AxlNetClient.updateInterClusterServiceProfileResponse retVal = ((AxlNetClient.AXLPort54)(this)).updateInterClusterServiceProfile(inValue);
            return retVal.updateInterClusterServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateInterClusterServiceProfileResponse> AxlNetClient.AXLPort54.updateInterClusterServiceProfileAsync(AxlNetClient.updateInterClusterServiceProfileRequest request)
        {
            return base.Channel.updateInterClusterServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateInterClusterServiceProfileResponse> updateInterClusterServiceProfileAsync(AxlNetClient.UpdateInterClusterServiceProfileReq updateInterClusterServiceProfile)
        {
            AxlNetClient.updateInterClusterServiceProfileRequest inValue = new AxlNetClient.updateInterClusterServiceProfileRequest();
            inValue.updateInterClusterServiceProfile = updateInterClusterServiceProfile;
            return ((AxlNetClient.AXLPort54)(this)).updateInterClusterServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getInterClusterServiceProfileResponse AxlNetClient.AXLPort54.getInterClusterServiceProfile(AxlNetClient.getInterClusterServiceProfileRequest request)
        {
            return base.Channel.getInterClusterServiceProfile(request);
        }

        public AxlNetClient.GetInterClusterServiceProfileRes getInterClusterServiceProfile(AxlNetClient.GetInterClusterServiceProfileReq getInterClusterServiceProfile1)
        {
            AxlNetClient.getInterClusterServiceProfileRequest inValue = new AxlNetClient.getInterClusterServiceProfileRequest();
            inValue.getInterClusterServiceProfile = getInterClusterServiceProfile1;
            AxlNetClient.getInterClusterServiceProfileResponse retVal = ((AxlNetClient.AXLPort54)(this)).getInterClusterServiceProfile(inValue);
            return retVal.getInterClusterServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getInterClusterServiceProfileResponse> AxlNetClient.AXLPort54.getInterClusterServiceProfileAsync(AxlNetClient.getInterClusterServiceProfileRequest request)
        {
            return base.Channel.getInterClusterServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getInterClusterServiceProfileResponse> getInterClusterServiceProfileAsync(AxlNetClient.GetInterClusterServiceProfileReq getInterClusterServiceProfile)
        {
            AxlNetClient.getInterClusterServiceProfileRequest inValue = new AxlNetClient.getInterClusterServiceProfileRequest();
            inValue.getInterClusterServiceProfile = getInterClusterServiceProfile;
            return ((AxlNetClient.AXLPort54)(this)).getInterClusterServiceProfileAsync(inValue);
        }
    }
}