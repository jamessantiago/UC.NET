namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient14 _axlPortClient14;

        private static AXLPortClient14 axlPortClient14 => _axlPortClient14 == null ||
            _axlPortClient14.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient14 = LoadClient14()) : _axlPortClient14;

        private static AXLPortClient14 LoadClient14()
        {
            var client = new AXLPortClient14(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close14;
            OnAbort += Abort14;
            return client;
        }

        private static void Close14(object sender, System.EventArgs e)
        {
            _axlPortClient14.Close();
        }

        private static void Abort14(object sender, System.EventArgs e)
        {
            _axlPortClient14.Abort();
        }

        public AxlNetClient.StandardResponse updateCmcInfo(AxlNetClient.UpdateCmcInfoReq updateCmcInfo1)
        {
            return axlPortClient14.updateCmcInfo(updateCmcInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCmcInfoResponse> updateCmcInfoAsync(AxlNetClient.UpdateCmcInfoReq updateCmcInfo)
        {
            return axlPortClient14.updateCmcInfoAsync(updateCmcInfo);
        }

        public AxlNetClient.GetCmcInfoRes getCmcInfo(AxlNetClient.GetCmcInfoReq getCmcInfo1)
        {
            return axlPortClient14.getCmcInfo(getCmcInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCmcInfoResponse> getCmcInfoAsync(AxlNetClient.GetCmcInfoReq getCmcInfo)
        {
            return axlPortClient14.getCmcInfoAsync(getCmcInfo);
        }

        public AxlNetClient.StandardResponse removeCmcInfo(AxlNetClient.RemoveCmcInfoReq removeCmcInfo1)
        {
            return axlPortClient14.removeCmcInfo(removeCmcInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCmcInfoResponse> removeCmcInfoAsync(AxlNetClient.RemoveCmcInfoReq removeCmcInfo)
        {
            return axlPortClient14.removeCmcInfoAsync(removeCmcInfo);
        }

        public AxlNetClient.ListCmcInfoRes listCmcInfo(AxlNetClient.ListCmcInfoReq listCmcInfo1)
        {
            return axlPortClient14.listCmcInfo(listCmcInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCmcInfoResponse> listCmcInfoAsync(AxlNetClient.ListCmcInfoReq listCmcInfo)
        {
            return axlPortClient14.listCmcInfoAsync(listCmcInfo);
        }

        public AxlNetClient.StandardResponse addCredentialPolicy(AxlNetClient.AddCredentialPolicyReq addCredentialPolicy1)
        {
            return axlPortClient14.addCredentialPolicy(addCredentialPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCredentialPolicyResponse> addCredentialPolicyAsync(AxlNetClient.AddCredentialPolicyReq addCredentialPolicy)
        {
            return axlPortClient14.addCredentialPolicyAsync(addCredentialPolicy);
        }

        public AxlNetClient.StandardResponse updateCredentialPolicy(AxlNetClient.UpdateCredentialPolicyReq updateCredentialPolicy1)
        {
            return axlPortClient14.updateCredentialPolicy(updateCredentialPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyResponse> updateCredentialPolicyAsync(AxlNetClient.UpdateCredentialPolicyReq updateCredentialPolicy)
        {
            return axlPortClient14.updateCredentialPolicyAsync(updateCredentialPolicy);
        }

        public AxlNetClient.GetCredentialPolicyRes getCredentialPolicy(AxlNetClient.GetCredentialPolicyReq getCredentialPolicy1)
        {
            return axlPortClient14.getCredentialPolicy(getCredentialPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyResponse> getCredentialPolicyAsync(AxlNetClient.GetCredentialPolicyReq getCredentialPolicy)
        {
            return axlPortClient14.getCredentialPolicyAsync(getCredentialPolicy);
        }

        public AxlNetClient.StandardResponse removeCredentialPolicy(AxlNetClient.NameAndGUIDRequest removeCredentialPolicy1)
        {
            return axlPortClient14.removeCredentialPolicy(removeCredentialPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCredentialPolicyResponse> removeCredentialPolicyAsync(AxlNetClient.NameAndGUIDRequest removeCredentialPolicy)
        {
            return axlPortClient14.removeCredentialPolicyAsync(removeCredentialPolicy);
        }

        public AxlNetClient.ListCredentialPolicyRes listCredentialPolicy(AxlNetClient.ListCredentialPolicyReq listCredentialPolicy1)
        {
            return axlPortClient14.listCredentialPolicy(listCredentialPolicy1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCredentialPolicyResponse> listCredentialPolicyAsync(AxlNetClient.ListCredentialPolicyReq listCredentialPolicy)
        {
            return axlPortClient14.listCredentialPolicyAsync(listCredentialPolicy);
        }

        public AxlNetClient.StandardResponse addFacInfo(AxlNetClient.AddFacInfoReq addFacInfo1)
        {
            return axlPortClient14.addFacInfo(addFacInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFacInfoResponse> addFacInfoAsync(AxlNetClient.AddFacInfoReq addFacInfo)
        {
            return axlPortClient14.addFacInfoAsync(addFacInfo);
        }

        public AxlNetClient.StandardResponse updateFacInfo(AxlNetClient.UpdateFacInfoReq updateFacInfo1)
        {
            return axlPortClient14.updateFacInfo(updateFacInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFacInfoResponse> updateFacInfoAsync(AxlNetClient.UpdateFacInfoReq updateFacInfo)
        {
            return axlPortClient14.updateFacInfoAsync(updateFacInfo);
        }

        public AxlNetClient.GetFacInfoRes getFacInfo(AxlNetClient.GetFacInfoReq getFacInfo1)
        {
            return axlPortClient14.getFacInfo(getFacInfo1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFacInfoResponse> getFacInfoAsync(AxlNetClient.GetFacInfoReq getFacInfo)
        {
            return axlPortClient14.getFacInfoAsync(getFacInfo);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort14
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCmcInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCmcInfoResponse updateCmcInfo(AxlNetClient.updateCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCmcInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCmcInfoResponse> updateCmcInfoAsync(AxlNetClient.updateCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCmcInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCmcInfoResponse getCmcInfo(AxlNetClient.getCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCmcInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCmcInfoResponse> getCmcInfoAsync(AxlNetClient.getCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCmcInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCmcInfoResponse removeCmcInfo(AxlNetClient.removeCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCmcInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCmcInfoResponse> removeCmcInfoAsync(AxlNetClient.removeCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCmcInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCmcInfoResponse listCmcInfo(AxlNetClient.listCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCmcInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCmcInfoResponse> listCmcInfoAsync(AxlNetClient.listCmcInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCredentialPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCredentialPolicyResponse addCredentialPolicy(AxlNetClient.addCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCredentialPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCredentialPolicyResponse> addCredentialPolicyAsync(AxlNetClient.addCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCredentialPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCredentialPolicyResponse updateCredentialPolicy(AxlNetClient.updateCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCredentialPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyResponse> updateCredentialPolicyAsync(AxlNetClient.updateCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCredentialPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCredentialPolicyResponse getCredentialPolicy(AxlNetClient.getCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCredentialPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyResponse> getCredentialPolicyAsync(AxlNetClient.getCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCredentialPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCredentialPolicyResponse removeCredentialPolicy(AxlNetClient.removeCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCredentialPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCredentialPolicyResponse> removeCredentialPolicyAsync(AxlNetClient.removeCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCredentialPolicy", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCredentialPolicyResponse listCredentialPolicy(AxlNetClient.listCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCredentialPolicy", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCredentialPolicyResponse> listCredentialPolicyAsync(AxlNetClient.listCredentialPolicyRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFacInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addFacInfoResponse addFacInfo(AxlNetClient.addFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addFacInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addFacInfoResponse> addFacInfoAsync(AxlNetClient.addFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFacInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateFacInfoResponse updateFacInfo(AxlNetClient.updateFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateFacInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateFacInfoResponse> updateFacInfoAsync(AxlNetClient.updateFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFacInfo", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getFacInfoResponse getFacInfo(AxlNetClient.getFacInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getFacInfo", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getFacInfoResponse> getFacInfoAsync(AxlNetClient.getFacInfoRequest request);
    }

    public class AXLPortClient14 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort14>, AxlNetClient.AXLPort14
    {
        public AXLPortClient14(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCmcInfoResponse AxlNetClient.AXLPort14.updateCmcInfo(AxlNetClient.updateCmcInfoRequest request)
        {
            return base.Channel.updateCmcInfo(request);
        }

        public AxlNetClient.StandardResponse updateCmcInfo(AxlNetClient.UpdateCmcInfoReq updateCmcInfo1)
        {
            AxlNetClient.updateCmcInfoRequest inValue = new AxlNetClient.updateCmcInfoRequest();
            inValue.updateCmcInfo = updateCmcInfo1;
            AxlNetClient.updateCmcInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).updateCmcInfo(inValue);
            return retVal.updateCmcInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCmcInfoResponse> AxlNetClient.AXLPort14.updateCmcInfoAsync(AxlNetClient.updateCmcInfoRequest request)
        {
            return base.Channel.updateCmcInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCmcInfoResponse> updateCmcInfoAsync(AxlNetClient.UpdateCmcInfoReq updateCmcInfo)
        {
            AxlNetClient.updateCmcInfoRequest inValue = new AxlNetClient.updateCmcInfoRequest();
            inValue.updateCmcInfo = updateCmcInfo;
            return ((AxlNetClient.AXLPort14)(this)).updateCmcInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCmcInfoResponse AxlNetClient.AXLPort14.getCmcInfo(AxlNetClient.getCmcInfoRequest request)
        {
            return base.Channel.getCmcInfo(request);
        }

        public AxlNetClient.GetCmcInfoRes getCmcInfo(AxlNetClient.GetCmcInfoReq getCmcInfo1)
        {
            AxlNetClient.getCmcInfoRequest inValue = new AxlNetClient.getCmcInfoRequest();
            inValue.getCmcInfo = getCmcInfo1;
            AxlNetClient.getCmcInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).getCmcInfo(inValue);
            return retVal.getCmcInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCmcInfoResponse> AxlNetClient.AXLPort14.getCmcInfoAsync(AxlNetClient.getCmcInfoRequest request)
        {
            return base.Channel.getCmcInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCmcInfoResponse> getCmcInfoAsync(AxlNetClient.GetCmcInfoReq getCmcInfo)
        {
            AxlNetClient.getCmcInfoRequest inValue = new AxlNetClient.getCmcInfoRequest();
            inValue.getCmcInfo = getCmcInfo;
            return ((AxlNetClient.AXLPort14)(this)).getCmcInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCmcInfoResponse AxlNetClient.AXLPort14.removeCmcInfo(AxlNetClient.removeCmcInfoRequest request)
        {
            return base.Channel.removeCmcInfo(request);
        }

        public AxlNetClient.StandardResponse removeCmcInfo(AxlNetClient.RemoveCmcInfoReq removeCmcInfo1)
        {
            AxlNetClient.removeCmcInfoRequest inValue = new AxlNetClient.removeCmcInfoRequest();
            inValue.removeCmcInfo = removeCmcInfo1;
            AxlNetClient.removeCmcInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).removeCmcInfo(inValue);
            return retVal.removeCmcInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCmcInfoResponse> AxlNetClient.AXLPort14.removeCmcInfoAsync(AxlNetClient.removeCmcInfoRequest request)
        {
            return base.Channel.removeCmcInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCmcInfoResponse> removeCmcInfoAsync(AxlNetClient.RemoveCmcInfoReq removeCmcInfo)
        {
            AxlNetClient.removeCmcInfoRequest inValue = new AxlNetClient.removeCmcInfoRequest();
            inValue.removeCmcInfo = removeCmcInfo;
            return ((AxlNetClient.AXLPort14)(this)).removeCmcInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCmcInfoResponse AxlNetClient.AXLPort14.listCmcInfo(AxlNetClient.listCmcInfoRequest request)
        {
            return base.Channel.listCmcInfo(request);
        }

        public AxlNetClient.ListCmcInfoRes listCmcInfo(AxlNetClient.ListCmcInfoReq listCmcInfo1)
        {
            AxlNetClient.listCmcInfoRequest inValue = new AxlNetClient.listCmcInfoRequest();
            inValue.listCmcInfo = listCmcInfo1;
            AxlNetClient.listCmcInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).listCmcInfo(inValue);
            return retVal.listCmcInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCmcInfoResponse> AxlNetClient.AXLPort14.listCmcInfoAsync(AxlNetClient.listCmcInfoRequest request)
        {
            return base.Channel.listCmcInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCmcInfoResponse> listCmcInfoAsync(AxlNetClient.ListCmcInfoReq listCmcInfo)
        {
            AxlNetClient.listCmcInfoRequest inValue = new AxlNetClient.listCmcInfoRequest();
            inValue.listCmcInfo = listCmcInfo;
            return ((AxlNetClient.AXLPort14)(this)).listCmcInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCredentialPolicyResponse AxlNetClient.AXLPort14.addCredentialPolicy(AxlNetClient.addCredentialPolicyRequest request)
        {
            return base.Channel.addCredentialPolicy(request);
        }

        public AxlNetClient.StandardResponse addCredentialPolicy(AxlNetClient.AddCredentialPolicyReq addCredentialPolicy1)
        {
            AxlNetClient.addCredentialPolicyRequest inValue = new AxlNetClient.addCredentialPolicyRequest();
            inValue.addCredentialPolicy = addCredentialPolicy1;
            AxlNetClient.addCredentialPolicyResponse retVal = ((AxlNetClient.AXLPort14)(this)).addCredentialPolicy(inValue);
            return retVal.addCredentialPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCredentialPolicyResponse> AxlNetClient.AXLPort14.addCredentialPolicyAsync(AxlNetClient.addCredentialPolicyRequest request)
        {
            return base.Channel.addCredentialPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCredentialPolicyResponse> addCredentialPolicyAsync(AxlNetClient.AddCredentialPolicyReq addCredentialPolicy)
        {
            AxlNetClient.addCredentialPolicyRequest inValue = new AxlNetClient.addCredentialPolicyRequest();
            inValue.addCredentialPolicy = addCredentialPolicy;
            return ((AxlNetClient.AXLPort14)(this)).addCredentialPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCredentialPolicyResponse AxlNetClient.AXLPort14.updateCredentialPolicy(AxlNetClient.updateCredentialPolicyRequest request)
        {
            return base.Channel.updateCredentialPolicy(request);
        }

        public AxlNetClient.StandardResponse updateCredentialPolicy(AxlNetClient.UpdateCredentialPolicyReq updateCredentialPolicy1)
        {
            AxlNetClient.updateCredentialPolicyRequest inValue = new AxlNetClient.updateCredentialPolicyRequest();
            inValue.updateCredentialPolicy = updateCredentialPolicy1;
            AxlNetClient.updateCredentialPolicyResponse retVal = ((AxlNetClient.AXLPort14)(this)).updateCredentialPolicy(inValue);
            return retVal.updateCredentialPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyResponse> AxlNetClient.AXLPort14.updateCredentialPolicyAsync(AxlNetClient.updateCredentialPolicyRequest request)
        {
            return base.Channel.updateCredentialPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCredentialPolicyResponse> updateCredentialPolicyAsync(AxlNetClient.UpdateCredentialPolicyReq updateCredentialPolicy)
        {
            AxlNetClient.updateCredentialPolicyRequest inValue = new AxlNetClient.updateCredentialPolicyRequest();
            inValue.updateCredentialPolicy = updateCredentialPolicy;
            return ((AxlNetClient.AXLPort14)(this)).updateCredentialPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCredentialPolicyResponse AxlNetClient.AXLPort14.getCredentialPolicy(AxlNetClient.getCredentialPolicyRequest request)
        {
            return base.Channel.getCredentialPolicy(request);
        }

        public AxlNetClient.GetCredentialPolicyRes getCredentialPolicy(AxlNetClient.GetCredentialPolicyReq getCredentialPolicy1)
        {
            AxlNetClient.getCredentialPolicyRequest inValue = new AxlNetClient.getCredentialPolicyRequest();
            inValue.getCredentialPolicy = getCredentialPolicy1;
            AxlNetClient.getCredentialPolicyResponse retVal = ((AxlNetClient.AXLPort14)(this)).getCredentialPolicy(inValue);
            return retVal.getCredentialPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyResponse> AxlNetClient.AXLPort14.getCredentialPolicyAsync(AxlNetClient.getCredentialPolicyRequest request)
        {
            return base.Channel.getCredentialPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCredentialPolicyResponse> getCredentialPolicyAsync(AxlNetClient.GetCredentialPolicyReq getCredentialPolicy)
        {
            AxlNetClient.getCredentialPolicyRequest inValue = new AxlNetClient.getCredentialPolicyRequest();
            inValue.getCredentialPolicy = getCredentialPolicy;
            return ((AxlNetClient.AXLPort14)(this)).getCredentialPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCredentialPolicyResponse AxlNetClient.AXLPort14.removeCredentialPolicy(AxlNetClient.removeCredentialPolicyRequest request)
        {
            return base.Channel.removeCredentialPolicy(request);
        }

        public AxlNetClient.StandardResponse removeCredentialPolicy(AxlNetClient.NameAndGUIDRequest removeCredentialPolicy1)
        {
            AxlNetClient.removeCredentialPolicyRequest inValue = new AxlNetClient.removeCredentialPolicyRequest();
            inValue.removeCredentialPolicy = removeCredentialPolicy1;
            AxlNetClient.removeCredentialPolicyResponse retVal = ((AxlNetClient.AXLPort14)(this)).removeCredentialPolicy(inValue);
            return retVal.removeCredentialPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCredentialPolicyResponse> AxlNetClient.AXLPort14.removeCredentialPolicyAsync(AxlNetClient.removeCredentialPolicyRequest request)
        {
            return base.Channel.removeCredentialPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCredentialPolicyResponse> removeCredentialPolicyAsync(AxlNetClient.NameAndGUIDRequest removeCredentialPolicy)
        {
            AxlNetClient.removeCredentialPolicyRequest inValue = new AxlNetClient.removeCredentialPolicyRequest();
            inValue.removeCredentialPolicy = removeCredentialPolicy;
            return ((AxlNetClient.AXLPort14)(this)).removeCredentialPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCredentialPolicyResponse AxlNetClient.AXLPort14.listCredentialPolicy(AxlNetClient.listCredentialPolicyRequest request)
        {
            return base.Channel.listCredentialPolicy(request);
        }

        public AxlNetClient.ListCredentialPolicyRes listCredentialPolicy(AxlNetClient.ListCredentialPolicyReq listCredentialPolicy1)
        {
            AxlNetClient.listCredentialPolicyRequest inValue = new AxlNetClient.listCredentialPolicyRequest();
            inValue.listCredentialPolicy = listCredentialPolicy1;
            AxlNetClient.listCredentialPolicyResponse retVal = ((AxlNetClient.AXLPort14)(this)).listCredentialPolicy(inValue);
            return retVal.listCredentialPolicyResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCredentialPolicyResponse> AxlNetClient.AXLPort14.listCredentialPolicyAsync(AxlNetClient.listCredentialPolicyRequest request)
        {
            return base.Channel.listCredentialPolicyAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCredentialPolicyResponse> listCredentialPolicyAsync(AxlNetClient.ListCredentialPolicyReq listCredentialPolicy)
        {
            AxlNetClient.listCredentialPolicyRequest inValue = new AxlNetClient.listCredentialPolicyRequest();
            inValue.listCredentialPolicy = listCredentialPolicy;
            return ((AxlNetClient.AXLPort14)(this)).listCredentialPolicyAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addFacInfoResponse AxlNetClient.AXLPort14.addFacInfo(AxlNetClient.addFacInfoRequest request)
        {
            return base.Channel.addFacInfo(request);
        }

        public AxlNetClient.StandardResponse addFacInfo(AxlNetClient.AddFacInfoReq addFacInfo1)
        {
            AxlNetClient.addFacInfoRequest inValue = new AxlNetClient.addFacInfoRequest();
            inValue.addFacInfo = addFacInfo1;
            AxlNetClient.addFacInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).addFacInfo(inValue);
            return retVal.addFacInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addFacInfoResponse> AxlNetClient.AXLPort14.addFacInfoAsync(AxlNetClient.addFacInfoRequest request)
        {
            return base.Channel.addFacInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addFacInfoResponse> addFacInfoAsync(AxlNetClient.AddFacInfoReq addFacInfo)
        {
            AxlNetClient.addFacInfoRequest inValue = new AxlNetClient.addFacInfoRequest();
            inValue.addFacInfo = addFacInfo;
            return ((AxlNetClient.AXLPort14)(this)).addFacInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateFacInfoResponse AxlNetClient.AXLPort14.updateFacInfo(AxlNetClient.updateFacInfoRequest request)
        {
            return base.Channel.updateFacInfo(request);
        }

        public AxlNetClient.StandardResponse updateFacInfo(AxlNetClient.UpdateFacInfoReq updateFacInfo1)
        {
            AxlNetClient.updateFacInfoRequest inValue = new AxlNetClient.updateFacInfoRequest();
            inValue.updateFacInfo = updateFacInfo1;
            AxlNetClient.updateFacInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).updateFacInfo(inValue);
            return retVal.updateFacInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateFacInfoResponse> AxlNetClient.AXLPort14.updateFacInfoAsync(AxlNetClient.updateFacInfoRequest request)
        {
            return base.Channel.updateFacInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateFacInfoResponse> updateFacInfoAsync(AxlNetClient.UpdateFacInfoReq updateFacInfo)
        {
            AxlNetClient.updateFacInfoRequest inValue = new AxlNetClient.updateFacInfoRequest();
            inValue.updateFacInfo = updateFacInfo;
            return ((AxlNetClient.AXLPort14)(this)).updateFacInfoAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getFacInfoResponse AxlNetClient.AXLPort14.getFacInfo(AxlNetClient.getFacInfoRequest request)
        {
            return base.Channel.getFacInfo(request);
        }

        public AxlNetClient.GetFacInfoRes getFacInfo(AxlNetClient.GetFacInfoReq getFacInfo1)
        {
            AxlNetClient.getFacInfoRequest inValue = new AxlNetClient.getFacInfoRequest();
            inValue.getFacInfo = getFacInfo1;
            AxlNetClient.getFacInfoResponse retVal = ((AxlNetClient.AXLPort14)(this)).getFacInfo(inValue);
            return retVal.getFacInfoResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getFacInfoResponse> AxlNetClient.AXLPort14.getFacInfoAsync(AxlNetClient.getFacInfoRequest request)
        {
            return base.Channel.getFacInfoAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getFacInfoResponse> getFacInfoAsync(AxlNetClient.GetFacInfoReq getFacInfo)
        {
            AxlNetClient.getFacInfoRequest inValue = new AxlNetClient.getFacInfoRequest();
            inValue.getFacInfo = getFacInfo;
            return ((AxlNetClient.AXLPort14)(this)).getFacInfoAsync(inValue);
        }
    }
}