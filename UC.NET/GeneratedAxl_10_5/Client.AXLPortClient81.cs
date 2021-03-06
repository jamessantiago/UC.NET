namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient81 _axlPortClient81;

        private static AXLPortClient81 axlPortClient81 => _axlPortClient81 == null ||
            _axlPortClient81.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient81 = LoadClient81()) : _axlPortClient81;

        private static AXLPortClient81 LoadClient81()
        {
            var client = new AXLPortClient81(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close81;
            OnAbort += Abort81;
            return client;
        }

        private static void Close81(object sender, System.EventArgs e)
        {
            _axlPortClient81.Close();
        }

        private static void Abort81(object sender, System.EventArgs e)
        {
            _axlPortClient81.Abort();
        }

        public AxlNetClient.AddSNMPCommunityStringRes addSNMPCommunityString(AxlNetClient.AddSNMPCommunityStringReq addSNMPCommunityString1)
        {
            return axlPortClient81.addSNMPCommunityString(addSNMPCommunityString1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSNMPCommunityStringResponse> addSNMPCommunityStringAsync(AxlNetClient.AddSNMPCommunityStringReq addSNMPCommunityString)
        {
            return axlPortClient81.addSNMPCommunityStringAsync(addSNMPCommunityString);
        }

        public AxlNetClient.RemoveSNMPCommunityStringRes removeSNMPCommunityString(AxlNetClient.RemoveSNMPCommunityStringReq removeSNMPCommunityString1)
        {
            return axlPortClient81.removeSNMPCommunityString(removeSNMPCommunityString1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSNMPCommunityStringResponse> removeSNMPCommunityStringAsync(AxlNetClient.RemoveSNMPCommunityStringReq removeSNMPCommunityString)
        {
            return axlPortClient81.removeSNMPCommunityStringAsync(removeSNMPCommunityString);
        }

        public AxlNetClient.GetSNMPCommunityStringRes getSNMPCommunityString(AxlNetClient.GetSNMPCommunityStringReq getSNMPCommunityString1)
        {
            return axlPortClient81.getSNMPCommunityString(getSNMPCommunityString1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPCommunityStringResponse> getSNMPCommunityStringAsync(AxlNetClient.GetSNMPCommunityStringReq getSNMPCommunityString)
        {
            return axlPortClient81.getSNMPCommunityStringAsync(getSNMPCommunityString);
        }

        public AxlNetClient.UpdateSNMPCommunityStringRes updateSNMPCommunityString(AxlNetClient.UpdateSNMPCommunityStringReq updateSNMPCommunityString1)
        {
            return axlPortClient81.updateSNMPCommunityString(updateSNMPCommunityString1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPCommunityStringResponse> updateSNMPCommunityStringAsync(AxlNetClient.UpdateSNMPCommunityStringReq updateSNMPCommunityString)
        {
            return axlPortClient81.updateSNMPCommunityStringAsync(updateSNMPCommunityString);
        }

        public AxlNetClient.AddSNMPUserRes addSNMPUser(AxlNetClient.AddSNMPUserReq addSNMPUser1)
        {
            return axlPortClient81.addSNMPUser(addSNMPUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSNMPUserResponse> addSNMPUserAsync(AxlNetClient.AddSNMPUserReq addSNMPUser)
        {
            return axlPortClient81.addSNMPUserAsync(addSNMPUser);
        }

        public AxlNetClient.GetSNMPUserRes getSNMPUser(AxlNetClient.GetSNMPUserReq getSNMPUser1)
        {
            return axlPortClient81.getSNMPUser(getSNMPUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPUserResponse> getSNMPUserAsync(AxlNetClient.GetSNMPUserReq getSNMPUser)
        {
            return axlPortClient81.getSNMPUserAsync(getSNMPUser);
        }

        public AxlNetClient.RemoveSNMPUserRes removeSNMPUser(AxlNetClient.RemoveSNMPUserReq removeSNMPUser1)
        {
            return axlPortClient81.removeSNMPUser(removeSNMPUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSNMPUserResponse> removeSNMPUserAsync(AxlNetClient.RemoveSNMPUserReq removeSNMPUser)
        {
            return axlPortClient81.removeSNMPUserAsync(removeSNMPUser);
        }

        public AxlNetClient.UpdateSNMPUserRes updateSNMPUser(AxlNetClient.UpdateSNMPUserReq updateSNMPUser1)
        {
            return axlPortClient81.updateSNMPUser(updateSNMPUser1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPUserResponse> updateSNMPUserAsync(AxlNetClient.UpdateSNMPUserReq updateSNMPUser)
        {
            return axlPortClient81.updateSNMPUserAsync(updateSNMPUser);
        }

        public AxlNetClient.GetSNMPMIB2ListRes getSNMPMIB2List(AxlNetClient.GetSNMPMIB2ListReq getSNMPMIB2List1)
        {
            return axlPortClient81.getSNMPMIB2List(getSNMPMIB2List1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPMIB2ListResponse> getSNMPMIB2ListAsync(AxlNetClient.GetSNMPMIB2ListReq getSNMPMIB2List)
        {
            return axlPortClient81.getSNMPMIB2ListAsync(getSNMPMIB2List);
        }

        public AxlNetClient.UpdateSNMPMIB2ListRes updateSNMPMIB2List(AxlNetClient.UpdateSNMPMIB2ListReq updateSNMPMIB2List1)
        {
            return axlPortClient81.updateSNMPMIB2List(updateSNMPMIB2List1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPMIB2ListResponse> updateSNMPMIB2ListAsync(AxlNetClient.UpdateSNMPMIB2ListReq updateSNMPMIB2List)
        {
            return axlPortClient81.updateSNMPMIB2ListAsync(updateSNMPMIB2List);
        }

        public AxlNetClient.StandardResponse updateBillingServer(AxlNetClient.UpdateBillingServerReq updateBillingServer1)
        {
            return axlPortClient81.updateBillingServer(updateBillingServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateBillingServerResponse> updateBillingServerAsync(AxlNetClient.UpdateBillingServerReq updateBillingServer)
        {
            return axlPortClient81.updateBillingServerAsync(updateBillingServer);
        }

        public AxlNetClient.GetBillingServerRes getBillingServer(AxlNetClient.GetBillingServerReq getBillingServer1)
        {
            return axlPortClient81.getBillingServer(getBillingServer1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getBillingServerResponse> getBillingServerAsync(AxlNetClient.GetBillingServerReq getBillingServer)
        {
            return axlPortClient81.getBillingServerAsync(getBillingServer);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort81
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSNMPCommunityString", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSNMPCommunityStringResponse addSNMPCommunityString(AxlNetClient.addSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSNMPCommunityString", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSNMPCommunityStringResponse> addSNMPCommunityStringAsync(AxlNetClient.addSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSNMPCommunityString", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSNMPCommunityStringResponse removeSNMPCommunityString(AxlNetClient.removeSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSNMPCommunityString", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSNMPCommunityStringResponse> removeSNMPCommunityStringAsync(AxlNetClient.removeSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPCommunityString", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSNMPCommunityStringResponse getSNMPCommunityString(AxlNetClient.getSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPCommunityString", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPCommunityStringResponse> getSNMPCommunityStringAsync(AxlNetClient.getSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPCommunityString", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSNMPCommunityStringResponse updateSNMPCommunityString(AxlNetClient.updateSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPCommunityString", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPCommunityStringResponse> updateSNMPCommunityStringAsync(AxlNetClient.updateSNMPCommunityStringRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSNMPUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSNMPUserResponse addSNMPUser(AxlNetClient.addSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSNMPUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSNMPUserResponse> addSNMPUserAsync(AxlNetClient.addSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSNMPUserResponse getSNMPUser(AxlNetClient.getSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPUserResponse> getSNMPUserAsync(AxlNetClient.getSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSNMPUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSNMPUserResponse removeSNMPUser(AxlNetClient.removeSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSNMPUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSNMPUserResponse> removeSNMPUserAsync(AxlNetClient.removeSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPUser", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSNMPUserResponse updateSNMPUser(AxlNetClient.updateSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPUser", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPUserResponse> updateSNMPUserAsync(AxlNetClient.updateSNMPUserRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPMIB2List", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSNMPMIB2ListResponse getSNMPMIB2List(AxlNetClient.getSNMPMIB2ListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSNMPMIB2List", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPMIB2ListResponse> getSNMPMIB2ListAsync(AxlNetClient.getSNMPMIB2ListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPMIB2List", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSNMPMIB2ListResponse updateSNMPMIB2List(AxlNetClient.updateSNMPMIB2ListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSNMPMIB2List", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPMIB2ListResponse> updateSNMPMIB2ListAsync(AxlNetClient.updateSNMPMIB2ListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateBillingServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateBillingServerResponse updateBillingServer(AxlNetClient.updateBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateBillingServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateBillingServerResponse> updateBillingServerAsync(AxlNetClient.updateBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getBillingServer", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getBillingServerResponse getBillingServer(AxlNetClient.getBillingServerRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getBillingServer", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getBillingServerResponse> getBillingServerAsync(AxlNetClient.getBillingServerRequest request);
    }

    public class AXLPortClient81 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort81>, AxlNetClient.AXLPort81
    {
        public AXLPortClient81(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSNMPCommunityStringResponse AxlNetClient.AXLPort81.addSNMPCommunityString(AxlNetClient.addSNMPCommunityStringRequest request)
        {
            return base.Channel.addSNMPCommunityString(request);
        }

        public AxlNetClient.AddSNMPCommunityStringRes addSNMPCommunityString(AxlNetClient.AddSNMPCommunityStringReq addSNMPCommunityString1)
        {
            AxlNetClient.addSNMPCommunityStringRequest inValue = new AxlNetClient.addSNMPCommunityStringRequest();
            inValue.addSNMPCommunityString = addSNMPCommunityString1;
            AxlNetClient.addSNMPCommunityStringResponse retVal = ((AxlNetClient.AXLPort81)(this)).addSNMPCommunityString(inValue);
            return retVal.addSNMPCommunityStringResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSNMPCommunityStringResponse> AxlNetClient.AXLPort81.addSNMPCommunityStringAsync(AxlNetClient.addSNMPCommunityStringRequest request)
        {
            return base.Channel.addSNMPCommunityStringAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSNMPCommunityStringResponse> addSNMPCommunityStringAsync(AxlNetClient.AddSNMPCommunityStringReq addSNMPCommunityString)
        {
            AxlNetClient.addSNMPCommunityStringRequest inValue = new AxlNetClient.addSNMPCommunityStringRequest();
            inValue.addSNMPCommunityString = addSNMPCommunityString;
            return ((AxlNetClient.AXLPort81)(this)).addSNMPCommunityStringAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSNMPCommunityStringResponse AxlNetClient.AXLPort81.removeSNMPCommunityString(AxlNetClient.removeSNMPCommunityStringRequest request)
        {
            return base.Channel.removeSNMPCommunityString(request);
        }

        public AxlNetClient.RemoveSNMPCommunityStringRes removeSNMPCommunityString(AxlNetClient.RemoveSNMPCommunityStringReq removeSNMPCommunityString1)
        {
            AxlNetClient.removeSNMPCommunityStringRequest inValue = new AxlNetClient.removeSNMPCommunityStringRequest();
            inValue.removeSNMPCommunityString = removeSNMPCommunityString1;
            AxlNetClient.removeSNMPCommunityStringResponse retVal = ((AxlNetClient.AXLPort81)(this)).removeSNMPCommunityString(inValue);
            return retVal.removeSNMPCommunityStringResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSNMPCommunityStringResponse> AxlNetClient.AXLPort81.removeSNMPCommunityStringAsync(AxlNetClient.removeSNMPCommunityStringRequest request)
        {
            return base.Channel.removeSNMPCommunityStringAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSNMPCommunityStringResponse> removeSNMPCommunityStringAsync(AxlNetClient.RemoveSNMPCommunityStringReq removeSNMPCommunityString)
        {
            AxlNetClient.removeSNMPCommunityStringRequest inValue = new AxlNetClient.removeSNMPCommunityStringRequest();
            inValue.removeSNMPCommunityString = removeSNMPCommunityString;
            return ((AxlNetClient.AXLPort81)(this)).removeSNMPCommunityStringAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSNMPCommunityStringResponse AxlNetClient.AXLPort81.getSNMPCommunityString(AxlNetClient.getSNMPCommunityStringRequest request)
        {
            return base.Channel.getSNMPCommunityString(request);
        }

        public AxlNetClient.GetSNMPCommunityStringRes getSNMPCommunityString(AxlNetClient.GetSNMPCommunityStringReq getSNMPCommunityString1)
        {
            AxlNetClient.getSNMPCommunityStringRequest inValue = new AxlNetClient.getSNMPCommunityStringRequest();
            inValue.getSNMPCommunityString = getSNMPCommunityString1;
            AxlNetClient.getSNMPCommunityStringResponse retVal = ((AxlNetClient.AXLPort81)(this)).getSNMPCommunityString(inValue);
            return retVal.getSNMPCommunityStringResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPCommunityStringResponse> AxlNetClient.AXLPort81.getSNMPCommunityStringAsync(AxlNetClient.getSNMPCommunityStringRequest request)
        {
            return base.Channel.getSNMPCommunityStringAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPCommunityStringResponse> getSNMPCommunityStringAsync(AxlNetClient.GetSNMPCommunityStringReq getSNMPCommunityString)
        {
            AxlNetClient.getSNMPCommunityStringRequest inValue = new AxlNetClient.getSNMPCommunityStringRequest();
            inValue.getSNMPCommunityString = getSNMPCommunityString;
            return ((AxlNetClient.AXLPort81)(this)).getSNMPCommunityStringAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSNMPCommunityStringResponse AxlNetClient.AXLPort81.updateSNMPCommunityString(AxlNetClient.updateSNMPCommunityStringRequest request)
        {
            return base.Channel.updateSNMPCommunityString(request);
        }

        public AxlNetClient.UpdateSNMPCommunityStringRes updateSNMPCommunityString(AxlNetClient.UpdateSNMPCommunityStringReq updateSNMPCommunityString1)
        {
            AxlNetClient.updateSNMPCommunityStringRequest inValue = new AxlNetClient.updateSNMPCommunityStringRequest();
            inValue.updateSNMPCommunityString = updateSNMPCommunityString1;
            AxlNetClient.updateSNMPCommunityStringResponse retVal = ((AxlNetClient.AXLPort81)(this)).updateSNMPCommunityString(inValue);
            return retVal.updateSNMPCommunityStringResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPCommunityStringResponse> AxlNetClient.AXLPort81.updateSNMPCommunityStringAsync(AxlNetClient.updateSNMPCommunityStringRequest request)
        {
            return base.Channel.updateSNMPCommunityStringAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPCommunityStringResponse> updateSNMPCommunityStringAsync(AxlNetClient.UpdateSNMPCommunityStringReq updateSNMPCommunityString)
        {
            AxlNetClient.updateSNMPCommunityStringRequest inValue = new AxlNetClient.updateSNMPCommunityStringRequest();
            inValue.updateSNMPCommunityString = updateSNMPCommunityString;
            return ((AxlNetClient.AXLPort81)(this)).updateSNMPCommunityStringAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSNMPUserResponse AxlNetClient.AXLPort81.addSNMPUser(AxlNetClient.addSNMPUserRequest request)
        {
            return base.Channel.addSNMPUser(request);
        }

        public AxlNetClient.AddSNMPUserRes addSNMPUser(AxlNetClient.AddSNMPUserReq addSNMPUser1)
        {
            AxlNetClient.addSNMPUserRequest inValue = new AxlNetClient.addSNMPUserRequest();
            inValue.addSNMPUser = addSNMPUser1;
            AxlNetClient.addSNMPUserResponse retVal = ((AxlNetClient.AXLPort81)(this)).addSNMPUser(inValue);
            return retVal.addSNMPUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSNMPUserResponse> AxlNetClient.AXLPort81.addSNMPUserAsync(AxlNetClient.addSNMPUserRequest request)
        {
            return base.Channel.addSNMPUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSNMPUserResponse> addSNMPUserAsync(AxlNetClient.AddSNMPUserReq addSNMPUser)
        {
            AxlNetClient.addSNMPUserRequest inValue = new AxlNetClient.addSNMPUserRequest();
            inValue.addSNMPUser = addSNMPUser;
            return ((AxlNetClient.AXLPort81)(this)).addSNMPUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSNMPUserResponse AxlNetClient.AXLPort81.getSNMPUser(AxlNetClient.getSNMPUserRequest request)
        {
            return base.Channel.getSNMPUser(request);
        }

        public AxlNetClient.GetSNMPUserRes getSNMPUser(AxlNetClient.GetSNMPUserReq getSNMPUser1)
        {
            AxlNetClient.getSNMPUserRequest inValue = new AxlNetClient.getSNMPUserRequest();
            inValue.getSNMPUser = getSNMPUser1;
            AxlNetClient.getSNMPUserResponse retVal = ((AxlNetClient.AXLPort81)(this)).getSNMPUser(inValue);
            return retVal.getSNMPUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPUserResponse> AxlNetClient.AXLPort81.getSNMPUserAsync(AxlNetClient.getSNMPUserRequest request)
        {
            return base.Channel.getSNMPUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPUserResponse> getSNMPUserAsync(AxlNetClient.GetSNMPUserReq getSNMPUser)
        {
            AxlNetClient.getSNMPUserRequest inValue = new AxlNetClient.getSNMPUserRequest();
            inValue.getSNMPUser = getSNMPUser;
            return ((AxlNetClient.AXLPort81)(this)).getSNMPUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSNMPUserResponse AxlNetClient.AXLPort81.removeSNMPUser(AxlNetClient.removeSNMPUserRequest request)
        {
            return base.Channel.removeSNMPUser(request);
        }

        public AxlNetClient.RemoveSNMPUserRes removeSNMPUser(AxlNetClient.RemoveSNMPUserReq removeSNMPUser1)
        {
            AxlNetClient.removeSNMPUserRequest inValue = new AxlNetClient.removeSNMPUserRequest();
            inValue.removeSNMPUser = removeSNMPUser1;
            AxlNetClient.removeSNMPUserResponse retVal = ((AxlNetClient.AXLPort81)(this)).removeSNMPUser(inValue);
            return retVal.removeSNMPUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSNMPUserResponse> AxlNetClient.AXLPort81.removeSNMPUserAsync(AxlNetClient.removeSNMPUserRequest request)
        {
            return base.Channel.removeSNMPUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSNMPUserResponse> removeSNMPUserAsync(AxlNetClient.RemoveSNMPUserReq removeSNMPUser)
        {
            AxlNetClient.removeSNMPUserRequest inValue = new AxlNetClient.removeSNMPUserRequest();
            inValue.removeSNMPUser = removeSNMPUser;
            return ((AxlNetClient.AXLPort81)(this)).removeSNMPUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSNMPUserResponse AxlNetClient.AXLPort81.updateSNMPUser(AxlNetClient.updateSNMPUserRequest request)
        {
            return base.Channel.updateSNMPUser(request);
        }

        public AxlNetClient.UpdateSNMPUserRes updateSNMPUser(AxlNetClient.UpdateSNMPUserReq updateSNMPUser1)
        {
            AxlNetClient.updateSNMPUserRequest inValue = new AxlNetClient.updateSNMPUserRequest();
            inValue.updateSNMPUser = updateSNMPUser1;
            AxlNetClient.updateSNMPUserResponse retVal = ((AxlNetClient.AXLPort81)(this)).updateSNMPUser(inValue);
            return retVal.updateSNMPUserResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPUserResponse> AxlNetClient.AXLPort81.updateSNMPUserAsync(AxlNetClient.updateSNMPUserRequest request)
        {
            return base.Channel.updateSNMPUserAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPUserResponse> updateSNMPUserAsync(AxlNetClient.UpdateSNMPUserReq updateSNMPUser)
        {
            AxlNetClient.updateSNMPUserRequest inValue = new AxlNetClient.updateSNMPUserRequest();
            inValue.updateSNMPUser = updateSNMPUser;
            return ((AxlNetClient.AXLPort81)(this)).updateSNMPUserAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSNMPMIB2ListResponse AxlNetClient.AXLPort81.getSNMPMIB2List(AxlNetClient.getSNMPMIB2ListRequest request)
        {
            return base.Channel.getSNMPMIB2List(request);
        }

        public AxlNetClient.GetSNMPMIB2ListRes getSNMPMIB2List(AxlNetClient.GetSNMPMIB2ListReq getSNMPMIB2List1)
        {
            AxlNetClient.getSNMPMIB2ListRequest inValue = new AxlNetClient.getSNMPMIB2ListRequest();
            inValue.getSNMPMIB2List = getSNMPMIB2List1;
            AxlNetClient.getSNMPMIB2ListResponse retVal = ((AxlNetClient.AXLPort81)(this)).getSNMPMIB2List(inValue);
            return retVal.getSNMPMIB2ListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSNMPMIB2ListResponse> AxlNetClient.AXLPort81.getSNMPMIB2ListAsync(AxlNetClient.getSNMPMIB2ListRequest request)
        {
            return base.Channel.getSNMPMIB2ListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSNMPMIB2ListResponse> getSNMPMIB2ListAsync(AxlNetClient.GetSNMPMIB2ListReq getSNMPMIB2List)
        {
            AxlNetClient.getSNMPMIB2ListRequest inValue = new AxlNetClient.getSNMPMIB2ListRequest();
            inValue.getSNMPMIB2List = getSNMPMIB2List;
            return ((AxlNetClient.AXLPort81)(this)).getSNMPMIB2ListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSNMPMIB2ListResponse AxlNetClient.AXLPort81.updateSNMPMIB2List(AxlNetClient.updateSNMPMIB2ListRequest request)
        {
            return base.Channel.updateSNMPMIB2List(request);
        }

        public AxlNetClient.UpdateSNMPMIB2ListRes updateSNMPMIB2List(AxlNetClient.UpdateSNMPMIB2ListReq updateSNMPMIB2List1)
        {
            AxlNetClient.updateSNMPMIB2ListRequest inValue = new AxlNetClient.updateSNMPMIB2ListRequest();
            inValue.updateSNMPMIB2List = updateSNMPMIB2List1;
            AxlNetClient.updateSNMPMIB2ListResponse retVal = ((AxlNetClient.AXLPort81)(this)).updateSNMPMIB2List(inValue);
            return retVal.updateSNMPMIB2ListResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSNMPMIB2ListResponse> AxlNetClient.AXLPort81.updateSNMPMIB2ListAsync(AxlNetClient.updateSNMPMIB2ListRequest request)
        {
            return base.Channel.updateSNMPMIB2ListAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSNMPMIB2ListResponse> updateSNMPMIB2ListAsync(AxlNetClient.UpdateSNMPMIB2ListReq updateSNMPMIB2List)
        {
            AxlNetClient.updateSNMPMIB2ListRequest inValue = new AxlNetClient.updateSNMPMIB2ListRequest();
            inValue.updateSNMPMIB2List = updateSNMPMIB2List;
            return ((AxlNetClient.AXLPort81)(this)).updateSNMPMIB2ListAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateBillingServerResponse AxlNetClient.AXLPort81.updateBillingServer(AxlNetClient.updateBillingServerRequest request)
        {
            return base.Channel.updateBillingServer(request);
        }

        public AxlNetClient.StandardResponse updateBillingServer(AxlNetClient.UpdateBillingServerReq updateBillingServer1)
        {
            AxlNetClient.updateBillingServerRequest inValue = new AxlNetClient.updateBillingServerRequest();
            inValue.updateBillingServer = updateBillingServer1;
            AxlNetClient.updateBillingServerResponse retVal = ((AxlNetClient.AXLPort81)(this)).updateBillingServer(inValue);
            return retVal.updateBillingServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateBillingServerResponse> AxlNetClient.AXLPort81.updateBillingServerAsync(AxlNetClient.updateBillingServerRequest request)
        {
            return base.Channel.updateBillingServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateBillingServerResponse> updateBillingServerAsync(AxlNetClient.UpdateBillingServerReq updateBillingServer)
        {
            AxlNetClient.updateBillingServerRequest inValue = new AxlNetClient.updateBillingServerRequest();
            inValue.updateBillingServer = updateBillingServer;
            return ((AxlNetClient.AXLPort81)(this)).updateBillingServerAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getBillingServerResponse AxlNetClient.AXLPort81.getBillingServer(AxlNetClient.getBillingServerRequest request)
        {
            return base.Channel.getBillingServer(request);
        }

        public AxlNetClient.GetBillingServerRes getBillingServer(AxlNetClient.GetBillingServerReq getBillingServer1)
        {
            AxlNetClient.getBillingServerRequest inValue = new AxlNetClient.getBillingServerRequest();
            inValue.getBillingServer = getBillingServer1;
            AxlNetClient.getBillingServerResponse retVal = ((AxlNetClient.AXLPort81)(this)).getBillingServer(inValue);
            return retVal.getBillingServerResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getBillingServerResponse> AxlNetClient.AXLPort81.getBillingServerAsync(AxlNetClient.getBillingServerRequest request)
        {
            return base.Channel.getBillingServerAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getBillingServerResponse> getBillingServerAsync(AxlNetClient.GetBillingServerReq getBillingServer)
        {
            AxlNetClient.getBillingServerRequest inValue = new AxlNetClient.getBillingServerRequest();
            inValue.getBillingServer = getBillingServer;
            return ((AxlNetClient.AXLPort81)(this)).getBillingServerAsync(inValue);
        }
    }
}