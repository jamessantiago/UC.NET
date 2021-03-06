namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient2 _axlPortClient2;

        private static AXLPortClient2 axlPortClient2 => _axlPortClient2 == null ||
            _axlPortClient2.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient2 = LoadClient2()) : _axlPortClient2;

        private static AXLPortClient2 LoadClient2()
        {
            var client = new AXLPortClient2(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close2;
            OnAbort += Abort2;
            return client;
        }

        private static void Close2(object sender, System.EventArgs e)
        {
            _axlPortClient2.Close();
        }

        private static void Abort2(object sender, System.EventArgs e)
        {
            _axlPortClient2.Abort();
        }

        public AxlNetClient.ListSipTrunkSecurityProfileRes listSipTrunkSecurityProfile(AxlNetClient.ListSipTrunkSecurityProfileReq listSipTrunkSecurityProfile1)
        {
            return axlPortClient2.listSipTrunkSecurityProfile(listSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipTrunkSecurityProfileResponse> listSipTrunkSecurityProfileAsync(AxlNetClient.ListSipTrunkSecurityProfileReq listSipTrunkSecurityProfile)
        {
            return axlPortClient2.listSipTrunkSecurityProfileAsync(listSipTrunkSecurityProfile);
        }

        public AxlNetClient.StandardResponse resetSipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest resetSipTrunkSecurityProfile1)
        {
            return axlPortClient2.resetSipTrunkSecurityProfile(resetSipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkSecurityProfileResponse> resetSipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest resetSipTrunkSecurityProfile)
        {
            return axlPortClient2.resetSipTrunkSecurityProfileAsync(resetSipTrunkSecurityProfile);
        }

        public AxlNetClient.StandardResponse applySipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest applySipTrunkSecurityProfile1)
        {
            return axlPortClient2.applySipTrunkSecurityProfile(applySipTrunkSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySipTrunkSecurityProfileResponse> applySipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest applySipTrunkSecurityProfile)
        {
            return axlPortClient2.applySipTrunkSecurityProfileAsync(applySipTrunkSecurityProfile);
        }

        public AxlNetClient.StandardResponse addTimePeriod(AxlNetClient.AddTimePeriodReq addTimePeriod1)
        {
            return axlPortClient2.addTimePeriod(addTimePeriod1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTimePeriodResponse> addTimePeriodAsync(AxlNetClient.AddTimePeriodReq addTimePeriod)
        {
            return axlPortClient2.addTimePeriodAsync(addTimePeriod);
        }

        public AxlNetClient.StandardResponse updateTimePeriod(AxlNetClient.UpdateTimePeriodReq updateTimePeriod1)
        {
            return axlPortClient2.updateTimePeriod(updateTimePeriod1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTimePeriodResponse> updateTimePeriodAsync(AxlNetClient.UpdateTimePeriodReq updateTimePeriod)
        {
            return axlPortClient2.updateTimePeriodAsync(updateTimePeriod);
        }

        public AxlNetClient.GetTimePeriodRes getTimePeriod(AxlNetClient.GetTimePeriodReq getTimePeriod1)
        {
            return axlPortClient2.getTimePeriod(getTimePeriod1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTimePeriodResponse> getTimePeriodAsync(AxlNetClient.GetTimePeriodReq getTimePeriod)
        {
            return axlPortClient2.getTimePeriodAsync(getTimePeriod);
        }

        public AxlNetClient.StandardResponse removeTimePeriod(AxlNetClient.NameAndGUIDRequest removeTimePeriod1)
        {
            return axlPortClient2.removeTimePeriod(removeTimePeriod1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTimePeriodResponse> removeTimePeriodAsync(AxlNetClient.NameAndGUIDRequest removeTimePeriod)
        {
            return axlPortClient2.removeTimePeriodAsync(removeTimePeriod);
        }

        public AxlNetClient.ListTimePeriodRes listTimePeriod(AxlNetClient.ListTimePeriodReq listTimePeriod1)
        {
            return axlPortClient2.listTimePeriod(listTimePeriod1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTimePeriodResponse> listTimePeriodAsync(AxlNetClient.ListTimePeriodReq listTimePeriod)
        {
            return axlPortClient2.listTimePeriodAsync(listTimePeriod);
        }

        public AxlNetClient.StandardResponse addTimeSchedule(AxlNetClient.AddTimeScheduleReq addTimeSchedule1)
        {
            return axlPortClient2.addTimeSchedule(addTimeSchedule1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTimeScheduleResponse> addTimeScheduleAsync(AxlNetClient.AddTimeScheduleReq addTimeSchedule)
        {
            return axlPortClient2.addTimeScheduleAsync(addTimeSchedule);
        }

        public AxlNetClient.StandardResponse updateTimeSchedule(AxlNetClient.UpdateTimeScheduleReq updateTimeSchedule1)
        {
            return axlPortClient2.updateTimeSchedule(updateTimeSchedule1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTimeScheduleResponse> updateTimeScheduleAsync(AxlNetClient.UpdateTimeScheduleReq updateTimeSchedule)
        {
            return axlPortClient2.updateTimeScheduleAsync(updateTimeSchedule);
        }

        public AxlNetClient.GetTimeScheduleRes getTimeSchedule(AxlNetClient.GetTimeScheduleReq getTimeSchedule1)
        {
            return axlPortClient2.getTimeSchedule(getTimeSchedule1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTimeScheduleResponse> getTimeScheduleAsync(AxlNetClient.GetTimeScheduleReq getTimeSchedule)
        {
            return axlPortClient2.getTimeScheduleAsync(getTimeSchedule);
        }

        public AxlNetClient.StandardResponse removeTimeSchedule(AxlNetClient.NameAndGUIDRequest removeTimeSchedule1)
        {
            return axlPortClient2.removeTimeSchedule(removeTimeSchedule1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTimeScheduleResponse> removeTimeScheduleAsync(AxlNetClient.NameAndGUIDRequest removeTimeSchedule)
        {
            return axlPortClient2.removeTimeScheduleAsync(removeTimeSchedule);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort2
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipTrunkSecurityProfileResponse listSipTrunkSecurityProfile(AxlNetClient.listSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipTrunkSecurityProfileResponse> listSipTrunkSecurityProfileAsync(AxlNetClient.listSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetSipTrunkSecurityProfileResponse resetSipTrunkSecurityProfile(AxlNetClient.resetSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetSipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkSecurityProfileResponse> resetSipTrunkSecurityProfileAsync(AxlNetClient.resetSipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySipTrunkSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applySipTrunkSecurityProfileResponse applySipTrunkSecurityProfile(AxlNetClient.applySipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applySipTrunkSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applySipTrunkSecurityProfileResponse> applySipTrunkSecurityProfileAsync(AxlNetClient.applySipTrunkSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTimePeriod", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTimePeriodResponse addTimePeriod(AxlNetClient.addTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTimePeriod", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTimePeriodResponse> addTimePeriodAsync(AxlNetClient.addTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTimePeriod", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTimePeriodResponse updateTimePeriod(AxlNetClient.updateTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTimePeriod", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTimePeriodResponse> updateTimePeriodAsync(AxlNetClient.updateTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTimePeriod", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTimePeriodResponse getTimePeriod(AxlNetClient.getTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTimePeriod", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTimePeriodResponse> getTimePeriodAsync(AxlNetClient.getTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTimePeriod", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTimePeriodResponse removeTimePeriod(AxlNetClient.removeTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTimePeriod", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTimePeriodResponse> removeTimePeriodAsync(AxlNetClient.removeTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTimePeriod", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTimePeriodResponse listTimePeriod(AxlNetClient.listTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTimePeriod", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTimePeriodResponse> listTimePeriodAsync(AxlNetClient.listTimePeriodRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTimeSchedule", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTimeScheduleResponse addTimeSchedule(AxlNetClient.addTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTimeSchedule", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTimeScheduleResponse> addTimeScheduleAsync(AxlNetClient.addTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTimeSchedule", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTimeScheduleResponse updateTimeSchedule(AxlNetClient.updateTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTimeSchedule", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTimeScheduleResponse> updateTimeScheduleAsync(AxlNetClient.updateTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTimeSchedule", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTimeScheduleResponse getTimeSchedule(AxlNetClient.getTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTimeSchedule", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTimeScheduleResponse> getTimeScheduleAsync(AxlNetClient.getTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTimeSchedule", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTimeScheduleResponse removeTimeSchedule(AxlNetClient.removeTimeScheduleRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTimeSchedule", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTimeScheduleResponse> removeTimeScheduleAsync(AxlNetClient.removeTimeScheduleRequest request);
    }

    public class AXLPortClient2 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort2>, AxlNetClient.AXLPort2
    {
        public AXLPortClient2(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipTrunkSecurityProfileResponse AxlNetClient.AXLPort2.listSipTrunkSecurityProfile(AxlNetClient.listSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.listSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.ListSipTrunkSecurityProfileRes listSipTrunkSecurityProfile(AxlNetClient.ListSipTrunkSecurityProfileReq listSipTrunkSecurityProfile1)
        {
            AxlNetClient.listSipTrunkSecurityProfileRequest inValue = new AxlNetClient.listSipTrunkSecurityProfileRequest();
            inValue.listSipTrunkSecurityProfile = listSipTrunkSecurityProfile1;
            AxlNetClient.listSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort2)(this)).listSipTrunkSecurityProfile(inValue);
            return retVal.listSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort2.listSipTrunkSecurityProfileAsync(AxlNetClient.listSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.listSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipTrunkSecurityProfileResponse> listSipTrunkSecurityProfileAsync(AxlNetClient.ListSipTrunkSecurityProfileReq listSipTrunkSecurityProfile)
        {
            AxlNetClient.listSipTrunkSecurityProfileRequest inValue = new AxlNetClient.listSipTrunkSecurityProfileRequest();
            inValue.listSipTrunkSecurityProfile = listSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort2)(this)).listSipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetSipTrunkSecurityProfileResponse AxlNetClient.AXLPort2.resetSipTrunkSecurityProfile(AxlNetClient.resetSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.resetSipTrunkSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse resetSipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest resetSipTrunkSecurityProfile1)
        {
            AxlNetClient.resetSipTrunkSecurityProfileRequest inValue = new AxlNetClient.resetSipTrunkSecurityProfileRequest();
            inValue.resetSipTrunkSecurityProfile = resetSipTrunkSecurityProfile1;
            AxlNetClient.resetSipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort2)(this)).resetSipTrunkSecurityProfile(inValue);
            return retVal.resetSipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkSecurityProfileResponse> AxlNetClient.AXLPort2.resetSipTrunkSecurityProfileAsync(AxlNetClient.resetSipTrunkSecurityProfileRequest request)
        {
            return base.Channel.resetSipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetSipTrunkSecurityProfileResponse> resetSipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest resetSipTrunkSecurityProfile)
        {
            AxlNetClient.resetSipTrunkSecurityProfileRequest inValue = new AxlNetClient.resetSipTrunkSecurityProfileRequest();
            inValue.resetSipTrunkSecurityProfile = resetSipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort2)(this)).resetSipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applySipTrunkSecurityProfileResponse AxlNetClient.AXLPort2.applySipTrunkSecurityProfile(AxlNetClient.applySipTrunkSecurityProfileRequest request)
        {
            return base.Channel.applySipTrunkSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse applySipTrunkSecurityProfile(AxlNetClient.NameAndGUIDRequest applySipTrunkSecurityProfile1)
        {
            AxlNetClient.applySipTrunkSecurityProfileRequest inValue = new AxlNetClient.applySipTrunkSecurityProfileRequest();
            inValue.applySipTrunkSecurityProfile = applySipTrunkSecurityProfile1;
            AxlNetClient.applySipTrunkSecurityProfileResponse retVal = ((AxlNetClient.AXLPort2)(this)).applySipTrunkSecurityProfile(inValue);
            return retVal.applySipTrunkSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applySipTrunkSecurityProfileResponse> AxlNetClient.AXLPort2.applySipTrunkSecurityProfileAsync(AxlNetClient.applySipTrunkSecurityProfileRequest request)
        {
            return base.Channel.applySipTrunkSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applySipTrunkSecurityProfileResponse> applySipTrunkSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest applySipTrunkSecurityProfile)
        {
            AxlNetClient.applySipTrunkSecurityProfileRequest inValue = new AxlNetClient.applySipTrunkSecurityProfileRequest();
            inValue.applySipTrunkSecurityProfile = applySipTrunkSecurityProfile;
            return ((AxlNetClient.AXLPort2)(this)).applySipTrunkSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTimePeriodResponse AxlNetClient.AXLPort2.addTimePeriod(AxlNetClient.addTimePeriodRequest request)
        {
            return base.Channel.addTimePeriod(request);
        }

        public AxlNetClient.StandardResponse addTimePeriod(AxlNetClient.AddTimePeriodReq addTimePeriod1)
        {
            AxlNetClient.addTimePeriodRequest inValue = new AxlNetClient.addTimePeriodRequest();
            inValue.addTimePeriod = addTimePeriod1;
            AxlNetClient.addTimePeriodResponse retVal = ((AxlNetClient.AXLPort2)(this)).addTimePeriod(inValue);
            return retVal.addTimePeriodResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTimePeriodResponse> AxlNetClient.AXLPort2.addTimePeriodAsync(AxlNetClient.addTimePeriodRequest request)
        {
            return base.Channel.addTimePeriodAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTimePeriodResponse> addTimePeriodAsync(AxlNetClient.AddTimePeriodReq addTimePeriod)
        {
            AxlNetClient.addTimePeriodRequest inValue = new AxlNetClient.addTimePeriodRequest();
            inValue.addTimePeriod = addTimePeriod;
            return ((AxlNetClient.AXLPort2)(this)).addTimePeriodAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTimePeriodResponse AxlNetClient.AXLPort2.updateTimePeriod(AxlNetClient.updateTimePeriodRequest request)
        {
            return base.Channel.updateTimePeriod(request);
        }

        public AxlNetClient.StandardResponse updateTimePeriod(AxlNetClient.UpdateTimePeriodReq updateTimePeriod1)
        {
            AxlNetClient.updateTimePeriodRequest inValue = new AxlNetClient.updateTimePeriodRequest();
            inValue.updateTimePeriod = updateTimePeriod1;
            AxlNetClient.updateTimePeriodResponse retVal = ((AxlNetClient.AXLPort2)(this)).updateTimePeriod(inValue);
            return retVal.updateTimePeriodResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTimePeriodResponse> AxlNetClient.AXLPort2.updateTimePeriodAsync(AxlNetClient.updateTimePeriodRequest request)
        {
            return base.Channel.updateTimePeriodAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTimePeriodResponse> updateTimePeriodAsync(AxlNetClient.UpdateTimePeriodReq updateTimePeriod)
        {
            AxlNetClient.updateTimePeriodRequest inValue = new AxlNetClient.updateTimePeriodRequest();
            inValue.updateTimePeriod = updateTimePeriod;
            return ((AxlNetClient.AXLPort2)(this)).updateTimePeriodAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTimePeriodResponse AxlNetClient.AXLPort2.getTimePeriod(AxlNetClient.getTimePeriodRequest request)
        {
            return base.Channel.getTimePeriod(request);
        }

        public AxlNetClient.GetTimePeriodRes getTimePeriod(AxlNetClient.GetTimePeriodReq getTimePeriod1)
        {
            AxlNetClient.getTimePeriodRequest inValue = new AxlNetClient.getTimePeriodRequest();
            inValue.getTimePeriod = getTimePeriod1;
            AxlNetClient.getTimePeriodResponse retVal = ((AxlNetClient.AXLPort2)(this)).getTimePeriod(inValue);
            return retVal.getTimePeriodResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTimePeriodResponse> AxlNetClient.AXLPort2.getTimePeriodAsync(AxlNetClient.getTimePeriodRequest request)
        {
            return base.Channel.getTimePeriodAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTimePeriodResponse> getTimePeriodAsync(AxlNetClient.GetTimePeriodReq getTimePeriod)
        {
            AxlNetClient.getTimePeriodRequest inValue = new AxlNetClient.getTimePeriodRequest();
            inValue.getTimePeriod = getTimePeriod;
            return ((AxlNetClient.AXLPort2)(this)).getTimePeriodAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTimePeriodResponse AxlNetClient.AXLPort2.removeTimePeriod(AxlNetClient.removeTimePeriodRequest request)
        {
            return base.Channel.removeTimePeriod(request);
        }

        public AxlNetClient.StandardResponse removeTimePeriod(AxlNetClient.NameAndGUIDRequest removeTimePeriod1)
        {
            AxlNetClient.removeTimePeriodRequest inValue = new AxlNetClient.removeTimePeriodRequest();
            inValue.removeTimePeriod = removeTimePeriod1;
            AxlNetClient.removeTimePeriodResponse retVal = ((AxlNetClient.AXLPort2)(this)).removeTimePeriod(inValue);
            return retVal.removeTimePeriodResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTimePeriodResponse> AxlNetClient.AXLPort2.removeTimePeriodAsync(AxlNetClient.removeTimePeriodRequest request)
        {
            return base.Channel.removeTimePeriodAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTimePeriodResponse> removeTimePeriodAsync(AxlNetClient.NameAndGUIDRequest removeTimePeriod)
        {
            AxlNetClient.removeTimePeriodRequest inValue = new AxlNetClient.removeTimePeriodRequest();
            inValue.removeTimePeriod = removeTimePeriod;
            return ((AxlNetClient.AXLPort2)(this)).removeTimePeriodAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTimePeriodResponse AxlNetClient.AXLPort2.listTimePeriod(AxlNetClient.listTimePeriodRequest request)
        {
            return base.Channel.listTimePeriod(request);
        }

        public AxlNetClient.ListTimePeriodRes listTimePeriod(AxlNetClient.ListTimePeriodReq listTimePeriod1)
        {
            AxlNetClient.listTimePeriodRequest inValue = new AxlNetClient.listTimePeriodRequest();
            inValue.listTimePeriod = listTimePeriod1;
            AxlNetClient.listTimePeriodResponse retVal = ((AxlNetClient.AXLPort2)(this)).listTimePeriod(inValue);
            return retVal.listTimePeriodResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTimePeriodResponse> AxlNetClient.AXLPort2.listTimePeriodAsync(AxlNetClient.listTimePeriodRequest request)
        {
            return base.Channel.listTimePeriodAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTimePeriodResponse> listTimePeriodAsync(AxlNetClient.ListTimePeriodReq listTimePeriod)
        {
            AxlNetClient.listTimePeriodRequest inValue = new AxlNetClient.listTimePeriodRequest();
            inValue.listTimePeriod = listTimePeriod;
            return ((AxlNetClient.AXLPort2)(this)).listTimePeriodAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTimeScheduleResponse AxlNetClient.AXLPort2.addTimeSchedule(AxlNetClient.addTimeScheduleRequest request)
        {
            return base.Channel.addTimeSchedule(request);
        }

        public AxlNetClient.StandardResponse addTimeSchedule(AxlNetClient.AddTimeScheduleReq addTimeSchedule1)
        {
            AxlNetClient.addTimeScheduleRequest inValue = new AxlNetClient.addTimeScheduleRequest();
            inValue.addTimeSchedule = addTimeSchedule1;
            AxlNetClient.addTimeScheduleResponse retVal = ((AxlNetClient.AXLPort2)(this)).addTimeSchedule(inValue);
            return retVal.addTimeScheduleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTimeScheduleResponse> AxlNetClient.AXLPort2.addTimeScheduleAsync(AxlNetClient.addTimeScheduleRequest request)
        {
            return base.Channel.addTimeScheduleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTimeScheduleResponse> addTimeScheduleAsync(AxlNetClient.AddTimeScheduleReq addTimeSchedule)
        {
            AxlNetClient.addTimeScheduleRequest inValue = new AxlNetClient.addTimeScheduleRequest();
            inValue.addTimeSchedule = addTimeSchedule;
            return ((AxlNetClient.AXLPort2)(this)).addTimeScheduleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTimeScheduleResponse AxlNetClient.AXLPort2.updateTimeSchedule(AxlNetClient.updateTimeScheduleRequest request)
        {
            return base.Channel.updateTimeSchedule(request);
        }

        public AxlNetClient.StandardResponse updateTimeSchedule(AxlNetClient.UpdateTimeScheduleReq updateTimeSchedule1)
        {
            AxlNetClient.updateTimeScheduleRequest inValue = new AxlNetClient.updateTimeScheduleRequest();
            inValue.updateTimeSchedule = updateTimeSchedule1;
            AxlNetClient.updateTimeScheduleResponse retVal = ((AxlNetClient.AXLPort2)(this)).updateTimeSchedule(inValue);
            return retVal.updateTimeScheduleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTimeScheduleResponse> AxlNetClient.AXLPort2.updateTimeScheduleAsync(AxlNetClient.updateTimeScheduleRequest request)
        {
            return base.Channel.updateTimeScheduleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTimeScheduleResponse> updateTimeScheduleAsync(AxlNetClient.UpdateTimeScheduleReq updateTimeSchedule)
        {
            AxlNetClient.updateTimeScheduleRequest inValue = new AxlNetClient.updateTimeScheduleRequest();
            inValue.updateTimeSchedule = updateTimeSchedule;
            return ((AxlNetClient.AXLPort2)(this)).updateTimeScheduleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTimeScheduleResponse AxlNetClient.AXLPort2.getTimeSchedule(AxlNetClient.getTimeScheduleRequest request)
        {
            return base.Channel.getTimeSchedule(request);
        }

        public AxlNetClient.GetTimeScheduleRes getTimeSchedule(AxlNetClient.GetTimeScheduleReq getTimeSchedule1)
        {
            AxlNetClient.getTimeScheduleRequest inValue = new AxlNetClient.getTimeScheduleRequest();
            inValue.getTimeSchedule = getTimeSchedule1;
            AxlNetClient.getTimeScheduleResponse retVal = ((AxlNetClient.AXLPort2)(this)).getTimeSchedule(inValue);
            return retVal.getTimeScheduleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTimeScheduleResponse> AxlNetClient.AXLPort2.getTimeScheduleAsync(AxlNetClient.getTimeScheduleRequest request)
        {
            return base.Channel.getTimeScheduleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTimeScheduleResponse> getTimeScheduleAsync(AxlNetClient.GetTimeScheduleReq getTimeSchedule)
        {
            AxlNetClient.getTimeScheduleRequest inValue = new AxlNetClient.getTimeScheduleRequest();
            inValue.getTimeSchedule = getTimeSchedule;
            return ((AxlNetClient.AXLPort2)(this)).getTimeScheduleAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTimeScheduleResponse AxlNetClient.AXLPort2.removeTimeSchedule(AxlNetClient.removeTimeScheduleRequest request)
        {
            return base.Channel.removeTimeSchedule(request);
        }

        public AxlNetClient.StandardResponse removeTimeSchedule(AxlNetClient.NameAndGUIDRequest removeTimeSchedule1)
        {
            AxlNetClient.removeTimeScheduleRequest inValue = new AxlNetClient.removeTimeScheduleRequest();
            inValue.removeTimeSchedule = removeTimeSchedule1;
            AxlNetClient.removeTimeScheduleResponse retVal = ((AxlNetClient.AXLPort2)(this)).removeTimeSchedule(inValue);
            return retVal.removeTimeScheduleResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTimeScheduleResponse> AxlNetClient.AXLPort2.removeTimeScheduleAsync(AxlNetClient.removeTimeScheduleRequest request)
        {
            return base.Channel.removeTimeScheduleAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTimeScheduleResponse> removeTimeScheduleAsync(AxlNetClient.NameAndGUIDRequest removeTimeSchedule)
        {
            AxlNetClient.removeTimeScheduleRequest inValue = new AxlNetClient.removeTimeScheduleRequest();
            inValue.removeTimeSchedule = removeTimeSchedule;
            return ((AxlNetClient.AXLPort2)(this)).removeTimeScheduleAsync(inValue);
        }
    }
}