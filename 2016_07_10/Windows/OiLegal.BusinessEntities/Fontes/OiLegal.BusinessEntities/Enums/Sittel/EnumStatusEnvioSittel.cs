using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
    [Serializable]
    public enum EnumStatusEnvioSittel : int
    {
        [Description("Não Enviada")]
        NaoEnviada = 0,
        [DescriptionAttribute("Enviado")]
        Enviado = 1,
        [DescriptionAttribute("Enviando")]
        Enviando = 2,
        [DescriptionAttribute("Erro")]
        Erro = 3
    }
}
