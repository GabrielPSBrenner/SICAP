﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACESSO.ADMINISTRATIVO.CPontoControle {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private System.Nullable<int> PoQtdMediaPessoasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PoQtdVerificaEquipField;
        
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
        public System.Nullable<int> PoQtdMediaPessoas {
            get {
                return this.PoQtdMediaPessoasField;
            }
            set {
                if ((this.PoQtdMediaPessoasField.Equals(value) != true)) {
                    this.PoQtdMediaPessoasField = value;
                    this.RaisePropertyChanged("PoQtdMediaPessoas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PoQtdVerificaEquip {
            get {
                return this.PoQtdVerificaEquipField;
            }
            set {
                if ((this.PoQtdVerificaEquipField.Equals(value) != true)) {
                    this.PoQtdVerificaEquipField = value;
                    this.RaisePropertyChanged("PoQtdVerificaEquip");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CPontoControle.ICPontoControle")]
    public interface ICPontoControle {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICPontoControle/ListarTodosPontosControle", ReplyAction="http://tempuri.org/ICPontoControle/ListarTodosPontosControleResponse")]
        ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE[] ListarTodosPontosControle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICPontoControle/SelecionaPKPontoControle", ReplyAction="http://tempuri.org/ICPontoControle/SelecionaPKPontoControleResponse")]
        ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICPontoControle/Incluir", ReplyAction="http://tempuri.org/ICPontoControle/IncluirResponse")]
        void Incluir(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICPontoControle/Alterar", ReplyAction="http://tempuri.org/ICPontoControle/AlterarResponse")]
        void Alterar(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICPontoControle/Excluir", ReplyAction="http://tempuri.org/ICPontoControle/ExcluirResponse")]
        void Excluir(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICPontoControleChannel : ACESSO.ADMINISTRATIVO.CPontoControle.ICPontoControle, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CPontoControleClient : System.ServiceModel.ClientBase<ACESSO.ADMINISTRATIVO.CPontoControle.ICPontoControle>, ACESSO.ADMINISTRATIVO.CPontoControle.ICPontoControle {
        
        public CPontoControleClient() {
        }
        
        public CPontoControleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CPontoControleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPontoControleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPontoControleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE[] ListarTodosPontosControle() {
            return base.Channel.ListarTodosPontosControle();
        }
        
        public ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE SelecionaPKPontoControle(int Codigo, string Tipo) {
            return base.Channel.SelecionaPKPontoControle(Codigo, Tipo);
        }
        
        public void Incluir(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE) {
            base.Channel.Incluir(oPONTOCONTROLE);
        }
        
        public void Alterar(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE) {
            base.Channel.Alterar(oPONTOCONTROLE);
        }
        
        public void Excluir(ACESSO.ADMINISTRATIVO.CPontoControle.PONTOCONTROLE oPONTOCONTROLE) {
            base.Channel.Excluir(oPONTOCONTROLE);
        }
    }
}
