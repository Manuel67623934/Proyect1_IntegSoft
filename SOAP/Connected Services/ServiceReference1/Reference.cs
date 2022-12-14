//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name codigo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Alumno", ReplyAction="*")]
        SOAP.ServiceReference1.AlumnoResponse Alumno(SOAP.ServiceReference1.AlumnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Alumno", ReplyAction="*")]
        System.Threading.Tasks.Task<SOAP.ServiceReference1.AlumnoResponse> AlumnoAsync(SOAP.ServiceReference1.AlumnoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AlumnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Alumno", Namespace="http://tempuri.org/", Order=0)]
        public SOAP.ServiceReference1.AlumnoRequestBody Body;
        
        public AlumnoRequest() {
        }
        
        public AlumnoRequest(SOAP.ServiceReference1.AlumnoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AlumnoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string codigo;
        
        public AlumnoRequestBody() {
        }
        
        public AlumnoRequestBody(string codigo) {
            this.codigo = codigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AlumnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AlumnoResponse", Namespace="http://tempuri.org/", Order=0)]
        public SOAP.ServiceReference1.AlumnoResponseBody Body;
        
        public AlumnoResponse() {
        }
        
        public AlumnoResponse(SOAP.ServiceReference1.AlumnoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AlumnoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AlumnoResult;
        
        public AlumnoResponseBody() {
        }
        
        public AlumnoResponseBody(string AlumnoResult) {
            this.AlumnoResult = AlumnoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : SOAP.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<SOAP.ServiceReference1.WebService1Soap>, SOAP.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SOAP.ServiceReference1.AlumnoResponse SOAP.ServiceReference1.WebService1Soap.Alumno(SOAP.ServiceReference1.AlumnoRequest request) {
            return base.Channel.Alumno(request);
        }
        
        public string Alumno(string codigo) {
            SOAP.ServiceReference1.AlumnoRequest inValue = new SOAP.ServiceReference1.AlumnoRequest();
            inValue.Body = new SOAP.ServiceReference1.AlumnoRequestBody();
            inValue.Body.codigo = codigo;
            SOAP.ServiceReference1.AlumnoResponse retVal = ((SOAP.ServiceReference1.WebService1Soap)(this)).Alumno(inValue);
            return retVal.Body.AlumnoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP.ServiceReference1.AlumnoResponse> SOAP.ServiceReference1.WebService1Soap.AlumnoAsync(SOAP.ServiceReference1.AlumnoRequest request) {
            return base.Channel.AlumnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP.ServiceReference1.AlumnoResponse> AlumnoAsync(string codigo) {
            SOAP.ServiceReference1.AlumnoRequest inValue = new SOAP.ServiceReference1.AlumnoRequest();
            inValue.Body = new SOAP.ServiceReference1.AlumnoRequestBody();
            inValue.Body.codigo = codigo;
            return ((SOAP.ServiceReference1.WebService1Soap)(this)).AlumnoAsync(inValue);
        }
    }
}
