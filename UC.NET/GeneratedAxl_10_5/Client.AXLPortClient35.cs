namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient35 _axlPortClient35;

        private static AXLPortClient35 axlPortClient35 => _axlPortClient35 == null ||
            _axlPortClient35.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient35 = LoadClient35()) : _axlPortClient35;

        private static AXLPortClient35 LoadClient35()
        {
            var client = new AXLPortClient35(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close35;
            OnAbort += Abort35;
            return client;
        }

        private static void Close35(object sender, System.EventArgs e)
        {
            _axlPortClient35.Close();
        }

        private static void Abort35(object sender, System.EventArgs e)
        {
            _axlPortClient35.Abort();
        }

        public AxlNetClient.StandardResponse addSipRoutePattern(AxlNetClient.AddSipRoutePatternReq addSipRoutePattern1)
        {
            return axlPortClient35.addSipRoutePattern(addSipRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipRoutePatternResponse> addSipRoutePatternAsync(AxlNetClient.AddSipRoutePatternReq addSipRoutePattern)
        {
            return axlPortClient35.addSipRoutePatternAsync(addSipRoutePattern);
        }

        public AxlNetClient.StandardResponse updateSipRoutePattern(AxlNetClient.UpdateSipRoutePatternReq updateSipRoutePattern1)
        {
            return axlPortClient35.updateSipRoutePattern(updateSipRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipRoutePatternResponse> updateSipRoutePatternAsync(AxlNetClient.UpdateSipRoutePatternReq updateSipRoutePattern)
        {
            return axlPortClient35.updateSipRoutePatternAsync(updateSipRoutePattern);
        }

        public AxlNetClient.GetSipRoutePatternRes getSipRoutePattern(AxlNetClient.GetSipRoutePatternReq getSipRoutePattern1)
        {
            return axlPortClient35.getSipRoutePattern(getSipRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipRoutePatternResponse> getSipRoutePatternAsync(AxlNetClient.GetSipRoutePatternReq getSipRoutePattern)
        {
            return axlPortClient35.getSipRoutePatternAsync(getSipRoutePattern);
        }

        public AxlNetClient.StandardResponse removeSipRoutePattern(AxlNetClient.RemoveSipRoutePatternReq removeSipRoutePattern1)
        {
            return axlPortClient35.removeSipRoutePattern(removeSipRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipRoutePatternResponse> removeSipRoutePatternAsync(AxlNetClient.RemoveSipRoutePatternReq removeSipRoutePattern)
        {
            return axlPortClient35.removeSipRoutePatternAsync(removeSipRoutePattern);
        }

        public AxlNetClient.ListSipRoutePatternRes listSipRoutePattern(AxlNetClient.ListSipRoutePatternReq listSipRoutePattern1)
        {
            return axlPortClient35.listSipRoutePattern(listSipRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipRoutePatternResponse> listSipRoutePatternAsync(AxlNetClient.ListSipRoutePatternReq listSipRoutePattern)
        {
            return axlPortClient35.listSipRoutePatternAsync(listSipRoutePattern);
        }

        public AxlNetClient.StandardResponse addHuntPilot(AxlNetClient.AddHuntPilotReq addHuntPilot1)
        {
            return axlPortClient35.addHuntPilot(addHuntPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHuntPilotResponse> addHuntPilotAsync(AxlNetClient.AddHuntPilotReq addHuntPilot)
        {
            return axlPortClient35.addHuntPilotAsync(addHuntPilot);
        }

        public AxlNetClient.StandardResponse updateHuntPilot(AxlNetClient.UpdateHuntPilotReq updateHuntPilot1)
        {
            return axlPortClient35.updateHuntPilot(updateHuntPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHuntPilotResponse> updateHuntPilotAsync(AxlNetClient.UpdateHuntPilotReq updateHuntPilot)
        {
            return axlPortClient35.updateHuntPilotAsync(updateHuntPilot);
        }

        public AxlNetClient.GetHuntPilotRes getHuntPilot(AxlNetClient.GetHuntPilotReq getHuntPilot1)
        {
            return axlPortClient35.getHuntPilot(getHuntPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHuntPilotResponse> getHuntPilotAsync(AxlNetClient.GetHuntPilotReq getHuntPilot)
        {
            return axlPortClient35.getHuntPilotAsync(getHuntPilot);
        }

        public AxlNetClient.StandardResponse removeHuntPilot(AxlNetClient.RemoveHuntPilotReq removeHuntPilot1)
        {
            return axlPortClient35.removeHuntPilot(removeHuntPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHuntPilotResponse> removeHuntPilotAsync(AxlNetClient.RemoveHuntPilotReq removeHuntPilot)
        {
            return axlPortClient35.removeHuntPilotAsync(removeHuntPilot);
        }

        public AxlNetClient.ListHuntPilotRes listHuntPilot(AxlNetClient.ListHuntPilotReq listHuntPilot1)
        {
            return axlPortClient35.listHuntPilot(listHuntPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listHuntPilotResponse> listHuntPilotAsync(AxlNetClient.ListHuntPilotReq listHuntPilot)
        {
            return axlPortClient35.listHuntPilotAsync(listHuntPilot);
        }

        public AxlNetClient.StandardResponse addRoutePattern(AxlNetClient.AddRoutePatternReq addRoutePattern1)
        {
            return axlPortClient35.addRoutePattern(addRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRoutePatternResponse> addRoutePatternAsync(AxlNetClient.AddRoutePatternReq addRoutePattern)
        {
            return axlPortClient35.addRoutePatternAsync(addRoutePattern);
        }

        public AxlNetClient.StandardResponse updateRoutePattern(AxlNetClient.UpdateRoutePatternReq updateRoutePattern1)
        {
            return axlPortClient35.updateRoutePattern(updateRoutePattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePatternResponse> updateRoutePatternAsync(AxlNetClient.UpdateRoutePatternReq updateRoutePattern)
        {
            return axlPortClient35.updateRoutePatternAsync(updateRoutePattern);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort35
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipRoutePatternResponse addSipRoutePattern(AxlNetClient.addSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipRoutePatternResponse> addSipRoutePatternAsync(AxlNetClient.addSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipRoutePatternResponse updateSipRoutePattern(AxlNetClient.updateSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipRoutePatternResponse> updateSipRoutePatternAsync(AxlNetClient.updateSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipRoutePatternResponse getSipRoutePattern(AxlNetClient.getSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipRoutePatternResponse> getSipRoutePatternAsync(AxlNetClient.getSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipRoutePatternResponse removeSipRoutePattern(AxlNetClient.removeSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipRoutePatternResponse> removeSipRoutePatternAsync(AxlNetClient.removeSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipRoutePatternResponse listSipRoutePattern(AxlNetClient.listSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipRoutePatternResponse> listSipRoutePatternAsync(AxlNetClient.listSipRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHuntPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addHuntPilotResponse addHuntPilot(AxlNetClient.addHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHuntPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addHuntPilotResponse> addHuntPilotAsync(AxlNetClient.addHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHuntPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateHuntPilotResponse updateHuntPilot(AxlNetClient.updateHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHuntPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateHuntPilotResponse> updateHuntPilotAsync(AxlNetClient.updateHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHuntPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getHuntPilotResponse getHuntPilot(AxlNetClient.getHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHuntPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getHuntPilotResponse> getHuntPilotAsync(AxlNetClient.getHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHuntPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeHuntPilotResponse removeHuntPilot(AxlNetClient.removeHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHuntPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeHuntPilotResponse> removeHuntPilotAsync(AxlNetClient.removeHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listHuntPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listHuntPilotResponse listHuntPilot(AxlNetClient.listHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listHuntPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listHuntPilotResponse> listHuntPilotAsync(AxlNetClient.listHuntPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRoutePatternResponse addRoutePattern(AxlNetClient.addRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRoutePatternResponse> addRoutePatternAsync(AxlNetClient.addRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRoutePatternResponse updateRoutePattern(AxlNetClient.updateRoutePatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRoutePattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePatternResponse> updateRoutePatternAsync(AxlNetClient.updateRoutePatternRequest request);
    }

    public class AXLPortClient35 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort35>, AxlNetClient.AXLPort35
    {
        public AXLPortClient35(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipRoutePatternResponse AxlNetClient.AXLPort35.addSipRoutePattern(AxlNetClient.addSipRoutePatternRequest request)
        {
            return base.Channel.addSipRoutePattern(request);
        }

        public AxlNetClient.StandardResponse addSipRoutePattern(AxlNetClient.AddSipRoutePatternReq addSipRoutePattern1)
        {
            AxlNetClient.addSipRoutePatternRequest inValue = new AxlNetClient.addSipRoutePatternRequest();
            inValue.addSipRoutePattern = addSipRoutePattern1;
            AxlNetClient.addSipRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).addSipRoutePattern(inValue);
            return retVal.addSipRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipRoutePatternResponse> AxlNetClient.AXLPort35.addSipRoutePatternAsync(AxlNetClient.addSipRoutePatternRequest request)
        {
            return base.Channel.addSipRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipRoutePatternResponse> addSipRoutePatternAsync(AxlNetClient.AddSipRoutePatternReq addSipRoutePattern)
        {
            AxlNetClient.addSipRoutePatternRequest inValue = new AxlNetClient.addSipRoutePatternRequest();
            inValue.addSipRoutePattern = addSipRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).addSipRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipRoutePatternResponse AxlNetClient.AXLPort35.updateSipRoutePattern(AxlNetClient.updateSipRoutePatternRequest request)
        {
            return base.Channel.updateSipRoutePattern(request);
        }

        public AxlNetClient.StandardResponse updateSipRoutePattern(AxlNetClient.UpdateSipRoutePatternReq updateSipRoutePattern1)
        {
            AxlNetClient.updateSipRoutePatternRequest inValue = new AxlNetClient.updateSipRoutePatternRequest();
            inValue.updateSipRoutePattern = updateSipRoutePattern1;
            AxlNetClient.updateSipRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).updateSipRoutePattern(inValue);
            return retVal.updateSipRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipRoutePatternResponse> AxlNetClient.AXLPort35.updateSipRoutePatternAsync(AxlNetClient.updateSipRoutePatternRequest request)
        {
            return base.Channel.updateSipRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipRoutePatternResponse> updateSipRoutePatternAsync(AxlNetClient.UpdateSipRoutePatternReq updateSipRoutePattern)
        {
            AxlNetClient.updateSipRoutePatternRequest inValue = new AxlNetClient.updateSipRoutePatternRequest();
            inValue.updateSipRoutePattern = updateSipRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).updateSipRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipRoutePatternResponse AxlNetClient.AXLPort35.getSipRoutePattern(AxlNetClient.getSipRoutePatternRequest request)
        {
            return base.Channel.getSipRoutePattern(request);
        }

        public AxlNetClient.GetSipRoutePatternRes getSipRoutePattern(AxlNetClient.GetSipRoutePatternReq getSipRoutePattern1)
        {
            AxlNetClient.getSipRoutePatternRequest inValue = new AxlNetClient.getSipRoutePatternRequest();
            inValue.getSipRoutePattern = getSipRoutePattern1;
            AxlNetClient.getSipRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).getSipRoutePattern(inValue);
            return retVal.getSipRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipRoutePatternResponse> AxlNetClient.AXLPort35.getSipRoutePatternAsync(AxlNetClient.getSipRoutePatternRequest request)
        {
            return base.Channel.getSipRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipRoutePatternResponse> getSipRoutePatternAsync(AxlNetClient.GetSipRoutePatternReq getSipRoutePattern)
        {
            AxlNetClient.getSipRoutePatternRequest inValue = new AxlNetClient.getSipRoutePatternRequest();
            inValue.getSipRoutePattern = getSipRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).getSipRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipRoutePatternResponse AxlNetClient.AXLPort35.removeSipRoutePattern(AxlNetClient.removeSipRoutePatternRequest request)
        {
            return base.Channel.removeSipRoutePattern(request);
        }

        public AxlNetClient.StandardResponse removeSipRoutePattern(AxlNetClient.RemoveSipRoutePatternReq removeSipRoutePattern1)
        {
            AxlNetClient.removeSipRoutePatternRequest inValue = new AxlNetClient.removeSipRoutePatternRequest();
            inValue.removeSipRoutePattern = removeSipRoutePattern1;
            AxlNetClient.removeSipRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).removeSipRoutePattern(inValue);
            return retVal.removeSipRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipRoutePatternResponse> AxlNetClient.AXLPort35.removeSipRoutePatternAsync(AxlNetClient.removeSipRoutePatternRequest request)
        {
            return base.Channel.removeSipRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipRoutePatternResponse> removeSipRoutePatternAsync(AxlNetClient.RemoveSipRoutePatternReq removeSipRoutePattern)
        {
            AxlNetClient.removeSipRoutePatternRequest inValue = new AxlNetClient.removeSipRoutePatternRequest();
            inValue.removeSipRoutePattern = removeSipRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).removeSipRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipRoutePatternResponse AxlNetClient.AXLPort35.listSipRoutePattern(AxlNetClient.listSipRoutePatternRequest request)
        {
            return base.Channel.listSipRoutePattern(request);
        }

        public AxlNetClient.ListSipRoutePatternRes listSipRoutePattern(AxlNetClient.ListSipRoutePatternReq listSipRoutePattern1)
        {
            AxlNetClient.listSipRoutePatternRequest inValue = new AxlNetClient.listSipRoutePatternRequest();
            inValue.listSipRoutePattern = listSipRoutePattern1;
            AxlNetClient.listSipRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).listSipRoutePattern(inValue);
            return retVal.listSipRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipRoutePatternResponse> AxlNetClient.AXLPort35.listSipRoutePatternAsync(AxlNetClient.listSipRoutePatternRequest request)
        {
            return base.Channel.listSipRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipRoutePatternResponse> listSipRoutePatternAsync(AxlNetClient.ListSipRoutePatternReq listSipRoutePattern)
        {
            AxlNetClient.listSipRoutePatternRequest inValue = new AxlNetClient.listSipRoutePatternRequest();
            inValue.listSipRoutePattern = listSipRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).listSipRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addHuntPilotResponse AxlNetClient.AXLPort35.addHuntPilot(AxlNetClient.addHuntPilotRequest request)
        {
            return base.Channel.addHuntPilot(request);
        }

        public AxlNetClient.StandardResponse addHuntPilot(AxlNetClient.AddHuntPilotReq addHuntPilot1)
        {
            AxlNetClient.addHuntPilotRequest inValue = new AxlNetClient.addHuntPilotRequest();
            inValue.addHuntPilot = addHuntPilot1;
            AxlNetClient.addHuntPilotResponse retVal = ((AxlNetClient.AXLPort35)(this)).addHuntPilot(inValue);
            return retVal.addHuntPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addHuntPilotResponse> AxlNetClient.AXLPort35.addHuntPilotAsync(AxlNetClient.addHuntPilotRequest request)
        {
            return base.Channel.addHuntPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHuntPilotResponse> addHuntPilotAsync(AxlNetClient.AddHuntPilotReq addHuntPilot)
        {
            AxlNetClient.addHuntPilotRequest inValue = new AxlNetClient.addHuntPilotRequest();
            inValue.addHuntPilot = addHuntPilot;
            return ((AxlNetClient.AXLPort35)(this)).addHuntPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateHuntPilotResponse AxlNetClient.AXLPort35.updateHuntPilot(AxlNetClient.updateHuntPilotRequest request)
        {
            return base.Channel.updateHuntPilot(request);
        }

        public AxlNetClient.StandardResponse updateHuntPilot(AxlNetClient.UpdateHuntPilotReq updateHuntPilot1)
        {
            AxlNetClient.updateHuntPilotRequest inValue = new AxlNetClient.updateHuntPilotRequest();
            inValue.updateHuntPilot = updateHuntPilot1;
            AxlNetClient.updateHuntPilotResponse retVal = ((AxlNetClient.AXLPort35)(this)).updateHuntPilot(inValue);
            return retVal.updateHuntPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateHuntPilotResponse> AxlNetClient.AXLPort35.updateHuntPilotAsync(AxlNetClient.updateHuntPilotRequest request)
        {
            return base.Channel.updateHuntPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHuntPilotResponse> updateHuntPilotAsync(AxlNetClient.UpdateHuntPilotReq updateHuntPilot)
        {
            AxlNetClient.updateHuntPilotRequest inValue = new AxlNetClient.updateHuntPilotRequest();
            inValue.updateHuntPilot = updateHuntPilot;
            return ((AxlNetClient.AXLPort35)(this)).updateHuntPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getHuntPilotResponse AxlNetClient.AXLPort35.getHuntPilot(AxlNetClient.getHuntPilotRequest request)
        {
            return base.Channel.getHuntPilot(request);
        }

        public AxlNetClient.GetHuntPilotRes getHuntPilot(AxlNetClient.GetHuntPilotReq getHuntPilot1)
        {
            AxlNetClient.getHuntPilotRequest inValue = new AxlNetClient.getHuntPilotRequest();
            inValue.getHuntPilot = getHuntPilot1;
            AxlNetClient.getHuntPilotResponse retVal = ((AxlNetClient.AXLPort35)(this)).getHuntPilot(inValue);
            return retVal.getHuntPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getHuntPilotResponse> AxlNetClient.AXLPort35.getHuntPilotAsync(AxlNetClient.getHuntPilotRequest request)
        {
            return base.Channel.getHuntPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHuntPilotResponse> getHuntPilotAsync(AxlNetClient.GetHuntPilotReq getHuntPilot)
        {
            AxlNetClient.getHuntPilotRequest inValue = new AxlNetClient.getHuntPilotRequest();
            inValue.getHuntPilot = getHuntPilot;
            return ((AxlNetClient.AXLPort35)(this)).getHuntPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeHuntPilotResponse AxlNetClient.AXLPort35.removeHuntPilot(AxlNetClient.removeHuntPilotRequest request)
        {
            return base.Channel.removeHuntPilot(request);
        }

        public AxlNetClient.StandardResponse removeHuntPilot(AxlNetClient.RemoveHuntPilotReq removeHuntPilot1)
        {
            AxlNetClient.removeHuntPilotRequest inValue = new AxlNetClient.removeHuntPilotRequest();
            inValue.removeHuntPilot = removeHuntPilot1;
            AxlNetClient.removeHuntPilotResponse retVal = ((AxlNetClient.AXLPort35)(this)).removeHuntPilot(inValue);
            return retVal.removeHuntPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeHuntPilotResponse> AxlNetClient.AXLPort35.removeHuntPilotAsync(AxlNetClient.removeHuntPilotRequest request)
        {
            return base.Channel.removeHuntPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHuntPilotResponse> removeHuntPilotAsync(AxlNetClient.RemoveHuntPilotReq removeHuntPilot)
        {
            AxlNetClient.removeHuntPilotRequest inValue = new AxlNetClient.removeHuntPilotRequest();
            inValue.removeHuntPilot = removeHuntPilot;
            return ((AxlNetClient.AXLPort35)(this)).removeHuntPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listHuntPilotResponse AxlNetClient.AXLPort35.listHuntPilot(AxlNetClient.listHuntPilotRequest request)
        {
            return base.Channel.listHuntPilot(request);
        }

        public AxlNetClient.ListHuntPilotRes listHuntPilot(AxlNetClient.ListHuntPilotReq listHuntPilot1)
        {
            AxlNetClient.listHuntPilotRequest inValue = new AxlNetClient.listHuntPilotRequest();
            inValue.listHuntPilot = listHuntPilot1;
            AxlNetClient.listHuntPilotResponse retVal = ((AxlNetClient.AXLPort35)(this)).listHuntPilot(inValue);
            return retVal.listHuntPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listHuntPilotResponse> AxlNetClient.AXLPort35.listHuntPilotAsync(AxlNetClient.listHuntPilotRequest request)
        {
            return base.Channel.listHuntPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listHuntPilotResponse> listHuntPilotAsync(AxlNetClient.ListHuntPilotReq listHuntPilot)
        {
            AxlNetClient.listHuntPilotRequest inValue = new AxlNetClient.listHuntPilotRequest();
            inValue.listHuntPilot = listHuntPilot;
            return ((AxlNetClient.AXLPort35)(this)).listHuntPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRoutePatternResponse AxlNetClient.AXLPort35.addRoutePattern(AxlNetClient.addRoutePatternRequest request)
        {
            return base.Channel.addRoutePattern(request);
        }

        public AxlNetClient.StandardResponse addRoutePattern(AxlNetClient.AddRoutePatternReq addRoutePattern1)
        {
            AxlNetClient.addRoutePatternRequest inValue = new AxlNetClient.addRoutePatternRequest();
            inValue.addRoutePattern = addRoutePattern1;
            AxlNetClient.addRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).addRoutePattern(inValue);
            return retVal.addRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRoutePatternResponse> AxlNetClient.AXLPort35.addRoutePatternAsync(AxlNetClient.addRoutePatternRequest request)
        {
            return base.Channel.addRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRoutePatternResponse> addRoutePatternAsync(AxlNetClient.AddRoutePatternReq addRoutePattern)
        {
            AxlNetClient.addRoutePatternRequest inValue = new AxlNetClient.addRoutePatternRequest();
            inValue.addRoutePattern = addRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).addRoutePatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRoutePatternResponse AxlNetClient.AXLPort35.updateRoutePattern(AxlNetClient.updateRoutePatternRequest request)
        {
            return base.Channel.updateRoutePattern(request);
        }

        public AxlNetClient.StandardResponse updateRoutePattern(AxlNetClient.UpdateRoutePatternReq updateRoutePattern1)
        {
            AxlNetClient.updateRoutePatternRequest inValue = new AxlNetClient.updateRoutePatternRequest();
            inValue.updateRoutePattern = updateRoutePattern1;
            AxlNetClient.updateRoutePatternResponse retVal = ((AxlNetClient.AXLPort35)(this)).updateRoutePattern(inValue);
            return retVal.updateRoutePatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRoutePatternResponse> AxlNetClient.AXLPort35.updateRoutePatternAsync(AxlNetClient.updateRoutePatternRequest request)
        {
            return base.Channel.updateRoutePatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRoutePatternResponse> updateRoutePatternAsync(AxlNetClient.UpdateRoutePatternReq updateRoutePattern)
        {
            AxlNetClient.updateRoutePatternRequest inValue = new AxlNetClient.updateRoutePatternRequest();
            inValue.updateRoutePattern = updateRoutePattern;
            return ((AxlNetClient.AXLPort35)(this)).updateRoutePatternAsync(inValue);
        }
    }
}