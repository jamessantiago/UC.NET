namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient24 _axlPortClient24;

        private static AXLPortClient24 axlPortClient24 => _axlPortClient24 == null ||
            _axlPortClient24.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient24 = LoadClient24()) : _axlPortClient24;

        private static AXLPortClient24 LoadClient24()
        {
            var client = new AXLPortClient24(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close24;
            OnAbort += Abort24;
            return client;
        }

        private static void Close24(object sender, System.EventArgs e)
        {
            _axlPortClient24.Close();
        }

        private static void Abort24(object sender, System.EventArgs e)
        {
            _axlPortClient24.Abort();
        }

        public AxlNetClient.ListSipRealmRes listSipRealm(AxlNetClient.ListSipRealmReq listSipRealm1)
        {
            return axlPortClient24.listSipRealm(listSipRealm1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipRealmResponse> listSipRealmAsync(AxlNetClient.ListSipRealmReq listSipRealm)
        {
            return axlPortClient24.listSipRealmAsync(listSipRealm);
        }

        public AxlNetClient.StandardResponse addPhoneNtp(AxlNetClient.AddPhoneNtpReq addPhoneNtp1)
        {
            return axlPortClient24.addPhoneNtp(addPhoneNtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneNtpResponse> addPhoneNtpAsync(AxlNetClient.AddPhoneNtpReq addPhoneNtp)
        {
            return axlPortClient24.addPhoneNtpAsync(addPhoneNtp);
        }

        public AxlNetClient.StandardResponse updatePhoneNtp(AxlNetClient.UpdatePhoneNtpReq updatePhoneNtp1)
        {
            return axlPortClient24.updatePhoneNtp(updatePhoneNtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneNtpResponse> updatePhoneNtpAsync(AxlNetClient.UpdatePhoneNtpReq updatePhoneNtp)
        {
            return axlPortClient24.updatePhoneNtpAsync(updatePhoneNtp);
        }

        public AxlNetClient.GetPhoneNtpRes getPhoneNtp(AxlNetClient.GetPhoneNtpReq getPhoneNtp1)
        {
            return axlPortClient24.getPhoneNtp(getPhoneNtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneNtpResponse> getPhoneNtpAsync(AxlNetClient.GetPhoneNtpReq getPhoneNtp)
        {
            return axlPortClient24.getPhoneNtpAsync(getPhoneNtp);
        }

        public AxlNetClient.StandardResponse removePhoneNtp(AxlNetClient.RemovePhoneNtpReq removePhoneNtp1)
        {
            return axlPortClient24.removePhoneNtp(removePhoneNtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneNtpResponse> removePhoneNtpAsync(AxlNetClient.RemovePhoneNtpReq removePhoneNtp)
        {
            return axlPortClient24.removePhoneNtpAsync(removePhoneNtp);
        }

        public AxlNetClient.ListPhoneNtpRes listPhoneNtp(AxlNetClient.ListPhoneNtpReq listPhoneNtp1)
        {
            return axlPortClient24.listPhoneNtp(listPhoneNtp1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneNtpResponse> listPhoneNtpAsync(AxlNetClient.ListPhoneNtpReq listPhoneNtp)
        {
            return axlPortClient24.listPhoneNtpAsync(listPhoneNtp);
        }

        public AxlNetClient.StandardResponse addDateTimeGroup(AxlNetClient.AddDateTimeGroupReq addDateTimeGroup1)
        {
            return axlPortClient24.addDateTimeGroup(addDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDateTimeGroupResponse> addDateTimeGroupAsync(AxlNetClient.AddDateTimeGroupReq addDateTimeGroup)
        {
            return axlPortClient24.addDateTimeGroupAsync(addDateTimeGroup);
        }

        public AxlNetClient.StandardResponse updateDateTimeGroup(AxlNetClient.UpdateDateTimeGroupReq updateDateTimeGroup1)
        {
            return axlPortClient24.updateDateTimeGroup(updateDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDateTimeGroupResponse> updateDateTimeGroupAsync(AxlNetClient.UpdateDateTimeGroupReq updateDateTimeGroup)
        {
            return axlPortClient24.updateDateTimeGroupAsync(updateDateTimeGroup);
        }

        public AxlNetClient.GetDateTimeGroupRes getDateTimeGroup(AxlNetClient.GetDateTimeGroupReq getDateTimeGroup1)
        {
            return axlPortClient24.getDateTimeGroup(getDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDateTimeGroupResponse> getDateTimeGroupAsync(AxlNetClient.GetDateTimeGroupReq getDateTimeGroup)
        {
            return axlPortClient24.getDateTimeGroupAsync(getDateTimeGroup);
        }

        public AxlNetClient.StandardResponse removeDateTimeGroup(AxlNetClient.NameAndGUIDRequest removeDateTimeGroup1)
        {
            return axlPortClient24.removeDateTimeGroup(removeDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDateTimeGroupResponse> removeDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest removeDateTimeGroup)
        {
            return axlPortClient24.removeDateTimeGroupAsync(removeDateTimeGroup);
        }

        public AxlNetClient.ListDateTimeGroupRes listDateTimeGroup(AxlNetClient.ListDateTimeGroupReq listDateTimeGroup1)
        {
            return axlPortClient24.listDateTimeGroup(listDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDateTimeGroupResponse> listDateTimeGroupAsync(AxlNetClient.ListDateTimeGroupReq listDateTimeGroup)
        {
            return axlPortClient24.listDateTimeGroupAsync(listDateTimeGroup);
        }

        public AxlNetClient.StandardResponse resetDateTimeGroup(AxlNetClient.NameAndGUIDRequest resetDateTimeGroup1)
        {
            return axlPortClient24.resetDateTimeGroup(resetDateTimeGroup1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDateTimeGroupResponse> resetDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest resetDateTimeGroup)
        {
            return axlPortClient24.resetDateTimeGroupAsync(resetDateTimeGroup);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort24
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipRealm", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listSipRealmResponse listSipRealm(AxlNetClient.listSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listSipRealm", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listSipRealmResponse> listSipRealmAsync(AxlNetClient.listSipRealmRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneNtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addPhoneNtpResponse addPhoneNtp(AxlNetClient.addPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addPhoneNtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneNtpResponse> addPhoneNtpAsync(AxlNetClient.addPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneNtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updatePhoneNtpResponse updatePhoneNtp(AxlNetClient.updatePhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updatePhoneNtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneNtpResponse> updatePhoneNtpAsync(AxlNetClient.updatePhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneNtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getPhoneNtpResponse getPhoneNtp(AxlNetClient.getPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getPhoneNtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneNtpResponse> getPhoneNtpAsync(AxlNetClient.getPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneNtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removePhoneNtpResponse removePhoneNtp(AxlNetClient.removePhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removePhoneNtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneNtpResponse> removePhoneNtpAsync(AxlNetClient.removePhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneNtp", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listPhoneNtpResponse listPhoneNtp(AxlNetClient.listPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listPhoneNtp", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneNtpResponse> listPhoneNtpAsync(AxlNetClient.listPhoneNtpRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addDateTimeGroupResponse addDateTimeGroup(AxlNetClient.addDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addDateTimeGroupResponse> addDateTimeGroupAsync(AxlNetClient.addDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateDateTimeGroupResponse updateDateTimeGroup(AxlNetClient.updateDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateDateTimeGroupResponse> updateDateTimeGroupAsync(AxlNetClient.updateDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getDateTimeGroupResponse getDateTimeGroup(AxlNetClient.getDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getDateTimeGroupResponse> getDateTimeGroupAsync(AxlNetClient.getDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeDateTimeGroupResponse removeDateTimeGroup(AxlNetClient.removeDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeDateTimeGroupResponse> removeDateTimeGroupAsync(AxlNetClient.removeDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listDateTimeGroupResponse listDateTimeGroup(AxlNetClient.listDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listDateTimeGroupResponse> listDateTimeGroupAsync(AxlNetClient.listDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDateTimeGroup", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.resetDateTimeGroupResponse resetDateTimeGroup(AxlNetClient.resetDateTimeGroupRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 resetDateTimeGroup", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.resetDateTimeGroupResponse> resetDateTimeGroupAsync(AxlNetClient.resetDateTimeGroupRequest request);
    }

    public class AXLPortClient24 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort24>, AxlNetClient.AXLPort24
    {
        public AXLPortClient24(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listSipRealmResponse AxlNetClient.AXLPort24.listSipRealm(AxlNetClient.listSipRealmRequest request)
        {
            return base.Channel.listSipRealm(request);
        }

        public AxlNetClient.ListSipRealmRes listSipRealm(AxlNetClient.ListSipRealmReq listSipRealm1)
        {
            AxlNetClient.listSipRealmRequest inValue = new AxlNetClient.listSipRealmRequest();
            inValue.listSipRealm = listSipRealm1;
            AxlNetClient.listSipRealmResponse retVal = ((AxlNetClient.AXLPort24)(this)).listSipRealm(inValue);
            return retVal.listSipRealmResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listSipRealmResponse> AxlNetClient.AXLPort24.listSipRealmAsync(AxlNetClient.listSipRealmRequest request)
        {
            return base.Channel.listSipRealmAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listSipRealmResponse> listSipRealmAsync(AxlNetClient.ListSipRealmReq listSipRealm)
        {
            AxlNetClient.listSipRealmRequest inValue = new AxlNetClient.listSipRealmRequest();
            inValue.listSipRealm = listSipRealm;
            return ((AxlNetClient.AXLPort24)(this)).listSipRealmAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addPhoneNtpResponse AxlNetClient.AXLPort24.addPhoneNtp(AxlNetClient.addPhoneNtpRequest request)
        {
            return base.Channel.addPhoneNtp(request);
        }

        public AxlNetClient.StandardResponse addPhoneNtp(AxlNetClient.AddPhoneNtpReq addPhoneNtp1)
        {
            AxlNetClient.addPhoneNtpRequest inValue = new AxlNetClient.addPhoneNtpRequest();
            inValue.addPhoneNtp = addPhoneNtp1;
            AxlNetClient.addPhoneNtpResponse retVal = ((AxlNetClient.AXLPort24)(this)).addPhoneNtp(inValue);
            return retVal.addPhoneNtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addPhoneNtpResponse> AxlNetClient.AXLPort24.addPhoneNtpAsync(AxlNetClient.addPhoneNtpRequest request)
        {
            return base.Channel.addPhoneNtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addPhoneNtpResponse> addPhoneNtpAsync(AxlNetClient.AddPhoneNtpReq addPhoneNtp)
        {
            AxlNetClient.addPhoneNtpRequest inValue = new AxlNetClient.addPhoneNtpRequest();
            inValue.addPhoneNtp = addPhoneNtp;
            return ((AxlNetClient.AXLPort24)(this)).addPhoneNtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updatePhoneNtpResponse AxlNetClient.AXLPort24.updatePhoneNtp(AxlNetClient.updatePhoneNtpRequest request)
        {
            return base.Channel.updatePhoneNtp(request);
        }

        public AxlNetClient.StandardResponse updatePhoneNtp(AxlNetClient.UpdatePhoneNtpReq updatePhoneNtp1)
        {
            AxlNetClient.updatePhoneNtpRequest inValue = new AxlNetClient.updatePhoneNtpRequest();
            inValue.updatePhoneNtp = updatePhoneNtp1;
            AxlNetClient.updatePhoneNtpResponse retVal = ((AxlNetClient.AXLPort24)(this)).updatePhoneNtp(inValue);
            return retVal.updatePhoneNtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updatePhoneNtpResponse> AxlNetClient.AXLPort24.updatePhoneNtpAsync(AxlNetClient.updatePhoneNtpRequest request)
        {
            return base.Channel.updatePhoneNtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updatePhoneNtpResponse> updatePhoneNtpAsync(AxlNetClient.UpdatePhoneNtpReq updatePhoneNtp)
        {
            AxlNetClient.updatePhoneNtpRequest inValue = new AxlNetClient.updatePhoneNtpRequest();
            inValue.updatePhoneNtp = updatePhoneNtp;
            return ((AxlNetClient.AXLPort24)(this)).updatePhoneNtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getPhoneNtpResponse AxlNetClient.AXLPort24.getPhoneNtp(AxlNetClient.getPhoneNtpRequest request)
        {
            return base.Channel.getPhoneNtp(request);
        }

        public AxlNetClient.GetPhoneNtpRes getPhoneNtp(AxlNetClient.GetPhoneNtpReq getPhoneNtp1)
        {
            AxlNetClient.getPhoneNtpRequest inValue = new AxlNetClient.getPhoneNtpRequest();
            inValue.getPhoneNtp = getPhoneNtp1;
            AxlNetClient.getPhoneNtpResponse retVal = ((AxlNetClient.AXLPort24)(this)).getPhoneNtp(inValue);
            return retVal.getPhoneNtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getPhoneNtpResponse> AxlNetClient.AXLPort24.getPhoneNtpAsync(AxlNetClient.getPhoneNtpRequest request)
        {
            return base.Channel.getPhoneNtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getPhoneNtpResponse> getPhoneNtpAsync(AxlNetClient.GetPhoneNtpReq getPhoneNtp)
        {
            AxlNetClient.getPhoneNtpRequest inValue = new AxlNetClient.getPhoneNtpRequest();
            inValue.getPhoneNtp = getPhoneNtp;
            return ((AxlNetClient.AXLPort24)(this)).getPhoneNtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removePhoneNtpResponse AxlNetClient.AXLPort24.removePhoneNtp(AxlNetClient.removePhoneNtpRequest request)
        {
            return base.Channel.removePhoneNtp(request);
        }

        public AxlNetClient.StandardResponse removePhoneNtp(AxlNetClient.RemovePhoneNtpReq removePhoneNtp1)
        {
            AxlNetClient.removePhoneNtpRequest inValue = new AxlNetClient.removePhoneNtpRequest();
            inValue.removePhoneNtp = removePhoneNtp1;
            AxlNetClient.removePhoneNtpResponse retVal = ((AxlNetClient.AXLPort24)(this)).removePhoneNtp(inValue);
            return retVal.removePhoneNtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removePhoneNtpResponse> AxlNetClient.AXLPort24.removePhoneNtpAsync(AxlNetClient.removePhoneNtpRequest request)
        {
            return base.Channel.removePhoneNtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removePhoneNtpResponse> removePhoneNtpAsync(AxlNetClient.RemovePhoneNtpReq removePhoneNtp)
        {
            AxlNetClient.removePhoneNtpRequest inValue = new AxlNetClient.removePhoneNtpRequest();
            inValue.removePhoneNtp = removePhoneNtp;
            return ((AxlNetClient.AXLPort24)(this)).removePhoneNtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listPhoneNtpResponse AxlNetClient.AXLPort24.listPhoneNtp(AxlNetClient.listPhoneNtpRequest request)
        {
            return base.Channel.listPhoneNtp(request);
        }

        public AxlNetClient.ListPhoneNtpRes listPhoneNtp(AxlNetClient.ListPhoneNtpReq listPhoneNtp1)
        {
            AxlNetClient.listPhoneNtpRequest inValue = new AxlNetClient.listPhoneNtpRequest();
            inValue.listPhoneNtp = listPhoneNtp1;
            AxlNetClient.listPhoneNtpResponse retVal = ((AxlNetClient.AXLPort24)(this)).listPhoneNtp(inValue);
            return retVal.listPhoneNtpResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listPhoneNtpResponse> AxlNetClient.AXLPort24.listPhoneNtpAsync(AxlNetClient.listPhoneNtpRequest request)
        {
            return base.Channel.listPhoneNtpAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listPhoneNtpResponse> listPhoneNtpAsync(AxlNetClient.ListPhoneNtpReq listPhoneNtp)
        {
            AxlNetClient.listPhoneNtpRequest inValue = new AxlNetClient.listPhoneNtpRequest();
            inValue.listPhoneNtp = listPhoneNtp;
            return ((AxlNetClient.AXLPort24)(this)).listPhoneNtpAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addDateTimeGroupResponse AxlNetClient.AXLPort24.addDateTimeGroup(AxlNetClient.addDateTimeGroupRequest request)
        {
            return base.Channel.addDateTimeGroup(request);
        }

        public AxlNetClient.StandardResponse addDateTimeGroup(AxlNetClient.AddDateTimeGroupReq addDateTimeGroup1)
        {
            AxlNetClient.addDateTimeGroupRequest inValue = new AxlNetClient.addDateTimeGroupRequest();
            inValue.addDateTimeGroup = addDateTimeGroup1;
            AxlNetClient.addDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).addDateTimeGroup(inValue);
            return retVal.addDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addDateTimeGroupResponse> AxlNetClient.AXLPort24.addDateTimeGroupAsync(AxlNetClient.addDateTimeGroupRequest request)
        {
            return base.Channel.addDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addDateTimeGroupResponse> addDateTimeGroupAsync(AxlNetClient.AddDateTimeGroupReq addDateTimeGroup)
        {
            AxlNetClient.addDateTimeGroupRequest inValue = new AxlNetClient.addDateTimeGroupRequest();
            inValue.addDateTimeGroup = addDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).addDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateDateTimeGroupResponse AxlNetClient.AXLPort24.updateDateTimeGroup(AxlNetClient.updateDateTimeGroupRequest request)
        {
            return base.Channel.updateDateTimeGroup(request);
        }

        public AxlNetClient.StandardResponse updateDateTimeGroup(AxlNetClient.UpdateDateTimeGroupReq updateDateTimeGroup1)
        {
            AxlNetClient.updateDateTimeGroupRequest inValue = new AxlNetClient.updateDateTimeGroupRequest();
            inValue.updateDateTimeGroup = updateDateTimeGroup1;
            AxlNetClient.updateDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).updateDateTimeGroup(inValue);
            return retVal.updateDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateDateTimeGroupResponse> AxlNetClient.AXLPort24.updateDateTimeGroupAsync(AxlNetClient.updateDateTimeGroupRequest request)
        {
            return base.Channel.updateDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateDateTimeGroupResponse> updateDateTimeGroupAsync(AxlNetClient.UpdateDateTimeGroupReq updateDateTimeGroup)
        {
            AxlNetClient.updateDateTimeGroupRequest inValue = new AxlNetClient.updateDateTimeGroupRequest();
            inValue.updateDateTimeGroup = updateDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).updateDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getDateTimeGroupResponse AxlNetClient.AXLPort24.getDateTimeGroup(AxlNetClient.getDateTimeGroupRequest request)
        {
            return base.Channel.getDateTimeGroup(request);
        }

        public AxlNetClient.GetDateTimeGroupRes getDateTimeGroup(AxlNetClient.GetDateTimeGroupReq getDateTimeGroup1)
        {
            AxlNetClient.getDateTimeGroupRequest inValue = new AxlNetClient.getDateTimeGroupRequest();
            inValue.getDateTimeGroup = getDateTimeGroup1;
            AxlNetClient.getDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).getDateTimeGroup(inValue);
            return retVal.getDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getDateTimeGroupResponse> AxlNetClient.AXLPort24.getDateTimeGroupAsync(AxlNetClient.getDateTimeGroupRequest request)
        {
            return base.Channel.getDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getDateTimeGroupResponse> getDateTimeGroupAsync(AxlNetClient.GetDateTimeGroupReq getDateTimeGroup)
        {
            AxlNetClient.getDateTimeGroupRequest inValue = new AxlNetClient.getDateTimeGroupRequest();
            inValue.getDateTimeGroup = getDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).getDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeDateTimeGroupResponse AxlNetClient.AXLPort24.removeDateTimeGroup(AxlNetClient.removeDateTimeGroupRequest request)
        {
            return base.Channel.removeDateTimeGroup(request);
        }

        public AxlNetClient.StandardResponse removeDateTimeGroup(AxlNetClient.NameAndGUIDRequest removeDateTimeGroup1)
        {
            AxlNetClient.removeDateTimeGroupRequest inValue = new AxlNetClient.removeDateTimeGroupRequest();
            inValue.removeDateTimeGroup = removeDateTimeGroup1;
            AxlNetClient.removeDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).removeDateTimeGroup(inValue);
            return retVal.removeDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeDateTimeGroupResponse> AxlNetClient.AXLPort24.removeDateTimeGroupAsync(AxlNetClient.removeDateTimeGroupRequest request)
        {
            return base.Channel.removeDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeDateTimeGroupResponse> removeDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest removeDateTimeGroup)
        {
            AxlNetClient.removeDateTimeGroupRequest inValue = new AxlNetClient.removeDateTimeGroupRequest();
            inValue.removeDateTimeGroup = removeDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).removeDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listDateTimeGroupResponse AxlNetClient.AXLPort24.listDateTimeGroup(AxlNetClient.listDateTimeGroupRequest request)
        {
            return base.Channel.listDateTimeGroup(request);
        }

        public AxlNetClient.ListDateTimeGroupRes listDateTimeGroup(AxlNetClient.ListDateTimeGroupReq listDateTimeGroup1)
        {
            AxlNetClient.listDateTimeGroupRequest inValue = new AxlNetClient.listDateTimeGroupRequest();
            inValue.listDateTimeGroup = listDateTimeGroup1;
            AxlNetClient.listDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).listDateTimeGroup(inValue);
            return retVal.listDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listDateTimeGroupResponse> AxlNetClient.AXLPort24.listDateTimeGroupAsync(AxlNetClient.listDateTimeGroupRequest request)
        {
            return base.Channel.listDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listDateTimeGroupResponse> listDateTimeGroupAsync(AxlNetClient.ListDateTimeGroupReq listDateTimeGroup)
        {
            AxlNetClient.listDateTimeGroupRequest inValue = new AxlNetClient.listDateTimeGroupRequest();
            inValue.listDateTimeGroup = listDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).listDateTimeGroupAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.resetDateTimeGroupResponse AxlNetClient.AXLPort24.resetDateTimeGroup(AxlNetClient.resetDateTimeGroupRequest request)
        {
            return base.Channel.resetDateTimeGroup(request);
        }

        public AxlNetClient.StandardResponse resetDateTimeGroup(AxlNetClient.NameAndGUIDRequest resetDateTimeGroup1)
        {
            AxlNetClient.resetDateTimeGroupRequest inValue = new AxlNetClient.resetDateTimeGroupRequest();
            inValue.resetDateTimeGroup = resetDateTimeGroup1;
            AxlNetClient.resetDateTimeGroupResponse retVal = ((AxlNetClient.AXLPort24)(this)).resetDateTimeGroup(inValue);
            return retVal.resetDateTimeGroupResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.resetDateTimeGroupResponse> AxlNetClient.AXLPort24.resetDateTimeGroupAsync(AxlNetClient.resetDateTimeGroupRequest request)
        {
            return base.Channel.resetDateTimeGroupAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.resetDateTimeGroupResponse> resetDateTimeGroupAsync(AxlNetClient.NameAndGUIDRequest resetDateTimeGroup)
        {
            AxlNetClient.resetDateTimeGroupRequest inValue = new AxlNetClient.resetDateTimeGroupRequest();
            inValue.resetDateTimeGroup = resetDateTimeGroup;
            return ((AxlNetClient.AXLPort24)(this)).resetDateTimeGroupAsync(inValue);
        }
    }
}