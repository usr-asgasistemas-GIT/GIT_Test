using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Requisicao
{
    #region Enumerador

    [Serializable]
    public enum EnumTipoBaixa
    {
        [DescriptionAttribute("Sem Baixa")]
        SemBaixa = 0,
        [DescriptionAttribute("Baixa Intermediária")]
        BaixaIntermediaria = 1,
        [DescriptionAttribute("Baixa Manual")]
        BaixaManual = 2,
        [DescriptionAttribute("Baixa Automática")]
        BaixaAutomatica = 3,
    }

    #endregion
}
