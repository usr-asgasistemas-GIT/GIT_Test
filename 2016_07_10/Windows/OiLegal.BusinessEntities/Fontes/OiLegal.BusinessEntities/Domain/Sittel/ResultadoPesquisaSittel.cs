using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Sittel
{
    [Serializable]
    public class ResultadoPesquisaSittel 
    {
        #region Atributos
        private bool _enviado;
        private string _codProtocolo;
        private string _numPesquisa;
        private string _numOrdemSittel;
        private string _indSolicitante;
        private string _nomeOrgao;
        private string _codRequisicaoSittel;
        private string _tipoResultado;
        private string _tipoRequisicao;
        private string _alvoValor;
        private string _endInstalacao;
        private string _dadosAssiInterlocutor;
        private string _periodo;
        private EnumStatusEnvioSittel _statusPesqSittel;
        private ResultadoRequisicao _resultadoRequisicao;

        #endregion

        #region Propriedades

        public bool Enviado
        {
            get { return _enviado; }
            set { _enviado = value; }
        }

        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public string NumPesquisa
        {
            get { return _numPesquisa; }
            set { _numPesquisa = value; }
        }

        public string NumOrdemSittel
        {
            get { return _numOrdemSittel; }
            set { _numOrdemSittel = value; }
        }

        public string IndSolicitante
        {
            get { return _indSolicitante; }
            set { _indSolicitante = value; }
        }

        public string NomeOrgao
        {
            get { return _nomeOrgao; }
            set { _nomeOrgao = value; }
        }

        public string CodRequisicaoSittel
        {
            get { return _codRequisicaoSittel; }
            set { _codRequisicaoSittel = value; }
        }

        public string TipoResultado
        {
            get { return _tipoResultado; }
            set { _tipoResultado = value; }
        }

        public string TipoRequisicao
        {
            get { return _tipoRequisicao; }
            set { _tipoRequisicao = value; }
        }

        public string AlvoValor
        {
            get { return _alvoValor; }
            set { _alvoValor = value; }
        }

        public string EndInstalacao
        {
            get { return _endInstalacao; }
            set { _endInstalacao = value; }
        }

        public string DadosAssiInterlocutor
        {
            get { return _dadosAssiInterlocutor; }
            set { _dadosAssiInterlocutor = value; }
        }

        public string Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        public EnumStatusEnvioSittel StatusPesqSittel
        {
            get { return _statusPesqSittel; }
            set { _statusPesqSittel = value; }
        }

        public ResultadoRequisicao ResultadoRequisicao
        {
            get { return _resultadoRequisicao; }
            set { _resultadoRequisicao = value; }
        }

        public byte[] Anexo {get;set;}

        #endregion

        #region Construtor

        public ResultadoPesquisaSittel() { }

        public ResultadoPesquisaSittel(string pCodProtocolo, string pNumPesquisa, string pNumOrdemSittel, string pIndSolicitante, string pNomeOrgao, string pCodRequisicaoSittel, string pTipoResultado, string pTipoRequisicao, string pAlvo, string pEndInstalacao, string pDadosAssiInterlocutor, string pPeriodo, EnumStatusEnvioSittel pstatusEnvio)
        {
            _codProtocolo = pCodProtocolo;
            _numPesquisa = pNumPesquisa;
            _numOrdemSittel = pNumOrdemSittel;
            _indSolicitante = pIndSolicitante;
            _nomeOrgao = pNomeOrgao;
            _codRequisicaoSittel = pCodRequisicaoSittel;
            _tipoResultado = pTipoResultado;
            _tipoRequisicao = pTipoRequisicao;
            _alvoValor = pAlvo;
            _endInstalacao = pEndInstalacao;
            _dadosAssiInterlocutor = pDadosAssiInterlocutor;
            _periodo = pPeriodo;
            _statusPesqSittel = pstatusEnvio;
        }


        public ResultadoPesquisaSittel(string pCodProtocolo, string pNumPesquisa, string pNumOrdemSittel, string pIndSolicitante, string pNomeOrgao, string pCodRequisicaoSittel, string pTipoResultado, string pTipoRequisicao, string pAlvo, string pEndInstalacao, string pDadosAssiInterlocutor, string pPeriodo, ResultadoRequisicao pResultadoRequisicao, EnumStatusEnvioSittel pstatusEnvio)
        {
            _codProtocolo = pCodProtocolo;
            _numPesquisa = pNumPesquisa;
            _numOrdemSittel = pNumOrdemSittel;
            _indSolicitante = pIndSolicitante;
            _nomeOrgao = pNomeOrgao;
            _codRequisicaoSittel = pCodRequisicaoSittel;
            _tipoResultado = pTipoResultado;
            _tipoRequisicao = pTipoRequisicao;
            _alvoValor = pAlvo;
            _endInstalacao = pEndInstalacao;
            _dadosAssiInterlocutor = pDadosAssiInterlocutor;
            _periodo = pPeriodo;
            _resultadoRequisicao = pResultadoRequisicao;
            _statusPesqSittel = pstatusEnvio;
        }

        

        #endregion

        public string getCodProtocolo()
        {
            return _codProtocolo;
        }



    }
}
