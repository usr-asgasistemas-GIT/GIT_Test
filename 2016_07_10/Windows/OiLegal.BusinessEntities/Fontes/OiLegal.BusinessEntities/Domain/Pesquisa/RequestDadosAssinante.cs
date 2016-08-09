using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    [XmlRoot]
    public class RequestDadosAssinantes
    {
        
        /// <summary>
        /// Key, composta por NumeroParametro-NumeroPesquisa-IdConsulta
        /// </summary>
        /// 
        [XmlIgnore]
        public Dictionary<string, List<ParametroAssinante>> DicMovel { get; set; }
        [XmlIgnore]
        public Dictionary<string, List<ParametroAssinante>> DicFixa { get; set; }
        
        public RequestDadosAssinantes()
        {
            DicMovel = new Dictionary<string, List<ParametroAssinante>>();
            DicFixa = new Dictionary<string, List<ParametroAssinante>>();
        }
    }
}