namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient57 _axlPortClient57;

        private static AXLPortClient57 axlPortClient57 => _axlPortClient57 == null ||
            _axlPortClient57.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient57 = LoadClient57()) : _axlPortClient57;

        private static AXLPortClient57 LoadClient57()
        {
            var client = new AXLPortClient57(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close57;
            OnAbort += Abort57;
            return client;
        }

        private static void Close57(object sender, System.EventArgs e)
        {
            _axlPortClient57.Close();
        }

        private static void Abort57(object sender, System.EventArgs e)
        {
            _axlPortClient57.Abort();
        }

        public AxlNetClient.StandardResponse addVpnGateway(AxlNetClient.AddVpnGatewayReq addVpnGateway1)
        {
            return axlPortClient57.addVpnGateway(addVpnGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnGatewayResponse> addVpnGatewayAsync(AxlNetClient.AddVpnGatewayReq addVpnGateway)
        {
            return axlPortClient57.addVpnGatewayAsync(addVpnGateway);
        }

        public AxlNetClient.StandardResponse updateVpnGateway(AxlNetClient.UpdateVpnGatewayReq updateVpnGateway1)
        {
            return axlPortClient57.updateVpnGateway(updateVpnGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnGatewayResponse> updateVpnGatewayAsync(AxlNetClient.UpdateVpnGatewayReq updateVpnGateway)
        {
            return axlPortClient57.updateVpnGatewayAsync(updateVpnGateway);
        }

        public AxlNetClient.GetVpnGatewayRes getVpnGateway(AxlNetClient.GetVpnGatewayReq getVpnGateway1)
        {
            return axlPortClient57.getVpnGateway(getVpnGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnGatewayResponse> getVpnGatewayAsync(AxlNetClient.GetVpnGatewayReq getVpnGateway)
        {
            return axlPortClient57.getVpnGatewayAsync(getVpnGateway);
        }

        public AxlNetClient.StandardResponse removeVpnGateway(AxlNetClient.NameAndGUIDRequest removeVpnGateway1)
        {
            return axlPortClient57.removeVpnGateway(removeVpnGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnGatewayResponse> removeVpnGatewayAsync(AxlNetClient.NameAndGUIDRequest removeVpnGateway)
        {
            return axlPortClient57.removeVpnGatewayAsync(removeVpnGateway);
        }

        public AxlNetClient.ListVpnGatewayRes listVpnGateway(AxlNetClient.ListVpnGatewayReq listVpnGateway1)
        {
            return axlPortClient57.listVpnGateway(listVpnGateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnGatewayResponse> listVpnGatewayAsync(AxlNetClient.ListVpnGatewayReq listVpnGateway)
        {
            return axlPortClient57.listVpnGatewayAsync(listVpnGateway);
        }

        public AxlNetClient.StandardResponse addVpnGroup(AxlNetClient.AddVpnGroupReq addVpnGroup1)
        {
            return axlPortClient57.addVpnGroup(addVpnGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnGroupResponse> addVpnGroupAsync(AxlNetClient.AddVpnGroupReq addVpnGroup)
        {
            return axlPortClient57.addVpnGroupAsync(addVpnGroup);
        }

        public AxlNetClient.StandardResponse updateVpnGroup(AxlNetClient.UpdateVpnGroupReq updateVpnGroup1)
        {
            return axlPortClient57.updateVpnGroup(updateVpnGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnGroupResponse> updateVpnGroupAsync(AxlNetClient.UpdateVpnGroupReq updateVpnGroup)
        {
            return axlPortClient57.updateVpnGroupAsync(updateVpnGroup);
        }

        public AxlNetClient.GetVpnGroupRes getVpnGroup(AxlNetClient.GetVpnGroupReq getVpnGroup1)
        {
            return axlPortClient57.getVpnGroup(getVpnGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnGroupResponse> getVpnGroupAsync(AxlNetClient.GetVpnGroupReq getVpnGroup)
        {
            return axlPortClient57.getVpnGroupAsync(getVpnGroup);
        }

        public AxlNetClient.StandardResponse removeVpnGroup(AxlNetClient.NameAndGUIDRequest removeVpnGroup1)
        {
            return axlPortClient57.removeVpnGroup(removeVpnGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnGroupResponse> removeVpnGroupAsync(AxlNetClient.NameAndGUIDRequest removeVpnGroup)
        {
            return axlPortClient57.removeVpnGroupAsync(removeVpnGroup);
        }

        public AxlNetClient.ListVpnGroupRes listVpnGroup(AxlNetClient.ListVpnGroupReq listVpnGroup1)
        {
            return axlPortClient57.listVpnGroup(listVpnGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnGroupResponse> listVpnGroupAsync(AxlNetClient.ListVpnGroupReq listVpnGroup)
        {
            return axlPortClient57.listVpnGroupAsync(listVpnGroup);
        }

        public AxlNetClient.StandardResponse addVpnProfile(AxlNetClient.AddVpnProfileReq addVpnProfile1)
        {
            return axlPortClient57.addVpnProfile(addVpnProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnProfileResponse> addVpnProfileAsync(AxlNetClient.AddVpnProfileReq addVpnProfile)
        {
            return axlPortClient57.addVpnProfileAsync(addVpnProfile);
        }

        public AxlNetClient.StandardResponse updateVpnProfile(AxlNetClient.UpdateVpnProfileReq updateVpnProfile1)
        {
            return axlPortClient57.updateVpnProfile(updateVpnProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnProfileResponse> updateVpnProfileAsync(AxlNetClient.UpdateVpnProfileReq updateVpnProfile)
        {
            return axlPortClient57.updateVpnProfileAsync(updateVpnProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort57
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVpnGatewayResponse addVpnGateway(AxlNetClient.addVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVpnGatewayResponse> addVpnGatewayAsync(AxlNetClient.addVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVpnGatewayResponse updateVpnGateway(AxlNetClient.updateVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnGatewayResponse> updateVpnGatewayAsync(AxlNetClient.updateVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVpnGatewayResponse getVpnGateway(AxlNetClient.getVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVpnGatewayResponse> getVpnGatewayAsync(AxlNetClient.getVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVpnGatewayResponse removeVpnGateway(AxlNetClient.removeVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnGatewayResponse> removeVpnGatewayAsync(AxlNetClient.removeVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnGateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVpnGatewayResponse listVpnGateway(AxlNetClient.listVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnGateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVpnGatewayResponse> listVpnGatewayAsync(AxlNetClient.listVpnGatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVpnGroupResponse addVpnGroup(AxlNetClient.addVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVpnGroupResponse> addVpnGroupAsync(AxlNetClient.addVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVpnGroupResponse updateVpnGroup(AxlNetClient.updateVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnGroupResponse> updateVpnGroupAsync(AxlNetClient.updateVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVpnGroupResponse getVpnGroup(AxlNetClient.getVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVpnGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVpnGroupResponse> getVpnGroupAsync(AxlNetClient.getVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVpnGroupResponse removeVpnGroup(AxlNetClient.removeVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVpnGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnGroupResponse> removeVpnGroupAsync(AxlNetClient.removeVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVpnGroupResponse listVpnGroup(AxlNetClient.listVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVpnGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVpnGroupResponse> listVpnGroupAsync(AxlNetClient.listVpnGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVpnProfileResponse addVpnProfile(AxlNetClient.addVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVpnProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVpnProfileResponse> addVpnProfileAsync(AxlNetClient.addVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVpnProfileResponse updateVpnProfile(AxlNetClient.updateVpnProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVpnProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnProfileResponse> updateVpnProfileAsync(AxlNetClient.updateVpnProfileRequest request);
    }

    public class AXLPortClient57 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort57>, AxlNetClient.AXLPort57
    {
        public AXLPortClient57(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVpnGatewayResponse AxlNetClient.AXLPort57.addVpnGateway(AxlNetClient.addVpnGatewayRequest request)
        {
            return base.Channel.addVpnGateway(request);
        }

        public AxlNetClient.StandardResponse addVpnGateway(AxlNetClient.AddVpnGatewayReq addVpnGateway1)
        {
            AxlNetClient.addVpnGatewayRequest inValue = new AxlNetClient.addVpnGatewayRequest();
            inValue.addVpnGateway = addVpnGateway1;
            AxlNetClient.addVpnGatewayResponse retVal = ((AxlNetClient.AXLPort57)(this)).addVpnGateway(inValue);
            return retVal.addVpnGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVpnGatewayResponse> AxlNetClient.AXLPort57.addVpnGatewayAsync(AxlNetClient.addVpnGatewayRequest request)
        {
            return base.Channel.addVpnGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnGatewayResponse> addVpnGatewayAsync(AxlNetClient.AddVpnGatewayReq addVpnGateway)
        {
            AxlNetClient.addVpnGatewayRequest inValue = new AxlNetClient.addVpnGatewayRequest();
            inValue.addVpnGateway = addVpnGateway;
            return ((AxlNetClient.AXLPort57)(this)).addVpnGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVpnGatewayResponse AxlNetClient.AXLPort57.updateVpnGateway(AxlNetClient.updateVpnGatewayRequest request)
        {
            return base.Channel.updateVpnGateway(request);
        }

        public AxlNetClient.StandardResponse updateVpnGateway(AxlNetClient.UpdateVpnGatewayReq updateVpnGateway1)
        {
            AxlNetClient.updateVpnGatewayRequest inValue = new AxlNetClient.updateVpnGatewayRequest();
            inValue.updateVpnGateway = updateVpnGateway1;
            AxlNetClient.updateVpnGatewayResponse retVal = ((AxlNetClient.AXLPort57)(this)).updateVpnGateway(inValue);
            return retVal.updateVpnGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnGatewayResponse> AxlNetClient.AXLPort57.updateVpnGatewayAsync(AxlNetClient.updateVpnGatewayRequest request)
        {
            return base.Channel.updateVpnGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnGatewayResponse> updateVpnGatewayAsync(AxlNetClient.UpdateVpnGatewayReq updateVpnGateway)
        {
            AxlNetClient.updateVpnGatewayRequest inValue = new AxlNetClient.updateVpnGatewayRequest();
            inValue.updateVpnGateway = updateVpnGateway;
            return ((AxlNetClient.AXLPort57)(this)).updateVpnGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVpnGatewayResponse AxlNetClient.AXLPort57.getVpnGateway(AxlNetClient.getVpnGatewayRequest request)
        {
            return base.Channel.getVpnGateway(request);
        }

        public AxlNetClient.GetVpnGatewayRes getVpnGateway(AxlNetClient.GetVpnGatewayReq getVpnGateway1)
        {
            AxlNetClient.getVpnGatewayRequest inValue = new AxlNetClient.getVpnGatewayRequest();
            inValue.getVpnGateway = getVpnGateway1;
            AxlNetClient.getVpnGatewayResponse retVal = ((AxlNetClient.AXLPort57)(this)).getVpnGateway(inValue);
            return retVal.getVpnGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVpnGatewayResponse> AxlNetClient.AXLPort57.getVpnGatewayAsync(AxlNetClient.getVpnGatewayRequest request)
        {
            return base.Channel.getVpnGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnGatewayResponse> getVpnGatewayAsync(AxlNetClient.GetVpnGatewayReq getVpnGateway)
        {
            AxlNetClient.getVpnGatewayRequest inValue = new AxlNetClient.getVpnGatewayRequest();
            inValue.getVpnGateway = getVpnGateway;
            return ((AxlNetClient.AXLPort57)(this)).getVpnGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVpnGatewayResponse AxlNetClient.AXLPort57.removeVpnGateway(AxlNetClient.removeVpnGatewayRequest request)
        {
            return base.Channel.removeVpnGateway(request);
        }

        public AxlNetClient.StandardResponse removeVpnGateway(AxlNetClient.NameAndGUIDRequest removeVpnGateway1)
        {
            AxlNetClient.removeVpnGatewayRequest inValue = new AxlNetClient.removeVpnGatewayRequest();
            inValue.removeVpnGateway = removeVpnGateway1;
            AxlNetClient.removeVpnGatewayResponse retVal = ((AxlNetClient.AXLPort57)(this)).removeVpnGateway(inValue);
            return retVal.removeVpnGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnGatewayResponse> AxlNetClient.AXLPort57.removeVpnGatewayAsync(AxlNetClient.removeVpnGatewayRequest request)
        {
            return base.Channel.removeVpnGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnGatewayResponse> removeVpnGatewayAsync(AxlNetClient.NameAndGUIDRequest removeVpnGateway)
        {
            AxlNetClient.removeVpnGatewayRequest inValue = new AxlNetClient.removeVpnGatewayRequest();
            inValue.removeVpnGateway = removeVpnGateway;
            return ((AxlNetClient.AXLPort57)(this)).removeVpnGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVpnGatewayResponse AxlNetClient.AXLPort57.listVpnGateway(AxlNetClient.listVpnGatewayRequest request)
        {
            return base.Channel.listVpnGateway(request);
        }

        public AxlNetClient.ListVpnGatewayRes listVpnGateway(AxlNetClient.ListVpnGatewayReq listVpnGateway1)
        {
            AxlNetClient.listVpnGatewayRequest inValue = new AxlNetClient.listVpnGatewayRequest();
            inValue.listVpnGateway = listVpnGateway1;
            AxlNetClient.listVpnGatewayResponse retVal = ((AxlNetClient.AXLPort57)(this)).listVpnGateway(inValue);
            return retVal.listVpnGatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVpnGatewayResponse> AxlNetClient.AXLPort57.listVpnGatewayAsync(AxlNetClient.listVpnGatewayRequest request)
        {
            return base.Channel.listVpnGatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnGatewayResponse> listVpnGatewayAsync(AxlNetClient.ListVpnGatewayReq listVpnGateway)
        {
            AxlNetClient.listVpnGatewayRequest inValue = new AxlNetClient.listVpnGatewayRequest();
            inValue.listVpnGateway = listVpnGateway;
            return ((AxlNetClient.AXLPort57)(this)).listVpnGatewayAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVpnGroupResponse AxlNetClient.AXLPort57.addVpnGroup(AxlNetClient.addVpnGroupRequest request)
        {
            return base.Channel.addVpnGroup(request);
        }

        public AxlNetClient.StandardResponse addVpnGroup(AxlNetClient.AddVpnGroupReq addVpnGroup1)
        {
            AxlNetClient.addVpnGroupRequest inValue = new AxlNetClient.addVpnGroupRequest();
            inValue.addVpnGroup = addVpnGroup1;
            AxlNetClient.addVpnGroupResponse retVal = ((AxlNetClient.AXLPort57)(this)).addVpnGroup(inValue);
            return retVal.addVpnGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVpnGroupResponse> AxlNetClient.AXLPort57.addVpnGroupAsync(AxlNetClient.addVpnGroupRequest request)
        {
            return base.Channel.addVpnGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnGroupResponse> addVpnGroupAsync(AxlNetClient.AddVpnGroupReq addVpnGroup)
        {
            AxlNetClient.addVpnGroupRequest inValue = new AxlNetClient.addVpnGroupRequest();
            inValue.addVpnGroup = addVpnGroup;
            return ((AxlNetClient.AXLPort57)(this)).addVpnGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVpnGroupResponse AxlNetClient.AXLPort57.updateVpnGroup(AxlNetClient.updateVpnGroupRequest request)
        {
            return base.Channel.updateVpnGroup(request);
        }

        public AxlNetClient.StandardResponse updateVpnGroup(AxlNetClient.UpdateVpnGroupReq updateVpnGroup1)
        {
            AxlNetClient.updateVpnGroupRequest inValue = new AxlNetClient.updateVpnGroupRequest();
            inValue.updateVpnGroup = updateVpnGroup1;
            AxlNetClient.updateVpnGroupResponse retVal = ((AxlNetClient.AXLPort57)(this)).updateVpnGroup(inValue);
            return retVal.updateVpnGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnGroupResponse> AxlNetClient.AXLPort57.updateVpnGroupAsync(AxlNetClient.updateVpnGroupRequest request)
        {
            return base.Channel.updateVpnGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnGroupResponse> updateVpnGroupAsync(AxlNetClient.UpdateVpnGroupReq updateVpnGroup)
        {
            AxlNetClient.updateVpnGroupRequest inValue = new AxlNetClient.updateVpnGroupRequest();
            inValue.updateVpnGroup = updateVpnGroup;
            return ((AxlNetClient.AXLPort57)(this)).updateVpnGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVpnGroupResponse AxlNetClient.AXLPort57.getVpnGroup(AxlNetClient.getVpnGroupRequest request)
        {
            return base.Channel.getVpnGroup(request);
        }

        public AxlNetClient.GetVpnGroupRes getVpnGroup(AxlNetClient.GetVpnGroupReq getVpnGroup1)
        {
            AxlNetClient.getVpnGroupRequest inValue = new AxlNetClient.getVpnGroupRequest();
            inValue.getVpnGroup = getVpnGroup1;
            AxlNetClient.getVpnGroupResponse retVal = ((AxlNetClient.AXLPort57)(this)).getVpnGroup(inValue);
            return retVal.getVpnGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVpnGroupResponse> AxlNetClient.AXLPort57.getVpnGroupAsync(AxlNetClient.getVpnGroupRequest request)
        {
            return base.Channel.getVpnGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVpnGroupResponse> getVpnGroupAsync(AxlNetClient.GetVpnGroupReq getVpnGroup)
        {
            AxlNetClient.getVpnGroupRequest inValue = new AxlNetClient.getVpnGroupRequest();
            inValue.getVpnGroup = getVpnGroup;
            return ((AxlNetClient.AXLPort57)(this)).getVpnGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVpnGroupResponse AxlNetClient.AXLPort57.removeVpnGroup(AxlNetClient.removeVpnGroupRequest request)
        {
            return base.Channel.removeVpnGroup(request);
        }

        public AxlNetClient.StandardResponse removeVpnGroup(AxlNetClient.NameAndGUIDRequest removeVpnGroup1)
        {
            AxlNetClient.removeVpnGroupRequest inValue = new AxlNetClient.removeVpnGroupRequest();
            inValue.removeVpnGroup = removeVpnGroup1;
            AxlNetClient.removeVpnGroupResponse retVal = ((AxlNetClient.AXLPort57)(this)).removeVpnGroup(inValue);
            return retVal.removeVpnGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVpnGroupResponse> AxlNetClient.AXLPort57.removeVpnGroupAsync(AxlNetClient.removeVpnGroupRequest request)
        {
            return base.Channel.removeVpnGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVpnGroupResponse> removeVpnGroupAsync(AxlNetClient.NameAndGUIDRequest removeVpnGroup)
        {
            AxlNetClient.removeVpnGroupRequest inValue = new AxlNetClient.removeVpnGroupRequest();
            inValue.removeVpnGroup = removeVpnGroup;
            return ((AxlNetClient.AXLPort57)(this)).removeVpnGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVpnGroupResponse AxlNetClient.AXLPort57.listVpnGroup(AxlNetClient.listVpnGroupRequest request)
        {
            return base.Channel.listVpnGroup(request);
        }

        public AxlNetClient.ListVpnGroupRes listVpnGroup(AxlNetClient.ListVpnGroupReq listVpnGroup1)
        {
            AxlNetClient.listVpnGroupRequest inValue = new AxlNetClient.listVpnGroupRequest();
            inValue.listVpnGroup = listVpnGroup1;
            AxlNetClient.listVpnGroupResponse retVal = ((AxlNetClient.AXLPort57)(this)).listVpnGroup(inValue);
            return retVal.listVpnGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVpnGroupResponse> AxlNetClient.AXLPort57.listVpnGroupAsync(AxlNetClient.listVpnGroupRequest request)
        {
            return base.Channel.listVpnGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVpnGroupResponse> listVpnGroupAsync(AxlNetClient.ListVpnGroupReq listVpnGroup)
        {
            AxlNetClient.listVpnGroupRequest inValue = new AxlNetClient.listVpnGroupRequest();
            inValue.listVpnGroup = listVpnGroup;
            return ((AxlNetClient.AXLPort57)(this)).listVpnGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVpnProfileResponse AxlNetClient.AXLPort57.addVpnProfile(AxlNetClient.addVpnProfileRequest request)
        {
            return base.Channel.addVpnProfile(request);
        }

        public AxlNetClient.StandardResponse addVpnProfile(AxlNetClient.AddVpnProfileReq addVpnProfile1)
        {
            AxlNetClient.addVpnProfileRequest inValue = new AxlNetClient.addVpnProfileRequest();
            inValue.addVpnProfile = addVpnProfile1;
            AxlNetClient.addVpnProfileResponse retVal = ((AxlNetClient.AXLPort57)(this)).addVpnProfile(inValue);
            return retVal.addVpnProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVpnProfileResponse> AxlNetClient.AXLPort57.addVpnProfileAsync(AxlNetClient.addVpnProfileRequest request)
        {
            return base.Channel.addVpnProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVpnProfileResponse> addVpnProfileAsync(AxlNetClient.AddVpnProfileReq addVpnProfile)
        {
            AxlNetClient.addVpnProfileRequest inValue = new AxlNetClient.addVpnProfileRequest();
            inValue.addVpnProfile = addVpnProfile;
            return ((AxlNetClient.AXLPort57)(this)).addVpnProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVpnProfileResponse AxlNetClient.AXLPort57.updateVpnProfile(AxlNetClient.updateVpnProfileRequest request)
        {
            return base.Channel.updateVpnProfile(request);
        }

        public AxlNetClient.StandardResponse updateVpnProfile(AxlNetClient.UpdateVpnProfileReq updateVpnProfile1)
        {
            AxlNetClient.updateVpnProfileRequest inValue = new AxlNetClient.updateVpnProfileRequest();
            inValue.updateVpnProfile = updateVpnProfile1;
            AxlNetClient.updateVpnProfileResponse retVal = ((AxlNetClient.AXLPort57)(this)).updateVpnProfile(inValue);
            return retVal.updateVpnProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVpnProfileResponse> AxlNetClient.AXLPort57.updateVpnProfileAsync(AxlNetClient.updateVpnProfileRequest request)
        {
            return base.Channel.updateVpnProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVpnProfileResponse> updateVpnProfileAsync(AxlNetClient.UpdateVpnProfileReq updateVpnProfile)
        {
            AxlNetClient.updateVpnProfileRequest inValue = new AxlNetClient.updateVpnProfileRequest();
            inValue.updateVpnProfile = updateVpnProfile;
            return ((AxlNetClient.AXLPort57)(this)).updateVpnProfileAsync(inValue);
        }
    }
}