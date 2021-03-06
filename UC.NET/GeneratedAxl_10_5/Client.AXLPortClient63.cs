namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient63 _axlPortClient63;

        private static AXLPortClient63 axlPortClient63 => _axlPortClient63 == null ||
            _axlPortClient63.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient63 = LoadClient63()) : _axlPortClient63;

        private static AXLPortClient63 LoadClient63()
        {
            var client = new AXLPortClient63(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close63;
            OnAbort += Abort63;
            return client;
        }

        private static void Close63(object sender, System.EventArgs e)
        {
            _axlPortClient63.Close();
        }

        private static void Abort63(object sender, System.EventArgs e)
        {
            _axlPortClient63.Abort();
        }

        public AxlNetClient.GetFallbackProfileRes getFallbackProfile(AxlNetClient.GetFallbackProfileReq getFallbackProfile1)
        {
            return axlPortClient63.getFallbackProfile(getFallbackProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFallbackProfileResponse> getFallbackProfileAsync(AxlNetClient.GetFallbackProfileReq getFallbackProfile)
        {
            return axlPortClient63.getFallbackProfileAsync(getFallbackProfile);
        }

        public AxlNetClient.StandardResponse removeFallbackProfile(AxlNetClient.NameAndGUIDRequest removeFallbackProfile1)
        {
            return axlPortClient63.removeFallbackProfile(removeFallbackProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFallbackProfileResponse> removeFallbackProfileAsync(AxlNetClient.NameAndGUIDRequest removeFallbackProfile)
        {
            return axlPortClient63.removeFallbackProfileAsync(removeFallbackProfile);
        }

        public AxlNetClient.ListFallbackProfileRes listFallbackProfile(AxlNetClient.ListFallbackProfileReq listFallbackProfile1)
        {
            return axlPortClient63.listFallbackProfile(listFallbackProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFallbackProfileResponse> listFallbackProfileAsync(AxlNetClient.ListFallbackProfileReq listFallbackProfile)
        {
            return axlPortClient63.listFallbackProfileAsync(listFallbackProfile);
        }

        public AxlNetClient.StandardResponse addLdapFilter(AxlNetClient.AddLdapFilterReq addLdapFilter1)
        {
            return axlPortClient63.addLdapFilter(addLdapFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapFilterResponse> addLdapFilterAsync(AxlNetClient.AddLdapFilterReq addLdapFilter)
        {
            return axlPortClient63.addLdapFilterAsync(addLdapFilter);
        }

        public AxlNetClient.StandardResponse updateLdapFilter(AxlNetClient.UpdateLdapFilterReq updateLdapFilter1)
        {
            return axlPortClient63.updateLdapFilter(updateLdapFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapFilterResponse> updateLdapFilterAsync(AxlNetClient.UpdateLdapFilterReq updateLdapFilter)
        {
            return axlPortClient63.updateLdapFilterAsync(updateLdapFilter);
        }

        public AxlNetClient.GetLdapFilterRes getLdapFilter(AxlNetClient.GetLdapFilterReq getLdapFilter1)
        {
            return axlPortClient63.getLdapFilter(getLdapFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapFilterResponse> getLdapFilterAsync(AxlNetClient.GetLdapFilterReq getLdapFilter)
        {
            return axlPortClient63.getLdapFilterAsync(getLdapFilter);
        }

        public AxlNetClient.StandardResponse removeLdapFilter(AxlNetClient.NameAndGUIDRequest removeLdapFilter1)
        {
            return axlPortClient63.removeLdapFilter(removeLdapFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapFilterResponse> removeLdapFilterAsync(AxlNetClient.NameAndGUIDRequest removeLdapFilter)
        {
            return axlPortClient63.removeLdapFilterAsync(removeLdapFilter);
        }

        public AxlNetClient.ListLdapFilterRes listLdapFilter(AxlNetClient.ListLdapFilterReq listLdapFilter1)
        {
            return axlPortClient63.listLdapFilter(listLdapFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapFilterResponse> listLdapFilterAsync(AxlNetClient.ListLdapFilterReq listLdapFilter)
        {
            return axlPortClient63.listLdapFilterAsync(listLdapFilter);
        }

        public AxlNetClient.StandardResponse addAppServerInfo(AxlNetClient.AddAppServerInfoReq addAppServerInfo1)
        {
            return axlPortClient63.addAppServerInfo(addAppServerInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAppServerInfoResponse> addAppServerInfoAsync(AxlNetClient.AddAppServerInfoReq addAppServerInfo)
        {
            return axlPortClient63.addAppServerInfoAsync(addAppServerInfo);
        }

        public AxlNetClient.StandardResponse updateAppServerInfo(AxlNetClient.UpdateAppServerInfoReq updateAppServerInfo1)
        {
            return axlPortClient63.updateAppServerInfo(updateAppServerInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAppServerInfoResponse> updateAppServerInfoAsync(AxlNetClient.UpdateAppServerInfoReq updateAppServerInfo)
        {
            return axlPortClient63.updateAppServerInfoAsync(updateAppServerInfo);
        }

        public AxlNetClient.StandardResponse updateTvsCertificate(AxlNetClient.UpdateTvsCertificateReq updateTvsCertificate1)
        {
            return axlPortClient63.updateTvsCertificate(updateTvsCertificate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTvsCertificateResponse> updateTvsCertificateAsync(AxlNetClient.UpdateTvsCertificateReq updateTvsCertificate)
        {
            return axlPortClient63.updateTvsCertificateAsync(updateTvsCertificate);
        }

        public AxlNetClient.GetTvsCertificateRes getTvsCertificate(AxlNetClient.GetTvsCertificateReq getTvsCertificate1)
        {
            return axlPortClient63.getTvsCertificate(getTvsCertificate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTvsCertificateResponse> getTvsCertificateAsync(AxlNetClient.GetTvsCertificateReq getTvsCertificate)
        {
            return axlPortClient63.getTvsCertificateAsync(getTvsCertificate);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort63
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFallbackProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFallbackProfileResponse getFallbackProfile(AxlNetClient.getFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFallbackProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFallbackProfileResponse> getFallbackProfileAsync(AxlNetClient.getFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFallbackProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeFallbackProfileResponse removeFallbackProfile(AxlNetClient.removeFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFallbackProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeFallbackProfileResponse> removeFallbackProfileAsync(AxlNetClient.removeFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFallbackProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listFallbackProfileResponse listFallbackProfile(AxlNetClient.listFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFallbackProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listFallbackProfileResponse> listFallbackProfileAsync(AxlNetClient.listFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLdapFilterResponse addLdapFilter(AxlNetClient.addLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLdapFilterResponse> addLdapFilterAsync(AxlNetClient.addLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLdapFilterResponse updateLdapFilter(AxlNetClient.updateLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapFilterResponse> updateLdapFilterAsync(AxlNetClient.updateLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapFilterResponse getLdapFilter(AxlNetClient.getLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapFilterResponse> getLdapFilterAsync(AxlNetClient.getLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLdapFilterResponse removeLdapFilter(AxlNetClient.removeLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapFilterResponse> removeLdapFilterAsync(AxlNetClient.removeLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLdapFilterResponse listLdapFilter(AxlNetClient.listLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLdapFilterResponse> listLdapFilterAsync(AxlNetClient.listLdapFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAppServerInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAppServerInfoResponse addAppServerInfo(AxlNetClient.addAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAppServerInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAppServerInfoResponse> addAppServerInfoAsync(AxlNetClient.addAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAppServerInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAppServerInfoResponse updateAppServerInfo(AxlNetClient.updateAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAppServerInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAppServerInfoResponse> updateAppServerInfoAsync(AxlNetClient.updateAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTvsCertificate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTvsCertificateResponse updateTvsCertificate(AxlNetClient.updateTvsCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTvsCertificate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTvsCertificateResponse> updateTvsCertificateAsync(AxlNetClient.updateTvsCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTvsCertificate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTvsCertificateResponse getTvsCertificate(AxlNetClient.getTvsCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTvsCertificate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTvsCertificateResponse> getTvsCertificateAsync(AxlNetClient.getTvsCertificateRequest request);
    }

    public class AXLPortClient63 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort63>, AxlNetClient.AXLPort63
    {
        public AXLPortClient63(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFallbackProfileResponse AxlNetClient.AXLPort63.getFallbackProfile(AxlNetClient.getFallbackProfileRequest request)
        {
            return base.Channel.getFallbackProfile(request);
        }

        public AxlNetClient.GetFallbackProfileRes getFallbackProfile(AxlNetClient.GetFallbackProfileReq getFallbackProfile1)
        {
            AxlNetClient.getFallbackProfileRequest inValue = new AxlNetClient.getFallbackProfileRequest();
            inValue.getFallbackProfile = getFallbackProfile1;
            AxlNetClient.getFallbackProfileResponse retVal = ((AxlNetClient.AXLPort63)(this)).getFallbackProfile(inValue);
            return retVal.getFallbackProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFallbackProfileResponse> AxlNetClient.AXLPort63.getFallbackProfileAsync(AxlNetClient.getFallbackProfileRequest request)
        {
            return base.Channel.getFallbackProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFallbackProfileResponse> getFallbackProfileAsync(AxlNetClient.GetFallbackProfileReq getFallbackProfile)
        {
            AxlNetClient.getFallbackProfileRequest inValue = new AxlNetClient.getFallbackProfileRequest();
            inValue.getFallbackProfile = getFallbackProfile;
            return ((AxlNetClient.AXLPort63)(this)).getFallbackProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeFallbackProfileResponse AxlNetClient.AXLPort63.removeFallbackProfile(AxlNetClient.removeFallbackProfileRequest request)
        {
            return base.Channel.removeFallbackProfile(request);
        }

        public AxlNetClient.StandardResponse removeFallbackProfile(AxlNetClient.NameAndGUIDRequest removeFallbackProfile1)
        {
            AxlNetClient.removeFallbackProfileRequest inValue = new AxlNetClient.removeFallbackProfileRequest();
            inValue.removeFallbackProfile = removeFallbackProfile1;
            AxlNetClient.removeFallbackProfileResponse retVal = ((AxlNetClient.AXLPort63)(this)).removeFallbackProfile(inValue);
            return retVal.removeFallbackProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeFallbackProfileResponse> AxlNetClient.AXLPort63.removeFallbackProfileAsync(AxlNetClient.removeFallbackProfileRequest request)
        {
            return base.Channel.removeFallbackProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFallbackProfileResponse> removeFallbackProfileAsync(AxlNetClient.NameAndGUIDRequest removeFallbackProfile)
        {
            AxlNetClient.removeFallbackProfileRequest inValue = new AxlNetClient.removeFallbackProfileRequest();
            inValue.removeFallbackProfile = removeFallbackProfile;
            return ((AxlNetClient.AXLPort63)(this)).removeFallbackProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listFallbackProfileResponse AxlNetClient.AXLPort63.listFallbackProfile(AxlNetClient.listFallbackProfileRequest request)
        {
            return base.Channel.listFallbackProfile(request);
        }

        public AxlNetClient.ListFallbackProfileRes listFallbackProfile(AxlNetClient.ListFallbackProfileReq listFallbackProfile1)
        {
            AxlNetClient.listFallbackProfileRequest inValue = new AxlNetClient.listFallbackProfileRequest();
            inValue.listFallbackProfile = listFallbackProfile1;
            AxlNetClient.listFallbackProfileResponse retVal = ((AxlNetClient.AXLPort63)(this)).listFallbackProfile(inValue);
            return retVal.listFallbackProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listFallbackProfileResponse> AxlNetClient.AXLPort63.listFallbackProfileAsync(AxlNetClient.listFallbackProfileRequest request)
        {
            return base.Channel.listFallbackProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFallbackProfileResponse> listFallbackProfileAsync(AxlNetClient.ListFallbackProfileReq listFallbackProfile)
        {
            AxlNetClient.listFallbackProfileRequest inValue = new AxlNetClient.listFallbackProfileRequest();
            inValue.listFallbackProfile = listFallbackProfile;
            return ((AxlNetClient.AXLPort63)(this)).listFallbackProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLdapFilterResponse AxlNetClient.AXLPort63.addLdapFilter(AxlNetClient.addLdapFilterRequest request)
        {
            return base.Channel.addLdapFilter(request);
        }

        public AxlNetClient.StandardResponse addLdapFilter(AxlNetClient.AddLdapFilterReq addLdapFilter1)
        {
            AxlNetClient.addLdapFilterRequest inValue = new AxlNetClient.addLdapFilterRequest();
            inValue.addLdapFilter = addLdapFilter1;
            AxlNetClient.addLdapFilterResponse retVal = ((AxlNetClient.AXLPort63)(this)).addLdapFilter(inValue);
            return retVal.addLdapFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLdapFilterResponse> AxlNetClient.AXLPort63.addLdapFilterAsync(AxlNetClient.addLdapFilterRequest request)
        {
            return base.Channel.addLdapFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapFilterResponse> addLdapFilterAsync(AxlNetClient.AddLdapFilterReq addLdapFilter)
        {
            AxlNetClient.addLdapFilterRequest inValue = new AxlNetClient.addLdapFilterRequest();
            inValue.addLdapFilter = addLdapFilter;
            return ((AxlNetClient.AXLPort63)(this)).addLdapFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLdapFilterResponse AxlNetClient.AXLPort63.updateLdapFilter(AxlNetClient.updateLdapFilterRequest request)
        {
            return base.Channel.updateLdapFilter(request);
        }

        public AxlNetClient.StandardResponse updateLdapFilter(AxlNetClient.UpdateLdapFilterReq updateLdapFilter1)
        {
            AxlNetClient.updateLdapFilterRequest inValue = new AxlNetClient.updateLdapFilterRequest();
            inValue.updateLdapFilter = updateLdapFilter1;
            AxlNetClient.updateLdapFilterResponse retVal = ((AxlNetClient.AXLPort63)(this)).updateLdapFilter(inValue);
            return retVal.updateLdapFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapFilterResponse> AxlNetClient.AXLPort63.updateLdapFilterAsync(AxlNetClient.updateLdapFilterRequest request)
        {
            return base.Channel.updateLdapFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapFilterResponse> updateLdapFilterAsync(AxlNetClient.UpdateLdapFilterReq updateLdapFilter)
        {
            AxlNetClient.updateLdapFilterRequest inValue = new AxlNetClient.updateLdapFilterRequest();
            inValue.updateLdapFilter = updateLdapFilter;
            return ((AxlNetClient.AXLPort63)(this)).updateLdapFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapFilterResponse AxlNetClient.AXLPort63.getLdapFilter(AxlNetClient.getLdapFilterRequest request)
        {
            return base.Channel.getLdapFilter(request);
        }

        public AxlNetClient.GetLdapFilterRes getLdapFilter(AxlNetClient.GetLdapFilterReq getLdapFilter1)
        {
            AxlNetClient.getLdapFilterRequest inValue = new AxlNetClient.getLdapFilterRequest();
            inValue.getLdapFilter = getLdapFilter1;
            AxlNetClient.getLdapFilterResponse retVal = ((AxlNetClient.AXLPort63)(this)).getLdapFilter(inValue);
            return retVal.getLdapFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapFilterResponse> AxlNetClient.AXLPort63.getLdapFilterAsync(AxlNetClient.getLdapFilterRequest request)
        {
            return base.Channel.getLdapFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapFilterResponse> getLdapFilterAsync(AxlNetClient.GetLdapFilterReq getLdapFilter)
        {
            AxlNetClient.getLdapFilterRequest inValue = new AxlNetClient.getLdapFilterRequest();
            inValue.getLdapFilter = getLdapFilter;
            return ((AxlNetClient.AXLPort63)(this)).getLdapFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLdapFilterResponse AxlNetClient.AXLPort63.removeLdapFilter(AxlNetClient.removeLdapFilterRequest request)
        {
            return base.Channel.removeLdapFilter(request);
        }

        public AxlNetClient.StandardResponse removeLdapFilter(AxlNetClient.NameAndGUIDRequest removeLdapFilter1)
        {
            AxlNetClient.removeLdapFilterRequest inValue = new AxlNetClient.removeLdapFilterRequest();
            inValue.removeLdapFilter = removeLdapFilter1;
            AxlNetClient.removeLdapFilterResponse retVal = ((AxlNetClient.AXLPort63)(this)).removeLdapFilter(inValue);
            return retVal.removeLdapFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapFilterResponse> AxlNetClient.AXLPort63.removeLdapFilterAsync(AxlNetClient.removeLdapFilterRequest request)
        {
            return base.Channel.removeLdapFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapFilterResponse> removeLdapFilterAsync(AxlNetClient.NameAndGUIDRequest removeLdapFilter)
        {
            AxlNetClient.removeLdapFilterRequest inValue = new AxlNetClient.removeLdapFilterRequest();
            inValue.removeLdapFilter = removeLdapFilter;
            return ((AxlNetClient.AXLPort63)(this)).removeLdapFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLdapFilterResponse AxlNetClient.AXLPort63.listLdapFilter(AxlNetClient.listLdapFilterRequest request)
        {
            return base.Channel.listLdapFilter(request);
        }

        public AxlNetClient.ListLdapFilterRes listLdapFilter(AxlNetClient.ListLdapFilterReq listLdapFilter1)
        {
            AxlNetClient.listLdapFilterRequest inValue = new AxlNetClient.listLdapFilterRequest();
            inValue.listLdapFilter = listLdapFilter1;
            AxlNetClient.listLdapFilterResponse retVal = ((AxlNetClient.AXLPort63)(this)).listLdapFilter(inValue);
            return retVal.listLdapFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLdapFilterResponse> AxlNetClient.AXLPort63.listLdapFilterAsync(AxlNetClient.listLdapFilterRequest request)
        {
            return base.Channel.listLdapFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapFilterResponse> listLdapFilterAsync(AxlNetClient.ListLdapFilterReq listLdapFilter)
        {
            AxlNetClient.listLdapFilterRequest inValue = new AxlNetClient.listLdapFilterRequest();
            inValue.listLdapFilter = listLdapFilter;
            return ((AxlNetClient.AXLPort63)(this)).listLdapFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAppServerInfoResponse AxlNetClient.AXLPort63.addAppServerInfo(AxlNetClient.addAppServerInfoRequest request)
        {
            return base.Channel.addAppServerInfo(request);
        }

        public AxlNetClient.StandardResponse addAppServerInfo(AxlNetClient.AddAppServerInfoReq addAppServerInfo1)
        {
            AxlNetClient.addAppServerInfoRequest inValue = new AxlNetClient.addAppServerInfoRequest();
            inValue.addAppServerInfo = addAppServerInfo1;
            AxlNetClient.addAppServerInfoResponse retVal = ((AxlNetClient.AXLPort63)(this)).addAppServerInfo(inValue);
            return retVal.addAppServerInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAppServerInfoResponse> AxlNetClient.AXLPort63.addAppServerInfoAsync(AxlNetClient.addAppServerInfoRequest request)
        {
            return base.Channel.addAppServerInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAppServerInfoResponse> addAppServerInfoAsync(AxlNetClient.AddAppServerInfoReq addAppServerInfo)
        {
            AxlNetClient.addAppServerInfoRequest inValue = new AxlNetClient.addAppServerInfoRequest();
            inValue.addAppServerInfo = addAppServerInfo;
            return ((AxlNetClient.AXLPort63)(this)).addAppServerInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAppServerInfoResponse AxlNetClient.AXLPort63.updateAppServerInfo(AxlNetClient.updateAppServerInfoRequest request)
        {
            return base.Channel.updateAppServerInfo(request);
        }

        public AxlNetClient.StandardResponse updateAppServerInfo(AxlNetClient.UpdateAppServerInfoReq updateAppServerInfo1)
        {
            AxlNetClient.updateAppServerInfoRequest inValue = new AxlNetClient.updateAppServerInfoRequest();
            inValue.updateAppServerInfo = updateAppServerInfo1;
            AxlNetClient.updateAppServerInfoResponse retVal = ((AxlNetClient.AXLPort63)(this)).updateAppServerInfo(inValue);
            return retVal.updateAppServerInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAppServerInfoResponse> AxlNetClient.AXLPort63.updateAppServerInfoAsync(AxlNetClient.updateAppServerInfoRequest request)
        {
            return base.Channel.updateAppServerInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAppServerInfoResponse> updateAppServerInfoAsync(AxlNetClient.UpdateAppServerInfoReq updateAppServerInfo)
        {
            AxlNetClient.updateAppServerInfoRequest inValue = new AxlNetClient.updateAppServerInfoRequest();
            inValue.updateAppServerInfo = updateAppServerInfo;
            return ((AxlNetClient.AXLPort63)(this)).updateAppServerInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTvsCertificateResponse AxlNetClient.AXLPort63.updateTvsCertificate(AxlNetClient.updateTvsCertificateRequest request)
        {
            return base.Channel.updateTvsCertificate(request);
        }

        public AxlNetClient.StandardResponse updateTvsCertificate(AxlNetClient.UpdateTvsCertificateReq updateTvsCertificate1)
        {
            AxlNetClient.updateTvsCertificateRequest inValue = new AxlNetClient.updateTvsCertificateRequest();
            inValue.updateTvsCertificate = updateTvsCertificate1;
            AxlNetClient.updateTvsCertificateResponse retVal = ((AxlNetClient.AXLPort63)(this)).updateTvsCertificate(inValue);
            return retVal.updateTvsCertificateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTvsCertificateResponse> AxlNetClient.AXLPort63.updateTvsCertificateAsync(AxlNetClient.updateTvsCertificateRequest request)
        {
            return base.Channel.updateTvsCertificateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTvsCertificateResponse> updateTvsCertificateAsync(AxlNetClient.UpdateTvsCertificateReq updateTvsCertificate)
        {
            AxlNetClient.updateTvsCertificateRequest inValue = new AxlNetClient.updateTvsCertificateRequest();
            inValue.updateTvsCertificate = updateTvsCertificate;
            return ((AxlNetClient.AXLPort63)(this)).updateTvsCertificateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTvsCertificateResponse AxlNetClient.AXLPort63.getTvsCertificate(AxlNetClient.getTvsCertificateRequest request)
        {
            return base.Channel.getTvsCertificate(request);
        }

        public AxlNetClient.GetTvsCertificateRes getTvsCertificate(AxlNetClient.GetTvsCertificateReq getTvsCertificate1)
        {
            AxlNetClient.getTvsCertificateRequest inValue = new AxlNetClient.getTvsCertificateRequest();
            inValue.getTvsCertificate = getTvsCertificate1;
            AxlNetClient.getTvsCertificateResponse retVal = ((AxlNetClient.AXLPort63)(this)).getTvsCertificate(inValue);
            return retVal.getTvsCertificateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTvsCertificateResponse> AxlNetClient.AXLPort63.getTvsCertificateAsync(AxlNetClient.getTvsCertificateRequest request)
        {
            return base.Channel.getTvsCertificateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTvsCertificateResponse> getTvsCertificateAsync(AxlNetClient.GetTvsCertificateReq getTvsCertificate)
        {
            AxlNetClient.getTvsCertificateRequest inValue = new AxlNetClient.getTvsCertificateRequest();
            inValue.getTvsCertificate = getTvsCertificate;
            return ((AxlNetClient.AXLPort63)(this)).getTvsCertificateAsync(inValue);
        }
    }
}