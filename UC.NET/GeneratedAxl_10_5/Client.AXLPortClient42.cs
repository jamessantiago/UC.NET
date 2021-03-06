namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient42 _axlPortClient42;

        private static AXLPortClient42 axlPortClient42 => _axlPortClient42 == null ||
            _axlPortClient42.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient42 = LoadClient42()) : _axlPortClient42;

        private static AXLPortClient42 LoadClient42()
        {
            var client = new AXLPortClient42(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close42;
            OnAbort += Abort42;
            return client;
        }

        private static void Close42(object sender, System.EventArgs e)
        {
            _axlPortClient42.Close();
        }

        private static void Abort42(object sender, System.EventArgs e)
        {
            _axlPortClient42.Abort();
        }

        public AxlNetClient.StandardResponse restartH323Phone(AxlNetClient.NameAndGUIDRequest restartH323Phone1)
        {
            return axlPortClient42.restartH323Phone(restartH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323PhoneResponse> restartH323PhoneAsync(AxlNetClient.NameAndGUIDRequest restartH323Phone)
        {
            return axlPortClient42.restartH323PhoneAsync(restartH323Phone);
        }

        public AxlNetClient.StandardResponse applyH323Phone(AxlNetClient.NameAndGUIDRequest applyH323Phone1)
        {
            return axlPortClient42.applyH323Phone(applyH323Phone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyH323PhoneResponse> applyH323PhoneAsync(AxlNetClient.NameAndGUIDRequest applyH323Phone)
        {
            return axlPortClient42.applyH323PhoneAsync(applyH323Phone);
        }

        public AxlNetClient.StandardResponse updateMohServer(AxlNetClient.UpdateMohServerReq updateMohServer1)
        {
            return axlPortClient42.updateMohServer(updateMohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMohServerResponse> updateMohServerAsync(AxlNetClient.UpdateMohServerReq updateMohServer)
        {
            return axlPortClient42.updateMohServerAsync(updateMohServer);
        }

        public AxlNetClient.GetMohServerRes getMohServer(AxlNetClient.GetMohServerReq getMohServer1)
        {
            return axlPortClient42.getMohServer(getMohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMohServerResponse> getMohServerAsync(AxlNetClient.GetMohServerReq getMohServer)
        {
            return axlPortClient42.getMohServerAsync(getMohServer);
        }

        public AxlNetClient.ListMohServerRes listMohServer(AxlNetClient.ListMohServerReq listMohServer1)
        {
            return axlPortClient42.listMohServer(listMohServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMohServerResponse> listMohServerAsync(AxlNetClient.ListMohServerReq listMohServer)
        {
            return axlPortClient42.listMohServerAsync(listMohServer);
        }

        public AxlNetClient.StandardResponse addH323Trunk(AxlNetClient.AddH323TrunkReq addH323Trunk1)
        {
            return axlPortClient42.addH323Trunk(addH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323TrunkResponse> addH323TrunkAsync(AxlNetClient.AddH323TrunkReq addH323Trunk)
        {
            return axlPortClient42.addH323TrunkAsync(addH323Trunk);
        }

        public AxlNetClient.StandardResponse updateH323Trunk(AxlNetClient.UpdateH323TrunkReq updateH323Trunk1)
        {
            return axlPortClient42.updateH323Trunk(updateH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323TrunkResponse> updateH323TrunkAsync(AxlNetClient.UpdateH323TrunkReq updateH323Trunk)
        {
            return axlPortClient42.updateH323TrunkAsync(updateH323Trunk);
        }

        public AxlNetClient.GetH323TrunkRes getH323Trunk(AxlNetClient.GetH323TrunkReq getH323Trunk1)
        {
            return axlPortClient42.getH323Trunk(getH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323TrunkResponse> getH323TrunkAsync(AxlNetClient.GetH323TrunkReq getH323Trunk)
        {
            return axlPortClient42.getH323TrunkAsync(getH323Trunk);
        }

        public AxlNetClient.StandardResponse removeH323Trunk(AxlNetClient.NameAndGUIDRequest removeH323Trunk1)
        {
            return axlPortClient42.removeH323Trunk(removeH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323TrunkResponse> removeH323TrunkAsync(AxlNetClient.NameAndGUIDRequest removeH323Trunk)
        {
            return axlPortClient42.removeH323TrunkAsync(removeH323Trunk);
        }

        public AxlNetClient.ListH323TrunkRes listH323Trunk(AxlNetClient.ListH323TrunkReq listH323Trunk1)
        {
            return axlPortClient42.listH323Trunk(listH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323TrunkResponse> listH323TrunkAsync(AxlNetClient.ListH323TrunkReq listH323Trunk)
        {
            return axlPortClient42.listH323TrunkAsync(listH323Trunk);
        }

        public AxlNetClient.StandardResponse resetH323Trunk(AxlNetClient.NameAndGUIDRequest resetH323Trunk1)
        {
            return axlPortClient42.resetH323Trunk(resetH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323TrunkResponse> resetH323TrunkAsync(AxlNetClient.NameAndGUIDRequest resetH323Trunk)
        {
            return axlPortClient42.resetH323TrunkAsync(resetH323Trunk);
        }

        public AxlNetClient.StandardResponse restartH323Trunk(AxlNetClient.NameAndGUIDRequest restartH323Trunk1)
        {
            return axlPortClient42.restartH323Trunk(restartH323Trunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323TrunkResponse> restartH323TrunkAsync(AxlNetClient.NameAndGUIDRequest restartH323Trunk)
        {
            return axlPortClient42.restartH323TrunkAsync(restartH323Trunk);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort42
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartH323PhoneResponse restartH323Phone(AxlNetClient.restartH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartH323PhoneResponse> restartH323PhoneAsync(AxlNetClient.restartH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyH323Phone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyH323PhoneResponse applyH323Phone(AxlNetClient.applyH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyH323Phone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyH323PhoneResponse> applyH323PhoneAsync(AxlNetClient.applyH323PhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMohServerResponse updateMohServer(AxlNetClient.updateMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMohServerResponse> updateMohServerAsync(AxlNetClient.updateMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMohServerResponse getMohServer(AxlNetClient.getMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMohServerResponse> getMohServerAsync(AxlNetClient.getMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMohServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMohServerResponse listMohServer(AxlNetClient.listMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMohServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMohServerResponse> listMohServerAsync(AxlNetClient.listMohServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addH323TrunkResponse addH323Trunk(AxlNetClient.addH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addH323TrunkResponse> addH323TrunkAsync(AxlNetClient.addH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateH323TrunkResponse updateH323Trunk(AxlNetClient.updateH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateH323TrunkResponse> updateH323TrunkAsync(AxlNetClient.updateH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getH323TrunkResponse getH323Trunk(AxlNetClient.getH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getH323TrunkResponse> getH323TrunkAsync(AxlNetClient.getH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeH323TrunkResponse removeH323Trunk(AxlNetClient.removeH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeH323TrunkResponse> removeH323TrunkAsync(AxlNetClient.removeH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listH323TrunkResponse listH323Trunk(AxlNetClient.listH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listH323TrunkResponse> listH323TrunkAsync(AxlNetClient.listH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetH323TrunkResponse resetH323Trunk(AxlNetClient.resetH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetH323TrunkResponse> resetH323TrunkAsync(AxlNetClient.resetH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Trunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartH323TrunkResponse restartH323Trunk(AxlNetClient.restartH323TrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Trunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartH323TrunkResponse> restartH323TrunkAsync(AxlNetClient.restartH323TrunkRequest request);
    }

    public class AXLPortClient42 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort42>, AxlNetClient.AXLPort42
    {
        public AXLPortClient42(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartH323PhoneResponse AxlNetClient.AXLPort42.restartH323Phone(AxlNetClient.restartH323PhoneRequest request)
        {
            return base.Channel.restartH323Phone(request);
        }

        public AxlNetClient.StandardResponse restartH323Phone(AxlNetClient.NameAndGUIDRequest restartH323Phone1)
        {
            AxlNetClient.restartH323PhoneRequest inValue = new AxlNetClient.restartH323PhoneRequest();
            inValue.restartH323Phone = restartH323Phone1;
            AxlNetClient.restartH323PhoneResponse retVal = ((AxlNetClient.AXLPort42)(this)).restartH323Phone(inValue);
            return retVal.restartH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartH323PhoneResponse> AxlNetClient.AXLPort42.restartH323PhoneAsync(AxlNetClient.restartH323PhoneRequest request)
        {
            return base.Channel.restartH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323PhoneResponse> restartH323PhoneAsync(AxlNetClient.NameAndGUIDRequest restartH323Phone)
        {
            AxlNetClient.restartH323PhoneRequest inValue = new AxlNetClient.restartH323PhoneRequest();
            inValue.restartH323Phone = restartH323Phone;
            return ((AxlNetClient.AXLPort42)(this)).restartH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyH323PhoneResponse AxlNetClient.AXLPort42.applyH323Phone(AxlNetClient.applyH323PhoneRequest request)
        {
            return base.Channel.applyH323Phone(request);
        }

        public AxlNetClient.StandardResponse applyH323Phone(AxlNetClient.NameAndGUIDRequest applyH323Phone1)
        {
            AxlNetClient.applyH323PhoneRequest inValue = new AxlNetClient.applyH323PhoneRequest();
            inValue.applyH323Phone = applyH323Phone1;
            AxlNetClient.applyH323PhoneResponse retVal = ((AxlNetClient.AXLPort42)(this)).applyH323Phone(inValue);
            return retVal.applyH323PhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyH323PhoneResponse> AxlNetClient.AXLPort42.applyH323PhoneAsync(AxlNetClient.applyH323PhoneRequest request)
        {
            return base.Channel.applyH323PhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyH323PhoneResponse> applyH323PhoneAsync(AxlNetClient.NameAndGUIDRequest applyH323Phone)
        {
            AxlNetClient.applyH323PhoneRequest inValue = new AxlNetClient.applyH323PhoneRequest();
            inValue.applyH323Phone = applyH323Phone;
            return ((AxlNetClient.AXLPort42)(this)).applyH323PhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMohServerResponse AxlNetClient.AXLPort42.updateMohServer(AxlNetClient.updateMohServerRequest request)
        {
            return base.Channel.updateMohServer(request);
        }

        public AxlNetClient.StandardResponse updateMohServer(AxlNetClient.UpdateMohServerReq updateMohServer1)
        {
            AxlNetClient.updateMohServerRequest inValue = new AxlNetClient.updateMohServerRequest();
            inValue.updateMohServer = updateMohServer1;
            AxlNetClient.updateMohServerResponse retVal = ((AxlNetClient.AXLPort42)(this)).updateMohServer(inValue);
            return retVal.updateMohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMohServerResponse> AxlNetClient.AXLPort42.updateMohServerAsync(AxlNetClient.updateMohServerRequest request)
        {
            return base.Channel.updateMohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMohServerResponse> updateMohServerAsync(AxlNetClient.UpdateMohServerReq updateMohServer)
        {
            AxlNetClient.updateMohServerRequest inValue = new AxlNetClient.updateMohServerRequest();
            inValue.updateMohServer = updateMohServer;
            return ((AxlNetClient.AXLPort42)(this)).updateMohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMohServerResponse AxlNetClient.AXLPort42.getMohServer(AxlNetClient.getMohServerRequest request)
        {
            return base.Channel.getMohServer(request);
        }

        public AxlNetClient.GetMohServerRes getMohServer(AxlNetClient.GetMohServerReq getMohServer1)
        {
            AxlNetClient.getMohServerRequest inValue = new AxlNetClient.getMohServerRequest();
            inValue.getMohServer = getMohServer1;
            AxlNetClient.getMohServerResponse retVal = ((AxlNetClient.AXLPort42)(this)).getMohServer(inValue);
            return retVal.getMohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMohServerResponse> AxlNetClient.AXLPort42.getMohServerAsync(AxlNetClient.getMohServerRequest request)
        {
            return base.Channel.getMohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMohServerResponse> getMohServerAsync(AxlNetClient.GetMohServerReq getMohServer)
        {
            AxlNetClient.getMohServerRequest inValue = new AxlNetClient.getMohServerRequest();
            inValue.getMohServer = getMohServer;
            return ((AxlNetClient.AXLPort42)(this)).getMohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMohServerResponse AxlNetClient.AXLPort42.listMohServer(AxlNetClient.listMohServerRequest request)
        {
            return base.Channel.listMohServer(request);
        }

        public AxlNetClient.ListMohServerRes listMohServer(AxlNetClient.ListMohServerReq listMohServer1)
        {
            AxlNetClient.listMohServerRequest inValue = new AxlNetClient.listMohServerRequest();
            inValue.listMohServer = listMohServer1;
            AxlNetClient.listMohServerResponse retVal = ((AxlNetClient.AXLPort42)(this)).listMohServer(inValue);
            return retVal.listMohServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMohServerResponse> AxlNetClient.AXLPort42.listMohServerAsync(AxlNetClient.listMohServerRequest request)
        {
            return base.Channel.listMohServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMohServerResponse> listMohServerAsync(AxlNetClient.ListMohServerReq listMohServer)
        {
            AxlNetClient.listMohServerRequest inValue = new AxlNetClient.listMohServerRequest();
            inValue.listMohServer = listMohServer;
            return ((AxlNetClient.AXLPort42)(this)).listMohServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addH323TrunkResponse AxlNetClient.AXLPort42.addH323Trunk(AxlNetClient.addH323TrunkRequest request)
        {
            return base.Channel.addH323Trunk(request);
        }

        public AxlNetClient.StandardResponse addH323Trunk(AxlNetClient.AddH323TrunkReq addH323Trunk1)
        {
            AxlNetClient.addH323TrunkRequest inValue = new AxlNetClient.addH323TrunkRequest();
            inValue.addH323Trunk = addH323Trunk1;
            AxlNetClient.addH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).addH323Trunk(inValue);
            return retVal.addH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addH323TrunkResponse> AxlNetClient.AXLPort42.addH323TrunkAsync(AxlNetClient.addH323TrunkRequest request)
        {
            return base.Channel.addH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323TrunkResponse> addH323TrunkAsync(AxlNetClient.AddH323TrunkReq addH323Trunk)
        {
            AxlNetClient.addH323TrunkRequest inValue = new AxlNetClient.addH323TrunkRequest();
            inValue.addH323Trunk = addH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).addH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateH323TrunkResponse AxlNetClient.AXLPort42.updateH323Trunk(AxlNetClient.updateH323TrunkRequest request)
        {
            return base.Channel.updateH323Trunk(request);
        }

        public AxlNetClient.StandardResponse updateH323Trunk(AxlNetClient.UpdateH323TrunkReq updateH323Trunk1)
        {
            AxlNetClient.updateH323TrunkRequest inValue = new AxlNetClient.updateH323TrunkRequest();
            inValue.updateH323Trunk = updateH323Trunk1;
            AxlNetClient.updateH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).updateH323Trunk(inValue);
            return retVal.updateH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateH323TrunkResponse> AxlNetClient.AXLPort42.updateH323TrunkAsync(AxlNetClient.updateH323TrunkRequest request)
        {
            return base.Channel.updateH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323TrunkResponse> updateH323TrunkAsync(AxlNetClient.UpdateH323TrunkReq updateH323Trunk)
        {
            AxlNetClient.updateH323TrunkRequest inValue = new AxlNetClient.updateH323TrunkRequest();
            inValue.updateH323Trunk = updateH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).updateH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getH323TrunkResponse AxlNetClient.AXLPort42.getH323Trunk(AxlNetClient.getH323TrunkRequest request)
        {
            return base.Channel.getH323Trunk(request);
        }

        public AxlNetClient.GetH323TrunkRes getH323Trunk(AxlNetClient.GetH323TrunkReq getH323Trunk1)
        {
            AxlNetClient.getH323TrunkRequest inValue = new AxlNetClient.getH323TrunkRequest();
            inValue.getH323Trunk = getH323Trunk1;
            AxlNetClient.getH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).getH323Trunk(inValue);
            return retVal.getH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getH323TrunkResponse> AxlNetClient.AXLPort42.getH323TrunkAsync(AxlNetClient.getH323TrunkRequest request)
        {
            return base.Channel.getH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323TrunkResponse> getH323TrunkAsync(AxlNetClient.GetH323TrunkReq getH323Trunk)
        {
            AxlNetClient.getH323TrunkRequest inValue = new AxlNetClient.getH323TrunkRequest();
            inValue.getH323Trunk = getH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).getH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeH323TrunkResponse AxlNetClient.AXLPort42.removeH323Trunk(AxlNetClient.removeH323TrunkRequest request)
        {
            return base.Channel.removeH323Trunk(request);
        }

        public AxlNetClient.StandardResponse removeH323Trunk(AxlNetClient.NameAndGUIDRequest removeH323Trunk1)
        {
            AxlNetClient.removeH323TrunkRequest inValue = new AxlNetClient.removeH323TrunkRequest();
            inValue.removeH323Trunk = removeH323Trunk1;
            AxlNetClient.removeH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).removeH323Trunk(inValue);
            return retVal.removeH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeH323TrunkResponse> AxlNetClient.AXLPort42.removeH323TrunkAsync(AxlNetClient.removeH323TrunkRequest request)
        {
            return base.Channel.removeH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323TrunkResponse> removeH323TrunkAsync(AxlNetClient.NameAndGUIDRequest removeH323Trunk)
        {
            AxlNetClient.removeH323TrunkRequest inValue = new AxlNetClient.removeH323TrunkRequest();
            inValue.removeH323Trunk = removeH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).removeH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listH323TrunkResponse AxlNetClient.AXLPort42.listH323Trunk(AxlNetClient.listH323TrunkRequest request)
        {
            return base.Channel.listH323Trunk(request);
        }

        public AxlNetClient.ListH323TrunkRes listH323Trunk(AxlNetClient.ListH323TrunkReq listH323Trunk1)
        {
            AxlNetClient.listH323TrunkRequest inValue = new AxlNetClient.listH323TrunkRequest();
            inValue.listH323Trunk = listH323Trunk1;
            AxlNetClient.listH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).listH323Trunk(inValue);
            return retVal.listH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listH323TrunkResponse> AxlNetClient.AXLPort42.listH323TrunkAsync(AxlNetClient.listH323TrunkRequest request)
        {
            return base.Channel.listH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323TrunkResponse> listH323TrunkAsync(AxlNetClient.ListH323TrunkReq listH323Trunk)
        {
            AxlNetClient.listH323TrunkRequest inValue = new AxlNetClient.listH323TrunkRequest();
            inValue.listH323Trunk = listH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).listH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetH323TrunkResponse AxlNetClient.AXLPort42.resetH323Trunk(AxlNetClient.resetH323TrunkRequest request)
        {
            return base.Channel.resetH323Trunk(request);
        }

        public AxlNetClient.StandardResponse resetH323Trunk(AxlNetClient.NameAndGUIDRequest resetH323Trunk1)
        {
            AxlNetClient.resetH323TrunkRequest inValue = new AxlNetClient.resetH323TrunkRequest();
            inValue.resetH323Trunk = resetH323Trunk1;
            AxlNetClient.resetH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).resetH323Trunk(inValue);
            return retVal.resetH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetH323TrunkResponse> AxlNetClient.AXLPort42.resetH323TrunkAsync(AxlNetClient.resetH323TrunkRequest request)
        {
            return base.Channel.resetH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323TrunkResponse> resetH323TrunkAsync(AxlNetClient.NameAndGUIDRequest resetH323Trunk)
        {
            AxlNetClient.resetH323TrunkRequest inValue = new AxlNetClient.resetH323TrunkRequest();
            inValue.resetH323Trunk = resetH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).resetH323TrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartH323TrunkResponse AxlNetClient.AXLPort42.restartH323Trunk(AxlNetClient.restartH323TrunkRequest request)
        {
            return base.Channel.restartH323Trunk(request);
        }

        public AxlNetClient.StandardResponse restartH323Trunk(AxlNetClient.NameAndGUIDRequest restartH323Trunk1)
        {
            AxlNetClient.restartH323TrunkRequest inValue = new AxlNetClient.restartH323TrunkRequest();
            inValue.restartH323Trunk = restartH323Trunk1;
            AxlNetClient.restartH323TrunkResponse retVal = ((AxlNetClient.AXLPort42)(this)).restartH323Trunk(inValue);
            return retVal.restartH323TrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartH323TrunkResponse> AxlNetClient.AXLPort42.restartH323TrunkAsync(AxlNetClient.restartH323TrunkRequest request)
        {
            return base.Channel.restartH323TrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323TrunkResponse> restartH323TrunkAsync(AxlNetClient.NameAndGUIDRequest restartH323Trunk)
        {
            AxlNetClient.restartH323TrunkRequest inValue = new AxlNetClient.restartH323TrunkRequest();
            inValue.restartH323Trunk = restartH323Trunk;
            return ((AxlNetClient.AXLPort42)(this)).restartH323TrunkAsync(inValue);
        }
    }
}