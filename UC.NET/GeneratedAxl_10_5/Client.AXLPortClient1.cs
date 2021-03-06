namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient1 _axlPortClient1;

        private static AXLPortClient1 axlPortClient1 => _axlPortClient1 == null ||
            _axlPortClient1.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient1 = LoadClient1()) : _axlPortClient1;

        private static AXLPortClient1 LoadClient1()
        {
            var client = new AXLPortClient1(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close1;
            OnAbort += Abort1;
            return client;
        }

        private static void Close1(object sender, System.EventArgs e)
        {
            _axlPortClient1.Close();
        }

        private static void Abort1(object sender, System.EventArgs e)
        {
            _axlPortClient1.Abort();
        }

        public AxlNetClient.StandardResponse addSipProfile(AxlNetClient.AddSipProfileReq addSipProfile1)
        {
            return axlPortClient1.addSipProfile(addSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipProfileResponse> addSipProfileAsync(AxlNetClient.AddSipProfileReq addSipProfile)
        {
            return axlPortClient1.addSipProfileAsync(addSipProfile);
        }

        public AxlNetClient.StandardResponse updateSipProfile(AxlNetClient.UpdateSipProfileReq updateSipProfile1)
        {
            return axlPortClient1.updateSipProfile(updateSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipProfileResponse> updateSipProfileAsync(AxlNetClient.UpdateSipProfileReq updateSipProfile)
        {
            return axlPortClient1.updateSipProfileAsync(updateSipProfile);
        }

        public AxlNetClient.GetSipProfileRes getSipProfile(AxlNetClient.GetSipProfileReq getSipProfile1)
        {
            return axlPortClient1.getSipProfile(getSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipProfileResponse> getSipProfileAsync(AxlNetClient.GetSipProfileReq getSipProfile)
        {
            return axlPortClient1.getSipProfileAsync(getSipProfile);
        }

        public AxlNetClient.StandardResponse removeSipProfile(AxlNetClient.NameAndGUIDRequest removeSipProfile1)
        {
            return axlPortClient1.removeSipProfile(removeSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipProfileResponse> removeSipProfileAsync(AxlNetClient.NameAndGUIDRequest removeSipProfile)
        {
            return axlPortClient1.removeSipProfileAsync(removeSipProfile);
        }

        public AxlNetClient.ListSipProfileRes listSipProfile(AxlNetClient.ListSipProfileReq listSipProfile1)
        {
            return axlPortClient1.listSipProfile(listSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipProfileResponse> listSipProfileAsync(AxlNetClient.ListSipProfileReq listSipProfile)
        {
            return axlPortClient1.listSipProfileAsync(listSipProfile);
        }

        public AxlNetClient.StandardResponse restartSipProfile(AxlNetClient.NameAndGUIDRequest restartSipProfile1)
        {
            return axlPortClient1.restartSipProfile(restartSipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSipProfileResponse> restartSipProfileAsync(AxlNetClient.NameAndGUIDRequest restartSipProfile)
        {
            return axlPortClient1.restartSipProfileAsync(restartSipProfile);
        }

        public AxlNetClient.StandardResponse applySipProfile(AxlNetClient.NameAndGUIDRequest applySipProfile1)
        {
            return axlPortClient1.applySipProfile(applySipProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySipProfileResponse> applySipProfileAsync(AxlNetClient.NameAndGUIDRequest applySipProfile)
        {
            return axlPortClient1.applySipProfileAsync(applySipProfile);
        }

        public AxlNetClient.GetSipProfileOptionsRes getSipProfileOptions(AxlNetClient.GetSipProfileOptionsReq getSipProfileOptions1)
        {
            return axlPortClient1.getSipProfileOptions(getSipProfileOptions1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipProfileOptionsResponse> getSipProfileOptionsAsync(AxlNetClient.GetSipProfileOptionsReq getSipProfileOptions)
        {
            return axlPortClient1.getSipProfileOptionsAsync(getSipProfileOptions);
        }

        public AxlNetClient.StandardResponse addSipTrunkSecurityProfile(AxlNetClient.AddSipTrunkSecurityProfileReq addSipTrunkSecurityProfile1)
        {
            return axlPortClient1.addSipTrunkSecurityProfile(addSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipTrunkSecurityProfileResponse> addSipTrunkSecurityProfileAsync(AxlNetClient.AddSipTrunkSecurityProfileReq addSipTrunkSecurityProfile)
        {
            return axlPortClient1.addSipTrunkSecurityProfileAsync(addSipTrunkSecurityProfile);
        }

        public AxlNetClient.StandardResponse updateSipTrunkSecurityProfile(AxlNetClient.UpdateSipTrunkSecurityProfileReq updateSipTrunkSecurityProfile1)
        {
            return axlPortClient1.updateSipTrunkSecurityProfile(updateSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkSecurityProfileResponse> updateSipTrunkSecurityProfileAsync(AxlNetClient.UpdateSipTrunkSecurityProfileReq updateSipTrunkSecurityProfile)
        {
            return axlPortClient1.updateSipTrunkSecurityProfileAsync(updateSipTrunkSecurityProfile);
        }

        public AxlNetClient.GetSipTrunkSecurityProfileRes getSipTrunkSecurityProfile(AxlNetClient.GetSipTrunkSecurityProfileReq getSipTrunkSecurityProfile1)
        {
            return axlPortClient1.getSipTrunkSecurityProfile(getSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipTrunkSecurityProfileResponse> getSipTrunkSecurityProfileAsync(AxlNetClient.GetSipTrunkSecurityProfileReq getSipTrunkSecurityProfile)
        {
            return axlPortClient1.getSipTrunkSecurityProfileAsync(getSipTrunkSecurityProfile);
        }

        public AxlNetClient.StandardResponse removeSipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest removeSipTrunkSecurityProfile1)
        {
            return axlPortClient1.removeSipTrunkSecurityProfile(removeSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkSecurityProfileResponse> removeSipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeSipTrunkSecurityProfile)
        {
            return axlPortClient1.removeSipTrunkSecurityProfileAsync(removeSipTrunkSecurityProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort1
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipProfileResponse addSipProfile(AxlNetClient.addSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipProfileResponse> addSipProfileAsync(AxlNetClient.addSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipProfileResponse updateSipProfile(AxlNetClient.updateSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipProfileResponse> updateSipProfileAsync(AxlNetClient.updateSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipProfileResponse getSipProfile(AxlNetClient.getSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipProfileResponse> getSipProfileAsync(AxlNetClient.getSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipProfileResponse removeSipProfile(AxlNetClient.removeSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipProfileResponse> removeSipProfileAsync(AxlNetClient.removeSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipProfileResponse listSipProfile(AxlNetClient.listSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipProfileResponse> listSipProfileAsync(AxlNetClient.listSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartSipProfileResponse restartSipProfile(AxlNetClient.restartSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartSipProfileResponse> restartSipProfileAsync(AxlNetClient.restartSipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySipProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applySipProfileResponse applySipProfile(AxlNetClient.applySipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySipProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applySipProfileResponse> applySipProfileAsync(AxlNetClient.applySipProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipProfileOptions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipProfileOptionsResponse getSipProfileOptions(AxlNetClient.getSipProfileOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipProfileOptions", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipProfileOptionsResponse> getSipProfileOptionsAsync(AxlNetClient.getSipProfileOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipTrunkSecurityProfileResponse addSipTrunkSecurityProfile(AxlNetClient.addSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipTrunkSecurityProfileResponse> addSipTrunkSecurityProfileAsync(AxlNetClient.addSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipTrunkSecurityProfileResponse updateSipTrunkSecurityProfile(AxlNetClient.updateSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkSecurityProfileResponse> updateSipTrunkSecurityProfileAsync(AxlNetClient.updateSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipTrunkSecurityProfileResponse getSipTrunkSecurityProfile(AxlNetClient.getSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipTrunkSecurityProfileResponse> getSipTrunkSecurityProfileAsync(AxlNetClient.getSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipTrunkSecurityProfileResponse removeSipTrunkSecurityProfile(AxlNetClient.removeSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkSecurityProfileResponse> removeSipTrunkSecurityProfileAsync(AxlNetClient.removeSipTrunkSecurityProfileRequest request);
    }

    public class AXLPortClient1 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort1>, AxlNetClient.AXLPort1
    {
        public AXLPortClient1(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipProfileResponse AxlNetClient.AXLPort1.addSipProfile(AxlNetClient.addSipProfileRequest request)
        {
            return base.Channel.addSipProfile(request);
        }

        public AxlNetClient.StandardResponse addSipProfile(AxlNetClient.AddSipProfileReq addSipProfile1)
        {
            AxlNetClient.addSipProfileRequest inValue = new AxlNetClient.addSipProfileRequest();
            inValue.addSipProfile = addSipProfile1;
            AxlNetClient.addSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).addSipProfile(inValue);
            return retVal.addSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipProfileResponse> AxlNetClient.AXLPort1.addSipProfileAsync(AxlNetClient.addSipProfileRequest request)
        {
            return base.Channel.addSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipProfileResponse> addSipProfileAsync(AxlNetClient.AddSipProfileReq addSipProfile)
        {
            AxlNetClient.addSipProfileRequest inValue = new AxlNetClient.addSipProfileRequest();
            inValue.addSipProfile = addSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).addSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipProfileResponse AxlNetClient.AXLPort1.updateSipProfile(AxlNetClient.updateSipProfileRequest request)
        {
            return base.Channel.updateSipProfile(request);
        }

        public AxlNetClient.StandardResponse updateSipProfile(AxlNetClient.UpdateSipProfileReq updateSipProfile1)
        {
            AxlNetClient.updateSipProfileRequest inValue = new AxlNetClient.updateSipProfileRequest();
            inValue.updateSipProfile = updateSipProfile1;
            AxlNetClient.updateSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).updateSipProfile(inValue);
            return retVal.updateSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipProfileResponse> AxlNetClient.AXLPort1.updateSipProfileAsync(AxlNetClient.updateSipProfileRequest request)
        {
            return base.Channel.updateSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipProfileResponse> updateSipProfileAsync(AxlNetClient.UpdateSipProfileReq updateSipProfile)
        {
            AxlNetClient.updateSipProfileRequest inValue = new AxlNetClient.updateSipProfileRequest();
            inValue.updateSipProfile = updateSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).updateSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipProfileResponse AxlNetClient.AXLPort1.getSipProfile(AxlNetClient.getSipProfileRequest request)
        {
            return base.Channel.getSipProfile(request);
        }

        public AxlNetClient.GetSipProfileRes getSipProfile(AxlNetClient.GetSipProfileReq getSipProfile1)
        {
            AxlNetClient.getSipProfileRequest inValue = new AxlNetClient.getSipProfileRequest();
            inValue.getSipProfile = getSipProfile1;
            AxlNetClient.getSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).getSipProfile(inValue);
            return retVal.getSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipProfileResponse> AxlNetClient.AXLPort1.getSipProfileAsync(AxlNetClient.getSipProfileRequest request)
        {
            return base.Channel.getSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipProfileResponse> getSipProfileAsync(AxlNetClient.GetSipProfileReq getSipProfile)
        {
            AxlNetClient.getSipProfileRequest inValue = new AxlNetClient.getSipProfileRequest();
            inValue.getSipProfile = getSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).getSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipProfileResponse AxlNetClient.AXLPort1.removeSipProfile(AxlNetClient.removeSipProfileRequest request)
        {
            return base.Channel.removeSipProfile(request);
        }

        public AxlNetClient.StandardResponse removeSipProfile(AxlNetClient.NameAndGUIDRequest removeSipProfile1)
        {
            AxlNetClient.removeSipProfileRequest inValue = new AxlNetClient.removeSipProfileRequest();
            inValue.removeSipProfile = removeSipProfile1;
            AxlNetClient.removeSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).removeSipProfile(inValue);
            return retVal.removeSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipProfileResponse> AxlNetClient.AXLPort1.removeSipProfileAsync(AxlNetClient.removeSipProfileRequest request)
        {
            return base.Channel.removeSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipProfileResponse> removeSipProfileAsync(AxlNetClient.NameAndGUIDRequest removeSipProfile)
        {
            AxlNetClient.removeSipProfileRequest inValue = new AxlNetClient.removeSipProfileRequest();
            inValue.removeSipProfile = removeSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).removeSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipProfileResponse AxlNetClient.AXLPort1.listSipProfile(AxlNetClient.listSipProfileRequest request)
        {
            return base.Channel.listSipProfile(request);
        }

        public AxlNetClient.ListSipProfileRes listSipProfile(AxlNetClient.ListSipProfileReq listSipProfile1)
        {
            AxlNetClient.listSipProfileRequest inValue = new AxlNetClient.listSipProfileRequest();
            inValue.listSipProfile = listSipProfile1;
            AxlNetClient.listSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).listSipProfile(inValue);
            return retVal.listSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipProfileResponse> AxlNetClient.AXLPort1.listSipProfileAsync(AxlNetClient.listSipProfileRequest request)
        {
            return base.Channel.listSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipProfileResponse> listSipProfileAsync(AxlNetClient.ListSipProfileReq listSipProfile)
        {
            AxlNetClient.listSipProfileRequest inValue = new AxlNetClient.listSipProfileRequest();
            inValue.listSipProfile = listSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).listSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartSipProfileResponse AxlNetClient.AXLPort1.restartSipProfile(AxlNetClient.restartSipProfileRequest request)
        {
            return base.Channel.restartSipProfile(request);
        }

        public AxlNetClient.StandardResponse restartSipProfile(AxlNetClient.NameAndGUIDRequest restartSipProfile1)
        {
            AxlNetClient.restartSipProfileRequest inValue = new AxlNetClient.restartSipProfileRequest();
            inValue.restartSipProfile = restartSipProfile1;
            AxlNetClient.restartSipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).restartSipProfile(inValue);
            return retVal.restartSipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartSipProfileResponse> AxlNetClient.AXLPort1.restartSipProfileAsync(AxlNetClient.restartSipProfileRequest request)
        {
            return base.Channel.restartSipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSipProfileResponse> restartSipProfileAsync(AxlNetClient.NameAndGUIDRequest restartSipProfile)
        {
            AxlNetClient.restartSipProfileRequest inValue = new AxlNetClient.restartSipProfileRequest();
            inValue.restartSipProfile = restartSipProfile;
            return ((AxlNetClient.AXLPort1)(this)).restartSipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applySipProfileResponse AxlNetClient.AXLPort1.applySipProfile(AxlNetClient.applySipProfileRequest request)
        {
            return base.Channel.applySipProfile(request);
        }

        public AxlNetClient.StandardResponse applySipProfile(AxlNetClient.NameAndGUIDRequest applySipProfile1)
        {
            AxlNetClient.applySipProfileRequest inValue = new AxlNetClient.applySipProfileRequest();
            inValue.applySipProfile = applySipProfile1;
            AxlNetClient.applySipProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).applySipProfile(inValue);
            return retVal.applySipProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applySipProfileResponse> AxlNetClient.AXLPort1.applySipProfileAsync(AxlNetClient.applySipProfileRequest request)
        {
            return base.Channel.applySipProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySipProfileResponse> applySipProfileAsync(AxlNetClient.NameAndGUIDRequest applySipProfile)
        {
            AxlNetClient.applySipProfileRequest inValue = new AxlNetClient.applySipProfileRequest();
            inValue.applySipProfile = applySipProfile;
            return ((AxlNetClient.AXLPort1)(this)).applySipProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipProfileOptionsResponse AxlNetClient.AXLPort1.getSipProfileOptions(AxlNetClient.getSipProfileOptionsRequest request)
        {
            return base.Channel.getSipProfileOptions(request);
        }

        public AxlNetClient.GetSipProfileOptionsRes getSipProfileOptions(AxlNetClient.GetSipProfileOptionsReq getSipProfileOptions1)
        {
            AxlNetClient.getSipProfileOptionsRequest inValue = new AxlNetClient.getSipProfileOptionsRequest();
            inValue.getSipProfileOptions = getSipProfileOptions1;
            AxlNetClient.getSipProfileOptionsResponse retVal = ((AxlNetClient.AXLPort1)(this)).getSipProfileOptions(inValue);
            return retVal.getSipProfileOptionsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipProfileOptionsResponse> AxlNetClient.AXLPort1.getSipProfileOptionsAsync(AxlNetClient.getSipProfileOptionsRequest request)
        {
            return base.Channel.getSipProfileOptionsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipProfileOptionsResponse> getSipProfileOptionsAsync(AxlNetClient.GetSipProfileOptionsReq getSipProfileOptions)
        {
            AxlNetClient.getSipProfileOptionsRequest inValue = new AxlNetClient.getSipProfileOptionsRequest();
            inValue.getSipProfileOptions = getSipProfileOptions;
            return ((AxlNetClient.AXLPort1)(this)).getSipProfileOptionsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipTrunkSecurityProfileResponse AxlNetClient.AXLPort1.addSipTrunkSecurityProfile(AxlNetClient.addSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.addSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse addSipTrunkSecurityProfile(AxlNetClient.AddSipTrunkSecurityProfileReq addSipTrunkSecurityProfile1)
        {
            AxlNetClient.addSipTrunkSecurityProfileRequest inValue = new AxlNetClient.addSipTrunkSecurityProfileRequest();
            inValue.addSipTrunkSecurityProfile = addSipTrunkSecurityProfile1;
            AxlNetClient.addSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).addSipTrunkSecurityProfile(inValue);
            return retVal.addSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort1.addSipTrunkSecurityProfileAsync(AxlNetClient.addSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.addSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipTrunkSecurityProfileResponse> addSipTrunkSecurityProfileAsync(AxlNetClient.AddSipTrunkSecurityProfileReq addSipTrunkSecurityProfile)
        {
            AxlNetClient.addSipTrunkSecurityProfileRequest inValue = new AxlNetClient.addSipTrunkSecurityProfileRequest();
            inValue.addSipTrunkSecurityProfile = addSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort1)(this)).addSipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipTrunkSecurityProfileResponse AxlNetClient.AXLPort1.updateSipTrunkSecurityProfile(AxlNetClient.updateSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.updateSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse updateSipTrunkSecurityProfile(AxlNetClient.UpdateSipTrunkSecurityProfileReq updateSipTrunkSecurityProfile1)
        {
            AxlNetClient.updateSipTrunkSecurityProfileRequest inValue = new AxlNetClient.updateSipTrunkSecurityProfileRequest();
            inValue.updateSipTrunkSecurityProfile = updateSipTrunkSecurityProfile1;
            AxlNetClient.updateSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).updateSipTrunkSecurityProfile(inValue);
            return retVal.updateSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort1.updateSipTrunkSecurityProfileAsync(AxlNetClient.updateSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.updateSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkSecurityProfileResponse> updateSipTrunkSecurityProfileAsync(AxlNetClient.UpdateSipTrunkSecurityProfileReq updateSipTrunkSecurityProfile)
        {
            AxlNetClient.updateSipTrunkSecurityProfileRequest inValue = new AxlNetClient.updateSipTrunkSecurityProfileRequest();
            inValue.updateSipTrunkSecurityProfile = updateSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort1)(this)).updateSipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipTrunkSecurityProfileResponse AxlNetClient.AXLPort1.getSipTrunkSecurityProfile(AxlNetClient.getSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.getSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.GetSipTrunkSecurityProfileRes getSipTrunkSecurityProfile(AxlNetClient.GetSipTrunkSecurityProfileReq getSipTrunkSecurityProfile1)
        {
            AxlNetClient.getSipTrunkSecurityProfileRequest inValue = new AxlNetClient.getSipTrunkSecurityProfileRequest();
            inValue.getSipTrunkSecurityProfile = getSipTrunkSecurityProfile1;
            AxlNetClient.getSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).getSipTrunkSecurityProfile(inValue);
            return retVal.getSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort1.getSipTrunkSecurityProfileAsync(AxlNetClient.getSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.getSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipTrunkSecurityProfileResponse> getSipTrunkSecurityProfileAsync(AxlNetClient.GetSipTrunkSecurityProfileReq getSipTrunkSecurityProfile)
        {
            AxlNetClient.getSipTrunkSecurityProfileRequest inValue = new AxlNetClient.getSipTrunkSecurityProfileRequest();
            inValue.getSipTrunkSecurityProfile = getSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort1)(this)).getSipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipTrunkSecurityProfileResponse AxlNetClient.AXLPort1.removeSipTrunkSecurityProfile(AxlNetClient.removeSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.removeSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse removeSipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest removeSipTrunkSecurityProfile1)
        {
            AxlNetClient.removeSipTrunkSecurityProfileRequest inValue = new AxlNetClient.removeSipTrunkSecurityProfileRequest();
            inValue.removeSipTrunkSecurityProfile = removeSipTrunkSecurityProfile1;
            AxlNetClient.removeSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort1)(this)).removeSipTrunkSecurityProfile(inValue);
            return retVal.removeSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort1.removeSipTrunkSecurityProfileAsync(AxlNetClient.removeSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.removeSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkSecurityProfileResponse> removeSipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeSipTrunkSecurityProfile)
        {
            AxlNetClient.removeSipTrunkSecurityProfileRequest inValue = new AxlNetClient.removeSipTrunkSecurityProfileRequest();
            inValue.removeSipTrunkSecurityProfile = removeSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort1)(this)).removeSipTrunkSecurityProfileAsync(inValue);
        }
    }
}