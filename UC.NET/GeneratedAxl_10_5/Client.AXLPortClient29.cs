namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient29 _axlPortClient29;

        private static AXLPortClient29 axlPortClient29 => _axlPortClient29 == null ||
            _axlPortClient29.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient29 = LoadClient29()) : _axlPortClient29;

        private static AXLPortClient29 LoadClient29()
        {
            var client = new AXLPortClient29(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close29;
            OnAbort += Abort29;
            return client;
        }

        private static void Close29(object sender, System.EventArgs e)
        {
            _axlPortClient29.Close();
        }

        private static void Abort29(object sender, System.EventArgs e)
        {
            _axlPortClient29.Abort();
        }

        public AxlNetClient.StandardResponse addGeoLocationFilter(AxlNetClient.AddGeoLocationFilterReq addGeoLocationFilter1)
        {
            return axlPortClient29.addGeoLocationFilter(addGeoLocationFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationFilterResponse> addGeoLocationFilterAsync(AxlNetClient.AddGeoLocationFilterReq addGeoLocationFilter)
        {
            return axlPortClient29.addGeoLocationFilterAsync(addGeoLocationFilter);
        }

        public AxlNetClient.StandardResponse updateGeoLocationFilter(AxlNetClient.UpdateGeoLocationFilterReq updateGeoLocationFilter1)
        {
            return axlPortClient29.updateGeoLocationFilter(updateGeoLocationFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationFilterResponse> updateGeoLocationFilterAsync(AxlNetClient.UpdateGeoLocationFilterReq updateGeoLocationFilter)
        {
            return axlPortClient29.updateGeoLocationFilterAsync(updateGeoLocationFilter);
        }

        public AxlNetClient.GetGeoLocationFilterRes getGeoLocationFilter(AxlNetClient.GetGeoLocationFilterReq getGeoLocationFilter1)
        {
            return axlPortClient29.getGeoLocationFilter(getGeoLocationFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationFilterResponse> getGeoLocationFilterAsync(AxlNetClient.GetGeoLocationFilterReq getGeoLocationFilter)
        {
            return axlPortClient29.getGeoLocationFilterAsync(getGeoLocationFilter);
        }

        public AxlNetClient.StandardResponse removeGeoLocationFilter(AxlNetClient.NameAndGUIDRequest removeGeoLocationFilter1)
        {
            return axlPortClient29.removeGeoLocationFilter(removeGeoLocationFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationFilterResponse> removeGeoLocationFilterAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocationFilter)
        {
            return axlPortClient29.removeGeoLocationFilterAsync(removeGeoLocationFilter);
        }

        public AxlNetClient.ListGeoLocationFilterRes listGeoLocationFilter(AxlNetClient.ListGeoLocationFilterReq listGeoLocationFilter1)
        {
            return axlPortClient29.listGeoLocationFilter(listGeoLocationFilter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationFilterResponse> listGeoLocationFilterAsync(AxlNetClient.ListGeoLocationFilterReq listGeoLocationFilter)
        {
            return axlPortClient29.listGeoLocationFilterAsync(listGeoLocationFilter);
        }

        public AxlNetClient.StandardResponse addVoiceMailProfile(AxlNetClient.AddVoiceMailProfileReq addVoiceMailProfile1)
        {
            return axlPortClient29.addVoiceMailProfile(addVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailProfileResponse> addVoiceMailProfileAsync(AxlNetClient.AddVoiceMailProfileReq addVoiceMailProfile)
        {
            return axlPortClient29.addVoiceMailProfileAsync(addVoiceMailProfile);
        }

        public AxlNetClient.StandardResponse updateVoiceMailProfile(AxlNetClient.UpdateVoiceMailProfileReq updateVoiceMailProfile1)
        {
            return axlPortClient29.updateVoiceMailProfile(updateVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailProfileResponse> updateVoiceMailProfileAsync(AxlNetClient.UpdateVoiceMailProfileReq updateVoiceMailProfile)
        {
            return axlPortClient29.updateVoiceMailProfileAsync(updateVoiceMailProfile);
        }

        public AxlNetClient.GetVoiceMailProfileRes getVoiceMailProfile(AxlNetClient.GetVoiceMailProfileReq getVoiceMailProfile1)
        {
            return axlPortClient29.getVoiceMailProfile(getVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailProfileResponse> getVoiceMailProfileAsync(AxlNetClient.GetVoiceMailProfileReq getVoiceMailProfile)
        {
            return axlPortClient29.getVoiceMailProfileAsync(getVoiceMailProfile);
        }

        public AxlNetClient.StandardResponse removeVoiceMailProfile(AxlNetClient.NameAndGUIDRequest removeVoiceMailProfile1)
        {
            return axlPortClient29.removeVoiceMailProfile(removeVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailProfileResponse> removeVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest removeVoiceMailProfile)
        {
            return axlPortClient29.removeVoiceMailProfileAsync(removeVoiceMailProfile);
        }

        public AxlNetClient.ListVoiceMailProfileRes listVoiceMailProfile(AxlNetClient.ListVoiceMailProfileReq listVoiceMailProfile1)
        {
            return axlPortClient29.listVoiceMailProfile(listVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailProfileResponse> listVoiceMailProfileAsync(AxlNetClient.ListVoiceMailProfileReq listVoiceMailProfile)
        {
            return axlPortClient29.listVoiceMailProfileAsync(listVoiceMailProfile);
        }

        public AxlNetClient.StandardResponse resetVoiceMailProfile(AxlNetClient.NameAndGUIDRequest resetVoiceMailProfile1)
        {
            return axlPortClient29.resetVoiceMailProfile(resetVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailProfileResponse> resetVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest resetVoiceMailProfile)
        {
            return axlPortClient29.resetVoiceMailProfileAsync(resetVoiceMailProfile);
        }

        public AxlNetClient.StandardResponse restartVoiceMailProfile(AxlNetClient.NameAndGUIDRequest restartVoiceMailProfile1)
        {
            return axlPortClient29.restartVoiceMailProfile(restartVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailProfileResponse> restartVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest restartVoiceMailProfile)
        {
            return axlPortClient29.restartVoiceMailProfileAsync(restartVoiceMailProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort29
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocationFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGeoLocationFilterResponse addGeoLocationFilter(AxlNetClient.addGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocationFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationFilterResponse> addGeoLocationFilterAsync(AxlNetClient.addGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocationFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGeoLocationFilterResponse updateGeoLocationFilter(AxlNetClient.updateGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocationFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationFilterResponse> updateGeoLocationFilterAsync(AxlNetClient.updateGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocationFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGeoLocationFilterResponse getGeoLocationFilter(AxlNetClient.getGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocationFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationFilterResponse> getGeoLocationFilterAsync(AxlNetClient.getGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocationFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGeoLocationFilterResponse removeGeoLocationFilter(AxlNetClient.removeGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocationFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationFilterResponse> removeGeoLocationFilterAsync(AxlNetClient.removeGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocationFilter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listGeoLocationFilterResponse listGeoLocationFilter(AxlNetClient.listGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocationFilter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationFilterResponse> listGeoLocationFilterAsync(AxlNetClient.listGeoLocationFilterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVoiceMailProfileResponse addVoiceMailProfile(AxlNetClient.addVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailProfileResponse> addVoiceMailProfileAsync(AxlNetClient.addVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVoiceMailProfileResponse updateVoiceMailProfile(AxlNetClient.updateVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailProfileResponse> updateVoiceMailProfileAsync(AxlNetClient.updateVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVoiceMailProfileResponse getVoiceMailProfile(AxlNetClient.getVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailProfileResponse> getVoiceMailProfileAsync(AxlNetClient.getVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVoiceMailProfileResponse removeVoiceMailProfile(AxlNetClient.removeVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailProfileResponse> removeVoiceMailProfileAsync(AxlNetClient.removeVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVoiceMailProfileResponse listVoiceMailProfile(AxlNetClient.listVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailProfileResponse> listVoiceMailProfileAsync(AxlNetClient.listVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetVoiceMailProfileResponse resetVoiceMailProfile(AxlNetClient.resetVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailProfileResponse> resetVoiceMailProfileAsync(AxlNetClient.resetVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartVoiceMailProfileResponse restartVoiceMailProfile(AxlNetClient.restartVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailProfileResponse> restartVoiceMailProfileAsync(AxlNetClient.restartVoiceMailProfileRequest request);
    }

    public class AXLPortClient29 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort29>, AxlNetClient.AXLPort29
    {
        public AXLPortClient29(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGeoLocationFilterResponse AxlNetClient.AXLPort29.addGeoLocationFilter(AxlNetClient.addGeoLocationFilterRequest request)
        {
            return base.Channel.addGeoLocationFilter(request);
        }

        public AxlNetClient.StandardResponse addGeoLocationFilter(AxlNetClient.AddGeoLocationFilterReq addGeoLocationFilter1)
        {
            AxlNetClient.addGeoLocationFilterRequest inValue = new AxlNetClient.addGeoLocationFilterRequest();
            inValue.addGeoLocationFilter = addGeoLocationFilter1;
            AxlNetClient.addGeoLocationFilterResponse retVal = ((AxlNetClient.AXLPort29)(this)).addGeoLocationFilter(inValue);
            return retVal.addGeoLocationFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationFilterResponse> AxlNetClient.AXLPort29.addGeoLocationFilterAsync(AxlNetClient.addGeoLocationFilterRequest request)
        {
            return base.Channel.addGeoLocationFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationFilterResponse> addGeoLocationFilterAsync(AxlNetClient.AddGeoLocationFilterReq addGeoLocationFilter)
        {
            AxlNetClient.addGeoLocationFilterRequest inValue = new AxlNetClient.addGeoLocationFilterRequest();
            inValue.addGeoLocationFilter = addGeoLocationFilter;
            return ((AxlNetClient.AXLPort29)(this)).addGeoLocationFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGeoLocationFilterResponse AxlNetClient.AXLPort29.updateGeoLocationFilter(AxlNetClient.updateGeoLocationFilterRequest request)
        {
            return base.Channel.updateGeoLocationFilter(request);
        }

        public AxlNetClient.StandardResponse updateGeoLocationFilter(AxlNetClient.UpdateGeoLocationFilterReq updateGeoLocationFilter1)
        {
            AxlNetClient.updateGeoLocationFilterRequest inValue = new AxlNetClient.updateGeoLocationFilterRequest();
            inValue.updateGeoLocationFilter = updateGeoLocationFilter1;
            AxlNetClient.updateGeoLocationFilterResponse retVal = ((AxlNetClient.AXLPort29)(this)).updateGeoLocationFilter(inValue);
            return retVal.updateGeoLocationFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationFilterResponse> AxlNetClient.AXLPort29.updateGeoLocationFilterAsync(AxlNetClient.updateGeoLocationFilterRequest request)
        {
            return base.Channel.updateGeoLocationFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationFilterResponse> updateGeoLocationFilterAsync(AxlNetClient.UpdateGeoLocationFilterReq updateGeoLocationFilter)
        {
            AxlNetClient.updateGeoLocationFilterRequest inValue = new AxlNetClient.updateGeoLocationFilterRequest();
            inValue.updateGeoLocationFilter = updateGeoLocationFilter;
            return ((AxlNetClient.AXLPort29)(this)).updateGeoLocationFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGeoLocationFilterResponse AxlNetClient.AXLPort29.getGeoLocationFilter(AxlNetClient.getGeoLocationFilterRequest request)
        {
            return base.Channel.getGeoLocationFilter(request);
        }

        public AxlNetClient.GetGeoLocationFilterRes getGeoLocationFilter(AxlNetClient.GetGeoLocationFilterReq getGeoLocationFilter1)
        {
            AxlNetClient.getGeoLocationFilterRequest inValue = new AxlNetClient.getGeoLocationFilterRequest();
            inValue.getGeoLocationFilter = getGeoLocationFilter1;
            AxlNetClient.getGeoLocationFilterResponse retVal = ((AxlNetClient.AXLPort29)(this)).getGeoLocationFilter(inValue);
            return retVal.getGeoLocationFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationFilterResponse> AxlNetClient.AXLPort29.getGeoLocationFilterAsync(AxlNetClient.getGeoLocationFilterRequest request)
        {
            return base.Channel.getGeoLocationFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationFilterResponse> getGeoLocationFilterAsync(AxlNetClient.GetGeoLocationFilterReq getGeoLocationFilter)
        {
            AxlNetClient.getGeoLocationFilterRequest inValue = new AxlNetClient.getGeoLocationFilterRequest();
            inValue.getGeoLocationFilter = getGeoLocationFilter;
            return ((AxlNetClient.AXLPort29)(this)).getGeoLocationFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGeoLocationFilterResponse AxlNetClient.AXLPort29.removeGeoLocationFilter(AxlNetClient.removeGeoLocationFilterRequest request)
        {
            return base.Channel.removeGeoLocationFilter(request);
        }

        public AxlNetClient.StandardResponse removeGeoLocationFilter(AxlNetClient.NameAndGUIDRequest removeGeoLocationFilter1)
        {
            AxlNetClient.removeGeoLocationFilterRequest inValue = new AxlNetClient.removeGeoLocationFilterRequest();
            inValue.removeGeoLocationFilter = removeGeoLocationFilter1;
            AxlNetClient.removeGeoLocationFilterResponse retVal = ((AxlNetClient.AXLPort29)(this)).removeGeoLocationFilter(inValue);
            return retVal.removeGeoLocationFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationFilterResponse> AxlNetClient.AXLPort29.removeGeoLocationFilterAsync(AxlNetClient.removeGeoLocationFilterRequest request)
        {
            return base.Channel.removeGeoLocationFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationFilterResponse> removeGeoLocationFilterAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocationFilter)
        {
            AxlNetClient.removeGeoLocationFilterRequest inValue = new AxlNetClient.removeGeoLocationFilterRequest();
            inValue.removeGeoLocationFilter = removeGeoLocationFilter;
            return ((AxlNetClient.AXLPort29)(this)).removeGeoLocationFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listGeoLocationFilterResponse AxlNetClient.AXLPort29.listGeoLocationFilter(AxlNetClient.listGeoLocationFilterRequest request)
        {
            return base.Channel.listGeoLocationFilter(request);
        }

        public AxlNetClient.ListGeoLocationFilterRes listGeoLocationFilter(AxlNetClient.ListGeoLocationFilterReq listGeoLocationFilter1)
        {
            AxlNetClient.listGeoLocationFilterRequest inValue = new AxlNetClient.listGeoLocationFilterRequest();
            inValue.listGeoLocationFilter = listGeoLocationFilter1;
            AxlNetClient.listGeoLocationFilterResponse retVal = ((AxlNetClient.AXLPort29)(this)).listGeoLocationFilter(inValue);
            return retVal.listGeoLocationFilterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationFilterResponse> AxlNetClient.AXLPort29.listGeoLocationFilterAsync(AxlNetClient.listGeoLocationFilterRequest request)
        {
            return base.Channel.listGeoLocationFilterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationFilterResponse> listGeoLocationFilterAsync(AxlNetClient.ListGeoLocationFilterReq listGeoLocationFilter)
        {
            AxlNetClient.listGeoLocationFilterRequest inValue = new AxlNetClient.listGeoLocationFilterRequest();
            inValue.listGeoLocationFilter = listGeoLocationFilter;
            return ((AxlNetClient.AXLPort29)(this)).listGeoLocationFilterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVoiceMailProfileResponse AxlNetClient.AXLPort29.addVoiceMailProfile(AxlNetClient.addVoiceMailProfileRequest request)
        {
            return base.Channel.addVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse addVoiceMailProfile(AxlNetClient.AddVoiceMailProfileReq addVoiceMailProfile1)
        {
            AxlNetClient.addVoiceMailProfileRequest inValue = new AxlNetClient.addVoiceMailProfileRequest();
            inValue.addVoiceMailProfile = addVoiceMailProfile1;
            AxlNetClient.addVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).addVoiceMailProfile(inValue);
            return retVal.addVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailProfileResponse> AxlNetClient.AXLPort29.addVoiceMailProfileAsync(AxlNetClient.addVoiceMailProfileRequest request)
        {
            return base.Channel.addVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailProfileResponse> addVoiceMailProfileAsync(AxlNetClient.AddVoiceMailProfileReq addVoiceMailProfile)
        {
            AxlNetClient.addVoiceMailProfileRequest inValue = new AxlNetClient.addVoiceMailProfileRequest();
            inValue.addVoiceMailProfile = addVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).addVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVoiceMailProfileResponse AxlNetClient.AXLPort29.updateVoiceMailProfile(AxlNetClient.updateVoiceMailProfileRequest request)
        {
            return base.Channel.updateVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse updateVoiceMailProfile(AxlNetClient.UpdateVoiceMailProfileReq updateVoiceMailProfile1)
        {
            AxlNetClient.updateVoiceMailProfileRequest inValue = new AxlNetClient.updateVoiceMailProfileRequest();
            inValue.updateVoiceMailProfile = updateVoiceMailProfile1;
            AxlNetClient.updateVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).updateVoiceMailProfile(inValue);
            return retVal.updateVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailProfileResponse> AxlNetClient.AXLPort29.updateVoiceMailProfileAsync(AxlNetClient.updateVoiceMailProfileRequest request)
        {
            return base.Channel.updateVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailProfileResponse> updateVoiceMailProfileAsync(AxlNetClient.UpdateVoiceMailProfileReq updateVoiceMailProfile)
        {
            AxlNetClient.updateVoiceMailProfileRequest inValue = new AxlNetClient.updateVoiceMailProfileRequest();
            inValue.updateVoiceMailProfile = updateVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).updateVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVoiceMailProfileResponse AxlNetClient.AXLPort29.getVoiceMailProfile(AxlNetClient.getVoiceMailProfileRequest request)
        {
            return base.Channel.getVoiceMailProfile(request);
        }

        public AxlNetClient.GetVoiceMailProfileRes getVoiceMailProfile(AxlNetClient.GetVoiceMailProfileReq getVoiceMailProfile1)
        {
            AxlNetClient.getVoiceMailProfileRequest inValue = new AxlNetClient.getVoiceMailProfileRequest();
            inValue.getVoiceMailProfile = getVoiceMailProfile1;
            AxlNetClient.getVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).getVoiceMailProfile(inValue);
            return retVal.getVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailProfileResponse> AxlNetClient.AXLPort29.getVoiceMailProfileAsync(AxlNetClient.getVoiceMailProfileRequest request)
        {
            return base.Channel.getVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailProfileResponse> getVoiceMailProfileAsync(AxlNetClient.GetVoiceMailProfileReq getVoiceMailProfile)
        {
            AxlNetClient.getVoiceMailProfileRequest inValue = new AxlNetClient.getVoiceMailProfileRequest();
            inValue.getVoiceMailProfile = getVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).getVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVoiceMailProfileResponse AxlNetClient.AXLPort29.removeVoiceMailProfile(AxlNetClient.removeVoiceMailProfileRequest request)
        {
            return base.Channel.removeVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse removeVoiceMailProfile(AxlNetClient.NameAndGUIDRequest removeVoiceMailProfile1)
        {
            AxlNetClient.removeVoiceMailProfileRequest inValue = new AxlNetClient.removeVoiceMailProfileRequest();
            inValue.removeVoiceMailProfile = removeVoiceMailProfile1;
            AxlNetClient.removeVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).removeVoiceMailProfile(inValue);
            return retVal.removeVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailProfileResponse> AxlNetClient.AXLPort29.removeVoiceMailProfileAsync(AxlNetClient.removeVoiceMailProfileRequest request)
        {
            return base.Channel.removeVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailProfileResponse> removeVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest removeVoiceMailProfile)
        {
            AxlNetClient.removeVoiceMailProfileRequest inValue = new AxlNetClient.removeVoiceMailProfileRequest();
            inValue.removeVoiceMailProfile = removeVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).removeVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVoiceMailProfileResponse AxlNetClient.AXLPort29.listVoiceMailProfile(AxlNetClient.listVoiceMailProfileRequest request)
        {
            return base.Channel.listVoiceMailProfile(request);
        }

        public AxlNetClient.ListVoiceMailProfileRes listVoiceMailProfile(AxlNetClient.ListVoiceMailProfileReq listVoiceMailProfile1)
        {
            AxlNetClient.listVoiceMailProfileRequest inValue = new AxlNetClient.listVoiceMailProfileRequest();
            inValue.listVoiceMailProfile = listVoiceMailProfile1;
            AxlNetClient.listVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).listVoiceMailProfile(inValue);
            return retVal.listVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailProfileResponse> AxlNetClient.AXLPort29.listVoiceMailProfileAsync(AxlNetClient.listVoiceMailProfileRequest request)
        {
            return base.Channel.listVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailProfileResponse> listVoiceMailProfileAsync(AxlNetClient.ListVoiceMailProfileReq listVoiceMailProfile)
        {
            AxlNetClient.listVoiceMailProfileRequest inValue = new AxlNetClient.listVoiceMailProfileRequest();
            inValue.listVoiceMailProfile = listVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).listVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetVoiceMailProfileResponse AxlNetClient.AXLPort29.resetVoiceMailProfile(AxlNetClient.resetVoiceMailProfileRequest request)
        {
            return base.Channel.resetVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse resetVoiceMailProfile(AxlNetClient.NameAndGUIDRequest resetVoiceMailProfile1)
        {
            AxlNetClient.resetVoiceMailProfileRequest inValue = new AxlNetClient.resetVoiceMailProfileRequest();
            inValue.resetVoiceMailProfile = resetVoiceMailProfile1;
            AxlNetClient.resetVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).resetVoiceMailProfile(inValue);
            return retVal.resetVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailProfileResponse> AxlNetClient.AXLPort29.resetVoiceMailProfileAsync(AxlNetClient.resetVoiceMailProfileRequest request)
        {
            return base.Channel.resetVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailProfileResponse> resetVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest resetVoiceMailProfile)
        {
            AxlNetClient.resetVoiceMailProfileRequest inValue = new AxlNetClient.resetVoiceMailProfileRequest();
            inValue.resetVoiceMailProfile = resetVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).resetVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartVoiceMailProfileResponse AxlNetClient.AXLPort29.restartVoiceMailProfile(AxlNetClient.restartVoiceMailProfileRequest request)
        {
            return base.Channel.restartVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse restartVoiceMailProfile(AxlNetClient.NameAndGUIDRequest restartVoiceMailProfile1)
        {
            AxlNetClient.restartVoiceMailProfileRequest inValue = new AxlNetClient.restartVoiceMailProfileRequest();
            inValue.restartVoiceMailProfile = restartVoiceMailProfile1;
            AxlNetClient.restartVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort29)(this)).restartVoiceMailProfile(inValue);
            return retVal.restartVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailProfileResponse> AxlNetClient.AXLPort29.restartVoiceMailProfileAsync(AxlNetClient.restartVoiceMailProfileRequest request)
        {
            return base.Channel.restartVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailProfileResponse> restartVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest restartVoiceMailProfile)
        {
            AxlNetClient.restartVoiceMailProfileRequest inValue = new AxlNetClient.restartVoiceMailProfileRequest();
            inValue.restartVoiceMailProfile = restartVoiceMailProfile;
            return ((AxlNetClient.AXLPort29)(this)).restartVoiceMailProfileAsync(inValue);
        }
    }
}