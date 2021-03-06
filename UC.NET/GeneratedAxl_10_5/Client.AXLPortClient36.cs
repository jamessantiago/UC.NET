namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient36 _axlPortClient36;

        private static AXLPortClient36 axlPortClient36 => _axlPortClient36 == null ||
            _axlPortClient36.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient36 = LoadClient36()) : _axlPortClient36;

        private static AXLPortClient36 LoadClient36()
        {
            var client = new AXLPortClient36(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close36;
            OnAbort += Abort36;
            return client;
        }

        private static void Close36(object sender, System.EventArgs e)
        {
            _axlPortClient36.Close();
        }

        private static void Abort36(object sender, System.EventArgs e)
        {
            _axlPortClient36.Abort();
        }

        public AxlNetClient.GetRoutePatternRes getRoutePattern(AxlNetClient.GetRoutePatternReq getRoutePattern1)
        {
            return axlPortClient36.getRoutePattern(getRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRoutePatternResponse> getRoutePatternAsync(AxlNetClient.GetRoutePatternReq getRoutePattern)
        {
            return axlPortClient36.getRoutePatternAsync(getRoutePattern);
        }

        public AxlNetClient.StandardResponse removeRoutePattern(AxlNetClient.RemoveRoutePatternReq removeRoutePattern1)
        {
            return axlPortClient36.removeRoutePattern(removeRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRoutePatternResponse> removeRoutePatternAsync(AxlNetClient.RemoveRoutePatternReq removeRoutePattern)
        {
            return axlPortClient36.removeRoutePatternAsync(removeRoutePattern);
        }

        public AxlNetClient.ListRoutePatternRes listRoutePattern(AxlNetClient.ListRoutePatternReq listRoutePattern1)
        {
            return axlPortClient36.listRoutePattern(listRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePatternResponse> listRoutePatternAsync(AxlNetClient.ListRoutePatternReq listRoutePattern)
        {
            return axlPortClient36.listRoutePatternAsync(listRoutePattern);
        }

        public AxlNetClient.StandardResponse addApplicationDialRules(AxlNetClient.AddApplicationDialRulesReq addApplicationDialRules1)
        {
            return axlPortClient36.addApplicationDialRules(addApplicationDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationDialRulesResponse> addApplicationDialRulesAsync(AxlNetClient.AddApplicationDialRulesReq addApplicationDialRules)
        {
            return axlPortClient36.addApplicationDialRulesAsync(addApplicationDialRules);
        }

        public AxlNetClient.StandardResponse updateApplicationDialRules(AxlNetClient.UpdateApplicationDialRulesReq updateApplicationDialRules1)
        {
            return axlPortClient36.updateApplicationDialRules(updateApplicationDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationDialRulesResponse> updateApplicationDialRulesAsync(AxlNetClient.UpdateApplicationDialRulesReq updateApplicationDialRules)
        {
            return axlPortClient36.updateApplicationDialRulesAsync(updateApplicationDialRules);
        }

        public AxlNetClient.GetApplicationDialRulesRes getApplicationDialRules(AxlNetClient.GetApplicationDialRulesReq getApplicationDialRules1)
        {
            return axlPortClient36.getApplicationDialRules(getApplicationDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationDialRulesResponse> getApplicationDialRulesAsync(AxlNetClient.GetApplicationDialRulesReq getApplicationDialRules)
        {
            return axlPortClient36.getApplicationDialRulesAsync(getApplicationDialRules);
        }

        public AxlNetClient.StandardResponse removeApplicationDialRules(AxlNetClient.NameAndGUIDRequest removeApplicationDialRules1)
        {
            return axlPortClient36.removeApplicationDialRules(removeApplicationDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationDialRulesResponse> removeApplicationDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeApplicationDialRules)
        {
            return axlPortClient36.removeApplicationDialRulesAsync(removeApplicationDialRules);
        }

        public AxlNetClient.ListApplicationDialRulesRes listApplicationDialRules(AxlNetClient.ListApplicationDialRulesReq listApplicationDialRules1)
        {
            return axlPortClient36.listApplicationDialRules(listApplicationDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationDialRulesResponse> listApplicationDialRulesAsync(AxlNetClient.ListApplicationDialRulesReq listApplicationDialRules)
        {
            return axlPortClient36.listApplicationDialRulesAsync(listApplicationDialRules);
        }

        public AxlNetClient.StandardResponse addDirectoryLookupDialRules(AxlNetClient.AddDirectoryLookupDialRulesReq addDirectoryLookupDialRules1)
        {
            return axlPortClient36.addDirectoryLookupDialRules(addDirectoryLookupDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirectoryLookupDialRulesResponse> addDirectoryLookupDialRulesAsync(AxlNetClient.AddDirectoryLookupDialRulesReq addDirectoryLookupDialRules)
        {
            return axlPortClient36.addDirectoryLookupDialRulesAsync(addDirectoryLookupDialRules);
        }

        public AxlNetClient.StandardResponse updateDirectoryLookupDialRules(AxlNetClient.UpdateDirectoryLookupDialRulesReq updateDirectoryLookupDialRules1)
        {
            return axlPortClient36.updateDirectoryLookupDialRules(updateDirectoryLookupDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirectoryLookupDialRulesResponse> updateDirectoryLookupDialRulesAsync(AxlNetClient.UpdateDirectoryLookupDialRulesReq updateDirectoryLookupDialRules)
        {
            return axlPortClient36.updateDirectoryLookupDialRulesAsync(updateDirectoryLookupDialRules);
        }

        public AxlNetClient.GetDirectoryLookupDialRulesRes getDirectoryLookupDialRules(AxlNetClient.GetDirectoryLookupDialRulesReq getDirectoryLookupDialRules1)
        {
            return axlPortClient36.getDirectoryLookupDialRules(getDirectoryLookupDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirectoryLookupDialRulesResponse> getDirectoryLookupDialRulesAsync(AxlNetClient.GetDirectoryLookupDialRulesReq getDirectoryLookupDialRules)
        {
            return axlPortClient36.getDirectoryLookupDialRulesAsync(getDirectoryLookupDialRules);
        }

        public AxlNetClient.StandardResponse removeDirectoryLookupDialRules(AxlNetClient.NameAndGUIDRequest removeDirectoryLookupDialRules1)
        {
            return axlPortClient36.removeDirectoryLookupDialRules(removeDirectoryLookupDialRules1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirectoryLookupDialRulesResponse> removeDirectoryLookupDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeDirectoryLookupDialRules)
        {
            return axlPortClient36.removeDirectoryLookupDialRulesAsync(removeDirectoryLookupDialRules);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort36
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRoutePatternResponse getRoutePattern(AxlNetClient.getRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRoutePatternResponse> getRoutePatternAsync(AxlNetClient.getRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRoutePatternResponse removeRoutePattern(AxlNetClient.removeRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRoutePatternResponse> removeRoutePatternAsync(AxlNetClient.removeRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRoutePatternResponse listRoutePattern(AxlNetClient.listRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePatternResponse> listRoutePatternAsync(AxlNetClient.listRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addApplicationDialRulesResponse addApplicationDialRules(AxlNetClient.addApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addApplicationDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationDialRulesResponse> addApplicationDialRulesAsync(AxlNetClient.addApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateApplicationDialRulesResponse updateApplicationDialRules(AxlNetClient.updateApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateApplicationDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationDialRulesResponse> updateApplicationDialRulesAsync(AxlNetClient.updateApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getApplicationDialRulesResponse getApplicationDialRules(AxlNetClient.getApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getApplicationDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationDialRulesResponse> getApplicationDialRulesAsync(AxlNetClient.getApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeApplicationDialRulesResponse removeApplicationDialRules(AxlNetClient.removeApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeApplicationDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationDialRulesResponse> removeApplicationDialRulesAsync(AxlNetClient.removeApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listApplicationDialRulesResponse listApplicationDialRules(AxlNetClient.listApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listApplicationDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationDialRulesResponse> listApplicationDialRulesAsync(AxlNetClient.listApplicationDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirectoryLookupDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDirectoryLookupDialRulesResponse addDirectoryLookupDialRules(AxlNetClient.addDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirectoryLookupDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDirectoryLookupDialRulesResponse> addDirectoryLookupDialRulesAsync(AxlNetClient.addDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirectoryLookupDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDirectoryLookupDialRulesResponse updateDirectoryLookupDialRules(AxlNetClient.updateDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirectoryLookupDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDirectoryLookupDialRulesResponse> updateDirectoryLookupDialRulesAsync(AxlNetClient.updateDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirectoryLookupDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDirectoryLookupDialRulesResponse getDirectoryLookupDialRules(AxlNetClient.getDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirectoryLookupDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDirectoryLookupDialRulesResponse> getDirectoryLookupDialRulesAsync(AxlNetClient.getDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirectoryLookupDialRules", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDirectoryLookupDialRulesResponse removeDirectoryLookupDialRules(AxlNetClient.removeDirectoryLookupDialRulesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirectoryLookupDialRules", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDirectoryLookupDialRulesResponse> removeDirectoryLookupDialRulesAsync(AxlNetClient.removeDirectoryLookupDialRulesRequest request);
    }

    public class AXLPortClient36 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort36>, AxlNetClient.AXLPort36
    {
        public AXLPortClient36(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRoutePatternResponse AxlNetClient.AXLPort36.getRoutePattern(AxlNetClient.getRoutePatternRequest request)
        {
            return base.Channel.getRoutePattern(request);
        }

        public AxlNetClient.GetRoutePatternRes getRoutePattern(AxlNetClient.GetRoutePatternReq getRoutePattern1)
        {
            AxlNetClient.getRoutePatternRequest inValue = new AxlNetClient.getRoutePatternRequest();
            inValue.getRoutePattern = getRoutePattern1;
            AxlNetClient.getRoutePatternResponse retVal = ((AxlNetClient.AXLPort36)(this)).getRoutePattern(inValue);
            return retVal.getRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRoutePatternResponse> AxlNetClient.AXLPort36.getRoutePatternAsync(AxlNetClient.getRoutePatternRequest request)
        {
            return base.Channel.getRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRoutePatternResponse> getRoutePatternAsync(AxlNetClient.GetRoutePatternReq getRoutePattern)
        {
            AxlNetClient.getRoutePatternRequest inValue = new AxlNetClient.getRoutePatternRequest();
            inValue.getRoutePattern = getRoutePattern;
            return ((AxlNetClient.AXLPort36)(this)).getRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRoutePatternResponse AxlNetClient.AXLPort36.removeRoutePattern(AxlNetClient.removeRoutePatternRequest request)
        {
            return base.Channel.removeRoutePattern(request);
        }

        public AxlNetClient.StandardResponse removeRoutePattern(AxlNetClient.RemoveRoutePatternReq removeRoutePattern1)
        {
            AxlNetClient.removeRoutePatternRequest inValue = new AxlNetClient.removeRoutePatternRequest();
            inValue.removeRoutePattern = removeRoutePattern1;
            AxlNetClient.removeRoutePatternResponse retVal = ((AxlNetClient.AXLPort36)(this)).removeRoutePattern(inValue);
            return retVal.removeRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRoutePatternResponse> AxlNetClient.AXLPort36.removeRoutePatternAsync(AxlNetClient.removeRoutePatternRequest request)
        {
            return base.Channel.removeRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRoutePatternResponse> removeRoutePatternAsync(AxlNetClient.RemoveRoutePatternReq removeRoutePattern)
        {
            AxlNetClient.removeRoutePatternRequest inValue = new AxlNetClient.removeRoutePatternRequest();
            inValue.removeRoutePattern = removeRoutePattern;
            return ((AxlNetClient.AXLPort36)(this)).removeRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRoutePatternResponse AxlNetClient.AXLPort36.listRoutePattern(AxlNetClient.listRoutePatternRequest request)
        {
            return base.Channel.listRoutePattern(request);
        }

        public AxlNetClient.ListRoutePatternRes listRoutePattern(AxlNetClient.ListRoutePatternReq listRoutePattern1)
        {
            AxlNetClient.listRoutePatternRequest inValue = new AxlNetClient.listRoutePatternRequest();
            inValue.listRoutePattern = listRoutePattern1;
            AxlNetClient.listRoutePatternResponse retVal = ((AxlNetClient.AXLPort36)(this)).listRoutePattern(inValue);
            return retVal.listRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePatternResponse> AxlNetClient.AXLPort36.listRoutePatternAsync(AxlNetClient.listRoutePatternRequest request)
        {
            return base.Channel.listRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePatternResponse> listRoutePatternAsync(AxlNetClient.ListRoutePatternReq listRoutePattern)
        {
            AxlNetClient.listRoutePatternRequest inValue = new AxlNetClient.listRoutePatternRequest();
            inValue.listRoutePattern = listRoutePattern;
            return ((AxlNetClient.AXLPort36)(this)).listRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addApplicationDialRulesResponse AxlNetClient.AXLPort36.addApplicationDialRules(AxlNetClient.addApplicationDialRulesRequest request)
        {
            return base.Channel.addApplicationDialRules(request);
        }

        public AxlNetClient.StandardResponse addApplicationDialRules(AxlNetClient.AddApplicationDialRulesReq addApplicationDialRules1)
        {
            AxlNetClient.addApplicationDialRulesRequest inValue = new AxlNetClient.addApplicationDialRulesRequest();
            inValue.addApplicationDialRules = addApplicationDialRules1;
            AxlNetClient.addApplicationDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).addApplicationDialRules(inValue);
            return retVal.addApplicationDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addApplicationDialRulesResponse> AxlNetClient.AXLPort36.addApplicationDialRulesAsync(AxlNetClient.addApplicationDialRulesRequest request)
        {
            return base.Channel.addApplicationDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addApplicationDialRulesResponse> addApplicationDialRulesAsync(AxlNetClient.AddApplicationDialRulesReq addApplicationDialRules)
        {
            AxlNetClient.addApplicationDialRulesRequest inValue = new AxlNetClient.addApplicationDialRulesRequest();
            inValue.addApplicationDialRules = addApplicationDialRules;
            return ((AxlNetClient.AXLPort36)(this)).addApplicationDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateApplicationDialRulesResponse AxlNetClient.AXLPort36.updateApplicationDialRules(AxlNetClient.updateApplicationDialRulesRequest request)
        {
            return base.Channel.updateApplicationDialRules(request);
        }

        public AxlNetClient.StandardResponse updateApplicationDialRules(AxlNetClient.UpdateApplicationDialRulesReq updateApplicationDialRules1)
        {
            AxlNetClient.updateApplicationDialRulesRequest inValue = new AxlNetClient.updateApplicationDialRulesRequest();
            inValue.updateApplicationDialRules = updateApplicationDialRules1;
            AxlNetClient.updateApplicationDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).updateApplicationDialRules(inValue);
            return retVal.updateApplicationDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateApplicationDialRulesResponse> AxlNetClient.AXLPort36.updateApplicationDialRulesAsync(AxlNetClient.updateApplicationDialRulesRequest request)
        {
            return base.Channel.updateApplicationDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateApplicationDialRulesResponse> updateApplicationDialRulesAsync(AxlNetClient.UpdateApplicationDialRulesReq updateApplicationDialRules)
        {
            AxlNetClient.updateApplicationDialRulesRequest inValue = new AxlNetClient.updateApplicationDialRulesRequest();
            inValue.updateApplicationDialRules = updateApplicationDialRules;
            return ((AxlNetClient.AXLPort36)(this)).updateApplicationDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getApplicationDialRulesResponse AxlNetClient.AXLPort36.getApplicationDialRules(AxlNetClient.getApplicationDialRulesRequest request)
        {
            return base.Channel.getApplicationDialRules(request);
        }

        public AxlNetClient.GetApplicationDialRulesRes getApplicationDialRules(AxlNetClient.GetApplicationDialRulesReq getApplicationDialRules1)
        {
            AxlNetClient.getApplicationDialRulesRequest inValue = new AxlNetClient.getApplicationDialRulesRequest();
            inValue.getApplicationDialRules = getApplicationDialRules1;
            AxlNetClient.getApplicationDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).getApplicationDialRules(inValue);
            return retVal.getApplicationDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getApplicationDialRulesResponse> AxlNetClient.AXLPort36.getApplicationDialRulesAsync(AxlNetClient.getApplicationDialRulesRequest request)
        {
            return base.Channel.getApplicationDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getApplicationDialRulesResponse> getApplicationDialRulesAsync(AxlNetClient.GetApplicationDialRulesReq getApplicationDialRules)
        {
            AxlNetClient.getApplicationDialRulesRequest inValue = new AxlNetClient.getApplicationDialRulesRequest();
            inValue.getApplicationDialRules = getApplicationDialRules;
            return ((AxlNetClient.AXLPort36)(this)).getApplicationDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeApplicationDialRulesResponse AxlNetClient.AXLPort36.removeApplicationDialRules(AxlNetClient.removeApplicationDialRulesRequest request)
        {
            return base.Channel.removeApplicationDialRules(request);
        }

        public AxlNetClient.StandardResponse removeApplicationDialRules(AxlNetClient.NameAndGUIDRequest removeApplicationDialRules1)
        {
            AxlNetClient.removeApplicationDialRulesRequest inValue = new AxlNetClient.removeApplicationDialRulesRequest();
            inValue.removeApplicationDialRules = removeApplicationDialRules1;
            AxlNetClient.removeApplicationDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).removeApplicationDialRules(inValue);
            return retVal.removeApplicationDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeApplicationDialRulesResponse> AxlNetClient.AXLPort36.removeApplicationDialRulesAsync(AxlNetClient.removeApplicationDialRulesRequest request)
        {
            return base.Channel.removeApplicationDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeApplicationDialRulesResponse> removeApplicationDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeApplicationDialRules)
        {
            AxlNetClient.removeApplicationDialRulesRequest inValue = new AxlNetClient.removeApplicationDialRulesRequest();
            inValue.removeApplicationDialRules = removeApplicationDialRules;
            return ((AxlNetClient.AXLPort36)(this)).removeApplicationDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listApplicationDialRulesResponse AxlNetClient.AXLPort36.listApplicationDialRules(AxlNetClient.listApplicationDialRulesRequest request)
        {
            return base.Channel.listApplicationDialRules(request);
        }

        public AxlNetClient.ListApplicationDialRulesRes listApplicationDialRules(AxlNetClient.ListApplicationDialRulesReq listApplicationDialRules1)
        {
            AxlNetClient.listApplicationDialRulesRequest inValue = new AxlNetClient.listApplicationDialRulesRequest();
            inValue.listApplicationDialRules = listApplicationDialRules1;
            AxlNetClient.listApplicationDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).listApplicationDialRules(inValue);
            return retVal.listApplicationDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listApplicationDialRulesResponse> AxlNetClient.AXLPort36.listApplicationDialRulesAsync(AxlNetClient.listApplicationDialRulesRequest request)
        {
            return base.Channel.listApplicationDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listApplicationDialRulesResponse> listApplicationDialRulesAsync(AxlNetClient.ListApplicationDialRulesReq listApplicationDialRules)
        {
            AxlNetClient.listApplicationDialRulesRequest inValue = new AxlNetClient.listApplicationDialRulesRequest();
            inValue.listApplicationDialRules = listApplicationDialRules;
            return ((AxlNetClient.AXLPort36)(this)).listApplicationDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDirectoryLookupDialRulesResponse AxlNetClient.AXLPort36.addDirectoryLookupDialRules(AxlNetClient.addDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.addDirectoryLookupDialRules(request);
        }

        public AxlNetClient.StandardResponse addDirectoryLookupDialRules(AxlNetClient.AddDirectoryLookupDialRulesReq addDirectoryLookupDialRules1)
        {
            AxlNetClient.addDirectoryLookupDialRulesRequest inValue = new AxlNetClient.addDirectoryLookupDialRulesRequest();
            inValue.addDirectoryLookupDialRules = addDirectoryLookupDialRules1;
            AxlNetClient.addDirectoryLookupDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).addDirectoryLookupDialRules(inValue);
            return retVal.addDirectoryLookupDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDirectoryLookupDialRulesResponse> AxlNetClient.AXLPort36.addDirectoryLookupDialRulesAsync(AxlNetClient.addDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.addDirectoryLookupDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirectoryLookupDialRulesResponse> addDirectoryLookupDialRulesAsync(AxlNetClient.AddDirectoryLookupDialRulesReq addDirectoryLookupDialRules)
        {
            AxlNetClient.addDirectoryLookupDialRulesRequest inValue = new AxlNetClient.addDirectoryLookupDialRulesRequest();
            inValue.addDirectoryLookupDialRules = addDirectoryLookupDialRules;
            return ((AxlNetClient.AXLPort36)(this)).addDirectoryLookupDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDirectoryLookupDialRulesResponse AxlNetClient.AXLPort36.updateDirectoryLookupDialRules(AxlNetClient.updateDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.updateDirectoryLookupDialRules(request);
        }

        public AxlNetClient.StandardResponse updateDirectoryLookupDialRules(AxlNetClient.UpdateDirectoryLookupDialRulesReq updateDirectoryLookupDialRules1)
        {
            AxlNetClient.updateDirectoryLookupDialRulesRequest inValue = new AxlNetClient.updateDirectoryLookupDialRulesRequest();
            inValue.updateDirectoryLookupDialRules = updateDirectoryLookupDialRules1;
            AxlNetClient.updateDirectoryLookupDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).updateDirectoryLookupDialRules(inValue);
            return retVal.updateDirectoryLookupDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDirectoryLookupDialRulesResponse> AxlNetClient.AXLPort36.updateDirectoryLookupDialRulesAsync(AxlNetClient.updateDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.updateDirectoryLookupDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirectoryLookupDialRulesResponse> updateDirectoryLookupDialRulesAsync(AxlNetClient.UpdateDirectoryLookupDialRulesReq updateDirectoryLookupDialRules)
        {
            AxlNetClient.updateDirectoryLookupDialRulesRequest inValue = new AxlNetClient.updateDirectoryLookupDialRulesRequest();
            inValue.updateDirectoryLookupDialRules = updateDirectoryLookupDialRules;
            return ((AxlNetClient.AXLPort36)(this)).updateDirectoryLookupDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDirectoryLookupDialRulesResponse AxlNetClient.AXLPort36.getDirectoryLookupDialRules(AxlNetClient.getDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.getDirectoryLookupDialRules(request);
        }

        public AxlNetClient.GetDirectoryLookupDialRulesRes getDirectoryLookupDialRules(AxlNetClient.GetDirectoryLookupDialRulesReq getDirectoryLookupDialRules1)
        {
            AxlNetClient.getDirectoryLookupDialRulesRequest inValue = new AxlNetClient.getDirectoryLookupDialRulesRequest();
            inValue.getDirectoryLookupDialRules = getDirectoryLookupDialRules1;
            AxlNetClient.getDirectoryLookupDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).getDirectoryLookupDialRules(inValue);
            return retVal.getDirectoryLookupDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDirectoryLookupDialRulesResponse> AxlNetClient.AXLPort36.getDirectoryLookupDialRulesAsync(AxlNetClient.getDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.getDirectoryLookupDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirectoryLookupDialRulesResponse> getDirectoryLookupDialRulesAsync(AxlNetClient.GetDirectoryLookupDialRulesReq getDirectoryLookupDialRules)
        {
            AxlNetClient.getDirectoryLookupDialRulesRequest inValue = new AxlNetClient.getDirectoryLookupDialRulesRequest();
            inValue.getDirectoryLookupDialRules = getDirectoryLookupDialRules;
            return ((AxlNetClient.AXLPort36)(this)).getDirectoryLookupDialRulesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDirectoryLookupDialRulesResponse AxlNetClient.AXLPort36.removeDirectoryLookupDialRules(AxlNetClient.removeDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.removeDirectoryLookupDialRules(request);
        }

        public AxlNetClient.StandardResponse removeDirectoryLookupDialRules(AxlNetClient.NameAndGUIDRequest removeDirectoryLookupDialRules1)
        {
            AxlNetClient.removeDirectoryLookupDialRulesRequest inValue = new AxlNetClient.removeDirectoryLookupDialRulesRequest();
            inValue.removeDirectoryLookupDialRules = removeDirectoryLookupDialRules1;
            AxlNetClient.removeDirectoryLookupDialRulesResponse retVal = ((AxlNetClient.AXLPort36)(this)).removeDirectoryLookupDialRules(inValue);
            return retVal.removeDirectoryLookupDialRulesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDirectoryLookupDialRulesResponse> AxlNetClient.AXLPort36.removeDirectoryLookupDialRulesAsync(AxlNetClient.removeDirectoryLookupDialRulesRequest request)
        {
            return base.Channel.removeDirectoryLookupDialRulesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirectoryLookupDialRulesResponse> removeDirectoryLookupDialRulesAsync(AxlNetClient.NameAndGUIDRequest removeDirectoryLookupDialRules)
        {
            AxlNetClient.removeDirectoryLookupDialRulesRequest inValue = new AxlNetClient.removeDirectoryLookupDialRulesRequest();
            inValue.removeDirectoryLookupDialRules = removeDirectoryLookupDialRules;
            return ((AxlNetClient.AXLPort36)(this)).removeDirectoryLookupDialRulesAsync(inValue);
        }
    }
}