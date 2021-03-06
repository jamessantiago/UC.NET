namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient38 _axlPortClient38;

        private static AXLPortClient38 axlPortClient38 => _axlPortClient38 == null ||
            _axlPortClient38.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient38 = LoadClient38()) : _axlPortClient38;

        private static AXLPortClient38 LoadClient38()
        {
            var client = new AXLPortClient38(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close38;
            OnAbort += Abort38;
            return client;
        }

        private static void Close38(object sender, System.EventArgs e)
        {
            _axlPortClient38.Close();
        }

        private static void Abort38(object sender, System.EventArgs e)
        {
            _axlPortClient38.Abort();
        }

        public AxlNetClient.ListSipDialRulesRes listSipDialRules(AxlNetClient.ListSipDialRulesReq listSipDialRules1)
        {
            return axlPortClient38.listSipDialRules(listSipDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipDialRulesResponse> listSipDialRulesAsync(AxlNetClient.ListSipDialRulesReq listSipDialRules)
        {
            return axlPortClient38.listSipDialRulesAsync(listSipDialRules);
        }

        public AxlNetClient.StandardResponse addConferenceBridge(AxlNetClient.AddConferenceBridgeReq addConferenceBridge1)
        {
            return axlPortClient38.addConferenceBridge(addConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addConferenceBridgeResponse> addConferenceBridgeAsync(AxlNetClient.AddConferenceBridgeReq addConferenceBridge)
        {
            return axlPortClient38.addConferenceBridgeAsync(addConferenceBridge);
        }

        public AxlNetClient.StandardResponse updateConferenceBridge(AxlNetClient.UpdateConferenceBridgeReq updateConferenceBridge1)
        {
            return axlPortClient38.updateConferenceBridge(updateConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateConferenceBridgeResponse> updateConferenceBridgeAsync(AxlNetClient.UpdateConferenceBridgeReq updateConferenceBridge)
        {
            return axlPortClient38.updateConferenceBridgeAsync(updateConferenceBridge);
        }

        public AxlNetClient.GetConferenceBridgeRes getConferenceBridge(AxlNetClient.GetConferenceBridgeReq getConferenceBridge1)
        {
            return axlPortClient38.getConferenceBridge(getConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getConferenceBridgeResponse> getConferenceBridgeAsync(AxlNetClient.GetConferenceBridgeReq getConferenceBridge)
        {
            return axlPortClient38.getConferenceBridgeAsync(getConferenceBridge);
        }

        public AxlNetClient.StandardResponse removeConferenceBridge(AxlNetClient.NameAndGUIDRequest removeConferenceBridge1)
        {
            return axlPortClient38.removeConferenceBridge(removeConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeConferenceBridgeResponse> removeConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest removeConferenceBridge)
        {
            return axlPortClient38.removeConferenceBridgeAsync(removeConferenceBridge);
        }

        public AxlNetClient.ListConferenceBridgeRes listConferenceBridge(AxlNetClient.ListConferenceBridgeReq listConferenceBridge1)
        {
            return axlPortClient38.listConferenceBridge(listConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listConferenceBridgeResponse> listConferenceBridgeAsync(AxlNetClient.ListConferenceBridgeReq listConferenceBridge)
        {
            return axlPortClient38.listConferenceBridgeAsync(listConferenceBridge);
        }

        public AxlNetClient.StandardResponse resetConferenceBridge(AxlNetClient.NameAndGUIDRequest resetConferenceBridge1)
        {
            return axlPortClient38.resetConferenceBridge(resetConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetConferenceBridgeResponse> resetConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest resetConferenceBridge)
        {
            return axlPortClient38.resetConferenceBridgeAsync(resetConferenceBridge);
        }

        public AxlNetClient.StandardResponse restartConferenceBridge(AxlNetClient.NameAndGUIDRequest restartConferenceBridge1)
        {
            return axlPortClient38.restartConferenceBridge(restartConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartConferenceBridgeResponse> restartConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest restartConferenceBridge)
        {
            return axlPortClient38.restartConferenceBridgeAsync(restartConferenceBridge);
        }

        public AxlNetClient.StandardResponse applyConferenceBridge(AxlNetClient.NameAndGUIDRequest applyConferenceBridge1)
        {
            return axlPortClient38.applyConferenceBridge(applyConferenceBridge1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyConferenceBridgeResponse> applyConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest applyConferenceBridge)
        {
            return axlPortClient38.applyConferenceBridgeAsync(applyConferenceBridge);
        }

        public AxlNetClient.StandardResponse updateAnnunciator(AxlNetClient.UpdateAnnunciatorReq updateAnnunciator1)
        {
            return axlPortClient38.updateAnnunciator(updateAnnunciator1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAnnunciatorResponse> updateAnnunciatorAsync(AxlNetClient.UpdateAnnunciatorReq updateAnnunciator)
        {
            return axlPortClient38.updateAnnunciatorAsync(updateAnnunciator);
        }

        public AxlNetClient.GetAnnunciatorRes getAnnunciator(AxlNetClient.GetAnnunciatorReq getAnnunciator1)
        {
            return axlPortClient38.getAnnunciator(getAnnunciator1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAnnunciatorResponse> getAnnunciatorAsync(AxlNetClient.GetAnnunciatorReq getAnnunciator)
        {
            return axlPortClient38.getAnnunciatorAsync(getAnnunciator);
        }

        public AxlNetClient.ListAnnunciatorRes listAnnunciator(AxlNetClient.ListAnnunciatorReq listAnnunciator1)
        {
            return axlPortClient38.listAnnunciator(listAnnunciator1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAnnunciatorResponse> listAnnunciatorAsync(AxlNetClient.ListAnnunciatorReq listAnnunciator)
        {
            return axlPortClient38.listAnnunciatorAsync(listAnnunciator);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort38
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipDialRulesResponse listSipDialRules(AxlNetClient.listSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipDialRulesResponse> listSipDialRulesAsync(AxlNetClient.listSipDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addConferenceBridgeResponse addConferenceBridge(AxlNetClient.addConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addConferenceBridgeResponse> addConferenceBridgeAsync(AxlNetClient.addConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateConferenceBridgeResponse updateConferenceBridge(AxlNetClient.updateConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateConferenceBridgeResponse> updateConferenceBridgeAsync(AxlNetClient.updateConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getConferenceBridgeResponse getConferenceBridge(AxlNetClient.getConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getConferenceBridgeResponse> getConferenceBridgeAsync(AxlNetClient.getConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeConferenceBridgeResponse removeConferenceBridge(AxlNetClient.removeConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeConferenceBridgeResponse> removeConferenceBridgeAsync(AxlNetClient.removeConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listConferenceBridgeResponse listConferenceBridge(AxlNetClient.listConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listConferenceBridgeResponse> listConferenceBridgeAsync(AxlNetClient.listConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetConferenceBridgeResponse resetConferenceBridge(AxlNetClient.resetConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetConferenceBridgeResponse> resetConferenceBridgeAsync(AxlNetClient.resetConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartConferenceBridgeResponse restartConferenceBridge(AxlNetClient.restartConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartConferenceBridgeResponse> restartConferenceBridgeAsync(AxlNetClient.restartConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyConferenceBridge", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyConferenceBridgeResponse applyConferenceBridge(AxlNetClient.applyConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyConferenceBridge", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyConferenceBridgeResponse> applyConferenceBridgeAsync(AxlNetClient.applyConferenceBridgeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAnnunciator", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAnnunciatorResponse updateAnnunciator(AxlNetClient.updateAnnunciatorRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAnnunciator", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAnnunciatorResponse> updateAnnunciatorAsync(AxlNetClient.updateAnnunciatorRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAnnunciator", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAnnunciatorResponse getAnnunciator(AxlNetClient.getAnnunciatorRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAnnunciator", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAnnunciatorResponse> getAnnunciatorAsync(AxlNetClient.getAnnunciatorRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAnnunciator", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAnnunciatorResponse listAnnunciator(AxlNetClient.listAnnunciatorRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAnnunciator", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAnnunciatorResponse> listAnnunciatorAsync(AxlNetClient.listAnnunciatorRequest request);
    }

    public class AXLPortClient38 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort38>, AxlNetClient.AXLPort38
    {
        public AXLPortClient38(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipDialRulesResponse AxlNetClient.AXLPort38.listSipDialRules(AxlNetClient.listSipDialRulesRequest request)
        {
            return base.Channel.listSipDialRules(request);
        }

        public AxlNetClient.ListSipDialRulesRes listSipDialRules(AxlNetClient.ListSipDialRulesReq listSipDialRules1)
        {
            AxlNetClient.listSipDialRulesRequest inValue = new AxlNetClient.listSipDialRulesRequest();
            inValue.listSipDialRules = listSipDialRules1;
            AxlNetClient.listSipDialRulesResponse retVal = ((AxlNetClient.AXLPort38)(this)).listSipDialRules(inValue);
            return retVal.listSipDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipDialRulesResponse> AxlNetClient.AXLPort38.listSipDialRulesAsync(AxlNetClient.listSipDialRulesRequest request)
        {
            return base.Channel.listSipDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipDialRulesResponse> listSipDialRulesAsync(AxlNetClient.ListSipDialRulesReq listSipDialRules)
        {
            AxlNetClient.listSipDialRulesRequest inValue = new AxlNetClient.listSipDialRulesRequest();
            inValue.listSipDialRules = listSipDialRules;
            return ((AxlNetClient.AXLPort38)(this)).listSipDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addConferenceBridgeResponse AxlNetClient.AXLPort38.addConferenceBridge(AxlNetClient.addConferenceBridgeRequest request)
        {
            return base.Channel.addConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse addConferenceBridge(AxlNetClient.AddConferenceBridgeReq addConferenceBridge1)
        {
            AxlNetClient.addConferenceBridgeRequest inValue = new AxlNetClient.addConferenceBridgeRequest();
            inValue.addConferenceBridge = addConferenceBridge1;
            AxlNetClient.addConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).addConferenceBridge(inValue);
            return retVal.addConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addConferenceBridgeResponse> AxlNetClient.AXLPort38.addConferenceBridgeAsync(AxlNetClient.addConferenceBridgeRequest request)
        {
            return base.Channel.addConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addConferenceBridgeResponse> addConferenceBridgeAsync(AxlNetClient.AddConferenceBridgeReq addConferenceBridge)
        {
            AxlNetClient.addConferenceBridgeRequest inValue = new AxlNetClient.addConferenceBridgeRequest();
            inValue.addConferenceBridge = addConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).addConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateConferenceBridgeResponse AxlNetClient.AXLPort38.updateConferenceBridge(AxlNetClient.updateConferenceBridgeRequest request)
        {
            return base.Channel.updateConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse updateConferenceBridge(AxlNetClient.UpdateConferenceBridgeReq updateConferenceBridge1)
        {
            AxlNetClient.updateConferenceBridgeRequest inValue = new AxlNetClient.updateConferenceBridgeRequest();
            inValue.updateConferenceBridge = updateConferenceBridge1;
            AxlNetClient.updateConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).updateConferenceBridge(inValue);
            return retVal.updateConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateConferenceBridgeResponse> AxlNetClient.AXLPort38.updateConferenceBridgeAsync(AxlNetClient.updateConferenceBridgeRequest request)
        {
            return base.Channel.updateConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateConferenceBridgeResponse> updateConferenceBridgeAsync(AxlNetClient.UpdateConferenceBridgeReq updateConferenceBridge)
        {
            AxlNetClient.updateConferenceBridgeRequest inValue = new AxlNetClient.updateConferenceBridgeRequest();
            inValue.updateConferenceBridge = updateConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).updateConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getConferenceBridgeResponse AxlNetClient.AXLPort38.getConferenceBridge(AxlNetClient.getConferenceBridgeRequest request)
        {
            return base.Channel.getConferenceBridge(request);
        }

        public AxlNetClient.GetConferenceBridgeRes getConferenceBridge(AxlNetClient.GetConferenceBridgeReq getConferenceBridge1)
        {
            AxlNetClient.getConferenceBridgeRequest inValue = new AxlNetClient.getConferenceBridgeRequest();
            inValue.getConferenceBridge = getConferenceBridge1;
            AxlNetClient.getConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).getConferenceBridge(inValue);
            return retVal.getConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getConferenceBridgeResponse> AxlNetClient.AXLPort38.getConferenceBridgeAsync(AxlNetClient.getConferenceBridgeRequest request)
        {
            return base.Channel.getConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getConferenceBridgeResponse> getConferenceBridgeAsync(AxlNetClient.GetConferenceBridgeReq getConferenceBridge)
        {
            AxlNetClient.getConferenceBridgeRequest inValue = new AxlNetClient.getConferenceBridgeRequest();
            inValue.getConferenceBridge = getConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).getConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeConferenceBridgeResponse AxlNetClient.AXLPort38.removeConferenceBridge(AxlNetClient.removeConferenceBridgeRequest request)
        {
            return base.Channel.removeConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse removeConferenceBridge(AxlNetClient.NameAndGUIDRequest removeConferenceBridge1)
        {
            AxlNetClient.removeConferenceBridgeRequest inValue = new AxlNetClient.removeConferenceBridgeRequest();
            inValue.removeConferenceBridge = removeConferenceBridge1;
            AxlNetClient.removeConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).removeConferenceBridge(inValue);
            return retVal.removeConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeConferenceBridgeResponse> AxlNetClient.AXLPort38.removeConferenceBridgeAsync(AxlNetClient.removeConferenceBridgeRequest request)
        {
            return base.Channel.removeConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeConferenceBridgeResponse> removeConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest removeConferenceBridge)
        {
            AxlNetClient.removeConferenceBridgeRequest inValue = new AxlNetClient.removeConferenceBridgeRequest();
            inValue.removeConferenceBridge = removeConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).removeConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listConferenceBridgeResponse AxlNetClient.AXLPort38.listConferenceBridge(AxlNetClient.listConferenceBridgeRequest request)
        {
            return base.Channel.listConferenceBridge(request);
        }

        public AxlNetClient.ListConferenceBridgeRes listConferenceBridge(AxlNetClient.ListConferenceBridgeReq listConferenceBridge1)
        {
            AxlNetClient.listConferenceBridgeRequest inValue = new AxlNetClient.listConferenceBridgeRequest();
            inValue.listConferenceBridge = listConferenceBridge1;
            AxlNetClient.listConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).listConferenceBridge(inValue);
            return retVal.listConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listConferenceBridgeResponse> AxlNetClient.AXLPort38.listConferenceBridgeAsync(AxlNetClient.listConferenceBridgeRequest request)
        {
            return base.Channel.listConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listConferenceBridgeResponse> listConferenceBridgeAsync(AxlNetClient.ListConferenceBridgeReq listConferenceBridge)
        {
            AxlNetClient.listConferenceBridgeRequest inValue = new AxlNetClient.listConferenceBridgeRequest();
            inValue.listConferenceBridge = listConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).listConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetConferenceBridgeResponse AxlNetClient.AXLPort38.resetConferenceBridge(AxlNetClient.resetConferenceBridgeRequest request)
        {
            return base.Channel.resetConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse resetConferenceBridge(AxlNetClient.NameAndGUIDRequest resetConferenceBridge1)
        {
            AxlNetClient.resetConferenceBridgeRequest inValue = new AxlNetClient.resetConferenceBridgeRequest();
            inValue.resetConferenceBridge = resetConferenceBridge1;
            AxlNetClient.resetConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).resetConferenceBridge(inValue);
            return retVal.resetConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetConferenceBridgeResponse> AxlNetClient.AXLPort38.resetConferenceBridgeAsync(AxlNetClient.resetConferenceBridgeRequest request)
        {
            return base.Channel.resetConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetConferenceBridgeResponse> resetConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest resetConferenceBridge)
        {
            AxlNetClient.resetConferenceBridgeRequest inValue = new AxlNetClient.resetConferenceBridgeRequest();
            inValue.resetConferenceBridge = resetConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).resetConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartConferenceBridgeResponse AxlNetClient.AXLPort38.restartConferenceBridge(AxlNetClient.restartConferenceBridgeRequest request)
        {
            return base.Channel.restartConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse restartConferenceBridge(AxlNetClient.NameAndGUIDRequest restartConferenceBridge1)
        {
            AxlNetClient.restartConferenceBridgeRequest inValue = new AxlNetClient.restartConferenceBridgeRequest();
            inValue.restartConferenceBridge = restartConferenceBridge1;
            AxlNetClient.restartConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).restartConferenceBridge(inValue);
            return retVal.restartConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartConferenceBridgeResponse> AxlNetClient.AXLPort38.restartConferenceBridgeAsync(AxlNetClient.restartConferenceBridgeRequest request)
        {
            return base.Channel.restartConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartConferenceBridgeResponse> restartConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest restartConferenceBridge)
        {
            AxlNetClient.restartConferenceBridgeRequest inValue = new AxlNetClient.restartConferenceBridgeRequest();
            inValue.restartConferenceBridge = restartConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).restartConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyConferenceBridgeResponse AxlNetClient.AXLPort38.applyConferenceBridge(AxlNetClient.applyConferenceBridgeRequest request)
        {
            return base.Channel.applyConferenceBridge(request);
        }

        public AxlNetClient.StandardResponse applyConferenceBridge(AxlNetClient.NameAndGUIDRequest applyConferenceBridge1)
        {
            AxlNetClient.applyConferenceBridgeRequest inValue = new AxlNetClient.applyConferenceBridgeRequest();
            inValue.applyConferenceBridge = applyConferenceBridge1;
            AxlNetClient.applyConferenceBridgeResponse retVal = ((AxlNetClient.AXLPort38)(this)).applyConferenceBridge(inValue);
            return retVal.applyConferenceBridgeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyConferenceBridgeResponse> AxlNetClient.AXLPort38.applyConferenceBridgeAsync(AxlNetClient.applyConferenceBridgeRequest request)
        {
            return base.Channel.applyConferenceBridgeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyConferenceBridgeResponse> applyConferenceBridgeAsync(AxlNetClient.NameAndGUIDRequest applyConferenceBridge)
        {
            AxlNetClient.applyConferenceBridgeRequest inValue = new AxlNetClient.applyConferenceBridgeRequest();
            inValue.applyConferenceBridge = applyConferenceBridge;
            return ((AxlNetClient.AXLPort38)(this)).applyConferenceBridgeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAnnunciatorResponse AxlNetClient.AXLPort38.updateAnnunciator(AxlNetClient.updateAnnunciatorRequest request)
        {
            return base.Channel.updateAnnunciator(request);
        }

        public AxlNetClient.StandardResponse updateAnnunciator(AxlNetClient.UpdateAnnunciatorReq updateAnnunciator1)
        {
            AxlNetClient.updateAnnunciatorRequest inValue = new AxlNetClient.updateAnnunciatorRequest();
            inValue.updateAnnunciator = updateAnnunciator1;
            AxlNetClient.updateAnnunciatorResponse retVal = ((AxlNetClient.AXLPort38)(this)).updateAnnunciator(inValue);
            return retVal.updateAnnunciatorResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAnnunciatorResponse> AxlNetClient.AXLPort38.updateAnnunciatorAsync(AxlNetClient.updateAnnunciatorRequest request)
        {
            return base.Channel.updateAnnunciatorAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAnnunciatorResponse> updateAnnunciatorAsync(AxlNetClient.UpdateAnnunciatorReq updateAnnunciator)
        {
            AxlNetClient.updateAnnunciatorRequest inValue = new AxlNetClient.updateAnnunciatorRequest();
            inValue.updateAnnunciator = updateAnnunciator;
            return ((AxlNetClient.AXLPort38)(this)).updateAnnunciatorAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAnnunciatorResponse AxlNetClient.AXLPort38.getAnnunciator(AxlNetClient.getAnnunciatorRequest request)
        {
            return base.Channel.getAnnunciator(request);
        }

        public AxlNetClient.GetAnnunciatorRes getAnnunciator(AxlNetClient.GetAnnunciatorReq getAnnunciator1)
        {
            AxlNetClient.getAnnunciatorRequest inValue = new AxlNetClient.getAnnunciatorRequest();
            inValue.getAnnunciator = getAnnunciator1;
            AxlNetClient.getAnnunciatorResponse retVal = ((AxlNetClient.AXLPort38)(this)).getAnnunciator(inValue);
            return retVal.getAnnunciatorResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAnnunciatorResponse> AxlNetClient.AXLPort38.getAnnunciatorAsync(AxlNetClient.getAnnunciatorRequest request)
        {
            return base.Channel.getAnnunciatorAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAnnunciatorResponse> getAnnunciatorAsync(AxlNetClient.GetAnnunciatorReq getAnnunciator)
        {
            AxlNetClient.getAnnunciatorRequest inValue = new AxlNetClient.getAnnunciatorRequest();
            inValue.getAnnunciator = getAnnunciator;
            return ((AxlNetClient.AXLPort38)(this)).getAnnunciatorAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAnnunciatorResponse AxlNetClient.AXLPort38.listAnnunciator(AxlNetClient.listAnnunciatorRequest request)
        {
            return base.Channel.listAnnunciator(request);
        }

        public AxlNetClient.ListAnnunciatorRes listAnnunciator(AxlNetClient.ListAnnunciatorReq listAnnunciator1)
        {
            AxlNetClient.listAnnunciatorRequest inValue = new AxlNetClient.listAnnunciatorRequest();
            inValue.listAnnunciator = listAnnunciator1;
            AxlNetClient.listAnnunciatorResponse retVal = ((AxlNetClient.AXLPort38)(this)).listAnnunciator(inValue);
            return retVal.listAnnunciatorResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAnnunciatorResponse> AxlNetClient.AXLPort38.listAnnunciatorAsync(AxlNetClient.listAnnunciatorRequest request)
        {
            return base.Channel.listAnnunciatorAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAnnunciatorResponse> listAnnunciatorAsync(AxlNetClient.ListAnnunciatorReq listAnnunciator)
        {
            AxlNetClient.listAnnunciatorRequest inValue = new AxlNetClient.listAnnunciatorRequest();
            inValue.listAnnunciator = listAnnunciator;
            return ((AxlNetClient.AXLPort38)(this)).listAnnunciatorAsync(inValue);
        }
    }
}