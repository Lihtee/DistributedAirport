﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainServer.BalancerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderIPField;
        
        private int RequestTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MainServer.BalancerReference.Plane PlaneField;
        
        private int RequestDifficultyField;
        
        private int RequestTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SenderIP {
            get {
                return this.SenderIPField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderIPField, value) != true)) {
                    this.SenderIPField = value;
                    this.RaisePropertyChanged("SenderIP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int RequestType {
            get {
                return this.RequestTypeField;
            }
            set {
                if ((this.RequestTypeField.Equals(value) != true)) {
                    this.RequestTypeField = value;
                    this.RaisePropertyChanged("RequestType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public MainServer.BalancerReference.Plane Plane {
            get {
                return this.PlaneField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaneField, value) != true)) {
                    this.PlaneField = value;
                    this.RaisePropertyChanged("Plane");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int RequestDifficulty {
            get {
                return this.RequestDifficultyField;
            }
            set {
                if ((this.RequestDifficultyField.Equals(value) != true)) {
                    this.RequestDifficultyField = value;
                    this.RaisePropertyChanged("RequestDifficulty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int RequestTime {
            get {
                return this.RequestTimeField;
            }
            set {
                if ((this.RequestTimeField.Equals(value) != true)) {
                    this.RequestTimeField = value;
                    this.RaisePropertyChanged("RequestTime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Plane", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Plane : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int PlaneTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int PlaneType {
            get {
                return this.PlaneTypeField;
            }
            set {
                if ((this.PlaneTypeField.Equals(value) != true)) {
                    this.PlaneTypeField = value;
                    this.RaisePropertyChanged("PlaneType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BalancerReference.BalancerServiceSoap")]
    public interface BalancerServiceSoap {
        
        // CODEGEN: Generating message contract since element name request from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/request", ReplyAction="*")]
        MainServer.BalancerReference.requestResponse request(MainServer.BalancerReference.requestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/request", ReplyAction="*")]
        System.Threading.Tasks.Task<MainServer.BalancerReference.requestResponse> requestAsync(MainServer.BalancerReference.requestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class requestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="request", Namespace="http://tempuri.org/", Order=0)]
        public MainServer.BalancerReference.requestRequestBody Body;
        
        public requestRequest() {
        }
        
        public requestRequest(MainServer.BalancerReference.requestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class requestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainServer.BalancerReference.Request request;
        
        public requestRequestBody() {
        }
        
        public requestRequestBody(MainServer.BalancerReference.Request request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class requestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="requestResponse", Namespace="http://tempuri.org/", Order=0)]
        public MainServer.BalancerReference.requestResponseBody Body;
        
        public requestResponse() {
        }
        
        public requestResponse(MainServer.BalancerReference.requestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class requestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainServer.BalancerReference.Request requestResult;
        
        public requestResponseBody() {
        }
        
        public requestResponseBody(MainServer.BalancerReference.Request requestResult) {
            this.requestResult = requestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BalancerServiceSoapChannel : MainServer.BalancerReference.BalancerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BalancerServiceSoapClient : System.ServiceModel.ClientBase<MainServer.BalancerReference.BalancerServiceSoap>, MainServer.BalancerReference.BalancerServiceSoap {
        
        public BalancerServiceSoapClient() {
        }
        
        public BalancerServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BalancerServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalancerServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalancerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MainServer.BalancerReference.requestResponse MainServer.BalancerReference.BalancerServiceSoap.request(MainServer.BalancerReference.requestRequest request) {
            return base.Channel.request(request);
        }
        
        public MainServer.BalancerReference.Request request(MainServer.BalancerReference.Request request1) {
            MainServer.BalancerReference.requestRequest inValue = new MainServer.BalancerReference.requestRequest();
            inValue.Body = new MainServer.BalancerReference.requestRequestBody();
            inValue.Body.request = request1;
            MainServer.BalancerReference.requestResponse retVal = ((MainServer.BalancerReference.BalancerServiceSoap)(this)).request(inValue);
            return retVal.Body.requestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MainServer.BalancerReference.requestResponse> MainServer.BalancerReference.BalancerServiceSoap.requestAsync(MainServer.BalancerReference.requestRequest request) {
            return base.Channel.requestAsync(request);
        }
        
        public System.Threading.Tasks.Task<MainServer.BalancerReference.requestResponse> requestAsync(MainServer.BalancerReference.Request request) {
            MainServer.BalancerReference.requestRequest inValue = new MainServer.BalancerReference.requestRequest();
            inValue.Body = new MainServer.BalancerReference.requestRequestBody();
            inValue.Body.request = request;
            return ((MainServer.BalancerReference.BalancerServiceSoap)(this)).requestAsync(inValue);
        }
    }
}