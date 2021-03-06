namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient16 _axlPortClient16;

        private static AXLPortClient16 axlPortClient16 => _axlPortClient16 == null ||
            _axlPortClient16.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient16 = LoadClient16()) : _axlPortClient16;

        private static AXLPortClient16 LoadClient16()
        {
            var client = new AXLPortClient16(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close16;
            OnAbort += Abort16;
            return client;
        }

        private static void Close16(object sender, System.EventArgs e)
        {
            _axlPortClient16.Close();
        }

        private static void Abort16(object sender, System.EventArgs e)
        {
            _axlPortClient16.Abort();
        }

        public AxlNetClient.StandardResponse removeIvrUserLocale(AxlNetClient.RemoveIvrUserLocaleReq removeIvrUserLocale1)
        {
            return axlPortClient16.removeIvrUserLocale(removeIvrUserLocale1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeIvrUserLocaleResponse> removeIvrUserLocaleAsync(AxlNetClient.RemoveIvrUserLocaleReq removeIvrUserLocale)
        {
            return axlPortClient16.removeIvrUserLocaleAsync(removeIvrUserLocale);
        }

        public AxlNetClient.ListIvrUserLocaleRes listIvrUserLocale(AxlNetClient.ListIvrUserLocaleReq listIvrUserLocale1)
        {
            return axlPortClient16.listIvrUserLocale(listIvrUserLocale1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listIvrUserLocaleResponse> listIvrUserLocaleAsync(AxlNetClient.ListIvrUserLocaleReq listIvrUserLocale)
        {
            return axlPortClient16.listIvrUserLocaleAsync(listIvrUserLocale);
        }

        public AxlNetClient.StandardResponse addLineGroup(AxlNetClient.AddLineGroupReq addLineGroup1)
        {
            return axlPortClient16.addLineGroup(addLineGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLineGroupResponse> addLineGroupAsync(AxlNetClient.AddLineGroupReq addLineGroup)
        {
            return axlPortClient16.addLineGroupAsync(addLineGroup);
        }

        public AxlNetClient.StandardResponse updateLineGroup(AxlNetClient.UpdateLineGroupReq updateLineGroup1)
        {
            return axlPortClient16.updateLineGroup(updateLineGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLineGroupResponse> updateLineGroupAsync(AxlNetClient.UpdateLineGroupReq updateLineGroup)
        {
            return axlPortClient16.updateLineGroupAsync(updateLineGroup);
        }

        public AxlNetClient.GetLineGroupRes getLineGroup(AxlNetClient.GetLineGroupReq getLineGroup1)
        {
            return axlPortClient16.getLineGroup(getLineGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineGroupResponse> getLineGroupAsync(AxlNetClient.GetLineGroupReq getLineGroup)
        {
            return axlPortClient16.getLineGroupAsync(getLineGroup);
        }

        public AxlNetClient.StandardResponse removeLineGroup(AxlNetClient.NameAndGUIDRequest removeLineGroup1)
        {
            return axlPortClient16.removeLineGroup(removeLineGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLineGroupResponse> removeLineGroupAsync(AxlNetClient.NameAndGUIDRequest removeLineGroup)
        {
            return axlPortClient16.removeLineGroupAsync(removeLineGroup);
        }

        public AxlNetClient.ListLineGroupRes listLineGroup(AxlNetClient.ListLineGroupReq listLineGroup1)
        {
            return axlPortClient16.listLineGroup(listLineGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLineGroupResponse> listLineGroupAsync(AxlNetClient.ListLineGroupReq listLineGroup)
        {
            return axlPortClient16.listLineGroupAsync(listLineGroup);
        }

        public AxlNetClient.StandardResponse addRecordingProfile(AxlNetClient.AddRecordingProfileReq addRecordingProfile1)
        {
            return axlPortClient16.addRecordingProfile(addRecordingProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRecordingProfileResponse> addRecordingProfileAsync(AxlNetClient.AddRecordingProfileReq addRecordingProfile)
        {
            return axlPortClient16.addRecordingProfileAsync(addRecordingProfile);
        }

        public AxlNetClient.StandardResponse updateRecordingProfile(AxlNetClient.UpdateRecordingProfileReq updateRecordingProfile1)
        {
            return axlPortClient16.updateRecordingProfile(updateRecordingProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRecordingProfileResponse> updateRecordingProfileAsync(AxlNetClient.UpdateRecordingProfileReq updateRecordingProfile)
        {
            return axlPortClient16.updateRecordingProfileAsync(updateRecordingProfile);
        }

        public AxlNetClient.GetRecordingProfileRes getRecordingProfile(AxlNetClient.GetRecordingProfileReq getRecordingProfile1)
        {
            return axlPortClient16.getRecordingProfile(getRecordingProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRecordingProfileResponse> getRecordingProfileAsync(AxlNetClient.GetRecordingProfileReq getRecordingProfile)
        {
            return axlPortClient16.getRecordingProfileAsync(getRecordingProfile);
        }

        public AxlNetClient.StandardResponse removeRecordingProfile(AxlNetClient.NameAndGUIDRequest removeRecordingProfile1)
        {
            return axlPortClient16.removeRecordingProfile(removeRecordingProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRecordingProfileResponse> removeRecordingProfileAsync(AxlNetClient.NameAndGUIDRequest removeRecordingProfile)
        {
            return axlPortClient16.removeRecordingProfileAsync(removeRecordingProfile);
        }

        public AxlNetClient.ListRecordingProfileRes listRecordingProfile(AxlNetClient.ListRecordingProfileReq listRecordingProfile1)
        {
            return axlPortClient16.listRecordingProfile(listRecordingProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRecordingProfileResponse> listRecordingProfileAsync(AxlNetClient.ListRecordingProfileReq listRecordingProfile)
        {
            return axlPortClient16.listRecordingProfileAsync(listRecordingProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort16
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeIvrUserLocale", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeIvrUserLocaleResponse removeIvrUserLocale(AxlNetClient.removeIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeIvrUserLocale", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeIvrUserLocaleResponse> removeIvrUserLocaleAsync(AxlNetClient.removeIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listIvrUserLocale", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listIvrUserLocaleResponse listIvrUserLocale(AxlNetClient.listIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listIvrUserLocale", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listIvrUserLocaleResponse> listIvrUserLocaleAsync(AxlNetClient.listIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLineGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLineGroupResponse addLineGroup(AxlNetClient.addLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLineGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLineGroupResponse> addLineGroupAsync(AxlNetClient.addLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLineGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLineGroupResponse updateLineGroup(AxlNetClient.updateLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLineGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLineGroupResponse> updateLineGroupAsync(AxlNetClient.updateLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLineGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLineGroupResponse getLineGroup(AxlNetClient.getLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLineGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLineGroupResponse> getLineGroupAsync(AxlNetClient.getLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLineGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLineGroupResponse removeLineGroup(AxlNetClient.removeLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLineGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLineGroupResponse> removeLineGroupAsync(AxlNetClient.removeLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLineGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLineGroupResponse listLineGroup(AxlNetClient.listLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLineGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLineGroupResponse> listLineGroupAsync(AxlNetClient.listLineGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRecordingProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRecordingProfileResponse addRecordingProfile(AxlNetClient.addRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRecordingProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRecordingProfileResponse> addRecordingProfileAsync(AxlNetClient.addRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRecordingProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRecordingProfileResponse updateRecordingProfile(AxlNetClient.updateRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRecordingProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRecordingProfileResponse> updateRecordingProfileAsync(AxlNetClient.updateRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRecordingProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRecordingProfileResponse getRecordingProfile(AxlNetClient.getRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRecordingProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRecordingProfileResponse> getRecordingProfileAsync(AxlNetClient.getRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRecordingProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRecordingProfileResponse removeRecordingProfile(AxlNetClient.removeRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRecordingProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRecordingProfileResponse> removeRecordingProfileAsync(AxlNetClient.removeRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRecordingProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRecordingProfileResponse listRecordingProfile(AxlNetClient.listRecordingProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRecordingProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRecordingProfileResponse> listRecordingProfileAsync(AxlNetClient.listRecordingProfileRequest request);
    }

    public class AXLPortClient16 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort16>, AxlNetClient.AXLPort16
    {
        public AXLPortClient16(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeIvrUserLocaleResponse AxlNetClient.AXLPort16.removeIvrUserLocale(AxlNetClient.removeIvrUserLocaleRequest request)
        {
            return base.Channel.removeIvrUserLocale(request);
        }

        public AxlNetClient.StandardResponse removeIvrUserLocale(AxlNetClient.RemoveIvrUserLocaleReq removeIvrUserLocale1)
        {
            AxlNetClient.removeIvrUserLocaleRequest inValue = new AxlNetClient.removeIvrUserLocaleRequest();
            inValue.removeIvrUserLocale = removeIvrUserLocale1;
            AxlNetClient.removeIvrUserLocaleResponse retVal = ((AxlNetClient.AXLPort16)(this)).removeIvrUserLocale(inValue);
            return retVal.removeIvrUserLocaleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeIvrUserLocaleResponse> AxlNetClient.AXLPort16.removeIvrUserLocaleAsync(AxlNetClient.removeIvrUserLocaleRequest request)
        {
            return base.Channel.removeIvrUserLocaleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeIvrUserLocaleResponse> removeIvrUserLocaleAsync(AxlNetClient.RemoveIvrUserLocaleReq removeIvrUserLocale)
        {
            AxlNetClient.removeIvrUserLocaleRequest inValue = new AxlNetClient.removeIvrUserLocaleRequest();
            inValue.removeIvrUserLocale = removeIvrUserLocale;
            return ((AxlNetClient.AXLPort16)(this)).removeIvrUserLocaleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listIvrUserLocaleResponse AxlNetClient.AXLPort16.listIvrUserLocale(AxlNetClient.listIvrUserLocaleRequest request)
        {
            return base.Channel.listIvrUserLocale(request);
        }

        public AxlNetClient.ListIvrUserLocaleRes listIvrUserLocale(AxlNetClient.ListIvrUserLocaleReq listIvrUserLocale1)
        {
            AxlNetClient.listIvrUserLocaleRequest inValue = new AxlNetClient.listIvrUserLocaleRequest();
            inValue.listIvrUserLocale = listIvrUserLocale1;
            AxlNetClient.listIvrUserLocaleResponse retVal = ((AxlNetClient.AXLPort16)(this)).listIvrUserLocale(inValue);
            return retVal.listIvrUserLocaleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listIvrUserLocaleResponse> AxlNetClient.AXLPort16.listIvrUserLocaleAsync(AxlNetClient.listIvrUserLocaleRequest request)
        {
            return base.Channel.listIvrUserLocaleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listIvrUserLocaleResponse> listIvrUserLocaleAsync(AxlNetClient.ListIvrUserLocaleReq listIvrUserLocale)
        {
            AxlNetClient.listIvrUserLocaleRequest inValue = new AxlNetClient.listIvrUserLocaleRequest();
            inValue.listIvrUserLocale = listIvrUserLocale;
            return ((AxlNetClient.AXLPort16)(this)).listIvrUserLocaleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLineGroupResponse AxlNetClient.AXLPort16.addLineGroup(AxlNetClient.addLineGroupRequest request)
        {
            return base.Channel.addLineGroup(request);
        }

        public AxlNetClient.StandardResponse addLineGroup(AxlNetClient.AddLineGroupReq addLineGroup1)
        {
            AxlNetClient.addLineGroupRequest inValue = new AxlNetClient.addLineGroupRequest();
            inValue.addLineGroup = addLineGroup1;
            AxlNetClient.addLineGroupResponse retVal = ((AxlNetClient.AXLPort16)(this)).addLineGroup(inValue);
            return retVal.addLineGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLineGroupResponse> AxlNetClient.AXLPort16.addLineGroupAsync(AxlNetClient.addLineGroupRequest request)
        {
            return base.Channel.addLineGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLineGroupResponse> addLineGroupAsync(AxlNetClient.AddLineGroupReq addLineGroup)
        {
            AxlNetClient.addLineGroupRequest inValue = new AxlNetClient.addLineGroupRequest();
            inValue.addLineGroup = addLineGroup;
            return ((AxlNetClient.AXLPort16)(this)).addLineGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLineGroupResponse AxlNetClient.AXLPort16.updateLineGroup(AxlNetClient.updateLineGroupRequest request)
        {
            return base.Channel.updateLineGroup(request);
        }

        public AxlNetClient.StandardResponse updateLineGroup(AxlNetClient.UpdateLineGroupReq updateLineGroup1)
        {
            AxlNetClient.updateLineGroupRequest inValue = new AxlNetClient.updateLineGroupRequest();
            inValue.updateLineGroup = updateLineGroup1;
            AxlNetClient.updateLineGroupResponse retVal = ((AxlNetClient.AXLPort16)(this)).updateLineGroup(inValue);
            return retVal.updateLineGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLineGroupResponse> AxlNetClient.AXLPort16.updateLineGroupAsync(AxlNetClient.updateLineGroupRequest request)
        {
            return base.Channel.updateLineGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLineGroupResponse> updateLineGroupAsync(AxlNetClient.UpdateLineGroupReq updateLineGroup)
        {
            AxlNetClient.updateLineGroupRequest inValue = new AxlNetClient.updateLineGroupRequest();
            inValue.updateLineGroup = updateLineGroup;
            return ((AxlNetClient.AXLPort16)(this)).updateLineGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLineGroupResponse AxlNetClient.AXLPort16.getLineGroup(AxlNetClient.getLineGroupRequest request)
        {
            return base.Channel.getLineGroup(request);
        }

        public AxlNetClient.GetLineGroupRes getLineGroup(AxlNetClient.GetLineGroupReq getLineGroup1)
        {
            AxlNetClient.getLineGroupRequest inValue = new AxlNetClient.getLineGroupRequest();
            inValue.getLineGroup = getLineGroup1;
            AxlNetClient.getLineGroupResponse retVal = ((AxlNetClient.AXLPort16)(this)).getLineGroup(inValue);
            return retVal.getLineGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLineGroupResponse> AxlNetClient.AXLPort16.getLineGroupAsync(AxlNetClient.getLineGroupRequest request)
        {
            return base.Channel.getLineGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineGroupResponse> getLineGroupAsync(AxlNetClient.GetLineGroupReq getLineGroup)
        {
            AxlNetClient.getLineGroupRequest inValue = new AxlNetClient.getLineGroupRequest();
            inValue.getLineGroup = getLineGroup;
            return ((AxlNetClient.AXLPort16)(this)).getLineGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLineGroupResponse AxlNetClient.AXLPort16.removeLineGroup(AxlNetClient.removeLineGroupRequest request)
        {
            return base.Channel.removeLineGroup(request);
        }

        public AxlNetClient.StandardResponse removeLineGroup(AxlNetClient.NameAndGUIDRequest removeLineGroup1)
        {
            AxlNetClient.removeLineGroupRequest inValue = new AxlNetClient.removeLineGroupRequest();
            inValue.removeLineGroup = removeLineGroup1;
            AxlNetClient.removeLineGroupResponse retVal = ((AxlNetClient.AXLPort16)(this)).removeLineGroup(inValue);
            return retVal.removeLineGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLineGroupResponse> AxlNetClient.AXLPort16.removeLineGroupAsync(AxlNetClient.removeLineGroupRequest request)
        {
            return base.Channel.removeLineGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLineGroupResponse> removeLineGroupAsync(AxlNetClient.NameAndGUIDRequest removeLineGroup)
        {
            AxlNetClient.removeLineGroupRequest inValue = new AxlNetClient.removeLineGroupRequest();
            inValue.removeLineGroup = removeLineGroup;
            return ((AxlNetClient.AXLPort16)(this)).removeLineGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLineGroupResponse AxlNetClient.AXLPort16.listLineGroup(AxlNetClient.listLineGroupRequest request)
        {
            return base.Channel.listLineGroup(request);
        }

        public AxlNetClient.ListLineGroupRes listLineGroup(AxlNetClient.ListLineGroupReq listLineGroup1)
        {
            AxlNetClient.listLineGroupRequest inValue = new AxlNetClient.listLineGroupRequest();
            inValue.listLineGroup = listLineGroup1;
            AxlNetClient.listLineGroupResponse retVal = ((AxlNetClient.AXLPort16)(this)).listLineGroup(inValue);
            return retVal.listLineGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLineGroupResponse> AxlNetClient.AXLPort16.listLineGroupAsync(AxlNetClient.listLineGroupRequest request)
        {
            return base.Channel.listLineGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLineGroupResponse> listLineGroupAsync(AxlNetClient.ListLineGroupReq listLineGroup)
        {
            AxlNetClient.listLineGroupRequest inValue = new AxlNetClient.listLineGroupRequest();
            inValue.listLineGroup = listLineGroup;
            return ((AxlNetClient.AXLPort16)(this)).listLineGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRecordingProfileResponse AxlNetClient.AXLPort16.addRecordingProfile(AxlNetClient.addRecordingProfileRequest request)
        {
            return base.Channel.addRecordingProfile(request);
        }

        public AxlNetClient.StandardResponse addRecordingProfile(AxlNetClient.AddRecordingProfileReq addRecordingProfile1)
        {
            AxlNetClient.addRecordingProfileRequest inValue = new AxlNetClient.addRecordingProfileRequest();
            inValue.addRecordingProfile = addRecordingProfile1;
            AxlNetClient.addRecordingProfileResponse retVal = ((AxlNetClient.AXLPort16)(this)).addRecordingProfile(inValue);
            return retVal.addRecordingProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRecordingProfileResponse> AxlNetClient.AXLPort16.addRecordingProfileAsync(AxlNetClient.addRecordingProfileRequest request)
        {
            return base.Channel.addRecordingProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRecordingProfileResponse> addRecordingProfileAsync(AxlNetClient.AddRecordingProfileReq addRecordingProfile)
        {
            AxlNetClient.addRecordingProfileRequest inValue = new AxlNetClient.addRecordingProfileRequest();
            inValue.addRecordingProfile = addRecordingProfile;
            return ((AxlNetClient.AXLPort16)(this)).addRecordingProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRecordingProfileResponse AxlNetClient.AXLPort16.updateRecordingProfile(AxlNetClient.updateRecordingProfileRequest request)
        {
            return base.Channel.updateRecordingProfile(request);
        }

        public AxlNetClient.StandardResponse updateRecordingProfile(AxlNetClient.UpdateRecordingProfileReq updateRecordingProfile1)
        {
            AxlNetClient.updateRecordingProfileRequest inValue = new AxlNetClient.updateRecordingProfileRequest();
            inValue.updateRecordingProfile = updateRecordingProfile1;
            AxlNetClient.updateRecordingProfileResponse retVal = ((AxlNetClient.AXLPort16)(this)).updateRecordingProfile(inValue);
            return retVal.updateRecordingProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRecordingProfileResponse> AxlNetClient.AXLPort16.updateRecordingProfileAsync(AxlNetClient.updateRecordingProfileRequest request)
        {
            return base.Channel.updateRecordingProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRecordingProfileResponse> updateRecordingProfileAsync(AxlNetClient.UpdateRecordingProfileReq updateRecordingProfile)
        {
            AxlNetClient.updateRecordingProfileRequest inValue = new AxlNetClient.updateRecordingProfileRequest();
            inValue.updateRecordingProfile = updateRecordingProfile;
            return ((AxlNetClient.AXLPort16)(this)).updateRecordingProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRecordingProfileResponse AxlNetClient.AXLPort16.getRecordingProfile(AxlNetClient.getRecordingProfileRequest request)
        {
            return base.Channel.getRecordingProfile(request);
        }

        public AxlNetClient.GetRecordingProfileRes getRecordingProfile(AxlNetClient.GetRecordingProfileReq getRecordingProfile1)
        {
            AxlNetClient.getRecordingProfileRequest inValue = new AxlNetClient.getRecordingProfileRequest();
            inValue.getRecordingProfile = getRecordingProfile1;
            AxlNetClient.getRecordingProfileResponse retVal = ((AxlNetClient.AXLPort16)(this)).getRecordingProfile(inValue);
            return retVal.getRecordingProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRecordingProfileResponse> AxlNetClient.AXLPort16.getRecordingProfileAsync(AxlNetClient.getRecordingProfileRequest request)
        {
            return base.Channel.getRecordingProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRecordingProfileResponse> getRecordingProfileAsync(AxlNetClient.GetRecordingProfileReq getRecordingProfile)
        {
            AxlNetClient.getRecordingProfileRequest inValue = new AxlNetClient.getRecordingProfileRequest();
            inValue.getRecordingProfile = getRecordingProfile;
            return ((AxlNetClient.AXLPort16)(this)).getRecordingProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRecordingProfileResponse AxlNetClient.AXLPort16.removeRecordingProfile(AxlNetClient.removeRecordingProfileRequest request)
        {
            return base.Channel.removeRecordingProfile(request);
        }

        public AxlNetClient.StandardResponse removeRecordingProfile(AxlNetClient.NameAndGUIDRequest removeRecordingProfile1)
        {
            AxlNetClient.removeRecordingProfileRequest inValue = new AxlNetClient.removeRecordingProfileRequest();
            inValue.removeRecordingProfile = removeRecordingProfile1;
            AxlNetClient.removeRecordingProfileResponse retVal = ((AxlNetClient.AXLPort16)(this)).removeRecordingProfile(inValue);
            return retVal.removeRecordingProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRecordingProfileResponse> AxlNetClient.AXLPort16.removeRecordingProfileAsync(AxlNetClient.removeRecordingProfileRequest request)
        {
            return base.Channel.removeRecordingProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRecordingProfileResponse> removeRecordingProfileAsync(AxlNetClient.NameAndGUIDRequest removeRecordingProfile)
        {
            AxlNetClient.removeRecordingProfileRequest inValue = new AxlNetClient.removeRecordingProfileRequest();
            inValue.removeRecordingProfile = removeRecordingProfile;
            return ((AxlNetClient.AXLPort16)(this)).removeRecordingProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRecordingProfileResponse AxlNetClient.AXLPort16.listRecordingProfile(AxlNetClient.listRecordingProfileRequest request)
        {
            return base.Channel.listRecordingProfile(request);
        }

        public AxlNetClient.ListRecordingProfileRes listRecordingProfile(AxlNetClient.ListRecordingProfileReq listRecordingProfile1)
        {
            AxlNetClient.listRecordingProfileRequest inValue = new AxlNetClient.listRecordingProfileRequest();
            inValue.listRecordingProfile = listRecordingProfile1;
            AxlNetClient.listRecordingProfileResponse retVal = ((AxlNetClient.AXLPort16)(this)).listRecordingProfile(inValue);
            return retVal.listRecordingProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRecordingProfileResponse> AxlNetClient.AXLPort16.listRecordingProfileAsync(AxlNetClient.listRecordingProfileRequest request)
        {
            return base.Channel.listRecordingProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRecordingProfileResponse> listRecordingProfileAsync(AxlNetClient.ListRecordingProfileReq listRecordingProfile)
        {
            AxlNetClient.listRecordingProfileRequest inValue = new AxlNetClient.listRecordingProfileRequest();
            inValue.listRecordingProfile = listRecordingProfile;
            return ((AxlNetClient.AXLPort16)(this)).listRecordingProfileAsync(inValue);
        }
    }
}