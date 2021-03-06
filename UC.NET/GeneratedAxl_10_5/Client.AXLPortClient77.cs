namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient77 _axlPortClient77;

        private static AXLPortClient77 axlPortClient77 => _axlPortClient77 == null ||
            _axlPortClient77.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient77 = LoadClient77()) : _axlPortClient77;

        private static AXLPortClient77 LoadClient77()
        {
            var client = new AXLPortClient77(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close77;
            OnAbort += Abort77;
            return client;
        }

        private static void Close77(object sender, System.EventArgs e)
        {
            _axlPortClient77.Close();
        }

        private static void Abort77(object sender, System.EventArgs e)
        {
            _axlPortClient77.Abort();
        }

        public AxlNetClient.StandardResponse updateNetworkAccessProfile(AxlNetClient.UpdateNetworkAccessProfileReq updateNetworkAccessProfile1)
        {
            return axlPortClient77.updateNetworkAccessProfile(updateNetworkAccessProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateNetworkAccessProfileResponse> updateNetworkAccessProfileAsync(AxlNetClient.UpdateNetworkAccessProfileReq updateNetworkAccessProfile)
        {
            return axlPortClient77.updateNetworkAccessProfileAsync(updateNetworkAccessProfile);
        }

        public AxlNetClient.GetNetworkAccessProfileRes getNetworkAccessProfile(AxlNetClient.GetNetworkAccessProfileReq getNetworkAccessProfile1)
        {
            return axlPortClient77.getNetworkAccessProfile(getNetworkAccessProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getNetworkAccessProfileResponse> getNetworkAccessProfileAsync(AxlNetClient.GetNetworkAccessProfileReq getNetworkAccessProfile)
        {
            return axlPortClient77.getNetworkAccessProfileAsync(getNetworkAccessProfile);
        }

        public AxlNetClient.StandardResponse removeNetworkAccessProfile(AxlNetClient.NameAndGUIDRequest removeNetworkAccessProfile1)
        {
            return axlPortClient77.removeNetworkAccessProfile(removeNetworkAccessProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeNetworkAccessProfileResponse> removeNetworkAccessProfileAsync(AxlNetClient.NameAndGUIDRequest removeNetworkAccessProfile)
        {
            return axlPortClient77.removeNetworkAccessProfileAsync(removeNetworkAccessProfile);
        }

        public AxlNetClient.ListNetworkAccessProfileRes listNetworkAccessProfile(AxlNetClient.ListNetworkAccessProfileReq listNetworkAccessProfile1)
        {
            return axlPortClient77.listNetworkAccessProfile(listNetworkAccessProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listNetworkAccessProfileResponse> listNetworkAccessProfileAsync(AxlNetClient.ListNetworkAccessProfileReq listNetworkAccessProfile)
        {
            return axlPortClient77.listNetworkAccessProfileAsync(listNetworkAccessProfile);
        }

        public AxlNetClient.GetLicensedUserRes getLicensedUser(AxlNetClient.GetLicensedUserReq getLicensedUser1)
        {
            return axlPortClient77.getLicensedUser(getLicensedUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLicensedUserResponse> getLicensedUserAsync(AxlNetClient.GetLicensedUserReq getLicensedUser)
        {
            return axlPortClient77.getLicensedUserAsync(getLicensedUser);
        }

        public AxlNetClient.ExecuteSQLQueryRes executeSQLQuery(AxlNetClient.ExecuteSQLQueryReq executeSQLQuery1)
        {
            return axlPortClient77.executeSQLQuery(executeSQLQuery1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.executeSQLQueryResponse> executeSQLQueryAsync(AxlNetClient.ExecuteSQLQueryReq executeSQLQuery)
        {
            return axlPortClient77.executeSQLQueryAsync(executeSQLQuery);
        }

        public AxlNetClient.ExecuteSQLUpdateRes executeSQLUpdate(AxlNetClient.ExecuteSQLUpdateReq executeSQLUpdate1)
        {
            return axlPortClient77.executeSQLUpdate(executeSQLUpdate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.executeSQLUpdateResponse> executeSQLUpdateAsync(AxlNetClient.ExecuteSQLUpdateReq executeSQLUpdate)
        {
            return axlPortClient77.executeSQLUpdateAsync(executeSQLUpdate);
        }

        public AxlNetClient.DoAuthenticateUserRes doAuthenticateUser(AxlNetClient.DoAuthenticateUserReq doAuthenticateUser1)
        {
            return axlPortClient77.doAuthenticateUser(doAuthenticateUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doAuthenticateUserResponse> doAuthenticateUserAsync(AxlNetClient.DoAuthenticateUserReq doAuthenticateUser)
        {
            return axlPortClient77.doAuthenticateUserAsync(doAuthenticateUser);
        }

        public AxlNetClient.DoDeviceLoginRes doDeviceLogin(AxlNetClient.DoDeviceLoginReq doDeviceLogin1)
        {
            return axlPortClient77.doDeviceLogin(doDeviceLogin1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceLoginResponse> doDeviceLoginAsync(AxlNetClient.DoDeviceLoginReq doDeviceLogin)
        {
            return axlPortClient77.doDeviceLoginAsync(doDeviceLogin);
        }

        public AxlNetClient.DoDeviceLogoutRes doDeviceLogout(AxlNetClient.DoDeviceLogoutReq doDeviceLogout1)
        {
            return axlPortClient77.doDeviceLogout(doDeviceLogout1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceLogoutResponse> doDeviceLogoutAsync(AxlNetClient.DoDeviceLogoutReq doDeviceLogout)
        {
            return axlPortClient77.doDeviceLogoutAsync(doDeviceLogout);
        }

        public AxlNetClient.DoDeviceResetRes doDeviceReset(AxlNetClient.DoDeviceResetReq doDeviceReset1)
        {
            return axlPortClient77.doDeviceReset(doDeviceReset1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceResetResponse> doDeviceResetAsync(AxlNetClient.DoDeviceResetReq doDeviceReset)
        {
            return axlPortClient77.doDeviceResetAsync(doDeviceReset);
        }

        public AxlNetClient.GetOSVersionRes getOSVersion(AxlNetClient.GetOSVersionReq getOSVersion1)
        {
            return axlPortClient77.getOSVersion(getOSVersion1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getOSVersionResponse> getOSVersionAsync(AxlNetClient.GetOSVersionReq getOSVersion)
        {
            return axlPortClient77.getOSVersionAsync(getOSVersion);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort77
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateNetworkAccessProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateNetworkAccessProfileResponse updateNetworkAccessProfile(AxlNetClient.updateNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateNetworkAccessProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateNetworkAccessProfileResponse> updateNetworkAccessProfileAsync(AxlNetClient.updateNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getNetworkAccessProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getNetworkAccessProfileResponse getNetworkAccessProfile(AxlNetClient.getNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getNetworkAccessProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getNetworkAccessProfileResponse> getNetworkAccessProfileAsync(AxlNetClient.getNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeNetworkAccessProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeNetworkAccessProfileResponse removeNetworkAccessProfile(AxlNetClient.removeNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeNetworkAccessProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeNetworkAccessProfileResponse> removeNetworkAccessProfileAsync(AxlNetClient.removeNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listNetworkAccessProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listNetworkAccessProfileResponse listNetworkAccessProfile(AxlNetClient.listNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listNetworkAccessProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listNetworkAccessProfileResponse> listNetworkAccessProfileAsync(AxlNetClient.listNetworkAccessProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLicensedUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLicensedUserResponse getLicensedUser(AxlNetClient.getLicensedUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLicensedUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLicensedUserResponse> getLicensedUserAsync(AxlNetClient.getLicensedUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 executeSQLQuery", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.executeSQLQueryResponse executeSQLQuery(AxlNetClient.executeSQLQueryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 executeSQLQuery", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.executeSQLQueryResponse> executeSQLQueryAsync(AxlNetClient.executeSQLQueryRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 executeSQLUpdate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.executeSQLUpdateResponse executeSQLUpdate(AxlNetClient.executeSQLUpdateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 executeSQLUpdate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.executeSQLUpdateResponse> executeSQLUpdateAsync(AxlNetClient.executeSQLUpdateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doAuthenticateUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doAuthenticateUserResponse doAuthenticateUser(AxlNetClient.doAuthenticateUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doAuthenticateUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doAuthenticateUserResponse> doAuthenticateUserAsync(AxlNetClient.doAuthenticateUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceLogin", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doDeviceLoginResponse doDeviceLogin(AxlNetClient.doDeviceLoginRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceLogin", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceLoginResponse> doDeviceLoginAsync(AxlNetClient.doDeviceLoginRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceLogout", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doDeviceLogoutResponse doDeviceLogout(AxlNetClient.doDeviceLogoutRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceLogout", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceLogoutResponse> doDeviceLogoutAsync(AxlNetClient.doDeviceLogoutRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceReset", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doDeviceResetResponse doDeviceReset(AxlNetClient.doDeviceResetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doDeviceReset", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceResetResponse> doDeviceResetAsync(AxlNetClient.doDeviceResetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getOSVersion", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getOSVersionResponse getOSVersion(AxlNetClient.getOSVersionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getOSVersion", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getOSVersionResponse> getOSVersionAsync(AxlNetClient.getOSVersionRequest request);
    }

    public class AXLPortClient77 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort77>, AxlNetClient.AXLPort77
    {
        public AXLPortClient77(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateNetworkAccessProfileResponse AxlNetClient.AXLPort77.updateNetworkAccessProfile(AxlNetClient.updateNetworkAccessProfileRequest request)
        {
            return base.Channel.updateNetworkAccessProfile(request);
        }

        public AxlNetClient.StandardResponse updateNetworkAccessProfile(AxlNetClient.UpdateNetworkAccessProfileReq updateNetworkAccessProfile1)
        {
            AxlNetClient.updateNetworkAccessProfileRequest inValue = new AxlNetClient.updateNetworkAccessProfileRequest();
            inValue.updateNetworkAccessProfile = updateNetworkAccessProfile1;
            AxlNetClient.updateNetworkAccessProfileResponse retVal = ((AxlNetClient.AXLPort77)(this)).updateNetworkAccessProfile(inValue);
            return retVal.updateNetworkAccessProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateNetworkAccessProfileResponse> AxlNetClient.AXLPort77.updateNetworkAccessProfileAsync(AxlNetClient.updateNetworkAccessProfileRequest request)
        {
            return base.Channel.updateNetworkAccessProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateNetworkAccessProfileResponse> updateNetworkAccessProfileAsync(AxlNetClient.UpdateNetworkAccessProfileReq updateNetworkAccessProfile)
        {
            AxlNetClient.updateNetworkAccessProfileRequest inValue = new AxlNetClient.updateNetworkAccessProfileRequest();
            inValue.updateNetworkAccessProfile = updateNetworkAccessProfile;
            return ((AxlNetClient.AXLPort77)(this)).updateNetworkAccessProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getNetworkAccessProfileResponse AxlNetClient.AXLPort77.getNetworkAccessProfile(AxlNetClient.getNetworkAccessProfileRequest request)
        {
            return base.Channel.getNetworkAccessProfile(request);
        }

        public AxlNetClient.GetNetworkAccessProfileRes getNetworkAccessProfile(AxlNetClient.GetNetworkAccessProfileReq getNetworkAccessProfile1)
        {
            AxlNetClient.getNetworkAccessProfileRequest inValue = new AxlNetClient.getNetworkAccessProfileRequest();
            inValue.getNetworkAccessProfile = getNetworkAccessProfile1;
            AxlNetClient.getNetworkAccessProfileResponse retVal = ((AxlNetClient.AXLPort77)(this)).getNetworkAccessProfile(inValue);
            return retVal.getNetworkAccessProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getNetworkAccessProfileResponse> AxlNetClient.AXLPort77.getNetworkAccessProfileAsync(AxlNetClient.getNetworkAccessProfileRequest request)
        {
            return base.Channel.getNetworkAccessProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getNetworkAccessProfileResponse> getNetworkAccessProfileAsync(AxlNetClient.GetNetworkAccessProfileReq getNetworkAccessProfile)
        {
            AxlNetClient.getNetworkAccessProfileRequest inValue = new AxlNetClient.getNetworkAccessProfileRequest();
            inValue.getNetworkAccessProfile = getNetworkAccessProfile;
            return ((AxlNetClient.AXLPort77)(this)).getNetworkAccessProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeNetworkAccessProfileResponse AxlNetClient.AXLPort77.removeNetworkAccessProfile(AxlNetClient.removeNetworkAccessProfileRequest request)
        {
            return base.Channel.removeNetworkAccessProfile(request);
        }

        public AxlNetClient.StandardResponse removeNetworkAccessProfile(AxlNetClient.NameAndGUIDRequest removeNetworkAccessProfile1)
        {
            AxlNetClient.removeNetworkAccessProfileRequest inValue = new AxlNetClient.removeNetworkAccessProfileRequest();
            inValue.removeNetworkAccessProfile = removeNetworkAccessProfile1;
            AxlNetClient.removeNetworkAccessProfileResponse retVal = ((AxlNetClient.AXLPort77)(this)).removeNetworkAccessProfile(inValue);
            return retVal.removeNetworkAccessProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeNetworkAccessProfileResponse> AxlNetClient.AXLPort77.removeNetworkAccessProfileAsync(AxlNetClient.removeNetworkAccessProfileRequest request)
        {
            return base.Channel.removeNetworkAccessProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeNetworkAccessProfileResponse> removeNetworkAccessProfileAsync(AxlNetClient.NameAndGUIDRequest removeNetworkAccessProfile)
        {
            AxlNetClient.removeNetworkAccessProfileRequest inValue = new AxlNetClient.removeNetworkAccessProfileRequest();
            inValue.removeNetworkAccessProfile = removeNetworkAccessProfile;
            return ((AxlNetClient.AXLPort77)(this)).removeNetworkAccessProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listNetworkAccessProfileResponse AxlNetClient.AXLPort77.listNetworkAccessProfile(AxlNetClient.listNetworkAccessProfileRequest request)
        {
            return base.Channel.listNetworkAccessProfile(request);
        }

        public AxlNetClient.ListNetworkAccessProfileRes listNetworkAccessProfile(AxlNetClient.ListNetworkAccessProfileReq listNetworkAccessProfile1)
        {
            AxlNetClient.listNetworkAccessProfileRequest inValue = new AxlNetClient.listNetworkAccessProfileRequest();
            inValue.listNetworkAccessProfile = listNetworkAccessProfile1;
            AxlNetClient.listNetworkAccessProfileResponse retVal = ((AxlNetClient.AXLPort77)(this)).listNetworkAccessProfile(inValue);
            return retVal.listNetworkAccessProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listNetworkAccessProfileResponse> AxlNetClient.AXLPort77.listNetworkAccessProfileAsync(AxlNetClient.listNetworkAccessProfileRequest request)
        {
            return base.Channel.listNetworkAccessProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listNetworkAccessProfileResponse> listNetworkAccessProfileAsync(AxlNetClient.ListNetworkAccessProfileReq listNetworkAccessProfile)
        {
            AxlNetClient.listNetworkAccessProfileRequest inValue = new AxlNetClient.listNetworkAccessProfileRequest();
            inValue.listNetworkAccessProfile = listNetworkAccessProfile;
            return ((AxlNetClient.AXLPort77)(this)).listNetworkAccessProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLicensedUserResponse AxlNetClient.AXLPort77.getLicensedUser(AxlNetClient.getLicensedUserRequest request)
        {
            return base.Channel.getLicensedUser(request);
        }

        public AxlNetClient.GetLicensedUserRes getLicensedUser(AxlNetClient.GetLicensedUserReq getLicensedUser1)
        {
            AxlNetClient.getLicensedUserRequest inValue = new AxlNetClient.getLicensedUserRequest();
            inValue.getLicensedUser = getLicensedUser1;
            AxlNetClient.getLicensedUserResponse retVal = ((AxlNetClient.AXLPort77)(this)).getLicensedUser(inValue);
            return retVal.getLicensedUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLicensedUserResponse> AxlNetClient.AXLPort77.getLicensedUserAsync(AxlNetClient.getLicensedUserRequest request)
        {
            return base.Channel.getLicensedUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLicensedUserResponse> getLicensedUserAsync(AxlNetClient.GetLicensedUserReq getLicensedUser)
        {
            AxlNetClient.getLicensedUserRequest inValue = new AxlNetClient.getLicensedUserRequest();
            inValue.getLicensedUser = getLicensedUser;
            return ((AxlNetClient.AXLPort77)(this)).getLicensedUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.executeSQLQueryResponse AxlNetClient.AXLPort77.executeSQLQuery(AxlNetClient.executeSQLQueryRequest request)
        {
            return base.Channel.executeSQLQuery(request);
        }

        public AxlNetClient.ExecuteSQLQueryRes executeSQLQuery(AxlNetClient.ExecuteSQLQueryReq executeSQLQuery1)
        {
            AxlNetClient.executeSQLQueryRequest inValue = new AxlNetClient.executeSQLQueryRequest();
            inValue.executeSQLQuery = executeSQLQuery1;
            AxlNetClient.executeSQLQueryResponse retVal = ((AxlNetClient.AXLPort77)(this)).executeSQLQuery(inValue);
            return retVal.executeSQLQueryResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.executeSQLQueryResponse> AxlNetClient.AXLPort77.executeSQLQueryAsync(AxlNetClient.executeSQLQueryRequest request)
        {
            return base.Channel.executeSQLQueryAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.executeSQLQueryResponse> executeSQLQueryAsync(AxlNetClient.ExecuteSQLQueryReq executeSQLQuery)
        {
            AxlNetClient.executeSQLQueryRequest inValue = new AxlNetClient.executeSQLQueryRequest();
            inValue.executeSQLQuery = executeSQLQuery;
            return ((AxlNetClient.AXLPort77)(this)).executeSQLQueryAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.executeSQLUpdateResponse AxlNetClient.AXLPort77.executeSQLUpdate(AxlNetClient.executeSQLUpdateRequest request)
        {
            return base.Channel.executeSQLUpdate(request);
        }

        public AxlNetClient.ExecuteSQLUpdateRes executeSQLUpdate(AxlNetClient.ExecuteSQLUpdateReq executeSQLUpdate1)
        {
            AxlNetClient.executeSQLUpdateRequest inValue = new AxlNetClient.executeSQLUpdateRequest();
            inValue.executeSQLUpdate = executeSQLUpdate1;
            AxlNetClient.executeSQLUpdateResponse retVal = ((AxlNetClient.AXLPort77)(this)).executeSQLUpdate(inValue);
            return retVal.executeSQLUpdateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.executeSQLUpdateResponse> AxlNetClient.AXLPort77.executeSQLUpdateAsync(AxlNetClient.executeSQLUpdateRequest request)
        {
            return base.Channel.executeSQLUpdateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.executeSQLUpdateResponse> executeSQLUpdateAsync(AxlNetClient.ExecuteSQLUpdateReq executeSQLUpdate)
        {
            AxlNetClient.executeSQLUpdateRequest inValue = new AxlNetClient.executeSQLUpdateRequest();
            inValue.executeSQLUpdate = executeSQLUpdate;
            return ((AxlNetClient.AXLPort77)(this)).executeSQLUpdateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doAuthenticateUserResponse AxlNetClient.AXLPort77.doAuthenticateUser(AxlNetClient.doAuthenticateUserRequest request)
        {
            return base.Channel.doAuthenticateUser(request);
        }

        public AxlNetClient.DoAuthenticateUserRes doAuthenticateUser(AxlNetClient.DoAuthenticateUserReq doAuthenticateUser1)
        {
            AxlNetClient.doAuthenticateUserRequest inValue = new AxlNetClient.doAuthenticateUserRequest();
            inValue.doAuthenticateUser = doAuthenticateUser1;
            AxlNetClient.doAuthenticateUserResponse retVal = ((AxlNetClient.AXLPort77)(this)).doAuthenticateUser(inValue);
            return retVal.doAuthenticateUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doAuthenticateUserResponse> AxlNetClient.AXLPort77.doAuthenticateUserAsync(AxlNetClient.doAuthenticateUserRequest request)
        {
            return base.Channel.doAuthenticateUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doAuthenticateUserResponse> doAuthenticateUserAsync(AxlNetClient.DoAuthenticateUserReq doAuthenticateUser)
        {
            AxlNetClient.doAuthenticateUserRequest inValue = new AxlNetClient.doAuthenticateUserRequest();
            inValue.doAuthenticateUser = doAuthenticateUser;
            return ((AxlNetClient.AXLPort77)(this)).doAuthenticateUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doDeviceLoginResponse AxlNetClient.AXLPort77.doDeviceLogin(AxlNetClient.doDeviceLoginRequest request)
        {
            return base.Channel.doDeviceLogin(request);
        }

        public AxlNetClient.DoDeviceLoginRes doDeviceLogin(AxlNetClient.DoDeviceLoginReq doDeviceLogin1)
        {
            AxlNetClient.doDeviceLoginRequest inValue = new AxlNetClient.doDeviceLoginRequest();
            inValue.doDeviceLogin = doDeviceLogin1;
            AxlNetClient.doDeviceLoginResponse retVal = ((AxlNetClient.AXLPort77)(this)).doDeviceLogin(inValue);
            return retVal.doDeviceLoginResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceLoginResponse> AxlNetClient.AXLPort77.doDeviceLoginAsync(AxlNetClient.doDeviceLoginRequest request)
        {
            return base.Channel.doDeviceLoginAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceLoginResponse> doDeviceLoginAsync(AxlNetClient.DoDeviceLoginReq doDeviceLogin)
        {
            AxlNetClient.doDeviceLoginRequest inValue = new AxlNetClient.doDeviceLoginRequest();
            inValue.doDeviceLogin = doDeviceLogin;
            return ((AxlNetClient.AXLPort77)(this)).doDeviceLoginAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doDeviceLogoutResponse AxlNetClient.AXLPort77.doDeviceLogout(AxlNetClient.doDeviceLogoutRequest request)
        {
            return base.Channel.doDeviceLogout(request);
        }

        public AxlNetClient.DoDeviceLogoutRes doDeviceLogout(AxlNetClient.DoDeviceLogoutReq doDeviceLogout1)
        {
            AxlNetClient.doDeviceLogoutRequest inValue = new AxlNetClient.doDeviceLogoutRequest();
            inValue.doDeviceLogout = doDeviceLogout1;
            AxlNetClient.doDeviceLogoutResponse retVal = ((AxlNetClient.AXLPort77)(this)).doDeviceLogout(inValue);
            return retVal.doDeviceLogoutResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceLogoutResponse> AxlNetClient.AXLPort77.doDeviceLogoutAsync(AxlNetClient.doDeviceLogoutRequest request)
        {
            return base.Channel.doDeviceLogoutAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceLogoutResponse> doDeviceLogoutAsync(AxlNetClient.DoDeviceLogoutReq doDeviceLogout)
        {
            AxlNetClient.doDeviceLogoutRequest inValue = new AxlNetClient.doDeviceLogoutRequest();
            inValue.doDeviceLogout = doDeviceLogout;
            return ((AxlNetClient.AXLPort77)(this)).doDeviceLogoutAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doDeviceResetResponse AxlNetClient.AXLPort77.doDeviceReset(AxlNetClient.doDeviceResetRequest request)
        {
            return base.Channel.doDeviceReset(request);
        }

        public AxlNetClient.DoDeviceResetRes doDeviceReset(AxlNetClient.DoDeviceResetReq doDeviceReset1)
        {
            AxlNetClient.doDeviceResetRequest inValue = new AxlNetClient.doDeviceResetRequest();
            inValue.doDeviceReset = doDeviceReset1;
            AxlNetClient.doDeviceResetResponse retVal = ((AxlNetClient.AXLPort77)(this)).doDeviceReset(inValue);
            return retVal.doDeviceResetResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doDeviceResetResponse> AxlNetClient.AXLPort77.doDeviceResetAsync(AxlNetClient.doDeviceResetRequest request)
        {
            return base.Channel.doDeviceResetAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doDeviceResetResponse> doDeviceResetAsync(AxlNetClient.DoDeviceResetReq doDeviceReset)
        {
            AxlNetClient.doDeviceResetRequest inValue = new AxlNetClient.doDeviceResetRequest();
            inValue.doDeviceReset = doDeviceReset;
            return ((AxlNetClient.AXLPort77)(this)).doDeviceResetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getOSVersionResponse AxlNetClient.AXLPort77.getOSVersion(AxlNetClient.getOSVersionRequest request)
        {
            return base.Channel.getOSVersion(request);
        }

        public AxlNetClient.GetOSVersionRes getOSVersion(AxlNetClient.GetOSVersionReq getOSVersion1)
        {
            AxlNetClient.getOSVersionRequest inValue = new AxlNetClient.getOSVersionRequest();
            inValue.getOSVersion = getOSVersion1;
            AxlNetClient.getOSVersionResponse retVal = ((AxlNetClient.AXLPort77)(this)).getOSVersion(inValue);
            return retVal.getOSVersionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getOSVersionResponse> AxlNetClient.AXLPort77.getOSVersionAsync(AxlNetClient.getOSVersionRequest request)
        {
            return base.Channel.getOSVersionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getOSVersionResponse> getOSVersionAsync(AxlNetClient.GetOSVersionReq getOSVersion)
        {
            AxlNetClient.getOSVersionRequest inValue = new AxlNetClient.getOSVersionRequest();
            inValue.getOSVersion = getOSVersion;
            return ((AxlNetClient.AXLPort77)(this)).getOSVersionAsync(inValue);
        }
    }
}