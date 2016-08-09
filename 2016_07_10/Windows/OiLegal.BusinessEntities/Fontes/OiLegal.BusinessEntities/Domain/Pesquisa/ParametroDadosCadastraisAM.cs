#region Using

using System;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    /// <summary>
    /// Parametro para pesquisa Amazonia Celular
    /// </summary>
    [Serializable]
    public class ParametroDadosCadastraisAM: Parametro
    {
        
        #region Atributos

        private string _numeroTelefone;
        private string _cpfCnpj;
        private string _enderecoTitular;
        private string _enderecoCobranca;
        private string _nomeTitular;

        #endregion

        #region Propriedades

        /// <summary>
        /// Número do telefone.
        /// </summary>
        public string NumeroTelefone
        {
            get { return _numeroTelefone; }
            set { _numeroTelefone = value; }
        }

        /// <summary>
        /// CPF ou CNPJ.
        /// </summary>
        public string CpfCnpj
        {
            get { return _cpfCnpj; }
            set { _cpfCnpj = value; }
        }

        /// <summary>
        /// Endereço do titular.
        /// </summary>
        public string EnderecoTitular
        {
            get { return _enderecoTitular; }
            set { _enderecoTitular = value; }
        }

        /// <summary>
        /// Endereço de cobrança.
        /// </summary>
        public string EnderecoCobranca
        {
            get { return _enderecoCobranca; }
            set { _enderecoCobranca = value; }
        }

        /// <summary>
        /// Nome do titular.
        /// </summary>
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        #endregion

    }
}
