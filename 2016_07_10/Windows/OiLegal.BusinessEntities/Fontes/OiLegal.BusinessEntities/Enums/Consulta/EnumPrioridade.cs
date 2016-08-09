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
    public enum EnumPrioridade
    {
        [Description("Normal")]
        Normal = 1,
        [Description("Urgente")]
        Urgente = 2
    }

    #endregion

}
