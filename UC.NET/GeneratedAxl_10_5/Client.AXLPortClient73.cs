namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient73 _axlPortClient73;

        private static AXLPortClient73 axlPortClient73 => _axlPortClient73 == null ||
            _axlPortClient73.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient73 = LoadClient73()) : _axlPortClient73;

        private static AXLPortClient73 LoadClient73()
        {
            var client = new AXLPortClient73(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close73;
            OnAbort += Abort73;
            return client;
        }

        private static void Close73(object sender, System.EventArgs e)
        {
            _axlPortClient73.Close();
        }

        private static void Abort73(object sender, System.EventArgs e)
        {
            _axlPortClient73.Abort();
        }

        public AxlNetClient.GetBlockedLearnedPatternsRes getBlockedLearnedPatterns(AxlNetClient.GetBlockedLearnedPatternsReq getBlockedLearnedPatterns1)
        {
            return axlPortClient73.getBlockedLearnedPatterns(getBlockedLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getBlockedLearnedPatternsResponse> getBlockedLearnedPatternsAsync(AxlNetClient.GetBlockedLearnedPatternsReq getBlockedLearnedPatterns)
        {
            return axlPortClient73.getBlockedLearnedPatternsAsync(getBlockedLearnedPatterns);
        }

        public AxlNetClient.StandardResponse removeBlockedLearnedPatterns(AxlNetClient.RemoveBlockedLearnedPatternsReq removeBlockedLearnedPatterns1)
        {
            return axlPortClient73.removeBlockedLearnedPatterns(removeBlockedLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeBlockedLearnedPatternsResponse> removeBlockedLearnedPatternsAsync(AxlNetClient.RemoveBlockedLearnedPatternsReq removeBlockedLearnedPatterns)
        {
            return axlPortClient73.removeBlockedLearnedPatternsAsync(removeBlockedLearnedPatterns);
        }

        public AxlNetClient.ListBlockedLearnedPatternsRes listBlockedLearnedPatterns(AxlNetClient.ListBlockedLearnedPatternsReq listBlockedLearnedPatterns1)
        {
            return axlPortClient73.listBlockedLearnedPatterns(listBlockedLearnedPatterns1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listBlockedLearnedPatternsResponse> listBlockedLearnedPatternsAsync(AxlNetClient.ListBlockedLearnedPatternsReq listBlockedLearnedPatterns)
        {
            return axlPortClient73.listBlockedLearnedPatternsAsync(listBlockedLearnedPatterns);
        }

        public AxlNetClient.StandardResponse addCCAProfiles(AxlNetClient.AddCCAProfilesReq addCCAProfiles1)
        {
            return axlPortClient73.addCCAProfiles(addCCAProfiles1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCCAProfilesResponse> addCCAProfilesAsync(AxlNetClient.AddCCAProfilesReq addCCAProfiles)
        {
            return axlPortClient73.addCCAProfilesAsync(addCCAProfiles);
        }

        public AxlNetClient.StandardResponse updateCCAProfiles(AxlNetClient.UpdateCCAProfilesReq updateCCAProfiles1)
        {
            return axlPortClient73.updateCCAProfiles(updateCCAProfiles1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCCAProfilesResponse> updateCCAProfilesAsync(AxlNetClient.UpdateCCAProfilesReq updateCCAProfiles)
        {
            return axlPortClient73.updateCCAProfilesAsync(updateCCAProfiles);
        }

        public AxlNetClient.GetCCAProfilesRes getCCAProfiles(AxlNetClient.GetCCAProfilesReq getCCAProfiles1)
        {
            return axlPortClient73.getCCAProfiles(getCCAProfiles1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCCAProfilesResponse> getCCAProfilesAsync(AxlNetClient.GetCCAProfilesReq getCCAProfiles)
        {
            return axlPortClient73.getCCAProfilesAsync(getCCAProfiles);
        }

        public AxlNetClient.StandardResponse removeCCAProfiles(AxlNetClient.RemoveCCAProfilesReq removeCCAProfiles1)
        {
            return axlPortClient73.removeCCAProfiles(removeCCAProfiles1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCCAProfilesResponse> removeCCAProfilesAsync(AxlNetClient.RemoveCCAProfilesReq removeCCAProfiles)
        {
            return axlPortClient73.removeCCAProfilesAsync(removeCCAProfiles);
        }

        public AxlNetClient.ListCCAProfilesRes listCCAProfiles(AxlNetClient.ListCCAProfilesReq listCCAProfiles1)
        {
            return axlPortClient73.listCCAProfiles(listCCAProfiles1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCCAProfilesResponse> listCCAProfilesAsync(AxlNetClient.ListCCAProfilesReq listCCAProfiles)
        {
            return axlPortClient73.listCCAProfilesAsync(listCCAProfiles);
        }

        public AxlNetClient.StandardResponse addUniversalDeviceTemplate(AxlNetClient.AddUniversalDeviceTemplateReq addUniversalDeviceTemplate1)
        {
            return axlPortClient73.addUniversalDeviceTemplate(addUniversalDeviceTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUniversalDeviceTemplateResponse> addUniversalDeviceTemplateAsync(AxlNetClient.AddUniversalDeviceTemplateReq addUniversalDeviceTemplate)
        {
            return axlPortClient73.addUniversalDeviceTemplateAsync(addUniversalDeviceTemplate);
        }

        public AxlNetClient.StandardResponse updateUniversalDeviceTemplate(AxlNetClient.UpdateUniversalDeviceTemplateReq updateUniversalDeviceTemplate1)
        {
            return axlPortClient73.updateUniversalDeviceTemplate(updateUniversalDeviceTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUniversalDeviceTemplateResponse> updateUniversalDeviceTemplateAsync(AxlNetClient.UpdateUniversalDeviceTemplateReq updateUniversalDeviceTemplate)
        {
            return axlPortClient73.updateUniversalDeviceTemplateAsync(updateUniversalDeviceTemplate);
        }

        public AxlNetClient.GetUniversalDeviceTemplateRes getUniversalDeviceTemplate(AxlNetClient.GetUniversalDeviceTemplateReq getUniversalDeviceTemplate1)
        {
            return axlPortClient73.getUniversalDeviceTemplate(getUniversalDeviceTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUniversalDeviceTemplateResponse> getUniversalDeviceTemplateAsync(AxlNetClient.GetUniversalDeviceTemplateReq getUniversalDeviceTemplate)
        {
            return axlPortClient73.getUniversalDeviceTemplateAsync(getUniversalDeviceTemplate);
        }

        public AxlNetClient.StandardResponse removeUniversalDeviceTemplate(AxlNetClient.NameAndGUIDRequest removeUniversalDeviceTemplate1)
        {
            return axlPortClient73.removeUniversalDeviceTemplate(removeUniversalDeviceTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUniversalDeviceTemplateResponse> removeUniversalDeviceTemplateAsync(AxlNetClient.NameAndGUIDRequest removeUniversalDeviceTemplate)
        {
            return axlPortClient73.removeUniversalDeviceTemplateAsync(removeUniversalDeviceTemplate);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort73
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getBlockedLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getBlockedLearnedPatternsResponse getBlockedLearnedPatterns(AxlNetClient.getBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getBlockedLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getBlockedLearnedPatternsResponse> getBlockedLearnedPatternsAsync(AxlNetClient.getBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeBlockedLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeBlockedLearnedPatternsResponse removeBlockedLearnedPatterns(AxlNetClient.removeBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeBlockedLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeBlockedLearnedPatternsResponse> removeBlockedLearnedPatternsAsync(AxlNetClient.removeBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listBlockedLearnedPatterns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listBlockedLearnedPatternsResponse listBlockedLearnedPatterns(AxlNetClient.listBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listBlockedLearnedPatterns", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listBlockedLearnedPatternsResponse> listBlockedLearnedPatternsAsync(AxlNetClient.listBlockedLearnedPatternsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCCAProfiles", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCCAProfilesResponse addCCAProfiles(AxlNetClient.addCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCCAProfiles", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCCAProfilesResponse> addCCAProfilesAsync(AxlNetClient.addCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCCAProfiles", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCCAProfilesResponse updateCCAProfiles(AxlNetClient.updateCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCCAProfiles", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCCAProfilesResponse> updateCCAProfilesAsync(AxlNetClient.updateCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCCAProfiles", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCCAProfilesResponse getCCAProfiles(AxlNetClient.getCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCCAProfiles", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCCAProfilesResponse> getCCAProfilesAsync(AxlNetClient.getCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCCAProfiles", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCCAProfilesResponse removeCCAProfiles(AxlNetClient.removeCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCCAProfiles", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCCAProfilesResponse> removeCCAProfilesAsync(AxlNetClient.removeCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCCAProfiles", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCCAProfilesResponse listCCAProfiles(AxlNetClient.listCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCCAProfiles", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCCAProfilesResponse> listCCAProfilesAsync(AxlNetClient.listCCAProfilesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUniversalDeviceTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUniversalDeviceTemplateResponse addUniversalDeviceTemplate(AxlNetClient.addUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUniversalDeviceTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUniversalDeviceTemplateResponse> addUniversalDeviceTemplateAsync(AxlNetClient.addUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUniversalDeviceTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUniversalDeviceTemplateResponse updateUniversalDeviceTemplate(AxlNetClient.updateUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUniversalDeviceTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUniversalDeviceTemplateResponse> updateUniversalDeviceTemplateAsync(AxlNetClient.updateUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUniversalDeviceTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUniversalDeviceTemplateResponse getUniversalDeviceTemplate(AxlNetClient.getUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUniversalDeviceTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUniversalDeviceTemplateResponse> getUniversalDeviceTemplateAsync(AxlNetClient.getUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUniversalDeviceTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUniversalDeviceTemplateResponse removeUniversalDeviceTemplate(AxlNetClient.removeUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUniversalDeviceTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUniversalDeviceTemplateResponse> removeUniversalDeviceTemplateAsync(AxlNetClient.removeUniversalDeviceTemplateRequest request);
    }

    public class AXLPortClient73 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort73>, AxlNetClient.AXLPort73
    {
        public AXLPortClient73(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getBlockedLearnedPatternsResponse AxlNetClient.AXLPort73.getBlockedLearnedPatterns(AxlNetClient.getBlockedLearnedPatternsRequest request)
        {
            return base.Channel.getBlockedLearnedPatterns(request);
        }

        public AxlNetClient.GetBlockedLearnedPatternsRes getBlockedLearnedPatterns(AxlNetClient.GetBlockedLearnedPatternsReq getBlockedLearnedPatterns1)
        {
            AxlNetClient.getBlockedLearnedPatternsRequest inValue = new AxlNetClient.getBlockedLearnedPatternsRequest();
            inValue.getBlockedLearnedPatterns = getBlockedLearnedPatterns1;
            AxlNetClient.getBlockedLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort73)(this)).getBlockedLearnedPatterns(inValue);
            return retVal.getBlockedLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getBlockedLearnedPatternsResponse> AxlNetClient.AXLPort73.getBlockedLearnedPatternsAsync(AxlNetClient.getBlockedLearnedPatternsRequest request)
        {
            return base.Channel.getBlockedLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getBlockedLearnedPatternsResponse> getBlockedLearnedPatternsAsync(AxlNetClient.GetBlockedLearnedPatternsReq getBlockedLearnedPatterns)
        {
            AxlNetClient.getBlockedLearnedPatternsRequest inValue = new AxlNetClient.getBlockedLearnedPatternsRequest();
            inValue.getBlockedLearnedPatterns = getBlockedLearnedPatterns;
            return ((AxlNetClient.AXLPort73)(this)).getBlockedLearnedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeBlockedLearnedPatternsResponse AxlNetClient.AXLPort73.removeBlockedLearnedPatterns(AxlNetClient.removeBlockedLearnedPatternsRequest request)
        {
            return base.Channel.removeBlockedLearnedPatterns(request);
        }

        public AxlNetClient.StandardResponse removeBlockedLearnedPatterns(AxlNetClient.RemoveBlockedLearnedPatternsReq removeBlockedLearnedPatterns1)
        {
            AxlNetClient.removeBlockedLearnedPatternsRequest inValue = new AxlNetClient.removeBlockedLearnedPatternsRequest();
            inValue.removeBlockedLearnedPatterns = removeBlockedLearnedPatterns1;
            AxlNetClient.removeBlockedLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort73)(this)).removeBlockedLearnedPatterns(inValue);
            return retVal.removeBlockedLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeBlockedLearnedPatternsResponse> AxlNetClient.AXLPort73.removeBlockedLearnedPatternsAsync(AxlNetClient.removeBlockedLearnedPatternsRequest request)
        {
            return base.Channel.removeBlockedLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeBlockedLearnedPatternsResponse> removeBlockedLearnedPatternsAsync(AxlNetClient.RemoveBlockedLearnedPatternsReq removeBlockedLearnedPatterns)
        {
            AxlNetClient.removeBlockedLearnedPatternsRequest inValue = new AxlNetClient.removeBlockedLearnedPatternsRequest();
            inValue.removeBlockedLearnedPatterns = removeBlockedLearnedPatterns;
            return ((AxlNetClient.AXLPort73)(this)).removeBlockedLearnedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listBlockedLearnedPatternsResponse AxlNetClient.AXLPort73.listBlockedLearnedPatterns(AxlNetClient.listBlockedLearnedPatternsRequest request)
        {
            return base.Channel.listBlockedLearnedPatterns(request);
        }

        public AxlNetClient.ListBlockedLearnedPatternsRes listBlockedLearnedPatterns(AxlNetClient.ListBlockedLearnedPatternsReq listBlockedLearnedPatterns1)
        {
            AxlNetClient.listBlockedLearnedPatternsRequest inValue = new AxlNetClient.listBlockedLearnedPatternsRequest();
            inValue.listBlockedLearnedPatterns = listBlockedLearnedPatterns1;
            AxlNetClient.listBlockedLearnedPatternsResponse retVal = ((AxlNetClient.AXLPort73)(this)).listBlockedLearnedPatterns(inValue);
            return retVal.listBlockedLearnedPatternsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listBlockedLearnedPatternsResponse> AxlNetClient.AXLPort73.listBlockedLearnedPatternsAsync(AxlNetClient.listBlockedLearnedPatternsRequest request)
        {
            return base.Channel.listBlockedLearnedPatternsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listBlockedLearnedPatternsResponse> listBlockedLearnedPatternsAsync(AxlNetClient.ListBlockedLearnedPatternsReq listBlockedLearnedPatterns)
        {
            AxlNetClient.listBlockedLearnedPatternsRequest inValue = new AxlNetClient.listBlockedLearnedPatternsRequest();
            inValue.listBlockedLearnedPatterns = listBlockedLearnedPatterns;
            return ((AxlNetClient.AXLPort73)(this)).listBlockedLearnedPatternsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCCAProfilesResponse AxlNetClient.AXLPort73.addCCAProfiles(AxlNetClient.addCCAProfilesRequest request)
        {
            return base.Channel.addCCAProfiles(request);
        }

        public AxlNetClient.StandardResponse addCCAProfiles(AxlNetClient.AddCCAProfilesReq addCCAProfiles1)
        {
            AxlNetClient.addCCAProfilesRequest inValue = new AxlNetClient.addCCAProfilesRequest();
            inValue.addCCAProfiles = addCCAProfiles1;
            AxlNetClient.addCCAProfilesResponse retVal = ((AxlNetClient.AXLPort73)(this)).addCCAProfiles(inValue);
            return retVal.addCCAProfilesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCCAProfilesResponse> AxlNetClient.AXLPort73.addCCAProfilesAsync(AxlNetClient.addCCAProfilesRequest request)
        {
            return base.Channel.addCCAProfilesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCCAProfilesResponse> addCCAProfilesAsync(AxlNetClient.AddCCAProfilesReq addCCAProfiles)
        {
            AxlNetClient.addCCAProfilesRequest inValue = new AxlNetClient.addCCAProfilesRequest();
            inValue.addCCAProfiles = addCCAProfiles;
            return ((AxlNetClient.AXLPort73)(this)).addCCAProfilesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCCAProfilesResponse AxlNetClient.AXLPort73.updateCCAProfiles(AxlNetClient.updateCCAProfilesRequest request)
        {
            return base.Channel.updateCCAProfiles(request);
        }

        public AxlNetClient.StandardResponse updateCCAProfiles(AxlNetClient.UpdateCCAProfilesReq updateCCAProfiles1)
        {
            AxlNetClient.updateCCAProfilesRequest inValue = new AxlNetClient.updateCCAProfilesRequest();
            inValue.updateCCAProfiles = updateCCAProfiles1;
            AxlNetClient.updateCCAProfilesResponse retVal = ((AxlNetClient.AXLPort73)(this)).updateCCAProfiles(inValue);
            return retVal.updateCCAProfilesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCCAProfilesResponse> AxlNetClient.AXLPort73.updateCCAProfilesAsync(AxlNetClient.updateCCAProfilesRequest request)
        {
            return base.Channel.updateCCAProfilesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCCAProfilesResponse> updateCCAProfilesAsync(AxlNetClient.UpdateCCAProfilesReq updateCCAProfiles)
        {
            AxlNetClient.updateCCAProfilesRequest inValue = new AxlNetClient.updateCCAProfilesRequest();
            inValue.updateCCAProfiles = updateCCAProfiles;
            return ((AxlNetClient.AXLPort73)(this)).updateCCAProfilesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCCAProfilesResponse AxlNetClient.AXLPort73.getCCAProfiles(AxlNetClient.getCCAProfilesRequest request)
        {
            return base.Channel.getCCAProfiles(request);
        }

        public AxlNetClient.GetCCAProfilesRes getCCAProfiles(AxlNetClient.GetCCAProfilesReq getCCAProfiles1)
        {
            AxlNetClient.getCCAProfilesRequest inValue = new AxlNetClient.getCCAProfilesRequest();
            inValue.getCCAProfiles = getCCAProfiles1;
            AxlNetClient.getCCAProfilesResponse retVal = ((AxlNetClient.AXLPort73)(this)).getCCAProfiles(inValue);
            return retVal.getCCAProfilesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCCAProfilesResponse> AxlNetClient.AXLPort73.getCCAProfilesAsync(AxlNetClient.getCCAProfilesRequest request)
        {
            return base.Channel.getCCAProfilesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCCAProfilesResponse> getCCAProfilesAsync(AxlNetClient.GetCCAProfilesReq getCCAProfiles)
        {
            AxlNetClient.getCCAProfilesRequest inValue = new AxlNetClient.getCCAProfilesRequest();
            inValue.getCCAProfiles = getCCAProfiles;
            return ((AxlNetClient.AXLPort73)(this)).getCCAProfilesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCCAProfilesResponse AxlNetClient.AXLPort73.removeCCAProfiles(AxlNetClient.removeCCAProfilesRequest request)
        {
            return base.Channel.removeCCAProfiles(request);
        }

        public AxlNetClient.StandardResponse removeCCAProfiles(AxlNetClient.RemoveCCAProfilesReq removeCCAProfiles1)
        {
            AxlNetClient.removeCCAProfilesRequest inValue = new AxlNetClient.removeCCAProfilesRequest();
            inValue.removeCCAProfiles = removeCCAProfiles1;
            AxlNetClient.removeCCAProfilesResponse retVal = ((AxlNetClient.AXLPort73)(this)).removeCCAProfiles(inValue);
            return retVal.removeCCAProfilesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCCAProfilesResponse> AxlNetClient.AXLPort73.removeCCAProfilesAsync(AxlNetClient.removeCCAProfilesRequest request)
        {
            return base.Channel.removeCCAProfilesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCCAProfilesResponse> removeCCAProfilesAsync(AxlNetClient.RemoveCCAProfilesReq removeCCAProfiles)
        {
            AxlNetClient.removeCCAProfilesRequest inValue = new AxlNetClient.removeCCAProfilesRequest();
            inValue.removeCCAProfiles = removeCCAProfiles;
            return ((AxlNetClient.AXLPort73)(this)).removeCCAProfilesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCCAProfilesResponse AxlNetClient.AXLPort73.listCCAProfiles(AxlNetClient.listCCAProfilesRequest request)
        {
            return base.Channel.listCCAProfiles(request);
        }

        public AxlNetClient.ListCCAProfilesRes listCCAProfiles(AxlNetClient.ListCCAProfilesReq listCCAProfiles1)
        {
            AxlNetClient.listCCAProfilesRequest inValue = new AxlNetClient.listCCAProfilesRequest();
            inValue.listCCAProfiles = listCCAProfiles1;
            AxlNetClient.listCCAProfilesResponse retVal = ((AxlNetClient.AXLPort73)(this)).listCCAProfiles(inValue);
            return retVal.listCCAProfilesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCCAProfilesResponse> AxlNetClient.AXLPort73.listCCAProfilesAsync(AxlNetClient.listCCAProfilesRequest request)
        {
            return base.Channel.listCCAProfilesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCCAProfilesResponse> listCCAProfilesAsync(AxlNetClient.ListCCAProfilesReq listCCAProfiles)
        {
            AxlNetClient.listCCAProfilesRequest inValue = new AxlNetClient.listCCAProfilesRequest();
            inValue.listCCAProfiles = listCCAProfiles;
            return ((AxlNetClient.AXLPort73)(this)).listCCAProfilesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUniversalDeviceTemplateResponse AxlNetClient.AXLPort73.addUniversalDeviceTemplate(AxlNetClient.addUniversalDeviceTemplateRequest request)
        {
            return base.Channel.addUniversalDeviceTemplate(request);
        }

        public AxlNetClient.StandardResponse addUniversalDeviceTemplate(AxlNetClient.AddUniversalDeviceTemplateReq addUniversalDeviceTemplate1)
        {
            AxlNetClient.addUniversalDeviceTemplateRequest inValue = new AxlNetClient.addUniversalDeviceTemplateRequest();
            inValue.addUniversalDeviceTemplate = addUniversalDeviceTemplate1;
            AxlNetClient.addUniversalDeviceTemplateResponse retVal = ((AxlNetClient.AXLPort73)(this)).addUniversalDeviceTemplate(inValue);
            return retVal.addUniversalDeviceTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUniversalDeviceTemplateResponse> AxlNetClient.AXLPort73.addUniversalDeviceTemplateAsync(AxlNetClient.addUniversalDeviceTemplateRequest request)
        {
            return base.Channel.addUniversalDeviceTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUniversalDeviceTemplateResponse> addUniversalDeviceTemplateAsync(AxlNetClient.AddUniversalDeviceTemplateReq addUniversalDeviceTemplate)
        {
            AxlNetClient.addUniversalDeviceTemplateRequest inValue = new AxlNetClient.addUniversalDeviceTemplateRequest();
            inValue.addUniversalDeviceTemplate = addUniversalDeviceTemplate;
            return ((AxlNetClient.AXLPort73)(this)).addUniversalDeviceTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUniversalDeviceTemplateResponse AxlNetClient.AXLPort73.updateUniversalDeviceTemplate(AxlNetClient.updateUniversalDeviceTemplateRequest request)
        {
            return base.Channel.updateUniversalDeviceTemplate(request);
        }

        public AxlNetClient.StandardResponse updateUniversalDeviceTemplate(AxlNetClient.UpdateUniversalDeviceTemplateReq updateUniversalDeviceTemplate1)
        {
            AxlNetClient.updateUniversalDeviceTemplateRequest inValue = new AxlNetClient.updateUniversalDeviceTemplateRequest();
            inValue.updateUniversalDeviceTemplate = updateUniversalDeviceTemplate1;
            AxlNetClient.updateUniversalDeviceTemplateResponse retVal = ((AxlNetClient.AXLPort73)(this)).updateUniversalDeviceTemplate(inValue);
            return retVal.updateUniversalDeviceTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUniversalDeviceTemplateResponse> AxlNetClient.AXLPort73.updateUniversalDeviceTemplateAsync(AxlNetClient.updateUniversalDeviceTemplateRequest request)
        {
            return base.Channel.updateUniversalDeviceTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUniversalDeviceTemplateResponse> updateUniversalDeviceTemplateAsync(AxlNetClient.UpdateUniversalDeviceTemplateReq updateUniversalDeviceTemplate)
        {
            AxlNetClient.updateUniversalDeviceTemplateRequest inValue = new AxlNetClient.updateUniversalDeviceTemplateRequest();
            inValue.updateUniversalDeviceTemplate = updateUniversalDeviceTemplate;
            return ((AxlNetClient.AXLPort73)(this)).updateUniversalDeviceTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUniversalDeviceTemplateResponse AxlNetClient.AXLPort73.getUniversalDeviceTemplate(AxlNetClient.getUniversalDeviceTemplateRequest request)
        {
            return base.Channel.getUniversalDeviceTemplate(request);
        }

        public AxlNetClient.GetUniversalDeviceTemplateRes getUniversalDeviceTemplate(AxlNetClient.GetUniversalDeviceTemplateReq getUniversalDeviceTemplate1)
        {
            AxlNetClient.getUniversalDeviceTemplateRequest inValue = new AxlNetClient.getUniversalDeviceTemplateRequest();
            inValue.getUniversalDeviceTemplate = getUniversalDeviceTemplate1;
            AxlNetClient.getUniversalDeviceTemplateResponse retVal = ((AxlNetClient.AXLPort73)(this)).getUniversalDeviceTemplate(inValue);
            return retVal.getUniversalDeviceTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUniversalDeviceTemplateResponse> AxlNetClient.AXLPort73.getUniversalDeviceTemplateAsync(AxlNetClient.getUniversalDeviceTemplateRequest request)
        {
            return base.Channel.getUniversalDeviceTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUniversalDeviceTemplateResponse> getUniversalDeviceTemplateAsync(AxlNetClient.GetUniversalDeviceTemplateReq getUniversalDeviceTemplate)
        {
            AxlNetClient.getUniversalDeviceTemplateRequest inValue = new AxlNetClient.getUniversalDeviceTemplateRequest();
            inValue.getUniversalDeviceTemplate = getUniversalDeviceTemplate;
            return ((AxlNetClient.AXLPort73)(this)).getUniversalDeviceTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUniversalDeviceTemplateResponse AxlNetClient.AXLPort73.removeUniversalDeviceTemplate(AxlNetClient.removeUniversalDeviceTemplateRequest request)
        {
            return base.Channel.removeUniversalDeviceTemplate(request);
        }

        public AxlNetClient.StandardResponse removeUniversalDeviceTemplate(AxlNetClient.NameAndGUIDRequest removeUniversalDeviceTemplate1)
        {
            AxlNetClient.removeUniversalDeviceTemplateRequest inValue = new AxlNetClient.removeUniversalDeviceTemplateRequest();
            inValue.removeUniversalDeviceTemplate = removeUniversalDeviceTemplate1;
            AxlNetClient.removeUniversalDeviceTemplateResponse retVal = ((AxlNetClient.AXLPort73)(this)).removeUniversalDeviceTemplate(inValue);
            return retVal.removeUniversalDeviceTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUniversalDeviceTemplateResponse> AxlNetClient.AXLPort73.removeUniversalDeviceTemplateAsync(AxlNetClient.removeUniversalDeviceTemplateRequest request)
        {
            return base.Channel.removeUniversalDeviceTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUniversalDeviceTemplateResponse> removeUniversalDeviceTemplateAsync(AxlNetClient.NameAndGUIDRequest removeUniversalDeviceTemplate)
        {
            AxlNetClient.removeUniversalDeviceTemplateRequest inValue = new AxlNetClient.removeUniversalDeviceTemplateRequest();
            inValue.removeUniversalDeviceTemplate = removeUniversalDeviceTemplate;
            return ((AxlNetClient.AXLPort73)(this)).removeUniversalDeviceTemplateAsync(inValue);
        }
    }
}