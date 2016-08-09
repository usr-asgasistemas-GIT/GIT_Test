using System;
namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    /// <summary>
    /// Entidade que identifica as propriedades do Assinante a se solicitar ao SOA, referente as pesquisas Batch.
    /// </summary>
    [Serializable]
    public class ParametroAssinanteBatch: Parametro
    {
        public string IdSolicitacao { get; set; }
        public int ItemSolicitacao { get; set; }
        public short CodigoSelecao { get; set; }
        public string CpfCnpj { get; set; }
        public string Bairro { get; set; }
        public string NomeLogradouro { get; set; }

        /// <summary>
        /// Adequa o número do protocolo para adequação ao formato do string da solicitação.
        /// Ex. Remove a barra
        /// </summary>
        /// <returns></returns>
        public int TratarNumeroProtocolo(string numeroProtocolo)
        {
            string tratado = numeroProtocolo.Replace(@"/", string.Empty).Replace(@"\", string.Empty).Replace(@":", string.Empty);
            return Convert.ToInt32(tratado);
        }

        
    }
}
