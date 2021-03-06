namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient78 _axlPortClient78;

        private static AXLPortClient78 axlPortClient78 => _axlPortClient78 == null ||
            _axlPortClient78.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient78 = LoadClient78()) : _axlPortClient78;

        private static AXLPortClient78 LoadClient78()
        {
            var client = new AXLPortClient78(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close78;
            OnAbort += Abort78;
            return client;
        }

        private static void Close78(object sender, System.EventArgs e)
        {
            _axlPortClient78.Close();
        }

        private static void Abort78(object sender, System.EventArgs e)
        {
            _axlPortClient78.Abort();
        }

        public AxlNetClient.getNumDevicesResponse getNumDevices(AxlNetClient.GetNumDevicesReq getNumDevices1)
        {
            return axlPortClient78.getNumDevices(getNumDevices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getNumDevicesResponse1> getNumDevicesAsync(AxlNetClient.GetNumDevicesReq getNumDevices)
        {
            return axlPortClient78.getNumDevicesAsync(getNumDevices);
        }

        public AxlNetClient.StandardResponse addMobility(AxlNetClient.AddMobilityReq addMobility1)
        {
            return axlPortClient78.addMobility(addMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobilityResponse> addMobilityAsync(AxlNetClient.AddMobilityReq addMobility)
        {
            return axlPortClient78.addMobilityAsync(addMobility);
        }

        public AxlNetClient.StandardResponse updateMobility(AxlNetClient.UpdateMobilityReq updateMobility1)
        {
            return axlPortClient78.updateMobility(updateMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobilityResponse> updateMobilityAsync(AxlNetClient.UpdateMobilityReq updateMobility)
        {
            return axlPortClient78.updateMobilityAsync(updateMobility);
        }

        public AxlNetClient.GetMobilityRes getMobility(AxlNetClient.GetMobilityReq getMobility1)
        {
            return axlPortClient78.getMobility(getMobility1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobilityResponse> getMobilityAsync(AxlNetClient.GetMobilityReq getMobility)
        {
            return axlPortClient78.getMobilityAsync(getMobility);
        }

        public AxlNetClient.GetEnterprisePhoneConfigRes getEnterprisePhoneConfig(AxlNetClient.GetEnterprisePhoneConfigReq getEnterprisePhoneConfig1)
        {
            return axlPortClient78.getEnterprisePhoneConfig(getEnterprisePhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEnterprisePhoneConfigResponse> getEnterprisePhoneConfigAsync(AxlNetClient.GetEnterprisePhoneConfigReq getEnterprisePhoneConfig)
        {
            return axlPortClient78.getEnterprisePhoneConfigAsync(getEnterprisePhoneConfig);
        }

        public AxlNetClient.StandardResponse updateEnterprisePhoneConfig(AxlNetClient.UpdateEnterprisePhoneConfigReq updateEnterprisePhoneConfig1)
        {
            return axlPortClient78.updateEnterprisePhoneConfig(updateEnterprisePhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEnterprisePhoneConfigResponse> updateEnterprisePhoneConfigAsync(AxlNetClient.UpdateEnterprisePhoneConfigReq updateEnterprisePhoneConfig)
        {
            return axlPortClient78.updateEnterprisePhoneConfigAsync(updateEnterprisePhoneConfig);
        }

        public AxlNetClient.GetLdapSystemRes getLdapSystem(AxlNetClient.GetLdapSystemReq getLdapSystem1)
        {
            return axlPortClient78.getLdapSystem(getLdapSystem1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSystemResponse> getLdapSystemAsync(AxlNetClient.GetLdapSystemReq getLdapSystem)
        {
            return axlPortClient78.getLdapSystemAsync(getLdapSystem);
        }

        public AxlNetClient.StandardResponse updateLdapSystem(AxlNetClient.UpdateLdapSystemReq updateLdapSystem1)
        {
            return axlPortClient78.updateLdapSystem(updateLdapSystem1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapSystemResponse> updateLdapSystemAsync(AxlNetClient.UpdateLdapSystemReq updateLdapSystem)
        {
            return axlPortClient78.updateLdapSystemAsync(updateLdapSystem);
        }

        public AxlNetClient.GetLdapAuthenticationRes getLdapAuthentication(AxlNetClient.GetLdapAuthenticationReq getLdapAuthentication1)
        {
            return axlPortClient78.getLdapAuthentication(getLdapAuthentication1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapAuthenticationResponse> getLdapAuthenticationAsync(AxlNetClient.GetLdapAuthenticationReq getLdapAuthentication)
        {
            return axlPortClient78.getLdapAuthenticationAsync(getLdapAuthentication);
        }

        public AxlNetClient.StandardResponse updateLdapAuthentication(AxlNetClient.UpdateLdapAuthenticationReq updateLdapAuthentication1)
        {
            return axlPortClient78.updateLdapAuthentication(updateLdapAuthentication1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapAuthenticationResponse> updateLdapAuthenticationAsync(AxlNetClient.UpdateLdapAuthenticationReq updateLdapAuthentication)
        {
            return axlPortClient78.updateLdapAuthenticationAsync(updateLdapAuthentication);
        }

        public AxlNetClient.StandardResponse addApplicationToSoftkeyTemplate(AxlNetClient.AddApplicationToSoftkeyTemplateReq addApplicationToSoftkeyTemplate1)
        {
            return axlPortClient78.addApplicationToSoftkeyTemplate(addApplicationToSoftkeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationToSoftkeyTemplateResponse> addApplicationToSoftkeyTemplateAsync(AxlNetClient.AddApplicationToSoftkeyTemplateReq addApplicationToSoftkeyTemplate)
        {
            return axlPortClient78.addApplicationToSoftkeyTemplateAsync(addApplicationToSoftkeyTemplate);
        }

        public AxlNetClient.StandardResponse removeApplicationToSoftkeyTemplate(AxlNetClient.removeApplicationToSoftkeyTemplateReq removeApplicationToSoftkeyTemplate1)
        {
            return axlPortClient78.removeApplicationToSoftkeyTemplate(removeApplicationToSoftkeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationToSoftkeyTemplateResponse> removeApplicationToSoftkeyTemplateAsync(AxlNetClient.removeApplicationToSoftkeyTemplateReq removeApplicationToSoftkeyTemplate)
        {
            return axlPortClient78.removeApplicationToSoftkeyTemplateAsync(removeApplicationToSoftkeyTemplate);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort78
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getNumDevices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getNumDevicesResponse1 getNumDevices(AxlNetClient.getNumDevicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getNumDevices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getNumDevicesResponse1> getNumDevicesAsync(AxlNetClient.getNumDevicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMobilityResponse addMobility(AxlNetClient.addMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMobilityResponse> addMobilityAsync(AxlNetClient.addMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMobilityResponse updateMobility(AxlNetClient.updateMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMobilityResponse> updateMobilityAsync(AxlNetClient.updateMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobility", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMobilityResponse getMobility(AxlNetClient.getMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobility", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMobilityResponse> getMobilityAsync(AxlNetClient.getMobilityRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEnterprisePhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getEnterprisePhoneConfigResponse getEnterprisePhoneConfig(AxlNetClient.getEnterprisePhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEnterprisePhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getEnterprisePhoneConfigResponse> getEnterprisePhoneConfigAsync(AxlNetClient.getEnterprisePhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEnterprisePhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateEnterprisePhoneConfigResponse updateEnterprisePhoneConfig(AxlNetClient.updateEnterprisePhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEnterprisePhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateEnterprisePhoneConfigResponse> updateEnterprisePhoneConfigAsync(AxlNetClient.updateEnterprisePhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSystem", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapSystemResponse getLdapSystem(AxlNetClient.getLdapSystemRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSystem", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSystemResponse> getLdapSystemAsync(AxlNetClient.getLdapSystemRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapSystem", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLdapSystemResponse updateLdapSystem(AxlNetClient.updateLdapSystemRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapSystem", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapSystemResponse> updateLdapSystemAsync(AxlNetClient.updateLdapSystemRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapAuthentication", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapAuthenticationResponse getLdapAuthentication(AxlNetClient.getLdapAuthenticationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapAuthentication", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapAuthenticationResponse> getLdapAuthenticationAsync(AxlNetClient.getLdapAuthenticationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapAuthentication", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLdapAuthenticationResponse updateLdapAuthentication(AxlNetClient.updateLdapAuthenticationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapAuthentication", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapAuthenticationResponse> updateLdapAuthenticationAsync(AxlNetClient.updateLdapAuthenticationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationToSoftkeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addApplicationToSoftkeyTemplateResponse addApplicationToSoftkeyTemplate(AxlNetClient.addApplicationToSoftkeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationToSoftkeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationToSoftkeyTemplateResponse> addApplicationToSoftkeyTemplateAsync(AxlNetClient.addApplicationToSoftkeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationToSoftkeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeApplicationToSoftkeyTemplateResponse removeApplicationToSoftkeyTemplate(AxlNetClient.removeApplicationToSoftkeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationToSoftkeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationToSoftkeyTemplateResponse> removeApplicationToSoftkeyTemplateAsync(AxlNetClient.removeApplicationToSoftkeyTemplateRequest request);
    }

    public class AXLPortClient78 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort78>, AxlNetClient.AXLPort78
    {
        public AXLPortClient78(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getNumDevicesResponse1 AxlNetClient.AXLPort78.getNumDevices(AxlNetClient.getNumDevicesRequest request)
        {
            return base.Channel.getNumDevices(request);
        }

        public AxlNetClient.getNumDevicesResponse getNumDevices(AxlNetClient.GetNumDevicesReq getNumDevices1)
        {
            AxlNetClient.getNumDevicesRequest inValue = new AxlNetClient.getNumDevicesRequest();
            inValue.getNumDevices = getNumDevices1;
            AxlNetClient.getNumDevicesResponse1 retVal = ((AxlNetClient.AXLPort78)(this)).getNumDevices(inValue);
            return retVal.getNumDevicesResponse;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getNumDevicesResponse1> AxlNetClient.AXLPort78.getNumDevicesAsync(AxlNetClient.getNumDevicesRequest request)
        {
            return base.Channel.getNumDevicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getNumDevicesResponse1> getNumDevicesAsync(AxlNetClient.GetNumDevicesReq getNumDevices)
        {
            AxlNetClient.getNumDevicesRequest inValue = new AxlNetClient.getNumDevicesRequest();
            inValue.getNumDevices = getNumDevices;
            return ((AxlNetClient.AXLPort78)(this)).getNumDevicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMobilityResponse AxlNetClient.AXLPort78.addMobility(AxlNetClient.addMobilityRequest request)
        {
            return base.Channel.addMobility(request);
        }

        public AxlNetClient.StandardResponse addMobility(AxlNetClient.AddMobilityReq addMobility1)
        {
            AxlNetClient.addMobilityRequest inValue = new AxlNetClient.addMobilityRequest();
            inValue.addMobility = addMobility1;
            AxlNetClient.addMobilityResponse retVal = ((AxlNetClient.AXLPort78)(this)).addMobility(inValue);
            return retVal.addMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMobilityResponse> AxlNetClient.AXLPort78.addMobilityAsync(AxlNetClient.addMobilityRequest request)
        {
            return base.Channel.addMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobilityResponse> addMobilityAsync(AxlNetClient.AddMobilityReq addMobility)
        {
            AxlNetClient.addMobilityRequest inValue = new AxlNetClient.addMobilityRequest();
            inValue.addMobility = addMobility;
            return ((AxlNetClient.AXLPort78)(this)).addMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMobilityResponse AxlNetClient.AXLPort78.updateMobility(AxlNetClient.updateMobilityRequest request)
        {
            return base.Channel.updateMobility(request);
        }

        public AxlNetClient.StandardResponse updateMobility(AxlNetClient.UpdateMobilityReq updateMobility1)
        {
            AxlNetClient.updateMobilityRequest inValue = new AxlNetClient.updateMobilityRequest();
            inValue.updateMobility = updateMobility1;
            AxlNetClient.updateMobilityResponse retVal = ((AxlNetClient.AXLPort78)(this)).updateMobility(inValue);
            return retVal.updateMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMobilityResponse> AxlNetClient.AXLPort78.updateMobilityAsync(AxlNetClient.updateMobilityRequest request)
        {
            return base.Channel.updateMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobilityResponse> updateMobilityAsync(AxlNetClient.UpdateMobilityReq updateMobility)
        {
            AxlNetClient.updateMobilityRequest inValue = new AxlNetClient.updateMobilityRequest();
            inValue.updateMobility = updateMobility;
            return ((AxlNetClient.AXLPort78)(this)).updateMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMobilityResponse AxlNetClient.AXLPort78.getMobility(AxlNetClient.getMobilityRequest request)
        {
            return base.Channel.getMobility(request);
        }

        public AxlNetClient.GetMobilityRes getMobility(AxlNetClient.GetMobilityReq getMobility1)
        {
            AxlNetClient.getMobilityRequest inValue = new AxlNetClient.getMobilityRequest();
            inValue.getMobility = getMobility1;
            AxlNetClient.getMobilityResponse retVal = ((AxlNetClient.AXLPort78)(this)).getMobility(inValue);
            return retVal.getMobilityResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMobilityResponse> AxlNetClient.AXLPort78.getMobilityAsync(AxlNetClient.getMobilityRequest request)
        {
            return base.Channel.getMobilityAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobilityResponse> getMobilityAsync(AxlNetClient.GetMobilityReq getMobility)
        {
            AxlNetClient.getMobilityRequest inValue = new AxlNetClient.getMobilityRequest();
            inValue.getMobility = getMobility;
            return ((AxlNetClient.AXLPort78)(this)).getMobilityAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getEnterprisePhoneConfigResponse AxlNetClient.AXLPort78.getEnterprisePhoneConfig(AxlNetClient.getEnterprisePhoneConfigRequest request)
        {
            return base.Channel.getEnterprisePhoneConfig(request);
        }

        public AxlNetClient.GetEnterprisePhoneConfigRes getEnterprisePhoneConfig(AxlNetClient.GetEnterprisePhoneConfigReq getEnterprisePhoneConfig1)
        {
            AxlNetClient.getEnterprisePhoneConfigRequest inValue = new AxlNetClient.getEnterprisePhoneConfigRequest();
            inValue.getEnterprisePhoneConfig = getEnterprisePhoneConfig1;
            AxlNetClient.getEnterprisePhoneConfigResponse retVal = ((AxlNetClient.AXLPort78)(this)).getEnterprisePhoneConfig(inValue);
            return retVal.getEnterprisePhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getEnterprisePhoneConfigResponse> AxlNetClient.AXLPort78.getEnterprisePhoneConfigAsync(AxlNetClient.getEnterprisePhoneConfigRequest request)
        {
            return base.Channel.getEnterprisePhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEnterprisePhoneConfigResponse> getEnterprisePhoneConfigAsync(AxlNetClient.GetEnterprisePhoneConfigReq getEnterprisePhoneConfig)
        {
            AxlNetClient.getEnterprisePhoneConfigRequest inValue = new AxlNetClient.getEnterprisePhoneConfigRequest();
            inValue.getEnterprisePhoneConfig = getEnterprisePhoneConfig;
            return ((AxlNetClient.AXLPort78)(this)).getEnterprisePhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateEnterprisePhoneConfigResponse AxlNetClient.AXLPort78.updateEnterprisePhoneConfig(AxlNetClient.updateEnterprisePhoneConfigRequest request)
        {
            return base.Channel.updateEnterprisePhoneConfig(request);
        }

        public AxlNetClient.StandardResponse updateEnterprisePhoneConfig(AxlNetClient.UpdateEnterprisePhoneConfigReq updateEnterprisePhoneConfig1)
        {
            AxlNetClient.updateEnterprisePhoneConfigRequest inValue = new AxlNetClient.updateEnterprisePhoneConfigRequest();
            inValue.updateEnterprisePhoneConfig = updateEnterprisePhoneConfig1;
            AxlNetClient.updateEnterprisePhoneConfigResponse retVal = ((AxlNetClient.AXLPort78)(this)).updateEnterprisePhoneConfig(inValue);
            return retVal.updateEnterprisePhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateEnterprisePhoneConfigResponse> AxlNetClient.AXLPort78.updateEnterprisePhoneConfigAsync(AxlNetClient.updateEnterprisePhoneConfigRequest request)
        {
            return base.Channel.updateEnterprisePhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEnterprisePhoneConfigResponse> updateEnterprisePhoneConfigAsync(AxlNetClient.UpdateEnterprisePhoneConfigReq updateEnterprisePhoneConfig)
        {
            AxlNetClient.updateEnterprisePhoneConfigRequest inValue = new AxlNetClient.updateEnterprisePhoneConfigRequest();
            inValue.updateEnterprisePhoneConfig = updateEnterprisePhoneConfig;
            return ((AxlNetClient.AXLPort78)(this)).updateEnterprisePhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapSystemResponse AxlNetClient.AXLPort78.getLdapSystem(AxlNetClient.getLdapSystemRequest request)
        {
            return base.Channel.getLdapSystem(request);
        }

        public AxlNetClient.GetLdapSystemRes getLdapSystem(AxlNetClient.GetLdapSystemReq getLdapSystem1)
        {
            AxlNetClient.getLdapSystemRequest inValue = new AxlNetClient.getLdapSystemRequest();
            inValue.getLdapSystem = getLdapSystem1;
            AxlNetClient.getLdapSystemResponse retVal = ((AxlNetClient.AXLPort78)(this)).getLdapSystem(inValue);
            return retVal.getLdapSystemResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSystemResponse> AxlNetClient.AXLPort78.getLdapSystemAsync(AxlNetClient.getLdapSystemRequest request)
        {
            return base.Channel.getLdapSystemAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSystemResponse> getLdapSystemAsync(AxlNetClient.GetLdapSystemReq getLdapSystem)
        {
            AxlNetClient.getLdapSystemRequest inValue = new AxlNetClient.getLdapSystemRequest();
            inValue.getLdapSystem = getLdapSystem;
            return ((AxlNetClient.AXLPort78)(this)).getLdapSystemAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLdapSystemResponse AxlNetClient.AXLPort78.updateLdapSystem(AxlNetClient.updateLdapSystemRequest request)
        {
            return base.Channel.updateLdapSystem(request);
        }

        public AxlNetClient.StandardResponse updateLdapSystem(AxlNetClient.UpdateLdapSystemReq updateLdapSystem1)
        {
            AxlNetClient.updateLdapSystemRequest inValue = new AxlNetClient.updateLdapSystemRequest();
            inValue.updateLdapSystem = updateLdapSystem1;
            AxlNetClient.updateLdapSystemResponse retVal = ((AxlNetClient.AXLPort78)(this)).updateLdapSystem(inValue);
            return retVal.updateLdapSystemResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapSystemResponse> AxlNetClient.AXLPort78.updateLdapSystemAsync(AxlNetClient.updateLdapSystemRequest request)
        {
            return base.Channel.updateLdapSystemAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapSystemResponse> updateLdapSystemAsync(AxlNetClient.UpdateLdapSystemReq updateLdapSystem)
        {
            AxlNetClient.updateLdapSystemRequest inValue = new AxlNetClient.updateLdapSystemRequest();
            inValue.updateLdapSystem = updateLdapSystem;
            return ((AxlNetClient.AXLPort78)(this)).updateLdapSystemAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapAuthenticationResponse AxlNetClient.AXLPort78.getLdapAuthentication(AxlNetClient.getLdapAuthenticationRequest request)
        {
            return base.Channel.getLdapAuthentication(request);
        }

        public AxlNetClient.GetLdapAuthenticationRes getLdapAuthentication(AxlNetClient.GetLdapAuthenticationReq getLdapAuthentication1)
        {
            AxlNetClient.getLdapAuthenticationRequest inValue = new AxlNetClient.getLdapAuthenticationRequest();
            inValue.getLdapAuthentication = getLdapAuthentication1;
            AxlNetClient.getLdapAuthenticationResponse retVal = ((AxlNetClient.AXLPort78)(this)).getLdapAuthentication(inValue);
            return retVal.getLdapAuthenticationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapAuthenticationResponse> AxlNetClient.AXLPort78.getLdapAuthenticationAsync(AxlNetClient.getLdapAuthenticationRequest request)
        {
            return base.Channel.getLdapAuthenticationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapAuthenticationResponse> getLdapAuthenticationAsync(AxlNetClient.GetLdapAuthenticationReq getLdapAuthentication)
        {
            AxlNetClient.getLdapAuthenticationRequest inValue = new AxlNetClient.getLdapAuthenticationRequest();
            inValue.getLdapAuthentication = getLdapAuthentication;
            return ((AxlNetClient.AXLPort78)(this)).getLdapAuthenticationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLdapAuthenticationResponse AxlNetClient.AXLPort78.updateLdapAuthentication(AxlNetClient.updateLdapAuthenticationRequest request)
        {
            return base.Channel.updateLdapAuthentication(request);
        }

        public AxlNetClient.StandardResponse updateLdapAuthentication(AxlNetClient.UpdateLdapAuthenticationReq updateLdapAuthentication1)
        {
            AxlNetClient.updateLdapAuthenticationRequest inValue = new AxlNetClient.updateLdapAuthenticationRequest();
            inValue.updateLdapAuthentication = updateLdapAuthentication1;
            AxlNetClient.updateLdapAuthenticationResponse retVal = ((AxlNetClient.AXLPort78)(this)).updateLdapAuthentication(inValue);
            return retVal.updateLdapAuthenticationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapAuthenticationResponse> AxlNetClient.AXLPort78.updateLdapAuthenticationAsync(AxlNetClient.updateLdapAuthenticationRequest request)
        {
            return base.Channel.updateLdapAuthenticationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapAuthenticationResponse> updateLdapAuthenticationAsync(AxlNetClient.UpdateLdapAuthenticationReq updateLdapAuthentication)
        {
            AxlNetClient.updateLdapAuthenticationRequest inValue = new AxlNetClient.updateLdapAuthenticationRequest();
            inValue.updateLdapAuthentication = updateLdapAuthentication;
            return ((AxlNetClient.AXLPort78)(this)).updateLdapAuthenticationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addApplicationToSoftkeyTemplateResponse AxlNetClient.AXLPort78.addApplicationToSoftkeyTemplate(AxlNetClient.addApplicationToSoftkeyTemplateRequest request)
        {
            return base.Channel.addApplicationToSoftkeyTemplate(request);
        }

        public AxlNetClient.StandardResponse addApplicationToSoftkeyTemplate(AxlNetClient.AddApplicationToSoftkeyTemplateReq addApplicationToSoftkeyTemplate1)
        {
            AxlNetClient.addApplicationToSoftkeyTemplateRequest inValue = new AxlNetClient.addApplicationToSoftkeyTemplateRequest();
            inValue.addApplicationToSoftkeyTemplate = addApplicationToSoftkeyTemplate1;
            AxlNetClient.addApplicationToSoftkeyTemplateResponse retVal = ((AxlNetClient.AXLPort78)(this)).addApplicationToSoftkeyTemplate(inValue);
            return retVal.addApplicationToSoftkeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationToSoftkeyTemplateResponse> AxlNetClient.AXLPort78.addApplicationToSoftkeyTemplateAsync(AxlNetClient.addApplicationToSoftkeyTemplateRequest request)
        {
            return base.Channel.addApplicationToSoftkeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationToSoftkeyTemplateResponse> addApplicationToSoftkeyTemplateAsync(AxlNetClient.AddApplicationToSoftkeyTemplateReq addApplicationToSoftkeyTemplate)
        {
            AxlNetClient.addApplicationToSoftkeyTemplateRequest inValue = new AxlNetClient.addApplicationToSoftkeyTemplateRequest();
            inValue.addApplicationToSoftkeyTemplate = addApplicationToSoftkeyTemplate;
            return ((AxlNetClient.AXLPort78)(this)).addApplicationToSoftkeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeApplicationToSoftkeyTemplateResponse AxlNetClient.AXLPort78.removeApplicationToSoftkeyTemplate(AxlNetClient.removeApplicationToSoftkeyTemplateRequest request)
        {
            return base.Channel.removeApplicationToSoftkeyTemplate(request);
        }

        public AxlNetClient.StandardResponse removeApplicationToSoftkeyTemplate(AxlNetClient.removeApplicationToSoftkeyTemplateReq removeApplicationToSoftkeyTemplate1)
        {
            AxlNetClient.removeApplicationToSoftkeyTemplateRequest inValue = new AxlNetClient.removeApplicationToSoftkeyTemplateRequest();
            inValue.removeApplicationToSoftkeyTemplate = removeApplicationToSoftkeyTemplate1;
            AxlNetClient.removeApplicationToSoftkeyTemplateResponse retVal = ((AxlNetClient.AXLPort78)(this)).removeApplicationToSoftkeyTemplate(inValue);
            return retVal.removeApplicationToSoftkeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationToSoftkeyTemplateResponse> AxlNetClient.AXLPort78.removeApplicationToSoftkeyTemplateAsync(AxlNetClient.removeApplicationToSoftkeyTemplateRequest request)
        {
            return base.Channel.removeApplicationToSoftkeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationToSoftkeyTemplateResponse> removeApplicationToSoftkeyTemplateAsync(AxlNetClient.removeApplicationToSoftkeyTemplateReq removeApplicationToSoftkeyTemplate)
        {
            AxlNetClient.removeApplicationToSoftkeyTemplateRequest inValue = new AxlNetClient.removeApplicationToSoftkeyTemplateRequest();
            inValue.removeApplicationToSoftkeyTemplate = removeApplicationToSoftkeyTemplate;
            return ((AxlNetClient.AXLPort78)(this)).removeApplicationToSoftkeyTemplateAsync(inValue);
        }
    }
}