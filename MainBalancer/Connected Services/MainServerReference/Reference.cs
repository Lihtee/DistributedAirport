﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainBalancer.MainServerReference {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainServerReference.MainServerServiceSoap")]
    public interface MainServerServiceSoap {
        
        // CODEGEN: Generating message contract since element name NewPlaneResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPlane", ReplyAction="*")]
        MainBalancer.MainServerReference.NewPlaneResponse NewPlane(MainBalancer.MainServerReference.NewPlaneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPlane", ReplyAction="*")]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.NewPlaneResponse> NewPlaneAsync(MainBalancer.MainServerReference.NewPlaneRequest request);
        
        // CODEGEN: Generating message contract since element name plane from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeState", ReplyAction="*")]
        MainBalancer.MainServerReference.ChangeStateResponse ChangeState(MainBalancer.MainServerReference.ChangeStateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeState", ReplyAction="*")]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeStateResponse> ChangeStateAsync(MainBalancer.MainServerReference.ChangeStateRequest request);
        
        // CODEGEN: Generating message contract since element name plane from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeName", ReplyAction="*")]
        MainBalancer.MainServerReference.ChangeNameResponse ChangeName(MainBalancer.MainServerReference.ChangeNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeName", ReplyAction="*")]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeNameResponse> ChangeNameAsync(MainBalancer.MainServerReference.ChangeNameRequest request);
        
        // CODEGEN: Generating message contract since element name plane from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeType", ReplyAction="*")]
        MainBalancer.MainServerReference.ChangeTypeResponse ChangeType(MainBalancer.MainServerReference.ChangeTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeType", ReplyAction="*")]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeTypeResponse> ChangeTypeAsync(MainBalancer.MainServerReference.ChangeTypeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewPlaneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewPlane", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.NewPlaneRequestBody Body;
        
        public NewPlaneRequest() {
        }
        
        public NewPlaneRequest(MainBalancer.MainServerReference.NewPlaneRequestBody Body) {
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
        public MainBalancer.MainServerReference.NewPlaneResponseBody Body;
        
        public NewPlaneResponse() {
        }
        
        public NewPlaneResponse(MainBalancer.MainServerReference.NewPlaneResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewPlaneResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane NewPlaneResult;
        
        public NewPlaneResponseBody() {
        }
        
        public NewPlaneResponseBody(MainBalancer.MainServerReference.Plane NewPlaneResult) {
            this.NewPlaneResult = NewPlaneResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeStateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeState", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeStateRequestBody Body;
        
        public ChangeStateRequest() {
        }
        
        public ChangeStateRequest(MainBalancer.MainServerReference.ChangeStateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeStateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane plane;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int newState;
        
        public ChangeStateRequestBody() {
        }
        
        public ChangeStateRequestBody(MainBalancer.MainServerReference.Plane plane, int newState) {
            this.plane = plane;
            this.newState = newState;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeStateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeStateResponse", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeStateResponseBody Body;
        
        public ChangeStateResponse() {
        }
        
        public ChangeStateResponse(MainBalancer.MainServerReference.ChangeStateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeStateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane ChangeStateResult;
        
        public ChangeStateResponseBody() {
        }
        
        public ChangeStateResponseBody(MainBalancer.MainServerReference.Plane ChangeStateResult) {
            this.ChangeStateResult = ChangeStateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeName", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeNameRequestBody Body;
        
        public ChangeNameRequest() {
        }
        
        public ChangeNameRequest(MainBalancer.MainServerReference.ChangeNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane plane;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string newName;
        
        public ChangeNameRequestBody() {
        }
        
        public ChangeNameRequestBody(MainBalancer.MainServerReference.Plane plane, string newName) {
            this.plane = plane;
            this.newName = newName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeNameResponseBody Body;
        
        public ChangeNameResponse() {
        }
        
        public ChangeNameResponse(MainBalancer.MainServerReference.ChangeNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane ChangeNameResult;
        
        public ChangeNameResponseBody() {
        }
        
        public ChangeNameResponseBody(MainBalancer.MainServerReference.Plane ChangeNameResult) {
            this.ChangeNameResult = ChangeNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeTypeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeType", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeTypeRequestBody Body;
        
        public ChangeTypeRequest() {
        }
        
        public ChangeTypeRequest(MainBalancer.MainServerReference.ChangeTypeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeTypeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane plane;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int newType;
        
        public ChangeTypeRequestBody() {
        }
        
        public ChangeTypeRequestBody(MainBalancer.MainServerReference.Plane plane, int newType) {
            this.plane = plane;
            this.newType = newType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangeTypeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangeTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public MainBalancer.MainServerReference.ChangeTypeResponseBody Body;
        
        public ChangeTypeResponse() {
        }
        
        public ChangeTypeResponse(MainBalancer.MainServerReference.ChangeTypeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ChangeTypeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MainBalancer.MainServerReference.Plane ChangeTypeResult;
        
        public ChangeTypeResponseBody() {
        }
        
        public ChangeTypeResponseBody(MainBalancer.MainServerReference.Plane ChangeTypeResult) {
            this.ChangeTypeResult = ChangeTypeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MainServerServiceSoapChannel : MainBalancer.MainServerReference.MainServerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServerServiceSoapClient : System.ServiceModel.ClientBase<MainBalancer.MainServerReference.MainServerServiceSoap>, MainBalancer.MainServerReference.MainServerServiceSoap {
        
        public MainServerServiceSoapClient() {
        }
        
        public MainServerServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServerServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServerServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MainBalancer.MainServerReference.NewPlaneResponse MainBalancer.MainServerReference.MainServerServiceSoap.NewPlane(MainBalancer.MainServerReference.NewPlaneRequest request) {
            return base.Channel.NewPlane(request);
        }
        
        public MainBalancer.MainServerReference.Plane NewPlane() {
            MainBalancer.MainServerReference.NewPlaneRequest inValue = new MainBalancer.MainServerReference.NewPlaneRequest();
            inValue.Body = new MainBalancer.MainServerReference.NewPlaneRequestBody();
            MainBalancer.MainServerReference.NewPlaneResponse retVal = ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).NewPlane(inValue);
            return retVal.Body.NewPlaneResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.NewPlaneResponse> MainBalancer.MainServerReference.MainServerServiceSoap.NewPlaneAsync(MainBalancer.MainServerReference.NewPlaneRequest request) {
            return base.Channel.NewPlaneAsync(request);
        }
        
        public System.Threading.Tasks.Task<MainBalancer.MainServerReference.NewPlaneResponse> NewPlaneAsync() {
            MainBalancer.MainServerReference.NewPlaneRequest inValue = new MainBalancer.MainServerReference.NewPlaneRequest();
            inValue.Body = new MainBalancer.MainServerReference.NewPlaneRequestBody();
            return ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).NewPlaneAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MainBalancer.MainServerReference.ChangeStateResponse MainBalancer.MainServerReference.MainServerServiceSoap.ChangeState(MainBalancer.MainServerReference.ChangeStateRequest request) {
            return base.Channel.ChangeState(request);
        }
        
        public MainBalancer.MainServerReference.Plane ChangeState(MainBalancer.MainServerReference.Plane plane, int newState) {
            MainBalancer.MainServerReference.ChangeStateRequest inValue = new MainBalancer.MainServerReference.ChangeStateRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeStateRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newState = newState;
            MainBalancer.MainServerReference.ChangeStateResponse retVal = ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeState(inValue);
            return retVal.Body.ChangeStateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeStateResponse> MainBalancer.MainServerReference.MainServerServiceSoap.ChangeStateAsync(MainBalancer.MainServerReference.ChangeStateRequest request) {
            return base.Channel.ChangeStateAsync(request);
        }
        
        public System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeStateResponse> ChangeStateAsync(MainBalancer.MainServerReference.Plane plane, int newState) {
            MainBalancer.MainServerReference.ChangeStateRequest inValue = new MainBalancer.MainServerReference.ChangeStateRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeStateRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newState = newState;
            return ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeStateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MainBalancer.MainServerReference.ChangeNameResponse MainBalancer.MainServerReference.MainServerServiceSoap.ChangeName(MainBalancer.MainServerReference.ChangeNameRequest request) {
            return base.Channel.ChangeName(request);
        }
        
        public MainBalancer.MainServerReference.Plane ChangeName(MainBalancer.MainServerReference.Plane plane, string newName) {
            MainBalancer.MainServerReference.ChangeNameRequest inValue = new MainBalancer.MainServerReference.ChangeNameRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeNameRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newName = newName;
            MainBalancer.MainServerReference.ChangeNameResponse retVal = ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeName(inValue);
            return retVal.Body.ChangeNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeNameResponse> MainBalancer.MainServerReference.MainServerServiceSoap.ChangeNameAsync(MainBalancer.MainServerReference.ChangeNameRequest request) {
            return base.Channel.ChangeNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeNameResponse> ChangeNameAsync(MainBalancer.MainServerReference.Plane plane, string newName) {
            MainBalancer.MainServerReference.ChangeNameRequest inValue = new MainBalancer.MainServerReference.ChangeNameRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeNameRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newName = newName;
            return ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MainBalancer.MainServerReference.ChangeTypeResponse MainBalancer.MainServerReference.MainServerServiceSoap.ChangeType(MainBalancer.MainServerReference.ChangeTypeRequest request) {
            return base.Channel.ChangeType(request);
        }
        
        public MainBalancer.MainServerReference.Plane ChangeType(MainBalancer.MainServerReference.Plane plane, int newType) {
            MainBalancer.MainServerReference.ChangeTypeRequest inValue = new MainBalancer.MainServerReference.ChangeTypeRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeTypeRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newType = newType;
            MainBalancer.MainServerReference.ChangeTypeResponse retVal = ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeType(inValue);
            return retVal.Body.ChangeTypeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeTypeResponse> MainBalancer.MainServerReference.MainServerServiceSoap.ChangeTypeAsync(MainBalancer.MainServerReference.ChangeTypeRequest request) {
            return base.Channel.ChangeTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<MainBalancer.MainServerReference.ChangeTypeResponse> ChangeTypeAsync(MainBalancer.MainServerReference.Plane plane, int newType) {
            MainBalancer.MainServerReference.ChangeTypeRequest inValue = new MainBalancer.MainServerReference.ChangeTypeRequest();
            inValue.Body = new MainBalancer.MainServerReference.ChangeTypeRequestBody();
            inValue.Body.plane = plane;
            inValue.Body.newType = newType;
            return ((MainBalancer.MainServerReference.MainServerServiceSoap)(this)).ChangeTypeAsync(inValue);
        }
    }
}
