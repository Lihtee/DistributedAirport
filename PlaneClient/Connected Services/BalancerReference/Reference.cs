﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlaneClient.BalancerReference {
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
        private PlaneClient.BalancerReference.Plane PlaneField;
        
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
        public PlaneClient.BalancerReference.Plane Plane {
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
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PlaneClient.BalancerReference.ExtensionDataObject ExtensionData1Field;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="ExtensionData", EmitDefaultValue=false)]
        public PlaneClient.BalancerReference.ExtensionDataObject ExtensionData1 {
            get {
                return this.ExtensionData1Field;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionData1Field, value) != true)) {
                    this.ExtensionData1Field = value;
                    this.RaisePropertyChanged("ExtensionData1");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExtensionDataObject", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ExtensionDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakeRequest", ReplyAction="*")]
        PlaneClient.BalancerReference.MakeRequestResponse MakeRequest(PlaneClient.BalancerReference.MakeRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakeRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.MakeRequestResponse> MakeRequestAsync(PlaneClient.BalancerReference.MakeRequestRequest request);
        
        // CODEGEN: Generating message contract since element name NewRequestResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewRequest", ReplyAction="*")]
        PlaneClient.BalancerReference.NewRequestResponse NewRequest(PlaneClient.BalancerReference.NewRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewRequestResponse> NewRequestAsync(PlaneClient.BalancerReference.NewRequestRequest request);
        
        // CODEGEN: Generating message contract since element name NewPlaneResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPlane", ReplyAction="*")]
        PlaneClient.BalancerReference.NewPlaneResponse NewPlane(PlaneClient.BalancerReference.NewPlaneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPlane", ReplyAction="*")]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewPlaneResponse> NewPlaneAsync(PlaneClient.BalancerReference.NewPlaneRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakeRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakeRequest", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.MakeRequestRequestBody Body;
        
        public MakeRequestRequest() {
        }
        
        public MakeRequestRequest(PlaneClient.BalancerReference.MakeRequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakeRequestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PlaneClient.BalancerReference.Request request;
        
        public MakeRequestRequestBody() {
        }
        
        public MakeRequestRequestBody(PlaneClient.BalancerReference.Request request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakeRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakeRequestResponse", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.MakeRequestResponseBody Body;
        
        public MakeRequestResponse() {
        }
        
        public MakeRequestResponse(PlaneClient.BalancerReference.MakeRequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakeRequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PlaneClient.BalancerReference.Request MakeRequestResult;
        
        public MakeRequestResponseBody() {
        }
        
        public MakeRequestResponseBody(PlaneClient.BalancerReference.Request MakeRequestResult) {
            this.MakeRequestResult = MakeRequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewRequest", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.NewRequestRequestBody Body;
        
        public NewRequestRequest() {
        }
        
        public NewRequestRequest(PlaneClient.BalancerReference.NewRequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NewRequestRequestBody {
        
        public NewRequestRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewRequestResponse", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.NewRequestResponseBody Body;
        
        public NewRequestResponse() {
        }
        
        public NewRequestResponse(PlaneClient.BalancerReference.NewRequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewRequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PlaneClient.BalancerReference.Request NewRequestResult;
        
        public NewRequestResponseBody() {
        }
        
        public NewRequestResponseBody(PlaneClient.BalancerReference.Request NewRequestResult) {
            this.NewRequestResult = NewRequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewPlaneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewPlane", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.NewPlaneRequestBody Body;
        
        public NewPlaneRequest() {
        }
        
        public NewPlaneRequest(PlaneClient.BalancerReference.NewPlaneRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NewPlaneRequestBody {
        
        public NewPlaneRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewPlaneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewPlaneResponse", Namespace="http://tempuri.org/", Order=0)]
        public PlaneClient.BalancerReference.NewPlaneResponseBody Body;
        
        public NewPlaneResponse() {
        }
        
        public NewPlaneResponse(PlaneClient.BalancerReference.NewPlaneResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewPlaneResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PlaneClient.BalancerReference.Plane NewPlaneResult;
        
        public NewPlaneResponseBody() {
        }
        
        public NewPlaneResponseBody(PlaneClient.BalancerReference.Plane NewPlaneResult) {
            this.NewPlaneResult = NewPlaneResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BalancerServiceSoapChannel : PlaneClient.BalancerReference.BalancerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BalancerServiceSoapClient : System.ServiceModel.ClientBase<PlaneClient.BalancerReference.BalancerServiceSoap>, PlaneClient.BalancerReference.BalancerServiceSoap {
        
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
        PlaneClient.BalancerReference.MakeRequestResponse PlaneClient.BalancerReference.BalancerServiceSoap.MakeRequest(PlaneClient.BalancerReference.MakeRequestRequest request) {
            return base.Channel.MakeRequest(request);
        }
        
        public PlaneClient.BalancerReference.Request MakeRequest(PlaneClient.BalancerReference.Request request) {
            PlaneClient.BalancerReference.MakeRequestRequest inValue = new PlaneClient.BalancerReference.MakeRequestRequest();
            inValue.Body = new PlaneClient.BalancerReference.MakeRequestRequestBody();
            inValue.Body.request = request;
            PlaneClient.BalancerReference.MakeRequestResponse retVal = ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).MakeRequest(inValue);
            return retVal.Body.MakeRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.MakeRequestResponse> PlaneClient.BalancerReference.BalancerServiceSoap.MakeRequestAsync(PlaneClient.BalancerReference.MakeRequestRequest request) {
            return base.Channel.MakeRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<PlaneClient.BalancerReference.MakeRequestResponse> MakeRequestAsync(PlaneClient.BalancerReference.Request request) {
            PlaneClient.BalancerReference.MakeRequestRequest inValue = new PlaneClient.BalancerReference.MakeRequestRequest();
            inValue.Body = new PlaneClient.BalancerReference.MakeRequestRequestBody();
            inValue.Body.request = request;
            return ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).MakeRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PlaneClient.BalancerReference.NewRequestResponse PlaneClient.BalancerReference.BalancerServiceSoap.NewRequest(PlaneClient.BalancerReference.NewRequestRequest request) {
            return base.Channel.NewRequest(request);
        }
        
        public PlaneClient.BalancerReference.Request NewRequest() {
            PlaneClient.BalancerReference.NewRequestRequest inValue = new PlaneClient.BalancerReference.NewRequestRequest();
            inValue.Body = new PlaneClient.BalancerReference.NewRequestRequestBody();
            PlaneClient.BalancerReference.NewRequestResponse retVal = ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).NewRequest(inValue);
            return retVal.Body.NewRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewRequestResponse> PlaneClient.BalancerReference.BalancerServiceSoap.NewRequestAsync(PlaneClient.BalancerReference.NewRequestRequest request) {
            return base.Channel.NewRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewRequestResponse> NewRequestAsync() {
            PlaneClient.BalancerReference.NewRequestRequest inValue = new PlaneClient.BalancerReference.NewRequestRequest();
            inValue.Body = new PlaneClient.BalancerReference.NewRequestRequestBody();
            return ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).NewRequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PlaneClient.BalancerReference.NewPlaneResponse PlaneClient.BalancerReference.BalancerServiceSoap.NewPlane(PlaneClient.BalancerReference.NewPlaneRequest request) {
            return base.Channel.NewPlane(request);
        }
        
        public PlaneClient.BalancerReference.Plane NewPlane() {
            PlaneClient.BalancerReference.NewPlaneRequest inValue = new PlaneClient.BalancerReference.NewPlaneRequest();
            inValue.Body = new PlaneClient.BalancerReference.NewPlaneRequestBody();
            PlaneClient.BalancerReference.NewPlaneResponse retVal = ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).NewPlane(inValue);
            return retVal.Body.NewPlaneResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewPlaneResponse> PlaneClient.BalancerReference.BalancerServiceSoap.NewPlaneAsync(PlaneClient.BalancerReference.NewPlaneRequest request) {
            return base.Channel.NewPlaneAsync(request);
        }
        
        public System.Threading.Tasks.Task<PlaneClient.BalancerReference.NewPlaneResponse> NewPlaneAsync() {
            PlaneClient.BalancerReference.NewPlaneRequest inValue = new PlaneClient.BalancerReference.NewPlaneRequest();
            inValue.Body = new PlaneClient.BalancerReference.NewPlaneRequestBody();
            return ((PlaneClient.BalancerReference.BalancerServiceSoap)(this)).NewPlaneAsync(inValue);
        }
    }
}
