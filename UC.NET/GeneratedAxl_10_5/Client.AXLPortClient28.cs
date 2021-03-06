namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient28 _axlPortClient28;

        private static AXLPortClient28 axlPortClient28 => _axlPortClient28 == null ||
            _axlPortClient28.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient28 = LoadClient28()) : _axlPortClient28;

        private static AXLPortClient28 LoadClient28()
        {
            var client = new AXLPortClient28(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close28;
            OnAbort += Abort28;
            return client;
        }

        private static void Close28(object sender, System.EventArgs e)
        {
            _axlPortClient28.Close();
        }

        private static void Abort28(object sender, System.EventArgs e)
        {
            _axlPortClient28.Abort();
        }

        public AxlNetClient.GetApplicationUserCapfProfileRes getApplicationUserCapfProfile(AxlNetClient.GetApplicationUserCapfProfileReq getApplicationUserCapfProfile1)
        {
            return axlPortClient28.getApplicationUserCapfProfile(getApplicationUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationUserCapfProfileResponse> getApplicationUserCapfProfileAsync(AxlNetClient.GetApplicationUserCapfProfileReq getApplicationUserCapfProfile)
        {
            return axlPortClient28.getApplicationUserCapfProfileAsync(getApplicationUserCapfProfile);
        }

        public AxlNetClient.StandardResponse removeApplicationUserCapfProfile(AxlNetClient.RemoveApplicationUserCapfProfileReq removeApplicationUserCapfProfile1)
        {
            return axlPortClient28.removeApplicationUserCapfProfile(removeApplicationUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationUserCapfProfileResponse> removeApplicationUserCapfProfileAsync(AxlNetClient.RemoveApplicationUserCapfProfileReq removeApplicationUserCapfProfile)
        {
            return axlPortClient28.removeApplicationUserCapfProfileAsync(removeApplicationUserCapfProfile);
        }

        public AxlNetClient.ListApplicationUserCapfProfileRes listApplicationUserCapfProfile(AxlNetClient.ListApplicationUserCapfProfileReq listApplicationUserCapfProfile1)
        {
            return axlPortClient28.listApplicationUserCapfProfile(listApplicationUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationUserCapfProfileResponse> listApplicationUserCapfProfileAsync(AxlNetClient.ListApplicationUserCapfProfileReq listApplicationUserCapfProfile)
        {
            return axlPortClient28.listApplicationUserCapfProfileAsync(listApplicationUserCapfProfile);
        }

        public AxlNetClient.StandardResponse addEndUserCapfProfile(AxlNetClient.AddEndUserCapfProfileReq addEndUserCapfProfile1)
        {
            return axlPortClient28.addEndUserCapfProfile(addEndUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addEndUserCapfProfileResponse> addEndUserCapfProfileAsync(AxlNetClient.AddEndUserCapfProfileReq addEndUserCapfProfile)
        {
            return axlPortClient28.addEndUserCapfProfileAsync(addEndUserCapfProfile);
        }

        public AxlNetClient.StandardResponse updateEndUserCapfProfile(AxlNetClient.UpdateEndUserCapfProfileReq updateEndUserCapfProfile1)
        {
            return axlPortClient28.updateEndUserCapfProfile(updateEndUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEndUserCapfProfileResponse> updateEndUserCapfProfileAsync(AxlNetClient.UpdateEndUserCapfProfileReq updateEndUserCapfProfile)
        {
            return axlPortClient28.updateEndUserCapfProfileAsync(updateEndUserCapfProfile);
        }

        public AxlNetClient.GetEndUserCapfProfileRes getEndUserCapfProfile(AxlNetClient.GetEndUserCapfProfileReq getEndUserCapfProfile1)
        {
            return axlPortClient28.getEndUserCapfProfile(getEndUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEndUserCapfProfileResponse> getEndUserCapfProfileAsync(AxlNetClient.GetEndUserCapfProfileReq getEndUserCapfProfile)
        {
            return axlPortClient28.getEndUserCapfProfileAsync(getEndUserCapfProfile);
        }

        public AxlNetClient.StandardResponse removeEndUserCapfProfile(AxlNetClient.RemoveEndUserCapfProfileReq removeEndUserCapfProfile1)
        {
            return axlPortClient28.removeEndUserCapfProfile(removeEndUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeEndUserCapfProfileResponse> removeEndUserCapfProfileAsync(AxlNetClient.RemoveEndUserCapfProfileReq removeEndUserCapfProfile)
        {
            return axlPortClient28.removeEndUserCapfProfileAsync(removeEndUserCapfProfile);
        }

        public AxlNetClient.ListEndUserCapfProfileRes listEndUserCapfProfile(AxlNetClient.ListEndUserCapfProfileReq listEndUserCapfProfile1)
        {
            return axlPortClient28.listEndUserCapfProfile(listEndUserCapfProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listEndUserCapfProfileResponse> listEndUserCapfProfileAsync(AxlNetClient.ListEndUserCapfProfileReq listEndUserCapfProfile)
        {
            return axlPortClient28.listEndUserCapfProfileAsync(listEndUserCapfProfile);
        }

        public AxlNetClient.StandardResponse updateServiceParameter(AxlNetClient.UpdateServiceParameterReq updateServiceParameter1)
        {
            return axlPortClient28.updateServiceParameter(updateServiceParameter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateServiceParameterResponse> updateServiceParameterAsync(AxlNetClient.UpdateServiceParameterReq updateServiceParameter)
        {
            return axlPortClient28.updateServiceParameterAsync(updateServiceParameter);
        }

        public AxlNetClient.GetServiceParameterRes getServiceParameter(AxlNetClient.GetServiceParameterReq getServiceParameter1)
        {
            return axlPortClient28.getServiceParameter(getServiceParameter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getServiceParameterResponse> getServiceParameterAsync(AxlNetClient.GetServiceParameterReq getServiceParameter)
        {
            return axlPortClient28.getServiceParameterAsync(getServiceParameter);
        }

        public AxlNetClient.ListServiceParameterRes listServiceParameter(AxlNetClient.ListServiceParameterReq listServiceParameter1)
        {
            return axlPortClient28.listServiceParameter(listServiceParameter1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listServiceParameterResponse> listServiceParameterAsync(AxlNetClient.ListServiceParameterReq listServiceParameter)
        {
            return axlPortClient28.listServiceParameterAsync(listServiceParameter);
        }

        public AxlNetClient.StandardResponse addUserPhoneAssociation(AxlNetClient.AddUserPhoneAssociationReq addUserPhoneAssociation1)
        {
            return axlPortClient28.addUserPhoneAssociation(addUserPhoneAssociation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserPhoneAssociationResponse> addUserPhoneAssociationAsync(AxlNetClient.AddUserPhoneAssociationReq addUserPhoneAssociation)
        {
            return axlPortClient28.addUserPhoneAssociationAsync(addUserPhoneAssociation);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort28
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getApplicationUserCapfProfileResponse getApplicationUserCapfProfile(AxlNetClient.getApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationUserCapfProfileResponse> getApplicationUserCapfProfileAsync(AxlNetClient.getApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeApplicationUserCapfProfileResponse removeApplicationUserCapfProfile(AxlNetClient.removeApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationUserCapfProfileResponse> removeApplicationUserCapfProfileAsync(AxlNetClient.removeApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listApplicationUserCapfProfileResponse listApplicationUserCapfProfile(AxlNetClient.listApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationUserCapfProfileResponse> listApplicationUserCapfProfileAsync(AxlNetClient.listApplicationUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addEndUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addEndUserCapfProfileResponse addEndUserCapfProfile(AxlNetClient.addEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addEndUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addEndUserCapfProfileResponse> addEndUserCapfProfileAsync(AxlNetClient.addEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEndUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateEndUserCapfProfileResponse updateEndUserCapfProfile(AxlNetClient.updateEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEndUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateEndUserCapfProfileResponse> updateEndUserCapfProfileAsync(AxlNetClient.updateEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEndUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getEndUserCapfProfileResponse getEndUserCapfProfile(AxlNetClient.getEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEndUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getEndUserCapfProfileResponse> getEndUserCapfProfileAsync(AxlNetClient.getEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeEndUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeEndUserCapfProfileResponse removeEndUserCapfProfile(AxlNetClient.removeEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeEndUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeEndUserCapfProfileResponse> removeEndUserCapfProfileAsync(AxlNetClient.removeEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listEndUserCapfProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listEndUserCapfProfileResponse listEndUserCapfProfile(AxlNetClient.listEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listEndUserCapfProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listEndUserCapfProfileResponse> listEndUserCapfProfileAsync(AxlNetClient.listEndUserCapfProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateServiceParameter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateServiceParameterResponse updateServiceParameter(AxlNetClient.updateServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateServiceParameter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateServiceParameterResponse> updateServiceParameterAsync(AxlNetClient.updateServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getServiceParameter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getServiceParameterResponse getServiceParameter(AxlNetClient.getServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getServiceParameter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getServiceParameterResponse> getServiceParameterAsync(AxlNetClient.getServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listServiceParameter", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listServiceParameterResponse listServiceParameter(AxlNetClient.listServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listServiceParameter", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listServiceParameterResponse> listServiceParameterAsync(AxlNetClient.listServiceParameterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserPhoneAssociation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUserPhoneAssociationResponse addUserPhoneAssociation(AxlNetClient.addUserPhoneAssociationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserPhoneAssociation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUserPhoneAssociationResponse> addUserPhoneAssociationAsync(AxlNetClient.addUserPhoneAssociationRequest request);
    }

    public class AXLPortClient28 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort28>, AxlNetClient.AXLPort28
    {
        public AXLPortClient28(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getApplicationUserCapfProfileResponse AxlNetClient.AXLPort28.getApplicationUserCapfProfile(AxlNetClient.getApplicationUserCapfProfileRequest request)
        {
            return base.Channel.getApplicationUserCapfProfile(request);
        }

        public AxlNetClient.GetApplicationUserCapfProfileRes getApplicationUserCapfProfile(AxlNetClient.GetApplicationUserCapfProfileReq getApplicationUserCapfProfile1)
        {
            AxlNetClient.getApplicationUserCapfProfileRequest inValue = new AxlNetClient.getApplicationUserCapfProfileRequest();
            inValue.getApplicationUserCapfProfile = getApplicationUserCapfProfile1;
            AxlNetClient.getApplicationUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).getApplicationUserCapfProfile(inValue);
            return retVal.getApplicationUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationUserCapfProfileResponse> AxlNetClient.AXLPort28.getApplicationUserCapfProfileAsync(AxlNetClient.getApplicationUserCapfProfileRequest request)
        {
            return base.Channel.getApplicationUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationUserCapfProfileResponse> getApplicationUserCapfProfileAsync(AxlNetClient.GetApplicationUserCapfProfileReq getApplicationUserCapfProfile)
        {
            AxlNetClient.getApplicationUserCapfProfileRequest inValue = new AxlNetClient.getApplicationUserCapfProfileRequest();
            inValue.getApplicationUserCapfProfile = getApplicationUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).getApplicationUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeApplicationUserCapfProfileResponse AxlNetClient.AXLPort28.removeApplicationUserCapfProfile(AxlNetClient.removeApplicationUserCapfProfileRequest request)
        {
            return base.Channel.removeApplicationUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse removeApplicationUserCapfProfile(AxlNetClient.RemoveApplicationUserCapfProfileReq removeApplicationUserCapfProfile1)
        {
            AxlNetClient.removeApplicationUserCapfProfileRequest inValue = new AxlNetClient.removeApplicationUserCapfProfileRequest();
            inValue.removeApplicationUserCapfProfile = removeApplicationUserCapfProfile1;
            AxlNetClient.removeApplicationUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).removeApplicationUserCapfProfile(inValue);
            return retVal.removeApplicationUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationUserCapfProfileResponse> AxlNetClient.AXLPort28.removeApplicationUserCapfProfileAsync(AxlNetClient.removeApplicationUserCapfProfileRequest request)
        {
            return base.Channel.removeApplicationUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationUserCapfProfileResponse> removeApplicationUserCapfProfileAsync(AxlNetClient.RemoveApplicationUserCapfProfileReq removeApplicationUserCapfProfile)
        {
            AxlNetClient.removeApplicationUserCapfProfileRequest inValue = new AxlNetClient.removeApplicationUserCapfProfileRequest();
            inValue.removeApplicationUserCapfProfile = removeApplicationUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).removeApplicationUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listApplicationUserCapfProfileResponse AxlNetClient.AXLPort28.listApplicationUserCapfProfile(AxlNetClient.listApplicationUserCapfProfileRequest request)
        {
            return base.Channel.listApplicationUserCapfProfile(request);
        }

        public AxlNetClient.ListApplicationUserCapfProfileRes listApplicationUserCapfProfile(AxlNetClient.ListApplicationUserCapfProfileReq listApplicationUserCapfProfile1)
        {
            AxlNetClient.listApplicationUserCapfProfileRequest inValue = new AxlNetClient.listApplicationUserCapfProfileRequest();
            inValue.listApplicationUserCapfProfile = listApplicationUserCapfProfile1;
            AxlNetClient.listApplicationUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).listApplicationUserCapfProfile(inValue);
            return retVal.listApplicationUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationUserCapfProfileResponse> AxlNetClient.AXLPort28.listApplicationUserCapfProfileAsync(AxlNetClient.listApplicationUserCapfProfileRequest request)
        {
            return base.Channel.listApplicationUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationUserCapfProfileResponse> listApplicationUserCapfProfileAsync(AxlNetClient.ListApplicationUserCapfProfileReq listApplicationUserCapfProfile)
        {
            AxlNetClient.listApplicationUserCapfProfileRequest inValue = new AxlNetClient.listApplicationUserCapfProfileRequest();
            inValue.listApplicationUserCapfProfile = listApplicationUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).listApplicationUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addEndUserCapfProfileResponse AxlNetClient.AXLPort28.addEndUserCapfProfile(AxlNetClient.addEndUserCapfProfileRequest request)
        {
            return base.Channel.addEndUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse addEndUserCapfProfile(AxlNetClient.AddEndUserCapfProfileReq addEndUserCapfProfile1)
        {
            AxlNetClient.addEndUserCapfProfileRequest inValue = new AxlNetClient.addEndUserCapfProfileRequest();
            inValue.addEndUserCapfProfile = addEndUserCapfProfile1;
            AxlNetClient.addEndUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).addEndUserCapfProfile(inValue);
            return retVal.addEndUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addEndUserCapfProfileResponse> AxlNetClient.AXLPort28.addEndUserCapfProfileAsync(AxlNetClient.addEndUserCapfProfileRequest request)
        {
            return base.Channel.addEndUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addEndUserCapfProfileResponse> addEndUserCapfProfileAsync(AxlNetClient.AddEndUserCapfProfileReq addEndUserCapfProfile)
        {
            AxlNetClient.addEndUserCapfProfileRequest inValue = new AxlNetClient.addEndUserCapfProfileRequest();
            inValue.addEndUserCapfProfile = addEndUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).addEndUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateEndUserCapfProfileResponse AxlNetClient.AXLPort28.updateEndUserCapfProfile(AxlNetClient.updateEndUserCapfProfileRequest request)
        {
            return base.Channel.updateEndUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse updateEndUserCapfProfile(AxlNetClient.UpdateEndUserCapfProfileReq updateEndUserCapfProfile1)
        {
            AxlNetClient.updateEndUserCapfProfileRequest inValue = new AxlNetClient.updateEndUserCapfProfileRequest();
            inValue.updateEndUserCapfProfile = updateEndUserCapfProfile1;
            AxlNetClient.updateEndUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).updateEndUserCapfProfile(inValue);
            return retVal.updateEndUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateEndUserCapfProfileResponse> AxlNetClient.AXLPort28.updateEndUserCapfProfileAsync(AxlNetClient.updateEndUserCapfProfileRequest request)
        {
            return base.Channel.updateEndUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEndUserCapfProfileResponse> updateEndUserCapfProfileAsync(AxlNetClient.UpdateEndUserCapfProfileReq updateEndUserCapfProfile)
        {
            AxlNetClient.updateEndUserCapfProfileRequest inValue = new AxlNetClient.updateEndUserCapfProfileRequest();
            inValue.updateEndUserCapfProfile = updateEndUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).updateEndUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getEndUserCapfProfileResponse AxlNetClient.AXLPort28.getEndUserCapfProfile(AxlNetClient.getEndUserCapfProfileRequest request)
        {
            return base.Channel.getEndUserCapfProfile(request);
        }

        public AxlNetClient.GetEndUserCapfProfileRes getEndUserCapfProfile(AxlNetClient.GetEndUserCapfProfileReq getEndUserCapfProfile1)
        {
            AxlNetClient.getEndUserCapfProfileRequest inValue = new AxlNetClient.getEndUserCapfProfileRequest();
            inValue.getEndUserCapfProfile = getEndUserCapfProfile1;
            AxlNetClient.getEndUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).getEndUserCapfProfile(inValue);
            return retVal.getEndUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getEndUserCapfProfileResponse> AxlNetClient.AXLPort28.getEndUserCapfProfileAsync(AxlNetClient.getEndUserCapfProfileRequest request)
        {
            return base.Channel.getEndUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEndUserCapfProfileResponse> getEndUserCapfProfileAsync(AxlNetClient.GetEndUserCapfProfileReq getEndUserCapfProfile)
        {
            AxlNetClient.getEndUserCapfProfileRequest inValue = new AxlNetClient.getEndUserCapfProfileRequest();
            inValue.getEndUserCapfProfile = getEndUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).getEndUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeEndUserCapfProfileResponse AxlNetClient.AXLPort28.removeEndUserCapfProfile(AxlNetClient.removeEndUserCapfProfileRequest request)
        {
            return base.Channel.removeEndUserCapfProfile(request);
        }

        public AxlNetClient.StandardResponse removeEndUserCapfProfile(AxlNetClient.RemoveEndUserCapfProfileReq removeEndUserCapfProfile1)
        {
            AxlNetClient.removeEndUserCapfProfileRequest inValue = new AxlNetClient.removeEndUserCapfProfileRequest();
            inValue.removeEndUserCapfProfile = removeEndUserCapfProfile1;
            AxlNetClient.removeEndUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).removeEndUserCapfProfile(inValue);
            return retVal.removeEndUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeEndUserCapfProfileResponse> AxlNetClient.AXLPort28.removeEndUserCapfProfileAsync(AxlNetClient.removeEndUserCapfProfileRequest request)
        {
            return base.Channel.removeEndUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeEndUserCapfProfileResponse> removeEndUserCapfProfileAsync(AxlNetClient.RemoveEndUserCapfProfileReq removeEndUserCapfProfile)
        {
            AxlNetClient.removeEndUserCapfProfileRequest inValue = new AxlNetClient.removeEndUserCapfProfileRequest();
            inValue.removeEndUserCapfProfile = removeEndUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).removeEndUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listEndUserCapfProfileResponse AxlNetClient.AXLPort28.listEndUserCapfProfile(AxlNetClient.listEndUserCapfProfileRequest request)
        {
            return base.Channel.listEndUserCapfProfile(request);
        }

        public AxlNetClient.ListEndUserCapfProfileRes listEndUserCapfProfile(AxlNetClient.ListEndUserCapfProfileReq listEndUserCapfProfile1)
        {
            AxlNetClient.listEndUserCapfProfileRequest inValue = new AxlNetClient.listEndUserCapfProfileRequest();
            inValue.listEndUserCapfProfile = listEndUserCapfProfile1;
            AxlNetClient.listEndUserCapfProfileResponse retVal = ((AxlNetClient.AXLPort28)(this)).listEndUserCapfProfile(inValue);
            return retVal.listEndUserCapfProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listEndUserCapfProfileResponse> AxlNetClient.AXLPort28.listEndUserCapfProfileAsync(AxlNetClient.listEndUserCapfProfileRequest request)
        {
            return base.Channel.listEndUserCapfProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listEndUserCapfProfileResponse> listEndUserCapfProfileAsync(AxlNetClient.ListEndUserCapfProfileReq listEndUserCapfProfile)
        {
            AxlNetClient.listEndUserCapfProfileRequest inValue = new AxlNetClient.listEndUserCapfProfileRequest();
            inValue.listEndUserCapfProfile = listEndUserCapfProfile;
            return ((AxlNetClient.AXLPort28)(this)).listEndUserCapfProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateServiceParameterResponse AxlNetClient.AXLPort28.updateServiceParameter(AxlNetClient.updateServiceParameterRequest request)
        {
            return base.Channel.updateServiceParameter(request);
        }

        public AxlNetClient.StandardResponse updateServiceParameter(AxlNetClient.UpdateServiceParameterReq updateServiceParameter1)
        {
            AxlNetClient.updateServiceParameterRequest inValue = new AxlNetClient.updateServiceParameterRequest();
            inValue.updateServiceParameter = updateServiceParameter1;
            AxlNetClient.updateServiceParameterResponse retVal = ((AxlNetClient.AXLPort28)(this)).updateServiceParameter(inValue);
            return retVal.updateServiceParameterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateServiceParameterResponse> AxlNetClient.AXLPort28.updateServiceParameterAsync(AxlNetClient.updateServiceParameterRequest request)
        {
            return base.Channel.updateServiceParameterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateServiceParameterResponse> updateServiceParameterAsync(AxlNetClient.UpdateServiceParameterReq updateServiceParameter)
        {
            AxlNetClient.updateServiceParameterRequest inValue = new AxlNetClient.updateServiceParameterRequest();
            inValue.updateServiceParameter = updateServiceParameter;
            return ((AxlNetClient.AXLPort28)(this)).updateServiceParameterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getServiceParameterResponse AxlNetClient.AXLPort28.getServiceParameter(AxlNetClient.getServiceParameterRequest request)
        {
            return base.Channel.getServiceParameter(request);
        }

        public AxlNetClient.GetServiceParameterRes getServiceParameter(AxlNetClient.GetServiceParameterReq getServiceParameter1)
        {
            AxlNetClient.getServiceParameterRequest inValue = new AxlNetClient.getServiceParameterRequest();
            inValue.getServiceParameter = getServiceParameter1;
            AxlNetClient.getServiceParameterResponse retVal = ((AxlNetClient.AXLPort28)(this)).getServiceParameter(inValue);
            return retVal.getServiceParameterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getServiceParameterResponse> AxlNetClient.AXLPort28.getServiceParameterAsync(AxlNetClient.getServiceParameterRequest request)
        {
            return base.Channel.getServiceParameterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getServiceParameterResponse> getServiceParameterAsync(AxlNetClient.GetServiceParameterReq getServiceParameter)
        {
            AxlNetClient.getServiceParameterRequest inValue = new AxlNetClient.getServiceParameterRequest();
            inValue.getServiceParameter = getServiceParameter;
            return ((AxlNetClient.AXLPort28)(this)).getServiceParameterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listServiceParameterResponse AxlNetClient.AXLPort28.listServiceParameter(AxlNetClient.listServiceParameterRequest request)
        {
            return base.Channel.listServiceParameter(request);
        }

        public AxlNetClient.ListServiceParameterRes listServiceParameter(AxlNetClient.ListServiceParameterReq listServiceParameter1)
        {
            AxlNetClient.listServiceParameterRequest inValue = new AxlNetClient.listServiceParameterRequest();
            inValue.listServiceParameter = listServiceParameter1;
            AxlNetClient.listServiceParameterResponse retVal = ((AxlNetClient.AXLPort28)(this)).listServiceParameter(inValue);
            return retVal.listServiceParameterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listServiceParameterResponse> AxlNetClient.AXLPort28.listServiceParameterAsync(AxlNetClient.listServiceParameterRequest request)
        {
            return base.Channel.listServiceParameterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listServiceParameterResponse> listServiceParameterAsync(AxlNetClient.ListServiceParameterReq listServiceParameter)
        {
            AxlNetClient.listServiceParameterRequest inValue = new AxlNetClient.listServiceParameterRequest();
            inValue.listServiceParameter = listServiceParameter;
            return ((AxlNetClient.AXLPort28)(this)).listServiceParameterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUserPhoneAssociationResponse AxlNetClient.AXLPort28.addUserPhoneAssociation(AxlNetClient.addUserPhoneAssociationRequest request)
        {
            return base.Channel.addUserPhoneAssociation(request);
        }

        public AxlNetClient.StandardResponse addUserPhoneAssociation(AxlNetClient.AddUserPhoneAssociationReq addUserPhoneAssociation1)
        {
            AxlNetClient.addUserPhoneAssociationRequest inValue = new AxlNetClient.addUserPhoneAssociationRequest();
            inValue.addUserPhoneAssociation = addUserPhoneAssociation1;
            AxlNetClient.addUserPhoneAssociationResponse retVal = ((AxlNetClient.AXLPort28)(this)).addUserPhoneAssociation(inValue);
            return retVal.addUserPhoneAssociationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUserPhoneAssociationResponse> AxlNetClient.AXLPort28.addUserPhoneAssociationAsync(AxlNetClient.addUserPhoneAssociationRequest request)
        {
            return base.Channel.addUserPhoneAssociationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserPhoneAssociationResponse> addUserPhoneAssociationAsync(AxlNetClient.AddUserPhoneAssociationReq addUserPhoneAssociation)
        {
            AxlNetClient.addUserPhoneAssociationRequest inValue = new AxlNetClient.addUserPhoneAssociationRequest();
            inValue.addUserPhoneAssociation = addUserPhoneAssociation;
            return ((AxlNetClient.AXLPort28)(this)).addUserPhoneAssociationAsync(inValue);
        }
    }
}