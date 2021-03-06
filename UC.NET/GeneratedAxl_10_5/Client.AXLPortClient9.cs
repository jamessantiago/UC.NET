namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient9 _axlPortClient9;

        private static AXLPortClient9 axlPortClient9 => _axlPortClient9 == null ||
            _axlPortClient9.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient9 = LoadClient9()) : _axlPortClient9;

        private static AXLPortClient9 LoadClient9()
        {
            var client = new AXLPortClient9(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close9;
            OnAbort += Abort9;
            return client;
        }

        private static void Close9(object sender, System.EventArgs e)
        {
            _axlPortClient9.Close();
        }

        private static void Abort9(object sender, System.EventArgs e)
        {
            _axlPortClient9.Abort();
        }

        public AxlNetClient.StandardResponse updateDevicePool(AxlNetClient.UpdateDevicePoolReq updateDevicePool1)
        {
            return axlPortClient9.updateDevicePool(updateDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDevicePoolResponse> updateDevicePoolAsync(AxlNetClient.UpdateDevicePoolReq updateDevicePool)
        {
            return axlPortClient9.updateDevicePoolAsync(updateDevicePool);
        }

        public AxlNetClient.GetDevicePoolRes getDevicePool(AxlNetClient.GetDevicePoolReq getDevicePool1)
        {
            return axlPortClient9.getDevicePool(getDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDevicePoolResponse> getDevicePoolAsync(AxlNetClient.GetDevicePoolReq getDevicePool)
        {
            return axlPortClient9.getDevicePoolAsync(getDevicePool);
        }

        public AxlNetClient.StandardResponse removeDevicePool(AxlNetClient.NameAndGUIDRequest removeDevicePool1)
        {
            return axlPortClient9.removeDevicePool(removeDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDevicePoolResponse> removeDevicePoolAsync(AxlNetClient.NameAndGUIDRequest removeDevicePool)
        {
            return axlPortClient9.removeDevicePoolAsync(removeDevicePool);
        }

        public AxlNetClient.ListDevicePoolRes listDevicePool(AxlNetClient.ListDevicePoolReq listDevicePool1)
        {
            return axlPortClient9.listDevicePool(listDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDevicePoolResponse> listDevicePoolAsync(AxlNetClient.ListDevicePoolReq listDevicePool)
        {
            return axlPortClient9.listDevicePoolAsync(listDevicePool);
        }

        public AxlNetClient.StandardResponse resetDevicePool(AxlNetClient.NameAndGUIDRequest resetDevicePool1)
        {
            return axlPortClient9.resetDevicePool(resetDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDevicePoolResponse> resetDevicePoolAsync(AxlNetClient.NameAndGUIDRequest resetDevicePool)
        {
            return axlPortClient9.resetDevicePoolAsync(resetDevicePool);
        }

        public AxlNetClient.StandardResponse restartDevicePool(AxlNetClient.NameAndGUIDRequest restartDevicePool1)
        {
            return axlPortClient9.restartDevicePool(restartDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartDevicePoolResponse> restartDevicePoolAsync(AxlNetClient.NameAndGUIDRequest restartDevicePool)
        {
            return axlPortClient9.restartDevicePoolAsync(restartDevicePool);
        }

        public AxlNetClient.StandardResponse applyDevicePool(AxlNetClient.NameAndGUIDRequest applyDevicePool1)
        {
            return axlPortClient9.applyDevicePool(applyDevicePool1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDevicePoolResponse> applyDevicePoolAsync(AxlNetClient.NameAndGUIDRequest applyDevicePool)
        {
            return axlPortClient9.applyDevicePoolAsync(applyDevicePool);
        }

        public AxlNetClient.StandardResponse addDeviceMobilityGroup(AxlNetClient.AddDeviceMobilityGroupReq addDeviceMobilityGroup1)
        {
            return axlPortClient9.addDeviceMobilityGroup(addDeviceMobilityGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityGroupResponse> addDeviceMobilityGroupAsync(AxlNetClient.AddDeviceMobilityGroupReq addDeviceMobilityGroup)
        {
            return axlPortClient9.addDeviceMobilityGroupAsync(addDeviceMobilityGroup);
        }

        public AxlNetClient.StandardResponse updateDeviceMobilityGroup(AxlNetClient.UpdateDeviceMobilityGroupReq updateDeviceMobilityGroup1)
        {
            return axlPortClient9.updateDeviceMobilityGroup(updateDeviceMobilityGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityGroupResponse> updateDeviceMobilityGroupAsync(AxlNetClient.UpdateDeviceMobilityGroupReq updateDeviceMobilityGroup)
        {
            return axlPortClient9.updateDeviceMobilityGroupAsync(updateDeviceMobilityGroup);
        }

        public AxlNetClient.GetDeviceMobilityGroupRes getDeviceMobilityGroup(AxlNetClient.GetDeviceMobilityGroupReq getDeviceMobilityGroup1)
        {
            return axlPortClient9.getDeviceMobilityGroup(getDeviceMobilityGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityGroupResponse> getDeviceMobilityGroupAsync(AxlNetClient.GetDeviceMobilityGroupReq getDeviceMobilityGroup)
        {
            return axlPortClient9.getDeviceMobilityGroupAsync(getDeviceMobilityGroup);
        }

        public AxlNetClient.StandardResponse removeDeviceMobilityGroup(AxlNetClient.NameAndGUIDRequest removeDeviceMobilityGroup1)
        {
            return axlPortClient9.removeDeviceMobilityGroup(removeDeviceMobilityGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityGroupResponse> removeDeviceMobilityGroupAsync(AxlNetClient.NameAndGUIDRequest removeDeviceMobilityGroup)
        {
            return axlPortClient9.removeDeviceMobilityGroupAsync(removeDeviceMobilityGroup);
        }

        public AxlNetClient.ListDeviceMobilityGroupRes listDeviceMobilityGroup(AxlNetClient.ListDeviceMobilityGroupReq listDeviceMobilityGroup1)
        {
            return axlPortClient9.listDeviceMobilityGroup(listDeviceMobilityGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityGroupResponse> listDeviceMobilityGroupAsync(AxlNetClient.ListDeviceMobilityGroupReq listDeviceMobilityGroup)
        {
            return axlPortClient9.listDeviceMobilityGroupAsync(listDeviceMobilityGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort9
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDevicePoolResponse updateDevicePool(AxlNetClient.updateDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDevicePoolResponse> updateDevicePoolAsync(AxlNetClient.updateDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDevicePoolResponse getDevicePool(AxlNetClient.getDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDevicePoolResponse> getDevicePoolAsync(AxlNetClient.getDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDevicePoolResponse removeDevicePool(AxlNetClient.removeDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDevicePoolResponse> removeDevicePoolAsync(AxlNetClient.removeDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDevicePoolResponse listDevicePool(AxlNetClient.listDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDevicePoolResponse> listDevicePoolAsync(AxlNetClient.listDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetDevicePoolResponse resetDevicePool(AxlNetClient.resetDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetDevicePoolResponse> resetDevicePoolAsync(AxlNetClient.resetDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartDevicePoolResponse restartDevicePool(AxlNetClient.restartDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartDevicePoolResponse> restartDevicePoolAsync(AxlNetClient.restartDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDevicePool", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyDevicePoolResponse applyDevicePool(AxlNetClient.applyDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDevicePool", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyDevicePoolResponse> applyDevicePoolAsync(AxlNetClient.applyDevicePoolRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceMobilityGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDeviceMobilityGroupResponse addDeviceMobilityGroup(AxlNetClient.addDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDeviceMobilityGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityGroupResponse> addDeviceMobilityGroupAsync(AxlNetClient.addDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceMobilityGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDeviceMobilityGroupResponse updateDeviceMobilityGroup(AxlNetClient.updateDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDeviceMobilityGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityGroupResponse> updateDeviceMobilityGroupAsync(AxlNetClient.updateDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceMobilityGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDeviceMobilityGroupResponse getDeviceMobilityGroup(AxlNetClient.getDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDeviceMobilityGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityGroupResponse> getDeviceMobilityGroupAsync(AxlNetClient.getDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceMobilityGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDeviceMobilityGroupResponse removeDeviceMobilityGroup(AxlNetClient.removeDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDeviceMobilityGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityGroupResponse> removeDeviceMobilityGroupAsync(AxlNetClient.removeDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceMobilityGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDeviceMobilityGroupResponse listDeviceMobilityGroup(AxlNetClient.listDeviceMobilityGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDeviceMobilityGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityGroupResponse> listDeviceMobilityGroupAsync(AxlNetClient.listDeviceMobilityGroupRequest request);
    }

    public class AXLPortClient9 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort9>, AxlNetClient.AXLPort9
    {
        public AXLPortClient9(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDevicePoolResponse AxlNetClient.AXLPort9.updateDevicePool(AxlNetClient.updateDevicePoolRequest request)
        {
            return base.Channel.updateDevicePool(request);
        }

        public AxlNetClient.StandardResponse updateDevicePool(AxlNetClient.UpdateDevicePoolReq updateDevicePool1)
        {
            AxlNetClient.updateDevicePoolRequest inValue = new AxlNetClient.updateDevicePoolRequest();
            inValue.updateDevicePool = updateDevicePool1;
            AxlNetClient.updateDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).updateDevicePool(inValue);
            return retVal.updateDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDevicePoolResponse> AxlNetClient.AXLPort9.updateDevicePoolAsync(AxlNetClient.updateDevicePoolRequest request)
        {
            return base.Channel.updateDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDevicePoolResponse> updateDevicePoolAsync(AxlNetClient.UpdateDevicePoolReq updateDevicePool)
        {
            AxlNetClient.updateDevicePoolRequest inValue = new AxlNetClient.updateDevicePoolRequest();
            inValue.updateDevicePool = updateDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).updateDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDevicePoolResponse AxlNetClient.AXLPort9.getDevicePool(AxlNetClient.getDevicePoolRequest request)
        {
            return base.Channel.getDevicePool(request);
        }

        public AxlNetClient.GetDevicePoolRes getDevicePool(AxlNetClient.GetDevicePoolReq getDevicePool1)
        {
            AxlNetClient.getDevicePoolRequest inValue = new AxlNetClient.getDevicePoolRequest();
            inValue.getDevicePool = getDevicePool1;
            AxlNetClient.getDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).getDevicePool(inValue);
            return retVal.getDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDevicePoolResponse> AxlNetClient.AXLPort9.getDevicePoolAsync(AxlNetClient.getDevicePoolRequest request)
        {
            return base.Channel.getDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDevicePoolResponse> getDevicePoolAsync(AxlNetClient.GetDevicePoolReq getDevicePool)
        {
            AxlNetClient.getDevicePoolRequest inValue = new AxlNetClient.getDevicePoolRequest();
            inValue.getDevicePool = getDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).getDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDevicePoolResponse AxlNetClient.AXLPort9.removeDevicePool(AxlNetClient.removeDevicePoolRequest request)
        {
            return base.Channel.removeDevicePool(request);
        }

        public AxlNetClient.StandardResponse removeDevicePool(AxlNetClient.NameAndGUIDRequest removeDevicePool1)
        {
            AxlNetClient.removeDevicePoolRequest inValue = new AxlNetClient.removeDevicePoolRequest();
            inValue.removeDevicePool = removeDevicePool1;
            AxlNetClient.removeDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).removeDevicePool(inValue);
            return retVal.removeDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDevicePoolResponse> AxlNetClient.AXLPort9.removeDevicePoolAsync(AxlNetClient.removeDevicePoolRequest request)
        {
            return base.Channel.removeDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDevicePoolResponse> removeDevicePoolAsync(AxlNetClient.NameAndGUIDRequest removeDevicePool)
        {
            AxlNetClient.removeDevicePoolRequest inValue = new AxlNetClient.removeDevicePoolRequest();
            inValue.removeDevicePool = removeDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).removeDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDevicePoolResponse AxlNetClient.AXLPort9.listDevicePool(AxlNetClient.listDevicePoolRequest request)
        {
            return base.Channel.listDevicePool(request);
        }

        public AxlNetClient.ListDevicePoolRes listDevicePool(AxlNetClient.ListDevicePoolReq listDevicePool1)
        {
            AxlNetClient.listDevicePoolRequest inValue = new AxlNetClient.listDevicePoolRequest();
            inValue.listDevicePool = listDevicePool1;
            AxlNetClient.listDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).listDevicePool(inValue);
            return retVal.listDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDevicePoolResponse> AxlNetClient.AXLPort9.listDevicePoolAsync(AxlNetClient.listDevicePoolRequest request)
        {
            return base.Channel.listDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDevicePoolResponse> listDevicePoolAsync(AxlNetClient.ListDevicePoolReq listDevicePool)
        {
            AxlNetClient.listDevicePoolRequest inValue = new AxlNetClient.listDevicePoolRequest();
            inValue.listDevicePool = listDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).listDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetDevicePoolResponse AxlNetClient.AXLPort9.resetDevicePool(AxlNetClient.resetDevicePoolRequest request)
        {
            return base.Channel.resetDevicePool(request);
        }

        public AxlNetClient.StandardResponse resetDevicePool(AxlNetClient.NameAndGUIDRequest resetDevicePool1)
        {
            AxlNetClient.resetDevicePoolRequest inValue = new AxlNetClient.resetDevicePoolRequest();
            inValue.resetDevicePool = resetDevicePool1;
            AxlNetClient.resetDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).resetDevicePool(inValue);
            return retVal.resetDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetDevicePoolResponse> AxlNetClient.AXLPort9.resetDevicePoolAsync(AxlNetClient.resetDevicePoolRequest request)
        {
            return base.Channel.resetDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDevicePoolResponse> resetDevicePoolAsync(AxlNetClient.NameAndGUIDRequest resetDevicePool)
        {
            AxlNetClient.resetDevicePoolRequest inValue = new AxlNetClient.resetDevicePoolRequest();
            inValue.resetDevicePool = resetDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).resetDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartDevicePoolResponse AxlNetClient.AXLPort9.restartDevicePool(AxlNetClient.restartDevicePoolRequest request)
        {
            return base.Channel.restartDevicePool(request);
        }

        public AxlNetClient.StandardResponse restartDevicePool(AxlNetClient.NameAndGUIDRequest restartDevicePool1)
        {
            AxlNetClient.restartDevicePoolRequest inValue = new AxlNetClient.restartDevicePoolRequest();
            inValue.restartDevicePool = restartDevicePool1;
            AxlNetClient.restartDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).restartDevicePool(inValue);
            return retVal.restartDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartDevicePoolResponse> AxlNetClient.AXLPort9.restartDevicePoolAsync(AxlNetClient.restartDevicePoolRequest request)
        {
            return base.Channel.restartDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartDevicePoolResponse> restartDevicePoolAsync(AxlNetClient.NameAndGUIDRequest restartDevicePool)
        {
            AxlNetClient.restartDevicePoolRequest inValue = new AxlNetClient.restartDevicePoolRequest();
            inValue.restartDevicePool = restartDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).restartDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyDevicePoolResponse AxlNetClient.AXLPort9.applyDevicePool(AxlNetClient.applyDevicePoolRequest request)
        {
            return base.Channel.applyDevicePool(request);
        }

        public AxlNetClient.StandardResponse applyDevicePool(AxlNetClient.NameAndGUIDRequest applyDevicePool1)
        {
            AxlNetClient.applyDevicePoolRequest inValue = new AxlNetClient.applyDevicePoolRequest();
            inValue.applyDevicePool = applyDevicePool1;
            AxlNetClient.applyDevicePoolResponse retVal = ((AxlNetClient.AXLPort9)(this)).applyDevicePool(inValue);
            return retVal.applyDevicePoolResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyDevicePoolResponse> AxlNetClient.AXLPort9.applyDevicePoolAsync(AxlNetClient.applyDevicePoolRequest request)
        {
            return base.Channel.applyDevicePoolAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDevicePoolResponse> applyDevicePoolAsync(AxlNetClient.NameAndGUIDRequest applyDevicePool)
        {
            AxlNetClient.applyDevicePoolRequest inValue = new AxlNetClient.applyDevicePoolRequest();
            inValue.applyDevicePool = applyDevicePool;
            return ((AxlNetClient.AXLPort9)(this)).applyDevicePoolAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDeviceMobilityGroupResponse AxlNetClient.AXLPort9.addDeviceMobilityGroup(AxlNetClient.addDeviceMobilityGroupRequest request)
        {
            return base.Channel.addDeviceMobilityGroup(request);
        }

        public AxlNetClient.StandardResponse addDeviceMobilityGroup(AxlNetClient.AddDeviceMobilityGroupReq addDeviceMobilityGroup1)
        {
            AxlNetClient.addDeviceMobilityGroupRequest inValue = new AxlNetClient.addDeviceMobilityGroupRequest();
            inValue.addDeviceMobilityGroup = addDeviceMobilityGroup1;
            AxlNetClient.addDeviceMobilityGroupResponse retVal = ((AxlNetClient.AXLPort9)(this)).addDeviceMobilityGroup(inValue);
            return retVal.addDeviceMobilityGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityGroupResponse> AxlNetClient.AXLPort9.addDeviceMobilityGroupAsync(AxlNetClient.addDeviceMobilityGroupRequest request)
        {
            return base.Channel.addDeviceMobilityGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDeviceMobilityGroupResponse> addDeviceMobilityGroupAsync(AxlNetClient.AddDeviceMobilityGroupReq addDeviceMobilityGroup)
        {
            AxlNetClient.addDeviceMobilityGroupRequest inValue = new AxlNetClient.addDeviceMobilityGroupRequest();
            inValue.addDeviceMobilityGroup = addDeviceMobilityGroup;
            return ((AxlNetClient.AXLPort9)(this)).addDeviceMobilityGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDeviceMobilityGroupResponse AxlNetClient.AXLPort9.updateDeviceMobilityGroup(AxlNetClient.updateDeviceMobilityGroupRequest request)
        {
            return base.Channel.updateDeviceMobilityGroup(request);
        }

        public AxlNetClient.StandardResponse updateDeviceMobilityGroup(AxlNetClient.UpdateDeviceMobilityGroupReq updateDeviceMobilityGroup1)
        {
            AxlNetClient.updateDeviceMobilityGroupRequest inValue = new AxlNetClient.updateDeviceMobilityGroupRequest();
            inValue.updateDeviceMobilityGroup = updateDeviceMobilityGroup1;
            AxlNetClient.updateDeviceMobilityGroupResponse retVal = ((AxlNetClient.AXLPort9)(this)).updateDeviceMobilityGroup(inValue);
            return retVal.updateDeviceMobilityGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityGroupResponse> AxlNetClient.AXLPort9.updateDeviceMobilityGroupAsync(AxlNetClient.updateDeviceMobilityGroupRequest request)
        {
            return base.Channel.updateDeviceMobilityGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDeviceMobilityGroupResponse> updateDeviceMobilityGroupAsync(AxlNetClient.UpdateDeviceMobilityGroupReq updateDeviceMobilityGroup)
        {
            AxlNetClient.updateDeviceMobilityGroupRequest inValue = new AxlNetClient.updateDeviceMobilityGroupRequest();
            inValue.updateDeviceMobilityGroup = updateDeviceMobilityGroup;
            return ((AxlNetClient.AXLPort9)(this)).updateDeviceMobilityGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDeviceMobilityGroupResponse AxlNetClient.AXLPort9.getDeviceMobilityGroup(AxlNetClient.getDeviceMobilityGroupRequest request)
        {
            return base.Channel.getDeviceMobilityGroup(request);
        }

        public AxlNetClient.GetDeviceMobilityGroupRes getDeviceMobilityGroup(AxlNetClient.GetDeviceMobilityGroupReq getDeviceMobilityGroup1)
        {
            AxlNetClient.getDeviceMobilityGroupRequest inValue = new AxlNetClient.getDeviceMobilityGroupRequest();
            inValue.getDeviceMobilityGroup = getDeviceMobilityGroup1;
            AxlNetClient.getDeviceMobilityGroupResponse retVal = ((AxlNetClient.AXLPort9)(this)).getDeviceMobilityGroup(inValue);
            return retVal.getDeviceMobilityGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityGroupResponse> AxlNetClient.AXLPort9.getDeviceMobilityGroupAsync(AxlNetClient.getDeviceMobilityGroupRequest request)
        {
            return base.Channel.getDeviceMobilityGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDeviceMobilityGroupResponse> getDeviceMobilityGroupAsync(AxlNetClient.GetDeviceMobilityGroupReq getDeviceMobilityGroup)
        {
            AxlNetClient.getDeviceMobilityGroupRequest inValue = new AxlNetClient.getDeviceMobilityGroupRequest();
            inValue.getDeviceMobilityGroup = getDeviceMobilityGroup;
            return ((AxlNetClient.AXLPort9)(this)).getDeviceMobilityGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDeviceMobilityGroupResponse AxlNetClient.AXLPort9.removeDeviceMobilityGroup(AxlNetClient.removeDeviceMobilityGroupRequest request)
        {
            return base.Channel.removeDeviceMobilityGroup(request);
        }

        public AxlNetClient.StandardResponse removeDeviceMobilityGroup(AxlNetClient.NameAndGUIDRequest removeDeviceMobilityGroup1)
        {
            AxlNetClient.removeDeviceMobilityGroupRequest inValue = new AxlNetClient.removeDeviceMobilityGroupRequest();
            inValue.removeDeviceMobilityGroup = removeDeviceMobilityGroup1;
            AxlNetClient.removeDeviceMobilityGroupResponse retVal = ((AxlNetClient.AXLPort9)(this)).removeDeviceMobilityGroup(inValue);
            return retVal.removeDeviceMobilityGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityGroupResponse> AxlNetClient.AXLPort9.removeDeviceMobilityGroupAsync(AxlNetClient.removeDeviceMobilityGroupRequest request)
        {
            return base.Channel.removeDeviceMobilityGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDeviceMobilityGroupResponse> removeDeviceMobilityGroupAsync(AxlNetClient.NameAndGUIDRequest removeDeviceMobilityGroup)
        {
            AxlNetClient.removeDeviceMobilityGroupRequest inValue = new AxlNetClient.removeDeviceMobilityGroupRequest();
            inValue.removeDeviceMobilityGroup = removeDeviceMobilityGroup;
            return ((AxlNetClient.AXLPort9)(this)).removeDeviceMobilityGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDeviceMobilityGroupResponse AxlNetClient.AXLPort9.listDeviceMobilityGroup(AxlNetClient.listDeviceMobilityGroupRequest request)
        {
            return base.Channel.listDeviceMobilityGroup(request);
        }

        public AxlNetClient.ListDeviceMobilityGroupRes listDeviceMobilityGroup(AxlNetClient.ListDeviceMobilityGroupReq listDeviceMobilityGroup1)
        {
            AxlNetClient.listDeviceMobilityGroupRequest inValue = new AxlNetClient.listDeviceMobilityGroupRequest();
            inValue.listDeviceMobilityGroup = listDeviceMobilityGroup1;
            AxlNetClient.listDeviceMobilityGroupResponse retVal = ((AxlNetClient.AXLPort9)(this)).listDeviceMobilityGroup(inValue);
            return retVal.listDeviceMobilityGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityGroupResponse> AxlNetClient.AXLPort9.listDeviceMobilityGroupAsync(AxlNetClient.listDeviceMobilityGroupRequest request)
        {
            return base.Channel.listDeviceMobilityGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDeviceMobilityGroupResponse> listDeviceMobilityGroupAsync(AxlNetClient.ListDeviceMobilityGroupReq listDeviceMobilityGroup)
        {
            AxlNetClient.listDeviceMobilityGroupRequest inValue = new AxlNetClient.listDeviceMobilityGroupRequest();
            inValue.listDeviceMobilityGroup = listDeviceMobilityGroup;
            return ((AxlNetClient.AXLPort9)(this)).listDeviceMobilityGroupAsync(inValue);
        }
    }
}