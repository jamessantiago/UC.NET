namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient68 _axlPortClient68;

        private static AXLPortClient68 axlPortClient68 => _axlPortClient68 == null ||
            _axlPortClient68.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient68 = LoadClient68()) : _axlPortClient68;

        private static AXLPortClient68 LoadClient68()
        {
            var client = new AXLPortClient68(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close68;
            OnAbort += Abort68;
            return client;
        }

        private static void Close68(object sender, System.EventArgs e)
        {
            _axlPortClient68.Close();
        }

        private static void Abort68(object sender, System.EventArgs e)
        {
            _axlPortClient68.Abort();
        }

        public AxlNetClient.ListAnnouncementRes listAnnouncement(AxlNetClient.ListAnnouncementReq listAnnouncement1)
        {
            return axlPortClient68.listAnnouncement(listAnnouncement1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAnnouncementResponse> listAnnouncementAsync(AxlNetClient.ListAnnouncementReq listAnnouncement)
        {
            return axlPortClient68.listAnnouncementAsync(listAnnouncement);
        }

        public AxlNetClient.StandardResponse addServiceProfile(AxlNetClient.AddServiceProfileReq addServiceProfile1)
        {
            return axlPortClient68.addServiceProfile(addServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addServiceProfileResponse> addServiceProfileAsync(AxlNetClient.AddServiceProfileReq addServiceProfile)
        {
            return axlPortClient68.addServiceProfileAsync(addServiceProfile);
        }

        public AxlNetClient.StandardResponse updateServiceProfile(AxlNetClient.UpdateServiceProfileReq updateServiceProfile1)
        {
            return axlPortClient68.updateServiceProfile(updateServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateServiceProfileResponse> updateServiceProfileAsync(AxlNetClient.UpdateServiceProfileReq updateServiceProfile)
        {
            return axlPortClient68.updateServiceProfileAsync(updateServiceProfile);
        }

        public AxlNetClient.GetServiceProfileRes getServiceProfile(AxlNetClient.GetServiceProfileReq getServiceProfile1)
        {
            return axlPortClient68.getServiceProfile(getServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getServiceProfileResponse> getServiceProfileAsync(AxlNetClient.GetServiceProfileReq getServiceProfile)
        {
            return axlPortClient68.getServiceProfileAsync(getServiceProfile);
        }

        public AxlNetClient.StandardResponse removeServiceProfile(AxlNetClient.NameAndGUIDRequest removeServiceProfile1)
        {
            return axlPortClient68.removeServiceProfile(removeServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeServiceProfileResponse> removeServiceProfileAsync(AxlNetClient.NameAndGUIDRequest removeServiceProfile)
        {
            return axlPortClient68.removeServiceProfileAsync(removeServiceProfile);
        }

        public AxlNetClient.ListServiceProfileRes listServiceProfile(AxlNetClient.ListServiceProfileReq listServiceProfile1)
        {
            return axlPortClient68.listServiceProfile(listServiceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listServiceProfileResponse> listServiceProfileAsync(AxlNetClient.ListServiceProfileReq listServiceProfile)
        {
            return axlPortClient68.listServiceProfileAsync(listServiceProfile);
        }

        public AxlNetClient.StandardResponse addLdapSyncCustomField(AxlNetClient.AddLdapSyncCustomFieldReq addLdapSyncCustomField1)
        {
            return axlPortClient68.addLdapSyncCustomField(addLdapSyncCustomField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapSyncCustomFieldResponse> addLdapSyncCustomFieldAsync(AxlNetClient.AddLdapSyncCustomFieldReq addLdapSyncCustomField)
        {
            return axlPortClient68.addLdapSyncCustomFieldAsync(addLdapSyncCustomField);
        }

        public AxlNetClient.StandardResponse updateLdapSyncCustomField(AxlNetClient.UpdateLdapSyncCustomFieldReq updateLdapSyncCustomField1)
        {
            return axlPortClient68.updateLdapSyncCustomField(updateLdapSyncCustomField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapSyncCustomFieldResponse> updateLdapSyncCustomFieldAsync(AxlNetClient.UpdateLdapSyncCustomFieldReq updateLdapSyncCustomField)
        {
            return axlPortClient68.updateLdapSyncCustomFieldAsync(updateLdapSyncCustomField);
        }

        public AxlNetClient.GetLdapSyncCustomFieldRes getLdapSyncCustomField(AxlNetClient.GetLdapSyncCustomFieldReq getLdapSyncCustomField1)
        {
            return axlPortClient68.getLdapSyncCustomField(getLdapSyncCustomField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSyncCustomFieldResponse> getLdapSyncCustomFieldAsync(AxlNetClient.GetLdapSyncCustomFieldReq getLdapSyncCustomField)
        {
            return axlPortClient68.getLdapSyncCustomFieldAsync(getLdapSyncCustomField);
        }

        public AxlNetClient.StandardResponse removeLdapSyncCustomField(AxlNetClient.RemoveLdapSyncCustomFieldReq removeLdapSyncCustomField1)
        {
            return axlPortClient68.removeLdapSyncCustomField(removeLdapSyncCustomField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapSyncCustomFieldResponse> removeLdapSyncCustomFieldAsync(AxlNetClient.RemoveLdapSyncCustomFieldReq removeLdapSyncCustomField)
        {
            return axlPortClient68.removeLdapSyncCustomFieldAsync(removeLdapSyncCustomField);
        }

        public AxlNetClient.StandardResponse addAudioCodecPreferenceList(AxlNetClient.AddAudioCodecPreferenceListReq addAudioCodecPreferenceList1)
        {
            return axlPortClient68.addAudioCodecPreferenceList(addAudioCodecPreferenceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAudioCodecPreferenceListResponse> addAudioCodecPreferenceListAsync(AxlNetClient.AddAudioCodecPreferenceListReq addAudioCodecPreferenceList)
        {
            return axlPortClient68.addAudioCodecPreferenceListAsync(addAudioCodecPreferenceList);
        }

        public AxlNetClient.StandardResponse updateAudioCodecPreferenceList(AxlNetClient.UpdateAudioCodecPreferenceListReq updateAudioCodecPreferenceList1)
        {
            return axlPortClient68.updateAudioCodecPreferenceList(updateAudioCodecPreferenceList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAudioCodecPreferenceListResponse> updateAudioCodecPreferenceListAsync(AxlNetClient.UpdateAudioCodecPreferenceListReq updateAudioCodecPreferenceList)
        {
            return axlPortClient68.updateAudioCodecPreferenceListAsync(updateAudioCodecPreferenceList);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort68
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAnnouncement", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAnnouncementResponse listAnnouncement(AxlNetClient.listAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAnnouncement", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAnnouncementResponse> listAnnouncementAsync(AxlNetClient.listAnnouncementRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addServiceProfileResponse addServiceProfile(AxlNetClient.addServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addServiceProfileResponse> addServiceProfileAsync(AxlNetClient.addServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateServiceProfileResponse updateServiceProfile(AxlNetClient.updateServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateServiceProfileResponse> updateServiceProfileAsync(AxlNetClient.updateServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getServiceProfileResponse getServiceProfile(AxlNetClient.getServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getServiceProfileResponse> getServiceProfileAsync(AxlNetClient.getServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeServiceProfileResponse removeServiceProfile(AxlNetClient.removeServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeServiceProfileResponse> removeServiceProfileAsync(AxlNetClient.removeServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listServiceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listServiceProfileResponse listServiceProfile(AxlNetClient.listServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listServiceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listServiceProfileResponse> listServiceProfileAsync(AxlNetClient.listServiceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapSyncCustomField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLdapSyncCustomFieldResponse addLdapSyncCustomField(AxlNetClient.addLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapSyncCustomField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLdapSyncCustomFieldResponse> addLdapSyncCustomFieldAsync(AxlNetClient.addLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapSyncCustomField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLdapSyncCustomFieldResponse updateLdapSyncCustomField(AxlNetClient.updateLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapSyncCustomField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapSyncCustomFieldResponse> updateLdapSyncCustomFieldAsync(AxlNetClient.updateLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSyncCustomField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapSyncCustomFieldResponse getLdapSyncCustomField(AxlNetClient.getLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSyncCustomField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSyncCustomFieldResponse> getLdapSyncCustomFieldAsync(AxlNetClient.getLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapSyncCustomField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLdapSyncCustomFieldResponse removeLdapSyncCustomField(AxlNetClient.removeLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapSyncCustomField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapSyncCustomFieldResponse> removeLdapSyncCustomFieldAsync(AxlNetClient.removeLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAudioCodecPreferenceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAudioCodecPreferenceListResponse addAudioCodecPreferenceList(AxlNetClient.addAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAudioCodecPreferenceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAudioCodecPreferenceListResponse> addAudioCodecPreferenceListAsync(AxlNetClient.addAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAudioCodecPreferenceList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAudioCodecPreferenceListResponse updateAudioCodecPreferenceList(AxlNetClient.updateAudioCodecPreferenceListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAudioCodecPreferenceList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAudioCodecPreferenceListResponse> updateAudioCodecPreferenceListAsync(AxlNetClient.updateAudioCodecPreferenceListRequest request);
    }

    public class AXLPortClient68 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort68>, AxlNetClient.AXLPort68
    {
        public AXLPortClient68(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAnnouncementResponse AxlNetClient.AXLPort68.listAnnouncement(AxlNetClient.listAnnouncementRequest request)
        {
            return base.Channel.listAnnouncement(request);
        }

        public AxlNetClient.ListAnnouncementRes listAnnouncement(AxlNetClient.ListAnnouncementReq listAnnouncement1)
        {
            AxlNetClient.listAnnouncementRequest inValue = new AxlNetClient.listAnnouncementRequest();
            inValue.listAnnouncement = listAnnouncement1;
            AxlNetClient.listAnnouncementResponse retVal = ((AxlNetClient.AXLPort68)(this)).listAnnouncement(inValue);
            return retVal.listAnnouncementResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAnnouncementResponse> AxlNetClient.AXLPort68.listAnnouncementAsync(AxlNetClient.listAnnouncementRequest request)
        {
            return base.Channel.listAnnouncementAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAnnouncementResponse> listAnnouncementAsync(AxlNetClient.ListAnnouncementReq listAnnouncement)
        {
            AxlNetClient.listAnnouncementRequest inValue = new AxlNetClient.listAnnouncementRequest();
            inValue.listAnnouncement = listAnnouncement;
            return ((AxlNetClient.AXLPort68)(this)).listAnnouncementAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addServiceProfileResponse AxlNetClient.AXLPort68.addServiceProfile(AxlNetClient.addServiceProfileRequest request)
        {
            return base.Channel.addServiceProfile(request);
        }

        public AxlNetClient.StandardResponse addServiceProfile(AxlNetClient.AddServiceProfileReq addServiceProfile1)
        {
            AxlNetClient.addServiceProfileRequest inValue = new AxlNetClient.addServiceProfileRequest();
            inValue.addServiceProfile = addServiceProfile1;
            AxlNetClient.addServiceProfileResponse retVal = ((AxlNetClient.AXLPort68)(this)).addServiceProfile(inValue);
            return retVal.addServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addServiceProfileResponse> AxlNetClient.AXLPort68.addServiceProfileAsync(AxlNetClient.addServiceProfileRequest request)
        {
            return base.Channel.addServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addServiceProfileResponse> addServiceProfileAsync(AxlNetClient.AddServiceProfileReq addServiceProfile)
        {
            AxlNetClient.addServiceProfileRequest inValue = new AxlNetClient.addServiceProfileRequest();
            inValue.addServiceProfile = addServiceProfile;
            return ((AxlNetClient.AXLPort68)(this)).addServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateServiceProfileResponse AxlNetClient.AXLPort68.updateServiceProfile(AxlNetClient.updateServiceProfileRequest request)
        {
            return base.Channel.updateServiceProfile(request);
        }

        public AxlNetClient.StandardResponse updateServiceProfile(AxlNetClient.UpdateServiceProfileReq updateServiceProfile1)
        {
            AxlNetClient.updateServiceProfileRequest inValue = new AxlNetClient.updateServiceProfileRequest();
            inValue.updateServiceProfile = updateServiceProfile1;
            AxlNetClient.updateServiceProfileResponse retVal = ((AxlNetClient.AXLPort68)(this)).updateServiceProfile(inValue);
            return retVal.updateServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateServiceProfileResponse> AxlNetClient.AXLPort68.updateServiceProfileAsync(AxlNetClient.updateServiceProfileRequest request)
        {
            return base.Channel.updateServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateServiceProfileResponse> updateServiceProfileAsync(AxlNetClient.UpdateServiceProfileReq updateServiceProfile)
        {
            AxlNetClient.updateServiceProfileRequest inValue = new AxlNetClient.updateServiceProfileRequest();
            inValue.updateServiceProfile = updateServiceProfile;
            return ((AxlNetClient.AXLPort68)(this)).updateServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getServiceProfileResponse AxlNetClient.AXLPort68.getServiceProfile(AxlNetClient.getServiceProfileRequest request)
        {
            return base.Channel.getServiceProfile(request);
        }

        public AxlNetClient.GetServiceProfileRes getServiceProfile(AxlNetClient.GetServiceProfileReq getServiceProfile1)
        {
            AxlNetClient.getServiceProfileRequest inValue = new AxlNetClient.getServiceProfileRequest();
            inValue.getServiceProfile = getServiceProfile1;
            AxlNetClient.getServiceProfileResponse retVal = ((AxlNetClient.AXLPort68)(this)).getServiceProfile(inValue);
            return retVal.getServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getServiceProfileResponse> AxlNetClient.AXLPort68.getServiceProfileAsync(AxlNetClient.getServiceProfileRequest request)
        {
            return base.Channel.getServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getServiceProfileResponse> getServiceProfileAsync(AxlNetClient.GetServiceProfileReq getServiceProfile)
        {
            AxlNetClient.getServiceProfileRequest inValue = new AxlNetClient.getServiceProfileRequest();
            inValue.getServiceProfile = getServiceProfile;
            return ((AxlNetClient.AXLPort68)(this)).getServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeServiceProfileResponse AxlNetClient.AXLPort68.removeServiceProfile(AxlNetClient.removeServiceProfileRequest request)
        {
            return base.Channel.removeServiceProfile(request);
        }

        public AxlNetClient.StandardResponse removeServiceProfile(AxlNetClient.NameAndGUIDRequest removeServiceProfile1)
        {
            AxlNetClient.removeServiceProfileRequest inValue = new AxlNetClient.removeServiceProfileRequest();
            inValue.removeServiceProfile = removeServiceProfile1;
            AxlNetClient.removeServiceProfileResponse retVal = ((AxlNetClient.AXLPort68)(this)).removeServiceProfile(inValue);
            return retVal.removeServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeServiceProfileResponse> AxlNetClient.AXLPort68.removeServiceProfileAsync(AxlNetClient.removeServiceProfileRequest request)
        {
            return base.Channel.removeServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeServiceProfileResponse> removeServiceProfileAsync(AxlNetClient.NameAndGUIDRequest removeServiceProfile)
        {
            AxlNetClient.removeServiceProfileRequest inValue = new AxlNetClient.removeServiceProfileRequest();
            inValue.removeServiceProfile = removeServiceProfile;
            return ((AxlNetClient.AXLPort68)(this)).removeServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listServiceProfileResponse AxlNetClient.AXLPort68.listServiceProfile(AxlNetClient.listServiceProfileRequest request)
        {
            return base.Channel.listServiceProfile(request);
        }

        public AxlNetClient.ListServiceProfileRes listServiceProfile(AxlNetClient.ListServiceProfileReq listServiceProfile1)
        {
            AxlNetClient.listServiceProfileRequest inValue = new AxlNetClient.listServiceProfileRequest();
            inValue.listServiceProfile = listServiceProfile1;
            AxlNetClient.listServiceProfileResponse retVal = ((AxlNetClient.AXLPort68)(this)).listServiceProfile(inValue);
            return retVal.listServiceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listServiceProfileResponse> AxlNetClient.AXLPort68.listServiceProfileAsync(AxlNetClient.listServiceProfileRequest request)
        {
            return base.Channel.listServiceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listServiceProfileResponse> listServiceProfileAsync(AxlNetClient.ListServiceProfileReq listServiceProfile)
        {
            AxlNetClient.listServiceProfileRequest inValue = new AxlNetClient.listServiceProfileRequest();
            inValue.listServiceProfile = listServiceProfile;
            return ((AxlNetClient.AXLPort68)(this)).listServiceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLdapSyncCustomFieldResponse AxlNetClient.AXLPort68.addLdapSyncCustomField(AxlNetClient.addLdapSyncCustomFieldRequest request)
        {
            return base.Channel.addLdapSyncCustomField(request);
        }

        public AxlNetClient.StandardResponse addLdapSyncCustomField(AxlNetClient.AddLdapSyncCustomFieldReq addLdapSyncCustomField1)
        {
            AxlNetClient.addLdapSyncCustomFieldRequest inValue = new AxlNetClient.addLdapSyncCustomFieldRequest();
            inValue.addLdapSyncCustomField = addLdapSyncCustomField1;
            AxlNetClient.addLdapSyncCustomFieldResponse retVal = ((AxlNetClient.AXLPort68)(this)).addLdapSyncCustomField(inValue);
            return retVal.addLdapSyncCustomFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLdapSyncCustomFieldResponse> AxlNetClient.AXLPort68.addLdapSyncCustomFieldAsync(AxlNetClient.addLdapSyncCustomFieldRequest request)
        {
            return base.Channel.addLdapSyncCustomFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapSyncCustomFieldResponse> addLdapSyncCustomFieldAsync(AxlNetClient.AddLdapSyncCustomFieldReq addLdapSyncCustomField)
        {
            AxlNetClient.addLdapSyncCustomFieldRequest inValue = new AxlNetClient.addLdapSyncCustomFieldRequest();
            inValue.addLdapSyncCustomField = addLdapSyncCustomField;
            return ((AxlNetClient.AXLPort68)(this)).addLdapSyncCustomFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLdapSyncCustomFieldResponse AxlNetClient.AXLPort68.updateLdapSyncCustomField(AxlNetClient.updateLdapSyncCustomFieldRequest request)
        {
            return base.Channel.updateLdapSyncCustomField(request);
        }

        public AxlNetClient.StandardResponse updateLdapSyncCustomField(AxlNetClient.UpdateLdapSyncCustomFieldReq updateLdapSyncCustomField1)
        {
            AxlNetClient.updateLdapSyncCustomFieldRequest inValue = new AxlNetClient.updateLdapSyncCustomFieldRequest();
            inValue.updateLdapSyncCustomField = updateLdapSyncCustomField1;
            AxlNetClient.updateLdapSyncCustomFieldResponse retVal = ((AxlNetClient.AXLPort68)(this)).updateLdapSyncCustomField(inValue);
            return retVal.updateLdapSyncCustomFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapSyncCustomFieldResponse> AxlNetClient.AXLPort68.updateLdapSyncCustomFieldAsync(AxlNetClient.updateLdapSyncCustomFieldRequest request)
        {
            return base.Channel.updateLdapSyncCustomFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapSyncCustomFieldResponse> updateLdapSyncCustomFieldAsync(AxlNetClient.UpdateLdapSyncCustomFieldReq updateLdapSyncCustomField)
        {
            AxlNetClient.updateLdapSyncCustomFieldRequest inValue = new AxlNetClient.updateLdapSyncCustomFieldRequest();
            inValue.updateLdapSyncCustomField = updateLdapSyncCustomField;
            return ((AxlNetClient.AXLPort68)(this)).updateLdapSyncCustomFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapSyncCustomFieldResponse AxlNetClient.AXLPort68.getLdapSyncCustomField(AxlNetClient.getLdapSyncCustomFieldRequest request)
        {
            return base.Channel.getLdapSyncCustomField(request);
        }

        public AxlNetClient.GetLdapSyncCustomFieldRes getLdapSyncCustomField(AxlNetClient.GetLdapSyncCustomFieldReq getLdapSyncCustomField1)
        {
            AxlNetClient.getLdapSyncCustomFieldRequest inValue = new AxlNetClient.getLdapSyncCustomFieldRequest();
            inValue.getLdapSyncCustomField = getLdapSyncCustomField1;
            AxlNetClient.getLdapSyncCustomFieldResponse retVal = ((AxlNetClient.AXLPort68)(this)).getLdapSyncCustomField(inValue);
            return retVal.getLdapSyncCustomFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSyncCustomFieldResponse> AxlNetClient.AXLPort68.getLdapSyncCustomFieldAsync(AxlNetClient.getLdapSyncCustomFieldRequest request)
        {
            return base.Channel.getLdapSyncCustomFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSyncCustomFieldResponse> getLdapSyncCustomFieldAsync(AxlNetClient.GetLdapSyncCustomFieldReq getLdapSyncCustomField)
        {
            AxlNetClient.getLdapSyncCustomFieldRequest inValue = new AxlNetClient.getLdapSyncCustomFieldRequest();
            inValue.getLdapSyncCustomField = getLdapSyncCustomField;
            return ((AxlNetClient.AXLPort68)(this)).getLdapSyncCustomFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLdapSyncCustomFieldResponse AxlNetClient.AXLPort68.removeLdapSyncCustomField(AxlNetClient.removeLdapSyncCustomFieldRequest request)
        {
            return base.Channel.removeLdapSyncCustomField(request);
        }

        public AxlNetClient.StandardResponse removeLdapSyncCustomField(AxlNetClient.RemoveLdapSyncCustomFieldReq removeLdapSyncCustomField1)
        {
            AxlNetClient.removeLdapSyncCustomFieldRequest inValue = new AxlNetClient.removeLdapSyncCustomFieldRequest();
            inValue.removeLdapSyncCustomField = removeLdapSyncCustomField1;
            AxlNetClient.removeLdapSyncCustomFieldResponse retVal = ((AxlNetClient.AXLPort68)(this)).removeLdapSyncCustomField(inValue);
            return retVal.removeLdapSyncCustomFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapSyncCustomFieldResponse> AxlNetClient.AXLPort68.removeLdapSyncCustomFieldAsync(AxlNetClient.removeLdapSyncCustomFieldRequest request)
        {
            return base.Channel.removeLdapSyncCustomFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapSyncCustomFieldResponse> removeLdapSyncCustomFieldAsync(AxlNetClient.RemoveLdapSyncCustomFieldReq removeLdapSyncCustomField)
        {
            AxlNetClient.removeLdapSyncCustomFieldRequest inValue = new AxlNetClient.removeLdapSyncCustomFieldRequest();
            inValue.removeLdapSyncCustomField = removeLdapSyncCustomField;
            return ((AxlNetClient.AXLPort68)(this)).removeLdapSyncCustomFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAudioCodecPreferenceListResponse AxlNetClient.AXLPort68.addAudioCodecPreferenceList(AxlNetClient.addAudioCodecPreferenceListRequest request)
        {
            return base.Channel.addAudioCodecPreferenceList(request);
        }

        public AxlNetClient.StandardResponse addAudioCodecPreferenceList(AxlNetClient.AddAudioCodecPreferenceListReq addAudioCodecPreferenceList1)
        {
            AxlNetClient.addAudioCodecPreferenceListRequest inValue = new AxlNetClient.addAudioCodecPreferenceListRequest();
            inValue.addAudioCodecPreferenceList = addAudioCodecPreferenceList1;
            AxlNetClient.addAudioCodecPreferenceListResponse retVal = ((AxlNetClient.AXLPort68)(this)).addAudioCodecPreferenceList(inValue);
            return retVal.addAudioCodecPreferenceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAudioCodecPreferenceListResponse> AxlNetClient.AXLPort68.addAudioCodecPreferenceListAsync(AxlNetClient.addAudioCodecPreferenceListRequest request)
        {
            return base.Channel.addAudioCodecPreferenceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAudioCodecPreferenceListResponse> addAudioCodecPreferenceListAsync(AxlNetClient.AddAudioCodecPreferenceListReq addAudioCodecPreferenceList)
        {
            AxlNetClient.addAudioCodecPreferenceListRequest inValue = new AxlNetClient.addAudioCodecPreferenceListRequest();
            inValue.addAudioCodecPreferenceList = addAudioCodecPreferenceList;
            return ((AxlNetClient.AXLPort68)(this)).addAudioCodecPreferenceListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAudioCodecPreferenceListResponse AxlNetClient.AXLPort68.updateAudioCodecPreferenceList(AxlNetClient.updateAudioCodecPreferenceListRequest request)
        {
            return base.Channel.updateAudioCodecPreferenceList(request);
        }

        public AxlNetClient.StandardResponse updateAudioCodecPreferenceList(AxlNetClient.UpdateAudioCodecPreferenceListReq updateAudioCodecPreferenceList1)
        {
            AxlNetClient.updateAudioCodecPreferenceListRequest inValue = new AxlNetClient.updateAudioCodecPreferenceListRequest();
            inValue.updateAudioCodecPreferenceList = updateAudioCodecPreferenceList1;
            AxlNetClient.updateAudioCodecPreferenceListResponse retVal = ((AxlNetClient.AXLPort68)(this)).updateAudioCodecPreferenceList(inValue);
            return retVal.updateAudioCodecPreferenceListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAudioCodecPreferenceListResponse> AxlNetClient.AXLPort68.updateAudioCodecPreferenceListAsync(AxlNetClient.updateAudioCodecPreferenceListRequest request)
        {
            return base.Channel.updateAudioCodecPreferenceListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAudioCodecPreferenceListResponse> updateAudioCodecPreferenceListAsync(AxlNetClient.UpdateAudioCodecPreferenceListReq updateAudioCodecPreferenceList)
        {
            AxlNetClient.updateAudioCodecPreferenceListRequest inValue = new AxlNetClient.updateAudioCodecPreferenceListRequest();
            inValue.updateAudioCodecPreferenceList = updateAudioCodecPreferenceList;
            return ((AxlNetClient.AXLPort68)(this)).updateAudioCodecPreferenceListAsync(inValue);
        }
    }
}