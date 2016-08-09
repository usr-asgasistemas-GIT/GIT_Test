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
    public enum EnumTipoAtendimento
    {
        [Description("Completa")]
        Completa = 0 ,
        [Description("Parcial")]
        Parcial = 1
    }
}
