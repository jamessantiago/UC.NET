namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient79 _axlPortClient79;

        private static AXLPortClient79 axlPortClient79 => _axlPortClient79 == null ||
            _axlPortClient79.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient79 = LoadClient79()) : _axlPortClient79;

        private static AXLPortClient79 LoadClient79()
        {
            var client = new AXLPortClient79(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close79;
            OnAbort += Abort79;
            return client;
        }

        private static void Close79(object sender, System.EventArgs e)
        {
            _axlPortClient79.Close();
        }

        private static void Abort79(object sender, System.EventArgs e)
        {
            _axlPortClient79.Abort();
        }

        public AxlNetClient.GetCCMVersionRes getCCMVersion(AxlNetClient.GetCCMVersionReq getCCMVersion1)
        {
            return axlPortClient79.getCCMVersion(getCCMVersion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCCMVersionResponse> getCCMVersionAsync(AxlNetClient.GetCCMVersionReq getCCMVersion)
        {
            return axlPortClient79.getCCMVersionAsync(getCCMVersion);
        }

        public AxlNetClient.StandardResponse removeUnitsToGateway(AxlNetClient.RemoveUnitsToGatewayReq removeUnitsToGateway1)
        {
            return axlPortClient79.removeUnitsToGateway(removeUnitsToGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUnitsToGatewayResponse> removeUnitsToGatewayAsync(AxlNetClient.RemoveUnitsToGatewayReq removeUnitsToGateway)
        {
            return axlPortClient79.removeUnitsToGatewayAsync(removeUnitsToGateway);
        }

        public AxlNetClient.StandardResponse removeGatewaySubunits(AxlNetClient.RemoveGatewaySubunitsReq removeGatewaySubunits1)
        {
            return axlPortClient79.removeGatewaySubunits(removeGatewaySubunits1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewaySubunitsResponse> removeGatewaySubunitsAsync(AxlNetClient.RemoveGatewaySubunitsReq removeGatewaySubunits)
        {
            return axlPortClient79.removeGatewaySubunitsAsync(removeGatewaySubunits);
        }

        public AxlNetClient.StandardResponse updateImeFeatureConfig(AxlNetClient.UpdateImeFeatureConfigReq updateImeFeatureConfig1)
        {
            return axlPortClient79.updateImeFeatureConfig(updateImeFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeFeatureConfigResponse> updateImeFeatureConfigAsync(AxlNetClient.UpdateImeFeatureConfigReq updateImeFeatureConfig)
        {
            return axlPortClient79.updateImeFeatureConfigAsync(updateImeFeatureConfig);
        }

        public AxlNetClient.StandardResponse updateFallbackFeatureConfig(AxlNetClient.UpdateFallbackFeatureConfigReq updateFallbackFeatureConfig1)
        {
            return axlPortClient79.updateFallbackFeatureConfig(updateFallbackFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFallbackFeatureConfigResponse> updateFallbackFeatureConfigAsync(AxlNetClient.UpdateFallbackFeatureConfigReq updateFallbackFeatureConfig)
        {
            return axlPortClient79.updateFallbackFeatureConfigAsync(updateFallbackFeatureConfig);
        }

        public AxlNetClient.StandardResponse removeImeLearnedRoutes(AxlNetClient.RemoveImeLearnedRoutesReq removeImeLearnedRoutes1)
        {
            return axlPortClient79.removeImeLearnedRoutes(removeImeLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeLearnedRoutesResponse> removeImeLearnedRoutesAsync(AxlNetClient.RemoveImeLearnedRoutesReq removeImeLearnedRoutes)
        {
            return axlPortClient79.removeImeLearnedRoutesAsync(removeImeLearnedRoutes);
        }

        public AxlNetClient.StandardResponse updateImeLearnedRoutes(AxlNetClient.UpdateImeLearnedRoutesReq updateImeLearnedRoutes1)
        {
            return axlPortClient79.updateImeLearnedRoutes(updateImeLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeLearnedRoutesResponse> updateImeLearnedRoutesAsync(AxlNetClient.UpdateImeLearnedRoutesReq updateImeLearnedRoutes)
        {
            return axlPortClient79.updateImeLearnedRoutesAsync(updateImeLearnedRoutes);
        }

        public AxlNetClient.GetImeLearnedRoutesRes getImeLearnedRoutes(AxlNetClient.GetImeLearnedRoutesReq getImeLearnedRoutes1)
        {
            return axlPortClient79.getImeLearnedRoutes(getImeLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeLearnedRoutesResponse> getImeLearnedRoutesAsync(AxlNetClient.GetImeLearnedRoutesReq getImeLearnedRoutes)
        {
            return axlPortClient79.getImeLearnedRoutesAsync(getImeLearnedRoutes);
        }

        public AxlNetClient.GetImeFeatureConfigRes getImeFeatureConfig(AxlNetClient.GetImeFeatureConfigReq getImeFeatureConfig1)
        {
            return axlPortClient79.getImeFeatureConfig(getImeFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeFeatureConfigResponse> getImeFeatureConfigAsync(AxlNetClient.GetImeFeatureConfigReq getImeFeatureConfig)
        {
            return axlPortClient79.getImeFeatureConfigAsync(getImeFeatureConfig);
        }

        public AxlNetClient.GetFallbackFeatureConfigRes getFallbackFeatureConfig(AxlNetClient.GetFallbackFeatureConfigReq getFallbackFeatureConfig1)
        {
            return axlPortClient79.getFallbackFeatureConfig(getFallbackFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFallbackFeatureConfigResponse> getFallbackFeatureConfigAsync(AxlNetClient.GetFallbackFeatureConfigReq getFallbackFeatureConfig)
        {
            return axlPortClient79.getFallbackFeatureConfigAsync(getFallbackFeatureConfig);
        }

        public AxlNetClient.GetAppServerInfoRes getAppServerInfo(AxlNetClient.GetAppServerInfoReq getAppServerInfo1)
        {
            return axlPortClient79.getAppServerInfo(getAppServerInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAppServerInfoResponse> getAppServerInfoAsync(AxlNetClient.GetAppServerInfoReq getAppServerInfo)
        {
            return axlPortClient79.getAppServerInfoAsync(getAppServerInfo);
        }

        public AxlNetClient.StandardResponse removeAppServerInfo(AxlNetClient.RemoveAppServerInfoReq removeAppServerInfo1)
        {
            return axlPortClient79.removeAppServerInfo(removeAppServerInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAppServerInfoResponse> removeAppServerInfoAsync(AxlNetClient.RemoveAppServerInfoReq removeAppServerInfo)
        {
            return axlPortClient79.removeAppServerInfoAsync(removeAppServerInfo);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort79
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCCMVersion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCCMVersionResponse getCCMVersion(AxlNetClient.getCCMVersionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCCMVersion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCCMVersionResponse> getCCMVersionAsync(AxlNetClient.getCCMVersionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUnitsToGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUnitsToGatewayResponse removeUnitsToGateway(AxlNetClient.removeUnitsToGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUnitsToGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUnitsToGatewayResponse> removeUnitsToGatewayAsync(AxlNetClient.removeUnitsToGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewaySubunits", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatewaySubunitsResponse removeGatewaySubunits(AxlNetClient.removeGatewaySubunitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatewaySubunits", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewaySubunitsResponse> removeGatewaySubunitsAsync(AxlNetClient.removeGatewaySubunitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeFeatureConfigResponse updateImeFeatureConfig(AxlNetClient.updateImeFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeFeatureConfigResponse> updateImeFeatureConfigAsync(AxlNetClient.updateImeFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFallbackFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFallbackFeatureConfigResponse updateFallbackFeatureConfig(AxlNetClient.updateFallbackFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFallbackFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFallbackFeatureConfigResponse> updateFallbackFeatureConfigAsync(AxlNetClient.updateFallbackFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeLearnedRoutesResponse removeImeLearnedRoutes(AxlNetClient.removeImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeLearnedRoutesResponse> removeImeLearnedRoutesAsync(AxlNetClient.removeImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeLearnedRoutesResponse updateImeLearnedRoutes(AxlNetClient.updateImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeLearnedRoutesResponse> updateImeLearnedRoutesAsync(AxlNetClient.updateImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeLearnedRoutesResponse getImeLearnedRoutes(AxlNetClient.getImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeLearnedRoutesResponse> getImeLearnedRoutesAsync(AxlNetClient.getImeLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeFeatureConfigResponse getImeFeatureConfig(AxlNetClient.getImeFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeFeatureConfigResponse> getImeFeatureConfigAsync(AxlNetClient.getImeFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFallbackFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFallbackFeatureConfigResponse getFallbackFeatureConfig(AxlNetClient.getFallbackFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFallbackFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFallbackFeatureConfigResponse> getFallbackFeatureConfigAsync(AxlNetClient.getFallbackFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAppServerInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAppServerInfoResponse getAppServerInfo(AxlNetClient.getAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAppServerInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAppServerInfoResponse> getAppServerInfoAsync(AxlNetClient.getAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAppServerInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAppServerInfoResponse removeAppServerInfo(AxlNetClient.removeAppServerInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAppServerInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAppServerInfoResponse> removeAppServerInfoAsync(AxlNetClient.removeAppServerInfoRequest request);
    }

    public class AXLPortClient79 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort79>, AxlNetClient.AXLPort79
    {
        public AXLPortClient79(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCCMVersionResponse AxlNetClient.AXLPort79.getCCMVersion(AxlNetClient.getCCMVersionRequest request)
        {
            return base.Channel.getCCMVersion(request);
        }

        public AxlNetClient.GetCCMVersionRes getCCMVersion(AxlNetClient.GetCCMVersionReq getCCMVersion1)
        {
            AxlNetClient.getCCMVersionRequest inValue = new AxlNetClient.getCCMVersionRequest();
            inValue.getCCMVersion = getCCMVersion1;
            AxlNetClient.getCCMVersionResponse retVal = ((AxlNetClient.AXLPort79)(this)).getCCMVersion(inValue);
            return retVal.getCCMVersionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCCMVersionResponse> AxlNetClient.AXLPort79.getCCMVersionAsync(AxlNetClient.getCCMVersionRequest request)
        {
            return base.Channel.getCCMVersionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCCMVersionResponse> getCCMVersionAsync(AxlNetClient.GetCCMVersionReq getCCMVersion)
        {
            AxlNetClient.getCCMVersionRequest inValue = new AxlNetClient.getCCMVersionRequest();
            inValue.getCCMVersion = getCCMVersion;
            return ((AxlNetClient.AXLPort79)(this)).getCCMVersionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUnitsToGatewayResponse AxlNetClient.AXLPort79.removeUnitsToGateway(AxlNetClient.removeUnitsToGatewayRequest request)
        {
            return base.Channel.removeUnitsToGateway(request);
        }

        public AxlNetClient.StandardResponse removeUnitsToGateway(AxlNetClient.RemoveUnitsToGatewayReq removeUnitsToGateway1)
        {
            AxlNetClient.removeUnitsToGatewayRequest inValue = new AxlNetClient.removeUnitsToGatewayRequest();
            inValue.removeUnitsToGateway = removeUnitsToGateway1;
            AxlNetClient.removeUnitsToGatewayResponse retVal = ((AxlNetClient.AXLPort79)(this)).removeUnitsToGateway(inValue);
            return retVal.removeUnitsToGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUnitsToGatewayResponse> AxlNetClient.AXLPort79.removeUnitsToGatewayAsync(AxlNetClient.removeUnitsToGatewayRequest request)
        {
            return base.Channel.removeUnitsToGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUnitsToGatewayResponse> removeUnitsToGatewayAsync(AxlNetClient.RemoveUnitsToGatewayReq removeUnitsToGateway)
        {
            AxlNetClient.removeUnitsToGatewayRequest inValue = new AxlNetClient.removeUnitsToGatewayRequest();
            inValue.removeUnitsToGateway = removeUnitsToGateway;
            return ((AxlNetClient.AXLPort79)(this)).removeUnitsToGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatewaySubunitsResponse AxlNetClient.AXLPort79.removeGatewaySubunits(AxlNetClient.removeGatewaySubunitsRequest request)
        {
            return base.Channel.removeGatewaySubunits(request);
        }

        public AxlNetClient.StandardResponse removeGatewaySubunits(AxlNetClient.RemoveGatewaySubunitsReq removeGatewaySubunits1)
        {
            AxlNetClient.removeGatewaySubunitsRequest inValue = new AxlNetClient.removeGatewaySubunitsRequest();
            inValue.removeGatewaySubunits = removeGatewaySubunits1;
            AxlNetClient.removeGatewaySubunitsResponse retVal = ((AxlNetClient.AXLPort79)(this)).removeGatewaySubunits(inValue);
            return retVal.removeGatewaySubunitsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatewaySubunitsResponse> AxlNetClient.AXLPort79.removeGatewaySubunitsAsync(AxlNetClient.removeGatewaySubunitsRequest request)
        {
            return base.Channel.removeGatewaySubunitsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatewaySubunitsResponse> removeGatewaySubunitsAsync(AxlNetClient.RemoveGatewaySubunitsReq removeGatewaySubunits)
        {
            AxlNetClient.removeGatewaySubunitsRequest inValue = new AxlNetClient.removeGatewaySubunitsRequest();
            inValue.removeGatewaySubunits = removeGatewaySubunits;
            return ((AxlNetClient.AXLPort79)(this)).removeGatewaySubunitsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeFeatureConfigResponse AxlNetClient.AXLPort79.updateImeFeatureConfig(AxlNetClient.updateImeFeatureConfigRequest request)
        {
            return base.Channel.updateImeFeatureConfig(request);
        }

        public AxlNetClient.StandardResponse updateImeFeatureConfig(AxlNetClient.UpdateImeFeatureConfigReq updateImeFeatureConfig1)
        {
            AxlNetClient.updateImeFeatureConfigRequest inValue = new AxlNetClient.updateImeFeatureConfigRequest();
            inValue.updateImeFeatureConfig = updateImeFeatureConfig1;
            AxlNetClient.updateImeFeatureConfigResponse retVal = ((AxlNetClient.AXLPort79)(this)).updateImeFeatureConfig(inValue);
            return retVal.updateImeFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeFeatureConfigResponse> AxlNetClient.AXLPort79.updateImeFeatureConfigAsync(AxlNetClient.updateImeFeatureConfigRequest request)
        {
            return base.Channel.updateImeFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeFeatureConfigResponse> updateImeFeatureConfigAsync(AxlNetClient.UpdateImeFeatureConfigReq updateImeFeatureConfig)
        {
            AxlNetClient.updateImeFeatureConfigRequest inValue = new AxlNetClient.updateImeFeatureConfigRequest();
            inValue.updateImeFeatureConfig = updateImeFeatureConfig;
            return ((AxlNetClient.AXLPort79)(this)).updateImeFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFallbackFeatureConfigResponse AxlNetClient.AXLPort79.updateFallbackFeatureConfig(AxlNetClient.updateFallbackFeatureConfigRequest request)
        {
            return base.Channel.updateFallbackFeatureConfig(request);
        }

        public AxlNetClient.StandardResponse updateFallbackFeatureConfig(AxlNetClient.UpdateFallbackFeatureConfigReq updateFallbackFeatureConfig1)
        {
            AxlNetClient.updateFallbackFeatureConfigRequest inValue = new AxlNetClient.updateFallbackFeatureConfigRequest();
            inValue.updateFallbackFeatureConfig = updateFallbackFeatureConfig1;
            AxlNetClient.updateFallbackFeatureConfigResponse retVal = ((AxlNetClient.AXLPort79)(this)).updateFallbackFeatureConfig(inValue);
            return retVal.updateFallbackFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFallbackFeatureConfigResponse> AxlNetClient.AXLPort79.updateFallbackFeatureConfigAsync(AxlNetClient.updateFallbackFeatureConfigRequest request)
        {
            return base.Channel.updateFallbackFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFallbackFeatureConfigResponse> updateFallbackFeatureConfigAsync(AxlNetClient.UpdateFallbackFeatureConfigReq updateFallbackFeatureConfig)
        {
            AxlNetClient.updateFallbackFeatureConfigRequest inValue = new AxlNetClient.updateFallbackFeatureConfigRequest();
            inValue.updateFallbackFeatureConfig = updateFallbackFeatureConfig;
            return ((AxlNetClient.AXLPort79)(this)).updateFallbackFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeLearnedRoutesResponse AxlNetClient.AXLPort79.removeImeLearnedRoutes(AxlNetClient.removeImeLearnedRoutesRequest request)
        {
            return base.Channel.removeImeLearnedRoutes(request);
        }

        public AxlNetClient.StandardResponse removeImeLearnedRoutes(AxlNetClient.RemoveImeLearnedRoutesReq removeImeLearnedRoutes1)
        {
            AxlNetClient.removeImeLearnedRoutesRequest inValue = new AxlNetClient.removeImeLearnedRoutesRequest();
            inValue.removeImeLearnedRoutes = removeImeLearnedRoutes1;
            AxlNetClient.removeImeLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort79)(this)).removeImeLearnedRoutes(inValue);
            return retVal.removeImeLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeLearnedRoutesResponse> AxlNetClient.AXLPort79.removeImeLearnedRoutesAsync(AxlNetClient.removeImeLearnedRoutesRequest request)
        {
            return base.Channel.removeImeLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeLearnedRoutesResponse> removeImeLearnedRoutesAsync(AxlNetClient.RemoveImeLearnedRoutesReq removeImeLearnedRoutes)
        {
            AxlNetClient.removeImeLearnedRoutesRequest inValue = new AxlNetClient.removeImeLearnedRoutesRequest();
            inValue.removeImeLearnedRoutes = removeImeLearnedRoutes;
            return ((AxlNetClient.AXLPort79)(this)).removeImeLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeLearnedRoutesResponse AxlNetClient.AXLPort79.updateImeLearnedRoutes(AxlNetClient.updateImeLearnedRoutesRequest request)
        {
            return base.Channel.updateImeLearnedRoutes(request);
        }

        public AxlNetClient.StandardResponse updateImeLearnedRoutes(AxlNetClient.UpdateImeLearnedRoutesReq updateImeLearnedRoutes1)
        {
            AxlNetClient.updateImeLearnedRoutesRequest inValue = new AxlNetClient.updateImeLearnedRoutesRequest();
            inValue.updateImeLearnedRoutes = updateImeLearnedRoutes1;
            AxlNetClient.updateImeLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort79)(this)).updateImeLearnedRoutes(inValue);
            return retVal.updateImeLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeLearnedRoutesResponse> AxlNetClient.AXLPort79.updateImeLearnedRoutesAsync(AxlNetClient.updateImeLearnedRoutesRequest request)
        {
            return base.Channel.updateImeLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeLearnedRoutesResponse> updateImeLearnedRoutesAsync(AxlNetClient.UpdateImeLearnedRoutesReq updateImeLearnedRoutes)
        {
            AxlNetClient.updateImeLearnedRoutesRequest inValue = new AxlNetClient.updateImeLearnedRoutesRequest();
            inValue.updateImeLearnedRoutes = updateImeLearnedRoutes;
            return ((AxlNetClient.AXLPort79)(this)).updateImeLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeLearnedRoutesResponse AxlNetClient.AXLPort79.getImeLearnedRoutes(AxlNetClient.getImeLearnedRoutesRequest request)
        {
            return base.Channel.getImeLearnedRoutes(request);
        }

        public AxlNetClient.GetImeLearnedRoutesRes getImeLearnedRoutes(AxlNetClient.GetImeLearnedRoutesReq getImeLearnedRoutes1)
        {
            AxlNetClient.getImeLearnedRoutesRequest inValue = new AxlNetClient.getImeLearnedRoutesRequest();
            inValue.getImeLearnedRoutes = getImeLearnedRoutes1;
            AxlNetClient.getImeLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort79)(this)).getImeLearnedRoutes(inValue);
            return retVal.getImeLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeLearnedRoutesResponse> AxlNetClient.AXLPort79.getImeLearnedRoutesAsync(AxlNetClient.getImeLearnedRoutesRequest request)
        {
            return base.Channel.getImeLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeLearnedRoutesResponse> getImeLearnedRoutesAsync(AxlNetClient.GetImeLearnedRoutesReq getImeLearnedRoutes)
        {
            AxlNetClient.getImeLearnedRoutesRequest inValue = new AxlNetClient.getImeLearnedRoutesRequest();
            inValue.getImeLearnedRoutes = getImeLearnedRoutes;
            return ((AxlNetClient.AXLPort79)(this)).getImeLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeFeatureConfigResponse AxlNetClient.AXLPort79.getImeFeatureConfig(AxlNetClient.getImeFeatureConfigRequest request)
        {
            return base.Channel.getImeFeatureConfig(request);
        }

        public AxlNetClient.GetImeFeatureConfigRes getImeFeatureConfig(AxlNetClient.GetImeFeatureConfigReq getImeFeatureConfig1)
        {
            AxlNetClient.getImeFeatureConfigRequest inValue = new AxlNetClient.getImeFeatureConfigRequest();
            inValue.getImeFeatureConfig = getImeFeatureConfig1;
            AxlNetClient.getImeFeatureConfigResponse retVal = ((AxlNetClient.AXLPort79)(this)).getImeFeatureConfig(inValue);
            return retVal.getImeFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeFeatureConfigResponse> AxlNetClient.AXLPort79.getImeFeatureConfigAsync(AxlNetClient.getImeFeatureConfigRequest request)
        {
            return base.Channel.getImeFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeFeatureConfigResponse> getImeFeatureConfigAsync(AxlNetClient.GetImeFeatureConfigReq getImeFeatureConfig)
        {
            AxlNetClient.getImeFeatureConfigRequest inValue = new AxlNetClient.getImeFeatureConfigRequest();
            inValue.getImeFeatureConfig = getImeFeatureConfig;
            return ((AxlNetClient.AXLPort79)(this)).getImeFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFallbackFeatureConfigResponse AxlNetClient.AXLPort79.getFallbackFeatureConfig(AxlNetClient.getFallbackFeatureConfigRequest request)
        {
            return base.Channel.getFallbackFeatureConfig(request);
        }

        public AxlNetClient.GetFallbackFeatureConfigRes getFallbackFeatureConfig(AxlNetClient.GetFallbackFeatureConfigReq getFallbackFeatureConfig1)
        {
            AxlNetClient.getFallbackFeatureConfigRequest inValue = new AxlNetClient.getFallbackFeatureConfigRequest();
            inValue.getFallbackFeatureConfig = getFallbackFeatureConfig1;
            AxlNetClient.getFallbackFeatureConfigResponse retVal = ((AxlNetClient.AXLPort79)(this)).getFallbackFeatureConfig(inValue);
            return retVal.getFallbackFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFallbackFeatureConfigResponse> AxlNetClient.AXLPort79.getFallbackFeatureConfigAsync(AxlNetClient.getFallbackFeatureConfigRequest request)
        {
            return base.Channel.getFallbackFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFallbackFeatureConfigResponse> getFallbackFeatureConfigAsync(AxlNetClient.GetFallbackFeatureConfigReq getFallbackFeatureConfig)
        {
            AxlNetClient.getFallbackFeatureConfigRequest inValue = new AxlNetClient.getFallbackFeatureConfigRequest();
            inValue.getFallbackFeatureConfig = getFallbackFeatureConfig;
            return ((AxlNetClient.AXLPort79)(this)).getFallbackFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAppServerInfoResponse AxlNetClient.AXLPort79.getAppServerInfo(AxlNetClient.getAppServerInfoRequest request)
        {
            return base.Channel.getAppServerInfo(request);
        }

        public AxlNetClient.GetAppServerInfoRes getAppServerInfo(AxlNetClient.GetAppServerInfoReq getAppServerInfo1)
        {
            AxlNetClient.getAppServerInfoRequest inValue = new AxlNetClient.getAppServerInfoRequest();
            inValue.getAppServerInfo = getAppServerInfo1;
            AxlNetClient.getAppServerInfoResponse retVal = ((AxlNetClient.AXLPort79)(this)).getAppServerInfo(inValue);
            return retVal.getAppServerInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAppServerInfoResponse> AxlNetClient.AXLPort79.getAppServerInfoAsync(AxlNetClient.getAppServerInfoRequest request)
        {
            return base.Channel.getAppServerInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAppServerInfoResponse> getAppServerInfoAsync(AxlNetClient.GetAppServerInfoReq getAppServerInfo)
        {
            AxlNetClient.getAppServerInfoRequest inValue = new AxlNetClient.getAppServerInfoRequest();
            inValue.getAppServerInfo = getAppServerInfo;
            return ((AxlNetClient.AXLPort79)(this)).getAppServerInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAppServerInfoResponse AxlNetClient.AXLPort79.removeAppServerInfo(AxlNetClient.removeAppServerInfoRequest request)
        {
            return base.Channel.removeAppServerInfo(request);
        }

        public AxlNetClient.StandardResponse removeAppServerInfo(AxlNetClient.RemoveAppServerInfoReq removeAppServerInfo1)
        {
            AxlNetClient.removeAppServerInfoRequest inValue = new AxlNetClient.removeAppServerInfoRequest();
            inValue.removeAppServerInfo = removeAppServerInfo1;
            AxlNetClient.removeAppServerInfoResponse retVal = ((AxlNetClient.AXLPort79)(this)).removeAppServerInfo(inValue);
            return retVal.removeAppServerInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAppServerInfoResponse> AxlNetClient.AXLPort79.removeAppServerInfoAsync(AxlNetClient.removeAppServerInfoRequest request)
        {
            return base.Channel.removeAppServerInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAppServerInfoResponse> removeAppServerInfoAsync(AxlNetClient.RemoveAppServerInfoReq removeAppServerInfo)
        {
            AxlNetClient.removeAppServerInfoRequest inValue = new AxlNetClient.removeAppServerInfoRequest();
            inValue.removeAppServerInfo = removeAppServerInfo;
            return ((AxlNetClient.AXLPort79)(this)).removeAppServerInfoAsync(inValue);
        }
    }
}