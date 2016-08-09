using System;
using System.Collections.Generic;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    public class ListaDadosAssinantes
    {
        public List<AssinanteFixa> LstFixa { get; set; }
        public List<AssinanteMovel> LstMovel { get; set; }
        /// <summary>
        /// Utilização na Amazonia.
        /// </summary>
        public List<Assinante> LstGeral { get; set; }

        public ListaDadosAssinantes()
        {
            LstFixa = new List<AssinanteFixa>();
            LstMovel = new List<AssinanteMovel>();
        }
    }
}