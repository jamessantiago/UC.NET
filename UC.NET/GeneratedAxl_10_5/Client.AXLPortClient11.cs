namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient11 _axlPortClient11;

        private static AXLPortClient11 axlPortClient11 => _axlPortClient11 == null ||
            _axlPortClient11.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient11 = LoadClient11()) : _axlPortClient11;

        private static AXLPortClient11 LoadClient11()
        {
            var client = new AXLPortClient11(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close11;
            OnAbort += Abort11;
            return client;
        }

        private static void Close11(object sender, System.EventArgs e)
        {
            _axlPortClient11.Close();
        }

        private static void Abort11(object sender, System.EventArgs e)
        {
            _axlPortClient11.Abort();
        }

        public AxlNetClient.StandardResponse addTranscoder(AxlNetClient.AddTranscoderReq addTranscoder1)
        {
            return axlPortClient11.addTranscoder(addTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTranscoderResponse> addTranscoderAsync(AxlNetClient.AddTranscoderReq addTranscoder)
        {
            return axlPortClient11.addTranscoderAsync(addTranscoder);
        }

        public AxlNetClient.StandardResponse updateTranscoder(AxlNetClient.UpdateTranscoderReq updateTranscoder1)
        {
            return axlPortClient11.updateTranscoder(updateTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTranscoderResponse> updateTranscoderAsync(AxlNetClient.UpdateTranscoderReq updateTranscoder)
        {
            return axlPortClient11.updateTranscoderAsync(updateTranscoder);
        }

        public AxlNetClient.GetTranscoderRes getTranscoder(AxlNetClient.GetTranscoderReq getTranscoder1)
        {
            return axlPortClient11.getTranscoder(getTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTranscoderResponse> getTranscoderAsync(AxlNetClient.GetTranscoderReq getTranscoder)
        {
            return axlPortClient11.getTranscoderAsync(getTranscoder);
        }

        public AxlNetClient.StandardResponse removeTranscoder(AxlNetClient.NameAndGUIDRequest removeTranscoder1)
        {
            return axlPortClient11.removeTranscoder(removeTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTranscoderResponse> removeTranscoderAsync(AxlNetClient.NameAndGUIDRequest removeTranscoder)
        {
            return axlPortClient11.removeTranscoderAsync(removeTranscoder);
        }

        public AxlNetClient.ListTranscoderRes listTranscoder(AxlNetClient.ListTranscoderReq listTranscoder1)
        {
            return axlPortClient11.listTranscoder(listTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTranscoderResponse> listTranscoderAsync(AxlNetClient.ListTranscoderReq listTranscoder)
        {
            return axlPortClient11.listTranscoderAsync(listTranscoder);
        }

        public AxlNetClient.StandardResponse resetTranscoder(AxlNetClient.NameAndGUIDRequest resetTranscoder1)
        {
            return axlPortClient11.resetTranscoder(resetTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetTranscoderResponse> resetTranscoderAsync(AxlNetClient.NameAndGUIDRequest resetTranscoder)
        {
            return axlPortClient11.resetTranscoderAsync(resetTranscoder);
        }

        public AxlNetClient.StandardResponse applyTranscoder(AxlNetClient.NameAndGUIDRequest applyTranscoder1)
        {
            return axlPortClient11.applyTranscoder(applyTranscoder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyTranscoderResponse> applyTranscoderAsync(AxlNetClient.NameAndGUIDRequest applyTranscoder)
        {
            return axlPortClient11.applyTranscoderAsync(applyTranscoder);
        }

        public AxlNetClient.StandardResponse addCommonDeviceConfig(AxlNetClient.AddCommonDeviceConfigReq addCommonDeviceConfig1)
        {
            return axlPortClient11.addCommonDeviceConfig(addCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCommonDeviceConfigResponse> addCommonDeviceConfigAsync(AxlNetClient.AddCommonDeviceConfigReq addCommonDeviceConfig)
        {
            return axlPortClient11.addCommonDeviceConfigAsync(addCommonDeviceConfig);
        }

        public AxlNetClient.StandardResponse updateCommonDeviceConfig(AxlNetClient.UpdateCommonDeviceConfigReq updateCommonDeviceConfig1)
        {
            return axlPortClient11.updateCommonDeviceConfig(updateCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCommonDeviceConfigResponse> updateCommonDeviceConfigAsync(AxlNetClient.UpdateCommonDeviceConfigReq updateCommonDeviceConfig)
        {
            return axlPortClient11.updateCommonDeviceConfigAsync(updateCommonDeviceConfig);
        }

        public AxlNetClient.GetCommonDeviceConfigRes getCommonDeviceConfig(AxlNetClient.GetCommonDeviceConfigReq getCommonDeviceConfig1)
        {
            return axlPortClient11.getCommonDeviceConfig(getCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCommonDeviceConfigResponse> getCommonDeviceConfigAsync(AxlNetClient.GetCommonDeviceConfigReq getCommonDeviceConfig)
        {
            return axlPortClient11.getCommonDeviceConfigAsync(getCommonDeviceConfig);
        }

        public AxlNetClient.StandardResponse removeCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest removeCommonDeviceConfig1)
        {
            return axlPortClient11.removeCommonDeviceConfig(removeCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCommonDeviceConfigResponse> removeCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest removeCommonDeviceConfig)
        {
            return axlPortClient11.removeCommonDeviceConfigAsync(removeCommonDeviceConfig);
        }

        public AxlNetClient.ListCommonDeviceConfigRes listCommonDeviceConfig(AxlNetClient.ListCommonDeviceConfigReq listCommonDeviceConfig1)
        {
            return axlPortClient11.listCommonDeviceConfig(listCommonDeviceConfig1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCommonDeviceConfigResponse> listCommonDeviceConfigAsync(AxlNetClient.ListCommonDeviceConfigReq listCommonDeviceConfig)
        {
            return axlPortClient11.listCommonDeviceConfigAsync(listCommonDeviceConfig);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort11
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTranscoderResponse addTranscoder(AxlNetClient.addTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTranscoderResponse> addTranscoderAsync(AxlNetClient.addTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTranscoderResponse updateTranscoder(AxlNetClient.updateTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTranscoderResponse> updateTranscoderAsync(AxlNetClient.updateTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTranscoderResponse getTranscoder(AxlNetClient.getTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTranscoderResponse> getTranscoderAsync(AxlNetClient.getTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTranscoderResponse removeTranscoder(AxlNetClient.removeTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTranscoderResponse> removeTranscoderAsync(AxlNetClient.removeTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTranscoderResponse listTranscoder(AxlNetClient.listTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTranscoderResponse> listTranscoderAsync(AxlNetClient.listTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetTranscoderResponse resetTranscoder(AxlNetClient.resetTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetTranscoderResponse> resetTranscoderAsync(AxlNetClient.resetTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyTranscoder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyTranscoderResponse applyTranscoder(AxlNetClient.applyTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyTranscoder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyTranscoderResponse> applyTranscoderAsync(AxlNetClient.applyTranscoderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCommonDeviceConfigResponse addCommonDeviceConfig(AxlNetClient.addCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCommonDeviceConfigResponse> addCommonDeviceConfigAsync(AxlNetClient.addCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCommonDeviceConfigResponse updateCommonDeviceConfig(AxlNetClient.updateCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCommonDeviceConfigResponse> updateCommonDeviceConfigAsync(AxlNetClient.updateCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCommonDeviceConfigResponse getCommonDeviceConfig(AxlNetClient.getCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCommonDeviceConfigResponse> getCommonDeviceConfigAsync(AxlNetClient.getCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCommonDeviceConfigResponse removeCommonDeviceConfig(AxlNetClient.removeCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCommonDeviceConfigResponse> removeCommonDeviceConfigAsync(AxlNetClient.removeCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCommonDeviceConfig", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCommonDeviceConfigResponse listCommonDeviceConfig(AxlNetClient.listCommonDeviceConfigRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCommonDeviceConfig", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCommonDeviceConfigResponse> listCommonDeviceConfigAsync(AxlNetClient.listCommonDeviceConfigRequest request);
    }

    public class AXLPortClient11 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort11>, AxlNetClient.AXLPort11
    {
        public AXLPortClient11(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTranscoderResponse AxlNetClient.AXLPort11.addTranscoder(AxlNetClient.addTranscoderRequest request)
        {
            return base.Channel.addTranscoder(request);
        }

        public AxlNetClient.StandardResponse addTranscoder(AxlNetClient.AddTranscoderReq addTranscoder1)
        {
            AxlNetClient.addTranscoderRequest inValue = new AxlNetClient.addTranscoderRequest();
            inValue.addTranscoder = addTranscoder1;
            AxlNetClient.addTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).addTranscoder(inValue);
            return retVal.addTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTranscoderResponse> AxlNetClient.AXLPort11.addTranscoderAsync(AxlNetClient.addTranscoderRequest request)
        {
            return base.Channel.addTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTranscoderResponse> addTranscoderAsync(AxlNetClient.AddTranscoderReq addTranscoder)
        {
            AxlNetClient.addTranscoderRequest inValue = new AxlNetClient.addTranscoderRequest();
            inValue.addTranscoder = addTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).addTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTranscoderResponse AxlNetClient.AXLPort11.updateTranscoder(AxlNetClient.updateTranscoderRequest request)
        {
            return base.Channel.updateTranscoder(request);
        }

        public AxlNetClient.StandardResponse updateTranscoder(AxlNetClient.UpdateTranscoderReq updateTranscoder1)
        {
            AxlNetClient.updateTranscoderRequest inValue = new AxlNetClient.updateTranscoderRequest();
            inValue.updateTranscoder = updateTranscoder1;
            AxlNetClient.updateTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).updateTranscoder(inValue);
            return retVal.updateTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTranscoderResponse> AxlNetClient.AXLPort11.updateTranscoderAsync(AxlNetClient.updateTranscoderRequest request)
        {
            return base.Channel.updateTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTranscoderResponse> updateTranscoderAsync(AxlNetClient.UpdateTranscoderReq updateTranscoder)
        {
            AxlNetClient.updateTranscoderRequest inValue = new AxlNetClient.updateTranscoderRequest();
            inValue.updateTranscoder = updateTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).updateTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTranscoderResponse AxlNetClient.AXLPort11.getTranscoder(AxlNetClient.getTranscoderRequest request)
        {
            return base.Channel.getTranscoder(request);
        }

        public AxlNetClient.GetTranscoderRes getTranscoder(AxlNetClient.GetTranscoderReq getTranscoder1)
        {
            AxlNetClient.getTranscoderRequest inValue = new AxlNetClient.getTranscoderRequest();
            inValue.getTranscoder = getTranscoder1;
            AxlNetClient.getTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).getTranscoder(inValue);
            return retVal.getTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTranscoderResponse> AxlNetClient.AXLPort11.getTranscoderAsync(AxlNetClient.getTranscoderRequest request)
        {
            return base.Channel.getTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTranscoderResponse> getTranscoderAsync(AxlNetClient.GetTranscoderReq getTranscoder)
        {
            AxlNetClient.getTranscoderRequest inValue = new AxlNetClient.getTranscoderRequest();
            inValue.getTranscoder = getTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).getTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTranscoderResponse AxlNetClient.AXLPort11.removeTranscoder(AxlNetClient.removeTranscoderRequest request)
        {
            return base.Channel.removeTranscoder(request);
        }

        public AxlNetClient.StandardResponse removeTranscoder(AxlNetClient.NameAndGUIDRequest removeTranscoder1)
        {
            AxlNetClient.removeTranscoderRequest inValue = new AxlNetClient.removeTranscoderRequest();
            inValue.removeTranscoder = removeTranscoder1;
            AxlNetClient.removeTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).removeTranscoder(inValue);
            return retVal.removeTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTranscoderResponse> AxlNetClient.AXLPort11.removeTranscoderAsync(AxlNetClient.removeTranscoderRequest request)
        {
            return base.Channel.removeTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTranscoderResponse> removeTranscoderAsync(AxlNetClient.NameAndGUIDRequest removeTranscoder)
        {
            AxlNetClient.removeTranscoderRequest inValue = new AxlNetClient.removeTranscoderRequest();
            inValue.removeTranscoder = removeTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).removeTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTranscoderResponse AxlNetClient.AXLPort11.listTranscoder(AxlNetClient.listTranscoderRequest request)
        {
            return base.Channel.listTranscoder(request);
        }

        public AxlNetClient.ListTranscoderRes listTranscoder(AxlNetClient.ListTranscoderReq listTranscoder1)
        {
            AxlNetClient.listTranscoderRequest inValue = new AxlNetClient.listTranscoderRequest();
            inValue.listTranscoder = listTranscoder1;
            AxlNetClient.listTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).listTranscoder(inValue);
            return retVal.listTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTranscoderResponse> AxlNetClient.AXLPort11.listTranscoderAsync(AxlNetClient.listTranscoderRequest request)
        {
            return base.Channel.listTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTranscoderResponse> listTranscoderAsync(AxlNetClient.ListTranscoderReq listTranscoder)
        {
            AxlNetClient.listTranscoderRequest inValue = new AxlNetClient.listTranscoderRequest();
            inValue.listTranscoder = listTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).listTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetTranscoderResponse AxlNetClient.AXLPort11.resetTranscoder(AxlNetClient.resetTranscoderRequest request)
        {
            return base.Channel.resetTranscoder(request);
        }

        public AxlNetClient.StandardResponse resetTranscoder(AxlNetClient.NameAndGUIDRequest resetTranscoder1)
        {
            AxlNetClient.resetTranscoderRequest inValue = new AxlNetClient.resetTranscoderRequest();
            inValue.resetTranscoder = resetTranscoder1;
            AxlNetClient.resetTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).resetTranscoder(inValue);
            return retVal.resetTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetTranscoderResponse> AxlNetClient.AXLPort11.resetTranscoderAsync(AxlNetClient.resetTranscoderRequest request)
        {
            return base.Channel.resetTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetTranscoderResponse> resetTranscoderAsync(AxlNetClient.NameAndGUIDRequest resetTranscoder)
        {
            AxlNetClient.resetTranscoderRequest inValue = new AxlNetClient.resetTranscoderRequest();
            inValue.resetTranscoder = resetTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).resetTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyTranscoderResponse AxlNetClient.AXLPort11.applyTranscoder(AxlNetClient.applyTranscoderRequest request)
        {
            return base.Channel.applyTranscoder(request);
        }

        public AxlNetClient.StandardResponse applyTranscoder(AxlNetClient.NameAndGUIDRequest applyTranscoder1)
        {
            AxlNetClient.applyTranscoderRequest inValue = new AxlNetClient.applyTranscoderRequest();
            inValue.applyTranscoder = applyTranscoder1;
            AxlNetClient.applyTranscoderResponse retVal = ((AxlNetClient.AXLPort11)(this)).applyTranscoder(inValue);
            return retVal.applyTranscoderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyTranscoderResponse> AxlNetClient.AXLPort11.applyTranscoderAsync(AxlNetClient.applyTranscoderRequest request)
        {
            return base.Channel.applyTranscoderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyTranscoderResponse> applyTranscoderAsync(AxlNetClient.NameAndGUIDRequest applyTranscoder)
        {
            AxlNetClient.applyTranscoderRequest inValue = new AxlNetClient.applyTranscoderRequest();
            inValue.applyTranscoder = applyTranscoder;
            return ((AxlNetClient.AXLPort11)(this)).applyTranscoderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCommonDeviceConfigResponse AxlNetClient.AXLPort11.addCommonDeviceConfig(AxlNetClient.addCommonDeviceConfigRequest request)
        {
            return base.Channel.addCommonDeviceConfig(request);
        }

        public AxlNetClient.StandardResponse addCommonDeviceConfig(AxlNetClient.AddCommonDeviceConfigReq addCommonDeviceConfig1)
        {
            AxlNetClient.addCommonDeviceConfigRequest inValue = new AxlNetClient.addCommonDeviceConfigRequest();
            inValue.addCommonDeviceConfig = addCommonDeviceConfig1;
            AxlNetClient.addCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort11)(this)).addCommonDeviceConfig(inValue);
            return retVal.addCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCommonDeviceConfigResponse> AxlNetClient.AXLPort11.addCommonDeviceConfigAsync(AxlNetClient.addCommonDeviceConfigRequest request)
        {
            return base.Channel.addCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCommonDeviceConfigResponse> addCommonDeviceConfigAsync(AxlNetClient.AddCommonDeviceConfigReq addCommonDeviceConfig)
        {
            AxlNetClient.addCommonDeviceConfigRequest inValue = new AxlNetClient.addCommonDeviceConfigRequest();
            inValue.addCommonDeviceConfig = addCommonDeviceConfig;
            return ((AxlNetClient.AXLPort11)(this)).addCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCommonDeviceConfigResponse AxlNetClient.AXLPort11.updateCommonDeviceConfig(AxlNetClient.updateCommonDeviceConfigRequest request)
        {
            return base.Channel.updateCommonDeviceConfig(request);
        }

        public AxlNetClient.StandardResponse updateCommonDeviceConfig(AxlNetClient.UpdateCommonDeviceConfigReq updateCommonDeviceConfig1)
        {
            AxlNetClient.updateCommonDeviceConfigRequest inValue = new AxlNetClient.updateCommonDeviceConfigRequest();
            inValue.updateCommonDeviceConfig = updateCommonDeviceConfig1;
            AxlNetClient.updateCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort11)(this)).updateCommonDeviceConfig(inValue);
            return retVal.updateCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCommonDeviceConfigResponse> AxlNetClient.AXLPort11.updateCommonDeviceConfigAsync(AxlNetClient.updateCommonDeviceConfigRequest request)
        {
            return base.Channel.updateCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCommonDeviceConfigResponse> updateCommonDeviceConfigAsync(AxlNetClient.UpdateCommonDeviceConfigReq updateCommonDeviceConfig)
        {
            AxlNetClient.updateCommonDeviceConfigRequest inValue = new AxlNetClient.updateCommonDeviceConfigRequest();
            inValue.updateCommonDeviceConfig = updateCommonDeviceConfig;
            return ((AxlNetClient.AXLPort11)(this)).updateCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCommonDeviceConfigResponse AxlNetClient.AXLPort11.getCommonDeviceConfig(AxlNetClient.getCommonDeviceConfigRequest request)
        {
            return base.Channel.getCommonDeviceConfig(request);
        }

        public AxlNetClient.GetCommonDeviceConfigRes getCommonDeviceConfig(AxlNetClient.GetCommonDeviceConfigReq getCommonDeviceConfig1)
        {
            AxlNetClient.getCommonDeviceConfigRequest inValue = new AxlNetClient.getCommonDeviceConfigRequest();
            inValue.getCommonDeviceConfig = getCommonDeviceConfig1;
            AxlNetClient.getCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort11)(this)).getCommonDeviceConfig(inValue);
            return retVal.getCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCommonDeviceConfigResponse> AxlNetClient.AXLPort11.getCommonDeviceConfigAsync(AxlNetClient.getCommonDeviceConfigRequest request)
        {
            return base.Channel.getCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCommonDeviceConfigResponse> getCommonDeviceConfigAsync(AxlNetClient.GetCommonDeviceConfigReq getCommonDeviceConfig)
        {
            AxlNetClient.getCommonDeviceConfigRequest inValue = new AxlNetClient.getCommonDeviceConfigRequest();
            inValue.getCommonDeviceConfig = getCommonDeviceConfig;
            return ((AxlNetClient.AXLPort11)(this)).getCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCommonDeviceConfigResponse AxlNetClient.AXLPort11.removeCommonDeviceConfig(AxlNetClient.removeCommonDeviceConfigRequest request)
        {
            return base.Channel.removeCommonDeviceConfig(request);
        }

        public AxlNetClient.StandardResponse removeCommonDeviceConfig(AxlNetClient.NameAndGUIDRequest removeCommonDeviceConfig1)
        {
            AxlNetClient.removeCommonDeviceConfigRequest inValue = new AxlNetClient.removeCommonDeviceConfigRequest();
            inValue.removeCommonDeviceConfig = removeCommonDeviceConfig1;
            AxlNetClient.removeCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort11)(this)).removeCommonDeviceConfig(inValue);
            return retVal.removeCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCommonDeviceConfigResponse> AxlNetClient.AXLPort11.removeCommonDeviceConfigAsync(AxlNetClient.removeCommonDeviceConfigRequest request)
        {
            return base.Channel.removeCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCommonDeviceConfigResponse> removeCommonDeviceConfigAsync(AxlNetClient.NameAndGUIDRequest removeCommonDeviceConfig)
        {
            AxlNetClient.removeCommonDeviceConfigRequest inValue = new AxlNetClient.removeCommonDeviceConfigRequest();
            inValue.removeCommonDeviceConfig = removeCommonDeviceConfig;
            return ((AxlNetClient.AXLPort11)(this)).removeCommonDeviceConfigAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCommonDeviceConfigResponse AxlNetClient.AXLPort11.listCommonDeviceConfig(AxlNetClient.listCommonDeviceConfigRequest request)
        {
            return base.Channel.listCommonDeviceConfig(request);
        }

        public AxlNetClient.ListCommonDeviceConfigRes listCommonDeviceConfig(AxlNetClient.ListCommonDeviceConfigReq listCommonDeviceConfig1)
        {
            AxlNetClient.listCommonDeviceConfigRequest inValue = new AxlNetClient.listCommonDeviceConfigRequest();
            inValue.listCommonDeviceConfig = listCommonDeviceConfig1;
            AxlNetClient.listCommonDeviceConfigResponse retVal = ((AxlNetClient.AXLPort11)(this)).listCommonDeviceConfig(inValue);
            return retVal.listCommonDeviceConfigResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCommonDeviceConfigResponse> AxlNetClient.AXLPort11.listCommonDeviceConfigAsync(AxlNetClient.listCommonDeviceConfigRequest request)
        {
            return base.Channel.listCommonDeviceConfigAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCommonDeviceConfigResponse> listCommonDeviceConfigAsync(AxlNetClient.ListCommonDeviceConfigReq listCommonDeviceConfig)
        {
            AxlNetClient.listCommonDeviceConfigRequest inValue = new AxlNetClient.listCommonDeviceConfigRequest();
            inValue.listCommonDeviceConfig = listCommonDeviceConfig;
            return ((AxlNetClient.AXLPort11)(this)).listCommonDeviceConfigAsync(inValue);
        }
    }
}