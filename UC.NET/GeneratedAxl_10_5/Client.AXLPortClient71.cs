namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient71 _axlPortClient71;

        private static AXLPortClient71 axlPortClient71 => _axlPortClient71 == null ||
            _axlPortClient71.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient71 = LoadClient71()) : _axlPortClient71;

        private static AXLPortClient71 LoadClient71()
        {
            var client = new AXLPortClient71(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close71;
            OnAbort += Abort71;
            return client;
        }

        private static void Close71(object sender, System.EventArgs e)
        {
            _axlPortClient71.Close();
        }

        private static void Abort71(object sender, System.EventArgs e)
        {
            _axlPortClient71.Abort();
        }

        public AxlNetClient.StandardResponse updateSdpTransparencyProfile(AxlNetClient.UpdateSdpTransparencyProfileReq updateSdpTransparencyProfile1)
        {
            return axlPortClient71.updateSdpTransparencyProfile(updateSdpTransparencyProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSdpTransparencyProfileResponse> updateSdpTransparencyProfileAsync(AxlNetClient.UpdateSdpTransparencyProfileReq updateSdpTransparencyProfile)
        {
            return axlPortClient71.updateSdpTransparencyProfileAsync(updateSdpTransparencyProfile);
        }

        public AxlNetClient.GetSdpTransparencyProfileRes getSdpTransparencyProfile(AxlNetClient.GetSdpTransparencyProfileReq getSdpTransparencyProfile1)
        {
            return axlPortClient71.getSdpTransparencyProfile(getSdpTransparencyProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSdpTransparencyProfileResponse> getSdpTransparencyProfileAsync(AxlNetClient.GetSdpTransparencyProfileReq getSdpTransparencyProfile)
        {
            return axlPortClient71.getSdpTransparencyProfileAsync(getSdpTransparencyProfile);
        }

        public AxlNetClient.StandardResponse removeSdpTransparencyProfile(AxlNetClient.NameAndGUIDRequest removeSdpTransparencyProfile1)
        {
            return axlPortClient71.removeSdpTransparencyProfile(removeSdpTransparencyProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSdpTransparencyProfileResponse> removeSdpTransparencyProfileAsync(AxlNetClient.NameAndGUIDRequest removeSdpTransparencyProfile)
        {
            return axlPortClient71.removeSdpTransparencyProfileAsync(removeSdpTransparencyProfile);
        }

        public AxlNetClient.ListSdpTransparencyProfileRes listSdpTransparencyProfile(AxlNetClient.ListSdpTransparencyProfileReq listSdpTransparencyProfile1)
        {
            return axlPortClient71.listSdpTransparencyProfile(listSdpTransparencyProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSdpTransparencyProfileResponse> listSdpTransparencyProfileAsync(AxlNetClient.ListSdpTransparencyProfileReq listSdpTransparencyProfile)
        {
            return axlPortClient71.listSdpTransparencyProfileAsync(listSdpTransparencyProfile);
        }

        public AxlNetClient.StandardResponse addFeatureGroupTemplate(AxlNetClient.AddFeatureGroupTemplateReq addFeatureGroupTemplate1)
        {
            return axlPortClient71.addFeatureGroupTemplate(addFeatureGroupTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFeatureGroupTemplateResponse> addFeatureGroupTemplateAsync(AxlNetClient.AddFeatureGroupTemplateReq addFeatureGroupTemplate)
        {
            return axlPortClient71.addFeatureGroupTemplateAsync(addFeatureGroupTemplate);
        }

        public AxlNetClient.StandardResponse updateFeatureGroupTemplate(AxlNetClient.UpdateFeatureGroupTemplateReq updateFeatureGroupTemplate1)
        {
            return axlPortClient71.updateFeatureGroupTemplate(updateFeatureGroupTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFeatureGroupTemplateResponse> updateFeatureGroupTemplateAsync(AxlNetClient.UpdateFeatureGroupTemplateReq updateFeatureGroupTemplate)
        {
            return axlPortClient71.updateFeatureGroupTemplateAsync(updateFeatureGroupTemplate);
        }

        public AxlNetClient.GetFeatureGroupTemplateRes getFeatureGroupTemplate(AxlNetClient.GetFeatureGroupTemplateReq getFeatureGroupTemplate1)
        {
            return axlPortClient71.getFeatureGroupTemplate(getFeatureGroupTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFeatureGroupTemplateResponse> getFeatureGroupTemplateAsync(AxlNetClient.GetFeatureGroupTemplateReq getFeatureGroupTemplate)
        {
            return axlPortClient71.getFeatureGroupTemplateAsync(getFeatureGroupTemplate);
        }

        public AxlNetClient.StandardResponse removeFeatureGroupTemplate(AxlNetClient.NameAndGUIDRequest removeFeatureGroupTemplate1)
        {
            return axlPortClient71.removeFeatureGroupTemplate(removeFeatureGroupTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFeatureGroupTemplateResponse> removeFeatureGroupTemplateAsync(AxlNetClient.NameAndGUIDRequest removeFeatureGroupTemplate)
        {
            return axlPortClient71.removeFeatureGroupTemplateAsync(removeFeatureGroupTemplate);
        }

        public AxlNetClient.ListFeatureGroupTemplateRes listFeatureGroupTemplate(AxlNetClient.ListFeatureGroupTemplateReq listFeatureGroupTemplate1)
        {
            return axlPortClient71.listFeatureGroupTemplate(listFeatureGroupTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFeatureGroupTemplateResponse> listFeatureGroupTemplateAsync(AxlNetClient.ListFeatureGroupTemplateReq listFeatureGroupTemplate)
        {
            return axlPortClient71.listFeatureGroupTemplateAsync(listFeatureGroupTemplate);
        }

        public AxlNetClient.StandardResponse addDirNumberAliasLookupandSync(AxlNetClient.AddDirNumberAliasLookupandSyncReq addDirNumberAliasLookupandSync1)
        {
            return axlPortClient71.addDirNumberAliasLookupandSync(addDirNumberAliasLookupandSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirNumberAliasLookupandSyncResponse> addDirNumberAliasLookupandSyncAsync(AxlNetClient.AddDirNumberAliasLookupandSyncReq addDirNumberAliasLookupandSync)
        {
            return axlPortClient71.addDirNumberAliasLookupandSyncAsync(addDirNumberAliasLookupandSync);
        }

        public AxlNetClient.StandardResponse updateDirNumberAliasLookupandSync(AxlNetClient.UpdateDirNumberAliasLookupandSyncReq updateDirNumberAliasLookupandSync1)
        {
            return axlPortClient71.updateDirNumberAliasLookupandSync(updateDirNumberAliasLookupandSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirNumberAliasLookupandSyncResponse> updateDirNumberAliasLookupandSyncAsync(AxlNetClient.UpdateDirNumberAliasLookupandSyncReq updateDirNumberAliasLookupandSync)
        {
            return axlPortClient71.updateDirNumberAliasLookupandSyncAsync(updateDirNumberAliasLookupandSync);
        }

        public AxlNetClient.GetDirNumberAliasLookupandSyncRes getDirNumberAliasLookupandSync(AxlNetClient.GetDirNumberAliasLookupandSyncReq getDirNumberAliasLookupandSync1)
        {
            return axlPortClient71.getDirNumberAliasLookupandSync(getDirNumberAliasLookupandSync1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirNumberAliasLookupandSyncResponse> getDirNumberAliasLookupandSyncAsync(AxlNetClient.GetDirNumberAliasLookupandSyncReq getDirNumberAliasLookupandSync)
        {
            return axlPortClient71.getDirNumberAliasLookupandSyncAsync(getDirNumberAliasLookupandSync);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort71
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSdpTransparencyProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSdpTransparencyProfileResponse updateSdpTransparencyProfile(AxlNetClient.updateSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSdpTransparencyProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSdpTransparencyProfileResponse> updateSdpTransparencyProfileAsync(AxlNetClient.updateSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSdpTransparencyProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSdpTransparencyProfileResponse getSdpTransparencyProfile(AxlNetClient.getSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSdpTransparencyProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSdpTransparencyProfileResponse> getSdpTransparencyProfileAsync(AxlNetClient.getSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSdpTransparencyProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSdpTransparencyProfileResponse removeSdpTransparencyProfile(AxlNetClient.removeSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSdpTransparencyProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSdpTransparencyProfileResponse> removeSdpTransparencyProfileAsync(AxlNetClient.removeSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSdpTransparencyProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSdpTransparencyProfileResponse listSdpTransparencyProfile(AxlNetClient.listSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSdpTransparencyProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSdpTransparencyProfileResponse> listSdpTransparencyProfileAsync(AxlNetClient.listSdpTransparencyProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFeatureGroupTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addFeatureGroupTemplateResponse addFeatureGroupTemplate(AxlNetClient.addFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFeatureGroupTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addFeatureGroupTemplateResponse> addFeatureGroupTemplateAsync(AxlNetClient.addFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFeatureGroupTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFeatureGroupTemplateResponse updateFeatureGroupTemplate(AxlNetClient.updateFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFeatureGroupTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFeatureGroupTemplateResponse> updateFeatureGroupTemplateAsync(AxlNetClient.updateFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFeatureGroupTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFeatureGroupTemplateResponse getFeatureGroupTemplate(AxlNetClient.getFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFeatureGroupTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFeatureGroupTemplateResponse> getFeatureGroupTemplateAsync(AxlNetClient.getFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFeatureGroupTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeFeatureGroupTemplateResponse removeFeatureGroupTemplate(AxlNetClient.removeFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFeatureGroupTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeFeatureGroupTemplateResponse> removeFeatureGroupTemplateAsync(AxlNetClient.removeFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFeatureGroupTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listFeatureGroupTemplateResponse listFeatureGroupTemplate(AxlNetClient.listFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFeatureGroupTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listFeatureGroupTemplateResponse> listFeatureGroupTemplateAsync(AxlNetClient.listFeatureGroupTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirNumberAliasLookupandSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDirNumberAliasLookupandSyncResponse addDirNumberAliasLookupandSync(AxlNetClient.addDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDirNumberAliasLookupandSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDirNumberAliasLookupandSyncResponse> addDirNumberAliasLookupandSyncAsync(AxlNetClient.addDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirNumberAliasLookupandSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDirNumberAliasLookupandSyncResponse updateDirNumberAliasLookupandSync(AxlNetClient.updateDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirNumberAliasLookupandSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDirNumberAliasLookupandSyncResponse> updateDirNumberAliasLookupandSyncAsync(AxlNetClient.updateDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirNumberAliasLookupandSync", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDirNumberAliasLookupandSyncResponse getDirNumberAliasLookupandSync(AxlNetClient.getDirNumberAliasLookupandSyncRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirNumberAliasLookupandSync", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDirNumberAliasLookupandSyncResponse> getDirNumberAliasLookupandSyncAsync(AxlNetClient.getDirNumberAliasLookupandSyncRequest request);
    }

    public class AXLPortClient71 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort71>, AxlNetClient.AXLPort71
    {
        public AXLPortClient71(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSdpTransparencyProfileResponse AxlNetClient.AXLPort71.updateSdpTransparencyProfile(AxlNetClient.updateSdpTransparencyProfileRequest request)
        {
            return base.Channel.updateSdpTransparencyProfile(request);
        }

        public AxlNetClient.StandardResponse updateSdpTransparencyProfile(AxlNetClient.UpdateSdpTransparencyProfileReq updateSdpTransparencyProfile1)
        {
            AxlNetClient.updateSdpTransparencyProfileRequest inValue = new AxlNetClient.updateSdpTransparencyProfileRequest();
            inValue.updateSdpTransparencyProfile = updateSdpTransparencyProfile1;
            AxlNetClient.updateSdpTransparencyProfileResponse retVal = ((AxlNetClient.AXLPort71)(this)).updateSdpTransparencyProfile(inValue);
            return retVal.updateSdpTransparencyProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSdpTransparencyProfileResponse> AxlNetClient.AXLPort71.updateSdpTransparencyProfileAsync(AxlNetClient.updateSdpTransparencyProfileRequest request)
        {
            return base.Channel.updateSdpTransparencyProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSdpTransparencyProfileResponse> updateSdpTransparencyProfileAsync(AxlNetClient.UpdateSdpTransparencyProfileReq updateSdpTransparencyProfile)
        {
            AxlNetClient.updateSdpTransparencyProfileRequest inValue = new AxlNetClient.updateSdpTransparencyProfileRequest();
            inValue.updateSdpTransparencyProfile = updateSdpTransparencyProfile;
            return ((AxlNetClient.AXLPort71)(this)).updateSdpTransparencyProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSdpTransparencyProfileResponse AxlNetClient.AXLPort71.getSdpTransparencyProfile(AxlNetClient.getSdpTransparencyProfileRequest request)
        {
            return base.Channel.getSdpTransparencyProfile(request);
        }

        public AxlNetClient.GetSdpTransparencyProfileRes getSdpTransparencyProfile(AxlNetClient.GetSdpTransparencyProfileReq getSdpTransparencyProfile1)
        {
            AxlNetClient.getSdpTransparencyProfileRequest inValue = new AxlNetClient.getSdpTransparencyProfileRequest();
            inValue.getSdpTransparencyProfile = getSdpTransparencyProfile1;
            AxlNetClient.getSdpTransparencyProfileResponse retVal = ((AxlNetClient.AXLPort71)(this)).getSdpTransparencyProfile(inValue);
            return retVal.getSdpTransparencyProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSdpTransparencyProfileResponse> AxlNetClient.AXLPort71.getSdpTransparencyProfileAsync(AxlNetClient.getSdpTransparencyProfileRequest request)
        {
            return base.Channel.getSdpTransparencyProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSdpTransparencyProfileResponse> getSdpTransparencyProfileAsync(AxlNetClient.GetSdpTransparencyProfileReq getSdpTransparencyProfile)
        {
            AxlNetClient.getSdpTransparencyProfileRequest inValue = new AxlNetClient.getSdpTransparencyProfileRequest();
            inValue.getSdpTransparencyProfile = getSdpTransparencyProfile;
            return ((AxlNetClient.AXLPort71)(this)).getSdpTransparencyProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSdpTransparencyProfileResponse AxlNetClient.AXLPort71.removeSdpTransparencyProfile(AxlNetClient.removeSdpTransparencyProfileRequest request)
        {
            return base.Channel.removeSdpTransparencyProfile(request);
        }

        public AxlNetClient.StandardResponse removeSdpTransparencyProfile(AxlNetClient.NameAndGUIDRequest removeSdpTransparencyProfile1)
        {
            AxlNetClient.removeSdpTransparencyProfileRequest inValue = new AxlNetClient.removeSdpTransparencyProfileRequest();
            inValue.removeSdpTransparencyProfile = removeSdpTransparencyProfile1;
            AxlNetClient.removeSdpTransparencyProfileResponse retVal = ((AxlNetClient.AXLPort71)(this)).removeSdpTransparencyProfile(inValue);
            return retVal.removeSdpTransparencyProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSdpTransparencyProfileResponse> AxlNetClient.AXLPort71.removeSdpTransparencyProfileAsync(AxlNetClient.removeSdpTransparencyProfileRequest request)
        {
            return base.Channel.removeSdpTransparencyProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSdpTransparencyProfileResponse> removeSdpTransparencyProfileAsync(AxlNetClient.NameAndGUIDRequest removeSdpTransparencyProfile)
        {
            AxlNetClient.removeSdpTransparencyProfileRequest inValue = new AxlNetClient.removeSdpTransparencyProfileRequest();
            inValue.removeSdpTransparencyProfile = removeSdpTransparencyProfile;
            return ((AxlNetClient.AXLPort71)(this)).removeSdpTransparencyProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSdpTransparencyProfileResponse AxlNetClient.AXLPort71.listSdpTransparencyProfile(AxlNetClient.listSdpTransparencyProfileRequest request)
        {
            return base.Channel.listSdpTransparencyProfile(request);
        }

        public AxlNetClient.ListSdpTransparencyProfileRes listSdpTransparencyProfile(AxlNetClient.ListSdpTransparencyProfileReq listSdpTransparencyProfile1)
        {
            AxlNetClient.listSdpTransparencyProfileRequest inValue = new AxlNetClient.listSdpTransparencyProfileRequest();
            inValue.listSdpTransparencyProfile = listSdpTransparencyProfile1;
            AxlNetClient.listSdpTransparencyProfileResponse retVal = ((AxlNetClient.AXLPort71)(this)).listSdpTransparencyProfile(inValue);
            return retVal.listSdpTransparencyProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSdpTransparencyProfileResponse> AxlNetClient.AXLPort71.listSdpTransparencyProfileAsync(AxlNetClient.listSdpTransparencyProfileRequest request)
        {
            return base.Channel.listSdpTransparencyProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSdpTransparencyProfileResponse> listSdpTransparencyProfileAsync(AxlNetClient.ListSdpTransparencyProfileReq listSdpTransparencyProfile)
        {
            AxlNetClient.listSdpTransparencyProfileRequest inValue = new AxlNetClient.listSdpTransparencyProfileRequest();
            inValue.listSdpTransparencyProfile = listSdpTransparencyProfile;
            return ((AxlNetClient.AXLPort71)(this)).listSdpTransparencyProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addFeatureGroupTemplateResponse AxlNetClient.AXLPort71.addFeatureGroupTemplate(AxlNetClient.addFeatureGroupTemplateRequest request)
        {
            return base.Channel.addFeatureGroupTemplate(request);
        }

        public AxlNetClient.StandardResponse addFeatureGroupTemplate(AxlNetClient.AddFeatureGroupTemplateReq addFeatureGroupTemplate1)
        {
            AxlNetClient.addFeatureGroupTemplateRequest inValue = new AxlNetClient.addFeatureGroupTemplateRequest();
            inValue.addFeatureGroupTemplate = addFeatureGroupTemplate1;
            AxlNetClient.addFeatureGroupTemplateResponse retVal = ((AxlNetClient.AXLPort71)(this)).addFeatureGroupTemplate(inValue);
            return retVal.addFeatureGroupTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addFeatureGroupTemplateResponse> AxlNetClient.AXLPort71.addFeatureGroupTemplateAsync(AxlNetClient.addFeatureGroupTemplateRequest request)
        {
            return base.Channel.addFeatureGroupTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFeatureGroupTemplateResponse> addFeatureGroupTemplateAsync(AxlNetClient.AddFeatureGroupTemplateReq addFeatureGroupTemplate)
        {
            AxlNetClient.addFeatureGroupTemplateRequest inValue = new AxlNetClient.addFeatureGroupTemplateRequest();
            inValue.addFeatureGroupTemplate = addFeatureGroupTemplate;
            return ((AxlNetClient.AXLPort71)(this)).addFeatureGroupTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFeatureGroupTemplateResponse AxlNetClient.AXLPort71.updateFeatureGroupTemplate(AxlNetClient.updateFeatureGroupTemplateRequest request)
        {
            return base.Channel.updateFeatureGroupTemplate(request);
        }

        public AxlNetClient.StandardResponse updateFeatureGroupTemplate(AxlNetClient.UpdateFeatureGroupTemplateReq updateFeatureGroupTemplate1)
        {
            AxlNetClient.updateFeatureGroupTemplateRequest inValue = new AxlNetClient.updateFeatureGroupTemplateRequest();
            inValue.updateFeatureGroupTemplate = updateFeatureGroupTemplate1;
            AxlNetClient.updateFeatureGroupTemplateResponse retVal = ((AxlNetClient.AXLPort71)(this)).updateFeatureGroupTemplate(inValue);
            return retVal.updateFeatureGroupTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFeatureGroupTemplateResponse> AxlNetClient.AXLPort71.updateFeatureGroupTemplateAsync(AxlNetClient.updateFeatureGroupTemplateRequest request)
        {
            return base.Channel.updateFeatureGroupTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFeatureGroupTemplateResponse> updateFeatureGroupTemplateAsync(AxlNetClient.UpdateFeatureGroupTemplateReq updateFeatureGroupTemplate)
        {
            AxlNetClient.updateFeatureGroupTemplateRequest inValue = new AxlNetClient.updateFeatureGroupTemplateRequest();
            inValue.updateFeatureGroupTemplate = updateFeatureGroupTemplate;
            return ((AxlNetClient.AXLPort71)(this)).updateFeatureGroupTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFeatureGroupTemplateResponse AxlNetClient.AXLPort71.getFeatureGroupTemplate(AxlNetClient.getFeatureGroupTemplateRequest request)
        {
            return base.Channel.getFeatureGroupTemplate(request);
        }

        public AxlNetClient.GetFeatureGroupTemplateRes getFeatureGroupTemplate(AxlNetClient.GetFeatureGroupTemplateReq getFeatureGroupTemplate1)
        {
            AxlNetClient.getFeatureGroupTemplateRequest inValue = new AxlNetClient.getFeatureGroupTemplateRequest();
            inValue.getFeatureGroupTemplate = getFeatureGroupTemplate1;
            AxlNetClient.getFeatureGroupTemplateResponse retVal = ((AxlNetClient.AXLPort71)(this)).getFeatureGroupTemplate(inValue);
            return retVal.getFeatureGroupTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFeatureGroupTemplateResponse> AxlNetClient.AXLPort71.getFeatureGroupTemplateAsync(AxlNetClient.getFeatureGroupTemplateRequest request)
        {
            return base.Channel.getFeatureGroupTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFeatureGroupTemplateResponse> getFeatureGroupTemplateAsync(AxlNetClient.GetFeatureGroupTemplateReq getFeatureGroupTemplate)
        {
            AxlNetClient.getFeatureGroupTemplateRequest inValue = new AxlNetClient.getFeatureGroupTemplateRequest();
            inValue.getFeatureGroupTemplate = getFeatureGroupTemplate;
            return ((AxlNetClient.AXLPort71)(this)).getFeatureGroupTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeFeatureGroupTemplateResponse AxlNetClient.AXLPort71.removeFeatureGroupTemplate(AxlNetClient.removeFeatureGroupTemplateRequest request)
        {
            return base.Channel.removeFeatureGroupTemplate(request);
        }

        public AxlNetClient.StandardResponse removeFeatureGroupTemplate(AxlNetClient.NameAndGUIDRequest removeFeatureGroupTemplate1)
        {
            AxlNetClient.removeFeatureGroupTemplateRequest inValue = new AxlNetClient.removeFeatureGroupTemplateRequest();
            inValue.removeFeatureGroupTemplate = removeFeatureGroupTemplate1;
            AxlNetClient.removeFeatureGroupTemplateResponse retVal = ((AxlNetClient.AXLPort71)(this)).removeFeatureGroupTemplate(inValue);
            return retVal.removeFeatureGroupTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeFeatureGroupTemplateResponse> AxlNetClient.AXLPort71.removeFeatureGroupTemplateAsync(AxlNetClient.removeFeatureGroupTemplateRequest request)
        {
            return base.Channel.removeFeatureGroupTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFeatureGroupTemplateResponse> removeFeatureGroupTemplateAsync(AxlNetClient.NameAndGUIDRequest removeFeatureGroupTemplate)
        {
            AxlNetClient.removeFeatureGroupTemplateRequest inValue = new AxlNetClient.removeFeatureGroupTemplateRequest();
            inValue.removeFeatureGroupTemplate = removeFeatureGroupTemplate;
            return ((AxlNetClient.AXLPort71)(this)).removeFeatureGroupTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listFeatureGroupTemplateResponse AxlNetClient.AXLPort71.listFeatureGroupTemplate(AxlNetClient.listFeatureGroupTemplateRequest request)
        {
            return base.Channel.listFeatureGroupTemplate(request);
        }

        public AxlNetClient.ListFeatureGroupTemplateRes listFeatureGroupTemplate(AxlNetClient.ListFeatureGroupTemplateReq listFeatureGroupTemplate1)
        {
            AxlNetClient.listFeatureGroupTemplateRequest inValue = new AxlNetClient.listFeatureGroupTemplateRequest();
            inValue.listFeatureGroupTemplate = listFeatureGroupTemplate1;
            AxlNetClient.listFeatureGroupTemplateResponse retVal = ((AxlNetClient.AXLPort71)(this)).listFeatureGroupTemplate(inValue);
            return retVal.listFeatureGroupTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listFeatureGroupTemplateResponse> AxlNetClient.AXLPort71.listFeatureGroupTemplateAsync(AxlNetClient.listFeatureGroupTemplateRequest request)
        {
            return base.Channel.listFeatureGroupTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFeatureGroupTemplateResponse> listFeatureGroupTemplateAsync(AxlNetClient.ListFeatureGroupTemplateReq listFeatureGroupTemplate)
        {
            AxlNetClient.listFeatureGroupTemplateRequest inValue = new AxlNetClient.listFeatureGroupTemplateRequest();
            inValue.listFeatureGroupTemplate = listFeatureGroupTemplate;
            return ((AxlNetClient.AXLPort71)(this)).listFeatureGroupTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDirNumberAliasLookupandSyncResponse AxlNetClient.AXLPort71.addDirNumberAliasLookupandSync(AxlNetClient.addDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.addDirNumberAliasLookupandSync(request);
        }

        public AxlNetClient.StandardResponse addDirNumberAliasLookupandSync(AxlNetClient.AddDirNumberAliasLookupandSyncReq addDirNumberAliasLookupandSync1)
        {
            AxlNetClient.addDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.addDirNumberAliasLookupandSyncRequest();
            inValue.addDirNumberAliasLookupandSync = addDirNumberAliasLookupandSync1;
            AxlNetClient.addDirNumberAliasLookupandSyncResponse retVal = ((AxlNetClient.AXLPort71)(this)).addDirNumberAliasLookupandSync(inValue);
            return retVal.addDirNumberAliasLookupandSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDirNumberAliasLookupandSyncResponse> AxlNetClient.AXLPort71.addDirNumberAliasLookupandSyncAsync(AxlNetClient.addDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.addDirNumberAliasLookupandSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDirNumberAliasLookupandSyncResponse> addDirNumberAliasLookupandSyncAsync(AxlNetClient.AddDirNumberAliasLookupandSyncReq addDirNumberAliasLookupandSync)
        {
            AxlNetClient.addDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.addDirNumberAliasLookupandSyncRequest();
            inValue.addDirNumberAliasLookupandSync = addDirNumberAliasLookupandSync;
            return ((AxlNetClient.AXLPort71)(this)).addDirNumberAliasLookupandSyncAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDirNumberAliasLookupandSyncResponse AxlNetClient.AXLPort71.updateDirNumberAliasLookupandSync(AxlNetClient.updateDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.updateDirNumberAliasLookupandSync(request);
        }

        public AxlNetClient.StandardResponse updateDirNumberAliasLookupandSync(AxlNetClient.UpdateDirNumberAliasLookupandSyncReq updateDirNumberAliasLookupandSync1)
        {
            AxlNetClient.updateDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.updateDirNumberAliasLookupandSyncRequest();
            inValue.updateDirNumberAliasLookupandSync = updateDirNumberAliasLookupandSync1;
            AxlNetClient.updateDirNumberAliasLookupandSyncResponse retVal = ((AxlNetClient.AXLPort71)(this)).updateDirNumberAliasLookupandSync(inValue);
            return retVal.updateDirNumberAliasLookupandSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDirNumberAliasLookupandSyncResponse> AxlNetClient.AXLPort71.updateDirNumberAliasLookupandSyncAsync(AxlNetClient.updateDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.updateDirNumberAliasLookupandSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirNumberAliasLookupandSyncResponse> updateDirNumberAliasLookupandSyncAsync(AxlNetClient.UpdateDirNumberAliasLookupandSyncReq updateDirNumberAliasLookupandSync)
        {
            AxlNetClient.updateDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.updateDirNumberAliasLookupandSyncRequest();
            inValue.updateDirNumberAliasLookupandSync = updateDirNumberAliasLookupandSync;
            return ((AxlNetClient.AXLPort71)(this)).updateDirNumberAliasLookupandSyncAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDirNumberAliasLookupandSyncResponse AxlNetClient.AXLPort71.getDirNumberAliasLookupandSync(AxlNetClient.getDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.getDirNumberAliasLookupandSync(request);
        }

        public AxlNetClient.GetDirNumberAliasLookupandSyncRes getDirNumberAliasLookupandSync(AxlNetClient.GetDirNumberAliasLookupandSyncReq getDirNumberAliasLookupandSync1)
        {
            AxlNetClient.getDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.getDirNumberAliasLookupandSyncRequest();
            inValue.getDirNumberAliasLookupandSync = getDirNumberAliasLookupandSync1;
            AxlNetClient.getDirNumberAliasLookupandSyncResponse retVal = ((AxlNetClient.AXLPort71)(this)).getDirNumberAliasLookupandSync(inValue);
            return retVal.getDirNumberAliasLookupandSyncResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDirNumberAliasLookupandSyncResponse> AxlNetClient.AXLPort71.getDirNumberAliasLookupandSyncAsync(AxlNetClient.getDirNumberAliasLookupandSyncRequest request)
        {
            return base.Channel.getDirNumberAliasLookupandSyncAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirNumberAliasLookupandSyncResponse> getDirNumberAliasLookupandSyncAsync(AxlNetClient.GetDirNumberAliasLookupandSyncReq getDirNumberAliasLookupandSync)
        {
            AxlNetClient.getDirNumberAliasLookupandSyncRequest inValue = new AxlNetClient.getDirNumberAliasLookupandSyncRequest();
            inValue.getDirNumberAliasLookupandSync = getDirNumberAliasLookupandSync;
            return ((AxlNetClient.AXLPort71)(this)).getDirNumberAliasLookupandSyncAsync(inValue);
        }
    }
}