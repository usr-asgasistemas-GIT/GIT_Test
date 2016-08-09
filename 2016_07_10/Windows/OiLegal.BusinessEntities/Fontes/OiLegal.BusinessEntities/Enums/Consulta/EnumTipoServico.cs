using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Consulta
{    
    #region Enumerador

    [Serializable]    
    public enum EnumTipoServico
    {
        [Description("TODOS")]
        Todos = 0,
        [DescriptionAttribute("VOZ")]
        Voz = 1,
        [DescriptionAttribute("SMS")]
        SMS = 2,
        [DescriptionAttribute("MMS")]
        MMS = 3
    }

    #endregion
}
