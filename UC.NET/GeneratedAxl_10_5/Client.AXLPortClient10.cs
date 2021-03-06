namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient10 _axlPortClient10;

        private static AXLPortClient10 axlPortClient10 => _axlPortClient10 == null ||
            _axlPortClient10.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient10 = LoadClient10()) : _axlPortClient10;

        private static AXLPortClient10 LoadClient10()
        {
            var client = new AXLPortClient10(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close10;
            OnAbort += Abort10;
            return client;
        }

        private static void Close10(object sender, System.EventArgs e)
        {
            _axlPortClient10.Close();
        }

        private static void Abort10(object sender, System.EventArgs e)
        {
            _axlPortClient10.Abort();
        }

        public AxlNetClient.StandardResponse addLocation(AxlNetClient.AddLocationReq addLocation1)
        {
            return axlPortClient10.addLocation(addLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLocationResponse> addLocationAsync(AxlNetClient.AddLocationReq addLocation)
        {
            return axlPortClient10.addLocationAsync(addLocation);
        }

        public AxlNetClient.StandardResponse updateLocation(AxlNetClient.UpdateLocationReq updateLocation1)
        {
            return axlPortClient10.updateLocation(updateLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLocationResponse> updateLocationAsync(AxlNetClient.UpdateLocationReq updateLocation)
        {
            return axlPortClient10.updateLocationAsync(updateLocation);
        }

        public AxlNetClient.GetLocationRes getLocation(AxlNetClient.GetLocationReq getLocation1)
        {
            return axlPortClient10.getLocation(getLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLocationResponse> getLocationAsync(AxlNetClient.GetLocationReq getLocation)
        {
            return axlPortClient10.getLocationAsync(getLocation);
        }

        public AxlNetClient.StandardResponse removeLocation(AxlNetClient.NameAndGUIDRequest removeLocation1)
        {
            return axlPortClient10.removeLocation(removeLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLocationResponse> removeLocationAsync(AxlNetClient.NameAndGUIDRequest removeLocation)
        {
            return axlPortClient10.removeLocationAsync(removeLocation);
        }

        public AxlNetClient.ListLocationRes listLocation(AxlNetClient.ListLocationReq listLocation1)
        {
            return axlPortClient10.listLocation(listLocation1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLocationResponse> listLocationAsync(AxlNetClient.ListLocationReq listLocation)
        {
            return axlPortClient10.listLocationAsync(listLocation);
        }

        public AxlNetClient.StandardResponse addSoftKeyTemplate(AxlNetClient.AddSoftKeyTemplateReq addSoftKeyTemplate1)
        {
            return axlPortClient10.addSoftKeyTemplate(addSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSoftKeyTemplateResponse> addSoftKeyTemplateAsync(AxlNetClient.AddSoftKeyTemplateReq addSoftKeyTemplate)
        {
            return axlPortClient10.addSoftKeyTemplateAsync(addSoftKeyTemplate);
        }

        public AxlNetClient.StandardResponse updateSoftKeyTemplate(AxlNetClient.UpdateSoftKeyTemplateReq updateSoftKeyTemplate1)
        {
            return axlPortClient10.updateSoftKeyTemplate(updateSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSoftKeyTemplateResponse> updateSoftKeyTemplateAsync(AxlNetClient.UpdateSoftKeyTemplateReq updateSoftKeyTemplate)
        {
            return axlPortClient10.updateSoftKeyTemplateAsync(updateSoftKeyTemplate);
        }

        public AxlNetClient.GetSoftKeyTemplateRes getSoftKeyTemplate(AxlNetClient.GetSoftKeyTemplateReq getSoftKeyTemplate1)
        {
            return axlPortClient10.getSoftKeyTemplate(getSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSoftKeyTemplateResponse> getSoftKeyTemplateAsync(AxlNetClient.GetSoftKeyTemplateReq getSoftKeyTemplate)
        {
            return axlPortClient10.getSoftKeyTemplateAsync(getSoftKeyTemplate);
        }

        public AxlNetClient.StandardResponse removeSoftKeyTemplate(AxlNetClient.NameAndGUIDRequest removeSoftKeyTemplate1)
        {
            return axlPortClient10.removeSoftKeyTemplate(removeSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSoftKeyTemplateResponse> removeSoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest removeSoftKeyTemplate)
        {
            return axlPortClient10.removeSoftKeyTemplateAsync(removeSoftKeyTemplate);
        }

        public AxlNetClient.ListSoftKeyTemplateRes listSoftKeyTemplate(AxlNetClient.ListSoftKeyTemplateReq listSoftKeyTemplate1)
        {
            return axlPortClient10.listSoftKeyTemplate(listSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSoftKeyTemplateResponse> listSoftKeyTemplateAsync(AxlNetClient.ListSoftKeyTemplateReq listSoftKeyTemplate)
        {
            return axlPortClient10.listSoftKeyTemplateAsync(listSoftKeyTemplate);
        }

        public AxlNetClient.StandardResponse restartSoftKeyTemplate(AxlNetClient.NameAndGUIDRequest restartSoftKeyTemplate1)
        {
            return axlPortClient10.restartSoftKeyTemplate(restartSoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSoftKeyTemplateResponse> restartSoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest restartSoftKeyTemplate)
        {
            return axlPortClient10.restartSoftKeyTemplateAsync(restartSoftKeyTemplate);
        }

        public AxlNetClient.StandardResponse applySoftKeyTemplate(AxlNetClient.NameAndGUIDRequest applySoftKeyTemplate1)
        {
            return axlPortClient10.applySoftKeyTemplate(applySoftKeyTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySoftKeyTemplateResponse> applySoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest applySoftKeyTemplate)
        {
            return axlPortClient10.applySoftKeyTemplateAsync(applySoftKeyTemplate);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort10
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLocationResponse addLocation(AxlNetClient.addLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLocationResponse> addLocationAsync(AxlNetClient.addLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLocationResponse updateLocation(AxlNetClient.updateLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLocationResponse> updateLocationAsync(AxlNetClient.updateLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLocationResponse getLocation(AxlNetClient.getLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLocationResponse> getLocationAsync(AxlNetClient.getLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLocationResponse removeLocation(AxlNetClient.removeLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLocationResponse> removeLocationAsync(AxlNetClient.removeLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLocation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLocationResponse listLocation(AxlNetClient.listLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLocation", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLocationResponse> listLocationAsync(AxlNetClient.listLocationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSoftKeyTemplateResponse addSoftKeyTemplate(AxlNetClient.addSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSoftKeyTemplateResponse> addSoftKeyTemplateAsync(AxlNetClient.addSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSoftKeyTemplateResponse updateSoftKeyTemplate(AxlNetClient.updateSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSoftKeyTemplateResponse> updateSoftKeyTemplateAsync(AxlNetClient.updateSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSoftKeyTemplateResponse getSoftKeyTemplate(AxlNetClient.getSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSoftKeyTemplateResponse> getSoftKeyTemplateAsync(AxlNetClient.getSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSoftKeyTemplateResponse removeSoftKeyTemplate(AxlNetClient.removeSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSoftKeyTemplateResponse> removeSoftKeyTemplateAsync(AxlNetClient.removeSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSoftKeyTemplateResponse listSoftKeyTemplate(AxlNetClient.listSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSoftKeyTemplateResponse> listSoftKeyTemplateAsync(AxlNetClient.listSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartSoftKeyTemplateResponse restartSoftKeyTemplate(AxlNetClient.restartSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartSoftKeyTemplateResponse> restartSoftKeyTemplateAsync(AxlNetClient.restartSoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySoftKeyTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applySoftKeyTemplateResponse applySoftKeyTemplate(AxlNetClient.applySoftKeyTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySoftKeyTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applySoftKeyTemplateResponse> applySoftKeyTemplateAsync(AxlNetClient.applySoftKeyTemplateRequest request);
    }

    public class AXLPortClient10 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort10>, AxlNetClient.AXLPort10
    {
        public AXLPortClient10(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLocationResponse AxlNetClient.AXLPort10.addLocation(AxlNetClient.addLocationRequest request)
        {
            return base.Channel.addLocation(request);
        }

        public AxlNetClient.StandardResponse addLocation(AxlNetClient.AddLocationReq addLocation1)
        {
            AxlNetClient.addLocationRequest inValue = new AxlNetClient.addLocationRequest();
            inValue.addLocation = addLocation1;
            AxlNetClient.addLocationResponse retVal = ((AxlNetClient.AXLPort10)(this)).addLocation(inValue);
            return retVal.addLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLocationResponse> AxlNetClient.AXLPort10.addLocationAsync(AxlNetClient.addLocationRequest request)
        {
            return base.Channel.addLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLocationResponse> addLocationAsync(AxlNetClient.AddLocationReq addLocation)
        {
            AxlNetClient.addLocationRequest inValue = new AxlNetClient.addLocationRequest();
            inValue.addLocation = addLocation;
            return ((AxlNetClient.AXLPort10)(this)).addLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLocationResponse AxlNetClient.AXLPort10.updateLocation(AxlNetClient.updateLocationRequest request)
        {
            return base.Channel.updateLocation(request);
        }

        public AxlNetClient.StandardResponse updateLocation(AxlNetClient.UpdateLocationReq updateLocation1)
        {
            AxlNetClient.updateLocationRequest inValue = new AxlNetClient.updateLocationRequest();
            inValue.updateLocation = updateLocation1;
            AxlNetClient.updateLocationResponse retVal = ((AxlNetClient.AXLPort10)(this)).updateLocation(inValue);
            return retVal.updateLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLocationResponse> AxlNetClient.AXLPort10.updateLocationAsync(AxlNetClient.updateLocationRequest request)
        {
            return base.Channel.updateLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLocationResponse> updateLocationAsync(AxlNetClient.UpdateLocationReq updateLocation)
        {
            AxlNetClient.updateLocationRequest inValue = new AxlNetClient.updateLocationRequest();
            inValue.updateLocation = updateLocation;
            return ((AxlNetClient.AXLPort10)(this)).updateLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLocationResponse AxlNetClient.AXLPort10.getLocation(AxlNetClient.getLocationRequest request)
        {
            return base.Channel.getLocation(request);
        }

        public AxlNetClient.GetLocationRes getLocation(AxlNetClient.GetLocationReq getLocation1)
        {
            AxlNetClient.getLocationRequest inValue = new AxlNetClient.getLocationRequest();
            inValue.getLocation = getLocation1;
            AxlNetClient.getLocationResponse retVal = ((AxlNetClient.AXLPort10)(this)).getLocation(inValue);
            return retVal.getLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLocationResponse> AxlNetClient.AXLPort10.getLocationAsync(AxlNetClient.getLocationRequest request)
        {
            return base.Channel.getLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLocationResponse> getLocationAsync(AxlNetClient.GetLocationReq getLocation)
        {
            AxlNetClient.getLocationRequest inValue = new AxlNetClient.getLocationRequest();
            inValue.getLocation = getLocation;
            return ((AxlNetClient.AXLPort10)(this)).getLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLocationResponse AxlNetClient.AXLPort10.removeLocation(AxlNetClient.removeLocationRequest request)
        {
            return base.Channel.removeLocation(request);
        }

        public AxlNetClient.StandardResponse removeLocation(AxlNetClient.NameAndGUIDRequest removeLocation1)
        {
            AxlNetClient.removeLocationRequest inValue = new AxlNetClient.removeLocationRequest();
            inValue.removeLocation = removeLocation1;
            AxlNetClient.removeLocationResponse retVal = ((AxlNetClient.AXLPort10)(this)).removeLocation(inValue);
            return retVal.removeLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLocationResponse> AxlNetClient.AXLPort10.removeLocationAsync(AxlNetClient.removeLocationRequest request)
        {
            return base.Channel.removeLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLocationResponse> removeLocationAsync(AxlNetClient.NameAndGUIDRequest removeLocation)
        {
            AxlNetClient.removeLocationRequest inValue = new AxlNetClient.removeLocationRequest();
            inValue.removeLocation = removeLocation;
            return ((AxlNetClient.AXLPort10)(this)).removeLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLocationResponse AxlNetClient.AXLPort10.listLocation(AxlNetClient.listLocationRequest request)
        {
            return base.Channel.listLocation(request);
        }

        public AxlNetClient.ListLocationRes listLocation(AxlNetClient.ListLocationReq listLocation1)
        {
            AxlNetClient.listLocationRequest inValue = new AxlNetClient.listLocationRequest();
            inValue.listLocation = listLocation1;
            AxlNetClient.listLocationResponse retVal = ((AxlNetClient.AXLPort10)(this)).listLocation(inValue);
            return retVal.listLocationResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLocationResponse> AxlNetClient.AXLPort10.listLocationAsync(AxlNetClient.listLocationRequest request)
        {
            return base.Channel.listLocationAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLocationResponse> listLocationAsync(AxlNetClient.ListLocationReq listLocation)
        {
            AxlNetClient.listLocationRequest inValue = new AxlNetClient.listLocationRequest();
            inValue.listLocation = listLocation;
            return ((AxlNetClient.AXLPort10)(this)).listLocationAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSoftKeyTemplateResponse AxlNetClient.AXLPort10.addSoftKeyTemplate(AxlNetClient.addSoftKeyTemplateRequest request)
        {
            return base.Channel.addSoftKeyTemplate(request);
        }

        public AxlNetClient.StandardResponse addSoftKeyTemplate(AxlNetClient.AddSoftKeyTemplateReq addSoftKeyTemplate1)
        {
            AxlNetClient.addSoftKeyTemplateRequest inValue = new AxlNetClient.addSoftKeyTemplateRequest();
            inValue.addSoftKeyTemplate = addSoftKeyTemplate1;
            AxlNetClient.addSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).addSoftKeyTemplate(inValue);
            return retVal.addSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSoftKeyTemplateResponse> AxlNetClient.AXLPort10.addSoftKeyTemplateAsync(AxlNetClient.addSoftKeyTemplateRequest request)
        {
            return base.Channel.addSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSoftKeyTemplateResponse> addSoftKeyTemplateAsync(AxlNetClient.AddSoftKeyTemplateReq addSoftKeyTemplate)
        {
            AxlNetClient.addSoftKeyTemplateRequest inValue = new AxlNetClient.addSoftKeyTemplateRequest();
            inValue.addSoftKeyTemplate = addSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).addSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSoftKeyTemplateResponse AxlNetClient.AXLPort10.updateSoftKeyTemplate(AxlNetClient.updateSoftKeyTemplateRequest request)
        {
            return base.Channel.updateSoftKeyTemplate(request);
        }

        public AxlNetClient.StandardResponse updateSoftKeyTemplate(AxlNetClient.UpdateSoftKeyTemplateReq updateSoftKeyTemplate1)
        {
            AxlNetClient.updateSoftKeyTemplateRequest inValue = new AxlNetClient.updateSoftKeyTemplateRequest();
            inValue.updateSoftKeyTemplate = updateSoftKeyTemplate1;
            AxlNetClient.updateSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).updateSoftKeyTemplate(inValue);
            return retVal.updateSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSoftKeyTemplateResponse> AxlNetClient.AXLPort10.updateSoftKeyTemplateAsync(AxlNetClient.updateSoftKeyTemplateRequest request)
        {
            return base.Channel.updateSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSoftKeyTemplateResponse> updateSoftKeyTemplateAsync(AxlNetClient.UpdateSoftKeyTemplateReq updateSoftKeyTemplate)
        {
            AxlNetClient.updateSoftKeyTemplateRequest inValue = new AxlNetClient.updateSoftKeyTemplateRequest();
            inValue.updateSoftKeyTemplate = updateSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).updateSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSoftKeyTemplateResponse AxlNetClient.AXLPort10.getSoftKeyTemplate(AxlNetClient.getSoftKeyTemplateRequest request)
        {
            return base.Channel.getSoftKeyTemplate(request);
        }

        public AxlNetClient.GetSoftKeyTemplateRes getSoftKeyTemplate(AxlNetClient.GetSoftKeyTemplateReq getSoftKeyTemplate1)
        {
            AxlNetClient.getSoftKeyTemplateRequest inValue = new AxlNetClient.getSoftKeyTemplateRequest();
            inValue.getSoftKeyTemplate = getSoftKeyTemplate1;
            AxlNetClient.getSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).getSoftKeyTemplate(inValue);
            return retVal.getSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSoftKeyTemplateResponse> AxlNetClient.AXLPort10.getSoftKeyTemplateAsync(AxlNetClient.getSoftKeyTemplateRequest request)
        {
            return base.Channel.getSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSoftKeyTemplateResponse> getSoftKeyTemplateAsync(AxlNetClient.GetSoftKeyTemplateReq getSoftKeyTemplate)
        {
            AxlNetClient.getSoftKeyTemplateRequest inValue = new AxlNetClient.getSoftKeyTemplateRequest();
            inValue.getSoftKeyTemplate = getSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).getSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSoftKeyTemplateResponse AxlNetClient.AXLPort10.removeSoftKeyTemplate(AxlNetClient.removeSoftKeyTemplateRequest request)
        {
            return base.Channel.removeSoftKeyTemplate(request);
        }

        public AxlNetClient.StandardResponse removeSoftKeyTemplate(AxlNetClient.NameAndGUIDRequest removeSoftKeyTemplate1)
        {
            AxlNetClient.removeSoftKeyTemplateRequest inValue = new AxlNetClient.removeSoftKeyTemplateRequest();
            inValue.removeSoftKeyTemplate = removeSoftKeyTemplate1;
            AxlNetClient.removeSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).removeSoftKeyTemplate(inValue);
            return retVal.removeSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSoftKeyTemplateResponse> AxlNetClient.AXLPort10.removeSoftKeyTemplateAsync(AxlNetClient.removeSoftKeyTemplateRequest request)
        {
            return base.Channel.removeSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSoftKeyTemplateResponse> removeSoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest removeSoftKeyTemplate)
        {
            AxlNetClient.removeSoftKeyTemplateRequest inValue = new AxlNetClient.removeSoftKeyTemplateRequest();
            inValue.removeSoftKeyTemplate = removeSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).removeSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSoftKeyTemplateResponse AxlNetClient.AXLPort10.listSoftKeyTemplate(AxlNetClient.listSoftKeyTemplateRequest request)
        {
            return base.Channel.listSoftKeyTemplate(request);
        }

        public AxlNetClient.ListSoftKeyTemplateRes listSoftKeyTemplate(AxlNetClient.ListSoftKeyTemplateReq listSoftKeyTemplate1)
        {
            AxlNetClient.listSoftKeyTemplateRequest inValue = new AxlNetClient.listSoftKeyTemplateRequest();
            inValue.listSoftKeyTemplate = listSoftKeyTemplate1;
            AxlNetClient.listSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).listSoftKeyTemplate(inValue);
            return retVal.listSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSoftKeyTemplateResponse> AxlNetClient.AXLPort10.listSoftKeyTemplateAsync(AxlNetClient.listSoftKeyTemplateRequest request)
        {
            return base.Channel.listSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSoftKeyTemplateResponse> listSoftKeyTemplateAsync(AxlNetClient.ListSoftKeyTemplateReq listSoftKeyTemplate)
        {
            AxlNetClient.listSoftKeyTemplateRequest inValue = new AxlNetClient.listSoftKeyTemplateRequest();
            inValue.listSoftKeyTemplate = listSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).listSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartSoftKeyTemplateResponse AxlNetClient.AXLPort10.restartSoftKeyTemplate(AxlNetClient.restartSoftKeyTemplateRequest request)
        {
            return base.Channel.restartSoftKeyTemplate(request);
        }

        public AxlNetClient.StandardResponse restartSoftKeyTemplate(AxlNetClient.NameAndGUIDRequest restartSoftKeyTemplate1)
        {
            AxlNetClient.restartSoftKeyTemplateRequest inValue = new AxlNetClient.restartSoftKeyTemplateRequest();
            inValue.restartSoftKeyTemplate = restartSoftKeyTemplate1;
            AxlNetClient.restartSoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).restartSoftKeyTemplate(inValue);
            return retVal.restartSoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartSoftKeyTemplateResponse> AxlNetClient.AXLPort10.restartSoftKeyTemplateAsync(AxlNetClient.restartSoftKeyTemplateRequest request)
        {
            return base.Channel.restartSoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSoftKeyTemplateResponse> restartSoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest restartSoftKeyTemplate)
        {
            AxlNetClient.restartSoftKeyTemplateRequest inValue = new AxlNetClient.restartSoftKeyTemplateRequest();
            inValue.restartSoftKeyTemplate = restartSoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).restartSoftKeyTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applySoftKeyTemplateResponse AxlNetClient.AXLPort10.applySoftKeyTemplate(AxlNetClient.applySoftKeyTemplateRequest request)
        {
            return base.Channel.applySoftKeyTemplate(request);
        }

        public AxlNetClient.StandardResponse applySoftKeyTemplate(AxlNetClient.NameAndGUIDRequest applySoftKeyTemplate1)
        {
            AxlNetClient.applySoftKeyTemplateRequest inValue = new AxlNetClient.applySoftKeyTemplateRequest();
            inValue.applySoftKeyTemplate = applySoftKeyTemplate1;
            AxlNetClient.applySoftKeyTemplateResponse retVal = ((AxlNetClient.AXLPort10)(this)).applySoftKeyTemplate(inValue);
            return retVal.applySoftKeyTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applySoftKeyTemplateResponse> AxlNetClient.AXLPort10.applySoftKeyTemplateAsync(AxlNetClient.applySoftKeyTemplateRequest request)
        {
            return base.Channel.applySoftKeyTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySoftKeyTemplateResponse> applySoftKeyTemplateAsync(AxlNetClient.NameAndGUIDRequest applySoftKeyTemplate)
        {
            AxlNetClient.applySoftKeyTemplateRequest inValue = new AxlNetClient.applySoftKeyTemplateRequest();
            inValue.applySoftKeyTemplate = applySoftKeyTemplate;
            return ((AxlNetClient.AXLPort10)(this)).applySoftKeyTemplateAsync(inValue);
        }
    }
}