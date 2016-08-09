#region using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    [XmlRoot]
    public class Pesquisa : IEquatable<Pesquisa>
    {

        #region Atributos

        private int _numeroPesquisa;
        private List<Parametro> _parametros;
        private List<ParametroAssinanteFixaBatch> _parametroAssinanteFixaBatch;
        private List<ParametroAssinanteMovelBatch> _parametroAssinanteMovelBatch;
        private IList<ParametroIp> _parametroIp;
        private List<ParametroIp> _parametroIpList;
        private IList<ParametroTerminais> _parametroTerminais;
        private List<ParametroTerminais> _parametroTerminaisList;
        private EnumPrioridade _prioridade;
        private EnumTipoResultado _resultado;
        private EnumDirecao _direcao;
        private EnumTipoAtendimento _tipoAtendimento;
        private bool _compactado;
        private bool _enderecoInstalacao;
        private bool _enderecoCobranca;
        private bool _dadosAssinante;
        private bool _enderecoInstalacaoAlvo;
        private bool _enderecoCobrancaAlvo;
        private bool _dadosAssinanteAlvo;
        private bool _enviaPesqAutomaticamente;
        private EnumTipoBusca _tipoBusca;
        private EnumTipoPesquisa _tipoPesquisa;
        private int _intIdTecnologiaCDR;
        private short _status;
        private DateTime? _dataFinalizado;
        private DateTime? _dataConsulta;
        private DateTime? _dataFimCdr;
        private int _resultadoParcial;
        private bool _resultadoOnline;
        private int _cod_requisicao;
        private bool _requisicaoSittel;
        private int _idUsuario;
        private List<EnumTipoBusca> _listaTipoBusca;
        private EnumStatusEnvioSittel _statusPesqSittel;


        #endregion

        #region Propriedades

        /// <summary>
        /// Número do protocolo.
        /// </summary>
        [XmlElement("NumeroProtocolo")]
        public string NumeroProtocolo
        {
            get
            {
                return _numeroProtocolo;
            }
            set
            {
                _numeroProtocolo = value;
            }
        }

        [XmlElement("_numeroProtocolo")]
        private string _numeroProtocolo;

        /// <summary>
        /// Código da consulta.
        /// </summary>
        public int IdConsulta
        {
            get
            {
                return _idConsulta;
            }
            set
            {
                _idConsulta = value;
            }
        }
        private int _idConsulta;

        /// <summary>
        /// Número da pesquisa.
        /// </summary>

        [XmlElement("NumeroPesquisa")]
        public int NumeroPesquisa
        {
            get { return _numeroPesquisa; }
            set { _numeroPesquisa = value; }
        }

        [XmlElement(ElementName = "DataFinalizado", IsNullable = true)] 
        public DateTime? DataFinalizado
        {
            get { return _dataFinalizado; }
            set { _dataFinalizado = value; }
        }

        [XmlElement(ElementName = "DataFimCdr", IsNullable = true)] 
        public DateTime? DataFimCdr
        {
            get { return _dataFimCdr; }
            set { _dataFimCdr = value; }
        }

      
        [XmlElement(ElementName = "DataConsulta", IsNullable = true)] 
        public DateTime? DataConsulta
        {
            get { return _dataConsulta; }
            set { _dataConsulta = value; }
        }

        [XmlIgnore]
        public List<Parametro> Parametros
        {
            get { return _parametros; }
            set
            {
                _parametros = value;
                if (_parametros != null)
                {
                    foreach (Parametro parametro in _parametros)
                    {
                        parametro.Pesquisa = this;
                    }
                }
            }
        }

        [XmlElement("ParametroAssinanteFixaBatch")]
        public List<ParametroAssinanteFixaBatch> ParametroAssinanteFixaBatch
        {
            get { return _parametroAssinanteFixaBatch; }
            set { _parametroAssinanteFixaBatch = value; }
        }

        [XmlElement("ParametroAssinanteMovelBatch")]
        public List<ParametroAssinanteMovelBatch> ParametroAssinanteMovelBatch
        {
            get { return _parametroAssinanteMovelBatch; }
            set { _parametroAssinanteMovelBatch = value; }
        }

        [XmlIgnore]
        public IList<ParametroIp> ParametroIp
        {
            get { return _parametroIp; }
            set { _parametroIp = value; }
        }

        [XmlElement("ParametroIp")]
        public List<ParametroIp> ParametroIpList
        {
            get { return _parametroIpList; }
            set { _parametroIpList = value; }
        }



        [XmlIgnore]
        public IList<ParametroTerminais> ParametroTerminais
        {
            get { return _parametroTerminais; }
            set { _parametroTerminais = value; }
        }

        [XmlElement("ParametroTerminais")]
        public List<ParametroTerminais> ParametroTerminaisList
        {
            get { return _parametroTerminaisList; }
            set { _parametroTerminaisList = value; }
        }

        [XmlElement("Prioridade")]
        public EnumPrioridade Prioridade
        {
            get { return _prioridade; }
            set { _prioridade = value; }
        }

        [XmlElement("Resultado")]
        public EnumTipoResultado Resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        [XmlElement("TipoAtendimento")]
        public EnumTipoAtendimento TipoAtendimento
        {
            get { return _tipoAtendimento; }
            set { _tipoAtendimento = value; }
        }

        [XmlElement("Direcao")]
        public EnumDirecao Direcao
        {
            get { return _direcao; }
            set { _direcao = value; }
        }

        [XmlElement("Compactado")]
        public bool Compactado
        {
            get { return _compactado; }
            set { _compactado = value; }
        }

        [XmlElement("EnderecoInstalacao")]
        public bool EnderecoInstalacao
        {
            get { return _enderecoInstalacao; }
            set { _enderecoInstalacao = value; }
        }

        [XmlElement("EnderecoCobranca")]
        public bool EnderecoCobranca
        {
            get { return _enderecoCobranca; }
            set { _enderecoCobranca = value; }
        }

        [XmlElement("DadosAssinante")]
        public bool DadosAssinante
        {
            get { return _dadosAssinante; }
            set { _dadosAssinante = value; }
        }

        [XmlElement("EnderecoInstalacaoAlvo")]
        public bool EnderecoInstalacaoAlvo
        {
            get { return _enderecoInstalacaoAlvo; }
            set { _enderecoInstalacaoAlvo = value; }
        }

        [XmlElement("EnderecoCobrancaAlvo")]
        public bool EnderecoCobrancaAlvo
        {
            get { return _enderecoCobrancaAlvo; }
            set { _enderecoCobrancaAlvo = value; }
        }

        [XmlElement("DadosAssinanteAlvo")]
        public bool DadosAssinanteAlvo
        {
            get { return _dadosAssinanteAlvo; }
            set { _dadosAssinanteAlvo = value; }
        }

        [XmlElement("EnviaPesqAutomaticamente")]
        public bool EnviaPesqAutomaticamente
        {
            get { return _enviaPesqAutomaticamente; }
            set { _enviaPesqAutomaticamente = value; }
        }

        [XmlIgnore]
        public EnumTipoBusca TipoBusca
        {
            get { return _tipoBusca; }
            set { _tipoBusca = value; }
        }

        [XmlIgnore]
        public EnumTipoPesquisa TipoPesquisa
        {
            get { return _tipoPesquisa; }
            set { _tipoPesquisa = value; }
        }

        [XmlElement("IDTecnologiaCDR")]
        public int IDTecnologiaCDR
        {
            get { return _intIdTecnologiaCDR; }
            set { _intIdTecnologiaCDR = value; }
        }

        [XmlElement("Status")]
        public short Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [XmlElement("ResultadoOnline")]
        public bool ResultadoOnline
        {
            get { return _resultadoOnline; }
            set { _resultadoOnline = value; }
        }

        public static string GetDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        [XmlElement("Cod_Requisicao")]
        public int Cod_Requisicao
        {
            get { return _cod_requisicao; }
            set { _cod_requisicao = value; }
        }

        [XmlIgnore]
        public bool RequisicaoSittel
        {
            get { return _requisicaoSittel; }
            set { _requisicaoSittel = value; }
        }

        [XmlElement("IdUsuario")]
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        [XmlIgnore]
        public int ResultadoParcial
        {
            get { return _resultadoParcial; }
            set { _resultadoParcial = value; }
        }

        [XmlIgnore]
        public List<EnumTipoBusca> ListaTipoBusca
        {
            get { return _listaTipoBusca; }
            set { _listaTipoBusca = value; }
        }

        [XmlIgnore]
        public EnumStatusEnvioSittel StatusPesqSittel
        {
            get { return _statusPesqSittel; }
            set { _statusPesqSittel = value; }
        }

        [XmlIgnore]
        public List<ArquivoSittel> ListaArquivosSittel { get; set; }

        [XmlIgnore]
        public bool DadosInterlocutorImei { get; set; } 

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(this.NumeroPesquisa.ToString());
            s.Append(" - ");
            if (this.TipoBusca == EnumTipoBusca.CadastralAmazonia)
            {
                s.Append("Amazônia");
                //s.Append(" - ");
                //s.Append();
            }
            else
            {
                s.Append(GetDescription(this.TipoBusca));
                if ((TipoBusca != EnumTipoBusca.IP) && (TipoBusca != EnumTipoBusca.CadastralFixa) &&
                    (TipoBusca != EnumTipoBusca.CadastralMovel))
                {
                    var enumPassadoParaRetornarDescricao = ((Parametro)(_parametros.ToArray().GetValue(0))).TipoPesquisa;
                    //Caso o tipo de pesquisa não seja 0, complementa descrição do mesmo.
                    if ((int)enumPassadoParaRetornarDescricao != 0)
                    {
                        s.Append(" - ");
                        s.Append(GetDescription(enumPassadoParaRetornarDescricao));
                    }
                }
            }

            return s.ToString();
        }

        #endregion

        #region Equals

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Pesquisa))
            {
                Pesquisa other = (Pesquisa)obj;
                return Equals(other);
            }
            return base.Equals(obj);
        }

        public bool Equals(Pesquisa pesquisa)
        {
            return (this.NumeroProtocolo == pesquisa.NumeroProtocolo && this.NumeroPesquisa == pesquisa.NumeroPesquisa);
        }

        #endregion

    }
}