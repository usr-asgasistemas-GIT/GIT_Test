using System;
namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{

    /// <summary>
    /// Classe especifica para pesquisas do tipo GPRS.
    /// </summary>
    [Serializable]
    public class ParametroGPRS : Parametro
    {

        /// <summary>
        /// Endereço IP. 999.999.999.999
        /// </summary>
        public string IP
        {
            get; set;
        }

    }
}
