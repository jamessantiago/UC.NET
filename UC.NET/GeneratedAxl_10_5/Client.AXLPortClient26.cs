namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient26 _axlPortClient26;

        private static AXLPortClient26 axlPortClient26 => _axlPortClient26 == null ||
            _axlPortClient26.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient26 = LoadClient26()) : _axlPortClient26;

        private static AXLPortClient26 LoadClient26()
        {
            var client = new AXLPortClient26(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close26;
            OnAbort += Abort26;
            return client;
        }

        private static void Close26(object sender, System.EventArgs e)
        {
            _axlPortClient26.Close();
        }

        private static void Abort26(object sender, System.EventArgs e)
        {
            _axlPortClient26.Abort();
        }

        public AxlNetClient.StandardResponse updateSrst(AxlNetClient.UpdateSrstReq updateSrst1)
        {
            return axlPortClient26.updateSrst(updateSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSrstResponse> updateSrstAsync(AxlNetClient.UpdateSrstReq updateSrst)
        {
            return axlPortClient26.updateSrstAsync(updateSrst);
        }

        public AxlNetClient.GetSrstRes getSrst(AxlNetClient.GetSrstReq getSrst1)
        {
            return axlPortClient26.getSrst(getSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSrstResponse> getSrstAsync(AxlNetClient.GetSrstReq getSrst)
        {
            return axlPortClient26.getSrstAsync(getSrst);
        }

        public AxlNetClient.StandardResponse removeSrst(AxlNetClient.NameAndGUIDRequest removeSrst1)
        {
            return axlPortClient26.removeSrst(removeSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSrstResponse> removeSrstAsync(AxlNetClient.NameAndGUIDRequest removeSrst)
        {
            return axlPortClient26.removeSrstAsync(removeSrst);
        }

        public AxlNetClient.ListSrstRes listSrst(AxlNetClient.ListSrstReq listSrst1)
        {
            return axlPortClient26.listSrst(listSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSrstResponse> listSrstAsync(AxlNetClient.ListSrstReq listSrst)
        {
            return axlPortClient26.listSrstAsync(listSrst);
        }

        public AxlNetClient.StandardResponse resetSrst(AxlNetClient.NameAndGUIDRequest resetSrst1)
        {
            return axlPortClient26.resetSrst(resetSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSrstResponse> resetSrstAsync(AxlNetClient.NameAndGUIDRequest resetSrst)
        {
            return axlPortClient26.resetSrstAsync(resetSrst);
        }

        public AxlNetClient.StandardResponse restartSrst(AxlNetClient.NameAndGUIDRequest restartSrst1)
        {
            return axlPortClient26.restartSrst(restartSrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSrstResponse> restartSrstAsync(AxlNetClient.NameAndGUIDRequest restartSrst)
        {
            return axlPortClient26.restartSrstAsync(restartSrst);
        }

        public AxlNetClient.StandardResponse applySrst(AxlNetClient.NameAndGUIDRequest applySrst1)
        {
            return axlPortClient26.applySrst(applySrst1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySrstResponse> applySrstAsync(AxlNetClient.NameAndGUIDRequest applySrst)
        {
            return axlPortClient26.applySrstAsync(applySrst);
        }

        public AxlNetClient.StandardResponse addMlppDomain(AxlNetClient.AddMlppDomainReq addMlppDomain1)
        {
            return axlPortClient26.addMlppDomain(addMlppDomain1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMlppDomainResponse> addMlppDomainAsync(AxlNetClient.AddMlppDomainReq addMlppDomain)
        {
            return axlPortClient26.addMlppDomainAsync(addMlppDomain);
        }

        public AxlNetClient.StandardResponse updateMlppDomain(AxlNetClient.UpdateMlppDomainReq updateMlppDomain1)
        {
            return axlPortClient26.updateMlppDomain(updateMlppDomain1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMlppDomainResponse> updateMlppDomainAsync(AxlNetClient.UpdateMlppDomainReq updateMlppDomain)
        {
            return axlPortClient26.updateMlppDomainAsync(updateMlppDomain);
        }

        public AxlNetClient.GetMlppDomainRes getMlppDomain(AxlNetClient.GetMlppDomainReq getMlppDomain1)
        {
            return axlPortClient26.getMlppDomain(getMlppDomain1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMlppDomainResponse> getMlppDomainAsync(AxlNetClient.GetMlppDomainReq getMlppDomain)
        {
            return axlPortClient26.getMlppDomainAsync(getMlppDomain);
        }

        public AxlNetClient.StandardResponse removeMlppDomain(AxlNetClient.RemoveMlppDomainReq removeMlppDomain1)
        {
            return axlPortClient26.removeMlppDomain(removeMlppDomain1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMlppDomainResponse> removeMlppDomainAsync(AxlNetClient.RemoveMlppDomainReq removeMlppDomain)
        {
            return axlPortClient26.removeMlppDomainAsync(removeMlppDomain);
        }

        public AxlNetClient.ListMlppDomainRes listMlppDomain(AxlNetClient.ListMlppDomainReq listMlppDomain1)
        {
            return axlPortClient26.listMlppDomain(listMlppDomain1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMlppDomainResponse> listMlppDomainAsync(AxlNetClient.ListMlppDomainReq listMlppDomain)
        {
            return axlPortClient26.listMlppDomainAsync(listMlppDomain);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort26
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSrstResponse updateSrst(AxlNetClient.updateSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSrstResponse> updateSrstAsync(AxlNetClient.updateSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSrstResponse getSrst(AxlNetClient.getSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSrstResponse> getSrstAsync(AxlNetClient.getSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSrstResponse removeSrst(AxlNetClient.removeSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSrstResponse> removeSrstAsync(AxlNetClient.removeSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSrstResponse listSrst(AxlNetClient.listSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSrstResponse> listSrstAsync(AxlNetClient.listSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetSrstResponse resetSrst(AxlNetClient.resetSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetSrstResponse> resetSrstAsync(AxlNetClient.resetSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartSrstResponse restartSrst(AxlNetClient.restartSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartSrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartSrstResponse> restartSrstAsync(AxlNetClient.restartSrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySrst", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applySrstResponse applySrst(AxlNetClient.applySrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySrst", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applySrstResponse> applySrstAsync(AxlNetClient.applySrstRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMlppDomain", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMlppDomainResponse addMlppDomain(AxlNetClient.addMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMlppDomain", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMlppDomainResponse> addMlppDomainAsync(AxlNetClient.addMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMlppDomain", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMlppDomainResponse updateMlppDomain(AxlNetClient.updateMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMlppDomain", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMlppDomainResponse> updateMlppDomainAsync(AxlNetClient.updateMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMlppDomain", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMlppDomainResponse getMlppDomain(AxlNetClient.getMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMlppDomain", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMlppDomainResponse> getMlppDomainAsync(AxlNetClient.getMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMlppDomain", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMlppDomainResponse removeMlppDomain(AxlNetClient.removeMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMlppDomain", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMlppDomainResponse> removeMlppDomainAsync(AxlNetClient.removeMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMlppDomain", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMlppDomainResponse listMlppDomain(AxlNetClient.listMlppDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMlppDomain", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMlppDomainResponse> listMlppDomainAsync(AxlNetClient.listMlppDomainRequest request);
    }

    public class AXLPortClient26 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort26>, AxlNetClient.AXLPort26
    {
        public AXLPortClient26(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSrstResponse AxlNetClient.AXLPort26.updateSrst(AxlNetClient.updateSrstRequest request)
        {
            return base.Channel.updateSrst(request);
        }

        public AxlNetClient.StandardResponse updateSrst(AxlNetClient.UpdateSrstReq updateSrst1)
        {
            AxlNetClient.updateSrstRequest inValue = new AxlNetClient.updateSrstRequest();
            inValue.updateSrst = updateSrst1;
            AxlNetClient.updateSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).updateSrst(inValue);
            return retVal.updateSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSrstResponse> AxlNetClient.AXLPort26.updateSrstAsync(AxlNetClient.updateSrstRequest request)
        {
            return base.Channel.updateSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSrstResponse> updateSrstAsync(AxlNetClient.UpdateSrstReq updateSrst)
        {
            AxlNetClient.updateSrstRequest inValue = new AxlNetClient.updateSrstRequest();
            inValue.updateSrst = updateSrst;
            return ((AxlNetClient.AXLPort26)(this)).updateSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSrstResponse AxlNetClient.AXLPort26.getSrst(AxlNetClient.getSrstRequest request)
        {
            return base.Channel.getSrst(request);
        }

        public AxlNetClient.GetSrstRes getSrst(AxlNetClient.GetSrstReq getSrst1)
        {
            AxlNetClient.getSrstRequest inValue = new AxlNetClient.getSrstRequest();
            inValue.getSrst = getSrst1;
            AxlNetClient.getSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).getSrst(inValue);
            return retVal.getSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSrstResponse> AxlNetClient.AXLPort26.getSrstAsync(AxlNetClient.getSrstRequest request)
        {
            return base.Channel.getSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSrstResponse> getSrstAsync(AxlNetClient.GetSrstReq getSrst)
        {
            AxlNetClient.getSrstRequest inValue = new AxlNetClient.getSrstRequest();
            inValue.getSrst = getSrst;
            return ((AxlNetClient.AXLPort26)(this)).getSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSrstResponse AxlNetClient.AXLPort26.removeSrst(AxlNetClient.removeSrstRequest request)
        {
            return base.Channel.removeSrst(request);
        }

        public AxlNetClient.StandardResponse removeSrst(AxlNetClient.NameAndGUIDRequest removeSrst1)
        {
            AxlNetClient.removeSrstRequest inValue = new AxlNetClient.removeSrstRequest();
            inValue.removeSrst = removeSrst1;
            AxlNetClient.removeSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).removeSrst(inValue);
            return retVal.removeSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSrstResponse> AxlNetClient.AXLPort26.removeSrstAsync(AxlNetClient.removeSrstRequest request)
        {
            return base.Channel.removeSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSrstResponse> removeSrstAsync(AxlNetClient.NameAndGUIDRequest removeSrst)
        {
            AxlNetClient.removeSrstRequest inValue = new AxlNetClient.removeSrstRequest();
            inValue.removeSrst = removeSrst;
            return ((AxlNetClient.AXLPort26)(this)).removeSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSrstResponse AxlNetClient.AXLPort26.listSrst(AxlNetClient.listSrstRequest request)
        {
            return base.Channel.listSrst(request);
        }

        public AxlNetClient.ListSrstRes listSrst(AxlNetClient.ListSrstReq listSrst1)
        {
            AxlNetClient.listSrstRequest inValue = new AxlNetClient.listSrstRequest();
            inValue.listSrst = listSrst1;
            AxlNetClient.listSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).listSrst(inValue);
            return retVal.listSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSrstResponse> AxlNetClient.AXLPort26.listSrstAsync(AxlNetClient.listSrstRequest request)
        {
            return base.Channel.listSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSrstResponse> listSrstAsync(AxlNetClient.ListSrstReq listSrst)
        {
            AxlNetClient.listSrstRequest inValue = new AxlNetClient.listSrstRequest();
            inValue.listSrst = listSrst;
            return ((AxlNetClient.AXLPort26)(this)).listSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetSrstResponse AxlNetClient.AXLPort26.resetSrst(AxlNetClient.resetSrstRequest request)
        {
            return base.Channel.resetSrst(request);
        }

        public AxlNetClient.StandardResponse resetSrst(AxlNetClient.NameAndGUIDRequest resetSrst1)
        {
            AxlNetClient.resetSrstRequest inValue = new AxlNetClient.resetSrstRequest();
            inValue.resetSrst = resetSrst1;
            AxlNetClient.resetSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).resetSrst(inValue);
            return retVal.resetSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetSrstResponse> AxlNetClient.AXLPort26.resetSrstAsync(AxlNetClient.resetSrstRequest request)
        {
            return base.Channel.resetSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSrstResponse> resetSrstAsync(AxlNetClient.NameAndGUIDRequest resetSrst)
        {
            AxlNetClient.resetSrstRequest inValue = new AxlNetClient.resetSrstRequest();
            inValue.resetSrst = resetSrst;
            return ((AxlNetClient.AXLPort26)(this)).resetSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartSrstResponse AxlNetClient.AXLPort26.restartSrst(AxlNetClient.restartSrstRequest request)
        {
            return base.Channel.restartSrst(request);
        }

        public AxlNetClient.StandardResponse restartSrst(AxlNetClient.NameAndGUIDRequest restartSrst1)
        {
            AxlNetClient.restartSrstRequest inValue = new AxlNetClient.restartSrstRequest();
            inValue.restartSrst = restartSrst1;
            AxlNetClient.restartSrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).restartSrst(inValue);
            return retVal.restartSrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartSrstResponse> AxlNetClient.AXLPort26.restartSrstAsync(AxlNetClient.restartSrstRequest request)
        {
            return base.Channel.restartSrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartSrstResponse> restartSrstAsync(AxlNetClient.NameAndGUIDRequest restartSrst)
        {
            AxlNetClient.restartSrstRequest inValue = new AxlNetClient.restartSrstRequest();
            inValue.restartSrst = restartSrst;
            return ((AxlNetClient.AXLPort26)(this)).restartSrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applySrstResponse AxlNetClient.AXLPort26.applySrst(AxlNetClient.applySrstRequest request)
        {
            return base.Channel.applySrst(request);
        }

        public AxlNetClient.StandardResponse applySrst(AxlNetClient.NameAndGUIDRequest applySrst1)
        {
            AxlNetClient.applySrstRequest inValue = new AxlNetClient.applySrstRequest();
            inValue.applySrst = applySrst1;
            AxlNetClient.applySrstResponse retVal = ((AxlNetClient.AXLPort26)(this)).applySrst(inValue);
            return retVal.applySrstResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applySrstResponse> AxlNetClient.AXLPort26.applySrstAsync(AxlNetClient.applySrstRequest request)
        {
            return base.Channel.applySrstAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySrstResponse> applySrstAsync(AxlNetClient.NameAndGUIDRequest applySrst)
        {
            AxlNetClient.applySrstRequest inValue = new AxlNetClient.applySrstRequest();
            inValue.applySrst = applySrst;
            return ((AxlNetClient.AXLPort26)(this)).applySrstAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMlppDomainResponse AxlNetClient.AXLPort26.addMlppDomain(AxlNetClient.addMlppDomainRequest request)
        {
            return base.Channel.addMlppDomain(request);
        }

        public AxlNetClient.StandardResponse addMlppDomain(AxlNetClient.AddMlppDomainReq addMlppDomain1)
        {
            AxlNetClient.addMlppDomainRequest inValue = new AxlNetClient.addMlppDomainRequest();
            inValue.addMlppDomain = addMlppDomain1;
            AxlNetClient.addMlppDomainResponse retVal = ((AxlNetClient.AXLPort26)(this)).addMlppDomain(inValue);
            return retVal.addMlppDomainResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMlppDomainResponse> AxlNetClient.AXLPort26.addMlppDomainAsync(AxlNetClient.addMlppDomainRequest request)
        {
            return base.Channel.addMlppDomainAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMlppDomainResponse> addMlppDomainAsync(AxlNetClient.AddMlppDomainReq addMlppDomain)
        {
            AxlNetClient.addMlppDomainRequest inValue = new AxlNetClient.addMlppDomainRequest();
            inValue.addMlppDomain = addMlppDomain;
            return ((AxlNetClient.AXLPort26)(this)).addMlppDomainAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMlppDomainResponse AxlNetClient.AXLPort26.updateMlppDomain(AxlNetClient.updateMlppDomainRequest request)
        {
            return base.Channel.updateMlppDomain(request);
        }

        public AxlNetClient.StandardResponse updateMlppDomain(AxlNetClient.UpdateMlppDomainReq updateMlppDomain1)
        {
            AxlNetClient.updateMlppDomainRequest inValue = new AxlNetClient.updateMlppDomainRequest();
            inValue.updateMlppDomain = updateMlppDomain1;
            AxlNetClient.updateMlppDomainResponse retVal = ((AxlNetClient.AXLPort26)(this)).updateMlppDomain(inValue);
            return retVal.updateMlppDomainResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMlppDomainResponse> AxlNetClient.AXLPort26.updateMlppDomainAsync(AxlNetClient.updateMlppDomainRequest request)
        {
            return base.Channel.updateMlppDomainAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMlppDomainResponse> updateMlppDomainAsync(AxlNetClient.UpdateMlppDomainReq updateMlppDomain)
        {
            AxlNetClient.updateMlppDomainRequest inValue = new AxlNetClient.updateMlppDomainRequest();
            inValue.updateMlppDomain = updateMlppDomain;
            return ((AxlNetClient.AXLPort26)(this)).updateMlppDomainAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMlppDomainResponse AxlNetClient.AXLPort26.getMlppDomain(AxlNetClient.getMlppDomainRequest request)
        {
            return base.Channel.getMlppDomain(request);
        }

        public AxlNetClient.GetMlppDomainRes getMlppDomain(AxlNetClient.GetMlppDomainReq getMlppDomain1)
        {
            AxlNetClient.getMlppDomainRequest inValue = new AxlNetClient.getMlppDomainRequest();
            inValue.getMlppDomain = getMlppDomain1;
            AxlNetClient.getMlppDomainResponse retVal = ((AxlNetClient.AXLPort26)(this)).getMlppDomain(inValue);
            return retVal.getMlppDomainResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMlppDomainResponse> AxlNetClient.AXLPort26.getMlppDomainAsync(AxlNetClient.getMlppDomainRequest request)
        {
            return base.Channel.getMlppDomainAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMlppDomainResponse> getMlppDomainAsync(AxlNetClient.GetMlppDomainReq getMlppDomain)
        {
            AxlNetClient.getMlppDomainRequest inValue = new AxlNetClient.getMlppDomainRequest();
            inValue.getMlppDomain = getMlppDomain;
            return ((AxlNetClient.AXLPort26)(this)).getMlppDomainAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMlppDomainResponse AxlNetClient.AXLPort26.removeMlppDomain(AxlNetClient.removeMlppDomainRequest request)
        {
            return base.Channel.removeMlppDomain(request);
        }

        public AxlNetClient.StandardResponse removeMlppDomain(AxlNetClient.RemoveMlppDomainReq removeMlppDomain1)
        {
            AxlNetClient.removeMlppDomainRequest inValue = new AxlNetClient.removeMlppDomainRequest();
            inValue.removeMlppDomain = removeMlppDomain1;
            AxlNetClient.removeMlppDomainResponse retVal = ((AxlNetClient.AXLPort26)(this)).removeMlppDomain(inValue);
            return retVal.removeMlppDomainResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMlppDomainResponse> AxlNetClient.AXLPort26.removeMlppDomainAsync(AxlNetClient.removeMlppDomainRequest request)
        {
            return base.Channel.removeMlppDomainAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMlppDomainResponse> removeMlppDomainAsync(AxlNetClient.RemoveMlppDomainReq removeMlppDomain)
        {
            AxlNetClient.removeMlppDomainRequest inValue = new AxlNetClient.removeMlppDomainRequest();
            inValue.removeMlppDomain = removeMlppDomain;
            return ((AxlNetClient.AXLPort26)(this)).removeMlppDomainAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMlppDomainResponse AxlNetClient.AXLPort26.listMlppDomain(AxlNetClient.listMlppDomainRequest request)
        {
            return base.Channel.listMlppDomain(request);
        }

        public AxlNetClient.ListMlppDomainRes listMlppDomain(AxlNetClient.ListMlppDomainReq listMlppDomain1)
        {
            AxlNetClient.listMlppDomainRequest inValue = new AxlNetClient.listMlppDomainRequest();
            inValue.listMlppDomain = listMlppDomain1;
            AxlNetClient.listMlppDomainResponse retVal = ((AxlNetClient.AXLPort26)(this)).listMlppDomain(inValue);
            return retVal.listMlppDomainResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMlppDomainResponse> AxlNetClient.AXLPort26.listMlppDomainAsync(AxlNetClient.listMlppDomainRequest request)
        {
            return base.Channel.listMlppDomainAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMlppDomainResponse> listMlppDomainAsync(AxlNetClient.ListMlppDomainReq listMlppDomain)
        {
            AxlNetClient.listMlppDomainRequest inValue = new AxlNetClient.listMlppDomainRequest();
            inValue.listMlppDomain = listMlppDomain;
            return ((AxlNetClient.AXLPort26)(this)).listMlppDomainAsync(inValue);
        }
    }
}