#region Using

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{

    #region Enumerador

    [Serializable]
    [XmlRoot]
    public enum EnumTipoResultado
    {
        [Description("PDF")]
        Pdf = 1,
        [DescriptionAttribute("Excel")]
        Excel = 2,
        [DescriptionAttribute("CSV")]
        Csv = 3,
        [DescriptionAttribute("Word")]
        Word = 4,
        [DescriptionAttribute("CPMI")]
        Cpmi = 5,
        [Description("Sittel")]
        Sittel = 6,
        [DescriptionAttribute("Manual (Excel)")]
        ManualExcel = 7    
    }

    #endregion

}
