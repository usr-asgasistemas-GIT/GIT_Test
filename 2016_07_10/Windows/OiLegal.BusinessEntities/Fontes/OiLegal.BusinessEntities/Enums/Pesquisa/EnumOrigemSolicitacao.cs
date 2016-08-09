using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa
{
    public enum EnumOrigemSolicitacao
    {
        [Description("Normal")]
        Normal = 0,
        [DescriptionAttribute("SITTEL")]
        Sittel = 1
    }
}
