﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csharp_Client_Side_T1_Library.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.java_t2", ConfigurationName="ServiceReference1.ISlaughterHousePortType")]
    public interface ISlaughterHousePortType {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:addAnimal", ReplyAction="urn:addAnimalResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse addAnimal(Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:addAnimal", ReplyAction="urn:addAnimalResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse> addAnimalAsync(Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getTray", ReplyAction="urn:getTrayResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse getTray(Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getTray", ReplyAction="urn:getTrayResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse> getTrayAsync(Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:newPart", ReplyAction="urn:newPartResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse newPart(Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:newPart", ReplyAction="urn:newPartResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse> newPartAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getCurrentWeight", ReplyAction="urn:getCurrentWeightResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse getCurrentWeight(Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getCurrentWeight", ReplyAction="urn:getCurrentWeightResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse> getCurrentWeightAsync(Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:newOrder", ReplyAction="urn:newOrderResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse newOrder(Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:newOrder", ReplyAction="urn:newOrderResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse> newOrderAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:newTray", ReplyAction="urn:newTrayResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse newTray(Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:newTray", ReplyAction="urn:newTrayResponse")]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse> newTrayAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addAnimal", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class addAnimalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=2)]
        public float args2;
        
        public addAnimalRequest() {
        }
        
        public addAnimalRequest(string args0, string args1, float args2) {
            this.args0 = args0;
            this.args1 = args1;
            this.args2 = args2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addAnimalResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class addAnimalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public addAnimalResponse() {
        }
        
        public addAnimalResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTray", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class getTrayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        public getTrayRequest() {
        }
        
        public getTrayRequest(string args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTrayResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class getTrayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public getTrayResponse() {
        }
        
        public getTrayResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newPart", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newPartRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=3)]
        public float args3;
        
        public newPartRequest() {
        }
        
        public newPartRequest(string args0, string args1, string args2, float args3) {
            this.args0 = args0;
            this.args1 = args1;
            this.args2 = args2;
            this.args3 = args3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newPartResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newPartResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public newPartResponse() {
        }
        
        public newPartResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCurrentWeight", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class getCurrentWeightRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        public getCurrentWeightRequest() {
        }
        
        public getCurrentWeightRequest(string args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCurrentWeightResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class getCurrentWeightResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public getCurrentWeightResponse() {
        }
        
        public getCurrentWeightResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newOrder", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=2)]
        public float args2;
        
        public newOrderRequest() {
        }
        
        public newOrderRequest(string args0, string args1, float args2) {
            this.args0 = args0;
            this.args1 = args1;
            this.args2 = args2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newOrderResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public newOrderResponse() {
        }
        
        public newOrderResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newTray", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newTrayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=2)]
        public float args2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string args3;
        
        public newTrayRequest() {
        }
        
        public newTrayRequest(string args0, string args1, float args2, string args3) {
            this.args0 = args0;
            this.args1 = args1;
            this.args2 = args2;
            this.args3 = args3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="newTrayResponse", WrapperNamespace="http://service.java_t2", IsWrapped=true)]
    public partial class newTrayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.java_t2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public newTrayResponse() {
        }
        
        public newTrayResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISlaughterHousePortTypeChannel : Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SlaughterHousePortTypeClient : System.ServiceModel.ClientBase<Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType>, Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType {
        
        public SlaughterHousePortTypeClient() {
        }
        
        public SlaughterHousePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SlaughterHousePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SlaughterHousePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SlaughterHousePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.addAnimal(Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest request) {
            return base.Channel.addAnimal(request);
        }
        
        public string addAnimal(string args0, string args1, float args2) {
            Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).addAnimal(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.addAnimalAsync(Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest request) {
            return base.Channel.addAnimalAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalResponse> addAnimalAsync(string args0, string args1, float args2) {
            Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.addAnimalRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).addAnimalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.getTray(Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest request) {
            return base.Channel.getTray(request);
        }
        
        public string getTray(string args0) {
            Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest();
            inValue.args0 = args0;
            Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).getTray(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.getTrayAsync(Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest request) {
            return base.Channel.getTrayAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getTrayResponse> getTrayAsync(string args0) {
            Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.getTrayRequest();
            inValue.args0 = args0;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).getTrayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newPart(Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest request) {
            return base.Channel.newPart(request);
        }
        
        public string newPart(string args0, string args1, string args2, float args3) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            inValue.args3 = args3;
            Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newPart(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newPartAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest request) {
            return base.Channel.newPartAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newPartResponse> newPartAsync(string args0, string args1, string args2, float args3) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newPartRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            inValue.args3 = args3;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newPartAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.getCurrentWeight(Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest request) {
            return base.Channel.getCurrentWeight(request);
        }
        
        public string getCurrentWeight(string args0) {
            Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest();
            inValue.args0 = args0;
            Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).getCurrentWeight(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.getCurrentWeightAsync(Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest request) {
            return base.Channel.getCurrentWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightResponse> getCurrentWeightAsync(string args0) {
            Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.getCurrentWeightRequest();
            inValue.args0 = args0;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).getCurrentWeightAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newOrder(Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest request) {
            return base.Channel.newOrder(request);
        }
        
        public string newOrder(string args0, string args1, float args2) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newOrder(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newOrderAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest request) {
            return base.Channel.newOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newOrderResponse> newOrderAsync(string args0, string args1, float args2) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newOrderRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newTray(Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest request) {
            return base.Channel.newTray(request);
        }
        
        public string newTray(string args0, string args1, float args2, string args3) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            inValue.args3 = args3;
            Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse retVal = ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newTray(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse> Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType.newTrayAsync(Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest request) {
            return base.Channel.newTrayAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csharp_Client_Side_T1_Library.ServiceReference1.newTrayResponse> newTrayAsync(string args0, string args1, float args2, string args3) {
            Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest inValue = new Csharp_Client_Side_T1_Library.ServiceReference1.newTrayRequest();
            inValue.args0 = args0;
            inValue.args1 = args1;
            inValue.args2 = args2;
            inValue.args3 = args3;
            return ((Csharp_Client_Side_T1_Library.ServiceReference1.ISlaughterHousePortType)(this)).newTrayAsync(inValue);
        }
    }
}
