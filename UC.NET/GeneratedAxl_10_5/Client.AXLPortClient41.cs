namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient41 _axlPortClient41;

        private static AXLPortClient41 axlPortClient41 => _axlPortClient41 == null ||
            _axlPortClient41.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient41 = LoadClient41()) : _axlPortClient41;

        private static AXLPortClient41 LoadClient41()
        {
            var client = new AXLPortClient41(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close41;
            OnAbort += Abort41;
            return client;
        }

        private static void Close41(object sender, System.EventArgs e)
        {
            _axlPortClient41.Close();
        }

        private static void Abort41(object sender, System.EventArgs e)
        {
            _axlPortClient41.Abort();
        }

        public AxlNetClient.GetLineOptionsRes getLineOptions(AxlNetClient.GetLineOptionsReq getLineOptions1)
        {
            return axlPortClient41.getLineOptions(getLineOptions1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineOptionsResponse> getLineOptionsAsync(AxlNetClient.GetLineOptionsReq getLineOptions)
        {
            return axlPortClient41.getLineOptionsAsync(getLineOptions);
        }

        public AxlNetClient.StandardResponse addDefaultDeviceProfile(AxlNetClient.AddDefaultDeviceProfileReq addDefaultDeviceProfile1)
        {
            return axlPortClient41.addDefaultDeviceProfile(addDefaultDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDefaultDeviceProfileResponse> addDefaultDeviceProfileAsync(AxlNetClient.AddDefaultDeviceProfileReq addDefaultDeviceProfile)
        {
            return axlPortClient41.addDefaultDeviceProfileAsync(addDefaultDeviceProfile);
        }

        public AxlNetClient.StandardResponse updateDefaultDeviceProfile(AxlNetClient.UpdateDefaultDeviceProfileReq updateDefaultDeviceProfile1)
        {
            return axlPortClient41.updateDefaultDeviceProfile(updateDefaultDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDefaultDeviceProfileResponse> updateDefaultDeviceProfileAsync(AxlNetClient.UpdateDefaultDeviceProfileReq updateDefaultDeviceProfile)
        {
            return axlPortClient41.updateDefaultDeviceProfileAsync(updateDefaultDeviceProfile);
        }

        public AxlNetClient.GetDefaultDeviceProfileRes getDefaultDeviceProfile(AxlNetClient.GetDefaultDeviceProfileReq getDefaultDeviceProfile1)
        {
            return axlPortClient41.getDefaultDeviceProfile(getDefaultDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDefaultDeviceProfileResponse> getDefaultDeviceProfileAsync(AxlNetClient.GetDefaultDeviceProfileReq getDefaultDeviceProfile)
        {
            return axlPortClient41.getDefaultDeviceProfileAsync(getDefaultDeviceProfile);
        }

        public AxlNetClient.StandardResponse removeDefaultDeviceProfile(AxlNetClient.NameAndGUIDRequest removeDefaultDeviceProfile1)
        {
            return axlPortClient41.removeDefaultDeviceProfile(removeDefaultDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDefaultDeviceProfileResponse> removeDefaultDeviceProfileAsync(AxlNetClient.NameAndGUIDRequest removeDefaultDeviceProfile)
        {
            return axlPortClient41.removeDefaultDeviceProfileAsync(removeDefaultDeviceProfile);
        }

        public AxlNetClient.ListDefaultDeviceProfileRes listDefaultDeviceProfile(AxlNetClient.ListDefaultDeviceProfileReq listDefaultDeviceProfile1)
        {
            return axlPortClient41.listDefaultDeviceProfile(listDefaultDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDefaultDeviceProfileResponse> listDefaultDeviceProfileAsync(AxlNetClient.ListDefaultDeviceProfileReq listDefaultDeviceProfile)
        {
            return axlPortClient41.listDefaultDeviceProfileAsync(listDefaultDeviceProfile);
        }

        public AxlNetClient.StandardResponse addH323Phone(AxlNetClient.AddH323PhoneReq addH323Phone1)
        {
            return axlPortClient41.addH323Phone(addH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323PhoneResponse> addH323PhoneAsync(AxlNetClient.AddH323PhoneReq addH323Phone)
        {
            return axlPortClient41.addH323PhoneAsync(addH323Phone);
        }

        public AxlNetClient.StandardResponse updateH323Phone(AxlNetClient.UpdateH323PhoneReq updateH323Phone1)
        {
            return axlPortClient41.updateH323Phone(updateH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323PhoneResponse> updateH323PhoneAsync(AxlNetClient.UpdateH323PhoneReq updateH323Phone)
        {
            return axlPortClient41.updateH323PhoneAsync(updateH323Phone);
        }

        public AxlNetClient.GetH323PhoneRes getH323Phone(AxlNetClient.GetH323PhoneReq getH323Phone1)
        {
            return axlPortClient41.getH323Phone(getH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323PhoneResponse> getH323PhoneAsync(AxlNetClient.GetH323PhoneReq getH323Phone)
        {
            return axlPortClient41.getH323PhoneAsync(getH323Phone);
        }

        public AxlNetClient.StandardResponse removeH323Phone(AxlNetClient.NameAndGUIDRequest removeH323Phone1)
        {
            return axlPortClient41.removeH323Phone(removeH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323PhoneResponse> removeH323PhoneAsync(AxlNetClient.NameAndGUIDRequest removeH323Phone)
        {
            return axlPortClient41.removeH323PhoneAsync(removeH323Phone);
        }

        public AxlNetClient.ListH323PhoneRes listH323Phone(AxlNetClient.ListH323PhoneReq listH323Phone1)
        {
            return axlPortClient41.listH323Phone(listH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323PhoneResponse> listH323PhoneAsync(AxlNetClient.ListH323PhoneReq listH323Phone)
        {
            return axlPortClient41.listH323PhoneAsync(listH323Phone);
        }

        public AxlNetClient.StandardResponse resetH323Phone(AxlNetClient.NameAndGUIDRequest resetH323Phone1)
        {
            return axlPortClient41.resetH323Phone(resetH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323PhoneResponse> resetH323PhoneAsync(AxlNetClient.NameAndGUIDRequest resetH323Phone)
        {
            return axlPortClient41.resetH323PhoneAsync(resetH323Phone);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort41
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLineOptions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLineOptionsResponse getLineOptions(AxlNetClient.getLineOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLineOptions", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLineOptionsResponse> getLineOptionsAsync(AxlNetClient.getLineOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDefaultDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDefaultDeviceProfileResponse addDefaultDeviceProfile(AxlNetClient.addDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDefaultDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDefaultDeviceProfileResponse> addDefaultDeviceProfileAsync(AxlNetClient.addDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDefaultDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDefaultDeviceProfileResponse updateDefaultDeviceProfile(AxlNetClient.updateDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDefaultDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDefaultDeviceProfileResponse> updateDefaultDeviceProfileAsync(AxlNetClient.updateDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDefaultDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDefaultDeviceProfileResponse getDefaultDeviceProfile(AxlNetClient.getDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDefaultDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDefaultDeviceProfileResponse> getDefaultDeviceProfileAsync(AxlNetClient.getDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDefaultDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDefaultDeviceProfileResponse removeDefaultDeviceProfile(AxlNetClient.removeDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDefaultDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDefaultDeviceProfileResponse> removeDefaultDeviceProfileAsync(AxlNetClient.removeDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDefaultDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDefaultDeviceProfileResponse listDefaultDeviceProfile(AxlNetClient.listDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDefaultDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDefaultDeviceProfileResponse> listDefaultDeviceProfileAsync(AxlNetClient.listDefaultDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addH323PhoneResponse addH323Phone(AxlNetClient.addH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addH323PhoneResponse> addH323PhoneAsync(AxlNetClient.addH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateH323PhoneResponse updateH323Phone(AxlNetClient.updateH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateH323PhoneResponse> updateH323PhoneAsync(AxlNetClient.updateH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getH323PhoneResponse getH323Phone(AxlNetClient.getH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getH323PhoneResponse> getH323PhoneAsync(AxlNetClient.getH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeH323PhoneResponse removeH323Phone(AxlNetClient.removeH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeH323PhoneResponse> removeH323PhoneAsync(AxlNetClient.removeH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listH323PhoneResponse listH323Phone(AxlNetClient.listH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listH323PhoneResponse> listH323PhoneAsync(AxlNetClient.listH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetH323PhoneResponse resetH323Phone(AxlNetClient.resetH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetH323PhoneResponse> resetH323PhoneAsync(AxlNetClient.resetH323PhoneRequest request);
    }

    public class AXLPortClient41 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort41>, AxlNetClient.AXLPort41
    {
        public AXLPortClient41(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLineOptionsResponse AxlNetClient.AXLPort41.getLineOptions(AxlNetClient.getLineOptionsRequest request)
        {
            return base.Channel.getLineOptions(request);
        }

        public AxlNetClient.GetLineOptionsRes getLineOptions(AxlNetClient.GetLineOptionsReq getLineOptions1)
        {
            AxlNetClient.getLineOptionsRequest inValue = new AxlNetClient.getLineOptionsRequest();
            inValue.getLineOptions = getLineOptions1;
            AxlNetClient.getLineOptionsResponse retVal = ((AxlNetClient.AXLPort41)(this)).getLineOptions(inValue);
            return retVal.getLineOptionsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLineOptionsResponse> AxlNetClient.AXLPort41.getLineOptionsAsync(AxlNetClient.getLineOptionsRequest request)
        {
            return base.Channel.getLineOptionsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineOptionsResponse> getLineOptionsAsync(AxlNetClient.GetLineOptionsReq getLineOptions)
        {
            AxlNetClient.getLineOptionsRequest inValue = new AxlNetClient.getLineOptionsRequest();
            inValue.getLineOptions = getLineOptions;
            return ((AxlNetClient.AXLPort41)(this)).getLineOptionsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDefaultDeviceProfileResponse AxlNetClient.AXLPort41.addDefaultDeviceProfile(AxlNetClient.addDefaultDeviceProfileRequest request)
        {
            return base.Channel.addDefaultDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse addDefaultDeviceProfile(AxlNetClient.AddDefaultDeviceProfileReq addDefaultDeviceProfile1)
        {
            AxlNetClient.addDefaultDeviceProfileRequest inValue = new AxlNetClient.addDefaultDeviceProfileRequest();
            inValue.addDefaultDeviceProfile = addDefaultDeviceProfile1;
            AxlNetClient.addDefaultDeviceProfileResponse retVal = ((AxlNetClient.AXLPort41)(this)).addDefaultDeviceProfile(inValue);
            return retVal.addDefaultDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDefaultDeviceProfileResponse> AxlNetClient.AXLPort41.addDefaultDeviceProfileAsync(AxlNetClient.addDefaultDeviceProfileRequest request)
        {
            return base.Channel.addDefaultDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDefaultDeviceProfileResponse> addDefaultDeviceProfileAsync(AxlNetClient.AddDefaultDeviceProfileReq addDefaultDeviceProfile)
        {
            AxlNetClient.addDefaultDeviceProfileRequest inValue = new AxlNetClient.addDefaultDeviceProfileRequest();
            inValue.addDefaultDeviceProfile = addDefaultDeviceProfile;
            return ((AxlNetClient.AXLPort41)(this)).addDefaultDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDefaultDeviceProfileResponse AxlNetClient.AXLPort41.updateDefaultDeviceProfile(AxlNetClient.updateDefaultDeviceProfileRequest request)
        {
            return base.Channel.updateDefaultDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse updateDefaultDeviceProfile(AxlNetClient.UpdateDefaultDeviceProfileReq updateDefaultDeviceProfile1)
        {
            AxlNetClient.updateDefaultDeviceProfileRequest inValue = new AxlNetClient.updateDefaultDeviceProfileRequest();
            inValue.updateDefaultDeviceProfile = updateDefaultDeviceProfile1;
            AxlNetClient.updateDefaultDeviceProfileResponse retVal = ((AxlNetClient.AXLPort41)(this)).updateDefaultDeviceProfile(inValue);
            return retVal.updateDefaultDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDefaultDeviceProfileResponse> AxlNetClient.AXLPort41.updateDefaultDeviceProfileAsync(AxlNetClient.updateDefaultDeviceProfileRequest request)
        {
            return base.Channel.updateDefaultDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDefaultDeviceProfileResponse> updateDefaultDeviceProfileAsync(AxlNetClient.UpdateDefaultDeviceProfileReq updateDefaultDeviceProfile)
        {
            AxlNetClient.updateDefaultDeviceProfileRequest inValue = new AxlNetClient.updateDefaultDeviceProfileRequest();
            inValue.updateDefaultDeviceProfile = updateDefaultDeviceProfile;
            return ((AxlNetClient.AXLPort41)(this)).updateDefaultDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDefaultDeviceProfileResponse AxlNetClient.AXLPort41.getDefaultDeviceProfile(AxlNetClient.getDefaultDeviceProfileRequest request)
        {
            return base.Channel.getDefaultDeviceProfile(request);
        }

        public AxlNetClient.GetDefaultDeviceProfileRes getDefaultDeviceProfile(AxlNetClient.GetDefaultDeviceProfileReq getDefaultDeviceProfile1)
        {
            AxlNetClient.getDefaultDeviceProfileRequest inValue = new AxlNetClient.getDefaultDeviceProfileRequest();
            inValue.getDefaultDeviceProfile = getDefaultDeviceProfile1;
            AxlNetClient.getDefaultDeviceProfileResponse retVal = ((AxlNetClient.AXLPort41)(this)).getDefaultDeviceProfile(inValue);
            return retVal.getDefaultDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDefaultDeviceProfileResponse> AxlNetClient.AXLPort41.getDefaultDeviceProfileAsync(AxlNetClient.getDefaultDeviceProfileRequest request)
        {
            return base.Channel.getDefaultDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDefaultDeviceProfileResponse> getDefaultDeviceProfileAsync(AxlNetClient.GetDefaultDeviceProfileReq getDefaultDeviceProfile)
        {
            AxlNetClient.getDefaultDeviceProfileRequest inValue = new AxlNetClient.getDefaultDeviceProfileRequest();
            inValue.getDefaultDeviceProfile = getDefaultDeviceProfile;
            return ((AxlNetClient.AXLPort41)(this)).getDefaultDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDefaultDeviceProfileResponse AxlNetClient.AXLPort41.removeDefaultDeviceProfile(AxlNetClient.removeDefaultDeviceProfileRequest request)
        {
            return base.Channel.removeDefaultDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse removeDefaultDeviceProfile(AxlNetClient.NameAndGUIDRequest removeDefaultDeviceProfile1)
        {
            AxlNetClient.removeDefaultDeviceProfileRequest inValue = new AxlNetClient.removeDefaultDeviceProfileRequest();
            inValue.removeDefaultDeviceProfile = removeDefaultDeviceProfile1;
            AxlNetClient.removeDefaultDeviceProfileResponse retVal = ((AxlNetClient.AXLPort41)(this)).removeDefaultDeviceProfile(inValue);
            return retVal.removeDefaultDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDefaultDeviceProfileResponse> AxlNetClient.AXLPort41.removeDefaultDeviceProfileAsync(AxlNetClient.removeDefaultDeviceProfileRequest request)
        {
            return base.Channel.removeDefaultDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDefaultDeviceProfileResponse> removeDefaultDeviceProfileAsync(AxlNetClient.NameAndGUIDRequest removeDefaultDeviceProfile)
        {
            AxlNetClient.removeDefaultDeviceProfileRequest inValue = new AxlNetClient.removeDefaultDeviceProfileRequest();
            inValue.removeDefaultDeviceProfile = removeDefaultDeviceProfile;
            return ((AxlNetClient.AXLPort41)(this)).removeDefaultDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDefaultDeviceProfileResponse AxlNetClient.AXLPort41.listDefaultDeviceProfile(AxlNetClient.listDefaultDeviceProfileRequest request)
        {
            return base.Channel.listDefaultDeviceProfile(request);
        }

        public AxlNetClient.ListDefaultDeviceProfileRes listDefaultDeviceProfile(AxlNetClient.ListDefaultDeviceProfileReq listDefaultDeviceProfile1)
        {
            AxlNetClient.listDefaultDeviceProfileRequest inValue = new AxlNetClient.listDefaultDeviceProfileRequest();
            inValue.listDefaultDeviceProfile = listDefaultDeviceProfile1;
            AxlNetClient.listDefaultDeviceProfileResponse retVal = ((AxlNetClient.AXLPort41)(this)).listDefaultDeviceProfile(inValue);
            return retVal.listDefaultDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDefaultDeviceProfileResponse> AxlNetClient.AXLPort41.listDefaultDeviceProfileAsync(AxlNetClient.listDefaultDeviceProfileRequest request)
        {
            return base.Channel.listDefaultDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDefaultDeviceProfileResponse> listDefaultDeviceProfileAsync(AxlNetClient.ListDefaultDeviceProfileReq listDefaultDeviceProfile)
        {
            AxlNetClient.listDefaultDeviceProfileRequest inValue = new AxlNetClient.listDefaultDeviceProfileRequest();
            inValue.listDefaultDeviceProfile = listDefaultDeviceProfile;
            return ((AxlNetClient.AXLPort41)(this)).listDefaultDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addH323PhoneResponse AxlNetClient.AXLPort41.addH323Phone(AxlNetClient.addH323PhoneRequest request)
        {
            return base.Channel.addH323Phone(request);
        }

        public AxlNetClient.StandardResponse addH323Phone(AxlNetClient.AddH323PhoneReq addH323Phone1)
        {
            AxlNetClient.addH323PhoneRequest inValue = new AxlNetClient.addH323PhoneRequest();
            inValue.addH323Phone = addH323Phone1;
            AxlNetClient.addH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).addH323Phone(inValue);
            return retVal.addH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addH323PhoneResponse> AxlNetClient.AXLPort41.addH323PhoneAsync(AxlNetClient.addH323PhoneRequest request)
        {
            return base.Channel.addH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323PhoneResponse> addH323PhoneAsync(AxlNetClient.AddH323PhoneReq addH323Phone)
        {
            AxlNetClient.addH323PhoneRequest inValue = new AxlNetClient.addH323PhoneRequest();
            inValue.addH323Phone = addH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).addH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateH323PhoneResponse AxlNetClient.AXLPort41.updateH323Phone(AxlNetClient.updateH323PhoneRequest request)
        {
            return base.Channel.updateH323Phone(request);
        }

        public AxlNetClient.StandardResponse updateH323Phone(AxlNetClient.UpdateH323PhoneReq updateH323Phone1)
        {
            AxlNetClient.updateH323PhoneRequest inValue = new AxlNetClient.updateH323PhoneRequest();
            inValue.updateH323Phone = updateH323Phone1;
            AxlNetClient.updateH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).updateH323Phone(inValue);
            return retVal.updateH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateH323PhoneResponse> AxlNetClient.AXLPort41.updateH323PhoneAsync(AxlNetClient.updateH323PhoneRequest request)
        {
            return base.Channel.updateH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323PhoneResponse> updateH323PhoneAsync(AxlNetClient.UpdateH323PhoneReq updateH323Phone)
        {
            AxlNetClient.updateH323PhoneRequest inValue = new AxlNetClient.updateH323PhoneRequest();
            inValue.updateH323Phone = updateH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).updateH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getH323PhoneResponse AxlNetClient.AXLPort41.getH323Phone(AxlNetClient.getH323PhoneRequest request)
        {
            return base.Channel.getH323Phone(request);
        }

        public AxlNetClient.GetH323PhoneRes getH323Phone(AxlNetClient.GetH323PhoneReq getH323Phone1)
        {
            AxlNetClient.getH323PhoneRequest inValue = new AxlNetClient.getH323PhoneRequest();
            inValue.getH323Phone = getH323Phone1;
            AxlNetClient.getH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).getH323Phone(inValue);
            return retVal.getH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getH323PhoneResponse> AxlNetClient.AXLPort41.getH323PhoneAsync(AxlNetClient.getH323PhoneRequest request)
        {
            return base.Channel.getH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323PhoneResponse> getH323PhoneAsync(AxlNetClient.GetH323PhoneReq getH323Phone)
        {
            AxlNetClient.getH323PhoneRequest inValue = new AxlNetClient.getH323PhoneRequest();
            inValue.getH323Phone = getH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).getH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeH323PhoneResponse AxlNetClient.AXLPort41.removeH323Phone(AxlNetClient.removeH323PhoneRequest request)
        {
            return base.Channel.removeH323Phone(request);
        }

        public AxlNetClient.StandardResponse removeH323Phone(AxlNetClient.NameAndGUIDRequest removeH323Phone1)
        {
            AxlNetClient.removeH323PhoneRequest inValue = new AxlNetClient.removeH323PhoneRequest();
            inValue.removeH323Phone = removeH323Phone1;
            AxlNetClient.removeH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).removeH323Phone(inValue);
            return retVal.removeH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeH323PhoneResponse> AxlNetClient.AXLPort41.removeH323PhoneAsync(AxlNetClient.removeH323PhoneRequest request)
        {
            return base.Channel.removeH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323PhoneResponse> removeH323PhoneAsync(AxlNetClient.NameAndGUIDRequest removeH323Phone)
        {
            AxlNetClient.removeH323PhoneRequest inValue = new AxlNetClient.removeH323PhoneRequest();
            inValue.removeH323Phone = removeH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).removeH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listH323PhoneResponse AxlNetClient.AXLPort41.listH323Phone(AxlNetClient.listH323PhoneRequest request)
        {
            return base.Channel.listH323Phone(request);
        }

        public AxlNetClient.ListH323PhoneRes listH323Phone(AxlNetClient.ListH323PhoneReq listH323Phone1)
        {
            AxlNetClient.listH323PhoneRequest inValue = new AxlNetClient.listH323PhoneRequest();
            inValue.listH323Phone = listH323Phone1;
            AxlNetClient.listH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).listH323Phone(inValue);
            return retVal.listH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listH323PhoneResponse> AxlNetClient.AXLPort41.listH323PhoneAsync(AxlNetClient.listH323PhoneRequest request)
        {
            return base.Channel.listH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323PhoneResponse> listH323PhoneAsync(AxlNetClient.ListH323PhoneReq listH323Phone)
        {
            AxlNetClient.listH323PhoneRequest inValue = new AxlNetClient.listH323PhoneRequest();
            inValue.listH323Phone = listH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).listH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetH323PhoneResponse AxlNetClient.AXLPort41.resetH323Phone(AxlNetClient.resetH323PhoneRequest request)
        {
            return base.Channel.resetH323Phone(request);
        }

        public AxlNetClient.StandardResponse resetH323Phone(AxlNetClient.NameAndGUIDRequest resetH323Phone1)
        {
            AxlNetClient.resetH323PhoneRequest inValue = new AxlNetClient.resetH323PhoneRequest();
            inValue.resetH323Phone = resetH323Phone1;
            AxlNetClient.resetH323PhoneResponse retVal = ((AxlNetClient.AXLPort41)(this)).resetH323Phone(inValue);
            return retVal.resetH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetH323PhoneResponse> AxlNetClient.AXLPort41.resetH323PhoneAsync(AxlNetClient.resetH323PhoneRequest request)
        {
            return base.Channel.resetH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323PhoneResponse> resetH323PhoneAsync(AxlNetClient.NameAndGUIDRequest resetH323Phone)
        {
            AxlNetClient.resetH323PhoneRequest inValue = new AxlNetClient.resetH323PhoneRequest();
            inValue.resetH323Phone = resetH323Phone;
            return ((AxlNetClient.AXLPort41)(this)).resetH323PhoneAsync(inValue);
        }
    }
}