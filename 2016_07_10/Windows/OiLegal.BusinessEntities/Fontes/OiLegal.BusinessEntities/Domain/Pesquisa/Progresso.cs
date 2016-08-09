using System;
using System.Xml.Serialization;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa
{
    [Serializable]
    [XmlRoot]
    public class Progresso
    {
        [XmlElement(ElementName = "DataHora", IsNullable = true)] 
        public DateTime? DataHora { get; set; }

        [XmlElement("IdConsulta")]
        public int IdConsulta { get; set; }

        [XmlElement("NumeroPesquisa")]
        public int NumeroPesquisa { get; set; }

        [XmlElement("NumeroParametro")]
        public int NumeroParametro { get; set; }

        [XmlElement("Passo")]
        public string Passo { get; set; }

        [XmlElement("Porcentagem")]
        public short Porcentagem { get; set; }
    }
}
