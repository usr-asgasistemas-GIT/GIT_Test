#region Using

using System;
using System.Text;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{
    [Serializable]
    public class ResultadoPesquisa
    {

        #region Propriedades
        
        /// <summary>
        /// Tamanho do arquivo anexo
        /// </summary>
        public int TamanhoArquivo
        {
            get { return _tamanhoArquivo; }
            set { _tamanhoArquivo = value; }
        }
        private int _tamanhoArquivo = int.MinValue;

        /// <summary>
        /// Tipo do arquivo anexo
        /// </summary>
        public string Extensao
        {
            get { return _extensao; }
            set { _extensao = value; }
        }
        private string _extensao;

        /// <summary>
        /// Nome do arquivo anexo
        /// </summary>
        public string NomeArquivo
        {
            get { return _nomeArquivo; }
            set { _nomeArquivo = value; }
        }
        private string _nomeArquivo;

        /// <summary>
        /// Caminho do Arquivo
        /// </summary>
        public string CaminhoArquivo { get; set; }

        /// <summary>
        /// Código da consulta.
        /// </summary>
        public int IdConsulta
        {
            get { return _idConsulta; }
            set { _idConsulta = value; }
        }
        private int _idConsulta;

        /// <summary>
        /// Número da pesquisa.
        /// </summary>
        public int NumeroPesquisa
        {
            get { return _numeroPesquisa; }
            set { _numeroPesquisa = value; }
        }
        private int _numeroPesquisa;

        /// <summary>
        /// Número do parâmetro.
        /// </summary>
        public int NumeroParametro
        {
            get { return _numeroParametro; }
            set { _numeroParametro = value; }
        }
        private int _numeroParametro;

        /// <summary>
        /// Tipo do CDR.
        /// </summary>
        public int IdTipoCDR
        {
            get { return _idTipoCDR; }
            set { _idTipoCDR = value; }
        }
        private int _idTipoCDR;

        /// <summary>
        /// Tipo da busca.
        /// </summary>
        public EnumTipoBusca TipoBusca
        {
            get { return tipoBusca; }
            set { tipoBusca = value; }
        }
        private EnumTipoBusca tipoBusca;

        /// <summary>
        /// Tipo de tecnologia do CDR.
        /// </summary>
        public EnumTecnologiaCDR? TecnologiaCDR
        {
            get
            {
                return _tecnologiaCDR;
            }
            set
            {
                _tecnologiaCDR = value;
            }
        }
        private EnumTecnologiaCDR? _tecnologiaCDR;

        /// <summary>
        /// Parametro ao qual o resultado se refere.
        /// </summary>
        public Parametro Parametro
        {
            get
            {
                return _parametro;
            }
            set
            {
                _parametro = value;
            }
        }
        private Parametro _parametro;

        public int TotalDeCdrsGravado { get; set; }
        public int TotalDeCdrsReal { get; set; }


        #endregion

        #region Métodos

        /// <summary>
        /// Implementacao de ToString para a classe AnexoBE
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("[ AnexoBE  \n");
            sBuilder.Append("\t_nomeArquivo: " + (_nomeArquivo == null ? "null" : _nomeArquivo.ToString()) + " \n");
            sBuilder.Append("\t_extensao: " + (_extensao == null ? "null" : _extensao.ToString()) + " \n");
            sBuilder.Append("\t_tamanhoArquivo: " + (_tamanhoArquivo == long.MinValue ? "long.MinValue" : _tamanhoArquivo.ToString()) + " \n");
            sBuilder.Append("] \n");
            return sBuilder.ToString();
        }
        #endregion
        
    }
}
