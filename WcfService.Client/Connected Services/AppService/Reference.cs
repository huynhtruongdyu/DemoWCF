//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService.Client.AppService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AppService.IAppService")]
    public interface IAppService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Greeting", ReplyAction="http://tempuri.org/IAppService/GreetingResponse")]
        string Greeting(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Greeting", ReplyAction="http://tempuri.org/IAppService/GreetingResponse")]
        System.Threading.Tasks.Task<string> GreetingAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppServiceChannel : WcfService.Client.AppService.IAppService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppServiceClient : System.ServiceModel.ClientBase<WcfService.Client.AppService.IAppService>, WcfService.Client.AppService.IAppService {
        
        public AppServiceClient() {
        }
        
        public AppServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Greeting(string name) {
            return base.Channel.Greeting(name);
        }
        
        public System.Threading.Tasks.Task<string> GreetingAsync(string name) {
            return base.Channel.GreetingAsync(name);
        }
    }
}
