namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient39 _axlPortClient39;

        private static AXLPortClient39 axlPortClient39 => _axlPortClient39 == null ||
            _axlPortClient39.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient39 = LoadClient39()) : _axlPortClient39;

        private static AXLPortClient39 LoadClient39()
        {
            var client = new AXLPortClient39(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close39;
            OnAbort += Abort39;
            return client;
        }

        private static void Close39(object sender, System.EventArgs e)
        {
            _axlPortClient39.Close();
        }

        private static void Abort39(object sender, System.EventArgs e)
        {
            _axlPortClient39.Abort();
        }

        public AxlNetClient.StandardResponse addMtp(AxlNetClient.AddMtpReq addMtp1)
        {
            return axlPortClient39.addMtp(addMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMtpResponse> addMtpAsync(AxlNetClient.AddMtpReq addMtp)
        {
            return axlPortClient39.addMtpAsync(addMtp);
        }

        public AxlNetClient.StandardResponse updateMtp(AxlNetClient.UpdateMtpReq updateMtp1)
        {
            return axlPortClient39.updateMtp(updateMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMtpResponse> updateMtpAsync(AxlNetClient.UpdateMtpReq updateMtp)
        {
            return axlPortClient39.updateMtpAsync(updateMtp);
        }

        public AxlNetClient.GetMtpRes getMtp(AxlNetClient.GetMtpReq getMtp1)
        {
            return axlPortClient39.getMtp(getMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMtpResponse> getMtpAsync(AxlNetClient.GetMtpReq getMtp)
        {
            return axlPortClient39.getMtpAsync(getMtp);
        }

        public AxlNetClient.StandardResponse removeMtp(AxlNetClient.NameAndGUIDRequest removeMtp1)
        {
            return axlPortClient39.removeMtp(removeMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMtpResponse> removeMtpAsync(AxlNetClient.NameAndGUIDRequest removeMtp)
        {
            return axlPortClient39.removeMtpAsync(removeMtp);
        }

        public AxlNetClient.ListMtpRes listMtp(AxlNetClient.ListMtpReq listMtp1)
        {
            return axlPortClient39.listMtp(listMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMtpResponse> listMtpAsync(AxlNetClient.ListMtpReq listMtp)
        {
            return axlPortClient39.listMtpAsync(listMtp);
        }

        public AxlNetClient.StandardResponse resetMtp(AxlNetClient.NameAndGUIDRequest resetMtp1)
        {
            return axlPortClient39.resetMtp(resetMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetMtpResponse> resetMtpAsync(AxlNetClient.NameAndGUIDRequest resetMtp)
        {
            return axlPortClient39.resetMtpAsync(resetMtp);
        }

        public AxlNetClient.StandardResponse restartMtp(AxlNetClient.NameAndGUIDRequest restartMtp1)
        {
            return axlPortClient39.restartMtp(restartMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartMtpResponse> restartMtpAsync(AxlNetClient.NameAndGUIDRequest restartMtp)
        {
            return axlPortClient39.restartMtpAsync(restartMtp);
        }

        public AxlNetClient.StandardResponse applyMtp(AxlNetClient.NameAndGUIDRequest applyMtp1)
        {
            return axlPortClient39.applyMtp(applyMtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyMtpResponse> applyMtpAsync(AxlNetClient.NameAndGUIDRequest applyMtp)
        {
            return axlPortClient39.applyMtpAsync(applyMtp);
        }

        public AxlNetClient.StandardResponse updateFixedMohAudioSource(AxlNetClient.UpdateFixedMohAudioSourceReq updateFixedMohAudioSource1)
        {
            return axlPortClient39.updateFixedMohAudioSource(updateFixedMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFixedMohAudioSourceResponse> updateFixedMohAudioSourceAsync(AxlNetClient.UpdateFixedMohAudioSourceReq updateFixedMohAudioSource)
        {
            return axlPortClient39.updateFixedMohAudioSourceAsync(updateFixedMohAudioSource);
        }

        public AxlNetClient.GetFixedMohAudioSourceRes getFixedMohAudioSource(AxlNetClient.GetFixedMohAudioSourceReq getFixedMohAudioSource1)
        {
            return axlPortClient39.getFixedMohAudioSource(getFixedMohAudioSource1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFixedMohAudioSourceResponse> getFixedMohAudioSourceAsync(AxlNetClient.GetFixedMohAudioSourceReq getFixedMohAudioSource)
        {
            return axlPortClient39.getFixedMohAudioSourceAsync(getFixedMohAudioSource);
        }

        public AxlNetClient.StandardResponse updateAarGroupMatrix(AxlNetClient.UpdateAarGroupMatrixReq updateAarGroupMatrix1)
        {
            return axlPortClient39.updateAarGroupMatrix(updateAarGroupMatrix1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAarGroupMatrixResponse> updateAarGroupMatrixAsync(AxlNetClient.UpdateAarGroupMatrixReq updateAarGroupMatrix)
        {
            return axlPortClient39.updateAarGroupMatrixAsync(updateAarGroupMatrix);
        }

        public AxlNetClient.StandardResponse addRemoteDestinationProfile(AxlNetClient.AddRemoteDestinationProfileReq addRemoteDestinationProfile1)
        {
            return axlPortClient39.addRemoteDestinationProfile(addRemoteDestinationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationProfileResponse> addRemoteDestinationProfileAsync(AxlNetClient.AddRemoteDestinationProfileReq addRemoteDestinationProfile)
        {
            return axlPortClient39.addRemoteDestinationProfileAsync(addRemoteDestinationProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort39
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMtpResponse addMtp(AxlNetClient.addMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMtpResponse> addMtpAsync(AxlNetClient.addMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMtpResponse updateMtp(AxlNetClient.updateMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMtpResponse> updateMtpAsync(AxlNetClient.updateMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMtpResponse getMtp(AxlNetClient.getMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMtpResponse> getMtpAsync(AxlNetClient.getMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMtpResponse removeMtp(AxlNetClient.removeMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMtpResponse> removeMtpAsync(AxlNetClient.removeMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMtpResponse listMtp(AxlNetClient.listMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMtpResponse> listMtpAsync(AxlNetClient.listMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetMtpResponse resetMtp(AxlNetClient.resetMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetMtpResponse> resetMtpAsync(AxlNetClient.resetMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartMtpResponse restartMtp(AxlNetClient.restartMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartMtpResponse> restartMtpAsync(AxlNetClient.restartMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyMtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyMtpResponse applyMtp(AxlNetClient.applyMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyMtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyMtpResponse> applyMtpAsync(AxlNetClient.applyMtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFixedMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFixedMohAudioSourceResponse updateFixedMohAudioSource(AxlNetClient.updateFixedMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFixedMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFixedMohAudioSourceResponse> updateFixedMohAudioSourceAsync(AxlNetClient.updateFixedMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFixedMohAudioSource", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFixedMohAudioSourceResponse getFixedMohAudioSource(AxlNetClient.getFixedMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFixedMohAudioSource", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFixedMohAudioSourceResponse> getFixedMohAudioSourceAsync(AxlNetClient.getFixedMohAudioSourceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAarGroupMatrix", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAarGroupMatrixResponse updateAarGroupMatrix(AxlNetClient.updateAarGroupMatrixRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAarGroupMatrix", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAarGroupMatrixResponse> updateAarGroupMatrixAsync(AxlNetClient.updateAarGroupMatrixRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteDestinationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRemoteDestinationProfileResponse addRemoteDestinationProfile(AxlNetClient.addRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRemoteDestinationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationProfileResponse> addRemoteDestinationProfileAsync(AxlNetClient.addRemoteDestinationProfileRequest request);
    }

    public class AXLPortClient39 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort39>, AxlNetClient.AXLPort39
    {
        public AXLPortClient39(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMtpResponse AxlNetClient.AXLPort39.addMtp(AxlNetClient.addMtpRequest request)
        {
            return base.Channel.addMtp(request);
        }

        public AxlNetClient.StandardResponse addMtp(AxlNetClient.AddMtpReq addMtp1)
        {
            AxlNetClient.addMtpRequest inValue = new AxlNetClient.addMtpRequest();
            inValue.addMtp = addMtp1;
            AxlNetClient.addMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).addMtp(inValue);
            return retVal.addMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMtpResponse> AxlNetClient.AXLPort39.addMtpAsync(AxlNetClient.addMtpRequest request)
        {
            return base.Channel.addMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMtpResponse> addMtpAsync(AxlNetClient.AddMtpReq addMtp)
        {
            AxlNetClient.addMtpRequest inValue = new AxlNetClient.addMtpRequest();
            inValue.addMtp = addMtp;
            return ((AxlNetClient.AXLPort39)(this)).addMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMtpResponse AxlNetClient.AXLPort39.updateMtp(AxlNetClient.updateMtpRequest request)
        {
            return base.Channel.updateMtp(request);
        }

        public AxlNetClient.StandardResponse updateMtp(AxlNetClient.UpdateMtpReq updateMtp1)
        {
            AxlNetClient.updateMtpRequest inValue = new AxlNetClient.updateMtpRequest();
            inValue.updateMtp = updateMtp1;
            AxlNetClient.updateMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).updateMtp(inValue);
            return retVal.updateMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMtpResponse> AxlNetClient.AXLPort39.updateMtpAsync(AxlNetClient.updateMtpRequest request)
        {
            return base.Channel.updateMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMtpResponse> updateMtpAsync(AxlNetClient.UpdateMtpReq updateMtp)
        {
            AxlNetClient.updateMtpRequest inValue = new AxlNetClient.updateMtpRequest();
            inValue.updateMtp = updateMtp;
            return ((AxlNetClient.AXLPort39)(this)).updateMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMtpResponse AxlNetClient.AXLPort39.getMtp(AxlNetClient.getMtpRequest request)
        {
            return base.Channel.getMtp(request);
        }

        public AxlNetClient.GetMtpRes getMtp(AxlNetClient.GetMtpReq getMtp1)
        {
            AxlNetClient.getMtpRequest inValue = new AxlNetClient.getMtpRequest();
            inValue.getMtp = getMtp1;
            AxlNetClient.getMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).getMtp(inValue);
            return retVal.getMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMtpResponse> AxlNetClient.AXLPort39.getMtpAsync(AxlNetClient.getMtpRequest request)
        {
            return base.Channel.getMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMtpResponse> getMtpAsync(AxlNetClient.GetMtpReq getMtp)
        {
            AxlNetClient.getMtpRequest inValue = new AxlNetClient.getMtpRequest();
            inValue.getMtp = getMtp;
            return ((AxlNetClient.AXLPort39)(this)).getMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMtpResponse AxlNetClient.AXLPort39.removeMtp(AxlNetClient.removeMtpRequest request)
        {
            return base.Channel.removeMtp(request);
        }

        public AxlNetClient.StandardResponse removeMtp(AxlNetClient.NameAndGUIDRequest removeMtp1)
        {
            AxlNetClient.removeMtpRequest inValue = new AxlNetClient.removeMtpRequest();
            inValue.removeMtp = removeMtp1;
            AxlNetClient.removeMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).removeMtp(inValue);
            return retVal.removeMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMtpResponse> AxlNetClient.AXLPort39.removeMtpAsync(AxlNetClient.removeMtpRequest request)
        {
            return base.Channel.removeMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMtpResponse> removeMtpAsync(AxlNetClient.NameAndGUIDRequest removeMtp)
        {
            AxlNetClient.removeMtpRequest inValue = new AxlNetClient.removeMtpRequest();
            inValue.removeMtp = removeMtp;
            return ((AxlNetClient.AXLPort39)(this)).removeMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMtpResponse AxlNetClient.AXLPort39.listMtp(AxlNetClient.listMtpRequest request)
        {
            return base.Channel.listMtp(request);
        }

        public AxlNetClient.ListMtpRes listMtp(AxlNetClient.ListMtpReq listMtp1)
        {
            AxlNetClient.listMtpRequest inValue = new AxlNetClient.listMtpRequest();
            inValue.listMtp = listMtp1;
            AxlNetClient.listMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).listMtp(inValue);
            return retVal.listMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMtpResponse> AxlNetClient.AXLPort39.listMtpAsync(AxlNetClient.listMtpRequest request)
        {
            return base.Channel.listMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMtpResponse> listMtpAsync(AxlNetClient.ListMtpReq listMtp)
        {
            AxlNetClient.listMtpRequest inValue = new AxlNetClient.listMtpRequest();
            inValue.listMtp = listMtp;
            return ((AxlNetClient.AXLPort39)(this)).listMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetMtpResponse AxlNetClient.AXLPort39.resetMtp(AxlNetClient.resetMtpRequest request)
        {
            return base.Channel.resetMtp(request);
        }

        public AxlNetClient.StandardResponse resetMtp(AxlNetClient.NameAndGUIDRequest resetMtp1)
        {
            AxlNetClient.resetMtpRequest inValue = new AxlNetClient.resetMtpRequest();
            inValue.resetMtp = resetMtp1;
            AxlNetClient.resetMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).resetMtp(inValue);
            return retVal.resetMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetMtpResponse> AxlNetClient.AXLPort39.resetMtpAsync(AxlNetClient.resetMtpRequest request)
        {
            return base.Channel.resetMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetMtpResponse> resetMtpAsync(AxlNetClient.NameAndGUIDRequest resetMtp)
        {
            AxlNetClient.resetMtpRequest inValue = new AxlNetClient.resetMtpRequest();
            inValue.resetMtp = resetMtp;
            return ((AxlNetClient.AXLPort39)(this)).resetMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartMtpResponse AxlNetClient.AXLPort39.restartMtp(AxlNetClient.restartMtpRequest request)
        {
            return base.Channel.restartMtp(request);
        }

        public AxlNetClient.StandardResponse restartMtp(AxlNetClient.NameAndGUIDRequest restartMtp1)
        {
            AxlNetClient.restartMtpRequest inValue = new AxlNetClient.restartMtpRequest();
            inValue.restartMtp = restartMtp1;
            AxlNetClient.restartMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).restartMtp(inValue);
            return retVal.restartMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartMtpResponse> AxlNetClient.AXLPort39.restartMtpAsync(AxlNetClient.restartMtpRequest request)
        {
            return base.Channel.restartMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartMtpResponse> restartMtpAsync(AxlNetClient.NameAndGUIDRequest restartMtp)
        {
            AxlNetClient.restartMtpRequest inValue = new AxlNetClient.restartMtpRequest();
            inValue.restartMtp = restartMtp;
            return ((AxlNetClient.AXLPort39)(this)).restartMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyMtpResponse AxlNetClient.AXLPort39.applyMtp(AxlNetClient.applyMtpRequest request)
        {
            return base.Channel.applyMtp(request);
        }

        public AxlNetClient.StandardResponse applyMtp(AxlNetClient.NameAndGUIDRequest applyMtp1)
        {
            AxlNetClient.applyMtpRequest inValue = new AxlNetClient.applyMtpRequest();
            inValue.applyMtp = applyMtp1;
            AxlNetClient.applyMtpResponse retVal = ((AxlNetClient.AXLPort39)(this)).applyMtp(inValue);
            return retVal.applyMtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyMtpResponse> AxlNetClient.AXLPort39.applyMtpAsync(AxlNetClient.applyMtpRequest request)
        {
            return base.Channel.applyMtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyMtpResponse> applyMtpAsync(AxlNetClient.NameAndGUIDRequest applyMtp)
        {
            AxlNetClient.applyMtpRequest inValue = new AxlNetClient.applyMtpRequest();
            inValue.applyMtp = applyMtp;
            return ((AxlNetClient.AXLPort39)(this)).applyMtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFixedMohAudioSourceResponse AxlNetClient.AXLPort39.updateFixedMohAudioSource(AxlNetClient.updateFixedMohAudioSourceRequest request)
        {
            return base.Channel.updateFixedMohAudioSource(request);
        }

        public AxlNetClient.StandardResponse updateFixedMohAudioSource(AxlNetClient.UpdateFixedMohAudioSourceReq updateFixedMohAudioSource1)
        {
            AxlNetClient.updateFixedMohAudioSourceRequest inValue = new AxlNetClient.updateFixedMohAudioSourceRequest();
            inValue.updateFixedMohAudioSource = updateFixedMohAudioSource1;
            AxlNetClient.updateFixedMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort39)(this)).updateFixedMohAudioSource(inValue);
            return retVal.updateFixedMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFixedMohAudioSourceResponse> AxlNetClient.AXLPort39.updateFixedMohAudioSourceAsync(AxlNetClient.updateFixedMohAudioSourceRequest request)
        {
            return base.Channel.updateFixedMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFixedMohAudioSourceResponse> updateFixedMohAudioSourceAsync(AxlNetClient.UpdateFixedMohAudioSourceReq updateFixedMohAudioSource)
        {
            AxlNetClient.updateFixedMohAudioSourceRequest inValue = new AxlNetClient.updateFixedMohAudioSourceRequest();
            inValue.updateFixedMohAudioSource = updateFixedMohAudioSource;
            return ((AxlNetClient.AXLPort39)(this)).updateFixedMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFixedMohAudioSourceResponse AxlNetClient.AXLPort39.getFixedMohAudioSource(AxlNetClient.getFixedMohAudioSourceRequest request)
        {
            return base.Channel.getFixedMohAudioSource(request);
        }

        public AxlNetClient.GetFixedMohAudioSourceRes getFixedMohAudioSource(AxlNetClient.GetFixedMohAudioSourceReq getFixedMohAudioSource1)
        {
            AxlNetClient.getFixedMohAudioSourceRequest inValue = new AxlNetClient.getFixedMohAudioSourceRequest();
            inValue.getFixedMohAudioSource = getFixedMohAudioSource1;
            AxlNetClient.getFixedMohAudioSourceResponse retVal = ((AxlNetClient.AXLPort39)(this)).getFixedMohAudioSource(inValue);
            return retVal.getFixedMohAudioSourceResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFixedMohAudioSourceResponse> AxlNetClient.AXLPort39.getFixedMohAudioSourceAsync(AxlNetClient.getFixedMohAudioSourceRequest request)
        {
            return base.Channel.getFixedMohAudioSourceAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFixedMohAudioSourceResponse> getFixedMohAudioSourceAsync(AxlNetClient.GetFixedMohAudioSourceReq getFixedMohAudioSource)
        {
            AxlNetClient.getFixedMohAudioSourceRequest inValue = new AxlNetClient.getFixedMohAudioSourceRequest();
            inValue.getFixedMohAudioSource = getFixedMohAudioSource;
            return ((AxlNetClient.AXLPort39)(this)).getFixedMohAudioSourceAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAarGroupMatrixResponse AxlNetClient.AXLPort39.updateAarGroupMatrix(AxlNetClient.updateAarGroupMatrixRequest request)
        {
            return base.Channel.updateAarGroupMatrix(request);
        }

        public AxlNetClient.StandardResponse updateAarGroupMatrix(AxlNetClient.UpdateAarGroupMatrixReq updateAarGroupMatrix1)
        {
            AxlNetClient.updateAarGroupMatrixRequest inValue = new AxlNetClient.updateAarGroupMatrixRequest();
            inValue.updateAarGroupMatrix = updateAarGroupMatrix1;
            AxlNetClient.updateAarGroupMatrixResponse retVal = ((AxlNetClient.AXLPort39)(this)).updateAarGroupMatrix(inValue);
            return retVal.updateAarGroupMatrixResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAarGroupMatrixResponse> AxlNetClient.AXLPort39.updateAarGroupMatrixAsync(AxlNetClient.updateAarGroupMatrixRequest request)
        {
            return base.Channel.updateAarGroupMatrixAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAarGroupMatrixResponse> updateAarGroupMatrixAsync(AxlNetClient.UpdateAarGroupMatrixReq updateAarGroupMatrix)
        {
            AxlNetClient.updateAarGroupMatrixRequest inValue = new AxlNetClient.updateAarGroupMatrixRequest();
            inValue.updateAarGroupMatrix = updateAarGroupMatrix;
            return ((AxlNetClient.AXLPort39)(this)).updateAarGroupMatrixAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRemoteDestinationProfileResponse AxlNetClient.AXLPort39.addRemoteDestinationProfile(AxlNetClient.addRemoteDestinationProfileRequest request)
        {
            return base.Channel.addRemoteDestinationProfile(request);
        }

        public AxlNetClient.StandardResponse addRemoteDestinationProfile(AxlNetClient.AddRemoteDestinationProfileReq addRemoteDestinationProfile1)
        {
            AxlNetClient.addRemoteDestinationProfileRequest inValue = new AxlNetClient.addRemoteDestinationProfileRequest();
            inValue.addRemoteDestinationProfile = addRemoteDestinationProfile1;
            AxlNetClient.addRemoteDestinationProfileResponse retVal = ((AxlNetClient.AXLPort39)(this)).addRemoteDestinationProfile(inValue);
            return retVal.addRemoteDestinationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationProfileResponse> AxlNetClient.AXLPort39.addRemoteDestinationProfileAsync(AxlNetClient.addRemoteDestinationProfileRequest request)
        {
            return base.Channel.addRemoteDestinationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRemoteDestinationProfileResponse> addRemoteDestinationProfileAsync(AxlNetClient.AddRemoteDestinationProfileReq addRemoteDestinationProfile)
        {
            AxlNetClient.addRemoteDestinationProfileRequest inValue = new AxlNetClient.addRemoteDestinationProfileRequest();
            inValue.addRemoteDestinationProfile = addRemoteDestinationProfile;
            return ((AxlNetClient.AXLPort39)(this)).addRemoteDestinationProfileAsync(inValue);
        }
    }
}