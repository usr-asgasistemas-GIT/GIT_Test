using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums
{

    /// <summary>
    /// Tipos de tecnologia que podem ser recebidas nos arquivos de CDR.
    /// </summary>
    public enum EnumJecProconTipoRelatorio
    {
        [Description("Draft - Sem identificação da Empresa")]
        Draft = 1,
        [DescriptionAttribute("Relatório Oficial")]
        Oficial = 2,
    }

}