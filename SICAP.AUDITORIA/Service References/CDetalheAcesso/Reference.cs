﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACESSO.AUDITORIA.CDetalheAcesso {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vw_Acesso", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class vw_Acesso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> APAcessoForcadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int APCodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> APCodigoCartaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int APCodigoPontoControleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> APCodigoUsuarioAcessoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> APCodigoUsuarioInterrompeAlarmeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> APCodigoUsuarioLiberaForcadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool APControlarSaidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime APDataAcessoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> APDataInterrupcaoAlarmeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> APDisparouAlarmeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string APMotivoAcessoForcadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool APNegadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string APObservacaoInterrupcaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char APTipoPontoControleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ESNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FUNOMFUNCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TeNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOESTAGIARIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOTERCEIROField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOVISITANTEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USMATFUNCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<char> USTIPOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ViNomeField;
        
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
        public System.Nullable<bool> APAcessoForcado {
            get {
                return this.APAcessoForcadoField;
            }
            set {
                if ((this.APAcessoForcadoField.Equals(value) != true)) {
                    this.APAcessoForcadoField = value;
                    this.RaisePropertyChanged("APAcessoForcado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int APCodigo {
            get {
                return this.APCodigoField;
            }
            set {
                if ((this.APCodigoField.Equals(value) != true)) {
                    this.APCodigoField = value;
                    this.RaisePropertyChanged("APCodigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> APCodigoCartao {
            get {
                return this.APCodigoCartaoField;
            }
            set {
                if ((this.APCodigoCartaoField.Equals(value) != true)) {
                    this.APCodigoCartaoField = value;
                    this.RaisePropertyChanged("APCodigoCartao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int APCodigoPontoControle {
            get {
                return this.APCodigoPontoControleField;
            }
            set {
                if ((this.APCodigoPontoControleField.Equals(value) != true)) {
                    this.APCodigoPontoControleField = value;
                    this.RaisePropertyChanged("APCodigoPontoControle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> APCodigoUsuarioAcesso {
            get {
                return this.APCodigoUsuarioAcessoField;
            }
            set {
                if ((this.APCodigoUsuarioAcessoField.Equals(value) != true)) {
                    this.APCodigoUsuarioAcessoField = value;
                    this.RaisePropertyChanged("APCodigoUsuarioAcesso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> APCodigoUsuarioInterrompeAlarme {
            get {
                return this.APCodigoUsuarioInterrompeAlarmeField;
            }
            set {
                if ((this.APCodigoUsuarioInterrompeAlarmeField.Equals(value) != true)) {
                    this.APCodigoUsuarioInterrompeAlarmeField = value;
                    this.RaisePropertyChanged("APCodigoUsuarioInterrompeAlarme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> APCodigoUsuarioLiberaForcado {
            get {
                return this.APCodigoUsuarioLiberaForcadoField;
            }
            set {
                if ((this.APCodigoUsuarioLiberaForcadoField.Equals(value) != true)) {
                    this.APCodigoUsuarioLiberaForcadoField = value;
                    this.RaisePropertyChanged("APCodigoUsuarioLiberaForcado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool APControlarSaida {
            get {
                return this.APControlarSaidaField;
            }
            set {
                if ((this.APControlarSaidaField.Equals(value) != true)) {
                    this.APControlarSaidaField = value;
                    this.RaisePropertyChanged("APControlarSaida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime APDataAcesso {
            get {
                return this.APDataAcessoField;
            }
            set {
                if ((this.APDataAcessoField.Equals(value) != true)) {
                    this.APDataAcessoField = value;
                    this.RaisePropertyChanged("APDataAcesso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> APDataInterrupcaoAlarme {
            get {
                return this.APDataInterrupcaoAlarmeField;
            }
            set {
                if ((this.APDataInterrupcaoAlarmeField.Equals(value) != true)) {
                    this.APDataInterrupcaoAlarmeField = value;
                    this.RaisePropertyChanged("APDataInterrupcaoAlarme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> APDisparouAlarme {
            get {
                return this.APDisparouAlarmeField;
            }
            set {
                if ((this.APDisparouAlarmeField.Equals(value) != true)) {
                    this.APDisparouAlarmeField = value;
                    this.RaisePropertyChanged("APDisparouAlarme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string APMotivoAcessoForcado {
            get {
                return this.APMotivoAcessoForcadoField;
            }
            set {
                if ((object.ReferenceEquals(this.APMotivoAcessoForcadoField, value) != true)) {
                    this.APMotivoAcessoForcadoField = value;
                    this.RaisePropertyChanged("APMotivoAcessoForcado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool APNegado {
            get {
                return this.APNegadoField;
            }
            set {
                if ((this.APNegadoField.Equals(value) != true)) {
                    this.APNegadoField = value;
                    this.RaisePropertyChanged("APNegado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string APObservacaoInterrupcao {
            get {
                return this.APObservacaoInterrupcaoField;
            }
            set {
                if ((object.ReferenceEquals(this.APObservacaoInterrupcaoField, value) != true)) {
                    this.APObservacaoInterrupcaoField = value;
                    this.RaisePropertyChanged("APObservacaoInterrupcao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char APTipoPontoControle {
            get {
                return this.APTipoPontoControleField;
            }
            set {
                if ((this.APTipoPontoControleField.Equals(value) != true)) {
                    this.APTipoPontoControleField = value;
                    this.RaisePropertyChanged("APTipoPontoControle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ESNome {
            get {
                return this.ESNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.ESNomeField, value) != true)) {
                    this.ESNomeField = value;
                    this.RaisePropertyChanged("ESNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FUNOMFUNC {
            get {
                return this.FUNOMFUNCField;
            }
            set {
                if ((object.ReferenceEquals(this.FUNOMFUNCField, value) != true)) {
                    this.FUNOMFUNCField = value;
                    this.RaisePropertyChanged("FUNOMFUNC");
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
        public string TeNome {
            get {
                return this.TeNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.TeNomeField, value) != true)) {
                    this.TeNomeField = value;
                    this.RaisePropertyChanged("TeNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOESTAGIARIO {
            get {
                return this.USCODIGOESTAGIARIOField;
            }
            set {
                if ((this.USCODIGOESTAGIARIOField.Equals(value) != true)) {
                    this.USCODIGOESTAGIARIOField = value;
                    this.RaisePropertyChanged("USCODIGOESTAGIARIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOTERCEIRO {
            get {
                return this.USCODIGOTERCEIROField;
            }
            set {
                if ((this.USCODIGOTERCEIROField.Equals(value) != true)) {
                    this.USCODIGOTERCEIROField = value;
                    this.RaisePropertyChanged("USCODIGOTERCEIRO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOVISITANTE {
            get {
                return this.USCODIGOVISITANTEField;
            }
            set {
                if ((this.USCODIGOVISITANTEField.Equals(value) != true)) {
                    this.USCODIGOVISITANTEField = value;
                    this.RaisePropertyChanged("USCODIGOVISITANTE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USMATFUNC {
            get {
                return this.USMATFUNCField;
            }
            set {
                if ((this.USMATFUNCField.Equals(value) != true)) {
                    this.USMATFUNCField = value;
                    this.RaisePropertyChanged("USMATFUNC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<char> USTIPO {
            get {
                return this.USTIPOField;
            }
            set {
                if ((this.USTIPOField.Equals(value) != true)) {
                    this.USTIPOField = value;
                    this.RaisePropertyChanged("USTIPO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ViNome {
            get {
                return this.ViNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.ViNomeField, value) != true)) {
                    this.ViNomeField = value;
                    this.RaisePropertyChanged("ViNome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vw_Usuario", Namespace="http://schemas.datacontract.org/2004/07/ACESSO.MODEL")]
    [System.SerializableAttribute()]
    public partial class vw_Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ESNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FUNOMFUNCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TeNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> USAdministradorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> USAuditorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool USBloqueadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int USCODIGOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOESTAGIARIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOTERCEIROField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USCODIGOVISITANTEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> USGerenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> USMATFUNCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USMotivoBloqueioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> USSegurancaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USSenhaOpcionalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char USTIPOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string USUSUARIOREDEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ViNomeField;
        
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
        public string ESNome {
            get {
                return this.ESNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.ESNomeField, value) != true)) {
                    this.ESNomeField = value;
                    this.RaisePropertyChanged("ESNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FUNOMFUNC {
            get {
                return this.FUNOMFUNCField;
            }
            set {
                if ((object.ReferenceEquals(this.FUNOMFUNCField, value) != true)) {
                    this.FUNOMFUNCField = value;
                    this.RaisePropertyChanged("FUNOMFUNC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TeNome {
            get {
                return this.TeNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.TeNomeField, value) != true)) {
                    this.TeNomeField = value;
                    this.RaisePropertyChanged("TeNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> USAdministrador {
            get {
                return this.USAdministradorField;
            }
            set {
                if ((this.USAdministradorField.Equals(value) != true)) {
                    this.USAdministradorField = value;
                    this.RaisePropertyChanged("USAdministrador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> USAuditor {
            get {
                return this.USAuditorField;
            }
            set {
                if ((this.USAuditorField.Equals(value) != true)) {
                    this.USAuditorField = value;
                    this.RaisePropertyChanged("USAuditor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool USBloqueado {
            get {
                return this.USBloqueadoField;
            }
            set {
                if ((this.USBloqueadoField.Equals(value) != true)) {
                    this.USBloqueadoField = value;
                    this.RaisePropertyChanged("USBloqueado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int USCODIGO {
            get {
                return this.USCODIGOField;
            }
            set {
                if ((this.USCODIGOField.Equals(value) != true)) {
                    this.USCODIGOField = value;
                    this.RaisePropertyChanged("USCODIGO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOESTAGIARIO {
            get {
                return this.USCODIGOESTAGIARIOField;
            }
            set {
                if ((this.USCODIGOESTAGIARIOField.Equals(value) != true)) {
                    this.USCODIGOESTAGIARIOField = value;
                    this.RaisePropertyChanged("USCODIGOESTAGIARIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOTERCEIRO {
            get {
                return this.USCODIGOTERCEIROField;
            }
            set {
                if ((this.USCODIGOTERCEIROField.Equals(value) != true)) {
                    this.USCODIGOTERCEIROField = value;
                    this.RaisePropertyChanged("USCODIGOTERCEIRO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USCODIGOVISITANTE {
            get {
                return this.USCODIGOVISITANTEField;
            }
            set {
                if ((this.USCODIGOVISITANTEField.Equals(value) != true)) {
                    this.USCODIGOVISITANTEField = value;
                    this.RaisePropertyChanged("USCODIGOVISITANTE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> USGerente {
            get {
                return this.USGerenteField;
            }
            set {
                if ((this.USGerenteField.Equals(value) != true)) {
                    this.USGerenteField = value;
                    this.RaisePropertyChanged("USGerente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> USMATFUNC {
            get {
                return this.USMATFUNCField;
            }
            set {
                if ((this.USMATFUNCField.Equals(value) != true)) {
                    this.USMATFUNCField = value;
                    this.RaisePropertyChanged("USMATFUNC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string USMotivoBloqueio {
            get {
                return this.USMotivoBloqueioField;
            }
            set {
                if ((object.ReferenceEquals(this.USMotivoBloqueioField, value) != true)) {
                    this.USMotivoBloqueioField = value;
                    this.RaisePropertyChanged("USMotivoBloqueio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> USSeguranca {
            get {
                return this.USSegurancaField;
            }
            set {
                if ((this.USSegurancaField.Equals(value) != true)) {
                    this.USSegurancaField = value;
                    this.RaisePropertyChanged("USSeguranca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string USSenhaOpcional {
            get {
                return this.USSenhaOpcionalField;
            }
            set {
                if ((object.ReferenceEquals(this.USSenhaOpcionalField, value) != true)) {
                    this.USSenhaOpcionalField = value;
                    this.RaisePropertyChanged("USSenhaOpcional");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char USTIPO {
            get {
                return this.USTIPOField;
            }
            set {
                if ((this.USTIPOField.Equals(value) != true)) {
                    this.USTIPOField = value;
                    this.RaisePropertyChanged("USTIPO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string USUSUARIOREDE {
            get {
                return this.USUSUARIOREDEField;
            }
            set {
                if ((object.ReferenceEquals(this.USUSUARIOREDEField, value) != true)) {
                    this.USUSUARIOREDEField = value;
                    this.RaisePropertyChanged("USUSUARIOREDE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ViNome {
            get {
                return this.ViNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.ViNomeField, value) != true)) {
                    this.ViNomeField = value;
                    this.RaisePropertyChanged("ViNome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CDetalheAcesso.ICDetalheAcesso")]
    public interface ICDetalheAcesso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICDetalheAcesso/oAcesso", ReplyAction="http://tempuri.org/ICDetalheAcesso/oAcessoResponse")]
        ACESSO.AUDITORIA.CDetalheAcesso.vw_Acesso oAcesso(int APCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICDetalheAcesso/oUsuario", ReplyAction="http://tempuri.org/ICDetalheAcesso/oUsuarioResponse")]
        ACESSO.AUDITORIA.CDetalheAcesso.vw_Usuario oUsuario(int UsCodigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICDetalheAcessoChannel : ACESSO.AUDITORIA.CDetalheAcesso.ICDetalheAcesso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CDetalheAcessoClient : System.ServiceModel.ClientBase<ACESSO.AUDITORIA.CDetalheAcesso.ICDetalheAcesso>, ACESSO.AUDITORIA.CDetalheAcesso.ICDetalheAcesso {
        
        public CDetalheAcessoClient() {
        }
        
        public CDetalheAcessoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CDetalheAcessoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CDetalheAcessoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CDetalheAcessoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ACESSO.AUDITORIA.CDetalheAcesso.vw_Acesso oAcesso(int APCodigo) {
            return base.Channel.oAcesso(APCodigo);
        }
        
        public ACESSO.AUDITORIA.CDetalheAcesso.vw_Usuario oUsuario(int UsCodigo) {
            return base.Channel.oUsuario(UsCodigo);
        }
    }
}
