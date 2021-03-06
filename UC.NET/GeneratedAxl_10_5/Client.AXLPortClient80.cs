namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient80 _axlPortClient80;

        private static AXLPortClient80 axlPortClient80 => _axlPortClient80 == null ||
            _axlPortClient80.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient80 = LoadClient80()) : _axlPortClient80;

        private static AXLPortClient80 LoadClient80()
        {
            var client = new AXLPortClient80(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close80;
            OnAbort += Abort80;
            return client;
        }

        private static void Close80(object sender, System.EventArgs e)
        {
            _axlPortClient80.Close();
        }

        private static void Abort80(object sender, System.EventArgs e)
        {
            _axlPortClient80.Abort();
        }

        public AxlNetClient.DoLdapSyncRes doLdapSync(AxlNetClient.DoLdapSyncReq doLdapSync1)
        {
            return axlPortClient80.doLdapSync(doLdapSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doLdapSyncResponse> doLdapSyncAsync(AxlNetClient.DoLdapSyncReq doLdapSync)
        {
            return axlPortClient80.doLdapSyncAsync(doLdapSync);
        }

        public AxlNetClient.GetLdapSyncStatusRes getLdapSyncStatus(AxlNetClient.GetLdapSyncStatusReq getLdapSyncStatus1)
        {
            return axlPortClient80.getLdapSyncStatus(getLdapSyncStatus1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSyncStatusResponse> getLdapSyncStatusAsync(AxlNetClient.GetLdapSyncStatusReq getLdapSyncStatus)
        {
            return axlPortClient80.getLdapSyncStatusAsync(getLdapSyncStatus);
        }

        public AxlNetClient.StandardResponse updateSoftKeySet(AxlNetClient.UpdateSoftKeySetReq updateSoftKeySet1)
        {
            return axlPortClient80.updateSoftKeySet(updateSoftKeySet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSoftKeySetResponse> updateSoftKeySetAsync(AxlNetClient.UpdateSoftKeySetReq updateSoftKeySet)
        {
            return axlPortClient80.updateSoftKeySetAsync(updateSoftKeySet);
        }

        public AxlNetClient.GetSoftKeySetRes getSoftKeySet(AxlNetClient.GetSoftKeySetReq getSoftKeySet1)
        {
            return axlPortClient80.getSoftKeySet(getSoftKeySet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSoftKeySetResponse> getSoftKeySetAsync(AxlNetClient.GetSoftKeySetReq getSoftKeySet)
        {
            return axlPortClient80.getSoftKeySetAsync(getSoftKeySet);
        }

        public AxlNetClient.DoUpdateRemoteClusterRes doUpdateRemoteCluster(AxlNetClient.DoUpdateRemoteClusterReq doUpdateRemoteCluster1)
        {
            return axlPortClient80.doUpdateRemoteCluster(doUpdateRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doUpdateRemoteClusterResponse> doUpdateRemoteClusterAsync(AxlNetClient.DoUpdateRemoteClusterReq doUpdateRemoteCluster)
        {
            return axlPortClient80.doUpdateRemoteClusterAsync(doUpdateRemoteCluster);
        }

        public AxlNetClient.UpdateSyslogConfigurationRes updateSyslogConfiguration(AxlNetClient.UpdateSyslogConfigurationReq updateSyslogConfiguration1)
        {
            return axlPortClient80.updateSyslogConfiguration(updateSyslogConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSyslogConfigurationResponse> updateSyslogConfigurationAsync(AxlNetClient.UpdateSyslogConfigurationReq updateSyslogConfiguration)
        {
            return axlPortClient80.updateSyslogConfigurationAsync(updateSyslogConfiguration);
        }

        public AxlNetClient.GetSyslogConfigurationRes getSyslogConfiguration(AxlNetClient.GetSyslogConfigurationReq getSyslogConfiguration1)
        {
            return axlPortClient80.getSyslogConfiguration(getSyslogConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSyslogConfigurationResponse> getSyslogConfigurationAsync(AxlNetClient.GetSyslogConfigurationReq getSyslogConfiguration)
        {
            return axlPortClient80.getSyslogConfigurationAsync(getSyslogConfiguration);
        }

        public AxlNetClient.ListLdapSyncCustomFieldRes listLdapSyncCustomField(AxlNetClient.ListLdapSyncCustomFieldReq listLdapSyncCustomField1)
        {
            return axlPortClient80.listLdapSyncCustomField(listLdapSyncCustomField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapSyncCustomFieldResponse> listLdapSyncCustomFieldAsync(AxlNetClient.ListLdapSyncCustomFieldReq listLdapSyncCustomField)
        {
            return axlPortClient80.listLdapSyncCustomFieldAsync(listLdapSyncCustomField);
        }

        public AxlNetClient.GetPhoneTypeDisplayInstanceRes getPhoneTypeDisplayInstance(AxlNetClient.GetPhoneTypeDisplayInstanceReq getPhoneTypeDisplayInstance1)
        {
            return axlPortClient80.getPhoneTypeDisplayInstance(getPhoneTypeDisplayInstance1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneTypeDisplayInstanceResponse> getPhoneTypeDisplayInstanceAsync(AxlNetClient.GetPhoneTypeDisplayInstanceReq getPhoneTypeDisplayInstance)
        {
            return axlPortClient80.getPhoneTypeDisplayInstanceAsync(getPhoneTypeDisplayInstance);
        }

        public AxlNetClient.StandardResponse updateInterClusterDirectoryUri(AxlNetClient.UpdateInterClusterDirectoryUriReq updateInterClusterDirectoryUri1)
        {
            return axlPortClient80.updateInterClusterDirectoryUri(updateInterClusterDirectoryUri1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateInterClusterDirectoryUriResponse> updateInterClusterDirectoryUriAsync(AxlNetClient.UpdateInterClusterDirectoryUriReq updateInterClusterDirectoryUri)
        {
            return axlPortClient80.updateInterClusterDirectoryUriAsync(updateInterClusterDirectoryUri);
        }

        public AxlNetClient.StandardResponse updateIlsConfig(AxlNetClient.UpdateIlsConfigReq updateIlsConfig1)
        {
            return axlPortClient80.updateIlsConfig(updateIlsConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIlsConfigResponse> updateIlsConfigAsync(AxlNetClient.UpdateIlsConfigReq updateIlsConfig)
        {
            return axlPortClient80.updateIlsConfigAsync(updateIlsConfig);
        }

        public AxlNetClient.GetIlsConfigRes getIlsConfig(AxlNetClient.GetIlsConfigReq getIlsConfig1)
        {
            return axlPortClient80.getIlsConfig(getIlsConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIlsConfigResponse> getIlsConfigAsync(AxlNetClient.GetIlsConfigReq getIlsConfig)
        {
            return axlPortClient80.getIlsConfigAsync(getIlsConfig);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort80
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doLdapSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doLdapSyncResponse doLdapSync(AxlNetClient.doLdapSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doLdapSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doLdapSyncResponse> doLdapSyncAsync(AxlNetClient.doLdapSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSyncStatus", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLdapSyncStatusResponse getLdapSyncStatus(AxlNetClient.getLdapSyncStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLdapSyncStatus", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSyncStatusResponse> getLdapSyncStatusAsync(AxlNetClient.getLdapSyncStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSoftKeySet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSoftKeySetResponse updateSoftKeySet(AxlNetClient.updateSoftKeySetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSoftKeySet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSoftKeySetResponse> updateSoftKeySetAsync(AxlNetClient.updateSoftKeySetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSoftKeySet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSoftKeySetResponse getSoftKeySet(AxlNetClient.getSoftKeySetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSoftKeySet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSoftKeySetResponse> getSoftKeySetAsync(AxlNetClient.getSoftKeySetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doUpdateRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doUpdateRemoteClusterResponse doUpdateRemoteCluster(AxlNetClient.doUpdateRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doUpdateRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doUpdateRemoteClusterResponse> doUpdateRemoteClusterAsync(AxlNetClient.doUpdateRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSyslogConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSyslogConfigurationResponse updateSyslogConfiguration(AxlNetClient.updateSyslogConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSyslogConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSyslogConfigurationResponse> updateSyslogConfigurationAsync(AxlNetClient.updateSyslogConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSyslogConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSyslogConfigurationResponse getSyslogConfiguration(AxlNetClient.getSyslogConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSyslogConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSyslogConfigurationResponse> getSyslogConfigurationAsync(AxlNetClient.getSyslogConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapSyncCustomField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLdapSyncCustomFieldResponse listLdapSyncCustomField(AxlNetClient.listLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLdapSyncCustomField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLdapSyncCustomFieldResponse> listLdapSyncCustomFieldAsync(AxlNetClient.listLdapSyncCustomFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneTypeDisplayInstance", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneTypeDisplayInstanceResponse getPhoneTypeDisplayInstance(AxlNetClient.getPhoneTypeDisplayInstanceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneTypeDisplayInstance", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneTypeDisplayInstanceResponse> getPhoneTypeDisplayInstanceAsync(AxlNetClient.getPhoneTypeDisplayInstanceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateInterClusterDirectoryUri", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateInterClusterDirectoryUriResponse updateInterClusterDirectoryUri(AxlNetClient.updateInterClusterDirectoryUriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateInterClusterDirectoryUri", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateInterClusterDirectoryUriResponse> updateInterClusterDirectoryUriAsync(AxlNetClient.updateInterClusterDirectoryUriRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIlsConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateIlsConfigResponse updateIlsConfig(AxlNetClient.updateIlsConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIlsConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateIlsConfigResponse> updateIlsConfigAsync(AxlNetClient.updateIlsConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIlsConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getIlsConfigResponse getIlsConfig(AxlNetClient.getIlsConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIlsConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getIlsConfigResponse> getIlsConfigAsync(AxlNetClient.getIlsConfigRequest request);
    }

    public class AXLPortClient80 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort80>, AxlNetClient.AXLPort80
    {
        public AXLPortClient80(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doLdapSyncResponse AxlNetClient.AXLPort80.doLdapSync(AxlNetClient.doLdapSyncRequest request)
        {
            return base.Channel.doLdapSync(request);
        }

        public AxlNetClient.DoLdapSyncRes doLdapSync(AxlNetClient.DoLdapSyncReq doLdapSync1)
        {
            AxlNetClient.doLdapSyncRequest inValue = new AxlNetClient.doLdapSyncRequest();
            inValue.doLdapSync = doLdapSync1;
            AxlNetClient.doLdapSyncResponse retVal = ((AxlNetClient.AXLPort80)(this)).doLdapSync(inValue);
            return retVal.doLdapSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doLdapSyncResponse> AxlNetClient.AXLPort80.doLdapSyncAsync(AxlNetClient.doLdapSyncRequest request)
        {
            return base.Channel.doLdapSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doLdapSyncResponse> doLdapSyncAsync(AxlNetClient.DoLdapSyncReq doLdapSync)
        {
            AxlNetClient.doLdapSyncRequest inValue = new AxlNetClient.doLdapSyncRequest();
            inValue.doLdapSync = doLdapSync;
            return ((AxlNetClient.AXLPort80)(this)).doLdapSyncAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLdapSyncStatusResponse AxlNetClient.AXLPort80.getLdapSyncStatus(AxlNetClient.getLdapSyncStatusRequest request)
        {
            return base.Channel.getLdapSyncStatus(request);
        }

        public AxlNetClient.GetLdapSyncStatusRes getLdapSyncStatus(AxlNetClient.GetLdapSyncStatusReq getLdapSyncStatus1)
        {
            AxlNetClient.getLdapSyncStatusRequest inValue = new AxlNetClient.getLdapSyncStatusRequest();
            inValue.getLdapSyncStatus = getLdapSyncStatus1;
            AxlNetClient.getLdapSyncStatusResponse retVal = ((AxlNetClient.AXLPort80)(this)).getLdapSyncStatus(inValue);
            return retVal.getLdapSyncStatusResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLdapSyncStatusResponse> AxlNetClient.AXLPort80.getLdapSyncStatusAsync(AxlNetClient.getLdapSyncStatusRequest request)
        {
            return base.Channel.getLdapSyncStatusAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLdapSyncStatusResponse> getLdapSyncStatusAsync(AxlNetClient.GetLdapSyncStatusReq getLdapSyncStatus)
        {
            AxlNetClient.getLdapSyncStatusRequest inValue = new AxlNetClient.getLdapSyncStatusRequest();
            inValue.getLdapSyncStatus = getLdapSyncStatus;
            return ((AxlNetClient.AXLPort80)(this)).getLdapSyncStatusAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSoftKeySetResponse AxlNetClient.AXLPort80.updateSoftKeySet(AxlNetClient.updateSoftKeySetRequest request)
        {
            return base.Channel.updateSoftKeySet(request);
        }

        public AxlNetClient.StandardResponse updateSoftKeySet(AxlNetClient.UpdateSoftKeySetReq updateSoftKeySet1)
        {
            AxlNetClient.updateSoftKeySetRequest inValue = new AxlNetClient.updateSoftKeySetRequest();
            inValue.updateSoftKeySet = updateSoftKeySet1;
            AxlNetClient.updateSoftKeySetResponse retVal = ((AxlNetClient.AXLPort80)(this)).updateSoftKeySet(inValue);
            return retVal.updateSoftKeySetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSoftKeySetResponse> AxlNetClient.AXLPort80.updateSoftKeySetAsync(AxlNetClient.updateSoftKeySetRequest request)
        {
            return base.Channel.updateSoftKeySetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSoftKeySetResponse> updateSoftKeySetAsync(AxlNetClient.UpdateSoftKeySetReq updateSoftKeySet)
        {
            AxlNetClient.updateSoftKeySetRequest inValue = new AxlNetClient.updateSoftKeySetRequest();
            inValue.updateSoftKeySet = updateSoftKeySet;
            return ((AxlNetClient.AXLPort80)(this)).updateSoftKeySetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSoftKeySetResponse AxlNetClient.AXLPort80.getSoftKeySet(AxlNetClient.getSoftKeySetRequest request)
        {
            return base.Channel.getSoftKeySet(request);
        }

        public AxlNetClient.GetSoftKeySetRes getSoftKeySet(AxlNetClient.GetSoftKeySetReq getSoftKeySet1)
        {
            AxlNetClient.getSoftKeySetRequest inValue = new AxlNetClient.getSoftKeySetRequest();
            inValue.getSoftKeySet = getSoftKeySet1;
            AxlNetClient.getSoftKeySetResponse retVal = ((AxlNetClient.AXLPort80)(this)).getSoftKeySet(inValue);
            return retVal.getSoftKeySetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSoftKeySetResponse> AxlNetClient.AXLPort80.getSoftKeySetAsync(AxlNetClient.getSoftKeySetRequest request)
        {
            return base.Channel.getSoftKeySetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSoftKeySetResponse> getSoftKeySetAsync(AxlNetClient.GetSoftKeySetReq getSoftKeySet)
        {
            AxlNetClient.getSoftKeySetRequest inValue = new AxlNetClient.getSoftKeySetRequest();
            inValue.getSoftKeySet = getSoftKeySet;
            return ((AxlNetClient.AXLPort80)(this)).getSoftKeySetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doUpdateRemoteClusterResponse AxlNetClient.AXLPort80.doUpdateRemoteCluster(AxlNetClient.doUpdateRemoteClusterRequest request)
        {
            return base.Channel.doUpdateRemoteCluster(request);
        }

        public AxlNetClient.DoUpdateRemoteClusterRes doUpdateRemoteCluster(AxlNetClient.DoUpdateRemoteClusterReq doUpdateRemoteCluster1)
        {
            AxlNetClient.doUpdateRemoteClusterRequest inValue = new AxlNetClient.doUpdateRemoteClusterRequest();
            inValue.doUpdateRemoteCluster = doUpdateRemoteCluster1;
            AxlNetClient.doUpdateRemoteClusterResponse retVal = ((AxlNetClient.AXLPort80)(this)).doUpdateRemoteCluster(inValue);
            return retVal.doUpdateRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doUpdateRemoteClusterResponse> AxlNetClient.AXLPort80.doUpdateRemoteClusterAsync(AxlNetClient.doUpdateRemoteClusterRequest request)
        {
            return base.Channel.doUpdateRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doUpdateRemoteClusterResponse> doUpdateRemoteClusterAsync(AxlNetClient.DoUpdateRemoteClusterReq doUpdateRemoteCluster)
        {
            AxlNetClient.doUpdateRemoteClusterRequest inValue = new AxlNetClient.doUpdateRemoteClusterRequest();
            inValue.doUpdateRemoteCluster = doUpdateRemoteCluster;
            return ((AxlNetClient.AXLPort80)(this)).doUpdateRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSyslogConfigurationResponse AxlNetClient.AXLPort80.updateSyslogConfiguration(AxlNetClient.updateSyslogConfigurationRequest request)
        {
            return base.Channel.updateSyslogConfiguration(request);
        }

        public AxlNetClient.UpdateSyslogConfigurationRes updateSyslogConfiguration(AxlNetClient.UpdateSyslogConfigurationReq updateSyslogConfiguration1)
        {
            AxlNetClient.updateSyslogConfigurationRequest inValue = new AxlNetClient.updateSyslogConfigurationRequest();
            inValue.updateSyslogConfiguration = updateSyslogConfiguration1;
            AxlNetClient.updateSyslogConfigurationResponse retVal = ((AxlNetClient.AXLPort80)(this)).updateSyslogConfiguration(inValue);
            return retVal.updateSyslogConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSyslogConfigurationResponse> AxlNetClient.AXLPort80.updateSyslogConfigurationAsync(AxlNetClient.updateSyslogConfigurationRequest request)
        {
            return base.Channel.updateSyslogConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSyslogConfigurationResponse> updateSyslogConfigurationAsync(AxlNetClient.UpdateSyslogConfigurationReq updateSyslogConfiguration)
        {
            AxlNetClient.updateSyslogConfigurationRequest inValue = new AxlNetClient.updateSyslogConfigurationRequest();
            inValue.updateSyslogConfiguration = updateSyslogConfiguration;
            return ((AxlNetClient.AXLPort80)(this)).updateSyslogConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSyslogConfigurationResponse AxlNetClient.AXLPort80.getSyslogConfiguration(AxlNetClient.getSyslogConfigurationRequest request)
        {
            return base.Channel.getSyslogConfiguration(request);
        }

        public AxlNetClient.GetSyslogConfigurationRes getSyslogConfiguration(AxlNetClient.GetSyslogConfigurationReq getSyslogConfiguration1)
        {
            AxlNetClient.getSyslogConfigurationRequest inValue = new AxlNetClient.getSyslogConfigurationRequest();
            inValue.getSyslogConfiguration = getSyslogConfiguration1;
            AxlNetClient.getSyslogConfigurationResponse retVal = ((AxlNetClient.AXLPort80)(this)).getSyslogConfiguration(inValue);
            return retVal.getSyslogConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSyslogConfigurationResponse> AxlNetClient.AXLPort80.getSyslogConfigurationAsync(AxlNetClient.getSyslogConfigurationRequest request)
        {
            return base.Channel.getSyslogConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSyslogConfigurationResponse> getSyslogConfigurationAsync(AxlNetClient.GetSyslogConfigurationReq getSyslogConfiguration)
        {
            AxlNetClient.getSyslogConfigurationRequest inValue = new AxlNetClient.getSyslogConfigurationRequest();
            inValue.getSyslogConfiguration = getSyslogConfiguration;
            return ((AxlNetClient.AXLPort80)(this)).getSyslogConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLdapSyncCustomFieldResponse AxlNetClient.AXLPort80.listLdapSyncCustomField(AxlNetClient.listLdapSyncCustomFieldRequest request)
        {
            return base.Channel.listLdapSyncCustomField(request);
        }

        public AxlNetClient.ListLdapSyncCustomFieldRes listLdapSyncCustomField(AxlNetClient.ListLdapSyncCustomFieldReq listLdapSyncCustomField1)
        {
            AxlNetClient.listLdapSyncCustomFieldRequest inValue = new AxlNetClient.listLdapSyncCustomFieldRequest();
            inValue.listLdapSyncCustomField = listLdapSyncCustomField1;
            AxlNetClient.listLdapSyncCustomFieldResponse retVal = ((AxlNetClient.AXLPort80)(this)).listLdapSyncCustomField(inValue);
            return retVal.listLdapSyncCustomFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLdapSyncCustomFieldResponse> AxlNetClient.AXLPort80.listLdapSyncCustomFieldAsync(AxlNetClient.listLdapSyncCustomFieldRequest request)
        {
            return base.Channel.listLdapSyncCustomFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLdapSyncCustomFieldResponse> listLdapSyncCustomFieldAsync(AxlNetClient.ListLdapSyncCustomFieldReq listLdapSyncCustomField)
        {
            AxlNetClient.listLdapSyncCustomFieldRequest inValue = new AxlNetClient.listLdapSyncCustomFieldRequest();
            inValue.listLdapSyncCustomField = listLdapSyncCustomField;
            return ((AxlNetClient.AXLPort80)(this)).listLdapSyncCustomFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneTypeDisplayInstanceResponse AxlNetClient.AXLPort80.getPhoneTypeDisplayInstance(AxlNetClient.getPhoneTypeDisplayInstanceRequest request)
        {
            return base.Channel.getPhoneTypeDisplayInstance(request);
        }

        public AxlNetClient.GetPhoneTypeDisplayInstanceRes getPhoneTypeDisplayInstance(AxlNetClient.GetPhoneTypeDisplayInstanceReq getPhoneTypeDisplayInstance1)
        {
            AxlNetClient.getPhoneTypeDisplayInstanceRequest inValue = new AxlNetClient.getPhoneTypeDisplayInstanceRequest();
            inValue.getPhoneTypeDisplayInstance = getPhoneTypeDisplayInstance1;
            AxlNetClient.getPhoneTypeDisplayInstanceResponse retVal = ((AxlNetClient.AXLPort80)(this)).getPhoneTypeDisplayInstance(inValue);
            return retVal.getPhoneTypeDisplayInstanceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneTypeDisplayInstanceResponse> AxlNetClient.AXLPort80.getPhoneTypeDisplayInstanceAsync(AxlNetClient.getPhoneTypeDisplayInstanceRequest request)
        {
            return base.Channel.getPhoneTypeDisplayInstanceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneTypeDisplayInstanceResponse> getPhoneTypeDisplayInstanceAsync(AxlNetClient.GetPhoneTypeDisplayInstanceReq getPhoneTypeDisplayInstance)
        {
            AxlNetClient.getPhoneTypeDisplayInstanceRequest inValue = new AxlNetClient.getPhoneTypeDisplayInstanceRequest();
            inValue.getPhoneTypeDisplayInstance = getPhoneTypeDisplayInstance;
            return ((AxlNetClient.AXLPort80)(this)).getPhoneTypeDisplayInstanceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateInterClusterDirectoryUriResponse AxlNetClient.AXLPort80.updateInterClusterDirectoryUri(AxlNetClient.updateInterClusterDirectoryUriRequest request)
        {
            return base.Channel.updateInterClusterDirectoryUri(request);
        }

        public AxlNetClient.StandardResponse updateInterClusterDirectoryUri(AxlNetClient.UpdateInterClusterDirectoryUriReq updateInterClusterDirectoryUri1)
        {
            AxlNetClient.updateInterClusterDirectoryUriRequest inValue = new AxlNetClient.updateInterClusterDirectoryUriRequest();
            inValue.updateInterClusterDirectoryUri = updateInterClusterDirectoryUri1;
            AxlNetClient.updateInterClusterDirectoryUriResponse retVal = ((AxlNetClient.AXLPort80)(this)).updateInterClusterDirectoryUri(inValue);
            return retVal.updateInterClusterDirectoryUriResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateInterClusterDirectoryUriResponse> AxlNetClient.AXLPort80.updateInterClusterDirectoryUriAsync(AxlNetClient.updateInterClusterDirectoryUriRequest request)
        {
            return base.Channel.updateInterClusterDirectoryUriAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateInterClusterDirectoryUriResponse> updateInterClusterDirectoryUriAsync(AxlNetClient.UpdateInterClusterDirectoryUriReq updateInterClusterDirectoryUri)
        {
            AxlNetClient.updateInterClusterDirectoryUriRequest inValue = new AxlNetClient.updateInterClusterDirectoryUriRequest();
            inValue.updateInterClusterDirectoryUri = updateInterClusterDirectoryUri;
            return ((AxlNetClient.AXLPort80)(this)).updateInterClusterDirectoryUriAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateIlsConfigResponse AxlNetClient.AXLPort80.updateIlsConfig(AxlNetClient.updateIlsConfigRequest request)
        {
            return base.Channel.updateIlsConfig(request);
        }

        public AxlNetClient.StandardResponse updateIlsConfig(AxlNetClient.UpdateIlsConfigReq updateIlsConfig1)
        {
            AxlNetClient.updateIlsConfigRequest inValue = new AxlNetClient.updateIlsConfigRequest();
            inValue.updateIlsConfig = updateIlsConfig1;
            AxlNetClient.updateIlsConfigResponse retVal = ((AxlNetClient.AXLPort80)(this)).updateIlsConfig(inValue);
            return retVal.updateIlsConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateIlsConfigResponse> AxlNetClient.AXLPort80.updateIlsConfigAsync(AxlNetClient.updateIlsConfigRequest request)
        {
            return base.Channel.updateIlsConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIlsConfigResponse> updateIlsConfigAsync(AxlNetClient.UpdateIlsConfigReq updateIlsConfig)
        {
            AxlNetClient.updateIlsConfigRequest inValue = new AxlNetClient.updateIlsConfigRequest();
            inValue.updateIlsConfig = updateIlsConfig;
            return ((AxlNetClient.AXLPort80)(this)).updateIlsConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getIlsConfigResponse AxlNetClient.AXLPort80.getIlsConfig(AxlNetClient.getIlsConfigRequest request)
        {
            return base.Channel.getIlsConfig(request);
        }

        public AxlNetClient.GetIlsConfigRes getIlsConfig(AxlNetClient.GetIlsConfigReq getIlsConfig1)
        {
            AxlNetClient.getIlsConfigRequest inValue = new AxlNetClient.getIlsConfigRequest();
            inValue.getIlsConfig = getIlsConfig1;
            AxlNetClient.getIlsConfigResponse retVal = ((AxlNetClient.AXLPort80)(this)).getIlsConfig(inValue);
            return retVal.getIlsConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getIlsConfigResponse> AxlNetClient.AXLPort80.getIlsConfigAsync(AxlNetClient.getIlsConfigRequest request)
        {
            return base.Channel.getIlsConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIlsConfigResponse> getIlsConfigAsync(AxlNetClient.GetIlsConfigReq getIlsConfig)
        {
            AxlNetClient.getIlsConfigRequest inValue = new AxlNetClient.getIlsConfigRequest();
            inValue.getIlsConfig = getIlsConfig;
            return ((AxlNetClient.AXLPort80)(this)).getIlsConfigAsync(inValue);
        }
    }
}