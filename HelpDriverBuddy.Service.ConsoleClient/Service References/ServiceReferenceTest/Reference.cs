﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDriverBuddy.Service.ConsoleClient.ServiceReferenceTest {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceTest.IHelpDriverBuddyService")]
    public interface IHelpDriverBuddyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelpDriverBuddyService/GetVehicleProblems", ReplyAction="http://tempuri.org/IHelpDriverBuddyService/GetVehicleProblemsResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] GetVehicleProblems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelpDriverBuddyService/GetVehicleProblems", ReplyAction="http://tempuri.org/IHelpDriverBuddyService/GetVehicleProblemsResponse")]
        System.Threading.Tasks.Task<object[]> GetVehicleProblemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelpDriverBuddyService/AddProblem", ReplyAction="http://tempuri.org/IHelpDriverBuddyService/AddProblemResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void AddProblem(object infomation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelpDriverBuddyService/AddProblem", ReplyAction="http://tempuri.org/IHelpDriverBuddyService/AddProblemResponse")]
        System.Threading.Tasks.Task AddProblemAsync(object infomation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelpDriverBuddyServiceChannel : HelpDriverBuddy.Service.ConsoleClient.ServiceReferenceTest.IHelpDriverBuddyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelpDriverBuddyServiceClient : System.ServiceModel.ClientBase<HelpDriverBuddy.Service.ConsoleClient.ServiceReferenceTest.IHelpDriverBuddyService>, HelpDriverBuddy.Service.ConsoleClient.ServiceReferenceTest.IHelpDriverBuddyService {
        
        public HelpDriverBuddyServiceClient() {
        }
        
        public HelpDriverBuddyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelpDriverBuddyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelpDriverBuddyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelpDriverBuddyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object[] GetVehicleProblems() {
            return base.Channel.GetVehicleProblems();
        }
        
        public System.Threading.Tasks.Task<object[]> GetVehicleProblemsAsync() {
            return base.Channel.GetVehicleProblemsAsync();
        }
        
        public void AddProblem(object infomation) {
            base.Channel.AddProblem(infomation);
        }
        
        public System.Threading.Tasks.Task AddProblemAsync(object infomation) {
            return base.Channel.AddProblemAsync(infomation);
        }
    }
}
