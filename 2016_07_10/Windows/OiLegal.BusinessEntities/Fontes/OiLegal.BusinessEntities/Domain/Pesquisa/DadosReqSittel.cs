using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class DadosReqSittel
    {

        #region atributos
        private long _codRequisicao;
        private long _codOrdemSittel;
        private long _codRequisicaoSittel;
        private string _ind_Solicitante;
        private string _alvo;
        private string _valorAlvo;
        private bool _dadosCadInterlocutores;
        private DateTime _dtRequisicao;
        private DateTime _dtInicio;
        private DateTime _dtFim;
        private EnumTipoPesquisa _tpPesquisa;
        private List<EnumTipoServico> _tpServico;
        private string _cpf;
        private string _cnpj;
        private string _nomeAssinante;
        private string _documentoAssinante;
        private string _numTerminalAssinante;
        private string _enderecoIP;
        private int _portaIP;
        private bool _usado;
        private EnumDirecao _direcao;
        private string _codListaArquivos;
        private List<string> _listaArquivos;

        #endregion

        #region Propriedades

        public long CodRequisicao
        {
            get { return _codRequisicao; }
            set { _codRequisicao = value;}
        }

        public long CodOrdemSittel
        {
            get { return _codOrdemSittel; }
            set { _codOrdemSittel = value; }
        }

        public long CodRequisicaoSittel
        {
            get { return _codRequisicaoSittel; }
            set { _codRequisicaoSittel = value; }
        }

        public string Ind_Solicitante
        {
            get { return _ind_Solicitante; }
            set { _ind_Solicitante = value; }
        }

        public string Alvo
        {
            get { return _alvo; }
            set { _alvo = value; }
        }

        public string ValorAlvo
        {
            get { return _valorAlvo; }
            set { _valorAlvo = value; }
        }

        public bool DadosCadInterlocutores
        {
            get { return _dadosCadInterlocutores; }
            set { _dadosCadInterlocutores = value; }
        }

        public DateTime DtRequisicao
        {
            get { return _dtRequisicao; }
            set { _dtRequisicao = value; }
        }

        public DateTime DtInicio
        {
            get { return _dtInicio; }
            set { _dtInicio = value; }
        }

        public DateTime DtFim
        {
            get { return _dtFim; }
            set { _dtFim = value; }
        }

        public EnumTipoPesquisa TpPesquisa
        {
            get { return _tpPesquisa; }
            set { _tpPesquisa = value; }
        }

        public List<EnumTipoServico> TpServico
        {
            get { return _tpServico; }
            set { _tpServico = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string NomeAssinante
        {
            get { return _nomeAssinante; }
            set { _nomeAssinante = value; }
        }

        public string DocumentoAssinante
        {
            get { return _documentoAssinante; }
            set { _documentoAssinante = value; }
        }

        public string NumTerminalAssinante
        {
            get { return _numTerminalAssinante; }
            set { _numTerminalAssinante = value; }
        }

        public string EnderecoIP
        {
            get { return _enderecoIP; }
            set { _enderecoIP = value; }
        }

        public int PortaIp
        {
            get { return _portaIP; }
            set { _portaIP = value; }
        }

        public bool Usado
        {
            get { return _usado; }
            set { _usado = value; }
        }

        public EnumDirecao Direcao
        {
            get { return _direcao; }
            set { _direcao = value; }
        }

        public string CodListaArquivos
        {
            get { return _codListaArquivos; }
            set { _codListaArquivos = value; }
        }

        public List<string> ListaArquivos
        {
            get { return _listaArquivos; }
            set { _listaArquivos = value; }
        }

        public EnumTipoDeRequisicao TipoRequisicao { get; set; }

        #endregion

        #region Construtor
        public DadosReqSittel()
        {
            _tpServico = new List<EnumTipoServico>();
            _listaArquivos = new List<string>();
        }

        public DadosReqSittel(int pCodReq, string pValorParam, bool pDadosAssinante, DateTime pDataRequisicao, DateTime pDataInicio, DateTime pDataFim, EnumTipoPesquisa pTpPesq, EnumTipoServico pTpServico, bool pUsado, string palvo,string pcpf,string pcnpj )
        {
            _tpServico = new List<EnumTipoServico>();
            _codRequisicao = pCodReq;
            _alvo = palvo;
            _valorAlvo = pValorParam;
            _dadosCadInterlocutores = pDadosAssinante;
            _dtRequisicao = pDataRequisicao;
            _dtInicio = pDataInicio;
            _dtFim = pDataInicio;
            _tpPesquisa = pTpPesq;
            _tpServico.Add(pTpServico);            
            _usado = pUsado;
            _cpf = pcpf;
            _cnpj = pcnpj;
        }


       
        #endregion

    }
}
