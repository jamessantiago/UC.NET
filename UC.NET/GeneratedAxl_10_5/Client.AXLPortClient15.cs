namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient15 _axlPortClient15;

        private static AXLPortClient15 axlPortClient15 => _axlPortClient15 == null ||
            _axlPortClient15.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient15 = LoadClient15()) : _axlPortClient15;

        private static AXLPortClient15 LoadClient15()
        {
            var client = new AXLPortClient15(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close15;
            OnAbort += Abort15;
            return client;
        }

        private static void Close15(object sender, System.EventArgs e)
        {
            _axlPortClient15.Close();
        }

        private static void Abort15(object sender, System.EventArgs e)
        {
            _axlPortClient15.Abort();
        }

        public AxlNetClient.StandardResponse removeFacInfo(AxlNetClient.NameAndGUIDRequest removeFacInfo1)
        {
            return axlPortClient15.removeFacInfo(removeFacInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFacInfoResponse> removeFacInfoAsync(AxlNetClient.NameAndGUIDRequest removeFacInfo)
        {
            return axlPortClient15.removeFacInfoAsync(removeFacInfo);
        }

        public AxlNetClient.ListFacInfoRes listFacInfo(AxlNetClient.ListFacInfoReq listFacInfo1)
        {
            return axlPortClient15.listFacInfo(listFacInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFacInfoResponse> listFacInfoAsync(AxlNetClient.ListFacInfoReq listFacInfo)
        {
            return axlPortClient15.listFacInfoAsync(listFacInfo);
        }

        public AxlNetClient.StandardResponse addHuntList(AxlNetClient.AddHuntListReq addHuntList1)
        {
            return axlPortClient15.addHuntList(addHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHuntListResponse> addHuntListAsync(AxlNetClient.AddHuntListReq addHuntList)
        {
            return axlPortClient15.addHuntListAsync(addHuntList);
        }

        public AxlNetClient.StandardResponse updateHuntList(AxlNetClient.UpdateHuntListReq updateHuntList1)
        {
            return axlPortClient15.updateHuntList(updateHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHuntListResponse> updateHuntListAsync(AxlNetClient.UpdateHuntListReq updateHuntList)
        {
            return axlPortClient15.updateHuntListAsync(updateHuntList);
        }

        public AxlNetClient.GetHuntListRes getHuntList(AxlNetClient.GetHuntListReq getHuntList1)
        {
            return axlPortClient15.getHuntList(getHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHuntListResponse> getHuntListAsync(AxlNetClient.GetHuntListReq getHuntList)
        {
            return axlPortClient15.getHuntListAsync(getHuntList);
        }

        public AxlNetClient.StandardResponse removeHuntList(AxlNetClient.NameAndGUIDRequest removeHuntList1)
        {
            return axlPortClient15.removeHuntList(removeHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHuntListResponse> removeHuntListAsync(AxlNetClient.NameAndGUIDRequest removeHuntList)
        {
            return axlPortClient15.removeHuntListAsync(removeHuntList);
        }

        public AxlNetClient.ListHuntListRes listHuntList(AxlNetClient.ListHuntListReq listHuntList1)
        {
            return axlPortClient15.listHuntList(listHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listHuntListResponse> listHuntListAsync(AxlNetClient.ListHuntListReq listHuntList)
        {
            return axlPortClient15.listHuntListAsync(listHuntList);
        }

        public AxlNetClient.StandardResponse resetHuntList(AxlNetClient.NameAndGUIDRequest resetHuntList1)
        {
            return axlPortClient15.resetHuntList(resetHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetHuntListResponse> resetHuntListAsync(AxlNetClient.NameAndGUIDRequest resetHuntList)
        {
            return axlPortClient15.resetHuntListAsync(resetHuntList);
        }

        public AxlNetClient.StandardResponse applyHuntList(AxlNetClient.NameAndGUIDRequest applyHuntList1)
        {
            return axlPortClient15.applyHuntList(applyHuntList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyHuntListResponse> applyHuntListAsync(AxlNetClient.NameAndGUIDRequest applyHuntList)
        {
            return axlPortClient15.applyHuntListAsync(applyHuntList);
        }

        public AxlNetClient.StandardResponse addIvrUserLocale(AxlNetClient.AddIvrUserLocaleReq addIvrUserLocale1)
        {
            return axlPortClient15.addIvrUserLocale(addIvrUserLocale1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addIvrUserLocaleResponse> addIvrUserLocaleAsync(AxlNetClient.AddIvrUserLocaleReq addIvrUserLocale)
        {
            return axlPortClient15.addIvrUserLocaleAsync(addIvrUserLocale);
        }

        public AxlNetClient.StandardResponse updateIvrUserLocale(AxlNetClient.UpdateIvrUserLocaleReq updateIvrUserLocale1)
        {
            return axlPortClient15.updateIvrUserLocale(updateIvrUserLocale1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIvrUserLocaleResponse> updateIvrUserLocaleAsync(AxlNetClient.UpdateIvrUserLocaleReq updateIvrUserLocale)
        {
            return axlPortClient15.updateIvrUserLocaleAsync(updateIvrUserLocale);
        }

        public AxlNetClient.GetIvrUserLocaleRes getIvrUserLocale(AxlNetClient.GetIvrUserLocaleReq getIvrUserLocale1)
        {
            return axlPortClient15.getIvrUserLocale(getIvrUserLocale1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIvrUserLocaleResponse> getIvrUserLocaleAsync(AxlNetClient.GetIvrUserLocaleReq getIvrUserLocale)
        {
            return axlPortClient15.getIvrUserLocaleAsync(getIvrUserLocale);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort15
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFacInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeFacInfoResponse removeFacInfo(AxlNetClient.removeFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeFacInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeFacInfoResponse> removeFacInfoAsync(AxlNetClient.removeFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFacInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listFacInfoResponse listFacInfo(AxlNetClient.listFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listFacInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listFacInfoResponse> listFacInfoAsync(AxlNetClient.listFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addHuntListResponse addHuntList(AxlNetClient.addHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addHuntListResponse> addHuntListAsync(AxlNetClient.addHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateHuntListResponse updateHuntList(AxlNetClient.updateHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateHuntListResponse> updateHuntListAsync(AxlNetClient.updateHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getHuntListResponse getHuntList(AxlNetClient.getHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getHuntListResponse> getHuntListAsync(AxlNetClient.getHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeHuntListResponse removeHuntList(AxlNetClient.removeHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeHuntListResponse> removeHuntListAsync(AxlNetClient.removeHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listHuntListResponse listHuntList(AxlNetClient.listHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listHuntListResponse> listHuntListAsync(AxlNetClient.listHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetHuntListResponse resetHuntList(AxlNetClient.resetHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetHuntListResponse> resetHuntListAsync(AxlNetClient.resetHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyHuntList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyHuntListResponse applyHuntList(AxlNetClient.applyHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyHuntList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyHuntListResponse> applyHuntListAsync(AxlNetClient.applyHuntListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addIvrUserLocale", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addIvrUserLocaleResponse addIvrUserLocale(AxlNetClient.addIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addIvrUserLocale", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addIvrUserLocaleResponse> addIvrUserLocaleAsync(AxlNetClient.addIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIvrUserLocale", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateIvrUserLocaleResponse updateIvrUserLocale(AxlNetClient.updateIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIvrUserLocale", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateIvrUserLocaleResponse> updateIvrUserLocaleAsync(AxlNetClient.updateIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIvrUserLocale", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getIvrUserLocaleResponse getIvrUserLocale(AxlNetClient.getIvrUserLocaleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIvrUserLocale", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getIvrUserLocaleResponse> getIvrUserLocaleAsync(AxlNetClient.getIvrUserLocaleRequest request);
    }

    public class AXLPortClient15 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort15>, AxlNetClient.AXLPort15
    {
        public AXLPortClient15(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeFacInfoResponse AxlNetClient.AXLPort15.removeFacInfo(AxlNetClient.removeFacInfoRequest request)
        {
            return base.Channel.removeFacInfo(request);
        }

        public AxlNetClient.StandardResponse removeFacInfo(AxlNetClient.NameAndGUIDRequest removeFacInfo1)
        {
            AxlNetClient.removeFacInfoRequest inValue = new AxlNetClient.removeFacInfoRequest();
            inValue.removeFacInfo = removeFacInfo1;
            AxlNetClient.removeFacInfoResponse retVal = ((AxlNetClient.AXLPort15)(this)).removeFacInfo(inValue);
            return retVal.removeFacInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeFacInfoResponse> AxlNetClient.AXLPort15.removeFacInfoAsync(AxlNetClient.removeFacInfoRequest request)
        {
            return base.Channel.removeFacInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeFacInfoResponse> removeFacInfoAsync(AxlNetClient.NameAndGUIDRequest removeFacInfo)
        {
            AxlNetClient.removeFacInfoRequest inValue = new AxlNetClient.removeFacInfoRequest();
            inValue.removeFacInfo = removeFacInfo;
            return ((AxlNetClient.AXLPort15)(this)).removeFacInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listFacInfoResponse AxlNetClient.AXLPort15.listFacInfo(AxlNetClient.listFacInfoRequest request)
        {
            return base.Channel.listFacInfo(request);
        }

        public AxlNetClient.ListFacInfoRes listFacInfo(AxlNetClient.ListFacInfoReq listFacInfo1)
        {
            AxlNetClient.listFacInfoRequest inValue = new AxlNetClient.listFacInfoRequest();
            inValue.listFacInfo = listFacInfo1;
            AxlNetClient.listFacInfoResponse retVal = ((AxlNetClient.AXLPort15)(this)).listFacInfo(inValue);
            return retVal.listFacInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listFacInfoResponse> AxlNetClient.AXLPort15.listFacInfoAsync(AxlNetClient.listFacInfoRequest request)
        {
            return base.Channel.listFacInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listFacInfoResponse> listFacInfoAsync(AxlNetClient.ListFacInfoReq listFacInfo)
        {
            AxlNetClient.listFacInfoRequest inValue = new AxlNetClient.listFacInfoRequest();
            inValue.listFacInfo = listFacInfo;
            return ((AxlNetClient.AXLPort15)(this)).listFacInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addHuntListResponse AxlNetClient.AXLPort15.addHuntList(AxlNetClient.addHuntListRequest request)
        {
            return base.Channel.addHuntList(request);
        }

        public AxlNetClient.StandardResponse addHuntList(AxlNetClient.AddHuntListReq addHuntList1)
        {
            AxlNetClient.addHuntListRequest inValue = new AxlNetClient.addHuntListRequest();
            inValue.addHuntList = addHuntList1;
            AxlNetClient.addHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).addHuntList(inValue);
            return retVal.addHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addHuntListResponse> AxlNetClient.AXLPort15.addHuntListAsync(AxlNetClient.addHuntListRequest request)
        {
            return base.Channel.addHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addHuntListResponse> addHuntListAsync(AxlNetClient.AddHuntListReq addHuntList)
        {
            AxlNetClient.addHuntListRequest inValue = new AxlNetClient.addHuntListRequest();
            inValue.addHuntList = addHuntList;
            return ((AxlNetClient.AXLPort15)(this)).addHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateHuntListResponse AxlNetClient.AXLPort15.updateHuntList(AxlNetClient.updateHuntListRequest request)
        {
            return base.Channel.updateHuntList(request);
        }

        public AxlNetClient.StandardResponse updateHuntList(AxlNetClient.UpdateHuntListReq updateHuntList1)
        {
            AxlNetClient.updateHuntListRequest inValue = new AxlNetClient.updateHuntListRequest();
            inValue.updateHuntList = updateHuntList1;
            AxlNetClient.updateHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).updateHuntList(inValue);
            return retVal.updateHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateHuntListResponse> AxlNetClient.AXLPort15.updateHuntListAsync(AxlNetClient.updateHuntListRequest request)
        {
            return base.Channel.updateHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateHuntListResponse> updateHuntListAsync(AxlNetClient.UpdateHuntListReq updateHuntList)
        {
            AxlNetClient.updateHuntListRequest inValue = new AxlNetClient.updateHuntListRequest();
            inValue.updateHuntList = updateHuntList;
            return ((AxlNetClient.AXLPort15)(this)).updateHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getHuntListResponse AxlNetClient.AXLPort15.getHuntList(AxlNetClient.getHuntListRequest request)
        {
            return base.Channel.getHuntList(request);
        }

        public AxlNetClient.GetHuntListRes getHuntList(AxlNetClient.GetHuntListReq getHuntList1)
        {
            AxlNetClient.getHuntListRequest inValue = new AxlNetClient.getHuntListRequest();
            inValue.getHuntList = getHuntList1;
            AxlNetClient.getHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).getHuntList(inValue);
            return retVal.getHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getHuntListResponse> AxlNetClient.AXLPort15.getHuntListAsync(AxlNetClient.getHuntListRequest request)
        {
            return base.Channel.getHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getHuntListResponse> getHuntListAsync(AxlNetClient.GetHuntListReq getHuntList)
        {
            AxlNetClient.getHuntListRequest inValue = new AxlNetClient.getHuntListRequest();
            inValue.getHuntList = getHuntList;
            return ((AxlNetClient.AXLPort15)(this)).getHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeHuntListResponse AxlNetClient.AXLPort15.removeHuntList(AxlNetClient.removeHuntListRequest request)
        {
            return base.Channel.removeHuntList(request);
        }

        public AxlNetClient.StandardResponse removeHuntList(AxlNetClient.NameAndGUIDRequest removeHuntList1)
        {
            AxlNetClient.removeHuntListRequest inValue = new AxlNetClient.removeHuntListRequest();
            inValue.removeHuntList = removeHuntList1;
            AxlNetClient.removeHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).removeHuntList(inValue);
            return retVal.removeHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeHuntListResponse> AxlNetClient.AXLPort15.removeHuntListAsync(AxlNetClient.removeHuntListRequest request)
        {
            return base.Channel.removeHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeHuntListResponse> removeHuntListAsync(AxlNetClient.NameAndGUIDRequest removeHuntList)
        {
            AxlNetClient.removeHuntListRequest inValue = new AxlNetClient.removeHuntListRequest();
            inValue.removeHuntList = removeHuntList;
            return ((AxlNetClient.AXLPort15)(this)).removeHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listHuntListResponse AxlNetClient.AXLPort15.listHuntList(AxlNetClient.listHuntListRequest request)
        {
            return base.Channel.listHuntList(request);
        }

        public AxlNetClient.ListHuntListRes listHuntList(AxlNetClient.ListHuntListReq listHuntList1)
        {
            AxlNetClient.listHuntListRequest inValue = new AxlNetClient.listHuntListRequest();
            inValue.listHuntList = listHuntList1;
            AxlNetClient.listHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).listHuntList(inValue);
            return retVal.listHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listHuntListResponse> AxlNetClient.AXLPort15.listHuntListAsync(AxlNetClient.listHuntListRequest request)
        {
            return base.Channel.listHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listHuntListResponse> listHuntListAsync(AxlNetClient.ListHuntListReq listHuntList)
        {
            AxlNetClient.listHuntListRequest inValue = new AxlNetClient.listHuntListRequest();
            inValue.listHuntList = listHuntList;
            return ((AxlNetClient.AXLPort15)(this)).listHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetHuntListResponse AxlNetClient.AXLPort15.resetHuntList(AxlNetClient.resetHuntListRequest request)
        {
            return base.Channel.resetHuntList(request);
        }

        public AxlNetClient.StandardResponse resetHuntList(AxlNetClient.NameAndGUIDRequest resetHuntList1)
        {
            AxlNetClient.resetHuntListRequest inValue = new AxlNetClient.resetHuntListRequest();
            inValue.resetHuntList = resetHuntList1;
            AxlNetClient.resetHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).resetHuntList(inValue);
            return retVal.resetHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetHuntListResponse> AxlNetClient.AXLPort15.resetHuntListAsync(AxlNetClient.resetHuntListRequest request)
        {
            return base.Channel.resetHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetHuntListResponse> resetHuntListAsync(AxlNetClient.NameAndGUIDRequest resetHuntList)
        {
            AxlNetClient.resetHuntListRequest inValue = new AxlNetClient.resetHuntListRequest();
            inValue.resetHuntList = resetHuntList;
            return ((AxlNetClient.AXLPort15)(this)).resetHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyHuntListResponse AxlNetClient.AXLPort15.applyHuntList(AxlNetClient.applyHuntListRequest request)
        {
            return base.Channel.applyHuntList(request);
        }

        public AxlNetClient.StandardResponse applyHuntList(AxlNetClient.NameAndGUIDRequest applyHuntList1)
        {
            AxlNetClient.applyHuntListRequest inValue = new AxlNetClient.applyHuntListRequest();
            inValue.applyHuntList = applyHuntList1;
            AxlNetClient.applyHuntListResponse retVal = ((AxlNetClient.AXLPort15)(this)).applyHuntList(inValue);
            return retVal.applyHuntListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyHuntListResponse> AxlNetClient.AXLPort15.applyHuntListAsync(AxlNetClient.applyHuntListRequest request)
        {
            return base.Channel.applyHuntListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyHuntListResponse> applyHuntListAsync(AxlNetClient.NameAndGUIDRequest applyHuntList)
        {
            AxlNetClient.applyHuntListRequest inValue = new AxlNetClient.applyHuntListRequest();
            inValue.applyHuntList = applyHuntList;
            return ((AxlNetClient.AXLPort15)(this)).applyHuntListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addIvrUserLocaleResponse AxlNetClient.AXLPort15.addIvrUserLocale(AxlNetClient.addIvrUserLocaleRequest request)
        {
            return base.Channel.addIvrUserLocale(request);
        }

        public AxlNetClient.StandardResponse addIvrUserLocale(AxlNetClient.AddIvrUserLocaleReq addIvrUserLocale1)
        {
            AxlNetClient.addIvrUserLocaleRequest inValue = new AxlNetClient.addIvrUserLocaleRequest();
            inValue.addIvrUserLocale = addIvrUserLocale1;
            AxlNetClient.addIvrUserLocaleResponse retVal = ((AxlNetClient.AXLPort15)(this)).addIvrUserLocale(inValue);
            return retVal.addIvrUserLocaleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addIvrUserLocaleResponse> AxlNetClient.AXLPort15.addIvrUserLocaleAsync(AxlNetClient.addIvrUserLocaleRequest request)
        {
            return base.Channel.addIvrUserLocaleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addIvrUserLocaleResponse> addIvrUserLocaleAsync(AxlNetClient.AddIvrUserLocaleReq addIvrUserLocale)
        {
            AxlNetClient.addIvrUserLocaleRequest inValue = new AxlNetClient.addIvrUserLocaleRequest();
            inValue.addIvrUserLocale = addIvrUserLocale;
            return ((AxlNetClient.AXLPort15)(this)).addIvrUserLocaleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateIvrUserLocaleResponse AxlNetClient.AXLPort15.updateIvrUserLocale(AxlNetClient.updateIvrUserLocaleRequest request)
        {
            return base.Channel.updateIvrUserLocale(request);
        }

        public AxlNetClient.StandardResponse updateIvrUserLocale(AxlNetClient.UpdateIvrUserLocaleReq updateIvrUserLocale1)
        {
            AxlNetClient.updateIvrUserLocaleRequest inValue = new AxlNetClient.updateIvrUserLocaleRequest();
            inValue.updateIvrUserLocale = updateIvrUserLocale1;
            AxlNetClient.updateIvrUserLocaleResponse retVal = ((AxlNetClient.AXLPort15)(this)).updateIvrUserLocale(inValue);
            return retVal.updateIvrUserLocaleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateIvrUserLocaleResponse> AxlNetClient.AXLPort15.updateIvrUserLocaleAsync(AxlNetClient.updateIvrUserLocaleRequest request)
        {
            return base.Channel.updateIvrUserLocaleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIvrUserLocaleResponse> updateIvrUserLocaleAsync(AxlNetClient.UpdateIvrUserLocaleReq updateIvrUserLocale)
        {
            AxlNetClient.updateIvrUserLocaleRequest inValue = new AxlNetClient.updateIvrUserLocaleRequest();
            inValue.updateIvrUserLocale = updateIvrUserLocale;
            return ((AxlNetClient.AXLPort15)(this)).updateIvrUserLocaleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getIvrUserLocaleResponse AxlNetClient.AXLPort15.getIvrUserLocale(AxlNetClient.getIvrUserLocaleRequest request)
        {
            return base.Channel.getIvrUserLocale(request);
        }

        public AxlNetClient.GetIvrUserLocaleRes getIvrUserLocale(AxlNetClient.GetIvrUserLocaleReq getIvrUserLocale1)
        {
            AxlNetClient.getIvrUserLocaleRequest inValue = new AxlNetClient.getIvrUserLocaleRequest();
            inValue.getIvrUserLocale = getIvrUserLocale1;
            AxlNetClient.getIvrUserLocaleResponse retVal = ((AxlNetClient.AXLPort15)(this)).getIvrUserLocale(inValue);
            return retVal.getIvrUserLocaleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getIvrUserLocaleResponse> AxlNetClient.AXLPort15.getIvrUserLocaleAsync(AxlNetClient.getIvrUserLocaleRequest request)
        {
            return base.Channel.getIvrUserLocaleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIvrUserLocaleResponse> getIvrUserLocaleAsync(AxlNetClient.GetIvrUserLocaleReq getIvrUserLocale)
        {
            AxlNetClient.getIvrUserLocaleRequest inValue = new AxlNetClient.getIvrUserLocaleRequest();
            inValue.getIvrUserLocale = getIvrUserLocale;
            return ((AxlNetClient.AXLPort15)(this)).getIvrUserLocaleAsync(inValue);
        }
    }
}