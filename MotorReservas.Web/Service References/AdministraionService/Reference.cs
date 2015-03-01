﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotorReservas.Web.AdministraionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdministraionService.IAdministracion")]
    public interface IAdministracion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracion/RegistrarUsuario", ReplyAction="http://tempuri.org/IAdministracion/RegistrarUsuarioResponse")]
        bool RegistrarUsuario(MotorReservas.Entidad.Usuario pUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracion/RegistrarUsuario", ReplyAction="http://tempuri.org/IAdministracion/RegistrarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> RegistrarUsuarioAsync(MotorReservas.Entidad.Usuario pUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracion/ListarUsuarios", ReplyAction="http://tempuri.org/IAdministracion/ListarUsuariosResponse")]
        System.Collections.Generic.List<MotorReservas.Entidad.Usuario> ListarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministracion/ListarUsuarios", ReplyAction="http://tempuri.org/IAdministracion/ListarUsuariosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MotorReservas.Entidad.Usuario>> ListarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministracionChannel : MotorReservas.Web.AdministraionService.IAdministracion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministracionClient : System.ServiceModel.ClientBase<MotorReservas.Web.AdministraionService.IAdministracion>, MotorReservas.Web.AdministraionService.IAdministracion {
        
        public AdministracionClient() {
        }
        
        public AdministracionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministracionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministracionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministracionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegistrarUsuario(MotorReservas.Entidad.Usuario pUsuario) {
            return base.Channel.RegistrarUsuario(pUsuario);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrarUsuarioAsync(MotorReservas.Entidad.Usuario pUsuario) {
            return base.Channel.RegistrarUsuarioAsync(pUsuario);
        }
        
        public System.Collections.Generic.List<MotorReservas.Entidad.Usuario> ListarUsuarios() {
            return base.Channel.ListarUsuarios();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MotorReservas.Entidad.Usuario>> ListarUsuariosAsync() {
            return base.Channel.ListarUsuariosAsync();
        }
    }
}