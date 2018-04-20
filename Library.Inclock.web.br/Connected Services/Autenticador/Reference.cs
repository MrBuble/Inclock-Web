﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Inclock.web.br.Autenticador {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Autenticador.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logar", ReplyAction="http://tempuri.org/IService/LogarResponse")]
        Classes.VO.Funcionario Logar(string password, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Logar", ReplyAction="http://tempuri.org/IService/LogarResponse")]
        System.Threading.Tasks.Task<Classes.VO.Funcionario> LogarAsync(string password, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetLogin", ReplyAction="http://tempuri.org/IService/GetLoginResponse")]
        string GetLogin(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetLogin", ReplyAction="http://tempuri.org/IService/GetLoginResponse")]
        System.Threading.Tasks.Task<string> GetLoginAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPassword", ReplyAction="http://tempuri.org/IService/GetPasswordResponse")]
        string GetPassword(string Login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPassword", ReplyAction="http://tempuri.org/IService/GetPasswordResponse")]
        System.Threading.Tasks.Task<string> GetPasswordAsync(string Login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointDateInterval", ReplyAction="http://tempuri.org/IService/GetCheckPointDateIntervalResponse")]
        Classes.VO.Ponto[] GetCheckPointDateInterval(string InitialDate, string FinalDate, string id_funcionario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointDateInterval", ReplyAction="http://tempuri.org/IService/GetCheckPointDateIntervalResponse")]
        System.Threading.Tasks.Task<Classes.VO.Ponto[]> GetCheckPointDateIntervalAsync(string InitialDate, string FinalDate, string id_funcionario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointByDate", ReplyAction="http://tempuri.org/IService/GetCheckPointByDateResponse")]
        Classes.VO.Ponto[] GetCheckPointByDate(string InitialDate, string FinalDate, string id_funcionario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointByDate", ReplyAction="http://tempuri.org/IService/GetCheckPointByDateResponse")]
        System.Threading.Tasks.Task<Classes.VO.Ponto[]> GetCheckPointByDateAsync(string InitialDate, string FinalDate, string id_funcionario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointById", ReplyAction="http://tempuri.org/IService/GetCheckPointByIdResponse")]
        string GetCheckPointById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCheckPointById", ReplyAction="http://tempuri.org/IService/GetCheckPointByIdResponse")]
        System.Threading.Tasks.Task<string> GetCheckPointByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserById", ReplyAction="http://tempuri.org/IService/GetUserByIdResponse")]
        Classes.VO.Funcionario GetUserById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserById", ReplyAction="http://tempuri.org/IService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<Classes.VO.Funcionario> GetUserByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPoint", ReplyAction="http://tempuri.org/IService/CheckPointResponse")]
        Classes.VO.FeedBack CheckPoint(Classes.VO.Ponto ponto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckPoint", ReplyAction="http://tempuri.org/IService/CheckPointResponse")]
        System.Threading.Tasks.Task<Classes.VO.FeedBack> CheckPointAsync(Classes.VO.Ponto ponto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExpediente", ReplyAction="http://tempuri.org/IService/GetExpedienteResponse")]
        Classes.VO.Expediente[] GetExpediente(string semana, string funcionario_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExpediente", ReplyAction="http://tempuri.org/IService/GetExpedienteResponse")]
        System.Threading.Tasks.Task<Classes.VO.Expediente[]> GetExpedienteAsync(string semana, string funcionario_Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Library.Inclock.web.br.Autenticador.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Library.Inclock.web.br.Autenticador.IService>, Library.Inclock.web.br.Autenticador.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Classes.VO.Funcionario Logar(string password, string login) {
            return base.Channel.Logar(password, login);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.Funcionario> LogarAsync(string password, string login) {
            return base.Channel.LogarAsync(password, login);
        }
        
        public string GetLogin(string Email) {
            return base.Channel.GetLogin(Email);
        }
        
        public System.Threading.Tasks.Task<string> GetLoginAsync(string Email) {
            return base.Channel.GetLoginAsync(Email);
        }
        
        public string GetPassword(string Login) {
            return base.Channel.GetPassword(Login);
        }
        
        public System.Threading.Tasks.Task<string> GetPasswordAsync(string Login) {
            return base.Channel.GetPasswordAsync(Login);
        }
        
        public Classes.VO.Ponto[] GetCheckPointDateInterval(string InitialDate, string FinalDate, string id_funcionario) {
            return base.Channel.GetCheckPointDateInterval(InitialDate, FinalDate, id_funcionario);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.Ponto[]> GetCheckPointDateIntervalAsync(string InitialDate, string FinalDate, string id_funcionario) {
            return base.Channel.GetCheckPointDateIntervalAsync(InitialDate, FinalDate, id_funcionario);
        }
        
        public Classes.VO.Ponto[] GetCheckPointByDate(string InitialDate, string FinalDate, string id_funcionario) {
            return base.Channel.GetCheckPointByDate(InitialDate, FinalDate, id_funcionario);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.Ponto[]> GetCheckPointByDateAsync(string InitialDate, string FinalDate, string id_funcionario) {
            return base.Channel.GetCheckPointByDateAsync(InitialDate, FinalDate, id_funcionario);
        }
        
        public string GetCheckPointById(int id) {
            return base.Channel.GetCheckPointById(id);
        }
        
        public System.Threading.Tasks.Task<string> GetCheckPointByIdAsync(int id) {
            return base.Channel.GetCheckPointByIdAsync(id);
        }
        
        public Classes.VO.Funcionario GetUserById(string id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.Funcionario> GetUserByIdAsync(string id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public Classes.VO.FeedBack CheckPoint(Classes.VO.Ponto ponto) {
            return base.Channel.CheckPoint(ponto);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.FeedBack> CheckPointAsync(Classes.VO.Ponto ponto) {
            return base.Channel.CheckPointAsync(ponto);
        }
        
        public Classes.VO.Expediente[] GetExpediente(string semana, string funcionario_Id) {
            return base.Channel.GetExpediente(semana, funcionario_Id);
        }
        
        public System.Threading.Tasks.Task<Classes.VO.Expediente[]> GetExpedienteAsync(string semana, string funcionario_Id) {
            return base.Channel.GetExpedienteAsync(semana, funcionario_Id);
        }
    }
}
