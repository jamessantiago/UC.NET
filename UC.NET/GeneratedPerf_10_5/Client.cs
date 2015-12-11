//svcutil PerfmonService.xml /t:code /l:C# /o:Client.cs /n:*,PerfNetClient

namespace PerfNetClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.cisco.com/ast/soap", ConfigurationName="PerfNetClient.PerfmonPortType")]
    public interface PerfmonPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonOpenSession", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonOpenSessionReturn")]
        PerfNetClient.SessionHandleType perfmonOpenSession();
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonOpenSession", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonOpenSessionReturn")]
        System.Threading.Tasks.Task<PerfNetClient.SessionHandleType> perfmonOpenSessionAsync();
        
        // CODEGEN: Parameter 'ArrayOfCounter' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonAddCounter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        PerfNetClient.perfmonAddCounterResponse perfmonAddCounter(PerfNetClient.perfmonAddCounterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonAddCounter", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonAddCounterResponse> perfmonAddCounterAsync(PerfNetClient.perfmonAddCounterRequest request);
        
        // CODEGEN: Parameter 'ArrayOfCounter' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonRemoveCounter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        PerfNetClient.perfmonRemoveCounterResponse perfmonRemoveCounter(PerfNetClient.perfmonRemoveCounterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonRemoveCounter", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonRemoveCounterResponse> perfmonRemoveCounterAsync(PerfNetClient.perfmonRemoveCounterRequest request);
        
        // CODEGEN: Parameter 'perfmonCollectSessionDataReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCollectSessionData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonCollectSessionDataReturn")]
        PerfNetClient.perfmonCollectSessionDataResponse perfmonCollectSessionData(PerfNetClient.perfmonCollectSessionDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCollectSessionData", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonCollectSessionDataResponse> perfmonCollectSessionDataAsync(PerfNetClient.perfmonCollectSessionDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCloseSession", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void perfmonCloseSession(PerfNetClient.SessionHandleType SessionHandle);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCloseSession", ReplyAction="*")]
        System.Threading.Tasks.Task perfmonCloseSessionAsync(PerfNetClient.SessionHandleType SessionHandle);
        
        // CODEGEN: Parameter 'perfmonListInstanceReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonListInstance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonListInstanceReturn")]
        PerfNetClient.perfmonListInstanceResponse perfmonListInstance(PerfNetClient.perfmonListInstanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonListInstance", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonListInstanceResponse> perfmonListInstanceAsync(PerfNetClient.perfmonListInstanceRequest request);
        
        // CODEGEN: Parameter 'perfmonQueryCounterDescriptionReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonQueryCounterDescription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonQueryCounterDescriptionReturn")]
        PerfNetClient.perfmonQueryCounterDescriptionResponse perfmonQueryCounterDescription(PerfNetClient.perfmonQueryCounterDescriptionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonQueryCounterDescription", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonQueryCounterDescriptionResponse> perfmonQueryCounterDescriptionAsync(PerfNetClient.perfmonQueryCounterDescriptionRequest request);
        
        // CODEGEN: Parameter 'perfmonListCounterReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonListCounter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonListCounterReturn")]
        PerfNetClient.perfmonListCounterResponse perfmonListCounter(PerfNetClient.perfmonListCounterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonListCounter", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonListCounterResponse> perfmonListCounterAsync(PerfNetClient.perfmonListCounterRequest request);
        
        // CODEGEN: Parameter 'perfmonCollectCounterDataReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCollectCounterData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [return: System.ServiceModel.MessageParameterAttribute(Name="perfmonCollectCounterDataReturn")]
        PerfNetClient.perfmonCollectCounterDataResponse perfmonCollectCounterData(PerfNetClient.perfmonCollectCounterDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="perfmonCollectCounterData", ReplyAction="*")]
        System.Threading.Tasks.Task<PerfNetClient.perfmonCollectCounterDataResponse> perfmonCollectCounterDataAsync(PerfNetClient.perfmonCollectCounterDataRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SessionHandleType
    {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class ObjectInfoType
    {
        
        private ObjectNameType nameField;
        
        private bool multiInstanceField;
        
        private CounterType[] arrayOfCounterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public ObjectNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool MultiInstance
        {
            get
            {
                return this.multiInstanceField;
            }
            set
            {
                this.multiInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public CounterType[] ArrayOfCounter
        {
            get
            {
                return this.arrayOfCounterField;
            }
            set
            {
                this.arrayOfCounterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class ObjectNameType
    {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CounterType
    {
        
        private CounterNameType nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public CounterNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CounterNameType
    {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class InstanceNameType
    {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class InstanceType
    {
        
        private InstanceNameType nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public InstanceNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CounterInfoType
    {
        
        private CounterNameType nameField;
        
        private long valueField;
        
        private uint cStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public CounterNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public uint CStatus
        {
            get
            {
                return this.cStatusField;
            }
            set
            {
                this.cStatusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonAddCounter", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonAddCounterRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public PerfNetClient.SessionHandleType SessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Counter", IsNullable=false)]
        public PerfNetClient.CounterType[] ArrayOfCounter;
        
        public perfmonAddCounterRequest()
        {
        }
        
        public perfmonAddCounterRequest(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            this.SessionHandle = SessionHandle;
            this.ArrayOfCounter = ArrayOfCounter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonAddCounterResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonAddCounterResponse
    {
        
        public perfmonAddCounterResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonRemoveCounter", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonRemoveCounterRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public PerfNetClient.SessionHandleType SessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Counter", IsNullable=false)]
        public PerfNetClient.CounterType[] ArrayOfCounter;
        
        public perfmonRemoveCounterRequest()
        {
        }
        
        public perfmonRemoveCounterRequest(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            this.SessionHandle = SessionHandle;
            this.ArrayOfCounter = ArrayOfCounter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonRemoveCounterResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonRemoveCounterResponse
    {
        
        public perfmonRemoveCounterResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonCollectSessionData", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonCollectSessionDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public PerfNetClient.SessionHandleType SessionHandle;
        
        public perfmonCollectSessionDataRequest()
        {
        }
        
        public perfmonCollectSessionDataRequest(PerfNetClient.SessionHandleType SessionHandle)
        {
            this.SessionHandle = SessionHandle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonCollectSessionDataResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonCollectSessionDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("perfmonCollectSessionDataReturn")]
        public PerfNetClient.CounterInfoType[] perfmonCollectSessionDataReturn;
        
        public perfmonCollectSessionDataResponse()
        {
        }
        
        public perfmonCollectSessionDataResponse(PerfNetClient.CounterInfoType[] perfmonCollectSessionDataReturn)
        {
            this.perfmonCollectSessionDataReturn = perfmonCollectSessionDataReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonListInstance", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonListInstanceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public string Host;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=1)]
        public PerfNetClient.ObjectNameType Object;
        
        public perfmonListInstanceRequest()
        {
        }
        
        public perfmonListInstanceRequest(string Host, PerfNetClient.ObjectNameType Object)
        {
            this.Host = Host;
            this.Object = Object;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonListInstanceResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonListInstanceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("perfmonListInstanceReturn")]
        public PerfNetClient.InstanceType[] perfmonListInstanceReturn;
        
        public perfmonListInstanceResponse()
        {
        }
        
        public perfmonListInstanceResponse(PerfNetClient.InstanceType[] perfmonListInstanceReturn)
        {
            this.perfmonListInstanceReturn = perfmonListInstanceReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonQueryCounterDescription", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonQueryCounterDescriptionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public PerfNetClient.CounterNameType Counter;
        
        public perfmonQueryCounterDescriptionRequest()
        {
        }
        
        public perfmonQueryCounterDescriptionRequest(PerfNetClient.CounterNameType Counter)
        {
            this.Counter = Counter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonQueryCounterDescriptionResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonQueryCounterDescriptionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string perfmonQueryCounterDescriptionReturn;
        
        public perfmonQueryCounterDescriptionResponse()
        {
        }
        
        public perfmonQueryCounterDescriptionResponse(string perfmonQueryCounterDescriptionReturn)
        {
            this.perfmonQueryCounterDescriptionReturn = perfmonQueryCounterDescriptionReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonListCounter", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonListCounterRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public string Host;
        
        public perfmonListCounterRequest()
        {
        }
        
        public perfmonListCounterRequest(string Host)
        {
            this.Host = Host;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonListCounterResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonListCounterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("perfmonListCounterReturn")]
        public PerfNetClient.ObjectInfoType[] perfmonListCounterReturn;
        
        public perfmonListCounterResponse()
        {
        }
        
        public perfmonListCounterResponse(PerfNetClient.ObjectInfoType[] perfmonListCounterReturn)
        {
            this.perfmonListCounterReturn = perfmonListCounterReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonCollectCounterData", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonCollectCounterDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public string Host;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=1)]
        public PerfNetClient.ObjectNameType Object;
        
        public perfmonCollectCounterDataRequest()
        {
        }
        
        public perfmonCollectCounterDataRequest(string Host, PerfNetClient.ObjectNameType Object)
        {
            this.Host = Host;
            this.Object = Object;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="perfmonCollectCounterDataResponse", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class perfmonCollectCounterDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("perfmonCollectCounterDataReturn")]
        public PerfNetClient.CounterInfoType[] perfmonCollectCounterDataReturn;
        
        public perfmonCollectCounterDataResponse()
        {
        }
        
        public perfmonCollectCounterDataResponse(PerfNetClient.CounterInfoType[] perfmonCollectCounterDataReturn)
        {
            this.perfmonCollectCounterDataReturn = perfmonCollectCounterDataReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PerfmonPortTypeChannel : PerfNetClient.PerfmonPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PerfmonPortTypeClient : System.ServiceModel.ClientBase<PerfNetClient.PerfmonPortType>, PerfNetClient.PerfmonPortType
    {
        
        public PerfmonPortTypeClient()
        {
        }
        
        public PerfmonPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public PerfmonPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PerfmonPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PerfmonPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public PerfNetClient.SessionHandleType perfmonOpenSession()
        {
            return base.Channel.perfmonOpenSession();
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.SessionHandleType> perfmonOpenSessionAsync()
        {
            return base.Channel.perfmonOpenSessionAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonAddCounterResponse PerfNetClient.PerfmonPortType.perfmonAddCounter(PerfNetClient.perfmonAddCounterRequest request)
        {
            return base.Channel.perfmonAddCounter(request);
        }
        
        public void perfmonAddCounter(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            PerfNetClient.perfmonAddCounterRequest inValue = new PerfNetClient.perfmonAddCounterRequest();
            inValue.SessionHandle = SessionHandle;
            inValue.ArrayOfCounter = ArrayOfCounter;
            PerfNetClient.perfmonAddCounterResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonAddCounter(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonAddCounterResponse> PerfNetClient.PerfmonPortType.perfmonAddCounterAsync(PerfNetClient.perfmonAddCounterRequest request)
        {
            return base.Channel.perfmonAddCounterAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonAddCounterResponse> perfmonAddCounterAsync(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            PerfNetClient.perfmonAddCounterRequest inValue = new PerfNetClient.perfmonAddCounterRequest();
            inValue.SessionHandle = SessionHandle;
            inValue.ArrayOfCounter = ArrayOfCounter;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonAddCounterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonRemoveCounterResponse PerfNetClient.PerfmonPortType.perfmonRemoveCounter(PerfNetClient.perfmonRemoveCounterRequest request)
        {
            return base.Channel.perfmonRemoveCounter(request);
        }
        
        public void perfmonRemoveCounter(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            PerfNetClient.perfmonRemoveCounterRequest inValue = new PerfNetClient.perfmonRemoveCounterRequest();
            inValue.SessionHandle = SessionHandle;
            inValue.ArrayOfCounter = ArrayOfCounter;
            PerfNetClient.perfmonRemoveCounterResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonRemoveCounter(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonRemoveCounterResponse> PerfNetClient.PerfmonPortType.perfmonRemoveCounterAsync(PerfNetClient.perfmonRemoveCounterRequest request)
        {
            return base.Channel.perfmonRemoveCounterAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonRemoveCounterResponse> perfmonRemoveCounterAsync(PerfNetClient.SessionHandleType SessionHandle, PerfNetClient.CounterType[] ArrayOfCounter)
        {
            PerfNetClient.perfmonRemoveCounterRequest inValue = new PerfNetClient.perfmonRemoveCounterRequest();
            inValue.SessionHandle = SessionHandle;
            inValue.ArrayOfCounter = ArrayOfCounter;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonRemoveCounterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonCollectSessionDataResponse PerfNetClient.PerfmonPortType.perfmonCollectSessionData(PerfNetClient.perfmonCollectSessionDataRequest request)
        {
            return base.Channel.perfmonCollectSessionData(request);
        }
        
        public PerfNetClient.CounterInfoType[] perfmonCollectSessionData(PerfNetClient.SessionHandleType SessionHandle)
        {
            PerfNetClient.perfmonCollectSessionDataRequest inValue = new PerfNetClient.perfmonCollectSessionDataRequest();
            inValue.SessionHandle = SessionHandle;
            PerfNetClient.perfmonCollectSessionDataResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonCollectSessionData(inValue);
            return retVal.perfmonCollectSessionDataReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonCollectSessionDataResponse> PerfNetClient.PerfmonPortType.perfmonCollectSessionDataAsync(PerfNetClient.perfmonCollectSessionDataRequest request)
        {
            return base.Channel.perfmonCollectSessionDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonCollectSessionDataResponse> perfmonCollectSessionDataAsync(PerfNetClient.SessionHandleType SessionHandle)
        {
            PerfNetClient.perfmonCollectSessionDataRequest inValue = new PerfNetClient.perfmonCollectSessionDataRequest();
            inValue.SessionHandle = SessionHandle;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonCollectSessionDataAsync(inValue);
        }
        
        public void perfmonCloseSession(PerfNetClient.SessionHandleType SessionHandle)
        {
            base.Channel.perfmonCloseSession(SessionHandle);
        }
        
        public System.Threading.Tasks.Task perfmonCloseSessionAsync(PerfNetClient.SessionHandleType SessionHandle)
        {
            return base.Channel.perfmonCloseSessionAsync(SessionHandle);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonListInstanceResponse PerfNetClient.PerfmonPortType.perfmonListInstance(PerfNetClient.perfmonListInstanceRequest request)
        {
            return base.Channel.perfmonListInstance(request);
        }
        
        public PerfNetClient.InstanceType[] perfmonListInstance(string Host, PerfNetClient.ObjectNameType Object)
        {
            PerfNetClient.perfmonListInstanceRequest inValue = new PerfNetClient.perfmonListInstanceRequest();
            inValue.Host = Host;
            inValue.Object = Object;
            PerfNetClient.perfmonListInstanceResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonListInstance(inValue);
            return retVal.perfmonListInstanceReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonListInstanceResponse> PerfNetClient.PerfmonPortType.perfmonListInstanceAsync(PerfNetClient.perfmonListInstanceRequest request)
        {
            return base.Channel.perfmonListInstanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonListInstanceResponse> perfmonListInstanceAsync(string Host, PerfNetClient.ObjectNameType Object)
        {
            PerfNetClient.perfmonListInstanceRequest inValue = new PerfNetClient.perfmonListInstanceRequest();
            inValue.Host = Host;
            inValue.Object = Object;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonListInstanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonQueryCounterDescriptionResponse PerfNetClient.PerfmonPortType.perfmonQueryCounterDescription(PerfNetClient.perfmonQueryCounterDescriptionRequest request)
        {
            return base.Channel.perfmonQueryCounterDescription(request);
        }
        
        public string perfmonQueryCounterDescription(PerfNetClient.CounterNameType Counter)
        {
            PerfNetClient.perfmonQueryCounterDescriptionRequest inValue = new PerfNetClient.perfmonQueryCounterDescriptionRequest();
            inValue.Counter = Counter;
            PerfNetClient.perfmonQueryCounterDescriptionResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonQueryCounterDescription(inValue);
            return retVal.perfmonQueryCounterDescriptionReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonQueryCounterDescriptionResponse> PerfNetClient.PerfmonPortType.perfmonQueryCounterDescriptionAsync(PerfNetClient.perfmonQueryCounterDescriptionRequest request)
        {
            return base.Channel.perfmonQueryCounterDescriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonQueryCounterDescriptionResponse> perfmonQueryCounterDescriptionAsync(PerfNetClient.CounterNameType Counter)
        {
            PerfNetClient.perfmonQueryCounterDescriptionRequest inValue = new PerfNetClient.perfmonQueryCounterDescriptionRequest();
            inValue.Counter = Counter;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonQueryCounterDescriptionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonListCounterResponse PerfNetClient.PerfmonPortType.perfmonListCounter(PerfNetClient.perfmonListCounterRequest request)
        {
            return base.Channel.perfmonListCounter(request);
        }
        
        public PerfNetClient.ObjectInfoType[] perfmonListCounter(string Host)
        {
            PerfNetClient.perfmonListCounterRequest inValue = new PerfNetClient.perfmonListCounterRequest();
            inValue.Host = Host;
            PerfNetClient.perfmonListCounterResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonListCounter(inValue);
            return retVal.perfmonListCounterReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonListCounterResponse> PerfNetClient.PerfmonPortType.perfmonListCounterAsync(PerfNetClient.perfmonListCounterRequest request)
        {
            return base.Channel.perfmonListCounterAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonListCounterResponse> perfmonListCounterAsync(string Host)
        {
            PerfNetClient.perfmonListCounterRequest inValue = new PerfNetClient.perfmonListCounterRequest();
            inValue.Host = Host;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonListCounterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PerfNetClient.perfmonCollectCounterDataResponse PerfNetClient.PerfmonPortType.perfmonCollectCounterData(PerfNetClient.perfmonCollectCounterDataRequest request)
        {
            return base.Channel.perfmonCollectCounterData(request);
        }
        
        public PerfNetClient.CounterInfoType[] perfmonCollectCounterData(string Host, PerfNetClient.ObjectNameType Object)
        {
            PerfNetClient.perfmonCollectCounterDataRequest inValue = new PerfNetClient.perfmonCollectCounterDataRequest();
            inValue.Host = Host;
            inValue.Object = Object;
            PerfNetClient.perfmonCollectCounterDataResponse retVal = ((PerfNetClient.PerfmonPortType)(this)).perfmonCollectCounterData(inValue);
            return retVal.perfmonCollectCounterDataReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PerfNetClient.perfmonCollectCounterDataResponse> PerfNetClient.PerfmonPortType.perfmonCollectCounterDataAsync(PerfNetClient.perfmonCollectCounterDataRequest request)
        {
            return base.Channel.perfmonCollectCounterDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<PerfNetClient.perfmonCollectCounterDataResponse> perfmonCollectCounterDataAsync(string Host, PerfNetClient.ObjectNameType Object)
        {
            PerfNetClient.perfmonCollectCounterDataRequest inValue = new PerfNetClient.perfmonCollectCounterDataRequest();
            inValue.Host = Host;
            inValue.Object = Object;
            return ((PerfNetClient.PerfmonPortType)(this)).perfmonCollectCounterDataAsync(inValue);
        }
    }
}
