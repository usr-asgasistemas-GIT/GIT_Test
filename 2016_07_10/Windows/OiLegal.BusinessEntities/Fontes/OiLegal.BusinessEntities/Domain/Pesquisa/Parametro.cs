#region Using

using System;
using System.Xml.Serialization;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa.NonoDigito;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;
using System.Collections.Generic;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    [XmlRoot]
    public class Parametro : IComparable<Parametro>
    {
        // #REQ#0170-001-13-1;1;10

        #region Atributos

        private string _numeroProtocolo;
        private int _idConsulta;
        private int _numeroPesquisa;
        private int _numeroParametro;
        private DateTime? _dataInicial;
        private DateTime? _dataFinal;
        private DateTime _dataPesquisa;
        private EnumTipoPesquisa _tipoPesquisa;
        private Int64 _valorParametro;
        private String _valorParametroTexto;
        private EnumTipoBusca _tipoBusca;
        private EnumTipoBusca _tipoBuscaOriginal;
        private EnumPrioridade _prioridade;
        private OcorrenciaLimitanteResultado _ocorrenciaDoLimitante;
        private int? _indicePrioridade;
        private Pesquisa _pesquisa;
        private string _ip;
        private short _status;
        private string _mensagem;
        private string _fusoHorario;
        private long _totalDeCdrs;
        private bool _emailDePesquisaConcluidaEnviado;
        private int _idUsuario;
        private EnumFlagExistenciaNonoDigito _flagNonoDigito;
        private long _totalDeCdrsGravado;
        private string _porta;
        private bool _statusSysLog;
        
        
        #endregion

        #region Propriedades

        [XmlElement("NumeroProtocolo")]
        public string NumeroProtocolo
        {
            get { return _numeroProtocolo; }
            set { _numeroProtocolo = value; }
        }

        [XmlElement("IdConsulta")]
        public int IdConsulta
        {
            get { return _idConsulta; }
            set { _idConsulta = value; }
        }

        [XmlElement("NumeroPesquisa")]
        public int NumeroPesquisa
        {
            get { return _numeroPesquisa; }
            set { _numeroPesquisa = value; }
        }

        [XmlElement("NumeroParametro")]
        public int NumeroParametro
        {
            get { return _numeroParametro; }
            set { _numeroParametro = value; }
        }

        [XmlElement(ElementName = "DataInicial", IsNullable = true)] 
        public DateTime? DataInicial
        {
            get { return _dataInicial; }
            set { _dataInicial = value; }
        }

        [XmlElement(ElementName = "DataFinal", IsNullable = true)] 
        public DateTime? DataFinal
        {
            get { return _dataFinal; }
            set { _dataFinal = value; }
        }

        [XmlElement("DataPesquisa")]
        public DateTime DataPesquisa
        {
            get { return _dataPesquisa; }
            set { _dataPesquisa = value; }
        }

        [XmlElement("TipoPesquisa")]
        public EnumTipoPesquisa TipoPesquisa
        {
            get { return _tipoPesquisa; }
            set { _tipoPesquisa = value; }
        }

        [XmlElement("ValorParametro")]
        public Int64 ValorParametro
        {
            get { return _valorParametro; }
            set { _valorParametro = value; }
        }

        [XmlElement("ValorParametroTexto")]
        public String ValorParametroTexto
        {
            get { return _valorParametroTexto; }
            set { _valorParametroTexto = value; }
        }

        [XmlElement("TipoBusca")]
        public EnumTipoBusca TipoBusca
        {
            get { return _tipoBusca; }
            set { _tipoBusca = value; }
        }

        [XmlElement("Prioridade")]
        public EnumPrioridade Prioridade
        {
            get { return _prioridade; }
            set { _prioridade = value; }
        }

        [XmlElement("OcorrenciaLimitanteResultado")]
        public OcorrenciaLimitanteResultado OcorrenciaLimitanteResultado
        {
            get { return _ocorrenciaDoLimitante; }
            set { _ocorrenciaDoLimitante = value; }
        }

        [XmlElement("Ip")]
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        [XmlElement("Status")]
        public short Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [XmlElement("Mensagem")]
        public string Mensagem
        {
            get { return _mensagem; }
            set { _mensagem = value; }
        }

        [XmlElement("FusoHorario")]
        public string FusoHorario
        {
            get { return _fusoHorario; }
            set { _fusoHorario = value; }
        }

        [XmlElement("TotalDeCdrs")]
        public long TotalDeCdrs
        {
            get { return _totalDeCdrs; }
            set { _totalDeCdrs = value; }
        }

        [XmlElement("TotalDeCdrsGravado")]
        public long TotalDeCdrsGravado
        {
            get { return _totalDeCdrsGravado; }
            set { _totalDeCdrsGravado = value; }
        }

        [XmlElement("EmailDePesquisaConcluidaEnviado")]
        public bool EmailDePesquisaConcluidaEnviado
        {
            get
            {
                return _emailDePesquisaConcluidaEnviado;
            }
            set
            {
                _emailDePesquisaConcluidaEnviado = value;
            }
        }

        [XmlElement("IdUsuario")]
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        [XmlElement("Imei")]
        public string Imei { get; set; }

        [XmlElement("Progresso")]
        public Progresso Progresso { get; set; }

        [XmlElement("CodigoDaVisao")]
        public int CodigoDaVisao { get; set; }

        [XmlElement("CGI")]
        public string CGI { get; set; }

        /// <summary>
        /// Número da prioridade definido pelo administrador.
        /// </summary>
        [XmlElement(ElementName = "IndicePrioridade", IsNullable = true)] 
        public int? IndicePrioridade
        {
            get
            {
                return _indicePrioridade;
            }
            set
            {
                _indicePrioridade = value;
            }
        }

        /// <summary>
        /// Referência para a pesquisa a qual esse parâmetro está associado.
        /// </summary>
        [XmlElement("Pesquisa")]
        public Pesquisa Pesquisa
        {
            get
            {
                return _pesquisa;
            }
            set
            {
                _pesquisa = value;
            }
        }

        /// <summary>
        /// Propriedade que armazena o valor in
        /// </summary>
        [XmlElement("FlagLimiteResultado")]
        public int FlagLimiteResultado { get; set; }

        /// <summary>
        /// Propriedade que indentifica se número é WLL ou não
        /// </summary>
        [XmlElement("EhNumeroWll")]
        public bool EhNumeroWll { get; set; }

        [XmlElement("FlagNonoDigito")]
        public EnumFlagExistenciaNonoDigito FlagNonoDigito
        {
            get { return _flagNonoDigito; }
            set { _flagNonoDigito = value; }
        }

        [XmlElement("Porta")]
        public string Porta
        {
            get { return _porta; }
            set { _porta = value; }
        }

        [XmlElement("StatusSysLog")]
        public bool StatusSysLog
        {
            get { return _statusSysLog; }
            set { _statusSysLog = value; }
        }

        [XmlElement("TipoBuscaOriginal")]
        public EnumTipoBusca TipoBuscaOriginal
        {
            get { return _tipoBuscaOriginal; }
            set { _tipoBuscaOriginal = value; }
        }

        [XmlElement("ConcatenadoMediacao")]
        public EnumCdrConcatenado? ConcatenadoMediacao { get; set; }

        [XmlElement("MensagemIPDR")]
        public string MensagemIPDR { get; set; }

        [XmlElement("Localidade")]
        public string Localidade { get; set; }

        [XmlElement("ListaArquivosSittel")]
        public List<ArquivoSittel> ListaArquivosSittel { get; set; }

        [XmlElement("OrdemSittel")]
        public int OrdemSittel { get; set; }

        [XmlElement("RequisicaoSittel")]
        public int RequisicaoSittel { get; set; }

        [XmlElement("TipoRequisicao")]
        public string TipoRequisicao { get; set; }

         [XmlElement("Ipv6")]
         public string Ipv6 { get; set; }



         [XmlElement("OrdemSittelEmail")]
         public long OrdemSittelEmail { get; set; }

         [XmlElement("RequisicaoSittelEmail")]
         public long RequisicaoSittelEmail { get; set; }

        #endregion

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (TipoPesquisa == EnumTipoPesquisa.Cpmi || TipoPesquisa == EnumTipoPesquisa.Celula)
            {
                s.Append(this.ValorParametroTexto.ToString());
                s.Append(" - ");
            }
            else
            if (TipoPesquisa == EnumTipoPesquisa.Imei)
            {
                s.Append(this.Imei.ToString());
                s.Append(" - ");
            }
            else
            {
                s.Append(this.ValorParametro.ToString());
                s.Append(" - ");
                if (TipoPesquisa == EnumTipoPesquisa.NumeroComImei)
                {
                    s.Append(this.Imei.ToString());
                    s.Append(" - ");
                }
            }
            s.Append(this.DataInicial.Value.ToString());
            s.Append(" à ");
            s.Append(this.DataFinal.Value.ToString());

            return s.ToString();
        }

        #region IComparable<Parametro> Members

        /// <summary>
        /// Realiza a comparação de prioridade com outro determinado parâmetro.
        /// </summary>
        /// <param name="other">Parâmetro que será utilizado para comparação.</param>
        /// <returns>Resultado da comparação.</returns>
        public int CompareTo(Parametro other)
        {
            if (_indicePrioridade.HasValue && other._indicePrioridade.HasValue)
            {
                return _indicePrioridade.Value.CompareTo(other._indicePrioridade.Value);
            }

            if (_prioridade != other.Prioridade)
            {
                // Ordenação direta pela prioridade.
                return (_prioridade == EnumPrioridade.Urgente) ? -1 : 1;
            }

            return _dataPesquisa.CompareTo(other._dataPesquisa);
        }

        #endregion

        public static Parametro ObterParametro(string protocolo, Pesquisa pesquisa)
        {
            return new Parametro
            {
                DataPesquisa = DateTime.Now,
                IndicePrioridade = 1,
                NumeroPesquisa = 1,
                NumeroProtocolo = protocolo,
                Pesquisa = pesquisa
            };
        }
    }
}
