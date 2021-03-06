namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient51 _axlPortClient51;

        private static AXLPortClient51 axlPortClient51 => _axlPortClient51 == null ||
            _axlPortClient51.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient51 = LoadClient51()) : _axlPortClient51;

        private static AXLPortClient51 LoadClient51()
        {
            var client = new AXLPortClient51(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close51;
            OnAbort += Abort51;
            return client;
        }

        private static void Close51(object sender, System.EventArgs e)
        {
            _axlPortClient51.Close();
        }

        private static void Abort51(object sender, System.EventArgs e)
        {
            _axlPortClient51.Abort();
        }

        public AxlNetClient.StandardResponse updateGeoLocationPolicy(AxlNetClient.UpdateGeoLocationPolicyReq updateGeoLocationPolicy1)
        {
            return axlPortClient51.updateGeoLocationPolicy(updateGeoLocationPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationPolicyResponse> updateGeoLocationPolicyAsync(AxlNetClient.UpdateGeoLocationPolicyReq updateGeoLocationPolicy)
        {
            return axlPortClient51.updateGeoLocationPolicyAsync(updateGeoLocationPolicy);
        }

        public AxlNetClient.GetGeoLocationPolicyRes getGeoLocationPolicy(AxlNetClient.GetGeoLocationPolicyReq getGeoLocationPolicy1)
        {
            return axlPortClient51.getGeoLocationPolicy(getGeoLocationPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationPolicyResponse> getGeoLocationPolicyAsync(AxlNetClient.GetGeoLocationPolicyReq getGeoLocationPolicy)
        {
            return axlPortClient51.getGeoLocationPolicyAsync(getGeoLocationPolicy);
        }

        public AxlNetClient.StandardResponse removeGeoLocationPolicy(AxlNetClient.NameAndGUIDRequest removeGeoLocationPolicy1)
        {
            return axlPortClient51.removeGeoLocationPolicy(removeGeoLocationPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationPolicyResponse> removeGeoLocationPolicyAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocationPolicy)
        {
            return axlPortClient51.removeGeoLocationPolicyAsync(removeGeoLocationPolicy);
        }

        public AxlNetClient.ListGeoLocationPolicyRes listGeoLocationPolicy(AxlNetClient.ListGeoLocationPolicyReq listGeoLocationPolicy1)
        {
            return axlPortClient51.listGeoLocationPolicy(listGeoLocationPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationPolicyResponse> listGeoLocationPolicyAsync(AxlNetClient.ListGeoLocationPolicyReq listGeoLocationPolicy)
        {
            return axlPortClient51.listGeoLocationPolicyAsync(listGeoLocationPolicy);
        }

        public AxlNetClient.StandardResponse addSipTrunk(AxlNetClient.AddSipTrunkReq addSipTrunk1)
        {
            return axlPortClient51.addSipTrunk(addSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipTrunkResponse> addSipTrunkAsync(AxlNetClient.AddSipTrunkReq addSipTrunk)
        {
            return axlPortClient51.addSipTrunkAsync(addSipTrunk);
        }

        public AxlNetClient.StandardResponse updateSipTrunk(AxlNetClient.UpdateSipTrunkReq updateSipTrunk1)
        {
            return axlPortClient51.updateSipTrunk(updateSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkResponse> updateSipTrunkAsync(AxlNetClient.UpdateSipTrunkReq updateSipTrunk)
        {
            return axlPortClient51.updateSipTrunkAsync(updateSipTrunk);
        }

        public AxlNetClient.GetSipTrunkRes getSipTrunk(AxlNetClient.GetSipTrunkReq getSipTrunk1)
        {
            return axlPortClient51.getSipTrunk(getSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipTrunkResponse> getSipTrunkAsync(AxlNetClient.GetSipTrunkReq getSipTrunk)
        {
            return axlPortClient51.getSipTrunkAsync(getSipTrunk);
        }

        public AxlNetClient.StandardResponse removeSipTrunk(AxlNetClient.NameAndGUIDRequest removeSipTrunk1)
        {
            return axlPortClient51.removeSipTrunk(removeSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkResponse> removeSipTrunkAsync(AxlNetClient.NameAndGUIDRequest removeSipTrunk)
        {
            return axlPortClient51.removeSipTrunkAsync(removeSipTrunk);
        }

        public AxlNetClient.ListSipTrunkRes listSipTrunk(AxlNetClient.ListSipTrunkReq listSipTrunk1)
        {
            return axlPortClient51.listSipTrunk(listSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipTrunkResponse> listSipTrunkAsync(AxlNetClient.ListSipTrunkReq listSipTrunk)
        {
            return axlPortClient51.listSipTrunkAsync(listSipTrunk);
        }

        public AxlNetClient.StandardResponse resetSipTrunk(AxlNetClient.NameAndGUIDRequest resetSipTrunk1)
        {
            return axlPortClient51.resetSipTrunk(resetSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkResponse> resetSipTrunkAsync(AxlNetClient.NameAndGUIDRequest resetSipTrunk)
        {
            return axlPortClient51.resetSipTrunkAsync(resetSipTrunk);
        }

        public AxlNetClient.StandardResponse restartSipTrunk(AxlNetClient.NameAndGUIDRequest restartSipTrunk1)
        {
            return axlPortClient51.restartSipTrunk(restartSipTrunk1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSipTrunkResponse> restartSipTrunkAsync(AxlNetClient.NameAndGUIDRequest restartSipTrunk)
        {
            return axlPortClient51.restartSipTrunkAsync(restartSipTrunk);
        }

        public AxlNetClient.StandardResponse updateRegionMatrix(AxlNetClient.UpdateRegionMatrixReq updateRegionMatrix1)
        {
            return axlPortClient51.updateRegionMatrix(updateRegionMatrix1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRegionMatrixResponse> updateRegionMatrixAsync(AxlNetClient.UpdateRegionMatrixReq updateRegionMatrix)
        {
            return axlPortClient51.updateRegionMatrixAsync(updateRegionMatrix);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort51
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocationPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateGeoLocationPolicyResponse updateGeoLocationPolicy(AxlNetClient.updateGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateGeoLocationPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationPolicyResponse> updateGeoLocationPolicyAsync(AxlNetClient.updateGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocationPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getGeoLocationPolicyResponse getGeoLocationPolicy(AxlNetClient.getGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getGeoLocationPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationPolicyResponse> getGeoLocationPolicyAsync(AxlNetClient.getGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocationPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeGeoLocationPolicyResponse removeGeoLocationPolicy(AxlNetClient.removeGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeGeoLocationPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationPolicyResponse> removeGeoLocationPolicyAsync(AxlNetClient.removeGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocationPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listGeoLocationPolicyResponse listGeoLocationPolicy(AxlNetClient.listGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listGeoLocationPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationPolicyResponse> listGeoLocationPolicyAsync(AxlNetClient.listGeoLocationPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSipTrunkResponse addSipTrunk(AxlNetClient.addSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSipTrunkResponse> addSipTrunkAsync(AxlNetClient.addSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSipTrunkResponse updateSipTrunk(AxlNetClient.updateSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkResponse> updateSipTrunkAsync(AxlNetClient.updateSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSipTrunkResponse getSipTrunk(AxlNetClient.getSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSipTrunkResponse> getSipTrunkAsync(AxlNetClient.getSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSipTrunkResponse removeSipTrunk(AxlNetClient.removeSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkResponse> removeSipTrunkAsync(AxlNetClient.removeSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipTrunkResponse listSipTrunk(AxlNetClient.listSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipTrunkResponse> listSipTrunkAsync(AxlNetClient.listSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetSipTrunkResponse resetSipTrunk(AxlNetClient.resetSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkResponse> resetSipTrunkAsync(AxlNetClient.resetSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSipTrunk", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartSipTrunkResponse restartSipTrunk(AxlNetClient.restartSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSipTrunk", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartSipTrunkResponse> restartSipTrunkAsync(AxlNetClient.restartSipTrunkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRegionMatrix", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRegionMatrixResponse updateRegionMatrix(AxlNetClient.updateRegionMatrixRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRegionMatrix", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRegionMatrixResponse> updateRegionMatrixAsync(AxlNetClient.updateRegionMatrixRequest request);
    }

    public class AXLPortClient51 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort51>, AxlNetClient.AXLPort51
    {
        public AXLPortClient51(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateGeoLocationPolicyResponse AxlNetClient.AXLPort51.updateGeoLocationPolicy(AxlNetClient.updateGeoLocationPolicyRequest request)
        {
            return base.Channel.updateGeoLocationPolicy(request);
        }

        public AxlNetClient.StandardResponse updateGeoLocationPolicy(AxlNetClient.UpdateGeoLocationPolicyReq updateGeoLocationPolicy1)
        {
            AxlNetClient.updateGeoLocationPolicyRequest inValue = new AxlNetClient.updateGeoLocationPolicyRequest();
            inValue.updateGeoLocationPolicy = updateGeoLocationPolicy1;
            AxlNetClient.updateGeoLocationPolicyResponse retVal = ((AxlNetClient.AXLPort51)(this)).updateGeoLocationPolicy(inValue);
            return retVal.updateGeoLocationPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationPolicyResponse> AxlNetClient.AXLPort51.updateGeoLocationPolicyAsync(AxlNetClient.updateGeoLocationPolicyRequest request)
        {
            return base.Channel.updateGeoLocationPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateGeoLocationPolicyResponse> updateGeoLocationPolicyAsync(AxlNetClient.UpdateGeoLocationPolicyReq updateGeoLocationPolicy)
        {
            AxlNetClient.updateGeoLocationPolicyRequest inValue = new AxlNetClient.updateGeoLocationPolicyRequest();
            inValue.updateGeoLocationPolicy = updateGeoLocationPolicy;
            return ((AxlNetClient.AXLPort51)(this)).updateGeoLocationPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getGeoLocationPolicyResponse AxlNetClient.AXLPort51.getGeoLocationPolicy(AxlNetClient.getGeoLocationPolicyRequest request)
        {
            return base.Channel.getGeoLocationPolicy(request);
        }

        public AxlNetClient.GetGeoLocationPolicyRes getGeoLocationPolicy(AxlNetClient.GetGeoLocationPolicyReq getGeoLocationPolicy1)
        {
            AxlNetClient.getGeoLocationPolicyRequest inValue = new AxlNetClient.getGeoLocationPolicyRequest();
            inValue.getGeoLocationPolicy = getGeoLocationPolicy1;
            AxlNetClient.getGeoLocationPolicyResponse retVal = ((AxlNetClient.AXLPort51)(this)).getGeoLocationPolicy(inValue);
            return retVal.getGeoLocationPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getGeoLocationPolicyResponse> AxlNetClient.AXLPort51.getGeoLocationPolicyAsync(AxlNetClient.getGeoLocationPolicyRequest request)
        {
            return base.Channel.getGeoLocationPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getGeoLocationPolicyResponse> getGeoLocationPolicyAsync(AxlNetClient.GetGeoLocationPolicyReq getGeoLocationPolicy)
        {
            AxlNetClient.getGeoLocationPolicyRequest inValue = new AxlNetClient.getGeoLocationPolicyRequest();
            inValue.getGeoLocationPolicy = getGeoLocationPolicy;
            return ((AxlNetClient.AXLPort51)(this)).getGeoLocationPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeGeoLocationPolicyResponse AxlNetClient.AXLPort51.removeGeoLocationPolicy(AxlNetClient.removeGeoLocationPolicyRequest request)
        {
            return base.Channel.removeGeoLocationPolicy(request);
        }

        public AxlNetClient.StandardResponse removeGeoLocationPolicy(AxlNetClient.NameAndGUIDRequest removeGeoLocationPolicy1)
        {
            AxlNetClient.removeGeoLocationPolicyRequest inValue = new AxlNetClient.removeGeoLocationPolicyRequest();
            inValue.removeGeoLocationPolicy = removeGeoLocationPolicy1;
            AxlNetClient.removeGeoLocationPolicyResponse retVal = ((AxlNetClient.AXLPort51)(this)).removeGeoLocationPolicy(inValue);
            return retVal.removeGeoLocationPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationPolicyResponse> AxlNetClient.AXLPort51.removeGeoLocationPolicyAsync(AxlNetClient.removeGeoLocationPolicyRequest request)
        {
            return base.Channel.removeGeoLocationPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeGeoLocationPolicyResponse> removeGeoLocationPolicyAsync(AxlNetClient.NameAndGUIDRequest removeGeoLocationPolicy)
        {
            AxlNetClient.removeGeoLocationPolicyRequest inValue = new AxlNetClient.removeGeoLocationPolicyRequest();
            inValue.removeGeoLocationPolicy = removeGeoLocationPolicy;
            return ((AxlNetClient.AXLPort51)(this)).removeGeoLocationPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listGeoLocationPolicyResponse AxlNetClient.AXLPort51.listGeoLocationPolicy(AxlNetClient.listGeoLocationPolicyRequest request)
        {
            return base.Channel.listGeoLocationPolicy(request);
        }

        public AxlNetClient.ListGeoLocationPolicyRes listGeoLocationPolicy(AxlNetClient.ListGeoLocationPolicyReq listGeoLocationPolicy1)
        {
            AxlNetClient.listGeoLocationPolicyRequest inValue = new AxlNetClient.listGeoLocationPolicyRequest();
            inValue.listGeoLocationPolicy = listGeoLocationPolicy1;
            AxlNetClient.listGeoLocationPolicyResponse retVal = ((AxlNetClient.AXLPort51)(this)).listGeoLocationPolicy(inValue);
            return retVal.listGeoLocationPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listGeoLocationPolicyResponse> AxlNetClient.AXLPort51.listGeoLocationPolicyAsync(AxlNetClient.listGeoLocationPolicyRequest request)
        {
            return base.Channel.listGeoLocationPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listGeoLocationPolicyResponse> listGeoLocationPolicyAsync(AxlNetClient.ListGeoLocationPolicyReq listGeoLocationPolicy)
        {
            AxlNetClient.listGeoLocationPolicyRequest inValue = new AxlNetClient.listGeoLocationPolicyRequest();
            inValue.listGeoLocationPolicy = listGeoLocationPolicy;
            return ((AxlNetClient.AXLPort51)(this)).listGeoLocationPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSipTrunkResponse AxlNetClient.AXLPort51.addSipTrunk(AxlNetClient.addSipTrunkRequest request)
        {
            return base.Channel.addSipTrunk(request);
        }

        public AxlNetClient.StandardResponse addSipTrunk(AxlNetClient.AddSipTrunkReq addSipTrunk1)
        {
            AxlNetClient.addSipTrunkRequest inValue = new AxlNetClient.addSipTrunkRequest();
            inValue.addSipTrunk = addSipTrunk1;
            AxlNetClient.addSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).addSipTrunk(inValue);
            return retVal.addSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSipTrunkResponse> AxlNetClient.AXLPort51.addSipTrunkAsync(AxlNetClient.addSipTrunkRequest request)
        {
            return base.Channel.addSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSipTrunkResponse> addSipTrunkAsync(AxlNetClient.AddSipTrunkReq addSipTrunk)
        {
            AxlNetClient.addSipTrunkRequest inValue = new AxlNetClient.addSipTrunkRequest();
            inValue.addSipTrunk = addSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).addSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSipTrunkResponse AxlNetClient.AXLPort51.updateSipTrunk(AxlNetClient.updateSipTrunkRequest request)
        {
            return base.Channel.updateSipTrunk(request);
        }

        public AxlNetClient.StandardResponse updateSipTrunk(AxlNetClient.UpdateSipTrunkReq updateSipTrunk1)
        {
            AxlNetClient.updateSipTrunkRequest inValue = new AxlNetClient.updateSipTrunkRequest();
            inValue.updateSipTrunk = updateSipTrunk1;
            AxlNetClient.updateSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).updateSipTrunk(inValue);
            return retVal.updateSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkResponse> AxlNetClient.AXLPort51.updateSipTrunkAsync(AxlNetClient.updateSipTrunkRequest request)
        {
            return base.Channel.updateSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSipTrunkResponse> updateSipTrunkAsync(AxlNetClient.UpdateSipTrunkReq updateSipTrunk)
        {
            AxlNetClient.updateSipTrunkRequest inValue = new AxlNetClient.updateSipTrunkRequest();
            inValue.updateSipTrunk = updateSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).updateSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSipTrunkResponse AxlNetClient.AXLPort51.getSipTrunk(AxlNetClient.getSipTrunkRequest request)
        {
            return base.Channel.getSipTrunk(request);
        }

        public AxlNetClient.GetSipTrunkRes getSipTrunk(AxlNetClient.GetSipTrunkReq getSipTrunk1)
        {
            AxlNetClient.getSipTrunkRequest inValue = new AxlNetClient.getSipTrunkRequest();
            inValue.getSipTrunk = getSipTrunk1;
            AxlNetClient.getSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).getSipTrunk(inValue);
            return retVal.getSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSipTrunkResponse> AxlNetClient.AXLPort51.getSipTrunkAsync(AxlNetClient.getSipTrunkRequest request)
        {
            return base.Channel.getSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSipTrunkResponse> getSipTrunkAsync(AxlNetClient.GetSipTrunkReq getSipTrunk)
        {
            AxlNetClient.getSipTrunkRequest inValue = new AxlNetClient.getSipTrunkRequest();
            inValue.getSipTrunk = getSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).getSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSipTrunkResponse AxlNetClient.AXLPort51.removeSipTrunk(AxlNetClient.removeSipTrunkRequest request)
        {
            return base.Channel.removeSipTrunk(request);
        }

        public AxlNetClient.StandardResponse removeSipTrunk(AxlNetClient.NameAndGUIDRequest removeSipTrunk1)
        {
            AxlNetClient.removeSipTrunkRequest inValue = new AxlNetClient.removeSipTrunkRequest();
            inValue.removeSipTrunk = removeSipTrunk1;
            AxlNetClient.removeSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).removeSipTrunk(inValue);
            return retVal.removeSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkResponse> AxlNetClient.AXLPort51.removeSipTrunkAsync(AxlNetClient.removeSipTrunkRequest request)
        {
            return base.Channel.removeSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSipTrunkResponse> removeSipTrunkAsync(AxlNetClient.NameAndGUIDRequest removeSipTrunk)
        {
            AxlNetClient.removeSipTrunkRequest inValue = new AxlNetClient.removeSipTrunkRequest();
            inValue.removeSipTrunk = removeSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).removeSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipTrunkResponse AxlNetClient.AXLPort51.listSipTrunk(AxlNetClient.listSipTrunkRequest request)
        {
            return base.Channel.listSipTrunk(request);
        }

        public AxlNetClient.ListSipTrunkRes listSipTrunk(AxlNetClient.ListSipTrunkReq listSipTrunk1)
        {
            AxlNetClient.listSipTrunkRequest inValue = new AxlNetClient.listSipTrunkRequest();
            inValue.listSipTrunk = listSipTrunk1;
            AxlNetClient.listSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).listSipTrunk(inValue);
            return retVal.listSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipTrunkResponse> AxlNetClient.AXLPort51.listSipTrunkAsync(AxlNetClient.listSipTrunkRequest request)
        {
            return base.Channel.listSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipTrunkResponse> listSipTrunkAsync(AxlNetClient.ListSipTrunkReq listSipTrunk)
        {
            AxlNetClient.listSipTrunkRequest inValue = new AxlNetClient.listSipTrunkRequest();
            inValue.listSipTrunk = listSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).listSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetSipTrunkResponse AxlNetClient.AXLPort51.resetSipTrunk(AxlNetClient.resetSipTrunkRequest request)
        {
            return base.Channel.resetSipTrunk(request);
        }

        public AxlNetClient.StandardResponse resetSipTrunk(AxlNetClient.NameAndGUIDRequest resetSipTrunk1)
        {
            AxlNetClient.resetSipTrunkRequest inValue = new AxlNetClient.resetSipTrunkRequest();
            inValue.resetSipTrunk = resetSipTrunk1;
            AxlNetClient.resetSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).resetSipTrunk(inValue);
            return retVal.resetSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkResponse> AxlNetClient.AXLPort51.resetSipTrunkAsync(AxlNetClient.resetSipTrunkRequest request)
        {
            return base.Channel.resetSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkResponse> resetSipTrunkAsync(AxlNetClient.NameAndGUIDRequest resetSipTrunk)
        {
            AxlNetClient.resetSipTrunkRequest inValue = new AxlNetClient.resetSipTrunkRequest();
            inValue.resetSipTrunk = resetSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).resetSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartSipTrunkResponse AxlNetClient.AXLPort51.restartSipTrunk(AxlNetClient.restartSipTrunkRequest request)
        {
            return base.Channel.restartSipTrunk(request);
        }

        public AxlNetClient.StandardResponse restartSipTrunk(AxlNetClient.NameAndGUIDRequest restartSipTrunk1)
        {
            AxlNetClient.restartSipTrunkRequest inValue = new AxlNetClient.restartSipTrunkRequest();
            inValue.restartSipTrunk = restartSipTrunk1;
            AxlNetClient.restartSipTrunkResponse retVal = ((AxlNetClient.AXLPort51)(this)).restartSipTrunk(inValue);
            return retVal.restartSipTrunkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartSipTrunkResponse> AxlNetClient.AXLPort51.restartSipTrunkAsync(AxlNetClient.restartSipTrunkRequest request)
        {
            return base.Channel.restartSipTrunkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSipTrunkResponse> restartSipTrunkAsync(AxlNetClient.NameAndGUIDRequest restartSipTrunk)
        {
            AxlNetClient.restartSipTrunkRequest inValue = new AxlNetClient.restartSipTrunkRequest();
            inValue.restartSipTrunk = restartSipTrunk;
            return ((AxlNetClient.AXLPort51)(this)).restartSipTrunkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRegionMatrixResponse AxlNetClient.AXLPort51.updateRegionMatrix(AxlNetClient.updateRegionMatrixRequest request)
        {
            return base.Channel.updateRegionMatrix(request);
        }

        public AxlNetClient.StandardResponse updateRegionMatrix(AxlNetClient.UpdateRegionMatrixReq updateRegionMatrix1)
        {
            AxlNetClient.updateRegionMatrixRequest inValue = new AxlNetClient.updateRegionMatrixRequest();
            inValue.updateRegionMatrix = updateRegionMatrix1;
            AxlNetClient.updateRegionMatrixResponse retVal = ((AxlNetClient.AXLPort51)(this)).updateRegionMatrix(inValue);
            return retVal.updateRegionMatrixResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRegionMatrixResponse> AxlNetClient.AXLPort51.updateRegionMatrixAsync(AxlNetClient.updateRegionMatrixRequest request)
        {
            return base.Channel.updateRegionMatrixAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRegionMatrixResponse> updateRegionMatrixAsync(AxlNetClient.UpdateRegionMatrixReq updateRegionMatrix)
        {
            AxlNetClient.updateRegionMatrixRequest inValue = new AxlNetClient.updateRegionMatrixRequest();
            inValue.updateRegionMatrix = updateRegionMatrix;
            return ((AxlNetClient.AXLPort51)(this)).updateRegionMatrixAsync(inValue);
        }
    }
}