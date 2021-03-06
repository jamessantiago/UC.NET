namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient74 _axlPortClient74;

        private static AXLPortClient74 axlPortClient74 => _axlPortClient74 == null ||
            _axlPortClient74.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient74 = LoadClient74()) : _axlPortClient74;

        private static AXLPortClient74 LoadClient74()
        {
            var client = new AXLPortClient74(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close74;
            OnAbort += Abort74;
            return client;
        }

        private static void Close74(object sender, System.EventArgs e)
        {
            _axlPortClient74.Close();
        }

        private static void Abort74(object sender, System.EventArgs e)
        {
            _axlPortClient74.Abort();
        }

        public AxlNetClient.ListUniversalDeviceTemplateRes listUniversalDeviceTemplate(AxlNetClient.ListUniversalDeviceTemplateReq listUniversalDeviceTemplate1)
        {
            return axlPortClient74.listUniversalDeviceTemplate(listUniversalDeviceTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUniversalDeviceTemplateResponse> listUniversalDeviceTemplateAsync(AxlNetClient.ListUniversalDeviceTemplateReq listUniversalDeviceTemplate)
        {
            return axlPortClient74.listUniversalDeviceTemplateAsync(listUniversalDeviceTemplate);
        }

        public AxlNetClient.StandardResponse addUserProfileProvision(AxlNetClient.AddUserProfileProvisionReq addUserProfileProvision1)
        {
            return axlPortClient74.addUserProfileProvision(addUserProfileProvision1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserProfileProvisionResponse> addUserProfileProvisionAsync(AxlNetClient.AddUserProfileProvisionReq addUserProfileProvision)
        {
            return axlPortClient74.addUserProfileProvisionAsync(addUserProfileProvision);
        }

        public AxlNetClient.StandardResponse updateUserProfileProvision(AxlNetClient.UpdateUserProfileProvisionReq updateUserProfileProvision1)
        {
            return axlPortClient74.updateUserProfileProvision(updateUserProfileProvision1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserProfileProvisionResponse> updateUserProfileProvisionAsync(AxlNetClient.UpdateUserProfileProvisionReq updateUserProfileProvision)
        {
            return axlPortClient74.updateUserProfileProvisionAsync(updateUserProfileProvision);
        }

        public AxlNetClient.GetUserProfileProvisionRes getUserProfileProvision(AxlNetClient.GetUserProfileProvisionReq getUserProfileProvision1)
        {
            return axlPortClient74.getUserProfileProvision(getUserProfileProvision1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserProfileProvisionResponse> getUserProfileProvisionAsync(AxlNetClient.GetUserProfileProvisionReq getUserProfileProvision)
        {
            return axlPortClient74.getUserProfileProvisionAsync(getUserProfileProvision);
        }

        public AxlNetClient.StandardResponse removeUserProfileProvision(AxlNetClient.NameAndGUIDRequest removeUserProfileProvision1)
        {
            return axlPortClient74.removeUserProfileProvision(removeUserProfileProvision1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserProfileProvisionResponse> removeUserProfileProvisionAsync(AxlNetClient.NameAndGUIDRequest removeUserProfileProvision)
        {
            return axlPortClient74.removeUserProfileProvisionAsync(removeUserProfileProvision);
        }

        public AxlNetClient.ListUserProfileProvisionRes listUserProfileProvision(AxlNetClient.ListUserProfileProvisionReq listUserProfileProvision1)
        {
            return axlPortClient74.listUserProfileProvision(listUserProfileProvision1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserProfileProvisionResponse> listUserProfileProvisionAsync(AxlNetClient.ListUserProfileProvisionReq listUserProfileProvision)
        {
            return axlPortClient74.listUserProfileProvisionAsync(listUserProfileProvision);
        }

        public AxlNetClient.StandardResponse addPresenceRedundancyGroup(AxlNetClient.AddPresenceRedundancyGroupReq addPresenceRedundancyGroup1)
        {
            return axlPortClient74.addPresenceRedundancyGroup(addPresenceRedundancyGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPresenceRedundancyGroupResponse> addPresenceRedundancyGroupAsync(AxlNetClient.AddPresenceRedundancyGroupReq addPresenceRedundancyGroup)
        {
            return axlPortClient74.addPresenceRedundancyGroupAsync(addPresenceRedundancyGroup);
        }

        public AxlNetClient.StandardResponse updatePresenceRedundancyGroup(AxlNetClient.UpdatePresenceRedundancyGroupReq updatePresenceRedundancyGroup1)
        {
            return axlPortClient74.updatePresenceRedundancyGroup(updatePresenceRedundancyGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePresenceRedundancyGroupResponse> updatePresenceRedundancyGroupAsync(AxlNetClient.UpdatePresenceRedundancyGroupReq updatePresenceRedundancyGroup)
        {
            return axlPortClient74.updatePresenceRedundancyGroupAsync(updatePresenceRedundancyGroup);
        }

        public AxlNetClient.GetPresenceRedundancyGroupRes getPresenceRedundancyGroup(AxlNetClient.GetPresenceRedundancyGroupReq getPresenceRedundancyGroup1)
        {
            return axlPortClient74.getPresenceRedundancyGroup(getPresenceRedundancyGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPresenceRedundancyGroupResponse> getPresenceRedundancyGroupAsync(AxlNetClient.GetPresenceRedundancyGroupReq getPresenceRedundancyGroup)
        {
            return axlPortClient74.getPresenceRedundancyGroupAsync(getPresenceRedundancyGroup);
        }

        public AxlNetClient.StandardResponse removePresenceRedundancyGroup(AxlNetClient.NameAndGUIDRequest removePresenceRedundancyGroup1)
        {
            return axlPortClient74.removePresenceRedundancyGroup(removePresenceRedundancyGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePresenceRedundancyGroupResponse> removePresenceRedundancyGroupAsync(AxlNetClient.NameAndGUIDRequest removePresenceRedundancyGroup)
        {
            return axlPortClient74.removePresenceRedundancyGroupAsync(removePresenceRedundancyGroup);
        }

        public AxlNetClient.ListPresenceRedundancyGroupRes listPresenceRedundancyGroup(AxlNetClient.ListPresenceRedundancyGroupReq listPresenceRedundancyGroup1)
        {
            return axlPortClient74.listPresenceRedundancyGroup(listPresenceRedundancyGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPresenceRedundancyGroupResponse> listPresenceRedundancyGroupAsync(AxlNetClient.ListPresenceRedundancyGroupReq listPresenceRedundancyGroup)
        {
            return axlPortClient74.listPresenceRedundancyGroupAsync(listPresenceRedundancyGroup);
        }

        public AxlNetClient.ListAssignedPresenceServersRes listAssignedPresenceServers(AxlNetClient.ListAssignedPresenceServersReq listAssignedPresenceServers1)
        {
            return axlPortClient74.listAssignedPresenceServers(listAssignedPresenceServers1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceServersResponse> listAssignedPresenceServersAsync(AxlNetClient.ListAssignedPresenceServersReq listAssignedPresenceServers)
        {
            return axlPortClient74.listAssignedPresenceServersAsync(listAssignedPresenceServers);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort74
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUniversalDeviceTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUniversalDeviceTemplateResponse listUniversalDeviceTemplate(AxlNetClient.listUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUniversalDeviceTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUniversalDeviceTemplateResponse> listUniversalDeviceTemplateAsync(AxlNetClient.listUniversalDeviceTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserProfileProvision", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addUserProfileProvisionResponse addUserProfileProvision(AxlNetClient.addUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addUserProfileProvision", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addUserProfileProvisionResponse> addUserProfileProvisionAsync(AxlNetClient.addUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUserProfileProvision", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateUserProfileProvisionResponse updateUserProfileProvision(AxlNetClient.updateUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateUserProfileProvision", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateUserProfileProvisionResponse> updateUserProfileProvisionAsync(AxlNetClient.updateUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUserProfileProvision", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getUserProfileProvisionResponse getUserProfileProvision(AxlNetClient.getUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getUserProfileProvision", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getUserProfileProvisionResponse> getUserProfileProvisionAsync(AxlNetClient.getUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUserProfileProvision", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeUserProfileProvisionResponse removeUserProfileProvision(AxlNetClient.removeUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeUserProfileProvision", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeUserProfileProvisionResponse> removeUserProfileProvisionAsync(AxlNetClient.removeUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUserProfileProvision", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listUserProfileProvisionResponse listUserProfileProvision(AxlNetClient.listUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listUserProfileProvision", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listUserProfileProvisionResponse> listUserProfileProvisionAsync(AxlNetClient.listUserProfileProvisionRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPresenceRedundancyGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPresenceRedundancyGroupResponse addPresenceRedundancyGroup(AxlNetClient.addPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPresenceRedundancyGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPresenceRedundancyGroupResponse> addPresenceRedundancyGroupAsync(AxlNetClient.addPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePresenceRedundancyGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePresenceRedundancyGroupResponse updatePresenceRedundancyGroup(AxlNetClient.updatePresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePresenceRedundancyGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePresenceRedundancyGroupResponse> updatePresenceRedundancyGroupAsync(AxlNetClient.updatePresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPresenceRedundancyGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPresenceRedundancyGroupResponse getPresenceRedundancyGroup(AxlNetClient.getPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPresenceRedundancyGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPresenceRedundancyGroupResponse> getPresenceRedundancyGroupAsync(AxlNetClient.getPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePresenceRedundancyGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePresenceRedundancyGroupResponse removePresenceRedundancyGroup(AxlNetClient.removePresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePresenceRedundancyGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePresenceRedundancyGroupResponse> removePresenceRedundancyGroupAsync(AxlNetClient.removePresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPresenceRedundancyGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPresenceRedundancyGroupResponse listPresenceRedundancyGroup(AxlNetClient.listPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPresenceRedundancyGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPresenceRedundancyGroupResponse> listPresenceRedundancyGroupAsync(AxlNetClient.listPresenceRedundancyGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAssignedPresenceServers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAssignedPresenceServersResponse listAssignedPresenceServers(AxlNetClient.listAssignedPresenceServersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAssignedPresenceServers", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceServersResponse> listAssignedPresenceServersAsync(AxlNetClient.listAssignedPresenceServersRequest request);
    }

    public class AXLPortClient74 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort74>, AxlNetClient.AXLPort74
    {
        public AXLPortClient74(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUniversalDeviceTemplateResponse AxlNetClient.AXLPort74.listUniversalDeviceTemplate(AxlNetClient.listUniversalDeviceTemplateRequest request)
        {
            return base.Channel.listUniversalDeviceTemplate(request);
        }

        public AxlNetClient.ListUniversalDeviceTemplateRes listUniversalDeviceTemplate(AxlNetClient.ListUniversalDeviceTemplateReq listUniversalDeviceTemplate1)
        {
            AxlNetClient.listUniversalDeviceTemplateRequest inValue = new AxlNetClient.listUniversalDeviceTemplateRequest();
            inValue.listUniversalDeviceTemplate = listUniversalDeviceTemplate1;
            AxlNetClient.listUniversalDeviceTemplateResponse retVal = ((AxlNetClient.AXLPort74)(this)).listUniversalDeviceTemplate(inValue);
            return retVal.listUniversalDeviceTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUniversalDeviceTemplateResponse> AxlNetClient.AXLPort74.listUniversalDeviceTemplateAsync(AxlNetClient.listUniversalDeviceTemplateRequest request)
        {
            return base.Channel.listUniversalDeviceTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUniversalDeviceTemplateResponse> listUniversalDeviceTemplateAsync(AxlNetClient.ListUniversalDeviceTemplateReq listUniversalDeviceTemplate)
        {
            AxlNetClient.listUniversalDeviceTemplateRequest inValue = new AxlNetClient.listUniversalDeviceTemplateRequest();
            inValue.listUniversalDeviceTemplate = listUniversalDeviceTemplate;
            return ((AxlNetClient.AXLPort74)(this)).listUniversalDeviceTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addUserProfileProvisionResponse AxlNetClient.AXLPort74.addUserProfileProvision(AxlNetClient.addUserProfileProvisionRequest request)
        {
            return base.Channel.addUserProfileProvision(request);
        }

        public AxlNetClient.StandardResponse addUserProfileProvision(AxlNetClient.AddUserProfileProvisionReq addUserProfileProvision1)
        {
            AxlNetClient.addUserProfileProvisionRequest inValue = new AxlNetClient.addUserProfileProvisionRequest();
            inValue.addUserProfileProvision = addUserProfileProvision1;
            AxlNetClient.addUserProfileProvisionResponse retVal = ((AxlNetClient.AXLPort74)(this)).addUserProfileProvision(inValue);
            return retVal.addUserProfileProvisionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addUserProfileProvisionResponse> AxlNetClient.AXLPort74.addUserProfileProvisionAsync(AxlNetClient.addUserProfileProvisionRequest request)
        {
            return base.Channel.addUserProfileProvisionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addUserProfileProvisionResponse> addUserProfileProvisionAsync(AxlNetClient.AddUserProfileProvisionReq addUserProfileProvision)
        {
            AxlNetClient.addUserProfileProvisionRequest inValue = new AxlNetClient.addUserProfileProvisionRequest();
            inValue.addUserProfileProvision = addUserProfileProvision;
            return ((AxlNetClient.AXLPort74)(this)).addUserProfileProvisionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateUserProfileProvisionResponse AxlNetClient.AXLPort74.updateUserProfileProvision(AxlNetClient.updateUserProfileProvisionRequest request)
        {
            return base.Channel.updateUserProfileProvision(request);
        }

        public AxlNetClient.StandardResponse updateUserProfileProvision(AxlNetClient.UpdateUserProfileProvisionReq updateUserProfileProvision1)
        {
            AxlNetClient.updateUserProfileProvisionRequest inValue = new AxlNetClient.updateUserProfileProvisionRequest();
            inValue.updateUserProfileProvision = updateUserProfileProvision1;
            AxlNetClient.updateUserProfileProvisionResponse retVal = ((AxlNetClient.AXLPort74)(this)).updateUserProfileProvision(inValue);
            return retVal.updateUserProfileProvisionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateUserProfileProvisionResponse> AxlNetClient.AXLPort74.updateUserProfileProvisionAsync(AxlNetClient.updateUserProfileProvisionRequest request)
        {
            return base.Channel.updateUserProfileProvisionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateUserProfileProvisionResponse> updateUserProfileProvisionAsync(AxlNetClient.UpdateUserProfileProvisionReq updateUserProfileProvision)
        {
            AxlNetClient.updateUserProfileProvisionRequest inValue = new AxlNetClient.updateUserProfileProvisionRequest();
            inValue.updateUserProfileProvision = updateUserProfileProvision;
            return ((AxlNetClient.AXLPort74)(this)).updateUserProfileProvisionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getUserProfileProvisionResponse AxlNetClient.AXLPort74.getUserProfileProvision(AxlNetClient.getUserProfileProvisionRequest request)
        {
            return base.Channel.getUserProfileProvision(request);
        }

        public AxlNetClient.GetUserProfileProvisionRes getUserProfileProvision(AxlNetClient.GetUserProfileProvisionReq getUserProfileProvision1)
        {
            AxlNetClient.getUserProfileProvisionRequest inValue = new AxlNetClient.getUserProfileProvisionRequest();
            inValue.getUserProfileProvision = getUserProfileProvision1;
            AxlNetClient.getUserProfileProvisionResponse retVal = ((AxlNetClient.AXLPort74)(this)).getUserProfileProvision(inValue);
            return retVal.getUserProfileProvisionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getUserProfileProvisionResponse> AxlNetClient.AXLPort74.getUserProfileProvisionAsync(AxlNetClient.getUserProfileProvisionRequest request)
        {
            return base.Channel.getUserProfileProvisionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getUserProfileProvisionResponse> getUserProfileProvisionAsync(AxlNetClient.GetUserProfileProvisionReq getUserProfileProvision)
        {
            AxlNetClient.getUserProfileProvisionRequest inValue = new AxlNetClient.getUserProfileProvisionRequest();
            inValue.getUserProfileProvision = getUserProfileProvision;
            return ((AxlNetClient.AXLPort74)(this)).getUserProfileProvisionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeUserProfileProvisionResponse AxlNetClient.AXLPort74.removeUserProfileProvision(AxlNetClient.removeUserProfileProvisionRequest request)
        {
            return base.Channel.removeUserProfileProvision(request);
        }

        public AxlNetClient.StandardResponse removeUserProfileProvision(AxlNetClient.NameAndGUIDRequest removeUserProfileProvision1)
        {
            AxlNetClient.removeUserProfileProvisionRequest inValue = new AxlNetClient.removeUserProfileProvisionRequest();
            inValue.removeUserProfileProvision = removeUserProfileProvision1;
            AxlNetClient.removeUserProfileProvisionResponse retVal = ((AxlNetClient.AXLPort74)(this)).removeUserProfileProvision(inValue);
            return retVal.removeUserProfileProvisionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeUserProfileProvisionResponse> AxlNetClient.AXLPort74.removeUserProfileProvisionAsync(AxlNetClient.removeUserProfileProvisionRequest request)
        {
            return base.Channel.removeUserProfileProvisionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeUserProfileProvisionResponse> removeUserProfileProvisionAsync(AxlNetClient.NameAndGUIDRequest removeUserProfileProvision)
        {
            AxlNetClient.removeUserProfileProvisionRequest inValue = new AxlNetClient.removeUserProfileProvisionRequest();
            inValue.removeUserProfileProvision = removeUserProfileProvision;
            return ((AxlNetClient.AXLPort74)(this)).removeUserProfileProvisionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listUserProfileProvisionResponse AxlNetClient.AXLPort74.listUserProfileProvision(AxlNetClient.listUserProfileProvisionRequest request)
        {
            return base.Channel.listUserProfileProvision(request);
        }

        public AxlNetClient.ListUserProfileProvisionRes listUserProfileProvision(AxlNetClient.ListUserProfileProvisionReq listUserProfileProvision1)
        {
            AxlNetClient.listUserProfileProvisionRequest inValue = new AxlNetClient.listUserProfileProvisionRequest();
            inValue.listUserProfileProvision = listUserProfileProvision1;
            AxlNetClient.listUserProfileProvisionResponse retVal = ((AxlNetClient.AXLPort74)(this)).listUserProfileProvision(inValue);
            return retVal.listUserProfileProvisionResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listUserProfileProvisionResponse> AxlNetClient.AXLPort74.listUserProfileProvisionAsync(AxlNetClient.listUserProfileProvisionRequest request)
        {
            return base.Channel.listUserProfileProvisionAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listUserProfileProvisionResponse> listUserProfileProvisionAsync(AxlNetClient.ListUserProfileProvisionReq listUserProfileProvision)
        {
            AxlNetClient.listUserProfileProvisionRequest inValue = new AxlNetClient.listUserProfileProvisionRequest();
            inValue.listUserProfileProvision = listUserProfileProvision;
            return ((AxlNetClient.AXLPort74)(this)).listUserProfileProvisionAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPresenceRedundancyGroupResponse AxlNetClient.AXLPort74.addPresenceRedundancyGroup(AxlNetClient.addPresenceRedundancyGroupRequest request)
        {
            return base.Channel.addPresenceRedundancyGroup(request);
        }

        public AxlNetClient.StandardResponse addPresenceRedundancyGroup(AxlNetClient.AddPresenceRedundancyGroupReq addPresenceRedundancyGroup1)
        {
            AxlNetClient.addPresenceRedundancyGroupRequest inValue = new AxlNetClient.addPresenceRedundancyGroupRequest();
            inValue.addPresenceRedundancyGroup = addPresenceRedundancyGroup1;
            AxlNetClient.addPresenceRedundancyGroupResponse retVal = ((AxlNetClient.AXLPort74)(this)).addPresenceRedundancyGroup(inValue);
            return retVal.addPresenceRedundancyGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPresenceRedundancyGroupResponse> AxlNetClient.AXLPort74.addPresenceRedundancyGroupAsync(AxlNetClient.addPresenceRedundancyGroupRequest request)
        {
            return base.Channel.addPresenceRedundancyGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPresenceRedundancyGroupResponse> addPresenceRedundancyGroupAsync(AxlNetClient.AddPresenceRedundancyGroupReq addPresenceRedundancyGroup)
        {
            AxlNetClient.addPresenceRedundancyGroupRequest inValue = new AxlNetClient.addPresenceRedundancyGroupRequest();
            inValue.addPresenceRedundancyGroup = addPresenceRedundancyGroup;
            return ((AxlNetClient.AXLPort74)(this)).addPresenceRedundancyGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePresenceRedundancyGroupResponse AxlNetClient.AXLPort74.updatePresenceRedundancyGroup(AxlNetClient.updatePresenceRedundancyGroupRequest request)
        {
            return base.Channel.updatePresenceRedundancyGroup(request);
        }

        public AxlNetClient.StandardResponse updatePresenceRedundancyGroup(AxlNetClient.UpdatePresenceRedundancyGroupReq updatePresenceRedundancyGroup1)
        {
            AxlNetClient.updatePresenceRedundancyGroupRequest inValue = new AxlNetClient.updatePresenceRedundancyGroupRequest();
            inValue.updatePresenceRedundancyGroup = updatePresenceRedundancyGroup1;
            AxlNetClient.updatePresenceRedundancyGroupResponse retVal = ((AxlNetClient.AXLPort74)(this)).updatePresenceRedundancyGroup(inValue);
            return retVal.updatePresenceRedundancyGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePresenceRedundancyGroupResponse> AxlNetClient.AXLPort74.updatePresenceRedundancyGroupAsync(AxlNetClient.updatePresenceRedundancyGroupRequest request)
        {
            return base.Channel.updatePresenceRedundancyGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePresenceRedundancyGroupResponse> updatePresenceRedundancyGroupAsync(AxlNetClient.UpdatePresenceRedundancyGroupReq updatePresenceRedundancyGroup)
        {
            AxlNetClient.updatePresenceRedundancyGroupRequest inValue = new AxlNetClient.updatePresenceRedundancyGroupRequest();
            inValue.updatePresenceRedundancyGroup = updatePresenceRedundancyGroup;
            return ((AxlNetClient.AXLPort74)(this)).updatePresenceRedundancyGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPresenceRedundancyGroupResponse AxlNetClient.AXLPort74.getPresenceRedundancyGroup(AxlNetClient.getPresenceRedundancyGroupRequest request)
        {
            return base.Channel.getPresenceRedundancyGroup(request);
        }

        public AxlNetClient.GetPresenceRedundancyGroupRes getPresenceRedundancyGroup(AxlNetClient.GetPresenceRedundancyGroupReq getPresenceRedundancyGroup1)
        {
            AxlNetClient.getPresenceRedundancyGroupRequest inValue = new AxlNetClient.getPresenceRedundancyGroupRequest();
            inValue.getPresenceRedundancyGroup = getPresenceRedundancyGroup1;
            AxlNetClient.getPresenceRedundancyGroupResponse retVal = ((AxlNetClient.AXLPort74)(this)).getPresenceRedundancyGroup(inValue);
            return retVal.getPresenceRedundancyGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPresenceRedundancyGroupResponse> AxlNetClient.AXLPort74.getPresenceRedundancyGroupAsync(AxlNetClient.getPresenceRedundancyGroupRequest request)
        {
            return base.Channel.getPresenceRedundancyGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPresenceRedundancyGroupResponse> getPresenceRedundancyGroupAsync(AxlNetClient.GetPresenceRedundancyGroupReq getPresenceRedundancyGroup)
        {
            AxlNetClient.getPresenceRedundancyGroupRequest inValue = new AxlNetClient.getPresenceRedundancyGroupRequest();
            inValue.getPresenceRedundancyGroup = getPresenceRedundancyGroup;
            return ((AxlNetClient.AXLPort74)(this)).getPresenceRedundancyGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePresenceRedundancyGroupResponse AxlNetClient.AXLPort74.removePresenceRedundancyGroup(AxlNetClient.removePresenceRedundancyGroupRequest request)
        {
            return base.Channel.removePresenceRedundancyGroup(request);
        }

        public AxlNetClient.StandardResponse removePresenceRedundancyGroup(AxlNetClient.NameAndGUIDRequest removePresenceRedundancyGroup1)
        {
            AxlNetClient.removePresenceRedundancyGroupRequest inValue = new AxlNetClient.removePresenceRedundancyGroupRequest();
            inValue.removePresenceRedundancyGroup = removePresenceRedundancyGroup1;
            AxlNetClient.removePresenceRedundancyGroupResponse retVal = ((AxlNetClient.AXLPort74)(this)).removePresenceRedundancyGroup(inValue);
            return retVal.removePresenceRedundancyGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePresenceRedundancyGroupResponse> AxlNetClient.AXLPort74.removePresenceRedundancyGroupAsync(AxlNetClient.removePresenceRedundancyGroupRequest request)
        {
            return base.Channel.removePresenceRedundancyGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePresenceRedundancyGroupResponse> removePresenceRedundancyGroupAsync(AxlNetClient.NameAndGUIDRequest removePresenceRedundancyGroup)
        {
            AxlNetClient.removePresenceRedundancyGroupRequest inValue = new AxlNetClient.removePresenceRedundancyGroupRequest();
            inValue.removePresenceRedundancyGroup = removePresenceRedundancyGroup;
            return ((AxlNetClient.AXLPort74)(this)).removePresenceRedundancyGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPresenceRedundancyGroupResponse AxlNetClient.AXLPort74.listPresenceRedundancyGroup(AxlNetClient.listPresenceRedundancyGroupRequest request)
        {
            return base.Channel.listPresenceRedundancyGroup(request);
        }

        public AxlNetClient.ListPresenceRedundancyGroupRes listPresenceRedundancyGroup(AxlNetClient.ListPresenceRedundancyGroupReq listPresenceRedundancyGroup1)
        {
            AxlNetClient.listPresenceRedundancyGroupRequest inValue = new AxlNetClient.listPresenceRedundancyGroupRequest();
            inValue.listPresenceRedundancyGroup = listPresenceRedundancyGroup1;
            AxlNetClient.listPresenceRedundancyGroupResponse retVal = ((AxlNetClient.AXLPort74)(this)).listPresenceRedundancyGroup(inValue);
            return retVal.listPresenceRedundancyGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPresenceRedundancyGroupResponse> AxlNetClient.AXLPort74.listPresenceRedundancyGroupAsync(AxlNetClient.listPresenceRedundancyGroupRequest request)
        {
            return base.Channel.listPresenceRedundancyGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPresenceRedundancyGroupResponse> listPresenceRedundancyGroupAsync(AxlNetClient.ListPresenceRedundancyGroupReq listPresenceRedundancyGroup)
        {
            AxlNetClient.listPresenceRedundancyGroupRequest inValue = new AxlNetClient.listPresenceRedundancyGroupRequest();
            inValue.listPresenceRedundancyGroup = listPresenceRedundancyGroup;
            return ((AxlNetClient.AXLPort74)(this)).listPresenceRedundancyGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAssignedPresenceServersResponse AxlNetClient.AXLPort74.listAssignedPresenceServers(AxlNetClient.listAssignedPresenceServersRequest request)
        {
            return base.Channel.listAssignedPresenceServers(request);
        }

        public AxlNetClient.ListAssignedPresenceServersRes listAssignedPresenceServers(AxlNetClient.ListAssignedPresenceServersReq listAssignedPresenceServers1)
        {
            AxlNetClient.listAssignedPresenceServersRequest inValue = new AxlNetClient.listAssignedPresenceServersRequest();
            inValue.listAssignedPresenceServers = listAssignedPresenceServers1;
            AxlNetClient.listAssignedPresenceServersResponse retVal = ((AxlNetClient.AXLPort74)(this)).listAssignedPresenceServers(inValue);
            return retVal.listAssignedPresenceServersResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceServersResponse> AxlNetClient.AXLPort74.listAssignedPresenceServersAsync(AxlNetClient.listAssignedPresenceServersRequest request)
        {
            return base.Channel.listAssignedPresenceServersAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAssignedPresenceServersResponse> listAssignedPresenceServersAsync(AxlNetClient.ListAssignedPresenceServersReq listAssignedPresenceServers)
        {
            AxlNetClient.listAssignedPresenceServersRequest inValue = new AxlNetClient.listAssignedPresenceServersRequest();
            inValue.listAssignedPresenceServers = listAssignedPresenceServers;
            return ((AxlNetClient.AXLPort74)(this)).listAssignedPresenceServersAsync(inValue);
        }
    }
}