#region Using

using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Protocolo
    {

        #region Atributos

        private string _codProtocolo;
        private long? _codOrdemSittel;
        private string _indSolicitante;
        private string _nomeOrgao;
        private DateTime? _dataCadastro;
        private Oficio _oficio;
        private DateTime? _dataHoraRecebimento;
        private bool _isReiteracao;
        private string _numReiteracao;
        private bool _isCPI;
        private bool _isPrazoJudicial;
        private Recebimentos _recebimentos;
        private Usuario.Usuario _usuario;
        private bool _isDeletado;
        private List<OficioExtraJudicial> _extraJudicialDataList;
        private List<Requisicao> _requisicoes;
        private Requerente _requerente;
        private int _idProtocolo;
        private string _pathArquivoDigitalizado;
        private DateTime? _dataRecebimentoArea;
        private string _localRecebimento;
        private DateTime? _dataFinalizado;
        private EnumStatusProtocolo _statusProtocolo;
        private List<Email> _emails;        
        private List<PermissaoProtocolo> _permissaoProtocolo;
        #endregion

        #region Propriedades

        public string CodProtocolo
        {
            get { return _codProtocolo; }
            set { _codProtocolo = value; }
        }

        public long? CodOrdemSittel
        {
            get { return _codOrdemSittel; }
            set { _codOrdemSittel = value; }
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
        
        public DateTime? DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }
        
        public Oficio Oficio
        {
            get { return _oficio; }
            set { _oficio = value; }
        }
        
        public DateTime? DataHoraRecebimento
        {
            get { return _dataHoraRecebimento; }
            set { _dataHoraRecebimento = value; }
        }
        
        public bool IsReiteracao
        {
            get { return _isReiteracao; }
            set { _isReiteracao = value; }
        }
        
        public string NumReiteracao
        {
            get { return _numReiteracao; }
            set { _numReiteracao = value; }
        }
        
        public bool IsCPI
        {
            get { return _isCPI; }
            set { _isCPI = value; }
        }        

        public bool IsPrazoJudicial
        {
            get { return _isPrazoJudicial; }
            set { _isPrazoJudicial = value; }
        }
        
        public Recebimentos Recebimentos
        {
            get { return _recebimentos; }
            set { _recebimentos = value; }
        }        
        
        public Usuario.Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        
        public bool IsDeletado
        {
            get { return _isDeletado; }
            set { _isDeletado = value; }
        }
        
        public List<OficioExtraJudicial> ExtraJudicialDataList
        {
            get { return _extraJudicialDataList; }
            set { _extraJudicialDataList = value; }
        }
       
        public List<Requisicao> Requisicoes
        {
            get { return _requisicoes; }
            set { _requisicoes = value; }
        }

        public List<Email> Emails
        {
            get { return _emails; }
            set { _emails = value; }
        }
        
        public Requerente Requerente
        {
            get { return _requerente; }
            set { _requerente = value; }
        }

        public int IdProtocolo
        {
            get { return _idProtocolo; }
            set { _idProtocolo = value; }
        }

        public string PathArquivoDigitalizado
        {
            get { return _pathArquivoDigitalizado; }
            set { _pathArquivoDigitalizado = value; }
        }

        public DateTime? DataRecebimentoArea
        {
            get { return _dataRecebimentoArea; }
            set { _dataRecebimentoArea = value; }
        }

        public string LocalRecebimento
        {
            get { return _localRecebimento; }
            set { _localRecebimento = value; }
        }

        public DateTime? DataFinalizado
        {
            get { return _dataFinalizado; }
            set { _dataFinalizado = value; }
        }

        public EnumStatusProtocolo StatusProtocolo
        {
            get { return _statusProtocolo; }
            set { _statusProtocolo = value; }
        }
      
        public List<PermissaoProtocolo> PermissaoProtocolo
        {
            get { return _permissaoProtocolo; }
            set {_permissaoProtocolo = value;}
        }

        public EnumRequisicaoAgrupada? Tipo_Solicitacao { get; set; }

        public bool ArquivoDigitalizado { get; set; }

        #endregion

        #region Construtor

            public Protocolo()
            {
                DataCadastro = DateTime.Now;
            }

        #endregion

    }
}