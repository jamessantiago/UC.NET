namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient52 _axlPortClient52;

        private static AXLPortClient52 axlPortClient52 => _axlPortClient52 == null ||
            _axlPortClient52.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient52 = LoadClient52()) : _axlPortClient52;

        private static AXLPortClient52 LoadClient52()
        {
            var client = new AXLPortClient52(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close52;
            OnAbort += Abort52;
            return client;
        }

        private static void Close52(object sender, System.EventArgs e)
        {
            _axlPortClient52.Close();
        }

        private static void Abort52(object sender, System.EventArgs e)
        {
            _axlPortClient52.Abort();
        }

        public AxlNetClient.StandardResponse addCalledPartyTransformationPattern(AxlNetClient.AddCalledPartyTransformationPatternReq addCalledPartyTransformationPattern1)
        {
            return axlPortClient52.addCalledPartyTransformationPattern(addCalledPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTransformationPatternResponse> addCalledPartyTransformationPatternAsync(AxlNetClient.AddCalledPartyTransformationPatternReq addCalledPartyTransformationPattern)
        {
            return axlPortClient52.addCalledPartyTransformationPatternAsync(addCalledPartyTransformationPattern);
        }

        public AxlNetClient.StandardResponse updateCalledPartyTransformationPattern(AxlNetClient.UpdateCalledPartyTransformationPatternReq updateCalledPartyTransformationPattern1)
        {
            return axlPortClient52.updateCalledPartyTransformationPattern(updateCalledPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCalledPartyTransformationPatternResponse> updateCalledPartyTransformationPatternAsync(AxlNetClient.UpdateCalledPartyTransformationPatternReq updateCalledPartyTransformationPattern)
        {
            return axlPortClient52.updateCalledPartyTransformationPatternAsync(updateCalledPartyTransformationPattern);
        }

        public AxlNetClient.GetCalledPartyTransformationPatternRes getCalledPartyTransformationPattern(AxlNetClient.GetCalledPartyTransformationPatternReq getCalledPartyTransformationPattern1)
        {
            return axlPortClient52.getCalledPartyTransformationPattern(getCalledPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCalledPartyTransformationPatternResponse> getCalledPartyTransformationPatternAsync(AxlNetClient.GetCalledPartyTransformationPatternReq getCalledPartyTransformationPattern)
        {
            return axlPortClient52.getCalledPartyTransformationPatternAsync(getCalledPartyTransformationPattern);
        }

        public AxlNetClient.StandardResponse removeCalledPartyTransformationPattern(AxlNetClient.RemoveCalledPartyTransformationPatternReq removeCalledPartyTransformationPattern1)
        {
            return axlPortClient52.removeCalledPartyTransformationPattern(removeCalledPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTransformationPatternResponse> removeCalledPartyTransformationPatternAsync(AxlNetClient.RemoveCalledPartyTransformationPatternReq removeCalledPartyTransformationPattern)
        {
            return axlPortClient52.removeCalledPartyTransformationPatternAsync(removeCalledPartyTransformationPattern);
        }

        public AxlNetClient.ListCalledPartyTransformationPatternRes listCalledPartyTransformationPattern(AxlNetClient.ListCalledPartyTransformationPatternReq listCalledPartyTransformationPattern1)
        {
            return axlPortClient52.listCalledPartyTransformationPattern(listCalledPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTransformationPatternResponse> listCalledPartyTransformationPatternAsync(AxlNetClient.ListCalledPartyTransformationPatternReq listCalledPartyTransformationPattern)
        {
            return axlPortClient52.listCalledPartyTransformationPatternAsync(listCalledPartyTransformationPattern);
        }

        public AxlNetClient.StandardResponse addExternalCallControlProfile(AxlNetClient.AddExternalCallControlProfileReq addExternalCallControlProfile1)
        {
            return axlPortClient52.addExternalCallControlProfile(addExternalCallControlProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addExternalCallControlProfileResponse> addExternalCallControlProfileAsync(AxlNetClient.AddExternalCallControlProfileReq addExternalCallControlProfile)
        {
            return axlPortClient52.addExternalCallControlProfileAsync(addExternalCallControlProfile);
        }

        public AxlNetClient.StandardResponse updateExternalCallControlProfile(AxlNetClient.UpdateExternalCallControlProfileReq updateExternalCallControlProfile1)
        {
            return axlPortClient52.updateExternalCallControlProfile(updateExternalCallControlProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateExternalCallControlProfileResponse> updateExternalCallControlProfileAsync(AxlNetClient.UpdateExternalCallControlProfileReq updateExternalCallControlProfile)
        {
            return axlPortClient52.updateExternalCallControlProfileAsync(updateExternalCallControlProfile);
        }

        public AxlNetClient.GetExternalCallControlProfileRes getExternalCallControlProfile(AxlNetClient.GetExternalCallControlProfileReq getExternalCallControlProfile1)
        {
            return axlPortClient52.getExternalCallControlProfile(getExternalCallControlProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getExternalCallControlProfileResponse> getExternalCallControlProfileAsync(AxlNetClient.GetExternalCallControlProfileReq getExternalCallControlProfile)
        {
            return axlPortClient52.getExternalCallControlProfileAsync(getExternalCallControlProfile);
        }

        public AxlNetClient.StandardResponse removeExternalCallControlProfile(AxlNetClient.NameAndGUIDRequest removeExternalCallControlProfile1)
        {
            return axlPortClient52.removeExternalCallControlProfile(removeExternalCallControlProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeExternalCallControlProfileResponse> removeExternalCallControlProfileAsync(AxlNetClient.NameAndGUIDRequest removeExternalCallControlProfile)
        {
            return axlPortClient52.removeExternalCallControlProfileAsync(removeExternalCallControlProfile);
        }

        public AxlNetClient.ListExternalCallControlProfileRes listExternalCallControlProfile(AxlNetClient.ListExternalCallControlProfileReq listExternalCallControlProfile1)
        {
            return axlPortClient52.listExternalCallControlProfile(listExternalCallControlProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listExternalCallControlProfileResponse> listExternalCallControlProfileAsync(AxlNetClient.ListExternalCallControlProfileReq listExternalCallControlProfile)
        {
            return axlPortClient52.listExternalCallControlProfileAsync(listExternalCallControlProfile);
        }

        public AxlNetClient.StandardResponse addSafSecurityProfile(AxlNetClient.AddSafSecurityProfileReq addSafSecurityProfile1)
        {
            return axlPortClient52.addSafSecurityProfile(addSafSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafSecurityProfileResponse> addSafSecurityProfileAsync(AxlNetClient.AddSafSecurityProfileReq addSafSecurityProfile)
        {
            return axlPortClient52.addSafSecurityProfileAsync(addSafSecurityProfile);
        }

        public AxlNetClient.StandardResponse updateSafSecurityProfile(AxlNetClient.UpdateSafSecurityProfileReq updateSafSecurityProfile1)
        {
            return axlPortClient52.updateSafSecurityProfile(updateSafSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafSecurityProfileResponse> updateSafSecurityProfileAsync(AxlNetClient.UpdateSafSecurityProfileReq updateSafSecurityProfile)
        {
            return axlPortClient52.updateSafSecurityProfileAsync(updateSafSecurityProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort52
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCalledPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCalledPartyTransformationPatternResponse addCalledPartyTransformationPattern(AxlNetClient.addCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCalledPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTransformationPatternResponse> addCalledPartyTransformationPatternAsync(AxlNetClient.addCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCalledPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCalledPartyTransformationPatternResponse updateCalledPartyTransformationPattern(AxlNetClient.updateCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCalledPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCalledPartyTransformationPatternResponse> updateCalledPartyTransformationPatternAsync(AxlNetClient.updateCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCalledPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCalledPartyTransformationPatternResponse getCalledPartyTransformationPattern(AxlNetClient.getCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCalledPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCalledPartyTransformationPatternResponse> getCalledPartyTransformationPatternAsync(AxlNetClient.getCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCalledPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCalledPartyTransformationPatternResponse removeCalledPartyTransformationPattern(AxlNetClient.removeCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCalledPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTransformationPatternResponse> removeCalledPartyTransformationPatternAsync(AxlNetClient.removeCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCalledPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCalledPartyTransformationPatternResponse listCalledPartyTransformationPattern(AxlNetClient.listCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCalledPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTransformationPatternResponse> listCalledPartyTransformationPatternAsync(AxlNetClient.listCalledPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addExternalCallControlProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addExternalCallControlProfileResponse addExternalCallControlProfile(AxlNetClient.addExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addExternalCallControlProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addExternalCallControlProfileResponse> addExternalCallControlProfileAsync(AxlNetClient.addExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateExternalCallControlProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateExternalCallControlProfileResponse updateExternalCallControlProfile(AxlNetClient.updateExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateExternalCallControlProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateExternalCallControlProfileResponse> updateExternalCallControlProfileAsync(AxlNetClient.updateExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getExternalCallControlProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getExternalCallControlProfileResponse getExternalCallControlProfile(AxlNetClient.getExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getExternalCallControlProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getExternalCallControlProfileResponse> getExternalCallControlProfileAsync(AxlNetClient.getExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeExternalCallControlProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeExternalCallControlProfileResponse removeExternalCallControlProfile(AxlNetClient.removeExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeExternalCallControlProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeExternalCallControlProfileResponse> removeExternalCallControlProfileAsync(AxlNetClient.removeExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listExternalCallControlProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listExternalCallControlProfileResponse listExternalCallControlProfile(AxlNetClient.listExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listExternalCallControlProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listExternalCallControlProfileResponse> listExternalCallControlProfileAsync(AxlNetClient.listExternalCallControlProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSafSecurityProfileResponse addSafSecurityProfile(AxlNetClient.addSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSafSecurityProfileResponse> addSafSecurityProfileAsync(AxlNetClient.addSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSafSecurityProfileResponse updateSafSecurityProfile(AxlNetClient.updateSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSafSecurityProfileResponse> updateSafSecurityProfileAsync(AxlNetClient.updateSafSecurityProfileRequest request);
    }

    public class AXLPortClient52 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort52>, AxlNetClient.AXLPort52
    {
        public AXLPortClient52(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCalledPartyTransformationPatternResponse AxlNetClient.AXLPort52.addCalledPartyTransformationPattern(AxlNetClient.addCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.addCalledPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse addCalledPartyTransformationPattern(AxlNetClient.AddCalledPartyTransformationPatternReq addCalledPartyTransformationPattern1)
        {
            AxlNetClient.addCalledPartyTransformationPatternRequest inValue = new AxlNetClient.addCalledPartyTransformationPatternRequest();
            inValue.addCalledPartyTransformationPattern = addCalledPartyTransformationPattern1;
            AxlNetClient.addCalledPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort52)(this)).addCalledPartyTransformationPattern(inValue);
            return retVal.addCalledPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTransformationPatternResponse> AxlNetClient.AXLPort52.addCalledPartyTransformationPatternAsync(AxlNetClient.addCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.addCalledPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTransformationPatternResponse> addCalledPartyTransformationPatternAsync(AxlNetClient.AddCalledPartyTransformationPatternReq addCalledPartyTransformationPattern)
        {
            AxlNetClient.addCalledPartyTransformationPatternRequest inValue = new AxlNetClient.addCalledPartyTransformationPatternRequest();
            inValue.addCalledPartyTransformationPattern = addCalledPartyTransformationPattern;
            return ((AxlNetClient.AXLPort52)(this)).addCalledPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCalledPartyTransformationPatternResponse AxlNetClient.AXLPort52.updateCalledPartyTransformationPattern(AxlNetClient.updateCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.updateCalledPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse updateCalledPartyTransformationPattern(AxlNetClient.UpdateCalledPartyTransformationPatternReq updateCalledPartyTransformationPattern1)
        {
            AxlNetClient.updateCalledPartyTransformationPatternRequest inValue = new AxlNetClient.updateCalledPartyTransformationPatternRequest();
            inValue.updateCalledPartyTransformationPattern = updateCalledPartyTransformationPattern1;
            AxlNetClient.updateCalledPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort52)(this)).updateCalledPartyTransformationPattern(inValue);
            return retVal.updateCalledPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCalledPartyTransformationPatternResponse> AxlNetClient.AXLPort52.updateCalledPartyTransformationPatternAsync(AxlNetClient.updateCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.updateCalledPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCalledPartyTransformationPatternResponse> updateCalledPartyTransformationPatternAsync(AxlNetClient.UpdateCalledPartyTransformationPatternReq updateCalledPartyTransformationPattern)
        {
            AxlNetClient.updateCalledPartyTransformationPatternRequest inValue = new AxlNetClient.updateCalledPartyTransformationPatternRequest();
            inValue.updateCalledPartyTransformationPattern = updateCalledPartyTransformationPattern;
            return ((AxlNetClient.AXLPort52)(this)).updateCalledPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCalledPartyTransformationPatternResponse AxlNetClient.AXLPort52.getCalledPartyTransformationPattern(AxlNetClient.getCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.getCalledPartyTransformationPattern(request);
        }

        public AxlNetClient.GetCalledPartyTransformationPatternRes getCalledPartyTransformationPattern(AxlNetClient.GetCalledPartyTransformationPatternReq getCalledPartyTransformationPattern1)
        {
            AxlNetClient.getCalledPartyTransformationPatternRequest inValue = new AxlNetClient.getCalledPartyTransformationPatternRequest();
            inValue.getCalledPartyTransformationPattern = getCalledPartyTransformationPattern1;
            AxlNetClient.getCalledPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort52)(this)).getCalledPartyTransformationPattern(inValue);
            return retVal.getCalledPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCalledPartyTransformationPatternResponse> AxlNetClient.AXLPort52.getCalledPartyTransformationPatternAsync(AxlNetClient.getCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.getCalledPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCalledPartyTransformationPatternResponse> getCalledPartyTransformationPatternAsync(AxlNetClient.GetCalledPartyTransformationPatternReq getCalledPartyTransformationPattern)
        {
            AxlNetClient.getCalledPartyTransformationPatternRequest inValue = new AxlNetClient.getCalledPartyTransformationPatternRequest();
            inValue.getCalledPartyTransformationPattern = getCalledPartyTransformationPattern;
            return ((AxlNetClient.AXLPort52)(this)).getCalledPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCalledPartyTransformationPatternResponse AxlNetClient.AXLPort52.removeCalledPartyTransformationPattern(AxlNetClient.removeCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.removeCalledPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse removeCalledPartyTransformationPattern(AxlNetClient.RemoveCalledPartyTransformationPatternReq removeCalledPartyTransformationPattern1)
        {
            AxlNetClient.removeCalledPartyTransformationPatternRequest inValue = new AxlNetClient.removeCalledPartyTransformationPatternRequest();
            inValue.removeCalledPartyTransformationPattern = removeCalledPartyTransformationPattern1;
            AxlNetClient.removeCalledPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort52)(this)).removeCalledPartyTransformationPattern(inValue);
            return retVal.removeCalledPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTransformationPatternResponse> AxlNetClient.AXLPort52.removeCalledPartyTransformationPatternAsync(AxlNetClient.removeCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.removeCalledPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTransformationPatternResponse> removeCalledPartyTransformationPatternAsync(AxlNetClient.RemoveCalledPartyTransformationPatternReq removeCalledPartyTransformationPattern)
        {
            AxlNetClient.removeCalledPartyTransformationPatternRequest inValue = new AxlNetClient.removeCalledPartyTransformationPatternRequest();
            inValue.removeCalledPartyTransformationPattern = removeCalledPartyTransformationPattern;
            return ((AxlNetClient.AXLPort52)(this)).removeCalledPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCalledPartyTransformationPatternResponse AxlNetClient.AXLPort52.listCalledPartyTransformationPattern(AxlNetClient.listCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.listCalledPartyTransformationPattern(request);
        }

        public AxlNetClient.ListCalledPartyTransformationPatternRes listCalledPartyTransformationPattern(AxlNetClient.ListCalledPartyTransformationPatternReq listCalledPartyTransformationPattern1)
        {
            AxlNetClient.listCalledPartyTransformationPatternRequest inValue = new AxlNetClient.listCalledPartyTransformationPatternRequest();
            inValue.listCalledPartyTransformationPattern = listCalledPartyTransformationPattern1;
            AxlNetClient.listCalledPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort52)(this)).listCalledPartyTransformationPattern(inValue);
            return retVal.listCalledPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTransformationPatternResponse> AxlNetClient.AXLPort52.listCalledPartyTransformationPatternAsync(AxlNetClient.listCalledPartyTransformationPatternRequest request)
        {
            return base.Channel.listCalledPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTransformationPatternResponse> listCalledPartyTransformationPatternAsync(AxlNetClient.ListCalledPartyTransformationPatternReq listCalledPartyTransformationPattern)
        {
            AxlNetClient.listCalledPartyTransformationPatternRequest inValue = new AxlNetClient.listCalledPartyTransformationPatternRequest();
            inValue.listCalledPartyTransformationPattern = listCalledPartyTransformationPattern;
            return ((AxlNetClient.AXLPort52)(this)).listCalledPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addExternalCallControlProfileResponse AxlNetClient.AXLPort52.addExternalCallControlProfile(AxlNetClient.addExternalCallControlProfileRequest request)
        {
            return base.Channel.addExternalCallControlProfile(request);
        }

        public AxlNetClient.StandardResponse addExternalCallControlProfile(AxlNetClient.AddExternalCallControlProfileReq addExternalCallControlProfile1)
        {
            AxlNetClient.addExternalCallControlProfileRequest inValue = new AxlNetClient.addExternalCallControlProfileRequest();
            inValue.addExternalCallControlProfile = addExternalCallControlProfile1;
            AxlNetClient.addExternalCallControlProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).addExternalCallControlProfile(inValue);
            return retVal.addExternalCallControlProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addExternalCallControlProfileResponse> AxlNetClient.AXLPort52.addExternalCallControlProfileAsync(AxlNetClient.addExternalCallControlProfileRequest request)
        {
            return base.Channel.addExternalCallControlProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addExternalCallControlProfileResponse> addExternalCallControlProfileAsync(AxlNetClient.AddExternalCallControlProfileReq addExternalCallControlProfile)
        {
            AxlNetClient.addExternalCallControlProfileRequest inValue = new AxlNetClient.addExternalCallControlProfileRequest();
            inValue.addExternalCallControlProfile = addExternalCallControlProfile;
            return ((AxlNetClient.AXLPort52)(this)).addExternalCallControlProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateExternalCallControlProfileResponse AxlNetClient.AXLPort52.updateExternalCallControlProfile(AxlNetClient.updateExternalCallControlProfileRequest request)
        {
            return base.Channel.updateExternalCallControlProfile(request);
        }

        public AxlNetClient.StandardResponse updateExternalCallControlProfile(AxlNetClient.UpdateExternalCallControlProfileReq updateExternalCallControlProfile1)
        {
            AxlNetClient.updateExternalCallControlProfileRequest inValue = new AxlNetClient.updateExternalCallControlProfileRequest();
            inValue.updateExternalCallControlProfile = updateExternalCallControlProfile1;
            AxlNetClient.updateExternalCallControlProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).updateExternalCallControlProfile(inValue);
            return retVal.updateExternalCallControlProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateExternalCallControlProfileResponse> AxlNetClient.AXLPort52.updateExternalCallControlProfileAsync(AxlNetClient.updateExternalCallControlProfileRequest request)
        {
            return base.Channel.updateExternalCallControlProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateExternalCallControlProfileResponse> updateExternalCallControlProfileAsync(AxlNetClient.UpdateExternalCallControlProfileReq updateExternalCallControlProfile)
        {
            AxlNetClient.updateExternalCallControlProfileRequest inValue = new AxlNetClient.updateExternalCallControlProfileRequest();
            inValue.updateExternalCallControlProfile = updateExternalCallControlProfile;
            return ((AxlNetClient.AXLPort52)(this)).updateExternalCallControlProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getExternalCallControlProfileResponse AxlNetClient.AXLPort52.getExternalCallControlProfile(AxlNetClient.getExternalCallControlProfileRequest request)
        {
            return base.Channel.getExternalCallControlProfile(request);
        }

        public AxlNetClient.GetExternalCallControlProfileRes getExternalCallControlProfile(AxlNetClient.GetExternalCallControlProfileReq getExternalCallControlProfile1)
        {
            AxlNetClient.getExternalCallControlProfileRequest inValue = new AxlNetClient.getExternalCallControlProfileRequest();
            inValue.getExternalCallControlProfile = getExternalCallControlProfile1;
            AxlNetClient.getExternalCallControlProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).getExternalCallControlProfile(inValue);
            return retVal.getExternalCallControlProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getExternalCallControlProfileResponse> AxlNetClient.AXLPort52.getExternalCallControlProfileAsync(AxlNetClient.getExternalCallControlProfileRequest request)
        {
            return base.Channel.getExternalCallControlProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getExternalCallControlProfileResponse> getExternalCallControlProfileAsync(AxlNetClient.GetExternalCallControlProfileReq getExternalCallControlProfile)
        {
            AxlNetClient.getExternalCallControlProfileRequest inValue = new AxlNetClient.getExternalCallControlProfileRequest();
            inValue.getExternalCallControlProfile = getExternalCallControlProfile;
            return ((AxlNetClient.AXLPort52)(this)).getExternalCallControlProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeExternalCallControlProfileResponse AxlNetClient.AXLPort52.removeExternalCallControlProfile(AxlNetClient.removeExternalCallControlProfileRequest request)
        {
            return base.Channel.removeExternalCallControlProfile(request);
        }

        public AxlNetClient.StandardResponse removeExternalCallControlProfile(AxlNetClient.NameAndGUIDRequest removeExternalCallControlProfile1)
        {
            AxlNetClient.removeExternalCallControlProfileRequest inValue = new AxlNetClient.removeExternalCallControlProfileRequest();
            inValue.removeExternalCallControlProfile = removeExternalCallControlProfile1;
            AxlNetClient.removeExternalCallControlProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).removeExternalCallControlProfile(inValue);
            return retVal.removeExternalCallControlProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeExternalCallControlProfileResponse> AxlNetClient.AXLPort52.removeExternalCallControlProfileAsync(AxlNetClient.removeExternalCallControlProfileRequest request)
        {
            return base.Channel.removeExternalCallControlProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeExternalCallControlProfileResponse> removeExternalCallControlProfileAsync(AxlNetClient.NameAndGUIDRequest removeExternalCallControlProfile)
        {
            AxlNetClient.removeExternalCallControlProfileRequest inValue = new AxlNetClient.removeExternalCallControlProfileRequest();
            inValue.removeExternalCallControlProfile = removeExternalCallControlProfile;
            return ((AxlNetClient.AXLPort52)(this)).removeExternalCallControlProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listExternalCallControlProfileResponse AxlNetClient.AXLPort52.listExternalCallControlProfile(AxlNetClient.listExternalCallControlProfileRequest request)
        {
            return base.Channel.listExternalCallControlProfile(request);
        }

        public AxlNetClient.ListExternalCallControlProfileRes listExternalCallControlProfile(AxlNetClient.ListExternalCallControlProfileReq listExternalCallControlProfile1)
        {
            AxlNetClient.listExternalCallControlProfileRequest inValue = new AxlNetClient.listExternalCallControlProfileRequest();
            inValue.listExternalCallControlProfile = listExternalCallControlProfile1;
            AxlNetClient.listExternalCallControlProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).listExternalCallControlProfile(inValue);
            return retVal.listExternalCallControlProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listExternalCallControlProfileResponse> AxlNetClient.AXLPort52.listExternalCallControlProfileAsync(AxlNetClient.listExternalCallControlProfileRequest request)
        {
            return base.Channel.listExternalCallControlProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listExternalCallControlProfileResponse> listExternalCallControlProfileAsync(AxlNetClient.ListExternalCallControlProfileReq listExternalCallControlProfile)
        {
            AxlNetClient.listExternalCallControlProfileRequest inValue = new AxlNetClient.listExternalCallControlProfileRequest();
            inValue.listExternalCallControlProfile = listExternalCallControlProfile;
            return ((AxlNetClient.AXLPort52)(this)).listExternalCallControlProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSafSecurityProfileResponse AxlNetClient.AXLPort52.addSafSecurityProfile(AxlNetClient.addSafSecurityProfileRequest request)
        {
            return base.Channel.addSafSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse addSafSecurityProfile(AxlNetClient.AddSafSecurityProfileReq addSafSecurityProfile1)
        {
            AxlNetClient.addSafSecurityProfileRequest inValue = new AxlNetClient.addSafSecurityProfileRequest();
            inValue.addSafSecurityProfile = addSafSecurityProfile1;
            AxlNetClient.addSafSecurityProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).addSafSecurityProfile(inValue);
            return retVal.addSafSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSafSecurityProfileResponse> AxlNetClient.AXLPort52.addSafSecurityProfileAsync(AxlNetClient.addSafSecurityProfileRequest request)
        {
            return base.Channel.addSafSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafSecurityProfileResponse> addSafSecurityProfileAsync(AxlNetClient.AddSafSecurityProfileReq addSafSecurityProfile)
        {
            AxlNetClient.addSafSecurityProfileRequest inValue = new AxlNetClient.addSafSecurityProfileRequest();
            inValue.addSafSecurityProfile = addSafSecurityProfile;
            return ((AxlNetClient.AXLPort52)(this)).addSafSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSafSecurityProfileResponse AxlNetClient.AXLPort52.updateSafSecurityProfile(AxlNetClient.updateSafSecurityProfileRequest request)
        {
            return base.Channel.updateSafSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse updateSafSecurityProfile(AxlNetClient.UpdateSafSecurityProfileReq updateSafSecurityProfile1)
        {
            AxlNetClient.updateSafSecurityProfileRequest inValue = new AxlNetClient.updateSafSecurityProfileRequest();
            inValue.updateSafSecurityProfile = updateSafSecurityProfile1;
            AxlNetClient.updateSafSecurityProfileResponse retVal = ((AxlNetClient.AXLPort52)(this)).updateSafSecurityProfile(inValue);
            return retVal.updateSafSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSafSecurityProfileResponse> AxlNetClient.AXLPort52.updateSafSecurityProfileAsync(AxlNetClient.updateSafSecurityProfileRequest request)
        {
            return base.Channel.updateSafSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafSecurityProfileResponse> updateSafSecurityProfileAsync(AxlNetClient.UpdateSafSecurityProfileReq updateSafSecurityProfile)
        {
            AxlNetClient.updateSafSecurityProfileRequest inValue = new AxlNetClient.updateSafSecurityProfileRequest();
            inValue.updateSafSecurityProfile = updateSafSecurityProfile;
            return ((AxlNetClient.AXLPort52)(this)).updateSafSecurityProfileAsync(inValue);
        }
    }
}