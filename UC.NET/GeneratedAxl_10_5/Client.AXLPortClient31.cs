namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient31 _axlPortClient31;

        private static AXLPortClient31 axlPortClient31 => _axlPortClient31 == null ||
            _axlPortClient31.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient31 = LoadClient31()) : _axlPortClient31;

        private static AXLPortClient31 LoadClient31()
        {
            var client = new AXLPortClient31(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close31;
            OnAbort += Abort31;
            return client;
        }

        private static void Close31(object sender, System.EventArgs e)
        {
            _axlPortClient31.Close();
        }

        private static void Abort31(object sender, System.EventArgs e)
        {
            _axlPortClient31.Abort();
        }

        public AxlNetClient.StandardResponse removeGatekeeper(AxlNetClient.NameAndGUIDRequest removeGatekeeper1)
        {
            return axlPortClient31.removeGatekeeper(removeGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatekeeperResponse> removeGatekeeperAsync(AxlNetClient.NameAndGUIDRequest removeGatekeeper)
        {
            return axlPortClient31.removeGatekeeperAsync(removeGatekeeper);
        }

        public AxlNetClient.ListGatekeeperRes listGatekeeper(AxlNetClient.ListGatekeeperReq listGatekeeper1)
        {
            return axlPortClient31.listGatekeeper(listGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGatekeeperResponse> listGatekeeperAsync(AxlNetClient.ListGatekeeperReq listGatekeeper)
        {
            return axlPortClient31.listGatekeeperAsync(listGatekeeper);
        }

        public AxlNetClient.StandardResponse resetGatekeeper(AxlNetClient.NameAndGUIDRequest resetGatekeeper1)
        {
            return axlPortClient31.resetGatekeeper(resetGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetGatekeeperResponse> resetGatekeeperAsync(AxlNetClient.NameAndGUIDRequest resetGatekeeper)
        {
            return axlPortClient31.resetGatekeeperAsync(resetGatekeeper);
        }

        public AxlNetClient.StandardResponse restartGatekeeper(AxlNetClient.NameAndGUIDRequest restartGatekeeper1)
        {
            return axlPortClient31.restartGatekeeper(restartGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartGatekeeperResponse> restartGatekeeperAsync(AxlNetClient.NameAndGUIDRequest restartGatekeeper)
        {
            return axlPortClient31.restartGatekeeperAsync(restartGatekeeper);
        }

        public AxlNetClient.StandardResponse applyGatekeeper(AxlNetClient.NameAndGUIDRequest applyGatekeeper1)
        {
            return axlPortClient31.applyGatekeeper(applyGatekeeper1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyGatekeeperResponse> applyGatekeeperAsync(AxlNetClient.NameAndGUIDRequest applyGatekeeper)
        {
            return axlPortClient31.applyGatekeeperAsync(applyGatekeeper);
        }

        public AxlNetClient.StandardResponse addPhoneButtonTemplate(AxlNetClient.AddPhoneButtonTemplateReq addPhoneButtonTemplate1)
        {
            return axlPortClient31.addPhoneButtonTemplate(addPhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneButtonTemplateResponse> addPhoneButtonTemplateAsync(AxlNetClient.AddPhoneButtonTemplateReq addPhoneButtonTemplate)
        {
            return axlPortClient31.addPhoneButtonTemplateAsync(addPhoneButtonTemplate);
        }

        public AxlNetClient.StandardResponse updatePhoneButtonTemplate(AxlNetClient.UpdatePhoneButtonTemplateReq updatePhoneButtonTemplate1)
        {
            return axlPortClient31.updatePhoneButtonTemplate(updatePhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneButtonTemplateResponse> updatePhoneButtonTemplateAsync(AxlNetClient.UpdatePhoneButtonTemplateReq updatePhoneButtonTemplate)
        {
            return axlPortClient31.updatePhoneButtonTemplateAsync(updatePhoneButtonTemplate);
        }

        public AxlNetClient.GetPhoneButtonTemplateRes getPhoneButtonTemplate(AxlNetClient.GetPhoneButtonTemplateReq getPhoneButtonTemplate1)
        {
            return axlPortClient31.getPhoneButtonTemplate(getPhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneButtonTemplateResponse> getPhoneButtonTemplateAsync(AxlNetClient.GetPhoneButtonTemplateReq getPhoneButtonTemplate)
        {
            return axlPortClient31.getPhoneButtonTemplateAsync(getPhoneButtonTemplate);
        }

        public AxlNetClient.StandardResponse removePhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest removePhoneButtonTemplate1)
        {
            return axlPortClient31.removePhoneButtonTemplate(removePhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneButtonTemplateResponse> removePhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest removePhoneButtonTemplate)
        {
            return axlPortClient31.removePhoneButtonTemplateAsync(removePhoneButtonTemplate);
        }

        public AxlNetClient.ListPhoneButtonTemplateRes listPhoneButtonTemplate(AxlNetClient.ListPhoneButtonTemplateReq listPhoneButtonTemplate1)
        {
            return axlPortClient31.listPhoneButtonTemplate(listPhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneButtonTemplateResponse> listPhoneButtonTemplateAsync(AxlNetClient.ListPhoneButtonTemplateReq listPhoneButtonTemplate)
        {
            return axlPortClient31.listPhoneButtonTemplateAsync(listPhoneButtonTemplate);
        }

        public AxlNetClient.StandardResponse restartPhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest restartPhoneButtonTemplate1)
        {
            return axlPortClient31.restartPhoneButtonTemplate(restartPhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartPhoneButtonTemplateResponse> restartPhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest restartPhoneButtonTemplate)
        {
            return axlPortClient31.restartPhoneButtonTemplateAsync(restartPhoneButtonTemplate);
        }

        public AxlNetClient.StandardResponse applyPhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest applyPhoneButtonTemplate1)
        {
            return axlPortClient31.applyPhoneButtonTemplate(applyPhoneButtonTemplate1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneButtonTemplateResponse> applyPhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest applyPhoneButtonTemplate)
        {
            return axlPortClient31.applyPhoneButtonTemplateAsync(applyPhoneButtonTemplate);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort31
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGatekeeperResponse removeGatekeeper(AxlNetClient.removeGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGatekeeperResponse> removeGatekeeperAsync(AxlNetClient.removeGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listGatekeeperResponse listGatekeeper(AxlNetClient.listGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listGatekeeperResponse> listGatekeeperAsync(AxlNetClient.listGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetGatekeeperResponse resetGatekeeper(AxlNetClient.resetGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetGatekeeperResponse> resetGatekeeperAsync(AxlNetClient.resetGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartGatekeeperResponse restartGatekeeper(AxlNetClient.restartGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartGatekeeperResponse> restartGatekeeperAsync(AxlNetClient.restartGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyGatekeeper", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyGatekeeperResponse applyGatekeeper(AxlNetClient.applyGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyGatekeeper", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyGatekeeperResponse> applyGatekeeperAsync(AxlNetClient.applyGatekeeperRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPhoneButtonTemplateResponse addPhoneButtonTemplate(AxlNetClient.addPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneButtonTemplateResponse> addPhoneButtonTemplateAsync(AxlNetClient.addPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePhoneButtonTemplateResponse updatePhoneButtonTemplate(AxlNetClient.updatePhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneButtonTemplateResponse> updatePhoneButtonTemplateAsync(AxlNetClient.updatePhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneButtonTemplateResponse getPhoneButtonTemplate(AxlNetClient.getPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneButtonTemplateResponse> getPhoneButtonTemplateAsync(AxlNetClient.getPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePhoneButtonTemplateResponse removePhoneButtonTemplate(AxlNetClient.removePhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneButtonTemplateResponse> removePhoneButtonTemplateAsync(AxlNetClient.removePhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPhoneButtonTemplateResponse listPhoneButtonTemplate(AxlNetClient.listPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneButtonTemplateResponse> listPhoneButtonTemplateAsync(AxlNetClient.listPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartPhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartPhoneButtonTemplateResponse restartPhoneButtonTemplate(AxlNetClient.restartPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartPhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartPhoneButtonTemplateResponse> restartPhoneButtonTemplateAsync(AxlNetClient.restartPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhoneButtonTemplate", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyPhoneButtonTemplateResponse applyPhoneButtonTemplate(AxlNetClient.applyPhoneButtonTemplateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhoneButtonTemplate", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneButtonTemplateResponse> applyPhoneButtonTemplateAsync(AxlNetClient.applyPhoneButtonTemplateRequest request);
    }

    public class AXLPortClient31 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort31>, AxlNetClient.AXLPort31
    {
        public AXLPortClient31(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGatekeeperResponse AxlNetClient.AXLPort31.removeGatekeeper(AxlNetClient.removeGatekeeperRequest request)
        {
            return base.Channel.removeGatekeeper(request);
        }

        public AxlNetClient.StandardResponse removeGatekeeper(AxlNetClient.NameAndGUIDRequest removeGatekeeper1)
        {
            AxlNetClient.removeGatekeeperRequest inValue = new AxlNetClient.removeGatekeeperRequest();
            inValue.removeGatekeeper = removeGatekeeper1;
            AxlNetClient.removeGatekeeperResponse retVal = ((AxlNetClient.AXLPort31)(this)).removeGatekeeper(inValue);
            return retVal.removeGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGatekeeperResponse> AxlNetClient.AXLPort31.removeGatekeeperAsync(AxlNetClient.removeGatekeeperRequest request)
        {
            return base.Channel.removeGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGatekeeperResponse> removeGatekeeperAsync(AxlNetClient.NameAndGUIDRequest removeGatekeeper)
        {
            AxlNetClient.removeGatekeeperRequest inValue = new AxlNetClient.removeGatekeeperRequest();
            inValue.removeGatekeeper = removeGatekeeper;
            return ((AxlNetClient.AXLPort31)(this)).removeGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listGatekeeperResponse AxlNetClient.AXLPort31.listGatekeeper(AxlNetClient.listGatekeeperRequest request)
        {
            return base.Channel.listGatekeeper(request);
        }

        public AxlNetClient.ListGatekeeperRes listGatekeeper(AxlNetClient.ListGatekeeperReq listGatekeeper1)
        {
            AxlNetClient.listGatekeeperRequest inValue = new AxlNetClient.listGatekeeperRequest();
            inValue.listGatekeeper = listGatekeeper1;
            AxlNetClient.listGatekeeperResponse retVal = ((AxlNetClient.AXLPort31)(this)).listGatekeeper(inValue);
            return retVal.listGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listGatekeeperResponse> AxlNetClient.AXLPort31.listGatekeeperAsync(AxlNetClient.listGatekeeperRequest request)
        {
            return base.Channel.listGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGatekeeperResponse> listGatekeeperAsync(AxlNetClient.ListGatekeeperReq listGatekeeper)
        {
            AxlNetClient.listGatekeeperRequest inValue = new AxlNetClient.listGatekeeperRequest();
            inValue.listGatekeeper = listGatekeeper;
            return ((AxlNetClient.AXLPort31)(this)).listGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetGatekeeperResponse AxlNetClient.AXLPort31.resetGatekeeper(AxlNetClient.resetGatekeeperRequest request)
        {
            return base.Channel.resetGatekeeper(request);
        }

        public AxlNetClient.StandardResponse resetGatekeeper(AxlNetClient.NameAndGUIDRequest resetGatekeeper1)
        {
            AxlNetClient.resetGatekeeperRequest inValue = new AxlNetClient.resetGatekeeperRequest();
            inValue.resetGatekeeper = resetGatekeeper1;
            AxlNetClient.resetGatekeeperResponse retVal = ((AxlNetClient.AXLPort31)(this)).resetGatekeeper(inValue);
            return retVal.resetGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetGatekeeperResponse> AxlNetClient.AXLPort31.resetGatekeeperAsync(AxlNetClient.resetGatekeeperRequest request)
        {
            return base.Channel.resetGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetGatekeeperResponse> resetGatekeeperAsync(AxlNetClient.NameAndGUIDRequest resetGatekeeper)
        {
            AxlNetClient.resetGatekeeperRequest inValue = new AxlNetClient.resetGatekeeperRequest();
            inValue.resetGatekeeper = resetGatekeeper;
            return ((AxlNetClient.AXLPort31)(this)).resetGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartGatekeeperResponse AxlNetClient.AXLPort31.restartGatekeeper(AxlNetClient.restartGatekeeperRequest request)
        {
            return base.Channel.restartGatekeeper(request);
        }

        public AxlNetClient.StandardResponse restartGatekeeper(AxlNetClient.NameAndGUIDRequest restartGatekeeper1)
        {
            AxlNetClient.restartGatekeeperRequest inValue = new AxlNetClient.restartGatekeeperRequest();
            inValue.restartGatekeeper = restartGatekeeper1;
            AxlNetClient.restartGatekeeperResponse retVal = ((AxlNetClient.AXLPort31)(this)).restartGatekeeper(inValue);
            return retVal.restartGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartGatekeeperResponse> AxlNetClient.AXLPort31.restartGatekeeperAsync(AxlNetClient.restartGatekeeperRequest request)
        {
            return base.Channel.restartGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartGatekeeperResponse> restartGatekeeperAsync(AxlNetClient.NameAndGUIDRequest restartGatekeeper)
        {
            AxlNetClient.restartGatekeeperRequest inValue = new AxlNetClient.restartGatekeeperRequest();
            inValue.restartGatekeeper = restartGatekeeper;
            return ((AxlNetClient.AXLPort31)(this)).restartGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyGatekeeperResponse AxlNetClient.AXLPort31.applyGatekeeper(AxlNetClient.applyGatekeeperRequest request)
        {
            return base.Channel.applyGatekeeper(request);
        }

        public AxlNetClient.StandardResponse applyGatekeeper(AxlNetClient.NameAndGUIDRequest applyGatekeeper1)
        {
            AxlNetClient.applyGatekeeperRequest inValue = new AxlNetClient.applyGatekeeperRequest();
            inValue.applyGatekeeper = applyGatekeeper1;
            AxlNetClient.applyGatekeeperResponse retVal = ((AxlNetClient.AXLPort31)(this)).applyGatekeeper(inValue);
            return retVal.applyGatekeeperResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyGatekeeperResponse> AxlNetClient.AXLPort31.applyGatekeeperAsync(AxlNetClient.applyGatekeeperRequest request)
        {
            return base.Channel.applyGatekeeperAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyGatekeeperResponse> applyGatekeeperAsync(AxlNetClient.NameAndGUIDRequest applyGatekeeper)
        {
            AxlNetClient.applyGatekeeperRequest inValue = new AxlNetClient.applyGatekeeperRequest();
            inValue.applyGatekeeper = applyGatekeeper;
            return ((AxlNetClient.AXLPort31)(this)).applyGatekeeperAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPhoneButtonTemplateResponse AxlNetClient.AXLPort31.addPhoneButtonTemplate(AxlNetClient.addPhoneButtonTemplateRequest request)
        {
            return base.Channel.addPhoneButtonTemplate(request);
        }

        public AxlNetClient.StandardResponse addPhoneButtonTemplate(AxlNetClient.AddPhoneButtonTemplateReq addPhoneButtonTemplate1)
        {
            AxlNetClient.addPhoneButtonTemplateRequest inValue = new AxlNetClient.addPhoneButtonTemplateRequest();
            inValue.addPhoneButtonTemplate = addPhoneButtonTemplate1;
            AxlNetClient.addPhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).addPhoneButtonTemplate(inValue);
            return retVal.addPhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneButtonTemplateResponse> AxlNetClient.AXLPort31.addPhoneButtonTemplateAsync(AxlNetClient.addPhoneButtonTemplateRequest request)
        {
            return base.Channel.addPhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneButtonTemplateResponse> addPhoneButtonTemplateAsync(AxlNetClient.AddPhoneButtonTemplateReq addPhoneButtonTemplate)
        {
            AxlNetClient.addPhoneButtonTemplateRequest inValue = new AxlNetClient.addPhoneButtonTemplateRequest();
            inValue.addPhoneButtonTemplate = addPhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).addPhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePhoneButtonTemplateResponse AxlNetClient.AXLPort31.updatePhoneButtonTemplate(AxlNetClient.updatePhoneButtonTemplateRequest request)
        {
            return base.Channel.updatePhoneButtonTemplate(request);
        }

        public AxlNetClient.StandardResponse updatePhoneButtonTemplate(AxlNetClient.UpdatePhoneButtonTemplateReq updatePhoneButtonTemplate1)
        {
            AxlNetClient.updatePhoneButtonTemplateRequest inValue = new AxlNetClient.updatePhoneButtonTemplateRequest();
            inValue.updatePhoneButtonTemplate = updatePhoneButtonTemplate1;
            AxlNetClient.updatePhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).updatePhoneButtonTemplate(inValue);
            return retVal.updatePhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneButtonTemplateResponse> AxlNetClient.AXLPort31.updatePhoneButtonTemplateAsync(AxlNetClient.updatePhoneButtonTemplateRequest request)
        {
            return base.Channel.updatePhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneButtonTemplateResponse> updatePhoneButtonTemplateAsync(AxlNetClient.UpdatePhoneButtonTemplateReq updatePhoneButtonTemplate)
        {
            AxlNetClient.updatePhoneButtonTemplateRequest inValue = new AxlNetClient.updatePhoneButtonTemplateRequest();
            inValue.updatePhoneButtonTemplate = updatePhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).updatePhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneButtonTemplateResponse AxlNetClient.AXLPort31.getPhoneButtonTemplate(AxlNetClient.getPhoneButtonTemplateRequest request)
        {
            return base.Channel.getPhoneButtonTemplate(request);
        }

        public AxlNetClient.GetPhoneButtonTemplateRes getPhoneButtonTemplate(AxlNetClient.GetPhoneButtonTemplateReq getPhoneButtonTemplate1)
        {
            AxlNetClient.getPhoneButtonTemplateRequest inValue = new AxlNetClient.getPhoneButtonTemplateRequest();
            inValue.getPhoneButtonTemplate = getPhoneButtonTemplate1;
            AxlNetClient.getPhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).getPhoneButtonTemplate(inValue);
            return retVal.getPhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneButtonTemplateResponse> AxlNetClient.AXLPort31.getPhoneButtonTemplateAsync(AxlNetClient.getPhoneButtonTemplateRequest request)
        {
            return base.Channel.getPhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneButtonTemplateResponse> getPhoneButtonTemplateAsync(AxlNetClient.GetPhoneButtonTemplateReq getPhoneButtonTemplate)
        {
            AxlNetClient.getPhoneButtonTemplateRequest inValue = new AxlNetClient.getPhoneButtonTemplateRequest();
            inValue.getPhoneButtonTemplate = getPhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).getPhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePhoneButtonTemplateResponse AxlNetClient.AXLPort31.removePhoneButtonTemplate(AxlNetClient.removePhoneButtonTemplateRequest request)
        {
            return base.Channel.removePhoneButtonTemplate(request);
        }

        public AxlNetClient.StandardResponse removePhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest removePhoneButtonTemplate1)
        {
            AxlNetClient.removePhoneButtonTemplateRequest inValue = new AxlNetClient.removePhoneButtonTemplateRequest();
            inValue.removePhoneButtonTemplate = removePhoneButtonTemplate1;
            AxlNetClient.removePhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).removePhoneButtonTemplate(inValue);
            return retVal.removePhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneButtonTemplateResponse> AxlNetClient.AXLPort31.removePhoneButtonTemplateAsync(AxlNetClient.removePhoneButtonTemplateRequest request)
        {
            return base.Channel.removePhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneButtonTemplateResponse> removePhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest removePhoneButtonTemplate)
        {
            AxlNetClient.removePhoneButtonTemplateRequest inValue = new AxlNetClient.removePhoneButtonTemplateRequest();
            inValue.removePhoneButtonTemplate = removePhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).removePhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPhoneButtonTemplateResponse AxlNetClient.AXLPort31.listPhoneButtonTemplate(AxlNetClient.listPhoneButtonTemplateRequest request)
        {
            return base.Channel.listPhoneButtonTemplate(request);
        }

        public AxlNetClient.ListPhoneButtonTemplateRes listPhoneButtonTemplate(AxlNetClient.ListPhoneButtonTemplateReq listPhoneButtonTemplate1)
        {
            AxlNetClient.listPhoneButtonTemplateRequest inValue = new AxlNetClient.listPhoneButtonTemplateRequest();
            inValue.listPhoneButtonTemplate = listPhoneButtonTemplate1;
            AxlNetClient.listPhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).listPhoneButtonTemplate(inValue);
            return retVal.listPhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneButtonTemplateResponse> AxlNetClient.AXLPort31.listPhoneButtonTemplateAsync(AxlNetClient.listPhoneButtonTemplateRequest request)
        {
            return base.Channel.listPhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneButtonTemplateResponse> listPhoneButtonTemplateAsync(AxlNetClient.ListPhoneButtonTemplateReq listPhoneButtonTemplate)
        {
            AxlNetClient.listPhoneButtonTemplateRequest inValue = new AxlNetClient.listPhoneButtonTemplateRequest();
            inValue.listPhoneButtonTemplate = listPhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).listPhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartPhoneButtonTemplateResponse AxlNetClient.AXLPort31.restartPhoneButtonTemplate(AxlNetClient.restartPhoneButtonTemplateRequest request)
        {
            return base.Channel.restartPhoneButtonTemplate(request);
        }

        public AxlNetClient.StandardResponse restartPhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest restartPhoneButtonTemplate1)
        {
            AxlNetClient.restartPhoneButtonTemplateRequest inValue = new AxlNetClient.restartPhoneButtonTemplateRequest();
            inValue.restartPhoneButtonTemplate = restartPhoneButtonTemplate1;
            AxlNetClient.restartPhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).restartPhoneButtonTemplate(inValue);
            return retVal.restartPhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartPhoneButtonTemplateResponse> AxlNetClient.AXLPort31.restartPhoneButtonTemplateAsync(AxlNetClient.restartPhoneButtonTemplateRequest request)
        {
            return base.Channel.restartPhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartPhoneButtonTemplateResponse> restartPhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest restartPhoneButtonTemplate)
        {
            AxlNetClient.restartPhoneButtonTemplateRequest inValue = new AxlNetClient.restartPhoneButtonTemplateRequest();
            inValue.restartPhoneButtonTemplate = restartPhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).restartPhoneButtonTemplateAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyPhoneButtonTemplateResponse AxlNetClient.AXLPort31.applyPhoneButtonTemplate(AxlNetClient.applyPhoneButtonTemplateRequest request)
        {
            return base.Channel.applyPhoneButtonTemplate(request);
        }

        public AxlNetClient.StandardResponse applyPhoneButtonTemplate(AxlNetClient.NameAndGUIDRequest applyPhoneButtonTemplate1)
        {
            AxlNetClient.applyPhoneButtonTemplateRequest inValue = new AxlNetClient.applyPhoneButtonTemplateRequest();
            inValue.applyPhoneButtonTemplate = applyPhoneButtonTemplate1;
            AxlNetClient.applyPhoneButtonTemplateResponse retVal = ((AxlNetClient.AXLPort31)(this)).applyPhoneButtonTemplate(inValue);
            return retVal.applyPhoneButtonTemplateResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneButtonTemplateResponse> AxlNetClient.AXLPort31.applyPhoneButtonTemplateAsync(AxlNetClient.applyPhoneButtonTemplateRequest request)
        {
            return base.Channel.applyPhoneButtonTemplateAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneButtonTemplateResponse> applyPhoneButtonTemplateAsync(AxlNetClient.NameAndGUIDRequest applyPhoneButtonTemplate)
        {
            AxlNetClient.applyPhoneButtonTemplateRequest inValue = new AxlNetClient.applyPhoneButtonTemplateRequest();
            inValue.applyPhoneButtonTemplate = applyPhoneButtonTemplate;
            return ((AxlNetClient.AXLPort31)(this)).applyPhoneButtonTemplateAsync(inValue);
        }
    }
}