namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient8 _axlPortClient8;

        private static AXLPortClient8 axlPortClient8 => _axlPortClient8 == null ||
            _axlPortClient8.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient8 = LoadClient8()) : _axlPortClient8;

        private static AXLPortClient8 LoadClient8()
        {
            var client = new AXLPortClient8(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close8;
            OnAbort += Abort8;
            return client;
        }

        private static void Close8(object sender, System.EventArgs e)
        {
            _axlPortClient8.Close();
        }

        private static void Abort8(object sender, System.EventArgs e)
        {
            _axlPortClient8.Abort();
        }

        public AxlNetClient.ListAarGroupRes listAarGroup(AxlNetClient.ListAarGroupReq listAarGroup1)
        {
            return axlPortClient8.listAarGroup(listAarGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAarGroupResponse> listAarGroupAsync(AxlNetClient.ListAarGroupReq listAarGroup)
        {
            return axlPortClient8.listAarGroupAsync(listAarGroup);
        }

        public AxlNetClient.StandardResponse addPhysicalLocation(AxlNetClient.AddPhysicalLocationReq addPhysicalLocation1)
        {
            return axlPortClient8.addPhysicalLocation(addPhysicalLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhysicalLocationResponse> addPhysicalLocationAsync(AxlNetClient.AddPhysicalLocationReq addPhysicalLocation)
        {
            return axlPortClient8.addPhysicalLocationAsync(addPhysicalLocation);
        }

        public AxlNetClient.StandardResponse updatePhysicalLocation(AxlNetClient.UpdatePhysicalLocationReq updatePhysicalLocation1)
        {
            return axlPortClient8.updatePhysicalLocation(updatePhysicalLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhysicalLocationResponse> updatePhysicalLocationAsync(AxlNetClient.UpdatePhysicalLocationReq updatePhysicalLocation)
        {
            return axlPortClient8.updatePhysicalLocationAsync(updatePhysicalLocation);
        }

        public AxlNetClient.GetPhysicalLocationRes getPhysicalLocation(AxlNetClient.GetPhysicalLocationReq getPhysicalLocation1)
        {
            return axlPortClient8.getPhysicalLocation(getPhysicalLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhysicalLocationResponse> getPhysicalLocationAsync(AxlNetClient.GetPhysicalLocationReq getPhysicalLocation)
        {
            return axlPortClient8.getPhysicalLocationAsync(getPhysicalLocation);
        }

        public AxlNetClient.StandardResponse removePhysicalLocation(AxlNetClient.NameAndGUIDRequest removePhysicalLocation1)
        {
            return axlPortClient8.removePhysicalLocation(removePhysicalLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhysicalLocationResponse> removePhysicalLocationAsync(AxlNetClient.NameAndGUIDRequest removePhysicalLocation)
        {
            return axlPortClient8.removePhysicalLocationAsync(removePhysicalLocation);
        }

        public AxlNetClient.ListPhysicalLocationRes listPhysicalLocation(AxlNetClient.ListPhysicalLocationReq listPhysicalLocation1)
        {
            return axlPortClient8.listPhysicalLocation(listPhysicalLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhysicalLocationResponse> listPhysicalLocationAsync(AxlNetClient.ListPhysicalLocationReq listPhysicalLocation)
        {
            return axlPortClient8.listPhysicalLocationAsync(listPhysicalLocation);
        }

        public AxlNetClient.StandardResponse addRouteGroup(AxlNetClient.AddRouteGroupReq addRouteGroup1)
        {
            return axlPortClient8.addRouteGroup(addRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteGroupResponse> addRouteGroupAsync(AxlNetClient.AddRouteGroupReq addRouteGroup)
        {
            return axlPortClient8.addRouteGroupAsync(addRouteGroup);
        }

        public AxlNetClient.StandardResponse updateRouteGroup(AxlNetClient.UpdateRouteGroupReq updateRouteGroup1)
        {
            return axlPortClient8.updateRouteGroup(updateRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteGroupResponse> updateRouteGroupAsync(AxlNetClient.UpdateRouteGroupReq updateRouteGroup)
        {
            return axlPortClient8.updateRouteGroupAsync(updateRouteGroup);
        }

        public AxlNetClient.GetRouteGroupRes getRouteGroup(AxlNetClient.GetRouteGroupReq getRouteGroup1)
        {
            return axlPortClient8.getRouteGroup(getRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteGroupResponse> getRouteGroupAsync(AxlNetClient.GetRouteGroupReq getRouteGroup)
        {
            return axlPortClient8.getRouteGroupAsync(getRouteGroup);
        }

        public AxlNetClient.StandardResponse removeRouteGroup(AxlNetClient.NameAndGUIDRequest removeRouteGroup1)
        {
            return axlPortClient8.removeRouteGroup(removeRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteGroupResponse> removeRouteGroupAsync(AxlNetClient.NameAndGUIDRequest removeRouteGroup)
        {
            return axlPortClient8.removeRouteGroupAsync(removeRouteGroup);
        }

        public AxlNetClient.ListRouteGroupRes listRouteGroup(AxlNetClient.ListRouteGroupReq listRouteGroup1)
        {
            return axlPortClient8.listRouteGroup(listRouteGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteGroupResponse> listRouteGroupAsync(AxlNetClient.ListRouteGroupReq listRouteGroup)
        {
            return axlPortClient8.listRouteGroupAsync(listRouteGroup);
        }

        public AxlNetClient.StandardResponse addDevicePool(AxlNetClient.AddDevicePoolReq addDevicePool1)
        {
            return axlPortClient8.addDevicePool(addDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDevicePoolResponse> addDevicePoolAsync(AxlNetClient.AddDevicePoolReq addDevicePool)
        {
            return axlPortClient8.addDevicePoolAsync(addDevicePool);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort8
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAarGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listAarGroupResponse listAarGroup(AxlNetClient.listAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listAarGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listAarGroupResponse> listAarGroupAsync(AxlNetClient.listAarGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhysicalLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPhysicalLocationResponse addPhysicalLocation(AxlNetClient.addPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhysicalLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPhysicalLocationResponse> addPhysicalLocationAsync(AxlNetClient.addPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhysicalLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePhysicalLocationResponse updatePhysicalLocation(AxlNetClient.updatePhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhysicalLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePhysicalLocationResponse> updatePhysicalLocationAsync(AxlNetClient.updatePhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhysicalLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhysicalLocationResponse getPhysicalLocation(AxlNetClient.getPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhysicalLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhysicalLocationResponse> getPhysicalLocationAsync(AxlNetClient.getPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhysicalLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePhysicalLocationResponse removePhysicalLocation(AxlNetClient.removePhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhysicalLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePhysicalLocationResponse> removePhysicalLocationAsync(AxlNetClient.removePhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhysicalLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPhysicalLocationResponse listPhysicalLocation(AxlNetClient.listPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhysicalLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPhysicalLocationResponse> listPhysicalLocationAsync(AxlNetClient.listPhysicalLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addRouteGroupResponse addRouteGroup(AxlNetClient.addRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addRouteGroupResponse> addRouteGroupAsync(AxlNetClient.addRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRouteGroupResponse updateRouteGroup(AxlNetClient.updateRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteGroupResponse> updateRouteGroupAsync(AxlNetClient.updateRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRouteGroupResponse getRouteGroup(AxlNetClient.getRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRouteGroupResponse> getRouteGroupAsync(AxlNetClient.getRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRouteGroupResponse removeRouteGroup(AxlNetClient.removeRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteGroupResponse> removeRouteGroupAsync(AxlNetClient.removeRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRouteGroupResponse listRouteGroup(AxlNetClient.listRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRouteGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRouteGroupResponse> listRouteGroupAsync(AxlNetClient.listRouteGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDevicePoolResponse addDevicePool(AxlNetClient.addDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDevicePoolResponse> addDevicePoolAsync(AxlNetClient.addDevicePoolRequest request);
    }

    public class AXLPortClient8 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort8>, AxlNetClient.AXLPort8
    {
        public AXLPortClient8(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listAarGroupResponse AxlNetClient.AXLPort8.listAarGroup(AxlNetClient.listAarGroupRequest request)
        {
            return base.Channel.listAarGroup(request);
        }

        public AxlNetClient.ListAarGroupRes listAarGroup(AxlNetClient.ListAarGroupReq listAarGroup1)
        {
            AxlNetClient.listAarGroupRequest inValue = new AxlNetClient.listAarGroupRequest();
            inValue.listAarGroup = listAarGroup1;
            AxlNetClient.listAarGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).listAarGroup(inValue);
            return retVal.listAarGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listAarGroupResponse> AxlNetClient.AXLPort8.listAarGroupAsync(AxlNetClient.listAarGroupRequest request)
        {
            return base.Channel.listAarGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listAarGroupResponse> listAarGroupAsync(AxlNetClient.ListAarGroupReq listAarGroup)
        {
            AxlNetClient.listAarGroupRequest inValue = new AxlNetClient.listAarGroupRequest();
            inValue.listAarGroup = listAarGroup;
            return ((AxlNetClient.AXLPort8)(this)).listAarGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPhysicalLocationResponse AxlNetClient.AXLPort8.addPhysicalLocation(AxlNetClient.addPhysicalLocationRequest request)
        {
            return base.Channel.addPhysicalLocation(request);
        }

        public AxlNetClient.StandardResponse addPhysicalLocation(AxlNetClient.AddPhysicalLocationReq addPhysicalLocation1)
        {
            AxlNetClient.addPhysicalLocationRequest inValue = new AxlNetClient.addPhysicalLocationRequest();
            inValue.addPhysicalLocation = addPhysicalLocation1;
            AxlNetClient.addPhysicalLocationResponse retVal = ((AxlNetClient.AXLPort8)(this)).addPhysicalLocation(inValue);
            return retVal.addPhysicalLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPhysicalLocationResponse> AxlNetClient.AXLPort8.addPhysicalLocationAsync(AxlNetClient.addPhysicalLocationRequest request)
        {
            return base.Channel.addPhysicalLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhysicalLocationResponse> addPhysicalLocationAsync(AxlNetClient.AddPhysicalLocationReq addPhysicalLocation)
        {
            AxlNetClient.addPhysicalLocationRequest inValue = new AxlNetClient.addPhysicalLocationRequest();
            inValue.addPhysicalLocation = addPhysicalLocation;
            return ((AxlNetClient.AXLPort8)(this)).addPhysicalLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePhysicalLocationResponse AxlNetClient.AXLPort8.updatePhysicalLocation(AxlNetClient.updatePhysicalLocationRequest request)
        {
            return base.Channel.updatePhysicalLocation(request);
        }

        public AxlNetClient.StandardResponse updatePhysicalLocation(AxlNetClient.UpdatePhysicalLocationReq updatePhysicalLocation1)
        {
            AxlNetClient.updatePhysicalLocationRequest inValue = new AxlNetClient.updatePhysicalLocationRequest();
            inValue.updatePhysicalLocation = updatePhysicalLocation1;
            AxlNetClient.updatePhysicalLocationResponse retVal = ((AxlNetClient.AXLPort8)(this)).updatePhysicalLocation(inValue);
            return retVal.updatePhysicalLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePhysicalLocationResponse> AxlNetClient.AXLPort8.updatePhysicalLocationAsync(AxlNetClient.updatePhysicalLocationRequest request)
        {
            return base.Channel.updatePhysicalLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhysicalLocationResponse> updatePhysicalLocationAsync(AxlNetClient.UpdatePhysicalLocationReq updatePhysicalLocation)
        {
            AxlNetClient.updatePhysicalLocationRequest inValue = new AxlNetClient.updatePhysicalLocationRequest();
            inValue.updatePhysicalLocation = updatePhysicalLocation;
            return ((AxlNetClient.AXLPort8)(this)).updatePhysicalLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhysicalLocationResponse AxlNetClient.AXLPort8.getPhysicalLocation(AxlNetClient.getPhysicalLocationRequest request)
        {
            return base.Channel.getPhysicalLocation(request);
        }

        public AxlNetClient.GetPhysicalLocationRes getPhysicalLocation(AxlNetClient.GetPhysicalLocationReq getPhysicalLocation1)
        {
            AxlNetClient.getPhysicalLocationRequest inValue = new AxlNetClient.getPhysicalLocationRequest();
            inValue.getPhysicalLocation = getPhysicalLocation1;
            AxlNetClient.getPhysicalLocationResponse retVal = ((AxlNetClient.AXLPort8)(this)).getPhysicalLocation(inValue);
            return retVal.getPhysicalLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhysicalLocationResponse> AxlNetClient.AXLPort8.getPhysicalLocationAsync(AxlNetClient.getPhysicalLocationRequest request)
        {
            return base.Channel.getPhysicalLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhysicalLocationResponse> getPhysicalLocationAsync(AxlNetClient.GetPhysicalLocationReq getPhysicalLocation)
        {
            AxlNetClient.getPhysicalLocationRequest inValue = new AxlNetClient.getPhysicalLocationRequest();
            inValue.getPhysicalLocation = getPhysicalLocation;
            return ((AxlNetClient.AXLPort8)(this)).getPhysicalLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePhysicalLocationResponse AxlNetClient.AXLPort8.removePhysicalLocation(AxlNetClient.removePhysicalLocationRequest request)
        {
            return base.Channel.removePhysicalLocation(request);
        }

        public AxlNetClient.StandardResponse removePhysicalLocation(AxlNetClient.NameAndGUIDRequest removePhysicalLocation1)
        {
            AxlNetClient.removePhysicalLocationRequest inValue = new AxlNetClient.removePhysicalLocationRequest();
            inValue.removePhysicalLocation = removePhysicalLocation1;
            AxlNetClient.removePhysicalLocationResponse retVal = ((AxlNetClient.AXLPort8)(this)).removePhysicalLocation(inValue);
            return retVal.removePhysicalLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePhysicalLocationResponse> AxlNetClient.AXLPort8.removePhysicalLocationAsync(AxlNetClient.removePhysicalLocationRequest request)
        {
            return base.Channel.removePhysicalLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhysicalLocationResponse> removePhysicalLocationAsync(AxlNetClient.NameAndGUIDRequest removePhysicalLocation)
        {
            AxlNetClient.removePhysicalLocationRequest inValue = new AxlNetClient.removePhysicalLocationRequest();
            inValue.removePhysicalLocation = removePhysicalLocation;
            return ((AxlNetClient.AXLPort8)(this)).removePhysicalLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPhysicalLocationResponse AxlNetClient.AXLPort8.listPhysicalLocation(AxlNetClient.listPhysicalLocationRequest request)
        {
            return base.Channel.listPhysicalLocation(request);
        }

        public AxlNetClient.ListPhysicalLocationRes listPhysicalLocation(AxlNetClient.ListPhysicalLocationReq listPhysicalLocation1)
        {
            AxlNetClient.listPhysicalLocationRequest inValue = new AxlNetClient.listPhysicalLocationRequest();
            inValue.listPhysicalLocation = listPhysicalLocation1;
            AxlNetClient.listPhysicalLocationResponse retVal = ((AxlNetClient.AXLPort8)(this)).listPhysicalLocation(inValue);
            return retVal.listPhysicalLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPhysicalLocationResponse> AxlNetClient.AXLPort8.listPhysicalLocationAsync(AxlNetClient.listPhysicalLocationRequest request)
        {
            return base.Channel.listPhysicalLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhysicalLocationResponse> listPhysicalLocationAsync(AxlNetClient.ListPhysicalLocationReq listPhysicalLocation)
        {
            AxlNetClient.listPhysicalLocationRequest inValue = new AxlNetClient.listPhysicalLocationRequest();
            inValue.listPhysicalLocation = listPhysicalLocation;
            return ((AxlNetClient.AXLPort8)(this)).listPhysicalLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addRouteGroupResponse AxlNetClient.AXLPort8.addRouteGroup(AxlNetClient.addRouteGroupRequest request)
        {
            return base.Channel.addRouteGroup(request);
        }

        public AxlNetClient.StandardResponse addRouteGroup(AxlNetClient.AddRouteGroupReq addRouteGroup1)
        {
            AxlNetClient.addRouteGroupRequest inValue = new AxlNetClient.addRouteGroupRequest();
            inValue.addRouteGroup = addRouteGroup1;
            AxlNetClient.addRouteGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).addRouteGroup(inValue);
            return retVal.addRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addRouteGroupResponse> AxlNetClient.AXLPort8.addRouteGroupAsync(AxlNetClient.addRouteGroupRequest request)
        {
            return base.Channel.addRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addRouteGroupResponse> addRouteGroupAsync(AxlNetClient.AddRouteGroupReq addRouteGroup)
        {
            AxlNetClient.addRouteGroupRequest inValue = new AxlNetClient.addRouteGroupRequest();
            inValue.addRouteGroup = addRouteGroup;
            return ((AxlNetClient.AXLPort8)(this)).addRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRouteGroupResponse AxlNetClient.AXLPort8.updateRouteGroup(AxlNetClient.updateRouteGroupRequest request)
        {
            return base.Channel.updateRouteGroup(request);
        }

        public AxlNetClient.StandardResponse updateRouteGroup(AxlNetClient.UpdateRouteGroupReq updateRouteGroup1)
        {
            AxlNetClient.updateRouteGroupRequest inValue = new AxlNetClient.updateRouteGroupRequest();
            inValue.updateRouteGroup = updateRouteGroup1;
            AxlNetClient.updateRouteGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).updateRouteGroup(inValue);
            return retVal.updateRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRouteGroupResponse> AxlNetClient.AXLPort8.updateRouteGroupAsync(AxlNetClient.updateRouteGroupRequest request)
        {
            return base.Channel.updateRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRouteGroupResponse> updateRouteGroupAsync(AxlNetClient.UpdateRouteGroupReq updateRouteGroup)
        {
            AxlNetClient.updateRouteGroupRequest inValue = new AxlNetClient.updateRouteGroupRequest();
            inValue.updateRouteGroup = updateRouteGroup;
            return ((AxlNetClient.AXLPort8)(this)).updateRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRouteGroupResponse AxlNetClient.AXLPort8.getRouteGroup(AxlNetClient.getRouteGroupRequest request)
        {
            return base.Channel.getRouteGroup(request);
        }

        public AxlNetClient.GetRouteGroupRes getRouteGroup(AxlNetClient.GetRouteGroupReq getRouteGroup1)
        {
            AxlNetClient.getRouteGroupRequest inValue = new AxlNetClient.getRouteGroupRequest();
            inValue.getRouteGroup = getRouteGroup1;
            AxlNetClient.getRouteGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).getRouteGroup(inValue);
            return retVal.getRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRouteGroupResponse> AxlNetClient.AXLPort8.getRouteGroupAsync(AxlNetClient.getRouteGroupRequest request)
        {
            return base.Channel.getRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRouteGroupResponse> getRouteGroupAsync(AxlNetClient.GetRouteGroupReq getRouteGroup)
        {
            AxlNetClient.getRouteGroupRequest inValue = new AxlNetClient.getRouteGroupRequest();
            inValue.getRouteGroup = getRouteGroup;
            return ((AxlNetClient.AXLPort8)(this)).getRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRouteGroupResponse AxlNetClient.AXLPort8.removeRouteGroup(AxlNetClient.removeRouteGroupRequest request)
        {
            return base.Channel.removeRouteGroup(request);
        }

        public AxlNetClient.StandardResponse removeRouteGroup(AxlNetClient.NameAndGUIDRequest removeRouteGroup1)
        {
            AxlNetClient.removeRouteGroupRequest inValue = new AxlNetClient.removeRouteGroupRequest();
            inValue.removeRouteGroup = removeRouteGroup1;
            AxlNetClient.removeRouteGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).removeRouteGroup(inValue);
            return retVal.removeRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRouteGroupResponse> AxlNetClient.AXLPort8.removeRouteGroupAsync(AxlNetClient.removeRouteGroupRequest request)
        {
            return base.Channel.removeRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRouteGroupResponse> removeRouteGroupAsync(AxlNetClient.NameAndGUIDRequest removeRouteGroup)
        {
            AxlNetClient.removeRouteGroupRequest inValue = new AxlNetClient.removeRouteGroupRequest();
            inValue.removeRouteGroup = removeRouteGroup;
            return ((AxlNetClient.AXLPort8)(this)).removeRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRouteGroupResponse AxlNetClient.AXLPort8.listRouteGroup(AxlNetClient.listRouteGroupRequest request)
        {
            return base.Channel.listRouteGroup(request);
        }

        public AxlNetClient.ListRouteGroupRes listRouteGroup(AxlNetClient.ListRouteGroupReq listRouteGroup1)
        {
            AxlNetClient.listRouteGroupRequest inValue = new AxlNetClient.listRouteGroupRequest();
            inValue.listRouteGroup = listRouteGroup1;
            AxlNetClient.listRouteGroupResponse retVal = ((AxlNetClient.AXLPort8)(this)).listRouteGroup(inValue);
            return retVal.listRouteGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRouteGroupResponse> AxlNetClient.AXLPort8.listRouteGroupAsync(AxlNetClient.listRouteGroupRequest request)
        {
            return base.Channel.listRouteGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRouteGroupResponse> listRouteGroupAsync(AxlNetClient.ListRouteGroupReq listRouteGroup)
        {
            AxlNetClient.listRouteGroupRequest inValue = new AxlNetClient.listRouteGroupRequest();
            inValue.listRouteGroup = listRouteGroup;
            return ((AxlNetClient.AXLPort8)(this)).listRouteGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDevicePoolResponse AxlNetClient.AXLPort8.addDevicePool(AxlNetClient.addDevicePoolRequest request)
        {
            return base.Channel.addDevicePool(request);
        }

        public AxlNetClient.StandardResponse addDevicePool(AxlNetClient.AddDevicePoolReq addDevicePool1)
        {
            AxlNetClient.addDevicePoolRequest inValue = new AxlNetClient.addDevicePoolRequest();
            inValue.addDevicePool = addDevicePool1;
            AxlNetClient.addDevicePoolResponse retVal = ((AxlNetClient.AXLPort8)(this)).addDevicePool(inValue);
            return retVal.addDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDevicePoolResponse> AxlNetClient.AXLPort8.addDevicePoolAsync(AxlNetClient.addDevicePoolRequest request)
        {
            return base.Channel.addDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDevicePoolResponse> addDevicePoolAsync(AxlNetClient.AddDevicePoolReq addDevicePool)
        {
            AxlNetClient.addDevicePoolRequest inValue = new AxlNetClient.addDevicePoolRequest();
            inValue.addDevicePool = addDevicePool;
            return ((AxlNetClient.AXLPort8)(this)).addDevicePoolAsync(inValue);
        }
    }
}