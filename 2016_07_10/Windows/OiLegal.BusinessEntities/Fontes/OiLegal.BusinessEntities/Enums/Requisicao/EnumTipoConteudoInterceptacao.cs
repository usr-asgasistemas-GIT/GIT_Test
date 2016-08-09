using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao
{
        #region Enumerador

        [Serializable]
        public enum EnumTipoConteudoInterceptacao
        {
            [DescriptionAttribute("Voz Fixa")]
            VozFixa = 1,
            [DescriptionAttribute("Voz Móvel")]
            VozMovel = 2,
            [DescriptionAttribute("Telemática Fixa")]
            TelematicaFixa = 3,
            [DescriptionAttribute("Telemática Móvel")]
            TelematicaMovel = 4,
            [DescriptionAttribute("E-mail")]
            Email = 5
            
        }

        #endregion

    
}
