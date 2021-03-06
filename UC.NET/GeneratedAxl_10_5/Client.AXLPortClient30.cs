namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient30 _axlPortClient30;

        private static AXLPortClient30 axlPortClient30 => _axlPortClient30 == null ||
            _axlPortClient30.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient30 = LoadClient30()) : _axlPortClient30;

        private static AXLPortClient30 LoadClient30()
        {
            var client = new AXLPortClient30(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close30;
            OnAbort += Abort30;
            return client;
        }

        private static void Close30(object sender, System.EventArgs e)
        {
            _axlPortClient30.Close();
        }

        private static void Abort30(object sender, System.EventArgs e)
        {
            _axlPortClient30.Abort();
        }

        public AxlNetClient.StandardResponse applyVoiceMailProfile(AxlNetClient.NameAndGUIDRequest applyVoiceMailProfile1)
        {
            return axlPortClient30.applyVoiceMailProfile(applyVoiceMailProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailProfileResponse> applyVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest applyVoiceMailProfile)
        {
            return axlPortClient30.applyVoiceMailProfileAsync(applyVoiceMailProfile);
        }

        public AxlNetClient.StandardResponse addVoiceMailPort(AxlNetClient.AddVoiceMailPortReq addVoiceMailPort1)
        {
            return axlPortClient30.addVoiceMailPort(addVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPortResponse> addVoiceMailPortAsync(AxlNetClient.AddVoiceMailPortReq addVoiceMailPort)
        {
            return axlPortClient30.addVoiceMailPortAsync(addVoiceMailPort);
        }

        public AxlNetClient.StandardResponse updateVoiceMailPort(AxlNetClient.UpdateVoiceMailPortReq updateVoiceMailPort1)
        {
            return axlPortClient30.updateVoiceMailPort(updateVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPortResponse> updateVoiceMailPortAsync(AxlNetClient.UpdateVoiceMailPortReq updateVoiceMailPort)
        {
            return axlPortClient30.updateVoiceMailPortAsync(updateVoiceMailPort);
        }

        public AxlNetClient.GetVoiceMailPortRes getVoiceMailPort(AxlNetClient.GetVoiceMailPortReq getVoiceMailPort1)
        {
            return axlPortClient30.getVoiceMailPort(getVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPortResponse> getVoiceMailPortAsync(AxlNetClient.GetVoiceMailPortReq getVoiceMailPort)
        {
            return axlPortClient30.getVoiceMailPortAsync(getVoiceMailPort);
        }

        public AxlNetClient.StandardResponse removeVoiceMailPort(AxlNetClient.NameAndGUIDRequest removeVoiceMailPort1)
        {
            return axlPortClient30.removeVoiceMailPort(removeVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPortResponse> removeVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest removeVoiceMailPort)
        {
            return axlPortClient30.removeVoiceMailPortAsync(removeVoiceMailPort);
        }

        public AxlNetClient.ListVoiceMailPortRes listVoiceMailPort(AxlNetClient.ListVoiceMailPortReq listVoiceMailPort1)
        {
            return axlPortClient30.listVoiceMailPort(listVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPortResponse> listVoiceMailPortAsync(AxlNetClient.ListVoiceMailPortReq listVoiceMailPort)
        {
            return axlPortClient30.listVoiceMailPortAsync(listVoiceMailPort);
        }

        public AxlNetClient.StandardResponse resetVoiceMailPort(AxlNetClient.NameAndGUIDRequest resetVoiceMailPort1)
        {
            return axlPortClient30.resetVoiceMailPort(resetVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailPortResponse> resetVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest resetVoiceMailPort)
        {
            return axlPortClient30.resetVoiceMailPortAsync(resetVoiceMailPort);
        }

        public AxlNetClient.StandardResponse restartVoiceMailPort(AxlNetClient.NameAndGUIDRequest restartVoiceMailPort1)
        {
            return axlPortClient30.restartVoiceMailPort(restartVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailPortResponse> restartVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest restartVoiceMailPort)
        {
            return axlPortClient30.restartVoiceMailPortAsync(restartVoiceMailPort);
        }

        public AxlNetClient.StandardResponse applyVoiceMailPort(AxlNetClient.NameAndGUIDRequest applyVoiceMailPort1)
        {
            return axlPortClient30.applyVoiceMailPort(applyVoiceMailPort1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailPortResponse> applyVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest applyVoiceMailPort)
        {
            return axlPortClient30.applyVoiceMailPortAsync(applyVoiceMailPort);
        }

        public AxlNetClient.StandardResponse addGatekeeper(AxlNetClient.AddGatekeeperReq addGatekeeper1)
        {
            return axlPortClient30.addGatekeeper(addGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatekeeperResponse> addGatekeeperAsync(AxlNetClient.AddGatekeeperReq addGatekeeper)
        {
            return axlPortClient30.addGatekeeperAsync(addGatekeeper);
        }

        public AxlNetClient.StandardResponse updateGatekeeper(AxlNetClient.UpdateGatekeeperReq updateGatekeeper1)
        {
            return axlPortClient30.updateGatekeeper(updateGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatekeeperResponse> updateGatekeeperAsync(AxlNetClient.UpdateGatekeeperReq updateGatekeeper)
        {
            return axlPortClient30.updateGatekeeperAsync(updateGatekeeper);
        }

        public AxlNetClient.GetGatekeeperRes getGatekeeper(AxlNetClient.GetGatekeeperReq getGatekeeper1)
        {
            return axlPortClient30.getGatekeeper(getGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatekeeperResponse> getGatekeeperAsync(AxlNetClient.GetGatekeeperReq getGatekeeper)
        {
            return axlPortClient30.getGatekeeperAsync(getGatekeeper);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort30
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyVoiceMailProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyVoiceMailProfileResponse applyVoiceMailProfile(AxlNetClient.applyVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyVoiceMailProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailProfileResponse> applyVoiceMailProfileAsync(AxlNetClient.applyVoiceMailProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVoiceMailPortResponse addVoiceMailPort(AxlNetClient.addVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPortResponse> addVoiceMailPortAsync(AxlNetClient.addVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVoiceMailPortResponse updateVoiceMailPort(AxlNetClient.updateVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPortResponse> updateVoiceMailPortAsync(AxlNetClient.updateVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVoiceMailPortResponse getVoiceMailPort(AxlNetClient.getVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPortResponse> getVoiceMailPortAsync(AxlNetClient.getVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVoiceMailPortResponse removeVoiceMailPort(AxlNetClient.removeVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPortResponse> removeVoiceMailPortAsync(AxlNetClient.removeVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVoiceMailPortResponse listVoiceMailPort(AxlNetClient.listVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPortResponse> listVoiceMailPortAsync(AxlNetClient.listVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetVoiceMailPortResponse resetVoiceMailPort(AxlNetClient.resetVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailPortResponse> resetVoiceMailPortAsync(AxlNetClient.resetVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartVoiceMailPortResponse restartVoiceMailPort(AxlNetClient.restartVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailPortResponse> restartVoiceMailPortAsync(AxlNetClient.restartVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyVoiceMailPort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyVoiceMailPortResponse applyVoiceMailPort(AxlNetClient.applyVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyVoiceMailPort", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailPortResponse> applyVoiceMailPortAsync(AxlNetClient.applyVoiceMailPortRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatekeeperResponse addGatekeeper(AxlNetClient.addGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatekeeperResponse> addGatekeeperAsync(AxlNetClient.addGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatekeeperResponse updateGatekeeper(AxlNetClient.updateGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatekeeperResponse> updateGatekeeperAsync(AxlNetClient.updateGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatekeeperResponse getGatekeeper(AxlNetClient.getGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatekeeperResponse> getGatekeeperAsync(AxlNetClient.getGatekeeperRequest request);
    }

    public class AXLPortClient30 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort30>, AxlNetClient.AXLPort30
    {
        public AXLPortClient30(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyVoiceMailProfileResponse AxlNetClient.AXLPort30.applyVoiceMailProfile(AxlNetClient.applyVoiceMailProfileRequest request)
        {
            return base.Channel.applyVoiceMailProfile(request);
        }

        public AxlNetClient.StandardResponse applyVoiceMailProfile(AxlNetClient.NameAndGUIDRequest applyVoiceMailProfile1)
        {
            AxlNetClient.applyVoiceMailProfileRequest inValue = new AxlNetClient.applyVoiceMailProfileRequest();
            inValue.applyVoiceMailProfile = applyVoiceMailProfile1;
            AxlNetClient.applyVoiceMailProfileResponse retVal = ((AxlNetClient.AXLPort30)(this)).applyVoiceMailProfile(inValue);
            return retVal.applyVoiceMailProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailProfileResponse> AxlNetClient.AXLPort30.applyVoiceMailProfileAsync(AxlNetClient.applyVoiceMailProfileRequest request)
        {
            return base.Channel.applyVoiceMailProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailProfileResponse> applyVoiceMailProfileAsync(AxlNetClient.NameAndGUIDRequest applyVoiceMailProfile)
        {
            AxlNetClient.applyVoiceMailProfileRequest inValue = new AxlNetClient.applyVoiceMailProfileRequest();
            inValue.applyVoiceMailProfile = applyVoiceMailProfile;
            return ((AxlNetClient.AXLPort30)(this)).applyVoiceMailProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVoiceMailPortResponse AxlNetClient.AXLPort30.addVoiceMailPort(AxlNetClient.addVoiceMailPortRequest request)
        {
            return base.Channel.addVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse addVoiceMailPort(AxlNetClient.AddVoiceMailPortReq addVoiceMailPort1)
        {
            AxlNetClient.addVoiceMailPortRequest inValue = new AxlNetClient.addVoiceMailPortRequest();
            inValue.addVoiceMailPort = addVoiceMailPort1;
            AxlNetClient.addVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).addVoiceMailPort(inValue);
            return retVal.addVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPortResponse> AxlNetClient.AXLPort30.addVoiceMailPortAsync(AxlNetClient.addVoiceMailPortRequest request)
        {
            return base.Channel.addVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPortResponse> addVoiceMailPortAsync(AxlNetClient.AddVoiceMailPortReq addVoiceMailPort)
        {
            AxlNetClient.addVoiceMailPortRequest inValue = new AxlNetClient.addVoiceMailPortRequest();
            inValue.addVoiceMailPort = addVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).addVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVoiceMailPortResponse AxlNetClient.AXLPort30.updateVoiceMailPort(AxlNetClient.updateVoiceMailPortRequest request)
        {
            return base.Channel.updateVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse updateVoiceMailPort(AxlNetClient.UpdateVoiceMailPortReq updateVoiceMailPort1)
        {
            AxlNetClient.updateVoiceMailPortRequest inValue = new AxlNetClient.updateVoiceMailPortRequest();
            inValue.updateVoiceMailPort = updateVoiceMailPort1;
            AxlNetClient.updateVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).updateVoiceMailPort(inValue);
            return retVal.updateVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPortResponse> AxlNetClient.AXLPort30.updateVoiceMailPortAsync(AxlNetClient.updateVoiceMailPortRequest request)
        {
            return base.Channel.updateVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPortResponse> updateVoiceMailPortAsync(AxlNetClient.UpdateVoiceMailPortReq updateVoiceMailPort)
        {
            AxlNetClient.updateVoiceMailPortRequest inValue = new AxlNetClient.updateVoiceMailPortRequest();
            inValue.updateVoiceMailPort = updateVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).updateVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVoiceMailPortResponse AxlNetClient.AXLPort30.getVoiceMailPort(AxlNetClient.getVoiceMailPortRequest request)
        {
            return base.Channel.getVoiceMailPort(request);
        }

        public AxlNetClient.GetVoiceMailPortRes getVoiceMailPort(AxlNetClient.GetVoiceMailPortReq getVoiceMailPort1)
        {
            AxlNetClient.getVoiceMailPortRequest inValue = new AxlNetClient.getVoiceMailPortRequest();
            inValue.getVoiceMailPort = getVoiceMailPort1;
            AxlNetClient.getVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).getVoiceMailPort(inValue);
            return retVal.getVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPortResponse> AxlNetClient.AXLPort30.getVoiceMailPortAsync(AxlNetClient.getVoiceMailPortRequest request)
        {
            return base.Channel.getVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPortResponse> getVoiceMailPortAsync(AxlNetClient.GetVoiceMailPortReq getVoiceMailPort)
        {
            AxlNetClient.getVoiceMailPortRequest inValue = new AxlNetClient.getVoiceMailPortRequest();
            inValue.getVoiceMailPort = getVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).getVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVoiceMailPortResponse AxlNetClient.AXLPort30.removeVoiceMailPort(AxlNetClient.removeVoiceMailPortRequest request)
        {
            return base.Channel.removeVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse removeVoiceMailPort(AxlNetClient.NameAndGUIDRequest removeVoiceMailPort1)
        {
            AxlNetClient.removeVoiceMailPortRequest inValue = new AxlNetClient.removeVoiceMailPortRequest();
            inValue.removeVoiceMailPort = removeVoiceMailPort1;
            AxlNetClient.removeVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).removeVoiceMailPort(inValue);
            return retVal.removeVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPortResponse> AxlNetClient.AXLPort30.removeVoiceMailPortAsync(AxlNetClient.removeVoiceMailPortRequest request)
        {
            return base.Channel.removeVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPortResponse> removeVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest removeVoiceMailPort)
        {
            AxlNetClient.removeVoiceMailPortRequest inValue = new AxlNetClient.removeVoiceMailPortRequest();
            inValue.removeVoiceMailPort = removeVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).removeVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVoiceMailPortResponse AxlNetClient.AXLPort30.listVoiceMailPort(AxlNetClient.listVoiceMailPortRequest request)
        {
            return base.Channel.listVoiceMailPort(request);
        }

        public AxlNetClient.ListVoiceMailPortRes listVoiceMailPort(AxlNetClient.ListVoiceMailPortReq listVoiceMailPort1)
        {
            AxlNetClient.listVoiceMailPortRequest inValue = new AxlNetClient.listVoiceMailPortRequest();
            inValue.listVoiceMailPort = listVoiceMailPort1;
            AxlNetClient.listVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).listVoiceMailPort(inValue);
            return retVal.listVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPortResponse> AxlNetClient.AXLPort30.listVoiceMailPortAsync(AxlNetClient.listVoiceMailPortRequest request)
        {
            return base.Channel.listVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPortResponse> listVoiceMailPortAsync(AxlNetClient.ListVoiceMailPortReq listVoiceMailPort)
        {
            AxlNetClient.listVoiceMailPortRequest inValue = new AxlNetClient.listVoiceMailPortRequest();
            inValue.listVoiceMailPort = listVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).listVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetVoiceMailPortResponse AxlNetClient.AXLPort30.resetVoiceMailPort(AxlNetClient.resetVoiceMailPortRequest request)
        {
            return base.Channel.resetVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse resetVoiceMailPort(AxlNetClient.NameAndGUIDRequest resetVoiceMailPort1)
        {
            AxlNetClient.resetVoiceMailPortRequest inValue = new AxlNetClient.resetVoiceMailPortRequest();
            inValue.resetVoiceMailPort = resetVoiceMailPort1;
            AxlNetClient.resetVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).resetVoiceMailPort(inValue);
            return retVal.resetVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailPortResponse> AxlNetClient.AXLPort30.resetVoiceMailPortAsync(AxlNetClient.resetVoiceMailPortRequest request)
        {
            return base.Channel.resetVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetVoiceMailPortResponse> resetVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest resetVoiceMailPort)
        {
            AxlNetClient.resetVoiceMailPortRequest inValue = new AxlNetClient.resetVoiceMailPortRequest();
            inValue.resetVoiceMailPort = resetVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).resetVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartVoiceMailPortResponse AxlNetClient.AXLPort30.restartVoiceMailPort(AxlNetClient.restartVoiceMailPortRequest request)
        {
            return base.Channel.restartVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse restartVoiceMailPort(AxlNetClient.NameAndGUIDRequest restartVoiceMailPort1)
        {
            AxlNetClient.restartVoiceMailPortRequest inValue = new AxlNetClient.restartVoiceMailPortRequest();
            inValue.restartVoiceMailPort = restartVoiceMailPort1;
            AxlNetClient.restartVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).restartVoiceMailPort(inValue);
            return retVal.restartVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailPortResponse> AxlNetClient.AXLPort30.restartVoiceMailPortAsync(AxlNetClient.restartVoiceMailPortRequest request)
        {
            return base.Channel.restartVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartVoiceMailPortResponse> restartVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest restartVoiceMailPort)
        {
            AxlNetClient.restartVoiceMailPortRequest inValue = new AxlNetClient.restartVoiceMailPortRequest();
            inValue.restartVoiceMailPort = restartVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).restartVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyVoiceMailPortResponse AxlNetClient.AXLPort30.applyVoiceMailPort(AxlNetClient.applyVoiceMailPortRequest request)
        {
            return base.Channel.applyVoiceMailPort(request);
        }

        public AxlNetClient.StandardResponse applyVoiceMailPort(AxlNetClient.NameAndGUIDRequest applyVoiceMailPort1)
        {
            AxlNetClient.applyVoiceMailPortRequest inValue = new AxlNetClient.applyVoiceMailPortRequest();
            inValue.applyVoiceMailPort = applyVoiceMailPort1;
            AxlNetClient.applyVoiceMailPortResponse retVal = ((AxlNetClient.AXLPort30)(this)).applyVoiceMailPort(inValue);
            return retVal.applyVoiceMailPortResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailPortResponse> AxlNetClient.AXLPort30.applyVoiceMailPortAsync(AxlNetClient.applyVoiceMailPortRequest request)
        {
            return base.Channel.applyVoiceMailPortAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyVoiceMailPortResponse> applyVoiceMailPortAsync(AxlNetClient.NameAndGUIDRequest applyVoiceMailPort)
        {
            AxlNetClient.applyVoiceMailPortRequest inValue = new AxlNetClient.applyVoiceMailPortRequest();
            inValue.applyVoiceMailPort = applyVoiceMailPort;
            return ((AxlNetClient.AXLPort30)(this)).applyVoiceMailPortAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatekeeperResponse AxlNetClient.AXLPort30.addGatekeeper(AxlNetClient.addGatekeeperRequest request)
        {
            return base.Channel.addGatekeeper(request);
        }

        public AxlNetClient.StandardResponse addGatekeeper(AxlNetClient.AddGatekeeperReq addGatekeeper1)
        {
            AxlNetClient.addGatekeeperRequest inValue = new AxlNetClient.addGatekeeperRequest();
            inValue.addGatekeeper = addGatekeeper1;
            AxlNetClient.addGatekeeperResponse retVal = ((AxlNetClient.AXLPort30)(this)).addGatekeeper(inValue);
            return retVal.addGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatekeeperResponse> AxlNetClient.AXLPort30.addGatekeeperAsync(AxlNetClient.addGatekeeperRequest request)
        {
            return base.Channel.addGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatekeeperResponse> addGatekeeperAsync(AxlNetClient.AddGatekeeperReq addGatekeeper)
        {
            AxlNetClient.addGatekeeperRequest inValue = new AxlNetClient.addGatekeeperRequest();
            inValue.addGatekeeper = addGatekeeper;
            return ((AxlNetClient.AXLPort30)(this)).addGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatekeeperResponse AxlNetClient.AXLPort30.updateGatekeeper(AxlNetClient.updateGatekeeperRequest request)
        {
            return base.Channel.updateGatekeeper(request);
        }

        public AxlNetClient.StandardResponse updateGatekeeper(AxlNetClient.UpdateGatekeeperReq updateGatekeeper1)
        {
            AxlNetClient.updateGatekeeperRequest inValue = new AxlNetClient.updateGatekeeperRequest();
            inValue.updateGatekeeper = updateGatekeeper1;
            AxlNetClient.updateGatekeeperResponse retVal = ((AxlNetClient.AXLPort30)(this)).updateGatekeeper(inValue);
            return retVal.updateGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatekeeperResponse> AxlNetClient.AXLPort30.updateGatekeeperAsync(AxlNetClient.updateGatekeeperRequest request)
        {
            return base.Channel.updateGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatekeeperResponse> updateGatekeeperAsync(AxlNetClient.UpdateGatekeeperReq updateGatekeeper)
        {
            AxlNetClient.updateGatekeeperRequest inValue = new AxlNetClient.updateGatekeeperRequest();
            inValue.updateGatekeeper = updateGatekeeper;
            return ((AxlNetClient.AXLPort30)(this)).updateGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatekeeperResponse AxlNetClient.AXLPort30.getGatekeeper(AxlNetClient.getGatekeeperRequest request)
        {
            return base.Channel.getGatekeeper(request);
        }

        public AxlNetClient.GetGatekeeperRes getGatekeeper(AxlNetClient.GetGatekeeperReq getGatekeeper1)
        {
            AxlNetClient.getGatekeeperRequest inValue = new AxlNetClient.getGatekeeperRequest();
            inValue.getGatekeeper = getGatekeeper1;
            AxlNetClient.getGatekeeperResponse retVal = ((AxlNetClient.AXLPort30)(this)).getGatekeeper(inValue);
            return retVal.getGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatekeeperResponse> AxlNetClient.AXLPort30.getGatekeeperAsync(AxlNetClient.getGatekeeperRequest request)
        {
            return base.Channel.getGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatekeeperResponse> getGatekeeperAsync(AxlNetClient.GetGatekeeperReq getGatekeeper)
        {
            AxlNetClient.getGatekeeperRequest inValue = new AxlNetClient.getGatekeeperRequest();
            inValue.getGatekeeper = getGatekeeper;
            return ((AxlNetClient.AXLPort30)(this)).getGatekeeperAsync(inValue);
        }
    }
}