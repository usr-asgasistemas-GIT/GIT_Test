using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa
{
    [Serializable]
    [XmlRoot]
    public enum EnumDirecao
    {
        [Description("Ambas")]
        Ambas = 0,
        [Description("Originadas")]
        Originadas = 1,
        [Description("Recebidas")]
        Recebidas = 2
    }
}
