namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient40 _axlPortClient40;

        private static AXLPortClient40 axlPortClient40 => _axlPortClient40 == null ||
            _axlPortClient40.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient40 = LoadClient40()) : _axlPortClient40;

        private static AXLPortClient40 LoadClient40()
        {
            var client = new AXLPortClient40(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close40;
            OnAbort += Abort40;
            return client;
        }

        private static void Close40(object sender, System.EventArgs e)
        {
            _axlPortClient40.Close();
        }

        private static void Abort40(object sender, System.EventArgs e)
        {
            _axlPortClient40.Abort();
        }

        public AxlNetClient.StandardResponse updateRemoteDestinationProfile(AxlNetClient.UpdateRemoteDestinationProfileReq updateRemoteDestinationProfile1)
        {
            return axlPortClient40.updateRemoteDestinationProfile(updateRemoteDestinationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationProfileResponse> updateRemoteDestinationProfileAsync(AxlNetClient.UpdateRemoteDestinationProfileReq updateRemoteDestinationProfile)
        {
            return axlPortClient40.updateRemoteDestinationProfileAsync(updateRemoteDestinationProfile);
        }

        public AxlNetClient.GetRemoteDestinationProfileRes getRemoteDestinationProfile(AxlNetClient.GetRemoteDestinationProfileReq getRemoteDestinationProfile1)
        {
            return axlPortClient40.getRemoteDestinationProfile(getRemoteDestinationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationProfileResponse> getRemoteDestinationProfileAsync(AxlNetClient.GetRemoteDestinationProfileReq getRemoteDestinationProfile)
        {
            return axlPortClient40.getRemoteDestinationProfileAsync(getRemoteDestinationProfile);
        }

        public AxlNetClient.StandardResponse removeRemoteDestinationProfile(AxlNetClient.NameAndGUIDRequest removeRemoteDestinationProfile1)
        {
            return axlPortClient40.removeRemoteDestinationProfile(removeRemoteDestinationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationProfileResponse> removeRemoteDestinationProfileAsync(AxlNetClient.NameAndGUIDRequest removeRemoteDestinationProfile)
        {
            return axlPortClient40.removeRemoteDestinationProfileAsync(removeRemoteDestinationProfile);
        }

        public AxlNetClient.ListRemoteDestinationProfileRes listRemoteDestinationProfile(AxlNetClient.ListRemoteDestinationProfileReq listRemoteDestinationProfile1)
        {
            return axlPortClient40.listRemoteDestinationProfile(listRemoteDestinationProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationProfileResponse> listRemoteDestinationProfileAsync(AxlNetClient.ListRemoteDestinationProfileReq listRemoteDestinationProfile)
        {
            return axlPortClient40.listRemoteDestinationProfileAsync(listRemoteDestinationProfile);
        }

        public AxlNetClient.StandardResponse addLine(AxlNetClient.AddLineReq addLine1)
        {
            return axlPortClient40.addLine(addLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLineResponse> addLineAsync(AxlNetClient.AddLineReq addLine)
        {
            return axlPortClient40.addLineAsync(addLine);
        }

        public AxlNetClient.StandardResponse updateLine(AxlNetClient.UpdateLineReq updateLine1)
        {
            return axlPortClient40.updateLine(updateLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLineResponse> updateLineAsync(AxlNetClient.UpdateLineReq updateLine)
        {
            return axlPortClient40.updateLineAsync(updateLine);
        }

        public AxlNetClient.GetLineRes getLine(AxlNetClient.GetLineReq getLine1)
        {
            return axlPortClient40.getLine(getLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineResponse> getLineAsync(AxlNetClient.GetLineReq getLine)
        {
            return axlPortClient40.getLineAsync(getLine);
        }

        public AxlNetClient.StandardResponse removeLine(AxlNetClient.RemoveLineReq removeLine1)
        {
            return axlPortClient40.removeLine(removeLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLineResponse> removeLineAsync(AxlNetClient.RemoveLineReq removeLine)
        {
            return axlPortClient40.removeLineAsync(removeLine);
        }

        public AxlNetClient.ListLineRes listLine(AxlNetClient.ListLineReq listLine1)
        {
            return axlPortClient40.listLine(listLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLineResponse> listLineAsync(AxlNetClient.ListLineReq listLine)
        {
            return axlPortClient40.listLineAsync(listLine);
        }

        public AxlNetClient.StandardResponse resetLine(AxlNetClient.ResetLineReq resetLine1)
        {
            return axlPortClient40.resetLine(resetLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetLineResponse> resetLineAsync(AxlNetClient.ResetLineReq resetLine)
        {
            return axlPortClient40.resetLineAsync(resetLine);
        }

        public AxlNetClient.StandardResponse restartLine(AxlNetClient.RestartLineReq restartLine1)
        {
            return axlPortClient40.restartLine(restartLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartLineResponse> restartLineAsync(AxlNetClient.RestartLineReq restartLine)
        {
            return axlPortClient40.restartLineAsync(restartLine);
        }

        public AxlNetClient.StandardResponse applyLine(AxlNetClient.ApplyLineReq applyLine1)
        {
            return axlPortClient40.applyLine(applyLine1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyLineResponse> applyLineAsync(AxlNetClient.ApplyLineReq applyLine)
        {
            return axlPortClient40.applyLineAsync(applyLine);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort40
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteDestinationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateRemoteDestinationProfileResponse updateRemoteDestinationProfile(AxlNetClient.updateRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateRemoteDestinationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationProfileResponse> updateRemoteDestinationProfileAsync(AxlNetClient.updateRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteDestinationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getRemoteDestinationProfileResponse getRemoteDestinationProfile(AxlNetClient.getRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getRemoteDestinationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationProfileResponse> getRemoteDestinationProfileAsync(AxlNetClient.getRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteDestinationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeRemoteDestinationProfileResponse removeRemoteDestinationProfile(AxlNetClient.removeRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeRemoteDestinationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationProfileResponse> removeRemoteDestinationProfileAsync(AxlNetClient.removeRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteDestinationProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listRemoteDestinationProfileResponse listRemoteDestinationProfile(AxlNetClient.listRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listRemoteDestinationProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationProfileResponse> listRemoteDestinationProfileAsync(AxlNetClient.listRemoteDestinationProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addLineResponse addLine(AxlNetClient.addLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addLineResponse> addLineAsync(AxlNetClient.addLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateLineResponse updateLine(AxlNetClient.updateLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateLineResponse> updateLineAsync(AxlNetClient.updateLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getLineResponse getLine(AxlNetClient.getLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getLineResponse> getLineAsync(AxlNetClient.getLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeLineResponse removeLine(AxlNetClient.removeLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeLineResponse> removeLineAsync(AxlNetClient.removeLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listLineResponse listLine(AxlNetClient.listLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listLineResponse> listLineAsync(AxlNetClient.listLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetLineResponse resetLine(AxlNetClient.resetLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetLineResponse> resetLineAsync(AxlNetClient.resetLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartLineResponse restartLine(AxlNetClient.restartLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartLineResponse> restartLineAsync(AxlNetClient.restartLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyLine", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyLineResponse applyLine(AxlNetClient.applyLineRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyLine", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyLineResponse> applyLineAsync(AxlNetClient.applyLineRequest request);
    }

    public class AXLPortClient40 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort40>, AxlNetClient.AXLPort40
    {
        public AXLPortClient40(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateRemoteDestinationProfileResponse AxlNetClient.AXLPort40.updateRemoteDestinationProfile(AxlNetClient.updateRemoteDestinationProfileRequest request)
        {
            return base.Channel.updateRemoteDestinationProfile(request);
        }

        public AxlNetClient.StandardResponse updateRemoteDestinationProfile(AxlNetClient.UpdateRemoteDestinationProfileReq updateRemoteDestinationProfile1)
        {
            AxlNetClient.updateRemoteDestinationProfileRequest inValue = new AxlNetClient.updateRemoteDestinationProfileRequest();
            inValue.updateRemoteDestinationProfile = updateRemoteDestinationProfile1;
            AxlNetClient.updateRemoteDestinationProfileResponse retVal = ((AxlNetClient.AXLPort40)(this)).updateRemoteDestinationProfile(inValue);
            return retVal.updateRemoteDestinationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationProfileResponse> AxlNetClient.AXLPort40.updateRemoteDestinationProfileAsync(AxlNetClient.updateRemoteDestinationProfileRequest request)
        {
            return base.Channel.updateRemoteDestinationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateRemoteDestinationProfileResponse> updateRemoteDestinationProfileAsync(AxlNetClient.UpdateRemoteDestinationProfileReq updateRemoteDestinationProfile)
        {
            AxlNetClient.updateRemoteDestinationProfileRequest inValue = new AxlNetClient.updateRemoteDestinationProfileRequest();
            inValue.updateRemoteDestinationProfile = updateRemoteDestinationProfile;
            return ((AxlNetClient.AXLPort40)(this)).updateRemoteDestinationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getRemoteDestinationProfileResponse AxlNetClient.AXLPort40.getRemoteDestinationProfile(AxlNetClient.getRemoteDestinationProfileRequest request)
        {
            return base.Channel.getRemoteDestinationProfile(request);
        }

        public AxlNetClient.GetRemoteDestinationProfileRes getRemoteDestinationProfile(AxlNetClient.GetRemoteDestinationProfileReq getRemoteDestinationProfile1)
        {
            AxlNetClient.getRemoteDestinationProfileRequest inValue = new AxlNetClient.getRemoteDestinationProfileRequest();
            inValue.getRemoteDestinationProfile = getRemoteDestinationProfile1;
            AxlNetClient.getRemoteDestinationProfileResponse retVal = ((AxlNetClient.AXLPort40)(this)).getRemoteDestinationProfile(inValue);
            return retVal.getRemoteDestinationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationProfileResponse> AxlNetClient.AXLPort40.getRemoteDestinationProfileAsync(AxlNetClient.getRemoteDestinationProfileRequest request)
        {
            return base.Channel.getRemoteDestinationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getRemoteDestinationProfileResponse> getRemoteDestinationProfileAsync(AxlNetClient.GetRemoteDestinationProfileReq getRemoteDestinationProfile)
        {
            AxlNetClient.getRemoteDestinationProfileRequest inValue = new AxlNetClient.getRemoteDestinationProfileRequest();
            inValue.getRemoteDestinationProfile = getRemoteDestinationProfile;
            return ((AxlNetClient.AXLPort40)(this)).getRemoteDestinationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeRemoteDestinationProfileResponse AxlNetClient.AXLPort40.removeRemoteDestinationProfile(AxlNetClient.removeRemoteDestinationProfileRequest request)
        {
            return base.Channel.removeRemoteDestinationProfile(request);
        }

        public AxlNetClient.StandardResponse removeRemoteDestinationProfile(AxlNetClient.NameAndGUIDRequest removeRemoteDestinationProfile1)
        {
            AxlNetClient.removeRemoteDestinationProfileRequest inValue = new AxlNetClient.removeRemoteDestinationProfileRequest();
            inValue.removeRemoteDestinationProfile = removeRemoteDestinationProfile1;
            AxlNetClient.removeRemoteDestinationProfileResponse retVal = ((AxlNetClient.AXLPort40)(this)).removeRemoteDestinationProfile(inValue);
            return retVal.removeRemoteDestinationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationProfileResponse> AxlNetClient.AXLPort40.removeRemoteDestinationProfileAsync(AxlNetClient.removeRemoteDestinationProfileRequest request)
        {
            return base.Channel.removeRemoteDestinationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeRemoteDestinationProfileResponse> removeRemoteDestinationProfileAsync(AxlNetClient.NameAndGUIDRequest removeRemoteDestinationProfile)
        {
            AxlNetClient.removeRemoteDestinationProfileRequest inValue = new AxlNetClient.removeRemoteDestinationProfileRequest();
            inValue.removeRemoteDestinationProfile = removeRemoteDestinationProfile;
            return ((AxlNetClient.AXLPort40)(this)).removeRemoteDestinationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listRemoteDestinationProfileResponse AxlNetClient.AXLPort40.listRemoteDestinationProfile(AxlNetClient.listRemoteDestinationProfileRequest request)
        {
            return base.Channel.listRemoteDestinationProfile(request);
        }

        public AxlNetClient.ListRemoteDestinationProfileRes listRemoteDestinationProfile(AxlNetClient.ListRemoteDestinationProfileReq listRemoteDestinationProfile1)
        {
            AxlNetClient.listRemoteDestinationProfileRequest inValue = new AxlNetClient.listRemoteDestinationProfileRequest();
            inValue.listRemoteDestinationProfile = listRemoteDestinationProfile1;
            AxlNetClient.listRemoteDestinationProfileResponse retVal = ((AxlNetClient.AXLPort40)(this)).listRemoteDestinationProfile(inValue);
            return retVal.listRemoteDestinationProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationProfileResponse> AxlNetClient.AXLPort40.listRemoteDestinationProfileAsync(AxlNetClient.listRemoteDestinationProfileRequest request)
        {
            return base.Channel.listRemoteDestinationProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listRemoteDestinationProfileResponse> listRemoteDestinationProfileAsync(AxlNetClient.ListRemoteDestinationProfileReq listRemoteDestinationProfile)
        {
            AxlNetClient.listRemoteDestinationProfileRequest inValue = new AxlNetClient.listRemoteDestinationProfileRequest();
            inValue.listRemoteDestinationProfile = listRemoteDestinationProfile;
            return ((AxlNetClient.AXLPort40)(this)).listRemoteDestinationProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addLineResponse AxlNetClient.AXLPort40.addLine(AxlNetClient.addLineRequest request)
        {
            return base.Channel.addLine(request);
        }

        public AxlNetClient.StandardResponse addLine(AxlNetClient.AddLineReq addLine1)
        {
            AxlNetClient.addLineRequest inValue = new AxlNetClient.addLineRequest();
            inValue.addLine = addLine1;
            AxlNetClient.addLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).addLine(inValue);
            return retVal.addLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addLineResponse> AxlNetClient.AXLPort40.addLineAsync(AxlNetClient.addLineRequest request)
        {
            return base.Channel.addLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addLineResponse> addLineAsync(AxlNetClient.AddLineReq addLine)
        {
            AxlNetClient.addLineRequest inValue = new AxlNetClient.addLineRequest();
            inValue.addLine = addLine;
            return ((AxlNetClient.AXLPort40)(this)).addLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateLineResponse AxlNetClient.AXLPort40.updateLine(AxlNetClient.updateLineRequest request)
        {
            return base.Channel.updateLine(request);
        }

        public AxlNetClient.StandardResponse updateLine(AxlNetClient.UpdateLineReq updateLine1)
        {
            AxlNetClient.updateLineRequest inValue = new AxlNetClient.updateLineRequest();
            inValue.updateLine = updateLine1;
            AxlNetClient.updateLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).updateLine(inValue);
            return retVal.updateLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateLineResponse> AxlNetClient.AXLPort40.updateLineAsync(AxlNetClient.updateLineRequest request)
        {
            return base.Channel.updateLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateLineResponse> updateLineAsync(AxlNetClient.UpdateLineReq updateLine)
        {
            AxlNetClient.updateLineRequest inValue = new AxlNetClient.updateLineRequest();
            inValue.updateLine = updateLine;
            return ((AxlNetClient.AXLPort40)(this)).updateLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getLineResponse AxlNetClient.AXLPort40.getLine(AxlNetClient.getLineRequest request)
        {
            return base.Channel.getLine(request);
        }

        public AxlNetClient.GetLineRes getLine(AxlNetClient.GetLineReq getLine1)
        {
            AxlNetClient.getLineRequest inValue = new AxlNetClient.getLineRequest();
            inValue.getLine = getLine1;
            AxlNetClient.getLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).getLine(inValue);
            return retVal.getLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getLineResponse> AxlNetClient.AXLPort40.getLineAsync(AxlNetClient.getLineRequest request)
        {
            return base.Channel.getLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getLineResponse> getLineAsync(AxlNetClient.GetLineReq getLine)
        {
            AxlNetClient.getLineRequest inValue = new AxlNetClient.getLineRequest();
            inValue.getLine = getLine;
            return ((AxlNetClient.AXLPort40)(this)).getLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeLineResponse AxlNetClient.AXLPort40.removeLine(AxlNetClient.removeLineRequest request)
        {
            return base.Channel.removeLine(request);
        }

        public AxlNetClient.StandardResponse removeLine(AxlNetClient.RemoveLineReq removeLine1)
        {
            AxlNetClient.removeLineRequest inValue = new AxlNetClient.removeLineRequest();
            inValue.removeLine = removeLine1;
            AxlNetClient.removeLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).removeLine(inValue);
            return retVal.removeLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeLineResponse> AxlNetClient.AXLPort40.removeLineAsync(AxlNetClient.removeLineRequest request)
        {
            return base.Channel.removeLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeLineResponse> removeLineAsync(AxlNetClient.RemoveLineReq removeLine)
        {
            AxlNetClient.removeLineRequest inValue = new AxlNetClient.removeLineRequest();
            inValue.removeLine = removeLine;
            return ((AxlNetClient.AXLPort40)(this)).removeLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listLineResponse AxlNetClient.AXLPort40.listLine(AxlNetClient.listLineRequest request)
        {
            return base.Channel.listLine(request);
        }

        public AxlNetClient.ListLineRes listLine(AxlNetClient.ListLineReq listLine1)
        {
            AxlNetClient.listLineRequest inValue = new AxlNetClient.listLineRequest();
            inValue.listLine = listLine1;
            AxlNetClient.listLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).listLine(inValue);
            return retVal.listLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listLineResponse> AxlNetClient.AXLPort40.listLineAsync(AxlNetClient.listLineRequest request)
        {
            return base.Channel.listLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listLineResponse> listLineAsync(AxlNetClient.ListLineReq listLine)
        {
            AxlNetClient.listLineRequest inValue = new AxlNetClient.listLineRequest();
            inValue.listLine = listLine;
            return ((AxlNetClient.AXLPort40)(this)).listLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetLineResponse AxlNetClient.AXLPort40.resetLine(AxlNetClient.resetLineRequest request)
        {
            return base.Channel.resetLine(request);
        }

        public AxlNetClient.StandardResponse resetLine(AxlNetClient.ResetLineReq resetLine1)
        {
            AxlNetClient.resetLineRequest inValue = new AxlNetClient.resetLineRequest();
            inValue.resetLine = resetLine1;
            AxlNetClient.resetLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).resetLine(inValue);
            return retVal.resetLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetLineResponse> AxlNetClient.AXLPort40.resetLineAsync(AxlNetClient.resetLineRequest request)
        {
            return base.Channel.resetLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetLineResponse> resetLineAsync(AxlNetClient.ResetLineReq resetLine)
        {
            AxlNetClient.resetLineRequest inValue = new AxlNetClient.resetLineRequest();
            inValue.resetLine = resetLine;
            return ((AxlNetClient.AXLPort40)(this)).resetLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartLineResponse AxlNetClient.AXLPort40.restartLine(AxlNetClient.restartLineRequest request)
        {
            return base.Channel.restartLine(request);
        }

        public AxlNetClient.StandardResponse restartLine(AxlNetClient.RestartLineReq restartLine1)
        {
            AxlNetClient.restartLineRequest inValue = new AxlNetClient.restartLineRequest();
            inValue.restartLine = restartLine1;
            AxlNetClient.restartLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).restartLine(inValue);
            return retVal.restartLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartLineResponse> AxlNetClient.AXLPort40.restartLineAsync(AxlNetClient.restartLineRequest request)
        {
            return base.Channel.restartLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartLineResponse> restartLineAsync(AxlNetClient.RestartLineReq restartLine)
        {
            AxlNetClient.restartLineRequest inValue = new AxlNetClient.restartLineRequest();
            inValue.restartLine = restartLine;
            return ((AxlNetClient.AXLPort40)(this)).restartLineAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyLineResponse AxlNetClient.AXLPort40.applyLine(AxlNetClient.applyLineRequest request)
        {
            return base.Channel.applyLine(request);
        }

        public AxlNetClient.StandardResponse applyLine(AxlNetClient.ApplyLineReq applyLine1)
        {
            AxlNetClient.applyLineRequest inValue = new AxlNetClient.applyLineRequest();
            inValue.applyLine = applyLine1;
            AxlNetClient.applyLineResponse retVal = ((AxlNetClient.AXLPort40)(this)).applyLine(inValue);
            return retVal.applyLineResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyLineResponse> AxlNetClient.AXLPort40.applyLineAsync(AxlNetClient.applyLineRequest request)
        {
            return base.Channel.applyLineAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyLineResponse> applyLineAsync(AxlNetClient.ApplyLineReq applyLine)
        {
            AxlNetClient.applyLineRequest inValue = new AxlNetClient.applyLineRequest();
            inValue.applyLine = applyLine;
            return ((AxlNetClient.AXLPort40)(this)).applyLineAsync(inValue);
        }
    }
}