﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.4952.
// 
#pragma warning disable 1591

namespace AsgaSistemas.saga.CE.OiLegal.Dispatcher.Oi.Processador.SolicitarCadastroMovel {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SolicitarRelatorioDadosCadastraisMovelSOAP", Namespace="http://alsb.telemar/wsdl/TerminalMovel/SolicitarRelatorioDadosCadastraisMovelAlsb" +
        "")]
    public partial class SolicitarRelatorioDadosCadastraisMovel : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CallSolicitarRelatorioDadosCadastraisMovelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SolicitarRelatorioDadosCadastraisMovel() {
            this.Url = global::AsgaSistemas.saga.CE.OiLegal.Dispatcher.Oi.Processador.Properties.Settings.Default.OiLegal_Dispatcher_Oi_Processador_SolicitarCadastroMovel_SolicitarRelatorioDadosCadastraisMovel;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CallSolicitarRelatorioDadosCadastraisMovelCompletedEventHandler CallSolicitarRelatorioDadosCadastraisMovelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://alsb.telemar/TerminalMovel/SolicitarRelatorioDadosCadastraisMovel", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseControl", Namespace="http://alsb.telemar/soap/esb")]
        public ResponseControlType CallSolicitarRelatorioDadosCadastraisMovel([System.Xml.Serialization.XmlElementAttribute(Namespace="http://alsb.telemar/xsd/TelefoniaMovel/SolicitarRelatorioDadosCadastraisMovelRequ" +
            "est")] SolicitarRelatorioDadosCadastraisMovelRequest SolicitarRelatorioDadosCadastraisMovelRequest) {
            object[] results = this.Invoke("CallSolicitarRelatorioDadosCadastraisMovel", new object[] {
                        SolicitarRelatorioDadosCadastraisMovelRequest});
            return ((ResponseControlType)(results[0]));
        }
        
        /// <remarks/>
        public void CallSolicitarRelatorioDadosCadastraisMovelAsync(SolicitarRelatorioDadosCadastraisMovelRequest SolicitarRelatorioDadosCadastraisMovelRequest) {
            this.CallSolicitarRelatorioDadosCadastraisMovelAsync(SolicitarRelatorioDadosCadastraisMovelRequest, null);
        }
        
        /// <remarks/>
        public void CallSolicitarRelatorioDadosCadastraisMovelAsync(SolicitarRelatorioDadosCadastraisMovelRequest SolicitarRelatorioDadosCadastraisMovelRequest, object userState) {
            if ((this.CallSolicitarRelatorioDadosCadastraisMovelOperationCompleted == null)) {
                this.CallSolicitarRelatorioDadosCadastraisMovelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallSolicitarRelatorioDadosCadastraisMovelOperationCompleted);
            }
            this.InvokeAsync("CallSolicitarRelatorioDadosCadastraisMovel", new object[] {
                        SolicitarRelatorioDadosCadastraisMovelRequest}, this.CallSolicitarRelatorioDadosCadastraisMovelOperationCompleted, userState);
        }
        
        private void OnCallSolicitarRelatorioDadosCadastraisMovelOperationCompleted(object arg) {
            if ((this.CallSolicitarRelatorioDadosCadastraisMovelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CallSolicitarRelatorioDadosCadastraisMovelCompleted(this, new CallSolicitarRelatorioDadosCadastraisMovelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alsb.telemar/xsd/TelefoniaMovel/SolicitarRelatorioDadosCadastraisMovelRequ" +
        "est")]
    public partial class SolicitarRelatorioDadosCadastraisMovelRequest {
        
        private string idSolicitacaoField;
        
        private string dataSolicitacaoField;
        
        private string idItemSolicitacaoField;
        
        private string tipoSolicitacaoField;
        
        private string msisdnField;
        
        private System.DateTime dataInicioPeridoField;
        
        private bool dataInicioPeridoFieldSpecified;
        
        private System.DateTime dataFimPeriodoField;
        
        private bool dataFimPeriodoFieldSpecified;
        
        private string cpfCnpjField;
        
        private string nomeField;
        
        private enderecoType enderecoField;
        
        /// <remarks/>
        public string idSolicitacao {
            get {
                return this.idSolicitacaoField;
            }
            set {
                this.idSolicitacaoField = value;
            }
        }
        
        /// <remarks/>
        public string dataSolicitacao {
            get {
                return this.dataSolicitacaoField;
            }
            set {
                this.dataSolicitacaoField = value;
            }
        }
        
        /// <remarks/>
        public string idItemSolicitacao {
            get {
                return this.idItemSolicitacaoField;
            }
            set {
                this.idItemSolicitacaoField = value;
            }
        }
        
        /// <remarks/>
        public string tipoSolicitacao {
            get {
                return this.tipoSolicitacaoField;
            }
            set {
                this.tipoSolicitacaoField = value;
            }
        }
        
        /// <remarks/>
        public string msisdn {
            get {
                return this.msisdnField;
            }
            set {
                this.msisdnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dataInicioPerido {
            get {
                return this.dataInicioPeridoField;
            }
            set {
                this.dataInicioPeridoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataInicioPeridoSpecified {
            get {
                return this.dataInicioPeridoFieldSpecified;
            }
            set {
                this.dataInicioPeridoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dataFimPeriodo {
            get {
                return this.dataFimPeriodoField;
            }
            set {
                this.dataFimPeriodoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataFimPeriodoSpecified {
            get {
                return this.dataFimPeriodoFieldSpecified;
            }
            set {
                this.dataFimPeriodoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string cpfCnpj {
            get {
                return this.cpfCnpjField;
            }
            set {
                this.cpfCnpjField = value;
            }
        }
        
        /// <remarks/>
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public enderecoType endereco {
            get {
                return this.enderecoField;
            }
            set {
                this.enderecoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alsb.telemar/xsd/TelefoniaMovel/SolicitarRelatorioDadosCadastraisMovelRequ" +
        "est")]
    public partial class enderecoType {
        
        private string descricaoLogradouroField;
        
        private string nomeLogradouroField;
        
        private string numeroPortaField;
        
        private string tipoComplemento1Field;
        
        private string numeroComplemento1Field;
        
        private string tipoComplemento2Field;
        
        private string numeroComplemento2Field;
        
        private string tipoComplemento3Field;
        
        private string numeroComplemento3Field;
        
        private string bairroField;
        
        private string cidadeField;
        
        private string cEPField;
        
        private string estadoField;
        
        private string nomeEstadoField;
        
        private string paisField;
        
        /// <remarks/>
        public string descricaoLogradouro {
            get {
                return this.descricaoLogradouroField;
            }
            set {
                this.descricaoLogradouroField = value;
            }
        }
        
        /// <remarks/>
        public string nomeLogradouro {
            get {
                return this.nomeLogradouroField;
            }
            set {
                this.nomeLogradouroField = value;
            }
        }
        
        /// <remarks/>
        public string numeroPorta {
            get {
                return this.numeroPortaField;
            }
            set {
                this.numeroPortaField = value;
            }
        }
        
        /// <remarks/>
        public string tipoComplemento1 {
            get {
                return this.tipoComplemento1Field;
            }
            set {
                this.tipoComplemento1Field = value;
            }
        }
        
        /// <remarks/>
        public string numeroComplemento1 {
            get {
                return this.numeroComplemento1Field;
            }
            set {
                this.numeroComplemento1Field = value;
            }
        }
        
        /// <remarks/>
        public string tipoComplemento2 {
            get {
                return this.tipoComplemento2Field;
            }
            set {
                this.tipoComplemento2Field = value;
            }
        }
        
        /// <remarks/>
        public string numeroComplemento2 {
            get {
                return this.numeroComplemento2Field;
            }
            set {
                this.numeroComplemento2Field = value;
            }
        }
        
        /// <remarks/>
        public string tipoComplemento3 {
            get {
                return this.tipoComplemento3Field;
            }
            set {
                this.tipoComplemento3Field = value;
            }
        }
        
        /// <remarks/>
        public string numeroComplemento3 {
            get {
                return this.numeroComplemento3Field;
            }
            set {
                this.numeroComplemento3Field = value;
            }
        }
        
        /// <remarks/>
        public string bairro {
            get {
                return this.bairroField;
            }
            set {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        public string cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        public string CEP {
            get {
                return this.cEPField;
            }
            set {
                this.cEPField = value;
            }
        }
        
        /// <remarks/>
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        public string nomeEstado {
            get {
                return this.nomeEstadoField;
            }
            set {
                this.nomeEstadoField = value;
            }
        }
        
        /// <remarks/>
        public string pais {
            get {
                return this.paisField;
            }
            set {
                this.paisField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alsb.telemar/soap/esb")]
    public partial class ResponseControlType {
        
        private string codeField;
        
        private string reasonField;
        
        private string detailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void CallSolicitarRelatorioDadosCadastraisMovelCompletedEventHandler(object sender, CallSolicitarRelatorioDadosCadastraisMovelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CallSolicitarRelatorioDadosCadastraisMovelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CallSolicitarRelatorioDadosCadastraisMovelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseControlType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseControlType)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591