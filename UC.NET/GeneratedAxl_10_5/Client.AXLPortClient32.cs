namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient32 _axlPortClient32;

        private static AXLPortClient32 axlPortClient32 => _axlPortClient32 == null ||
            _axlPortClient32.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient32 = LoadClient32()) : _axlPortClient32;

        private static AXLPortClient32 LoadClient32()
        {
            var client = new AXLPortClient32(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close32;
            OnAbort += Abort32;
            return client;
        }

        private static void Close32(object sender, System.EventArgs e)
        {
            _axlPortClient32.Close();
        }

        private static void Abort32(object sender, System.EventArgs e)
        {
            _axlPortClient32.Abort();
        }

        public AxlNetClient.StandardResponse addCommonPhoneConfig(AxlNetClient.AddCommonPhoneConfigReq addCommonPhoneConfig1)
        {
            return axlPortClient32.addCommonPhoneConfig(addCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCommonPhoneConfigResponse> addCommonPhoneConfigAsync(AxlNetClient.AddCommonPhoneConfigReq addCommonPhoneConfig)
        {
            return axlPortClient32.addCommonPhoneConfigAsync(addCommonPhoneConfig);
        }

        public AxlNetClient.StandardResponse updateCommonPhoneConfig(AxlNetClient.UpdateCommonPhoneConfigReq updateCommonPhoneConfig1)
        {
            return axlPortClient32.updateCommonPhoneConfig(updateCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCommonPhoneConfigResponse> updateCommonPhoneConfigAsync(AxlNetClient.UpdateCommonPhoneConfigReq updateCommonPhoneConfig)
        {
            return axlPortClient32.updateCommonPhoneConfigAsync(updateCommonPhoneConfig);
        }

        public AxlNetClient.GetCommonPhoneConfigRes getCommonPhoneConfig(AxlNetClient.GetCommonPhoneConfigReq getCommonPhoneConfig1)
        {
            return axlPortClient32.getCommonPhoneConfig(getCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCommonPhoneConfigResponse> getCommonPhoneConfigAsync(AxlNetClient.GetCommonPhoneConfigReq getCommonPhoneConfig)
        {
            return axlPortClient32.getCommonPhoneConfigAsync(getCommonPhoneConfig);
        }

        public AxlNetClient.StandardResponse removeCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest removeCommonPhoneConfig1)
        {
            return axlPortClient32.removeCommonPhoneConfig(removeCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCommonPhoneConfigResponse> removeCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest removeCommonPhoneConfig)
        {
            return axlPortClient32.removeCommonPhoneConfigAsync(removeCommonPhoneConfig);
        }

        public AxlNetClient.ListCommonPhoneConfigRes listCommonPhoneConfig(AxlNetClient.ListCommonPhoneConfigReq listCommonPhoneConfig1)
        {
            return axlPortClient32.listCommonPhoneConfig(listCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCommonPhoneConfigResponse> listCommonPhoneConfigAsync(AxlNetClient.ListCommonPhoneConfigReq listCommonPhoneConfig)
        {
            return axlPortClient32.listCommonPhoneConfigAsync(listCommonPhoneConfig);
        }

        public AxlNetClient.StandardResponse resetCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest resetCommonPhoneConfig1)
        {
            return axlPortClient32.resetCommonPhoneConfig(resetCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCommonPhoneConfigResponse> resetCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest resetCommonPhoneConfig)
        {
            return axlPortClient32.resetCommonPhoneConfigAsync(resetCommonPhoneConfig);
        }

        public AxlNetClient.StandardResponse applyCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest applyCommonPhoneConfig1)
        {
            return axlPortClient32.applyCommonPhoneConfig(applyCommonPhoneConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCommonPhoneConfigResponse> applyCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest applyCommonPhoneConfig)
        {
            return axlPortClient32.applyCommonPhoneConfigAsync(applyCommonPhoneConfig);
        }

        public AxlNetClient.StandardResponse addMessageWaiting(AxlNetClient.AddMessageWaitingReq addMessageWaiting1)
        {
            return axlPortClient32.addMessageWaiting(addMessageWaiting1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMessageWaitingResponse> addMessageWaitingAsync(AxlNetClient.AddMessageWaitingReq addMessageWaiting)
        {
            return axlPortClient32.addMessageWaitingAsync(addMessageWaiting);
        }

        public AxlNetClient.StandardResponse updateMessageWaiting(AxlNetClient.UpdateMessageWaitingReq updateMessageWaiting1)
        {
            return axlPortClient32.updateMessageWaiting(updateMessageWaiting1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMessageWaitingResponse> updateMessageWaitingAsync(AxlNetClient.UpdateMessageWaitingReq updateMessageWaiting)
        {
            return axlPortClient32.updateMessageWaitingAsync(updateMessageWaiting);
        }

        public AxlNetClient.GetMessageWaitingRes getMessageWaiting(AxlNetClient.GetMessageWaitingReq getMessageWaiting1)
        {
            return axlPortClient32.getMessageWaiting(getMessageWaiting1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMessageWaitingResponse> getMessageWaitingAsync(AxlNetClient.GetMessageWaitingReq getMessageWaiting)
        {
            return axlPortClient32.getMessageWaitingAsync(getMessageWaiting);
        }

        public AxlNetClient.StandardResponse removeMessageWaiting(AxlNetClient.RemoveMessageWaitingReq removeMessageWaiting1)
        {
            return axlPortClient32.removeMessageWaiting(removeMessageWaiting1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMessageWaitingResponse> removeMessageWaitingAsync(AxlNetClient.RemoveMessageWaitingReq removeMessageWaiting)
        {
            return axlPortClient32.removeMessageWaitingAsync(removeMessageWaiting);
        }

        public AxlNetClient.ListMessageWaitingRes listMessageWaiting(AxlNetClient.ListMessageWaitingReq listMessageWaiting1)
        {
            return axlPortClient32.listMessageWaiting(listMessageWaiting1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMessageWaitingResponse> listMessageWaitingAsync(AxlNetClient.ListMessageWaitingReq listMessageWaiting)
        {
            return axlPortClient32.listMessageWaitingAsync(listMessageWaiting);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort32
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCommonPhoneConfigResponse addCommonPhoneConfig(AxlNetClient.addCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCommonPhoneConfigResponse> addCommonPhoneConfigAsync(AxlNetClient.addCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCommonPhoneConfigResponse updateCommonPhoneConfig(AxlNetClient.updateCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCommonPhoneConfigResponse> updateCommonPhoneConfigAsync(AxlNetClient.updateCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCommonPhoneConfigResponse getCommonPhoneConfig(AxlNetClient.getCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCommonPhoneConfigResponse> getCommonPhoneConfigAsync(AxlNetClient.getCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCommonPhoneConfigResponse removeCommonPhoneConfig(AxlNetClient.removeCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCommonPhoneConfigResponse> removeCommonPhoneConfigAsync(AxlNetClient.removeCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCommonPhoneConfigResponse listCommonPhoneConfig(AxlNetClient.listCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCommonPhoneConfigResponse> listCommonPhoneConfigAsync(AxlNetClient.listCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCommonPhoneConfigResponse resetCommonPhoneConfig(AxlNetClient.resetCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCommonPhoneConfigResponse> resetCommonPhoneConfigAsync(AxlNetClient.resetCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCommonPhoneConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCommonPhoneConfigResponse applyCommonPhoneConfig(AxlNetClient.applyCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCommonPhoneConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCommonPhoneConfigResponse> applyCommonPhoneConfigAsync(AxlNetClient.applyCommonPhoneConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMessageWaiting", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMessageWaitingResponse addMessageWaiting(AxlNetClient.addMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMessageWaiting", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMessageWaitingResponse> addMessageWaitingAsync(AxlNetClient.addMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMessageWaiting", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMessageWaitingResponse updateMessageWaiting(AxlNetClient.updateMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMessageWaiting", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMessageWaitingResponse> updateMessageWaitingAsync(AxlNetClient.updateMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMessageWaiting", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMessageWaitingResponse getMessageWaiting(AxlNetClient.getMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMessageWaiting", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMessageWaitingResponse> getMessageWaitingAsync(AxlNetClient.getMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMessageWaiting", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMessageWaitingResponse removeMessageWaiting(AxlNetClient.removeMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMessageWaiting", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMessageWaitingResponse> removeMessageWaitingAsync(AxlNetClient.removeMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMessageWaiting", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMessageWaitingResponse listMessageWaiting(AxlNetClient.listMessageWaitingRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMessageWaiting", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMessageWaitingResponse> listMessageWaitingAsync(AxlNetClient.listMessageWaitingRequest request);
    }

    public class AXLPortClient32 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort32>, AxlNetClient.AXLPort32
    {
        public AXLPortClient32(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCommonPhoneConfigResponse AxlNetClient.AXLPort32.addCommonPhoneConfig(AxlNetClient.addCommonPhoneConfigRequest request)
        {
            return base.Channel.addCommonPhoneConfig(request);
        }

        public AxlNetClient.StandardResponse addCommonPhoneConfig(AxlNetClient.AddCommonPhoneConfigReq addCommonPhoneConfig1)
        {
            AxlNetClient.addCommonPhoneConfigRequest inValue = new AxlNetClient.addCommonPhoneConfigRequest();
            inValue.addCommonPhoneConfig = addCommonPhoneConfig1;
            AxlNetClient.addCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).addCommonPhoneConfig(inValue);
            return retVal.addCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCommonPhoneConfigResponse> AxlNetClient.AXLPort32.addCommonPhoneConfigAsync(AxlNetClient.addCommonPhoneConfigRequest request)
        {
            return base.Channel.addCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCommonPhoneConfigResponse> addCommonPhoneConfigAsync(AxlNetClient.AddCommonPhoneConfigReq addCommonPhoneConfig)
        {
            AxlNetClient.addCommonPhoneConfigRequest inValue = new AxlNetClient.addCommonPhoneConfigRequest();
            inValue.addCommonPhoneConfig = addCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).addCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCommonPhoneConfigResponse AxlNetClient.AXLPort32.updateCommonPhoneConfig(AxlNetClient.updateCommonPhoneConfigRequest request)
        {
            return base.Channel.updateCommonPhoneConfig(request);
        }

        public AxlNetClient.StandardResponse updateCommonPhoneConfig(AxlNetClient.UpdateCommonPhoneConfigReq updateCommonPhoneConfig1)
        {
            AxlNetClient.updateCommonPhoneConfigRequest inValue = new AxlNetClient.updateCommonPhoneConfigRequest();
            inValue.updateCommonPhoneConfig = updateCommonPhoneConfig1;
            AxlNetClient.updateCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).updateCommonPhoneConfig(inValue);
            return retVal.updateCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCommonPhoneConfigResponse> AxlNetClient.AXLPort32.updateCommonPhoneConfigAsync(AxlNetClient.updateCommonPhoneConfigRequest request)
        {
            return base.Channel.updateCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCommonPhoneConfigResponse> updateCommonPhoneConfigAsync(AxlNetClient.UpdateCommonPhoneConfigReq updateCommonPhoneConfig)
        {
            AxlNetClient.updateCommonPhoneConfigRequest inValue = new AxlNetClient.updateCommonPhoneConfigRequest();
            inValue.updateCommonPhoneConfig = updateCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).updateCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCommonPhoneConfigResponse AxlNetClient.AXLPort32.getCommonPhoneConfig(AxlNetClient.getCommonPhoneConfigRequest request)
        {
            return base.Channel.getCommonPhoneConfig(request);
        }

        public AxlNetClient.GetCommonPhoneConfigRes getCommonPhoneConfig(AxlNetClient.GetCommonPhoneConfigReq getCommonPhoneConfig1)
        {
            AxlNetClient.getCommonPhoneConfigRequest inValue = new AxlNetClient.getCommonPhoneConfigRequest();
            inValue.getCommonPhoneConfig = getCommonPhoneConfig1;
            AxlNetClient.getCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).getCommonPhoneConfig(inValue);
            return retVal.getCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCommonPhoneConfigResponse> AxlNetClient.AXLPort32.getCommonPhoneConfigAsync(AxlNetClient.getCommonPhoneConfigRequest request)
        {
            return base.Channel.getCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCommonPhoneConfigResponse> getCommonPhoneConfigAsync(AxlNetClient.GetCommonPhoneConfigReq getCommonPhoneConfig)
        {
            AxlNetClient.getCommonPhoneConfigRequest inValue = new AxlNetClient.getCommonPhoneConfigRequest();
            inValue.getCommonPhoneConfig = getCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).getCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCommonPhoneConfigResponse AxlNetClient.AXLPort32.removeCommonPhoneConfig(AxlNetClient.removeCommonPhoneConfigRequest request)
        {
            return base.Channel.removeCommonPhoneConfig(request);
        }

        public AxlNetClient.StandardResponse removeCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest removeCommonPhoneConfig1)
        {
            AxlNetClient.removeCommonPhoneConfigRequest inValue = new AxlNetClient.removeCommonPhoneConfigRequest();
            inValue.removeCommonPhoneConfig = removeCommonPhoneConfig1;
            AxlNetClient.removeCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).removeCommonPhoneConfig(inValue);
            return retVal.removeCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCommonPhoneConfigResponse> AxlNetClient.AXLPort32.removeCommonPhoneConfigAsync(AxlNetClient.removeCommonPhoneConfigRequest request)
        {
            return base.Channel.removeCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCommonPhoneConfigResponse> removeCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest removeCommonPhoneConfig)
        {
            AxlNetClient.removeCommonPhoneConfigRequest inValue = new AxlNetClient.removeCommonPhoneConfigRequest();
            inValue.removeCommonPhoneConfig = removeCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).removeCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCommonPhoneConfigResponse AxlNetClient.AXLPort32.listCommonPhoneConfig(AxlNetClient.listCommonPhoneConfigRequest request)
        {
            return base.Channel.listCommonPhoneConfig(request);
        }

        public AxlNetClient.ListCommonPhoneConfigRes listCommonPhoneConfig(AxlNetClient.ListCommonPhoneConfigReq listCommonPhoneConfig1)
        {
            AxlNetClient.listCommonPhoneConfigRequest inValue = new AxlNetClient.listCommonPhoneConfigRequest();
            inValue.listCommonPhoneConfig = listCommonPhoneConfig1;
            AxlNetClient.listCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).listCommonPhoneConfig(inValue);
            return retVal.listCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCommonPhoneConfigResponse> AxlNetClient.AXLPort32.listCommonPhoneConfigAsync(AxlNetClient.listCommonPhoneConfigRequest request)
        {
            return base.Channel.listCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCommonPhoneConfigResponse> listCommonPhoneConfigAsync(AxlNetClient.ListCommonPhoneConfigReq listCommonPhoneConfig)
        {
            AxlNetClient.listCommonPhoneConfigRequest inValue = new AxlNetClient.listCommonPhoneConfigRequest();
            inValue.listCommonPhoneConfig = listCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).listCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCommonPhoneConfigResponse AxlNetClient.AXLPort32.resetCommonPhoneConfig(AxlNetClient.resetCommonPhoneConfigRequest request)
        {
            return base.Channel.resetCommonPhoneConfig(request);
        }

        public AxlNetClient.StandardResponse resetCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest resetCommonPhoneConfig1)
        {
            AxlNetClient.resetCommonPhoneConfigRequest inValue = new AxlNetClient.resetCommonPhoneConfigRequest();
            inValue.resetCommonPhoneConfig = resetCommonPhoneConfig1;
            AxlNetClient.resetCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).resetCommonPhoneConfig(inValue);
            return retVal.resetCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCommonPhoneConfigResponse> AxlNetClient.AXLPort32.resetCommonPhoneConfigAsync(AxlNetClient.resetCommonPhoneConfigRequest request)
        {
            return base.Channel.resetCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCommonPhoneConfigResponse> resetCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest resetCommonPhoneConfig)
        {
            AxlNetClient.resetCommonPhoneConfigRequest inValue = new AxlNetClient.resetCommonPhoneConfigRequest();
            inValue.resetCommonPhoneConfig = resetCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).resetCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCommonPhoneConfigResponse AxlNetClient.AXLPort32.applyCommonPhoneConfig(AxlNetClient.applyCommonPhoneConfigRequest request)
        {
            return base.Channel.applyCommonPhoneConfig(request);
        }

        public AxlNetClient.StandardResponse applyCommonPhoneConfig(AxlNetClient.NameAndGUIDRequest applyCommonPhoneConfig1)
        {
            AxlNetClient.applyCommonPhoneConfigRequest inValue = new AxlNetClient.applyCommonPhoneConfigRequest();
            inValue.applyCommonPhoneConfig = applyCommonPhoneConfig1;
            AxlNetClient.applyCommonPhoneConfigResponse retVal = ((AxlNetClient.AXLPort32)(this)).applyCommonPhoneConfig(inValue);
            return retVal.applyCommonPhoneConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCommonPhoneConfigResponse> AxlNetClient.AXLPort32.applyCommonPhoneConfigAsync(AxlNetClient.applyCommonPhoneConfigRequest request)
        {
            return base.Channel.applyCommonPhoneConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCommonPhoneConfigResponse> applyCommonPhoneConfigAsync(AxlNetClient.NameAndGUIDRequest applyCommonPhoneConfig)
        {
            AxlNetClient.applyCommonPhoneConfigRequest inValue = new AxlNetClient.applyCommonPhoneConfigRequest();
            inValue.applyCommonPhoneConfig = applyCommonPhoneConfig;
            return ((AxlNetClient.AXLPort32)(this)).applyCommonPhoneConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMessageWaitingResponse AxlNetClient.AXLPort32.addMessageWaiting(AxlNetClient.addMessageWaitingRequest request)
        {
            return base.Channel.addMessageWaiting(request);
        }

        public AxlNetClient.StandardResponse addMessageWaiting(AxlNetClient.AddMessageWaitingReq addMessageWaiting1)
        {
            AxlNetClient.addMessageWaitingRequest inValue = new AxlNetClient.addMessageWaitingRequest();
            inValue.addMessageWaiting = addMessageWaiting1;
            AxlNetClient.addMessageWaitingResponse retVal = ((AxlNetClient.AXLPort32)(this)).addMessageWaiting(inValue);
            return retVal.addMessageWaitingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMessageWaitingResponse> AxlNetClient.AXLPort32.addMessageWaitingAsync(AxlNetClient.addMessageWaitingRequest request)
        {
            return base.Channel.addMessageWaitingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMessageWaitingResponse> addMessageWaitingAsync(AxlNetClient.AddMessageWaitingReq addMessageWaiting)
        {
            AxlNetClient.addMessageWaitingRequest inValue = new AxlNetClient.addMessageWaitingRequest();
            inValue.addMessageWaiting = addMessageWaiting;
            return ((AxlNetClient.AXLPort32)(this)).addMessageWaitingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMessageWaitingResponse AxlNetClient.AXLPort32.updateMessageWaiting(AxlNetClient.updateMessageWaitingRequest request)
        {
            return base.Channel.updateMessageWaiting(request);
        }

        public AxlNetClient.StandardResponse updateMessageWaiting(AxlNetClient.UpdateMessageWaitingReq updateMessageWaiting1)
        {
            AxlNetClient.updateMessageWaitingRequest inValue = new AxlNetClient.updateMessageWaitingRequest();
            inValue.updateMessageWaiting = updateMessageWaiting1;
            AxlNetClient.updateMessageWaitingResponse retVal = ((AxlNetClient.AXLPort32)(this)).updateMessageWaiting(inValue);
            return retVal.updateMessageWaitingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMessageWaitingResponse> AxlNetClient.AXLPort32.updateMessageWaitingAsync(AxlNetClient.updateMessageWaitingRequest request)
        {
            return base.Channel.updateMessageWaitingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMessageWaitingResponse> updateMessageWaitingAsync(AxlNetClient.UpdateMessageWaitingReq updateMessageWaiting)
        {
            AxlNetClient.updateMessageWaitingRequest inValue = new AxlNetClient.updateMessageWaitingRequest();
            inValue.updateMessageWaiting = updateMessageWaiting;
            return ((AxlNetClient.AXLPort32)(this)).updateMessageWaitingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMessageWaitingResponse AxlNetClient.AXLPort32.getMessageWaiting(AxlNetClient.getMessageWaitingRequest request)
        {
            return base.Channel.getMessageWaiting(request);
        }

        public AxlNetClient.GetMessageWaitingRes getMessageWaiting(AxlNetClient.GetMessageWaitingReq getMessageWaiting1)
        {
            AxlNetClient.getMessageWaitingRequest inValue = new AxlNetClient.getMessageWaitingRequest();
            inValue.getMessageWaiting = getMessageWaiting1;
            AxlNetClient.getMessageWaitingResponse retVal = ((AxlNetClient.AXLPort32)(this)).getMessageWaiting(inValue);
            return retVal.getMessageWaitingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMessageWaitingResponse> AxlNetClient.AXLPort32.getMessageWaitingAsync(AxlNetClient.getMessageWaitingRequest request)
        {
            return base.Channel.getMessageWaitingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMessageWaitingResponse> getMessageWaitingAsync(AxlNetClient.GetMessageWaitingReq getMessageWaiting)
        {
            AxlNetClient.getMessageWaitingRequest inValue = new AxlNetClient.getMessageWaitingRequest();
            inValue.getMessageWaiting = getMessageWaiting;
            return ((AxlNetClient.AXLPort32)(this)).getMessageWaitingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMessageWaitingResponse AxlNetClient.AXLPort32.removeMessageWaiting(AxlNetClient.removeMessageWaitingRequest request)
        {
            return base.Channel.removeMessageWaiting(request);
        }

        public AxlNetClient.StandardResponse removeMessageWaiting(AxlNetClient.RemoveMessageWaitingReq removeMessageWaiting1)
        {
            AxlNetClient.removeMessageWaitingRequest inValue = new AxlNetClient.removeMessageWaitingRequest();
            inValue.removeMessageWaiting = removeMessageWaiting1;
            AxlNetClient.removeMessageWaitingResponse retVal = ((AxlNetClient.AXLPort32)(this)).removeMessageWaiting(inValue);
            return retVal.removeMessageWaitingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMessageWaitingResponse> AxlNetClient.AXLPort32.removeMessageWaitingAsync(AxlNetClient.removeMessageWaitingRequest request)
        {
            return base.Channel.removeMessageWaitingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMessageWaitingResponse> removeMessageWaitingAsync(AxlNetClient.RemoveMessageWaitingReq removeMessageWaiting)
        {
            AxlNetClient.removeMessageWaitingRequest inValue = new AxlNetClient.removeMessageWaitingRequest();
            inValue.removeMessageWaiting = removeMessageWaiting;
            return ((AxlNetClient.AXLPort32)(this)).removeMessageWaitingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMessageWaitingResponse AxlNetClient.AXLPort32.listMessageWaiting(AxlNetClient.listMessageWaitingRequest request)
        {
            return base.Channel.listMessageWaiting(request);
        }

        public AxlNetClient.ListMessageWaitingRes listMessageWaiting(AxlNetClient.ListMessageWaitingReq listMessageWaiting1)
        {
            AxlNetClient.listMessageWaitingRequest inValue = new AxlNetClient.listMessageWaitingRequest();
            inValue.listMessageWaiting = listMessageWaiting1;
            AxlNetClient.listMessageWaitingResponse retVal = ((AxlNetClient.AXLPort32)(this)).listMessageWaiting(inValue);
            return retVal.listMessageWaitingResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMessageWaitingResponse> AxlNetClient.AXLPort32.listMessageWaitingAsync(AxlNetClient.listMessageWaitingRequest request)
        {
            return base.Channel.listMessageWaitingAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMessageWaitingResponse> listMessageWaitingAsync(AxlNetClient.ListMessageWaitingReq listMessageWaiting)
        {
            AxlNetClient.listMessageWaitingRequest inValue = new AxlNetClient.listMessageWaitingRequest();
            inValue.listMessageWaiting = listMessageWaiting;
            return ((AxlNetClient.AXLPort32)(this)).listMessageWaitingAsync(inValue);
        }
    }
}