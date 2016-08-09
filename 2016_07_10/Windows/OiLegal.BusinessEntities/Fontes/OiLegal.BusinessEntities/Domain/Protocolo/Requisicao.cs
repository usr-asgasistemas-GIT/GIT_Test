#region Using

using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Usuario.Grupo;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Protocolo
{
    [Serializable]
    public class Requisicao
    {

        #region Atributos
        
        private int _cod_Requisicao;
        private string _cod_Protocolo;
        private TipoRequisicao _tipoRequisicao;
        private StatusRequisicaoType _status;
        private Grupo _grupo;
        private DateTime _dataRequisicao;
        private string _prazo;
        private DateTime _dataPrazo;
        private DateTime _dataResposta;
        private string _observacao;
        private List<Usuario.Usuario> _usuarios;
        private DateTime _novaDataPrazo;
        private bool? _prazoJudicial;
        private List<string> _numTerminal;
        private List<string> _numImei;
        private DateTime _dataRecebimentoOi;
        private DateTime _dataRecebimentoArea;
        private DateTime _dataCadastro;
        private List<Email> _emails;
        private long? _cod_RequisicaoSittel;
        private int _tipoBaixa;
        private DateTime _dataBaixa;
        private long? _codOrdemSittel;
        private string _indSolicitante;
        private string _versao;
        private string _tipoInvestigado;
        private string _investigado;
        private string _operacaoPolicial;
        private string _cpf;
        private string _cnpj;
        private string _docAssinante;
        private string _nomeAssinante;        
        private string _terminalAssinante;
        private string _imei;
        private string _cgiErb;
        private string _enderecoErb;
        private string _latitude;
        private string _longitude;
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private string _enderecoIP;
        private int _portaIP;
        private int _tipoServico;
        private int _tipoPesquisa;
        private string _direcao;
        private int _dadosCadInterloc;
        private int _listaArquivos;
        private string _observacaoSittel;
        private string _statusSittel;
        private int _codErro;
        private string _descricaoErro;
        private int _codTipoRejeicao;
        private DateTime _dataRecebimento;
        private DateTime _dataConclusao;        
        private int _idUsuario;
        private string _justificativa_rejeicao;
        private DateTime _dataRejeicao;
        private string _tipoConteudo;
        private string _alvo;
        private string _valorAlvo;
        private string _tipoInterceptacao;
        private int _duracaoInterceptacao;
        private string _desvioConteudo;
        private string _desvioConteudoValor;
        private int _autorizacaoAdicional;
        private string _autorizacaoAdicionalValor;
        private int _tipoRequisicaoAgrupada;
        private DateTime _dataRecepcaoRecibo;
        private DuracaoInterceptacao _duracaoInterceptacaoClass;
        private List<string> _arquivos;

        #endregion

        #region Propriedades

        public int Cod_Requisicao
        {
            get { return _cod_Requisicao; }
            set { _cod_Requisicao = value; }
        }

        public string Cod_Protocolo
        {
            get { return _cod_Protocolo; }
            set { _cod_Protocolo = value; }
        }
        
        public TipoRequisicao TipoRequisicao
        {
            get { return _tipoRequisicao; }
            set { _tipoRequisicao = value; }
        }

        public StatusRequisicaoType Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Grupo Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        public DateTime DataRequisicao
        {
            get { return _dataRequisicao; }
            set { _dataRequisicao = value; }
        }

        public string Prazo
        {
            get { return _prazo; }
            set { _prazo = value; }
        }

        public DateTime DataPrazo
        {
            get { return _dataPrazo; }
            set { _dataPrazo = value; }
        }

        public DateTime DataResposta
        {
            get { return _dataResposta; }
            set { _dataResposta = value; }
        }

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public List<Usuario.Usuario> Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        public DateTime NovaDataPrazo
        {
            get { return _novaDataPrazo; }
            set { _novaDataPrazo = value; }
        }
        public bool? PrazoJudicial
        {
            get { return _prazoJudicial; }
            set { _prazoJudicial = value; }
        }

        public List<string> NumTerminal
        {
            get { return _numTerminal; }
            set { _numTerminal = value; }
        }

        public List<string> NumImei
        {
            get { return _numImei; }
            set { _numImei = value; }
        }

        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        public DateTime DataRecebimentoArea
        {
            get { return _dataRecebimentoArea; }
            set { _dataRecebimentoArea = value; }
        }

        public DateTime DataRecebimentoOi
        {
            get { return _dataRecebimentoOi; }
            set { _dataRecebimentoOi = value; }
        }

        public bool EstahAssociada { get; set; }

        public List<Email> Emails
        {
            get { return _emails; }
            set { _emails = value; }
        }

        public long? CodRequisicaoSittel
        {
            get { return _cod_RequisicaoSittel; }
            set { _cod_RequisicaoSittel = value; }
        }

        public int TipoBaixa
        {
            get { return _tipoBaixa; }
            set { _tipoBaixa = value; }
        }

        public DateTime DataBaixa
        {
            get { return _dataBaixa; }
            set { _dataBaixa = value; }
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

        public string Versao
        {
            get { return _versao; }
            set { _versao = value; }
        }

        public string TipoInvestigado
        {
            get { return _tipoInvestigado; }
            set { _tipoInvestigado = value; }
        }

        public string Investigado
        {
            get { return _investigado; }
            set { _investigado = value; }
        }

        public string OperacaoPolicial
        {
            get { return _operacaoPolicial; }
            set { _operacaoPolicial = value; }
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

        public string DocAssinante
        {
            get { return _docAssinante; }
            set { _docAssinante = value; }
        }

        public string NomeAssinante
        {
            get { return _nomeAssinante; }
            set { _nomeAssinante = value; }
        }

        public string TerminalAssinante
        {
            get { return _terminalAssinante; }
            set { _terminalAssinante = value; }
        }

        public string Imei
        {
            get { return _imei; }
            set { _imei = value; }
        }

        public string CgiErb
        {
            get { return _cgiErb; }
            set { _cgiErb = value; }
        }

        public string EnderecoErb
        {
            get { return _enderecoErb; }
            set { _enderecoErb = value; }
        }

        public string Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        public string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }

        public string EnderecoIP
        {
            get { return _enderecoIP; }
            set { _enderecoIP = value; }
        }

        public int PortaIP
        {
            get { return _portaIP; }
            set { _portaIP = value; }
        }

        public int TipoServico
        {
            get { return _tipoServico; }
            set { _tipoServico = value; }
        }

        public int TipoPesquisa
        {
            get { return _tipoPesquisa; }
            set { _tipoPesquisa = value; }
        }

        public string Direcao
        {
            get { return _direcao; }
            set { _direcao = value; }
        }

        public int DadosCadInterloc
        {
            get { return _dadosCadInterloc; }
            set { _dadosCadInterloc = value; }
        }

        public int ListaArquivos
        {
            get { return _listaArquivos; }
            set { _listaArquivos = value; }
        }

        public string Observacao_Sittel
        {
            get { return _observacaoSittel; }
            set { _observacaoSittel = value; }
        }

        public string Status_Sittel
        {
            get { return _statusSittel; }
            set { _statusSittel = value; }
        }

        public int CodErro
        {
            get { return _codErro; }
            set { _codErro = value; }
        }

        public string DescricaoErro
        {
            get { return _descricaoErro; }
            set { _descricaoErro = value; }
        }

        public int CodTipoRejeicao
        {
            get { return _codTipoRejeicao; }
            set { _codTipoRejeicao = value; }
        }

        public DateTime DataRecebimento
        {
            get { return _dataRecebimento; }
            set { _dataRecebimento = value; }
        }

        public DateTime DataConclusao
        {
            get { return _dataConclusao; }
            set { _dataConclusao = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string JustificativaRejeicao
        {
            get { return _justificativa_rejeicao; }
            set { _justificativa_rejeicao = value; }
        }

        public DateTime DataRejeicao
        {
            get { return _dataRejeicao; }
            set { _dataRejeicao = value; }
        }

        public string TipoConteudo
        {
            get { return _tipoConteudo; }
            set { _tipoConteudo = value; }
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

        public string TipoInterceptacao
        {
            get { return _tipoInterceptacao; }
            set { _tipoInterceptacao = value; }
        }

        public int DuracaoInterceptacao
        {
            get { return _duracaoInterceptacao; }
            set { _duracaoInterceptacao = value; }
        }

        public string DesvioConteudo
        {
            get { return _desvioConteudo; }
            set { _desvioConteudo = value; }
        }

        public string DesvioConteudoValor
        {
            get { return _desvioConteudoValor; }
            set { _desvioConteudoValor = value; }
        }

        public int AutorizacaoAdicional
        {
            get { return _autorizacaoAdicional; }
            set { _autorizacaoAdicional = value; }
        }

        public string AutorizacaoAdicionalValor
        {
            get { return _autorizacaoAdicionalValor; }
            set { _autorizacaoAdicionalValor = value; }
        }

        public int TipoRequisicaoAgrupada
        {
            get { return _tipoRequisicaoAgrupada; }
            set { _tipoRequisicaoAgrupada = value; }
        }

        public DateTime DataRecepcaoRecibo
        {
            get { return _dataRecepcaoRecibo; }
            set { _dataRecepcaoRecibo = value; }
        }

        public TipoRequisicao TipoRequisicaoOutras { get; set; } 

        public Domain.Protocolo.DuracaoInterceptacao DuracaoInterceptacaoClass 
        {
            get
            {
                if (this._duracaoInterceptacaoClass == null)
                    this._duracaoInterceptacaoClass = new Domain.Protocolo.DuracaoInterceptacao();
                return this._duracaoInterceptacaoClass;
            }
            set { this._duracaoInterceptacaoClass = value; }
        }

        public int? Usado { get; set; }

        /// <summary>
        /// Lista dos nomes de arquivos adicionados à requisição.
        /// </summary>
        public List<string> Arquivos
        {
            get
            {
                if (this._arquivos == null)
                    this._arquivos = new List<string>();
                return this._arquivos;
            }
            set { this._arquivos = value; }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append("Tipo Requisição : " + TipoRequisicao.Descricao);
            s.Append(" - ");

            s.Append("Data Requisição : " + DataRequisicao);
            s.Append(" - ");

            s.Append("Prazo : " + Prazo);
            s.Append(" - ");

            s.Append("Data Prazo : " + DataPrazo);

            
            if (Usuarios != null && Usuarios.Count >0 )
            {
                foreach (Usuario.Usuario usuario in Usuarios)
                {
                    s.Append(" - ");
                    s.Append("Usuário : " + usuario.Nome);
                }
            }
            else if (Grupo != null)
            {
                s.Append(" - ");
                s.Append("Grupo Usuário : " + Grupo.CodGrupo);
            }

            return s.ToString();
        }

        #region Construtor

        public Requisicao()
        {
            Status = StatusRequisicaoType.Aberto;
        }

        #endregion

    }
}