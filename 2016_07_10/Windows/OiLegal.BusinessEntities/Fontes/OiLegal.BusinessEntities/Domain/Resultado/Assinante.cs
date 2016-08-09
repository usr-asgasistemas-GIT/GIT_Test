#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Classe que representa um assinante relacionado a uma chamada.
    /// </summary>
    [Serializable]
    public class Assinante
    {
        public int IdSolicitacao {get; set; }
        public int ItemSolicitacao {get; set; }
        public string Nome {get; set; }
        public string DescricaoErro  {get; set; }
        public string Comentario {get; set; }
        public DateTime? DataAtivacao { get; set; }
        public DateTime? DataDesativacao { get; set; }
        public DateTime? DataInicioPeriodo  {get; set;}
        public DateTime? DataTerminoPeriodo { get; set; }
        public Enums.TipoTerminal TipoTerminal {get; set;}
        public Endereco EnderecoAssinante {get; set; }
        public string CpfCnpj { get; set; }
        public string NumeroContrato { get; set; }
        public string Ddd { get; set; }
        public string TerminalAssociado { get; set; }
        public DateTime? Dt_Inicio_Vinculo { get; set; }
        public DateTime? Dt_Fim_Vinculo { get; set; }
        public DateTime? Dt_Retorno { get; set; }
        public string TipoTerminalSittel { get; set; }
        public string TerminalRelatorio { get; set; }

        #region Propriedades obsoletas, mantidas para compatibilidade até alterar o código
        
        /// <summary>
        /// Código do assinante.
        /// </summary>
        [Obsolete]
        public string CodigoAssinante
        {
            get { return _codigoAssinante; }
            set { _codigoAssinante = value; }
        }
        [Obsolete]
        private string _codigoAssinante;

        /// <summary>
        /// Código do IMEI.
        /// </summary>
        [Obsolete]
        public string IMEI
        {
            get { return _imei; }
            set { _imei = value; }
        }
        [Obsolete]
        private string _imei;

        [Obsolete]
        public string OiChip
        {
            get { return _oichip; }
            set { _oichip = value; }
        }
        [Obsolete]
        private string _oichip;

        /// <summary>
        /// Número do terminal.
        /// </summary>
        public string NumeroTerminal
        {
            get { return _numeroTerminal; }
            set { _numeroTerminal = value; }
        }
        private string _numeroTerminal;

        /// <summary>
        /// Número do documento.
        /// </summary>
        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }
        private string _numeroDocumento;

        /// <summary>
        /// Tipo do documento.
        /// </summary>
        [Obsolete]
        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        [Obsolete]
        private string _tipoDocumento;

        /// <summary>
        /// Endereço do assinante.
        /// </summary>
        [Obsolete]
        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        [Obsolete]
        private Endereco _endereco;

        /// <summary>
        /// Endereço de cobrança.
        /// </summary>
        public Endereco EnderecoCobranca
        {
            get { return _enderecoCobranca; }
            set { _enderecoCobranca = value; }
        }
        private Endereco _enderecoCobranca;

        /// <summary>
        /// Data de início.
        /// </summary>
        [Obsolete]
        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { _dataInicio = value; }
        }
        [Obsolete]
        private DateTime _dataInicio;

        /// <summary>
        /// Data de fim.
        /// </summary>
        [Obsolete]
        public DateTime DataFim
        {
            get { return _dataFim; }
            set { _dataFim = value; }
        }
        [Obsolete]
        private DateTime _dataFim;
        #endregion
    }

    [Serializable]
    public class AssinanteFixa : Assinante
    {
        
       
        
    }

    [Serializable]
    public class AssinanteMovel : Assinante
    {
        [Obsolete("É utilizado agora a propriedade número terminal da classe base.")]
        public string Msisdn { get; set; }
        public string  Imsi { get; set; }
        [Obsolete("É utilizado somente a propriedade endereço de cobrança da classe base.")]
        public Endereco EnderecoContato { get; set; }
      
    }
}
