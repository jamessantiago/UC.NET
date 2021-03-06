namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient50 _axlPortClient50;

        private static AXLPortClient50 axlPortClient50 => _axlPortClient50 == null ||
            _axlPortClient50.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient50 = LoadClient50()) : _axlPortClient50;

        private static AXLPortClient50 LoadClient50()
        {
            var client = new AXLPortClient50(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close50;
            OnAbort += Abort50;
            return client;
        }

        private static void Close50(object sender, System.EventArgs e)
        {
            _axlPortClient50.Close();
        }

        private static void Abort50(object sender, System.EventArgs e)
        {
            _axlPortClient50.Abort();
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient50.removeCiscoCatalyst6000T1VoIPGatewayT1(removeCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response> removeCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient50.removeCiscoCatalyst6000T1VoIPGatewayT1Async(removeCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Res listCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Req listCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient50.listCiscoCatalyst6000T1VoIPGatewayT1(listCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response> listCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Req listCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient50.listCiscoCatalyst6000T1VoIPGatewayT1Async(listCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient50.resetCiscoCatalyst6000T1VoIPGatewayT1(resetCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response> resetCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient50.resetCiscoCatalyst6000T1VoIPGatewayT1Async(resetCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient50.restartCiscoCatalyst6000T1VoIPGatewayT1(restartCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response> restartCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient50.restartCiscoCatalyst6000T1VoIPGatewayT1Async(restartCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayT11)
        {
            return axlPortClient50.applyCiscoCatalyst6000T1VoIPGatewayT1(applyCiscoCatalyst6000T1VoIPGatewayT11);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response> applyCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayT1)
        {
            return axlPortClient50.applyCiscoCatalyst6000T1VoIPGatewayT1Async(applyCiscoCatalyst6000T1VoIPGatewayT1);
        }

        public AxlNetClient.StandardResponse addCallPickupGroup(AxlNetClient.AddCallPickupGroupReq addCallPickupGroup1)
        {
            return axlPortClient50.addCallPickupGroup(addCallPickupGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallPickupGroupResponse> addCallPickupGroupAsync(AxlNetClient.AddCallPickupGroupReq addCallPickupGroup)
        {
            return axlPortClient50.addCallPickupGroupAsync(addCallPickupGroup);
        }

        public AxlNetClient.StandardResponse updateCallPickupGroup(AxlNetClient.UpdateCallPickupGroupReq updateCallPickupGroup1)
        {
            return axlPortClient50.updateCallPickupGroup(updateCallPickupGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallPickupGroupResponse> updateCallPickupGroupAsync(AxlNetClient.UpdateCallPickupGroupReq updateCallPickupGroup)
        {
            return axlPortClient50.updateCallPickupGroupAsync(updateCallPickupGroup);
        }

        public AxlNetClient.GetCallPickupGroupRes getCallPickupGroup(AxlNetClient.GetCallPickupGroupReq getCallPickupGroup1)
        {
            return axlPortClient50.getCallPickupGroup(getCallPickupGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallPickupGroupResponse> getCallPickupGroupAsync(AxlNetClient.GetCallPickupGroupReq getCallPickupGroup)
        {
            return axlPortClient50.getCallPickupGroupAsync(getCallPickupGroup);
        }

        public AxlNetClient.StandardResponse removeCallPickupGroup(AxlNetClient.RemoveCallPickupGroupReq removeCallPickupGroup1)
        {
            return axlPortClient50.removeCallPickupGroup(removeCallPickupGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallPickupGroupResponse> removeCallPickupGroupAsync(AxlNetClient.RemoveCallPickupGroupReq removeCallPickupGroup)
        {
            return axlPortClient50.removeCallPickupGroupAsync(removeCallPickupGroup);
        }

        public AxlNetClient.ListCallPickupGroupRes listCallPickupGroup(AxlNetClient.ListCallPickupGroupReq listCallPickupGroup1)
        {
            return axlPortClient50.listCallPickupGroup(listCallPickupGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallPickupGroupResponse> listCallPickupGroupAsync(AxlNetClient.ListCallPickupGroupReq listCallPickupGroup)
        {
            return axlPortClient50.listCallPickupGroupAsync(listCallPickupGroup);
        }

        public AxlNetClient.ListRoutePlanRes listRoutePlan(AxlNetClient.ListRoutePlanReq listRoutePlan1)
        {
            return axlPortClient50.listRoutePlan(listRoutePlan1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePlanResponse> listRoutePlanAsync(AxlNetClient.ListRoutePlanReq listRoutePlan)
        {
            return axlPortClient50.listRoutePlanAsync(listRoutePlan);
        }

        public AxlNetClient.StandardResponse addGeoLocationPolicy(AxlNetClient.AddGeoLocationPolicyReq addGeoLocationPolicy1)
        {
            return axlPortClient50.addGeoLocationPolicy(addGeoLocationPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationPolicyResponse> addGeoLocationPolicyAsync(AxlNetClient.AddGeoLocationPolicyReq addGeoLocationPolicy)
        {
            return axlPortClient50.addGeoLocationPolicyAsync(addGeoLocationPolicy);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort50
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response removeCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response> removeCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response listCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response> listCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response resetCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response> resetCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response restartCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response> restartCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response applyCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCiscoCatalyst6000T1VoIPGatewayT1", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response> applyCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallPickupGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCallPickupGroupResponse addCallPickupGroup(AxlNetClient.addCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallPickupGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCallPickupGroupResponse> addCallPickupGroupAsync(AxlNetClient.addCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallPickupGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallPickupGroupResponse updateCallPickupGroup(AxlNetClient.updateCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallPickupGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallPickupGroupResponse> updateCallPickupGroupAsync(AxlNetClient.updateCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallPickupGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallPickupGroupResponse getCallPickupGroup(AxlNetClient.getCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallPickupGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallPickupGroupResponse> getCallPickupGroupAsync(AxlNetClient.getCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallPickupGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCallPickupGroupResponse removeCallPickupGroup(AxlNetClient.removeCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallPickupGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCallPickupGroupResponse> removeCallPickupGroupAsync(AxlNetClient.removeCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallPickupGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallPickupGroupResponse listCallPickupGroup(AxlNetClient.listCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallPickupGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallPickupGroupResponse> listCallPickupGroupAsync(AxlNetClient.listCallPickupGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePlan", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRoutePlanResponse listRoutePlan(AxlNetClient.listRoutePlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRoutePlan", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePlanResponse> listRoutePlanAsync(AxlNetClient.listRoutePlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocationPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGeoLocationPolicyResponse addGeoLocationPolicy(AxlNetClient.addGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocationPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationPolicyResponse> addGeoLocationPolicyAsync(AxlNetClient.addGeoLocationPolicyRequest request);
    }

    public class AXLPortClient50 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort50>, AxlNetClient.AXLPort50
    {
        public AXLPortClient50(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort50.removeCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.removeCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse removeCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.removeCiscoCatalyst6000T1VoIPGatewayT1 = removeCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort50)(this)).removeCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.removeCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort50.removeCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.removeCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Response> removeCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest removeCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.removeCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.removeCiscoCatalyst6000T1VoIPGatewayT1 = removeCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort50)(this)).removeCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort50.listCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.listCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Res listCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Req listCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.listCiscoCatalyst6000T1VoIPGatewayT1 = listCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort50)(this)).listCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.listCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort50.listCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.listCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Response> listCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.ListCiscoCatalyst6000T1VoIPGatewayT1Req listCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.listCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.listCiscoCatalyst6000T1VoIPGatewayT1 = listCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort50)(this)).listCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort50.resetCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.resetCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse resetCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.resetCiscoCatalyst6000T1VoIPGatewayT1 = resetCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort50)(this)).resetCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.resetCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort50.resetCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.resetCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Response> resetCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest resetCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.resetCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.resetCiscoCatalyst6000T1VoIPGatewayT1 = resetCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort50)(this)).resetCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort50.restartCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.restartCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse restartCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.restartCiscoCatalyst6000T1VoIPGatewayT1 = restartCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort50)(this)).restartCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.restartCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort50.restartCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.restartCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Response> restartCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest restartCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.restartCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.restartCiscoCatalyst6000T1VoIPGatewayT1 = restartCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort50)(this)).restartCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response AxlNetClient.AXLPort50.applyCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.applyCiscoCatalyst6000T1VoIPGatewayT1(request);
        }

        public AxlNetClient.StandardResponse applyCiscoCatalyst6000T1VoIPGatewayT1(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayT11)
        {
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.applyCiscoCatalyst6000T1VoIPGatewayT1 = applyCiscoCatalyst6000T1VoIPGatewayT11;
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response retVal = ((AxlNetClient.AXLPort50)(this)).applyCiscoCatalyst6000T1VoIPGatewayT1(inValue);
            return retVal.applyCiscoCatalyst6000T1VoIPGatewayT1Response1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response> AxlNetClient.AXLPort50.applyCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request request)
        {
            return base.Channel.applyCiscoCatalyst6000T1VoIPGatewayT1Async(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Response> applyCiscoCatalyst6000T1VoIPGatewayT1Async(AxlNetClient.NameAndGUIDRequest applyCiscoCatalyst6000T1VoIPGatewayT1)
        {
            AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request inValue = new AxlNetClient.applyCiscoCatalyst6000T1VoIPGatewayT1Request();
            inValue.applyCiscoCatalyst6000T1VoIPGatewayT1 = applyCiscoCatalyst6000T1VoIPGatewayT1;
            return ((AxlNetClient.AXLPort50)(this)).applyCiscoCatalyst6000T1VoIPGatewayT1Async(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCallPickupGroupResponse AxlNetClient.AXLPort50.addCallPickupGroup(AxlNetClient.addCallPickupGroupRequest request)
        {
            return base.Channel.addCallPickupGroup(request);
        }

        public AxlNetClient.StandardResponse addCallPickupGroup(AxlNetClient.AddCallPickupGroupReq addCallPickupGroup1)
        {
            AxlNetClient.addCallPickupGroupRequest inValue = new AxlNetClient.addCallPickupGroupRequest();
            inValue.addCallPickupGroup = addCallPickupGroup1;
            AxlNetClient.addCallPickupGroupResponse retVal = ((AxlNetClient.AXLPort50)(this)).addCallPickupGroup(inValue);
            return retVal.addCallPickupGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCallPickupGroupResponse> AxlNetClient.AXLPort50.addCallPickupGroupAsync(AxlNetClient.addCallPickupGroupRequest request)
        {
            return base.Channel.addCallPickupGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallPickupGroupResponse> addCallPickupGroupAsync(AxlNetClient.AddCallPickupGroupReq addCallPickupGroup)
        {
            AxlNetClient.addCallPickupGroupRequest inValue = new AxlNetClient.addCallPickupGroupRequest();
            inValue.addCallPickupGroup = addCallPickupGroup;
            return ((AxlNetClient.AXLPort50)(this)).addCallPickupGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallPickupGroupResponse AxlNetClient.AXLPort50.updateCallPickupGroup(AxlNetClient.updateCallPickupGroupRequest request)
        {
            return base.Channel.updateCallPickupGroup(request);
        }

        public AxlNetClient.StandardResponse updateCallPickupGroup(AxlNetClient.UpdateCallPickupGroupReq updateCallPickupGroup1)
        {
            AxlNetClient.updateCallPickupGroupRequest inValue = new AxlNetClient.updateCallPickupGroupRequest();
            inValue.updateCallPickupGroup = updateCallPickupGroup1;
            AxlNetClient.updateCallPickupGroupResponse retVal = ((AxlNetClient.AXLPort50)(this)).updateCallPickupGroup(inValue);
            return retVal.updateCallPickupGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallPickupGroupResponse> AxlNetClient.AXLPort50.updateCallPickupGroupAsync(AxlNetClient.updateCallPickupGroupRequest request)
        {
            return base.Channel.updateCallPickupGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallPickupGroupResponse> updateCallPickupGroupAsync(AxlNetClient.UpdateCallPickupGroupReq updateCallPickupGroup)
        {
            AxlNetClient.updateCallPickupGroupRequest inValue = new AxlNetClient.updateCallPickupGroupRequest();
            inValue.updateCallPickupGroup = updateCallPickupGroup;
            return ((AxlNetClient.AXLPort50)(this)).updateCallPickupGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallPickupGroupResponse AxlNetClient.AXLPort50.getCallPickupGroup(AxlNetClient.getCallPickupGroupRequest request)
        {
            return base.Channel.getCallPickupGroup(request);
        }

        public AxlNetClient.GetCallPickupGroupRes getCallPickupGroup(AxlNetClient.GetCallPickupGroupReq getCallPickupGroup1)
        {
            AxlNetClient.getCallPickupGroupRequest inValue = new AxlNetClient.getCallPickupGroupRequest();
            inValue.getCallPickupGroup = getCallPickupGroup1;
            AxlNetClient.getCallPickupGroupResponse retVal = ((AxlNetClient.AXLPort50)(this)).getCallPickupGroup(inValue);
            return retVal.getCallPickupGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallPickupGroupResponse> AxlNetClient.AXLPort50.getCallPickupGroupAsync(AxlNetClient.getCallPickupGroupRequest request)
        {
            return base.Channel.getCallPickupGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallPickupGroupResponse> getCallPickupGroupAsync(AxlNetClient.GetCallPickupGroupReq getCallPickupGroup)
        {
            AxlNetClient.getCallPickupGroupRequest inValue = new AxlNetClient.getCallPickupGroupRequest();
            inValue.getCallPickupGroup = getCallPickupGroup;
            return ((AxlNetClient.AXLPort50)(this)).getCallPickupGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCallPickupGroupResponse AxlNetClient.AXLPort50.removeCallPickupGroup(AxlNetClient.removeCallPickupGroupRequest request)
        {
            return base.Channel.removeCallPickupGroup(request);
        }

        public AxlNetClient.StandardResponse removeCallPickupGroup(AxlNetClient.RemoveCallPickupGroupReq removeCallPickupGroup1)
        {
            AxlNetClient.removeCallPickupGroupRequest inValue = new AxlNetClient.removeCallPickupGroupRequest();
            inValue.removeCallPickupGroup = removeCallPickupGroup1;
            AxlNetClient.removeCallPickupGroupResponse retVal = ((AxlNetClient.AXLPort50)(this)).removeCallPickupGroup(inValue);
            return retVal.removeCallPickupGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCallPickupGroupResponse> AxlNetClient.AXLPort50.removeCallPickupGroupAsync(AxlNetClient.removeCallPickupGroupRequest request)
        {
            return base.Channel.removeCallPickupGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallPickupGroupResponse> removeCallPickupGroupAsync(AxlNetClient.RemoveCallPickupGroupReq removeCallPickupGroup)
        {
            AxlNetClient.removeCallPickupGroupRequest inValue = new AxlNetClient.removeCallPickupGroupRequest();
            inValue.removeCallPickupGroup = removeCallPickupGroup;
            return ((AxlNetClient.AXLPort50)(this)).removeCallPickupGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallPickupGroupResponse AxlNetClient.AXLPort50.listCallPickupGroup(AxlNetClient.listCallPickupGroupRequest request)
        {
            return base.Channel.listCallPickupGroup(request);
        }

        public AxlNetClient.ListCallPickupGroupRes listCallPickupGroup(AxlNetClient.ListCallPickupGroupReq listCallPickupGroup1)
        {
            AxlNetClient.listCallPickupGroupRequest inValue = new AxlNetClient.listCallPickupGroupRequest();
            inValue.listCallPickupGroup = listCallPickupGroup1;
            AxlNetClient.listCallPickupGroupResponse retVal = ((AxlNetClient.AXLPort50)(this)).listCallPickupGroup(inValue);
            return retVal.listCallPickupGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallPickupGroupResponse> AxlNetClient.AXLPort50.listCallPickupGroupAsync(AxlNetClient.listCallPickupGroupRequest request)
        {
            return base.Channel.listCallPickupGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallPickupGroupResponse> listCallPickupGroupAsync(AxlNetClient.ListCallPickupGroupReq listCallPickupGroup)
        {
            AxlNetClient.listCallPickupGroupRequest inValue = new AxlNetClient.listCallPickupGroupRequest();
            inValue.listCallPickupGroup = listCallPickupGroup;
            return ((AxlNetClient.AXLPort50)(this)).listCallPickupGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRoutePlanResponse AxlNetClient.AXLPort50.listRoutePlan(AxlNetClient.listRoutePlanRequest request)
        {
            return base.Channel.listRoutePlan(request);
        }

        public AxlNetClient.ListRoutePlanRes listRoutePlan(AxlNetClient.ListRoutePlanReq listRoutePlan1)
        {
            AxlNetClient.listRoutePlanRequest inValue = new AxlNetClient.listRoutePlanRequest();
            inValue.listRoutePlan = listRoutePlan1;
            AxlNetClient.listRoutePlanResponse retVal = ((AxlNetClient.AXLPort50)(this)).listRoutePlan(inValue);
            return retVal.listRoutePlanResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRoutePlanResponse> AxlNetClient.AXLPort50.listRoutePlanAsync(AxlNetClient.listRoutePlanRequest request)
        {
            return base.Channel.listRoutePlanAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRoutePlanResponse> listRoutePlanAsync(AxlNetClient.ListRoutePlanReq listRoutePlan)
        {
            AxlNetClient.listRoutePlanRequest inValue = new AxlNetClient.listRoutePlanRequest();
            inValue.listRoutePlan = listRoutePlan;
            return ((AxlNetClient.AXLPort50)(this)).listRoutePlanAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGeoLocationPolicyResponse AxlNetClient.AXLPort50.addGeoLocationPolicy(AxlNetClient.addGeoLocationPolicyRequest request)
        {
            return base.Channel.addGeoLocationPolicy(request);
        }

        public AxlNetClient.StandardResponse addGeoLocationPolicy(AxlNetClient.AddGeoLocationPolicyReq addGeoLocationPolicy1)
        {
            AxlNetClient.addGeoLocationPolicyRequest inValue = new AxlNetClient.addGeoLocationPolicyRequest();
            inValue.addGeoLocationPolicy = addGeoLocationPolicy1;
            AxlNetClient.addGeoLocationPolicyResponse retVal = ((AxlNetClient.AXLPort50)(this)).addGeoLocationPolicy(inValue);
            return retVal.addGeoLocationPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationPolicyResponse> AxlNetClient.AXLPort50.addGeoLocationPolicyAsync(AxlNetClient.addGeoLocationPolicyRequest request)
        {
            return base.Channel.addGeoLocationPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationPolicyResponse> addGeoLocationPolicyAsync(AxlNetClient.AddGeoLocationPolicyReq addGeoLocationPolicy)
        {
            AxlNetClient.addGeoLocationPolicyRequest inValue = new AxlNetClient.addGeoLocationPolicyRequest();
            inValue.addGeoLocationPolicy = addGeoLocationPolicy;
            return ((AxlNetClient.AXLPort50)(this)).addGeoLocationPolicyAsync(inValue);
        }
    }
}