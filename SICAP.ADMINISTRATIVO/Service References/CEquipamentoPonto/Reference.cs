﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACESSO.ADMINISTRATIVO.CEquipamentoPonto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EQUIPAMENTOPONTO", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class EQUIPAMENTOPONTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EPCodigoPontoControleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EPCodigoTipoEquipamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char EPCodigoTipoPontoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EPNumeroPortaReleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> EPObrigatorioField;
        
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
        public int EPCodigoPontoControle {
            get {
                return this.EPCodigoPontoControleField;
            }
            set {
                if ((this.EPCodigoPontoControleField.Equals(value) != true)) {
                    this.EPCodigoPontoControleField = value;
                    this.RaisePropertyChanged("EPCodigoPontoControle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EPCodigoTipoEquipamento {
            get {
                return this.EPCodigoTipoEquipamentoField;
            }
            set {
                if ((this.EPCodigoTipoEquipamentoField.Equals(value) != true)) {
                    this.EPCodigoTipoEquipamentoField = value;
                    this.RaisePropertyChanged("EPCodigoTipoEquipamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char EPCodigoTipoPonto {
            get {
                return this.EPCodigoTipoPontoField;
            }
            set {
                if ((this.EPCodigoTipoPontoField.Equals(value) != true)) {
                    this.EPCodigoTipoPontoField = value;
                    this.RaisePropertyChanged("EPCodigoTipoPonto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EPNumeroPortaRele {
            get {
                return this.EPNumeroPortaReleField;
            }
            set {
                if ((this.EPNumeroPortaReleField.Equals(value) != true)) {
                    this.EPNumeroPortaReleField = value;
                    this.RaisePropertyChanged("EPNumeroPortaRele");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> EPObrigatorio {
            get {
                return this.EPObrigatorioField;
            }
            set {
                if ((this.EPObrigatorioField.Equals(value) != true)) {
                    this.EPObrigatorioField = value;
                    this.RaisePropertyChanged("EPObrigatorio");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TIPOEQUIPAMENTO", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class TIPOEQUIPAMENTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TECodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TEDescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> TEEPIField;
        
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
        public int TECodigo {
            get {
                return this.TECodigoField;
            }
            set {
                if ((this.TECodigoField.Equals(value) != true)) {
                    this.TECodigoField = value;
                    this.RaisePropertyChanged("TECodigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TEDescricao {
            get {
                return this.TEDescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.TEDescricaoField, value) != true)) {
                    this.TEDescricaoField = value;
                    this.RaisePropertyChanged("TEDescricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> TEEPI {
            get {
                return this.TEEPIField;
            }
            set {
                if ((this.TEEPIField.Equals(value) != true)) {
                    this.TEEPIField = value;
                    this.RaisePropertyChanged("TEEPI");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vw_EquipamentoPonto", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class vw_EquipamentoPonto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EPCodigoPontoControleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EPCodigoTipoEquipamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char EPCodigoTipoPontoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EPNumeroPortaReleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> EPObrigatorioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TEDescricaoField;
        
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
        public int EPCodigoPontoControle {
            get {
                return this.EPCodigoPontoControleField;
            }
            set {
                if ((this.EPCodigoPontoControleField.Equals(value) != true)) {
                    this.EPCodigoPontoControleField = value;
                    this.RaisePropertyChanged("EPCodigoPontoControle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EPCodigoTipoEquipamento {
            get {
                return this.EPCodigoTipoEquipamentoField;
            }
            set {
                if ((this.EPCodigoTipoEquipamentoField.Equals(value) != true)) {
                    this.EPCodigoTipoEquipamentoField = value;
                    this.RaisePropertyChanged("EPCodigoTipoEquipamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char EPCodigoTipoPonto {
            get {
                return this.EPCodigoTipoPontoField;
            }
            set {
                if ((this.EPCodigoTipoPontoField.Equals(value) != true)) {
                    this.EPCodigoTipoPontoField = value;
                    this.RaisePropertyChanged("EPCodigoTipoPonto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EPNumeroPortaRele {
            get {
                return this.EPNumeroPortaReleField;
            }
            set {
                if ((this.EPNumeroPortaReleField.Equals(value) != true)) {
                    this.EPNumeroPortaReleField = value;
                    this.RaisePropertyChanged("EPNumeroPortaRele");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> EPObrigatorio {
            get {
                return this.EPObrigatorioField;
            }
            set {
                if ((this.EPObrigatorioField.Equals(value) != true)) {
                    this.EPObrigatorioField = value;
                    this.RaisePropertyChanged("EPObrigatorio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoNome {
            get {
                return this.PoNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.PoNomeField, value) != true)) {
                    this.PoNomeField = value;
                    this.RaisePropertyChanged("PoNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TEDescricao {
            get {
                return this.TEDescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.TEDescricaoField, value) != true)) {
                    this.TEDescricaoField = value;
                    this.RaisePropertyChanged("TEDescricao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PONTOCONTROLE", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class PONTOCONTROLE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoBiometriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoCartaoRFIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PoCodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoControlaSaidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoDescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoDisparaAlarmeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoObservacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoPermiteLiberacaoForcadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoSenhaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PoSmartCardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<byte> PoTentativaIndevidaDisparaAlarmeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char PoTipoField;
        
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
        public bool PoBiometria {
            get {
                return this.PoBiometriaField;
            }
            set {
                if ((this.PoBiometriaField.Equals(value) != true)) {
                    this.PoBiometriaField = value;
                    this.RaisePropertyChanged("PoBiometria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoCartaoRFID {
            get {
                return this.PoCartaoRFIDField;
            }
            set {
                if ((this.PoCartaoRFIDField.Equals(value) != true)) {
                    this.PoCartaoRFIDField = value;
                    this.RaisePropertyChanged("PoCartaoRFID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PoCodigo {
            get {
                return this.PoCodigoField;
            }
            set {
                if ((this.PoCodigoField.Equals(value) != true)) {
                    this.PoCodigoField = value;
                    this.RaisePropertyChanged("PoCodigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoControlaSaida {
            get {
                return this.PoControlaSaidaField;
            }
            set {
                if ((this.PoControlaSaidaField.Equals(value) != true)) {
                    this.PoControlaSaidaField = value;
                    this.RaisePropertyChanged("PoControlaSaida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoDescricao {
            get {
                return this.PoDescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.PoDescricaoField, value) != true)) {
                    this.PoDescricaoField = value;
                    this.RaisePropertyChanged("PoDescricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoDisparaAlarme {
            get {
                return this.PoDisparaAlarmeField;
            }
            set {
                if ((this.PoDisparaAlarmeField.Equals(value) != true)) {
                    this.PoDisparaAlarmeField = value;
                    this.RaisePropertyChanged("PoDisparaAlarme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoNome {
            get {
                return this.PoNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.PoNomeField, value) != true)) {
                    this.PoNomeField = value;
                    this.RaisePropertyChanged("PoNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoObservacao {
            get {
                return this.PoObservacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.PoObservacaoField, value) != true)) {
                    this.PoObservacaoField = value;
                    this.RaisePropertyChanged("PoObservacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoPermiteLiberacaoForcada {
            get {
                return this.PoPermiteLiberacaoForcadaField;
            }
            set {
                if ((this.PoPermiteLiberacaoForcadaField.Equals(value) != true)) {
                    this.PoPermiteLiberacaoForcadaField = value;
                    this.RaisePropertyChanged("PoPermiteLiberacaoForcada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoSenha {
            get {
                return this.PoSenhaField;
            }
            set {
                if ((this.PoSenhaField.Equals(value) != true)) {
                    this.PoSenhaField = value;
                    this.RaisePropertyChanged("PoSenha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PoSmartCard {
            get {
                return this.PoSmartCardField;
            }
            set {
                if ((this.PoSmartCardField.Equals(value) != true)) {
                    this.PoSmartCardField = value;
                    this.RaisePropertyChanged("PoSmartCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> PoTentativaIndevidaDisparaAlarme {
            get {
                return this.PoTentativaIndevidaDisparaAlarmeField;
            }
            set {
                if ((this.PoTentativaIndevidaDisparaAlarmeField.Equals(value) != true)) {
                    this.PoTentativaIndevidaDisparaAlarmeField = value;
                    this.RaisePropertyChanged("PoTentativaIndevidaDisparaAlarme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char PoTipo {
            get {
                return this.PoTipoField;
            }
            set {
                if ((this.PoTipoField.Equals(value) != true)) {
                    this.PoTipoField = value;
                    this.RaisePropertyChanged("PoTipo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CEquipamentoPonto.ICEquipamentoPonto")]
    public interface ICEquipamentoPonto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEquipamentoPonto/Incluir", ReplyAction="http://tempuri.org/ICEquipamentoPonto/IncluirResponse")]
        void Incluir(ACESSO.ADMINISTRATIVO.CEquipamentoPonto.EQUIPAMENTOPONTO oEquipamentoPonto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEquipamentoPonto/Excluir", ReplyAction="http://tempuri.org/ICEquipamentoPonto/ExcluirResponse")]
        void Excluir(int pEpCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEquipamentoPonto/ListaTipoEquipamento", ReplyAction="http://tempuri.org/ICEquipamentoPonto/ListaTipoEquipamentoResponse")]
        ACESSO.ADMINISTRATIVO.CEquipamentoPonto.TIPOEQUIPAMENTO[] ListaTipoEquipamento(int CodigoPonto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEquipamentoPonto/ListaEquipamentoPonto", ReplyAction="http://tempuri.org/ICEquipamentoPonto/ListaEquipamentoPontoResponse")]
        ACESSO.ADMINISTRATIVO.CEquipamentoPonto.vw_EquipamentoPonto[] ListaEquipamentoPonto(int CodigoPonto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEquipamentoPonto/ListaPontoControleEPI", ReplyAction="http://tempuri.org/ICEquipamentoPonto/ListaPontoControleEPIResponse")]
        ACESSO.ADMINISTRATIVO.CEquipamentoPonto.PONTOCONTROLE[] ListaPontoControleEPI();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICEquipamentoPontoChannel : ACESSO.ADMINISTRATIVO.CEquipamentoPonto.ICEquipamentoPonto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CEquipamentoPontoClient : System.ServiceModel.ClientBase<ACESSO.ADMINISTRATIVO.CEquipamentoPonto.ICEquipamentoPonto>, ACESSO.ADMINISTRATIVO.CEquipamentoPonto.ICEquipamentoPonto {
        
        public CEquipamentoPontoClient() {
        }
        
        public CEquipamentoPontoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CEquipamentoPontoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEquipamentoPontoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEquipamentoPontoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Incluir(ACESSO.ADMINISTRATIVO.CEquipamentoPonto.EQUIPAMENTOPONTO oEquipamentoPonto) {
            base.Channel.Incluir(oEquipamentoPonto);
        }
        
        public void Excluir(int pEpCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto) {
            base.Channel.Excluir(pEpCodigoPontoControle, pEPEquipamento, pEPCodigoTipoPonto);
        }
        
        public ACESSO.ADMINISTRATIVO.CEquipamentoPonto.TIPOEQUIPAMENTO[] ListaTipoEquipamento(int CodigoPonto) {
            return base.Channel.ListaTipoEquipamento(CodigoPonto);
        }
        
        public ACESSO.ADMINISTRATIVO.CEquipamentoPonto.vw_EquipamentoPonto[] ListaEquipamentoPonto(int CodigoPonto) {
            return base.Channel.ListaEquipamentoPonto(CodigoPonto);
        }
        
        public ACESSO.ADMINISTRATIVO.CEquipamentoPonto.PONTOCONTROLE[] ListaPontoControleEPI() {
            return base.Channel.ListaPontoControleEPI();
        }
    }
}
