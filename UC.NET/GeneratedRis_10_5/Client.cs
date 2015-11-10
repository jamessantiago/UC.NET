//svcutil RISService70.xml /t:code /l:C# /o:Client.cs /n:*,RisNetClient

namespace RisNetClient
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmSelectionCriteria", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CmSelectionCriteria : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<uint> MaxReturnedDevicesField;
        
        private string DeviceClassField;
        
        private System.Nullable<uint> ModelField;
        
        private string StatusField;
        
        private string NodeNameField;
        
        private System.Nullable<RisNetClient.CmSelectBy> SelectByField;
        
        private RisNetClient.ArrayOfSelectItem SelectItemsField;
        
        private System.Nullable<RisNetClient.ProtocolType> ProtocolField;
        
        private System.Nullable<RisNetClient.DeviceDownloadStatus> DownloadStatusField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> MaxReturnedDevices
        {
            get
            {
                return this.MaxReturnedDevicesField;
            }
            set
            {
                this.MaxReturnedDevicesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string DeviceClass
        {
            get
            {
                return this.DeviceClassField;
            }
            set
            {
                this.DeviceClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<uint> Model
        {
            get
            {
                return this.ModelField;
            }
            set
            {
                this.ModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public string NodeName
        {
            get
            {
                return this.NodeNameField;
            }
            set
            {
                this.NodeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<RisNetClient.CmSelectBy> SelectBy
        {
            get
            {
                return this.SelectByField;
            }
            set
            {
                this.SelectByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public RisNetClient.ArrayOfSelectItem SelectItems
        {
            get
            {
                return this.SelectItemsField;
            }
            set
            {
                this.SelectItemsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<RisNetClient.ProtocolType> Protocol
        {
            get
            {
                return this.ProtocolField;
            }
            set
            {
                this.ProtocolField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<RisNetClient.DeviceDownloadStatus> DownloadStatus
        {
            get
            {
                return this.DownloadStatusField;
            }
            set
            {
                this.DownloadStatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmSelectBy", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CmSelectBy : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Name = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IPV4Address = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IPV6Address = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DirNumber = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Description = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfSelectItem", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfSelectItem : System.Collections.Generic.List<RisNetClient.SelectItem>
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProtocolType", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum ProtocolType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SCCP = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SIP = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeviceDownloadStatus", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum DeviceDownloadStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Upgrading = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Successful = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectItem", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ItemField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Item
        {
            get
            {
                return this.ItemField;
            }
            set
            {
                this.ItemField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="selectCmDeviceReturn", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCmDeviceReturn : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private RisNetClient.SelectCmDeviceResult SelectCmDeviceResultField;
        
        private string StateInfoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public RisNetClient.SelectCmDeviceResult SelectCmDeviceResult
        {
            get
            {
                return this.SelectCmDeviceResultField;
            }
            set
            {
                this.SelectCmDeviceResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string StateInfo
        {
            get
            {
                return this.StateInfoField;
            }
            set
            {
                this.StateInfoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectCmDeviceResult", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectCmDeviceResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<uint> TotalDevicesFoundField;
        
        private RisNetClient.ArrayOfCmNode CmNodesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> TotalDevicesFound
        {
            get
            {
                return this.TotalDevicesFoundField;
            }
            set
            {
                this.TotalDevicesFoundField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public RisNetClient.ArrayOfCmNode CmNodes
        {
            get
            {
                return this.CmNodesField;
            }
            set
            {
                this.CmNodesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCmNode", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfCmNode : System.Collections.Generic.List<RisNetClient.CmNode>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmNode", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CmNode : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<RisNetClient.RisReturnCode> ReturnCodeField;
        
        private string NameField;
        
        private bool NoChangeField;
        
        private RisNetClient.ArrayOfCmDevice CmDevicesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<RisNetClient.RisReturnCode> ReturnCode
        {
            get
            {
                return this.ReturnCodeField;
            }
            set
            {
                this.ReturnCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool NoChange
        {
            get
            {
                return this.NoChangeField;
            }
            set
            {
                this.NoChangeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public RisNetClient.ArrayOfCmDevice CmDevices
        {
            get
            {
                return this.CmDevicesField;
            }
            set
            {
                this.CmDevicesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RisReturnCode", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum RisReturnCode : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ok = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotFound = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidRequest = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InternalError = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NodeNotResponding = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidNodeName = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCmDevice", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfCmDevice : System.Collections.Generic.List<RisNetClient.CmDevice>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmDevice", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CmDevice : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string NameField;
        
        private string DirNumberField;
        
        private System.Nullable<RisNetClient.DeviceClass> DeviceClassField;
        
        private System.Nullable<uint> ModelField;
        
        private System.Nullable<uint> ProductField;
        
        private System.Nullable<uint> BoxProductField;
        
        private System.Nullable<RisNetClient.CmDevHttpd> HttpdField;
        
        private System.Nullable<uint> RegistrationAttemptsField;
        
        private bool IsCtiControllableField;
        
        private string LoginUserIdField;
        
        private System.Nullable<RisNetClient.CmDevRegStat> StatusField;
        
        private System.Nullable<uint> StatusReasonField;
        
        private System.Nullable<uint> PerfMonObjectField;
        
        private System.Nullable<uint> DChannelField;
        
        private string DescriptionField;
        
        private RisNetClient.H323Trunk H323TrunkField;
        
        private System.Nullable<uint> TimeStampField;
        
        private System.Nullable<RisNetClient.ProtocolType> ProtocolField;
        
        private System.Nullable<uint> NumOfLinesField;
        
        private RisNetClient.ArrayOfCmDevSingleLineStatus LinesStatusField;
        
        private string ActiveLoadIDField;
        
        private string InactiveLoadIDField;
        
        private System.Nullable<RisNetClient.DeviceDownloadStatus> DownloadStatusField;
        
        private string DownloadFailureReasonField;
        
        private string DownloadServerField;
        
        private RisNetClient.ArrayOfIPAddressArrayType IPAddressField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string DirNumber
        {
            get
            {
                return this.DirNumberField;
            }
            set
            {
                this.DirNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<RisNetClient.DeviceClass> DeviceClass
        {
            get
            {
                return this.DeviceClassField;
            }
            set
            {
                this.DeviceClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<uint> Model
        {
            get
            {
                return this.ModelField;
            }
            set
            {
                this.ModelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<uint> Product
        {
            get
            {
                return this.ProductField;
            }
            set
            {
                this.ProductField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<uint> BoxProduct
        {
            get
            {
                return this.BoxProductField;
            }
            set
            {
                this.BoxProductField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<RisNetClient.CmDevHttpd> Httpd
        {
            get
            {
                return this.HttpdField;
            }
            set
            {
                this.HttpdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<uint> RegistrationAttempts
        {
            get
            {
                return this.RegistrationAttemptsField;
            }
            set
            {
                this.RegistrationAttemptsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public bool IsCtiControllable
        {
            get
            {
                return this.IsCtiControllableField;
            }
            set
            {
                this.IsCtiControllableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public string LoginUserId
        {
            get
            {
                return this.LoginUserIdField;
            }
            set
            {
                this.LoginUserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public System.Nullable<RisNetClient.CmDevRegStat> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public System.Nullable<uint> StatusReason
        {
            get
            {
                return this.StatusReasonField;
            }
            set
            {
                this.StatusReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public System.Nullable<uint> PerfMonObject
        {
            get
            {
                return this.PerfMonObjectField;
            }
            set
            {
                this.PerfMonObjectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public System.Nullable<uint> DChannel
        {
            get
            {
                return this.DChannelField;
            }
            set
            {
                this.DChannelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public RisNetClient.H323Trunk H323Trunk
        {
            get
            {
                return this.H323TrunkField;
            }
            set
            {
                this.H323TrunkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=16)]
        public System.Nullable<uint> TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=17)]
        public System.Nullable<RisNetClient.ProtocolType> Protocol
        {
            get
            {
                return this.ProtocolField;
            }
            set
            {
                this.ProtocolField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=18)]
        public System.Nullable<uint> NumOfLines
        {
            get
            {
                return this.NumOfLinesField;
            }
            set
            {
                this.NumOfLinesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=19)]
        public RisNetClient.ArrayOfCmDevSingleLineStatus LinesStatus
        {
            get
            {
                return this.LinesStatusField;
            }
            set
            {
                this.LinesStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=20)]
        public string ActiveLoadID
        {
            get
            {
                return this.ActiveLoadIDField;
            }
            set
            {
                this.ActiveLoadIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=21)]
        public string InactiveLoadID
        {
            get
            {
                return this.InactiveLoadIDField;
            }
            set
            {
                this.InactiveLoadIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=22)]
        public System.Nullable<RisNetClient.DeviceDownloadStatus> DownloadStatus
        {
            get
            {
                return this.DownloadStatusField;
            }
            set
            {
                this.DownloadStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=23)]
        public string DownloadFailureReason
        {
            get
            {
                return this.DownloadFailureReasonField;
            }
            set
            {
                this.DownloadFailureReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=24)]
        public string DownloadServer
        {
            get
            {
                return this.DownloadServerField;
            }
            set
            {
                this.DownloadServerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=25)]
        public RisNetClient.ArrayOfIPAddressArrayType IPAddress
        {
            get
            {
                return this.IPAddressField;
            }
            set
            {
                this.IPAddressField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="H323Trunk", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class H323Trunk : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ConfigNameField;
        
        private string TechPrefixField;
        
        private string ZoneField;
        
        private string RemoteCmServer1Field;
        
        private string RemoteCmServer2Field;
        
        private string RemoteCmServer3Field;
        
        private string AltGkListField;
        
        private string ActiveGkField;
        
        private string CallSignalAddrField;
        
        private string RasAddrField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ConfigName
        {
            get
            {
                return this.ConfigNameField;
            }
            set
            {
                this.ConfigNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string TechPrefix
        {
            get
            {
                return this.TechPrefixField;
            }
            set
            {
                this.TechPrefixField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Zone
        {
            get
            {
                return this.ZoneField;
            }
            set
            {
                this.ZoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string RemoteCmServer1
        {
            get
            {
                return this.RemoteCmServer1Field;
            }
            set
            {
                this.RemoteCmServer1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public string RemoteCmServer2
        {
            get
            {
                return this.RemoteCmServer2Field;
            }
            set
            {
                this.RemoteCmServer2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public string RemoteCmServer3
        {
            get
            {
                return this.RemoteCmServer3Field;
            }
            set
            {
                this.RemoteCmServer3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public string AltGkList
        {
            get
            {
                return this.AltGkListField;
            }
            set
            {
                this.AltGkListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public string ActiveGk
        {
            get
            {
                return this.ActiveGkField;
            }
            set
            {
                this.ActiveGkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public string CallSignalAddr
        {
            get
            {
                return this.CallSignalAddrField;
            }
            set
            {
                this.CallSignalAddrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public string RasAddr
        {
            get
            {
                return this.RasAddrField;
            }
            set
            {
                this.RasAddrField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeviceClass", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum DeviceClass : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Phone = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Gateway = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        H323 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cti = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VoiceMail = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MediaResources = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SIPTrunk = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuntList = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 9,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmDevHttpd", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CmDevHttpd : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Yes = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        No = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmDevRegStat", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CmDevRegStat : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Registered = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnRegistered = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartiallyRegistered = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCmDevSingleLineStatus", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfCmDevSingleLineStatus : System.Collections.Generic.List<RisNetClient.CmDevSingleLineStatus>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfIPAddressArrayType", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfIPAddressArrayType : System.Collections.Generic.List<RisNetClient.IPAddressArrayType>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmDevSingleLineStatus", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CmDevSingleLineStatus : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DirectoryNumberField;
        
        private System.Nullable<RisNetClient.CmSingleLineStatus> StatusField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DirectoryNumber
        {
            get
            {
                return this.DirectoryNumberField;
            }
            set
            {
                this.DirectoryNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<RisNetClient.CmSingleLineStatus> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CmSingleLineStatus", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CmSingleLineStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Registered = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnRegistered = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IPAddressArrayType", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class IPAddressArrayType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string IPField;
        
        private RisNetClient.IPAddrType IPAddrTypeField;
        
        private System.Nullable<RisNetClient.AttributeType> AttributeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string IP
        {
            get
            {
                return this.IPField;
            }
            set
            {
                this.IPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public RisNetClient.IPAddrType IPAddrType
        {
            get
            {
                return this.IPAddrTypeField;
            }
            set
            {
                this.IPAddrTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<RisNetClient.AttributeType> Attribute
        {
            get
            {
                return this.AttributeField;
            }
            set
            {
                this.AttributeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IPAddrType", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum IPAddrType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ipv4 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ipv6 = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AttributeType", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum AttributeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Adminstrative = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Signaling = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AdministrativeAndSignaling = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiSelectionCriteria", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CtiSelectionCriteria : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<uint> MaxReturnedItemsField;
        
        private System.Nullable<RisNetClient.CtiMgrClass> CtiMgrClassField;
        
        private System.Nullable<RisNetClient.CtiStatus> StatusField;
        
        private string NodeNameField;
        
        private System.Nullable<RisNetClient.CtiSelectAppBy> SelectAppByField;
        
        private RisNetClient.ArrayOfSelectAppItem AppItemsField;
        
        private RisNetClient.ArrayOfSelectDevName DevNamesField;
        
        private RisNetClient.ArrayOfSelectDirNumber DirNumbersField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> MaxReturnedItems
        {
            get
            {
                return this.MaxReturnedItemsField;
            }
            set
            {
                this.MaxReturnedItemsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.Nullable<RisNetClient.CtiMgrClass> CtiMgrClass
        {
            get
            {
                return this.CtiMgrClassField;
            }
            set
            {
                this.CtiMgrClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<RisNetClient.CtiStatus> Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string NodeName
        {
            get
            {
                return this.NodeNameField;
            }
            set
            {
                this.NodeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<RisNetClient.CtiSelectAppBy> SelectAppBy
        {
            get
            {
                return this.SelectAppByField;
            }
            set
            {
                this.SelectAppByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public RisNetClient.ArrayOfSelectAppItem AppItems
        {
            get
            {
                return this.AppItemsField;
            }
            set
            {
                this.AppItemsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public RisNetClient.ArrayOfSelectDevName DevNames
        {
            get
            {
                return this.DevNamesField;
            }
            set
            {
                this.DevNamesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public RisNetClient.ArrayOfSelectDirNumber DirNumbers
        {
            get
            {
                return this.DirNumbersField;
            }
            set
            {
                this.DirNumbersField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiMgrClass", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CtiMgrClass : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Provider = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Device = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Line = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiStatus", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CtiStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Any = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Closed = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OpenFailed = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiSelectAppBy", Namespace="http://schemas.cisco.com/ast/soap")]
    public enum CtiSelectAppBy : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AppId = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AppIPV4Address = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AppIPV6Address = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UserId = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfSelectAppItem", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfSelectAppItem : System.Collections.Generic.List<RisNetClient.SelectAppItem>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfSelectDevName", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfSelectDevName : System.Collections.Generic.List<RisNetClient.SelectDevName>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfSelectDirNumber", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfSelectDirNumber : System.Collections.Generic.List<RisNetClient.SelectDirNumber>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectAppItem", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectAppItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AppItemField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string AppItem
        {
            get
            {
                return this.AppItemField;
            }
            set
            {
                this.AppItemField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectDevName", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectDevName : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DevNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DevName
        {
            get
            {
                return this.DevNameField;
            }
            set
            {
                this.DevNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectDirNumber", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectDirNumber : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DirNumberField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DirNumber
        {
            get
            {
                return this.DirNumberField;
            }
            set
            {
                this.DirNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="selectCtiItemReturn", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCtiItemReturn : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private RisNetClient.SelectCtiItemResult SelectCtiItemResultField;
        
        private string StateInfoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public RisNetClient.SelectCtiItemResult SelectCtiItemResult
        {
            get
            {
                return this.SelectCtiItemResultField;
            }
            set
            {
                this.SelectCtiItemResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string StateInfo
        {
            get
            {
                return this.StateInfoField;
            }
            set
            {
                this.StateInfoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectCtiItemResult", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class SelectCtiItemResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<uint> TotalItemsFoundField;
        
        private RisNetClient.ArrayOfCtiNode CtiNodesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> TotalItemsFound
        {
            get
            {
                return this.TotalItemsFoundField;
            }
            set
            {
                this.TotalItemsFoundField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public RisNetClient.ArrayOfCtiNode CtiNodes
        {
            get
            {
                return this.CtiNodesField;
            }
            set
            {
                this.CtiNodesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCtiNode", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfCtiNode : System.Collections.Generic.List<RisNetClient.CtiNode>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiNode", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CtiNode : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<RisNetClient.RisReturnCode> ReturnCodeField;
        
        private string NameField;
        
        private bool NoChangeField;
        
        private RisNetClient.ArrayOfCtiItem CtiItemsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<RisNetClient.RisReturnCode> ReturnCode
        {
            get
            {
                return this.ReturnCodeField;
            }
            set
            {
                this.ReturnCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool NoChange
        {
            get
            {
                return this.NoChangeField;
            }
            set
            {
                this.NoChangeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public RisNetClient.ArrayOfCtiItem CtiItems
        {
            get
            {
                return this.CtiItemsField;
            }
            set
            {
                this.CtiItemsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCtiItem", Namespace="http://schemas.cisco.com/ast/soap", ItemName="item")]
    public class ArrayOfCtiItem : System.Collections.Generic.List<RisNetClient.CtiItem>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiItem", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CtiItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AppIdField;
        
        private string UserIdField;
        
        private string AppIpAddrField;
        
        private string AppIpv6AddrField;
        
        private System.Nullable<RisNetClient.CtiStatus> AppStatusField;
        
        private System.Nullable<uint> AppStatusReasonField;
        
        private System.Nullable<uint> AppTimeStampField;
        
        private RisNetClient.CtiDevice CtiDeviceField;
        
        private RisNetClient.CtiLine CtiLineField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string AppId
        {
            get
            {
                return this.AppIdField;
            }
            set
            {
                this.AppIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public string AppIpAddr
        {
            get
            {
                return this.AppIpAddrField;
            }
            set
            {
                this.AppIpAddrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public string AppIpv6Addr
        {
            get
            {
                return this.AppIpv6AddrField;
            }
            set
            {
                this.AppIpv6AddrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<RisNetClient.CtiStatus> AppStatus
        {
            get
            {
                return this.AppStatusField;
            }
            set
            {
                this.AppStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<uint> AppStatusReason
        {
            get
            {
                return this.AppStatusReasonField;
            }
            set
            {
                this.AppStatusReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<uint> AppTimeStamp
        {
            get
            {
                return this.AppTimeStampField;
            }
            set
            {
                this.AppTimeStampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public RisNetClient.CtiDevice CtiDevice
        {
            get
            {
                return this.CtiDeviceField;
            }
            set
            {
                this.CtiDeviceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public RisNetClient.CtiLine CtiLine
        {
            get
            {
                return this.CtiLineField;
            }
            set
            {
                this.CtiLineField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiDevice", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CtiDevice : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<bool> AppControlsMediaField;
        
        private string DeviceNameField;
        
        private System.Nullable<RisNetClient.CtiStatus> DeviceStatusField;
        
        private System.Nullable<uint> DeviceStatusReasonField;
        
        private System.Nullable<uint> DeviceTimeStampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<bool> AppControlsMedia
        {
            get
            {
                return this.AppControlsMediaField;
            }
            set
            {
                this.AppControlsMediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DeviceName
        {
            get
            {
                return this.DeviceNameField;
            }
            set
            {
                this.DeviceNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<RisNetClient.CtiStatus> DeviceStatus
        {
            get
            {
                return this.DeviceStatusField;
            }
            set
            {
                this.DeviceStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> DeviceStatusReason
        {
            get
            {
                return this.DeviceStatusReasonField;
            }
            set
            {
                this.DeviceStatusReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> DeviceTimeStamp
        {
            get
            {
                return this.DeviceTimeStampField;
            }
            set
            {
                this.DeviceTimeStampField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtiLine", Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class CtiLine : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DirNumberField;
        
        private System.Nullable<RisNetClient.CtiStatus> LineStatusField;
        
        private System.Nullable<uint> LineStatusReasonField;
        
        private System.Nullable<uint> LineTimeStampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DirNumber
        {
            get
            {
                return this.DirNumberField;
            }
            set
            {
                this.DirNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<RisNetClient.CtiStatus> LineStatus
        {
            get
            {
                return this.LineStatusField;
            }
            set
            {
                this.LineStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> LineStatusReason
        {
            get
            {
                return this.LineStatusReasonField;
            }
            set
            {
                this.LineStatusReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<uint> LineTimeStamp
        {
            get
            {
                return this.LineTimeStampField;
            }
            set
            {
                this.LineTimeStampField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.cisco.com/ast/soap", ConfigurationName="RisNetClient.RisPortType")]
    public interface RisPortType
    {
        
        // CODEGEN: Generating message contract since element name StateInfo from namespace http://schemas.cisco.com/ast/soap is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="selectCmDevice", ReplyAction="*")]
        RisNetClient.selectCmDeviceResponse selectCmDevice(RisNetClient.selectCmDeviceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="selectCmDevice", ReplyAction="*")]
        System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> selectCmDeviceAsync(RisNetClient.selectCmDeviceRequest request);
        
        // CODEGEN: Generating message contract since element name StateInfo from namespace http://schemas.cisco.com/ast/soap is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="selectCtiItem", ReplyAction="*")]
        RisNetClient.selectCtiItemResponse selectCtiItem(RisNetClient.selectCtiItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="selectCtiItem", ReplyAction="*")]
        System.Threading.Tasks.Task<RisNetClient.selectCtiItemResponse> selectCtiItemAsync(RisNetClient.selectCtiItemRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (selectCmDeviceResponse) of message selectCmDeviceResponse does not match the default value (selectCmDeviceExt)
        [System.ServiceModel.OperationContractAttribute(Action="selectCmDeviceExt", ReplyAction="*")]
        RisNetClient.selectCmDeviceResponse selectCmDeviceExt(RisNetClient.selectCmDeviceRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="selectCmDeviceExt", ReplyAction="*")]
        System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> selectCmDeviceExtAsync(RisNetClient.selectCmDeviceRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectCmDeviceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectCmDevice", Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public RisNetClient.selectCmDeviceRequestBody Body;
        
        public selectCmDeviceRequest()
        {
        }
        
        public selectCmDeviceRequest(RisNetClient.selectCmDeviceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCmDeviceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StateInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public RisNetClient.CmSelectionCriteria CmSelectionCriteria;
        
        public selectCmDeviceRequestBody()
        {
        }
        
        public selectCmDeviceRequestBody(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            this.StateInfo = StateInfo;
            this.CmSelectionCriteria = CmSelectionCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectCmDeviceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectCmDeviceResponse", Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public RisNetClient.selectCmDeviceResponseBody Body;
        
        public selectCmDeviceResponse()
        {
        }
        
        public selectCmDeviceResponse(RisNetClient.selectCmDeviceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCmDeviceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RisNetClient.selectCmDeviceReturn selectCmDeviceReturn;
        
        public selectCmDeviceResponseBody()
        {
        }
        
        public selectCmDeviceResponseBody(RisNetClient.selectCmDeviceReturn selectCmDeviceReturn)
        {
            this.selectCmDeviceReturn = selectCmDeviceReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectCtiItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectCtiItem", Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public RisNetClient.selectCtiItemRequestBody Body;
        
        public selectCtiItemRequest()
        {
        }
        
        public selectCtiItemRequest(RisNetClient.selectCtiItemRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCtiItemRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StateInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public RisNetClient.CtiSelectionCriteria CtiSelectionCriteria;
        
        public selectCtiItemRequestBody()
        {
        }
        
        public selectCtiItemRequestBody(string StateInfo, RisNetClient.CtiSelectionCriteria CtiSelectionCriteria)
        {
            this.StateInfo = StateInfo;
            this.CtiSelectionCriteria = CtiSelectionCriteria;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class selectCtiItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="selectCtiItemResponse", Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public RisNetClient.selectCtiItemResponseBody Body;
        
        public selectCtiItemResponse()
        {
        }
        
        public selectCtiItemResponse(RisNetClient.selectCtiItemResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.cisco.com/ast/soap")]
    public partial class selectCtiItemResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RisNetClient.selectCtiItemReturn selectCtiItemReturn;
        
        public selectCtiItemResponseBody()
        {
        }
        
        public selectCtiItemResponseBody(RisNetClient.selectCtiItemReturn selectCtiItemReturn)
        {
            this.selectCtiItemReturn = selectCtiItemReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="selectCmDeviceExt", WrapperNamespace="http://schemas.cisco.com/ast/soap", IsWrapped=true)]
    public partial class selectCmDeviceRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=0)]
        public string StateInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.cisco.com/ast/soap", Order=1)]
        public RisNetClient.CmSelectionCriteria CmSelectionCriteria;
        
        public selectCmDeviceRequest1()
        {
        }
        
        public selectCmDeviceRequest1(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            this.StateInfo = StateInfo;
            this.CmSelectionCriteria = CmSelectionCriteria;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RisPortTypeChannel : RisNetClient.RisPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RisPortTypeClient : System.ServiceModel.ClientBase<RisNetClient.RisPortType>, RisNetClient.RisPortType
    {
        
        public RisPortTypeClient()
        {
        }
        
        public RisPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public RisPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RisPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public RisPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RisNetClient.selectCmDeviceResponse RisNetClient.RisPortType.selectCmDevice(RisNetClient.selectCmDeviceRequest request)
        {
            return base.Channel.selectCmDevice(request);
        }
        
        public RisNetClient.selectCmDeviceReturn selectCmDevice(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            RisNetClient.selectCmDeviceRequest inValue = new RisNetClient.selectCmDeviceRequest();
            inValue.Body = new RisNetClient.selectCmDeviceRequestBody();
            inValue.Body.StateInfo = StateInfo;
            inValue.Body.CmSelectionCriteria = CmSelectionCriteria;
            RisNetClient.selectCmDeviceResponse retVal = ((RisNetClient.RisPortType)(this)).selectCmDevice(inValue);
            return retVal.Body.selectCmDeviceReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> RisNetClient.RisPortType.selectCmDeviceAsync(RisNetClient.selectCmDeviceRequest request)
        {
            return base.Channel.selectCmDeviceAsync(request);
        }
        
        public System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> selectCmDeviceAsync(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            RisNetClient.selectCmDeviceRequest inValue = new RisNetClient.selectCmDeviceRequest();
            inValue.Body = new RisNetClient.selectCmDeviceRequestBody();
            inValue.Body.StateInfo = StateInfo;
            inValue.Body.CmSelectionCriteria = CmSelectionCriteria;
            return ((RisNetClient.RisPortType)(this)).selectCmDeviceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RisNetClient.selectCtiItemResponse RisNetClient.RisPortType.selectCtiItem(RisNetClient.selectCtiItemRequest request)
        {
            return base.Channel.selectCtiItem(request);
        }
        
        public RisNetClient.selectCtiItemReturn selectCtiItem(string StateInfo, RisNetClient.CtiSelectionCriteria CtiSelectionCriteria)
        {
            RisNetClient.selectCtiItemRequest inValue = new RisNetClient.selectCtiItemRequest();
            inValue.Body = new RisNetClient.selectCtiItemRequestBody();
            inValue.Body.StateInfo = StateInfo;
            inValue.Body.CtiSelectionCriteria = CtiSelectionCriteria;
            RisNetClient.selectCtiItemResponse retVal = ((RisNetClient.RisPortType)(this)).selectCtiItem(inValue);
            return retVal.Body.selectCtiItemReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RisNetClient.selectCtiItemResponse> RisNetClient.RisPortType.selectCtiItemAsync(RisNetClient.selectCtiItemRequest request)
        {
            return base.Channel.selectCtiItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<RisNetClient.selectCtiItemResponse> selectCtiItemAsync(string StateInfo, RisNetClient.CtiSelectionCriteria CtiSelectionCriteria)
        {
            RisNetClient.selectCtiItemRequest inValue = new RisNetClient.selectCtiItemRequest();
            inValue.Body = new RisNetClient.selectCtiItemRequestBody();
            inValue.Body.StateInfo = StateInfo;
            inValue.Body.CtiSelectionCriteria = CtiSelectionCriteria;
            return ((RisNetClient.RisPortType)(this)).selectCtiItemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RisNetClient.selectCmDeviceResponse RisNetClient.RisPortType.selectCmDeviceExt(RisNetClient.selectCmDeviceRequest1 request)
        {
            return base.Channel.selectCmDeviceExt(request);
        }
        
        public RisNetClient.selectCmDeviceReturn selectCmDeviceExt(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            RisNetClient.selectCmDeviceRequest1 inValue = new RisNetClient.selectCmDeviceRequest1();
            inValue.StateInfo = StateInfo;
            inValue.CmSelectionCriteria = CmSelectionCriteria;
            RisNetClient.selectCmDeviceResponse retVal = ((RisNetClient.RisPortType)(this)).selectCmDeviceExt(inValue);
            return retVal.Body.selectCmDeviceReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> RisNetClient.RisPortType.selectCmDeviceExtAsync(RisNetClient.selectCmDeviceRequest1 request)
        {
            return base.Channel.selectCmDeviceExtAsync(request);
        }
        
        public System.Threading.Tasks.Task<RisNetClient.selectCmDeviceResponse> selectCmDeviceExtAsync(string StateInfo, RisNetClient.CmSelectionCriteria CmSelectionCriteria)
        {
            RisNetClient.selectCmDeviceRequest1 inValue = new RisNetClient.selectCmDeviceRequest1();
            inValue.StateInfo = StateInfo;
            inValue.CmSelectionCriteria = CmSelectionCriteria;
            return ((RisNetClient.RisPortType)(this)).selectCmDeviceExtAsync(inValue);
        }
    }
}
