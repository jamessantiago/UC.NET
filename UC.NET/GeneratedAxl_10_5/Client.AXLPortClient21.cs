namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient21 _axlPortClient21;

        private static AXLPortClient21 axlPortClient21 => _axlPortClient21 == null ||
            _axlPortClient21.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient21 = LoadClient21()) : _axlPortClient21;

        private static AXLPortClient21 LoadClient21()
        {
            var client = new AXLPortClient21(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close21;
            OnAbort += Abort21;
            return client;
        }

        private static void Close21(object sender, System.EventArgs e)
        {
            _axlPortClient21.Close();
        }

        private static void Abort21(object sender, System.EventArgs e)
        {
            _axlPortClient21.Abort();
        }

        public AxlNetClient.StandardResponse updateDirectedCallPark(AxlNetClient.UpdateDirectedCallParkReq updateDirectedCallPark1)
        {
            return axlPortClient21.updateDirectedCallPark(updateDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirectedCallParkResponse> updateDirectedCallParkAsync(AxlNetClient.UpdateDirectedCallParkReq updateDirectedCallPark)
        {
            return axlPortClient21.updateDirectedCallParkAsync(updateDirectedCallPark);
        }

        public AxlNetClient.GetDirectedCallParkRes getDirectedCallPark(AxlNetClient.GetDirectedCallParkReq getDirectedCallPark1)
        {
            return axlPortClient21.getDirectedCallPark(getDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirectedCallParkResponse> getDirectedCallParkAsync(AxlNetClient.GetDirectedCallParkReq getDirectedCallPark)
        {
            return axlPortClient21.getDirectedCallParkAsync(getDirectedCallPark);
        }

        public AxlNetClient.StandardResponse removeDirectedCallPark(AxlNetClient.RemoveDirectedCallParkReq removeDirectedCallPark1)
        {
            return axlPortClient21.removeDirectedCallPark(removeDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirectedCallParkResponse> removeDirectedCallParkAsync(AxlNetClient.RemoveDirectedCallParkReq removeDirectedCallPark)
        {
            return axlPortClient21.removeDirectedCallParkAsync(removeDirectedCallPark);
        }

        public AxlNetClient.ListDirectedCallParkRes listDirectedCallPark(AxlNetClient.ListDirectedCallParkReq listDirectedCallPark1)
        {
            return axlPortClient21.listDirectedCallPark(listDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirectedCallParkResponse> listDirectedCallParkAsync(AxlNetClient.ListDirectedCallParkReq listDirectedCallPark)
        {
            return axlPortClient21.listDirectedCallParkAsync(listDirectedCallPark);
        }

        public AxlNetClient.StandardResponse resetDirectedCallPark(AxlNetClient.ResetDirectedCallParkReq resetDirectedCallPark1)
        {
            return axlPortClient21.resetDirectedCallPark(resetDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDirectedCallParkResponse> resetDirectedCallParkAsync(AxlNetClient.ResetDirectedCallParkReq resetDirectedCallPark)
        {
            return axlPortClient21.resetDirectedCallParkAsync(resetDirectedCallPark);
        }

        public AxlNetClient.StandardResponse applyDirectedCallPark(AxlNetClient.ApplyDirectedCallParkReq applyDirectedCallPark1)
        {
            return axlPortClient21.applyDirectedCallPark(applyDirectedCallPark1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDirectedCallParkResponse> applyDirectedCallParkAsync(AxlNetClient.ApplyDirectedCallParkReq applyDirectedCallPark)
        {
            return axlPortClient21.applyDirectedCallParkAsync(applyDirectedCallPark);
        }

        public AxlNetClient.StandardResponse addMeetMe(AxlNetClient.AddMeetMeReq addMeetMe1)
        {
            return axlPortClient21.addMeetMe(addMeetMe1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMeetMeResponse> addMeetMeAsync(AxlNetClient.AddMeetMeReq addMeetMe)
        {
            return axlPortClient21.addMeetMeAsync(addMeetMe);
        }

        public AxlNetClient.StandardResponse updateMeetMe(AxlNetClient.UpdateMeetMeReq updateMeetMe1)
        {
            return axlPortClient21.updateMeetMe(updateMeetMe1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMeetMeResponse> updateMeetMeAsync(AxlNetClient.UpdateMeetMeReq updateMeetMe)
        {
            return axlPortClient21.updateMeetMeAsync(updateMeetMe);
        }

        public AxlNetClient.GetMeetMeRes getMeetMe(AxlNetClient.GetMeetMeReq getMeetMe1)
        {
            return axlPortClient21.getMeetMe(getMeetMe1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMeetMeResponse> getMeetMeAsync(AxlNetClient.GetMeetMeReq getMeetMe)
        {
            return axlPortClient21.getMeetMeAsync(getMeetMe);
        }

        public AxlNetClient.StandardResponse removeMeetMe(AxlNetClient.RemoveMeetMeReq removeMeetMe1)
        {
            return axlPortClient21.removeMeetMe(removeMeetMe1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMeetMeResponse> removeMeetMeAsync(AxlNetClient.RemoveMeetMeReq removeMeetMe)
        {
            return axlPortClient21.removeMeetMeAsync(removeMeetMe);
        }

        public AxlNetClient.ListMeetMeRes listMeetMe(AxlNetClient.ListMeetMeReq listMeetMe1)
        {
            return axlPortClient21.listMeetMe(listMeetMe1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMeetMeResponse> listMeetMeAsync(AxlNetClient.ListMeetMeReq listMeetMe)
        {
            return axlPortClient21.listMeetMeAsync(listMeetMe);
        }

        public AxlNetClient.StandardResponse addMobileVoiceAccess(AxlNetClient.AddMobileVoiceAccessReq addMobileVoiceAccess1)
        {
            return axlPortClient21.addMobileVoiceAccess(addMobileVoiceAccess1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobileVoiceAccessResponse> addMobileVoiceAccessAsync(AxlNetClient.AddMobileVoiceAccessReq addMobileVoiceAccess)
        {
            return axlPortClient21.addMobileVoiceAccessAsync(addMobileVoiceAccess);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort21
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDirectedCallParkResponse updateDirectedCallPark(AxlNetClient.updateDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDirectedCallParkResponse> updateDirectedCallParkAsync(AxlNetClient.updateDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDirectedCallParkResponse getDirectedCallPark(AxlNetClient.getDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDirectedCallParkResponse> getDirectedCallParkAsync(AxlNetClient.getDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDirectedCallParkResponse removeDirectedCallPark(AxlNetClient.removeDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDirectedCallParkResponse> removeDirectedCallParkAsync(AxlNetClient.removeDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDirectedCallParkResponse listDirectedCallPark(AxlNetClient.listDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDirectedCallParkResponse> listDirectedCallParkAsync(AxlNetClient.listDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetDirectedCallParkResponse resetDirectedCallPark(AxlNetClient.resetDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetDirectedCallParkResponse> resetDirectedCallParkAsync(AxlNetClient.resetDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDirectedCallPark", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyDirectedCallParkResponse applyDirectedCallPark(AxlNetClient.applyDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyDirectedCallPark", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyDirectedCallParkResponse> applyDirectedCallParkAsync(AxlNetClient.applyDirectedCallParkRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMeetMe", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMeetMeResponse addMeetMe(AxlNetClient.addMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMeetMe", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMeetMeResponse> addMeetMeAsync(AxlNetClient.addMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMeetMe", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateMeetMeResponse updateMeetMe(AxlNetClient.updateMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateMeetMe", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateMeetMeResponse> updateMeetMeAsync(AxlNetClient.updateMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMeetMe", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getMeetMeResponse getMeetMe(AxlNetClient.getMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getMeetMe", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getMeetMeResponse> getMeetMeAsync(AxlNetClient.getMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMeetMe", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeMeetMeResponse removeMeetMe(AxlNetClient.removeMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeMeetMe", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeMeetMeResponse> removeMeetMeAsync(AxlNetClient.removeMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMeetMe", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listMeetMeResponse listMeetMe(AxlNetClient.listMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listMeetMe", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listMeetMeResponse> listMeetMeAsync(AxlNetClient.listMeetMeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobileVoiceAccess", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addMobileVoiceAccessResponse addMobileVoiceAccess(AxlNetClient.addMobileVoiceAccessRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addMobileVoiceAccess", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addMobileVoiceAccessResponse> addMobileVoiceAccessAsync(AxlNetClient.addMobileVoiceAccessRequest request);
    }

    public class AXLPortClient21 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort21>, AxlNetClient.AXLPort21
    {
        public AXLPortClient21(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDirectedCallParkResponse AxlNetClient.AXLPort21.updateDirectedCallPark(AxlNetClient.updateDirectedCallParkRequest request)
        {
            return base.Channel.updateDirectedCallPark(request);
        }

        public AxlNetClient.StandardResponse updateDirectedCallPark(AxlNetClient.UpdateDirectedCallParkReq updateDirectedCallPark1)
        {
            AxlNetClient.updateDirectedCallParkRequest inValue = new AxlNetClient.updateDirectedCallParkRequest();
            inValue.updateDirectedCallPark = updateDirectedCallPark1;
            AxlNetClient.updateDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).updateDirectedCallPark(inValue);
            return retVal.updateDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDirectedCallParkResponse> AxlNetClient.AXLPort21.updateDirectedCallParkAsync(AxlNetClient.updateDirectedCallParkRequest request)
        {
            return base.Channel.updateDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDirectedCallParkResponse> updateDirectedCallParkAsync(AxlNetClient.UpdateDirectedCallParkReq updateDirectedCallPark)
        {
            AxlNetClient.updateDirectedCallParkRequest inValue = new AxlNetClient.updateDirectedCallParkRequest();
            inValue.updateDirectedCallPark = updateDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).updateDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDirectedCallParkResponse AxlNetClient.AXLPort21.getDirectedCallPark(AxlNetClient.getDirectedCallParkRequest request)
        {
            return base.Channel.getDirectedCallPark(request);
        }

        public AxlNetClient.GetDirectedCallParkRes getDirectedCallPark(AxlNetClient.GetDirectedCallParkReq getDirectedCallPark1)
        {
            AxlNetClient.getDirectedCallParkRequest inValue = new AxlNetClient.getDirectedCallParkRequest();
            inValue.getDirectedCallPark = getDirectedCallPark1;
            AxlNetClient.getDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).getDirectedCallPark(inValue);
            return retVal.getDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDirectedCallParkResponse> AxlNetClient.AXLPort21.getDirectedCallParkAsync(AxlNetClient.getDirectedCallParkRequest request)
        {
            return base.Channel.getDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDirectedCallParkResponse> getDirectedCallParkAsync(AxlNetClient.GetDirectedCallParkReq getDirectedCallPark)
        {
            AxlNetClient.getDirectedCallParkRequest inValue = new AxlNetClient.getDirectedCallParkRequest();
            inValue.getDirectedCallPark = getDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).getDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDirectedCallParkResponse AxlNetClient.AXLPort21.removeDirectedCallPark(AxlNetClient.removeDirectedCallParkRequest request)
        {
            return base.Channel.removeDirectedCallPark(request);
        }

        public AxlNetClient.StandardResponse removeDirectedCallPark(AxlNetClient.RemoveDirectedCallParkReq removeDirectedCallPark1)
        {
            AxlNetClient.removeDirectedCallParkRequest inValue = new AxlNetClient.removeDirectedCallParkRequest();
            inValue.removeDirectedCallPark = removeDirectedCallPark1;
            AxlNetClient.removeDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).removeDirectedCallPark(inValue);
            return retVal.removeDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDirectedCallParkResponse> AxlNetClient.AXLPort21.removeDirectedCallParkAsync(AxlNetClient.removeDirectedCallParkRequest request)
        {
            return base.Channel.removeDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDirectedCallParkResponse> removeDirectedCallParkAsync(AxlNetClient.RemoveDirectedCallParkReq removeDirectedCallPark)
        {
            AxlNetClient.removeDirectedCallParkRequest inValue = new AxlNetClient.removeDirectedCallParkRequest();
            inValue.removeDirectedCallPark = removeDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).removeDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDirectedCallParkResponse AxlNetClient.AXLPort21.listDirectedCallPark(AxlNetClient.listDirectedCallParkRequest request)
        {
            return base.Channel.listDirectedCallPark(request);
        }

        public AxlNetClient.ListDirectedCallParkRes listDirectedCallPark(AxlNetClient.ListDirectedCallParkReq listDirectedCallPark1)
        {
            AxlNetClient.listDirectedCallParkRequest inValue = new AxlNetClient.listDirectedCallParkRequest();
            inValue.listDirectedCallPark = listDirectedCallPark1;
            AxlNetClient.listDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).listDirectedCallPark(inValue);
            return retVal.listDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDirectedCallParkResponse> AxlNetClient.AXLPort21.listDirectedCallParkAsync(AxlNetClient.listDirectedCallParkRequest request)
        {
            return base.Channel.listDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDirectedCallParkResponse> listDirectedCallParkAsync(AxlNetClient.ListDirectedCallParkReq listDirectedCallPark)
        {
            AxlNetClient.listDirectedCallParkRequest inValue = new AxlNetClient.listDirectedCallParkRequest();
            inValue.listDirectedCallPark = listDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).listDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetDirectedCallParkResponse AxlNetClient.AXLPort21.resetDirectedCallPark(AxlNetClient.resetDirectedCallParkRequest request)
        {
            return base.Channel.resetDirectedCallPark(request);
        }

        public AxlNetClient.StandardResponse resetDirectedCallPark(AxlNetClient.ResetDirectedCallParkReq resetDirectedCallPark1)
        {
            AxlNetClient.resetDirectedCallParkRequest inValue = new AxlNetClient.resetDirectedCallParkRequest();
            inValue.resetDirectedCallPark = resetDirectedCallPark1;
            AxlNetClient.resetDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).resetDirectedCallPark(inValue);
            return retVal.resetDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetDirectedCallParkResponse> AxlNetClient.AXLPort21.resetDirectedCallParkAsync(AxlNetClient.resetDirectedCallParkRequest request)
        {
            return base.Channel.resetDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDirectedCallParkResponse> resetDirectedCallParkAsync(AxlNetClient.ResetDirectedCallParkReq resetDirectedCallPark)
        {
            AxlNetClient.resetDirectedCallParkRequest inValue = new AxlNetClient.resetDirectedCallParkRequest();
            inValue.resetDirectedCallPark = resetDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).resetDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyDirectedCallParkResponse AxlNetClient.AXLPort21.applyDirectedCallPark(AxlNetClient.applyDirectedCallParkRequest request)
        {
            return base.Channel.applyDirectedCallPark(request);
        }

        public AxlNetClient.StandardResponse applyDirectedCallPark(AxlNetClient.ApplyDirectedCallParkReq applyDirectedCallPark1)
        {
            AxlNetClient.applyDirectedCallParkRequest inValue = new AxlNetClient.applyDirectedCallParkRequest();
            inValue.applyDirectedCallPark = applyDirectedCallPark1;
            AxlNetClient.applyDirectedCallParkResponse retVal = ((AxlNetClient.AXLPort21)(this)).applyDirectedCallPark(inValue);
            return retVal.applyDirectedCallParkResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyDirectedCallParkResponse> AxlNetClient.AXLPort21.applyDirectedCallParkAsync(AxlNetClient.applyDirectedCallParkRequest request)
        {
            return base.Channel.applyDirectedCallParkAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyDirectedCallParkResponse> applyDirectedCallParkAsync(AxlNetClient.ApplyDirectedCallParkReq applyDirectedCallPark)
        {
            AxlNetClient.applyDirectedCallParkRequest inValue = new AxlNetClient.applyDirectedCallParkRequest();
            inValue.applyDirectedCallPark = applyDirectedCallPark;
            return ((AxlNetClient.AXLPort21)(this)).applyDirectedCallParkAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMeetMeResponse AxlNetClient.AXLPort21.addMeetMe(AxlNetClient.addMeetMeRequest request)
        {
            return base.Channel.addMeetMe(request);
        }

        public AxlNetClient.StandardResponse addMeetMe(AxlNetClient.AddMeetMeReq addMeetMe1)
        {
            AxlNetClient.addMeetMeRequest inValue = new AxlNetClient.addMeetMeRequest();
            inValue.addMeetMe = addMeetMe1;
            AxlNetClient.addMeetMeResponse retVal = ((AxlNetClient.AXLPort21)(this)).addMeetMe(inValue);
            return retVal.addMeetMeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMeetMeResponse> AxlNetClient.AXLPort21.addMeetMeAsync(AxlNetClient.addMeetMeRequest request)
        {
            return base.Channel.addMeetMeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMeetMeResponse> addMeetMeAsync(AxlNetClient.AddMeetMeReq addMeetMe)
        {
            AxlNetClient.addMeetMeRequest inValue = new AxlNetClient.addMeetMeRequest();
            inValue.addMeetMe = addMeetMe;
            return ((AxlNetClient.AXLPort21)(this)).addMeetMeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateMeetMeResponse AxlNetClient.AXLPort21.updateMeetMe(AxlNetClient.updateMeetMeRequest request)
        {
            return base.Channel.updateMeetMe(request);
        }

        public AxlNetClient.StandardResponse updateMeetMe(AxlNetClient.UpdateMeetMeReq updateMeetMe1)
        {
            AxlNetClient.updateMeetMeRequest inValue = new AxlNetClient.updateMeetMeRequest();
            inValue.updateMeetMe = updateMeetMe1;
            AxlNetClient.updateMeetMeResponse retVal = ((AxlNetClient.AXLPort21)(this)).updateMeetMe(inValue);
            return retVal.updateMeetMeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateMeetMeResponse> AxlNetClient.AXLPort21.updateMeetMeAsync(AxlNetClient.updateMeetMeRequest request)
        {
            return base.Channel.updateMeetMeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateMeetMeResponse> updateMeetMeAsync(AxlNetClient.UpdateMeetMeReq updateMeetMe)
        {
            AxlNetClient.updateMeetMeRequest inValue = new AxlNetClient.updateMeetMeRequest();
            inValue.updateMeetMe = updateMeetMe;
            return ((AxlNetClient.AXLPort21)(this)).updateMeetMeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getMeetMeResponse AxlNetClient.AXLPort21.getMeetMe(AxlNetClient.getMeetMeRequest request)
        {
            return base.Channel.getMeetMe(request);
        }

        public AxlNetClient.GetMeetMeRes getMeetMe(AxlNetClient.GetMeetMeReq getMeetMe1)
        {
            AxlNetClient.getMeetMeRequest inValue = new AxlNetClient.getMeetMeRequest();
            inValue.getMeetMe = getMeetMe1;
            AxlNetClient.getMeetMeResponse retVal = ((AxlNetClient.AXLPort21)(this)).getMeetMe(inValue);
            return retVal.getMeetMeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getMeetMeResponse> AxlNetClient.AXLPort21.getMeetMeAsync(AxlNetClient.getMeetMeRequest request)
        {
            return base.Channel.getMeetMeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getMeetMeResponse> getMeetMeAsync(AxlNetClient.GetMeetMeReq getMeetMe)
        {
            AxlNetClient.getMeetMeRequest inValue = new AxlNetClient.getMeetMeRequest();
            inValue.getMeetMe = getMeetMe;
            return ((AxlNetClient.AXLPort21)(this)).getMeetMeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeMeetMeResponse AxlNetClient.AXLPort21.removeMeetMe(AxlNetClient.removeMeetMeRequest request)
        {
            return base.Channel.removeMeetMe(request);
        }

        public AxlNetClient.StandardResponse removeMeetMe(AxlNetClient.RemoveMeetMeReq removeMeetMe1)
        {
            AxlNetClient.removeMeetMeRequest inValue = new AxlNetClient.removeMeetMeRequest();
            inValue.removeMeetMe = removeMeetMe1;
            AxlNetClient.removeMeetMeResponse retVal = ((AxlNetClient.AXLPort21)(this)).removeMeetMe(inValue);
            return retVal.removeMeetMeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeMeetMeResponse> AxlNetClient.AXLPort21.removeMeetMeAsync(AxlNetClient.removeMeetMeRequest request)
        {
            return base.Channel.removeMeetMeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeMeetMeResponse> removeMeetMeAsync(AxlNetClient.RemoveMeetMeReq removeMeetMe)
        {
            AxlNetClient.removeMeetMeRequest inValue = new AxlNetClient.removeMeetMeRequest();
            inValue.removeMeetMe = removeMeetMe;
            return ((AxlNetClient.AXLPort21)(this)).removeMeetMeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listMeetMeResponse AxlNetClient.AXLPort21.listMeetMe(AxlNetClient.listMeetMeRequest request)
        {
            return base.Channel.listMeetMe(request);
        }

        public AxlNetClient.ListMeetMeRes listMeetMe(AxlNetClient.ListMeetMeReq listMeetMe1)
        {
            AxlNetClient.listMeetMeRequest inValue = new AxlNetClient.listMeetMeRequest();
            inValue.listMeetMe = listMeetMe1;
            AxlNetClient.listMeetMeResponse retVal = ((AxlNetClient.AXLPort21)(this)).listMeetMe(inValue);
            return retVal.listMeetMeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listMeetMeResponse> AxlNetClient.AXLPort21.listMeetMeAsync(AxlNetClient.listMeetMeRequest request)
        {
            return base.Channel.listMeetMeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listMeetMeResponse> listMeetMeAsync(AxlNetClient.ListMeetMeReq listMeetMe)
        {
            AxlNetClient.listMeetMeRequest inValue = new AxlNetClient.listMeetMeRequest();
            inValue.listMeetMe = listMeetMe;
            return ((AxlNetClient.AXLPort21)(this)).listMeetMeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addMobileVoiceAccessResponse AxlNetClient.AXLPort21.addMobileVoiceAccess(AxlNetClient.addMobileVoiceAccessRequest request)
        {
            return base.Channel.addMobileVoiceAccess(request);
        }

        public AxlNetClient.StandardResponse addMobileVoiceAccess(AxlNetClient.AddMobileVoiceAccessReq addMobileVoiceAccess1)
        {
            AxlNetClient.addMobileVoiceAccessRequest inValue = new AxlNetClient.addMobileVoiceAccessRequest();
            inValue.addMobileVoiceAccess = addMobileVoiceAccess1;
            AxlNetClient.addMobileVoiceAccessResponse retVal = ((AxlNetClient.AXLPort21)(this)).addMobileVoiceAccess(inValue);
            return retVal.addMobileVoiceAccessResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addMobileVoiceAccessResponse> AxlNetClient.AXLPort21.addMobileVoiceAccessAsync(AxlNetClient.addMobileVoiceAccessRequest request)
        {
            return base.Channel.addMobileVoiceAccessAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addMobileVoiceAccessResponse> addMobileVoiceAccessAsync(AxlNetClient.AddMobileVoiceAccessReq addMobileVoiceAccess)
        {
            AxlNetClient.addMobileVoiceAccessRequest inValue = new AxlNetClient.addMobileVoiceAccessRequest();
            inValue.addMobileVoiceAccess = addMobileVoiceAccess;
            return ((AxlNetClient.AXLPort21)(this)).addMobileVoiceAccessAsync(inValue);
        }
    }
}