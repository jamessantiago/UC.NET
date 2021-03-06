namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient83 _axlPortClient83;

        private static AXLPortClient83 axlPortClient83 => _axlPortClient83 == null ||
            _axlPortClient83.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient83 = LoadClient83()) : _axlPortClient83;

        private static AXLPortClient83 LoadClient83()
        {
            var client = new AXLPortClient83(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close83;
            OnAbort += Abort83;
            return client;
        }

        private static void Close83(object sender, System.EventArgs e)
        {
            _axlPortClient83.Close();
        }

        private static void Abort83(object sender, System.EventArgs e)
        {
            _axlPortClient83.Abort();
        }

        public AxlNetClient.StandardResponse updateSelfProvisioning(AxlNetClient.UpdateSelfProvisioningReq updateSelfProvisioning1)
        {
            return axlPortClient83.updateSelfProvisioning(updateSelfProvisioning1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSelfProvisioningResponse> updateSelfProvisioningAsync(AxlNetClient.UpdateSelfProvisioningReq updateSelfProvisioning)
        {
            return axlPortClient83.updateSelfProvisioningAsync(updateSelfProvisioning);
        }

        public AxlNetClient.ListChangeRes listChange(AxlNetClient.ListChangeReq listChange1)
        {
            return axlPortClient83.listChange(listChange1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listChangeResponse> listChangeAsync(AxlNetClient.ListChangeReq listChange)
        {
            return axlPortClient83.listChangeAsync(listChange);
        }

        public AxlNetClient.DoChangeDNDStatusRes doChangeDNDStatus(AxlNetClient.DoChangeDNDStatusReq doChangeDNDStatus1)
        {
            return axlPortClient83.doChangeDNDStatus(doChangeDNDStatus1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doChangeDNDStatusResponse> doChangeDNDStatusAsync(AxlNetClient.DoChangeDNDStatusReq doChangeDNDStatus)
        {
            return axlPortClient83.doChangeDNDStatusAsync(doChangeDNDStatus);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort83
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSelfProvisioning", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateSelfProvisioningResponse updateSelfProvisioning(AxlNetClient.updateSelfProvisioningRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateSelfProvisioning", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateSelfProvisioningResponse> updateSelfProvisioningAsync(AxlNetClient.updateSelfProvisioningRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listChange", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listChangeResponse listChange(AxlNetClient.listChangeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listChange", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listChangeResponse> listChangeAsync(AxlNetClient.listChangeRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doChangeDNDStatus", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.doChangeDNDStatusResponse doChangeDNDStatus(AxlNetClient.doChangeDNDStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 doChangeDNDStatus", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.doChangeDNDStatusResponse> doChangeDNDStatusAsync(AxlNetClient.doChangeDNDStatusRequest request);
    }

    public class AXLPortClient83 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort83>, AxlNetClient.AXLPort83
    {
        public AXLPortClient83(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateSelfProvisioningResponse AxlNetClient.AXLPort83.updateSelfProvisioning(AxlNetClient.updateSelfProvisioningRequest request)
        {
            return base.Channel.updateSelfProvisioning(request);
        }

        public AxlNetClient.StandardResponse updateSelfProvisioning(AxlNetClient.UpdateSelfProvisioningReq updateSelfProvisioning1)
        {
            AxlNetClient.updateSelfProvisioningRequest inValue = new AxlNetClient.updateSelfProvisioningRequest();
            inValue.updateSelfProvisioning = updateSelfProvisioning1;
            AxlNetClient.updateSelfProvisioningResponse retVal = ((AxlNetClient.AXLPort83)(this)).updateSelfProvisioning(inValue);
            return retVal.updateSelfProvisioningResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateSelfProvisioningResponse> AxlNetClient.AXLPort83.updateSelfProvisioningAsync(AxlNetClient.updateSelfProvisioningRequest request)
        {
            return base.Channel.updateSelfProvisioningAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateSelfProvisioningResponse> updateSelfProvisioningAsync(AxlNetClient.UpdateSelfProvisioningReq updateSelfProvisioning)
        {
            AxlNetClient.updateSelfProvisioningRequest inValue = new AxlNetClient.updateSelfProvisioningRequest();
            inValue.updateSelfProvisioning = updateSelfProvisioning;
            return ((AxlNetClient.AXLPort83)(this)).updateSelfProvisioningAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listChangeResponse AxlNetClient.AXLPort83.listChange(AxlNetClient.listChangeRequest request)
        {
            return base.Channel.listChange(request);
        }

        public AxlNetClient.ListChangeRes listChange(AxlNetClient.ListChangeReq listChange1)
        {
            AxlNetClient.listChangeRequest inValue = new AxlNetClient.listChangeRequest();
            inValue.listChange = listChange1;
            AxlNetClient.listChangeResponse retVal = ((AxlNetClient.AXLPort83)(this)).listChange(inValue);
            return retVal.listChangeResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listChangeResponse> AxlNetClient.AXLPort83.listChangeAsync(AxlNetClient.listChangeRequest request)
        {
            return base.Channel.listChangeAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listChangeResponse> listChangeAsync(AxlNetClient.ListChangeReq listChange)
        {
            AxlNetClient.listChangeRequest inValue = new AxlNetClient.listChangeRequest();
            inValue.listChange = listChange;
            return ((AxlNetClient.AXLPort83)(this)).listChangeAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.doChangeDNDStatusResponse AxlNetClient.AXLPort83.doChangeDNDStatus(AxlNetClient.doChangeDNDStatusRequest request)
        {
            return base.Channel.doChangeDNDStatus(request);
        }

        public AxlNetClient.DoChangeDNDStatusRes doChangeDNDStatus(AxlNetClient.DoChangeDNDStatusReq doChangeDNDStatus1)
        {
            AxlNetClient.doChangeDNDStatusRequest inValue = new AxlNetClient.doChangeDNDStatusRequest();
            inValue.doChangeDNDStatus = doChangeDNDStatus1;
            AxlNetClient.doChangeDNDStatusResponse retVal = ((AxlNetClient.AXLPort83)(this)).doChangeDNDStatus(inValue);
            return retVal.doChangeDNDStatusResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.doChangeDNDStatusResponse> AxlNetClient.AXLPort83.doChangeDNDStatusAsync(AxlNetClient.doChangeDNDStatusRequest request)
        {
            return base.Channel.doChangeDNDStatusAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.doChangeDNDStatusResponse> doChangeDNDStatusAsync(AxlNetClient.DoChangeDNDStatusReq doChangeDNDStatus)
        {
            AxlNetClient.doChangeDNDStatusRequest inValue = new AxlNetClient.doChangeDNDStatusRequest();
            inValue.doChangeDNDStatus = doChangeDNDStatus;
            return ((AxlNetClient.AXLPort83)(this)).doChangeDNDStatusAsync(inValue);
        }
    }
}