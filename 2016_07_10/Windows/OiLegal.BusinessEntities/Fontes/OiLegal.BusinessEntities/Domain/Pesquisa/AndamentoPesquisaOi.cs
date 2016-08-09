using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class AndamentoPesquisaOi
    {

        #region Atributos

        private DateTime _data;
        private DateTime? _dataFinal;
        private DateTime? _dataFinalCdr;
        private string _protocolo;
        private short _porcentagem;
        private int _idConsulta;
        private int _numeroPesquisa;
        private string _statusProtocolo;
        private string _imagemUrl;
        private string _dadosAssinantes;
        private bool _canDownload;
        private EnumStatusPesquisa _statusPesquisa;
        private List<Parametro> _parametros;
        private EnumTipoAtendimento _tipoAtendimento;
        private bool _enviaPesqAutomaticamente;
        private bool _requisicaoSittel;
        private bool _podeEnviar;
        private EnumStatusEnvioSittel _statusPesqSittel;

        #endregion

        #region Propriedades

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public DateTime? DataFinal
        {
            get { return _dataFinal; }
            set { _dataFinal = value; }
        }

        public DateTime? DataFinalCdr
        {
            get { return _dataFinalCdr; }
            set { _dataFinalCdr = value; }
        }

        public string Protocolo
        {
            get { return _protocolo; }
            set { _protocolo = value; }
        }

        public short Porcentagem
        {
            get { return _porcentagem; }
            set { _porcentagem = value; }
        }

        public string Passo { get; set; }

        public int IdConsulta
        {
            get { return _idConsulta; }
            set { _idConsulta = value; }
        }

        public int NumeroPesquisa
        {
            get { return _numeroPesquisa; }
            set { _numeroPesquisa = value; }
        }

        public string StatusProtocolo
        {
            get { return _statusProtocolo; }
            set { _statusProtocolo = value; }
        }

        public string ImagemUrl
        {
            get { return _imagemUrl; }
            set { _imagemUrl = value; }
        }

        public bool CanDownload
        {
            get { return _canDownload; }
            set { _canDownload = value; }
        }

        public EnumStatusPesquisa StatusPesquisa
        {
            get { return _statusPesquisa; }
            set { _statusPesquisa = value; }
        }

        public List<Parametro> Parametros
        {
            get { return _parametros; }
            set
            {
                _parametros = value;
            }
        }

        public string DadosAssinantes
        {
            get { return _dadosAssinantes; }
            set { _dadosAssinantes = value; }
        }

        public bool TemDadosDeAssinante { get; set; }

        public EnumTipoBusca TipoDaBusca { get; set; }
        
        public EnumTipoAtendimento TipoAtendimento
        {
            get { return _tipoAtendimento; }
            set { _tipoAtendimento = value; }
        }

        public bool RequisicaoSittel
        {
            get { return _requisicaoSittel; }
            set { _requisicaoSittel = value; }
        }

        public bool EnviaPesqAutomaticamente
        {
            get { return _enviaPesqAutomaticamente; }
            set { _enviaPesqAutomaticamente = value; }
        }

        public bool PodeEnviar
        {
            get { return _podeEnviar; }
            set { _podeEnviar = value; }
        }

        public EnumStatusEnvioSittel StatusPesqSittel
        {
            get { return _statusPesqSittel; }
            set { _statusPesqSittel = value; }
        }

        public int Cod_Requisicao { get; set; }
        
        #endregion

    }
}
