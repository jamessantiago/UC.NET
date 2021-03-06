namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient3 _axlPortClient3;

        private static AXLPortClient3 axlPortClient3 => _axlPortClient3 == null ||
            _axlPortClient3.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient3 = LoadClient3()) : _axlPortClient3;

        private static AXLPortClient3 LoadClient3()
        {
            var client = new AXLPortClient3(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close3;
            OnAbort += Abort3;
            return client;
        }

        private static void Close3(object sender, System.EventArgs e)
        {
            _axlPortClient3.Close();
        }

        private static void Abort3(object sender, System.EventArgs e)
        {
            _axlPortClient3.Abort();
        }

        public AxlNetClient.ListTimeScheduleRes listTimeSchedule(AxlNetClient.ListTimeScheduleReq listTimeSchedule1)
        {
            return axlPortClient3.listTimeSchedule(listTimeSchedule1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTimeScheduleResponse> listTimeScheduleAsync(AxlNetClient.ListTimeScheduleReq listTimeSchedule)
        {
            return axlPortClient3.listTimeScheduleAsync(listTimeSchedule);
        }

        public AxlNetClient.StandardResponse addTodAccess(AxlNetClient.AddTodAccessReq addTodAccess1)
        {
            return axlPortClient3.addTodAccess(addTodAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTodAccessResponse> addTodAccessAsync(AxlNetClient.AddTodAccessReq addTodAccess)
        {
            return axlPortClient3.addTodAccessAsync(addTodAccess);
        }

        public AxlNetClient.StandardResponse updateTodAccess(AxlNetClient.UpdateTodAccessReq updateTodAccess1)
        {
            return axlPortClient3.updateTodAccess(updateTodAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTodAccessResponse> updateTodAccessAsync(AxlNetClient.UpdateTodAccessReq updateTodAccess)
        {
            return axlPortClient3.updateTodAccessAsync(updateTodAccess);
        }

        public AxlNetClient.GetTodAccessRes getTodAccess(AxlNetClient.GetTodAccessReq getTodAccess1)
        {
            return axlPortClient3.getTodAccess(getTodAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTodAccessResponse> getTodAccessAsync(AxlNetClient.GetTodAccessReq getTodAccess)
        {
            return axlPortClient3.getTodAccessAsync(getTodAccess);
        }

        public AxlNetClient.StandardResponse removeTodAccess(AxlNetClient.NameAndGUIDRequest removeTodAccess1)
        {
            return axlPortClient3.removeTodAccess(removeTodAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTodAccessResponse> removeTodAccessAsync(AxlNetClient.NameAndGUIDRequest removeTodAccess)
        {
            return axlPortClient3.removeTodAccessAsync(removeTodAccess);
        }

        public AxlNetClient.ListTodAccessRes listTodAccess(AxlNetClient.ListTodAccessReq listTodAccess1)
        {
            return axlPortClient3.listTodAccess(listTodAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTodAccessResponse> listTodAccessAsync(AxlNetClient.ListTodAccessReq listTodAccess)
        {
            return axlPortClient3.listTodAccessAsync(listTodAccess);
        }

        public AxlNetClient.StandardResponse addVoiceMailPilot(AxlNetClient.AddVoiceMailPilotReq addVoiceMailPilot1)
        {
            return axlPortClient3.addVoiceMailPilot(addVoiceMailPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPilotResponse> addVoiceMailPilotAsync(AxlNetClient.AddVoiceMailPilotReq addVoiceMailPilot)
        {
            return axlPortClient3.addVoiceMailPilotAsync(addVoiceMailPilot);
        }

        public AxlNetClient.StandardResponse updateVoiceMailPilot(AxlNetClient.UpdateVoiceMailPilotReq updateVoiceMailPilot1)
        {
            return axlPortClient3.updateVoiceMailPilot(updateVoiceMailPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPilotResponse> updateVoiceMailPilotAsync(AxlNetClient.UpdateVoiceMailPilotReq updateVoiceMailPilot)
        {
            return axlPortClient3.updateVoiceMailPilotAsync(updateVoiceMailPilot);
        }

        public AxlNetClient.GetVoiceMailPilotRes getVoiceMailPilot(AxlNetClient.GetVoiceMailPilotReq getVoiceMailPilot1)
        {
            return axlPortClient3.getVoiceMailPilot(getVoiceMailPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPilotResponse> getVoiceMailPilotAsync(AxlNetClient.GetVoiceMailPilotReq getVoiceMailPilot)
        {
            return axlPortClient3.getVoiceMailPilotAsync(getVoiceMailPilot);
        }

        public AxlNetClient.StandardResponse removeVoiceMailPilot(AxlNetClient.RemoveVoiceMailPilotReq removeVoiceMailPilot1)
        {
            return axlPortClient3.removeVoiceMailPilot(removeVoiceMailPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPilotResponse> removeVoiceMailPilotAsync(AxlNetClient.RemoveVoiceMailPilotReq removeVoiceMailPilot)
        {
            return axlPortClient3.removeVoiceMailPilotAsync(removeVoiceMailPilot);
        }

        public AxlNetClient.ListVoiceMailPilotRes listVoiceMailPilot(AxlNetClient.ListVoiceMailPilotReq listVoiceMailPilot1)
        {
            return axlPortClient3.listVoiceMailPilot(listVoiceMailPilot1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPilotResponse> listVoiceMailPilotAsync(AxlNetClient.ListVoiceMailPilotReq listVoiceMailPilot)
        {
            return axlPortClient3.listVoiceMailPilotAsync(listVoiceMailPilot);
        }

        public AxlNetClient.StandardResponse addProcessNode(AxlNetClient.AddProcessNodeReq addProcessNode1)
        {
            return axlPortClient3.addProcessNode(addProcessNode1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addProcessNodeResponse> addProcessNodeAsync(AxlNetClient.AddProcessNodeReq addProcessNode)
        {
            return axlPortClient3.addProcessNodeAsync(addProcessNode);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort3
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTimeSchedule", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTimeScheduleResponse listTimeSchedule(AxlNetClient.listTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTimeSchedule", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTimeScheduleResponse> listTimeScheduleAsync(AxlNetClient.listTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTodAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTodAccessResponse addTodAccess(AxlNetClient.addTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTodAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTodAccessResponse> addTodAccessAsync(AxlNetClient.addTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTodAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTodAccessResponse updateTodAccess(AxlNetClient.updateTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTodAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTodAccessResponse> updateTodAccessAsync(AxlNetClient.updateTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTodAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTodAccessResponse getTodAccess(AxlNetClient.getTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTodAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTodAccessResponse> getTodAccessAsync(AxlNetClient.getTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTodAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTodAccessResponse removeTodAccess(AxlNetClient.removeTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTodAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTodAccessResponse> removeTodAccessAsync(AxlNetClient.removeTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTodAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTodAccessResponse listTodAccess(AxlNetClient.listTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTodAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTodAccessResponse> listTodAccessAsync(AxlNetClient.listTodAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addVoiceMailPilotResponse addVoiceMailPilot(AxlNetClient.addVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addVoiceMailPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPilotResponse> addVoiceMailPilotAsync(AxlNetClient.addVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateVoiceMailPilotResponse updateVoiceMailPilot(AxlNetClient.updateVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateVoiceMailPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPilotResponse> updateVoiceMailPilotAsync(AxlNetClient.updateVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getVoiceMailPilotResponse getVoiceMailPilot(AxlNetClient.getVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getVoiceMailPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPilotResponse> getVoiceMailPilotAsync(AxlNetClient.getVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeVoiceMailPilotResponse removeVoiceMailPilot(AxlNetClient.removeVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeVoiceMailPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPilotResponse> removeVoiceMailPilotAsync(AxlNetClient.removeVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailPilot", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listVoiceMailPilotResponse listVoiceMailPilot(AxlNetClient.listVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listVoiceMailPilot", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPilotResponse> listVoiceMailPilotAsync(AxlNetClient.listVoiceMailPilotRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addProcessNode", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addProcessNodeResponse addProcessNode(AxlNetClient.addProcessNodeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addProcessNode", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addProcessNodeResponse> addProcessNodeAsync(AxlNetClient.addProcessNodeRequest request);
    }

    public class AXLPortClient3 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort3>, AxlNetClient.AXLPort3
    {
        public AXLPortClient3(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTimeScheduleResponse AxlNetClient.AXLPort3.listTimeSchedule(AxlNetClient.listTimeScheduleRequest request)
        {
            return base.Channel.listTimeSchedule(request);
        }

        public AxlNetClient.ListTimeScheduleRes listTimeSchedule(AxlNetClient.ListTimeScheduleReq listTimeSchedule1)
        {
            AxlNetClient.listTimeScheduleRequest inValue = new AxlNetClient.listTimeScheduleRequest();
            inValue.listTimeSchedule = listTimeSchedule1;
            AxlNetClient.listTimeScheduleResponse retVal = ((AxlNetClient.AXLPort3)(this)).listTimeSchedule(inValue);
            return retVal.listTimeScheduleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTimeScheduleResponse> AxlNetClient.AXLPort3.listTimeScheduleAsync(AxlNetClient.listTimeScheduleRequest request)
        {
            return base.Channel.listTimeScheduleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTimeScheduleResponse> listTimeScheduleAsync(AxlNetClient.ListTimeScheduleReq listTimeSchedule)
        {
            AxlNetClient.listTimeScheduleRequest inValue = new AxlNetClient.listTimeScheduleRequest();
            inValue.listTimeSchedule = listTimeSchedule;
            return ((AxlNetClient.AXLPort3)(this)).listTimeScheduleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTodAccessResponse AxlNetClient.AXLPort3.addTodAccess(AxlNetClient.addTodAccessRequest request)
        {
            return base.Channel.addTodAccess(request);
        }

        public AxlNetClient.StandardResponse addTodAccess(AxlNetClient.AddTodAccessReq addTodAccess1)
        {
            AxlNetClient.addTodAccessRequest inValue = new AxlNetClient.addTodAccessRequest();
            inValue.addTodAccess = addTodAccess1;
            AxlNetClient.addTodAccessResponse retVal = ((AxlNetClient.AXLPort3)(this)).addTodAccess(inValue);
            return retVal.addTodAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTodAccessResponse> AxlNetClient.AXLPort3.addTodAccessAsync(AxlNetClient.addTodAccessRequest request)
        {
            return base.Channel.addTodAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTodAccessResponse> addTodAccessAsync(AxlNetClient.AddTodAccessReq addTodAccess)
        {
            AxlNetClient.addTodAccessRequest inValue = new AxlNetClient.addTodAccessRequest();
            inValue.addTodAccess = addTodAccess;
            return ((AxlNetClient.AXLPort3)(this)).addTodAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTodAccessResponse AxlNetClient.AXLPort3.updateTodAccess(AxlNetClient.updateTodAccessRequest request)
        {
            return base.Channel.updateTodAccess(request);
        }

        public AxlNetClient.StandardResponse updateTodAccess(AxlNetClient.UpdateTodAccessReq updateTodAccess1)
        {
            AxlNetClient.updateTodAccessRequest inValue = new AxlNetClient.updateTodAccessRequest();
            inValue.updateTodAccess = updateTodAccess1;
            AxlNetClient.updateTodAccessResponse retVal = ((AxlNetClient.AXLPort3)(this)).updateTodAccess(inValue);
            return retVal.updateTodAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTodAccessResponse> AxlNetClient.AXLPort3.updateTodAccessAsync(AxlNetClient.updateTodAccessRequest request)
        {
            return base.Channel.updateTodAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTodAccessResponse> updateTodAccessAsync(AxlNetClient.UpdateTodAccessReq updateTodAccess)
        {
            AxlNetClient.updateTodAccessRequest inValue = new AxlNetClient.updateTodAccessRequest();
            inValue.updateTodAccess = updateTodAccess;
            return ((AxlNetClient.AXLPort3)(this)).updateTodAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTodAccessResponse AxlNetClient.AXLPort3.getTodAccess(AxlNetClient.getTodAccessRequest request)
        {
            return base.Channel.getTodAccess(request);
        }

        public AxlNetClient.GetTodAccessRes getTodAccess(AxlNetClient.GetTodAccessReq getTodAccess1)
        {
            AxlNetClient.getTodAccessRequest inValue = new AxlNetClient.getTodAccessRequest();
            inValue.getTodAccess = getTodAccess1;
            AxlNetClient.getTodAccessResponse retVal = ((AxlNetClient.AXLPort3)(this)).getTodAccess(inValue);
            return retVal.getTodAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTodAccessResponse> AxlNetClient.AXLPort3.getTodAccessAsync(AxlNetClient.getTodAccessRequest request)
        {
            return base.Channel.getTodAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTodAccessResponse> getTodAccessAsync(AxlNetClient.GetTodAccessReq getTodAccess)
        {
            AxlNetClient.getTodAccessRequest inValue = new AxlNetClient.getTodAccessRequest();
            inValue.getTodAccess = getTodAccess;
            return ((AxlNetClient.AXLPort3)(this)).getTodAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTodAccessResponse AxlNetClient.AXLPort3.removeTodAccess(AxlNetClient.removeTodAccessRequest request)
        {
            return base.Channel.removeTodAccess(request);
        }

        public AxlNetClient.StandardResponse removeTodAccess(AxlNetClient.NameAndGUIDRequest removeTodAccess1)
        {
            AxlNetClient.removeTodAccessRequest inValue = new AxlNetClient.removeTodAccessRequest();
            inValue.removeTodAccess = removeTodAccess1;
            AxlNetClient.removeTodAccessResponse retVal = ((AxlNetClient.AXLPort3)(this)).removeTodAccess(inValue);
            return retVal.removeTodAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTodAccessResponse> AxlNetClient.AXLPort3.removeTodAccessAsync(AxlNetClient.removeTodAccessRequest request)
        {
            return base.Channel.removeTodAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTodAccessResponse> removeTodAccessAsync(AxlNetClient.NameAndGUIDRequest removeTodAccess)
        {
            AxlNetClient.removeTodAccessRequest inValue = new AxlNetClient.removeTodAccessRequest();
            inValue.removeTodAccess = removeTodAccess;
            return ((AxlNetClient.AXLPort3)(this)).removeTodAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTodAccessResponse AxlNetClient.AXLPort3.listTodAccess(AxlNetClient.listTodAccessRequest request)
        {
            return base.Channel.listTodAccess(request);
        }

        public AxlNetClient.ListTodAccessRes listTodAccess(AxlNetClient.ListTodAccessReq listTodAccess1)
        {
            AxlNetClient.listTodAccessRequest inValue = new AxlNetClient.listTodAccessRequest();
            inValue.listTodAccess = listTodAccess1;
            AxlNetClient.listTodAccessResponse retVal = ((AxlNetClient.AXLPort3)(this)).listTodAccess(inValue);
            return retVal.listTodAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTodAccessResponse> AxlNetClient.AXLPort3.listTodAccessAsync(AxlNetClient.listTodAccessRequest request)
        {
            return base.Channel.listTodAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTodAccessResponse> listTodAccessAsync(AxlNetClient.ListTodAccessReq listTodAccess)
        {
            AxlNetClient.listTodAccessRequest inValue = new AxlNetClient.listTodAccessRequest();
            inValue.listTodAccess = listTodAccess;
            return ((AxlNetClient.AXLPort3)(this)).listTodAccessAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addVoiceMailPilotResponse AxlNetClient.AXLPort3.addVoiceMailPilot(AxlNetClient.addVoiceMailPilotRequest request)
        {
            return base.Channel.addVoiceMailPilot(request);
        }

        public AxlNetClient.StandardResponse addVoiceMailPilot(AxlNetClient.AddVoiceMailPilotReq addVoiceMailPilot1)
        {
            AxlNetClient.addVoiceMailPilotRequest inValue = new AxlNetClient.addVoiceMailPilotRequest();
            inValue.addVoiceMailPilot = addVoiceMailPilot1;
            AxlNetClient.addVoiceMailPilotResponse retVal = ((AxlNetClient.AXLPort3)(this)).addVoiceMailPilot(inValue);
            return retVal.addVoiceMailPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPilotResponse> AxlNetClient.AXLPort3.addVoiceMailPilotAsync(AxlNetClient.addVoiceMailPilotRequest request)
        {
            return base.Channel.addVoiceMailPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addVoiceMailPilotResponse> addVoiceMailPilotAsync(AxlNetClient.AddVoiceMailPilotReq addVoiceMailPilot)
        {
            AxlNetClient.addVoiceMailPilotRequest inValue = new AxlNetClient.addVoiceMailPilotRequest();
            inValue.addVoiceMailPilot = addVoiceMailPilot;
            return ((AxlNetClient.AXLPort3)(this)).addVoiceMailPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateVoiceMailPilotResponse AxlNetClient.AXLPort3.updateVoiceMailPilot(AxlNetClient.updateVoiceMailPilotRequest request)
        {
            return base.Channel.updateVoiceMailPilot(request);
        }

        public AxlNetClient.StandardResponse updateVoiceMailPilot(AxlNetClient.UpdateVoiceMailPilotReq updateVoiceMailPilot1)
        {
            AxlNetClient.updateVoiceMailPilotRequest inValue = new AxlNetClient.updateVoiceMailPilotRequest();
            inValue.updateVoiceMailPilot = updateVoiceMailPilot1;
            AxlNetClient.updateVoiceMailPilotResponse retVal = ((AxlNetClient.AXLPort3)(this)).updateVoiceMailPilot(inValue);
            return retVal.updateVoiceMailPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPilotResponse> AxlNetClient.AXLPort3.updateVoiceMailPilotAsync(AxlNetClient.updateVoiceMailPilotRequest request)
        {
            return base.Channel.updateVoiceMailPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateVoiceMailPilotResponse> updateVoiceMailPilotAsync(AxlNetClient.UpdateVoiceMailPilotReq updateVoiceMailPilot)
        {
            AxlNetClient.updateVoiceMailPilotRequest inValue = new AxlNetClient.updateVoiceMailPilotRequest();
            inValue.updateVoiceMailPilot = updateVoiceMailPilot;
            return ((AxlNetClient.AXLPort3)(this)).updateVoiceMailPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getVoiceMailPilotResponse AxlNetClient.AXLPort3.getVoiceMailPilot(AxlNetClient.getVoiceMailPilotRequest request)
        {
            return base.Channel.getVoiceMailPilot(request);
        }

        public AxlNetClient.GetVoiceMailPilotRes getVoiceMailPilot(AxlNetClient.GetVoiceMailPilotReq getVoiceMailPilot1)
        {
            AxlNetClient.getVoiceMailPilotRequest inValue = new AxlNetClient.getVoiceMailPilotRequest();
            inValue.getVoiceMailPilot = getVoiceMailPilot1;
            AxlNetClient.getVoiceMailPilotResponse retVal = ((AxlNetClient.AXLPort3)(this)).getVoiceMailPilot(inValue);
            return retVal.getVoiceMailPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPilotResponse> AxlNetClient.AXLPort3.getVoiceMailPilotAsync(AxlNetClient.getVoiceMailPilotRequest request)
        {
            return base.Channel.getVoiceMailPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getVoiceMailPilotResponse> getVoiceMailPilotAsync(AxlNetClient.GetVoiceMailPilotReq getVoiceMailPilot)
        {
            AxlNetClient.getVoiceMailPilotRequest inValue = new AxlNetClient.getVoiceMailPilotRequest();
            inValue.getVoiceMailPilot = getVoiceMailPilot;
            return ((AxlNetClient.AXLPort3)(this)).getVoiceMailPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeVoiceMailPilotResponse AxlNetClient.AXLPort3.removeVoiceMailPilot(AxlNetClient.removeVoiceMailPilotRequest request)
        {
            return base.Channel.removeVoiceMailPilot(request);
        }

        public AxlNetClient.StandardResponse removeVoiceMailPilot(AxlNetClient.RemoveVoiceMailPilotReq removeVoiceMailPilot1)
        {
            AxlNetClient.removeVoiceMailPilotRequest inValue = new AxlNetClient.removeVoiceMailPilotRequest();
            inValue.removeVoiceMailPilot = removeVoiceMailPilot1;
            AxlNetClient.removeVoiceMailPilotResponse retVal = ((AxlNetClient.AXLPort3)(this)).removeVoiceMailPilot(inValue);
            return retVal.removeVoiceMailPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPilotResponse> AxlNetClient.AXLPort3.removeVoiceMailPilotAsync(AxlNetClient.removeVoiceMailPilotRequest request)
        {
            return base.Channel.removeVoiceMailPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeVoiceMailPilotResponse> removeVoiceMailPilotAsync(AxlNetClient.RemoveVoiceMailPilotReq removeVoiceMailPilot)
        {
            AxlNetClient.removeVoiceMailPilotRequest inValue = new AxlNetClient.removeVoiceMailPilotRequest();
            inValue.removeVoiceMailPilot = removeVoiceMailPilot;
            return ((AxlNetClient.AXLPort3)(this)).removeVoiceMailPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listVoiceMailPilotResponse AxlNetClient.AXLPort3.listVoiceMailPilot(AxlNetClient.listVoiceMailPilotRequest request)
        {
            return base.Channel.listVoiceMailPilot(request);
        }

        public AxlNetClient.ListVoiceMailPilotRes listVoiceMailPilot(AxlNetClient.ListVoiceMailPilotReq listVoiceMailPilot1)
        {
            AxlNetClient.listVoiceMailPilotRequest inValue = new AxlNetClient.listVoiceMailPilotRequest();
            inValue.listVoiceMailPilot = listVoiceMailPilot1;
            AxlNetClient.listVoiceMailPilotResponse retVal = ((AxlNetClient.AXLPort3)(this)).listVoiceMailPilot(inValue);
            return retVal.listVoiceMailPilotResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPilotResponse> AxlNetClient.AXLPort3.listVoiceMailPilotAsync(AxlNetClient.listVoiceMailPilotRequest request)
        {
            return base.Channel.listVoiceMailPilotAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listVoiceMailPilotResponse> listVoiceMailPilotAsync(AxlNetClient.ListVoiceMailPilotReq listVoiceMailPilot)
        {
            AxlNetClient.listVoiceMailPilotRequest inValue = new AxlNetClient.listVoiceMailPilotRequest();
            inValue.listVoiceMailPilot = listVoiceMailPilot;
            return ((AxlNetClient.AXLPort3)(this)).listVoiceMailPilotAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addProcessNodeResponse AxlNetClient.AXLPort3.addProcessNode(AxlNetClient.addProcessNodeRequest request)
        {
            return base.Channel.addProcessNode(request);
        }

        public AxlNetClient.StandardResponse addProcessNode(AxlNetClient.AddProcessNodeReq addProcessNode1)
        {
            AxlNetClient.addProcessNodeRequest inValue = new AxlNetClient.addProcessNodeRequest();
            inValue.addProcessNode = addProcessNode1;
            AxlNetClient.addProcessNodeResponse retVal = ((AxlNetClient.AXLPort3)(this)).addProcessNode(inValue);
            return retVal.addProcessNodeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addProcessNodeResponse> AxlNetClient.AXLPort3.addProcessNodeAsync(AxlNetClient.addProcessNodeRequest request)
        {
            return base.Channel.addProcessNodeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addProcessNodeResponse> addProcessNodeAsync(AxlNetClient.AddProcessNodeReq addProcessNode)
        {
            AxlNetClient.addProcessNodeRequest inValue = new AxlNetClient.addProcessNodeRequest();
            inValue.addProcessNode = addProcessNode;
            return ((AxlNetClient.AXLPort3)(this)).addProcessNodeAsync(inValue);
        }
    }
}