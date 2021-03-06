namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient56 _axlPortClient56;

        private static AXLPortClient56 axlPortClient56 => _axlPortClient56 == null ||
            _axlPortClient56.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient56 = LoadClient56()) : _axlPortClient56;

        private static AXLPortClient56 LoadClient56()
        {
            var client = new AXLPortClient56(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close56;
            OnAbort += Abort56;
            return client;
        }

        private static void Close56(object sender, System.EventArgs e)
        {
            _axlPortClient56.Close();
        }

        private static void Abort56(object sender, System.EventArgs e)
        {
            _axlPortClient56.Abort();
        }

        public AxlNetClient.StandardResponse addLdapDirectory(AxlNetClient.AddLdapDirectoryReq addLdapDirectory1)
        {
            return axlPortClient56.addLdapDirectory(addLdapDirectory1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapDirectoryResponse> addLdapDirectoryAsync(AxlNetClient.AddLdapDirectoryReq addLdapDirectory)
        {
            return axlPortClient56.addLdapDirectoryAsync(addLdapDirectory);
        }

        public AxlNetClient.StandardResponse updateLdapDirectory(AxlNetClient.UpdateLdapDirectoryReq updateLdapDirectory1)
        {
            return axlPortClient56.updateLdapDirectory(updateLdapDirectory1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapDirectoryResponse> updateLdapDirectoryAsync(AxlNetClient.UpdateLdapDirectoryReq updateLdapDirectory)
        {
            return axlPortClient56.updateLdapDirectoryAsync(updateLdapDirectory);
        }

        public AxlNetClient.GetLdapDirectoryRes getLdapDirectory(AxlNetClient.GetLdapDirectoryReq getLdapDirectory1)
        {
            return axlPortClient56.getLdapDirectory(getLdapDirectory1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapDirectoryResponse> getLdapDirectoryAsync(AxlNetClient.GetLdapDirectoryReq getLdapDirectory)
        {
            return axlPortClient56.getLdapDirectoryAsync(getLdapDirectory);
        }

        public AxlNetClient.StandardResponse removeLdapDirectory(AxlNetClient.NameAndGUIDRequest removeLdapDirectory1)
        {
            return axlPortClient56.removeLdapDirectory(removeLdapDirectory1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapDirectoryResponse> removeLdapDirectoryAsync(AxlNetClient.NameAndGUIDRequest removeLdapDirectory)
        {
            return axlPortClient56.removeLdapDirectoryAsync(removeLdapDirectory);
        }

        public AxlNetClient.ListLdapDirectoryRes listLdapDirectory(AxlNetClient.ListLdapDirectoryReq listLdapDirectory1)
        {
            return axlPortClient56.listLdapDirectory(listLdapDirectory1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapDirectoryResponse> listLdapDirectoryAsync(AxlNetClient.ListLdapDirectoryReq listLdapDirectory)
        {
            return axlPortClient56.listLdapDirectoryAsync(listLdapDirectory);
        }

        public AxlNetClient.StandardResponse updateEmccFeatureConfig(AxlNetClient.UpdateEmccFeatureConfigReq updateEmccFeatureConfig1)
        {
            return axlPortClient56.updateEmccFeatureConfig(updateEmccFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEmccFeatureConfigResponse> updateEmccFeatureConfigAsync(AxlNetClient.UpdateEmccFeatureConfigReq updateEmccFeatureConfig)
        {
            return axlPortClient56.updateEmccFeatureConfigAsync(updateEmccFeatureConfig);
        }

        public AxlNetClient.GetEmccFeatureConfigRes getEmccFeatureConfig(AxlNetClient.GetEmccFeatureConfigReq getEmccFeatureConfig1)
        {
            return axlPortClient56.getEmccFeatureConfig(getEmccFeatureConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEmccFeatureConfigResponse> getEmccFeatureConfigAsync(AxlNetClient.GetEmccFeatureConfigReq getEmccFeatureConfig)
        {
            return axlPortClient56.getEmccFeatureConfigAsync(getEmccFeatureConfig);
        }

        public AxlNetClient.StandardResponse addSafCcdPurgeBlockLearnedRoutes(AxlNetClient.AddSafCcdPurgeBlockLearnedRoutesReq addSafCcdPurgeBlockLearnedRoutes1)
        {
            return axlPortClient56.addSafCcdPurgeBlockLearnedRoutes(addSafCcdPurgeBlockLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse> addSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.AddSafCcdPurgeBlockLearnedRoutesReq addSafCcdPurgeBlockLearnedRoutes)
        {
            return axlPortClient56.addSafCcdPurgeBlockLearnedRoutesAsync(addSafCcdPurgeBlockLearnedRoutes);
        }

        public AxlNetClient.StandardResponse updateSafCcdPurgeBlockLearnedRoutes(AxlNetClient.UpdateSafCcdPurgeBlockLearnedRoutesReq updateSafCcdPurgeBlockLearnedRoutes1)
        {
            return axlPortClient56.updateSafCcdPurgeBlockLearnedRoutes(updateSafCcdPurgeBlockLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse> updateSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.UpdateSafCcdPurgeBlockLearnedRoutesReq updateSafCcdPurgeBlockLearnedRoutes)
        {
            return axlPortClient56.updateSafCcdPurgeBlockLearnedRoutesAsync(updateSafCcdPurgeBlockLearnedRoutes);
        }

        public AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesRes getSafCcdPurgeBlockLearnedRoutes(AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesReq getSafCcdPurgeBlockLearnedRoutes1)
        {
            return axlPortClient56.getSafCcdPurgeBlockLearnedRoutes(getSafCcdPurgeBlockLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse> getSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesReq getSafCcdPurgeBlockLearnedRoutes)
        {
            return axlPortClient56.getSafCcdPurgeBlockLearnedRoutesAsync(getSafCcdPurgeBlockLearnedRoutes);
        }

        public AxlNetClient.StandardResponse removeSafCcdPurgeBlockLearnedRoutes(AxlNetClient.RemoveSafCcdPurgeBlockLearnedRoutesReq removeSafCcdPurgeBlockLearnedRoutes1)
        {
            return axlPortClient56.removeSafCcdPurgeBlockLearnedRoutes(removeSafCcdPurgeBlockLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse> removeSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.RemoveSafCcdPurgeBlockLearnedRoutesReq removeSafCcdPurgeBlockLearnedRoutes)
        {
            return axlPortClient56.removeSafCcdPurgeBlockLearnedRoutesAsync(removeSafCcdPurgeBlockLearnedRoutes);
        }

        public AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesRes listSafCcdPurgeBlockLearnedRoutes(AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesReq listSafCcdPurgeBlockLearnedRoutes1)
        {
            return axlPortClient56.listSafCcdPurgeBlockLearnedRoutes(listSafCcdPurgeBlockLearnedRoutes1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse> listSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesReq listSafCcdPurgeBlockLearnedRoutes)
        {
            return axlPortClient56.listSafCcdPurgeBlockLearnedRoutesAsync(listSafCcdPurgeBlockLearnedRoutes);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort56
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapDirectory", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLdapDirectoryResponse addLdapDirectory(AxlNetClient.addLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLdapDirectory", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLdapDirectoryResponse> addLdapDirectoryAsync(AxlNetClient.addLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapDirectory", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLdapDirectoryResponse updateLdapDirectory(AxlNetClient.updateLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLdapDirectory", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapDirectoryResponse> updateLdapDirectoryAsync(AxlNetClient.updateLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapDirectory", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapDirectoryResponse getLdapDirectory(AxlNetClient.getLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapDirectory", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapDirectoryResponse> getLdapDirectoryAsync(AxlNetClient.getLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapDirectory", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLdapDirectoryResponse removeLdapDirectory(AxlNetClient.removeLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLdapDirectory", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapDirectoryResponse> removeLdapDirectoryAsync(AxlNetClient.removeLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapDirectory", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLdapDirectoryResponse listLdapDirectory(AxlNetClient.listLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapDirectory", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLdapDirectoryResponse> listLdapDirectoryAsync(AxlNetClient.listLdapDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEmccFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateEmccFeatureConfigResponse updateEmccFeatureConfig(AxlNetClient.updateEmccFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEmccFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateEmccFeatureConfigResponse> updateEmccFeatureConfigAsync(AxlNetClient.updateEmccFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEmccFeatureConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getEmccFeatureConfigResponse getEmccFeatureConfig(AxlNetClient.getEmccFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEmccFeatureConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getEmccFeatureConfigResponse> getEmccFeatureConfigAsync(AxlNetClient.getEmccFeatureConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse addSafCcdPurgeBlockLearnedRoutes(AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse> addSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse updateSafCcdPurgeBlockLearnedRoutes(AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse> updateSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse getSafCcdPurgeBlockLearnedRoutes(AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse> getSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse removeSafCcdPurgeBlockLearnedRoutes(AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse> removeSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse listSafCcdPurgeBlockLearnedRoutes(AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafCcdPurgeBlockLearnedRoutes", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse> listSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest request);
    }

    public class AXLPortClient56 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort56>, AxlNetClient.AXLPort56
    {
        public AXLPortClient56(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLdapDirectoryResponse AxlNetClient.AXLPort56.addLdapDirectory(AxlNetClient.addLdapDirectoryRequest request)
        {
            return base.Channel.addLdapDirectory(request);
        }

        public AxlNetClient.StandardResponse addLdapDirectory(AxlNetClient.AddLdapDirectoryReq addLdapDirectory1)
        {
            AxlNetClient.addLdapDirectoryRequest inValue = new AxlNetClient.addLdapDirectoryRequest();
            inValue.addLdapDirectory = addLdapDirectory1;
            AxlNetClient.addLdapDirectoryResponse retVal = ((AxlNetClient.AXLPort56)(this)).addLdapDirectory(inValue);
            return retVal.addLdapDirectoryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLdapDirectoryResponse> AxlNetClient.AXLPort56.addLdapDirectoryAsync(AxlNetClient.addLdapDirectoryRequest request)
        {
            return base.Channel.addLdapDirectoryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLdapDirectoryResponse> addLdapDirectoryAsync(AxlNetClient.AddLdapDirectoryReq addLdapDirectory)
        {
            AxlNetClient.addLdapDirectoryRequest inValue = new AxlNetClient.addLdapDirectoryRequest();
            inValue.addLdapDirectory = addLdapDirectory;
            return ((AxlNetClient.AXLPort56)(this)).addLdapDirectoryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLdapDirectoryResponse AxlNetClient.AXLPort56.updateLdapDirectory(AxlNetClient.updateLdapDirectoryRequest request)
        {
            return base.Channel.updateLdapDirectory(request);
        }

        public AxlNetClient.StandardResponse updateLdapDirectory(AxlNetClient.UpdateLdapDirectoryReq updateLdapDirectory1)
        {
            AxlNetClient.updateLdapDirectoryRequest inValue = new AxlNetClient.updateLdapDirectoryRequest();
            inValue.updateLdapDirectory = updateLdapDirectory1;
            AxlNetClient.updateLdapDirectoryResponse retVal = ((AxlNetClient.AXLPort56)(this)).updateLdapDirectory(inValue);
            return retVal.updateLdapDirectoryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLdapDirectoryResponse> AxlNetClient.AXLPort56.updateLdapDirectoryAsync(AxlNetClient.updateLdapDirectoryRequest request)
        {
            return base.Channel.updateLdapDirectoryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLdapDirectoryResponse> updateLdapDirectoryAsync(AxlNetClient.UpdateLdapDirectoryReq updateLdapDirectory)
        {
            AxlNetClient.updateLdapDirectoryRequest inValue = new AxlNetClient.updateLdapDirectoryRequest();
            inValue.updateLdapDirectory = updateLdapDirectory;
            return ((AxlNetClient.AXLPort56)(this)).updateLdapDirectoryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapDirectoryResponse AxlNetClient.AXLPort56.getLdapDirectory(AxlNetClient.getLdapDirectoryRequest request)
        {
            return base.Channel.getLdapDirectory(request);
        }

        public AxlNetClient.GetLdapDirectoryRes getLdapDirectory(AxlNetClient.GetLdapDirectoryReq getLdapDirectory1)
        {
            AxlNetClient.getLdapDirectoryRequest inValue = new AxlNetClient.getLdapDirectoryRequest();
            inValue.getLdapDirectory = getLdapDirectory1;
            AxlNetClient.getLdapDirectoryResponse retVal = ((AxlNetClient.AXLPort56)(this)).getLdapDirectory(inValue);
            return retVal.getLdapDirectoryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapDirectoryResponse> AxlNetClient.AXLPort56.getLdapDirectoryAsync(AxlNetClient.getLdapDirectoryRequest request)
        {
            return base.Channel.getLdapDirectoryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapDirectoryResponse> getLdapDirectoryAsync(AxlNetClient.GetLdapDirectoryReq getLdapDirectory)
        {
            AxlNetClient.getLdapDirectoryRequest inValue = new AxlNetClient.getLdapDirectoryRequest();
            inValue.getLdapDirectory = getLdapDirectory;
            return ((AxlNetClient.AXLPort56)(this)).getLdapDirectoryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLdapDirectoryResponse AxlNetClient.AXLPort56.removeLdapDirectory(AxlNetClient.removeLdapDirectoryRequest request)
        {
            return base.Channel.removeLdapDirectory(request);
        }

        public AxlNetClient.StandardResponse removeLdapDirectory(AxlNetClient.NameAndGUIDRequest removeLdapDirectory1)
        {
            AxlNetClient.removeLdapDirectoryRequest inValue = new AxlNetClient.removeLdapDirectoryRequest();
            inValue.removeLdapDirectory = removeLdapDirectory1;
            AxlNetClient.removeLdapDirectoryResponse retVal = ((AxlNetClient.AXLPort56)(this)).removeLdapDirectory(inValue);
            return retVal.removeLdapDirectoryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLdapDirectoryResponse> AxlNetClient.AXLPort56.removeLdapDirectoryAsync(AxlNetClient.removeLdapDirectoryRequest request)
        {
            return base.Channel.removeLdapDirectoryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLdapDirectoryResponse> removeLdapDirectoryAsync(AxlNetClient.NameAndGUIDRequest removeLdapDirectory)
        {
            AxlNetClient.removeLdapDirectoryRequest inValue = new AxlNetClient.removeLdapDirectoryRequest();
            inValue.removeLdapDirectory = removeLdapDirectory;
            return ((AxlNetClient.AXLPort56)(this)).removeLdapDirectoryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLdapDirectoryResponse AxlNetClient.AXLPort56.listLdapDirectory(AxlNetClient.listLdapDirectoryRequest request)
        {
            return base.Channel.listLdapDirectory(request);
        }

        public AxlNetClient.ListLdapDirectoryRes listLdapDirectory(AxlNetClient.ListLdapDirectoryReq listLdapDirectory1)
        {
            AxlNetClient.listLdapDirectoryRequest inValue = new AxlNetClient.listLdapDirectoryRequest();
            inValue.listLdapDirectory = listLdapDirectory1;
            AxlNetClient.listLdapDirectoryResponse retVal = ((AxlNetClient.AXLPort56)(this)).listLdapDirectory(inValue);
            return retVal.listLdapDirectoryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLdapDirectoryResponse> AxlNetClient.AXLPort56.listLdapDirectoryAsync(AxlNetClient.listLdapDirectoryRequest request)
        {
            return base.Channel.listLdapDirectoryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapDirectoryResponse> listLdapDirectoryAsync(AxlNetClient.ListLdapDirectoryReq listLdapDirectory)
        {
            AxlNetClient.listLdapDirectoryRequest inValue = new AxlNetClient.listLdapDirectoryRequest();
            inValue.listLdapDirectory = listLdapDirectory;
            return ((AxlNetClient.AXLPort56)(this)).listLdapDirectoryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateEmccFeatureConfigResponse AxlNetClient.AXLPort56.updateEmccFeatureConfig(AxlNetClient.updateEmccFeatureConfigRequest request)
        {
            return base.Channel.updateEmccFeatureConfig(request);
        }

        public AxlNetClient.StandardResponse updateEmccFeatureConfig(AxlNetClient.UpdateEmccFeatureConfigReq updateEmccFeatureConfig1)
        {
            AxlNetClient.updateEmccFeatureConfigRequest inValue = new AxlNetClient.updateEmccFeatureConfigRequest();
            inValue.updateEmccFeatureConfig = updateEmccFeatureConfig1;
            AxlNetClient.updateEmccFeatureConfigResponse retVal = ((AxlNetClient.AXLPort56)(this)).updateEmccFeatureConfig(inValue);
            return retVal.updateEmccFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateEmccFeatureConfigResponse> AxlNetClient.AXLPort56.updateEmccFeatureConfigAsync(AxlNetClient.updateEmccFeatureConfigRequest request)
        {
            return base.Channel.updateEmccFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEmccFeatureConfigResponse> updateEmccFeatureConfigAsync(AxlNetClient.UpdateEmccFeatureConfigReq updateEmccFeatureConfig)
        {
            AxlNetClient.updateEmccFeatureConfigRequest inValue = new AxlNetClient.updateEmccFeatureConfigRequest();
            inValue.updateEmccFeatureConfig = updateEmccFeatureConfig;
            return ((AxlNetClient.AXLPort56)(this)).updateEmccFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getEmccFeatureConfigResponse AxlNetClient.AXLPort56.getEmccFeatureConfig(AxlNetClient.getEmccFeatureConfigRequest request)
        {
            return base.Channel.getEmccFeatureConfig(request);
        }

        public AxlNetClient.GetEmccFeatureConfigRes getEmccFeatureConfig(AxlNetClient.GetEmccFeatureConfigReq getEmccFeatureConfig1)
        {
            AxlNetClient.getEmccFeatureConfigRequest inValue = new AxlNetClient.getEmccFeatureConfigRequest();
            inValue.getEmccFeatureConfig = getEmccFeatureConfig1;
            AxlNetClient.getEmccFeatureConfigResponse retVal = ((AxlNetClient.AXLPort56)(this)).getEmccFeatureConfig(inValue);
            return retVal.getEmccFeatureConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getEmccFeatureConfigResponse> AxlNetClient.AXLPort56.getEmccFeatureConfigAsync(AxlNetClient.getEmccFeatureConfigRequest request)
        {
            return base.Channel.getEmccFeatureConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEmccFeatureConfigResponse> getEmccFeatureConfigAsync(AxlNetClient.GetEmccFeatureConfigReq getEmccFeatureConfig)
        {
            AxlNetClient.getEmccFeatureConfigRequest inValue = new AxlNetClient.getEmccFeatureConfigRequest();
            inValue.getEmccFeatureConfig = getEmccFeatureConfig;
            return ((AxlNetClient.AXLPort56)(this)).getEmccFeatureConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse AxlNetClient.AXLPort56.addSafCcdPurgeBlockLearnedRoutes(AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.addSafCcdPurgeBlockLearnedRoutes(request);
        }

        public AxlNetClient.StandardResponse addSafCcdPurgeBlockLearnedRoutes(AxlNetClient.AddSafCcdPurgeBlockLearnedRoutesReq addSafCcdPurgeBlockLearnedRoutes1)
        {
            AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.addSafCcdPurgeBlockLearnedRoutes = addSafCcdPurgeBlockLearnedRoutes1;
            AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort56)(this)).addSafCcdPurgeBlockLearnedRoutes(inValue);
            return retVal.addSafCcdPurgeBlockLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse> AxlNetClient.AXLPort56.addSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.addSafCcdPurgeBlockLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafCcdPurgeBlockLearnedRoutesResponse> addSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.AddSafCcdPurgeBlockLearnedRoutesReq addSafCcdPurgeBlockLearnedRoutes)
        {
            AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.addSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.addSafCcdPurgeBlockLearnedRoutes = addSafCcdPurgeBlockLearnedRoutes;
            return ((AxlNetClient.AXLPort56)(this)).addSafCcdPurgeBlockLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse AxlNetClient.AXLPort56.updateSafCcdPurgeBlockLearnedRoutes(AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.updateSafCcdPurgeBlockLearnedRoutes(request);
        }

        public AxlNetClient.StandardResponse updateSafCcdPurgeBlockLearnedRoutes(AxlNetClient.UpdateSafCcdPurgeBlockLearnedRoutesReq updateSafCcdPurgeBlockLearnedRoutes1)
        {
            AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.updateSafCcdPurgeBlockLearnedRoutes = updateSafCcdPurgeBlockLearnedRoutes1;
            AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort56)(this)).updateSafCcdPurgeBlockLearnedRoutes(inValue);
            return retVal.updateSafCcdPurgeBlockLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse> AxlNetClient.AXLPort56.updateSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.updateSafCcdPurgeBlockLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesResponse> updateSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.UpdateSafCcdPurgeBlockLearnedRoutesReq updateSafCcdPurgeBlockLearnedRoutes)
        {
            AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.updateSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.updateSafCcdPurgeBlockLearnedRoutes = updateSafCcdPurgeBlockLearnedRoutes;
            return ((AxlNetClient.AXLPort56)(this)).updateSafCcdPurgeBlockLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse AxlNetClient.AXLPort56.getSafCcdPurgeBlockLearnedRoutes(AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.getSafCcdPurgeBlockLearnedRoutes(request);
        }

        public AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesRes getSafCcdPurgeBlockLearnedRoutes(AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesReq getSafCcdPurgeBlockLearnedRoutes1)
        {
            AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.getSafCcdPurgeBlockLearnedRoutes = getSafCcdPurgeBlockLearnedRoutes1;
            AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort56)(this)).getSafCcdPurgeBlockLearnedRoutes(inValue);
            return retVal.getSafCcdPurgeBlockLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse> AxlNetClient.AXLPort56.getSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.getSafCcdPurgeBlockLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafCcdPurgeBlockLearnedRoutesResponse> getSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.GetSafCcdPurgeBlockLearnedRoutesReq getSafCcdPurgeBlockLearnedRoutes)
        {
            AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.getSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.getSafCcdPurgeBlockLearnedRoutes = getSafCcdPurgeBlockLearnedRoutes;
            return ((AxlNetClient.AXLPort56)(this)).getSafCcdPurgeBlockLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse AxlNetClient.AXLPort56.removeSafCcdPurgeBlockLearnedRoutes(AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.removeSafCcdPurgeBlockLearnedRoutes(request);
        }

        public AxlNetClient.StandardResponse removeSafCcdPurgeBlockLearnedRoutes(AxlNetClient.RemoveSafCcdPurgeBlockLearnedRoutesReq removeSafCcdPurgeBlockLearnedRoutes1)
        {
            AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.removeSafCcdPurgeBlockLearnedRoutes = removeSafCcdPurgeBlockLearnedRoutes1;
            AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort56)(this)).removeSafCcdPurgeBlockLearnedRoutes(inValue);
            return retVal.removeSafCcdPurgeBlockLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse> AxlNetClient.AXLPort56.removeSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.removeSafCcdPurgeBlockLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesResponse> removeSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.RemoveSafCcdPurgeBlockLearnedRoutesReq removeSafCcdPurgeBlockLearnedRoutes)
        {
            AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.removeSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.removeSafCcdPurgeBlockLearnedRoutes = removeSafCcdPurgeBlockLearnedRoutes;
            return ((AxlNetClient.AXLPort56)(this)).removeSafCcdPurgeBlockLearnedRoutesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse AxlNetClient.AXLPort56.listSafCcdPurgeBlockLearnedRoutes(AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.listSafCcdPurgeBlockLearnedRoutes(request);
        }

        public AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesRes listSafCcdPurgeBlockLearnedRoutes(AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesReq listSafCcdPurgeBlockLearnedRoutes1)
        {
            AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.listSafCcdPurgeBlockLearnedRoutes = listSafCcdPurgeBlockLearnedRoutes1;
            AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse retVal = ((AxlNetClient.AXLPort56)(this)).listSafCcdPurgeBlockLearnedRoutes(inValue);
            return retVal.listSafCcdPurgeBlockLearnedRoutesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse> AxlNetClient.AXLPort56.listSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest request)
        {
            return base.Channel.listSafCcdPurgeBlockLearnedRoutesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafCcdPurgeBlockLearnedRoutesResponse> listSafCcdPurgeBlockLearnedRoutesAsync(AxlNetClient.ListSafCcdPurgeBlockLearnedRoutesReq listSafCcdPurgeBlockLearnedRoutes)
        {
            AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest inValue = new AxlNetClient.listSafCcdPurgeBlockLearnedRoutesRequest();
            inValue.listSafCcdPurgeBlockLearnedRoutes = listSafCcdPurgeBlockLearnedRoutes;
            return ((AxlNetClient.AXLPort56)(this)).listSafCcdPurgeBlockLearnedRoutesAsync(inValue);
        }
    }
}