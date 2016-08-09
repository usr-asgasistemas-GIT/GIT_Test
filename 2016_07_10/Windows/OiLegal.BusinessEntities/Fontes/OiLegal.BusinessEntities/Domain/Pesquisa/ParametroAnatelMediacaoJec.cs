using System;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ParametroAnatelMediacaoJec : Parametro
    {
        #region Atributos

        private String _assinanteA;
        private String _assinanteB;
        private String _assinanteC;
        private String _assinanteAPortado;
        private String _assinanteBPortado;
        private int? _assinantesComum;
        private String _imsi;
        private String _celulaErb;
        private String _cidadeCelulaErb;
        private String _gtt;
        private String _causeTermination;
        private String _rotaEntrada;
        private String _rotaSaida;
        private String _tipoCdr;
        private String _cnlA;
        private String _eotA;
        private String _eotB;
        private String _causeTerm;
        private String _apn;
        private String _tipoAcesso;
        private String _parceiro;
        private String _tipoUso;
        private String _central;
        private String _uf;
        private String _parteTarifada;
        private String _csp;
        private String _fds;
        private String _categoria;
        private String _flagPortabilidade;
        private String _classeCdrs;
        private int? _ddd;
        private String _localidade;
        private int? _apresentarTerminalDestino;
        private int? _tipoRelatorio;
        private int? _pesquisaPorN8;

        #endregion

        #region Propriedades

        public String AssinanteA
        {
            get { return _assinanteA; }
            set { _assinanteA = value; }
        }
        public String AssinanteB
        {
            get { return _assinanteB; }
            set { _assinanteB = value; }
        }
        public String AssinanteC
        {
            get { return _assinanteC; }
            set { _assinanteC = value; }
        }
        public String AssinanteAPortado
        {
            get { return _assinanteAPortado; }
            set { _assinanteAPortado = value; }
        }
        public String AssinanteBPortado
        {
            get { return _assinanteBPortado; }
            set { _assinanteBPortado = value; }
        }
        public int? AssinantesComum
        {
            get { return _assinantesComum; }
            set { _assinantesComum = value; }
        }
        public String Imsi
        {
            get { return _imsi; }
            set { _imsi = value; }
        }
        public String CelulaErb
        {
            get { return _celulaErb; }
            set { _celulaErb = value; }
        }
        public String CidadeCelulaErb
        {
            get { return _cidadeCelulaErb; }
            set { _cidadeCelulaErb = value; }
        }
        public String Gtt
        {
            get { return _gtt; }
            set { _gtt = value; }
        }
        public String CauseTermination
        {
            get { return _causeTermination; }
            set { _causeTermination = value; }
        }
        public String RotaEntrada
        {
            get { return _rotaEntrada; }
            set { _rotaEntrada = value; }
        }
        public String RotaSaida
        {
            get { return _rotaSaida; }
            set { _rotaSaida = value; }
        }
        public String TipoCdr
        {
            get { return _tipoCdr; }
            set { _tipoCdr = value; }
        }
        public String CnlA
        {
            get { return _cnlA; }
            set { _cnlA = value; }
        }
        public String EotA
        {
            get { return _eotA; }
            set { _eotA = value; }
        }
        public String EotB
        {
            get { return _eotB; }
            set { _eotB = value; }
        }
        public String CauseTerm
        {
            get { return _causeTerm; }
            set { _causeTerm = value; }
        }
        public String Apn
        {
            get { return _apn; }
            set { _apn = value; }
        }
        public String TipoAcesso
        {
            get { return _tipoAcesso; }
            set { _tipoAcesso = value; }
        }
        public String Parceiro
        {
            get { return _parceiro; }
            set { _parceiro = value; }
        }
        public String TipoUso
        {
            get { return _tipoUso; }
            set { _tipoUso = value; }
        }
        public String Central
        {
            get { return _central; }
            set { _central = value; }
        }
        public String Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }
        public String ParteTarifada
        {
            get { return _parteTarifada; }
            set { _parteTarifada = value; }
        }
        public String Csp
        {
            get { return _csp; }
            set { _csp = value; }
        }
        public String Fds
        {
            get { return _fds; }
            set { _fds = value; }
        }
        public String Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public String FlagPortabilidade
        {
            get { return _flagPortabilidade; }
            set { _flagPortabilidade = value; }
        }
        public String ClasseCdrs
        {
            get { return _classeCdrs; }
            set { _classeCdrs = value; }
        }
        public int? Ddd
        {
            get { return _ddd; }
            set { _ddd = value; }
        }
        public String Localidade
        {
            get { return _localidade; }
            set { _localidade = value; }
        }
        public int? ApresentarTerminalDestino
        {
            get { return _apresentarTerminalDestino; }
            set { _apresentarTerminalDestino = value; }
        }
        public int? TipoRelatorio
        {
            get { return _tipoRelatorio; }
            set { _tipoRelatorio = value; }
        }
        public int? PesquisaPorN8
        {
            get { return _pesquisaPorN8; }
            set { _pesquisaPorN8 = value; }
        }

        public string Produto { get; set; }
        public string IpDoCliente { get; set; }
        public string TipoDoLog { get; set; }
        public string IpNas { get; set; }
        public string NumeroDoCircuito { get; set; }
        public string NomeUsuario { get; set; }
        public string OcorrenciaDoFaturamento { get; set; }
        public string CodigoDaEstacao { get; set; }
        public string TerminalDeOrigem { get; set; }
        public string CodigoDoProvedor { get; set; }
        public string IdentificaoDaSessao { get; set; }
        public string StatusDoFaturamento { get; set; }
        #endregion
    }
}
