namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient44 _axlPortClient44;

        private static AXLPortClient44 axlPortClient44 => _axlPortClient44 == null ||
            _axlPortClient44.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient44 = LoadClient44()) : _axlPortClient44;

        private static AXLPortClient44 LoadClient44()
        {
            var client = new AXLPortClient44(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close44;
            OnAbort += Abort44;
            return client;
        }

        private static void Close44(object sender, System.EventArgs e)
        {
            _axlPortClient44.Close();
        }

        private static void Abort44(object sender, System.EventArgs e)
        {
            _axlPortClient44.Abort();
        }

        public AxlNetClient.StandardResponse updateH323Gateway(AxlNetClient.UpdateH323GatewayReq updateH323Gateway1)
        {
            return axlPortClient44.updateH323Gateway(updateH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323GatewayResponse> updateH323GatewayAsync(AxlNetClient.UpdateH323GatewayReq updateH323Gateway)
        {
            return axlPortClient44.updateH323GatewayAsync(updateH323Gateway);
        }

        public AxlNetClient.GetH323GatewayRes getH323Gateway(AxlNetClient.GetH323GatewayReq getH323Gateway1)
        {
            return axlPortClient44.getH323Gateway(getH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323GatewayResponse> getH323GatewayAsync(AxlNetClient.GetH323GatewayReq getH323Gateway)
        {
            return axlPortClient44.getH323GatewayAsync(getH323Gateway);
        }

        public AxlNetClient.StandardResponse removeH323Gateway(AxlNetClient.NameAndGUIDRequest removeH323Gateway1)
        {
            return axlPortClient44.removeH323Gateway(removeH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323GatewayResponse> removeH323GatewayAsync(AxlNetClient.NameAndGUIDRequest removeH323Gateway)
        {
            return axlPortClient44.removeH323GatewayAsync(removeH323Gateway);
        }

        public AxlNetClient.ListH323GatewayRes listH323Gateway(AxlNetClient.ListH323GatewayReq listH323Gateway1)
        {
            return axlPortClient44.listH323Gateway(listH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323GatewayResponse> listH323GatewayAsync(AxlNetClient.ListH323GatewayReq listH323Gateway)
        {
            return axlPortClient44.listH323GatewayAsync(listH323Gateway);
        }

        public AxlNetClient.StandardResponse resetH323Gateway(AxlNetClient.NameAndGUIDRequest resetH323Gateway1)
        {
            return axlPortClient44.resetH323Gateway(resetH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323GatewayResponse> resetH323GatewayAsync(AxlNetClient.NameAndGUIDRequest resetH323Gateway)
        {
            return axlPortClient44.resetH323GatewayAsync(resetH323Gateway);
        }

        public AxlNetClient.StandardResponse restartH323Gateway(AxlNetClient.NameAndGUIDRequest restartH323Gateway1)
        {
            return axlPortClient44.restartH323Gateway(restartH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323GatewayResponse> restartH323GatewayAsync(AxlNetClient.NameAndGUIDRequest restartH323Gateway)
        {
            return axlPortClient44.restartH323GatewayAsync(restartH323Gateway);
        }

        public AxlNetClient.StandardResponse applyH323Gateway(AxlNetClient.NameAndGUIDRequest applyH323Gateway1)
        {
            return axlPortClient44.applyH323Gateway(applyH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyH323GatewayResponse> applyH323GatewayAsync(AxlNetClient.NameAndGUIDRequest applyH323Gateway)
        {
            return axlPortClient44.applyH323GatewayAsync(applyH323Gateway);
        }

        public AxlNetClient.StandardResponse addDeviceProfile(AxlNetClient.AddDeviceProfileReq addDeviceProfile1)
        {
            return axlPortClient44.addDeviceProfile(addDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceProfileResponse> addDeviceProfileAsync(AxlNetClient.AddDeviceProfileReq addDeviceProfile)
        {
            return axlPortClient44.addDeviceProfileAsync(addDeviceProfile);
        }

        public AxlNetClient.StandardResponse updateDeviceProfile(AxlNetClient.UpdateDeviceProfileReq updateDeviceProfile1)
        {
            return axlPortClient44.updateDeviceProfile(updateDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceProfileResponse> updateDeviceProfileAsync(AxlNetClient.UpdateDeviceProfileReq updateDeviceProfile)
        {
            return axlPortClient44.updateDeviceProfileAsync(updateDeviceProfile);
        }

        public AxlNetClient.GetDeviceProfileRes getDeviceProfile(AxlNetClient.GetDeviceProfileReq getDeviceProfile1)
        {
            return axlPortClient44.getDeviceProfile(getDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileResponse> getDeviceProfileAsync(AxlNetClient.GetDeviceProfileReq getDeviceProfile)
        {
            return axlPortClient44.getDeviceProfileAsync(getDeviceProfile);
        }

        public AxlNetClient.StandardResponse removeDeviceProfile(AxlNetClient.NameAndGUIDRequest removeDeviceProfile1)
        {
            return axlPortClient44.removeDeviceProfile(removeDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceProfileResponse> removeDeviceProfileAsync(AxlNetClient.NameAndGUIDRequest removeDeviceProfile)
        {
            return axlPortClient44.removeDeviceProfileAsync(removeDeviceProfile);
        }

        public AxlNetClient.ListDeviceProfileRes listDeviceProfile(AxlNetClient.ListDeviceProfileReq listDeviceProfile1)
        {
            return axlPortClient44.listDeviceProfile(listDeviceProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceProfileResponse> listDeviceProfileAsync(AxlNetClient.ListDeviceProfileReq listDeviceProfile)
        {
            return axlPortClient44.listDeviceProfileAsync(listDeviceProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort44
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateH323GatewayResponse updateH323Gateway(AxlNetClient.updateH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateH323GatewayResponse> updateH323GatewayAsync(AxlNetClient.updateH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getH323GatewayResponse getH323Gateway(AxlNetClient.getH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getH323GatewayResponse> getH323GatewayAsync(AxlNetClient.getH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeH323GatewayResponse removeH323Gateway(AxlNetClient.removeH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeH323GatewayResponse> removeH323GatewayAsync(AxlNetClient.removeH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listH323GatewayResponse listH323Gateway(AxlNetClient.listH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listH323GatewayResponse> listH323GatewayAsync(AxlNetClient.listH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetH323GatewayResponse resetH323Gateway(AxlNetClient.resetH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetH323GatewayResponse> resetH323GatewayAsync(AxlNetClient.resetH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartH323GatewayResponse restartH323Gateway(AxlNetClient.restartH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartH323GatewayResponse> restartH323GatewayAsync(AxlNetClient.restartH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyH323GatewayResponse applyH323Gateway(AxlNetClient.applyH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyH323GatewayResponse> applyH323GatewayAsync(AxlNetClient.applyH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDeviceProfileResponse addDeviceProfile(AxlNetClient.addDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceProfileResponse> addDeviceProfileAsync(AxlNetClient.addDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDeviceProfileResponse updateDeviceProfile(AxlNetClient.updateDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceProfileResponse> updateDeviceProfileAsync(AxlNetClient.updateDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDeviceProfileResponse getDeviceProfile(AxlNetClient.getDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileResponse> getDeviceProfileAsync(AxlNetClient.getDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDeviceProfileResponse removeDeviceProfile(AxlNetClient.removeDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceProfileResponse> removeDeviceProfileAsync(AxlNetClient.removeDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDeviceProfileResponse listDeviceProfile(AxlNetClient.listDeviceProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceProfileResponse> listDeviceProfileAsync(AxlNetClient.listDeviceProfileRequest request);
    }

    public class AXLPortClient44 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort44>, AxlNetClient.AXLPort44
    {
        public AXLPortClient44(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateH323GatewayResponse AxlNetClient.AXLPort44.updateH323Gateway(AxlNetClient.updateH323GatewayRequest request)
        {
            return base.Channel.updateH323Gateway(request);
        }

        public AxlNetClient.StandardResponse updateH323Gateway(AxlNetClient.UpdateH323GatewayReq updateH323Gateway1)
        {
            AxlNetClient.updateH323GatewayRequest inValue = new AxlNetClient.updateH323GatewayRequest();
            inValue.updateH323Gateway = updateH323Gateway1;
            AxlNetClient.updateH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).updateH323Gateway(inValue);
            return retVal.updateH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateH323GatewayResponse> AxlNetClient.AXLPort44.updateH323GatewayAsync(AxlNetClient.updateH323GatewayRequest request)
        {
            return base.Channel.updateH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateH323GatewayResponse> updateH323GatewayAsync(AxlNetClient.UpdateH323GatewayReq updateH323Gateway)
        {
            AxlNetClient.updateH323GatewayRequest inValue = new AxlNetClient.updateH323GatewayRequest();
            inValue.updateH323Gateway = updateH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).updateH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getH323GatewayResponse AxlNetClient.AXLPort44.getH323Gateway(AxlNetClient.getH323GatewayRequest request)
        {
            return base.Channel.getH323Gateway(request);
        }

        public AxlNetClient.GetH323GatewayRes getH323Gateway(AxlNetClient.GetH323GatewayReq getH323Gateway1)
        {
            AxlNetClient.getH323GatewayRequest inValue = new AxlNetClient.getH323GatewayRequest();
            inValue.getH323Gateway = getH323Gateway1;
            AxlNetClient.getH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).getH323Gateway(inValue);
            return retVal.getH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getH323GatewayResponse> AxlNetClient.AXLPort44.getH323GatewayAsync(AxlNetClient.getH323GatewayRequest request)
        {
            return base.Channel.getH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getH323GatewayResponse> getH323GatewayAsync(AxlNetClient.GetH323GatewayReq getH323Gateway)
        {
            AxlNetClient.getH323GatewayRequest inValue = new AxlNetClient.getH323GatewayRequest();
            inValue.getH323Gateway = getH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).getH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeH323GatewayResponse AxlNetClient.AXLPort44.removeH323Gateway(AxlNetClient.removeH323GatewayRequest request)
        {
            return base.Channel.removeH323Gateway(request);
        }

        public AxlNetClient.StandardResponse removeH323Gateway(AxlNetClient.NameAndGUIDRequest removeH323Gateway1)
        {
            AxlNetClient.removeH323GatewayRequest inValue = new AxlNetClient.removeH323GatewayRequest();
            inValue.removeH323Gateway = removeH323Gateway1;
            AxlNetClient.removeH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).removeH323Gateway(inValue);
            return retVal.removeH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeH323GatewayResponse> AxlNetClient.AXLPort44.removeH323GatewayAsync(AxlNetClient.removeH323GatewayRequest request)
        {
            return base.Channel.removeH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeH323GatewayResponse> removeH323GatewayAsync(AxlNetClient.NameAndGUIDRequest removeH323Gateway)
        {
            AxlNetClient.removeH323GatewayRequest inValue = new AxlNetClient.removeH323GatewayRequest();
            inValue.removeH323Gateway = removeH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).removeH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listH323GatewayResponse AxlNetClient.AXLPort44.listH323Gateway(AxlNetClient.listH323GatewayRequest request)
        {
            return base.Channel.listH323Gateway(request);
        }

        public AxlNetClient.ListH323GatewayRes listH323Gateway(AxlNetClient.ListH323GatewayReq listH323Gateway1)
        {
            AxlNetClient.listH323GatewayRequest inValue = new AxlNetClient.listH323GatewayRequest();
            inValue.listH323Gateway = listH323Gateway1;
            AxlNetClient.listH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).listH323Gateway(inValue);
            return retVal.listH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listH323GatewayResponse> AxlNetClient.AXLPort44.listH323GatewayAsync(AxlNetClient.listH323GatewayRequest request)
        {
            return base.Channel.listH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listH323GatewayResponse> listH323GatewayAsync(AxlNetClient.ListH323GatewayReq listH323Gateway)
        {
            AxlNetClient.listH323GatewayRequest inValue = new AxlNetClient.listH323GatewayRequest();
            inValue.listH323Gateway = listH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).listH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetH323GatewayResponse AxlNetClient.AXLPort44.resetH323Gateway(AxlNetClient.resetH323GatewayRequest request)
        {
            return base.Channel.resetH323Gateway(request);
        }

        public AxlNetClient.StandardResponse resetH323Gateway(AxlNetClient.NameAndGUIDRequest resetH323Gateway1)
        {
            AxlNetClient.resetH323GatewayRequest inValue = new AxlNetClient.resetH323GatewayRequest();
            inValue.resetH323Gateway = resetH323Gateway1;
            AxlNetClient.resetH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).resetH323Gateway(inValue);
            return retVal.resetH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetH323GatewayResponse> AxlNetClient.AXLPort44.resetH323GatewayAsync(AxlNetClient.resetH323GatewayRequest request)
        {
            return base.Channel.resetH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetH323GatewayResponse> resetH323GatewayAsync(AxlNetClient.NameAndGUIDRequest resetH323Gateway)
        {
            AxlNetClient.resetH323GatewayRequest inValue = new AxlNetClient.resetH323GatewayRequest();
            inValue.resetH323Gateway = resetH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).resetH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartH323GatewayResponse AxlNetClient.AXLPort44.restartH323Gateway(AxlNetClient.restartH323GatewayRequest request)
        {
            return base.Channel.restartH323Gateway(request);
        }

        public AxlNetClient.StandardResponse restartH323Gateway(AxlNetClient.NameAndGUIDRequest restartH323Gateway1)
        {
            AxlNetClient.restartH323GatewayRequest inValue = new AxlNetClient.restartH323GatewayRequest();
            inValue.restartH323Gateway = restartH323Gateway1;
            AxlNetClient.restartH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).restartH323Gateway(inValue);
            return retVal.restartH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartH323GatewayResponse> AxlNetClient.AXLPort44.restartH323GatewayAsync(AxlNetClient.restartH323GatewayRequest request)
        {
            return base.Channel.restartH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartH323GatewayResponse> restartH323GatewayAsync(AxlNetClient.NameAndGUIDRequest restartH323Gateway)
        {
            AxlNetClient.restartH323GatewayRequest inValue = new AxlNetClient.restartH323GatewayRequest();
            inValue.restartH323Gateway = restartH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).restartH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyH323GatewayResponse AxlNetClient.AXLPort44.applyH323Gateway(AxlNetClient.applyH323GatewayRequest request)
        {
            return base.Channel.applyH323Gateway(request);
        }

        public AxlNetClient.StandardResponse applyH323Gateway(AxlNetClient.NameAndGUIDRequest applyH323Gateway1)
        {
            AxlNetClient.applyH323GatewayRequest inValue = new AxlNetClient.applyH323GatewayRequest();
            inValue.applyH323Gateway = applyH323Gateway1;
            AxlNetClient.applyH323GatewayResponse retVal = ((AxlNetClient.AXLPort44)(this)).applyH323Gateway(inValue);
            return retVal.applyH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyH323GatewayResponse> AxlNetClient.AXLPort44.applyH323GatewayAsync(AxlNetClient.applyH323GatewayRequest request)
        {
            return base.Channel.applyH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyH323GatewayResponse> applyH323GatewayAsync(AxlNetClient.NameAndGUIDRequest applyH323Gateway)
        {
            AxlNetClient.applyH323GatewayRequest inValue = new AxlNetClient.applyH323GatewayRequest();
            inValue.applyH323Gateway = applyH323Gateway;
            return ((AxlNetClient.AXLPort44)(this)).applyH323GatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDeviceProfileResponse AxlNetClient.AXLPort44.addDeviceProfile(AxlNetClient.addDeviceProfileRequest request)
        {
            return base.Channel.addDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse addDeviceProfile(AxlNetClient.AddDeviceProfileReq addDeviceProfile1)
        {
            AxlNetClient.addDeviceProfileRequest inValue = new AxlNetClient.addDeviceProfileRequest();
            inValue.addDeviceProfile = addDeviceProfile1;
            AxlNetClient.addDeviceProfileResponse retVal = ((AxlNetClient.AXLPort44)(this)).addDeviceProfile(inValue);
            return retVal.addDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceProfileResponse> AxlNetClient.AXLPort44.addDeviceProfileAsync(AxlNetClient.addDeviceProfileRequest request)
        {
            return base.Channel.addDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceProfileResponse> addDeviceProfileAsync(AxlNetClient.AddDeviceProfileReq addDeviceProfile)
        {
            AxlNetClient.addDeviceProfileRequest inValue = new AxlNetClient.addDeviceProfileRequest();
            inValue.addDeviceProfile = addDeviceProfile;
            return ((AxlNetClient.AXLPort44)(this)).addDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDeviceProfileResponse AxlNetClient.AXLPort44.updateDeviceProfile(AxlNetClient.updateDeviceProfileRequest request)
        {
            return base.Channel.updateDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse updateDeviceProfile(AxlNetClient.UpdateDeviceProfileReq updateDeviceProfile1)
        {
            AxlNetClient.updateDeviceProfileRequest inValue = new AxlNetClient.updateDeviceProfileRequest();
            inValue.updateDeviceProfile = updateDeviceProfile1;
            AxlNetClient.updateDeviceProfileResponse retVal = ((AxlNetClient.AXLPort44)(this)).updateDeviceProfile(inValue);
            return retVal.updateDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceProfileResponse> AxlNetClient.AXLPort44.updateDeviceProfileAsync(AxlNetClient.updateDeviceProfileRequest request)
        {
            return base.Channel.updateDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceProfileResponse> updateDeviceProfileAsync(AxlNetClient.UpdateDeviceProfileReq updateDeviceProfile)
        {
            AxlNetClient.updateDeviceProfileRequest inValue = new AxlNetClient.updateDeviceProfileRequest();
            inValue.updateDeviceProfile = updateDeviceProfile;
            return ((AxlNetClient.AXLPort44)(this)).updateDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDeviceProfileResponse AxlNetClient.AXLPort44.getDeviceProfile(AxlNetClient.getDeviceProfileRequest request)
        {
            return base.Channel.getDeviceProfile(request);
        }

        public AxlNetClient.GetDeviceProfileRes getDeviceProfile(AxlNetClient.GetDeviceProfileReq getDeviceProfile1)
        {
            AxlNetClient.getDeviceProfileRequest inValue = new AxlNetClient.getDeviceProfileRequest();
            inValue.getDeviceProfile = getDeviceProfile1;
            AxlNetClient.getDeviceProfileResponse retVal = ((AxlNetClient.AXLPort44)(this)).getDeviceProfile(inValue);
            return retVal.getDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileResponse> AxlNetClient.AXLPort44.getDeviceProfileAsync(AxlNetClient.getDeviceProfileRequest request)
        {
            return base.Channel.getDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceProfileResponse> getDeviceProfileAsync(AxlNetClient.GetDeviceProfileReq getDeviceProfile)
        {
            AxlNetClient.getDeviceProfileRequest inValue = new AxlNetClient.getDeviceProfileRequest();
            inValue.getDeviceProfile = getDeviceProfile;
            return ((AxlNetClient.AXLPort44)(this)).getDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDeviceProfileResponse AxlNetClient.AXLPort44.removeDeviceProfile(AxlNetClient.removeDeviceProfileRequest request)
        {
            return base.Channel.removeDeviceProfile(request);
        }

        public AxlNetClient.StandardResponse removeDeviceProfile(AxlNetClient.NameAndGUIDRequest removeDeviceProfile1)
        {
            AxlNetClient.removeDeviceProfileRequest inValue = new AxlNetClient.removeDeviceProfileRequest();
            inValue.removeDeviceProfile = removeDeviceProfile1;
            AxlNetClient.removeDeviceProfileResponse retVal = ((AxlNetClient.AXLPort44)(this)).removeDeviceProfile(inValue);
            return retVal.removeDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceProfileResponse> AxlNetClient.AXLPort44.removeDeviceProfileAsync(AxlNetClient.removeDeviceProfileRequest request)
        {
            return base.Channel.removeDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceProfileResponse> removeDeviceProfileAsync(AxlNetClient.NameAndGUIDRequest removeDeviceProfile)
        {
            AxlNetClient.removeDeviceProfileRequest inValue = new AxlNetClient.removeDeviceProfileRequest();
            inValue.removeDeviceProfile = removeDeviceProfile;
            return ((AxlNetClient.AXLPort44)(this)).removeDeviceProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDeviceProfileResponse AxlNetClient.AXLPort44.listDeviceProfile(AxlNetClient.listDeviceProfileRequest request)
        {
            return base.Channel.listDeviceProfile(request);
        }

        public AxlNetClient.ListDeviceProfileRes listDeviceProfile(AxlNetClient.ListDeviceProfileReq listDeviceProfile1)
        {
            AxlNetClient.listDeviceProfileRequest inValue = new AxlNetClient.listDeviceProfileRequest();
            inValue.listDeviceProfile = listDeviceProfile1;
            AxlNetClient.listDeviceProfileResponse retVal = ((AxlNetClient.AXLPort44)(this)).listDeviceProfile(inValue);
            return retVal.listDeviceProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceProfileResponse> AxlNetClient.AXLPort44.listDeviceProfileAsync(AxlNetClient.listDeviceProfileRequest request)
        {
            return base.Channel.listDeviceProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceProfileResponse> listDeviceProfileAsync(AxlNetClient.ListDeviceProfileReq listDeviceProfile)
        {
            AxlNetClient.listDeviceProfileRequest inValue = new AxlNetClient.listDeviceProfileRequest();
            inValue.listDeviceProfile = listDeviceProfile;
            return ((AxlNetClient.AXLPort44)(this)).listDeviceProfileAsync(inValue);
        }
    }
}