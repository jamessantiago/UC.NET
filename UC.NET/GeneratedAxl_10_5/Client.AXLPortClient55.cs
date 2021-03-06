namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient55 _axlPortClient55;

        private static AXLPortClient55 axlPortClient55 => _axlPortClient55 == null ||
            _axlPortClient55.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient55 = LoadClient55()) : _axlPortClient55;

        private static AXLPortClient55 LoadClient55()
        {
            var client = new AXLPortClient55(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close55;
            OnAbort += Abort55;
            return client;
        }

        private static void Close55(object sender, System.EventArgs e)
        {
            _axlPortClient55.Close();
        }

        private static void Abort55(object sender, System.EventArgs e)
        {
            _axlPortClient55.Abort();
        }

        public AxlNetClient.StandardResponse addRemoteCluster(AxlNetClient.AddRemoteClusterReq addRemoteCluster1)
        {
            return axlPortClient55.addRemoteCluster(addRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteClusterResponse> addRemoteClusterAsync(AxlNetClient.AddRemoteClusterReq addRemoteCluster)
        {
            return axlPortClient55.addRemoteClusterAsync(addRemoteCluster);
        }

        public AxlNetClient.StandardResponse updateRemoteCluster(AxlNetClient.UpdateRemoteClusterReq updateRemoteCluster1)
        {
            return axlPortClient55.updateRemoteCluster(updateRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteClusterResponse> updateRemoteClusterAsync(AxlNetClient.UpdateRemoteClusterReq updateRemoteCluster)
        {
            return axlPortClient55.updateRemoteClusterAsync(updateRemoteCluster);
        }

        public AxlNetClient.GetRemoteClusterRes getRemoteCluster(AxlNetClient.GetRemoteClusterReq getRemoteCluster1)
        {
            return axlPortClient55.getRemoteCluster(getRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteClusterResponse> getRemoteClusterAsync(AxlNetClient.GetRemoteClusterReq getRemoteCluster)
        {
            return axlPortClient55.getRemoteClusterAsync(getRemoteCluster);
        }

        public AxlNetClient.StandardResponse removeRemoteCluster(AxlNetClient.RemoveRemoteClusterReq removeRemoteCluster1)
        {
            return axlPortClient55.removeRemoteCluster(removeRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteClusterResponse> removeRemoteClusterAsync(AxlNetClient.RemoveRemoteClusterReq removeRemoteCluster)
        {
            return axlPortClient55.removeRemoteClusterAsync(removeRemoteCluster);
        }

        public AxlNetClient.ListRemoteClusterRes listRemoteCluster(AxlNetClient.ListRemoteClusterReq listRemoteCluster1)
        {
            return axlPortClient55.listRemoteCluster(listRemoteCluster1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteClusterResponse> listRemoteClusterAsync(AxlNetClient.ListRemoteClusterReq listRemoteCluster)
        {
            return axlPortClient55.listRemoteClusterAsync(listRemoteCluster);
        }

        public AxlNetClient.StandardResponse addCcdAdvertisingService(AxlNetClient.AddCcdAdvertisingServiceReq addCcdAdvertisingService1)
        {
            return axlPortClient55.addCcdAdvertisingService(addCcdAdvertisingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdAdvertisingServiceResponse> addCcdAdvertisingServiceAsync(AxlNetClient.AddCcdAdvertisingServiceReq addCcdAdvertisingService)
        {
            return axlPortClient55.addCcdAdvertisingServiceAsync(addCcdAdvertisingService);
        }

        public AxlNetClient.StandardResponse updateCcdAdvertisingService(AxlNetClient.UpdateCcdAdvertisingServiceReq updateCcdAdvertisingService1)
        {
            return axlPortClient55.updateCcdAdvertisingService(updateCcdAdvertisingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdAdvertisingServiceResponse> updateCcdAdvertisingServiceAsync(AxlNetClient.UpdateCcdAdvertisingServiceReq updateCcdAdvertisingService)
        {
            return axlPortClient55.updateCcdAdvertisingServiceAsync(updateCcdAdvertisingService);
        }

        public AxlNetClient.GetCcdAdvertisingServiceRes getCcdAdvertisingService(AxlNetClient.GetCcdAdvertisingServiceReq getCcdAdvertisingService1)
        {
            return axlPortClient55.getCcdAdvertisingService(getCcdAdvertisingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdAdvertisingServiceResponse> getCcdAdvertisingServiceAsync(AxlNetClient.GetCcdAdvertisingServiceReq getCcdAdvertisingService)
        {
            return axlPortClient55.getCcdAdvertisingServiceAsync(getCcdAdvertisingService);
        }

        public AxlNetClient.StandardResponse removeCcdAdvertisingService(AxlNetClient.NameAndGUIDRequest removeCcdAdvertisingService1)
        {
            return axlPortClient55.removeCcdAdvertisingService(removeCcdAdvertisingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdAdvertisingServiceResponse> removeCcdAdvertisingServiceAsync(AxlNetClient.NameAndGUIDRequest removeCcdAdvertisingService)
        {
            return axlPortClient55.removeCcdAdvertisingServiceAsync(removeCcdAdvertisingService);
        }

        public AxlNetClient.ListCcdAdvertisingServiceRes listCcdAdvertisingService(AxlNetClient.ListCcdAdvertisingServiceReq listCcdAdvertisingService1)
        {
            return axlPortClient55.listCcdAdvertisingService(listCcdAdvertisingService1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdAdvertisingServiceResponse> listCcdAdvertisingServiceAsync(AxlNetClient.ListCcdAdvertisingServiceReq listCcdAdvertisingService)
        {
            return axlPortClient55.listCcdAdvertisingServiceAsync(listCcdAdvertisingService);
        }

        public AxlNetClient.StandardResponse addUnitsToGateway(AxlNetClient.AddUnitsToGatewayReq addUnitsToGateway1)
        {
            return axlPortClient55.addUnitsToGateway(addUnitsToGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUnitsToGatewayResponse> addUnitsToGatewayAsync(AxlNetClient.AddUnitsToGatewayReq addUnitsToGateway)
        {
            return axlPortClient55.addUnitsToGatewayAsync(addUnitsToGateway);
        }

        public AxlNetClient.StandardResponse addGatewaySubunits(AxlNetClient.AddGatewaySubunitsReq addGatewaySubunits1)
        {
            return axlPortClient55.addGatewaySubunits(addGatewaySubunits1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewaySubunitsResponse> addGatewaySubunitsAsync(AxlNetClient.AddGatewaySubunitsReq addGatewaySubunits)
        {
            return axlPortClient55.addGatewaySubunitsAsync(addGatewaySubunits);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort55
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRemoteClusterResponse addRemoteCluster(AxlNetClient.addRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteClusterResponse> addRemoteClusterAsync(AxlNetClient.addRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRemoteClusterResponse updateRemoteCluster(AxlNetClient.updateRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteClusterResponse> updateRemoteClusterAsync(AxlNetClient.updateRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRemoteClusterResponse getRemoteCluster(AxlNetClient.getRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteClusterResponse> getRemoteClusterAsync(AxlNetClient.getRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRemoteClusterResponse removeRemoteCluster(AxlNetClient.removeRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteClusterResponse> removeRemoteClusterAsync(AxlNetClient.removeRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteCluster", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRemoteClusterResponse listRemoteCluster(AxlNetClient.listRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteCluster", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteClusterResponse> listRemoteClusterAsync(AxlNetClient.listRemoteClusterRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdAdvertisingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCcdAdvertisingServiceResponse addCcdAdvertisingService(AxlNetClient.addCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdAdvertisingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCcdAdvertisingServiceResponse> addCcdAdvertisingServiceAsync(AxlNetClient.addCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdAdvertisingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCcdAdvertisingServiceResponse updateCcdAdvertisingService(AxlNetClient.updateCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdAdvertisingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdAdvertisingServiceResponse> updateCcdAdvertisingServiceAsync(AxlNetClient.updateCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdAdvertisingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCcdAdvertisingServiceResponse getCcdAdvertisingService(AxlNetClient.getCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdAdvertisingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCcdAdvertisingServiceResponse> getCcdAdvertisingServiceAsync(AxlNetClient.getCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdAdvertisingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCcdAdvertisingServiceResponse removeCcdAdvertisingService(AxlNetClient.removeCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdAdvertisingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdAdvertisingServiceResponse> removeCcdAdvertisingServiceAsync(AxlNetClient.removeCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdAdvertisingService", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCcdAdvertisingServiceResponse listCcdAdvertisingService(AxlNetClient.listCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCcdAdvertisingService", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCcdAdvertisingServiceResponse> listCcdAdvertisingServiceAsync(AxlNetClient.listCcdAdvertisingServiceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUnitsToGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUnitsToGatewayResponse addUnitsToGateway(AxlNetClient.addUnitsToGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUnitsToGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUnitsToGatewayResponse> addUnitsToGatewayAsync(AxlNetClient.addUnitsToGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewaySubunits", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewaySubunitsResponse addGatewaySubunits(AxlNetClient.addGatewaySubunitsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewaySubunits", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewaySubunitsResponse> addGatewaySubunitsAsync(AxlNetClient.addGatewaySubunitsRequest request);
    }

    public class AXLPortClient55 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort55>, AxlNetClient.AXLPort55
    {
        public AXLPortClient55(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRemoteClusterResponse AxlNetClient.AXLPort55.addRemoteCluster(AxlNetClient.addRemoteClusterRequest request)
        {
            return base.Channel.addRemoteCluster(request);
        }

        public AxlNetClient.StandardResponse addRemoteCluster(AxlNetClient.AddRemoteClusterReq addRemoteCluster1)
        {
            AxlNetClient.addRemoteClusterRequest inValue = new AxlNetClient.addRemoteClusterRequest();
            inValue.addRemoteCluster = addRemoteCluster1;
            AxlNetClient.addRemoteClusterResponse retVal = ((AxlNetClient.AXLPort55)(this)).addRemoteCluster(inValue);
            return retVal.addRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteClusterResponse> AxlNetClient.AXLPort55.addRemoteClusterAsync(AxlNetClient.addRemoteClusterRequest request)
        {
            return base.Channel.addRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteClusterResponse> addRemoteClusterAsync(AxlNetClient.AddRemoteClusterReq addRemoteCluster)
        {
            AxlNetClient.addRemoteClusterRequest inValue = new AxlNetClient.addRemoteClusterRequest();
            inValue.addRemoteCluster = addRemoteCluster;
            return ((AxlNetClient.AXLPort55)(this)).addRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRemoteClusterResponse AxlNetClient.AXLPort55.updateRemoteCluster(AxlNetClient.updateRemoteClusterRequest request)
        {
            return base.Channel.updateRemoteCluster(request);
        }

        public AxlNetClient.StandardResponse updateRemoteCluster(AxlNetClient.UpdateRemoteClusterReq updateRemoteCluster1)
        {
            AxlNetClient.updateRemoteClusterRequest inValue = new AxlNetClient.updateRemoteClusterRequest();
            inValue.updateRemoteCluster = updateRemoteCluster1;
            AxlNetClient.updateRemoteClusterResponse retVal = ((AxlNetClient.AXLPort55)(this)).updateRemoteCluster(inValue);
            return retVal.updateRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteClusterResponse> AxlNetClient.AXLPort55.updateRemoteClusterAsync(AxlNetClient.updateRemoteClusterRequest request)
        {
            return base.Channel.updateRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteClusterResponse> updateRemoteClusterAsync(AxlNetClient.UpdateRemoteClusterReq updateRemoteCluster)
        {
            AxlNetClient.updateRemoteClusterRequest inValue = new AxlNetClient.updateRemoteClusterRequest();
            inValue.updateRemoteCluster = updateRemoteCluster;
            return ((AxlNetClient.AXLPort55)(this)).updateRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRemoteClusterResponse AxlNetClient.AXLPort55.getRemoteCluster(AxlNetClient.getRemoteClusterRequest request)
        {
            return base.Channel.getRemoteCluster(request);
        }

        public AxlNetClient.GetRemoteClusterRes getRemoteCluster(AxlNetClient.GetRemoteClusterReq getRemoteCluster1)
        {
            AxlNetClient.getRemoteClusterRequest inValue = new AxlNetClient.getRemoteClusterRequest();
            inValue.getRemoteCluster = getRemoteCluster1;
            AxlNetClient.getRemoteClusterResponse retVal = ((AxlNetClient.AXLPort55)(this)).getRemoteCluster(inValue);
            return retVal.getRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteClusterResponse> AxlNetClient.AXLPort55.getRemoteClusterAsync(AxlNetClient.getRemoteClusterRequest request)
        {
            return base.Channel.getRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteClusterResponse> getRemoteClusterAsync(AxlNetClient.GetRemoteClusterReq getRemoteCluster)
        {
            AxlNetClient.getRemoteClusterRequest inValue = new AxlNetClient.getRemoteClusterRequest();
            inValue.getRemoteCluster = getRemoteCluster;
            return ((AxlNetClient.AXLPort55)(this)).getRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRemoteClusterResponse AxlNetClient.AXLPort55.removeRemoteCluster(AxlNetClient.removeRemoteClusterRequest request)
        {
            return base.Channel.removeRemoteCluster(request);
        }

        public AxlNetClient.StandardResponse removeRemoteCluster(AxlNetClient.RemoveRemoteClusterReq removeRemoteCluster1)
        {
            AxlNetClient.removeRemoteClusterRequest inValue = new AxlNetClient.removeRemoteClusterRequest();
            inValue.removeRemoteCluster = removeRemoteCluster1;
            AxlNetClient.removeRemoteClusterResponse retVal = ((AxlNetClient.AXLPort55)(this)).removeRemoteCluster(inValue);
            return retVal.removeRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteClusterResponse> AxlNetClient.AXLPort55.removeRemoteClusterAsync(AxlNetClient.removeRemoteClusterRequest request)
        {
            return base.Channel.removeRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteClusterResponse> removeRemoteClusterAsync(AxlNetClient.RemoveRemoteClusterReq removeRemoteCluster)
        {
            AxlNetClient.removeRemoteClusterRequest inValue = new AxlNetClient.removeRemoteClusterRequest();
            inValue.removeRemoteCluster = removeRemoteCluster;
            return ((AxlNetClient.AXLPort55)(this)).removeRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRemoteClusterResponse AxlNetClient.AXLPort55.listRemoteCluster(AxlNetClient.listRemoteClusterRequest request)
        {
            return base.Channel.listRemoteCluster(request);
        }

        public AxlNetClient.ListRemoteClusterRes listRemoteCluster(AxlNetClient.ListRemoteClusterReq listRemoteCluster1)
        {
            AxlNetClient.listRemoteClusterRequest inValue = new AxlNetClient.listRemoteClusterRequest();
            inValue.listRemoteCluster = listRemoteCluster1;
            AxlNetClient.listRemoteClusterResponse retVal = ((AxlNetClient.AXLPort55)(this)).listRemoteCluster(inValue);
            return retVal.listRemoteClusterResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteClusterResponse> AxlNetClient.AXLPort55.listRemoteClusterAsync(AxlNetClient.listRemoteClusterRequest request)
        {
            return base.Channel.listRemoteClusterAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteClusterResponse> listRemoteClusterAsync(AxlNetClient.ListRemoteClusterReq listRemoteCluster)
        {
            AxlNetClient.listRemoteClusterRequest inValue = new AxlNetClient.listRemoteClusterRequest();
            inValue.listRemoteCluster = listRemoteCluster;
            return ((AxlNetClient.AXLPort55)(this)).listRemoteClusterAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCcdAdvertisingServiceResponse AxlNetClient.AXLPort55.addCcdAdvertisingService(AxlNetClient.addCcdAdvertisingServiceRequest request)
        {
            return base.Channel.addCcdAdvertisingService(request);
        }

        public AxlNetClient.StandardResponse addCcdAdvertisingService(AxlNetClient.AddCcdAdvertisingServiceReq addCcdAdvertisingService1)
        {
            AxlNetClient.addCcdAdvertisingServiceRequest inValue = new AxlNetClient.addCcdAdvertisingServiceRequest();
            inValue.addCcdAdvertisingService = addCcdAdvertisingService1;
            AxlNetClient.addCcdAdvertisingServiceResponse retVal = ((AxlNetClient.AXLPort55)(this)).addCcdAdvertisingService(inValue);
            return retVal.addCcdAdvertisingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCcdAdvertisingServiceResponse> AxlNetClient.AXLPort55.addCcdAdvertisingServiceAsync(AxlNetClient.addCcdAdvertisingServiceRequest request)
        {
            return base.Channel.addCcdAdvertisingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdAdvertisingServiceResponse> addCcdAdvertisingServiceAsync(AxlNetClient.AddCcdAdvertisingServiceReq addCcdAdvertisingService)
        {
            AxlNetClient.addCcdAdvertisingServiceRequest inValue = new AxlNetClient.addCcdAdvertisingServiceRequest();
            inValue.addCcdAdvertisingService = addCcdAdvertisingService;
            return ((AxlNetClient.AXLPort55)(this)).addCcdAdvertisingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCcdAdvertisingServiceResponse AxlNetClient.AXLPort55.updateCcdAdvertisingService(AxlNetClient.updateCcdAdvertisingServiceRequest request)
        {
            return base.Channel.updateCcdAdvertisingService(request);
        }

        public AxlNetClient.StandardResponse updateCcdAdvertisingService(AxlNetClient.UpdateCcdAdvertisingServiceReq updateCcdAdvertisingService1)
        {
            AxlNetClient.updateCcdAdvertisingServiceRequest inValue = new AxlNetClient.updateCcdAdvertisingServiceRequest();
            inValue.updateCcdAdvertisingService = updateCcdAdvertisingService1;
            AxlNetClient.updateCcdAdvertisingServiceResponse retVal = ((AxlNetClient.AXLPort55)(this)).updateCcdAdvertisingService(inValue);
            return retVal.updateCcdAdvertisingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdAdvertisingServiceResponse> AxlNetClient.AXLPort55.updateCcdAdvertisingServiceAsync(AxlNetClient.updateCcdAdvertisingServiceRequest request)
        {
            return base.Channel.updateCcdAdvertisingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdAdvertisingServiceResponse> updateCcdAdvertisingServiceAsync(AxlNetClient.UpdateCcdAdvertisingServiceReq updateCcdAdvertisingService)
        {
            AxlNetClient.updateCcdAdvertisingServiceRequest inValue = new AxlNetClient.updateCcdAdvertisingServiceRequest();
            inValue.updateCcdAdvertisingService = updateCcdAdvertisingService;
            return ((AxlNetClient.AXLPort55)(this)).updateCcdAdvertisingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCcdAdvertisingServiceResponse AxlNetClient.AXLPort55.getCcdAdvertisingService(AxlNetClient.getCcdAdvertisingServiceRequest request)
        {
            return base.Channel.getCcdAdvertisingService(request);
        }

        public AxlNetClient.GetCcdAdvertisingServiceRes getCcdAdvertisingService(AxlNetClient.GetCcdAdvertisingServiceReq getCcdAdvertisingService1)
        {
            AxlNetClient.getCcdAdvertisingServiceRequest inValue = new AxlNetClient.getCcdAdvertisingServiceRequest();
            inValue.getCcdAdvertisingService = getCcdAdvertisingService1;
            AxlNetClient.getCcdAdvertisingServiceResponse retVal = ((AxlNetClient.AXLPort55)(this)).getCcdAdvertisingService(inValue);
            return retVal.getCcdAdvertisingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCcdAdvertisingServiceResponse> AxlNetClient.AXLPort55.getCcdAdvertisingServiceAsync(AxlNetClient.getCcdAdvertisingServiceRequest request)
        {
            return base.Channel.getCcdAdvertisingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdAdvertisingServiceResponse> getCcdAdvertisingServiceAsync(AxlNetClient.GetCcdAdvertisingServiceReq getCcdAdvertisingService)
        {
            AxlNetClient.getCcdAdvertisingServiceRequest inValue = new AxlNetClient.getCcdAdvertisingServiceRequest();
            inValue.getCcdAdvertisingService = getCcdAdvertisingService;
            return ((AxlNetClient.AXLPort55)(this)).getCcdAdvertisingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCcdAdvertisingServiceResponse AxlNetClient.AXLPort55.removeCcdAdvertisingService(AxlNetClient.removeCcdAdvertisingServiceRequest request)
        {
            return base.Channel.removeCcdAdvertisingService(request);
        }

        public AxlNetClient.StandardResponse removeCcdAdvertisingService(AxlNetClient.NameAndGUIDRequest removeCcdAdvertisingService1)
        {
            AxlNetClient.removeCcdAdvertisingServiceRequest inValue = new AxlNetClient.removeCcdAdvertisingServiceRequest();
            inValue.removeCcdAdvertisingService = removeCcdAdvertisingService1;
            AxlNetClient.removeCcdAdvertisingServiceResponse retVal = ((AxlNetClient.AXLPort55)(this)).removeCcdAdvertisingService(inValue);
            return retVal.removeCcdAdvertisingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdAdvertisingServiceResponse> AxlNetClient.AXLPort55.removeCcdAdvertisingServiceAsync(AxlNetClient.removeCcdAdvertisingServiceRequest request)
        {
            return base.Channel.removeCcdAdvertisingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdAdvertisingServiceResponse> removeCcdAdvertisingServiceAsync(AxlNetClient.NameAndGUIDRequest removeCcdAdvertisingService)
        {
            AxlNetClient.removeCcdAdvertisingServiceRequest inValue = new AxlNetClient.removeCcdAdvertisingServiceRequest();
            inValue.removeCcdAdvertisingService = removeCcdAdvertisingService;
            return ((AxlNetClient.AXLPort55)(this)).removeCcdAdvertisingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCcdAdvertisingServiceResponse AxlNetClient.AXLPort55.listCcdAdvertisingService(AxlNetClient.listCcdAdvertisingServiceRequest request)
        {
            return base.Channel.listCcdAdvertisingService(request);
        }

        public AxlNetClient.ListCcdAdvertisingServiceRes listCcdAdvertisingService(AxlNetClient.ListCcdAdvertisingServiceReq listCcdAdvertisingService1)
        {
            AxlNetClient.listCcdAdvertisingServiceRequest inValue = new AxlNetClient.listCcdAdvertisingServiceRequest();
            inValue.listCcdAdvertisingService = listCcdAdvertisingService1;
            AxlNetClient.listCcdAdvertisingServiceResponse retVal = ((AxlNetClient.AXLPort55)(this)).listCcdAdvertisingService(inValue);
            return retVal.listCcdAdvertisingServiceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCcdAdvertisingServiceResponse> AxlNetClient.AXLPort55.listCcdAdvertisingServiceAsync(AxlNetClient.listCcdAdvertisingServiceRequest request)
        {
            return base.Channel.listCcdAdvertisingServiceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCcdAdvertisingServiceResponse> listCcdAdvertisingServiceAsync(AxlNetClient.ListCcdAdvertisingServiceReq listCcdAdvertisingService)
        {
            AxlNetClient.listCcdAdvertisingServiceRequest inValue = new AxlNetClient.listCcdAdvertisingServiceRequest();
            inValue.listCcdAdvertisingService = listCcdAdvertisingService;
            return ((AxlNetClient.AXLPort55)(this)).listCcdAdvertisingServiceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUnitsToGatewayResponse AxlNetClient.AXLPort55.addUnitsToGateway(AxlNetClient.addUnitsToGatewayRequest request)
        {
            return base.Channel.addUnitsToGateway(request);
        }

        public AxlNetClient.StandardResponse addUnitsToGateway(AxlNetClient.AddUnitsToGatewayReq addUnitsToGateway1)
        {
            AxlNetClient.addUnitsToGatewayRequest inValue = new AxlNetClient.addUnitsToGatewayRequest();
            inValue.addUnitsToGateway = addUnitsToGateway1;
            AxlNetClient.addUnitsToGatewayResponse retVal = ((AxlNetClient.AXLPort55)(this)).addUnitsToGateway(inValue);
            return retVal.addUnitsToGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUnitsToGatewayResponse> AxlNetClient.AXLPort55.addUnitsToGatewayAsync(AxlNetClient.addUnitsToGatewayRequest request)
        {
            return base.Channel.addUnitsToGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUnitsToGatewayResponse> addUnitsToGatewayAsync(AxlNetClient.AddUnitsToGatewayReq addUnitsToGateway)
        {
            AxlNetClient.addUnitsToGatewayRequest inValue = new AxlNetClient.addUnitsToGatewayRequest();
            inValue.addUnitsToGateway = addUnitsToGateway;
            return ((AxlNetClient.AXLPort55)(this)).addUnitsToGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewaySubunitsResponse AxlNetClient.AXLPort55.addGatewaySubunits(AxlNetClient.addGatewaySubunitsRequest request)
        {
            return base.Channel.addGatewaySubunits(request);
        }

        public AxlNetClient.StandardResponse addGatewaySubunits(AxlNetClient.AddGatewaySubunitsReq addGatewaySubunits1)
        {
            AxlNetClient.addGatewaySubunitsRequest inValue = new AxlNetClient.addGatewaySubunitsRequest();
            inValue.addGatewaySubunits = addGatewaySubunits1;
            AxlNetClient.addGatewaySubunitsResponse retVal = ((AxlNetClient.AXLPort55)(this)).addGatewaySubunits(inValue);
            return retVal.addGatewaySubunitsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewaySubunitsResponse> AxlNetClient.AXLPort55.addGatewaySubunitsAsync(AxlNetClient.addGatewaySubunitsRequest request)
        {
            return base.Channel.addGatewaySubunitsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewaySubunitsResponse> addGatewaySubunitsAsync(AxlNetClient.AddGatewaySubunitsReq addGatewaySubunits)
        {
            AxlNetClient.addGatewaySubunitsRequest inValue = new AxlNetClient.addGatewaySubunitsRequest();
            inValue.addGatewaySubunits = addGatewaySubunits;
            return ((AxlNetClient.AXLPort55)(this)).addGatewaySubunitsAsync(inValue);
        }
    }
}