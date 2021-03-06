namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient20 _axlPortClient20;

        private static AXLPortClient20 axlPortClient20 => _axlPortClient20 == null ||
            _axlPortClient20.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient20 = LoadClient20()) : _axlPortClient20;

        private static AXLPortClient20 LoadClient20()
        {
            var client = new AXLPortClient20(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close20;
            OnAbort += Abort20;
            return client;
        }

        private static void Close20(object sender, System.EventArgs e)
        {
            _axlPortClient20.Close();
        }

        private static void Abort20(object sender, System.EventArgs e)
        {
            _axlPortClient20.Abort();
        }

        public AxlNetClient.ListDhcpServerRes listDhcpServer(AxlNetClient.ListDhcpServerReq listDhcpServer1)
        {
            return axlPortClient20.listDhcpServer(listDhcpServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDhcpServerResponse> listDhcpServerAsync(AxlNetClient.ListDhcpServerReq listDhcpServer)
        {
            return axlPortClient20.listDhcpServerAsync(listDhcpServer);
        }

        public AxlNetClient.StandardResponse addDhcpSubnet(AxlNetClient.AddDhcpSubnetReq addDhcpSubnet1)
        {
            return axlPortClient20.addDhcpSubnet(addDhcpSubnet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDhcpSubnetResponse> addDhcpSubnetAsync(AxlNetClient.AddDhcpSubnetReq addDhcpSubnet)
        {
            return axlPortClient20.addDhcpSubnetAsync(addDhcpSubnet);
        }

        public AxlNetClient.StandardResponse updateDhcpSubnet(AxlNetClient.UpdateDhcpSubnetReq updateDhcpSubnet1)
        {
            return axlPortClient20.updateDhcpSubnet(updateDhcpSubnet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDhcpSubnetResponse> updateDhcpSubnetAsync(AxlNetClient.UpdateDhcpSubnetReq updateDhcpSubnet)
        {
            return axlPortClient20.updateDhcpSubnetAsync(updateDhcpSubnet);
        }

        public AxlNetClient.GetDhcpSubnetRes getDhcpSubnet(AxlNetClient.GetDhcpSubnetReq getDhcpSubnet1)
        {
            return axlPortClient20.getDhcpSubnet(getDhcpSubnet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDhcpSubnetResponse> getDhcpSubnetAsync(AxlNetClient.GetDhcpSubnetReq getDhcpSubnet)
        {
            return axlPortClient20.getDhcpSubnetAsync(getDhcpSubnet);
        }

        public AxlNetClient.StandardResponse removeDhcpSubnet(AxlNetClient.RemoveDhcpSubnetReq removeDhcpSubnet1)
        {
            return axlPortClient20.removeDhcpSubnet(removeDhcpSubnet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDhcpSubnetResponse> removeDhcpSubnetAsync(AxlNetClient.RemoveDhcpSubnetReq removeDhcpSubnet)
        {
            return axlPortClient20.removeDhcpSubnetAsync(removeDhcpSubnet);
        }

        public AxlNetClient.ListDhcpSubnetRes listDhcpSubnet(AxlNetClient.ListDhcpSubnetReq listDhcpSubnet1)
        {
            return axlPortClient20.listDhcpSubnet(listDhcpSubnet1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDhcpSubnetResponse> listDhcpSubnetAsync(AxlNetClient.ListDhcpSubnetReq listDhcpSubnet)
        {
            return axlPortClient20.listDhcpSubnetAsync(listDhcpSubnet);
        }

        public AxlNetClient.StandardResponse addCallPark(AxlNetClient.AddCallParkReq addCallPark1)
        {
            return axlPortClient20.addCallPark(addCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallParkResponse> addCallParkAsync(AxlNetClient.AddCallParkReq addCallPark)
        {
            return axlPortClient20.addCallParkAsync(addCallPark);
        }

        public AxlNetClient.StandardResponse updateCallPark(AxlNetClient.UpdateCallParkReq updateCallPark1)
        {
            return axlPortClient20.updateCallPark(updateCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallParkResponse> updateCallParkAsync(AxlNetClient.UpdateCallParkReq updateCallPark)
        {
            return axlPortClient20.updateCallParkAsync(updateCallPark);
        }

        public AxlNetClient.GetCallParkRes getCallPark(AxlNetClient.GetCallParkReq getCallPark1)
        {
            return axlPortClient20.getCallPark(getCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallParkResponse> getCallParkAsync(AxlNetClient.GetCallParkReq getCallPark)
        {
            return axlPortClient20.getCallParkAsync(getCallPark);
        }

        public AxlNetClient.StandardResponse removeCallPark(AxlNetClient.RemoveCallParkReq removeCallPark1)
        {
            return axlPortClient20.removeCallPark(removeCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallParkResponse> removeCallParkAsync(AxlNetClient.RemoveCallParkReq removeCallPark)
        {
            return axlPortClient20.removeCallParkAsync(removeCallPark);
        }

        public AxlNetClient.ListCallParkRes listCallPark(AxlNetClient.ListCallParkReq listCallPark1)
        {
            return axlPortClient20.listCallPark(listCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallParkResponse> listCallParkAsync(AxlNetClient.ListCallParkReq listCallPark)
        {
            return axlPortClient20.listCallParkAsync(listCallPark);
        }

        public AxlNetClient.StandardResponse addDirectedCallPark(AxlNetClient.AddDirectedCallParkReq addDirectedCallPark1)
        {
            return axlPortClient20.addDirectedCallPark(addDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirectedCallParkResponse> addDirectedCallParkAsync(AxlNetClient.AddDirectedCallParkReq addDirectedCallPark)
        {
            return axlPortClient20.addDirectedCallParkAsync(addDirectedCallPark);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort20
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDhcpServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDhcpServerResponse listDhcpServer(AxlNetClient.listDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDhcpServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDhcpServerResponse> listDhcpServerAsync(AxlNetClient.listDhcpServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDhcpSubnet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDhcpSubnetResponse addDhcpSubnet(AxlNetClient.addDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDhcpSubnet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDhcpSubnetResponse> addDhcpSubnetAsync(AxlNetClient.addDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDhcpSubnet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDhcpSubnetResponse updateDhcpSubnet(AxlNetClient.updateDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDhcpSubnet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDhcpSubnetResponse> updateDhcpSubnetAsync(AxlNetClient.updateDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDhcpSubnet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDhcpSubnetResponse getDhcpSubnet(AxlNetClient.getDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDhcpSubnet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDhcpSubnetResponse> getDhcpSubnetAsync(AxlNetClient.getDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDhcpSubnet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDhcpSubnetResponse removeDhcpSubnet(AxlNetClient.removeDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDhcpSubnet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDhcpSubnetResponse> removeDhcpSubnetAsync(AxlNetClient.removeDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDhcpSubnet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDhcpSubnetResponse listDhcpSubnet(AxlNetClient.listDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDhcpSubnet", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDhcpSubnetResponse> listDhcpSubnetAsync(AxlNetClient.listDhcpSubnetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCallParkResponse addCallPark(AxlNetClient.addCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCallParkResponse> addCallParkAsync(AxlNetClient.addCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallParkResponse updateCallPark(AxlNetClient.updateCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallParkResponse> updateCallParkAsync(AxlNetClient.updateCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallParkResponse getCallPark(AxlNetClient.getCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallParkResponse> getCallParkAsync(AxlNetClient.getCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCallParkResponse removeCallPark(AxlNetClient.removeCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCallParkResponse> removeCallParkAsync(AxlNetClient.removeCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallParkResponse listCallPark(AxlNetClient.listCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallParkResponse> listCallParkAsync(AxlNetClient.listCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDirectedCallParkResponse addDirectedCallPark(AxlNetClient.addDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDirectedCallParkResponse> addDirectedCallParkAsync(AxlNetClient.addDirectedCallParkRequest request);
    }

    public class AXLPortClient20 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort20>, AxlNetClient.AXLPort20
    {
        public AXLPortClient20(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDhcpServerResponse AxlNetClient.AXLPort20.listDhcpServer(AxlNetClient.listDhcpServerRequest request)
        {
            return base.Channel.listDhcpServer(request);
        }

        public AxlNetClient.ListDhcpServerRes listDhcpServer(AxlNetClient.ListDhcpServerReq listDhcpServer1)
        {
            AxlNetClient.listDhcpServerRequest inValue = new AxlNetClient.listDhcpServerRequest();
            inValue.listDhcpServer = listDhcpServer1;
            AxlNetClient.listDhcpServerResponse retVal = ((AxlNetClient.AXLPort20)(this)).listDhcpServer(inValue);
            return retVal.listDhcpServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDhcpServerResponse> AxlNetClient.AXLPort20.listDhcpServerAsync(AxlNetClient.listDhcpServerRequest request)
        {
            return base.Channel.listDhcpServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDhcpServerResponse> listDhcpServerAsync(AxlNetClient.ListDhcpServerReq listDhcpServer)
        {
            AxlNetClient.listDhcpServerRequest inValue = new AxlNetClient.listDhcpServerRequest();
            inValue.listDhcpServer = listDhcpServer;
            return ((AxlNetClient.AXLPort20)(this)).listDhcpServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDhcpSubnetResponse AxlNetClient.AXLPort20.addDhcpSubnet(AxlNetClient.addDhcpSubnetRequest request)
        {
            return base.Channel.addDhcpSubnet(request);
        }

        public AxlNetClient.StandardResponse addDhcpSubnet(AxlNetClient.AddDhcpSubnetReq addDhcpSubnet1)
        {
            AxlNetClient.addDhcpSubnetRequest inValue = new AxlNetClient.addDhcpSubnetRequest();
            inValue.addDhcpSubnet = addDhcpSubnet1;
            AxlNetClient.addDhcpSubnetResponse retVal = ((AxlNetClient.AXLPort20)(this)).addDhcpSubnet(inValue);
            return retVal.addDhcpSubnetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDhcpSubnetResponse> AxlNetClient.AXLPort20.addDhcpSubnetAsync(AxlNetClient.addDhcpSubnetRequest request)
        {
            return base.Channel.addDhcpSubnetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDhcpSubnetResponse> addDhcpSubnetAsync(AxlNetClient.AddDhcpSubnetReq addDhcpSubnet)
        {
            AxlNetClient.addDhcpSubnetRequest inValue = new AxlNetClient.addDhcpSubnetRequest();
            inValue.addDhcpSubnet = addDhcpSubnet;
            return ((AxlNetClient.AXLPort20)(this)).addDhcpSubnetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDhcpSubnetResponse AxlNetClient.AXLPort20.updateDhcpSubnet(AxlNetClient.updateDhcpSubnetRequest request)
        {
            return base.Channel.updateDhcpSubnet(request);
        }

        public AxlNetClient.StandardResponse updateDhcpSubnet(AxlNetClient.UpdateDhcpSubnetReq updateDhcpSubnet1)
        {
            AxlNetClient.updateDhcpSubnetRequest inValue = new AxlNetClient.updateDhcpSubnetRequest();
            inValue.updateDhcpSubnet = updateDhcpSubnet1;
            AxlNetClient.updateDhcpSubnetResponse retVal = ((AxlNetClient.AXLPort20)(this)).updateDhcpSubnet(inValue);
            return retVal.updateDhcpSubnetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDhcpSubnetResponse> AxlNetClient.AXLPort20.updateDhcpSubnetAsync(AxlNetClient.updateDhcpSubnetRequest request)
        {
            return base.Channel.updateDhcpSubnetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDhcpSubnetResponse> updateDhcpSubnetAsync(AxlNetClient.UpdateDhcpSubnetReq updateDhcpSubnet)
        {
            AxlNetClient.updateDhcpSubnetRequest inValue = new AxlNetClient.updateDhcpSubnetRequest();
            inValue.updateDhcpSubnet = updateDhcpSubnet;
            return ((AxlNetClient.AXLPort20)(this)).updateDhcpSubnetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDhcpSubnetResponse AxlNetClient.AXLPort20.getDhcpSubnet(AxlNetClient.getDhcpSubnetRequest request)
        {
            return base.Channel.getDhcpSubnet(request);
        }

        public AxlNetClient.GetDhcpSubnetRes getDhcpSubnet(AxlNetClient.GetDhcpSubnetReq getDhcpSubnet1)
        {
            AxlNetClient.getDhcpSubnetRequest inValue = new AxlNetClient.getDhcpSubnetRequest();
            inValue.getDhcpSubnet = getDhcpSubnet1;
            AxlNetClient.getDhcpSubnetResponse retVal = ((AxlNetClient.AXLPort20)(this)).getDhcpSubnet(inValue);
            return retVal.getDhcpSubnetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDhcpSubnetResponse> AxlNetClient.AXLPort20.getDhcpSubnetAsync(AxlNetClient.getDhcpSubnetRequest request)
        {
            return base.Channel.getDhcpSubnetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDhcpSubnetResponse> getDhcpSubnetAsync(AxlNetClient.GetDhcpSubnetReq getDhcpSubnet)
        {
            AxlNetClient.getDhcpSubnetRequest inValue = new AxlNetClient.getDhcpSubnetRequest();
            inValue.getDhcpSubnet = getDhcpSubnet;
            return ((AxlNetClient.AXLPort20)(this)).getDhcpSubnetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDhcpSubnetResponse AxlNetClient.AXLPort20.removeDhcpSubnet(AxlNetClient.removeDhcpSubnetRequest request)
        {
            return base.Channel.removeDhcpSubnet(request);
        }

        public AxlNetClient.StandardResponse removeDhcpSubnet(AxlNetClient.RemoveDhcpSubnetReq removeDhcpSubnet1)
        {
            AxlNetClient.removeDhcpSubnetRequest inValue = new AxlNetClient.removeDhcpSubnetRequest();
            inValue.removeDhcpSubnet = removeDhcpSubnet1;
            AxlNetClient.removeDhcpSubnetResponse retVal = ((AxlNetClient.AXLPort20)(this)).removeDhcpSubnet(inValue);
            return retVal.removeDhcpSubnetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDhcpSubnetResponse> AxlNetClient.AXLPort20.removeDhcpSubnetAsync(AxlNetClient.removeDhcpSubnetRequest request)
        {
            return base.Channel.removeDhcpSubnetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDhcpSubnetResponse> removeDhcpSubnetAsync(AxlNetClient.RemoveDhcpSubnetReq removeDhcpSubnet)
        {
            AxlNetClient.removeDhcpSubnetRequest inValue = new AxlNetClient.removeDhcpSubnetRequest();
            inValue.removeDhcpSubnet = removeDhcpSubnet;
            return ((AxlNetClient.AXLPort20)(this)).removeDhcpSubnetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDhcpSubnetResponse AxlNetClient.AXLPort20.listDhcpSubnet(AxlNetClient.listDhcpSubnetRequest request)
        {
            return base.Channel.listDhcpSubnet(request);
        }

        public AxlNetClient.ListDhcpSubnetRes listDhcpSubnet(AxlNetClient.ListDhcpSubnetReq listDhcpSubnet1)
        {
            AxlNetClient.listDhcpSubnetRequest inValue = new AxlNetClient.listDhcpSubnetRequest();
            inValue.listDhcpSubnet = listDhcpSubnet1;
            AxlNetClient.listDhcpSubnetResponse retVal = ((AxlNetClient.AXLPort20)(this)).listDhcpSubnet(inValue);
            return retVal.listDhcpSubnetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDhcpSubnetResponse> AxlNetClient.AXLPort20.listDhcpSubnetAsync(AxlNetClient.listDhcpSubnetRequest request)
        {
            return base.Channel.listDhcpSubnetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDhcpSubnetResponse> listDhcpSubnetAsync(AxlNetClient.ListDhcpSubnetReq listDhcpSubnet)
        {
            AxlNetClient.listDhcpSubnetRequest inValue = new AxlNetClient.listDhcpSubnetRequest();
            inValue.listDhcpSubnet = listDhcpSubnet;
            return ((AxlNetClient.AXLPort20)(this)).listDhcpSubnetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCallParkResponse AxlNetClient.AXLPort20.addCallPark(AxlNetClient.addCallParkRequest request)
        {
            return base.Channel.addCallPark(request);
        }

        public AxlNetClient.StandardResponse addCallPark(AxlNetClient.AddCallParkReq addCallPark1)
        {
            AxlNetClient.addCallParkRequest inValue = new AxlNetClient.addCallParkRequest();
            inValue.addCallPark = addCallPark1;
            AxlNetClient.addCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).addCallPark(inValue);
            return retVal.addCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCallParkResponse> AxlNetClient.AXLPort20.addCallParkAsync(AxlNetClient.addCallParkRequest request)
        {
            return base.Channel.addCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallParkResponse> addCallParkAsync(AxlNetClient.AddCallParkReq addCallPark)
        {
            AxlNetClient.addCallParkRequest inValue = new AxlNetClient.addCallParkRequest();
            inValue.addCallPark = addCallPark;
            return ((AxlNetClient.AXLPort20)(this)).addCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallParkResponse AxlNetClient.AXLPort20.updateCallPark(AxlNetClient.updateCallParkRequest request)
        {
            return base.Channel.updateCallPark(request);
        }

        public AxlNetClient.StandardResponse updateCallPark(AxlNetClient.UpdateCallParkReq updateCallPark1)
        {
            AxlNetClient.updateCallParkRequest inValue = new AxlNetClient.updateCallParkRequest();
            inValue.updateCallPark = updateCallPark1;
            AxlNetClient.updateCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).updateCallPark(inValue);
            return retVal.updateCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallParkResponse> AxlNetClient.AXLPort20.updateCallParkAsync(AxlNetClient.updateCallParkRequest request)
        {
            return base.Channel.updateCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallParkResponse> updateCallParkAsync(AxlNetClient.UpdateCallParkReq updateCallPark)
        {
            AxlNetClient.updateCallParkRequest inValue = new AxlNetClient.updateCallParkRequest();
            inValue.updateCallPark = updateCallPark;
            return ((AxlNetClient.AXLPort20)(this)).updateCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallParkResponse AxlNetClient.AXLPort20.getCallPark(AxlNetClient.getCallParkRequest request)
        {
            return base.Channel.getCallPark(request);
        }

        public AxlNetClient.GetCallParkRes getCallPark(AxlNetClient.GetCallParkReq getCallPark1)
        {
            AxlNetClient.getCallParkRequest inValue = new AxlNetClient.getCallParkRequest();
            inValue.getCallPark = getCallPark1;
            AxlNetClient.getCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).getCallPark(inValue);
            return retVal.getCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallParkResponse> AxlNetClient.AXLPort20.getCallParkAsync(AxlNetClient.getCallParkRequest request)
        {
            return base.Channel.getCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallParkResponse> getCallParkAsync(AxlNetClient.GetCallParkReq getCallPark)
        {
            AxlNetClient.getCallParkRequest inValue = new AxlNetClient.getCallParkRequest();
            inValue.getCallPark = getCallPark;
            return ((AxlNetClient.AXLPort20)(this)).getCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCallParkResponse AxlNetClient.AXLPort20.removeCallPark(AxlNetClient.removeCallParkRequest request)
        {
            return base.Channel.removeCallPark(request);
        }

        public AxlNetClient.StandardResponse removeCallPark(AxlNetClient.RemoveCallParkReq removeCallPark1)
        {
            AxlNetClient.removeCallParkRequest inValue = new AxlNetClient.removeCallParkRequest();
            inValue.removeCallPark = removeCallPark1;
            AxlNetClient.removeCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).removeCallPark(inValue);
            return retVal.removeCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCallParkResponse> AxlNetClient.AXLPort20.removeCallParkAsync(AxlNetClient.removeCallParkRequest request)
        {
            return base.Channel.removeCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallParkResponse> removeCallParkAsync(AxlNetClient.RemoveCallParkReq removeCallPark)
        {
            AxlNetClient.removeCallParkRequest inValue = new AxlNetClient.removeCallParkRequest();
            inValue.removeCallPark = removeCallPark;
            return ((AxlNetClient.AXLPort20)(this)).removeCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallParkResponse AxlNetClient.AXLPort20.listCallPark(AxlNetClient.listCallParkRequest request)
        {
            return base.Channel.listCallPark(request);
        }

        public AxlNetClient.ListCallParkRes listCallPark(AxlNetClient.ListCallParkReq listCallPark1)
        {
            AxlNetClient.listCallParkRequest inValue = new AxlNetClient.listCallParkRequest();
            inValue.listCallPark = listCallPark1;
            AxlNetClient.listCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).listCallPark(inValue);
            return retVal.listCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallParkResponse> AxlNetClient.AXLPort20.listCallParkAsync(AxlNetClient.listCallParkRequest request)
        {
            return base.Channel.listCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallParkResponse> listCallParkAsync(AxlNetClient.ListCallParkReq listCallPark)
        {
            AxlNetClient.listCallParkRequest inValue = new AxlNetClient.listCallParkRequest();
            inValue.listCallPark = listCallPark;
            return ((AxlNetClient.AXLPort20)(this)).listCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDirectedCallParkResponse AxlNetClient.AXLPort20.addDirectedCallPark(AxlNetClient.addDirectedCallParkRequest request)
        {
            return base.Channel.addDirectedCallPark(request);
        }

        public AxlNetClient.StandardResponse addDirectedCallPark(AxlNetClient.AddDirectedCallParkReq addDirectedCallPark1)
        {
            AxlNetClient.addDirectedCallParkRequest inValue = new AxlNetClient.addDirectedCallParkRequest();
            inValue.addDirectedCallPark = addDirectedCallPark1;
            AxlNetClient.addDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort20)(this)).addDirectedCallPark(inValue);
            return retVal.addDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDirectedCallParkResponse> AxlNetClient.AXLPort20.addDirectedCallParkAsync(AxlNetClient.addDirectedCallParkRequest request)
        {
            return base.Channel.addDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirectedCallParkResponse> addDirectedCallParkAsync(AxlNetClient.AddDirectedCallParkReq addDirectedCallPark)
        {
            AxlNetClient.addDirectedCallParkRequest inValue = new AxlNetClient.addDirectedCallParkRequest();
            inValue.addDirectedCallPark = addDirectedCallPark;
            return ((AxlNetClient.AXLPort20)(this)).addDirectedCallParkAsync(inValue);
        }
    }
}