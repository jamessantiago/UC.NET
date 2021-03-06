namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient22 _axlPortClient22;

        private static AXLPortClient22 axlPortClient22 => _axlPortClient22 == null ||
            _axlPortClient22.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient22 = LoadClient22()) : _axlPortClient22;

        private static AXLPortClient22 LoadClient22()
        {
            var client = new AXLPortClient22(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close22;
            OnAbort += Abort22;
            return client;
        }

        private static void Close22(object sender, System.EventArgs e)
        {
            _axlPortClient22.Close();
        }

        private static void Abort22(object sender, System.EventArgs e)
        {
            _axlPortClient22.Abort();
        }

        public AxlNetClient.StandardResponse updateMobileVoiceAccess(AxlNetClient.UpdateMobileVoiceAccessReq updateMobileVoiceAccess1)
        {
            return axlPortClient22.updateMobileVoiceAccess(updateMobileVoiceAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobileVoiceAccessResponse> updateMobileVoiceAccessAsync(AxlNetClient.UpdateMobileVoiceAccessReq updateMobileVoiceAccess)
        {
            return axlPortClient22.updateMobileVoiceAccessAsync(updateMobileVoiceAccess);
        }

        public AxlNetClient.GetMobileVoiceAccessRes getMobileVoiceAccess(AxlNetClient.GetMobileVoiceAccessReq getMobileVoiceAccess1)
        {
            return axlPortClient22.getMobileVoiceAccess(getMobileVoiceAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobileVoiceAccessResponse> getMobileVoiceAccessAsync(AxlNetClient.GetMobileVoiceAccessReq getMobileVoiceAccess)
        {
            return axlPortClient22.getMobileVoiceAccessAsync(getMobileVoiceAccess);
        }

        public AxlNetClient.StandardResponse removeMobileVoiceAccess(AxlNetClient.RemoveMobileVoiceAccessReq removeMobileVoiceAccess1)
        {
            return axlPortClient22.removeMobileVoiceAccess(removeMobileVoiceAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMobileVoiceAccessResponse> removeMobileVoiceAccessAsync(AxlNetClient.RemoveMobileVoiceAccessReq removeMobileVoiceAccess)
        {
            return axlPortClient22.removeMobileVoiceAccessAsync(removeMobileVoiceAccess);
        }

        public AxlNetClient.StandardResponse addRouteList(AxlNetClient.AddRouteListReq addRouteList1)
        {
            return axlPortClient22.addRouteList(addRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteListResponse> addRouteListAsync(AxlNetClient.AddRouteListReq addRouteList)
        {
            return axlPortClient22.addRouteListAsync(addRouteList);
        }

        public AxlNetClient.StandardResponse updateRouteList(AxlNetClient.UpdateRouteListReq updateRouteList1)
        {
            return axlPortClient22.updateRouteList(updateRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteListResponse> updateRouteListAsync(AxlNetClient.UpdateRouteListReq updateRouteList)
        {
            return axlPortClient22.updateRouteListAsync(updateRouteList);
        }

        public AxlNetClient.GetRouteListRes getRouteList(AxlNetClient.GetRouteListReq getRouteList1)
        {
            return axlPortClient22.getRouteList(getRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteListResponse> getRouteListAsync(AxlNetClient.GetRouteListReq getRouteList)
        {
            return axlPortClient22.getRouteListAsync(getRouteList);
        }

        public AxlNetClient.StandardResponse removeRouteList(AxlNetClient.NameAndGUIDRequest removeRouteList1)
        {
            return axlPortClient22.removeRouteList(removeRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteListResponse> removeRouteListAsync(AxlNetClient.NameAndGUIDRequest removeRouteList)
        {
            return axlPortClient22.removeRouteListAsync(removeRouteList);
        }

        public AxlNetClient.ListRouteListRes listRouteList(AxlNetClient.ListRouteListReq listRouteList1)
        {
            return axlPortClient22.listRouteList(listRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteListResponse> listRouteListAsync(AxlNetClient.ListRouteListReq listRouteList)
        {
            return axlPortClient22.listRouteListAsync(listRouteList);
        }

        public AxlNetClient.StandardResponse resetRouteList(AxlNetClient.NameAndGUIDRequest resetRouteList1)
        {
            return axlPortClient22.resetRouteList(resetRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetRouteListResponse> resetRouteListAsync(AxlNetClient.NameAndGUIDRequest resetRouteList)
        {
            return axlPortClient22.resetRouteListAsync(resetRouteList);
        }

        public AxlNetClient.StandardResponse applyRouteList(AxlNetClient.NameAndGUIDRequest applyRouteList1)
        {
            return axlPortClient22.applyRouteList(applyRouteList1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRouteListResponse> applyRouteListAsync(AxlNetClient.NameAndGUIDRequest applyRouteList)
        {
            return axlPortClient22.applyRouteListAsync(applyRouteList);
        }

        public AxlNetClient.StandardResponse addUser(AxlNetClient.AddUserReq addUser1)
        {
            return axlPortClient22.addUser(addUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserResponse> addUserAsync(AxlNetClient.AddUserReq addUser)
        {
            return axlPortClient22.addUserAsync(addUser);
        }

        public AxlNetClient.StandardResponse updateUser(AxlNetClient.UpdateUserReq updateUser1)
        {
            return axlPortClient22.updateUser(updateUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserResponse> updateUserAsync(AxlNetClient.UpdateUserReq updateUser)
        {
            return axlPortClient22.updateUserAsync(updateUser);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort22
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobileVoiceAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMobileVoiceAccessResponse updateMobileVoiceAccess(AxlNetClient.updateMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMobileVoiceAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMobileVoiceAccessResponse> updateMobileVoiceAccessAsync(AxlNetClient.updateMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobileVoiceAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMobileVoiceAccessResponse getMobileVoiceAccess(AxlNetClient.getMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobileVoiceAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMobileVoiceAccessResponse> getMobileVoiceAccessAsync(AxlNetClient.getMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMobileVoiceAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMobileVoiceAccessResponse removeMobileVoiceAccess(AxlNetClient.removeMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMobileVoiceAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMobileVoiceAccessResponse> removeMobileVoiceAccessAsync(AxlNetClient.removeMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRouteListResponse addRouteList(AxlNetClient.addRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRouteListResponse> addRouteListAsync(AxlNetClient.addRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRouteListResponse updateRouteList(AxlNetClient.updateRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteListResponse> updateRouteListAsync(AxlNetClient.updateRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRouteListResponse getRouteList(AxlNetClient.getRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRouteListResponse> getRouteListAsync(AxlNetClient.getRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRouteListResponse removeRouteList(AxlNetClient.removeRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteListResponse> removeRouteListAsync(AxlNetClient.removeRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRouteListResponse listRouteList(AxlNetClient.listRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRouteListResponse> listRouteListAsync(AxlNetClient.listRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetRouteListResponse resetRouteList(AxlNetClient.resetRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetRouteListResponse> resetRouteListAsync(AxlNetClient.resetRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRouteList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyRouteListResponse applyRouteList(AxlNetClient.applyRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyRouteList", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyRouteListResponse> applyRouteListAsync(AxlNetClient.applyRouteListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUserResponse addUser(AxlNetClient.addUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUserResponse> addUserAsync(AxlNetClient.addUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUserResponse updateUser(AxlNetClient.updateUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUserResponse> updateUserAsync(AxlNetClient.updateUserRequest request);
    }

    public class AXLPortClient22 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort22>, AxlNetClient.AXLPort22
    {
        public AXLPortClient22(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMobileVoiceAccessResponse AxlNetClient.AXLPort22.updateMobileVoiceAccess(AxlNetClient.updateMobileVoiceAccessRequest request)
        {
            return base.Channel.updateMobileVoiceAccess(request);
        }

        public AxlNetClient.StandardResponse updateMobileVoiceAccess(AxlNetClient.UpdateMobileVoiceAccessReq updateMobileVoiceAccess1)
        {
            AxlNetClient.updateMobileVoiceAccessRequest inValue = new AxlNetClient.updateMobileVoiceAccessRequest();
            inValue.updateMobileVoiceAccess = updateMobileVoiceAccess1;
            AxlNetClient.updateMobileVoiceAccessResponse retVal = ((AxlNetClient.AXLPort22)(this)).updateMobileVoiceAccess(inValue);
            return retVal.updateMobileVoiceAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMobileVoiceAccessResponse> AxlNetClient.AXLPort22.updateMobileVoiceAccessAsync(AxlNetClient.updateMobileVoiceAccessRequest request)
        {
            return base.Channel.updateMobileVoiceAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMobileVoiceAccessResponse> updateMobileVoiceAccessAsync(AxlNetClient.UpdateMobileVoiceAccessReq updateMobileVoiceAccess)
        {
            AxlNetClient.updateMobileVoiceAccessRequest inValue = new AxlNetClient.updateMobileVoiceAccessRequest();
            inValue.updateMobileVoiceAccess = updateMobileVoiceAccess;
            return ((AxlNetClient.AXLPort22)(this)).updateMobileVoiceAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMobileVoiceAccessResponse AxlNetClient.AXLPort22.getMobileVoiceAccess(AxlNetClient.getMobileVoiceAccessRequest request)
        {
            return base.Channel.getMobileVoiceAccess(request);
        }

        public AxlNetClient.GetMobileVoiceAccessRes getMobileVoiceAccess(AxlNetClient.GetMobileVoiceAccessReq getMobileVoiceAccess1)
        {
            AxlNetClient.getMobileVoiceAccessRequest inValue = new AxlNetClient.getMobileVoiceAccessRequest();
            inValue.getMobileVoiceAccess = getMobileVoiceAccess1;
            AxlNetClient.getMobileVoiceAccessResponse retVal = ((AxlNetClient.AXLPort22)(this)).getMobileVoiceAccess(inValue);
            return retVal.getMobileVoiceAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMobileVoiceAccessResponse> AxlNetClient.AXLPort22.getMobileVoiceAccessAsync(AxlNetClient.getMobileVoiceAccessRequest request)
        {
            return base.Channel.getMobileVoiceAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobileVoiceAccessResponse> getMobileVoiceAccessAsync(AxlNetClient.GetMobileVoiceAccessReq getMobileVoiceAccess)
        {
            AxlNetClient.getMobileVoiceAccessRequest inValue = new AxlNetClient.getMobileVoiceAccessRequest();
            inValue.getMobileVoiceAccess = getMobileVoiceAccess;
            return ((AxlNetClient.AXLPort22)(this)).getMobileVoiceAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMobileVoiceAccessResponse AxlNetClient.AXLPort22.removeMobileVoiceAccess(AxlNetClient.removeMobileVoiceAccessRequest request)
        {
            return base.Channel.removeMobileVoiceAccess(request);
        }

        public AxlNetClient.StandardResponse removeMobileVoiceAccess(AxlNetClient.RemoveMobileVoiceAccessReq removeMobileVoiceAccess1)
        {
            AxlNetClient.removeMobileVoiceAccessRequest inValue = new AxlNetClient.removeMobileVoiceAccessRequest();
            inValue.removeMobileVoiceAccess = removeMobileVoiceAccess1;
            AxlNetClient.removeMobileVoiceAccessResponse retVal = ((AxlNetClient.AXLPort22)(this)).removeMobileVoiceAccess(inValue);
            return retVal.removeMobileVoiceAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMobileVoiceAccessResponse> AxlNetClient.AXLPort22.removeMobileVoiceAccessAsync(AxlNetClient.removeMobileVoiceAccessRequest request)
        {
            return base.Channel.removeMobileVoiceAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMobileVoiceAccessResponse> removeMobileVoiceAccessAsync(AxlNetClient.RemoveMobileVoiceAccessReq removeMobileVoiceAccess)
        {
            AxlNetClient.removeMobileVoiceAccessRequest inValue = new AxlNetClient.removeMobileVoiceAccessRequest();
            inValue.removeMobileVoiceAccess = removeMobileVoiceAccess;
            return ((AxlNetClient.AXLPort22)(this)).removeMobileVoiceAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRouteListResponse AxlNetClient.AXLPort22.addRouteList(AxlNetClient.addRouteListRequest request)
        {
            return base.Channel.addRouteList(request);
        }

        public AxlNetClient.StandardResponse addRouteList(AxlNetClient.AddRouteListReq addRouteList1)
        {
            AxlNetClient.addRouteListRequest inValue = new AxlNetClient.addRouteListRequest();
            inValue.addRouteList = addRouteList1;
            AxlNetClient.addRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).addRouteList(inValue);
            return retVal.addRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRouteListResponse> AxlNetClient.AXLPort22.addRouteListAsync(AxlNetClient.addRouteListRequest request)
        {
            return base.Channel.addRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteListResponse> addRouteListAsync(AxlNetClient.AddRouteListReq addRouteList)
        {
            AxlNetClient.addRouteListRequest inValue = new AxlNetClient.addRouteListRequest();
            inValue.addRouteList = addRouteList;
            return ((AxlNetClient.AXLPort22)(this)).addRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRouteListResponse AxlNetClient.AXLPort22.updateRouteList(AxlNetClient.updateRouteListRequest request)
        {
            return base.Channel.updateRouteList(request);
        }

        public AxlNetClient.StandardResponse updateRouteList(AxlNetClient.UpdateRouteListReq updateRouteList1)
        {
            AxlNetClient.updateRouteListRequest inValue = new AxlNetClient.updateRouteListRequest();
            inValue.updateRouteList = updateRouteList1;
            AxlNetClient.updateRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).updateRouteList(inValue);
            return retVal.updateRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteListResponse> AxlNetClient.AXLPort22.updateRouteListAsync(AxlNetClient.updateRouteListRequest request)
        {
            return base.Channel.updateRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteListResponse> updateRouteListAsync(AxlNetClient.UpdateRouteListReq updateRouteList)
        {
            AxlNetClient.updateRouteListRequest inValue = new AxlNetClient.updateRouteListRequest();
            inValue.updateRouteList = updateRouteList;
            return ((AxlNetClient.AXLPort22)(this)).updateRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRouteListResponse AxlNetClient.AXLPort22.getRouteList(AxlNetClient.getRouteListRequest request)
        {
            return base.Channel.getRouteList(request);
        }

        public AxlNetClient.GetRouteListRes getRouteList(AxlNetClient.GetRouteListReq getRouteList1)
        {
            AxlNetClient.getRouteListRequest inValue = new AxlNetClient.getRouteListRequest();
            inValue.getRouteList = getRouteList1;
            AxlNetClient.getRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).getRouteList(inValue);
            return retVal.getRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRouteListResponse> AxlNetClient.AXLPort22.getRouteListAsync(AxlNetClient.getRouteListRequest request)
        {
            return base.Channel.getRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteListResponse> getRouteListAsync(AxlNetClient.GetRouteListReq getRouteList)
        {
            AxlNetClient.getRouteListRequest inValue = new AxlNetClient.getRouteListRequest();
            inValue.getRouteList = getRouteList;
            return ((AxlNetClient.AXLPort22)(this)).getRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRouteListResponse AxlNetClient.AXLPort22.removeRouteList(AxlNetClient.removeRouteListRequest request)
        {
            return base.Channel.removeRouteList(request);
        }

        public AxlNetClient.StandardResponse removeRouteList(AxlNetClient.NameAndGUIDRequest removeRouteList1)
        {
            AxlNetClient.removeRouteListRequest inValue = new AxlNetClient.removeRouteListRequest();
            inValue.removeRouteList = removeRouteList1;
            AxlNetClient.removeRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).removeRouteList(inValue);
            return retVal.removeRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteListResponse> AxlNetClient.AXLPort22.removeRouteListAsync(AxlNetClient.removeRouteListRequest request)
        {
            return base.Channel.removeRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteListResponse> removeRouteListAsync(AxlNetClient.NameAndGUIDRequest removeRouteList)
        {
            AxlNetClient.removeRouteListRequest inValue = new AxlNetClient.removeRouteListRequest();
            inValue.removeRouteList = removeRouteList;
            return ((AxlNetClient.AXLPort22)(this)).removeRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRouteListResponse AxlNetClient.AXLPort22.listRouteList(AxlNetClient.listRouteListRequest request)
        {
            return base.Channel.listRouteList(request);
        }

        public AxlNetClient.ListRouteListRes listRouteList(AxlNetClient.ListRouteListReq listRouteList1)
        {
            AxlNetClient.listRouteListRequest inValue = new AxlNetClient.listRouteListRequest();
            inValue.listRouteList = listRouteList1;
            AxlNetClient.listRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).listRouteList(inValue);
            return retVal.listRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRouteListResponse> AxlNetClient.AXLPort22.listRouteListAsync(AxlNetClient.listRouteListRequest request)
        {
            return base.Channel.listRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteListResponse> listRouteListAsync(AxlNetClient.ListRouteListReq listRouteList)
        {
            AxlNetClient.listRouteListRequest inValue = new AxlNetClient.listRouteListRequest();
            inValue.listRouteList = listRouteList;
            return ((AxlNetClient.AXLPort22)(this)).listRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetRouteListResponse AxlNetClient.AXLPort22.resetRouteList(AxlNetClient.resetRouteListRequest request)
        {
            return base.Channel.resetRouteList(request);
        }

        public AxlNetClient.StandardResponse resetRouteList(AxlNetClient.NameAndGUIDRequest resetRouteList1)
        {
            AxlNetClient.resetRouteListRequest inValue = new AxlNetClient.resetRouteListRequest();
            inValue.resetRouteList = resetRouteList1;
            AxlNetClient.resetRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).resetRouteList(inValue);
            return retVal.resetRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetRouteListResponse> AxlNetClient.AXLPort22.resetRouteListAsync(AxlNetClient.resetRouteListRequest request)
        {
            return base.Channel.resetRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetRouteListResponse> resetRouteListAsync(AxlNetClient.NameAndGUIDRequest resetRouteList)
        {
            AxlNetClient.resetRouteListRequest inValue = new AxlNetClient.resetRouteListRequest();
            inValue.resetRouteList = resetRouteList;
            return ((AxlNetClient.AXLPort22)(this)).resetRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyRouteListResponse AxlNetClient.AXLPort22.applyRouteList(AxlNetClient.applyRouteListRequest request)
        {
            return base.Channel.applyRouteList(request);
        }

        public AxlNetClient.StandardResponse applyRouteList(AxlNetClient.NameAndGUIDRequest applyRouteList1)
        {
            AxlNetClient.applyRouteListRequest inValue = new AxlNetClient.applyRouteListRequest();
            inValue.applyRouteList = applyRouteList1;
            AxlNetClient.applyRouteListResponse retVal = ((AxlNetClient.AXLPort22)(this)).applyRouteList(inValue);
            return retVal.applyRouteListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyRouteListResponse> AxlNetClient.AXLPort22.applyRouteListAsync(AxlNetClient.applyRouteListRequest request)
        {
            return base.Channel.applyRouteListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyRouteListResponse> applyRouteListAsync(AxlNetClient.NameAndGUIDRequest applyRouteList)
        {
            AxlNetClient.applyRouteListRequest inValue = new AxlNetClient.applyRouteListRequest();
            inValue.applyRouteList = applyRouteList;
            return ((AxlNetClient.AXLPort22)(this)).applyRouteListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUserResponse AxlNetClient.AXLPort22.addUser(AxlNetClient.addUserRequest request)
        {
            return base.Channel.addUser(request);
        }

        public AxlNetClient.StandardResponse addUser(AxlNetClient.AddUserReq addUser1)
        {
            AxlNetClient.addUserRequest inValue = new AxlNetClient.addUserRequest();
            inValue.addUser = addUser1;
            AxlNetClient.addUserResponse retVal = ((AxlNetClient.AXLPort22)(this)).addUser(inValue);
            return retVal.addUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUserResponse> AxlNetClient.AXLPort22.addUserAsync(AxlNetClient.addUserRequest request)
        {
            return base.Channel.addUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserResponse> addUserAsync(AxlNetClient.AddUserReq addUser)
        {
            AxlNetClient.addUserRequest inValue = new AxlNetClient.addUserRequest();
            inValue.addUser = addUser;
            return ((AxlNetClient.AXLPort22)(this)).addUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUserResponse AxlNetClient.AXLPort22.updateUser(AxlNetClient.updateUserRequest request)
        {
            return base.Channel.updateUser(request);
        }

        public AxlNetClient.StandardResponse updateUser(AxlNetClient.UpdateUserReq updateUser1)
        {
            AxlNetClient.updateUserRequest inValue = new AxlNetClient.updateUserRequest();
            inValue.updateUser = updateUser1;
            AxlNetClient.updateUserResponse retVal = ((AxlNetClient.AXLPort22)(this)).updateUser(inValue);
            return retVal.updateUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUserResponse> AxlNetClient.AXLPort22.updateUserAsync(AxlNetClient.updateUserRequest request)
        {
            return base.Channel.updateUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserResponse> updateUserAsync(AxlNetClient.UpdateUserReq updateUser)
        {
            AxlNetClient.updateUserRequest inValue = new AxlNetClient.updateUserRequest();
            inValue.updateUser = updateUser;
            return ((AxlNetClient.AXLPort22)(this)).updateUserAsync(inValue);
        }
    }
}