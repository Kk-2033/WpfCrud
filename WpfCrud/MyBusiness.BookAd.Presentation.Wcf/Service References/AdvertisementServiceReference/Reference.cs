﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyBusiness.BookAd.Business.Entities;

namespace MyBusiness.BookAd.Presentation.Wcf.AdvertisementServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdvertisementServiceReference.IAdvertisementService")]
    public interface IAdvertisementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdvertisementService/AddAdvertisement", ReplyAction="http://tempuri.org/IAdvertisementService/AddAdvertisementResponse")]
        void AddAdvertisement(Advertisement value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdvertisementService/AddAdvertisement", ReplyAction="http://tempuri.org/IAdvertisementService/AddAdvertisementResponse")]
        System.Threading.Tasks.Task AddAdvertisementAsync(Advertisement value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdvertisementService/GetAdvertisements", ReplyAction="http://tempuri.org/IAdvertisementService/GetAdvertisementsResponse")]
        Advertisement[] GetAdvertisements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdvertisementService/GetAdvertisements", ReplyAction="http://tempuri.org/IAdvertisementService/GetAdvertisementsResponse")]
        System.Threading.Tasks.Task<Advertisement[]> GetAdvertisementsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdvertisementServiceChannel : MyBusiness.BookAd.Presentation.Wcf.AdvertisementServiceReference.IAdvertisementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdvertisementServiceClient : System.ServiceModel.ClientBase<MyBusiness.BookAd.Presentation.Wcf.AdvertisementServiceReference.IAdvertisementService>, MyBusiness.BookAd.Presentation.Wcf.AdvertisementServiceReference.IAdvertisementService {
        
        public AdvertisementServiceClient() {
        }
        
        public AdvertisementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdvertisementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdvertisementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdvertisementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddAdvertisement(Advertisement value) {
            base.Channel.AddAdvertisement(value);
        }
        
        public System.Threading.Tasks.Task AddAdvertisementAsync(Advertisement value) {
            return base.Channel.AddAdvertisementAsync(value);
        }
        
        public Advertisement[] GetAdvertisements() {
            return base.Channel.GetAdvertisements();
        }
        
        public System.Threading.Tasks.Task<Advertisement[]> GetAdvertisementsAsync() {
            return base.Channel.GetAdvertisementsAsync();
        }
    }
}
