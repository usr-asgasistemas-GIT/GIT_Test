using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{

    /// <summary>
    /// Tipos de tecnologia que podem ser recebidas nos arquivos de CDR.
    /// </summary>
    public enum EnumJecProconTerminalDestino
    {
        [Description("Número completo")]
        Completo = 1,
        [DescriptionAttribute("Apenas Prefixo")]
        Prefixo = 2,
    }

}