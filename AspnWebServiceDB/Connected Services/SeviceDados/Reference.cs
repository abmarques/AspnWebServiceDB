﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspnWebServiceDB.SeviceDados {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SeviceDados.ServiceDBSoap")]
    public interface ServiceDBSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDados", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDados", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDadosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceDBSoapChannel : AspnWebServiceDB.SeviceDados.ServiceDBSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDBSoapClient : System.ServiceModel.ClientBase<AspnWebServiceDB.SeviceDados.ServiceDBSoap>, AspnWebServiceDB.SeviceDados.ServiceDBSoap {
        
        public ServiceDBSoapClient() {
        }
        
        public ServiceDBSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDBSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDBSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDBSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetDados() {
            return base.Channel.GetDados();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDadosAsync() {
            return base.Channel.GetDadosAsync();
        }
    }
}