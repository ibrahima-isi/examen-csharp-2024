﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSharedMemory.ServiceMetier {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MetierSharedMemory")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Encadreur", Namespace="http://schemas.datacontract.org/2004/07/MetierSharedMemory.Model")]
    [System.SerializableAttribute()]
    public partial class Encadreur : AppSharedMemory.ServiceMetier.Personne {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialiteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialite {
            get {
                return this.SpecialiteField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialiteField, value) != true)) {
                    this.SpecialiteField = value;
                    this.RaisePropertyChanged("Specialite");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Personne", Namespace="http://schemas.datacontract.org/2004/07/MetierSharedMemory.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AppSharedMemory.ServiceMetier.Encadreur))]
    public partial class Personne : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPersonneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPersonne {
            get {
                return this.IdPersonneField;
            }
            set {
                if ((this.IdPersonneField.Equals(value) != true)) {
                    this.IdPersonneField = value;
                    this.RaisePropertyChanged("IdPersonne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMetier.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        AppSharedMemory.ServiceMetier.CompositeType GetDataUsingDataContract(AppSharedMemory.ServiceMetier.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.CompositeType> GetDataUsingDataContractAsync(AppSharedMemory.ServiceMetier.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEncadreurs", ReplyAction="http://tempuri.org/IService1/GetEncadreursResponse")]
        AppSharedMemory.ServiceMetier.Encadreur[] GetEncadreurs(string Nom, string Prenom, string Specialite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEncadreurs", ReplyAction="http://tempuri.org/IService1/GetEncadreursResponse")]
        System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur[]> GetEncadreursAsync(string Nom, string Prenom, string Specialite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEncadreur", ReplyAction="http://tempuri.org/IService1/GetEncadreurResponse")]
        AppSharedMemory.ServiceMetier.Encadreur GetEncadreur(System.Nullable<int> IdEncadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEncadreur", ReplyAction="http://tempuri.org/IService1/GetEncadreurResponse")]
        System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur> GetEncadreurAsync(System.Nullable<int> IdEncadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEncadreur", ReplyAction="http://tempuri.org/IService1/DeleteEncadreurResponse")]
        bool DeleteEncadreur(System.Nullable<int> IdEncadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEncadreur", ReplyAction="http://tempuri.org/IService1/DeleteEncadreurResponse")]
        System.Threading.Tasks.Task<bool> DeleteEncadreurAsync(System.Nullable<int> IdEncadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEncadreur", ReplyAction="http://tempuri.org/IService1/UpdateEncadreurResponse")]
        bool UpdateEncadreur(AppSharedMemory.ServiceMetier.Encadreur encadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEncadreur", ReplyAction="http://tempuri.org/IService1/UpdateEncadreurResponse")]
        System.Threading.Tasks.Task<bool> UpdateEncadreurAsync(AppSharedMemory.ServiceMetier.Encadreur encadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEncadreur", ReplyAction="http://tempuri.org/IService1/AddEncadreurResponse")]
        bool AddEncadreur(AppSharedMemory.ServiceMetier.Encadreur encadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEncadreur", ReplyAction="http://tempuri.org/IService1/AddEncadreurResponse")]
        System.Threading.Tasks.Task<bool> AddEncadreurAsync(AppSharedMemory.ServiceMetier.Encadreur encadreur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEncadreur", ReplyAction="http://tempuri.org/IService1/GetAllEncadreurResponse")]
        AppSharedMemory.ServiceMetier.Encadreur[] GetAllEncadreur();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEncadreur", ReplyAction="http://tempuri.org/IService1/GetAllEncadreurResponse")]
        System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur[]> GetAllEncadreurAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AppSharedMemory.ServiceMetier.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AppSharedMemory.ServiceMetier.IService1>, AppSharedMemory.ServiceMetier.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public AppSharedMemory.ServiceMetier.CompositeType GetDataUsingDataContract(AppSharedMemory.ServiceMetier.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.CompositeType> GetDataUsingDataContractAsync(AppSharedMemory.ServiceMetier.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public AppSharedMemory.ServiceMetier.Encadreur[] GetEncadreurs(string Nom, string Prenom, string Specialite) {
            return base.Channel.GetEncadreurs(Nom, Prenom, Specialite);
        }
        
        public System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur[]> GetEncadreursAsync(string Nom, string Prenom, string Specialite) {
            return base.Channel.GetEncadreursAsync(Nom, Prenom, Specialite);
        }
        
        public AppSharedMemory.ServiceMetier.Encadreur GetEncadreur(System.Nullable<int> IdEncadreur) {
            return base.Channel.GetEncadreur(IdEncadreur);
        }
        
        public System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur> GetEncadreurAsync(System.Nullable<int> IdEncadreur) {
            return base.Channel.GetEncadreurAsync(IdEncadreur);
        }
        
        public bool DeleteEncadreur(System.Nullable<int> IdEncadreur) {
            return base.Channel.DeleteEncadreur(IdEncadreur);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEncadreurAsync(System.Nullable<int> IdEncadreur) {
            return base.Channel.DeleteEncadreurAsync(IdEncadreur);
        }
        
        public bool UpdateEncadreur(AppSharedMemory.ServiceMetier.Encadreur encadreur) {
            return base.Channel.UpdateEncadreur(encadreur);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEncadreurAsync(AppSharedMemory.ServiceMetier.Encadreur encadreur) {
            return base.Channel.UpdateEncadreurAsync(encadreur);
        }
        
        public bool AddEncadreur(AppSharedMemory.ServiceMetier.Encadreur encadreur) {
            return base.Channel.AddEncadreur(encadreur);
        }
        
        public System.Threading.Tasks.Task<bool> AddEncadreurAsync(AppSharedMemory.ServiceMetier.Encadreur encadreur) {
            return base.Channel.AddEncadreurAsync(encadreur);
        }
        
        public AppSharedMemory.ServiceMetier.Encadreur[] GetAllEncadreur() {
            return base.Channel.GetAllEncadreur();
        }
        
        public System.Threading.Tasks.Task<AppSharedMemory.ServiceMetier.Encadreur[]> GetAllEncadreurAsync() {
            return base.Channel.GetAllEncadreurAsync();
        }
    }
}
