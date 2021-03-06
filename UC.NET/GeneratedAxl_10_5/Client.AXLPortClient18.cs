namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient18 _axlPortClient18;

        private static AXLPortClient18 axlPortClient18 => _axlPortClient18 == null ||
            _axlPortClient18.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient18 = LoadClient18()) : _axlPortClient18;

        private static AXLPortClient18 LoadClient18()
        {
            var client = new AXLPortClient18(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close18;
            OnAbort += Abort18;
            return client;
        }

        private static void Close18(object sender, System.EventArgs e)
        {
            _axlPortClient18.Close();
        }

        private static void Abort18(object sender, System.EventArgs e)
        {
            _axlPortClient18.Abort();
        }

        public AxlNetClient.StandardResponse addUserGroup(AxlNetClient.AddUserGroupReq addUserGroup1)
        {
            return axlPortClient18.addUserGroup(addUserGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserGroupResponse> addUserGroupAsync(AxlNetClient.AddUserGroupReq addUserGroup)
        {
            return axlPortClient18.addUserGroupAsync(addUserGroup);
        }

        public AxlNetClient.StandardResponse updateUserGroup(AxlNetClient.UpdateUserGroupReq updateUserGroup1)
        {
            return axlPortClient18.updateUserGroup(updateUserGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserGroupResponse> updateUserGroupAsync(AxlNetClient.UpdateUserGroupReq updateUserGroup)
        {
            return axlPortClient18.updateUserGroupAsync(updateUserGroup);
        }

        public AxlNetClient.GetUserGroupRes getUserGroup(AxlNetClient.GetUserGroupReq getUserGroup1)
        {
            return axlPortClient18.getUserGroup(getUserGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserGroupResponse> getUserGroupAsync(AxlNetClient.GetUserGroupReq getUserGroup)
        {
            return axlPortClient18.getUserGroupAsync(getUserGroup);
        }

        public AxlNetClient.StandardResponse removeUserGroup(AxlNetClient.NameAndGUIDRequest removeUserGroup1)
        {
            return axlPortClient18.removeUserGroup(removeUserGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserGroupResponse> removeUserGroupAsync(AxlNetClient.NameAndGUIDRequest removeUserGroup)
        {
            return axlPortClient18.removeUserGroupAsync(removeUserGroup);
        }

        public AxlNetClient.ListUserGroupRes listUserGroup(AxlNetClient.ListUserGroupReq listUserGroup1)
        {
            return axlPortClient18.listUserGroup(listUserGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserGroupResponse> listUserGroupAsync(AxlNetClient.ListUserGroupReq listUserGroup)
        {
            return axlPortClient18.listUserGroupAsync(listUserGroup);
        }

        public AxlNetClient.GetDialPlanRes getDialPlan(AxlNetClient.GetDialPlanReq getDialPlan1)
        {
            return axlPortClient18.getDialPlan(getDialPlan1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDialPlanResponse> getDialPlanAsync(AxlNetClient.GetDialPlanReq getDialPlan)
        {
            return axlPortClient18.getDialPlanAsync(getDialPlan);
        }

        public AxlNetClient.ListDialPlanRes listDialPlan(AxlNetClient.ListDialPlanReq listDialPlan1)
        {
            return axlPortClient18.listDialPlan(listDialPlan1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDialPlanResponse> listDialPlanAsync(AxlNetClient.ListDialPlanReq listDialPlan)
        {
            return axlPortClient18.listDialPlanAsync(listDialPlan);
        }

        public AxlNetClient.GetDialPlanTagRes getDialPlanTag(AxlNetClient.GetDialPlanTagReq getDialPlanTag1)
        {
            return axlPortClient18.getDialPlanTag(getDialPlanTag1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDialPlanTagResponse> getDialPlanTagAsync(AxlNetClient.GetDialPlanTagReq getDialPlanTag)
        {
            return axlPortClient18.getDialPlanTagAsync(getDialPlanTag);
        }

        public AxlNetClient.ListDialPlanTagRes listDialPlanTag(AxlNetClient.ListDialPlanTagReq listDialPlanTag1)
        {
            return axlPortClient18.listDialPlanTag(listDialPlanTag1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDialPlanTagResponse> listDialPlanTagAsync(AxlNetClient.ListDialPlanTagReq listDialPlanTag)
        {
            return axlPortClient18.listDialPlanTagAsync(listDialPlanTag);
        }

        public AxlNetClient.GetDdiRes getDdi(AxlNetClient.GetDdiReq getDdi1)
        {
            return axlPortClient18.getDdi(getDdi1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDdiResponse> getDdiAsync(AxlNetClient.GetDdiReq getDdi)
        {
            return axlPortClient18.getDdiAsync(getDdi);
        }

        public AxlNetClient.ListDdiRes listDdi(AxlNetClient.ListDdiReq listDdi1)
        {
            return axlPortClient18.listDdi(listDdi1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDdiResponse> listDdiAsync(AxlNetClient.ListDdiReq listDdi)
        {
            return axlPortClient18.listDdiAsync(listDdi);
        }

        public AxlNetClient.GetMobileSmartClientProfileRes getMobileSmartClientProfile(AxlNetClient.GetMobileSmartClientProfileReq getMobileSmartClientProfile1)
        {
            return axlPortClient18.getMobileSmartClientProfile(getMobileSmartClientProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobileSmartClientProfileResponse> getMobileSmartClientProfileAsync(AxlNetClient.GetMobileSmartClientProfileReq getMobileSmartClientProfile)
        {
            return axlPortClient18.getMobileSmartClientProfileAsync(getMobileSmartClientProfile);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort18
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUserGroupResponse addUserGroup(AxlNetClient.addUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUserGroupResponse> addUserGroupAsync(AxlNetClient.addUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUserGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUserGroupResponse updateUserGroup(AxlNetClient.updateUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUserGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUserGroupResponse> updateUserGroupAsync(AxlNetClient.updateUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUserGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUserGroupResponse getUserGroup(AxlNetClient.getUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUserGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUserGroupResponse> getUserGroupAsync(AxlNetClient.getUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUserGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUserGroupResponse removeUserGroup(AxlNetClient.removeUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUserGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUserGroupResponse> removeUserGroupAsync(AxlNetClient.removeUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUserGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUserGroupResponse listUserGroup(AxlNetClient.listUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUserGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUserGroupResponse> listUserGroupAsync(AxlNetClient.listUserGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDialPlan", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDialPlanResponse getDialPlan(AxlNetClient.getDialPlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDialPlan", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDialPlanResponse> getDialPlanAsync(AxlNetClient.getDialPlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDialPlan", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDialPlanResponse listDialPlan(AxlNetClient.listDialPlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDialPlan", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDialPlanResponse> listDialPlanAsync(AxlNetClient.listDialPlanRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDialPlanTag", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDialPlanTagResponse getDialPlanTag(AxlNetClient.getDialPlanTagRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDialPlanTag", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDialPlanTagResponse> getDialPlanTagAsync(AxlNetClient.getDialPlanTagRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDialPlanTag", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDialPlanTagResponse listDialPlanTag(AxlNetClient.listDialPlanTagRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDialPlanTag", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDialPlanTagResponse> listDialPlanTagAsync(AxlNetClient.listDialPlanTagRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDdi", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDdiResponse getDdi(AxlNetClient.getDdiRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDdi", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDdiResponse> getDdiAsync(AxlNetClient.getDdiRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDdi", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDdiResponse listDdi(AxlNetClient.listDdiRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDdi", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDdiResponse> listDdiAsync(AxlNetClient.listDdiRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobileSmartClientProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMobileSmartClientProfileResponse getMobileSmartClientProfile(AxlNetClient.getMobileSmartClientProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMobileSmartClientProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMobileSmartClientProfileResponse> getMobileSmartClientProfileAsync(AxlNetClient.getMobileSmartClientProfileRequest request);
    }

    public class AXLPortClient18 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort18>, AxlNetClient.AXLPort18
    {
        public AXLPortClient18(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUserGroupResponse AxlNetClient.AXLPort18.addUserGroup(AxlNetClient.addUserGroupRequest request)
        {
            return base.Channel.addUserGroup(request);
        }

        public AxlNetClient.StandardResponse addUserGroup(AxlNetClient.AddUserGroupReq addUserGroup1)
        {
            AxlNetClient.addUserGroupRequest inValue = new AxlNetClient.addUserGroupRequest();
            inValue.addUserGroup = addUserGroup1;
            AxlNetClient.addUserGroupResponse retVal = ((AxlNetClient.AXLPort18)(this)).addUserGroup(inValue);
            return retVal.addUserGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUserGroupResponse> AxlNetClient.AXLPort18.addUserGroupAsync(AxlNetClient.addUserGroupRequest request)
        {
            return base.Channel.addUserGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserGroupResponse> addUserGroupAsync(AxlNetClient.AddUserGroupReq addUserGroup)
        {
            AxlNetClient.addUserGroupRequest inValue = new AxlNetClient.addUserGroupRequest();
            inValue.addUserGroup = addUserGroup;
            return ((AxlNetClient.AXLPort18)(this)).addUserGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUserGroupResponse AxlNetClient.AXLPort18.updateUserGroup(AxlNetClient.updateUserGroupRequest request)
        {
            return base.Channel.updateUserGroup(request);
        }

        public AxlNetClient.StandardResponse updateUserGroup(AxlNetClient.UpdateUserGroupReq updateUserGroup1)
        {
            AxlNetClient.updateUserGroupRequest inValue = new AxlNetClient.updateUserGroupRequest();
            inValue.updateUserGroup = updateUserGroup1;
            AxlNetClient.updateUserGroupResponse retVal = ((AxlNetClient.AXLPort18)(this)).updateUserGroup(inValue);
            return retVal.updateUserGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUserGroupResponse> AxlNetClient.AXLPort18.updateUserGroupAsync(AxlNetClient.updateUserGroupRequest request)
        {
            return base.Channel.updateUserGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserGroupResponse> updateUserGroupAsync(AxlNetClient.UpdateUserGroupReq updateUserGroup)
        {
            AxlNetClient.updateUserGroupRequest inValue = new AxlNetClient.updateUserGroupRequest();
            inValue.updateUserGroup = updateUserGroup;
            return ((AxlNetClient.AXLPort18)(this)).updateUserGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUserGroupResponse AxlNetClient.AXLPort18.getUserGroup(AxlNetClient.getUserGroupRequest request)
        {
            return base.Channel.getUserGroup(request);
        }

        public AxlNetClient.GetUserGroupRes getUserGroup(AxlNetClient.GetUserGroupReq getUserGroup1)
        {
            AxlNetClient.getUserGroupRequest inValue = new AxlNetClient.getUserGroupRequest();
            inValue.getUserGroup = getUserGroup1;
            AxlNetClient.getUserGroupResponse retVal = ((AxlNetClient.AXLPort18)(this)).getUserGroup(inValue);
            return retVal.getUserGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUserGroupResponse> AxlNetClient.AXLPort18.getUserGroupAsync(AxlNetClient.getUserGroupRequest request)
        {
            return base.Channel.getUserGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserGroupResponse> getUserGroupAsync(AxlNetClient.GetUserGroupReq getUserGroup)
        {
            AxlNetClient.getUserGroupRequest inValue = new AxlNetClient.getUserGroupRequest();
            inValue.getUserGroup = getUserGroup;
            return ((AxlNetClient.AXLPort18)(this)).getUserGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUserGroupResponse AxlNetClient.AXLPort18.removeUserGroup(AxlNetClient.removeUserGroupRequest request)
        {
            return base.Channel.removeUserGroup(request);
        }

        public AxlNetClient.StandardResponse removeUserGroup(AxlNetClient.NameAndGUIDRequest removeUserGroup1)
        {
            AxlNetClient.removeUserGroupRequest inValue = new AxlNetClient.removeUserGroupRequest();
            inValue.removeUserGroup = removeUserGroup1;
            AxlNetClient.removeUserGroupResponse retVal = ((AxlNetClient.AXLPort18)(this)).removeUserGroup(inValue);
            return retVal.removeUserGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUserGroupResponse> AxlNetClient.AXLPort18.removeUserGroupAsync(AxlNetClient.removeUserGroupRequest request)
        {
            return base.Channel.removeUserGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserGroupResponse> removeUserGroupAsync(AxlNetClient.NameAndGUIDRequest removeUserGroup)
        {
            AxlNetClient.removeUserGroupRequest inValue = new AxlNetClient.removeUserGroupRequest();
            inValue.removeUserGroup = removeUserGroup;
            return ((AxlNetClient.AXLPort18)(this)).removeUserGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUserGroupResponse AxlNetClient.AXLPort18.listUserGroup(AxlNetClient.listUserGroupRequest request)
        {
            return base.Channel.listUserGroup(request);
        }

        public AxlNetClient.ListUserGroupRes listUserGroup(AxlNetClient.ListUserGroupReq listUserGroup1)
        {
            AxlNetClient.listUserGroupRequest inValue = new AxlNetClient.listUserGroupRequest();
            inValue.listUserGroup = listUserGroup1;
            AxlNetClient.listUserGroupResponse retVal = ((AxlNetClient.AXLPort18)(this)).listUserGroup(inValue);
            return retVal.listUserGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUserGroupResponse> AxlNetClient.AXLPort18.listUserGroupAsync(AxlNetClient.listUserGroupRequest request)
        {
            return base.Channel.listUserGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserGroupResponse> listUserGroupAsync(AxlNetClient.ListUserGroupReq listUserGroup)
        {
            AxlNetClient.listUserGroupRequest inValue = new AxlNetClient.listUserGroupRequest();
            inValue.listUserGroup = listUserGroup;
            return ((AxlNetClient.AXLPort18)(this)).listUserGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDialPlanResponse AxlNetClient.AXLPort18.getDialPlan(AxlNetClient.getDialPlanRequest request)
        {
            return base.Channel.getDialPlan(request);
        }

        public AxlNetClient.GetDialPlanRes getDialPlan(AxlNetClient.GetDialPlanReq getDialPlan1)
        {
            AxlNetClient.getDialPlanRequest inValue = new AxlNetClient.getDialPlanRequest();
            inValue.getDialPlan = getDialPlan1;
            AxlNetClient.getDialPlanResponse retVal = ((AxlNetClient.AXLPort18)(this)).getDialPlan(inValue);
            return retVal.getDialPlanResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDialPlanResponse> AxlNetClient.AXLPort18.getDialPlanAsync(AxlNetClient.getDialPlanRequest request)
        {
            return base.Channel.getDialPlanAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDialPlanResponse> getDialPlanAsync(AxlNetClient.GetDialPlanReq getDialPlan)
        {
            AxlNetClient.getDialPlanRequest inValue = new AxlNetClient.getDialPlanRequest();
            inValue.getDialPlan = getDialPlan;
            return ((AxlNetClient.AXLPort18)(this)).getDialPlanAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDialPlanResponse AxlNetClient.AXLPort18.listDialPlan(AxlNetClient.listDialPlanRequest request)
        {
            return base.Channel.listDialPlan(request);
        }

        public AxlNetClient.ListDialPlanRes listDialPlan(AxlNetClient.ListDialPlanReq listDialPlan1)
        {
            AxlNetClient.listDialPlanRequest inValue = new AxlNetClient.listDialPlanRequest();
            inValue.listDialPlan = listDialPlan1;
            AxlNetClient.listDialPlanResponse retVal = ((AxlNetClient.AXLPort18)(this)).listDialPlan(inValue);
            return retVal.listDialPlanResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDialPlanResponse> AxlNetClient.AXLPort18.listDialPlanAsync(AxlNetClient.listDialPlanRequest request)
        {
            return base.Channel.listDialPlanAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDialPlanResponse> listDialPlanAsync(AxlNetClient.ListDialPlanReq listDialPlan)
        {
            AxlNetClient.listDialPlanRequest inValue = new AxlNetClient.listDialPlanRequest();
            inValue.listDialPlan = listDialPlan;
            return ((AxlNetClient.AXLPort18)(this)).listDialPlanAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDialPlanTagResponse AxlNetClient.AXLPort18.getDialPlanTag(AxlNetClient.getDialPlanTagRequest request)
        {
            return base.Channel.getDialPlanTag(request);
        }

        public AxlNetClient.GetDialPlanTagRes getDialPlanTag(AxlNetClient.GetDialPlanTagReq getDialPlanTag1)
        {
            AxlNetClient.getDialPlanTagRequest inValue = new AxlNetClient.getDialPlanTagRequest();
            inValue.getDialPlanTag = getDialPlanTag1;
            AxlNetClient.getDialPlanTagResponse retVal = ((AxlNetClient.AXLPort18)(this)).getDialPlanTag(inValue);
            return retVal.getDialPlanTagResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDialPlanTagResponse> AxlNetClient.AXLPort18.getDialPlanTagAsync(AxlNetClient.getDialPlanTagRequest request)
        {
            return base.Channel.getDialPlanTagAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDialPlanTagResponse> getDialPlanTagAsync(AxlNetClient.GetDialPlanTagReq getDialPlanTag)
        {
            AxlNetClient.getDialPlanTagRequest inValue = new AxlNetClient.getDialPlanTagRequest();
            inValue.getDialPlanTag = getDialPlanTag;
            return ((AxlNetClient.AXLPort18)(this)).getDialPlanTagAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDialPlanTagResponse AxlNetClient.AXLPort18.listDialPlanTag(AxlNetClient.listDialPlanTagRequest request)
        {
            return base.Channel.listDialPlanTag(request);
        }

        public AxlNetClient.ListDialPlanTagRes listDialPlanTag(AxlNetClient.ListDialPlanTagReq listDialPlanTag1)
        {
            AxlNetClient.listDialPlanTagRequest inValue = new AxlNetClient.listDialPlanTagRequest();
            inValue.listDialPlanTag = listDialPlanTag1;
            AxlNetClient.listDialPlanTagResponse retVal = ((AxlNetClient.AXLPort18)(this)).listDialPlanTag(inValue);
            return retVal.listDialPlanTagResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDialPlanTagResponse> AxlNetClient.AXLPort18.listDialPlanTagAsync(AxlNetClient.listDialPlanTagRequest request)
        {
            return base.Channel.listDialPlanTagAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDialPlanTagResponse> listDialPlanTagAsync(AxlNetClient.ListDialPlanTagReq listDialPlanTag)
        {
            AxlNetClient.listDialPlanTagRequest inValue = new AxlNetClient.listDialPlanTagRequest();
            inValue.listDialPlanTag = listDialPlanTag;
            return ((AxlNetClient.AXLPort18)(this)).listDialPlanTagAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDdiResponse AxlNetClient.AXLPort18.getDdi(AxlNetClient.getDdiRequest request)
        {
            return base.Channel.getDdi(request);
        }

        public AxlNetClient.GetDdiRes getDdi(AxlNetClient.GetDdiReq getDdi1)
        {
            AxlNetClient.getDdiRequest inValue = new AxlNetClient.getDdiRequest();
            inValue.getDdi = getDdi1;
            AxlNetClient.getDdiResponse retVal = ((AxlNetClient.AXLPort18)(this)).getDdi(inValue);
            return retVal.getDdiResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDdiResponse> AxlNetClient.AXLPort18.getDdiAsync(AxlNetClient.getDdiRequest request)
        {
            return base.Channel.getDdiAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDdiResponse> getDdiAsync(AxlNetClient.GetDdiReq getDdi)
        {
            AxlNetClient.getDdiRequest inValue = new AxlNetClient.getDdiRequest();
            inValue.getDdi = getDdi;
            return ((AxlNetClient.AXLPort18)(this)).getDdiAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDdiResponse AxlNetClient.AXLPort18.listDdi(AxlNetClient.listDdiRequest request)
        {
            return base.Channel.listDdi(request);
        }

        public AxlNetClient.ListDdiRes listDdi(AxlNetClient.ListDdiReq listDdi1)
        {
            AxlNetClient.listDdiRequest inValue = new AxlNetClient.listDdiRequest();
            inValue.listDdi = listDdi1;
            AxlNetClient.listDdiResponse retVal = ((AxlNetClient.AXLPort18)(this)).listDdi(inValue);
            return retVal.listDdiResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDdiResponse> AxlNetClient.AXLPort18.listDdiAsync(AxlNetClient.listDdiRequest request)
        {
            return base.Channel.listDdiAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDdiResponse> listDdiAsync(AxlNetClient.ListDdiReq listDdi)
        {
            AxlNetClient.listDdiRequest inValue = new AxlNetClient.listDdiRequest();
            inValue.listDdi = listDdi;
            return ((AxlNetClient.AXLPort18)(this)).listDdiAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMobileSmartClientProfileResponse AxlNetClient.AXLPort18.getMobileSmartClientProfile(AxlNetClient.getMobileSmartClientProfileRequest request)
        {
            return base.Channel.getMobileSmartClientProfile(request);
        }

        public AxlNetClient.GetMobileSmartClientProfileRes getMobileSmartClientProfile(AxlNetClient.GetMobileSmartClientProfileReq getMobileSmartClientProfile1)
        {
            AxlNetClient.getMobileSmartClientProfileRequest inValue = new AxlNetClient.getMobileSmartClientProfileRequest();
            inValue.getMobileSmartClientProfile = getMobileSmartClientProfile1;
            AxlNetClient.getMobileSmartClientProfileResponse retVal = ((AxlNetClient.AXLPort18)(this)).getMobileSmartClientProfile(inValue);
            return retVal.getMobileSmartClientProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMobileSmartClientProfileResponse> AxlNetClient.AXLPort18.getMobileSmartClientProfileAsync(AxlNetClient.getMobileSmartClientProfileRequest request)
        {
            return base.Channel.getMobileSmartClientProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMobileSmartClientProfileResponse> getMobileSmartClientProfileAsync(AxlNetClient.GetMobileSmartClientProfileReq getMobileSmartClientProfile)
        {
            AxlNetClient.getMobileSmartClientProfileRequest inValue = new AxlNetClient.getMobileSmartClientProfileRequest();
            inValue.getMobileSmartClientProfile = getMobileSmartClientProfile;
            return ((AxlNetClient.AXLPort18)(this)).getMobileSmartClientProfileAsync(inValue);
        }
    }
}