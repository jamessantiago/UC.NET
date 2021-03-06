namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient27 _axlPortClient27;

        private static AXLPortClient27 axlPortClient27 => _axlPortClient27 == null ||
            _axlPortClient27.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient27 = LoadClient27()) : _axlPortClient27;

        private static AXLPortClient27 LoadClient27()
        {
            var client = new AXLPortClient27(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close27;
            OnAbort += Abort27;
            return client;
        }

        private static void Close27(object sender, System.EventArgs e)
        {
            _axlPortClient27.Close();
        }

        private static void Abort27(object sender, System.EventArgs e)
        {
            _axlPortClient27.Abort();
        }

        public AxlNetClient.StandardResponse addCumaServerSecurityProfile(AxlNetClient.AddCumaServerSecurityProfileReq addCumaServerSecurityProfile1)
        {
            return axlPortClient27.addCumaServerSecurityProfile(addCumaServerSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCumaServerSecurityProfileResponse> addCumaServerSecurityProfileAsync(AxlNetClient.AddCumaServerSecurityProfileReq addCumaServerSecurityProfile)
        {
            return axlPortClient27.addCumaServerSecurityProfileAsync(addCumaServerSecurityProfile);
        }

        public AxlNetClient.StandardResponse updateCumaServerSecurityProfile(AxlNetClient.UpdateCumaServerSecurityProfileReq updateCumaServerSecurityProfile1)
        {
            return axlPortClient27.updateCumaServerSecurityProfile(updateCumaServerSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCumaServerSecurityProfileResponse> updateCumaServerSecurityProfileAsync(AxlNetClient.UpdateCumaServerSecurityProfileReq updateCumaServerSecurityProfile)
        {
            return axlPortClient27.updateCumaServerSecurityProfileAsync(updateCumaServerSecurityProfile);
        }

        public AxlNetClient.GetCumaServerSecurityProfileRes getCumaServerSecurityProfile(AxlNetClient.GetCumaServerSecurityProfileReq getCumaServerSecurityProfile1)
        {
            return axlPortClient27.getCumaServerSecurityProfile(getCumaServerSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCumaServerSecurityProfileResponse> getCumaServerSecurityProfileAsync(AxlNetClient.GetCumaServerSecurityProfileReq getCumaServerSecurityProfile)
        {
            return axlPortClient27.getCumaServerSecurityProfileAsync(getCumaServerSecurityProfile);
        }

        public AxlNetClient.StandardResponse removeCumaServerSecurityProfile(AxlNetClient.NameAndGUIDRequest removeCumaServerSecurityProfile1)
        {
            return axlPortClient27.removeCumaServerSecurityProfile(removeCumaServerSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCumaServerSecurityProfileResponse> removeCumaServerSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeCumaServerSecurityProfile)
        {
            return axlPortClient27.removeCumaServerSecurityProfileAsync(removeCumaServerSecurityProfile);
        }

        public AxlNetClient.ListCumaServerSecurityProfileRes listCumaServerSecurityProfile(AxlNetClient.ListCumaServerSecurityProfileReq listCumaServerSecurityProfile1)
        {
            return axlPortClient27.listCumaServerSecurityProfile(listCumaServerSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCumaServerSecurityProfileResponse> listCumaServerSecurityProfileAsync(AxlNetClient.ListCumaServerSecurityProfileReq listCumaServerSecurityProfile)
        {
            return axlPortClient27.listCumaServerSecurityProfileAsync(listCumaServerSecurityProfile);
        }

        public AxlNetClient.StandardResponse addApplicationServer(AxlNetClient.AddApplicationServerReq addApplicationServer1)
        {
            return axlPortClient27.addApplicationServer(addApplicationServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationServerResponse> addApplicationServerAsync(AxlNetClient.AddApplicationServerReq addApplicationServer)
        {
            return axlPortClient27.addApplicationServerAsync(addApplicationServer);
        }

        public AxlNetClient.StandardResponse updateApplicationServer(AxlNetClient.UpdateApplicationServerReq updateApplicationServer1)
        {
            return axlPortClient27.updateApplicationServer(updateApplicationServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationServerResponse> updateApplicationServerAsync(AxlNetClient.UpdateApplicationServerReq updateApplicationServer)
        {
            return axlPortClient27.updateApplicationServerAsync(updateApplicationServer);
        }

        public AxlNetClient.GetApplicationServerRes getApplicationServer(AxlNetClient.GetApplicationServerReq getApplicationServer1)
        {
            return axlPortClient27.getApplicationServer(getApplicationServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationServerResponse> getApplicationServerAsync(AxlNetClient.GetApplicationServerReq getApplicationServer)
        {
            return axlPortClient27.getApplicationServerAsync(getApplicationServer);
        }

        public AxlNetClient.StandardResponse removeApplicationServer(AxlNetClient.RemoveApplicationServerReq removeApplicationServer1)
        {
            return axlPortClient27.removeApplicationServer(removeApplicationServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationServerResponse> removeApplicationServerAsync(AxlNetClient.RemoveApplicationServerReq removeApplicationServer)
        {
            return axlPortClient27.removeApplicationServerAsync(removeApplicationServer);
        }

        public AxlNetClient.ListApplicationServerRes listApplicationServer(AxlNetClient.ListApplicationServerReq listApplicationServer1)
        {
            return axlPortClient27.listApplicationServer(listApplicationServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationServerResponse> listApplicationServerAsync(AxlNetClient.ListApplicationServerReq listApplicationServer)
        {
            return axlPortClient27.listApplicationServerAsync(listApplicationServer);
        }

        public AxlNetClient.StandardResponse addApplicationUserCapfProfile(AxlNetClient.AddApplicationUserCapfProfileReq addApplicationUserCapfProfile1)
        {
            return axlPortClient27.addApplicationUserCapfProfile(addApplicationUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationUserCapfProfileResponse> addApplicationUserCapfProfileAsync(AxlNetClient.AddApplicationUserCapfProfileReq addApplicationUserCapfProfile)
        {
            return axlPortClient27.addApplicationUserCapfProfileAsync(addApplicationUserCapfProfile);
        }

        public AxlNetClient.StandardResponse updateApplicationUserCapfProfile(AxlNetClient.UpdateApplicationUserCapfProfileReq updateApplicationUserCapfProfile1)
        {
            return axlPortClient27.updateApplicationUserCapfProfile(updateApplicationUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationUserCapfProfileResponse> updateApplicationUserCapfProfileAsync(AxlNetClient.UpdateApplicationUserCapfProfileReq updateApplicationUserCapfProfile)
        {
            return axlPortClient27.updateApplicationUserCapfProfileAsync(updateApplicationUserCapfProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort27
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCumaServerSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCumaServerSecurityProfileResponse addCumaServerSecurityProfile(AxlNetClient.addCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCumaServerSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCumaServerSecurityProfileResponse> addCumaServerSecurityProfileAsync(AxlNetClient.addCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCumaServerSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCumaServerSecurityProfileResponse updateCumaServerSecurityProfile(AxlNetClient.updateCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCumaServerSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCumaServerSecurityProfileResponse> updateCumaServerSecurityProfileAsync(AxlNetClient.updateCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCumaServerSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCumaServerSecurityProfileResponse getCumaServerSecurityProfile(AxlNetClient.getCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCumaServerSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCumaServerSecurityProfileResponse> getCumaServerSecurityProfileAsync(AxlNetClient.getCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCumaServerSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCumaServerSecurityProfileResponse removeCumaServerSecurityProfile(AxlNetClient.removeCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCumaServerSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCumaServerSecurityProfileResponse> removeCumaServerSecurityProfileAsync(AxlNetClient.removeCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCumaServerSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCumaServerSecurityProfileResponse listCumaServerSecurityProfile(AxlNetClient.listCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCumaServerSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCumaServerSecurityProfileResponse> listCumaServerSecurityProfileAsync(AxlNetClient.listCumaServerSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addApplicationServerResponse addApplicationServer(AxlNetClient.addApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationServerResponse> addApplicationServerAsync(AxlNetClient.addApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateApplicationServerResponse updateApplicationServer(AxlNetClient.updateApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationServerResponse> updateApplicationServerAsync(AxlNetClient.updateApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getApplicationServerResponse getApplicationServer(AxlNetClient.getApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationServerResponse> getApplicationServerAsync(AxlNetClient.getApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeApplicationServerResponse removeApplicationServer(AxlNetClient.removeApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationServerResponse> removeApplicationServerAsync(AxlNetClient.removeApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listApplicationServerResponse listApplicationServer(AxlNetClient.listApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationServerResponse> listApplicationServerAsync(AxlNetClient.listApplicationServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addApplicationUserCapfProfileResponse addApplicationUserCapfProfile(AxlNetClient.addApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationUserCapfProfileResponse> addApplicationUserCapfProfileAsync(AxlNetClient.addApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateApplicationUserCapfProfileResponse updateApplicationUserCapfProfile(AxlNetClient.updateApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationUserCapfProfileResponse> updateApplicationUserCapfProfileAsync(AxlNetClient.updateApplicationUserCapfProfileRequest request);
    }

    public class AXLPortClient27 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort27>, AxlNetClient.AXLPort27
    {
        public AXLPortClient27(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCumaServerSecurityProfileResponse AxlNetClient.AXLPort27.addCumaServerSecurityProfile(AxlNetClient.addCumaServerSecurityProfileRequest request)
        {
            return base.Channel.addCumaServerSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse addCumaServerSecurityProfile(AxlNetClient.AddCumaServerSecurityProfileReq addCumaServerSecurityProfile1)
        {
            AxlNetClient.addCumaServerSecurityProfileRequest inValue = new AxlNetClient.addCumaServerSecurityProfileRequest();
            inValue.addCumaServerSecurityProfile = addCumaServerSecurityProfile1;
            AxlNetClient.addCumaServerSecurityProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).addCumaServerSecurityProfile(inValue);
            return retVal.addCumaServerSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCumaServerSecurityProfileResponse> AxlNetClient.AXLPort27.addCumaServerSecurityProfileAsync(AxlNetClient.addCumaServerSecurityProfileRequest request)
        {
            return base.Channel.addCumaServerSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCumaServerSecurityProfileResponse> addCumaServerSecurityProfileAsync(AxlNetClient.AddCumaServerSecurityProfileReq addCumaServerSecurityProfile)
        {
            AxlNetClient.addCumaServerSecurityProfileRequest inValue = new AxlNetClient.addCumaServerSecurityProfileRequest();
            inValue.addCumaServerSecurityProfile = addCumaServerSecurityProfile;
            return ((AxlNetClient.AXLPort27)(this)).addCumaServerSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCumaServerSecurityProfileResponse AxlNetClient.AXLPort27.updateCumaServerSecurityProfile(AxlNetClient.updateCumaServerSecurityProfileRequest request)
        {
            return base.Channel.updateCumaServerSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse updateCumaServerSecurityProfile(AxlNetClient.UpdateCumaServerSecurityProfileReq updateCumaServerSecurityProfile1)
        {
            AxlNetClient.updateCumaServerSecurityProfileRequest inValue = new AxlNetClient.updateCumaServerSecurityProfileRequest();
            inValue.updateCumaServerSecurityProfile = updateCumaServerSecurityProfile1;
            AxlNetClient.updateCumaServerSecurityProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).updateCumaServerSecurityProfile(inValue);
            return retVal.updateCumaServerSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCumaServerSecurityProfileResponse> AxlNetClient.AXLPort27.updateCumaServerSecurityProfileAsync(AxlNetClient.updateCumaServerSecurityProfileRequest request)
        {
            return base.Channel.updateCumaServerSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCumaServerSecurityProfileResponse> updateCumaServerSecurityProfileAsync(AxlNetClient.UpdateCumaServerSecurityProfileReq updateCumaServerSecurityProfile)
        {
            AxlNetClient.updateCumaServerSecurityProfileRequest inValue = new AxlNetClient.updateCumaServerSecurityProfileRequest();
            inValue.updateCumaServerSecurityProfile = updateCumaServerSecurityProfile;
            return ((AxlNetClient.AXLPort27)(this)).updateCumaServerSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCumaServerSecurityProfileResponse AxlNetClient.AXLPort27.getCumaServerSecurityProfile(AxlNetClient.getCumaServerSecurityProfileRequest request)
        {
            return base.Channel.getCumaServerSecurityProfile(request);
        }

        public AxlNetClient.GetCumaServerSecurityProfileRes getCumaServerSecurityProfile(AxlNetClient.GetCumaServerSecurityProfileReq getCumaServerSecurityProfile1)
        {
            AxlNetClient.getCumaServerSecurityProfileRequest inValue = new AxlNetClient.getCumaServerSecurityProfileRequest();
            inValue.getCumaServerSecurityProfile = getCumaServerSecurityProfile1;
            AxlNetClient.getCumaServerSecurityProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).getCumaServerSecurityProfile(inValue);
            return retVal.getCumaServerSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCumaServerSecurityProfileResponse> AxlNetClient.AXLPort27.getCumaServerSecurityProfileAsync(AxlNetClient.getCumaServerSecurityProfileRequest request)
        {
            return base.Channel.getCumaServerSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCumaServerSecurityProfileResponse> getCumaServerSecurityProfileAsync(AxlNetClient.GetCumaServerSecurityProfileReq getCumaServerSecurityProfile)
        {
            AxlNetClient.getCumaServerSecurityProfileRequest inValue = new AxlNetClient.getCumaServerSecurityProfileRequest();
            inValue.getCumaServerSecurityProfile = getCumaServerSecurityProfile;
            return ((AxlNetClient.AXLPort27)(this)).getCumaServerSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCumaServerSecurityProfileResponse AxlNetClient.AXLPort27.removeCumaServerSecurityProfile(AxlNetClient.removeCumaServerSecurityProfileRequest request)
        {
            return base.Channel.removeCumaServerSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse removeCumaServerSecurityProfile(AxlNetClient.NameAndGUIDRequest removeCumaServerSecurityProfile1)
        {
            AxlNetClient.removeCumaServerSecurityProfileRequest inValue = new AxlNetClient.removeCumaServerSecurityProfileRequest();
            inValue.removeCumaServerSecurityProfile = removeCumaServerSecurityProfile1;
            AxlNetClient.removeCumaServerSecurityProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).removeCumaServerSecurityProfile(inValue);
            return retVal.removeCumaServerSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCumaServerSecurityProfileResponse> AxlNetClient.AXLPort27.removeCumaServerSecurityProfileAsync(AxlNetClient.removeCumaServerSecurityProfileRequest request)
        {
            return base.Channel.removeCumaServerSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCumaServerSecurityProfileResponse> removeCumaServerSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeCumaServerSecurityProfile)
        {
            AxlNetClient.removeCumaServerSecurityProfileRequest inValue = new AxlNetClient.removeCumaServerSecurityProfileRequest();
            inValue.removeCumaServerSecurityProfile = removeCumaServerSecurityProfile;
            return ((AxlNetClient.AXLPort27)(this)).removeCumaServerSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCumaServerSecurityProfileResponse AxlNetClient.AXLPort27.listCumaServerSecurityProfile(AxlNetClient.listCumaServerSecurityProfileRequest request)
        {
            return base.Channel.listCumaServerSecurityProfile(request);
        }

        public AxlNetClient.ListCumaServerSecurityProfileRes listCumaServerSecurityProfile(AxlNetClient.ListCumaServerSecurityProfileReq listCumaServerSecurityProfile1)
        {
            AxlNetClient.listCumaServerSecurityProfileRequest inValue = new AxlNetClient.listCumaServerSecurityProfileRequest();
            inValue.listCumaServerSecurityProfile = listCumaServerSecurityProfile1;
            AxlNetClient.listCumaServerSecurityProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).listCumaServerSecurityProfile(inValue);
            return retVal.listCumaServerSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCumaServerSecurityProfileResponse> AxlNetClient.AXLPort27.listCumaServerSecurityProfileAsync(AxlNetClient.listCumaServerSecurityProfileRequest request)
        {
            return base.Channel.listCumaServerSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCumaServerSecurityProfileResponse> listCumaServerSecurityProfileAsync(AxlNetClient.ListCumaServerSecurityProfileReq listCumaServerSecurityProfile)
        {
            AxlNetClient.listCumaServerSecurityProfileRequest inValue = new AxlNetClient.listCumaServerSecurityProfileRequest();
            inValue.listCumaServerSecurityProfile = listCumaServerSecurityProfile;
            return ((AxlNetClient.AXLPort27)(this)).listCumaServerSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addApplicationServerResponse AxlNetClient.AXLPort27.addApplicationServer(AxlNetClient.addApplicationServerRequest request)
        {
            return base.Channel.addApplicationServer(request);
        }

        public AxlNetClient.StandardResponse addApplicationServer(AxlNetClient.AddApplicationServerReq addApplicationServer1)
        {
            AxlNetClient.addApplicationServerRequest inValue = new AxlNetClient.addApplicationServerRequest();
            inValue.addApplicationServer = addApplicationServer1;
            AxlNetClient.addApplicationServerResponse retVal = ((AxlNetClient.AXLPort27)(this)).addApplicationServer(inValue);
            return retVal.addApplicationServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationServerResponse> AxlNetClient.AXLPort27.addApplicationServerAsync(AxlNetClient.addApplicationServerRequest request)
        {
            return base.Channel.addApplicationServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationServerResponse> addApplicationServerAsync(AxlNetClient.AddApplicationServerReq addApplicationServer)
        {
            AxlNetClient.addApplicationServerRequest inValue = new AxlNetClient.addApplicationServerRequest();
            inValue.addApplicationServer = addApplicationServer;
            return ((AxlNetClient.AXLPort27)(this)).addApplicationServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateApplicationServerResponse AxlNetClient.AXLPort27.updateApplicationServer(AxlNetClient.updateApplicationServerRequest request)
        {
            return base.Channel.updateApplicationServer(request);
        }

        public AxlNetClient.StandardResponse updateApplicationServer(AxlNetClient.UpdateApplicationServerReq updateApplicationServer1)
        {
            AxlNetClient.updateApplicationServerRequest inValue = new AxlNetClient.updateApplicationServerRequest();
            inValue.updateApplicationServer = updateApplicationServer1;
            AxlNetClient.updateApplicationServerResponse retVal = ((AxlNetClient.AXLPort27)(this)).updateApplicationServer(inValue);
            return retVal.updateApplicationServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationServerResponse> AxlNetClient.AXLPort27.updateApplicationServerAsync(AxlNetClient.updateApplicationServerRequest request)
        {
            return base.Channel.updateApplicationServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationServerResponse> updateApplicationServerAsync(AxlNetClient.UpdateApplicationServerReq updateApplicationServer)
        {
            AxlNetClient.updateApplicationServerRequest inValue = new AxlNetClient.updateApplicationServerRequest();
            inValue.updateApplicationServer = updateApplicationServer;
            return ((AxlNetClient.AXLPort27)(this)).updateApplicationServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getApplicationServerResponse AxlNetClient.AXLPort27.getApplicationServer(AxlNetClient.getApplicationServerRequest request)
        {
            return base.Channel.getApplicationServer(request);
        }

        public AxlNetClient.GetApplicationServerRes getApplicationServer(AxlNetClient.GetApplicationServerReq getApplicationServer1)
        {
            AxlNetClient.getApplicationServerRequest inValue = new AxlNetClient.getApplicationServerRequest();
            inValue.getApplicationServer = getApplicationServer1;
            AxlNetClient.getApplicationServerResponse retVal = ((AxlNetClient.AXLPort27)(this)).getApplicationServer(inValue);
            return retVal.getApplicationServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationServerResponse> AxlNetClient.AXLPort27.getApplicationServerAsync(AxlNetClient.getApplicationServerRequest request)
        {
            return base.Channel.getApplicationServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationServerResponse> getApplicationServerAsync(AxlNetClient.GetApplicationServerReq getApplicationServer)
        {
            AxlNetClient.getApplicationServerRequest inValue = new AxlNetClient.getApplicationServerRequest();
            inValue.getApplicationServer = getApplicationServer;
            return ((AxlNetClient.AXLPort27)(this)).getApplicationServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeApplicationServerResponse AxlNetClient.AXLPort27.removeApplicationServer(AxlNetClient.removeApplicationServerRequest request)
        {
            return base.Channel.removeApplicationServer(request);
        }

        public AxlNetClient.StandardResponse removeApplicationServer(AxlNetClient.RemoveApplicationServerReq removeApplicationServer1)
        {
            AxlNetClient.removeApplicationServerRequest inValue = new AxlNetClient.removeApplicationServerRequest();
            inValue.removeApplicationServer = removeApplicationServer1;
            AxlNetClient.removeApplicationServerResponse retVal = ((AxlNetClient.AXLPort27)(this)).removeApplicationServer(inValue);
            return retVal.removeApplicationServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationServerResponse> AxlNetClient.AXLPort27.removeApplicationServerAsync(AxlNetClient.removeApplicationServerRequest request)
        {
            return base.Channel.removeApplicationServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationServerResponse> removeApplicationServerAsync(AxlNetClient.RemoveApplicationServerReq removeApplicationServer)
        {
            AxlNetClient.removeApplicationServerRequest inValue = new AxlNetClient.removeApplicationServerRequest();
            inValue.removeApplicationServer = removeApplicationServer;
            return ((AxlNetClient.AXLPort27)(this)).removeApplicationServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listApplicationServerResponse AxlNetClient.AXLPort27.listApplicationServer(AxlNetClient.listApplicationServerRequest request)
        {
            return base.Channel.listApplicationServer(request);
        }

        public AxlNetClient.ListApplicationServerRes listApplicationServer(AxlNetClient.ListApplicationServerReq listApplicationServer1)
        {
            AxlNetClient.listApplicationServerRequest inValue = new AxlNetClient.listApplicationServerRequest();
            inValue.listApplicationServer = listApplicationServer1;
            AxlNetClient.listApplicationServerResponse retVal = ((AxlNetClient.AXLPort27)(this)).listApplicationServer(inValue);
            return retVal.listApplicationServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationServerResponse> AxlNetClient.AXLPort27.listApplicationServerAsync(AxlNetClient.listApplicationServerRequest request)
        {
            return base.Channel.listApplicationServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationServerResponse> listApplicationServerAsync(AxlNetClient.ListApplicationServerReq listApplicationServer)
        {
            AxlNetClient.listApplicationServerRequest inValue = new AxlNetClient.listApplicationServerRequest();
            inValue.listApplicationServer = listApplicationServer;
            return ((AxlNetClient.AXLPort27)(this)).listApplicationServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addApplicationUserCapfProfileResponse AxlNetClient.AXLPort27.addApplicationUserCapfProfile(AxlNetClient.addApplicationUserCapfProfileRequest request)
        {
            return base.Channel.addApplicationUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse addApplicationUserCapfProfile(AxlNetClient.AddApplicationUserCapfProfileReq addApplicationUserCapfProfile1)
        {
            AxlNetClient.addApplicationUserCapfProfileRequest inValue = new AxlNetClient.addApplicationUserCapfProfileRequest();
            inValue.addApplicationUserCapfProfile = addApplicationUserCapfProfile1;
            AxlNetClient.addApplicationUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).addApplicationUserCapfProfile(inValue);
            return retVal.addApplicationUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationUserCapfProfileResponse> AxlNetClient.AXLPort27.addApplicationUserCapfProfileAsync(AxlNetClient.addApplicationUserCapfProfileRequest request)
        {
            return base.Channel.addApplicationUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationUserCapfProfileResponse> addApplicationUserCapfProfileAsync(AxlNetClient.AddApplicationUserCapfProfileReq addApplicationUserCapfProfile)
        {
            AxlNetClient.addApplicationUserCapfProfileRequest inValue = new AxlNetClient.addApplicationUserCapfProfileRequest();
            inValue.addApplicationUserCapfProfile = addApplicationUserCapfProfile;
            return ((AxlNetClient.AXLPort27)(this)).addApplicationUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateApplicationUserCapfProfileResponse AxlNetClient.AXLPort27.updateApplicationUserCapfProfile(AxlNetClient.updateApplicationUserCapfProfileRequest request)
        {
            return base.Channel.updateApplicationUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse updateApplicationUserCapfProfile(AxlNetClient.UpdateApplicationUserCapfProfileReq updateApplicationUserCapfProfile1)
        {
            AxlNetClient.updateApplicationUserCapfProfileRequest inValue = new AxlNetClient.updateApplicationUserCapfProfileRequest();
            inValue.updateApplicationUserCapfProfile = updateApplicationUserCapfProfile1;
            AxlNetClient.updateApplicationUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort27)(this)).updateApplicationUserCapfProfile(inValue);
            return retVal.updateApplicationUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationUserCapfProfileResponse> AxlNetClient.AXLPort27.updateApplicationUserCapfProfileAsync(AxlNetClient.updateApplicationUserCapfProfileRequest request)
        {
            return base.Channel.updateApplicationUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationUserCapfProfileResponse> updateApplicationUserCapfProfileAsync(AxlNetClient.UpdateApplicationUserCapfProfileReq updateApplicationUserCapfProfile)
        {
            AxlNetClient.updateApplicationUserCapfProfileRequest inValue = new AxlNetClient.updateApplicationUserCapfProfileRequest();
            inValue.updateApplicationUserCapfProfile = updateApplicationUserCapfProfile;
            return ((AxlNetClient.AXLPort27)(this)).updateApplicationUserCapfProfileAsync(inValue);
        }
    }
}