namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient5 _axlPortClient5;

        private static AXLPortClient5 axlPortClient5 => _axlPortClient5 == null ||
            _axlPortClient5.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient5 = LoadClient5()) : _axlPortClient5;

        private static AXLPortClient5 LoadClient5()
        {
            var client = new AXLPortClient5(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close5;
            OnAbort += Abort5;
            return client;
        }

        private static void Close5(object sender, System.EventArgs e)
        {
            _axlPortClient5.Close();
        }

        private static void Abort5(object sender, System.EventArgs e)
        {
            _axlPortClient5.Abort();
        }

        public AxlNetClient.StandardResponse removeRoutePartition(AxlNetClient.NameAndGUIDRequest removeRoutePartition1)
        {
            return axlPortClient5.removeRoutePartition(removeRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRoutePartitionResponse> removeRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest removeRoutePartition)
        {
            return axlPortClient5.removeRoutePartitionAsync(removeRoutePartition);
        }

        public AxlNetClient.ListRoutePartitionRes listRoutePartition(AxlNetClient.ListRoutePartitionReq listRoutePartition1)
        {
            return axlPortClient5.listRoutePartition(listRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePartitionResponse> listRoutePartitionAsync(AxlNetClient.ListRoutePartitionReq listRoutePartition)
        {
            return axlPortClient5.listRoutePartitionAsync(listRoutePartition);
        }

        public AxlNetClient.StandardResponse restartRoutePartition(AxlNetClient.NameAndGUIDRequest restartRoutePartition1)
        {
            return axlPortClient5.restartRoutePartition(restartRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartRoutePartitionResponse> restartRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest restartRoutePartition)
        {
            return axlPortClient5.restartRoutePartitionAsync(restartRoutePartition);
        }

        public AxlNetClient.StandardResponse applyRoutePartition(AxlNetClient.NameAndGUIDRequest applyRoutePartition1)
        {
            return axlPortClient5.applyRoutePartition(applyRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRoutePartitionResponse> applyRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest applyRoutePartition)
        {
            return axlPortClient5.applyRoutePartitionAsync(applyRoutePartition);
        }

        public AxlNetClient.StandardResponse addCss(AxlNetClient.AddCssReq addCss1)
        {
            return axlPortClient5.addCss(addCss1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCssResponse> addCssAsync(AxlNetClient.AddCssReq addCss)
        {
            return axlPortClient5.addCssAsync(addCss);
        }

        public AxlNetClient.StandardResponse updateCss(AxlNetClient.UpdateCssReq updateCss1)
        {
            return axlPortClient5.updateCss(updateCss1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCssResponse> updateCssAsync(AxlNetClient.UpdateCssReq updateCss)
        {
            return axlPortClient5.updateCssAsync(updateCss);
        }

        public AxlNetClient.GetCssRes getCss(AxlNetClient.GetCssReq getCss1)
        {
            return axlPortClient5.getCss(getCss1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCssResponse> getCssAsync(AxlNetClient.GetCssReq getCss)
        {
            return axlPortClient5.getCssAsync(getCss);
        }

        public AxlNetClient.StandardResponse removeCss(AxlNetClient.NameAndGUIDRequest removeCss1)
        {
            return axlPortClient5.removeCss(removeCss1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCssResponse> removeCssAsync(AxlNetClient.NameAndGUIDRequest removeCss)
        {
            return axlPortClient5.removeCssAsync(removeCss);
        }

        public AxlNetClient.ListCssRes listCss(AxlNetClient.ListCssReq listCss1)
        {
            return axlPortClient5.listCss(listCss1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCssResponse> listCssAsync(AxlNetClient.ListCssReq listCss)
        {
            return axlPortClient5.listCssAsync(listCss);
        }

        public AxlNetClient.StandardResponse updateCallManager(AxlNetClient.UpdateCallManagerReq updateCallManager1)
        {
            return axlPortClient5.updateCallManager(updateCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallManagerResponse> updateCallManagerAsync(AxlNetClient.UpdateCallManagerReq updateCallManager)
        {
            return axlPortClient5.updateCallManagerAsync(updateCallManager);
        }

        public AxlNetClient.GetCallManagerRes getCallManager(AxlNetClient.GetCallManagerReq getCallManager1)
        {
            return axlPortClient5.getCallManager(getCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallManagerResponse> getCallManagerAsync(AxlNetClient.GetCallManagerReq getCallManager)
        {
            return axlPortClient5.getCallManagerAsync(getCallManager);
        }

        public AxlNetClient.ListCallManagerRes listCallManager(AxlNetClient.ListCallManagerReq listCallManager1)
        {
            return axlPortClient5.listCallManager(listCallManager1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallManagerResponse> listCallManagerAsync(AxlNetClient.ListCallManagerReq listCallManager)
        {
            return axlPortClient5.listCallManagerAsync(listCallManager);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort5
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRoutePartitionResponse removeRoutePartition(AxlNetClient.removeRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRoutePartitionResponse> removeRoutePartitionAsync(AxlNetClient.removeRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRoutePartitionResponse listRoutePartition(AxlNetClient.listRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePartitionResponse> listRoutePartitionAsync(AxlNetClient.listRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartRoutePartitionResponse restartRoutePartition(AxlNetClient.restartRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartRoutePartitionResponse> restartRoutePartitionAsync(AxlNetClient.restartRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyRoutePartitionResponse applyRoutePartition(AxlNetClient.applyRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyRoutePartitionResponse> applyRoutePartitionAsync(AxlNetClient.applyRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCss", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCssResponse addCss(AxlNetClient.addCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCss", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCssResponse> addCssAsync(AxlNetClient.addCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCss", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCssResponse updateCss(AxlNetClient.updateCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCss", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCssResponse> updateCssAsync(AxlNetClient.updateCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCss", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCssResponse getCss(AxlNetClient.getCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCss", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCssResponse> getCssAsync(AxlNetClient.getCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCss", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCssResponse removeCss(AxlNetClient.removeCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCss", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCssResponse> removeCssAsync(AxlNetClient.removeCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCss", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCssResponse listCss(AxlNetClient.listCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCss", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCssResponse> listCssAsync(AxlNetClient.listCssRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallManagerResponse updateCallManager(AxlNetClient.updateCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallManagerResponse> updateCallManagerAsync(AxlNetClient.updateCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallManagerResponse getCallManager(AxlNetClient.getCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallManagerResponse> getCallManagerAsync(AxlNetClient.getCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallManager", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallManagerResponse listCallManager(AxlNetClient.listCallManagerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallManager", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallManagerResponse> listCallManagerAsync(AxlNetClient.listCallManagerRequest request);
    }

    public class AXLPortClient5 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort5>, AxlNetClient.AXLPort5
    {
        public AXLPortClient5(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRoutePartitionResponse AxlNetClient.AXLPort5.removeRoutePartition(AxlNetClient.removeRoutePartitionRequest request)
        {
            return base.Channel.removeRoutePartition(request);
        }

        public AxlNetClient.StandardResponse removeRoutePartition(AxlNetClient.NameAndGUIDRequest removeRoutePartition1)
        {
            AxlNetClient.removeRoutePartitionRequest inValue = new AxlNetClient.removeRoutePartitionRequest();
            inValue.removeRoutePartition = removeRoutePartition1;
            AxlNetClient.removeRoutePartitionResponse retVal = ((AxlNetClient.AXLPort5)(this)).removeRoutePartition(inValue);
            return retVal.removeRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRoutePartitionResponse> AxlNetClient.AXLPort5.removeRoutePartitionAsync(AxlNetClient.removeRoutePartitionRequest request)
        {
            return base.Channel.removeRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRoutePartitionResponse> removeRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest removeRoutePartition)
        {
            AxlNetClient.removeRoutePartitionRequest inValue = new AxlNetClient.removeRoutePartitionRequest();
            inValue.removeRoutePartition = removeRoutePartition;
            return ((AxlNetClient.AXLPort5)(this)).removeRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRoutePartitionResponse AxlNetClient.AXLPort5.listRoutePartition(AxlNetClient.listRoutePartitionRequest request)
        {
            return base.Channel.listRoutePartition(request);
        }

        public AxlNetClient.ListRoutePartitionRes listRoutePartition(AxlNetClient.ListRoutePartitionReq listRoutePartition1)
        {
            AxlNetClient.listRoutePartitionRequest inValue = new AxlNetClient.listRoutePartitionRequest();
            inValue.listRoutePartition = listRoutePartition1;
            AxlNetClient.listRoutePartitionResponse retVal = ((AxlNetClient.AXLPort5)(this)).listRoutePartition(inValue);
            return retVal.listRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePartitionResponse> AxlNetClient.AXLPort5.listRoutePartitionAsync(AxlNetClient.listRoutePartitionRequest request)
        {
            return base.Channel.listRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePartitionResponse> listRoutePartitionAsync(AxlNetClient.ListRoutePartitionReq listRoutePartition)
        {
            AxlNetClient.listRoutePartitionRequest inValue = new AxlNetClient.listRoutePartitionRequest();
            inValue.listRoutePartition = listRoutePartition;
            return ((AxlNetClient.AXLPort5)(this)).listRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartRoutePartitionResponse AxlNetClient.AXLPort5.restartRoutePartition(AxlNetClient.restartRoutePartitionRequest request)
        {
            return base.Channel.restartRoutePartition(request);
        }

        public AxlNetClient.StandardResponse restartRoutePartition(AxlNetClient.NameAndGUIDRequest restartRoutePartition1)
        {
            AxlNetClient.restartRoutePartitionRequest inValue = new AxlNetClient.restartRoutePartitionRequest();
            inValue.restartRoutePartition = restartRoutePartition1;
            AxlNetClient.restartRoutePartitionResponse retVal = ((AxlNetClient.AXLPort5)(this)).restartRoutePartition(inValue);
            return retVal.restartRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartRoutePartitionResponse> AxlNetClient.AXLPort5.restartRoutePartitionAsync(AxlNetClient.restartRoutePartitionRequest request)
        {
            return base.Channel.restartRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartRoutePartitionResponse> restartRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest restartRoutePartition)
        {
            AxlNetClient.restartRoutePartitionRequest inValue = new AxlNetClient.restartRoutePartitionRequest();
            inValue.restartRoutePartition = restartRoutePartition;
            return ((AxlNetClient.AXLPort5)(this)).restartRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyRoutePartitionResponse AxlNetClient.AXLPort5.applyRoutePartition(AxlNetClient.applyRoutePartitionRequest request)
        {
            return base.Channel.applyRoutePartition(request);
        }

        public AxlNetClient.StandardResponse applyRoutePartition(AxlNetClient.NameAndGUIDRequest applyRoutePartition1)
        {
            AxlNetClient.applyRoutePartitionRequest inValue = new AxlNetClient.applyRoutePartitionRequest();
            inValue.applyRoutePartition = applyRoutePartition1;
            AxlNetClient.applyRoutePartitionResponse retVal = ((AxlNetClient.AXLPort5)(this)).applyRoutePartition(inValue);
            return retVal.applyRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyRoutePartitionResponse> AxlNetClient.AXLPort5.applyRoutePartitionAsync(AxlNetClient.applyRoutePartitionRequest request)
        {
            return base.Channel.applyRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRoutePartitionResponse> applyRoutePartitionAsync(AxlNetClient.NameAndGUIDRequest applyRoutePartition)
        {
            AxlNetClient.applyRoutePartitionRequest inValue = new AxlNetClient.applyRoutePartitionRequest();
            inValue.applyRoutePartition = applyRoutePartition;
            return ((AxlNetClient.AXLPort5)(this)).applyRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCssResponse AxlNetClient.AXLPort5.addCss(AxlNetClient.addCssRequest request)
        {
            return base.Channel.addCss(request);
        }

        public AxlNetClient.StandardResponse addCss(AxlNetClient.AddCssReq addCss1)
        {
            AxlNetClient.addCssRequest inValue = new AxlNetClient.addCssRequest();
            inValue.addCss = addCss1;
            AxlNetClient.addCssResponse retVal = ((AxlNetClient.AXLPort5)(this)).addCss(inValue);
            return retVal.addCssResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCssResponse> AxlNetClient.AXLPort5.addCssAsync(AxlNetClient.addCssRequest request)
        {
            return base.Channel.addCssAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCssResponse> addCssAsync(AxlNetClient.AddCssReq addCss)
        {
            AxlNetClient.addCssRequest inValue = new AxlNetClient.addCssRequest();
            inValue.addCss = addCss;
            return ((AxlNetClient.AXLPort5)(this)).addCssAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCssResponse AxlNetClient.AXLPort5.updateCss(AxlNetClient.updateCssRequest request)
        {
            return base.Channel.updateCss(request);
        }

        public AxlNetClient.StandardResponse updateCss(AxlNetClient.UpdateCssReq updateCss1)
        {
            AxlNetClient.updateCssRequest inValue = new AxlNetClient.updateCssRequest();
            inValue.updateCss = updateCss1;
            AxlNetClient.updateCssResponse retVal = ((AxlNetClient.AXLPort5)(this)).updateCss(inValue);
            return retVal.updateCssResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCssResponse> AxlNetClient.AXLPort5.updateCssAsync(AxlNetClient.updateCssRequest request)
        {
            return base.Channel.updateCssAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCssResponse> updateCssAsync(AxlNetClient.UpdateCssReq updateCss)
        {
            AxlNetClient.updateCssRequest inValue = new AxlNetClient.updateCssRequest();
            inValue.updateCss = updateCss;
            return ((AxlNetClient.AXLPort5)(this)).updateCssAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCssResponse AxlNetClient.AXLPort5.getCss(AxlNetClient.getCssRequest request)
        {
            return base.Channel.getCss(request);
        }

        public AxlNetClient.GetCssRes getCss(AxlNetClient.GetCssReq getCss1)
        {
            AxlNetClient.getCssRequest inValue = new AxlNetClient.getCssRequest();
            inValue.getCss = getCss1;
            AxlNetClient.getCssResponse retVal = ((AxlNetClient.AXLPort5)(this)).getCss(inValue);
            return retVal.getCssResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCssResponse> AxlNetClient.AXLPort5.getCssAsync(AxlNetClient.getCssRequest request)
        {
            return base.Channel.getCssAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCssResponse> getCssAsync(AxlNetClient.GetCssReq getCss)
        {
            AxlNetClient.getCssRequest inValue = new AxlNetClient.getCssRequest();
            inValue.getCss = getCss;
            return ((AxlNetClient.AXLPort5)(this)).getCssAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCssResponse AxlNetClient.AXLPort5.removeCss(AxlNetClient.removeCssRequest request)
        {
            return base.Channel.removeCss(request);
        }

        public AxlNetClient.StandardResponse removeCss(AxlNetClient.NameAndGUIDRequest removeCss1)
        {
            AxlNetClient.removeCssRequest inValue = new AxlNetClient.removeCssRequest();
            inValue.removeCss = removeCss1;
            AxlNetClient.removeCssResponse retVal = ((AxlNetClient.AXLPort5)(this)).removeCss(inValue);
            return retVal.removeCssResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCssResponse> AxlNetClient.AXLPort5.removeCssAsync(AxlNetClient.removeCssRequest request)
        {
            return base.Channel.removeCssAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCssResponse> removeCssAsync(AxlNetClient.NameAndGUIDRequest removeCss)
        {
            AxlNetClient.removeCssRequest inValue = new AxlNetClient.removeCssRequest();
            inValue.removeCss = removeCss;
            return ((AxlNetClient.AXLPort5)(this)).removeCssAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCssResponse AxlNetClient.AXLPort5.listCss(AxlNetClient.listCssRequest request)
        {
            return base.Channel.listCss(request);
        }

        public AxlNetClient.ListCssRes listCss(AxlNetClient.ListCssReq listCss1)
        {
            AxlNetClient.listCssRequest inValue = new AxlNetClient.listCssRequest();
            inValue.listCss = listCss1;
            AxlNetClient.listCssResponse retVal = ((AxlNetClient.AXLPort5)(this)).listCss(inValue);
            return retVal.listCssResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCssResponse> AxlNetClient.AXLPort5.listCssAsync(AxlNetClient.listCssRequest request)
        {
            return base.Channel.listCssAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCssResponse> listCssAsync(AxlNetClient.ListCssReq listCss)
        {
            AxlNetClient.listCssRequest inValue = new AxlNetClient.listCssRequest();
            inValue.listCss = listCss;
            return ((AxlNetClient.AXLPort5)(this)).listCssAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallManagerResponse AxlNetClient.AXLPort5.updateCallManager(AxlNetClient.updateCallManagerRequest request)
        {
            return base.Channel.updateCallManager(request);
        }

        public AxlNetClient.StandardResponse updateCallManager(AxlNetClient.UpdateCallManagerReq updateCallManager1)
        {
            AxlNetClient.updateCallManagerRequest inValue = new AxlNetClient.updateCallManagerRequest();
            inValue.updateCallManager = updateCallManager1;
            AxlNetClient.updateCallManagerResponse retVal = ((AxlNetClient.AXLPort5)(this)).updateCallManager(inValue);
            return retVal.updateCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallManagerResponse> AxlNetClient.AXLPort5.updateCallManagerAsync(AxlNetClient.updateCallManagerRequest request)
        {
            return base.Channel.updateCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallManagerResponse> updateCallManagerAsync(AxlNetClient.UpdateCallManagerReq updateCallManager)
        {
            AxlNetClient.updateCallManagerRequest inValue = new AxlNetClient.updateCallManagerRequest();
            inValue.updateCallManager = updateCallManager;
            return ((AxlNetClient.AXLPort5)(this)).updateCallManagerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallManagerResponse AxlNetClient.AXLPort5.getCallManager(AxlNetClient.getCallManagerRequest request)
        {
            return base.Channel.getCallManager(request);
        }

        public AxlNetClient.GetCallManagerRes getCallManager(AxlNetClient.GetCallManagerReq getCallManager1)
        {
            AxlNetClient.getCallManagerRequest inValue = new AxlNetClient.getCallManagerRequest();
            inValue.getCallManager = getCallManager1;
            AxlNetClient.getCallManagerResponse retVal = ((AxlNetClient.AXLPort5)(this)).getCallManager(inValue);
            return retVal.getCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallManagerResponse> AxlNetClient.AXLPort5.getCallManagerAsync(AxlNetClient.getCallManagerRequest request)
        {
            return base.Channel.getCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallManagerResponse> getCallManagerAsync(AxlNetClient.GetCallManagerReq getCallManager)
        {
            AxlNetClient.getCallManagerRequest inValue = new AxlNetClient.getCallManagerRequest();
            inValue.getCallManager = getCallManager;
            return ((AxlNetClient.AXLPort5)(this)).getCallManagerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallManagerResponse AxlNetClient.AXLPort5.listCallManager(AxlNetClient.listCallManagerRequest request)
        {
            return base.Channel.listCallManager(request);
        }

        public AxlNetClient.ListCallManagerRes listCallManager(AxlNetClient.ListCallManagerReq listCallManager1)
        {
            AxlNetClient.listCallManagerRequest inValue = new AxlNetClient.listCallManagerRequest();
            inValue.listCallManager = listCallManager1;
            AxlNetClient.listCallManagerResponse retVal = ((AxlNetClient.AXLPort5)(this)).listCallManager(inValue);
            return retVal.listCallManagerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallManagerResponse> AxlNetClient.AXLPort5.listCallManagerAsync(AxlNetClient.listCallManagerRequest request)
        {
            return base.Channel.listCallManagerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallManagerResponse> listCallManagerAsync(AxlNetClient.ListCallManagerReq listCallManager)
        {
            AxlNetClient.listCallManagerRequest inValue = new AxlNetClient.listCallManagerRequest();
            inValue.listCallManager = listCallManager;
            return ((AxlNetClient.AXLPort5)(this)).listCallManagerAsync(inValue);
        }
    }
}