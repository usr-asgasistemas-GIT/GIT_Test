using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.ProcessadorCDR
{
    /// <summary>
    /// Enumerador que define o tipo da linha (Header/trailer/Footer)
    /// </summary>
    public enum EnumTipoLinhaCDR
    {
        [DescriptionAttribute("Header")]
        Header = 1,
        [Description("Trailer")]
        Trailer = 2,
        [DescriptionAttribute("Footer")]
        Footer = 3
    }
}
