﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guestbook_Web_Service_Tester.GuestbookServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GuestbookServiceReference.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SignGuestBook", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SignGuestBook(string userName, string userMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RetrieveGuestBookData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable RetrieveGuestBookData();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : Guestbook_Web_Service_Tester.GuestbookServiceReference.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<Guestbook_Web_Service_Tester.GuestbookServiceReference.Service1Soap>, Guestbook_Web_Service_Tester.GuestbookServiceReference.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SignGuestBook(string userName, string userMessage) {
            base.Channel.SignGuestBook(userName, userMessage);
        }
        
        public System.Data.DataTable RetrieveGuestBookData() {
            return base.Channel.RetrieveGuestBookData();
        }
    }
}
