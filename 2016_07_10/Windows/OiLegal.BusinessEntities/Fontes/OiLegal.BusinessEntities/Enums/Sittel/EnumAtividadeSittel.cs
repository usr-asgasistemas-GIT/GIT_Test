using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
    public enum EnumAtividadeSittel : int
    {
        [Description("Rejeitado")]
        Rejeitado = 0,
        [DescriptionAttribute("Protocolado")]
        Protocolado = 1,
        [DescriptionAttribute("Pesquisado")]
        Pesquisado = 2,
        [DescriptionAttribute("Respondido")]
        Respondido = 3,
        [DescriptionAttribute("Requisicao Baixada")]
        RequisicaoBaixada = 4,
        [DescriptionAttribute("Protocolo Baixado")]
        ProtocoloBaixado = 5,
        [DescriptionAttribute("Protocolo sem Anexo")]
        ProtocoloSemAnexo = 6,
    }
}