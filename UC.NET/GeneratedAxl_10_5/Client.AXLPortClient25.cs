namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient25 _axlPortClient25;

        private static AXLPortClient25 axlPortClient25 => _axlPortClient25 == null ||
            _axlPortClient25.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient25 = LoadClient25()) : _axlPortClient25;

        private static AXLPortClient25 LoadClient25()
        {
            var client = new AXLPortClient25(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close25;
            OnAbort += Abort25;
            return client;
        }

        private static void Close25(object sender, System.EventArgs e)
        {
            _axlPortClient25.Close();
        }

        private static void Abort25(object sender, System.EventArgs e)
        {
            _axlPortClient25.Abort();
        }

        public AxlNetClient.StandardResponse applyDateTimeGroup(AxlNetClient.NameAndGUIDRequest applyDateTimeGroup1)
        {
            return axlPortClient25.applyDateTimeGroup(applyDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDateTimeGroupResponse> applyDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest applyDateTimeGroup)
        {
            return axlPortClient25.applyDateTimeGroupAsync(applyDateTimeGroup);
        }

        public AxlNetClient.StandardResponse addPresenceGroup(AxlNetClient.AddPresenceGroupReq addPresenceGroup1)
        {
            return axlPortClient25.addPresenceGroup(addPresenceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPresenceGroupResponse> addPresenceGroupAsync(AxlNetClient.AddPresenceGroupReq addPresenceGroup)
        {
            return axlPortClient25.addPresenceGroupAsync(addPresenceGroup);
        }

        public AxlNetClient.StandardResponse updatePresenceGroup(AxlNetClient.UpdatePresenceGroupReq updatePresenceGroup1)
        {
            return axlPortClient25.updatePresenceGroup(updatePresenceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePresenceGroupResponse> updatePresenceGroupAsync(AxlNetClient.UpdatePresenceGroupReq updatePresenceGroup)
        {
            return axlPortClient25.updatePresenceGroupAsync(updatePresenceGroup);
        }

        public AxlNetClient.GetPresenceGroupRes getPresenceGroup(AxlNetClient.GetPresenceGroupReq getPresenceGroup1)
        {
            return axlPortClient25.getPresenceGroup(getPresenceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPresenceGroupResponse> getPresenceGroupAsync(AxlNetClient.GetPresenceGroupReq getPresenceGroup)
        {
            return axlPortClient25.getPresenceGroupAsync(getPresenceGroup);
        }

        public AxlNetClient.StandardResponse removePresenceGroup(AxlNetClient.NameAndGUIDRequest removePresenceGroup1)
        {
            return axlPortClient25.removePresenceGroup(removePresenceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePresenceGroupResponse> removePresenceGroupAsync(AxlNetClient.NameAndGUIDRequest removePresenceGroup)
        {
            return axlPortClient25.removePresenceGroupAsync(removePresenceGroup);
        }

        public AxlNetClient.ListPresenceGroupRes listPresenceGroup(AxlNetClient.ListPresenceGroupReq listPresenceGroup1)
        {
            return axlPortClient25.listPresenceGroup(listPresenceGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPresenceGroupResponse> listPresenceGroupAsync(AxlNetClient.ListPresenceGroupReq listPresenceGroup)
        {
            return axlPortClient25.listPresenceGroupAsync(listPresenceGroup);
        }

        public AxlNetClient.StandardResponse addGeoLocation(AxlNetClient.AddGeoLocationReq addGeoLocation1)
        {
            return axlPortClient25.addGeoLocation(addGeoLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationResponse> addGeoLocationAsync(AxlNetClient.AddGeoLocationReq addGeoLocation)
        {
            return axlPortClient25.addGeoLocationAsync(addGeoLocation);
        }

        public AxlNetClient.StandardResponse updateGeoLocation(AxlNetClient.UpdateGeoLocationReq updateGeoLocation1)
        {
            return axlPortClient25.updateGeoLocation(updateGeoLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationResponse> updateGeoLocationAsync(AxlNetClient.UpdateGeoLocationReq updateGeoLocation)
        {
            return axlPortClient25.updateGeoLocationAsync(updateGeoLocation);
        }

        public AxlNetClient.GetGeoLocationRes getGeoLocation(AxlNetClient.GetGeoLocationReq getGeoLocation1)
        {
            return axlPortClient25.getGeoLocation(getGeoLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationResponse> getGeoLocationAsync(AxlNetClient.GetGeoLocationReq getGeoLocation)
        {
            return axlPortClient25.getGeoLocationAsync(getGeoLocation);
        }

        public AxlNetClient.StandardResponse removeGeoLocation(AxlNetClient.NameAndGUIDRequest removeGeoLocation1)
        {
            return axlPortClient25.removeGeoLocation(removeGeoLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationResponse> removeGeoLocationAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocation)
        {
            return axlPortClient25.removeGeoLocationAsync(removeGeoLocation);
        }

        public AxlNetClient.ListGeoLocationRes listGeoLocation(AxlNetClient.ListGeoLocationReq listGeoLocation1)
        {
            return axlPortClient25.listGeoLocation(listGeoLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationResponse> listGeoLocationAsync(AxlNetClient.ListGeoLocationReq listGeoLocation)
        {
            return axlPortClient25.listGeoLocationAsync(listGeoLocation);
        }

        public AxlNetClient.StandardResponse addSrst(AxlNetClient.AddSrstReq addSrst1)
        {
            return axlPortClient25.addSrst(addSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSrstResponse> addSrstAsync(AxlNetClient.AddSrstReq addSrst)
        {
            return axlPortClient25.addSrstAsync(addSrst);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort25
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyDateTimeGroupResponse applyDateTimeGroup(AxlNetClient.applyDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyDateTimeGroupResponse> applyDateTimeGroupAsync(AxlNetClient.applyDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPresenceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPresenceGroupResponse addPresenceGroup(AxlNetClient.addPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPresenceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPresenceGroupResponse> addPresenceGroupAsync(AxlNetClient.addPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePresenceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePresenceGroupResponse updatePresenceGroup(AxlNetClient.updatePresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePresenceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePresenceGroupResponse> updatePresenceGroupAsync(AxlNetClient.updatePresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPresenceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPresenceGroupResponse getPresenceGroup(AxlNetClient.getPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPresenceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPresenceGroupResponse> getPresenceGroupAsync(AxlNetClient.getPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePresenceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePresenceGroupResponse removePresenceGroup(AxlNetClient.removePresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePresenceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePresenceGroupResponse> removePresenceGroupAsync(AxlNetClient.removePresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPresenceGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPresenceGroupResponse listPresenceGroup(AxlNetClient.listPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPresenceGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPresenceGroupResponse> listPresenceGroupAsync(AxlNetClient.listPresenceGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGeoLocationResponse addGeoLocation(AxlNetClient.addGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGeoLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationResponse> addGeoLocationAsync(AxlNetClient.addGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGeoLocationResponse updateGeoLocation(AxlNetClient.updateGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationResponse> updateGeoLocationAsync(AxlNetClient.updateGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGeoLocationResponse getGeoLocation(AxlNetClient.getGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationResponse> getGeoLocationAsync(AxlNetClient.getGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGeoLocationResponse removeGeoLocation(AxlNetClient.removeGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationResponse> removeGeoLocationAsync(AxlNetClient.removeGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listGeoLocationResponse listGeoLocation(AxlNetClient.listGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationResponse> listGeoLocationAsync(AxlNetClient.listGeoLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSrstResponse addSrst(AxlNetClient.addSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSrstResponse> addSrstAsync(AxlNetClient.addSrstRequest request);
    }

    public class AXLPortClient25 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort25>, AxlNetClient.AXLPort25
    {
        public AXLPortClient25(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyDateTimeGroupResponse AxlNetClient.AXLPort25.applyDateTimeGroup(AxlNetClient.applyDateTimeGroupRequest request)
        {
            return base.Channel.applyDateTimeGroup(request);
        }

        public AxlNetClient.StandardResponse applyDateTimeGroup(AxlNetClient.NameAndGUIDRequest applyDateTimeGroup1)
        {
            AxlNetClient.applyDateTimeGroupRequest inValue = new AxlNetClient.applyDateTimeGroupRequest();
            inValue.applyDateTimeGroup = applyDateTimeGroup1;
            AxlNetClient.applyDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).applyDateTimeGroup(inValue);
            return retVal.applyDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyDateTimeGroupResponse> AxlNetClient.AXLPort25.applyDateTimeGroupAsync(AxlNetClient.applyDateTimeGroupRequest request)
        {
            return base.Channel.applyDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDateTimeGroupResponse> applyDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest applyDateTimeGroup)
        {
            AxlNetClient.applyDateTimeGroupRequest inValue = new AxlNetClient.applyDateTimeGroupRequest();
            inValue.applyDateTimeGroup = applyDateTimeGroup;
            return ((AxlNetClient.AXLPort25)(this)).applyDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPresenceGroupResponse AxlNetClient.AXLPort25.addPresenceGroup(AxlNetClient.addPresenceGroupRequest request)
        {
            return base.Channel.addPresenceGroup(request);
        }

        public AxlNetClient.StandardResponse addPresenceGroup(AxlNetClient.AddPresenceGroupReq addPresenceGroup1)
        {
            AxlNetClient.addPresenceGroupRequest inValue = new AxlNetClient.addPresenceGroupRequest();
            inValue.addPresenceGroup = addPresenceGroup1;
            AxlNetClient.addPresenceGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).addPresenceGroup(inValue);
            return retVal.addPresenceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPresenceGroupResponse> AxlNetClient.AXLPort25.addPresenceGroupAsync(AxlNetClient.addPresenceGroupRequest request)
        {
            return base.Channel.addPresenceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPresenceGroupResponse> addPresenceGroupAsync(AxlNetClient.AddPresenceGroupReq addPresenceGroup)
        {
            AxlNetClient.addPresenceGroupRequest inValue = new AxlNetClient.addPresenceGroupRequest();
            inValue.addPresenceGroup = addPresenceGroup;
            return ((AxlNetClient.AXLPort25)(this)).addPresenceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePresenceGroupResponse AxlNetClient.AXLPort25.updatePresenceGroup(AxlNetClient.updatePresenceGroupRequest request)
        {
            return base.Channel.updatePresenceGroup(request);
        }

        public AxlNetClient.StandardResponse updatePresenceGroup(AxlNetClient.UpdatePresenceGroupReq updatePresenceGroup1)
        {
            AxlNetClient.updatePresenceGroupRequest inValue = new AxlNetClient.updatePresenceGroupRequest();
            inValue.updatePresenceGroup = updatePresenceGroup1;
            AxlNetClient.updatePresenceGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).updatePresenceGroup(inValue);
            return retVal.updatePresenceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePresenceGroupResponse> AxlNetClient.AXLPort25.updatePresenceGroupAsync(AxlNetClient.updatePresenceGroupRequest request)
        {
            return base.Channel.updatePresenceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePresenceGroupResponse> updatePresenceGroupAsync(AxlNetClient.UpdatePresenceGroupReq updatePresenceGroup)
        {
            AxlNetClient.updatePresenceGroupRequest inValue = new AxlNetClient.updatePresenceGroupRequest();
            inValue.updatePresenceGroup = updatePresenceGroup;
            return ((AxlNetClient.AXLPort25)(this)).updatePresenceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPresenceGroupResponse AxlNetClient.AXLPort25.getPresenceGroup(AxlNetClient.getPresenceGroupRequest request)
        {
            return base.Channel.getPresenceGroup(request);
        }

        public AxlNetClient.GetPresenceGroupRes getPresenceGroup(AxlNetClient.GetPresenceGroupReq getPresenceGroup1)
        {
            AxlNetClient.getPresenceGroupRequest inValue = new AxlNetClient.getPresenceGroupRequest();
            inValue.getPresenceGroup = getPresenceGroup1;
            AxlNetClient.getPresenceGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).getPresenceGroup(inValue);
            return retVal.getPresenceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPresenceGroupResponse> AxlNetClient.AXLPort25.getPresenceGroupAsync(AxlNetClient.getPresenceGroupRequest request)
        {
            return base.Channel.getPresenceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPresenceGroupResponse> getPresenceGroupAsync(AxlNetClient.GetPresenceGroupReq getPresenceGroup)
        {
            AxlNetClient.getPresenceGroupRequest inValue = new AxlNetClient.getPresenceGroupRequest();
            inValue.getPresenceGroup = getPresenceGroup;
            return ((AxlNetClient.AXLPort25)(this)).getPresenceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePresenceGroupResponse AxlNetClient.AXLPort25.removePresenceGroup(AxlNetClient.removePresenceGroupRequest request)
        {
            return base.Channel.removePresenceGroup(request);
        }

        public AxlNetClient.StandardResponse removePresenceGroup(AxlNetClient.NameAndGUIDRequest removePresenceGroup1)
        {
            AxlNetClient.removePresenceGroupRequest inValue = new AxlNetClient.removePresenceGroupRequest();
            inValue.removePresenceGroup = removePresenceGroup1;
            AxlNetClient.removePresenceGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).removePresenceGroup(inValue);
            return retVal.removePresenceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePresenceGroupResponse> AxlNetClient.AXLPort25.removePresenceGroupAsync(AxlNetClient.removePresenceGroupRequest request)
        {
            return base.Channel.removePresenceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePresenceGroupResponse> removePresenceGroupAsync(AxlNetClient.NameAndGUIDRequest removePresenceGroup)
        {
            AxlNetClient.removePresenceGroupRequest inValue = new AxlNetClient.removePresenceGroupRequest();
            inValue.removePresenceGroup = removePresenceGroup;
            return ((AxlNetClient.AXLPort25)(this)).removePresenceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPresenceGroupResponse AxlNetClient.AXLPort25.listPresenceGroup(AxlNetClient.listPresenceGroupRequest request)
        {
            return base.Channel.listPresenceGroup(request);
        }

        public AxlNetClient.ListPresenceGroupRes listPresenceGroup(AxlNetClient.ListPresenceGroupReq listPresenceGroup1)
        {
            AxlNetClient.listPresenceGroupRequest inValue = new AxlNetClient.listPresenceGroupRequest();
            inValue.listPresenceGroup = listPresenceGroup1;
            AxlNetClient.listPresenceGroupResponse retVal = ((AxlNetClient.AXLPort25)(this)).listPresenceGroup(inValue);
            return retVal.listPresenceGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPresenceGroupResponse> AxlNetClient.AXLPort25.listPresenceGroupAsync(AxlNetClient.listPresenceGroupRequest request)
        {
            return base.Channel.listPresenceGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPresenceGroupResponse> listPresenceGroupAsync(AxlNetClient.ListPresenceGroupReq listPresenceGroup)
        {
            AxlNetClient.listPresenceGroupRequest inValue = new AxlNetClient.listPresenceGroupRequest();
            inValue.listPresenceGroup = listPresenceGroup;
            return ((AxlNetClient.AXLPort25)(this)).listPresenceGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGeoLocationResponse AxlNetClient.AXLPort25.addGeoLocation(AxlNetClient.addGeoLocationRequest request)
        {
            return base.Channel.addGeoLocation(request);
        }

        public AxlNetClient.StandardResponse addGeoLocation(AxlNetClient.AddGeoLocationReq addGeoLocation1)
        {
            AxlNetClient.addGeoLocationRequest inValue = new AxlNetClient.addGeoLocationRequest();
            inValue.addGeoLocation = addGeoLocation1;
            AxlNetClient.addGeoLocationResponse retVal = ((AxlNetClient.AXLPort25)(this)).addGeoLocation(inValue);
            return retVal.addGeoLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGeoLocationResponse> AxlNetClient.AXLPort25.addGeoLocationAsync(AxlNetClient.addGeoLocationRequest request)
        {
            return base.Channel.addGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGeoLocationResponse> addGeoLocationAsync(AxlNetClient.AddGeoLocationReq addGeoLocation)
        {
            AxlNetClient.addGeoLocationRequest inValue = new AxlNetClient.addGeoLocationRequest();
            inValue.addGeoLocation = addGeoLocation;
            return ((AxlNetClient.AXLPort25)(this)).addGeoLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGeoLocationResponse AxlNetClient.AXLPort25.updateGeoLocation(AxlNetClient.updateGeoLocationRequest request)
        {
            return base.Channel.updateGeoLocation(request);
        }

        public AxlNetClient.StandardResponse updateGeoLocation(AxlNetClient.UpdateGeoLocationReq updateGeoLocation1)
        {
            AxlNetClient.updateGeoLocationRequest inValue = new AxlNetClient.updateGeoLocationRequest();
            inValue.updateGeoLocation = updateGeoLocation1;
            AxlNetClient.updateGeoLocationResponse retVal = ((AxlNetClient.AXLPort25)(this)).updateGeoLocation(inValue);
            return retVal.updateGeoLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationResponse> AxlNetClient.AXLPort25.updateGeoLocationAsync(AxlNetClient.updateGeoLocationRequest request)
        {
            return base.Channel.updateGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationResponse> updateGeoLocationAsync(AxlNetClient.UpdateGeoLocationReq updateGeoLocation)
        {
            AxlNetClient.updateGeoLocationRequest inValue = new AxlNetClient.updateGeoLocationRequest();
            inValue.updateGeoLocation = updateGeoLocation;
            return ((AxlNetClient.AXLPort25)(this)).updateGeoLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGeoLocationResponse AxlNetClient.AXLPort25.getGeoLocation(AxlNetClient.getGeoLocationRequest request)
        {
            return base.Channel.getGeoLocation(request);
        }

        public AxlNetClient.GetGeoLocationRes getGeoLocation(AxlNetClient.GetGeoLocationReq getGeoLocation1)
        {
            AxlNetClient.getGeoLocationRequest inValue = new AxlNetClient.getGeoLocationRequest();
            inValue.getGeoLocation = getGeoLocation1;
            AxlNetClient.getGeoLocationResponse retVal = ((AxlNetClient.AXLPort25)(this)).getGeoLocation(inValue);
            return retVal.getGeoLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationResponse> AxlNetClient.AXLPort25.getGeoLocationAsync(AxlNetClient.getGeoLocationRequest request)
        {
            return base.Channel.getGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationResponse> getGeoLocationAsync(AxlNetClient.GetGeoLocationReq getGeoLocation)
        {
            AxlNetClient.getGeoLocationRequest inValue = new AxlNetClient.getGeoLocationRequest();
            inValue.getGeoLocation = getGeoLocation;
            return ((AxlNetClient.AXLPort25)(this)).getGeoLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGeoLocationResponse AxlNetClient.AXLPort25.removeGeoLocation(AxlNetClient.removeGeoLocationRequest request)
        {
            return base.Channel.removeGeoLocation(request);
        }

        public AxlNetClient.StandardResponse removeGeoLocation(AxlNetClient.NameAndGUIDRequest removeGeoLocation1)
        {
            AxlNetClient.removeGeoLocationRequest inValue = new AxlNetClient.removeGeoLocationRequest();
            inValue.removeGeoLocation = removeGeoLocation1;
            AxlNetClient.removeGeoLocationResponse retVal = ((AxlNetClient.AXLPort25)(this)).removeGeoLocation(inValue);
            return retVal.removeGeoLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationResponse> AxlNetClient.AXLPort25.removeGeoLocationAsync(AxlNetClient.removeGeoLocationRequest request)
        {
            return base.Channel.removeGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationResponse> removeGeoLocationAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocation)
        {
            AxlNetClient.removeGeoLocationRequest inValue = new AxlNetClient.removeGeoLocationRequest();
            inValue.removeGeoLocation = removeGeoLocation;
            return ((AxlNetClient.AXLPort25)(this)).removeGeoLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listGeoLocationResponse AxlNetClient.AXLPort25.listGeoLocation(AxlNetClient.listGeoLocationRequest request)
        {
            return base.Channel.listGeoLocation(request);
        }

        public AxlNetClient.ListGeoLocationRes listGeoLocation(AxlNetClient.ListGeoLocationReq listGeoLocation1)
        {
            AxlNetClient.listGeoLocationRequest inValue = new AxlNetClient.listGeoLocationRequest();
            inValue.listGeoLocation = listGeoLocation1;
            AxlNetClient.listGeoLocationResponse retVal = ((AxlNetClient.AXLPort25)(this)).listGeoLocation(inValue);
            return retVal.listGeoLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationResponse> AxlNetClient.AXLPort25.listGeoLocationAsync(AxlNetClient.listGeoLocationRequest request)
        {
            return base.Channel.listGeoLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationResponse> listGeoLocationAsync(AxlNetClient.ListGeoLocationReq listGeoLocation)
        {
            AxlNetClient.listGeoLocationRequest inValue = new AxlNetClient.listGeoLocationRequest();
            inValue.listGeoLocation = listGeoLocation;
            return ((AxlNetClient.AXLPort25)(this)).listGeoLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSrstResponse AxlNetClient.AXLPort25.addSrst(AxlNetClient.addSrstRequest request)
        {
            return base.Channel.addSrst(request);
        }

        public AxlNetClient.StandardResponse addSrst(AxlNetClient.AddSrstReq addSrst1)
        {
            AxlNetClient.addSrstRequest inValue = new AxlNetClient.addSrstRequest();
            inValue.addSrst = addSrst1;
            AxlNetClient.addSrstResponse retVal = ((AxlNetClient.AXLPort25)(this)).addSrst(inValue);
            return retVal.addSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSrstResponse> AxlNetClient.AXLPort25.addSrstAsync(AxlNetClient.addSrstRequest request)
        {
            return base.Channel.addSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSrstResponse> addSrstAsync(AxlNetClient.AddSrstReq addSrst)
        {
            AxlNetClient.addSrstRequest inValue = new AxlNetClient.addSrstRequest();
            inValue.addSrst = addSrst;
            return ((AxlNetClient.AXLPort25)(this)).addSrstAsync(inValue);
        }
    }
}