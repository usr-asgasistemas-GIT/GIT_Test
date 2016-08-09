#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado
{

    /// <summary>
    /// Dados de assinante recuperados de arquivo de retorno Amazônia Celular.
    /// </summary>
    [Serializable]
    public class AssinanteAmazonia
    {

        #region Propriedades

        /// <summary>
        /// Código de acesso.
        /// </summary>
        public string CodigoAcesso
        {
            get
            {
                return _codigoAcesso;
            }
            set
            {
                _codigoAcesso = value;
            }
        }
        private string _codigoAcesso;

        /// <summary>
        /// Nome do assinante.
        /// </summary>
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private string _nome;

        /// <summary>
        /// Data da ativação do cadastro.
        /// </summary>
        public DateTime? DataAtivacao
        {
            get
            {
                return _dataAtivacao;
            }
            set
            {
                _dataAtivacao = value;
            }
        }
        private DateTime? _dataAtivacao;

        /// <summary>
        /// Data da expiração do cadastro.
        /// </summary>
        public DateTime? DataExpiracao
        {
            get
            {
                return _dataExpiracao;
            }
            set
            {
                _dataExpiracao = value;
            }
        }
        private DateTime? _dataExpiracao;

        #endregion

    }

}
