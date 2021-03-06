namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient43 _axlPortClient43;

        private static AXLPortClient43 axlPortClient43 => _axlPortClient43 == null ||
            _axlPortClient43.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient43 = LoadClient43()) : _axlPortClient43;

        private static AXLPortClient43 LoadClient43()
        {
            var client = new AXLPortClient43(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close43;
            OnAbort += Abort43;
            return client;
        }

        private static void Close43(object sender, System.EventArgs e)
        {
            _axlPortClient43.Close();            
        }

        private static void Abort43(object sender, System.EventArgs e)
        {
            _axlPortClient43.Abort();
        }

        public AxlNetClient.StandardResponse addPhone(AxlNetClient.AddPhoneReq addPhone1)
        {
            return axlPortClient43.addPhone(addPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneResponse> addPhoneAsync(AxlNetClient.AddPhoneReq addPhone)
        {
            return axlPortClient43.addPhoneAsync(addPhone);
        }

        public AxlNetClient.StandardResponse updatePhone(AxlNetClient.UpdatePhoneReq updatePhone1)
        {
            return axlPortClient43.updatePhone(updatePhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneResponse> updatePhoneAsync(AxlNetClient.UpdatePhoneReq updatePhone)
        {
            return axlPortClient43.updatePhoneAsync(updatePhone);
        }

        public AxlNetClient.GetPhoneRes getPhone(AxlNetClient.GetPhoneReq getPhone1)
        {
            return axlPortClient43.getPhone(getPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneResponse> getPhoneAsync(AxlNetClient.GetPhoneReq getPhone)
        {
            return axlPortClient43.getPhoneAsync(getPhone);
        }

        public AxlNetClient.StandardResponse removePhone(AxlNetClient.NameAndGUIDRequest removePhone1)
        {
            return axlPortClient43.removePhone(removePhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneResponse> removePhoneAsync(AxlNetClient.NameAndGUIDRequest removePhone)
        {
            return axlPortClient43.removePhoneAsync(removePhone);
        }

        public AxlNetClient.ListPhoneRes listPhone(AxlNetClient.ListPhoneReq listPhone1)
        {
            return axlPortClient43.listPhone(listPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneResponse> listPhoneAsync(AxlNetClient.ListPhoneReq listPhone)
        {
            return axlPortClient43.listPhoneAsync(listPhone);
        }

        public AxlNetClient.StandardResponse resetPhone(AxlNetClient.NameAndGUIDRequest resetPhone1)
        {
            return axlPortClient43.resetPhone(resetPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetPhoneResponse> resetPhoneAsync(AxlNetClient.NameAndGUIDRequest resetPhone)
        {
            return axlPortClient43.resetPhoneAsync(resetPhone);
        }

        public AxlNetClient.StandardResponse restartPhone(AxlNetClient.NameAndGUIDRequest restartPhone1)
        {
            return axlPortClient43.restartPhone(restartPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartPhoneResponse> restartPhoneAsync(AxlNetClient.NameAndGUIDRequest restartPhone)
        {
            return axlPortClient43.restartPhoneAsync(restartPhone);
        }

        public AxlNetClient.StandardResponse applyPhone(AxlNetClient.NameAndGUIDRequest applyPhone1)
        {
            return axlPortClient43.applyPhone(applyPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneResponse> applyPhoneAsync(AxlNetClient.NameAndGUIDRequest applyPhone)
        {
            return axlPortClient43.applyPhoneAsync(applyPhone);
        }

        public AxlNetClient.StandardResponse wipePhone(AxlNetClient.NameAndGUIDRequest wipePhone1)
        {
            return axlPortClient43.wipePhone(wipePhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.wipePhoneResponse> wipePhoneAsync(AxlNetClient.NameAndGUIDRequest wipePhone)
        {
            return axlPortClient43.wipePhoneAsync(wipePhone);
        }

        public AxlNetClient.StandardResponse lockPhone(AxlNetClient.NameAndGUIDRequest lockPhone1)
        {
            return axlPortClient43.lockPhone(lockPhone1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.lockPhoneResponse> lockPhoneAsync(AxlNetClient.NameAndGUIDRequest lockPhone)
        {
            return axlPortClient43.lockPhoneAsync(lockPhone);
        }

        public AxlNetClient.GetPhoneOptionsRes getPhoneOptions(AxlNetClient.GetPhoneOptionsReq getPhoneOptions1)
        {
            return axlPortClient43.getPhoneOptions(getPhoneOptions1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneOptionsResponse> getPhoneOptionsAsync(AxlNetClient.GetPhoneOptionsReq getPhoneOptions)
        {
            return axlPortClient43.getPhoneOptionsAsync(getPhoneOptions);
        }

        public AxlNetClient.StandardResponse addH323Gateway(AxlNetClient.AddH323GatewayReq addH323Gateway1)
        {
            return axlPortClient43.addH323Gateway(addH323Gateway1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323GatewayResponse> addH323GatewayAsync(AxlNetClient.AddH323GatewayReq addH323Gateway)
        {
            return axlPortClient43.addH323GatewayAsync(addH323Gateway);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort43
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPhoneResponse addPhone(AxlNetClient.addPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneResponse> addPhoneAsync(AxlNetClient.addPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePhoneResponse updatePhone(AxlNetClient.updatePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneResponse> updatePhoneAsync(AxlNetClient.updatePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneResponse getPhone(AxlNetClient.getPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneResponse> getPhoneAsync(AxlNetClient.getPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePhoneResponse removePhone(AxlNetClient.removePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneResponse> removePhoneAsync(AxlNetClient.removePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPhoneResponse listPhone(AxlNetClient.listPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneResponse> listPhoneAsync(AxlNetClient.listPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetPhoneResponse resetPhone(AxlNetClient.resetPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetPhoneResponse> resetPhoneAsync(AxlNetClient.resetPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.restartPhoneResponse restartPhone(AxlNetClient.restartPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 restartPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.restartPhoneResponse> restartPhoneAsync(AxlNetClient.restartPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyPhoneResponse applyPhone(AxlNetClient.applyPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneResponse> applyPhoneAsync(AxlNetClient.applyPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 wipePhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.wipePhoneResponse wipePhone(AxlNetClient.wipePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 wipePhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.wipePhoneResponse> wipePhoneAsync(AxlNetClient.wipePhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 lockPhone", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.lockPhoneResponse lockPhone(AxlNetClient.lockPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 lockPhone", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.lockPhoneResponse> lockPhoneAsync(AxlNetClient.lockPhoneRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneOptions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneOptionsResponse getPhoneOptions(AxlNetClient.getPhoneOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneOptions", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneOptionsResponse> getPhoneOptionsAsync(AxlNetClient.getPhoneOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Gateway", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addH323GatewayResponse addH323Gateway(AxlNetClient.addH323GatewayRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addH323Gateway", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addH323GatewayResponse> addH323GatewayAsync(AxlNetClient.addH323GatewayRequest request);
    }

    public class AXLPortClient43 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort43>, AxlNetClient.AXLPort43
    {
        public AXLPortClient43(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPhoneResponse AxlNetClient.AXLPort43.addPhone(AxlNetClient.addPhoneRequest request)
        {
            return base.Channel.addPhone(request);
        }

        public AxlNetClient.StandardResponse addPhone(AxlNetClient.AddPhoneReq addPhone1)
        {
            AxlNetClient.addPhoneRequest inValue = new AxlNetClient.addPhoneRequest();
            inValue.addPhone = addPhone1;
            AxlNetClient.addPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).addPhone(inValue);
            return retVal.addPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneResponse> AxlNetClient.AXLPort43.addPhoneAsync(AxlNetClient.addPhoneRequest request)
        {
            return base.Channel.addPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneResponse> addPhoneAsync(AxlNetClient.AddPhoneReq addPhone)
        {
            AxlNetClient.addPhoneRequest inValue = new AxlNetClient.addPhoneRequest();
            inValue.addPhone = addPhone;
            return ((AxlNetClient.AXLPort43)(this)).addPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePhoneResponse AxlNetClient.AXLPort43.updatePhone(AxlNetClient.updatePhoneRequest request)
        {
            return base.Channel.updatePhone(request);
        }

        public AxlNetClient.StandardResponse updatePhone(AxlNetClient.UpdatePhoneReq updatePhone1)
        {
            AxlNetClient.updatePhoneRequest inValue = new AxlNetClient.updatePhoneRequest();
            inValue.updatePhone = updatePhone1;
            AxlNetClient.updatePhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).updatePhone(inValue);
            return retVal.updatePhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneResponse> AxlNetClient.AXLPort43.updatePhoneAsync(AxlNetClient.updatePhoneRequest request)
        {
            return base.Channel.updatePhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneResponse> updatePhoneAsync(AxlNetClient.UpdatePhoneReq updatePhone)
        {
            AxlNetClient.updatePhoneRequest inValue = new AxlNetClient.updatePhoneRequest();
            inValue.updatePhone = updatePhone;
            return ((AxlNetClient.AXLPort43)(this)).updatePhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneResponse AxlNetClient.AXLPort43.getPhone(AxlNetClient.getPhoneRequest request)
        {
            return base.Channel.getPhone(request);
        }

        public AxlNetClient.GetPhoneRes getPhone(AxlNetClient.GetPhoneReq getPhone1)
        {
            AxlNetClient.getPhoneRequest inValue = new AxlNetClient.getPhoneRequest();
            inValue.getPhone = getPhone1;
            AxlNetClient.getPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).getPhone(inValue);
            return retVal.getPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneResponse> AxlNetClient.AXLPort43.getPhoneAsync(AxlNetClient.getPhoneRequest request)
        {
            return base.Channel.getPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneResponse> getPhoneAsync(AxlNetClient.GetPhoneReq getPhone)
        {
            AxlNetClient.getPhoneRequest inValue = new AxlNetClient.getPhoneRequest();
            inValue.getPhone = getPhone;
            return ((AxlNetClient.AXLPort43)(this)).getPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePhoneResponse AxlNetClient.AXLPort43.removePhone(AxlNetClient.removePhoneRequest request)
        {
            return base.Channel.removePhone(request);
        }

        public AxlNetClient.StandardResponse removePhone(AxlNetClient.NameAndGUIDRequest removePhone1)
        {
            AxlNetClient.removePhoneRequest inValue = new AxlNetClient.removePhoneRequest();
            inValue.removePhone = removePhone1;
            AxlNetClient.removePhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).removePhone(inValue);
            return retVal.removePhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneResponse> AxlNetClient.AXLPort43.removePhoneAsync(AxlNetClient.removePhoneRequest request)
        {
            return base.Channel.removePhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneResponse> removePhoneAsync(AxlNetClient.NameAndGUIDRequest removePhone)
        {
            AxlNetClient.removePhoneRequest inValue = new AxlNetClient.removePhoneRequest();
            inValue.removePhone = removePhone;
            return ((AxlNetClient.AXLPort43)(this)).removePhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPhoneResponse AxlNetClient.AXLPort43.listPhone(AxlNetClient.listPhoneRequest request)
        {
            return base.Channel.listPhone(request);
        }

        public AxlNetClient.ListPhoneRes listPhone(AxlNetClient.ListPhoneReq listPhone1)
        {
            AxlNetClient.listPhoneRequest inValue = new AxlNetClient.listPhoneRequest();
            inValue.listPhone = listPhone1;
            AxlNetClient.listPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).listPhone(inValue);
            return retVal.listPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneResponse> AxlNetClient.AXLPort43.listPhoneAsync(AxlNetClient.listPhoneRequest request)
        {
            return base.Channel.listPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneResponse> listPhoneAsync(AxlNetClient.ListPhoneReq listPhone)
        {
            AxlNetClient.listPhoneRequest inValue = new AxlNetClient.listPhoneRequest();
            inValue.listPhone = listPhone;
            return ((AxlNetClient.AXLPort43)(this)).listPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetPhoneResponse AxlNetClient.AXLPort43.resetPhone(AxlNetClient.resetPhoneRequest request)
        {
            return base.Channel.resetPhone(request);
        }

        public AxlNetClient.StandardResponse resetPhone(AxlNetClient.NameAndGUIDRequest resetPhone1)
        {
            AxlNetClient.resetPhoneRequest inValue = new AxlNetClient.resetPhoneRequest();
            inValue.resetPhone = resetPhone1;
            AxlNetClient.resetPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).resetPhone(inValue);
            return retVal.resetPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetPhoneResponse> AxlNetClient.AXLPort43.resetPhoneAsync(AxlNetClient.resetPhoneRequest request)
        {
            return base.Channel.resetPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetPhoneResponse> resetPhoneAsync(AxlNetClient.NameAndGUIDRequest resetPhone)
        {
            AxlNetClient.resetPhoneRequest inValue = new AxlNetClient.resetPhoneRequest();
            inValue.resetPhone = resetPhone;
            return ((AxlNetClient.AXLPort43)(this)).resetPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.restartPhoneResponse AxlNetClient.AXLPort43.restartPhone(AxlNetClient.restartPhoneRequest request)
        {
            return base.Channel.restartPhone(request);
        }

        public AxlNetClient.StandardResponse restartPhone(AxlNetClient.NameAndGUIDRequest restartPhone1)
        {
            AxlNetClient.restartPhoneRequest inValue = new AxlNetClient.restartPhoneRequest();
            inValue.restartPhone = restartPhone1;
            AxlNetClient.restartPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).restartPhone(inValue);
            return retVal.restartPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.restartPhoneResponse> AxlNetClient.AXLPort43.restartPhoneAsync(AxlNetClient.restartPhoneRequest request)
        {
            return base.Channel.restartPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.restartPhoneResponse> restartPhoneAsync(AxlNetClient.NameAndGUIDRequest restartPhone)
        {
            AxlNetClient.restartPhoneRequest inValue = new AxlNetClient.restartPhoneRequest();
            inValue.restartPhone = restartPhone;
            return ((AxlNetClient.AXLPort43)(this)).restartPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyPhoneResponse AxlNetClient.AXLPort43.applyPhone(AxlNetClient.applyPhoneRequest request)
        {
            return base.Channel.applyPhone(request);
        }

        public AxlNetClient.StandardResponse applyPhone(AxlNetClient.NameAndGUIDRequest applyPhone1)
        {
            AxlNetClient.applyPhoneRequest inValue = new AxlNetClient.applyPhoneRequest();
            inValue.applyPhone = applyPhone1;
            AxlNetClient.applyPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).applyPhone(inValue);
            return retVal.applyPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyPhoneResponse> AxlNetClient.AXLPort43.applyPhoneAsync(AxlNetClient.applyPhoneRequest request)
        {
            return base.Channel.applyPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyPhoneResponse> applyPhoneAsync(AxlNetClient.NameAndGUIDRequest applyPhone)
        {
            AxlNetClient.applyPhoneRequest inValue = new AxlNetClient.applyPhoneRequest();
            inValue.applyPhone = applyPhone;
            return ((AxlNetClient.AXLPort43)(this)).applyPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.wipePhoneResponse AxlNetClient.AXLPort43.wipePhone(AxlNetClient.wipePhoneRequest request)
        {
            return base.Channel.wipePhone(request);
        }

        public AxlNetClient.StandardResponse wipePhone(AxlNetClient.NameAndGUIDRequest wipePhone1)
        {
            AxlNetClient.wipePhoneRequest inValue = new AxlNetClient.wipePhoneRequest();
            inValue.wipePhone = wipePhone1;
            AxlNetClient.wipePhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).wipePhone(inValue);
            return retVal.wipePhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.wipePhoneResponse> AxlNetClient.AXLPort43.wipePhoneAsync(AxlNetClient.wipePhoneRequest request)
        {
            return base.Channel.wipePhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.wipePhoneResponse> wipePhoneAsync(AxlNetClient.NameAndGUIDRequest wipePhone)
        {
            AxlNetClient.wipePhoneRequest inValue = new AxlNetClient.wipePhoneRequest();
            inValue.wipePhone = wipePhone;
            return ((AxlNetClient.AXLPort43)(this)).wipePhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.lockPhoneResponse AxlNetClient.AXLPort43.lockPhone(AxlNetClient.lockPhoneRequest request)
        {
            return base.Channel.lockPhone(request);
        }

        public AxlNetClient.StandardResponse lockPhone(AxlNetClient.NameAndGUIDRequest lockPhone1)
        {
            AxlNetClient.lockPhoneRequest inValue = new AxlNetClient.lockPhoneRequest();
            inValue.lockPhone = lockPhone1;
            AxlNetClient.lockPhoneResponse retVal = ((AxlNetClient.AXLPort43)(this)).lockPhone(inValue);
            return retVal.lockPhoneResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.lockPhoneResponse> AxlNetClient.AXLPort43.lockPhoneAsync(AxlNetClient.lockPhoneRequest request)
        {
            return base.Channel.lockPhoneAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.lockPhoneResponse> lockPhoneAsync(AxlNetClient.NameAndGUIDRequest lockPhone)
        {
            AxlNetClient.lockPhoneRequest inValue = new AxlNetClient.lockPhoneRequest();
            inValue.lockPhone = lockPhone;
            return ((AxlNetClient.AXLPort43)(this)).lockPhoneAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneOptionsResponse AxlNetClient.AXLPort43.getPhoneOptions(AxlNetClient.getPhoneOptionsRequest request)
        {
            return base.Channel.getPhoneOptions(request);
        }

        public AxlNetClient.GetPhoneOptionsRes getPhoneOptions(AxlNetClient.GetPhoneOptionsReq getPhoneOptions1)
        {
            AxlNetClient.getPhoneOptionsRequest inValue = new AxlNetClient.getPhoneOptionsRequest();
            inValue.getPhoneOptions = getPhoneOptions1;
            AxlNetClient.getPhoneOptionsResponse retVal = ((AxlNetClient.AXLPort43)(this)).getPhoneOptions(inValue);
            return retVal.getPhoneOptionsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneOptionsResponse> AxlNetClient.AXLPort43.getPhoneOptionsAsync(AxlNetClient.getPhoneOptionsRequest request)
        {
            return base.Channel.getPhoneOptionsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneOptionsResponse> getPhoneOptionsAsync(AxlNetClient.GetPhoneOptionsReq getPhoneOptions)
        {
            AxlNetClient.getPhoneOptionsRequest inValue = new AxlNetClient.getPhoneOptionsRequest();
            inValue.getPhoneOptions = getPhoneOptions;
            return ((AxlNetClient.AXLPort43)(this)).getPhoneOptionsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addH323GatewayResponse AxlNetClient.AXLPort43.addH323Gateway(AxlNetClient.addH323GatewayRequest request)
        {
            return base.Channel.addH323Gateway(request);
        }

        public AxlNetClient.StandardResponse addH323Gateway(AxlNetClient.AddH323GatewayReq addH323Gateway1)
        {
            AxlNetClient.addH323GatewayRequest inValue = new AxlNetClient.addH323GatewayRequest();
            inValue.addH323Gateway = addH323Gateway1;
            AxlNetClient.addH323GatewayResponse retVal = ((AxlNetClient.AXLPort43)(this)).addH323Gateway(inValue);
            return retVal.addH323GatewayResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addH323GatewayResponse> AxlNetClient.AXLPort43.addH323GatewayAsync(AxlNetClient.addH323GatewayRequest request)
        {
            return base.Channel.addH323GatewayAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addH323GatewayResponse> addH323GatewayAsync(AxlNetClient.AddH323GatewayReq addH323Gateway)
        {
            AxlNetClient.addH323GatewayRequest inValue = new AxlNetClient.addH323GatewayRequest();
            inValue.addH323Gateway = addH323Gateway;
            return ((AxlNetClient.AXLPort43)(this)).addH323GatewayAsync(inValue);
        }
    }
}