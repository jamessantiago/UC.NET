namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient4 _axlPortClient4;

        private static AXLPortClient4 axlPortClient4 => _axlPortClient4 == null ||
            _axlPortClient4.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient4 = LoadClient4()) : _axlPortClient4;

        private static AXLPortClient4 LoadClient4()
        {
            var client = new AXLPortClient4(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close4;
            OnAbort += Abort4;
            return client;
        }

        private static void Close4(object sender, System.EventArgs e)
        {
            _axlPortClient4.Close();
        }

        private static void Abort4(object sender, System.EventArgs e)
        {
            _axlPortClient4.Abort();
        }

        public AxlNetClient.StandardResponse updateProcessNode(AxlNetClient.UpdateProcessNodeReq updateProcessNode1)
        {
            return axlPortClient4.updateProcessNode(updateProcessNode1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeResponse> updateProcessNodeAsync(AxlNetClient.UpdateProcessNodeReq updateProcessNode)
        {
            return axlPortClient4.updateProcessNodeAsync(updateProcessNode);
        }

        public AxlNetClient.GetProcessNodeRes getProcessNode(AxlNetClient.GetProcessNodeReq getProcessNode1)
        {
            return axlPortClient4.getProcessNode(getProcessNode1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getProcessNodeResponse> getProcessNodeAsync(AxlNetClient.GetProcessNodeReq getProcessNode)
        {
            return axlPortClient4.getProcessNodeAsync(getProcessNode);
        }

        public AxlNetClient.StandardResponse removeProcessNode(AxlNetClient.NameAndGUIDRequest removeProcessNode1)
        {
            return axlPortClient4.removeProcessNode(removeProcessNode1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeProcessNodeResponse> removeProcessNodeAsync(AxlNetClient.NameAndGUIDRequest removeProcessNode)
        {
            return axlPortClient4.removeProcessNodeAsync(removeProcessNode);
        }

        public AxlNetClient.ListProcessNodeRes listProcessNode(AxlNetClient.ListProcessNodeReq listProcessNode1)
        {
            return axlPortClient4.listProcessNode(listProcessNode1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listProcessNodeResponse> listProcessNodeAsync(AxlNetClient.ListProcessNodeReq listProcessNode)
        {
            return axlPortClient4.listProcessNodeAsync(listProcessNode);
        }

        public AxlNetClient.StandardResponse addCallerFilterList(AxlNetClient.AddCallerFilterListReq addCallerFilterList1)
        {
            return axlPortClient4.addCallerFilterList(addCallerFilterList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallerFilterListResponse> addCallerFilterListAsync(AxlNetClient.AddCallerFilterListReq addCallerFilterList)
        {
            return axlPortClient4.addCallerFilterListAsync(addCallerFilterList);
        }

        public AxlNetClient.StandardResponse updateCallerFilterList(AxlNetClient.UpdateCallerFilterListReq updateCallerFilterList1)
        {
            return axlPortClient4.updateCallerFilterList(updateCallerFilterList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallerFilterListResponse> updateCallerFilterListAsync(AxlNetClient.UpdateCallerFilterListReq updateCallerFilterList)
        {
            return axlPortClient4.updateCallerFilterListAsync(updateCallerFilterList);
        }

        public AxlNetClient.GetCallerFilterListRes getCallerFilterList(AxlNetClient.GetCallerFilterListReq getCallerFilterList1)
        {
            return axlPortClient4.getCallerFilterList(getCallerFilterList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallerFilterListResponse> getCallerFilterListAsync(AxlNetClient.GetCallerFilterListReq getCallerFilterList)
        {
            return axlPortClient4.getCallerFilterListAsync(getCallerFilterList);
        }

        public AxlNetClient.StandardResponse removeCallerFilterList(AxlNetClient.NameAndGUIDRequest removeCallerFilterList1)
        {
            return axlPortClient4.removeCallerFilterList(removeCallerFilterList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallerFilterListResponse> removeCallerFilterListAsync(AxlNetClient.NameAndGUIDRequest removeCallerFilterList)
        {
            return axlPortClient4.removeCallerFilterListAsync(removeCallerFilterList);
        }

        public AxlNetClient.ListCallerFilterListRes listCallerFilterList(AxlNetClient.ListCallerFilterListReq listCallerFilterList1)
        {
            return axlPortClient4.listCallerFilterList(listCallerFilterList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallerFilterListResponse> listCallerFilterListAsync(AxlNetClient.ListCallerFilterListReq listCallerFilterList)
        {
            return axlPortClient4.listCallerFilterListAsync(listCallerFilterList);
        }

        public AxlNetClient.StandardResponse addRoutePartition(AxlNetClient.AddRoutePartitionReq addRoutePartition1)
        {
            return axlPortClient4.addRoutePartition(addRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRoutePartitionResponse> addRoutePartitionAsync(AxlNetClient.AddRoutePartitionReq addRoutePartition)
        {
            return axlPortClient4.addRoutePartitionAsync(addRoutePartition);
        }

        public AxlNetClient.StandardResponse updateRoutePartition(AxlNetClient.UpdateRoutePartitionReq updateRoutePartition1)
        {
            return axlPortClient4.updateRoutePartition(updateRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionResponse> updateRoutePartitionAsync(AxlNetClient.UpdateRoutePartitionReq updateRoutePartition)
        {
            return axlPortClient4.updateRoutePartitionAsync(updateRoutePartition);
        }

        public AxlNetClient.GetRoutePartitionRes getRoutePartition(AxlNetClient.GetRoutePartitionReq getRoutePartition1)
        {
            return axlPortClient4.getRoutePartition(getRoutePartition1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRoutePartitionResponse> getRoutePartitionAsync(AxlNetClient.GetRoutePartitionReq getRoutePartition)
        {
            return axlPortClient4.getRoutePartitionAsync(getRoutePartition);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort4
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateProcessNode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateProcessNodeResponse updateProcessNode(AxlNetClient.updateProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateProcessNode", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeResponse> updateProcessNodeAsync(AxlNetClient.updateProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getProcessNode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getProcessNodeResponse getProcessNode(AxlNetClient.getProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getProcessNode", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getProcessNodeResponse> getProcessNodeAsync(AxlNetClient.getProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeProcessNode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeProcessNodeResponse removeProcessNode(AxlNetClient.removeProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeProcessNode", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeProcessNodeResponse> removeProcessNodeAsync(AxlNetClient.removeProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listProcessNode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listProcessNodeResponse listProcessNode(AxlNetClient.listProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listProcessNode", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listProcessNodeResponse> listProcessNodeAsync(AxlNetClient.listProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallerFilterList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCallerFilterListResponse addCallerFilterList(AxlNetClient.addCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallerFilterList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCallerFilterListResponse> addCallerFilterListAsync(AxlNetClient.addCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallerFilterList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallerFilterListResponse updateCallerFilterList(AxlNetClient.updateCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallerFilterList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallerFilterListResponse> updateCallerFilterListAsync(AxlNetClient.updateCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallerFilterList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallerFilterListResponse getCallerFilterList(AxlNetClient.getCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallerFilterList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallerFilterListResponse> getCallerFilterListAsync(AxlNetClient.getCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallerFilterList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCallerFilterListResponse removeCallerFilterList(AxlNetClient.removeCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallerFilterList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCallerFilterListResponse> removeCallerFilterListAsync(AxlNetClient.removeCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallerFilterList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallerFilterListResponse listCallerFilterList(AxlNetClient.listCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallerFilterList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallerFilterListResponse> listCallerFilterListAsync(AxlNetClient.listCallerFilterListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRoutePartitionResponse addRoutePartition(AxlNetClient.addRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRoutePartitionResponse> addRoutePartitionAsync(AxlNetClient.addRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRoutePartitionResponse updateRoutePartition(AxlNetClient.updateRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionResponse> updateRoutePartitionAsync(AxlNetClient.updateRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRoutePartition", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRoutePartitionResponse getRoutePartition(AxlNetClient.getRoutePartitionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRoutePartition", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRoutePartitionResponse> getRoutePartitionAsync(AxlNetClient.getRoutePartitionRequest request);
    }

    public class AXLPortClient4 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort4>, AxlNetClient.AXLPort4
    {
        public AXLPortClient4(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateProcessNodeResponse AxlNetClient.AXLPort4.updateProcessNode(AxlNetClient.updateProcessNodeRequest request)
        {
            return base.Channel.updateProcessNode(request);
        }

        public AxlNetClient.StandardResponse updateProcessNode(AxlNetClient.UpdateProcessNodeReq updateProcessNode1)
        {
            AxlNetClient.updateProcessNodeRequest inValue = new AxlNetClient.updateProcessNodeRequest();
            inValue.updateProcessNode = updateProcessNode1;
            AxlNetClient.updateProcessNodeResponse retVal = ((AxlNetClient.AXLPort4)(this)).updateProcessNode(inValue);
            return retVal.updateProcessNodeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeResponse> AxlNetClient.AXLPort4.updateProcessNodeAsync(AxlNetClient.updateProcessNodeRequest request)
        {
            return base.Channel.updateProcessNodeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateProcessNodeResponse> updateProcessNodeAsync(AxlNetClient.UpdateProcessNodeReq updateProcessNode)
        {
            AxlNetClient.updateProcessNodeRequest inValue = new AxlNetClient.updateProcessNodeRequest();
            inValue.updateProcessNode = updateProcessNode;
            return ((AxlNetClient.AXLPort4)(this)).updateProcessNodeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getProcessNodeResponse AxlNetClient.AXLPort4.getProcessNode(AxlNetClient.getProcessNodeRequest request)
        {
            return base.Channel.getProcessNode(request);
        }

        public AxlNetClient.GetProcessNodeRes getProcessNode(AxlNetClient.GetProcessNodeReq getProcessNode1)
        {
            AxlNetClient.getProcessNodeRequest inValue = new AxlNetClient.getProcessNodeRequest();
            inValue.getProcessNode = getProcessNode1;
            AxlNetClient.getProcessNodeResponse retVal = ((AxlNetClient.AXLPort4)(this)).getProcessNode(inValue);
            return retVal.getProcessNodeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getProcessNodeResponse> AxlNetClient.AXLPort4.getProcessNodeAsync(AxlNetClient.getProcessNodeRequest request)
        {
            return base.Channel.getProcessNodeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getProcessNodeResponse> getProcessNodeAsync(AxlNetClient.GetProcessNodeReq getProcessNode)
        {
            AxlNetClient.getProcessNodeRequest inValue = new AxlNetClient.getProcessNodeRequest();
            inValue.getProcessNode = getProcessNode;
            return ((AxlNetClient.AXLPort4)(this)).getProcessNodeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeProcessNodeResponse AxlNetClient.AXLPort4.removeProcessNode(AxlNetClient.removeProcessNodeRequest request)
        {
            return base.Channel.removeProcessNode(request);
        }

        public AxlNetClient.StandardResponse removeProcessNode(AxlNetClient.NameAndGUIDRequest removeProcessNode1)
        {
            AxlNetClient.removeProcessNodeRequest inValue = new AxlNetClient.removeProcessNodeRequest();
            inValue.removeProcessNode = removeProcessNode1;
            AxlNetClient.removeProcessNodeResponse retVal = ((AxlNetClient.AXLPort4)(this)).removeProcessNode(inValue);
            return retVal.removeProcessNodeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeProcessNodeResponse> AxlNetClient.AXLPort4.removeProcessNodeAsync(AxlNetClient.removeProcessNodeRequest request)
        {
            return base.Channel.removeProcessNodeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeProcessNodeResponse> removeProcessNodeAsync(AxlNetClient.NameAndGUIDRequest removeProcessNode)
        {
            AxlNetClient.removeProcessNodeRequest inValue = new AxlNetClient.removeProcessNodeRequest();
            inValue.removeProcessNode = removeProcessNode;
            return ((AxlNetClient.AXLPort4)(this)).removeProcessNodeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listProcessNodeResponse AxlNetClient.AXLPort4.listProcessNode(AxlNetClient.listProcessNodeRequest request)
        {
            return base.Channel.listProcessNode(request);
        }

        public AxlNetClient.ListProcessNodeRes listProcessNode(AxlNetClient.ListProcessNodeReq listProcessNode1)
        {
            AxlNetClient.listProcessNodeRequest inValue = new AxlNetClient.listProcessNodeRequest();
            inValue.listProcessNode = listProcessNode1;
            AxlNetClient.listProcessNodeResponse retVal = ((AxlNetClient.AXLPort4)(this)).listProcessNode(inValue);
            return retVal.listProcessNodeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listProcessNodeResponse> AxlNetClient.AXLPort4.listProcessNodeAsync(AxlNetClient.listProcessNodeRequest request)
        {
            return base.Channel.listProcessNodeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listProcessNodeResponse> listProcessNodeAsync(AxlNetClient.ListProcessNodeReq listProcessNode)
        {
            AxlNetClient.listProcessNodeRequest inValue = new AxlNetClient.listProcessNodeRequest();
            inValue.listProcessNode = listProcessNode;
            return ((AxlNetClient.AXLPort4)(this)).listProcessNodeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCallerFilterListResponse AxlNetClient.AXLPort4.addCallerFilterList(AxlNetClient.addCallerFilterListRequest request)
        {
            return base.Channel.addCallerFilterList(request);
        }

        public AxlNetClient.StandardResponse addCallerFilterList(AxlNetClient.AddCallerFilterListReq addCallerFilterList1)
        {
            AxlNetClient.addCallerFilterListRequest inValue = new AxlNetClient.addCallerFilterListRequest();
            inValue.addCallerFilterList = addCallerFilterList1;
            AxlNetClient.addCallerFilterListResponse retVal = ((AxlNetClient.AXLPort4)(this)).addCallerFilterList(inValue);
            return retVal.addCallerFilterListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCallerFilterListResponse> AxlNetClient.AXLPort4.addCallerFilterListAsync(AxlNetClient.addCallerFilterListRequest request)
        {
            return base.Channel.addCallerFilterListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallerFilterListResponse> addCallerFilterListAsync(AxlNetClient.AddCallerFilterListReq addCallerFilterList)
        {
            AxlNetClient.addCallerFilterListRequest inValue = new AxlNetClient.addCallerFilterListRequest();
            inValue.addCallerFilterList = addCallerFilterList;
            return ((AxlNetClient.AXLPort4)(this)).addCallerFilterListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallerFilterListResponse AxlNetClient.AXLPort4.updateCallerFilterList(AxlNetClient.updateCallerFilterListRequest request)
        {
            return base.Channel.updateCallerFilterList(request);
        }

        public AxlNetClient.StandardResponse updateCallerFilterList(AxlNetClient.UpdateCallerFilterListReq updateCallerFilterList1)
        {
            AxlNetClient.updateCallerFilterListRequest inValue = new AxlNetClient.updateCallerFilterListRequest();
            inValue.updateCallerFilterList = updateCallerFilterList1;
            AxlNetClient.updateCallerFilterListResponse retVal = ((AxlNetClient.AXLPort4)(this)).updateCallerFilterList(inValue);
            return retVal.updateCallerFilterListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallerFilterListResponse> AxlNetClient.AXLPort4.updateCallerFilterListAsync(AxlNetClient.updateCallerFilterListRequest request)
        {
            return base.Channel.updateCallerFilterListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallerFilterListResponse> updateCallerFilterListAsync(AxlNetClient.UpdateCallerFilterListReq updateCallerFilterList)
        {
            AxlNetClient.updateCallerFilterListRequest inValue = new AxlNetClient.updateCallerFilterListRequest();
            inValue.updateCallerFilterList = updateCallerFilterList;
            return ((AxlNetClient.AXLPort4)(this)).updateCallerFilterListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallerFilterListResponse AxlNetClient.AXLPort4.getCallerFilterList(AxlNetClient.getCallerFilterListRequest request)
        {
            return base.Channel.getCallerFilterList(request);
        }

        public AxlNetClient.GetCallerFilterListRes getCallerFilterList(AxlNetClient.GetCallerFilterListReq getCallerFilterList1)
        {
            AxlNetClient.getCallerFilterListRequest inValue = new AxlNetClient.getCallerFilterListRequest();
            inValue.getCallerFilterList = getCallerFilterList1;
            AxlNetClient.getCallerFilterListResponse retVal = ((AxlNetClient.AXLPort4)(this)).getCallerFilterList(inValue);
            return retVal.getCallerFilterListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallerFilterListResponse> AxlNetClient.AXLPort4.getCallerFilterListAsync(AxlNetClient.getCallerFilterListRequest request)
        {
            return base.Channel.getCallerFilterListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallerFilterListResponse> getCallerFilterListAsync(AxlNetClient.GetCallerFilterListReq getCallerFilterList)
        {
            AxlNetClient.getCallerFilterListRequest inValue = new AxlNetClient.getCallerFilterListRequest();
            inValue.getCallerFilterList = getCallerFilterList;
            return ((AxlNetClient.AXLPort4)(this)).getCallerFilterListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCallerFilterListResponse AxlNetClient.AXLPort4.removeCallerFilterList(AxlNetClient.removeCallerFilterListRequest request)
        {
            return base.Channel.removeCallerFilterList(request);
        }

        public AxlNetClient.StandardResponse removeCallerFilterList(AxlNetClient.NameAndGUIDRequest removeCallerFilterList1)
        {
            AxlNetClient.removeCallerFilterListRequest inValue = new AxlNetClient.removeCallerFilterListRequest();
            inValue.removeCallerFilterList = removeCallerFilterList1;
            AxlNetClient.removeCallerFilterListResponse retVal = ((AxlNetClient.AXLPort4)(this)).removeCallerFilterList(inValue);
            return retVal.removeCallerFilterListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCallerFilterListResponse> AxlNetClient.AXLPort4.removeCallerFilterListAsync(AxlNetClient.removeCallerFilterListRequest request)
        {
            return base.Channel.removeCallerFilterListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallerFilterListResponse> removeCallerFilterListAsync(AxlNetClient.NameAndGUIDRequest removeCallerFilterList)
        {
            AxlNetClient.removeCallerFilterListRequest inValue = new AxlNetClient.removeCallerFilterListRequest();
            inValue.removeCallerFilterList = removeCallerFilterList;
            return ((AxlNetClient.AXLPort4)(this)).removeCallerFilterListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallerFilterListResponse AxlNetClient.AXLPort4.listCallerFilterList(AxlNetClient.listCallerFilterListRequest request)
        {
            return base.Channel.listCallerFilterList(request);
        }

        public AxlNetClient.ListCallerFilterListRes listCallerFilterList(AxlNetClient.ListCallerFilterListReq listCallerFilterList1)
        {
            AxlNetClient.listCallerFilterListRequest inValue = new AxlNetClient.listCallerFilterListRequest();
            inValue.listCallerFilterList = listCallerFilterList1;
            AxlNetClient.listCallerFilterListResponse retVal = ((AxlNetClient.AXLPort4)(this)).listCallerFilterList(inValue);
            return retVal.listCallerFilterListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallerFilterListResponse> AxlNetClient.AXLPort4.listCallerFilterListAsync(AxlNetClient.listCallerFilterListRequest request)
        {
            return base.Channel.listCallerFilterListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallerFilterListResponse> listCallerFilterListAsync(AxlNetClient.ListCallerFilterListReq listCallerFilterList)
        {
            AxlNetClient.listCallerFilterListRequest inValue = new AxlNetClient.listCallerFilterListRequest();
            inValue.listCallerFilterList = listCallerFilterList;
            return ((AxlNetClient.AXLPort4)(this)).listCallerFilterListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRoutePartitionResponse AxlNetClient.AXLPort4.addRoutePartition(AxlNetClient.addRoutePartitionRequest request)
        {
            return base.Channel.addRoutePartition(request);
        }

        public AxlNetClient.StandardResponse addRoutePartition(AxlNetClient.AddRoutePartitionReq addRoutePartition1)
        {
            AxlNetClient.addRoutePartitionRequest inValue = new AxlNetClient.addRoutePartitionRequest();
            inValue.addRoutePartition = addRoutePartition1;
            AxlNetClient.addRoutePartitionResponse retVal = ((AxlNetClient.AXLPort4)(this)).addRoutePartition(inValue);
            return retVal.addRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRoutePartitionResponse> AxlNetClient.AXLPort4.addRoutePartitionAsync(AxlNetClient.addRoutePartitionRequest request)
        {
            return base.Channel.addRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRoutePartitionResponse> addRoutePartitionAsync(AxlNetClient.AddRoutePartitionReq addRoutePartition)
        {
            AxlNetClient.addRoutePartitionRequest inValue = new AxlNetClient.addRoutePartitionRequest();
            inValue.addRoutePartition = addRoutePartition;
            return ((AxlNetClient.AXLPort4)(this)).addRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRoutePartitionResponse AxlNetClient.AXLPort4.updateRoutePartition(AxlNetClient.updateRoutePartitionRequest request)
        {
            return base.Channel.updateRoutePartition(request);
        }

        public AxlNetClient.StandardResponse updateRoutePartition(AxlNetClient.UpdateRoutePartitionReq updateRoutePartition1)
        {
            AxlNetClient.updateRoutePartitionRequest inValue = new AxlNetClient.updateRoutePartitionRequest();
            inValue.updateRoutePartition = updateRoutePartition1;
            AxlNetClient.updateRoutePartitionResponse retVal = ((AxlNetClient.AXLPort4)(this)).updateRoutePartition(inValue);
            return retVal.updateRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionResponse> AxlNetClient.AXLPort4.updateRoutePartitionAsync(AxlNetClient.updateRoutePartitionRequest request)
        {
            return base.Channel.updateRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePartitionResponse> updateRoutePartitionAsync(AxlNetClient.UpdateRoutePartitionReq updateRoutePartition)
        {
            AxlNetClient.updateRoutePartitionRequest inValue = new AxlNetClient.updateRoutePartitionRequest();
            inValue.updateRoutePartition = updateRoutePartition;
            return ((AxlNetClient.AXLPort4)(this)).updateRoutePartitionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRoutePartitionResponse AxlNetClient.AXLPort4.getRoutePartition(AxlNetClient.getRoutePartitionRequest request)
        {
            return base.Channel.getRoutePartition(request);
        }

        public AxlNetClient.GetRoutePartitionRes getRoutePartition(AxlNetClient.GetRoutePartitionReq getRoutePartition1)
        {
            AxlNetClient.getRoutePartitionRequest inValue = new AxlNetClient.getRoutePartitionRequest();
            inValue.getRoutePartition = getRoutePartition1;
            AxlNetClient.getRoutePartitionResponse retVal = ((AxlNetClient.AXLPort4)(this)).getRoutePartition(inValue);
            return retVal.getRoutePartitionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRoutePartitionResponse> AxlNetClient.AXLPort4.getRoutePartitionAsync(AxlNetClient.getRoutePartitionRequest request)
        {
            return base.Channel.getRoutePartitionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRoutePartitionResponse> getRoutePartitionAsync(AxlNetClient.GetRoutePartitionReq getRoutePartition)
        {
            AxlNetClient.getRoutePartitionRequest inValue = new AxlNetClient.getRoutePartitionRequest();
            inValue.getRoutePartition = getRoutePartition;
            return ((AxlNetClient.AXLPort4)(this)).getRoutePartitionAsync(inValue);
        }
    }
}