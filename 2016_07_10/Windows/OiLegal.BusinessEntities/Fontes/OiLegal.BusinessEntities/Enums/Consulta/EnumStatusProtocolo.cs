#region Using

using System;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{
    [Serializable]
    [XmlRoot]
    public enum EnumStatusProtocolo
    {
        [Description("Novo")]
        Novo = 0,
        [Description("Concluido")]
        Concluido = 1,
        [Description("Em Andamento")]
        EmAndamento = 2
    }
}