using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
    [Serializable]
    [XmlRoot]
    public enum EnumTipoResultadoSittel
    {
        [Description("SITTEL")]
        Sittel = 1,
        [DescriptionAttribute("Manual (Excel)")]
        Excel = 2        
    }
}
