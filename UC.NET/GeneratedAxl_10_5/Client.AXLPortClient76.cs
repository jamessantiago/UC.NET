namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient76 _axlPortClient76;

        private static AXLPortClient76 axlPortClient76 => _axlPortClient76 == null ||
            _axlPortClient76.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient76 = LoadClient76()) : _axlPortClient76;

        private static AXLPortClient76 LoadClient76()
        {
            var client = new AXLPortClient76(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close76;
            OnAbort += Abort76;
            return client;
        }

        private static void Close76(object sender, System.EventArgs e)
        {
            _axlPortClient76.Close();
        }

        private static void Abort76(object sender, System.EventArgs e)
        {
            _axlPortClient76.Abort();
        }

        public AxlNetClient.ListWlanProfileGroupRes listWlanProfileGroup(AxlNetClient.ListWlanProfileGroupReq listWlanProfileGroup1)
        {
            return axlPortClient76.listWlanProfileGroup(listWlanProfileGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWlanProfileGroupResponse> listWlanProfileGroupAsync(AxlNetClient.ListWlanProfileGroupReq listWlanProfileGroup)
        {
            return axlPortClient76.listWlanProfileGroupAsync(listWlanProfileGroup);
        }

        public AxlNetClient.StandardResponse addWLANProfile(AxlNetClient.AddWLANProfileReq addWLANProfile1)
        {
            return axlPortClient76.addWLANProfile(addWLANProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWLANProfileResponse> addWLANProfileAsync(AxlNetClient.AddWLANProfileReq addWLANProfile)
        {
            return axlPortClient76.addWLANProfileAsync(addWLANProfile);
        }

        public AxlNetClient.StandardResponse updateWLANProfile(AxlNetClient.UpdateWLANProfileReq updateWLANProfile1)
        {
            return axlPortClient76.updateWLANProfile(updateWLANProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWLANProfileResponse> updateWLANProfileAsync(AxlNetClient.UpdateWLANProfileReq updateWLANProfile)
        {
            return axlPortClient76.updateWLANProfileAsync(updateWLANProfile);
        }

        public AxlNetClient.GetWLANProfileRes getWLANProfile(AxlNetClient.GetWLANProfileReq getWLANProfile1)
        {
            return axlPortClient76.getWLANProfile(getWLANProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWLANProfileResponse> getWLANProfileAsync(AxlNetClient.GetWLANProfileReq getWLANProfile)
        {
            return axlPortClient76.getWLANProfileAsync(getWLANProfile);
        }

        public AxlNetClient.StandardResponse removeWLANProfile(AxlNetClient.NameAndGUIDRequest removeWLANProfile1)
        {
            return axlPortClient76.removeWLANProfile(removeWLANProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWLANProfileResponse> removeWLANProfileAsync(AxlNetClient.NameAndGUIDRequest removeWLANProfile)
        {
            return axlPortClient76.removeWLANProfileAsync(removeWLANProfile);
        }

        public AxlNetClient.ListWLANProfileRes listWLANProfile(AxlNetClient.ListWLANProfileReq listWLANProfile1)
        {
            return axlPortClient76.listWLANProfile(listWLANProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWLANProfileResponse> listWLANProfileAsync(AxlNetClient.ListWLANProfileReq listWLANProfile)
        {
            return axlPortClient76.listWLANProfileAsync(listWLANProfile);
        }

        public AxlNetClient.StandardResponse addUniversalLineTemplate(AxlNetClient.AddUniversalLineTemplateReq addUniversalLineTemplate1)
        {
            return axlPortClient76.addUniversalLineTemplate(addUniversalLineTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUniversalLineTemplateResponse> addUniversalLineTemplateAsync(AxlNetClient.AddUniversalLineTemplateReq addUniversalLineTemplate)
        {
            return axlPortClient76.addUniversalLineTemplateAsync(addUniversalLineTemplate);
        }

        public AxlNetClient.StandardResponse updateUniversalLineTemplate(AxlNetClient.UpdateUniversalLineTemplateReq updateUniversalLineTemplate1)
        {
            return axlPortClient76.updateUniversalLineTemplate(updateUniversalLineTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUniversalLineTemplateResponse> updateUniversalLineTemplateAsync(AxlNetClient.UpdateUniversalLineTemplateReq updateUniversalLineTemplate)
        {
            return axlPortClient76.updateUniversalLineTemplateAsync(updateUniversalLineTemplate);
        }

        public AxlNetClient.GetUniversalLineTemplateRes getUniversalLineTemplate(AxlNetClient.GetUniversalLineTemplateReq getUniversalLineTemplate1)
        {
            return axlPortClient76.getUniversalLineTemplate(getUniversalLineTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUniversalLineTemplateResponse> getUniversalLineTemplateAsync(AxlNetClient.GetUniversalLineTemplateReq getUniversalLineTemplate)
        {
            return axlPortClient76.getUniversalLineTemplateAsync(getUniversalLineTemplate);
        }

        public AxlNetClient.StandardResponse removeUniversalLineTemplate(AxlNetClient.NameAndGUIDRequest removeUniversalLineTemplate1)
        {
            return axlPortClient76.removeUniversalLineTemplate(removeUniversalLineTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUniversalLineTemplateResponse> removeUniversalLineTemplateAsync(AxlNetClient.NameAndGUIDRequest removeUniversalLineTemplate)
        {
            return axlPortClient76.removeUniversalLineTemplateAsync(removeUniversalLineTemplate);
        }

        public AxlNetClient.ListUniversalLineTemplateRes listUniversalLineTemplate(AxlNetClient.ListUniversalLineTemplateReq listUniversalLineTemplate1)
        {
            return axlPortClient76.listUniversalLineTemplate(listUniversalLineTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUniversalLineTemplateResponse> listUniversalLineTemplateAsync(AxlNetClient.ListUniversalLineTemplateReq listUniversalLineTemplate)
        {
            return axlPortClient76.listUniversalLineTemplateAsync(listUniversalLineTemplate);
        }

        public AxlNetClient.StandardResponse addNetworkAccessProfile(AxlNetClient.AddNetworkAccessProfileReq addNetworkAccessProfile1)
        {
            return axlPortClient76.addNetworkAccessProfile(addNetworkAccessProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addNetworkAccessProfileResponse> addNetworkAccessProfileAsync(AxlNetClient.AddNetworkAccessProfileReq addNetworkAccessProfile)
        {
            return axlPortClient76.addNetworkAccessProfileAsync(addNetworkAccessProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort76
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWlanProfileGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listWlanProfileGroupResponse listWlanProfileGroup(AxlNetClient.listWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWlanProfileGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listWlanProfileGroupResponse> listWlanProfileGroupAsync(AxlNetClient.listWlanProfileGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWLANProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addWLANProfileResponse addWLANProfile(AxlNetClient.addWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addWLANProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addWLANProfileResponse> addWLANProfileAsync(AxlNetClient.addWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWLANProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateWLANProfileResponse updateWLANProfile(AxlNetClient.updateWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateWLANProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateWLANProfileResponse> updateWLANProfileAsync(AxlNetClient.updateWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWLANProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getWLANProfileResponse getWLANProfile(AxlNetClient.getWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getWLANProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getWLANProfileResponse> getWLANProfileAsync(AxlNetClient.getWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWLANProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeWLANProfileResponse removeWLANProfile(AxlNetClient.removeWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeWLANProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeWLANProfileResponse> removeWLANProfileAsync(AxlNetClient.removeWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWLANProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listWLANProfileResponse listWLANProfile(AxlNetClient.listWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listWLANProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listWLANProfileResponse> listWLANProfileAsync(AxlNetClient.listWLANProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUniversalLineTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUniversalLineTemplateResponse addUniversalLineTemplate(AxlNetClient.addUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUniversalLineTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUniversalLineTemplateResponse> addUniversalLineTemplateAsync(AxlNetClient.addUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUniversalLineTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUniversalLineTemplateResponse updateUniversalLineTemplate(AxlNetClient.updateUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUniversalLineTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUniversalLineTemplateResponse> updateUniversalLineTemplateAsync(AxlNetClient.updateUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUniversalLineTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUniversalLineTemplateResponse getUniversalLineTemplate(AxlNetClient.getUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUniversalLineTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUniversalLineTemplateResponse> getUniversalLineTemplateAsync(AxlNetClient.getUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUniversalLineTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUniversalLineTemplateResponse removeUniversalLineTemplate(AxlNetClient.removeUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUniversalLineTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUniversalLineTemplateResponse> removeUniversalLineTemplateAsync(AxlNetClient.removeUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUniversalLineTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUniversalLineTemplateResponse listUniversalLineTemplate(AxlNetClient.listUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUniversalLineTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUniversalLineTemplateResponse> listUniversalLineTemplateAsync(AxlNetClient.listUniversalLineTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addNetworkAccessProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addNetworkAccessProfileResponse addNetworkAccessProfile(AxlNetClient.addNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addNetworkAccessProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addNetworkAccessProfileResponse> addNetworkAccessProfileAsync(AxlNetClient.addNetworkAccessProfileRequest request);
    }

    public class AXLPortClient76 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort76>, AxlNetClient.AXLPort76
    {
        public AXLPortClient76(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listWlanProfileGroupResponse AxlNetClient.AXLPort76.listWlanProfileGroup(AxlNetClient.listWlanProfileGroupRequest request)
        {
            return base.Channel.listWlanProfileGroup(request);
        }

        public AxlNetClient.ListWlanProfileGroupRes listWlanProfileGroup(AxlNetClient.ListWlanProfileGroupReq listWlanProfileGroup1)
        {
            AxlNetClient.listWlanProfileGroupRequest inValue = new AxlNetClient.listWlanProfileGroupRequest();
            inValue.listWlanProfileGroup = listWlanProfileGroup1;
            AxlNetClient.listWlanProfileGroupResponse retVal = ((AxlNetClient.AXLPort76)(this)).listWlanProfileGroup(inValue);
            return retVal.listWlanProfileGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listWlanProfileGroupResponse> AxlNetClient.AXLPort76.listWlanProfileGroupAsync(AxlNetClient.listWlanProfileGroupRequest request)
        {
            return base.Channel.listWlanProfileGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWlanProfileGroupResponse> listWlanProfileGroupAsync(AxlNetClient.ListWlanProfileGroupReq listWlanProfileGroup)
        {
            AxlNetClient.listWlanProfileGroupRequest inValue = new AxlNetClient.listWlanProfileGroupRequest();
            inValue.listWlanProfileGroup = listWlanProfileGroup;
            return ((AxlNetClient.AXLPort76)(this)).listWlanProfileGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addWLANProfileResponse AxlNetClient.AXLPort76.addWLANProfile(AxlNetClient.addWLANProfileRequest request)
        {
            return base.Channel.addWLANProfile(request);
        }

        public AxlNetClient.StandardResponse addWLANProfile(AxlNetClient.AddWLANProfileReq addWLANProfile1)
        {
            AxlNetClient.addWLANProfileRequest inValue = new AxlNetClient.addWLANProfileRequest();
            inValue.addWLANProfile = addWLANProfile1;
            AxlNetClient.addWLANProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).addWLANProfile(inValue);
            return retVal.addWLANProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addWLANProfileResponse> AxlNetClient.AXLPort76.addWLANProfileAsync(AxlNetClient.addWLANProfileRequest request)
        {
            return base.Channel.addWLANProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addWLANProfileResponse> addWLANProfileAsync(AxlNetClient.AddWLANProfileReq addWLANProfile)
        {
            AxlNetClient.addWLANProfileRequest inValue = new AxlNetClient.addWLANProfileRequest();
            inValue.addWLANProfile = addWLANProfile;
            return ((AxlNetClient.AXLPort76)(this)).addWLANProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateWLANProfileResponse AxlNetClient.AXLPort76.updateWLANProfile(AxlNetClient.updateWLANProfileRequest request)
        {
            return base.Channel.updateWLANProfile(request);
        }

        public AxlNetClient.StandardResponse updateWLANProfile(AxlNetClient.UpdateWLANProfileReq updateWLANProfile1)
        {
            AxlNetClient.updateWLANProfileRequest inValue = new AxlNetClient.updateWLANProfileRequest();
            inValue.updateWLANProfile = updateWLANProfile1;
            AxlNetClient.updateWLANProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).updateWLANProfile(inValue);
            return retVal.updateWLANProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateWLANProfileResponse> AxlNetClient.AXLPort76.updateWLANProfileAsync(AxlNetClient.updateWLANProfileRequest request)
        {
            return base.Channel.updateWLANProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateWLANProfileResponse> updateWLANProfileAsync(AxlNetClient.UpdateWLANProfileReq updateWLANProfile)
        {
            AxlNetClient.updateWLANProfileRequest inValue = new AxlNetClient.updateWLANProfileRequest();
            inValue.updateWLANProfile = updateWLANProfile;
            return ((AxlNetClient.AXLPort76)(this)).updateWLANProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getWLANProfileResponse AxlNetClient.AXLPort76.getWLANProfile(AxlNetClient.getWLANProfileRequest request)
        {
            return base.Channel.getWLANProfile(request);
        }

        public AxlNetClient.GetWLANProfileRes getWLANProfile(AxlNetClient.GetWLANProfileReq getWLANProfile1)
        {
            AxlNetClient.getWLANProfileRequest inValue = new AxlNetClient.getWLANProfileRequest();
            inValue.getWLANProfile = getWLANProfile1;
            AxlNetClient.getWLANProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).getWLANProfile(inValue);
            return retVal.getWLANProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getWLANProfileResponse> AxlNetClient.AXLPort76.getWLANProfileAsync(AxlNetClient.getWLANProfileRequest request)
        {
            return base.Channel.getWLANProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getWLANProfileResponse> getWLANProfileAsync(AxlNetClient.GetWLANProfileReq getWLANProfile)
        {
            AxlNetClient.getWLANProfileRequest inValue = new AxlNetClient.getWLANProfileRequest();
            inValue.getWLANProfile = getWLANProfile;
            return ((AxlNetClient.AXLPort76)(this)).getWLANProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeWLANProfileResponse AxlNetClient.AXLPort76.removeWLANProfile(AxlNetClient.removeWLANProfileRequest request)
        {
            return base.Channel.removeWLANProfile(request);
        }

        public AxlNetClient.StandardResponse removeWLANProfile(AxlNetClient.NameAndGUIDRequest removeWLANProfile1)
        {
            AxlNetClient.removeWLANProfileRequest inValue = new AxlNetClient.removeWLANProfileRequest();
            inValue.removeWLANProfile = removeWLANProfile1;
            AxlNetClient.removeWLANProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).removeWLANProfile(inValue);
            return retVal.removeWLANProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeWLANProfileResponse> AxlNetClient.AXLPort76.removeWLANProfileAsync(AxlNetClient.removeWLANProfileRequest request)
        {
            return base.Channel.removeWLANProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeWLANProfileResponse> removeWLANProfileAsync(AxlNetClient.NameAndGUIDRequest removeWLANProfile)
        {
            AxlNetClient.removeWLANProfileRequest inValue = new AxlNetClient.removeWLANProfileRequest();
            inValue.removeWLANProfile = removeWLANProfile;
            return ((AxlNetClient.AXLPort76)(this)).removeWLANProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listWLANProfileResponse AxlNetClient.AXLPort76.listWLANProfile(AxlNetClient.listWLANProfileRequest request)
        {
            return base.Channel.listWLANProfile(request);
        }

        public AxlNetClient.ListWLANProfileRes listWLANProfile(AxlNetClient.ListWLANProfileReq listWLANProfile1)
        {
            AxlNetClient.listWLANProfileRequest inValue = new AxlNetClient.listWLANProfileRequest();
            inValue.listWLANProfile = listWLANProfile1;
            AxlNetClient.listWLANProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).listWLANProfile(inValue);
            return retVal.listWLANProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listWLANProfileResponse> AxlNetClient.AXLPort76.listWLANProfileAsync(AxlNetClient.listWLANProfileRequest request)
        {
            return base.Channel.listWLANProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listWLANProfileResponse> listWLANProfileAsync(AxlNetClient.ListWLANProfileReq listWLANProfile)
        {
            AxlNetClient.listWLANProfileRequest inValue = new AxlNetClient.listWLANProfileRequest();
            inValue.listWLANProfile = listWLANProfile;
            return ((AxlNetClient.AXLPort76)(this)).listWLANProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUniversalLineTemplateResponse AxlNetClient.AXLPort76.addUniversalLineTemplate(AxlNetClient.addUniversalLineTemplateRequest request)
        {
            return base.Channel.addUniversalLineTemplate(request);
        }

        public AxlNetClient.StandardResponse addUniversalLineTemplate(AxlNetClient.AddUniversalLineTemplateReq addUniversalLineTemplate1)
        {
            AxlNetClient.addUniversalLineTemplateRequest inValue = new AxlNetClient.addUniversalLineTemplateRequest();
            inValue.addUniversalLineTemplate = addUniversalLineTemplate1;
            AxlNetClient.addUniversalLineTemplateResponse retVal = ((AxlNetClient.AXLPort76)(this)).addUniversalLineTemplate(inValue);
            return retVal.addUniversalLineTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUniversalLineTemplateResponse> AxlNetClient.AXLPort76.addUniversalLineTemplateAsync(AxlNetClient.addUniversalLineTemplateRequest request)
        {
            return base.Channel.addUniversalLineTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUniversalLineTemplateResponse> addUniversalLineTemplateAsync(AxlNetClient.AddUniversalLineTemplateReq addUniversalLineTemplate)
        {
            AxlNetClient.addUniversalLineTemplateRequest inValue = new AxlNetClient.addUniversalLineTemplateRequest();
            inValue.addUniversalLineTemplate = addUniversalLineTemplate;
            return ((AxlNetClient.AXLPort76)(this)).addUniversalLineTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUniversalLineTemplateResponse AxlNetClient.AXLPort76.updateUniversalLineTemplate(AxlNetClient.updateUniversalLineTemplateRequest request)
        {
            return base.Channel.updateUniversalLineTemplate(request);
        }

        public AxlNetClient.StandardResponse updateUniversalLineTemplate(AxlNetClient.UpdateUniversalLineTemplateReq updateUniversalLineTemplate1)
        {
            AxlNetClient.updateUniversalLineTemplateRequest inValue = new AxlNetClient.updateUniversalLineTemplateRequest();
            inValue.updateUniversalLineTemplate = updateUniversalLineTemplate1;
            AxlNetClient.updateUniversalLineTemplateResponse retVal = ((AxlNetClient.AXLPort76)(this)).updateUniversalLineTemplate(inValue);
            return retVal.updateUniversalLineTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUniversalLineTemplateResponse> AxlNetClient.AXLPort76.updateUniversalLineTemplateAsync(AxlNetClient.updateUniversalLineTemplateRequest request)
        {
            return base.Channel.updateUniversalLineTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUniversalLineTemplateResponse> updateUniversalLineTemplateAsync(AxlNetClient.UpdateUniversalLineTemplateReq updateUniversalLineTemplate)
        {
            AxlNetClient.updateUniversalLineTemplateRequest inValue = new AxlNetClient.updateUniversalLineTemplateRequest();
            inValue.updateUniversalLineTemplate = updateUniversalLineTemplate;
            return ((AxlNetClient.AXLPort76)(this)).updateUniversalLineTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUniversalLineTemplateResponse AxlNetClient.AXLPort76.getUniversalLineTemplate(AxlNetClient.getUniversalLineTemplateRequest request)
        {
            return base.Channel.getUniversalLineTemplate(request);
        }

        public AxlNetClient.GetUniversalLineTemplateRes getUniversalLineTemplate(AxlNetClient.GetUniversalLineTemplateReq getUniversalLineTemplate1)
        {
            AxlNetClient.getUniversalLineTemplateRequest inValue = new AxlNetClient.getUniversalLineTemplateRequest();
            inValue.getUniversalLineTemplate = getUniversalLineTemplate1;
            AxlNetClient.getUniversalLineTemplateResponse retVal = ((AxlNetClient.AXLPort76)(this)).getUniversalLineTemplate(inValue);
            return retVal.getUniversalLineTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUniversalLineTemplateResponse> AxlNetClient.AXLPort76.getUniversalLineTemplateAsync(AxlNetClient.getUniversalLineTemplateRequest request)
        {
            return base.Channel.getUniversalLineTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUniversalLineTemplateResponse> getUniversalLineTemplateAsync(AxlNetClient.GetUniversalLineTemplateReq getUniversalLineTemplate)
        {
            AxlNetClient.getUniversalLineTemplateRequest inValue = new AxlNetClient.getUniversalLineTemplateRequest();
            inValue.getUniversalLineTemplate = getUniversalLineTemplate;
            return ((AxlNetClient.AXLPort76)(this)).getUniversalLineTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUniversalLineTemplateResponse AxlNetClient.AXLPort76.removeUniversalLineTemplate(AxlNetClient.removeUniversalLineTemplateRequest request)
        {
            return base.Channel.removeUniversalLineTemplate(request);
        }

        public AxlNetClient.StandardResponse removeUniversalLineTemplate(AxlNetClient.NameAndGUIDRequest removeUniversalLineTemplate1)
        {
            AxlNetClient.removeUniversalLineTemplateRequest inValue = new AxlNetClient.removeUniversalLineTemplateRequest();
            inValue.removeUniversalLineTemplate = removeUniversalLineTemplate1;
            AxlNetClient.removeUniversalLineTemplateResponse retVal = ((AxlNetClient.AXLPort76)(this)).removeUniversalLineTemplate(inValue);
            return retVal.removeUniversalLineTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUniversalLineTemplateResponse> AxlNetClient.AXLPort76.removeUniversalLineTemplateAsync(AxlNetClient.removeUniversalLineTemplateRequest request)
        {
            return base.Channel.removeUniversalLineTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUniversalLineTemplateResponse> removeUniversalLineTemplateAsync(AxlNetClient.NameAndGUIDRequest removeUniversalLineTemplate)
        {
            AxlNetClient.removeUniversalLineTemplateRequest inValue = new AxlNetClient.removeUniversalLineTemplateRequest();
            inValue.removeUniversalLineTemplate = removeUniversalLineTemplate;
            return ((AxlNetClient.AXLPort76)(this)).removeUniversalLineTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUniversalLineTemplateResponse AxlNetClient.AXLPort76.listUniversalLineTemplate(AxlNetClient.listUniversalLineTemplateRequest request)
        {
            return base.Channel.listUniversalLineTemplate(request);
        }

        public AxlNetClient.ListUniversalLineTemplateRes listUniversalLineTemplate(AxlNetClient.ListUniversalLineTemplateReq listUniversalLineTemplate1)
        {
            AxlNetClient.listUniversalLineTemplateRequest inValue = new AxlNetClient.listUniversalLineTemplateRequest();
            inValue.listUniversalLineTemplate = listUniversalLineTemplate1;
            AxlNetClient.listUniversalLineTemplateResponse retVal = ((AxlNetClient.AXLPort76)(this)).listUniversalLineTemplate(inValue);
            return retVal.listUniversalLineTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUniversalLineTemplateResponse> AxlNetClient.AXLPort76.listUniversalLineTemplateAsync(AxlNetClient.listUniversalLineTemplateRequest request)
        {
            return base.Channel.listUniversalLineTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUniversalLineTemplateResponse> listUniversalLineTemplateAsync(AxlNetClient.ListUniversalLineTemplateReq listUniversalLineTemplate)
        {
            AxlNetClient.listUniversalLineTemplateRequest inValue = new AxlNetClient.listUniversalLineTemplateRequest();
            inValue.listUniversalLineTemplate = listUniversalLineTemplate;
            return ((AxlNetClient.AXLPort76)(this)).listUniversalLineTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addNetworkAccessProfileResponse AxlNetClient.AXLPort76.addNetworkAccessProfile(AxlNetClient.addNetworkAccessProfileRequest request)
        {
            return base.Channel.addNetworkAccessProfile(request);
        }

        public AxlNetClient.StandardResponse addNetworkAccessProfile(AxlNetClient.AddNetworkAccessProfileReq addNetworkAccessProfile1)
        {
            AxlNetClient.addNetworkAccessProfileRequest inValue = new AxlNetClient.addNetworkAccessProfileRequest();
            inValue.addNetworkAccessProfile = addNetworkAccessProfile1;
            AxlNetClient.addNetworkAccessProfileResponse retVal = ((AxlNetClient.AXLPort76)(this)).addNetworkAccessProfile(inValue);
            return retVal.addNetworkAccessProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addNetworkAccessProfileResponse> AxlNetClient.AXLPort76.addNetworkAccessProfileAsync(AxlNetClient.addNetworkAccessProfileRequest request)
        {
            return base.Channel.addNetworkAccessProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addNetworkAccessProfileResponse> addNetworkAccessProfileAsync(AxlNetClient.AddNetworkAccessProfileReq addNetworkAccessProfile)
        {
            AxlNetClient.addNetworkAccessProfileRequest inValue = new AxlNetClient.addNetworkAccessProfileRequest();
            inValue.addNetworkAccessProfile = addNetworkAccessProfile;
            return ((AxlNetClient.AXLPort76)(this)).addNetworkAccessProfileAsync(inValue);
        }
    }
}