namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient65 _axlPortClient65;

        private static AXLPortClient65 axlPortClient65 => _axlPortClient65 == null ||
            _axlPortClient65.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient65 = LoadClient65()) : _axlPortClient65;

        private static AXLPortClient65 LoadClient65()
        {
            var client = new AXLPortClient65(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close65;
            OnAbort += Abort65;
            return client;
        }

        private static void Close65(object sender, System.EventArgs e)
        {
            _axlPortClient65.Close();
        }

        private static void Abort65(object sender, System.EventArgs e)
        {
            _axlPortClient65.Abort();
        }

        public AxlNetClient.StandardResponse updateEnterpriseFeatureAccessConfiguration(AxlNetClient.UpdateEnterpriseFeatureAccessConfigurationReq updateEnterpriseFeatureAccessConfiguration1)
        {
            return axlPortClient65.updateEnterpriseFeatureAccessConfiguration(updateEnterpriseFeatureAccessConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse> updateEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.UpdateEnterpriseFeatureAccessConfigurationReq updateEnterpriseFeatureAccessConfiguration)
        {
            return axlPortClient65.updateEnterpriseFeatureAccessConfigurationAsync(updateEnterpriseFeatureAccessConfiguration);
        }

        public AxlNetClient.GetEnterpriseFeatureAccessConfigurationRes getEnterpriseFeatureAccessConfiguration(AxlNetClient.GetEnterpriseFeatureAccessConfigurationReq getEnterpriseFeatureAccessConfiguration1)
        {
            return axlPortClient65.getEnterpriseFeatureAccessConfiguration(getEnterpriseFeatureAccessConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse> getEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.GetEnterpriseFeatureAccessConfigurationReq getEnterpriseFeatureAccessConfiguration)
        {
            return axlPortClient65.getEnterpriseFeatureAccessConfigurationAsync(getEnterpriseFeatureAccessConfiguration);
        }

        public AxlNetClient.StandardResponse removeEnterpriseFeatureAccessConfiguration(AxlNetClient.RemoveEnterpriseFeatureAccessConfigurationReq removeEnterpriseFeatureAccessConfiguration1)
        {
            return axlPortClient65.removeEnterpriseFeatureAccessConfiguration(removeEnterpriseFeatureAccessConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse> removeEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.RemoveEnterpriseFeatureAccessConfigurationReq removeEnterpriseFeatureAccessConfiguration)
        {
            return axlPortClient65.removeEnterpriseFeatureAccessConfigurationAsync(removeEnterpriseFeatureAccessConfiguration);
        }

        public AxlNetClient.ListEnterpriseFeatureAccessConfigurationRes listEnterpriseFeatureAccessConfiguration(AxlNetClient.ListEnterpriseFeatureAccessConfigurationReq listEnterpriseFeatureAccessConfiguration1)
        {
            return axlPortClient65.listEnterpriseFeatureAccessConfiguration(listEnterpriseFeatureAccessConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse> listEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.ListEnterpriseFeatureAccessConfigurationReq listEnterpriseFeatureAccessConfiguration)
        {
            return axlPortClient65.listEnterpriseFeatureAccessConfigurationAsync(listEnterpriseFeatureAccessConfiguration);
        }

        public AxlNetClient.StandardResponse addHandoffConfiguration(AxlNetClient.AddHandoffConfigurationReq addHandoffConfiguration1)
        {
            return axlPortClient65.addHandoffConfiguration(addHandoffConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHandoffConfigurationResponse> addHandoffConfigurationAsync(AxlNetClient.AddHandoffConfigurationReq addHandoffConfiguration)
        {
            return axlPortClient65.addHandoffConfigurationAsync(addHandoffConfiguration);
        }

        public AxlNetClient.StandardResponse updateHandoffConfiguration(AxlNetClient.UpdateHandoffConfigurationReq updateHandoffConfiguration1)
        {
            return axlPortClient65.updateHandoffConfiguration(updateHandoffConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHandoffConfigurationResponse> updateHandoffConfigurationAsync(AxlNetClient.UpdateHandoffConfigurationReq updateHandoffConfiguration)
        {
            return axlPortClient65.updateHandoffConfigurationAsync(updateHandoffConfiguration);
        }

        public AxlNetClient.GetHandoffConfigurationRes getHandoffConfiguration(AxlNetClient.GetHandoffConfigurationReq getHandoffConfiguration1)
        {
            return axlPortClient65.getHandoffConfiguration(getHandoffConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHandoffConfigurationResponse> getHandoffConfigurationAsync(AxlNetClient.GetHandoffConfigurationReq getHandoffConfiguration)
        {
            return axlPortClient65.getHandoffConfigurationAsync(getHandoffConfiguration);
        }

        public AxlNetClient.StandardResponse removeHandoffConfiguration(AxlNetClient.RemoveHandoffConfigurationReq removeHandoffConfiguration1)
        {
            return axlPortClient65.removeHandoffConfiguration(removeHandoffConfiguration1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHandoffConfigurationResponse> removeHandoffConfigurationAsync(AxlNetClient.RemoveHandoffConfigurationReq removeHandoffConfiguration)
        {
            return axlPortClient65.removeHandoffConfigurationAsync(removeHandoffConfiguration);
        }

        public AxlNetClient.StandardResponse addCalledPartyTracing(AxlNetClient.AddCalledPartyTracingReq addCalledPartyTracing1)
        {
            return axlPortClient65.addCalledPartyTracing(addCalledPartyTracing1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTracingResponse> addCalledPartyTracingAsync(AxlNetClient.AddCalledPartyTracingReq addCalledPartyTracing)
        {
            return axlPortClient65.addCalledPartyTracingAsync(addCalledPartyTracing);
        }

        public AxlNetClient.StandardResponse removeCalledPartyTracing(AxlNetClient.RemoveCalledPartyTracingReq removeCalledPartyTracing1)
        {
            return axlPortClient65.removeCalledPartyTracing(removeCalledPartyTracing1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTracingResponse> removeCalledPartyTracingAsync(AxlNetClient.RemoveCalledPartyTracingReq removeCalledPartyTracing)
        {
            return axlPortClient65.removeCalledPartyTracingAsync(removeCalledPartyTracing);
        }

        public AxlNetClient.ListCalledPartyTracingRes listCalledPartyTracing(AxlNetClient.ListCalledPartyTracingReq listCalledPartyTracing1)
        {
            return axlPortClient65.listCalledPartyTracing(listCalledPartyTracing1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTracingResponse> listCalledPartyTracingAsync(AxlNetClient.ListCalledPartyTracingReq listCalledPartyTracing)
        {
            return axlPortClient65.listCalledPartyTracingAsync(listCalledPartyTracing);
        }

        public AxlNetClient.StandardResponse addSIPNormalizationScript(AxlNetClient.AddSIPNormalizationScriptReq addSIPNormalizationScript1)
        {
            return axlPortClient65.addSIPNormalizationScript(addSIPNormalizationScript1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSIPNormalizationScriptResponse> addSIPNormalizationScriptAsync(AxlNetClient.AddSIPNormalizationScriptReq addSIPNormalizationScript)
        {
            return axlPortClient65.addSIPNormalizationScriptAsync(addSIPNormalizationScript);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort65
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse updateEnterpriseFeatureAccessConfiguration(AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse> updateEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse getEnterpriseFeatureAccessConfiguration(AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse> getEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse removeEnterpriseFeatureAccessConfiguration(AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse> removeEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse listEnterpriseFeatureAccessConfiguration(AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listEnterpriseFeatureAccessConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse> listEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHandoffConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addHandoffConfigurationResponse addHandoffConfiguration(AxlNetClient.addHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHandoffConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addHandoffConfigurationResponse> addHandoffConfigurationAsync(AxlNetClient.addHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHandoffConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateHandoffConfigurationResponse updateHandoffConfiguration(AxlNetClient.updateHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHandoffConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateHandoffConfigurationResponse> updateHandoffConfigurationAsync(AxlNetClient.updateHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHandoffConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getHandoffConfigurationResponse getHandoffConfiguration(AxlNetClient.getHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHandoffConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getHandoffConfigurationResponse> getHandoffConfigurationAsync(AxlNetClient.getHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHandoffConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeHandoffConfigurationResponse removeHandoffConfiguration(AxlNetClient.removeHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHandoffConfiguration", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeHandoffConfigurationResponse> removeHandoffConfigurationAsync(AxlNetClient.removeHandoffConfigurationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCalledPartyTracing", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCalledPartyTracingResponse addCalledPartyTracing(AxlNetClient.addCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCalledPartyTracing", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTracingResponse> addCalledPartyTracingAsync(AxlNetClient.addCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCalledPartyTracing", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCalledPartyTracingResponse removeCalledPartyTracing(AxlNetClient.removeCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCalledPartyTracing", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTracingResponse> removeCalledPartyTracingAsync(AxlNetClient.removeCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCalledPartyTracing", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCalledPartyTracingResponse listCalledPartyTracing(AxlNetClient.listCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCalledPartyTracing", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTracingResponse> listCalledPartyTracingAsync(AxlNetClient.listCalledPartyTracingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSIPNormalizationScript", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSIPNormalizationScriptResponse addSIPNormalizationScript(AxlNetClient.addSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSIPNormalizationScript", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSIPNormalizationScriptResponse> addSIPNormalizationScriptAsync(AxlNetClient.addSIPNormalizationScriptRequest request);
    }

    public class AXLPortClient65 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort65>, AxlNetClient.AXLPort65
    {
        public AXLPortClient65(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse AxlNetClient.AXLPort65.updateEnterpriseFeatureAccessConfiguration(AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.updateEnterpriseFeatureAccessConfiguration(request);
        }

        public AxlNetClient.StandardResponse updateEnterpriseFeatureAccessConfiguration(AxlNetClient.UpdateEnterpriseFeatureAccessConfigurationReq updateEnterpriseFeatureAccessConfiguration1)
        {
            AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest();
            inValue.updateEnterpriseFeatureAccessConfiguration = updateEnterpriseFeatureAccessConfiguration1;
            AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).updateEnterpriseFeatureAccessConfiguration(inValue);
            return retVal.updateEnterpriseFeatureAccessConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse> AxlNetClient.AXLPort65.updateEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.updateEnterpriseFeatureAccessConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateEnterpriseFeatureAccessConfigurationResponse> updateEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.UpdateEnterpriseFeatureAccessConfigurationReq updateEnterpriseFeatureAccessConfiguration)
        {
            AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.updateEnterpriseFeatureAccessConfigurationRequest();
            inValue.updateEnterpriseFeatureAccessConfiguration = updateEnterpriseFeatureAccessConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).updateEnterpriseFeatureAccessConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse AxlNetClient.AXLPort65.getEnterpriseFeatureAccessConfiguration(AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.getEnterpriseFeatureAccessConfiguration(request);
        }

        public AxlNetClient.GetEnterpriseFeatureAccessConfigurationRes getEnterpriseFeatureAccessConfiguration(AxlNetClient.GetEnterpriseFeatureAccessConfigurationReq getEnterpriseFeatureAccessConfiguration1)
        {
            AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest();
            inValue.getEnterpriseFeatureAccessConfiguration = getEnterpriseFeatureAccessConfiguration1;
            AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).getEnterpriseFeatureAccessConfiguration(inValue);
            return retVal.getEnterpriseFeatureAccessConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse> AxlNetClient.AXLPort65.getEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.getEnterpriseFeatureAccessConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getEnterpriseFeatureAccessConfigurationResponse> getEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.GetEnterpriseFeatureAccessConfigurationReq getEnterpriseFeatureAccessConfiguration)
        {
            AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.getEnterpriseFeatureAccessConfigurationRequest();
            inValue.getEnterpriseFeatureAccessConfiguration = getEnterpriseFeatureAccessConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).getEnterpriseFeatureAccessConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse AxlNetClient.AXLPort65.removeEnterpriseFeatureAccessConfiguration(AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.removeEnterpriseFeatureAccessConfiguration(request);
        }

        public AxlNetClient.StandardResponse removeEnterpriseFeatureAccessConfiguration(AxlNetClient.RemoveEnterpriseFeatureAccessConfigurationReq removeEnterpriseFeatureAccessConfiguration1)
        {
            AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest();
            inValue.removeEnterpriseFeatureAccessConfiguration = removeEnterpriseFeatureAccessConfiguration1;
            AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).removeEnterpriseFeatureAccessConfiguration(inValue);
            return retVal.removeEnterpriseFeatureAccessConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse> AxlNetClient.AXLPort65.removeEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.removeEnterpriseFeatureAccessConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeEnterpriseFeatureAccessConfigurationResponse> removeEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.RemoveEnterpriseFeatureAccessConfigurationReq removeEnterpriseFeatureAccessConfiguration)
        {
            AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.removeEnterpriseFeatureAccessConfigurationRequest();
            inValue.removeEnterpriseFeatureAccessConfiguration = removeEnterpriseFeatureAccessConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).removeEnterpriseFeatureAccessConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse AxlNetClient.AXLPort65.listEnterpriseFeatureAccessConfiguration(AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.listEnterpriseFeatureAccessConfiguration(request);
        }

        public AxlNetClient.ListEnterpriseFeatureAccessConfigurationRes listEnterpriseFeatureAccessConfiguration(AxlNetClient.ListEnterpriseFeatureAccessConfigurationReq listEnterpriseFeatureAccessConfiguration1)
        {
            AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest();
            inValue.listEnterpriseFeatureAccessConfiguration = listEnterpriseFeatureAccessConfiguration1;
            AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).listEnterpriseFeatureAccessConfiguration(inValue);
            return retVal.listEnterpriseFeatureAccessConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse> AxlNetClient.AXLPort65.listEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest request)
        {
            return base.Channel.listEnterpriseFeatureAccessConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listEnterpriseFeatureAccessConfigurationResponse> listEnterpriseFeatureAccessConfigurationAsync(AxlNetClient.ListEnterpriseFeatureAccessConfigurationReq listEnterpriseFeatureAccessConfiguration)
        {
            AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest inValue = new AxlNetClient.listEnterpriseFeatureAccessConfigurationRequest();
            inValue.listEnterpriseFeatureAccessConfiguration = listEnterpriseFeatureAccessConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).listEnterpriseFeatureAccessConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addHandoffConfigurationResponse AxlNetClient.AXLPort65.addHandoffConfiguration(AxlNetClient.addHandoffConfigurationRequest request)
        {
            return base.Channel.addHandoffConfiguration(request);
        }

        public AxlNetClient.StandardResponse addHandoffConfiguration(AxlNetClient.AddHandoffConfigurationReq addHandoffConfiguration1)
        {
            AxlNetClient.addHandoffConfigurationRequest inValue = new AxlNetClient.addHandoffConfigurationRequest();
            inValue.addHandoffConfiguration = addHandoffConfiguration1;
            AxlNetClient.addHandoffConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).addHandoffConfiguration(inValue);
            return retVal.addHandoffConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addHandoffConfigurationResponse> AxlNetClient.AXLPort65.addHandoffConfigurationAsync(AxlNetClient.addHandoffConfigurationRequest request)
        {
            return base.Channel.addHandoffConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHandoffConfigurationResponse> addHandoffConfigurationAsync(AxlNetClient.AddHandoffConfigurationReq addHandoffConfiguration)
        {
            AxlNetClient.addHandoffConfigurationRequest inValue = new AxlNetClient.addHandoffConfigurationRequest();
            inValue.addHandoffConfiguration = addHandoffConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).addHandoffConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateHandoffConfigurationResponse AxlNetClient.AXLPort65.updateHandoffConfiguration(AxlNetClient.updateHandoffConfigurationRequest request)
        {
            return base.Channel.updateHandoffConfiguration(request);
        }

        public AxlNetClient.StandardResponse updateHandoffConfiguration(AxlNetClient.UpdateHandoffConfigurationReq updateHandoffConfiguration1)
        {
            AxlNetClient.updateHandoffConfigurationRequest inValue = new AxlNetClient.updateHandoffConfigurationRequest();
            inValue.updateHandoffConfiguration = updateHandoffConfiguration1;
            AxlNetClient.updateHandoffConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).updateHandoffConfiguration(inValue);
            return retVal.updateHandoffConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateHandoffConfigurationResponse> AxlNetClient.AXLPort65.updateHandoffConfigurationAsync(AxlNetClient.updateHandoffConfigurationRequest request)
        {
            return base.Channel.updateHandoffConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHandoffConfigurationResponse> updateHandoffConfigurationAsync(AxlNetClient.UpdateHandoffConfigurationReq updateHandoffConfiguration)
        {
            AxlNetClient.updateHandoffConfigurationRequest inValue = new AxlNetClient.updateHandoffConfigurationRequest();
            inValue.updateHandoffConfiguration = updateHandoffConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).updateHandoffConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getHandoffConfigurationResponse AxlNetClient.AXLPort65.getHandoffConfiguration(AxlNetClient.getHandoffConfigurationRequest request)
        {
            return base.Channel.getHandoffConfiguration(request);
        }

        public AxlNetClient.GetHandoffConfigurationRes getHandoffConfiguration(AxlNetClient.GetHandoffConfigurationReq getHandoffConfiguration1)
        {
            AxlNetClient.getHandoffConfigurationRequest inValue = new AxlNetClient.getHandoffConfigurationRequest();
            inValue.getHandoffConfiguration = getHandoffConfiguration1;
            AxlNetClient.getHandoffConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).getHandoffConfiguration(inValue);
            return retVal.getHandoffConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getHandoffConfigurationResponse> AxlNetClient.AXLPort65.getHandoffConfigurationAsync(AxlNetClient.getHandoffConfigurationRequest request)
        {
            return base.Channel.getHandoffConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHandoffConfigurationResponse> getHandoffConfigurationAsync(AxlNetClient.GetHandoffConfigurationReq getHandoffConfiguration)
        {
            AxlNetClient.getHandoffConfigurationRequest inValue = new AxlNetClient.getHandoffConfigurationRequest();
            inValue.getHandoffConfiguration = getHandoffConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).getHandoffConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeHandoffConfigurationResponse AxlNetClient.AXLPort65.removeHandoffConfiguration(AxlNetClient.removeHandoffConfigurationRequest request)
        {
            return base.Channel.removeHandoffConfiguration(request);
        }

        public AxlNetClient.StandardResponse removeHandoffConfiguration(AxlNetClient.RemoveHandoffConfigurationReq removeHandoffConfiguration1)
        {
            AxlNetClient.removeHandoffConfigurationRequest inValue = new AxlNetClient.removeHandoffConfigurationRequest();
            inValue.removeHandoffConfiguration = removeHandoffConfiguration1;
            AxlNetClient.removeHandoffConfigurationResponse retVal = ((AxlNetClient.AXLPort65)(this)).removeHandoffConfiguration(inValue);
            return retVal.removeHandoffConfigurationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeHandoffConfigurationResponse> AxlNetClient.AXLPort65.removeHandoffConfigurationAsync(AxlNetClient.removeHandoffConfigurationRequest request)
        {
            return base.Channel.removeHandoffConfigurationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHandoffConfigurationResponse> removeHandoffConfigurationAsync(AxlNetClient.RemoveHandoffConfigurationReq removeHandoffConfiguration)
        {
            AxlNetClient.removeHandoffConfigurationRequest inValue = new AxlNetClient.removeHandoffConfigurationRequest();
            inValue.removeHandoffConfiguration = removeHandoffConfiguration;
            return ((AxlNetClient.AXLPort65)(this)).removeHandoffConfigurationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCalledPartyTracingResponse AxlNetClient.AXLPort65.addCalledPartyTracing(AxlNetClient.addCalledPartyTracingRequest request)
        {
            return base.Channel.addCalledPartyTracing(request);
        }

        public AxlNetClient.StandardResponse addCalledPartyTracing(AxlNetClient.AddCalledPartyTracingReq addCalledPartyTracing1)
        {
            AxlNetClient.addCalledPartyTracingRequest inValue = new AxlNetClient.addCalledPartyTracingRequest();
            inValue.addCalledPartyTracing = addCalledPartyTracing1;
            AxlNetClient.addCalledPartyTracingResponse retVal = ((AxlNetClient.AXLPort65)(this)).addCalledPartyTracing(inValue);
            return retVal.addCalledPartyTracingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTracingResponse> AxlNetClient.AXLPort65.addCalledPartyTracingAsync(AxlNetClient.addCalledPartyTracingRequest request)
        {
            return base.Channel.addCalledPartyTracingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCalledPartyTracingResponse> addCalledPartyTracingAsync(AxlNetClient.AddCalledPartyTracingReq addCalledPartyTracing)
        {
            AxlNetClient.addCalledPartyTracingRequest inValue = new AxlNetClient.addCalledPartyTracingRequest();
            inValue.addCalledPartyTracing = addCalledPartyTracing;
            return ((AxlNetClient.AXLPort65)(this)).addCalledPartyTracingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCalledPartyTracingResponse AxlNetClient.AXLPort65.removeCalledPartyTracing(AxlNetClient.removeCalledPartyTracingRequest request)
        {
            return base.Channel.removeCalledPartyTracing(request);
        }

        public AxlNetClient.StandardResponse removeCalledPartyTracing(AxlNetClient.RemoveCalledPartyTracingReq removeCalledPartyTracing1)
        {
            AxlNetClient.removeCalledPartyTracingRequest inValue = new AxlNetClient.removeCalledPartyTracingRequest();
            inValue.removeCalledPartyTracing = removeCalledPartyTracing1;
            AxlNetClient.removeCalledPartyTracingResponse retVal = ((AxlNetClient.AXLPort65)(this)).removeCalledPartyTracing(inValue);
            return retVal.removeCalledPartyTracingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTracingResponse> AxlNetClient.AXLPort65.removeCalledPartyTracingAsync(AxlNetClient.removeCalledPartyTracingRequest request)
        {
            return base.Channel.removeCalledPartyTracingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCalledPartyTracingResponse> removeCalledPartyTracingAsync(AxlNetClient.RemoveCalledPartyTracingReq removeCalledPartyTracing)
        {
            AxlNetClient.removeCalledPartyTracingRequest inValue = new AxlNetClient.removeCalledPartyTracingRequest();
            inValue.removeCalledPartyTracing = removeCalledPartyTracing;
            return ((AxlNetClient.AXLPort65)(this)).removeCalledPartyTracingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCalledPartyTracingResponse AxlNetClient.AXLPort65.listCalledPartyTracing(AxlNetClient.listCalledPartyTracingRequest request)
        {
            return base.Channel.listCalledPartyTracing(request);
        }

        public AxlNetClient.ListCalledPartyTracingRes listCalledPartyTracing(AxlNetClient.ListCalledPartyTracingReq listCalledPartyTracing1)
        {
            AxlNetClient.listCalledPartyTracingRequest inValue = new AxlNetClient.listCalledPartyTracingRequest();
            inValue.listCalledPartyTracing = listCalledPartyTracing1;
            AxlNetClient.listCalledPartyTracingResponse retVal = ((AxlNetClient.AXLPort65)(this)).listCalledPartyTracing(inValue);
            return retVal.listCalledPartyTracingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTracingResponse> AxlNetClient.AXLPort65.listCalledPartyTracingAsync(AxlNetClient.listCalledPartyTracingRequest request)
        {
            return base.Channel.listCalledPartyTracingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCalledPartyTracingResponse> listCalledPartyTracingAsync(AxlNetClient.ListCalledPartyTracingReq listCalledPartyTracing)
        {
            AxlNetClient.listCalledPartyTracingRequest inValue = new AxlNetClient.listCalledPartyTracingRequest();
            inValue.listCalledPartyTracing = listCalledPartyTracing;
            return ((AxlNetClient.AXLPort65)(this)).listCalledPartyTracingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSIPNormalizationScriptResponse AxlNetClient.AXLPort65.addSIPNormalizationScript(AxlNetClient.addSIPNormalizationScriptRequest request)
        {
            return base.Channel.addSIPNormalizationScript(request);
        }

        public AxlNetClient.StandardResponse addSIPNormalizationScript(AxlNetClient.AddSIPNormalizationScriptReq addSIPNormalizationScript1)
        {
            AxlNetClient.addSIPNormalizationScriptRequest inValue = new AxlNetClient.addSIPNormalizationScriptRequest();
            inValue.addSIPNormalizationScript = addSIPNormalizationScript1;
            AxlNetClient.addSIPNormalizationScriptResponse retVal = ((AxlNetClient.AXLPort65)(this)).addSIPNormalizationScript(inValue);
            return retVal.addSIPNormalizationScriptResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSIPNormalizationScriptResponse> AxlNetClient.AXLPort65.addSIPNormalizationScriptAsync(AxlNetClient.addSIPNormalizationScriptRequest request)
        {
            return base.Channel.addSIPNormalizationScriptAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSIPNormalizationScriptResponse> addSIPNormalizationScriptAsync(AxlNetClient.AddSIPNormalizationScriptReq addSIPNormalizationScript)
        {
            AxlNetClient.addSIPNormalizationScriptRequest inValue = new AxlNetClient.addSIPNormalizationScriptRequest();
            inValue.addSIPNormalizationScript = addSIPNormalizationScript;
            return ((AxlNetClient.AXLPort65)(this)).addSIPNormalizationScriptAsync(inValue);
        }
    }
}