﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.SupServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SupServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPrice", ReplyAction="*")]
        double getPrice(int itemId, int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<double> getPriceAsync(int itemId, int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateQuantity", ReplyAction="*")]
        void updateQuantity(int itemId, int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateQuantity", ReplyAction="*")]
        System.Threading.Tasks.Task updateQuantityAsync(int itemId, int qty);
        
        // CODEGEN: Generating message contract since element name des from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        WebApplication2.SupServiceReference1.placeOrderResponse placeOrder(WebApplication2.SupServiceReference1.placeOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.SupServiceReference1.placeOrderResponse> placeOrderAsync(WebApplication2.SupServiceReference1.placeOrderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class placeOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="placeOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.SupServiceReference1.placeOrderRequestBody Body;
        
        public placeOrderRequest() {
        }
        
        public placeOrderRequest(WebApplication2.SupServiceReference1.placeOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class placeOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string des;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string cus;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string add;
        
        public placeOrderRequestBody() {
        }
        
        public placeOrderRequestBody(string des, string cus, string add) {
            this.des = des;
            this.cus = cus;
            this.add = add;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class placeOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="placeOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.SupServiceReference1.placeOrderResponseBody Body;
        
        public placeOrderResponse() {
        }
        
        public placeOrderResponse(WebApplication2.SupServiceReference1.placeOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class placeOrderResponseBody {
        
        public placeOrderResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WebApplication2.SupServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication2.SupServiceReference1.WebServiceSoap>, WebApplication2.SupServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double getPrice(int itemId, int qty) {
            return base.Channel.getPrice(itemId, qty);
        }
        
        public System.Threading.Tasks.Task<double> getPriceAsync(int itemId, int qty) {
            return base.Channel.getPriceAsync(itemId, qty);
        }
        
        public void updateQuantity(int itemId, int qty) {
            base.Channel.updateQuantity(itemId, qty);
        }
        
        public System.Threading.Tasks.Task updateQuantityAsync(int itemId, int qty) {
            return base.Channel.updateQuantityAsync(itemId, qty);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.SupServiceReference1.placeOrderResponse WebApplication2.SupServiceReference1.WebServiceSoap.placeOrder(WebApplication2.SupServiceReference1.placeOrderRequest request) {
            return base.Channel.placeOrder(request);
        }
        
        public void placeOrder(string des, string cus, string add) {
            WebApplication2.SupServiceReference1.placeOrderRequest inValue = new WebApplication2.SupServiceReference1.placeOrderRequest();
            inValue.Body = new WebApplication2.SupServiceReference1.placeOrderRequestBody();
            inValue.Body.des = des;
            inValue.Body.cus = cus;
            inValue.Body.add = add;
            WebApplication2.SupServiceReference1.placeOrderResponse retVal = ((WebApplication2.SupServiceReference1.WebServiceSoap)(this)).placeOrder(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.SupServiceReference1.placeOrderResponse> WebApplication2.SupServiceReference1.WebServiceSoap.placeOrderAsync(WebApplication2.SupServiceReference1.placeOrderRequest request) {
            return base.Channel.placeOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.SupServiceReference1.placeOrderResponse> placeOrderAsync(string des, string cus, string add) {
            WebApplication2.SupServiceReference1.placeOrderRequest inValue = new WebApplication2.SupServiceReference1.placeOrderRequest();
            inValue.Body = new WebApplication2.SupServiceReference1.placeOrderRequestBody();
            inValue.Body.des = des;
            inValue.Body.cus = cus;
            inValue.Body.add = add;
            return ((WebApplication2.SupServiceReference1.WebServiceSoap)(this)).placeOrderAsync(inValue);
        }
    }
}