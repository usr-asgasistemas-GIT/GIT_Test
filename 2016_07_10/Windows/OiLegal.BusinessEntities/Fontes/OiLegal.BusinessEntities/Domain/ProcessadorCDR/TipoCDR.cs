#region Using

using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.ProcessadorCDR;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.ProcessadorCDR
{
    /// <summary>
    /// Tipo do registro de CDR.
    /// </summary>
    [Serializable]
    public class TipoCDR
    {

        #region Propriedades

        /// <summary>
        /// Código do tipo de CDR.
        /// </summary>
        public int IdTipoCDR
        {
            get { return _idTipoCDR; }
            set { _idTipoCDR = value; }
        }
        private int _idTipoCDR;

        /// <summary>
        /// Descrição do tipo de CDR.
        /// </summary>
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private string _descricao;

        /// <summary>
        /// Caracter utilizado como separador do CDR.
        /// </summary>
        public char Separador
        {
            get { return _separador; }
            set { _separador = value; }
        }
        private char _separador;

        /// <summary>
        /// Campos associados ao tipo de CDR.
        /// </summary>
        public Dictionary<string, CampoCDR> Campos
        {
            get { return _campos; }
            set { _campos = value; }
        }
        private Dictionary<String, CampoCDR> _campos;

        /// <summary>
        /// Tipo de CDR.
        /// </summary>
        public EnumTipoCDR Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private EnumTipoCDR _tipo;

        public int Inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }
        private int _inicio;

        public int Tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value; }
        }
        private int _tamanho;

        public string XdrProcessor
        {
            get { return _xdrProcessor; }
            set { _xdrProcessor = value; }
        }
        private string _xdrProcessor;

        #endregion

    }
}
