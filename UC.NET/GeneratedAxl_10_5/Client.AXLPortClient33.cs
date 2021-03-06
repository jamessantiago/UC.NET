namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient33 _axlPortClient33;

        private static AXLPortClient33 axlPortClient33 => _axlPortClient33 == null ||
            _axlPortClient33.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient33 = LoadClient33()) : _axlPortClient33;

        private static AXLPortClient33 LoadClient33()
        {
            var client = new AXLPortClient33(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close33;
            OnAbort += Abort33;
            return client;
        }

        private static void Close33(object sender, System.EventArgs e)
        {
            _axlPortClient33.Close();
        }

        private static void Abort33(object sender, System.EventArgs e)
        {
            _axlPortClient33.Abort();
        }

        public AxlNetClient.StandardResponse addIpPhoneServices(AxlNetClient.AddIpPhoneServicesReq addIpPhoneServices1)
        {
            return axlPortClient33.addIpPhoneServices(addIpPhoneServices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addIpPhoneServicesResponse> addIpPhoneServicesAsync(AxlNetClient.AddIpPhoneServicesReq addIpPhoneServices)
        {
            return axlPortClient33.addIpPhoneServicesAsync(addIpPhoneServices);
        }

        public AxlNetClient.StandardResponse updateIpPhoneServices(AxlNetClient.UpdateIpPhoneServicesReq updateIpPhoneServices1)
        {
            return axlPortClient33.updateIpPhoneServices(updateIpPhoneServices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIpPhoneServicesResponse> updateIpPhoneServicesAsync(AxlNetClient.UpdateIpPhoneServicesReq updateIpPhoneServices)
        {
            return axlPortClient33.updateIpPhoneServicesAsync(updateIpPhoneServices);
        }

        public AxlNetClient.GetIpPhoneServicesRes getIpPhoneServices(AxlNetClient.GetIpPhoneServicesReq getIpPhoneServices1)
        {
            return axlPortClient33.getIpPhoneServices(getIpPhoneServices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIpPhoneServicesResponse> getIpPhoneServicesAsync(AxlNetClient.GetIpPhoneServicesReq getIpPhoneServices)
        {
            return axlPortClient33.getIpPhoneServicesAsync(getIpPhoneServices);
        }

        public AxlNetClient.StandardResponse removeIpPhoneServices(AxlNetClient.RemoveIpPhoneServicesReq removeIpPhoneServices1)
        {
            return axlPortClient33.removeIpPhoneServices(removeIpPhoneServices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeIpPhoneServicesResponse> removeIpPhoneServicesAsync(AxlNetClient.RemoveIpPhoneServicesReq removeIpPhoneServices)
        {
            return axlPortClient33.removeIpPhoneServicesAsync(removeIpPhoneServices);
        }

        public AxlNetClient.ListIpPhoneServicesRes listIpPhoneServices(AxlNetClient.ListIpPhoneServicesReq listIpPhoneServices1)
        {
            return axlPortClient33.listIpPhoneServices(listIpPhoneServices1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listIpPhoneServicesResponse> listIpPhoneServicesAsync(AxlNetClient.ListIpPhoneServicesReq listIpPhoneServices)
        {
            return axlPortClient33.listIpPhoneServicesAsync(listIpPhoneServices);
        }

        public AxlNetClient.StandardResponse addCtiRoutePoint(AxlNetClient.AddCtiRoutePointReq addCtiRoutePoint1)
        {
            return axlPortClient33.addCtiRoutePoint(addCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCtiRoutePointResponse> addCtiRoutePointAsync(AxlNetClient.AddCtiRoutePointReq addCtiRoutePoint)
        {
            return axlPortClient33.addCtiRoutePointAsync(addCtiRoutePoint);
        }

        public AxlNetClient.StandardResponse updateCtiRoutePoint(AxlNetClient.UpdateCtiRoutePointReq updateCtiRoutePoint1)
        {
            return axlPortClient33.updateCtiRoutePoint(updateCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCtiRoutePointResponse> updateCtiRoutePointAsync(AxlNetClient.UpdateCtiRoutePointReq updateCtiRoutePoint)
        {
            return axlPortClient33.updateCtiRoutePointAsync(updateCtiRoutePoint);
        }

        public AxlNetClient.GetCtiRoutePointRes getCtiRoutePoint(AxlNetClient.GetCtiRoutePointReq getCtiRoutePoint1)
        {
            return axlPortClient33.getCtiRoutePoint(getCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCtiRoutePointResponse> getCtiRoutePointAsync(AxlNetClient.GetCtiRoutePointReq getCtiRoutePoint)
        {
            return axlPortClient33.getCtiRoutePointAsync(getCtiRoutePoint);
        }

        public AxlNetClient.StandardResponse removeCtiRoutePoint(AxlNetClient.NameAndGUIDRequest removeCtiRoutePoint1)
        {
            return axlPortClient33.removeCtiRoutePoint(removeCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCtiRoutePointResponse> removeCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest removeCtiRoutePoint)
        {
            return axlPortClient33.removeCtiRoutePointAsync(removeCtiRoutePoint);
        }

        public AxlNetClient.ListCtiRoutePointRes listCtiRoutePoint(AxlNetClient.ListCtiRoutePointReq listCtiRoutePoint1)
        {
            return axlPortClient33.listCtiRoutePoint(listCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCtiRoutePointResponse> listCtiRoutePointAsync(AxlNetClient.ListCtiRoutePointReq listCtiRoutePoint)
        {
            return axlPortClient33.listCtiRoutePointAsync(listCtiRoutePoint);
        }

        public AxlNetClient.StandardResponse resetCtiRoutePoint(AxlNetClient.NameAndGUIDRequest resetCtiRoutePoint1)
        {
            return axlPortClient33.resetCtiRoutePoint(resetCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCtiRoutePointResponse> resetCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest resetCtiRoutePoint)
        {
            return axlPortClient33.resetCtiRoutePointAsync(resetCtiRoutePoint);
        }

        public AxlNetClient.StandardResponse restartCtiRoutePoint(AxlNetClient.NameAndGUIDRequest restartCtiRoutePoint1)
        {
            return axlPortClient33.restartCtiRoutePoint(restartCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCtiRoutePointResponse> restartCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest restartCtiRoutePoint)
        {
            return axlPortClient33.restartCtiRoutePointAsync(restartCtiRoutePoint);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort33
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addIpPhoneServices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addIpPhoneServicesResponse addIpPhoneServices(AxlNetClient.addIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addIpPhoneServices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addIpPhoneServicesResponse> addIpPhoneServicesAsync(AxlNetClient.addIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIpPhoneServices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateIpPhoneServicesResponse updateIpPhoneServices(AxlNetClient.updateIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateIpPhoneServices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateIpPhoneServicesResponse> updateIpPhoneServicesAsync(AxlNetClient.updateIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIpPhoneServices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getIpPhoneServicesResponse getIpPhoneServices(AxlNetClient.getIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getIpPhoneServices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getIpPhoneServicesResponse> getIpPhoneServicesAsync(AxlNetClient.getIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeIpPhoneServices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeIpPhoneServicesResponse removeIpPhoneServices(AxlNetClient.removeIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeIpPhoneServices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeIpPhoneServicesResponse> removeIpPhoneServicesAsync(AxlNetClient.removeIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listIpPhoneServices", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listIpPhoneServicesResponse listIpPhoneServices(AxlNetClient.listIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listIpPhoneServices", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listIpPhoneServicesResponse> listIpPhoneServicesAsync(AxlNetClient.listIpPhoneServicesRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCtiRoutePointResponse addCtiRoutePoint(AxlNetClient.addCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCtiRoutePointResponse> addCtiRoutePointAsync(AxlNetClient.addCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCtiRoutePointResponse updateCtiRoutePoint(AxlNetClient.updateCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCtiRoutePointResponse> updateCtiRoutePointAsync(AxlNetClient.updateCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCtiRoutePointResponse getCtiRoutePoint(AxlNetClient.getCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCtiRoutePointResponse> getCtiRoutePointAsync(AxlNetClient.getCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCtiRoutePointResponse removeCtiRoutePoint(AxlNetClient.removeCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCtiRoutePointResponse> removeCtiRoutePointAsync(AxlNetClient.removeCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCtiRoutePointResponse listCtiRoutePoint(AxlNetClient.listCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCtiRoutePointResponse> listCtiRoutePointAsync(AxlNetClient.listCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetCtiRoutePointResponse resetCtiRoutePoint(AxlNetClient.resetCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetCtiRoutePointResponse> resetCtiRoutePointAsync(AxlNetClient.resetCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartCtiRoutePointResponse restartCtiRoutePoint(AxlNetClient.restartCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartCtiRoutePointResponse> restartCtiRoutePointAsync(AxlNetClient.restartCtiRoutePointRequest request);
    }

    public class AXLPortClient33 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort33>, AxlNetClient.AXLPort33
    {
        public AXLPortClient33(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addIpPhoneServicesResponse AxlNetClient.AXLPort33.addIpPhoneServices(AxlNetClient.addIpPhoneServicesRequest request)
        {
            return base.Channel.addIpPhoneServices(request);
        }

        public AxlNetClient.StandardResponse addIpPhoneServices(AxlNetClient.AddIpPhoneServicesReq addIpPhoneServices1)
        {
            AxlNetClient.addIpPhoneServicesRequest inValue = new AxlNetClient.addIpPhoneServicesRequest();
            inValue.addIpPhoneServices = addIpPhoneServices1;
            AxlNetClient.addIpPhoneServicesResponse retVal = ((AxlNetClient.AXLPort33)(this)).addIpPhoneServices(inValue);
            return retVal.addIpPhoneServicesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addIpPhoneServicesResponse> AxlNetClient.AXLPort33.addIpPhoneServicesAsync(AxlNetClient.addIpPhoneServicesRequest request)
        {
            return base.Channel.addIpPhoneServicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addIpPhoneServicesResponse> addIpPhoneServicesAsync(AxlNetClient.AddIpPhoneServicesReq addIpPhoneServices)
        {
            AxlNetClient.addIpPhoneServicesRequest inValue = new AxlNetClient.addIpPhoneServicesRequest();
            inValue.addIpPhoneServices = addIpPhoneServices;
            return ((AxlNetClient.AXLPort33)(this)).addIpPhoneServicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateIpPhoneServicesResponse AxlNetClient.AXLPort33.updateIpPhoneServices(AxlNetClient.updateIpPhoneServicesRequest request)
        {
            return base.Channel.updateIpPhoneServices(request);
        }

        public AxlNetClient.StandardResponse updateIpPhoneServices(AxlNetClient.UpdateIpPhoneServicesReq updateIpPhoneServices1)
        {
            AxlNetClient.updateIpPhoneServicesRequest inValue = new AxlNetClient.updateIpPhoneServicesRequest();
            inValue.updateIpPhoneServices = updateIpPhoneServices1;
            AxlNetClient.updateIpPhoneServicesResponse retVal = ((AxlNetClient.AXLPort33)(this)).updateIpPhoneServices(inValue);
            return retVal.updateIpPhoneServicesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateIpPhoneServicesResponse> AxlNetClient.AXLPort33.updateIpPhoneServicesAsync(AxlNetClient.updateIpPhoneServicesRequest request)
        {
            return base.Channel.updateIpPhoneServicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateIpPhoneServicesResponse> updateIpPhoneServicesAsync(AxlNetClient.UpdateIpPhoneServicesReq updateIpPhoneServices)
        {
            AxlNetClient.updateIpPhoneServicesRequest inValue = new AxlNetClient.updateIpPhoneServicesRequest();
            inValue.updateIpPhoneServices = updateIpPhoneServices;
            return ((AxlNetClient.AXLPort33)(this)).updateIpPhoneServicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getIpPhoneServicesResponse AxlNetClient.AXLPort33.getIpPhoneServices(AxlNetClient.getIpPhoneServicesRequest request)
        {
            return base.Channel.getIpPhoneServices(request);
        }

        public AxlNetClient.GetIpPhoneServicesRes getIpPhoneServices(AxlNetClient.GetIpPhoneServicesReq getIpPhoneServices1)
        {
            AxlNetClient.getIpPhoneServicesRequest inValue = new AxlNetClient.getIpPhoneServicesRequest();
            inValue.getIpPhoneServices = getIpPhoneServices1;
            AxlNetClient.getIpPhoneServicesResponse retVal = ((AxlNetClient.AXLPort33)(this)).getIpPhoneServices(inValue);
            return retVal.getIpPhoneServicesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getIpPhoneServicesResponse> AxlNetClient.AXLPort33.getIpPhoneServicesAsync(AxlNetClient.getIpPhoneServicesRequest request)
        {
            return base.Channel.getIpPhoneServicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getIpPhoneServicesResponse> getIpPhoneServicesAsync(AxlNetClient.GetIpPhoneServicesReq getIpPhoneServices)
        {
            AxlNetClient.getIpPhoneServicesRequest inValue = new AxlNetClient.getIpPhoneServicesRequest();
            inValue.getIpPhoneServices = getIpPhoneServices;
            return ((AxlNetClient.AXLPort33)(this)).getIpPhoneServicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeIpPhoneServicesResponse AxlNetClient.AXLPort33.removeIpPhoneServices(AxlNetClient.removeIpPhoneServicesRequest request)
        {
            return base.Channel.removeIpPhoneServices(request);
        }

        public AxlNetClient.StandardResponse removeIpPhoneServices(AxlNetClient.RemoveIpPhoneServicesReq removeIpPhoneServices1)
        {
            AxlNetClient.removeIpPhoneServicesRequest inValue = new AxlNetClient.removeIpPhoneServicesRequest();
            inValue.removeIpPhoneServices = removeIpPhoneServices1;
            AxlNetClient.removeIpPhoneServicesResponse retVal = ((AxlNetClient.AXLPort33)(this)).removeIpPhoneServices(inValue);
            return retVal.removeIpPhoneServicesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeIpPhoneServicesResponse> AxlNetClient.AXLPort33.removeIpPhoneServicesAsync(AxlNetClient.removeIpPhoneServicesRequest request)
        {
            return base.Channel.removeIpPhoneServicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeIpPhoneServicesResponse> removeIpPhoneServicesAsync(AxlNetClient.RemoveIpPhoneServicesReq removeIpPhoneServices)
        {
            AxlNetClient.removeIpPhoneServicesRequest inValue = new AxlNetClient.removeIpPhoneServicesRequest();
            inValue.removeIpPhoneServices = removeIpPhoneServices;
            return ((AxlNetClient.AXLPort33)(this)).removeIpPhoneServicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listIpPhoneServicesResponse AxlNetClient.AXLPort33.listIpPhoneServices(AxlNetClient.listIpPhoneServicesRequest request)
        {
            return base.Channel.listIpPhoneServices(request);
        }

        public AxlNetClient.ListIpPhoneServicesRes listIpPhoneServices(AxlNetClient.ListIpPhoneServicesReq listIpPhoneServices1)
        {
            AxlNetClient.listIpPhoneServicesRequest inValue = new AxlNetClient.listIpPhoneServicesRequest();
            inValue.listIpPhoneServices = listIpPhoneServices1;
            AxlNetClient.listIpPhoneServicesResponse retVal = ((AxlNetClient.AXLPort33)(this)).listIpPhoneServices(inValue);
            return retVal.listIpPhoneServicesResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listIpPhoneServicesResponse> AxlNetClient.AXLPort33.listIpPhoneServicesAsync(AxlNetClient.listIpPhoneServicesRequest request)
        {
            return base.Channel.listIpPhoneServicesAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listIpPhoneServicesResponse> listIpPhoneServicesAsync(AxlNetClient.ListIpPhoneServicesReq listIpPhoneServices)
        {
            AxlNetClient.listIpPhoneServicesRequest inValue = new AxlNetClient.listIpPhoneServicesRequest();
            inValue.listIpPhoneServices = listIpPhoneServices;
            return ((AxlNetClient.AXLPort33)(this)).listIpPhoneServicesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCtiRoutePointResponse AxlNetClient.AXLPort33.addCtiRoutePoint(AxlNetClient.addCtiRoutePointRequest request)
        {
            return base.Channel.addCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse addCtiRoutePoint(AxlNetClient.AddCtiRoutePointReq addCtiRoutePoint1)
        {
            AxlNetClient.addCtiRoutePointRequest inValue = new AxlNetClient.addCtiRoutePointRequest();
            inValue.addCtiRoutePoint = addCtiRoutePoint1;
            AxlNetClient.addCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).addCtiRoutePoint(inValue);
            return retVal.addCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCtiRoutePointResponse> AxlNetClient.AXLPort33.addCtiRoutePointAsync(AxlNetClient.addCtiRoutePointRequest request)
        {
            return base.Channel.addCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCtiRoutePointResponse> addCtiRoutePointAsync(AxlNetClient.AddCtiRoutePointReq addCtiRoutePoint)
        {
            AxlNetClient.addCtiRoutePointRequest inValue = new AxlNetClient.addCtiRoutePointRequest();
            inValue.addCtiRoutePoint = addCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).addCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCtiRoutePointResponse AxlNetClient.AXLPort33.updateCtiRoutePoint(AxlNetClient.updateCtiRoutePointRequest request)
        {
            return base.Channel.updateCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse updateCtiRoutePoint(AxlNetClient.UpdateCtiRoutePointReq updateCtiRoutePoint1)
        {
            AxlNetClient.updateCtiRoutePointRequest inValue = new AxlNetClient.updateCtiRoutePointRequest();
            inValue.updateCtiRoutePoint = updateCtiRoutePoint1;
            AxlNetClient.updateCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).updateCtiRoutePoint(inValue);
            return retVal.updateCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCtiRoutePointResponse> AxlNetClient.AXLPort33.updateCtiRoutePointAsync(AxlNetClient.updateCtiRoutePointRequest request)
        {
            return base.Channel.updateCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCtiRoutePointResponse> updateCtiRoutePointAsync(AxlNetClient.UpdateCtiRoutePointReq updateCtiRoutePoint)
        {
            AxlNetClient.updateCtiRoutePointRequest inValue = new AxlNetClient.updateCtiRoutePointRequest();
            inValue.updateCtiRoutePoint = updateCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).updateCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCtiRoutePointResponse AxlNetClient.AXLPort33.getCtiRoutePoint(AxlNetClient.getCtiRoutePointRequest request)
        {
            return base.Channel.getCtiRoutePoint(request);
        }

        public AxlNetClient.GetCtiRoutePointRes getCtiRoutePoint(AxlNetClient.GetCtiRoutePointReq getCtiRoutePoint1)
        {
            AxlNetClient.getCtiRoutePointRequest inValue = new AxlNetClient.getCtiRoutePointRequest();
            inValue.getCtiRoutePoint = getCtiRoutePoint1;
            AxlNetClient.getCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).getCtiRoutePoint(inValue);
            return retVal.getCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCtiRoutePointResponse> AxlNetClient.AXLPort33.getCtiRoutePointAsync(AxlNetClient.getCtiRoutePointRequest request)
        {
            return base.Channel.getCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCtiRoutePointResponse> getCtiRoutePointAsync(AxlNetClient.GetCtiRoutePointReq getCtiRoutePoint)
        {
            AxlNetClient.getCtiRoutePointRequest inValue = new AxlNetClient.getCtiRoutePointRequest();
            inValue.getCtiRoutePoint = getCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).getCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCtiRoutePointResponse AxlNetClient.AXLPort33.removeCtiRoutePoint(AxlNetClient.removeCtiRoutePointRequest request)
        {
            return base.Channel.removeCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse removeCtiRoutePoint(AxlNetClient.NameAndGUIDRequest removeCtiRoutePoint1)
        {
            AxlNetClient.removeCtiRoutePointRequest inValue = new AxlNetClient.removeCtiRoutePointRequest();
            inValue.removeCtiRoutePoint = removeCtiRoutePoint1;
            AxlNetClient.removeCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).removeCtiRoutePoint(inValue);
            return retVal.removeCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCtiRoutePointResponse> AxlNetClient.AXLPort33.removeCtiRoutePointAsync(AxlNetClient.removeCtiRoutePointRequest request)
        {
            return base.Channel.removeCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCtiRoutePointResponse> removeCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest removeCtiRoutePoint)
        {
            AxlNetClient.removeCtiRoutePointRequest inValue = new AxlNetClient.removeCtiRoutePointRequest();
            inValue.removeCtiRoutePoint = removeCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).removeCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCtiRoutePointResponse AxlNetClient.AXLPort33.listCtiRoutePoint(AxlNetClient.listCtiRoutePointRequest request)
        {
            return base.Channel.listCtiRoutePoint(request);
        }

        public AxlNetClient.ListCtiRoutePointRes listCtiRoutePoint(AxlNetClient.ListCtiRoutePointReq listCtiRoutePoint1)
        {
            AxlNetClient.listCtiRoutePointRequest inValue = new AxlNetClient.listCtiRoutePointRequest();
            inValue.listCtiRoutePoint = listCtiRoutePoint1;
            AxlNetClient.listCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).listCtiRoutePoint(inValue);
            return retVal.listCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCtiRoutePointResponse> AxlNetClient.AXLPort33.listCtiRoutePointAsync(AxlNetClient.listCtiRoutePointRequest request)
        {
            return base.Channel.listCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCtiRoutePointResponse> listCtiRoutePointAsync(AxlNetClient.ListCtiRoutePointReq listCtiRoutePoint)
        {
            AxlNetClient.listCtiRoutePointRequest inValue = new AxlNetClient.listCtiRoutePointRequest();
            inValue.listCtiRoutePoint = listCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).listCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetCtiRoutePointResponse AxlNetClient.AXLPort33.resetCtiRoutePoint(AxlNetClient.resetCtiRoutePointRequest request)
        {
            return base.Channel.resetCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse resetCtiRoutePoint(AxlNetClient.NameAndGUIDRequest resetCtiRoutePoint1)
        {
            AxlNetClient.resetCtiRoutePointRequest inValue = new AxlNetClient.resetCtiRoutePointRequest();
            inValue.resetCtiRoutePoint = resetCtiRoutePoint1;
            AxlNetClient.resetCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).resetCtiRoutePoint(inValue);
            return retVal.resetCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetCtiRoutePointResponse> AxlNetClient.AXLPort33.resetCtiRoutePointAsync(AxlNetClient.resetCtiRoutePointRequest request)
        {
            return base.Channel.resetCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetCtiRoutePointResponse> resetCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest resetCtiRoutePoint)
        {
            AxlNetClient.resetCtiRoutePointRequest inValue = new AxlNetClient.resetCtiRoutePointRequest();
            inValue.resetCtiRoutePoint = resetCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).resetCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartCtiRoutePointResponse AxlNetClient.AXLPort33.restartCtiRoutePoint(AxlNetClient.restartCtiRoutePointRequest request)
        {
            return base.Channel.restartCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse restartCtiRoutePoint(AxlNetClient.NameAndGUIDRequest restartCtiRoutePoint1)
        {
            AxlNetClient.restartCtiRoutePointRequest inValue = new AxlNetClient.restartCtiRoutePointRequest();
            inValue.restartCtiRoutePoint = restartCtiRoutePoint1;
            AxlNetClient.restartCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort33)(this)).restartCtiRoutePoint(inValue);
            return retVal.restartCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartCtiRoutePointResponse> AxlNetClient.AXLPort33.restartCtiRoutePointAsync(AxlNetClient.restartCtiRoutePointRequest request)
        {
            return base.Channel.restartCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartCtiRoutePointResponse> restartCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest restartCtiRoutePoint)
        {
            AxlNetClient.restartCtiRoutePointRequest inValue = new AxlNetClient.restartCtiRoutePointRequest();
            inValue.restartCtiRoutePoint = restartCtiRoutePoint;
            return ((AxlNetClient.AXLPort33)(this)).restartCtiRoutePointAsync(inValue);
        }
    }
}