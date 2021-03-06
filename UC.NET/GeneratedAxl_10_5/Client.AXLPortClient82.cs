namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient82 _axlPortClient82;

        private static AXLPortClient82 axlPortClient82 => _axlPortClient82 == null ||
            _axlPortClient82.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient82 = LoadClient82()) : _axlPortClient82;

        private static AXLPortClient82 LoadClient82()
        {
            var client = new AXLPortClient82(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close82;
            OnAbort += Abort82;
            return client;
        }

        private static void Close82(object sender, System.EventArgs e)
        {
            _axlPortClient82.Close();
        }

        private static void Abort82(object sender, System.EventArgs e)
        {
            _axlPortClient82.Abort();
        }

        public AxlNetClient.StandardResponse removeBillingServer(AxlNetClient.RemoveBillingServerReq removeBillingServer1)
        {
            return axlPortClient82.removeBillingServer(removeBillingServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeBillingServerResponse> removeBillingServerAsync(AxlNetClient.RemoveBillingServerReq removeBillingServer)
        {
            return axlPortClient82.removeBillingServerAsync(removeBillingServer);
        }

        public AxlNetClient.UpdateCcdFeatureConfigRes updateCcdFeatureConfig(AxlNetClient.UpdateCcdFeatureConfigReq updateCcdFeatureConfig1)
        {
            return axlPortClient82.updateCcdFeatureConfig(updateCcdFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdFeatureConfigResponse> updateCcdFeatureConfigAsync(AxlNetClient.UpdateCcdFeatureConfigReq updateCcdFeatureConfig)
        {
            return axlPortClient82.updateCcdFeatureConfigAsync(updateCcdFeatureConfig);
        }

        public AxlNetClient.GetCcdFeatureConfigRes getCcdFeatureConfig(AxlNetClient.GetCcdFeatureConfigReq getCcdFeatureConfig1)
        {
            return axlPortClient82.getCcdFeatureConfig(getCcdFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdFeatureConfigResponse> getCcdFeatureConfigAsync(AxlNetClient.GetCcdFeatureConfigReq getCcdFeatureConfig)
        {
            return axlPortClient82.getCcdFeatureConfigAsync(getCcdFeatureConfig);
        }

        public AxlNetClient.StandardResponse updateRoutePartitionsForLearnedPatterns(AxlNetClient.UpdateRoutePartitionsForLearnedPatternsReq updateRoutePartitionsForLearnedPatterns1)
        {
            return axlPortClient82.updateRoutePartitionsForLearnedPatterns(updateRoutePartitionsForLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse> updateRoutePartitionsForLearnedPatternsAsync(AxlNetClient.UpdateRoutePartitionsForLearnedPatternsReq updateRoutePartitionsForLearnedPatterns)
        {
            return axlPortClient82.updateRoutePartitionsForLearnedPatternsAsync(updateRoutePartitionsForLearnedPatterns);
        }

        public AxlNetClient.StandardResponse updateLocalRouteGroup(AxlNetClient.UpdateLocalRouteGroupReq updateLocalRouteGroup1)
        {
            return axlPortClient82.updateLocalRouteGroup(updateLocalRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLocalRouteGroupResponse> updateLocalRouteGroupAsync(AxlNetClient.UpdateLocalRouteGroupReq updateLocalRouteGroup)
        {
            return axlPortClient82.updateLocalRouteGroupAsync(updateLocalRouteGroup);
        }

        public AxlNetClient.StandardResponse removeLocalRouteGroup(AxlNetClient.RemoveLocalRouteGroupReq removeLocalRouteGroup1)
        {
            return axlPortClient82.removeLocalRouteGroup(removeLocalRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLocalRouteGroupResponse> removeLocalRouteGroupAsync(AxlNetClient.RemoveLocalRouteGroupReq removeLocalRouteGroup)
        {
            return axlPortClient82.removeLocalRouteGroupAsync(removeLocalRouteGroup);
        }

        public AxlNetClient.StandardResponse updatePageLayoutPreferences(AxlNetClient.UpdatePageLayoutPreferencesReq updatePageLayoutPreferences1)
        {
            return axlPortClient82.updatePageLayoutPreferences(updatePageLayoutPreferences1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePageLayoutPreferencesResponse> updatePageLayoutPreferencesAsync(AxlNetClient.UpdatePageLayoutPreferencesReq updatePageLayoutPreferences)
        {
            return axlPortClient82.updatePageLayoutPreferencesAsync(updatePageLayoutPreferences);
        }

        public AxlNetClient.GetPageLayoutPreferencesRes getPageLayoutPreferences(AxlNetClient.GetPageLayoutPreferencesReq getPageLayoutPreferences1)
        {
            return axlPortClient82.getPageLayoutPreferences(getPageLayoutPreferences1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPageLayoutPreferencesResponse> getPageLayoutPreferencesAsync(AxlNetClient.GetPageLayoutPreferencesReq getPageLayoutPreferences)
        {
            return axlPortClient82.getPageLayoutPreferencesAsync(getPageLayoutPreferences);
        }

        public AxlNetClient.StandardResponse assignPresenceUser(AxlNetClient.AssignPresenceUserReq assignPresenceUser1)
        {
            return axlPortClient82.assignPresenceUser(assignPresenceUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.assignPresenceUserResponse> assignPresenceUserAsync(AxlNetClient.AssignPresenceUserReq assignPresenceUser)
        {
            return axlPortClient82.assignPresenceUserAsync(assignPresenceUser);
        }

        public AxlNetClient.StandardResponse unassignPresenceUser(AxlNetClient.UnassignPresenceUserReq unassignPresenceUser1)
        {
            return axlPortClient82.unassignPresenceUser(unassignPresenceUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.unassignPresenceUserResponse> unassignPresenceUserAsync(AxlNetClient.UnassignPresenceUserReq unassignPresenceUser)
        {
            return axlPortClient82.unassignPresenceUserAsync(unassignPresenceUser);
        }

        public AxlNetClient.GetCredentialPolicyDefaultRes getCredentialPolicyDefault(AxlNetClient.GetCredentialPolicyDefaultReq getCredentialPolicyDefault1)
        {
            return axlPortClient82.getCredentialPolicyDefault(getCredentialPolicyDefault1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyDefaultResponse> getCredentialPolicyDefaultAsync(AxlNetClient.GetCredentialPolicyDefaultReq getCredentialPolicyDefault)
        {
            return axlPortClient82.getCredentialPolicyDefaultAsync(getCredentialPolicyDefault);
        }

        public AxlNetClient.StandardResponse updateCredentialPolicyDefault(AxlNetClient.UpdateCredentialPolicyDefaultReq updateCredentialPolicyDefault1)
        {
            return axlPortClient82.updateCredentialPolicyDefault(updateCredentialPolicyDefault1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyDefaultResponse> updateCredentialPolicyDefaultAsync(AxlNetClient.UpdateCredentialPolicyDefaultReq updateCredentialPolicyDefault)
        {
            return axlPortClient82.updateCredentialPolicyDefaultAsync(updateCredentialPolicyDefault);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort82
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeBillingServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeBillingServerResponse removeBillingServer(AxlNetClient.removeBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeBillingServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeBillingServerResponse> removeBillingServerAsync(AxlNetClient.removeBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCcdFeatureConfigResponse updateCcdFeatureConfig(AxlNetClient.updateCcdFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdFeatureConfigResponse> updateCcdFeatureConfigAsync(AxlNetClient.updateCcdFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCcdFeatureConfigResponse getCcdFeatureConfig(AxlNetClient.getCcdFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCcdFeatureConfigResponse> getCcdFeatureConfigAsync(AxlNetClient.getCcdFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePartitionsForLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse updateRoutePartitionsForLearnedPatterns(AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePartitionsForLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse> updateRoutePartitionsForLearnedPatternsAsync(AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLocalRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLocalRouteGroupResponse updateLocalRouteGroup(AxlNetClient.updateLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLocalRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLocalRouteGroupResponse> updateLocalRouteGroupAsync(AxlNetClient.updateLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLocalRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLocalRouteGroupResponse removeLocalRouteGroup(AxlNetClient.removeLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLocalRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLocalRouteGroupResponse> removeLocalRouteGroupAsync(AxlNetClient.removeLocalRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePageLayoutPreferences", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePageLayoutPreferencesResponse updatePageLayoutPreferences(AxlNetClient.updatePageLayoutPreferencesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePageLayoutPreferences", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePageLayoutPreferencesResponse> updatePageLayoutPreferencesAsync(AxlNetClient.updatePageLayoutPreferencesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPageLayoutPreferences", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPageLayoutPreferencesResponse getPageLayoutPreferences(AxlNetClient.getPageLayoutPreferencesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPageLayoutPreferences", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPageLayoutPreferencesResponse> getPageLayoutPreferencesAsync(AxlNetClient.getPageLayoutPreferencesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 assignPresenceUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.assignPresenceUserResponse assignPresenceUser(AxlNetClient.assignPresenceUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 assignPresenceUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.assignPresenceUserResponse> assignPresenceUserAsync(AxlNetClient.assignPresenceUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 unassignPresenceUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.unassignPresenceUserResponse unassignPresenceUser(AxlNetClient.unassignPresenceUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 unassignPresenceUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.unassignPresenceUserResponse> unassignPresenceUserAsync(AxlNetClient.unassignPresenceUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCredentialPolicyDefault", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCredentialPolicyDefaultResponse getCredentialPolicyDefault(AxlNetClient.getCredentialPolicyDefaultRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCredentialPolicyDefault", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyDefaultResponse> getCredentialPolicyDefaultAsync(AxlNetClient.getCredentialPolicyDefaultRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCredentialPolicyDefault", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCredentialPolicyDefaultResponse updateCredentialPolicyDefault(AxlNetClient.updateCredentialPolicyDefaultRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCredentialPolicyDefault", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyDefaultResponse> updateCredentialPolicyDefaultAsync(AxlNetClient.updateCredentialPolicyDefaultRequest request);
    }

    public class AXLPortClient82 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort82>, AxlNetClient.AXLPort82
    {
        public AXLPortClient82(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeBillingServerResponse AxlNetClient.AXLPort82.removeBillingServer(AxlNetClient.removeBillingServerRequest request)
        {
            return base.Channel.removeBillingServer(request);
        }

        public AxlNetClient.StandardResponse removeBillingServer(AxlNetClient.RemoveBillingServerReq removeBillingServer1)
        {
            AxlNetClient.removeBillingServerRequest inValue = new AxlNetClient.removeBillingServerRequest();
            inValue.removeBillingServer = removeBillingServer1;
            AxlNetClient.removeBillingServerResponse retVal = ((AxlNetClient.AXLPort82)(this)).removeBillingServer(inValue);
            return retVal.removeBillingServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeBillingServerResponse> AxlNetClient.AXLPort82.removeBillingServerAsync(AxlNetClient.removeBillingServerRequest request)
        {
            return base.Channel.removeBillingServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeBillingServerResponse> removeBillingServerAsync(AxlNetClient.RemoveBillingServerReq removeBillingServer)
        {
            AxlNetClient.removeBillingServerRequest inValue = new AxlNetClient.removeBillingServerRequest();
            inValue.removeBillingServer = removeBillingServer;
            return ((AxlNetClient.AXLPort82)(this)).removeBillingServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCcdFeatureConfigResponse AxlNetClient.AXLPort82.updateCcdFeatureConfig(AxlNetClient.updateCcdFeatureConfigRequest request)
        {
            return base.Channel.updateCcdFeatureConfig(request);
        }

        public AxlNetClient.UpdateCcdFeatureConfigRes updateCcdFeatureConfig(AxlNetClient.UpdateCcdFeatureConfigReq updateCcdFeatureConfig1)
        {
            AxlNetClient.updateCcdFeatureConfigRequest inValue = new AxlNetClient.updateCcdFeatureConfigRequest();
            inValue.updateCcdFeatureConfig = updateCcdFeatureConfig1;
            AxlNetClient.updateCcdFeatureConfigResponse retVal = ((AxlNetClient.AXLPort82)(this)).updateCcdFeatureConfig(inValue);
            return retVal.updateCcdFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdFeatureConfigResponse> AxlNetClient.AXLPort82.updateCcdFeatureConfigAsync(AxlNetClient.updateCcdFeatureConfigRequest request)
        {
            return base.Channel.updateCcdFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdFeatureConfigResponse> updateCcdFeatureConfigAsync(AxlNetClient.UpdateCcdFeatureConfigReq updateCcdFeatureConfig)
        {
            AxlNetClient.updateCcdFeatureConfigRequest inValue = new AxlNetClient.updateCcdFeatureConfigRequest();
            inValue.updateCcdFeatureConfig = updateCcdFeatureConfig;
            return ((AxlNetClient.AXLPort82)(this)).updateCcdFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCcdFeatureConfigResponse AxlNetClient.AXLPort82.getCcdFeatureConfig(AxlNetClient.getCcdFeatureConfigRequest request)
        {
            return base.Channel.getCcdFeatureConfig(request);
        }

        public AxlNetClient.GetCcdFeatureConfigRes getCcdFeatureConfig(AxlNetClient.GetCcdFeatureConfigReq getCcdFeatureConfig1)
        {
            AxlNetClient.getCcdFeatureConfigRequest inValue = new AxlNetClient.getCcdFeatureConfigRequest();
            inValue.getCcdFeatureConfig = getCcdFeatureConfig1;
            AxlNetClient.getCcdFeatureConfigResponse retVal = ((AxlNetClient.AXLPort82)(this)).getCcdFeatureConfig(inValue);
            return retVal.getCcdFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCcdFeatureConfigResponse> AxlNetClient.AXLPort82.getCcdFeatureConfigAsync(AxlNetClient.getCcdFeatureConfigRequest request)
        {
            return base.Channel.getCcdFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdFeatureConfigResponse> getCcdFeatureConfigAsync(AxlNetClient.GetCcdFeatureConfigReq getCcdFeatureConfig)
        {
            AxlNetClient.getCcdFeatureConfigRequest inValue = new AxlNetClient.getCcdFeatureConfigRequest();
            inValue.getCcdFeatureConfig = getCcdFeatureConfig;
            return ((AxlNetClient.AXLPort82)(this)).getCcdFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse AxlNetClient.AXLPort82.updateRoutePartitionsForLearnedPatterns(AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest request)
        {
            return base.Channel.updateRoutePartitionsForLearnedPatterns(request);
        }

        public AxlNetClient.StandardResponse updateRoutePartitionsForLearnedPatterns(AxlNetClient.UpdateRoutePartitionsForLearnedPatternsReq updateRoutePartitionsForLearnedPatterns1)
        {
            AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest inValue = new AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest();
            inValue.updateRoutePartitionsForLearnedPatterns = updateRoutePartitionsForLearnedPatterns1;
            AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort82)(this)).updateRoutePartitionsForLearnedPatterns(inValue);
            return retVal.updateRoutePartitionsForLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse> AxlNetClient.AXLPort82.updateRoutePartitionsForLearnedPatternsAsync(AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest request)
        {
            return base.Channel.updateRoutePartitionsForLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionsForLearnedPatternsResponse> updateRoutePartitionsForLearnedPatternsAsync(AxlNetClient.UpdateRoutePartitionsForLearnedPatternsReq updateRoutePartitionsForLearnedPatterns)
        {
            AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest inValue = new AxlNetClient.updateRoutePartitionsForLearnedPatternsRequest();
            inValue.updateRoutePartitionsForLearnedPatterns = updateRoutePartitionsForLearnedPatterns;
            return ((AxlNetClient.AXLPort82)(this)).updateRoutePartitionsForLearnedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLocalRouteGroupResponse AxlNetClient.AXLPort82.updateLocalRouteGroup(AxlNetClient.updateLocalRouteGroupRequest request)
        {
            return base.Channel.updateLocalRouteGroup(request);
        }

        public AxlNetClient.StandardResponse updateLocalRouteGroup(AxlNetClient.UpdateLocalRouteGroupReq updateLocalRouteGroup1)
        {
            AxlNetClient.updateLocalRouteGroupRequest inValue = new AxlNetClient.updateLocalRouteGroupRequest();
            inValue.updateLocalRouteGroup = updateLocalRouteGroup1;
            AxlNetClient.updateLocalRouteGroupResponse retVal = ((AxlNetClient.AXLPort82)(this)).updateLocalRouteGroup(inValue);
            return retVal.updateLocalRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLocalRouteGroupResponse> AxlNetClient.AXLPort82.updateLocalRouteGroupAsync(AxlNetClient.updateLocalRouteGroupRequest request)
        {
            return base.Channel.updateLocalRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLocalRouteGroupResponse> updateLocalRouteGroupAsync(AxlNetClient.UpdateLocalRouteGroupReq updateLocalRouteGroup)
        {
            AxlNetClient.updateLocalRouteGroupRequest inValue = new AxlNetClient.updateLocalRouteGroupRequest();
            inValue.updateLocalRouteGroup = updateLocalRouteGroup;
            return ((AxlNetClient.AXLPort82)(this)).updateLocalRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLocalRouteGroupResponse AxlNetClient.AXLPort82.removeLocalRouteGroup(AxlNetClient.removeLocalRouteGroupRequest request)
        {
            return base.Channel.removeLocalRouteGroup(request);
        }

        public AxlNetClient.StandardResponse removeLocalRouteGroup(AxlNetClient.RemoveLocalRouteGroupReq removeLocalRouteGroup1)
        {
            AxlNetClient.removeLocalRouteGroupRequest inValue = new AxlNetClient.removeLocalRouteGroupRequest();
            inValue.removeLocalRouteGroup = removeLocalRouteGroup1;
            AxlNetClient.removeLocalRouteGroupResponse retVal = ((AxlNetClient.AXLPort82)(this)).removeLocalRouteGroup(inValue);
            return retVal.removeLocalRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLocalRouteGroupResponse> AxlNetClient.AXLPort82.removeLocalRouteGroupAsync(AxlNetClient.removeLocalRouteGroupRequest request)
        {
            return base.Channel.removeLocalRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLocalRouteGroupResponse> removeLocalRouteGroupAsync(AxlNetClient.RemoveLocalRouteGroupReq removeLocalRouteGroup)
        {
            AxlNetClient.removeLocalRouteGroupRequest inValue = new AxlNetClient.removeLocalRouteGroupRequest();
            inValue.removeLocalRouteGroup = removeLocalRouteGroup;
            return ((AxlNetClient.AXLPort82)(this)).removeLocalRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePageLayoutPreferencesResponse AxlNetClient.AXLPort82.updatePageLayoutPreferences(AxlNetClient.updatePageLayoutPreferencesRequest request)
        {
            return base.Channel.updatePageLayoutPreferences(request);
        }

        public AxlNetClient.StandardResponse updatePageLayoutPreferences(AxlNetClient.UpdatePageLayoutPreferencesReq updatePageLayoutPreferences1)
        {
            AxlNetClient.updatePageLayoutPreferencesRequest inValue = new AxlNetClient.updatePageLayoutPreferencesRequest();
            inValue.updatePageLayoutPreferences = updatePageLayoutPreferences1;
            AxlNetClient.updatePageLayoutPreferencesResponse retVal = ((AxlNetClient.AXLPort82)(this)).updatePageLayoutPreferences(inValue);
            return retVal.updatePageLayoutPreferencesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePageLayoutPreferencesResponse> AxlNetClient.AXLPort82.updatePageLayoutPreferencesAsync(AxlNetClient.updatePageLayoutPreferencesRequest request)
        {
            return base.Channel.updatePageLayoutPreferencesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePageLayoutPreferencesResponse> updatePageLayoutPreferencesAsync(AxlNetClient.UpdatePageLayoutPreferencesReq updatePageLayoutPreferences)
        {
            AxlNetClient.updatePageLayoutPreferencesRequest inValue = new AxlNetClient.updatePageLayoutPreferencesRequest();
            inValue.updatePageLayoutPreferences = updatePageLayoutPreferences;
            return ((AxlNetClient.AXLPort82)(this)).updatePageLayoutPreferencesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPageLayoutPreferencesResponse AxlNetClient.AXLPort82.getPageLayoutPreferences(AxlNetClient.getPageLayoutPreferencesRequest request)
        {
            return base.Channel.getPageLayoutPreferences(request);
        }

        public AxlNetClient.GetPageLayoutPreferencesRes getPageLayoutPreferences(AxlNetClient.GetPageLayoutPreferencesReq getPageLayoutPreferences1)
        {
            AxlNetClient.getPageLayoutPreferencesRequest inValue = new AxlNetClient.getPageLayoutPreferencesRequest();
            inValue.getPageLayoutPreferences = getPageLayoutPreferences1;
            AxlNetClient.getPageLayoutPreferencesResponse retVal = ((AxlNetClient.AXLPort82)(this)).getPageLayoutPreferences(inValue);
            return retVal.getPageLayoutPreferencesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPageLayoutPreferencesResponse> AxlNetClient.AXLPort82.getPageLayoutPreferencesAsync(AxlNetClient.getPageLayoutPreferencesRequest request)
        {
            return base.Channel.getPageLayoutPreferencesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPageLayoutPreferencesResponse> getPageLayoutPreferencesAsync(AxlNetClient.GetPageLayoutPreferencesReq getPageLayoutPreferences)
        {
            AxlNetClient.getPageLayoutPreferencesRequest inValue = new AxlNetClient.getPageLayoutPreferencesRequest();
            inValue.getPageLayoutPreferences = getPageLayoutPreferences;
            return ((AxlNetClient.AXLPort82)(this)).getPageLayoutPreferencesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.assignPresenceUserResponse AxlNetClient.AXLPort82.assignPresenceUser(AxlNetClient.assignPresenceUserRequest request)
        {
            return base.Channel.assignPresenceUser(request);
        }

        public AxlNetClient.StandardResponse assignPresenceUser(AxlNetClient.AssignPresenceUserReq assignPresenceUser1)
        {
            AxlNetClient.assignPresenceUserRequest inValue = new AxlNetClient.assignPresenceUserRequest();
            inValue.assignPresenceUser = assignPresenceUser1;
            AxlNetClient.assignPresenceUserResponse retVal = ((AxlNetClient.AXLPort82)(this)).assignPresenceUser(inValue);
            return retVal.assignPresenceUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.assignPresenceUserResponse> AxlNetClient.AXLPort82.assignPresenceUserAsync(AxlNetClient.assignPresenceUserRequest request)
        {
            return base.Channel.assignPresenceUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.assignPresenceUserResponse> assignPresenceUserAsync(AxlNetClient.AssignPresenceUserReq assignPresenceUser)
        {
            AxlNetClient.assignPresenceUserRequest inValue = new AxlNetClient.assignPresenceUserRequest();
            inValue.assignPresenceUser = assignPresenceUser;
            return ((AxlNetClient.AXLPort82)(this)).assignPresenceUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.unassignPresenceUserResponse AxlNetClient.AXLPort82.unassignPresenceUser(AxlNetClient.unassignPresenceUserRequest request)
        {
            return base.Channel.unassignPresenceUser(request);
        }

        public AxlNetClient.StandardResponse unassignPresenceUser(AxlNetClient.UnassignPresenceUserReq unassignPresenceUser1)
        {
            AxlNetClient.unassignPresenceUserRequest inValue = new AxlNetClient.unassignPresenceUserRequest();
            inValue.unassignPresenceUser = unassignPresenceUser1;
            AxlNetClient.unassignPresenceUserResponse retVal = ((AxlNetClient.AXLPort82)(this)).unassignPresenceUser(inValue);
            return retVal.unassignPresenceUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.unassignPresenceUserResponse> AxlNetClient.AXLPort82.unassignPresenceUserAsync(AxlNetClient.unassignPresenceUserRequest request)
        {
            return base.Channel.unassignPresenceUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.unassignPresenceUserResponse> unassignPresenceUserAsync(AxlNetClient.UnassignPresenceUserReq unassignPresenceUser)
        {
            AxlNetClient.unassignPresenceUserRequest inValue = new AxlNetClient.unassignPresenceUserRequest();
            inValue.unassignPresenceUser = unassignPresenceUser;
            return ((AxlNetClient.AXLPort82)(this)).unassignPresenceUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCredentialPolicyDefaultResponse AxlNetClient.AXLPort82.getCredentialPolicyDefault(AxlNetClient.getCredentialPolicyDefaultRequest request)
        {
            return base.Channel.getCredentialPolicyDefault(request);
        }

        public AxlNetClient.GetCredentialPolicyDefaultRes getCredentialPolicyDefault(AxlNetClient.GetCredentialPolicyDefaultReq getCredentialPolicyDefault1)
        {
            AxlNetClient.getCredentialPolicyDefaultRequest inValue = new AxlNetClient.getCredentialPolicyDefaultRequest();
            inValue.getCredentialPolicyDefault = getCredentialPolicyDefault1;
            AxlNetClient.getCredentialPolicyDefaultResponse retVal = ((AxlNetClient.AXLPort82)(this)).getCredentialPolicyDefault(inValue);
            return retVal.getCredentialPolicyDefaultResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyDefaultResponse> AxlNetClient.AXLPort82.getCredentialPolicyDefaultAsync(AxlNetClient.getCredentialPolicyDefaultRequest request)
        {
            return base.Channel.getCredentialPolicyDefaultAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyDefaultResponse> getCredentialPolicyDefaultAsync(AxlNetClient.GetCredentialPolicyDefaultReq getCredentialPolicyDefault)
        {
            AxlNetClient.getCredentialPolicyDefaultRequest inValue = new AxlNetClient.getCredentialPolicyDefaultRequest();
            inValue.getCredentialPolicyDefault = getCredentialPolicyDefault;
            return ((AxlNetClient.AXLPort82)(this)).getCredentialPolicyDefaultAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCredentialPolicyDefaultResponse AxlNetClient.AXLPort82.updateCredentialPolicyDefault(AxlNetClient.updateCredentialPolicyDefaultRequest request)
        {
            return base.Channel.updateCredentialPolicyDefault(request);
        }

        public AxlNetClient.StandardResponse updateCredentialPolicyDefault(AxlNetClient.UpdateCredentialPolicyDefaultReq updateCredentialPolicyDefault1)
        {
            AxlNetClient.updateCredentialPolicyDefaultRequest inValue = new AxlNetClient.updateCredentialPolicyDefaultRequest();
            inValue.updateCredentialPolicyDefault = updateCredentialPolicyDefault1;
            AxlNetClient.updateCredentialPolicyDefaultResponse retVal = ((AxlNetClient.AXLPort82)(this)).updateCredentialPolicyDefault(inValue);
            return retVal.updateCredentialPolicyDefaultResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyDefaultResponse> AxlNetClient.AXLPort82.updateCredentialPolicyDefaultAsync(AxlNetClient.updateCredentialPolicyDefaultRequest request)
        {
            return base.Channel.updateCredentialPolicyDefaultAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyDefaultResponse> updateCredentialPolicyDefaultAsync(AxlNetClient.UpdateCredentialPolicyDefaultReq updateCredentialPolicyDefault)
        {
            AxlNetClient.updateCredentialPolicyDefaultRequest inValue = new AxlNetClient.updateCredentialPolicyDefaultRequest();
            inValue.updateCredentialPolicyDefault = updateCredentialPolicyDefault;
            return ((AxlNetClient.AXLPort82)(this)).updateCredentialPolicyDefaultAsync(inValue);
        }
    }
}