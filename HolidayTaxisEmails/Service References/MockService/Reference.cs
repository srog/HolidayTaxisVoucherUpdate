﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HolidayTaxisEmails.MockService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HttpStatusCode", Namespace="http://tempuri.org/")]
    public enum HttpStatusCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Continue = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SwitchingProtocols = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OK = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Created = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Accepted = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NonAuthoritativeInformation = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoContent = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ResetContent = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartialContent = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MultipleChoices = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ambiguous = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MovedPermanently = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Moved = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Found = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Redirect = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SeeOther = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RedirectMethod = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotModified = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UseProxy = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unused = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TemporaryRedirect = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RedirectKeepVerb = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BadRequest = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unauthorized = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PaymentRequired = 24,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Forbidden = 25,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotFound = 26,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MethodNotAllowed = 27,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotAcceptable = 28,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProxyAuthenticationRequired = 29,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RequestTimeout = 30,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Conflict = 31,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Gone = 32,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LengthRequired = 33,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PreconditionFailed = 34,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RequestEntityTooLarge = 35,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RequestUriTooLong = 36,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnsupportedMediaType = 37,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RequestedRangeNotSatisfiable = 38,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ExpectationFailed = 39,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UpgradeRequired = 40,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InternalServerError = 41,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotImplemented = 42,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BadGateway = 43,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceUnavailable = 44,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GatewayTimeout = 45,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HttpVersionNotSupported = 46,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MockService.MockServiceSoap")]
    public interface MockServiceSoap {
        
        // CODEGEN: Generating message contract since element name payload from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMockServiceData", ReplyAction="*")]
        HolidayTaxisEmails.MockService.GetMockServiceDataResponse GetMockServiceData(HolidayTaxisEmails.MockService.GetMockServiceDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMockServiceData", ReplyAction="*")]
        System.Threading.Tasks.Task<HolidayTaxisEmails.MockService.GetMockServiceDataResponse> GetMockServiceDataAsync(HolidayTaxisEmails.MockService.GetMockServiceDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMockServiceDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMockServiceData", Namespace="http://tempuri.org/", Order=0)]
        public HolidayTaxisEmails.MockService.GetMockServiceDataRequestBody Body;
        
        public GetMockServiceDataRequest() {
        }
        
        public GetMockServiceDataRequest(HolidayTaxisEmails.MockService.GetMockServiceDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMockServiceDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string payload;
        
        public GetMockServiceDataRequestBody() {
        }
        
        public GetMockServiceDataRequestBody(string payload) {
            this.payload = payload;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMockServiceDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMockServiceDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public HolidayTaxisEmails.MockService.GetMockServiceDataResponseBody Body;
        
        public GetMockServiceDataResponse() {
        }
        
        public GetMockServiceDataResponse(HolidayTaxisEmails.MockService.GetMockServiceDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMockServiceDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public HolidayTaxisEmails.MockService.HttpStatusCode GetMockServiceDataResult;
        
        public GetMockServiceDataResponseBody() {
        }
        
        public GetMockServiceDataResponseBody(HolidayTaxisEmails.MockService.HttpStatusCode GetMockServiceDataResult) {
            this.GetMockServiceDataResult = GetMockServiceDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MockServiceSoapChannel : HolidayTaxisEmails.MockService.MockServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MockServiceSoapClient : System.ServiceModel.ClientBase<HolidayTaxisEmails.MockService.MockServiceSoap>, HolidayTaxisEmails.MockService.MockServiceSoap {
        
        public MockServiceSoapClient() {
        }
        
        public MockServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MockServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MockServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MockServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HolidayTaxisEmails.MockService.GetMockServiceDataResponse HolidayTaxisEmails.MockService.MockServiceSoap.GetMockServiceData(HolidayTaxisEmails.MockService.GetMockServiceDataRequest request) {
            return base.Channel.GetMockServiceData(request);
        }
        
        public HolidayTaxisEmails.MockService.HttpStatusCode GetMockServiceData(string payload) {
            HolidayTaxisEmails.MockService.GetMockServiceDataRequest inValue = new HolidayTaxisEmails.MockService.GetMockServiceDataRequest();
            inValue.Body = new HolidayTaxisEmails.MockService.GetMockServiceDataRequestBody();
            inValue.Body.payload = payload;
            HolidayTaxisEmails.MockService.GetMockServiceDataResponse retVal = ((HolidayTaxisEmails.MockService.MockServiceSoap)(this)).GetMockServiceData(inValue);
            return retVal.Body.GetMockServiceDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HolidayTaxisEmails.MockService.GetMockServiceDataResponse> HolidayTaxisEmails.MockService.MockServiceSoap.GetMockServiceDataAsync(HolidayTaxisEmails.MockService.GetMockServiceDataRequest request) {
            return base.Channel.GetMockServiceDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<HolidayTaxisEmails.MockService.GetMockServiceDataResponse> GetMockServiceDataAsync(string payload) {
            HolidayTaxisEmails.MockService.GetMockServiceDataRequest inValue = new HolidayTaxisEmails.MockService.GetMockServiceDataRequest();
            inValue.Body = new HolidayTaxisEmails.MockService.GetMockServiceDataRequestBody();
            inValue.Body.payload = payload;
            return ((HolidayTaxisEmails.MockService.MockServiceSoap)(this)).GetMockServiceDataAsync(inValue);
        }
    }
}