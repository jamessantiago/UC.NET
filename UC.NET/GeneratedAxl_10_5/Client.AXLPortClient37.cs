namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient37 _axlPortClient37;

        private static AXLPortClient37 axlPortClient37 => _axlPortClient37 == null ||
            _axlPortClient37.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient37 = LoadClient37()) : _axlPortClient37;

        private static AXLPortClient37 LoadClient37()
        {
            var client = new AXLPortClient37(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close37;
            OnAbort += Abort37;
            return client;
        }

        private static void Close37(object sender, System.EventArgs e)
        {
            _axlPortClient37.Close();
        }

        private static void Abort37(object sender, System.EventArgs e)
        {
            _axlPortClient37.Abort();
        }

        public AxlNetClient.ListDirectoryLookupDialRulesRes listDirectoryLookupDialRules(AxlNetClient.ListDirectoryLookupDialRulesReq listDirectoryLookupDialRules1)
        {
            return axlPortClient37.listDirectoryLookupDialRules(listDirectoryLookupDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirectoryLookupDialRulesResponse> listDirectoryLookupDialRulesAsync(AxlNetClient.ListDirectoryLookupDialRulesReq listDirectoryLookupDialRules)
        {
            return axlPortClient37.listDirectoryLookupDialRulesAsync(listDirectoryLookupDialRules);
        }

        public AxlNetClient.StandardResponse addPhoneSecurityProfile(AxlNetClient.AddPhoneSecurityProfileReq addPhoneSecurityProfile1)
        {
            return axlPortClient37.addPhoneSecurityProfile(addPhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneSecurityProfileResponse> addPhoneSecurityProfileAsync(AxlNetClient.AddPhoneSecurityProfileReq addPhoneSecurityProfile)
        {
            return axlPortClient37.addPhoneSecurityProfileAsync(addPhoneSecurityProfile);
        }

        public AxlNetClient.StandardResponse updatePhoneSecurityProfile(AxlNetClient.UpdatePhoneSecurityProfileReq updatePhoneSecurityProfile1)
        {
            return axlPortClient37.updatePhoneSecurityProfile(updatePhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneSecurityProfileResponse> updatePhoneSecurityProfileAsync(AxlNetClient.UpdatePhoneSecurityProfileReq updatePhoneSecurityProfile)
        {
            return axlPortClient37.updatePhoneSecurityProfileAsync(updatePhoneSecurityProfile);
        }

        public AxlNetClient.GetPhoneSecurityProfileRes getPhoneSecurityProfile(AxlNetClient.GetPhoneSecurityProfileReq getPhoneSecurityProfile1)
        {
            return axlPortClient37.getPhoneSecurityProfile(getPhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneSecurityProfileResponse> getPhoneSecurityProfileAsync(AxlNetClient.GetPhoneSecurityProfileReq getPhoneSecurityProfile)
        {
            return axlPortClient37.getPhoneSecurityProfileAsync(getPhoneSecurityProfile);
        }

        public AxlNetClient.StandardResponse removePhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest removePhoneSecurityProfile1)
        {
            return axlPortClient37.removePhoneSecurityProfile(removePhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneSecurityProfileResponse> removePhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removePhoneSecurityProfile)
        {
            return axlPortClient37.removePhoneSecurityProfileAsync(removePhoneSecurityProfile);
        }

        public AxlNetClient.ListPhoneSecurityProfileRes listPhoneSecurityProfile(AxlNetClient.ListPhoneSecurityProfileReq listPhoneSecurityProfile1)
        {
            return axlPortClient37.listPhoneSecurityProfile(listPhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneSecurityProfileResponse> listPhoneSecurityProfileAsync(AxlNetClient.ListPhoneSecurityProfileReq listPhoneSecurityProfile)
        {
            return axlPortClient37.listPhoneSecurityProfileAsync(listPhoneSecurityProfile);
        }

        public AxlNetClient.StandardResponse resetPhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest resetPhoneSecurityProfile1)
        {
            return axlPortClient37.resetPhoneSecurityProfile(resetPhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetPhoneSecurityProfileResponse> resetPhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest resetPhoneSecurityProfile)
        {
            return axlPortClient37.resetPhoneSecurityProfileAsync(resetPhoneSecurityProfile);
        }

        public AxlNetClient.StandardResponse applyPhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest applyPhoneSecurityProfile1)
        {
            return axlPortClient37.applyPhoneSecurityProfile(applyPhoneSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneSecurityProfileResponse> applyPhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest applyPhoneSecurityProfile)
        {
            return axlPortClient37.applyPhoneSecurityProfileAsync(applyPhoneSecurityProfile);
        }

        public AxlNetClient.StandardResponse addSipDialRules(AxlNetClient.AddSipDialRulesReq addSipDialRules1)
        {
            return axlPortClient37.addSipDialRules(addSipDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipDialRulesResponse> addSipDialRulesAsync(AxlNetClient.AddSipDialRulesReq addSipDialRules)
        {
            return axlPortClient37.addSipDialRulesAsync(addSipDialRules);
        }

        public AxlNetClient.StandardResponse updateSipDialRules(AxlNetClient.UpdateSipDialRulesReq updateSipDialRules1)
        {
            return axlPortClient37.updateSipDialRules(updateSipDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipDialRulesResponse> updateSipDialRulesAsync(AxlNetClient.UpdateSipDialRulesReq updateSipDialRules)
        {
            return axlPortClient37.updateSipDialRulesAsync(updateSipDialRules);
        }

        public AxlNetClient.GetSipDialRulesRes getSipDialRules(AxlNetClient.GetSipDialRulesReq getSipDialRules1)
        {
            return axlPortClient37.getSipDialRules(getSipDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipDialRulesResponse> getSipDialRulesAsync(AxlNetClient.GetSipDialRulesReq getSipDialRules)
        {
            return axlPortClient37.getSipDialRulesAsync(getSipDialRules);
        }

        public AxlNetClient.StandardResponse removeSipDialRules(AxlNetClient.NameAndGUIDRequest removeSipDialRules1)
        {
            return axlPortClient37.removeSipDialRules(removeSipDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipDialRulesResponse> removeSipDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeSipDialRules)
        {
            return axlPortClient37.removeSipDialRulesAsync(removeSipDialRules);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort37
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirectoryLookupDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDirectoryLookupDialRulesResponse listDirectoryLookupDialRules(AxlNetClient.listDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirectoryLookupDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDirectoryLookupDialRulesResponse> listDirectoryLookupDialRulesAsync(AxlNetClient.listDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPhoneSecurityProfileResponse addPhoneSecurityProfile(AxlNetClient.addPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneSecurityProfileResponse> addPhoneSecurityProfileAsync(AxlNetClient.addPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePhoneSecurityProfileResponse updatePhoneSecurityProfile(AxlNetClient.updatePhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneSecurityProfileResponse> updatePhoneSecurityProfileAsync(AxlNetClient.updatePhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneSecurityProfileResponse getPhoneSecurityProfile(AxlNetClient.getPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneSecurityProfileResponse> getPhoneSecurityProfileAsync(AxlNetClient.getPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePhoneSecurityProfileResponse removePhoneSecurityProfile(AxlNetClient.removePhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneSecurityProfileResponse> removePhoneSecurityProfileAsync(AxlNetClient.removePhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPhoneSecurityProfileResponse listPhoneSecurityProfile(AxlNetClient.listPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneSecurityProfileResponse> listPhoneSecurityProfileAsync(AxlNetClient.listPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetPhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetPhoneSecurityProfileResponse resetPhoneSecurityProfile(AxlNetClient.resetPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetPhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetPhoneSecurityProfileResponse> resetPhoneSecurityProfileAsync(AxlNetClient.resetPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhoneSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyPhoneSecurityProfileResponse applyPhoneSecurityProfile(AxlNetClient.applyPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhoneSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneSecurityProfileResponse> applyPhoneSecurityProfileAsync(AxlNetClient.applyPhoneSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipDialRulesResponse addSipDialRules(AxlNetClient.addSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipDialRulesResponse> addSipDialRulesAsync(AxlNetClient.addSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipDialRulesResponse updateSipDialRules(AxlNetClient.updateSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipDialRulesResponse> updateSipDialRulesAsync(AxlNetClient.updateSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipDialRulesResponse getSipDialRules(AxlNetClient.getSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipDialRulesResponse> getSipDialRulesAsync(AxlNetClient.getSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipDialRulesResponse removeSipDialRules(AxlNetClient.removeSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipDialRulesResponse> removeSipDialRulesAsync(AxlNetClient.removeSipDialRulesRequest request);
    }

    public class AXLPortClient37 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort37>, AxlNetClient.AXLPort37
    {
        public AXLPortClient37(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDirectoryLookupDialRulesResponse AxlNetClient.AXLPort37.listDirectoryLookupDialRules(AxlNetClient.listDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.listDirectoryLookupDialRules(request);
        }

        public AxlNetClient.ListDirectoryLookupDialRulesRes listDirectoryLookupDialRules(AxlNetClient.ListDirectoryLookupDialRulesReq listDirectoryLookupDialRules1)
        {
            AxlNetClient.listDirectoryLookupDialRulesRequest inValue = new AxlNetClient.listDirectoryLookupDialRulesRequest();
            inValue.listDirectoryLookupDialRules = listDirectoryLookupDialRules1;
            AxlNetClient.listDirectoryLookupDialRulesResponse retVal = ((AxlNetClient.AXLPort37)(this)).listDirectoryLookupDialRules(inValue);
            return retVal.listDirectoryLookupDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDirectoryLookupDialRulesResponse> AxlNetClient.AXLPort37.listDirectoryLookupDialRulesAsync(AxlNetClient.listDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.listDirectoryLookupDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirectoryLookupDialRulesResponse> listDirectoryLookupDialRulesAsync(AxlNetClient.ListDirectoryLookupDialRulesReq listDirectoryLookupDialRules)
        {
            AxlNetClient.listDirectoryLookupDialRulesRequest inValue = new AxlNetClient.listDirectoryLookupDialRulesRequest();
            inValue.listDirectoryLookupDialRules = listDirectoryLookupDialRules;
            return ((AxlNetClient.AXLPort37)(this)).listDirectoryLookupDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPhoneSecurityProfileResponse AxlNetClient.AXLPort37.addPhoneSecurityProfile(AxlNetClient.addPhoneSecurityProfileRequest request)
        {
            return base.Channel.addPhoneSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse addPhoneSecurityProfile(AxlNetClient.AddPhoneSecurityProfileReq addPhoneSecurityProfile1)
        {
            AxlNetClient.addPhoneSecurityProfileRequest inValue = new AxlNetClient.addPhoneSecurityProfileRequest();
            inValue.addPhoneSecurityProfile = addPhoneSecurityProfile1;
            AxlNetClient.addPhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).addPhoneSecurityProfile(inValue);
            return retVal.addPhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneSecurityProfileResponse> AxlNetClient.AXLPort37.addPhoneSecurityProfileAsync(AxlNetClient.addPhoneSecurityProfileRequest request)
        {
            return base.Channel.addPhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneSecurityProfileResponse> addPhoneSecurityProfileAsync(AxlNetClient.AddPhoneSecurityProfileReq addPhoneSecurityProfile)
        {
            AxlNetClient.addPhoneSecurityProfileRequest inValue = new AxlNetClient.addPhoneSecurityProfileRequest();
            inValue.addPhoneSecurityProfile = addPhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).addPhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePhoneSecurityProfileResponse AxlNetClient.AXLPort37.updatePhoneSecurityProfile(AxlNetClient.updatePhoneSecurityProfileRequest request)
        {
            return base.Channel.updatePhoneSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse updatePhoneSecurityProfile(AxlNetClient.UpdatePhoneSecurityProfileReq updatePhoneSecurityProfile1)
        {
            AxlNetClient.updatePhoneSecurityProfileRequest inValue = new AxlNetClient.updatePhoneSecurityProfileRequest();
            inValue.updatePhoneSecurityProfile = updatePhoneSecurityProfile1;
            AxlNetClient.updatePhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).updatePhoneSecurityProfile(inValue);
            return retVal.updatePhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneSecurityProfileResponse> AxlNetClient.AXLPort37.updatePhoneSecurityProfileAsync(AxlNetClient.updatePhoneSecurityProfileRequest request)
        {
            return base.Channel.updatePhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneSecurityProfileResponse> updatePhoneSecurityProfileAsync(AxlNetClient.UpdatePhoneSecurityProfileReq updatePhoneSecurityProfile)
        {
            AxlNetClient.updatePhoneSecurityProfileRequest inValue = new AxlNetClient.updatePhoneSecurityProfileRequest();
            inValue.updatePhoneSecurityProfile = updatePhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).updatePhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneSecurityProfileResponse AxlNetClient.AXLPort37.getPhoneSecurityProfile(AxlNetClient.getPhoneSecurityProfileRequest request)
        {
            return base.Channel.getPhoneSecurityProfile(request);
        }

        public AxlNetClient.GetPhoneSecurityProfileRes getPhoneSecurityProfile(AxlNetClient.GetPhoneSecurityProfileReq getPhoneSecurityProfile1)
        {
            AxlNetClient.getPhoneSecurityProfileRequest inValue = new AxlNetClient.getPhoneSecurityProfileRequest();
            inValue.getPhoneSecurityProfile = getPhoneSecurityProfile1;
            AxlNetClient.getPhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).getPhoneSecurityProfile(inValue);
            return retVal.getPhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneSecurityProfileResponse> AxlNetClient.AXLPort37.getPhoneSecurityProfileAsync(AxlNetClient.getPhoneSecurityProfileRequest request)
        {
            return base.Channel.getPhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneSecurityProfileResponse> getPhoneSecurityProfileAsync(AxlNetClient.GetPhoneSecurityProfileReq getPhoneSecurityProfile)
        {
            AxlNetClient.getPhoneSecurityProfileRequest inValue = new AxlNetClient.getPhoneSecurityProfileRequest();
            inValue.getPhoneSecurityProfile = getPhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).getPhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePhoneSecurityProfileResponse AxlNetClient.AXLPort37.removePhoneSecurityProfile(AxlNetClient.removePhoneSecurityProfileRequest request)
        {
            return base.Channel.removePhoneSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse removePhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest removePhoneSecurityProfile1)
        {
            AxlNetClient.removePhoneSecurityProfileRequest inValue = new AxlNetClient.removePhoneSecurityProfileRequest();
            inValue.removePhoneSecurityProfile = removePhoneSecurityProfile1;
            AxlNetClient.removePhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).removePhoneSecurityProfile(inValue);
            return retVal.removePhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneSecurityProfileResponse> AxlNetClient.AXLPort37.removePhoneSecurityProfileAsync(AxlNetClient.removePhoneSecurityProfileRequest request)
        {
            return base.Channel.removePhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneSecurityProfileResponse> removePhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removePhoneSecurityProfile)
        {
            AxlNetClient.removePhoneSecurityProfileRequest inValue = new AxlNetClient.removePhoneSecurityProfileRequest();
            inValue.removePhoneSecurityProfile = removePhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).removePhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPhoneSecurityProfileResponse AxlNetClient.AXLPort37.listPhoneSecurityProfile(AxlNetClient.listPhoneSecurityProfileRequest request)
        {
            return base.Channel.listPhoneSecurityProfile(request);
        }

        public AxlNetClient.ListPhoneSecurityProfileRes listPhoneSecurityProfile(AxlNetClient.ListPhoneSecurityProfileReq listPhoneSecurityProfile1)
        {
            AxlNetClient.listPhoneSecurityProfileRequest inValue = new AxlNetClient.listPhoneSecurityProfileRequest();
            inValue.listPhoneSecurityProfile = listPhoneSecurityProfile1;
            AxlNetClient.listPhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).listPhoneSecurityProfile(inValue);
            return retVal.listPhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneSecurityProfileResponse> AxlNetClient.AXLPort37.listPhoneSecurityProfileAsync(AxlNetClient.listPhoneSecurityProfileRequest request)
        {
            return base.Channel.listPhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneSecurityProfileResponse> listPhoneSecurityProfileAsync(AxlNetClient.ListPhoneSecurityProfileReq listPhoneSecurityProfile)
        {
            AxlNetClient.listPhoneSecurityProfileRequest inValue = new AxlNetClient.listPhoneSecurityProfileRequest();
            inValue.listPhoneSecurityProfile = listPhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).listPhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetPhoneSecurityProfileResponse AxlNetClient.AXLPort37.resetPhoneSecurityProfile(AxlNetClient.resetPhoneSecurityProfileRequest request)
        {
            return base.Channel.resetPhoneSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse resetPhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest resetPhoneSecurityProfile1)
        {
            AxlNetClient.resetPhoneSecurityProfileRequest inValue = new AxlNetClient.resetPhoneSecurityProfileRequest();
            inValue.resetPhoneSecurityProfile = resetPhoneSecurityProfile1;
            AxlNetClient.resetPhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).resetPhoneSecurityProfile(inValue);
            return retVal.resetPhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetPhoneSecurityProfileResponse> AxlNetClient.AXLPort37.resetPhoneSecurityProfileAsync(AxlNetClient.resetPhoneSecurityProfileRequest request)
        {
            return base.Channel.resetPhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetPhoneSecurityProfileResponse> resetPhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest resetPhoneSecurityProfile)
        {
            AxlNetClient.resetPhoneSecurityProfileRequest inValue = new AxlNetClient.resetPhoneSecurityProfileRequest();
            inValue.resetPhoneSecurityProfile = resetPhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).resetPhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyPhoneSecurityProfileResponse AxlNetClient.AXLPort37.applyPhoneSecurityProfile(AxlNetClient.applyPhoneSecurityProfileRequest request)
        {
            return base.Channel.applyPhoneSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse applyPhoneSecurityProfile(AxlNetClient.NameAndGUIDRequest applyPhoneSecurityProfile1)
        {
            AxlNetClient.applyPhoneSecurityProfileRequest inValue = new AxlNetClient.applyPhoneSecurityProfileRequest();
            inValue.applyPhoneSecurityProfile = applyPhoneSecurityProfile1;
            AxlNetClient.applyPhoneSecurityProfileResponse retVal = ((AxlNetClient.AXLPort37)(this)).applyPhoneSecurityProfile(inValue);
            return retVal.applyPhoneSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneSecurityProfileResponse> AxlNetClient.AXLPort37.applyPhoneSecurityProfileAsync(AxlNetClient.applyPhoneSecurityProfileRequest request)
        {
            return base.Channel.applyPhoneSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneSecurityProfileResponse> applyPhoneSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest applyPhoneSecurityProfile)
        {
            AxlNetClient.applyPhoneSecurityProfileRequest inValue = new AxlNetClient.applyPhoneSecurityProfileRequest();
            inValue.applyPhoneSecurityProfile = applyPhoneSecurityProfile;
            return ((AxlNetClient.AXLPort37)(this)).applyPhoneSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipDialRulesResponse AxlNetClient.AXLPort37.addSipDialRules(AxlNetClient.addSipDialRulesRequest request)
        {
            return base.Channel.addSipDialRules(request);
        }

        public AxlNetClient.StandardResponse addSipDialRules(AxlNetClient.AddSipDialRulesReq addSipDialRules1)
        {
            AxlNetClient.addSipDialRulesRequest inValue = new AxlNetClient.addSipDialRulesRequest();
            inValue.addSipDialRules = addSipDialRules1;
            AxlNetClient.addSipDialRulesResponse retVal = ((AxlNetClient.AXLPort37)(this)).addSipDialRules(inValue);
            return retVal.addSipDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipDialRulesResponse> AxlNetClient.AXLPort37.addSipDialRulesAsync(AxlNetClient.addSipDialRulesRequest request)
        {
            return base.Channel.addSipDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipDialRulesResponse> addSipDialRulesAsync(AxlNetClient.AddSipDialRulesReq addSipDialRules)
        {
            AxlNetClient.addSipDialRulesRequest inValue = new AxlNetClient.addSipDialRulesRequest();
            inValue.addSipDialRules = addSipDialRules;
            return ((AxlNetClient.AXLPort37)(this)).addSipDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipDialRulesResponse AxlNetClient.AXLPort37.updateSipDialRules(AxlNetClient.updateSipDialRulesRequest request)
        {
            return base.Channel.updateSipDialRules(request);
        }

        public AxlNetClient.StandardResponse updateSipDialRules(AxlNetClient.UpdateSipDialRulesReq updateSipDialRules1)
        {
            AxlNetClient.updateSipDialRulesRequest inValue = new AxlNetClient.updateSipDialRulesRequest();
            inValue.updateSipDialRules = updateSipDialRules1;
            AxlNetClient.updateSipDialRulesResponse retVal = ((AxlNetClient.AXLPort37)(this)).updateSipDialRules(inValue);
            return retVal.updateSipDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipDialRulesResponse> AxlNetClient.AXLPort37.updateSipDialRulesAsync(AxlNetClient.updateSipDialRulesRequest request)
        {
            return base.Channel.updateSipDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipDialRulesResponse> updateSipDialRulesAsync(AxlNetClient.UpdateSipDialRulesReq updateSipDialRules)
        {
            AxlNetClient.updateSipDialRulesRequest inValue = new AxlNetClient.updateSipDialRulesRequest();
            inValue.updateSipDialRules = updateSipDialRules;
            return ((AxlNetClient.AXLPort37)(this)).updateSipDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipDialRulesResponse AxlNetClient.AXLPort37.getSipDialRules(AxlNetClient.getSipDialRulesRequest request)
        {
            return base.Channel.getSipDialRules(request);
        }

        public AxlNetClient.GetSipDialRulesRes getSipDialRules(AxlNetClient.GetSipDialRulesReq getSipDialRules1)
        {
            AxlNetClient.getSipDialRulesRequest inValue = new AxlNetClient.getSipDialRulesRequest();
            inValue.getSipDialRules = getSipDialRules1;
            AxlNetClient.getSipDialRulesResponse retVal = ((AxlNetClient.AXLPort37)(this)).getSipDialRules(inValue);
            return retVal.getSipDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipDialRulesResponse> AxlNetClient.AXLPort37.getSipDialRulesAsync(AxlNetClient.getSipDialRulesRequest request)
        {
            return base.Channel.getSipDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipDialRulesResponse> getSipDialRulesAsync(AxlNetClient.GetSipDialRulesReq getSipDialRules)
        {
            AxlNetClient.getSipDialRulesRequest inValue = new AxlNetClient.getSipDialRulesRequest();
            inValue.getSipDialRules = getSipDialRules;
            return ((AxlNetClient.AXLPort37)(this)).getSipDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipDialRulesResponse AxlNetClient.AXLPort37.removeSipDialRules(AxlNetClient.removeSipDialRulesRequest request)
        {
            return base.Channel.removeSipDialRules(request);
        }

        public AxlNetClient.StandardResponse removeSipDialRules(AxlNetClient.NameAndGUIDRequest removeSipDialRules1)
        {
            AxlNetClient.removeSipDialRulesRequest inValue = new AxlNetClient.removeSipDialRulesRequest();
            inValue.removeSipDialRules = removeSipDialRules1;
            AxlNetClient.removeSipDialRulesResponse retVal = ((AxlNetClient.AXLPort37)(this)).removeSipDialRules(inValue);
            return retVal.removeSipDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipDialRulesResponse> AxlNetClient.AXLPort37.removeSipDialRulesAsync(AxlNetClient.removeSipDialRulesRequest request)
        {
            return base.Channel.removeSipDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipDialRulesResponse> removeSipDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeSipDialRules)
        {
            AxlNetClient.removeSipDialRulesRequest inValue = new AxlNetClient.removeSipDialRulesRequest();
            inValue.removeSipDialRules = removeSipDialRules;
            return ((AxlNetClient.AXLPort37)(this)).removeSipDialRulesAsync(inValue);
        }
    }
}