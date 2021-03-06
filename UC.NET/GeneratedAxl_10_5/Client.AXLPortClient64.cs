namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient64 _axlPortClient64;

        private static AXLPortClient64 axlPortClient64 => _axlPortClient64 == null ||
            _axlPortClient64.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient64 = LoadClient64()) : _axlPortClient64;

        private static AXLPortClient64 LoadClient64()
        {
            var client = new AXLPortClient64(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close64;
            OnAbort += Abort64;
            return client;
        }

        private static void Close64(object sender, System.EventArgs e)
        {
            _axlPortClient64.Close();
        }

        private static void Abort64(object sender, System.EventArgs e)
        {
            _axlPortClient64.Abort();
        }

        public AxlNetClient.ListTvsCertificateRes listTvsCertificate(AxlNetClient.ListTvsCertificateReq listTvsCertificate1)
        {
            return axlPortClient64.listTvsCertificate(listTvsCertificate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTvsCertificateResponse> listTvsCertificateAsync(AxlNetClient.ListTvsCertificateReq listTvsCertificate)
        {
            return axlPortClient64.listTvsCertificateAsync(listTvsCertificate);
        }

        public AxlNetClient.StandardResponse addFeatureControlPolicy(AxlNetClient.AddFeatureControlPolicyReq addFeatureControlPolicy1)
        {
            return axlPortClient64.addFeatureControlPolicy(addFeatureControlPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFeatureControlPolicyResponse> addFeatureControlPolicyAsync(AxlNetClient.AddFeatureControlPolicyReq addFeatureControlPolicy)
        {
            return axlPortClient64.addFeatureControlPolicyAsync(addFeatureControlPolicy);
        }

        public AxlNetClient.StandardResponse updateFeatureControlPolicy(AxlNetClient.UpdateFeatureControlPolicyReq updateFeatureControlPolicy1)
        {
            return axlPortClient64.updateFeatureControlPolicy(updateFeatureControlPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFeatureControlPolicyResponse> updateFeatureControlPolicyAsync(AxlNetClient.UpdateFeatureControlPolicyReq updateFeatureControlPolicy)
        {
            return axlPortClient64.updateFeatureControlPolicyAsync(updateFeatureControlPolicy);
        }

        public AxlNetClient.GetFeatureControlPolicyRes getFeatureControlPolicy(AxlNetClient.GetFeatureControlPolicyReq getFeatureControlPolicy1)
        {
            return axlPortClient64.getFeatureControlPolicy(getFeatureControlPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFeatureControlPolicyResponse> getFeatureControlPolicyAsync(AxlNetClient.GetFeatureControlPolicyReq getFeatureControlPolicy)
        {
            return axlPortClient64.getFeatureControlPolicyAsync(getFeatureControlPolicy);
        }

        public AxlNetClient.StandardResponse removeFeatureControlPolicy(AxlNetClient.NameAndGUIDRequest removeFeatureControlPolicy1)
        {
            return axlPortClient64.removeFeatureControlPolicy(removeFeatureControlPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFeatureControlPolicyResponse> removeFeatureControlPolicyAsync(AxlNetClient.NameAndGUIDRequest removeFeatureControlPolicy)
        {
            return axlPortClient64.removeFeatureControlPolicyAsync(removeFeatureControlPolicy);
        }

        public AxlNetClient.ListFeatureControlPolicyRes listFeatureControlPolicy(AxlNetClient.ListFeatureControlPolicyReq listFeatureControlPolicy1)
        {
            return axlPortClient64.listFeatureControlPolicy(listFeatureControlPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFeatureControlPolicyResponse> listFeatureControlPolicyAsync(AxlNetClient.ListFeatureControlPolicyReq listFeatureControlPolicy)
        {
            return axlPortClient64.listFeatureControlPolicyAsync(listFeatureControlPolicy);
        }

        public AxlNetClient.StandardResponse addMobilityProfile(AxlNetClient.AddMobilityProfileReq addMobilityProfile1)
        {
            return axlPortClient64.addMobilityProfile(addMobilityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobilityProfileResponse> addMobilityProfileAsync(AxlNetClient.AddMobilityProfileReq addMobilityProfile)
        {
            return axlPortClient64.addMobilityProfileAsync(addMobilityProfile);
        }

        public AxlNetClient.StandardResponse updateMobilityProfile(AxlNetClient.UpdateMobilityProfileReq updateMobilityProfile1)
        {
            return axlPortClient64.updateMobilityProfile(updateMobilityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobilityProfileResponse> updateMobilityProfileAsync(AxlNetClient.UpdateMobilityProfileReq updateMobilityProfile)
        {
            return axlPortClient64.updateMobilityProfileAsync(updateMobilityProfile);
        }

        public AxlNetClient.GetMobilityProfileRes getMobilityProfile(AxlNetClient.GetMobilityProfileReq getMobilityProfile1)
        {
            return axlPortClient64.getMobilityProfile(getMobilityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobilityProfileResponse> getMobilityProfileAsync(AxlNetClient.GetMobilityProfileReq getMobilityProfile)
        {
            return axlPortClient64.getMobilityProfileAsync(getMobilityProfile);
        }

        public AxlNetClient.StandardResponse removeMobilityProfile(AxlNetClient.NameAndGUIDRequest removeMobilityProfile1)
        {
            return axlPortClient64.removeMobilityProfile(removeMobilityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMobilityProfileResponse> removeMobilityProfileAsync(AxlNetClient.NameAndGUIDRequest removeMobilityProfile)
        {
            return axlPortClient64.removeMobilityProfileAsync(removeMobilityProfile);
        }

        public AxlNetClient.ListMobilityProfileRes listMobilityProfile(AxlNetClient.ListMobilityProfileReq listMobilityProfile1)
        {
            return axlPortClient64.listMobilityProfile(listMobilityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMobilityProfileResponse> listMobilityProfileAsync(AxlNetClient.ListMobilityProfileReq listMobilityProfile)
        {
            return axlPortClient64.listMobilityProfileAsync(listMobilityProfile);
        }

        public AxlNetClient.StandardResponse addEnterpriseFeatureAccessConfiguration(AxlNetClient.AddEnterpriseFeatureAccessConfigurationReq addEnterpriseFeatureAccessConfiguration1)
        {
            return axlPortClient64.addEnterpriseFeatureAccessConfiguration(addEnterpriseFeatureAccessConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse> addEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.AddEnterpriseFeatureAccessConfigurationReq addEnterpriseFeatureAccessConfiguration)
        {
            return axlPortClient64.addEnterpriseFeatureAccessConfigurationAsync(addEnterpriseFeatureAccessConfiguration);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort64
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTvsCertificate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTvsCertificateResponse listTvsCertificate(AxlNetClient.listTvsCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTvsCertificate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTvsCertificateResponse> listTvsCertificateAsync(AxlNetClient.listTvsCertificateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFeatureControlPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addFeatureControlPolicyResponse addFeatureControlPolicy(AxlNetClient.addFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFeatureControlPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addFeatureControlPolicyResponse> addFeatureControlPolicyAsync(AxlNetClient.addFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFeatureControlPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFeatureControlPolicyResponse updateFeatureControlPolicy(AxlNetClient.updateFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFeatureControlPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFeatureControlPolicyResponse> updateFeatureControlPolicyAsync(AxlNetClient.updateFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFeatureControlPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFeatureControlPolicyResponse getFeatureControlPolicy(AxlNetClient.getFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFeatureControlPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFeatureControlPolicyResponse> getFeatureControlPolicyAsync(AxlNetClient.getFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFeatureControlPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeFeatureControlPolicyResponse removeFeatureControlPolicy(AxlNetClient.removeFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFeatureControlPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeFeatureControlPolicyResponse> removeFeatureControlPolicyAsync(AxlNetClient.removeFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFeatureControlPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listFeatureControlPolicyResponse listFeatureControlPolicy(AxlNetClient.listFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFeatureControlPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listFeatureControlPolicyResponse> listFeatureControlPolicyAsync(AxlNetClient.listFeatureControlPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobilityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMobilityProfileResponse addMobilityProfile(AxlNetClient.addMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobilityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMobilityProfileResponse> addMobilityProfileAsync(AxlNetClient.addMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobilityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMobilityProfileResponse updateMobilityProfile(AxlNetClient.updateMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobilityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMobilityProfileResponse> updateMobilityProfileAsync(AxlNetClient.updateMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobilityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMobilityProfileResponse getMobilityProfile(AxlNetClient.getMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobilityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMobilityProfileResponse> getMobilityProfileAsync(AxlNetClient.getMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMobilityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMobilityProfileResponse removeMobilityProfile(AxlNetClient.removeMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMobilityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMobilityProfileResponse> removeMobilityProfileAsync(AxlNetClient.removeMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMobilityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMobilityProfileResponse listMobilityProfile(AxlNetClient.listMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMobilityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMobilityProfileResponse> listMobilityProfileAsync(AxlNetClient.listMobilityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse addEnterpriseFeatureAccessConfiguration(AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse> addEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest request);
    }

    public class AXLPortClient64 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort64>, AxlNetClient.AXLPort64
    {
        public AXLPortClient64(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTvsCertificateResponse AxlNetClient.AXLPort64.listTvsCertificate(AxlNetClient.listTvsCertificateRequest request)
        {
            return base.Channel.listTvsCertificate(request);
        }

        public AxlNetClient.ListTvsCertificateRes listTvsCertificate(AxlNetClient.ListTvsCertificateReq listTvsCertificate1)
        {
            AxlNetClient.listTvsCertificateRequest inValue = new AxlNetClient.listTvsCertificateRequest();
            inValue.listTvsCertificate = listTvsCertificate1;
            AxlNetClient.listTvsCertificateResponse retVal = ((AxlNetClient.AXLPort64)(this)).listTvsCertificate(inValue);
            return retVal.listTvsCertificateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTvsCertificateResponse> AxlNetClient.AXLPort64.listTvsCertificateAsync(AxlNetClient.listTvsCertificateRequest request)
        {
            return base.Channel.listTvsCertificateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTvsCertificateResponse> listTvsCertificateAsync(AxlNetClient.ListTvsCertificateReq listTvsCertificate)
        {
            AxlNetClient.listTvsCertificateRequest inValue = new AxlNetClient.listTvsCertificateRequest();
            inValue.listTvsCertificate = listTvsCertificate;
            return ((AxlNetClient.AXLPort64)(this)).listTvsCertificateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addFeatureControlPolicyResponse AxlNetClient.AXLPort64.addFeatureControlPolicy(AxlNetClient.addFeatureControlPolicyRequest request)
        {
            return base.Channel.addFeatureControlPolicy(request);
        }

        public AxlNetClient.StandardResponse addFeatureControlPolicy(AxlNetClient.AddFeatureControlPolicyReq addFeatureControlPolicy1)
        {
            AxlNetClient.addFeatureControlPolicyRequest inValue = new AxlNetClient.addFeatureControlPolicyRequest();
            inValue.addFeatureControlPolicy = addFeatureControlPolicy1;
            AxlNetClient.addFeatureControlPolicyResponse retVal = ((AxlNetClient.AXLPort64)(this)).addFeatureControlPolicy(inValue);
            return retVal.addFeatureControlPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addFeatureControlPolicyResponse> AxlNetClient.AXLPort64.addFeatureControlPolicyAsync(AxlNetClient.addFeatureControlPolicyRequest request)
        {
            return base.Channel.addFeatureControlPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFeatureControlPolicyResponse> addFeatureControlPolicyAsync(AxlNetClient.AddFeatureControlPolicyReq addFeatureControlPolicy)
        {
            AxlNetClient.addFeatureControlPolicyRequest inValue = new AxlNetClient.addFeatureControlPolicyRequest();
            inValue.addFeatureControlPolicy = addFeatureControlPolicy;
            return ((AxlNetClient.AXLPort64)(this)).addFeatureControlPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFeatureControlPolicyResponse AxlNetClient.AXLPort64.updateFeatureControlPolicy(AxlNetClient.updateFeatureControlPolicyRequest request)
        {
            return base.Channel.updateFeatureControlPolicy(request);
        }

        public AxlNetClient.StandardResponse updateFeatureControlPolicy(AxlNetClient.UpdateFeatureControlPolicyReq updateFeatureControlPolicy1)
        {
            AxlNetClient.updateFeatureControlPolicyRequest inValue = new AxlNetClient.updateFeatureControlPolicyRequest();
            inValue.updateFeatureControlPolicy = updateFeatureControlPolicy1;
            AxlNetClient.updateFeatureControlPolicyResponse retVal = ((AxlNetClient.AXLPort64)(this)).updateFeatureControlPolicy(inValue);
            return retVal.updateFeatureControlPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFeatureControlPolicyResponse> AxlNetClient.AXLPort64.updateFeatureControlPolicyAsync(AxlNetClient.updateFeatureControlPolicyRequest request)
        {
            return base.Channel.updateFeatureControlPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFeatureControlPolicyResponse> updateFeatureControlPolicyAsync(AxlNetClient.UpdateFeatureControlPolicyReq updateFeatureControlPolicy)
        {
            AxlNetClient.updateFeatureControlPolicyRequest inValue = new AxlNetClient.updateFeatureControlPolicyRequest();
            inValue.updateFeatureControlPolicy = updateFeatureControlPolicy;
            return ((AxlNetClient.AXLPort64)(this)).updateFeatureControlPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFeatureControlPolicyResponse AxlNetClient.AXLPort64.getFeatureControlPolicy(AxlNetClient.getFeatureControlPolicyRequest request)
        {
            return base.Channel.getFeatureControlPolicy(request);
        }

        public AxlNetClient.GetFeatureControlPolicyRes getFeatureControlPolicy(AxlNetClient.GetFeatureControlPolicyReq getFeatureControlPolicy1)
        {
            AxlNetClient.getFeatureControlPolicyRequest inValue = new AxlNetClient.getFeatureControlPolicyRequest();
            inValue.getFeatureControlPolicy = getFeatureControlPolicy1;
            AxlNetClient.getFeatureControlPolicyResponse retVal = ((AxlNetClient.AXLPort64)(this)).getFeatureControlPolicy(inValue);
            return retVal.getFeatureControlPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFeatureControlPolicyResponse> AxlNetClient.AXLPort64.getFeatureControlPolicyAsync(AxlNetClient.getFeatureControlPolicyRequest request)
        {
            return base.Channel.getFeatureControlPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFeatureControlPolicyResponse> getFeatureControlPolicyAsync(AxlNetClient.GetFeatureControlPolicyReq getFeatureControlPolicy)
        {
            AxlNetClient.getFeatureControlPolicyRequest inValue = new AxlNetClient.getFeatureControlPolicyRequest();
            inValue.getFeatureControlPolicy = getFeatureControlPolicy;
            return ((AxlNetClient.AXLPort64)(this)).getFeatureControlPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeFeatureControlPolicyResponse AxlNetClient.AXLPort64.removeFeatureControlPolicy(AxlNetClient.removeFeatureControlPolicyRequest request)
        {
            return base.Channel.removeFeatureControlPolicy(request);
        }

        public AxlNetClient.StandardResponse removeFeatureControlPolicy(AxlNetClient.NameAndGUIDRequest removeFeatureControlPolicy1)
        {
            AxlNetClient.removeFeatureControlPolicyRequest inValue = new AxlNetClient.removeFeatureControlPolicyRequest();
            inValue.removeFeatureControlPolicy = removeFeatureControlPolicy1;
            AxlNetClient.removeFeatureControlPolicyResponse retVal = ((AxlNetClient.AXLPort64)(this)).removeFeatureControlPolicy(inValue);
            return retVal.removeFeatureControlPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeFeatureControlPolicyResponse> AxlNetClient.AXLPort64.removeFeatureControlPolicyAsync(AxlNetClient.removeFeatureControlPolicyRequest request)
        {
            return base.Channel.removeFeatureControlPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFeatureControlPolicyResponse> removeFeatureControlPolicyAsync(AxlNetClient.NameAndGUIDRequest removeFeatureControlPolicy)
        {
            AxlNetClient.removeFeatureControlPolicyRequest inValue = new AxlNetClient.removeFeatureControlPolicyRequest();
            inValue.removeFeatureControlPolicy = removeFeatureControlPolicy;
            return ((AxlNetClient.AXLPort64)(this)).removeFeatureControlPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listFeatureControlPolicyResponse AxlNetClient.AXLPort64.listFeatureControlPolicy(AxlNetClient.listFeatureControlPolicyRequest request)
        {
            return base.Channel.listFeatureControlPolicy(request);
        }

        public AxlNetClient.ListFeatureControlPolicyRes listFeatureControlPolicy(AxlNetClient.ListFeatureControlPolicyReq listFeatureControlPolicy1)
        {
            AxlNetClient.listFeatureControlPolicyRequest inValue = new AxlNetClient.listFeatureControlPolicyRequest();
            inValue.listFeatureControlPolicy = listFeatureControlPolicy1;
            AxlNetClient.listFeatureControlPolicyResponse retVal = ((AxlNetClient.AXLPort64)(this)).listFeatureControlPolicy(inValue);
            return retVal.listFeatureControlPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listFeatureControlPolicyResponse> AxlNetClient.AXLPort64.listFeatureControlPolicyAsync(AxlNetClient.listFeatureControlPolicyRequest request)
        {
            return base.Channel.listFeatureControlPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFeatureControlPolicyResponse> listFeatureControlPolicyAsync(AxlNetClient.ListFeatureControlPolicyReq listFeatureControlPolicy)
        {
            AxlNetClient.listFeatureControlPolicyRequest inValue = new AxlNetClient.listFeatureControlPolicyRequest();
            inValue.listFeatureControlPolicy = listFeatureControlPolicy;
            return ((AxlNetClient.AXLPort64)(this)).listFeatureControlPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMobilityProfileResponse AxlNetClient.AXLPort64.addMobilityProfile(AxlNetClient.addMobilityProfileRequest request)
        {
            return base.Channel.addMobilityProfile(request);
        }

        public AxlNetClient.StandardResponse addMobilityProfile(AxlNetClient.AddMobilityProfileReq addMobilityProfile1)
        {
            AxlNetClient.addMobilityProfileRequest inValue = new AxlNetClient.addMobilityProfileRequest();
            inValue.addMobilityProfile = addMobilityProfile1;
            AxlNetClient.addMobilityProfileResponse retVal = ((AxlNetClient.AXLPort64)(this)).addMobilityProfile(inValue);
            return retVal.addMobilityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMobilityProfileResponse> AxlNetClient.AXLPort64.addMobilityProfileAsync(AxlNetClient.addMobilityProfileRequest request)
        {
            return base.Channel.addMobilityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobilityProfileResponse> addMobilityProfileAsync(AxlNetClient.AddMobilityProfileReq addMobilityProfile)
        {
            AxlNetClient.addMobilityProfileRequest inValue = new AxlNetClient.addMobilityProfileRequest();
            inValue.addMobilityProfile = addMobilityProfile;
            return ((AxlNetClient.AXLPort64)(this)).addMobilityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMobilityProfileResponse AxlNetClient.AXLPort64.updateMobilityProfile(AxlNetClient.updateMobilityProfileRequest request)
        {
            return base.Channel.updateMobilityProfile(request);
        }

        public AxlNetClient.StandardResponse updateMobilityProfile(AxlNetClient.UpdateMobilityProfileReq updateMobilityProfile1)
        {
            AxlNetClient.updateMobilityProfileRequest inValue = new AxlNetClient.updateMobilityProfileRequest();
            inValue.updateMobilityProfile = updateMobilityProfile1;
            AxlNetClient.updateMobilityProfileResponse retVal = ((AxlNetClient.AXLPort64)(this)).updateMobilityProfile(inValue);
            return retVal.updateMobilityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMobilityProfileResponse> AxlNetClient.AXLPort64.updateMobilityProfileAsync(AxlNetClient.updateMobilityProfileRequest request)
        {
            return base.Channel.updateMobilityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobilityProfileResponse> updateMobilityProfileAsync(AxlNetClient.UpdateMobilityProfileReq updateMobilityProfile)
        {
            AxlNetClient.updateMobilityProfileRequest inValue = new AxlNetClient.updateMobilityProfileRequest();
            inValue.updateMobilityProfile = updateMobilityProfile;
            return ((AxlNetClient.AXLPort64)(this)).updateMobilityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMobilityProfileResponse AxlNetClient.AXLPort64.getMobilityProfile(AxlNetClient.getMobilityProfileRequest request)
        {
            return base.Channel.getMobilityProfile(request);
        }

        public AxlNetClient.GetMobilityProfileRes getMobilityProfile(AxlNetClient.GetMobilityProfileReq getMobilityProfile1)
        {
            AxlNetClient.getMobilityProfileRequest inValue = new AxlNetClient.getMobilityProfileRequest();
            inValue.getMobilityProfile = getMobilityProfile1;
            AxlNetClient.getMobilityProfileResponse retVal = ((AxlNetClient.AXLPort64)(this)).getMobilityProfile(inValue);
            return retVal.getMobilityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMobilityProfileResponse> AxlNetClient.AXLPort64.getMobilityProfileAsync(AxlNetClient.getMobilityProfileRequest request)
        {
            return base.Channel.getMobilityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobilityProfileResponse> getMobilityProfileAsync(AxlNetClient.GetMobilityProfileReq getMobilityProfile)
        {
            AxlNetClient.getMobilityProfileRequest inValue = new AxlNetClient.getMobilityProfileRequest();
            inValue.getMobilityProfile = getMobilityProfile;
            return ((AxlNetClient.AXLPort64)(this)).getMobilityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMobilityProfileResponse AxlNetClient.AXLPort64.removeMobilityProfile(AxlNetClient.removeMobilityProfileRequest request)
        {
            return base.Channel.removeMobilityProfile(request);
        }

        public AxlNetClient.StandardResponse removeMobilityProfile(AxlNetClient.NameAndGUIDRequest removeMobilityProfile1)
        {
            AxlNetClient.removeMobilityProfileRequest inValue = new AxlNetClient.removeMobilityProfileRequest();
            inValue.removeMobilityProfile = removeMobilityProfile1;
            AxlNetClient.removeMobilityProfileResponse retVal = ((AxlNetClient.AXLPort64)(this)).removeMobilityProfile(inValue);
            return retVal.removeMobilityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMobilityProfileResponse> AxlNetClient.AXLPort64.removeMobilityProfileAsync(AxlNetClient.removeMobilityProfileRequest request)
        {
            return base.Channel.removeMobilityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMobilityProfileResponse> removeMobilityProfileAsync(AxlNetClient.NameAndGUIDRequest removeMobilityProfile)
        {
            AxlNetClient.removeMobilityProfileRequest inValue = new AxlNetClient.removeMobilityProfileRequest();
            inValue.removeMobilityProfile = removeMobilityProfile;
            return ((AxlNetClient.AXLPort64)(this)).removeMobilityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMobilityProfileResponse AxlNetClient.AXLPort64.listMobilityProfile(AxlNetClient.listMobilityProfileRequest request)
        {
            return base.Channel.listMobilityProfile(request);
        }

        public AxlNetClient.ListMobilityProfileRes listMobilityProfile(AxlNetClient.ListMobilityProfileReq listMobilityProfile1)
        {
            AxlNetClient.listMobilityProfileRequest inValue = new AxlNetClient.listMobilityProfileRequest();
            inValue.listMobilityProfile = listMobilityProfile1;
            AxlNetClient.listMobilityProfileResponse retVal = ((AxlNetClient.AXLPort64)(this)).listMobilityProfile(inValue);
            return retVal.listMobilityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMobilityProfileResponse> AxlNetClient.AXLPort64.listMobilityProfileAsync(AxlNetClient.listMobilityProfileRequest request)
        {
            return base.Channel.listMobilityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMobilityProfileResponse> listMobilityProfileAsync(AxlNetClient.ListMobilityProfileReq listMobilityProfile)
        {
            AxlNetClient.listMobilityProfileRequest inValue = new AxlNetClient.listMobilityProfileRequest();
            inValue.listMobilityProfile = listMobilityProfile;
            return ((AxlNetClient.AXLPort64)(this)).listMobilityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse AxlNetClient.AXLPort64.addEnterpriseFeatureAccessConfiguration(AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.addEnterpriseFeatureAccessConfiguration(request);
        }

        public AxlNetClient.StandardResponse addEnterpriseFeatureAccessConfiguration(AxlNetClient.AddEnterpriseFeatureAccessConfigurationReq addEnterpriseFeatureAccessConfiguration1)
        {
            AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest();
            inValue.addEnterpriseFeatureAccessConfiguration = addEnterpriseFeatureAccessConfiguration1;
            AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse retVal = ((AxlNetClient.AXLPort64)(this)).addEnterpriseFeatureAccessConfiguration(inValue);
            return retVal.addEnterpriseFeatureAccessConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse> AxlNetClient.AXLPort64.addEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.addEnterpriseFeatureAccessConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addEnterpriseFeatureAccessConfigurationResponse> addEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.AddEnterpriseFeatureAccessConfigurationReq addEnterpriseFeatureAccessConfiguration)
        {
            AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.addEnterpriseFeatureAccessConfigurationRequest();
            inValue.addEnterpriseFeatureAccessConfiguration = addEnterpriseFeatureAccessConfiguration;
            return ((AxlNetClient.AXLPort64)(this)).addEnterpriseFeatureAccessConfigurationAsync(inValue);
        }
    }
}