namespace AxlNetClient
{
    public partial class AXLPortClient
    {
        private static AXLPortClient34 _axlPortClient34;

        private static AXLPortClient34 axlPortClient34 => _axlPortClient34 == null ||
            _axlPortClient34.State != System.ServiceModel.CommunicationState.Opened ? (_axlPortClient34 = LoadClient34()) : _axlPortClient34;

        private static AXLPortClient34 LoadClient34()
        {
            var client = new AXLPortClient34(EndpointConfiguration, EndpointAddress);
            client.Endpoint.EndpointBehaviors.Add(new AxlNetClient.AuthenticationBehavior(User, Password));
            OnClose += Close34;
            OnAbort += Abort34;
            return client;
        }

        private static void Close34(object sender, System.EventArgs e)
        {
            _axlPortClient34.Close();
        }

        private static void Abort34(object sender, System.EventArgs e)
        {
            _axlPortClient34.Abort();
        }

        public AxlNetClient.StandardResponse applyCtiRoutePoint(AxlNetClient.NameAndGUIDRequest applyCtiRoutePoint1)
        {
            return axlPortClient34.applyCtiRoutePoint(applyCtiRoutePoint1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCtiRoutePointResponse> applyCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest applyCtiRoutePoint)
        {
            return axlPortClient34.applyCtiRoutePointAsync(applyCtiRoutePoint);
        }

        public AxlNetClient.StandardResponse addTransPattern(AxlNetClient.AddTransPatternReq addTransPattern1)
        {
            return axlPortClient34.addTransPattern(addTransPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTransPatternResponse> addTransPatternAsync(AxlNetClient.AddTransPatternReq addTransPattern)
        {
            return axlPortClient34.addTransPatternAsync(addTransPattern);
        }

        public AxlNetClient.StandardResponse updateTransPattern(AxlNetClient.UpdateTransPatternReq updateTransPattern1)
        {
            return axlPortClient34.updateTransPattern(updateTransPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTransPatternResponse> updateTransPatternAsync(AxlNetClient.UpdateTransPatternReq updateTransPattern)
        {
            return axlPortClient34.updateTransPatternAsync(updateTransPattern);
        }

        public AxlNetClient.GetTransPatternRes getTransPattern(AxlNetClient.GetTransPatternReq getTransPattern1)
        {
            return axlPortClient34.getTransPattern(getTransPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransPatternResponse> getTransPatternAsync(AxlNetClient.GetTransPatternReq getTransPattern)
        {
            return axlPortClient34.getTransPatternAsync(getTransPattern);
        }

        public AxlNetClient.StandardResponse removeTransPattern(AxlNetClient.RemoveTransPatternReq removeTransPattern1)
        {
            return axlPortClient34.removeTransPattern(removeTransPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTransPatternResponse> removeTransPatternAsync(AxlNetClient.RemoveTransPatternReq removeTransPattern)
        {
            return axlPortClient34.removeTransPatternAsync(removeTransPattern);
        }

        public AxlNetClient.ListTransPatternRes listTransPattern(AxlNetClient.ListTransPatternReq listTransPattern1)
        {
            return axlPortClient34.listTransPattern(listTransPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTransPatternResponse> listTransPatternAsync(AxlNetClient.ListTransPatternReq listTransPattern)
        {
            return axlPortClient34.listTransPatternAsync(listTransPattern);
        }

        public AxlNetClient.GetTransPatternOptionsRes getTransPatternOptions(AxlNetClient.GetTransPatternOptionsReq getTransPatternOptions1)
        {
            return axlPortClient34.getTransPatternOptions(getTransPatternOptions1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransPatternOptionsResponse> getTransPatternOptionsAsync(AxlNetClient.GetTransPatternOptionsReq getTransPatternOptions)
        {
            return axlPortClient34.getTransPatternOptionsAsync(getTransPatternOptions);
        }

        public AxlNetClient.StandardResponse addCallingPartyTransformationPattern(AxlNetClient.AddCallingPartyTransformationPatternReq addCallingPartyTransformationPattern1)
        {
            return axlPortClient34.addCallingPartyTransformationPattern(addCallingPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallingPartyTransformationPatternResponse> addCallingPartyTransformationPatternAsync(AxlNetClient.AddCallingPartyTransformationPatternReq addCallingPartyTransformationPattern)
        {
            return axlPortClient34.addCallingPartyTransformationPatternAsync(addCallingPartyTransformationPattern);
        }

        public AxlNetClient.StandardResponse updateCallingPartyTransformationPattern(AxlNetClient.UpdateCallingPartyTransformationPatternReq updateCallingPartyTransformationPattern1)
        {
            return axlPortClient34.updateCallingPartyTransformationPattern(updateCallingPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallingPartyTransformationPatternResponse> updateCallingPartyTransformationPatternAsync(AxlNetClient.UpdateCallingPartyTransformationPatternReq updateCallingPartyTransformationPattern)
        {
            return axlPortClient34.updateCallingPartyTransformationPatternAsync(updateCallingPartyTransformationPattern);
        }

        public AxlNetClient.GetCallingPartyTransformationPatternRes getCallingPartyTransformationPattern(AxlNetClient.GetCallingPartyTransformationPatternReq getCallingPartyTransformationPattern1)
        {
            return axlPortClient34.getCallingPartyTransformationPattern(getCallingPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallingPartyTransformationPatternResponse> getCallingPartyTransformationPatternAsync(AxlNetClient.GetCallingPartyTransformationPatternReq getCallingPartyTransformationPattern)
        {
            return axlPortClient34.getCallingPartyTransformationPatternAsync(getCallingPartyTransformationPattern);
        }

        public AxlNetClient.StandardResponse removeCallingPartyTransformationPattern(AxlNetClient.RemoveCallingPartyTransformationPatternReq removeCallingPartyTransformationPattern1)
        {
            return axlPortClient34.removeCallingPartyTransformationPattern(removeCallingPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallingPartyTransformationPatternResponse> removeCallingPartyTransformationPatternAsync(AxlNetClient.RemoveCallingPartyTransformationPatternReq removeCallingPartyTransformationPattern)
        {
            return axlPortClient34.removeCallingPartyTransformationPatternAsync(removeCallingPartyTransformationPattern);
        }

        public AxlNetClient.ListCallingPartyTransformationPatternRes listCallingPartyTransformationPattern(AxlNetClient.ListCallingPartyTransformationPatternReq listCallingPartyTransformationPattern1)
        {
            return axlPortClient34.listCallingPartyTransformationPattern(listCallingPartyTransformationPattern1);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallingPartyTransformationPatternResponse> listCallingPartyTransformationPatternAsync(AxlNetClient.ListCallingPartyTransformationPatternReq listCallingPartyTransformationPattern)
        {
            return axlPortClient34.listCallingPartyTransformationPatternAsync(listCallingPartyTransformationPattern);
        }
    }

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.cisco.com/AXLAPIService/", ConfigurationName = "AxlNetClient.AXLPort")]
    public interface AXLPort34
    {
        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCtiRoutePoint", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.applyCtiRoutePointResponse applyCtiRoutePoint(AxlNetClient.applyCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 applyCtiRoutePoint", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.applyCtiRoutePointResponse> applyCtiRoutePointAsync(AxlNetClient.applyCtiRoutePointRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTransPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addTransPatternResponse addTransPattern(AxlNetClient.addTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addTransPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addTransPatternResponse> addTransPatternAsync(AxlNetClient.addTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTransPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateTransPatternResponse updateTransPattern(AxlNetClient.updateTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateTransPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateTransPatternResponse> updateTransPatternAsync(AxlNetClient.updateTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTransPatternResponse getTransPattern(AxlNetClient.getTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTransPatternResponse> getTransPatternAsync(AxlNetClient.getTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTransPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeTransPatternResponse removeTransPattern(AxlNetClient.removeTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeTransPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeTransPatternResponse> removeTransPatternAsync(AxlNetClient.removeTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTransPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listTransPatternResponse listTransPattern(AxlNetClient.listTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listTransPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listTransPatternResponse> listTransPatternAsync(AxlNetClient.listTransPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransPatternOptions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getTransPatternOptionsResponse getTransPatternOptions(AxlNetClient.getTransPatternOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getTransPatternOptions", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getTransPatternOptionsResponse> getTransPatternOptionsAsync(AxlNetClient.getTransPatternOptionsRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallingPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.addCallingPartyTransformationPatternResponse addCallingPartyTransformationPattern(AxlNetClient.addCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 addCallingPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.addCallingPartyTransformationPatternResponse> addCallingPartyTransformationPatternAsync(AxlNetClient.addCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallingPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.updateCallingPartyTransformationPatternResponse updateCallingPartyTransformationPattern(AxlNetClient.updateCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 updateCallingPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.updateCallingPartyTransformationPatternResponse> updateCallingPartyTransformationPatternAsync(AxlNetClient.updateCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallingPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.getCallingPartyTransformationPatternResponse getCallingPartyTransformationPattern(AxlNetClient.getCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 getCallingPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.getCallingPartyTransformationPatternResponse> getCallingPartyTransformationPatternAsync(AxlNetClient.getCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallingPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.removeCallingPartyTransformationPatternResponse removeCallingPartyTransformationPattern(AxlNetClient.removeCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 removeCallingPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.removeCallingPartyTransformationPatternResponse> removeCallingPartyTransformationPatternAsync(AxlNetClient.removeCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallingPartyTransformationPattern", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AxlNetClient.listCallingPartyTransformationPatternResponse listCallingPartyTransformationPattern(AxlNetClient.listCallingPartyTransformationPatternRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "CUCM:DB ver=10.5 listCallingPartyTransformationPattern", ReplyAction = "*")]
        System.Threading.Tasks.Task<AxlNetClient.listCallingPartyTransformationPatternResponse> listCallingPartyTransformationPatternAsync(AxlNetClient.listCallingPartyTransformationPatternRequest request);
    }

    public class AXLPortClient34 : System.ServiceModel.ClientBase<AxlNetClient.AXLPort34>, AxlNetClient.AXLPort34
    {
        public AXLPortClient34(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.applyCtiRoutePointResponse AxlNetClient.AXLPort34.applyCtiRoutePoint(AxlNetClient.applyCtiRoutePointRequest request)
        {
            return base.Channel.applyCtiRoutePoint(request);
        }

        public AxlNetClient.StandardResponse applyCtiRoutePoint(AxlNetClient.NameAndGUIDRequest applyCtiRoutePoint1)
        {
            AxlNetClient.applyCtiRoutePointRequest inValue = new AxlNetClient.applyCtiRoutePointRequest();
            inValue.applyCtiRoutePoint = applyCtiRoutePoint1;
            AxlNetClient.applyCtiRoutePointResponse retVal = ((AxlNetClient.AXLPort34)(this)).applyCtiRoutePoint(inValue);
            return retVal.applyCtiRoutePointResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.applyCtiRoutePointResponse> AxlNetClient.AXLPort34.applyCtiRoutePointAsync(AxlNetClient.applyCtiRoutePointRequest request)
        {
            return base.Channel.applyCtiRoutePointAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.applyCtiRoutePointResponse> applyCtiRoutePointAsync(AxlNetClient.NameAndGUIDRequest applyCtiRoutePoint)
        {
            AxlNetClient.applyCtiRoutePointRequest inValue = new AxlNetClient.applyCtiRoutePointRequest();
            inValue.applyCtiRoutePoint = applyCtiRoutePoint;
            return ((AxlNetClient.AXLPort34)(this)).applyCtiRoutePointAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addTransPatternResponse AxlNetClient.AXLPort34.addTransPattern(AxlNetClient.addTransPatternRequest request)
        {
            return base.Channel.addTransPattern(request);
        }

        public AxlNetClient.StandardResponse addTransPattern(AxlNetClient.AddTransPatternReq addTransPattern1)
        {
            AxlNetClient.addTransPatternRequest inValue = new AxlNetClient.addTransPatternRequest();
            inValue.addTransPattern = addTransPattern1;
            AxlNetClient.addTransPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).addTransPattern(inValue);
            return retVal.addTransPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addTransPatternResponse> AxlNetClient.AXLPort34.addTransPatternAsync(AxlNetClient.addTransPatternRequest request)
        {
            return base.Channel.addTransPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addTransPatternResponse> addTransPatternAsync(AxlNetClient.AddTransPatternReq addTransPattern)
        {
            AxlNetClient.addTransPatternRequest inValue = new AxlNetClient.addTransPatternRequest();
            inValue.addTransPattern = addTransPattern;
            return ((AxlNetClient.AXLPort34)(this)).addTransPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateTransPatternResponse AxlNetClient.AXLPort34.updateTransPattern(AxlNetClient.updateTransPatternRequest request)
        {
            return base.Channel.updateTransPattern(request);
        }

        public AxlNetClient.StandardResponse updateTransPattern(AxlNetClient.UpdateTransPatternReq updateTransPattern1)
        {
            AxlNetClient.updateTransPatternRequest inValue = new AxlNetClient.updateTransPatternRequest();
            inValue.updateTransPattern = updateTransPattern1;
            AxlNetClient.updateTransPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).updateTransPattern(inValue);
            return retVal.updateTransPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateTransPatternResponse> AxlNetClient.AXLPort34.updateTransPatternAsync(AxlNetClient.updateTransPatternRequest request)
        {
            return base.Channel.updateTransPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateTransPatternResponse> updateTransPatternAsync(AxlNetClient.UpdateTransPatternReq updateTransPattern)
        {
            AxlNetClient.updateTransPatternRequest inValue = new AxlNetClient.updateTransPatternRequest();
            inValue.updateTransPattern = updateTransPattern;
            return ((AxlNetClient.AXLPort34)(this)).updateTransPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTransPatternResponse AxlNetClient.AXLPort34.getTransPattern(AxlNetClient.getTransPatternRequest request)
        {
            return base.Channel.getTransPattern(request);
        }

        public AxlNetClient.GetTransPatternRes getTransPattern(AxlNetClient.GetTransPatternReq getTransPattern1)
        {
            AxlNetClient.getTransPatternRequest inValue = new AxlNetClient.getTransPatternRequest();
            inValue.getTransPattern = getTransPattern1;
            AxlNetClient.getTransPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).getTransPattern(inValue);
            return retVal.getTransPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTransPatternResponse> AxlNetClient.AXLPort34.getTransPatternAsync(AxlNetClient.getTransPatternRequest request)
        {
            return base.Channel.getTransPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransPatternResponse> getTransPatternAsync(AxlNetClient.GetTransPatternReq getTransPattern)
        {
            AxlNetClient.getTransPatternRequest inValue = new AxlNetClient.getTransPatternRequest();
            inValue.getTransPattern = getTransPattern;
            return ((AxlNetClient.AXLPort34)(this)).getTransPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeTransPatternResponse AxlNetClient.AXLPort34.removeTransPattern(AxlNetClient.removeTransPatternRequest request)
        {
            return base.Channel.removeTransPattern(request);
        }

        public AxlNetClient.StandardResponse removeTransPattern(AxlNetClient.RemoveTransPatternReq removeTransPattern1)
        {
            AxlNetClient.removeTransPatternRequest inValue = new AxlNetClient.removeTransPatternRequest();
            inValue.removeTransPattern = removeTransPattern1;
            AxlNetClient.removeTransPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).removeTransPattern(inValue);
            return retVal.removeTransPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeTransPatternResponse> AxlNetClient.AXLPort34.removeTransPatternAsync(AxlNetClient.removeTransPatternRequest request)
        {
            return base.Channel.removeTransPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeTransPatternResponse> removeTransPatternAsync(AxlNetClient.RemoveTransPatternReq removeTransPattern)
        {
            AxlNetClient.removeTransPatternRequest inValue = new AxlNetClient.removeTransPatternRequest();
            inValue.removeTransPattern = removeTransPattern;
            return ((AxlNetClient.AXLPort34)(this)).removeTransPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listTransPatternResponse AxlNetClient.AXLPort34.listTransPattern(AxlNetClient.listTransPatternRequest request)
        {
            return base.Channel.listTransPattern(request);
        }

        public AxlNetClient.ListTransPatternRes listTransPattern(AxlNetClient.ListTransPatternReq listTransPattern1)
        {
            AxlNetClient.listTransPatternRequest inValue = new AxlNetClient.listTransPatternRequest();
            inValue.listTransPattern = listTransPattern1;
            AxlNetClient.listTransPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).listTransPattern(inValue);
            return retVal.listTransPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listTransPatternResponse> AxlNetClient.AXLPort34.listTransPatternAsync(AxlNetClient.listTransPatternRequest request)
        {
            return base.Channel.listTransPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listTransPatternResponse> listTransPatternAsync(AxlNetClient.ListTransPatternReq listTransPattern)
        {
            AxlNetClient.listTransPatternRequest inValue = new AxlNetClient.listTransPatternRequest();
            inValue.listTransPattern = listTransPattern;
            return ((AxlNetClient.AXLPort34)(this)).listTransPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getTransPatternOptionsResponse AxlNetClient.AXLPort34.getTransPatternOptions(AxlNetClient.getTransPatternOptionsRequest request)
        {
            return base.Channel.getTransPatternOptions(request);
        }

        public AxlNetClient.GetTransPatternOptionsRes getTransPatternOptions(AxlNetClient.GetTransPatternOptionsReq getTransPatternOptions1)
        {
            AxlNetClient.getTransPatternOptionsRequest inValue = new AxlNetClient.getTransPatternOptionsRequest();
            inValue.getTransPatternOptions = getTransPatternOptions1;
            AxlNetClient.getTransPatternOptionsResponse retVal = ((AxlNetClient.AXLPort34)(this)).getTransPatternOptions(inValue);
            return retVal.getTransPatternOptionsResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getTransPatternOptionsResponse> AxlNetClient.AXLPort34.getTransPatternOptionsAsync(AxlNetClient.getTransPatternOptionsRequest request)
        {
            return base.Channel.getTransPatternOptionsAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getTransPatternOptionsResponse> getTransPatternOptionsAsync(AxlNetClient.GetTransPatternOptionsReq getTransPatternOptions)
        {
            AxlNetClient.getTransPatternOptionsRequest inValue = new AxlNetClient.getTransPatternOptionsRequest();
            inValue.getTransPatternOptions = getTransPatternOptions;
            return ((AxlNetClient.AXLPort34)(this)).getTransPatternOptionsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.addCallingPartyTransformationPatternResponse AxlNetClient.AXLPort34.addCallingPartyTransformationPattern(AxlNetClient.addCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.addCallingPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse addCallingPartyTransformationPattern(AxlNetClient.AddCallingPartyTransformationPatternReq addCallingPartyTransformationPattern1)
        {
            AxlNetClient.addCallingPartyTransformationPatternRequest inValue = new AxlNetClient.addCallingPartyTransformationPatternRequest();
            inValue.addCallingPartyTransformationPattern = addCallingPartyTransformationPattern1;
            AxlNetClient.addCallingPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).addCallingPartyTransformationPattern(inValue);
            return retVal.addCallingPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.addCallingPartyTransformationPatternResponse> AxlNetClient.AXLPort34.addCallingPartyTransformationPatternAsync(AxlNetClient.addCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.addCallingPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.addCallingPartyTransformationPatternResponse> addCallingPartyTransformationPatternAsync(AxlNetClient.AddCallingPartyTransformationPatternReq addCallingPartyTransformationPattern)
        {
            AxlNetClient.addCallingPartyTransformationPatternRequest inValue = new AxlNetClient.addCallingPartyTransformationPatternRequest();
            inValue.addCallingPartyTransformationPattern = addCallingPartyTransformationPattern;
            return ((AxlNetClient.AXLPort34)(this)).addCallingPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.updateCallingPartyTransformationPatternResponse AxlNetClient.AXLPort34.updateCallingPartyTransformationPattern(AxlNetClient.updateCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.updateCallingPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse updateCallingPartyTransformationPattern(AxlNetClient.UpdateCallingPartyTransformationPatternReq updateCallingPartyTransformationPattern1)
        {
            AxlNetClient.updateCallingPartyTransformationPatternRequest inValue = new AxlNetClient.updateCallingPartyTransformationPatternRequest();
            inValue.updateCallingPartyTransformationPattern = updateCallingPartyTransformationPattern1;
            AxlNetClient.updateCallingPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).updateCallingPartyTransformationPattern(inValue);
            return retVal.updateCallingPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.updateCallingPartyTransformationPatternResponse> AxlNetClient.AXLPort34.updateCallingPartyTransformationPatternAsync(AxlNetClient.updateCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.updateCallingPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.updateCallingPartyTransformationPatternResponse> updateCallingPartyTransformationPatternAsync(AxlNetClient.UpdateCallingPartyTransformationPatternReq updateCallingPartyTransformationPattern)
        {
            AxlNetClient.updateCallingPartyTransformationPatternRequest inValue = new AxlNetClient.updateCallingPartyTransformationPatternRequest();
            inValue.updateCallingPartyTransformationPattern = updateCallingPartyTransformationPattern;
            return ((AxlNetClient.AXLPort34)(this)).updateCallingPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.getCallingPartyTransformationPatternResponse AxlNetClient.AXLPort34.getCallingPartyTransformationPattern(AxlNetClient.getCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.getCallingPartyTransformationPattern(request);
        }

        public AxlNetClient.GetCallingPartyTransformationPatternRes getCallingPartyTransformationPattern(AxlNetClient.GetCallingPartyTransformationPatternReq getCallingPartyTransformationPattern1)
        {
            AxlNetClient.getCallingPartyTransformationPatternRequest inValue = new AxlNetClient.getCallingPartyTransformationPatternRequest();
            inValue.getCallingPartyTransformationPattern = getCallingPartyTransformationPattern1;
            AxlNetClient.getCallingPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).getCallingPartyTransformationPattern(inValue);
            return retVal.getCallingPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.getCallingPartyTransformationPatternResponse> AxlNetClient.AXLPort34.getCallingPartyTransformationPatternAsync(AxlNetClient.getCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.getCallingPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.getCallingPartyTransformationPatternResponse> getCallingPartyTransformationPatternAsync(AxlNetClient.GetCallingPartyTransformationPatternReq getCallingPartyTransformationPattern)
        {
            AxlNetClient.getCallingPartyTransformationPatternRequest inValue = new AxlNetClient.getCallingPartyTransformationPatternRequest();
            inValue.getCallingPartyTransformationPattern = getCallingPartyTransformationPattern;
            return ((AxlNetClient.AXLPort34)(this)).getCallingPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.removeCallingPartyTransformationPatternResponse AxlNetClient.AXLPort34.removeCallingPartyTransformationPattern(AxlNetClient.removeCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.removeCallingPartyTransformationPattern(request);
        }

        public AxlNetClient.StandardResponse removeCallingPartyTransformationPattern(AxlNetClient.RemoveCallingPartyTransformationPatternReq removeCallingPartyTransformationPattern1)
        {
            AxlNetClient.removeCallingPartyTransformationPatternRequest inValue = new AxlNetClient.removeCallingPartyTransformationPatternRequest();
            inValue.removeCallingPartyTransformationPattern = removeCallingPartyTransformationPattern1;
            AxlNetClient.removeCallingPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).removeCallingPartyTransformationPattern(inValue);
            return retVal.removeCallingPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.removeCallingPartyTransformationPatternResponse> AxlNetClient.AXLPort34.removeCallingPartyTransformationPatternAsync(AxlNetClient.removeCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.removeCallingPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.removeCallingPartyTransformationPatternResponse> removeCallingPartyTransformationPatternAsync(AxlNetClient.RemoveCallingPartyTransformationPatternReq removeCallingPartyTransformationPattern)
        {
            AxlNetClient.removeCallingPartyTransformationPatternRequest inValue = new AxlNetClient.removeCallingPartyTransformationPatternRequest();
            inValue.removeCallingPartyTransformationPattern = removeCallingPartyTransformationPattern;
            return ((AxlNetClient.AXLPort34)(this)).removeCallingPartyTransformationPatternAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxlNetClient.listCallingPartyTransformationPatternResponse AxlNetClient.AXLPort34.listCallingPartyTransformationPattern(AxlNetClient.listCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.listCallingPartyTransformationPattern(request);
        }

        public AxlNetClient.ListCallingPartyTransformationPatternRes listCallingPartyTransformationPattern(AxlNetClient.ListCallingPartyTransformationPatternReq listCallingPartyTransformationPattern1)
        {
            AxlNetClient.listCallingPartyTransformationPatternRequest inValue = new AxlNetClient.listCallingPartyTransformationPatternRequest();
            inValue.listCallingPartyTransformationPattern = listCallingPartyTransformationPattern1;
            AxlNetClient.listCallingPartyTransformationPatternResponse retVal = ((AxlNetClient.AXLPort34)(this)).listCallingPartyTransformationPattern(inValue);
            return retVal.listCallingPartyTransformationPatternResponse1;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxlNetClient.listCallingPartyTransformationPatternResponse> AxlNetClient.AXLPort34.listCallingPartyTransformationPatternAsync(AxlNetClient.listCallingPartyTransformationPatternRequest request)
        {
            return base.Channel.listCallingPartyTransformationPatternAsync(request);
        }

        public System.Threading.Tasks.Task<AxlNetClient.listCallingPartyTransformationPatternResponse> listCallingPartyTransformationPatternAsync(AxlNetClient.ListCallingPartyTransformationPatternReq listCallingPartyTransformationPattern)
        {
            AxlNetClient.listCallingPartyTransformationPatternRequest inValue = new AxlNetClient.listCallingPartyTransformationPatternRequest();
            inValue.listCallingPartyTransformationPattern = listCallingPartyTransformationPattern;
            return ((AxlNetClient.AXLPort34)(this)).listCallingPartyTransformationPatternAsync(inValue);
        }
    }
}