namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient53 _axlPortClient53;

        private static AXLPortClient53 axlPortClient53 => _axlPortClient53 == null ||
            _axlPortClient53.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient53 = LoadClient53()) : _axlPortClient53;

        private static AXLPortClient53 LoadClient53()
        {
            var client = new AXLPortClient53(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close53;
            OnAbort += Abort53;
            return client;
        }

        private static void Close53(object sender, System.EventArgs e)
        {
            _axlPortClient53.Close();
        }

        private static void Abort53(object sender, System.EventArgs e)
        {
            _axlPortClient53.Abort();
        }

        public AxlNetClient.GetSafSecurityProfileRes getSafSecurityProfile(AxlNetClient.GetSafSecurityProfileReq getSafSecurityProfile1)
        {
            return axlPortClient53.getSafSecurityProfile(getSafSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafSecurityProfileResponse> getSafSecurityProfileAsync(AxlNetClient.GetSafSecurityProfileReq getSafSecurityProfile)
        {
            return axlPortClient53.getSafSecurityProfileAsync(getSafSecurityProfile);
        }

        public AxlNetClient.StandardResponse removeSafSecurityProfile(AxlNetClient.NameAndGUIDRequest removeSafSecurityProfile1)
        {
            return axlPortClient53.removeSafSecurityProfile(removeSafSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafSecurityProfileResponse> removeSafSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeSafSecurityProfile)
        {
            return axlPortClient53.removeSafSecurityProfileAsync(removeSafSecurityProfile);
        }

        public AxlNetClient.ListSafSecurityProfileRes listSafSecurityProfile(AxlNetClient.ListSafSecurityProfileReq listSafSecurityProfile1)
        {
            return axlPortClient53.listSafSecurityProfile(listSafSecurityProfile1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafSecurityProfileResponse> listSafSecurityProfileAsync(AxlNetClient.ListSafSecurityProfileReq listSafSecurityProfile)
        {
            return axlPortClient53.listSafSecurityProfileAsync(listSafSecurityProfile);
        }

        public AxlNetClient.StandardResponse addSafForwarder(AxlNetClient.AddSafForwarderReq addSafForwarder1)
        {
            return axlPortClient53.addSafForwarder(addSafForwarder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafForwarderResponse> addSafForwarderAsync(AxlNetClient.AddSafForwarderReq addSafForwarder)
        {
            return axlPortClient53.addSafForwarderAsync(addSafForwarder);
        }

        public AxlNetClient.StandardResponse updateSafForwarder(AxlNetClient.UpdateSafForwarderReq updateSafForwarder1)
        {
            return axlPortClient53.updateSafForwarder(updateSafForwarder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafForwarderResponse> updateSafForwarderAsync(AxlNetClient.UpdateSafForwarderReq updateSafForwarder)
        {
            return axlPortClient53.updateSafForwarderAsync(updateSafForwarder);
        }

        public AxlNetClient.GetSafForwarderRes getSafForwarder(AxlNetClient.GetSafForwarderReq getSafForwarder1)
        {
            return axlPortClient53.getSafForwarder(getSafForwarder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafForwarderResponse> getSafForwarderAsync(AxlNetClient.GetSafForwarderReq getSafForwarder)
        {
            return axlPortClient53.getSafForwarderAsync(getSafForwarder);
        }

        public AxlNetClient.StandardResponse removeSafForwarder(AxlNetClient.NameAndGUIDRequest removeSafForwarder1)
        {
            return axlPortClient53.removeSafForwarder(removeSafForwarder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafForwarderResponse> removeSafForwarderAsync(AxlNetClient.NameAndGUIDRequest removeSafForwarder)
        {
            return axlPortClient53.removeSafForwarderAsync(removeSafForwarder);
        }

        public AxlNetClient.ListSafForwarderRes listSafForwarder(AxlNetClient.ListSafForwarderReq listSafForwarder1)
        {
            return axlPortClient53.listSafForwarder(listSafForwarder1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafForwarderResponse> listSafForwarderAsync(AxlNetClient.ListSafForwarderReq listSafForwarder)
        {
            return axlPortClient53.listSafForwarderAsync(listSafForwarder);
        }

        public AxlNetClient.StandardResponse addCcdHostedDN(AxlNetClient.AddCcdHostedDNReq addCcdHostedDN1)
        {
            return axlPortClient53.addCcdHostedDN(addCcdHostedDN1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNResponse> addCcdHostedDNAsync(AxlNetClient.AddCcdHostedDNReq addCcdHostedDN)
        {
            return axlPortClient53.addCcdHostedDNAsync(addCcdHostedDN);
        }

        public AxlNetClient.StandardResponse updateCcdHostedDN(AxlNetClient.UpdateCcdHostedDNReq updateCcdHostedDN1)
        {
            return axlPortClient53.updateCcdHostedDN(updateCcdHostedDN1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNResponse> updateCcdHostedDNAsync(AxlNetClient.UpdateCcdHostedDNReq updateCcdHostedDN)
        {
            return axlPortClient53.updateCcdHostedDNAsync(updateCcdHostedDN);
        }

        public AxlNetClient.GetCcdHostedDNRes getCcdHostedDN(AxlNetClient.GetCcdHostedDNReq getCcdHostedDN1)
        {
            return axlPortClient53.getCcdHostedDN(getCcdHostedDN1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNResponse> getCcdHostedDNAsync(AxlNetClient.GetCcdHostedDNReq getCcdHostedDN)
        {
            return axlPortClient53.getCcdHostedDNAsync(getCcdHostedDN);
        }

        public AxlNetClient.StandardResponse removeCcdHostedDN(AxlNetClient.RemoveCcdHostedDNReq removeCcdHostedDN1)
        {
            return axlPortClient53.removeCcdHostedDN(removeCcdHostedDN1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNResponse> removeCcdHostedDNAsync(AxlNetClient.RemoveCcdHostedDNReq removeCcdHostedDN)
        {
            return axlPortClient53.removeCcdHostedDNAsync(removeCcdHostedDN);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort53
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSafSecurityProfileResponse getSafSecurityProfile(AxlNetClient.getSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSafSecurityProfileResponse> getSafSecurityProfileAsync(AxlNetClient.getSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSafSecurityProfileResponse removeSafSecurityProfile(AxlNetClient.removeSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSafSecurityProfileResponse> removeSafSecurityProfileAsync(AxlNetClient.removeSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafSecurityProfile", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSafSecurityProfileResponse listSafSecurityProfile(AxlNetClient.listSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafSecurityProfile", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSafSecurityProfileResponse> listSafSecurityProfileAsync(AxlNetClient.listSafSecurityProfileRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafForwarder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addSafForwarderResponse addSafForwarder(AxlNetClient.addSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addSafForwarder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addSafForwarderResponse> addSafForwarderAsync(AxlNetClient.addSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafForwarder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSafForwarderResponse updateSafForwarder(AxlNetClient.updateSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSafForwarder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSafForwarderResponse> updateSafForwarderAsync(AxlNetClient.updateSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafForwarder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getSafForwarderResponse getSafForwarder(AxlNetClient.getSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getSafForwarder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getSafForwarderResponse> getSafForwarderAsync(AxlNetClient.getSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafForwarder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeSafForwarderResponse removeSafForwarder(AxlNetClient.removeSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeSafForwarder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeSafForwarderResponse> removeSafForwarderAsync(AxlNetClient.removeSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafForwarder", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSafForwarderResponse listSafForwarder(AxlNetClient.listSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSafForwarder", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSafForwarderResponse> listSafForwarderAsync(AxlNetClient.listSafForwarderRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdHostedDN", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCcdHostedDNResponse addCcdHostedDN(AxlNetClient.addCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCcdHostedDN", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNResponse> addCcdHostedDNAsync(AxlNetClient.addCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdHostedDN", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCcdHostedDNResponse updateCcdHostedDN(AxlNetClient.updateCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCcdHostedDN", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNResponse> updateCcdHostedDNAsync(AxlNetClient.updateCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdHostedDN", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCcdHostedDNResponse getCcdHostedDN(AxlNetClient.getCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCcdHostedDN", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNResponse> getCcdHostedDNAsync(AxlNetClient.getCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdHostedDN", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCcdHostedDNResponse removeCcdHostedDN(AxlNetClient.removeCcdHostedDNRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCcdHostedDN", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNResponse> removeCcdHostedDNAsync(AxlNetClient.removeCcdHostedDNRequest request);
    }

    public class AXLPortClient53 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort53>, AxlNetClient.AXLPort53
    {
        public AXLPortClient53(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSafSecurityProfileResponse AxlNetClient.AXLPort53.getSafSecurityProfile(AxlNetClient.getSafSecurityProfileRequest request)
        {
            return base.Channel.getSafSecurityProfile(request);
        }

        public AxlNetClient.GetSafSecurityProfileRes getSafSecurityProfile(AxlNetClient.GetSafSecurityProfileReq getSafSecurityProfile1)
        {
            AxlNetClient.getSafSecurityProfileRequest inValue = new AxlNetClient.getSafSecurityProfileRequest();
            inValue.getSafSecurityProfile = getSafSecurityProfile1;
            AxlNetClient.getSafSecurityProfileResponse retVal = ((AxlNetClient.AXLPort53)(this)).getSafSecurityProfile(inValue);
            return retVal.getSafSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSafSecurityProfileResponse> AxlNetClient.AXLPort53.getSafSecurityProfileAsync(AxlNetClient.getSafSecurityProfileRequest request)
        {
            return base.Channel.getSafSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafSecurityProfileResponse> getSafSecurityProfileAsync(AxlNetClient.GetSafSecurityProfileReq getSafSecurityProfile)
        {
            AxlNetClient.getSafSecurityProfileRequest inValue = new AxlNetClient.getSafSecurityProfileRequest();
            inValue.getSafSecurityProfile = getSafSecurityProfile;
            return ((AxlNetClient.AXLPort53)(this)).getSafSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSafSecurityProfileResponse AxlNetClient.AXLPort53.removeSafSecurityProfile(AxlNetClient.removeSafSecurityProfileRequest request)
        {
            return base.Channel.removeSafSecurityProfile(request);
        }

        public AxlNetClient.StandardResponse removeSafSecurityProfile(AxlNetClient.NameAndGUIDRequest removeSafSecurityProfile1)
        {
            AxlNetClient.removeSafSecurityProfileRequest inValue = new AxlNetClient.removeSafSecurityProfileRequest();
            inValue.removeSafSecurityProfile = removeSafSecurityProfile1;
            AxlNetClient.removeSafSecurityProfileResponse retVal = ((AxlNetClient.AXLPort53)(this)).removeSafSecurityProfile(inValue);
            return retVal.removeSafSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSafSecurityProfileResponse> AxlNetClient.AXLPort53.removeSafSecurityProfileAsync(AxlNetClient.removeSafSecurityProfileRequest request)
        {
            return base.Channel.removeSafSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafSecurityProfileResponse> removeSafSecurityProfileAsync(AxlNetClient.NameAndGUIDRequest removeSafSecurityProfile)
        {
            AxlNetClient.removeSafSecurityProfileRequest inValue = new AxlNetClient.removeSafSecurityProfileRequest();
            inValue.removeSafSecurityProfile = removeSafSecurityProfile;
            return ((AxlNetClient.AXLPort53)(this)).removeSafSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSafSecurityProfileResponse AxlNetClient.AXLPort53.listSafSecurityProfile(AxlNetClient.listSafSecurityProfileRequest request)
        {
            return base.Channel.listSafSecurityProfile(request);
        }

        public AxlNetClient.ListSafSecurityProfileRes listSafSecurityProfile(AxlNetClient.ListSafSecurityProfileReq listSafSecurityProfile1)
        {
            AxlNetClient.listSafSecurityProfileRequest inValue = new AxlNetClient.listSafSecurityProfileRequest();
            inValue.listSafSecurityProfile = listSafSecurityProfile1;
            AxlNetClient.listSafSecurityProfileResponse retVal = ((AxlNetClient.AXLPort53)(this)).listSafSecurityProfile(inValue);
            return retVal.listSafSecurityProfileResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSafSecurityProfileResponse> AxlNetClient.AXLPort53.listSafSecurityProfileAsync(AxlNetClient.listSafSecurityProfileRequest request)
        {
            return base.Channel.listSafSecurityProfileAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafSecurityProfileResponse> listSafSecurityProfileAsync(AxlNetClient.ListSafSecurityProfileReq listSafSecurityProfile)
        {
            AxlNetClient.listSafSecurityProfileRequest inValue = new AxlNetClient.listSafSecurityProfileRequest();
            inValue.listSafSecurityProfile = listSafSecurityProfile;
            return ((AxlNetClient.AXLPort53)(this)).listSafSecurityProfileAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addSafForwarderResponse AxlNetClient.AXLPort53.addSafForwarder(AxlNetClient.addSafForwarderRequest request)
        {
            return base.Channel.addSafForwarder(request);
        }

        public AxlNetClient.StandardResponse addSafForwarder(AxlNetClient.AddSafForwarderReq addSafForwarder1)
        {
            AxlNetClient.addSafForwarderRequest inValue = new AxlNetClient.addSafForwarderRequest();
            inValue.addSafForwarder = addSafForwarder1;
            AxlNetClient.addSafForwarderResponse retVal = ((AxlNetClient.AXLPort53)(this)).addSafForwarder(inValue);
            return retVal.addSafForwarderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addSafForwarderResponse> AxlNetClient.AXLPort53.addSafForwarderAsync(AxlNetClient.addSafForwarderRequest request)
        {
            return base.Channel.addSafForwarderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addSafForwarderResponse> addSafForwarderAsync(AxlNetClient.AddSafForwarderReq addSafForwarder)
        {
            AxlNetClient.addSafForwarderRequest inValue = new AxlNetClient.addSafForwarderRequest();
            inValue.addSafForwarder = addSafForwarder;
            return ((AxlNetClient.AXLPort53)(this)).addSafForwarderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSafForwarderResponse AxlNetClient.AXLPort53.updateSafForwarder(AxlNetClient.updateSafForwarderRequest request)
        {
            return base.Channel.updateSafForwarder(request);
        }

        public AxlNetClient.StandardResponse updateSafForwarder(AxlNetClient.UpdateSafForwarderReq updateSafForwarder1)
        {
            AxlNetClient.updateSafForwarderRequest inValue = new AxlNetClient.updateSafForwarderRequest();
            inValue.updateSafForwarder = updateSafForwarder1;
            AxlNetClient.updateSafForwarderResponse retVal = ((AxlNetClient.AXLPort53)(this)).updateSafForwarder(inValue);
            return retVal.updateSafForwarderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSafForwarderResponse> AxlNetClient.AXLPort53.updateSafForwarderAsync(AxlNetClient.updateSafForwarderRequest request)
        {
            return base.Channel.updateSafForwarderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSafForwarderResponse> updateSafForwarderAsync(AxlNetClient.UpdateSafForwarderReq updateSafForwarder)
        {
            AxlNetClient.updateSafForwarderRequest inValue = new AxlNetClient.updateSafForwarderRequest();
            inValue.updateSafForwarder = updateSafForwarder;
            return ((AxlNetClient.AXLPort53)(this)).updateSafForwarderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getSafForwarderResponse AxlNetClient.AXLPort53.getSafForwarder(AxlNetClient.getSafForwarderRequest request)
        {
            return base.Channel.getSafForwarder(request);
        }

        public AxlNetClient.GetSafForwarderRes getSafForwarder(AxlNetClient.GetSafForwarderReq getSafForwarder1)
        {
            AxlNetClient.getSafForwarderRequest inValue = new AxlNetClient.getSafForwarderRequest();
            inValue.getSafForwarder = getSafForwarder1;
            AxlNetClient.getSafForwarderResponse retVal = ((AxlNetClient.AXLPort53)(this)).getSafForwarder(inValue);
            return retVal.getSafForwarderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getSafForwarderResponse> AxlNetClient.AXLPort53.getSafForwarderAsync(AxlNetClient.getSafForwarderRequest request)
        {
            return base.Channel.getSafForwarderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getSafForwarderResponse> getSafForwarderAsync(AxlNetClient.GetSafForwarderReq getSafForwarder)
        {
            AxlNetClient.getSafForwarderRequest inValue = new AxlNetClient.getSafForwarderRequest();
            inValue.getSafForwarder = getSafForwarder;
            return ((AxlNetClient.AXLPort53)(this)).getSafForwarderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeSafForwarderResponse AxlNetClient.AXLPort53.removeSafForwarder(AxlNetClient.removeSafForwarderRequest request)
        {
            return base.Channel.removeSafForwarder(request);
        }

        public AxlNetClient.StandardResponse removeSafForwarder(AxlNetClient.NameAndGUIDRequest removeSafForwarder1)
        {
            AxlNetClient.removeSafForwarderRequest inValue = new AxlNetClient.removeSafForwarderRequest();
            inValue.removeSafForwarder = removeSafForwarder1;
            AxlNetClient.removeSafForwarderResponse retVal = ((AxlNetClient.AXLPort53)(this)).removeSafForwarder(inValue);
            return retVal.removeSafForwarderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeSafForwarderResponse> AxlNetClient.AXLPort53.removeSafForwarderAsync(AxlNetClient.removeSafForwarderRequest request)
        {
            return base.Channel.removeSafForwarderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeSafForwarderResponse> removeSafForwarderAsync(AxlNetClient.NameAndGUIDRequest removeSafForwarder)
        {
            AxlNetClient.removeSafForwarderRequest inValue = new AxlNetClient.removeSafForwarderRequest();
            inValue.removeSafForwarder = removeSafForwarder;
            return ((AxlNetClient.AXLPort53)(this)).removeSafForwarderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSafForwarderResponse AxlNetClient.AXLPort53.listSafForwarder(AxlNetClient.listSafForwarderRequest request)
        {
            return base.Channel.listSafForwarder(request);
        }

        public AxlNetClient.ListSafForwarderRes listSafForwarder(AxlNetClient.ListSafForwarderReq listSafForwarder1)
        {
            AxlNetClient.listSafForwarderRequest inValue = new AxlNetClient.listSafForwarderRequest();
            inValue.listSafForwarder = listSafForwarder1;
            AxlNetClient.listSafForwarderResponse retVal = ((AxlNetClient.AXLPort53)(this)).listSafForwarder(inValue);
            return retVal.listSafForwarderResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSafForwarderResponse> AxlNetClient.AXLPort53.listSafForwarderAsync(AxlNetClient.listSafForwarderRequest request)
        {
            return base.Channel.listSafForwarderAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSafForwarderResponse> listSafForwarderAsync(AxlNetClient.ListSafForwarderReq listSafForwarder)
        {
            AxlNetClient.listSafForwarderRequest inValue = new AxlNetClient.listSafForwarderRequest();
            inValue.listSafForwarder = listSafForwarder;
            return ((AxlNetClient.AXLPort53)(this)).listSafForwarderAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCcdHostedDNResponse AxlNetClient.AXLPort53.addCcdHostedDN(AxlNetClient.addCcdHostedDNRequest request)
        {
            return base.Channel.addCcdHostedDN(request);
        }

        public AxlNetClient.StandardResponse addCcdHostedDN(AxlNetClient.AddCcdHostedDNReq addCcdHostedDN1)
        {
            AxlNetClient.addCcdHostedDNRequest inValue = new AxlNetClient.addCcdHostedDNRequest();
            inValue.addCcdHostedDN = addCcdHostedDN1;
            AxlNetClient.addCcdHostedDNResponse retVal = ((AxlNetClient.AXLPort53)(this)).addCcdHostedDN(inValue);
            return retVal.addCcdHostedDNResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNResponse> AxlNetClient.AXLPort53.addCcdHostedDNAsync(AxlNetClient.addCcdHostedDNRequest request)
        {
            return base.Channel.addCcdHostedDNAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCcdHostedDNResponse> addCcdHostedDNAsync(AxlNetClient.AddCcdHostedDNReq addCcdHostedDN)
        {
            AxlNetClient.addCcdHostedDNRequest inValue = new AxlNetClient.addCcdHostedDNRequest();
            inValue.addCcdHostedDN = addCcdHostedDN;
            return ((AxlNetClient.AXLPort53)(this)).addCcdHostedDNAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCcdHostedDNResponse AxlNetClient.AXLPort53.updateCcdHostedDN(AxlNetClient.updateCcdHostedDNRequest request)
        {
            return base.Channel.updateCcdHostedDN(request);
        }

        public AxlNetClient.StandardResponse updateCcdHostedDN(AxlNetClient.UpdateCcdHostedDNReq updateCcdHostedDN1)
        {
            AxlNetClient.updateCcdHostedDNRequest inValue = new AxlNetClient.updateCcdHostedDNRequest();
            inValue.updateCcdHostedDN = updateCcdHostedDN1;
            AxlNetClient.updateCcdHostedDNResponse retVal = ((AxlNetClient.AXLPort53)(this)).updateCcdHostedDN(inValue);
            return retVal.updateCcdHostedDNResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNResponse> AxlNetClient.AXLPort53.updateCcdHostedDNAsync(AxlNetClient.updateCcdHostedDNRequest request)
        {
            return base.Channel.updateCcdHostedDNAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCcdHostedDNResponse> updateCcdHostedDNAsync(AxlNetClient.UpdateCcdHostedDNReq updateCcdHostedDN)
        {
            AxlNetClient.updateCcdHostedDNRequest inValue = new AxlNetClient.updateCcdHostedDNRequest();
            inValue.updateCcdHostedDN = updateCcdHostedDN;
            return ((AxlNetClient.AXLPort53)(this)).updateCcdHostedDNAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCcdHostedDNResponse AxlNetClient.AXLPort53.getCcdHostedDN(AxlNetClient.getCcdHostedDNRequest request)
        {
            return base.Channel.getCcdHostedDN(request);
        }

        public AxlNetClient.GetCcdHostedDNRes getCcdHostedDN(AxlNetClient.GetCcdHostedDNReq getCcdHostedDN1)
        {
            AxlNetClient.getCcdHostedDNRequest inValue = new AxlNetClient.getCcdHostedDNRequest();
            inValue.getCcdHostedDN = getCcdHostedDN1;
            AxlNetClient.getCcdHostedDNResponse retVal = ((AxlNetClient.AXLPort53)(this)).getCcdHostedDN(inValue);
            return retVal.getCcdHostedDNResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNResponse> AxlNetClient.AXLPort53.getCcdHostedDNAsync(AxlNetClient.getCcdHostedDNRequest request)
        {
            return base.Channel.getCcdHostedDNAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCcdHostedDNResponse> getCcdHostedDNAsync(AxlNetClient.GetCcdHostedDNReq getCcdHostedDN)
        {
            AxlNetClient.getCcdHostedDNRequest inValue = new AxlNetClient.getCcdHostedDNRequest();
            inValue.getCcdHostedDN = getCcdHostedDN;
            return ((AxlNetClient.AXLPort53)(this)).getCcdHostedDNAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCcdHostedDNResponse AxlNetClient.AXLPort53.removeCcdHostedDN(AxlNetClient.removeCcdHostedDNRequest request)
        {
            return base.Channel.removeCcdHostedDN(request);
        }

        public AxlNetClient.StandardResponse removeCcdHostedDN(AxlNetClient.RemoveCcdHostedDNReq removeCcdHostedDN1)
        {
            AxlNetClient.removeCcdHostedDNRequest inValue = new AxlNetClient.removeCcdHostedDNRequest();
            inValue.removeCcdHostedDN = removeCcdHostedDN1;
            AxlNetClient.removeCcdHostedDNResponse retVal = ((AxlNetClient.AXLPort53)(this)).removeCcdHostedDN(inValue);
            return retVal.removeCcdHostedDNResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNResponse> AxlNetClient.AXLPort53.removeCcdHostedDNAsync(AxlNetClient.removeCcdHostedDNRequest request)
        {
            return base.Channel.removeCcdHostedDNAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCcdHostedDNResponse> removeCcdHostedDNAsync(AxlNetClient.RemoveCcdHostedDNReq removeCcdHostedDN)
        {
            AxlNetClient.removeCcdHostedDNRequest inValue = new AxlNetClient.removeCcdHostedDNRequest();
            inValue.removeCcdHostedDN = removeCcdHostedDN;
            return ((AxlNetClient.AXLPort53)(this)).removeCcdHostedDNAsync(inValue);
        }
    }
}