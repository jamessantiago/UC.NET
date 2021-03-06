namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient23 _axlPortClient23;

        private static AXLPortClient23 axlPortClient23 => _axlPortClient23 == null ||
            _axlPortClient23.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient23 = LoadClient23()) : _axlPortClient23;

        private static AXLPortClient23 LoadClient23()
        {
            var client = new AXLPortClient23(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close23;
            OnAbort += Abort23;
            return client;
        }

        private static void Close23(object sender, System.EventArgs e)
        {
            _axlPortClient23.Close();
        }

        private static void Abort23(object sender, System.EventArgs e)
        {
            _axlPortClient23.Abort();
        }

        public AxlNetClient.GetUserRes getUser(AxlNetClient.GetUserReq getUser1)
        {
            return axlPortClient23.getUser(getUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserResponse> getUserAsync(AxlNetClient.GetUserReq getUser)
        {
            return axlPortClient23.getUserAsync(getUser);
        }

        public AxlNetClient.StandardResponse removeUser(AxlNetClient.RemoveUserReq removeUser1)
        {
            return axlPortClient23.removeUser(removeUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserResponse> removeUserAsync(AxlNetClient.RemoveUserReq removeUser)
        {
            return axlPortClient23.removeUserAsync(removeUser);
        }

        public AxlNetClient.ListUserRes listUser(AxlNetClient.ListUserReq listUser1)
        {
            return axlPortClient23.listUser(listUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserResponse> listUserAsync(AxlNetClient.ListUserReq listUser)
        {
            return axlPortClient23.listUserAsync(listUser);
        }

        public AxlNetClient.StandardResponse addAppUser(AxlNetClient.AddAppUserReq addAppUser1)
        {
            return axlPortClient23.addAppUser(addAppUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAppUserResponse> addAppUserAsync(AxlNetClient.AddAppUserReq addAppUser)
        {
            return axlPortClient23.addAppUserAsync(addAppUser);
        }

        public AxlNetClient.StandardResponse updateAppUser(AxlNetClient.UpdateAppUserReq updateAppUser1)
        {
            return axlPortClient23.updateAppUser(updateAppUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAppUserResponse> updateAppUserAsync(AxlNetClient.UpdateAppUserReq updateAppUser)
        {
            return axlPortClient23.updateAppUserAsync(updateAppUser);
        }

        public AxlNetClient.GetAppUserRes getAppUser(AxlNetClient.GetAppUserReq getAppUser1)
        {
            return axlPortClient23.getAppUser(getAppUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAppUserResponse> getAppUserAsync(AxlNetClient.GetAppUserReq getAppUser)
        {
            return axlPortClient23.getAppUserAsync(getAppUser);
        }

        public AxlNetClient.StandardResponse removeAppUser(AxlNetClient.RemoveAppUserReq removeAppUser1)
        {
            return axlPortClient23.removeAppUser(removeAppUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAppUserResponse> removeAppUserAsync(AxlNetClient.RemoveAppUserReq removeAppUser)
        {
            return axlPortClient23.removeAppUserAsync(removeAppUser);
        }

        public AxlNetClient.ListAppUserRes listAppUser(AxlNetClient.ListAppUserReq listAppUser1)
        {
            return axlPortClient23.listAppUser(listAppUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAppUserResponse> listAppUserAsync(AxlNetClient.ListAppUserReq listAppUser)
        {
            return axlPortClient23.listAppUserAsync(listAppUser);
        }

        public AxlNetClient.StandardResponse addSipRealm(AxlNetClient.AddSipRealmReq addSipRealm1)
        {
            return axlPortClient23.addSipRealm(addSipRealm1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipRealmResponse> addSipRealmAsync(AxlNetClient.AddSipRealmReq addSipRealm)
        {
            return axlPortClient23.addSipRealmAsync(addSipRealm);
        }

        public AxlNetClient.StandardResponse updateSipRealm(AxlNetClient.UpdateSipRealmReq updateSipRealm1)
        {
            return axlPortClient23.updateSipRealm(updateSipRealm1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipRealmResponse> updateSipRealmAsync(AxlNetClient.UpdateSipRealmReq updateSipRealm)
        {
            return axlPortClient23.updateSipRealmAsync(updateSipRealm);
        }

        public AxlNetClient.GetSipRealmRes getSipRealm(AxlNetClient.GetSipRealmReq getSipRealm1)
        {
            return axlPortClient23.getSipRealm(getSipRealm1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipRealmResponse> getSipRealmAsync(AxlNetClient.GetSipRealmReq getSipRealm)
        {
            return axlPortClient23.getSipRealmAsync(getSipRealm);
        }

        public AxlNetClient.StandardResponse removeSipRealm(AxlNetClient.RemoveSipRealmReq removeSipRealm1)
        {
            return axlPortClient23.removeSipRealm(removeSipRealm1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipRealmResponse> removeSipRealmAsync(AxlNetClient.RemoveSipRealmReq removeSipRealm)
        {
            return axlPortClient23.removeSipRealmAsync(removeSipRealm);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort23
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUserResponse getUser(AxlNetClient.getUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUserResponse> getUserAsync(AxlNetClient.getUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUserResponse removeUser(AxlNetClient.removeUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUserResponse> removeUserAsync(AxlNetClient.removeUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUserResponse listUser(AxlNetClient.listUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUserResponse> listUserAsync(AxlNetClient.listUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAppUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addAppUserResponse addAppUser(AxlNetClient.addAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addAppUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addAppUserResponse> addAppUserAsync(AxlNetClient.addAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAppUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateAppUserResponse updateAppUser(AxlNetClient.updateAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateAppUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateAppUserResponse> updateAppUserAsync(AxlNetClient.updateAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAppUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getAppUserResponse getAppUser(AxlNetClient.getAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getAppUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getAppUserResponse> getAppUserAsync(AxlNetClient.getAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAppUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeAppUserResponse removeAppUser(AxlNetClient.removeAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeAppUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeAppUserResponse> removeAppUserAsync(AxlNetClient.removeAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAppUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAppUserResponse listAppUser(AxlNetClient.listAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAppUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAppUserResponse> listAppUserAsync(AxlNetClient.listAppUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipRealm", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipRealmResponse addSipRealm(AxlNetClient.addSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipRealm", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipRealmResponse> addSipRealmAsync(AxlNetClient.addSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipRealm", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipRealmResponse updateSipRealm(AxlNetClient.updateSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipRealm", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipRealmResponse> updateSipRealmAsync(AxlNetClient.updateSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipRealm", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipRealmResponse getSipRealm(AxlNetClient.getSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipRealm", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipRealmResponse> getSipRealmAsync(AxlNetClient.getSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipRealm", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipRealmResponse removeSipRealm(AxlNetClient.removeSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipRealm", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipRealmResponse> removeSipRealmAsync(AxlNetClient.removeSipRealmRequest request);
    }

    public class AXLPortClient23 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort23>, AxlNetClient.AXLPort23
    {
        public AXLPortClient23(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUserResponse AxlNetClient.AXLPort23.getUser(AxlNetClient.getUserRequest request)
        {
            return base.Channel.getUser(request);
        }

        public AxlNetClient.GetUserRes getUser(AxlNetClient.GetUserReq getUser1)
        {
            AxlNetClient.getUserRequest inValue = new AxlNetClient.getUserRequest();
            inValue.getUser = getUser1;
            AxlNetClient.getUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).getUser(inValue);
            return retVal.getUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUserResponse> AxlNetClient.AXLPort23.getUserAsync(AxlNetClient.getUserRequest request)
        {
            return base.Channel.getUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserResponse> getUserAsync(AxlNetClient.GetUserReq getUser)
        {
            AxlNetClient.getUserRequest inValue = new AxlNetClient.getUserRequest();
            inValue.getUser = getUser;
            return ((AxlNetClient.AXLPort23)(this)).getUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUserResponse AxlNetClient.AXLPort23.removeUser(AxlNetClient.removeUserRequest request)
        {
            return base.Channel.removeUser(request);
        }

        public AxlNetClient.StandardResponse removeUser(AxlNetClient.RemoveUserReq removeUser1)
        {
            AxlNetClient.removeUserRequest inValue = new AxlNetClient.removeUserRequest();
            inValue.removeUser = removeUser1;
            AxlNetClient.removeUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).removeUser(inValue);
            return retVal.removeUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUserResponse> AxlNetClient.AXLPort23.removeUserAsync(AxlNetClient.removeUserRequest request)
        {
            return base.Channel.removeUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserResponse> removeUserAsync(AxlNetClient.RemoveUserReq removeUser)
        {
            AxlNetClient.removeUserRequest inValue = new AxlNetClient.removeUserRequest();
            inValue.removeUser = removeUser;
            return ((AxlNetClient.AXLPort23)(this)).removeUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUserResponse AxlNetClient.AXLPort23.listUser(AxlNetClient.listUserRequest request)
        {
            return base.Channel.listUser(request);
        }

        public AxlNetClient.ListUserRes listUser(AxlNetClient.ListUserReq listUser1)
        {
            AxlNetClient.listUserRequest inValue = new AxlNetClient.listUserRequest();
            inValue.listUser = listUser1;
            AxlNetClient.listUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).listUser(inValue);
            return retVal.listUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUserResponse> AxlNetClient.AXLPort23.listUserAsync(AxlNetClient.listUserRequest request)
        {
            return base.Channel.listUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserResponse> listUserAsync(AxlNetClient.ListUserReq listUser)
        {
            AxlNetClient.listUserRequest inValue = new AxlNetClient.listUserRequest();
            inValue.listUser = listUser;
            return ((AxlNetClient.AXLPort23)(this)).listUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addAppUserResponse AxlNetClient.AXLPort23.addAppUser(AxlNetClient.addAppUserRequest request)
        {
            return base.Channel.addAppUser(request);
        }

        public AxlNetClient.StandardResponse addAppUser(AxlNetClient.AddAppUserReq addAppUser1)
        {
            AxlNetClient.addAppUserRequest inValue = new AxlNetClient.addAppUserRequest();
            inValue.addAppUser = addAppUser1;
            AxlNetClient.addAppUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).addAppUser(inValue);
            return retVal.addAppUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addAppUserResponse> AxlNetClient.AXLPort23.addAppUserAsync(AxlNetClient.addAppUserRequest request)
        {
            return base.Channel.addAppUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addAppUserResponse> addAppUserAsync(AxlNetClient.AddAppUserReq addAppUser)
        {
            AxlNetClient.addAppUserRequest inValue = new AxlNetClient.addAppUserRequest();
            inValue.addAppUser = addAppUser;
            return ((AxlNetClient.AXLPort23)(this)).addAppUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateAppUserResponse AxlNetClient.AXLPort23.updateAppUser(AxlNetClient.updateAppUserRequest request)
        {
            return base.Channel.updateAppUser(request);
        }

        public AxlNetClient.StandardResponse updateAppUser(AxlNetClient.UpdateAppUserReq updateAppUser1)
        {
            AxlNetClient.updateAppUserRequest inValue = new AxlNetClient.updateAppUserRequest();
            inValue.updateAppUser = updateAppUser1;
            AxlNetClient.updateAppUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).updateAppUser(inValue);
            return retVal.updateAppUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateAppUserResponse> AxlNetClient.AXLPort23.updateAppUserAsync(AxlNetClient.updateAppUserRequest request)
        {
            return base.Channel.updateAppUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateAppUserResponse> updateAppUserAsync(AxlNetClient.UpdateAppUserReq updateAppUser)
        {
            AxlNetClient.updateAppUserRequest inValue = new AxlNetClient.updateAppUserRequest();
            inValue.updateAppUser = updateAppUser;
            return ((AxlNetClient.AXLPort23)(this)).updateAppUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getAppUserResponse AxlNetClient.AXLPort23.getAppUser(AxlNetClient.getAppUserRequest request)
        {
            return base.Channel.getAppUser(request);
        }

        public AxlNetClient.GetAppUserRes getAppUser(AxlNetClient.GetAppUserReq getAppUser1)
        {
            AxlNetClient.getAppUserRequest inValue = new AxlNetClient.getAppUserRequest();
            inValue.getAppUser = getAppUser1;
            AxlNetClient.getAppUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).getAppUser(inValue);
            return retVal.getAppUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getAppUserResponse> AxlNetClient.AXLPort23.getAppUserAsync(AxlNetClient.getAppUserRequest request)
        {
            return base.Channel.getAppUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getAppUserResponse> getAppUserAsync(AxlNetClient.GetAppUserReq getAppUser)
        {
            AxlNetClient.getAppUserRequest inValue = new AxlNetClient.getAppUserRequest();
            inValue.getAppUser = getAppUser;
            return ((AxlNetClient.AXLPort23)(this)).getAppUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeAppUserResponse AxlNetClient.AXLPort23.removeAppUser(AxlNetClient.removeAppUserRequest request)
        {
            return base.Channel.removeAppUser(request);
        }

        public AxlNetClient.StandardResponse removeAppUser(AxlNetClient.RemoveAppUserReq removeAppUser1)
        {
            AxlNetClient.removeAppUserRequest inValue = new AxlNetClient.removeAppUserRequest();
            inValue.removeAppUser = removeAppUser1;
            AxlNetClient.removeAppUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).removeAppUser(inValue);
            return retVal.removeAppUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeAppUserResponse> AxlNetClient.AXLPort23.removeAppUserAsync(AxlNetClient.removeAppUserRequest request)
        {
            return base.Channel.removeAppUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeAppUserResponse> removeAppUserAsync(AxlNetClient.RemoveAppUserReq removeAppUser)
        {
            AxlNetClient.removeAppUserRequest inValue = new AxlNetClient.removeAppUserRequest();
            inValue.removeAppUser = removeAppUser;
            return ((AxlNetClient.AXLPort23)(this)).removeAppUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAppUserResponse AxlNetClient.AXLPort23.listAppUser(AxlNetClient.listAppUserRequest request)
        {
            return base.Channel.listAppUser(request);
        }

        public AxlNetClient.ListAppUserRes listAppUser(AxlNetClient.ListAppUserReq listAppUser1)
        {
            AxlNetClient.listAppUserRequest inValue = new AxlNetClient.listAppUserRequest();
            inValue.listAppUser = listAppUser1;
            AxlNetClient.listAppUserResponse retVal = ((AxlNetClient.AXLPort23)(this)).listAppUser(inValue);
            return retVal.listAppUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAppUserResponse> AxlNetClient.AXLPort23.listAppUserAsync(AxlNetClient.listAppUserRequest request)
        {
            return base.Channel.listAppUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAppUserResponse> listAppUserAsync(AxlNetClient.ListAppUserReq listAppUser)
        {
            AxlNetClient.listAppUserRequest inValue = new AxlNetClient.listAppUserRequest();
            inValue.listAppUser = listAppUser;
            return ((AxlNetClient.AXLPort23)(this)).listAppUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipRealmResponse AxlNetClient.AXLPort23.addSipRealm(AxlNetClient.addSipRealmRequest request)
        {
            return base.Channel.addSipRealm(request);
        }

        public AxlNetClient.StandardResponse addSipRealm(AxlNetClient.AddSipRealmReq addSipRealm1)
        {
            AxlNetClient.addSipRealmRequest inValue = new AxlNetClient.addSipRealmRequest();
            inValue.addSipRealm = addSipRealm1;
            AxlNetClient.addSipRealmResponse retVal = ((AxlNetClient.AXLPort23)(this)).addSipRealm(inValue);
            return retVal.addSipRealmResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipRealmResponse> AxlNetClient.AXLPort23.addSipRealmAsync(AxlNetClient.addSipRealmRequest request)
        {
            return base.Channel.addSipRealmAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipRealmResponse> addSipRealmAsync(AxlNetClient.AddSipRealmReq addSipRealm)
        {
            AxlNetClient.addSipRealmRequest inValue = new AxlNetClient.addSipRealmRequest();
            inValue.addSipRealm = addSipRealm;
            return ((AxlNetClient.AXLPort23)(this)).addSipRealmAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipRealmResponse AxlNetClient.AXLPort23.updateSipRealm(AxlNetClient.updateSipRealmRequest request)
        {
            return base.Channel.updateSipRealm(request);
        }

        public AxlNetClient.StandardResponse updateSipRealm(AxlNetClient.UpdateSipRealmReq updateSipRealm1)
        {
            AxlNetClient.updateSipRealmRequest inValue = new AxlNetClient.updateSipRealmRequest();
            inValue.updateSipRealm = updateSipRealm1;
            AxlNetClient.updateSipRealmResponse retVal = ((AxlNetClient.AXLPort23)(this)).updateSipRealm(inValue);
            return retVal.updateSipRealmResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipRealmResponse> AxlNetClient.AXLPort23.updateSipRealmAsync(AxlNetClient.updateSipRealmRequest request)
        {
            return base.Channel.updateSipRealmAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipRealmResponse> updateSipRealmAsync(AxlNetClient.UpdateSipRealmReq updateSipRealm)
        {
            AxlNetClient.updateSipRealmRequest inValue = new AxlNetClient.updateSipRealmRequest();
            inValue.updateSipRealm = updateSipRealm;
            return ((AxlNetClient.AXLPort23)(this)).updateSipRealmAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipRealmResponse AxlNetClient.AXLPort23.getSipRealm(AxlNetClient.getSipRealmRequest request)
        {
            return base.Channel.getSipRealm(request);
        }

        public AxlNetClient.GetSipRealmRes getSipRealm(AxlNetClient.GetSipRealmReq getSipRealm1)
        {
            AxlNetClient.getSipRealmRequest inValue = new AxlNetClient.getSipRealmRequest();
            inValue.getSipRealm = getSipRealm1;
            AxlNetClient.getSipRealmResponse retVal = ((AxlNetClient.AXLPort23)(this)).getSipRealm(inValue);
            return retVal.getSipRealmResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipRealmResponse> AxlNetClient.AXLPort23.getSipRealmAsync(AxlNetClient.getSipRealmRequest request)
        {
            return base.Channel.getSipRealmAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipRealmResponse> getSipRealmAsync(AxlNetClient.GetSipRealmReq getSipRealm)
        {
            AxlNetClient.getSipRealmRequest inValue = new AxlNetClient.getSipRealmRequest();
            inValue.getSipRealm = getSipRealm;
            return ((AxlNetClient.AXLPort23)(this)).getSipRealmAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipRealmResponse AxlNetClient.AXLPort23.removeSipRealm(AxlNetClient.removeSipRealmRequest request)
        {
            return base.Channel.removeSipRealm(request);
        }

        public AxlNetClient.StandardResponse removeSipRealm(AxlNetClient.RemoveSipRealmReq removeSipRealm1)
        {
            AxlNetClient.removeSipRealmRequest inValue = new AxlNetClient.removeSipRealmRequest();
            inValue.removeSipRealm = removeSipRealm1;
            AxlNetClient.removeSipRealmResponse retVal = ((AxlNetClient.AXLPort23)(this)).removeSipRealm(inValue);
            return retVal.removeSipRealmResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipRealmResponse> AxlNetClient.AXLPort23.removeSipRealmAsync(AxlNetClient.removeSipRealmRequest request)
        {
            return base.Channel.removeSipRealmAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipRealmResponse> removeSipRealmAsync(AxlNetClient.RemoveSipRealmReq removeSipRealm)
        {
            AxlNetClient.removeSipRealmRequest inValue = new AxlNetClient.removeSipRealmRequest();
            inValue.removeSipRealm = removeSipRealm;
            return ((AxlNetClient.AXLPort23)(this)).removeSipRealmAsync(inValue);
        }
    }
}