namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient62 _axlPortClient62;

        private static AXLPortClient62 axlPortClient62 => _axlPortClient62 == null ||
            _axlPortClient62.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient62 = LoadClient62()) : _axlPortClient62;

        private static AXLPortClient62 LoadClient62()
        {
            var client = new AXLPortClient62(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close62;
            OnAbort += Abort62;
            return client;
        }

        private static void Close62(object sender, System.EventArgs e)
        {
            _axlPortClient62.Close();
        }

        private static void Abort62(object sender, System.EventArgs e)
        {
            _axlPortClient62.Abort();
        }

        public AxlNetClient.StandardResponse addImeE164Transformation(AxlNetClient.AddImeE164TransformationReq addImeE164Transformation1)
        {
            return axlPortClient62.addImeE164Transformation(addImeE164Transformation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeE164TransformationResponse> addImeE164TransformationAsync(AxlNetClient.AddImeE164TransformationReq addImeE164Transformation)
        {
            return axlPortClient62.addImeE164TransformationAsync(addImeE164Transformation);
        }

        public AxlNetClient.StandardResponse updateImeE164Transformation(AxlNetClient.UpdateImeE164TransformationReq updateImeE164Transformation1)
        {
            return axlPortClient62.updateImeE164Transformation(updateImeE164Transformation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeE164TransformationResponse> updateImeE164TransformationAsync(AxlNetClient.UpdateImeE164TransformationReq updateImeE164Transformation)
        {
            return axlPortClient62.updateImeE164TransformationAsync(updateImeE164Transformation);
        }

        public AxlNetClient.GetImeE164TransformationRes getImeE164Transformation(AxlNetClient.GetImeE164TransformationReq getImeE164Transformation1)
        {
            return axlPortClient62.getImeE164Transformation(getImeE164Transformation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeE164TransformationResponse> getImeE164TransformationAsync(AxlNetClient.GetImeE164TransformationReq getImeE164Transformation)
        {
            return axlPortClient62.getImeE164TransformationAsync(getImeE164Transformation);
        }

        public AxlNetClient.StandardResponse removeImeE164Transformation(AxlNetClient.NameAndGUIDRequest removeImeE164Transformation1)
        {
            return axlPortClient62.removeImeE164Transformation(removeImeE164Transformation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeE164TransformationResponse> removeImeE164TransformationAsync(AxlNetClient.NameAndGUIDRequest removeImeE164Transformation)
        {
            return axlPortClient62.removeImeE164TransformationAsync(removeImeE164Transformation);
        }

        public AxlNetClient.ListImeE164TransformationRes listImeE164Transformation(AxlNetClient.ListImeE164TransformationReq listImeE164Transformation1)
        {
            return axlPortClient62.listImeE164Transformation(listImeE164Transformation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeE164TransformationResponse> listImeE164TransformationAsync(AxlNetClient.ListImeE164TransformationReq listImeE164Transformation)
        {
            return axlPortClient62.listImeE164TransformationAsync(listImeE164Transformation);
        }

        public AxlNetClient.StandardResponse addTransformationProfile(AxlNetClient.AddTransformationProfileReq addTransformationProfile1)
        {
            return axlPortClient62.addTransformationProfile(addTransformationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTransformationProfileResponse> addTransformationProfileAsync(AxlNetClient.AddTransformationProfileReq addTransformationProfile)
        {
            return axlPortClient62.addTransformationProfileAsync(addTransformationProfile);
        }

        public AxlNetClient.StandardResponse updateTransformationProfile(AxlNetClient.UpdateTransformationProfileReq updateTransformationProfile1)
        {
            return axlPortClient62.updateTransformationProfile(updateTransformationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTransformationProfileResponse> updateTransformationProfileAsync(AxlNetClient.UpdateTransformationProfileReq updateTransformationProfile)
        {
            return axlPortClient62.updateTransformationProfileAsync(updateTransformationProfile);
        }

        public AxlNetClient.GetTransformationProfileRes getTransformationProfile(AxlNetClient.GetTransformationProfileReq getTransformationProfile1)
        {
            return axlPortClient62.getTransformationProfile(getTransformationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransformationProfileResponse> getTransformationProfileAsync(AxlNetClient.GetTransformationProfileReq getTransformationProfile)
        {
            return axlPortClient62.getTransformationProfileAsync(getTransformationProfile);
        }

        public AxlNetClient.StandardResponse removeTransformationProfile(AxlNetClient.NameAndGUIDRequest removeTransformationProfile1)
        {
            return axlPortClient62.removeTransformationProfile(removeTransformationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTransformationProfileResponse> removeTransformationProfileAsync(AxlNetClient.NameAndGUIDRequest removeTransformationProfile)
        {
            return axlPortClient62.removeTransformationProfileAsync(removeTransformationProfile);
        }

        public AxlNetClient.ListTransformationProfileRes listTransformationProfile(AxlNetClient.ListTransformationProfileReq listTransformationProfile1)
        {
            return axlPortClient62.listTransformationProfile(listTransformationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTransformationProfileResponse> listTransformationProfileAsync(AxlNetClient.ListTransformationProfileReq listTransformationProfile)
        {
            return axlPortClient62.listTransformationProfileAsync(listTransformationProfile);
        }

        public AxlNetClient.StandardResponse addFallbackProfile(AxlNetClient.AddFallbackProfileReq addFallbackProfile1)
        {
            return axlPortClient62.addFallbackProfile(addFallbackProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFallbackProfileResponse> addFallbackProfileAsync(AxlNetClient.AddFallbackProfileReq addFallbackProfile)
        {
            return axlPortClient62.addFallbackProfileAsync(addFallbackProfile);
        }

        public AxlNetClient.StandardResponse updateFallbackProfile(AxlNetClient.UpdateFallbackProfileReq updateFallbackProfile1)
        {
            return axlPortClient62.updateFallbackProfile(updateFallbackProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFallbackProfileResponse> updateFallbackProfileAsync(AxlNetClient.UpdateFallbackProfileReq updateFallbackProfile)
        {
            return axlPortClient62.updateFallbackProfileAsync(updateFallbackProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort62
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeE164Transformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addImeE164TransformationResponse addImeE164Transformation(AxlNetClient.addImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addImeE164Transformation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addImeE164TransformationResponse> addImeE164TransformationAsync(AxlNetClient.addImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeE164Transformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateImeE164TransformationResponse updateImeE164Transformation(AxlNetClient.updateImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateImeE164Transformation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateImeE164TransformationResponse> updateImeE164TransformationAsync(AxlNetClient.updateImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeE164Transformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getImeE164TransformationResponse getImeE164Transformation(AxlNetClient.getImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getImeE164Transformation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getImeE164TransformationResponse> getImeE164TransformationAsync(AxlNetClient.getImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeE164Transformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeImeE164TransformationResponse removeImeE164Transformation(AxlNetClient.removeImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeImeE164Transformation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeImeE164TransformationResponse> removeImeE164TransformationAsync(AxlNetClient.removeImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeE164Transformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listImeE164TransformationResponse listImeE164Transformation(AxlNetClient.listImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listImeE164Transformation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listImeE164TransformationResponse> listImeE164TransformationAsync(AxlNetClient.listImeE164TransformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTransformationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTransformationProfileResponse addTransformationProfile(AxlNetClient.addTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTransformationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTransformationProfileResponse> addTransformationProfileAsync(AxlNetClient.addTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTransformationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTransformationProfileResponse updateTransformationProfile(AxlNetClient.updateTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTransformationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTransformationProfileResponse> updateTransformationProfileAsync(AxlNetClient.updateTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransformationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTransformationProfileResponse getTransformationProfile(AxlNetClient.getTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransformationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTransformationProfileResponse> getTransformationProfileAsync(AxlNetClient.getTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTransformationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTransformationProfileResponse removeTransformationProfile(AxlNetClient.removeTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTransformationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTransformationProfileResponse> removeTransformationProfileAsync(AxlNetClient.removeTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTransformationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTransformationProfileResponse listTransformationProfile(AxlNetClient.listTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTransformationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTransformationProfileResponse> listTransformationProfileAsync(AxlNetClient.listTransformationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFallbackProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addFallbackProfileResponse addFallbackProfile(AxlNetClient.addFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFallbackProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addFallbackProfileResponse> addFallbackProfileAsync(AxlNetClient.addFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFallbackProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFallbackProfileResponse updateFallbackProfile(AxlNetClient.updateFallbackProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFallbackProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFallbackProfileResponse> updateFallbackProfileAsync(AxlNetClient.updateFallbackProfileRequest request);
    }

    public class AXLPortClient62 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort62>, AxlNetClient.AXLPort62
    {
        public AXLPortClient62(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addImeE164TransformationResponse AxlNetClient.AXLPort62.addImeE164Transformation(AxlNetClient.addImeE164TransformationRequest request)
        {
            return base.Channel.addImeE164Transformation(request);
        }

        public AxlNetClient.StandardResponse addImeE164Transformation(AxlNetClient.AddImeE164TransformationReq addImeE164Transformation1)
        {
            AxlNetClient.addImeE164TransformationRequest inValue = new AxlNetClient.addImeE164TransformationRequest();
            inValue.addImeE164Transformation = addImeE164Transformation1;
            AxlNetClient.addImeE164TransformationResponse retVal = ((AxlNetClient.AXLPort62)(this)).addImeE164Transformation(inValue);
            return retVal.addImeE164TransformationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addImeE164TransformationResponse> AxlNetClient.AXLPort62.addImeE164TransformationAsync(AxlNetClient.addImeE164TransformationRequest request)
        {
            return base.Channel.addImeE164TransformationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addImeE164TransformationResponse> addImeE164TransformationAsync(AxlNetClient.AddImeE164TransformationReq addImeE164Transformation)
        {
            AxlNetClient.addImeE164TransformationRequest inValue = new AxlNetClient.addImeE164TransformationRequest();
            inValue.addImeE164Transformation = addImeE164Transformation;
            return ((AxlNetClient.AXLPort62)(this)).addImeE164TransformationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateImeE164TransformationResponse AxlNetClient.AXLPort62.updateImeE164Transformation(AxlNetClient.updateImeE164TransformationRequest request)
        {
            return base.Channel.updateImeE164Transformation(request);
        }

        public AxlNetClient.StandardResponse updateImeE164Transformation(AxlNetClient.UpdateImeE164TransformationReq updateImeE164Transformation1)
        {
            AxlNetClient.updateImeE164TransformationRequest inValue = new AxlNetClient.updateImeE164TransformationRequest();
            inValue.updateImeE164Transformation = updateImeE164Transformation1;
            AxlNetClient.updateImeE164TransformationResponse retVal = ((AxlNetClient.AXLPort62)(this)).updateImeE164Transformation(inValue);
            return retVal.updateImeE164TransformationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateImeE164TransformationResponse> AxlNetClient.AXLPort62.updateImeE164TransformationAsync(AxlNetClient.updateImeE164TransformationRequest request)
        {
            return base.Channel.updateImeE164TransformationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateImeE164TransformationResponse> updateImeE164TransformationAsync(AxlNetClient.UpdateImeE164TransformationReq updateImeE164Transformation)
        {
            AxlNetClient.updateImeE164TransformationRequest inValue = new AxlNetClient.updateImeE164TransformationRequest();
            inValue.updateImeE164Transformation = updateImeE164Transformation;
            return ((AxlNetClient.AXLPort62)(this)).updateImeE164TransformationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getImeE164TransformationResponse AxlNetClient.AXLPort62.getImeE164Transformation(AxlNetClient.getImeE164TransformationRequest request)
        {
            return base.Channel.getImeE164Transformation(request);
        }

        public AxlNetClient.GetImeE164TransformationRes getImeE164Transformation(AxlNetClient.GetImeE164TransformationReq getImeE164Transformation1)
        {
            AxlNetClient.getImeE164TransformationRequest inValue = new AxlNetClient.getImeE164TransformationRequest();
            inValue.getImeE164Transformation = getImeE164Transformation1;
            AxlNetClient.getImeE164TransformationResponse retVal = ((AxlNetClient.AXLPort62)(this)).getImeE164Transformation(inValue);
            return retVal.getImeE164TransformationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getImeE164TransformationResponse> AxlNetClient.AXLPort62.getImeE164TransformationAsync(AxlNetClient.getImeE164TransformationRequest request)
        {
            return base.Channel.getImeE164TransformationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getImeE164TransformationResponse> getImeE164TransformationAsync(AxlNetClient.GetImeE164TransformationReq getImeE164Transformation)
        {
            AxlNetClient.getImeE164TransformationRequest inValue = new AxlNetClient.getImeE164TransformationRequest();
            inValue.getImeE164Transformation = getImeE164Transformation;
            return ((AxlNetClient.AXLPort62)(this)).getImeE164TransformationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeImeE164TransformationResponse AxlNetClient.AXLPort62.removeImeE164Transformation(AxlNetClient.removeImeE164TransformationRequest request)
        {
            return base.Channel.removeImeE164Transformation(request);
        }

        public AxlNetClient.StandardResponse removeImeE164Transformation(AxlNetClient.NameAndGUIDRequest removeImeE164Transformation1)
        {
            AxlNetClient.removeImeE164TransformationRequest inValue = new AxlNetClient.removeImeE164TransformationRequest();
            inValue.removeImeE164Transformation = removeImeE164Transformation1;
            AxlNetClient.removeImeE164TransformationResponse retVal = ((AxlNetClient.AXLPort62)(this)).removeImeE164Transformation(inValue);
            return retVal.removeImeE164TransformationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeImeE164TransformationResponse> AxlNetClient.AXLPort62.removeImeE164TransformationAsync(AxlNetClient.removeImeE164TransformationRequest request)
        {
            return base.Channel.removeImeE164TransformationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeImeE164TransformationResponse> removeImeE164TransformationAsync(AxlNetClient.NameAndGUIDRequest removeImeE164Transformation)
        {
            AxlNetClient.removeImeE164TransformationRequest inValue = new AxlNetClient.removeImeE164TransformationRequest();
            inValue.removeImeE164Transformation = removeImeE164Transformation;
            return ((AxlNetClient.AXLPort62)(this)).removeImeE164TransformationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listImeE164TransformationResponse AxlNetClient.AXLPort62.listImeE164Transformation(AxlNetClient.listImeE164TransformationRequest request)
        {
            return base.Channel.listImeE164Transformation(request);
        }

        public AxlNetClient.ListImeE164TransformationRes listImeE164Transformation(AxlNetClient.ListImeE164TransformationReq listImeE164Transformation1)
        {
            AxlNetClient.listImeE164TransformationRequest inValue = new AxlNetClient.listImeE164TransformationRequest();
            inValue.listImeE164Transformation = listImeE164Transformation1;
            AxlNetClient.listImeE164TransformationResponse retVal = ((AxlNetClient.AXLPort62)(this)).listImeE164Transformation(inValue);
            return retVal.listImeE164TransformationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listImeE164TransformationResponse> AxlNetClient.AXLPort62.listImeE164TransformationAsync(AxlNetClient.listImeE164TransformationRequest request)
        {
            return base.Channel.listImeE164TransformationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listImeE164TransformationResponse> listImeE164TransformationAsync(AxlNetClient.ListImeE164TransformationReq listImeE164Transformation)
        {
            AxlNetClient.listImeE164TransformationRequest inValue = new AxlNetClient.listImeE164TransformationRequest();
            inValue.listImeE164Transformation = listImeE164Transformation;
            return ((AxlNetClient.AXLPort62)(this)).listImeE164TransformationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTransformationProfileResponse AxlNetClient.AXLPort62.addTransformationProfile(AxlNetClient.addTransformationProfileRequest request)
        {
            return base.Channel.addTransformationProfile(request);
        }

        public AxlNetClient.StandardResponse addTransformationProfile(AxlNetClient.AddTransformationProfileReq addTransformationProfile1)
        {
            AxlNetClient.addTransformationProfileRequest inValue = new AxlNetClient.addTransformationProfileRequest();
            inValue.addTransformationProfile = addTransformationProfile1;
            AxlNetClient.addTransformationProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).addTransformationProfile(inValue);
            return retVal.addTransformationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTransformationProfileResponse> AxlNetClient.AXLPort62.addTransformationProfileAsync(AxlNetClient.addTransformationProfileRequest request)
        {
            return base.Channel.addTransformationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTransformationProfileResponse> addTransformationProfileAsync(AxlNetClient.AddTransformationProfileReq addTransformationProfile)
        {
            AxlNetClient.addTransformationProfileRequest inValue = new AxlNetClient.addTransformationProfileRequest();
            inValue.addTransformationProfile = addTransformationProfile;
            return ((AxlNetClient.AXLPort62)(this)).addTransformationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTransformationProfileResponse AxlNetClient.AXLPort62.updateTransformationProfile(AxlNetClient.updateTransformationProfileRequest request)
        {
            return base.Channel.updateTransformationProfile(request);
        }

        public AxlNetClient.StandardResponse updateTransformationProfile(AxlNetClient.UpdateTransformationProfileReq updateTransformationProfile1)
        {
            AxlNetClient.updateTransformationProfileRequest inValue = new AxlNetClient.updateTransformationProfileRequest();
            inValue.updateTransformationProfile = updateTransformationProfile1;
            AxlNetClient.updateTransformationProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).updateTransformationProfile(inValue);
            return retVal.updateTransformationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTransformationProfileResponse> AxlNetClient.AXLPort62.updateTransformationProfileAsync(AxlNetClient.updateTransformationProfileRequest request)
        {
            return base.Channel.updateTransformationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTransformationProfileResponse> updateTransformationProfileAsync(AxlNetClient.UpdateTransformationProfileReq updateTransformationProfile)
        {
            AxlNetClient.updateTransformationProfileRequest inValue = new AxlNetClient.updateTransformationProfileRequest();
            inValue.updateTransformationProfile = updateTransformationProfile;
            return ((AxlNetClient.AXLPort62)(this)).updateTransformationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTransformationProfileResponse AxlNetClient.AXLPort62.getTransformationProfile(AxlNetClient.getTransformationProfileRequest request)
        {
            return base.Channel.getTransformationProfile(request);
        }

        public AxlNetClient.GetTransformationProfileRes getTransformationProfile(AxlNetClient.GetTransformationProfileReq getTransformationProfile1)
        {
            AxlNetClient.getTransformationProfileRequest inValue = new AxlNetClient.getTransformationProfileRequest();
            inValue.getTransformationProfile = getTransformationProfile1;
            AxlNetClient.getTransformationProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).getTransformationProfile(inValue);
            return retVal.getTransformationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTransformationProfileResponse> AxlNetClient.AXLPort62.getTransformationProfileAsync(AxlNetClient.getTransformationProfileRequest request)
        {
            return base.Channel.getTransformationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransformationProfileResponse> getTransformationProfileAsync(AxlNetClient.GetTransformationProfileReq getTransformationProfile)
        {
            AxlNetClient.getTransformationProfileRequest inValue = new AxlNetClient.getTransformationProfileRequest();
            inValue.getTransformationProfile = getTransformationProfile;
            return ((AxlNetClient.AXLPort62)(this)).getTransformationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTransformationProfileResponse AxlNetClient.AXLPort62.removeTransformationProfile(AxlNetClient.removeTransformationProfileRequest request)
        {
            return base.Channel.removeTransformationProfile(request);
        }

        public AxlNetClient.StandardResponse removeTransformationProfile(AxlNetClient.NameAndGUIDRequest removeTransformationProfile1)
        {
            AxlNetClient.removeTransformationProfileRequest inValue = new AxlNetClient.removeTransformationProfileRequest();
            inValue.removeTransformationProfile = removeTransformationProfile1;
            AxlNetClient.removeTransformationProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).removeTransformationProfile(inValue);
            return retVal.removeTransformationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTransformationProfileResponse> AxlNetClient.AXLPort62.removeTransformationProfileAsync(AxlNetClient.removeTransformationProfileRequest request)
        {
            return base.Channel.removeTransformationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTransformationProfileResponse> removeTransformationProfileAsync(AxlNetClient.NameAndGUIDRequest removeTransformationProfile)
        {
            AxlNetClient.removeTransformationProfileRequest inValue = new AxlNetClient.removeTransformationProfileRequest();
            inValue.removeTransformationProfile = removeTransformationProfile;
            return ((AxlNetClient.AXLPort62)(this)).removeTransformationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTransformationProfileResponse AxlNetClient.AXLPort62.listTransformationProfile(AxlNetClient.listTransformationProfileRequest request)
        {
            return base.Channel.listTransformationProfile(request);
        }

        public AxlNetClient.ListTransformationProfileRes listTransformationProfile(AxlNetClient.ListTransformationProfileReq listTransformationProfile1)
        {
            AxlNetClient.listTransformationProfileRequest inValue = new AxlNetClient.listTransformationProfileRequest();
            inValue.listTransformationProfile = listTransformationProfile1;
            AxlNetClient.listTransformationProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).listTransformationProfile(inValue);
            return retVal.listTransformationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTransformationProfileResponse> AxlNetClient.AXLPort62.listTransformationProfileAsync(AxlNetClient.listTransformationProfileRequest request)
        {
            return base.Channel.listTransformationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTransformationProfileResponse> listTransformationProfileAsync(AxlNetClient.ListTransformationProfileReq listTransformationProfile)
        {
            AxlNetClient.listTransformationProfileRequest inValue = new AxlNetClient.listTransformationProfileRequest();
            inValue.listTransformationProfile = listTransformationProfile;
            return ((AxlNetClient.AXLPort62)(this)).listTransformationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addFallbackProfileResponse AxlNetClient.AXLPort62.addFallbackProfile(AxlNetClient.addFallbackProfileRequest request)
        {
            return base.Channel.addFallbackProfile(request);
        }

        public AxlNetClient.StandardResponse addFallbackProfile(AxlNetClient.AddFallbackProfileReq addFallbackProfile1)
        {
            AxlNetClient.addFallbackProfileRequest inValue = new AxlNetClient.addFallbackProfileRequest();
            inValue.addFallbackProfile = addFallbackProfile1;
            AxlNetClient.addFallbackProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).addFallbackProfile(inValue);
            return retVal.addFallbackProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addFallbackProfileResponse> AxlNetClient.AXLPort62.addFallbackProfileAsync(AxlNetClient.addFallbackProfileRequest request)
        {
            return base.Channel.addFallbackProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFallbackProfileResponse> addFallbackProfileAsync(AxlNetClient.AddFallbackProfileReq addFallbackProfile)
        {
            AxlNetClient.addFallbackProfileRequest inValue = new AxlNetClient.addFallbackProfileRequest();
            inValue.addFallbackProfile = addFallbackProfile;
            return ((AxlNetClient.AXLPort62)(this)).addFallbackProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFallbackProfileResponse AxlNetClient.AXLPort62.updateFallbackProfile(AxlNetClient.updateFallbackProfileRequest request)
        {
            return base.Channel.updateFallbackProfile(request);
        }

        public AxlNetClient.StandardResponse updateFallbackProfile(AxlNetClient.UpdateFallbackProfileReq updateFallbackProfile1)
        {
            AxlNetClient.updateFallbackProfileRequest inValue = new AxlNetClient.updateFallbackProfileRequest();
            inValue.updateFallbackProfile = updateFallbackProfile1;
            AxlNetClient.updateFallbackProfileResponse retVal = ((AxlNetClient.AXLPort62)(this)).updateFallbackProfile(inValue);
            return retVal.updateFallbackProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFallbackProfileResponse> AxlNetClient.AXLPort62.updateFallbackProfileAsync(AxlNetClient.updateFallbackProfileRequest request)
        {
            return base.Channel.updateFallbackProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFallbackProfileResponse> updateFallbackProfileAsync(AxlNetClient.UpdateFallbackProfileReq updateFallbackProfile)
        {
            AxlNetClient.updateFallbackProfileRequest inValue = new AxlNetClient.updateFallbackProfileRequest();
            inValue.updateFallbackProfile = updateFallbackProfile;
            return ((AxlNetClient.AXLPort62)(this)).updateFallbackProfileAsync(inValue);
        }
    }
}