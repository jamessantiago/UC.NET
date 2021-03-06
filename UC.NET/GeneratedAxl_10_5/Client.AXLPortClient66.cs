namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient66 _axlPortClient66;

        private static AXLPortClient66 axlPortClient66 => _axlPortClient66 == null ||
            _axlPortClient66.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient66 = LoadClient66()) : _axlPortClient66;

        private static AXLPortClient66 LoadClient66()
        {
            var client = new AXLPortClient66(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close66;
            OnAbort += Abort66;
            return client;
        }

        private static void Close66(object sender, System.EventArgs e)
        {
            _axlPortClient66.Close();
        }

        private static void Abort66(object sender, System.EventArgs e)
        {
            _axlPortClient66.Abort();
        }

        public AxlNetClient.StandardResponse updateSIPNormalizationScript(AxlNetClient.UpdateSIPNormalizationScriptReq updateSIPNormalizationScript1)
        {
            return axlPortClient66.updateSIPNormalizationScript(updateSIPNormalizationScript1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSIPNormalizationScriptResponse> updateSIPNormalizationScriptAsync(AxlNetClient.UpdateSIPNormalizationScriptReq updateSIPNormalizationScript)
        {
            return axlPortClient66.updateSIPNormalizationScriptAsync(updateSIPNormalizationScript);
        }

        public AxlNetClient.GetSIPNormalizationScriptRes getSIPNormalizationScript(AxlNetClient.GetSIPNormalizationScriptReq getSIPNormalizationScript1)
        {
            return axlPortClient66.getSIPNormalizationScript(getSIPNormalizationScript1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSIPNormalizationScriptResponse> getSIPNormalizationScriptAsync(AxlNetClient.GetSIPNormalizationScriptReq getSIPNormalizationScript)
        {
            return axlPortClient66.getSIPNormalizationScriptAsync(getSIPNormalizationScript);
        }

        public AxlNetClient.StandardResponse removeSIPNormalizationScript(AxlNetClient.NameAndGUIDRequest removeSIPNormalizationScript1)
        {
            return axlPortClient66.removeSIPNormalizationScript(removeSIPNormalizationScript1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSIPNormalizationScriptResponse> removeSIPNormalizationScriptAsync(AxlNetClient.NameAndGUIDRequest removeSIPNormalizationScript)
        {
            return axlPortClient66.removeSIPNormalizationScriptAsync(removeSIPNormalizationScript);
        }

        public AxlNetClient.ListSIPNormalizationScriptRes listSIPNormalizationScript(AxlNetClient.ListSIPNormalizationScriptReq listSIPNormalizationScript1)
        {
            return axlPortClient66.listSIPNormalizationScript(listSIPNormalizationScript1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSIPNormalizationScriptResponse> listSIPNormalizationScriptAsync(AxlNetClient.ListSIPNormalizationScriptReq listSIPNormalizationScript)
        {
            return axlPortClient66.listSIPNormalizationScriptAsync(listSIPNormalizationScript);
        }

        public AxlNetClient.StandardResponse addCustomUserField(AxlNetClient.AddCustomUserFieldReq addCustomUserField1)
        {
            return axlPortClient66.addCustomUserField(addCustomUserField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCustomUserFieldResponse> addCustomUserFieldAsync(AxlNetClient.AddCustomUserFieldReq addCustomUserField)
        {
            return axlPortClient66.addCustomUserFieldAsync(addCustomUserField);
        }

        public AxlNetClient.StandardResponse updateCustomUserField(AxlNetClient.UpdateCustomUserFieldReq updateCustomUserField1)
        {
            return axlPortClient66.updateCustomUserField(updateCustomUserField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCustomUserFieldResponse> updateCustomUserFieldAsync(AxlNetClient.UpdateCustomUserFieldReq updateCustomUserField)
        {
            return axlPortClient66.updateCustomUserFieldAsync(updateCustomUserField);
        }

        public AxlNetClient.GetCustomUserFieldRes getCustomUserField(AxlNetClient.GetCustomUserFieldReq getCustomUserField1)
        {
            return axlPortClient66.getCustomUserField(getCustomUserField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCustomUserFieldResponse> getCustomUserFieldAsync(AxlNetClient.GetCustomUserFieldReq getCustomUserField)
        {
            return axlPortClient66.getCustomUserFieldAsync(getCustomUserField);
        }

        public AxlNetClient.StandardResponse removeCustomUserField(AxlNetClient.RemoveCustomUserFieldReq removeCustomUserField1)
        {
            return axlPortClient66.removeCustomUserField(removeCustomUserField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCustomUserFieldResponse> removeCustomUserFieldAsync(AxlNetClient.RemoveCustomUserFieldReq removeCustomUserField)
        {
            return axlPortClient66.removeCustomUserFieldAsync(removeCustomUserField);
        }

        public AxlNetClient.ListCustomUserFieldRes listCustomUserField(AxlNetClient.ListCustomUserFieldReq listCustomUserField1)
        {
            return axlPortClient66.listCustomUserField(listCustomUserField1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCustomUserFieldResponse> listCustomUserFieldAsync(AxlNetClient.ListCustomUserFieldReq listCustomUserField)
        {
            return axlPortClient66.listCustomUserFieldAsync(listCustomUserField);
        }

        public AxlNetClient.StandardResponse addGatewaySccpEndpoints(AxlNetClient.AddGatewaySccpEndpointsReq addGatewaySccpEndpoints1)
        {
            return axlPortClient66.addGatewaySccpEndpoints(addGatewaySccpEndpoints1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewaySccpEndpointsResponse> addGatewaySccpEndpointsAsync(AxlNetClient.AddGatewaySccpEndpointsReq addGatewaySccpEndpoints)
        {
            return axlPortClient66.addGatewaySccpEndpointsAsync(addGatewaySccpEndpoints);
        }

        public AxlNetClient.StandardResponse updateGatewaySccpEndpoints(AxlNetClient.UpdateGatewaySccpEndpointsReq updateGatewaySccpEndpoints1)
        {
            return axlPortClient66.updateGatewaySccpEndpoints(updateGatewaySccpEndpoints1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewaySccpEndpointsResponse> updateGatewaySccpEndpointsAsync(AxlNetClient.UpdateGatewaySccpEndpointsReq updateGatewaySccpEndpoints)
        {
            return axlPortClient66.updateGatewaySccpEndpointsAsync(updateGatewaySccpEndpoints);
        }

        public AxlNetClient.GetGatewaySccpEndpointsRes getGatewaySccpEndpoints(AxlNetClient.GetGatewaySccpEndpointsReq getGatewaySccpEndpoints1)
        {
            return axlPortClient66.getGatewaySccpEndpoints(getGatewaySccpEndpoints1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewaySccpEndpointsResponse> getGatewaySccpEndpointsAsync(AxlNetClient.GetGatewaySccpEndpointsReq getGatewaySccpEndpoints)
        {
            return axlPortClient66.getGatewaySccpEndpointsAsync(getGatewaySccpEndpoints);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort66
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSIPNormalizationScript", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSIPNormalizationScriptResponse updateSIPNormalizationScript(AxlNetClient.updateSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSIPNormalizationScript", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSIPNormalizationScriptResponse> updateSIPNormalizationScriptAsync(AxlNetClient.updateSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSIPNormalizationScript", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSIPNormalizationScriptResponse getSIPNormalizationScript(AxlNetClient.getSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSIPNormalizationScript", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSIPNormalizationScriptResponse> getSIPNormalizationScriptAsync(AxlNetClient.getSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSIPNormalizationScript", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSIPNormalizationScriptResponse removeSIPNormalizationScript(AxlNetClient.removeSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSIPNormalizationScript", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSIPNormalizationScriptResponse> removeSIPNormalizationScriptAsync(AxlNetClient.removeSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSIPNormalizationScript", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSIPNormalizationScriptResponse listSIPNormalizationScript(AxlNetClient.listSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSIPNormalizationScript", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSIPNormalizationScriptResponse> listSIPNormalizationScriptAsync(AxlNetClient.listSIPNormalizationScriptRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCustomUserField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCustomUserFieldResponse addCustomUserField(AxlNetClient.addCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCustomUserField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCustomUserFieldResponse> addCustomUserFieldAsync(AxlNetClient.addCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCustomUserField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCustomUserFieldResponse updateCustomUserField(AxlNetClient.updateCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCustomUserField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCustomUserFieldResponse> updateCustomUserFieldAsync(AxlNetClient.updateCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCustomUserField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCustomUserFieldResponse getCustomUserField(AxlNetClient.getCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCustomUserField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCustomUserFieldResponse> getCustomUserFieldAsync(AxlNetClient.getCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCustomUserField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCustomUserFieldResponse removeCustomUserField(AxlNetClient.removeCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCustomUserField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCustomUserFieldResponse> removeCustomUserFieldAsync(AxlNetClient.removeCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCustomUserField", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCustomUserFieldResponse listCustomUserField(AxlNetClient.listCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCustomUserField", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCustomUserFieldResponse> listCustomUserFieldAsync(AxlNetClient.listCustomUserFieldRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewaySccpEndpoints", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addGatewaySccpEndpointsResponse addGatewaySccpEndpoints(AxlNetClient.addGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addGatewaySccpEndpoints", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addGatewaySccpEndpointsResponse> addGatewaySccpEndpointsAsync(AxlNetClient.addGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewaySccpEndpoints", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGatewaySccpEndpointsResponse updateGatewaySccpEndpoints(AxlNetClient.updateGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGatewaySccpEndpoints", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewaySccpEndpointsResponse> updateGatewaySccpEndpointsAsync(AxlNetClient.updateGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewaySccpEndpoints", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGatewaySccpEndpointsResponse getGatewaySccpEndpoints(AxlNetClient.getGatewaySccpEndpointsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGatewaySccpEndpoints", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGatewaySccpEndpointsResponse> getGatewaySccpEndpointsAsync(AxlNetClient.getGatewaySccpEndpointsRequest request);
    }

    public class AXLPortClient66 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort66>, AxlNetClient.AXLPort66
    {
        public AXLPortClient66(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSIPNormalizationScriptResponse AxlNetClient.AXLPort66.updateSIPNormalizationScript(AxlNetClient.updateSIPNormalizationScriptRequest request)
        {
            return base.Channel.updateSIPNormalizationScript(request);
        }

        public AxlNetClient.StandardResponse updateSIPNormalizationScript(AxlNetClient.UpdateSIPNormalizationScriptReq updateSIPNormalizationScript1)
        {
            AxlNetClient.updateSIPNormalizationScriptRequest inValue = new AxlNetClient.updateSIPNormalizationScriptRequest();
            inValue.updateSIPNormalizationScript = updateSIPNormalizationScript1;
            AxlNetClient.updateSIPNormalizationScriptResponse retVal = ((AxlNetClient.AXLPort66)(this)).updateSIPNormalizationScript(inValue);
            return retVal.updateSIPNormalizationScriptResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSIPNormalizationScriptResponse> AxlNetClient.AXLPort66.updateSIPNormalizationScriptAsync(AxlNetClient.updateSIPNormalizationScriptRequest request)
        {
            return base.Channel.updateSIPNormalizationScriptAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSIPNormalizationScriptResponse> updateSIPNormalizationScriptAsync(AxlNetClient.UpdateSIPNormalizationScriptReq updateSIPNormalizationScript)
        {
            AxlNetClient.updateSIPNormalizationScriptRequest inValue = new AxlNetClient.updateSIPNormalizationScriptRequest();
            inValue.updateSIPNormalizationScript = updateSIPNormalizationScript;
            return ((AxlNetClient.AXLPort66)(this)).updateSIPNormalizationScriptAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSIPNormalizationScriptResponse AxlNetClient.AXLPort66.getSIPNormalizationScript(AxlNetClient.getSIPNormalizationScriptRequest request)
        {
            return base.Channel.getSIPNormalizationScript(request);
        }

        public AxlNetClient.GetSIPNormalizationScriptRes getSIPNormalizationScript(AxlNetClient.GetSIPNormalizationScriptReq getSIPNormalizationScript1)
        {
            AxlNetClient.getSIPNormalizationScriptRequest inValue = new AxlNetClient.getSIPNormalizationScriptRequest();
            inValue.getSIPNormalizationScript = getSIPNormalizationScript1;
            AxlNetClient.getSIPNormalizationScriptResponse retVal = ((AxlNetClient.AXLPort66)(this)).getSIPNormalizationScript(inValue);
            return retVal.getSIPNormalizationScriptResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSIPNormalizationScriptResponse> AxlNetClient.AXLPort66.getSIPNormalizationScriptAsync(AxlNetClient.getSIPNormalizationScriptRequest request)
        {
            return base.Channel.getSIPNormalizationScriptAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSIPNormalizationScriptResponse> getSIPNormalizationScriptAsync(AxlNetClient.GetSIPNormalizationScriptReq getSIPNormalizationScript)
        {
            AxlNetClient.getSIPNormalizationScriptRequest inValue = new AxlNetClient.getSIPNormalizationScriptRequest();
            inValue.getSIPNormalizationScript = getSIPNormalizationScript;
            return ((AxlNetClient.AXLPort66)(this)).getSIPNormalizationScriptAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSIPNormalizationScriptResponse AxlNetClient.AXLPort66.removeSIPNormalizationScript(AxlNetClient.removeSIPNormalizationScriptRequest request)
        {
            return base.Channel.removeSIPNormalizationScript(request);
        }

        public AxlNetClient.StandardResponse removeSIPNormalizationScript(AxlNetClient.NameAndGUIDRequest removeSIPNormalizationScript1)
        {
            AxlNetClient.removeSIPNormalizationScriptRequest inValue = new AxlNetClient.removeSIPNormalizationScriptRequest();
            inValue.removeSIPNormalizationScript = removeSIPNormalizationScript1;
            AxlNetClient.removeSIPNormalizationScriptResponse retVal = ((AxlNetClient.AXLPort66)(this)).removeSIPNormalizationScript(inValue);
            return retVal.removeSIPNormalizationScriptResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSIPNormalizationScriptResponse> AxlNetClient.AXLPort66.removeSIPNormalizationScriptAsync(AxlNetClient.removeSIPNormalizationScriptRequest request)
        {
            return base.Channel.removeSIPNormalizationScriptAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSIPNormalizationScriptResponse> removeSIPNormalizationScriptAsync(AxlNetClient.NameAndGUIDRequest removeSIPNormalizationScript)
        {
            AxlNetClient.removeSIPNormalizationScriptRequest inValue = new AxlNetClient.removeSIPNormalizationScriptRequest();
            inValue.removeSIPNormalizationScript = removeSIPNormalizationScript;
            return ((AxlNetClient.AXLPort66)(this)).removeSIPNormalizationScriptAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSIPNormalizationScriptResponse AxlNetClient.AXLPort66.listSIPNormalizationScript(AxlNetClient.listSIPNormalizationScriptRequest request)
        {
            return base.Channel.listSIPNormalizationScript(request);
        }

        public AxlNetClient.ListSIPNormalizationScriptRes listSIPNormalizationScript(AxlNetClient.ListSIPNormalizationScriptReq listSIPNormalizationScript1)
        {
            AxlNetClient.listSIPNormalizationScriptRequest inValue = new AxlNetClient.listSIPNormalizationScriptRequest();
            inValue.listSIPNormalizationScript = listSIPNormalizationScript1;
            AxlNetClient.listSIPNormalizationScriptResponse retVal = ((AxlNetClient.AXLPort66)(this)).listSIPNormalizationScript(inValue);
            return retVal.listSIPNormalizationScriptResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSIPNormalizationScriptResponse> AxlNetClient.AXLPort66.listSIPNormalizationScriptAsync(AxlNetClient.listSIPNormalizationScriptRequest request)
        {
            return base.Channel.listSIPNormalizationScriptAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSIPNormalizationScriptResponse> listSIPNormalizationScriptAsync(AxlNetClient.ListSIPNormalizationScriptReq listSIPNormalizationScript)
        {
            AxlNetClient.listSIPNormalizationScriptRequest inValue = new AxlNetClient.listSIPNormalizationScriptRequest();
            inValue.listSIPNormalizationScript = listSIPNormalizationScript;
            return ((AxlNetClient.AXLPort66)(this)).listSIPNormalizationScriptAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCustomUserFieldResponse AxlNetClient.AXLPort66.addCustomUserField(AxlNetClient.addCustomUserFieldRequest request)
        {
            return base.Channel.addCustomUserField(request);
        }

        public AxlNetClient.StandardResponse addCustomUserField(AxlNetClient.AddCustomUserFieldReq addCustomUserField1)
        {
            AxlNetClient.addCustomUserFieldRequest inValue = new AxlNetClient.addCustomUserFieldRequest();
            inValue.addCustomUserField = addCustomUserField1;
            AxlNetClient.addCustomUserFieldResponse retVal = ((AxlNetClient.AXLPort66)(this)).addCustomUserField(inValue);
            return retVal.addCustomUserFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCustomUserFieldResponse> AxlNetClient.AXLPort66.addCustomUserFieldAsync(AxlNetClient.addCustomUserFieldRequest request)
        {
            return base.Channel.addCustomUserFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCustomUserFieldResponse> addCustomUserFieldAsync(AxlNetClient.AddCustomUserFieldReq addCustomUserField)
        {
            AxlNetClient.addCustomUserFieldRequest inValue = new AxlNetClient.addCustomUserFieldRequest();
            inValue.addCustomUserField = addCustomUserField;
            return ((AxlNetClient.AXLPort66)(this)).addCustomUserFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCustomUserFieldResponse AxlNetClient.AXLPort66.updateCustomUserField(AxlNetClient.updateCustomUserFieldRequest request)
        {
            return base.Channel.updateCustomUserField(request);
        }

        public AxlNetClient.StandardResponse updateCustomUserField(AxlNetClient.UpdateCustomUserFieldReq updateCustomUserField1)
        {
            AxlNetClient.updateCustomUserFieldRequest inValue = new AxlNetClient.updateCustomUserFieldRequest();
            inValue.updateCustomUserField = updateCustomUserField1;
            AxlNetClient.updateCustomUserFieldResponse retVal = ((AxlNetClient.AXLPort66)(this)).updateCustomUserField(inValue);
            return retVal.updateCustomUserFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCustomUserFieldResponse> AxlNetClient.AXLPort66.updateCustomUserFieldAsync(AxlNetClient.updateCustomUserFieldRequest request)
        {
            return base.Channel.updateCustomUserFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCustomUserFieldResponse> updateCustomUserFieldAsync(AxlNetClient.UpdateCustomUserFieldReq updateCustomUserField)
        {
            AxlNetClient.updateCustomUserFieldRequest inValue = new AxlNetClient.updateCustomUserFieldRequest();
            inValue.updateCustomUserField = updateCustomUserField;
            return ((AxlNetClient.AXLPort66)(this)).updateCustomUserFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCustomUserFieldResponse AxlNetClient.AXLPort66.getCustomUserField(AxlNetClient.getCustomUserFieldRequest request)
        {
            return base.Channel.getCustomUserField(request);
        }

        public AxlNetClient.GetCustomUserFieldRes getCustomUserField(AxlNetClient.GetCustomUserFieldReq getCustomUserField1)
        {
            AxlNetClient.getCustomUserFieldRequest inValue = new AxlNetClient.getCustomUserFieldRequest();
            inValue.getCustomUserField = getCustomUserField1;
            AxlNetClient.getCustomUserFieldResponse retVal = ((AxlNetClient.AXLPort66)(this)).getCustomUserField(inValue);
            return retVal.getCustomUserFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCustomUserFieldResponse> AxlNetClient.AXLPort66.getCustomUserFieldAsync(AxlNetClient.getCustomUserFieldRequest request)
        {
            return base.Channel.getCustomUserFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCustomUserFieldResponse> getCustomUserFieldAsync(AxlNetClient.GetCustomUserFieldReq getCustomUserField)
        {
            AxlNetClient.getCustomUserFieldRequest inValue = new AxlNetClient.getCustomUserFieldRequest();
            inValue.getCustomUserField = getCustomUserField;
            return ((AxlNetClient.AXLPort66)(this)).getCustomUserFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCustomUserFieldResponse AxlNetClient.AXLPort66.removeCustomUserField(AxlNetClient.removeCustomUserFieldRequest request)
        {
            return base.Channel.removeCustomUserField(request);
        }

        public AxlNetClient.StandardResponse removeCustomUserField(AxlNetClient.RemoveCustomUserFieldReq removeCustomUserField1)
        {
            AxlNetClient.removeCustomUserFieldRequest inValue = new AxlNetClient.removeCustomUserFieldRequest();
            inValue.removeCustomUserField = removeCustomUserField1;
            AxlNetClient.removeCustomUserFieldResponse retVal = ((AxlNetClient.AXLPort66)(this)).removeCustomUserField(inValue);
            return retVal.removeCustomUserFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCustomUserFieldResponse> AxlNetClient.AXLPort66.removeCustomUserFieldAsync(AxlNetClient.removeCustomUserFieldRequest request)
        {
            return base.Channel.removeCustomUserFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCustomUserFieldResponse> removeCustomUserFieldAsync(AxlNetClient.RemoveCustomUserFieldReq removeCustomUserField)
        {
            AxlNetClient.removeCustomUserFieldRequest inValue = new AxlNetClient.removeCustomUserFieldRequest();
            inValue.removeCustomUserField = removeCustomUserField;
            return ((AxlNetClient.AXLPort66)(this)).removeCustomUserFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCustomUserFieldResponse AxlNetClient.AXLPort66.listCustomUserField(AxlNetClient.listCustomUserFieldRequest request)
        {
            return base.Channel.listCustomUserField(request);
        }

        public AxlNetClient.ListCustomUserFieldRes listCustomUserField(AxlNetClient.ListCustomUserFieldReq listCustomUserField1)
        {
            AxlNetClient.listCustomUserFieldRequest inValue = new AxlNetClient.listCustomUserFieldRequest();
            inValue.listCustomUserField = listCustomUserField1;
            AxlNetClient.listCustomUserFieldResponse retVal = ((AxlNetClient.AXLPort66)(this)).listCustomUserField(inValue);
            return retVal.listCustomUserFieldResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCustomUserFieldResponse> AxlNetClient.AXLPort66.listCustomUserFieldAsync(AxlNetClient.listCustomUserFieldRequest request)
        {
            return base.Channel.listCustomUserFieldAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCustomUserFieldResponse> listCustomUserFieldAsync(AxlNetClient.ListCustomUserFieldReq listCustomUserField)
        {
            AxlNetClient.listCustomUserFieldRequest inValue = new AxlNetClient.listCustomUserFieldRequest();
            inValue.listCustomUserField = listCustomUserField;
            return ((AxlNetClient.AXLPort66)(this)).listCustomUserFieldAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addGatewaySccpEndpointsResponse AxlNetClient.AXLPort66.addGatewaySccpEndpoints(AxlNetClient.addGatewaySccpEndpointsRequest request)
        {
            return base.Channel.addGatewaySccpEndpoints(request);
        }

        public AxlNetClient.StandardResponse addGatewaySccpEndpoints(AxlNetClient.AddGatewaySccpEndpointsReq addGatewaySccpEndpoints1)
        {
            AxlNetClient.addGatewaySccpEndpointsRequest inValue = new AxlNetClient.addGatewaySccpEndpointsRequest();
            inValue.addGatewaySccpEndpoints = addGatewaySccpEndpoints1;
            AxlNetClient.addGatewaySccpEndpointsResponse retVal = ((AxlNetClient.AXLPort66)(this)).addGatewaySccpEndpoints(inValue);
            return retVal.addGatewaySccpEndpointsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addGatewaySccpEndpointsResponse> AxlNetClient.AXLPort66.addGatewaySccpEndpointsAsync(AxlNetClient.addGatewaySccpEndpointsRequest request)
        {
            return base.Channel.addGatewaySccpEndpointsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addGatewaySccpEndpointsResponse> addGatewaySccpEndpointsAsync(AxlNetClient.AddGatewaySccpEndpointsReq addGatewaySccpEndpoints)
        {
            AxlNetClient.addGatewaySccpEndpointsRequest inValue = new AxlNetClient.addGatewaySccpEndpointsRequest();
            inValue.addGatewaySccpEndpoints = addGatewaySccpEndpoints;
            return ((AxlNetClient.AXLPort66)(this)).addGatewaySccpEndpointsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGatewaySccpEndpointsResponse AxlNetClient.AXLPort66.updateGatewaySccpEndpoints(AxlNetClient.updateGatewaySccpEndpointsRequest request)
        {
            return base.Channel.updateGatewaySccpEndpoints(request);
        }

        public AxlNetClient.StandardResponse updateGatewaySccpEndpoints(AxlNetClient.UpdateGatewaySccpEndpointsReq updateGatewaySccpEndpoints1)
        {
            AxlNetClient.updateGatewaySccpEndpointsRequest inValue = new AxlNetClient.updateGatewaySccpEndpointsRequest();
            inValue.updateGatewaySccpEndpoints = updateGatewaySccpEndpoints1;
            AxlNetClient.updateGatewaySccpEndpointsResponse retVal = ((AxlNetClient.AXLPort66)(this)).updateGatewaySccpEndpoints(inValue);
            return retVal.updateGatewaySccpEndpointsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGatewaySccpEndpointsResponse> AxlNetClient.AXLPort66.updateGatewaySccpEndpointsAsync(AxlNetClient.updateGatewaySccpEndpointsRequest request)
        {
            return base.Channel.updateGatewaySccpEndpointsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGatewaySccpEndpointsResponse> updateGatewaySccpEndpointsAsync(AxlNetClient.UpdateGatewaySccpEndpointsReq updateGatewaySccpEndpoints)
        {
            AxlNetClient.updateGatewaySccpEndpointsRequest inValue = new AxlNetClient.updateGatewaySccpEndpointsRequest();
            inValue.updateGatewaySccpEndpoints = updateGatewaySccpEndpoints;
            return ((AxlNetClient.AXLPort66)(this)).updateGatewaySccpEndpointsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGatewaySccpEndpointsResponse AxlNetClient.AXLPort66.getGatewaySccpEndpoints(AxlNetClient.getGatewaySccpEndpointsRequest request)
        {
            return base.Channel.getGatewaySccpEndpoints(request);
        }

        public AxlNetClient.GetGatewaySccpEndpointsRes getGatewaySccpEndpoints(AxlNetClient.GetGatewaySccpEndpointsReq getGatewaySccpEndpoints1)
        {
            AxlNetClient.getGatewaySccpEndpointsRequest inValue = new AxlNetClient.getGatewaySccpEndpointsRequest();
            inValue.getGatewaySccpEndpoints = getGatewaySccpEndpoints1;
            AxlNetClient.getGatewaySccpEndpointsResponse retVal = ((AxlNetClient.AXLPort66)(this)).getGatewaySccpEndpoints(inValue);
            return retVal.getGatewaySccpEndpointsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGatewaySccpEndpointsResponse> AxlNetClient.AXLPort66.getGatewaySccpEndpointsAsync(AxlNetClient.getGatewaySccpEndpointsRequest request)
        {
            return base.Channel.getGatewaySccpEndpointsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGatewaySccpEndpointsResponse> getGatewaySccpEndpointsAsync(AxlNetClient.GetGatewaySccpEndpointsReq getGatewaySccpEndpoints)
        {
            AxlNetClient.getGatewaySccpEndpointsRequest inValue = new AxlNetClient.getGatewaySccpEndpointsRequest();
            inValue.getGatewaySccpEndpoints = getGatewaySccpEndpoints;
            return ((AxlNetClient.AXLPort66)(this)).getGatewaySccpEndpointsAsync(inValue);
        }
    }
}