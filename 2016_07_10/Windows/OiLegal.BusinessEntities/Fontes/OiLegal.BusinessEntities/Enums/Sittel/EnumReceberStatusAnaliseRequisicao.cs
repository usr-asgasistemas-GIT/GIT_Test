using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Sittel
{
    public enum EnumReceberStatusAnaliseRequisicao : int
    {
        [DescriptionAttribute("Recebido")]
        Recibido = 1,
        [DescriptionAttribute("Transmissao Parcial")]
        TransmissaoParcial = 2,
        [DescriptionAttribute("Concluido")]
        Concluido = 3
    }
}
